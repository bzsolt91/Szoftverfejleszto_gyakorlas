<?php
header('Content-Type: application/json; charset=utf-8');

// --- Adatbázis kapcsolat ---
$server = 'localhost';
$adatbazis = 'adatbazis_nevnapok'; 
$felhasznalo = 'root';
$jelszo = '';

$kapcsolat = new mysqli($server, $felhasznalo, $jelszo, $adatbazis);
if ($kapcsolat->connect_error) {
    echo json_encode(['hiba' => 'Kapcsolódási hiba az adatbázishoz.']);
    exit;
}
$kapcsolat->set_charset('utf8mb4');

// --- Segédfüggvény: hónapszám -> magyar hónapnév ---
function honapNev($h) {
    $t = [
        1 => 'január', 2 => 'február', 3 => 'március', 4 => 'április', 5 => 'május', 6 => 'június',
        7 => 'július', 8 => 'augusztus', 9 => 'szeptember', 10 => 'október', 11 => 'november', 12 => 'december'
    ];
    return $t[(int)$h] ?? '';
}

// --- Lekérdezések ---

if (isset($_GET['nap'])) {
    // Várt forma: "4-30" vagy "04-30"
    $nap_parameter = $_GET['nap'];
    $parameterlista = explode('-', $nap_parameter);

    // Ellenőrzés
    if (count($parameterlista) != 2) {
        echo json_encode(['hiba' => 'Hibás nap paraméter (pl. 4-30 formátum szükséges).']);
        exit;
    }

    $honap = (int)$parameterlista[0];
    $nap = (int)$parameterlista[1];

    $sql = "SELECT nev1, nev2 FROM nevnap WHERE ho = ? AND nap = ? LIMIT 1";
    $stmt = $kapcsolat->prepare($sql);
    $stmt->bind_param("ii", $honap, $nap);
    $stmt->execute();
    $eredmeny = $stmt->get_result();

    if ($sor = $eredmeny->fetch_assoc()) {
        echo json_encode([
            'honap' => honapNev($honap),
            'nap' => $nap,
            'nev1' => $sor['nev1'],
            'nev2' => $sor['nev2']
        ], JSON_UNESCAPED_UNICODE);
    } else {
        echo json_encode(['hiba' => 'Nincs találat.']);
    }

} elseif (isset($_GET['nev'])) {
    $nev = trim($_GET['nev']);
    $sql = "SELECT ho, nap FROM nevnap WHERE nev1 LIKE ? OR nev2 LIKE ? LIMIT 1";
    $stmt = $kapcsolat->prepare($sql);
    $likeNev = $nev . "%";
    $stmt->bind_param("ss", $likeNev, $likeNev);
    $stmt->execute();
    $eredmeny = $stmt->get_result();

    if ($sor = $eredmeny->fetch_assoc()) {
        echo json_encode([
            'nev' => $nev,
            'honap' => honapNev($sor['ho']),
            'nap' => $sor['nap']
        ], JSON_UNESCAPED_UNICODE);
    } else {
        echo json_encode(['hiba' => 'Nincs ilyen névnap.']);
    }

} else {
    // Ha nincs paraméter
    echo json_encode([
        'minta1' => '?nap=12-31',
        'minta2' => '?nev=Szilveszter'
    ], JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);
}

$kapcsolat->close();
