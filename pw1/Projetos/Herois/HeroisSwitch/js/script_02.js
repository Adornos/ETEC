
univ = window.prompt("Digite um universo (Marvel) (DC): ").toLowerCase();

switch (univ) {
    case "dc":
        heroi = window.prompt("Digite o nome de um heroi:  ");
        hero = heroi.toLowerCase().replace(/\s+/g, '');
        switch (hero) {
            case "batman":
            case "superman":
                let n = window.prompt("Digite a quantidade de aparições:  ");
                let i = 0;
                while (i < n) {
                    document.getElementById("herois").innerHTML += "<div class='dialogo'>O heroi é: " + heroi + " <div class='balao'> <div class = '" + hero + " image'> </div></div></div>";
                    i++;
                }
        break;
        default:
                document.getElementById("herois").innerHTML += "<div class='dialogo'>O heroi não existe nesse universo</div>";
        }
    break;

    case "marvel":
        heroi = window.prompt("Digite o nome de um heroi:  ");
        hero = heroi.toLowerCase().replace(/\s+/g, '');
        switch (hero) {
            case "spiderman":
            case "deadpool":
                let n = window.prompt("Digite a quantidade de aparições:  ");
                let i = 0;
                while (i < n) {
                    document.getElementById("herois").innerHTML += "<div class='dialogo'>O heroi é: " + heroi + " <div class='balao'> <div class = '" + hero + " image'> </div></div></div>";
                    i++;
                }
            break;
            default:
                document.getElementById("herois").innerHTML += "<div class='dialogo'>O heroi não existe nesse universo</div>";
        }
    break;

    default:
        document.getElementById("herois").innerHTML += "<div class='dialogo'>Esse universo não existe</div>";
}