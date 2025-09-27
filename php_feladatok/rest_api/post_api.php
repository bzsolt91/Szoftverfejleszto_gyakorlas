<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "futoverseny3"; // állítsd be a tényleges nevét

$conn = new mysqli($servername, $username, $password, $dbname);
$conn->set_charset("utf8");

if ($conn->connect_error) {
    die(json_encode(["error" => "Kapcsolódási hiba"]));
}

$nev = $_POST['nev'] ?? '';
$rajtszam = $_POST['rajtszam'] ?? 0;
//select versenyzo_neve, versenyzo_rajtszama, versenyzo_helyezese from versenyzok where versenyzo_neve like "Ta%" and versenyzo_rajtszama > 15 order by versenyzo_rajtszama desc;

$sql = "select versenyzo_neve, versenyzo_rajtszama, versenyzo_helyezese from versenyzok where versenyzo_neve like ? and versenyzo_rajtszama > ? order by versenyzo_rajtszama desc";
$stmt = $conn->prepare($sql);
$nev .= "%";
$stmt->bind_param("si", $nev, $rajtszam);


$stmt->execute();
$result = $stmt->get_result();

$adatok = [];
while ($row = $result->fetch_assoc()) {
    $adatok[] = $row;
}

header('Content-Type: application/json');
echo json_encode($adatok);

$stmt->close();
$conn->close();

?>