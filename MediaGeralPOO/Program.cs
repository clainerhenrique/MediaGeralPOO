namespace MediaGeralPOO
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Media Geral dos alunos";
            Console.Write("Quantos alunos? ");

            int nAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + " Nome..: ");
                string nome = Console.ReadLine();
                Console.Write("Aluno #" + (i + 1) + " Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno " + nome);

                alunos[i].InserirNotas();

            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.nome);
                Console.WriteLine("Media: " + aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Media geral dos alunos : " + resultadoFinal);


        }
    }
}
