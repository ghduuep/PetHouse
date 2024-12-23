namespace PetHouse.Models;
internal class Medico
{
    public Medico(string nome, string crmv, Especialidade especialidade)
    {
        this.Nome = nome;
        this.Crmv = crmv;
        this.Especialidade = especialidade;
    }
    public string Nome { get; }
    public string Crmv { get; }
    public Especialidade Especialidade { get; }
    public string Descricao => $"Nome: {this.Nome} - CRMV {this.Crmv}\nEspecialidade: {this.Especialidade}";
}
