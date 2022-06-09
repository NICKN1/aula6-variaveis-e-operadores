namespace Desafio_do_Prof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXISTEM FORMAS DE RESOLVER E DEIXAR O CÓDIGO BEM MENOR, MAS PENSEI EM DEIXAR O MAIS VISUAL PARA TODOS


            //Criei a variável do tipo double(decimal) 
            double quilometrosPercorridosPeloVeiculo = 80000;

            //Comando para imprimir uma mensagem no console do usuário
            Console.WriteLine("Digite os quilometros percorridos pelo veículo: ");

            /*Usa o Comando 'Console.ReadLine()' para ler o dado de entrada do usuário, 
              e atribui-lo logo a uma variável*/
            quilometrosPercorridosPeloVeiculo = double.Parse(Console.ReadLine());
            /*Usei o comando double.Parse para converter o valor que o usuário digitou, 
             no caso um tipo String, para o tipo double(decimal)*/

            /*Agora a variável é multiplicada pelo o valor 1.609344,
            que é necessário para converter quilometros em milhas*/
            quilometrosPercorridosPeloVeiculo /= 1.609344;

            Console.WriteLine(); // USADO APENAS PARA DAR ESPAÇAMENTO NO CONSOLE

            /*Usei a concatenação com o cifrão '$', digitei a mensagem desejada e em seguida
             dentro de chaves, coloquei a variável.*/
            Console.WriteLine($"Seu veículo percorreu um total de {quilometrosPercorridosPeloVeiculo.ToString("N2")} milhas.");
            /*Eis um ponto interessante, pois usei '.ToSting' para fazer uma conversão inversa aquela que
             * fiz lá em cima, dessa vez quero converter para String. Logo em seguida coloquei '(N2)' para
             * avisar ao programa que desejo apenas DOIS decimais após a virgula.
             */

        }
    }
}