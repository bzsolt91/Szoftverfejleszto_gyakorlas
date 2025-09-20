
    <?php
    session_start();
    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "oktav";
    $conn = new mysqli($servername,$username,$password,$dbname);

    if($conn->connect_error){
        die("Kapcsolódási hiba" . $conn->connection_error);
    }
if($_SERVER["REQUEST_METHOD"] == "POST")
{
    $nev = $_POST['felhasznalo'];
    $jelszo = $_POST['jelszo'];

    $stmt = $conn->prepare("SELECT valodi_nev FROM ugyintezok WHERE nev = ? and jelszo = ?");
    $stmt->bind_param("ss",$nev,$jelszo);
    $stmt->execute();
    $result = $stmt->get_result();

    $sor = $result->fetch_assoc();

    if($result->num_rows > 0)
    {
        
        
        $_SESSION['valodi_nev'] = $sor['valodi_nev'];
        $_SESSION['nev'] = $nev;
        header("Location: fooldal.php"); //átirányítás belépés után
       
    }
    else
    {
    header("Location: hibas_belepes.php"); //átirányítás belépés után
    }
}
    /*
    echo $_POST["felhasznalo"]. "<br>";
    echo $_POST["jelszo"]. "<br>";
*/
    ?>
