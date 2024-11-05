universos = ["dc", "marvel"];

herois = [
    ["batman", "superman"],
    ["spiderman", "deadpool"]
];

inUniverso = window.prompt("Digite o universo (Marvel) (DC)").toLowerCase().replace(/\s+/g, '');

if(universos.includes(inUniverso)){

    indexUniverso = universos.indexOf(inUniverso);

    inHeroi = window.prompt("Digite o nome de um heroi:  ");
    indentHeroi = inHeroi.toLowerCase().replace(/\s+/g, '');

    if(herois[indexUniverso].includes(indentHeroi)){

        heroiLoop = parseInt(window.prompt("Digite a quantidade de vezes que deseja que o heroi apareça: "));
        for (let i = 0; i < heroiLoop; i++) {
            document.getElementById("herois").innerHTML += "<div class='dialogo'>O heroi é: " + indentHeroi + " <div class='balao'> <div class = '" + indentHeroi + " image'> </div></div></div>";
        }
    }

    else{
        document.getElementById("herois").innerHTML = ("<div class='dialogo'>O heroi não existe nesse universo</div>");
    }
}

else{
    document.getElementById("herois").innerHTML = ("<div class='dialogo'>Esse universo não está incluido nesse banco</div>");
}


        


