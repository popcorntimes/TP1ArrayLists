using System.Collections;

namespace TP1ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new ArrayList();
            var passwords = new ArrayList();
            Console.WriteLine("Quantos usuários você deseja cadastrar?");
            int qteCad = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<qteCad; i++)
            {
                Console.WriteLine($"Entre com o usuário {i+1}: ");
                users.Add(Console.ReadLine());
                Console.WriteLine($"Entre com a senha {i+1}: ");
                passwords.Add(Console.ReadLine());
                Console.WriteLine("Cadastrado com sucesso");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
            int errorCounter = 0;
            while (errorCounter < 3)
            {
                Console.WriteLine("Realize o seu login");
                Console.WriteLine("Entre com o usuário: ");
                var user = Console.ReadLine();
                if (!users.Contains(user))
                {
                    Console.WriteLine("Usuário incorreto");
                    errorCounter++;
                    continue;
                }
                Console.WriteLine("Entre com a senha: ");
                var password = Console.ReadLine();
                if (!passwords.Contains(password))
                {
                    Console.WriteLine("Senha incorreta");
                    errorCounter++;
                    continue;
                }

                Console.WriteLine("Usuário autorizado");
                break;

            }
            if(errorCounter >= 3)
            {
                Console.WriteLine("VocÊ atingiu o limite de tentativas");
            }

        }
    }
}