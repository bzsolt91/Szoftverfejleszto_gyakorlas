<?php
$nev = isset($_GET['nev']) ? $_GET['nev'] : "";

// Az API meghívása (csak ha van adat, különben mindenkit listáz)
$apiUrl = "http://localhost/test/nev_api.php?nev=" . urlencode($nev);
$json = file_get_contents($apiUrl);
$talalatok = [];

if ($json !== false) {
    $valasz = json_decode($json, true);
    if (is_array($valasz)) {
        $talalatok = $valasz;  // <-- nincs SQL, itt már kész adat jön az API-ból
    }
}
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <title>Futóverseny kereső</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 20px; }
        table { border-collapse: collapse; width: 100%; margin-top: 20px; }
        th, td { border: 1px solid #ccc; padding: 8px; text-align: left; }
        th { background-color: #f2f2f2; }
        .ures { color: #888; font-style: italic; }
    </style>
</head>
<body>

<h1>Futóverseny kereső</h1>

<form method="get">
    <label for="nev">Név: </label>
    <input type="text" name="nev" id="nev" value="<?php echo htmlspecialchars($nev); ?>">
    <button type="submit">Keresés</button>
</form>

<?php if ($nev !== ""): ?>
    <h2>Keresés eredménye: "<?php echo htmlspecialchars($nev); ?>"</h2>

    <?php if (count($talalatok) > 0): ?>
        <table>
            <tr><th>Verseny ID</th><th>Versenyző neve</th><th>Helyezés</th></tr>
            <?php foreach ($talalatok as $sor): ?>
                <tr>
                    <td><?php echo htmlspecialchars($sor["verseny_id"]); ?></td>
                    <td><?php echo htmlspecialchars($sor["versenyzo_neve"]); ?></td>
                    <td><?php echo htmlspecialchars($sor["versenyzo_helyezese"]); ?></td>
                </tr>
            <?php endforeach; ?>
        </table>
    <?php else: ?>
        <p class="ures">Nincs találat.</p>
    <?php endif; ?>
<?php endif; ?>

</body>
</html>