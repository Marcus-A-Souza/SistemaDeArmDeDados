using System;
using System.Collections.Generic;

// Definição da classe de usuário
public class User
{
    public int Id { get; set; }
    public string Nome { get; set; } // Mudamos para "Name" em vez de "Username"
    public string Email { get; set; }
    

    // Método para exibir informações do usuário
    public void DisplayUserInfo()
    {
        Console.WriteLine($"ID: {Id}, Nome: {Nome}, Email: {Email}");
    }
}
