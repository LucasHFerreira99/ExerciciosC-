namespace CoursePOO
{
    internal class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public Boolean Aprovado()
        {
            if (NotaFinal() < 60)
            {
                return false;
            }else
            {
                return true;
            }
        }

        public double NotaRestante()
        {
            return 60 - NotaFinal();
        }

    }
}
