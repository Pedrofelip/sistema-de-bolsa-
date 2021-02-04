using System;
using sistema_de_notas_02.classes;


namespace sistema_de_notas_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Adicione o nome do aluno:");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Adicione o curso do seu interesse:");
            aluno.curso = Console.ReadLine();

            Console.WriteLine("Adicione o rg do aluno:");
            aluno.rg = Console.ReadLine();

            Console.WriteLine("Adicione a media final do aluno:");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Adicione o valor da mensalidade:");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("O aluno é bolsista? (s/n):");
            string resposta = Console.ReadLine();

            if (resposta=="s")
            {
                aluno.bolsista = true;
            }
            else{
                aluno.bolsista = false;
            }

                int opcao;
            do
            {
                Console.WriteLine("-----------menu-----------");
                Console.WriteLine("[1] - Ver a mensalidade");
                Console.WriteLine("[2] - Ver a media final");
                Console.WriteLine("[0] - Sair");

                Console.WriteLine("Escolha uma opção:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                            if (aluno.bolsista == true)
                            {
                                Console.WriteLine($"O aluno tem direito a bolsa de estudos de 50%. O valor da mensalidade é de: {aluno.verMensalidade()}");
                            }
                            else
                            {
                                 Console.WriteLine($"O aluno não tem direito a bolsa de estudos de 50%. O valor da mensalidade é de: {aluno.verMensalidade()}");
                            }
                        break;

                    case 2:
                            Console.WriteLine($"A media final do aluno {aluno.nome} é de {aluno.verMediaAluno()}");
                        break;
                    case 0:
                            Console.WriteLine("Obrigado por ter acessado");
                        break;
                    default:
                        break;
                }
                

            } while (opcao != 0);

        }
    }
}
