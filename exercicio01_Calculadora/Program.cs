namespace Classes;
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu(){
        int opcao;
        double valor1 = 0, valor2 = 0, resultado = 0;

        Console.Clear();
        Console.WriteLine("Selecione uma das opções:");
        Console.WriteLine("Opção 1: Soma;");
        Console.WriteLine("Opção 2: Subtração;");
        Console.WriteLine("Opção 3: Multiplicação;");
        Console.WriteLine("Opção 4: Divisão;");
        Console.WriteLine("Opção 0: Sair.");
        Console.Write("\nOpção: ");
        opcao = Convert.ToInt16(Console.ReadLine());

        switch(opcao){
            case 0:
            break;
            case 1:
            questionario(ref valor1, ref valor2);
            resultado = Soma(valor1, valor2);
            break;
            case 2:
            questionario(ref valor1, ref valor2);
            resultado = Subtracao(valor1, valor2);
            break;
            case 3:
            questionario(ref valor1, ref valor2);
            resultado = Multiplicacao(valor1, valor2);
            break;
            case 4:
            questionario(ref valor1, ref valor2);
            if(valor2 != 0){
                resultado = Divisao(valor1, valor2);
            }else{
                Console.WriteLine("ERRO: Divisor deve ser diferente de zero!");
                Console.ReadLine();
                Menu();
            } 
            break;
        } 
        Console.WriteLine("Resultado Final: {resultado}");
        Console.ReadLine();
        Menu();
    }
    public static void questionario(ref double v1, ref double v2){
         Console.Clear();
         Console.Write("Digite o 1º valor: ");
         v1 = Convert.ToDouble(Console.ReadLine());
         Console.Write("Digite o 2º valor: ");
         v2 = Convert.ToDouble(Console.ReadLine());
    }
    public static double Soma(double v1, double v2){
        return v1+v2;
    }
    public static double Subtracao(double v1, double v2){
        return v1-v2;
    }
    public static double Multiplicacao(double v1, double v2){
        return v1*v2;
    }
    public static double Divisao (double v1, double v2){
        return v1/v2;
    }


}
