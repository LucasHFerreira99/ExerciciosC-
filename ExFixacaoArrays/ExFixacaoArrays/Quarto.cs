
namespace ExFixacaoArrays
{
    internal class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }

        public override string ToString()
        {
            return Numero
                + ": "
                + Nome 
                + ", " 
                + Email;
        }
    }
}
