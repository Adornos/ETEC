document.write("<div id='arrays'></div>");

let nomes = ["Felipe", "Akemi", "Guilherme", "Caio", "Ademar", "Barbara", "Amanda", "Antonio", "Flavia", "camily"];

let alfabetico = nomes;
let betoalfatico = alfabetico.sort();

betoalfatico.reverse();

let metade1 = alfabetico.slice(0, 4);
let metade2 = alfabetico.slice(4, 9);

let shift1 = metade1.shift(2);
let shift2 = metade2.shift(3);

let concat = metade1.concat(metade2);

let splice = concat.splice(concat.indexOf("Guilherme"), concat.indexOf("Guilherme")+1, "Henri");

let popi = splice.pop(length);

// let push = popi.push("Julia");

document.getElementById("arrays").innerHTML += nomes + "1<br>" 
document.getElementById("arrays").innerHTML += alfabetico + "2<br>" 
document.getElementById("arrays").innerHTML += betoalfatico + "3<br>" 
document.getElementById("arrays").innerHTML += metade1 + "4<br>" 
document.getElementById("arrays").innerHTML += metade2 + "5<br>" 
document.getElementById("arrays").innerHTML += shift1 + "6<br>" 
document.getElementById("arrays").innerHTML += shift2 + "7<br>" 
document.getElementById("arrays").innerHTML += concat + "8<br>" 
document.getElementById("arrays").innerHTML += splice + "9<br>" 
document.getElementById("arrays").innerHTML += popi + "10<br>" 
// document.getElementById("arrays").innerHTML =+ push + "<br>" 
