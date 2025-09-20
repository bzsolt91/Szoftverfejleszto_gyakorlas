<?php
session_start();
session_destroy()
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <script>
        function ellenoriz()
        {
            
            var felhasznalonev = document.getElementById("felhasznalo");
            var jelszo = document.getElementById("jelszo");
            if(felhasznalonev.value === "" || jelszo.value === "")
                    alert("Minden mezőt ki kell tölteni");
        else
            belegy = document.getElementById("belegyezes");
            if(belegy.checked)
        {
                document.getElementById("belepteto").submit();
        }
        else
            alert("Fogadd el a feltételeket");
        }
    </script>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form id="belepteto" action="beleptet.php" method="post">
        <label for="felhasznalo">Felhasználónév:</label>
        <input type="text" id="felhasznalo" name="felhasznalo" required>
        <br><br>
        <label for="jelszo">Jelszó:</label>
        <input type="password" id="jelszo" name="jelszo" required>
        <br><br>
        <label for="belegyezes">Elfogadom a feltételeket</label> <input type="checkbox" id="belegyezes" name="belegyezes">
        <button type="button" onclick="ellenoriz()">Belépés</button>
    </form> 
</body>
</html>