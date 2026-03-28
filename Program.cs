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
    Console.Clear();
    System.Console.WriteLine("Menu MindForge");
    System.Console.WriteLine("1- Materias de estudo");
    System.Console.WriteLine("2- Sessão Pomodoro");
    System.Console.WriteLine("3- Notion");
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
            Console.Clear();
            menu2();
            break;
            case 3:
            menu3();
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
        bool gradee = true;
        while (gradee)
        {
            System.Console.WriteLine("Escolha seu Modelo de Estudo");
        System.Console.WriteLine("1- Grades Curriculares");
        System.Console.WriteLine("2- Passivo / Ativo");
        System.Console.WriteLine("3- Sair");
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
            case 2:
            break;
            case 3:
                gradee = false;
            break;
        }
        }
        
    }
    static void menu2()
    {
        bool pomodoro = true;
        while (pomodoro)
        {
                 System.Console.WriteLine("Pomodoro");
        System.Console.WriteLine("1- Iniciar Pomodoro\n 2- Timer\n3- Sair");
        string? escolha1 = Console.ReadLine();
        int.TryParse(escolha1, out int escolha2);
            if (escolha2 == 1)
        {
            for (var timer = 1500 ;timer > 0; timer--)
        {   
            int seg = timer;
          int min = 60;
          int tempo = seg / min;
          int segundos = seg % min;
            Thread.Sleep(1000);
            Console.Clear();
           System.Console.Write($"-{tempo}:{segundos:D2}");

             if (Console.KeyAvailable)
                {
                    break;
                }
        }
        } else if(escolha2 == 2)
        {
            for (var segundos = 0 ;segundos <  9999; segundos--)
            {
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine($"{segundos}");
            if (Console.KeyAvailable)
                {
                    break;
                }
                }
        } else
            {
                pomodoro = false;
            }  
        }
    }
      static List<string> resnotas = new List<string>();


    static void menu3()
    {
        Console.Clear();

        bool menution = true;
        while (menution)
        {
            
        System.Console.WriteLine("-Notion-");
        System.Console.WriteLine("1- Adcionar notas Nota\n2- Notas Passadas\n3- Sair");
        string? resuln = Console.ReadLine();
        int.TryParse(resuln, out int write);
            if (write == 1)
        {
            Console.Clear();
            System.Console.WriteLine("Notion\nColoque uma Nota...");
            string? nota = Console.ReadLine()!;
            resnotas.Add(nota);
            File.AppendAllText("notas.txt", nota + "\n");
        } else if (write == 2)
        {
            Console.Clear();
            System.Console.WriteLine("--notas passadas--");
            string[] linhas = File.ReadAllLines("notas.txt");
            foreach (string resul2 in linhas)
            {
                
                System.Console.WriteLine(resul2);
                
                
                
                
            } Console.ReadKey();

        } else
            {
                menution = false;
            }
        

        }
    
        

    }
    
}

