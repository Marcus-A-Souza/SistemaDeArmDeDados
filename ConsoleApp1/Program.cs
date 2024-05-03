using ConsoleApp1;

class Program:UserCollection
{
    static void Main(string[] args)
    {
        UserCollection userCollection = new UserCollection();

        bool continueRunning = true;
        while (continueRunning)
        {
            Console.WriteLine("\nO que você gostaria de fazer?");
            Console.WriteLine("1. Adicionar novo usuário");
            Console.WriteLine("2. Remover usuário");
            Console.WriteLine("3. Pesquisar usuário por ID");
            Console.WriteLine("4. Exibir todos os usuários");
            Console.WriteLine("5. Sair");

            Console.Write("\nEscolha uma opção: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    userCollection.AddUser();
                    break;
                case "2":
                    RemoveUser(userCollection);
                    break;
                case "3":
                    FindUserById(userCollection);
                    break;
                case "4":
                    userCollection.DisplayAllUsers();
                    break;
                case "5":
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void RemoveUser(UserCollection userCollection)
    {
        Console.WriteLine("\nRemover usuário:");
        Console.Write("ID do usuário: ");
        int id = Convert.ToInt32(Console.ReadLine());

        userCollection.RemoveUser(id);
    }

    static void FindUserById(UserCollection userCollection)
    {
        Console.WriteLine("\nPesquisar usuário por ID:");
        Console.Write("ID do usuário: ");
        int id = Convert.ToInt32(Console.ReadLine());

        User user = userCollection.FindUserById(id);
        if (user != null)
        {
            Console.WriteLine("Usuário encontrado:");
            user.DisplayUserInfo();
        }
    }
}