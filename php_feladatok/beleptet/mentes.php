<?php
 session_start();
 if (!isset($_SESSION["nev"]))
 header("Location: index.php");
 ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $eredeti= $_POST["eredeti_nev"];
    $nev =  $_POST["felhasznalo"];
    $valodi_nev = $_POST["valodi_nev"];
    $jelszo= $_POST["jelszo"];
    $aktiv= isset($_POST["aktiv"])?"i":"n";
  //  érték = feltétel ?igaz_érték : hamis_érték

    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "oktav";
    $conn = new mysqli($servername,$username,$password,$dbname);

    if($conn->connect_error)
    {
        die("Kapcsolódási hiba" . $conn->connection_error);
    }

   // $eredeti = $_GET['eredeti_nev'];
    

    $stmt = $conn->prepare("update ugyintezok set nev = ?, valodi_nev = ?,jelszo = ?,aktiv = ? where nev = ?");
    $stmt->bind_param("sssss",$nev,$valodi_nev,$jelszo,$aktiv,$eredeti);
    //ss string
    //i integer
    //d double
    //b blob
    $stmt->execute();
  $stmt->close();
  $conn->close();
  header("Location: fooldal.php")
    ?>
</body>
</html>