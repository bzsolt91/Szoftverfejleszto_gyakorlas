<?php

// Adatbázis kapcsolódás
$servername = "localhost";
$username = "root"; // vagy a saját adatbázis felhasználód
$password = "";     // jelszó, ha van
$dbname = "webshop";

$email = $_GET["email"];
$kod = $_GET["kod"];


$conn = new mysqli($servername,$username,$password,$dbname);

if($conn->connect_error)
{
    die("Kapcsolódási hiba" . $conn->connection_error);
}




$stmt = $conn->prepare("SELECT count(*) as darab FROM validalas WHERE  email = ? and kod = ? and hatarido >= now()");
$stmt->bind_param("ss",$email,$kod);
$stmt->execute();
$result = $stmt->get_result();

$sor = $result->fetch_assoc();


  if ($sor["darab"] == 1)

  {        // update validalas SET vegleges = now() WHERE email = 'kala@pal4.hu';

      $stmt = $conn->prepare("update validalas SET vegleges = now() WHERE email = ?");

      $stmt->bind_param("s", $email);

      $stmt->execute();

      $stmt = $conn->prepare("update felhasznalok SET aktiv = 1 WHERE email = ?");

      $stmt->bind_param("s", $email);

      $stmt->execute();

      header("Location: belepes.php");

  }

  else

  {
    //törlöm a lejárt nem validált regisztrációt
 header("Location: hiba_oldal.php");
  }

$stmt->close();
$conn->close();


?>