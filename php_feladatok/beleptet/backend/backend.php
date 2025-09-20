<?php

// Dinamikus WHERE feltételek
$where = [];
$params = [];
$types = "";

if (!empty($nev)) {
    $where[] = "nev LIKE ?";
    $params[] = $nev . "%";
    $types .= "s";
}

if (!empty($szulEv)) {
    $where[] = "szulEv > ?";
    $params[] = intval($szulEv);
    $types .= "i";
}

if (!empty($halEv)) {
    $where[] = "halEv < ?";
    $params[] = intval($halEv);
    $types .= "i";
}

$sql = "SELECT * FROM szerzok";
if (!empty($where)) {
    $sql .= " WHERE " . implode(" AND ", $where);
}

$stmt = $conn->prepare($sql);

?>