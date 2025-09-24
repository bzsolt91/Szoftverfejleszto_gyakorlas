<?php
// API URL meghatározása
$apiUrl = "http://127.0.0.1/api/szerzok.php";

// Ha van 'nev' paraméter az URL-ben, hozzáfűzzük a lekéréshez
if (isset($_GET['nev'])) {
    $nev = urlencode($_GET['nev']);
    $apiUrl .= "?nev=$nev";
}

// API kérés végrehajtása
$response = file_get_contents($apiUrl);

// Ellenőrzés, hogy sikeres volt-e a válasz
if ($response === FALSE) {
    die("Hiba történt az API lekérdezése közben.");
}

// JSON válasz dekódolása tömbbé
$szerzok = json_decode($response, true);
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <title>Szerzők listája</title>
</head>
<body>
    <h1>Szerzők</h1>
    <form method="get">
        <label for="nev">Keresés név szerint:</label>
        <input type="text" id="nev" name="nev" value="<?= htmlspecialchars($_GET['nev'] ?? '') ?>">
        <button type="submit">Keresés</button>
    </form>

    <ul>
        <?php
        echo "Első megoldás kiíratásra:";
        echo "<p>";
        //egyik fajta megoldás kiratás
        if (!empty($szerzok)): ?>
            <?php foreach ($szerzok as $szerzo): ?>
                <li><?= htmlspecialchars($szerzo['nev']) ?></li>
            <?php endforeach; ?>
        <?php else: ?>
            <li>Nincs találat.</li>
        <?php endif; ?>
    </ul>

    
    <?php
    //ez a másik fajta keresés
    echo "Olvashatóbb megoldás:";
      echo "<p>";
    if(empty($szerzok))
            echo "Nincs Találat!";
        else
        {
            echo "<ul>";
            foreach($szerzok as $szerzo)
            {
                echo "<li>";
                echo htmlspecialchars($szerzo['nev']);
                echo "</li>";
            }
            echo "</ul>";
        }

    ?>
    </body>
</html>
