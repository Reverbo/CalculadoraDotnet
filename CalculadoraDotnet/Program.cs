using System;

class CalculadoraDotnet
{
    private static int result;

    public static void Main()
    { 
        Console.WriteLine("Digite um número");
        var leftValue = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Digite o Operador");

        var operatorValue = Console.ReadLine();

        Console.WriteLine("Digite outro número");

        var rightValue = Convert.ToInt16(Console.ReadLine());
        


        switch (operatorValue)
        {
            case "+":
                result = leftValue + rightValue;
                break;
            case "-" :
                result = leftValue - rightValue;
                break;
            case "*":
                result = leftValue * rightValue;
                break;
            case "/":
                result = leftValue / rightValue;
                break;
        }

        Console.WriteLine($"O resultado é {result}");   



        

 

}
}

  
        


   
      

    
    



