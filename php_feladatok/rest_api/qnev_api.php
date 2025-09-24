<?php
$adatbazis = "futoverseny";
$jelszo = "";
$felhasznalonev = "root";
$kapcsolat = new mysqli("localhost", $felhasznalonev, $jelszo, $adatbazis);
if ($kapcsolat->connect_error) {
    die("Kapcsolódási hiba: " . $kapcsolat->connect_error);
}
if (isset($_GET['nev'])) 
    // Helyes értéklekérés: az előző verzió csak logikai értéket tárolt
    $nev = $_GET['nev'];
    else
        $nev = "";
$kapcsolat->set_charset("utf8");
$param = "%" . $nev ."%";
$sqlkapcsolat = $kapcsolat->prepare("SELECT verseny_id,versenyzo_neve,versenyzo_helyezese FROM versenyzok where versenyzo_neve LIKE ?");
$sqlkapcsolat->bind_param("s", $param );
$sqlkapcsolat->execute();
$eredmeny = $sqlkapcsolat->get_result();

$talalatok=[];
while($sor = $eredmeny->fetch_assoc())
{
    $talalatok[]=$sor;
}

echo json_encode($talalatok, JSON_UNESCAPED_UNICODE);

$kapcsolat->close();

?>