let clicagem = 0; // contador de clicks

function flipcard(card){

    const exList = ['img-1','img-2','img-9']; // exceções das imagens
    let cardType = ((exList.includes(card.className)) ? ".png" : ".webp") //vê se o card selecionado está contido na lista acima

    let cardSource = card.className + cardType; // concatena o nome da classe com o tipo de arquivo
    console.log(cardSource) // test

    if (card.style.cssText === ''){ 
        card.style.cssText = 'background: url(imgs/' + cardSource + ') no-repeat;';
        card.parentElement.style.cssText = 
        'rotate: 0 1 0 180deg;' +
        'transition: 1s ease-in-out;';
        clicagem++; // aumenta o contador de clicks
        card.dataset.flipped = ('true')
    }  // altera o estilo para carta virada caso não tenha nada no estilo clicado
    else{
        card.style.cssText = '';
        card.parentElement.style.cssText = '';
        clicagem--;  // diminue o contador de clicks
        card.dataset.flipped = ('false')
    } // altera o estilo para carta não virada caso não tenha nada no estilo clicado

    if (clicagem == 2) {
        let flippedCards = document.querySelectorAll('[data-flipped="true"]') // faz um array com o nome das cartas viras
        let cardMatch = (flippedCards[1].className == flippedCards[0].className) // verifica se as cartas viradas tem classes iguais
        if (cardMatch == true) {
            flippedCards.forEach(flippedCards => {
                flippedCards.style.backgroundColor = 'red'
                setTimeout(() => {
                    flippedCards.style.cssText = '';
                    flippedCards.parentElement.style.cssText = '';
                    flippedCards.dataset.flipped = ('false')
                }, 2500);

                setTimeout(()=>{flippedCards.parentElement.style.cssText = 'rotate: 0 1 0 1440deg;';}, 500)
            });
        }
        else{
            setTimeout(() => {
            flippedCards.forEach(flippedCards => {
                flippedCards.style.cssText = '';
                flippedCards.parentElement.style.cssText = '';
                flippedCards.dataset.flipped = ('false')
            })}, 1500);
        }
        clicagem = 0;
    }

    console.log(card.style.cssText);
    console.log(clicagem);
}