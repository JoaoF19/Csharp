using System;
using System.Collections.Generic;

namespace exercicio02_CalcMedia;
class Program
{
    public static void Main(string[] args)
    {
        int nQuantidade;
        bool retTP = false, withinInterval = false;
        do{
            Console.Clear();
            Console.Write("Quantidade de números a digitar: ");
            retTP = int.TryParse(Console.ReadLine(), out nQuantidade);  // modificador "out" é passagem de variaveis por referência que não precisa ser incializada ao contrário do modificador "ref"
            if(!retTP){
                ErrorMessage("Input inválido!");
                continue;
            }
            if(nQuantidade>=3 && nQuantidade <=10)
                withinInterval = true;
            else{
                withinInterval = false;
                ErrorMessage("Quantidade ultrapassa o limite de 3 a 10!");
            }
        }while(!retTP || withinInterval == false);

        var lista = RecolherValores(nQuantidade);
        Console.WriteLine($"Média: {lista.Average()}"); 
    }

    
    static void ErrorMessage(string message){
        Console.Write("Erro: " + message);
        Console.ReadLine();
    }

    static List<decimal> RecolherValores(int nTotal){
        int i=0;
        decimal val = 0;
        List<decimal> listaDeValores = new List<decimal>(nTotal); // É possível criar uma lista de forma dinamina  "new List<decimal>()"
        Console.WriteLine($"Insira os {nTotal} números:");
        for(i=0; i<nTotal; i++){
            do{
                Console.Write($"{i}º: ");
            }while(!decimal.TryParse(Console.ReadLine(), out val));
            listaDeValores.Add(val);
        }
        return listaDeValores;
    }
    static decimal calculaMedia(List<decimal> valores){
        decimal soma = valores.Sum();
        return soma/valores.Count;
    }
}
