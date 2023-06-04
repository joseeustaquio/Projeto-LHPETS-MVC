namespace LHPET.Models;

public class Cliente
{
    //criando a clase cliente com seus atributos
    public int Id{get; set;}
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Email {get; set;}
    public string Paciente {get; set;}

    //Criando o método construtor com parâmetros
    public Cliente (int id, string nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }
}