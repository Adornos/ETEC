document.write("<div id='resultado'></div>")

colega = ["joão", "Tim Maia", "Caio", "Adorno", "Henri"];

document.getElementById("resultado").innerHTML += "<div class='aluno'> Último elemento: " + colega[4] + "</div><br>";
for (let i = 0; i < colega.length; i++) {
    document.getElementById("resultado").innerHTML += "<div class='aluno'>" + i + "º elemento: " + colega[i] + "</div><br>";
    
}