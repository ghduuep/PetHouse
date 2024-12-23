using PetHouse.Models;

Medico medico = new("Guilherme Lima", "1234567", Especialidade.CARDIOLOGIA);
Dono dono = new("Paloma Duarte", "30245479803", "ghduep@outlook.com");
Pet pet = new("Lua", "Gato", 1, dono);

Consulta consulta = new(pet, medico, DateTime.Now);
Console.WriteLine(consulta.Descricao);
