<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Szerszámok</title>
    <style>
        table{            
            width: 600px;
            border: 1px solid #770000;
            border-collapse: collapse;
        }

        td, th {
            border: 1px solid #770000;
            padding: 3px;
            
        }
        div{
            padding: 20px;
            border: 1px solid #770000;
            margin: 10px;
        }
    </style>
    <script>
        function frissit()
        {
            const tipus = document.getElementById('nev').value;

            const xhr = new XMLHttpRequest();
            xhr.open('POST', 'backend_f.php', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');

            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                const data = JSON.parse(xhr.responseText);
                megjelenitTabla(data);
                }
            };

            const params = `nev=${encodeURIComponent(tipus)}`;
            xhr.send(params);
        }

        function megjelenitTabla(adatok)
        {
            const div = document.getElementById('eredmenyek');
            if (adatok.length === 0) {
                div.innerHTML = "<p>Nincs találat.</p>";
                return;
            }
            let tabla = "<table>";
            tabla += "<tr><th>Verseny neve</th><th>Verseny helye</th><th>Verseny ideje</th></tr>";
            
            for (const sor of adatok) {
                tabla += "<tr>";
                tabla += "<td>" + sor.verseny_neve + "</td>";
                tabla += "<td>" + sor.verseny_helye + "</td>",
                tabla += "<td>" + sor.verseny_idopontja + "</td>";
                tabla += "</tr>";
            }

            tabla += "</table>";
            div.innerHTML = tabla;
        }


    window.onload = frissit;
    </script>
</head>
<body>
<h1>Versenyek</h1>    
<div id="szuro">
  <label>Verseny: <input type="text" id="nev" placeholder="Ide írj a szűréshez!" oninput="frissit()"></label>
</div>

<div id="eredmenyek">
<!-- Itt jelenik meg a táblázat -->
</div>  

</body>
</html>