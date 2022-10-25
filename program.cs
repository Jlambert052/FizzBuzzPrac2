// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void FizzBuzz(int m) {

    for(int i =1; i <= m; i++) {
        if(i % 3 == 0 && i % 5 == 0){
        System.Console.WriteLine("FizzBuzz");}
        else if(i % 3 == 0 ){
        System.Console.WriteLine("Fizz");}
        else if(i % 5 == 0){
        System.Console.WriteLine("Buzz");}
        else {
            System.Console.WriteLine($"{i}");
        }
    }
}

FizzBuzz(150);
