univ = window.prompt("Digite um universo (Marvel) (DC): ").toLowerCase();
heroi = window.prompt("Digite o nome de um heroi:  ");
hero = heroi.toLowerCase().replace(/\s+/g, '');




if ((((hero == "batman") || (hero == "superman")) && (univ == "dc")) || (((hero == "spiderman") || (hero == "deadpool")) && (univ == "marvel"))){
    
    n = window.prompt("Digite a quantidade de aparições:  ");
    i = 0;
    while (i < n) {
        document.getElementById("herois").innerHTML += "<div class='dialogo'>O heroi é: " + heroi + " <div class='balao'> <div class = '" + hero + " image'> </div></div></div>";
        i++;
    }
    
} 
else{
    document.write("<div class='dialogo'>O heroi não existe nesse universo</div>");
}


