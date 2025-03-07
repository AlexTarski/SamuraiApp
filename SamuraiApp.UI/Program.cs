using System;
using System.Linq;
using SamuraiApp.Domain;
using SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SamuraiApp.UI;
static class Program
{
    private static SamuraiContext _context = new SamuraiContext();
    static void Main(string[] args)
    {
        _context.Database.EnsureCreated();
        AddSamurai("Julie3", "Sampson3");
        GetSamurais();
        Console.Write("Press any key...");
        Console.ReadKey();
    }

    private static void AddSamurai(params string[] names)
    {
        foreach(string name in names)
        {
            _context.Samurais.Add(new Samurai { Name = name });
        }
        _context.SaveChanges();
    }

    private static void GetSamurais()
    {
        var samurais = _context.Samurais
            .TagWith("ConsoleApp.Program.GetSamurais method")
            .ToList();
        Console.WriteLine($"Samurai count is {samurais.Count}");
        foreach (var samurai in samurais)
        {
            Console.WriteLine(samurai.Name);
        }
    }
}