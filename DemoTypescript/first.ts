
console.log("Welcome to Typescript")

var firstname : string ="Tom"
var age : number = 33

console.log("Name =" + firstname)
console.log("Age =" + age)

 var f : number = 70
 var s : number = 80
 var c : string ="40"

 var result = f+s+c
 var R = f+c+s

 console.log(result)
 console.log(R)

var fruits : string[] = ['Apple','Mango','Orange','Grapes']

for (var i = 0 ; i < fruits.length; i++){

    console.log(fruits[i])

}

function sayHello():void{

    console.log('Hello world')

}

function multiply (a:number , b:number ) : number {

    return a*b;

}

sayHello()
console.log(multiply(4,5))






