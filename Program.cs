using System;

class Program
{
    static void Main(string[] args)
    {
        string[] x = NomeAluno();
        double[,] y = NotaAluno(x);
        double[] z = MediaAluno(y);

        Console.WriteLine("Aluno\tNota 1\t nota 2\t nota 3\t média");
        for (int i = 0; i < 10; i++)
        {
            if (z[i] >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4:N2}\tAprovado(a)", x[i], y[i, 0], y[i, 1], y[i, 2], z[i]);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4:N2}\tReprovado(a)", x[i], y[i, 0], y[i, 1], y[i, 2], z[i]);


            }

        }
        Console.ReadKey();
    }
    static string[] NomeAluno()
    {
        string[] Aluno = new string[10];
        for (int i = 0; i < Aluno.Length; i++)
        {
            Console.WriteLine("Digite o nome do {0}° aluno: ", i + 1);
            Aluno[i] = Console.ReadLine();
        }
        return Aluno;
    }
    static double[,] NotaAluno(string[] NomeAluno)
    {
        double[,] Notas = new double[10, 3];
        for (int l = 0; l < 10; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine("Digite a {0}° nota de {1}", c + 1, NomeAluno[l]);
                Notas[l, c] = double.Parse(Console.ReadLine());
            }
        }
        return Notas;
    }
    static double[] MediaAluno(double[,] Notas)
    {
        double[] Medias = new double[10];
        for (int i = 0; i < 10; i++)
        {
            double aux = Notas[i, 0] + Notas[i, 1] + Notas[i, 2];
            Medias[i] = aux / 3;
        }
        return Medias;
    }
}
