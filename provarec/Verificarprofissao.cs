public class Verificarprofissao
{
    public string nome;
    public int cpf;
    public DateTime iniciodaprofissão;
    public DateTime datadenascimento;
    public string genero;
    public string profissão;
    public string aposentadoria;
    public int quantidadedepontos;


    public int idade()
    {
        DateTime datadenascimento = DateTime.Now;
        return datadenascimento.Year;
    }
    public int Verificarprofissao()
    {
        if (this.profissão == "Saúde")
        {
            quantidadedepontos = iniciodaprofissão.Year + idade();

        }
        else if (this.profissão == "Professor")
        {
            quantidadedepontos = iniciodaprofissão.Year + idade();
        }

        else if (this.profissão == "Agente de segurança")
        {
            quantidadedepontos = iniciodaprofissão.Year + idade();
        }
        else if (this.profissão == "Outra profissão")
        {
            quantidadedepontos = iniciodaprofissão.Year + idade();
        }
        return this.quantidadedepontos;
    }

   

}