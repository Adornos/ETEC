const game = document.getElementById('card-space');
const cartas = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8];
const estado = Array(20).fill(false);

function embaralhar() {
    console.log("Old Cards: " + cartas)
    for (let i = cartas.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [cartas[i], cartas[j]] = [cartas[j], cartas[i]]
    }
    console.log("New Cards: " + cartas)

    criarCartas();
}


function criarCartas(){

    const removeCard = game.innerHTML = ""

    for (let i = 1; i <= cartas.length; i++) {

        const   cardSpan = document.createElement("button");
                cardSpan.classList.add("card", "id-" + i);
                cardSpan.addEventListener('click', toggleCard)
        
        const   cardFront = document.createElement("span");
                cardFront.classList.add("card-front");
                
        const   cardBack = document.createElement("span");
                cardBack.style.backgroundImage = "url(imgs/img-" + cartas[i] + ".webp)";
                cardBack.classList.add("card-back");

        const   cardInside = document.createElement("span");
                cardInside.classList.add("card-inside")

        cardInside.appendChild(cardFront);
        cardInside.appendChild(cardBack);

        cardSpan.appendChild(cardInside);
        
        game.appendChild(cardSpan);

    }

function toggleCard(){

    const card = this.classList[2]
    const cardNumber = card.match(/\d+/);
    const cardState = estado[cardNumber]

    cardState ? revelarCarta() : esconderCarta() ;
}

function revelarCarta(){
    
    
}


}