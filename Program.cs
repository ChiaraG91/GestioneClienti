using System;
using System.Collections.Generic;

namespace GestioneClienti
{
    class Program
    {
        static List<Cliente> clienti = new List<Cliente>();
        static void Main(string[] args)
        {
            MenuPrincipale();
        }

static void AggiungiCliente()
{
    Console.Write("Inserisci il nome: ");
    string nome = Console.ReadLine();

    Console.Write("Inserisci il cognome: ");
    string cognome = Console.ReadLine();

    Console.Write("Inserisci l'email: ");
    string email = Console.ReadLine();

    Console.Write("Inserisci il numero di telefono: ");
    string numeroTelefono = Console.ReadLine();

    Cliente nuovoCliente = new Cliente
    {
        Nome = nome,
        Cognome = cognome,
        Email = email,
        NumeroTelefono = numeroTelefono
    };

    clienti.Add(nuovoCliente);
    Console.WriteLine("Cliente aggiunto con successo!\n");
}

static void VisualizzaClienti()
{
    if (clienti.Count == 0)
    {
        Console.WriteLine("Nessun cliente trovato.\n");
        return;
    }

    Console.WriteLine("Elenco clienti:");
    foreach (var cliente in clienti)
    {
        Console.WriteLine(cliente);
    }
    Console.WriteLine();
}

static void ModificaCliente()
{
    Console.Write("Inserisci l'email del cliente da modificare: ");
    string email = Console.ReadLine();

    Cliente cliente = clienti.Find(c => c.Email == email);
    if (cliente == null)
    {
        Console.WriteLine("Cliente non trovato.\n");
        return;
    }

    Console.Write("Nuovo nome (lascia vuoto per mantenere invariato): ");
    string nuovoNome = Console.ReadLine();
    if (!string.IsNullOrEmpty(nuovoNome)) cliente.Nome = nuovoNome;

    Console.Write("Nuovo cognome (lascia vuoto per mantenere invariato): ");
    string nuovoCognome = Console.ReadLine();
    if (!string.IsNullOrEmpty(nuovoCognome)) cliente.Cognome = nuovoCognome;

    Console.Write("Nuovo numero di telefono (lascia vuoto per mantenere invariato): ");
    string nuovoNumeroTelefono = Console.ReadLine();
    if (!string.IsNullOrEmpty(nuovoNumeroTelefono)) cliente.NumeroTelefono = nuovoNumeroTelefono;

    Console.WriteLine("Cliente aggiornato con successo!\n");
}

static void RimuoviCliente()
{
    Console.Write("Inserisci l'email del cliente da rimuovere: ");
    string email = Console.ReadLine();

    Cliente cliente = clienti.Find(c => c.Email == email);
    if (cliente == null)
    {
        Console.WriteLine("Cliente non trovato.\n");
        return;
    }

    clienti.Remove(cliente);
    Console.WriteLine("Cliente rimosso con successo!\n");
}
        static void MenuPrincipale()
{
    while (true)
    {
        Console.WriteLine("SISTEMA DI GESTIONE CLIENTI");
        Console.WriteLine("1. Aggiungi Cliente");
        Console.WriteLine("2. Visualizza Clienti");
        Console.WriteLine("3. Modifica Cliente");
        Console.WriteLine("4. Rimuovi Cliente");
        Console.WriteLine("0. Esci");
        Console.Write("Seleziona un'opzione: ");
        
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                AggiungiCliente();
                break;
            case "2":
                VisualizzaClienti();
                break;
            case "3":
                ModificaCliente();
                break;
            case "4":
                RimuoviCliente();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Scelta non valida. Riprova.");
                break;
        }
    }
}

    }
}

