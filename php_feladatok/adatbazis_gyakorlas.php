<?php
$adatbazis = "futoverseny";
$jelszo = "";
$felhasznalonev = "root";
$kapcsolat = new mysqli("localhost", $felhasznalonev, $jelszo, $adatbazis);
if ($kapcsolat->connect_error) {
    die("Kapcsolódási hiba: " . $kapcsolat->connect_error);
}
$kapcsolat->set_charset("utf8");
$sqlkapcsolat = $kapcsolat->prepare("SELECT * FROM versenyzok");
$sqlkapcsolat->execute();
$eredmeny = $sqlkapcsolat->get_result();
echo "<h1>Futóverseny eredmények</h1>";
echo "<h2>Versenyzők listája</h2>";
echo "<table border='1'><tr><th>ID</th><th>Név</th><th>Helyezés</th></tr>";

if ($eredmeny->num_rows > 0) {
    while ($sor = $eredmeny->fetch_assoc()) {
          echo "<tr>";
        echo "<td>" . $sor["id"] . "</td>";
        echo "<td>" . $sor["versenyzo_neve"] . "</td>";
        echo "<td>" . $sor["versenyzo_helyezese"] . "</td>";
        echo "</tr>";
    }
} else {
    echo "Nincs eredmény";
}
echo "</table>";
$kapcsolat->close();
echo "Sikeres kapcsolódás az adatbázishoz.";
?>