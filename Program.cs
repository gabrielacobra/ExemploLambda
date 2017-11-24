using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func<int,int,int> rs = soma; //os dois parâmetros de entrada e o último é sempre o de retorno. o delegate func se apropriou dos métodos de soma.
            // Console.WriteLine(rs(10,5));

            // Func<int, int, double> res = Atividade.subtrair;
            // Console.WriteLine(res(10,5));

            // Func<int, int, string> ser =  Atividade.multiplicar;
            // Console.WriteLine(ser(10,5));

            // Action<int, int> res = soma;
            // res(20,30); // passando os dados para a variável res

            // Predicate<int> res = Par;
    //         // Console.WriteLine(res(32));         
            
    //         Data dt = delegate (string msg){
    //             return msg +" Hoje é "+DateTime.Now;
    //         };
    //         Console.WriteLine(dt("Olá, sexta-feira!"));
    //     }
    //     static void soma (int v1, int v2){
    //         Console.WriteLine(v1+v2);
    //     }

    //     static bool Par(int valor){
    //         return valor%2==0; //se o valor passado pro método for divisível por 2, é par, ou seja, vai retornar true.
    //     }

    //     delegate string Data(string mensagem);

    // int [] valores = {40, 56, 1, 23, 9, 11, 22};

    // // Func<int, bool> rs = delegate(int x){
    // //     return x%2 == 0;
    // //   };

    // Func<int, bool> rs = x => x%2 ==0;

    // foreach(int i in valores)
    // if(rs(i))
    // Console.WriteLine(i);

    Func<double, double, double> calculo = (x,y) => x/y;
    Console.WriteLine(calculo(23,5));
    
    }

    // static bool Par(int v){
    //     return v%2 ==0;
    // }
    }
}
