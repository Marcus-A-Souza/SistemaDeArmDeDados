using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class UserCollection
{
    private Dictionary<int, User> users = new Dictionary<int, User>();

    public void AddUser()
    {
        Console.WriteLine("\nAdicionar novo usuário:");
        Console.Write("Nome de usuário: ");
        string Nome = Console.ReadLine();

        Console.Write("ID do usuário: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (users.ContainsKey(id))
        {
            Console.WriteLine($"Já existe um usuário com o ID {id}.");
            return;
        }

        Console.Write("Email: ");
        string email = Console.ReadLine();

        User newUser = new User { Id = id, Nome = Nome, Email = email };
        users.Add(id, newUser);
        Console.WriteLine("Usuário adicionado com sucesso.");
    }

    public void RemoveUser(int id)
    {
        if (users.ContainsKey(id))
        {
            users.Remove(id);
            Console.WriteLine($"Usuário com ID {id} removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"Usuário com ID {id} não encontrado.");
        }
    }

    public User FindUserById(int id)
    {
        if (users.ContainsKey(id))
        {
            return users[id];
        }
        else
        {
            Console.WriteLine($"Usuário com ID {id} não encontrado.");
            return null;
        }
    }

    public void DisplayAllUsers()
    {
        Console.WriteLine("\nLista de todos os usuários:");
        foreach (var userEntry in users)
        {
            userEntry.Value.DisplayUserInfo();
        }
    }
}

}
