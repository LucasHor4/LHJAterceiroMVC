namespace LHJAterceiroMVC.Models
{
    public class Pessoa
    {
        // Declarando as variaveis/atributos/propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Sexo {  get; set; }

        public Pessoa selectPessoa()
        {
            Pessoa ObjPessoa = new Pessoa();
            return ObjPessoa;
            //codigo para buscar pessoa no banco
        }



    }
}
