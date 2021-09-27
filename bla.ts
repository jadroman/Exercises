class Klasa {
    polje1: number;
    polje2?: number;
}

var objekt: number = 2;
//objekt.polje1 = 1;

console.log('before');

console.log(objekt);

Change(objekt);

console.log('after');

console.log(objekt);

function Change(objekt: number) {
    objekt = 3;
}