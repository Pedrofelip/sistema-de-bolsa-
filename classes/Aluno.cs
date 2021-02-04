namespace sistema_de_notas_02.classes
{
    public class Aluno
    {
        public string nome;

        public string curso;

        public string rg;

        public bool bolsista;

        public float mediaFinal;

        public float valorMensalidade;

        
        public float verMediaAluno(){

            return this.mediaFinal;

        }

        public float verMensalidade(){

              float valor;

                if (this.bolsista)
                {
                     valor = valorMensalidade*0.5f;
                }else{
                    valor = valorMensalidade;
                }

                return valor;

        }
    }
}