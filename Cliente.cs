
namespace GestioneClienti
{
public class Cliente
{
    public string Nome { get; set; } = " ";
    public string Cognome { get; set; } = " ";
    public string Email { get; set; } = " ";
    public string NumeroTelefono { get; set; } = " ";
    
    // Metodo per visualizzare i dettagli del cliente
    public override string ToString()
    {
        return $"Nome: {Nome}, Cognome: {Cognome}, Email: {Email}, Telefono: {NumeroTelefono}";
    }



}
}

