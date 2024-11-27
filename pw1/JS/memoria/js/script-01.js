var execute

function flipcard(card){

    console.log('%cExecução:' + execute, 'color: red')
    if (execute == true) {
        return;
    }
    execute = true
    setTimeout(() => {
        execute = false;
    }, document.querySelectorAll('[data-flipped="true"]').length*1000);

    if(document.querySelectorAll('[data-flipped="true"]').length < 2) { // Verifica se o número  de cartas viradas é menor do que 2
        
        const exList = ['img-1','img-2','img-9']; // exceções das imagens
        let cardType = ((exList.includes(card.className)) ? ".png" : ".webp") //vê se o card selecionado está contido na lista acima
        
        let cardSource = card.className + cardType; // concatena o nome da classe com o tipo de arquivo
        console.log(cardSource) // test
        
        if (card.style.cssText === ''){ 
            card.style.cssText = 'background: url(imgs/' + cardSource + ') no-repeat;';
            card.parentElement.style.cssText = 
            'rotate: 0 1 0 180deg;' +
            'transition: 1s ease-in-out;';
            card.dataset.flipped = ('true')
        }  // altera o estilo para carta virada caso não tenha nada no estilo clicado
        else{
            card.style.cssText = '';
            card.parentElement.style.cssText = '';
            card.dataset.flipped = ('false')
        } // altera o estilo para carta não virada caso não tenha nada no estilo clicado
    }
    
    if (document.querySelectorAll('[data-flipped="true"]').length == 2) { // Verifica se o número de cartas viradas é igual a 2

        let flippedCards = document.querySelectorAll('[data-flipped="true"]'); // faz um array com o nome das cartas viras
        console.log("card flipped 2: " + flippedCards.length)

        let cardMatch = (flippedCards[1].className == flippedCards[0].className) // verifica se as cartas viradas tem classes iguais
        console.log("CardMatch: " + cardMatch)

        if (cardMatch == true) { // aciona a ação de match
            flippedCards.forEach(flippedCards => { //torna cada carta virada em
                flippedCards.style.backgroundColor = 'red' // cor vermelha
                setTimeout(()=>{ // rotaciona a carta após o m
                    flippedCards.parentElement.style.cssText = 'rotate: 0 1 0 1440deg;';
                }, 1000)
                setTimeout(() => {  //retira os estilos
                    flippedCards.style.cssText = '';
                    flippedCards.parentElement.style.cssText = '';
                    flippedCards.dataset.flipped = ('false') // coloca a carta como não virada
                }, 3000);
            });
        }
        else{ // aciona a ação de não match
            setTimeout(() => { //retira os estilos
            flippedCards.forEach(flippedCards => {
                flippedCards.style.cssText = '';
                flippedCards.parentElement.style.cssText = '';
                flippedCards.dataset.flipped = ('false') // coloca a carta como não virada
            })}, 1500);
        };
    }
        
}

