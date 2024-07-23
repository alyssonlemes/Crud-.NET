namespace ApiCrud.Estudantes;

public class Estudante
{
    public Guid Id { get; init; }
    //guid é um id que não se repete e o init mantém o id sem alterações
    public String Nome { get; private set; }
    //private set mantém o nome sendo alterável apenas dentro da classe
    public bool Ativo { get; private set; }

    //criando construtor
    public Estudante(string nome)
    {
        Nome = nome;
        Id = Guid.NewGuid();
        Ativo = true;
    }

    public void AtualizarNome(string nome)
    {
        Nome = nome;
    }
    
    public void Desativar()
    {
        Ativo = false;
    }
}