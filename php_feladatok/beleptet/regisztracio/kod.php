<?php

function kod_generalas()
{
    $kod = '';
for ($i = 0; $i < 16; $i++) {
    $szam = rand(1, 3); // Háromféle karaktertípus: nagybetű, szám, speciális

    if ($szam == 1) {
        // Nagybetű
        $kod .= chr(rand(65, 90));
    } elseif ($szam == 2) {
        // Szám
        $kod .= chr(rand(48, 57));
    } else {
        // Speciális karakterek
        $jelek = '!@#$%^&*';
        $kod .= $jelek[rand(0, strlen($jelek) - 1)];
    }
}
return $kod;
}
?>