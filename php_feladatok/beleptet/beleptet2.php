<?php

$valid_user = "admin";
$valid_pass = "1234";

if ($_SERVER['REQUEST_METHOD'] == "POST") {
    
    if (isset($_POST["username"]) && isset($_POST["password"])) {
       
        if ($_POST["username"] == $valid_user && $_POST["password"] == $valid_pass) {
          echo "<hr>ok sikerült belépni<hr>";
          
        } else {
            echo "<b>Ezt elirtad</b>";
        
        }
    }
}
?>