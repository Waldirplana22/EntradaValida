using System;

class Program {
  public static void Main (string[] args) {
    
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ---- Exercicio Entrada Válida ---- ");
            PularLinha();
           
            int valida;

            Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
            valida = Convert.ToInt32(Console.ReadLine());
            
            LimparTela();
            PularLinha();
    Console.ForegroundColor = ConsoleColor.DarkRed;
            switch (valida)
            {
                case 0:
                    Console.WriteLine($"número selecionado = {valida}, a operação será cancelada");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
              PularLinha();
                    Console.WriteLine("digite qualquer tecla para sair:");
                    Console.ReadKey();
                    break;
             

                case 1:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 2:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 3:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 4:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 5:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 6:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 7:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 8:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                case 9:
                    Console.WriteLine($"Número selecionado = {valida}");
              PularLinha();
                    Console.WriteLine("Perfeito. Volte Sempre");
                    break;

                default:
                    Console.WriteLine("Número Inválido, Operação cancelada");
              PularLinha();
                    Console.WriteLine("Errado. Volte Sempre");
                    return;
                    break;
            }         
        static void PularLinha()
        {
            Console.WriteLine();
        }
        static void LimparTela()
        {
            Console.Clear();
        }
    }
}
