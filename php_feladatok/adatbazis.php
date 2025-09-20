<?php
header('Content-Type: application/json');

// Adatbázis kapcsolat beállítása
$servername = "localhost";
$username   = "root";
$password   = "";
$dbname     = "futoverseny"; // állítsd be a tényleges nevét

// Kapcsolat létrehozása
$conn = new mysqli($servername, $username, $password, $dbname);
$conn->set_charset("utf8mb4");

if ($conn->connect_error) {
    die(json_encode(["error" => "Kapcsolódási hiba"]));
}

// Bemeneti paraméterek
$nev = $_GET['nev'] ?? '';
$rajtszam = $_GET['rajtszam'] ?? '';

// SQL előkészítése
$sql = "SELECT versenyzo_neve, versenyzo_rajtszama, versenyzo_helyezese 
        FROM versenyzok 
        WHERE versenyzo_neve LIKE ? OR versenyzo_rajtszama = ?";
$stmt = $conn->prepare($sql);

// Paraméterek előkészítése
$nev .= "%";  // LIKE kereséshez
$stmt->bind_param("si", $nev, $rajtszam);

// Lekérdezés futtatása
$stmt->execute();
$result = $stmt->get_result();

// Eredmények összegyűjtése
$adatok = [];
while ($row = $result->fetch_assoc()) {
    $adatok[] = $row;
}

// JSON válasz visszaadása
echo json_encode($adatok);

// Erőforrások felszabadítása
$stmt->close();
$conn->close();
?>