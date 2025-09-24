<?php
// Helyes fejléc: Access és UTF-8 karakterkódolás javítása
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

// Adatbázis kapcsolat beállítása
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "oktav";

// Kapcsolat létrehozása
$conn = new mysqli($servername, $username, $password, $dbname);

// Karakterkódolás beállítása
$conn->set_charset("utf8");

// Kapcsolat ellenőrzése
if ($conn->connect_error) {
    http_response_code(500);
    echo json_encode(["error" => "Adatbázis kapcsolat sikertelen: " . $conn->connect_error]);
    exit;
}

if (isset($_GET['nev'])) {
    // Helyes értéklekérés: az előző verzió csak logikai értéket tárolt
    $nev = $_GET['nev'];
    $stmt = $conn->prepare("SELECT * FROM szerzok WHERE nev LIKE CONCAT(?, '%')");
    $stmt->bind_param("s", $nev);
    $stmt->execute();
    $result = $stmt->get_result();
} else {
    $result = $conn->query("SELECT * FROM szerzok");
}

// Eredmények beolvasása
$szerzok = [];
if ($result) {
    while ($row = $result->fetch_assoc()) {
        $szerzok[] = $row;
    }
}

// JSON visszaadása
echo json_encode($szerzok);

// Kapcsolat lezárása
$conn->close();
?>
