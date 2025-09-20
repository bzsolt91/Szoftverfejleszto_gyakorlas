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
    <h1>Felhasználók</h1>

    <table border="1">
    <tr><td>Login </td><td>Valodi nev</td><td>Jelszó</td></tr>

    <?php
     $servername = "localhost";
     $username = "root";
     $password = "";
     $dbname = "oktav";
     $conn = new mysqli($servername,$username,$password,$dbname);
if ($conn->connect_error) {
    die("Kapcsolódási hiba: " . $conn->connect_error);
}


    $stmt = $conn->prepare("SELECT nev, valodi_nev, jelszo FROM ugyintezok");
    $stmt->execute();
    $result = $stmt->get_result();

    while ($row = $result->fetch_assoc()) {
        echo "<tr>";
        foreach ($row as $key => $value) {

            if($key == "nev")
            {
                echo "<td><a href=\"szerkeszt.php?nev=" . $value . "\">" . $value . "<a/></td>"; 
            }
           else
        echo "<td>" . $value . "</td>";
        }
        
        echo "</tr>";
    }
    
    $stmt->close();


$conn->close();


?>

    
 

    </table>
    <?php
   
    //echo "Hello " . $_SESSION["valodi_nev"] . "!";
    ?>
</body>
</html>