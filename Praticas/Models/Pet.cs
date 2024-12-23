namespace PetHouse.Models;
internal class Pet
{
    public Pet(string nome, string especie, int idade, Dono dono)
    {
        this.Nome = nome;
        this.Especie = especie;
        this.Idade = idade;
        this.Dono = dono;
        dono.Pet = this;
    }
    public string Nome { get; }
    public string Especie { get; }
    public int Idade { get; }
    public Dono Dono { get; }
    public string Descricao => $"Nome: {this.Nome}\nEspécie: {this.Especie} - Idade: {this.Idade}\nDono: {this.Dono.Nome}";
}
