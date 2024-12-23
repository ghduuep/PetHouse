namespace PetHouse.Models;
internal class Dono
{
    public Dono(string nome, string cpf, string email)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
    }
    public string Nome { get; }
    public string Cpf { get; }
    public string Email {  get; }
    public Pet Pet { get; set; }
    public string Descricao => $"Nome: {this.Nome} - CPF: {this.Cpf}\nEmail: {this.Email}";
}
