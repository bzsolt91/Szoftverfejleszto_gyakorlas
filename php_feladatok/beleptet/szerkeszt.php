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
  
    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "oktav";
    $conn = new mysqli($servername,$username,$password,$dbname);

    if($conn->connect_error)
    {
        die("Kapcsolódási hiba" . $conn->connection_error);
    }

    $nev = $_GET['nev'];
    

    $stmt = $conn->prepare("SELECT nev,valodi_nev,jelszo,aktiv FROM ugyintezok WHERE nev = ?");
    $stmt->bind_param("s",$nev);
    $stmt->execute();
    $result = $stmt->get_result();

    $sor = $result->fetch_assoc();

  $stmt->close();
  $conn->close();

?>
<form id="frm_ugyintezo" name="frm_ugyintezo" action="mentes.php" method="post">
<label for="felhasznalo">Felhasználónév</label>
<input type="hidden" name="eredeti_nev" id="eredeti_nev" value="<?php echo $sor['nev']?>">
<input type="text" id="felhasznalo" name="felhasznalo" required value="<?php echo $sor['nev']?>">
<br></br>
<label for="valodi_nev">Valódi név</label>
<input type="text" id="valodi_nev" name="valodi_nev" value="<?php echo $sor['valodi_nev']?>"required>
<br></br>
<label for="jelszo">Jelszó</label>
<input type="password" id="jelszo" name="jelszo" value="<?php echo $sor['jelszo']?>" required>
<br></br>
<label for="aktiv">Aktív</label>
<input type="checkbox" id="aktiv" name="aktiv" <?php if($sor['aktiv'] =="1") echo "checked"?> >
<br></br>
<button type="submit">Mentés</button>
</form>
<script>
        document.getElementById("frm_ugyintezo").addEventListener("submit",function(event){
        event.preventDefault();
         nev_mezo = document.getElementById("felhasznalo").value;
         jelszo_mezo = document.getElementById("jelszo").value;
         valodi_nev = document.getElementById("valodi_nev").value;
        let isValid = true;
        
        if(nev_mezo.length >= 20)
    {
        isValid = false;
    }
        if(valodi_nev.length < 6)
    {
        isValid = false;
    }
    jelszo_pin = parseInt(jelszo_mezo);
    if (isNaN(jelszo_pin) || jelszo_pin < 1000 || jelszo_pin > 100999)
{
    isValid =  false;
}
if(isValid)
{
    alert("Űralpot jó");
    this.submit();
}
else
    {
        alert("az űrlapot nem lehet elküldeni");
    }
});
    </script>
</body>
</html>