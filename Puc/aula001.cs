using System;

class Class {
    public static void Main (string[] args) {
        int idade = 27;
        string nome = "Luna";

        //Concatenação
        Console.WriteLine( " Meu nome é "+nome+" e tenho"+idade+" anos de idade.");
        //Placeholder
        Console.WriteLine("Meu nome é {0} e tenho {1} anos de idade.",nome,idade);
        //Interpolação
        Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos de idade.");

        Console.ReadLine();  

    }
}

    
