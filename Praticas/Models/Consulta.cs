namespace PetHouse.Models;
internal class Consulta
{
    public Consulta(Pet pet, Medico medico, DateTime data)
    {
        this.Pet = pet;
        this.Medico = medico;
        this.dataConsulta = data;
    }
    public Pet Pet { get; }
    public Medico Medico { get; }
    public DateTime dataConsulta { get; }
    public string Descricao => $"Consulta ({this.dataConsulta}):\nPet:{this.Pet.Nome}\nMedico: {this.Medico.Nome}";
}
