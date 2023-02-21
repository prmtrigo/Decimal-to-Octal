namespace Decimal_to_Octal;
class Program
{
    public int ConverterParaOctal(int numero){

        //armazenando o número octal
        int[] numeroOctal = new int[100];

        //implementando um contador
        int contando = 0;
        
        //implementando o contador
        while (numero != 0)
        {  
            //divisões sucessivas
            //vamos dividindo sempre com o resto
            //ao final, obviamente
            //dividir numero por 8
            numeroOctal[contando] = numero % 8;
            numero /= 8;
            contando++;
        }

        //invertendo a string
        for (int i = contando -1; i >= 0; i--)
        {
            Console.Write(numeroOctal[i]);
        }

        return 1;
    }
    static void Main(string[] args)
    {
        Program p = new Program();

        Console.WriteLine("digite um número em decimal: ");

        //adicionar o número
        int numero = Convert.ToInt32(Console.ReadLine());

        //chamar a função
        p.ConverterParaOctal(numero);
    }
}
