<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
   
    <style>
        body {
            background-color: lightblue;
        }

        h1 {
            color: darkblue;
            text-align: center;
        }
    </style>
</head>



<?php
// Adatbázis kapcsolódás
$servername = "localhost";
$username = "root"; // vagy a saját adatbázis felhasználód
$password = "";     // jelszó, ha van
$dbname = "webshop";

// Kapcsolat létrehozása
$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Kapcsolódási hiba: " . $conn->connect_error);
}



$email = $_POST['email'];
$nickname = $_POST['nickname'];
$password = $_POST['password'];

$gender = $_POST['gender'] ;
$birthDate = $_POST['birthDate'];
$birthPlace = $_POST['birthPlace'];
$aktiv = 'n'; // Alapértelmezett, hogy nem aktív

// Validáció (két szinten: űrlapban is, de itt is fontos!)
$errors = [];

if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    $errors[] = "Érvénytelen email cím!";
}



if (empty($nickname) || empty($password) || empty($birthDate) || empty($birthPlace) || empty($gender)) {
    $errors[] = "Minden mezőt ki kell tölteni!";
}

if (!empty($errors)) {
    foreach ($errors as $error) {
        echo "<p style='color:red;'>$error</p>";
    }
    exit;
}



// Előkészített lekérdezés
$stmt = $conn->prepare("INSERT INTO felhasznalok 
(email, nicknev, jelszo, nem, szul_ido, szul_hely, aktiv,torolve)
VALUES (?, ?, md5(?), ?, ?, ?, r,NULL)");

$stmt->bind_param("sssssss", 
    $email,
    $nickname,
    $password,
    $gender,
    $birthDate,
    $birthPlace,
    $aktiv
);
$stmt->execute();



// az email validálása
$stmt = $conn->prepare("insert into validalas VALUES (?, date_add(now(), interval 1 day), ?, null);");
$stmt->bind_param("ss", $email, $password);

$stmt->execute();
// Végrehajtás
/*if ($stmt->execute()) {
    echo "<h1 style='color:green;'>Sikeresen regisztrtrált: ".$nickname . "!</p>";
} else {
    echo "<p style='color:red;'>Hiba történt: " . $stmt->error . "</p>";
}*/
/*
$leveltorzs= "Szia aktivációs email";
$leveltorzs.="Az laábbi linkre kattintva erősítheti meg az regisztrációját.";
$leveltorzs .="<a href=\"http://nagyokosvagyok.hu/17_alaklaom/validalas.php?kod=........";
mail($email,"Validálás",$leveltorzs);
*/

echo "<a $href=\"http://127.168.1.0/orai/regisztracio/validalas.php?kod=\" .\"$kod\">Validáláshoz kattintson ide:</a>";
// Lezárások
$stmt->close();
$conn->close();
?>
<body>
    
</body>
</html>