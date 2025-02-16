using System;

namespace Calculadora{
    class Program{

        static float resultado;
        
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            
            // Parte inicial do menu

            Console.Clear();
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1 ) SOMAR");
            Console.WriteLine("2 ) SUBTRAIR");
            Console.WriteLine("3 ) MULTIPLICAR");
            Console.WriteLine("4 ) DIVIDIR");
            Console.WriteLine("5 ) SAIR");
            Console.Write("Opção desejada: ");
            
            short resp;
            while (!short.TryParse(Console.ReadLine(), out resp)) {
                Console.WriteLine("Por favor, digite uma opção válida (1 a 5).");
                Console.Write("Opção desejada: ");
            }

            // Usar o switch case para chamar as funções
            
            switch(resp){
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                Dividir();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema.....");
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Somar(){
            float[] valores = Valores();
            float v1 = valores[0];
            float v2 = valores[1];
            float res = (v1+v2);
            Console.WriteLine($"O resultado da soma é: {res}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            Menu();
        }

        static void Subtrair(){
            float[] valores = Valores();
            float v1 = valores[0];
            float v2 = valores[1];
            float res = (v1-v2);
            Console.WriteLine($"O resultado da subtração é: {res}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicar(){
            float[] valores = Valores();
            float v1 = valores[0];
            float v2 = valores[1];
            float res = (v1*v2);
            Console.WriteLine($"O resultado da multiplicação é: {res}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            Menu();
        }

        static void Dividir(){
            float[] valores = Valores();
            float v1 = valores[0];
            float v2 = valores[1];
            float res = (v1/v2);
            Console.WriteLine($"O resultado da divisão é: {res}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            Menu();
        }

        static float[] Valores(){
            Console.Write("Digite o primeiro valor: ");
            float v1 =  float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float v2 =  float.Parse(Console.ReadLine());
            float[] valores = {v1,v2};
            return valores;
        }



    }    
}