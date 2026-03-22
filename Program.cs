using System;
using System.Runtime.CompilerServices;
namespace vitin;
class Program
{   
    static void Main(string[] args)
    {
        bool projeto = true;
        while (projeto)
        {
            Menu();
        }
   
    }
    static void Menu()
{
    System.Console.WriteLine("Menu MindForge");
    System.Console.WriteLine("1- Materias de estudo");
    System.Console.WriteLine("2- Sessão Pomodoro");
    System.Console.WriteLine("3- To-do");
    System.Console.WriteLine("4- Roadmap");
    System.Console.WriteLine("5- Sair do Ambiente");
    string? escolha = Console.ReadLine()!;
    int.TryParse(escolha, out int escolha1);
        switch (escolha1)
        {
            case 1:
            Console.Clear();
            menu1();
            break;
            case 2:
            break;
            case 3:
            break;
            case 4:
            break;
            case 5:
            Console.Clear();
            System.Console.WriteLine("saindo...");
            Environment.Exit(0);
            break;
            
        }
}    
    
    static void menu1()
    {
        System.Console.WriteLine("Escolha seu Modelo de Estudo");
        System.Console.WriteLine("1- Grades Curriculares");
        System.Console.WriteLine("2- Passivo / Ativo");
        string? menug = Console.ReadLine()!;
        int.TryParse(menug, out int menug1);
        switch (menug1)
        {
            case 1:
                Console.Clear();
                Dictionary<string, List<string>> grade = new Dictionary<string, List<string>>
                {
                    {"Fundação", new List<string> {"Arquitetura de Computador", "Eletrônica Básica", "Linux — Terminal"}},
                    {"Raciocínio", new List<string> {"Lógica de Programação", "C#", "GitHub"}},
                    {"Infraestrutura", new List<string> {"Redes de Computadores", "Cisco — SI", "Linux — Redes"}},
                    {"Frontend", new List<string> {"HTML + CSS", "JavaScript", "MySQL"}},
                    {"Extras", new List<string> {"Jornada IA", "Inglês — Pokémon", "Matemática"}}
                    
                };  foreach (var grade1 in grade) 
                    {
                        
                        Console.WriteLine($"\n{grade1.Key}");
                        foreach (var materia in grade1.Value)
                    {
                        
                        System.Console.WriteLine(materia);
                    }
                        
                    }
                    Console.ReadKey();
            break;
        }
    }
    static void menu2()
    {
        
    }
    
}

