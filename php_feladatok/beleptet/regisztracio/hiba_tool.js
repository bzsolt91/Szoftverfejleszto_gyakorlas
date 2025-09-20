function beleir()
{
    var tartalomdoboz = document.getElementById("tartalom");
    tartalomdoboz.innerHTML += "szia";
}
function hiba(hibaszoveg)
{
    var tartalomdoboz = document.getElementById("hiba_ablak");
    tartalomdoboz.innerHTML= hibaszoveg +"<br>"+"<button id=\"hiba_gomb\" onclick=\"bezar()\">Bezár</button>";

    document.getElementById("hiba_ablak").style.display = "block";
}
function bezar()
{
    var tartalomdoboz = document.getElementById("hiba_ablak");
    
    document.getElementById("hiba_ablak").style.display = "none";  
}