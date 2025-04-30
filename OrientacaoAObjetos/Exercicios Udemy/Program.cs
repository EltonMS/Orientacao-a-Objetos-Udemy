using ExerciciosOO.Exercicios_Udemy;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Quantas pessoas serão digitadas?");
        int qtd_pessoas = Convert.ToInt32(Console.ReadLine());
        double[] alturas = new double[qtd_pessoas];
        string[] generos = new string[qtd_pessoas];
        double menorAltura = 0.0;
        double maiorAltura = 0.0;
        double somaAlturasMulheres = 0.0;
        int qtdHomens = 0;
        for (int i = 0; i < qtd_pessoas; i++) {
            Console.WriteLine($"Digite a altura da {i + 1}ª pessoa:");
            double altura = Convert.ToDouble(Console.ReadLine());
            alturas[i] = altura;
            if (i == 0)
            {
                menorAltura = altura;
                maiorAltura = altura;
            }
            else
            {
                if (altura < menorAltura)
                {
                    menorAltura = altura;
                }
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                }
            }
            Console.WriteLine($"Digite o gênero da {i + 1}ª pessoa (M/F):");
            string genero = Console.ReadLine().ToUpper();
            generos[i] = genero;
            if (genero == "M")
            {
                qtdHomens++;
            }
            else if (genero == "F")
            {
                somaAlturasMulheres += altura;
            }
             

        }
        double mediaAlturaMulheres = somaAlturasMulheres / (qtd_pessoas - qtdHomens);
        Console.WriteLine($"Menor altura: {menorAltura}");
        Console.WriteLine($"Maior altura: {maiorAltura}");
        Console.WriteLine($"Média de altura das mulheres: {mediaAlturaMulheres}");
        Console.WriteLine($"Quantidade de homens: {qtdHomens}");
    }

    public void aprovados(){
        Console.WriteLine("Quantas alunos serão digitadas?");
        int qtd_alunos = Convert.ToInt32(Console.ReadLine());
        string[] nomes = new string[qtd_alunos];
        double[] nota1 = new double[qtd_alunos];
        double[] nota2 = new double[qtd_alunos];
        double[] media = new double[qtd_alunos];
        List<string> aprovados = new List<string>();
        for (int i = 0; i < qtd_alunos; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1}ª aluno:");
            string name = Console.ReadLine();
            nomes[i] = name;
            Console.WriteLine($"Digite a primeira nota do {i + 1}ª aluno:");
            double nota01 = Convert.ToDouble(Console.ReadLine());
            nota1[i] = nota01;
            Console.WriteLine($"Digite a segunda nota do {i + 1}ª aluno:");
            double nota02 = Convert.ToDouble(Console.ReadLine());
            nota2[i] = nota02;
            media[i] = (nota1[i] + nota2[i]) / 2.0;
            if (media[i] >= 6.0)
            {
                aprovados.Add(nomes[i]);
            }
        }
        Console.WriteLine("Alunos aprovados:" + string.Join(", ", aprovados));
    }

    public void maisVelho() {
        Console.WriteLine("Quantas pessoas serão digitadas?");
        int qtd_pessoas = Convert.ToInt32(Console.ReadLine());
        string[] nomes = new string[qtd_pessoas];
        int[] idades = new int[qtd_pessoas];
        int maiorIdade = 0;
        string nomeMaisVelho = "";
        for (int i = 0; i < qtd_pessoas; i++)
        {
            Console.WriteLine($"Digite o nome da {i + 1}ª pessoa:");
            string name = Console.ReadLine();
            nomes[i] = name;
            Console.WriteLine($"Digite a idade da {i + 1}ª pessoa:");
            int idade = Convert.ToInt32(Console.ReadLine());
            idades[i] = idade;
            if (idades[i] > maiorIdade)
            {
                maiorIdade = idades[i];
                nomeMaisVelho = nomes[i];
            }
        }
        Console.WriteLine("Pessoa mais velha dessa lista é: " + nomeMaisVelho);
    }
    public void abaixoDaMedia() {
        Console.WriteLine("Quantos valores terá o vetor?");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] vet = new double[n];
        double soma = 0;
        List<double> abaixoMedia = new List<double>();
        List<double> naMedia = new List<double>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º valor:");
            vet[i] = Convert.ToDouble(Console.ReadLine());
            if (vet[i] > 9.9)
            {
                soma += vet[i];
                naMedia.Add(vet[i]);
            }
            if (vet[i] <= 10.0)
            {
                abaixoMedia.Add(vet[i]);
            }
        }
        double media = soma / naMedia.Count;

        Console.WriteLine("Média do vetor = " + string.Join(", ", media));
        Console.WriteLine("Valores abaixo da média = " + string.Join(", ", abaixoMedia));
    }

    public void somaVetores() {
        Console.WriteLine("Quantos valores vai ter cada vetor?");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] vetA = new int[n];
        int[] vetB = new int[n];
        int[] vetC = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º valor do vetor A:");
            vetA[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º valor do vetor B:");
            vetB[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            vetC[i] = vetA[i] + vetB[i];
        }
        Console.WriteLine("Vetor A: " + string.Join(", ", vetA));
        Console.WriteLine("Vetor B: " + string.Join(", ", vetB));
        Console.WriteLine("Vetor Resultante: " + string.Join(", ", vetC));
    }

    public void maiorNumero() {
        Console.WriteLine("Quantos números você vai digitar?");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] vet = new double[n];
        double maiorNumero = 0;
        int posicao = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            vet[i] = Convert.ToDouble(Console.ReadLine());
            if (vet[i] > maiorNumero)
            {
                maiorNumero = vet[i];
                posicao = i;
            }
        }
        Console.WriteLine($"Maior número: {maiorNumero}");
        Console.WriteLine("Posição do maior número:" + posicao);

    }

    public void pares() {
        Console.WriteLine("Quantos números você vai digitar?");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] vet = new int[n];
        int quatidadePares = 0;
        List<int> pares = new List<int>();

        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            vet[i] = Convert.ToInt32(Console.ReadLine());
            if (vet[i] % 2 == 0)
            {
                quatidadePares++;
                pares.Add(vet[i]);
            }
        }
        Console.WriteLine($"Quantidade de números pares: {quatidadePares}");
        Console.WriteLine("Números pares:" + string.Join(", ", pares));
    }


    public void altura() {

        Console.WriteLine("Quantas pessoas serão digitadas?");
        int qtd_pessoas = Convert.ToInt32(Console.ReadLine());
        Pessoa[] pessoas = new Pessoa[qtd_pessoas];
        double somaAlturas = 0;
        int quantidadeMenoresDe16 = 0;
        List<string> nomesMenoresDe16 = new List<string>();
        for (int i = 0; i < qtd_pessoas; i++)
        {
            Console.WriteLine($"Digite o nome da {i + 1}ª pessoa:");
            string name = Console.ReadLine();

            Console.WriteLine($"Digite a idade da {i + 1}ª pessoa:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 16)
            {
                quantidadeMenoresDe16++;
                nomesMenoresDe16.Add(name);
            }

            Console.WriteLine($"Digite a altura da {i + 1}ª pessoa:");
            double altura = Convert.ToDouble(Console.ReadLine());
            pessoas[i] = new Pessoa(name, idade, altura);
            somaAlturas += altura;

        }

        double avg_altura = somaAlturas / qtd_pessoas;
        Console.WriteLine($"Altura média: {avg_altura:F2}");
        double porcetagem = (quantidadeMenoresDe16 / (double)qtd_pessoas) * 100;
        Console.WriteLine($"Pessoas com menos de 16 anos: {porcetagem:F1}%");
        Console.WriteLine("Nomes das pessoas com menos de 16 anos: " + string.Join(", ", nomesMenoresDe16));

    }



    public void soma() {

        Console.WriteLine("Quantos números você vai digitar?");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] vet = new double[n];
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            vet[i] = Convert.ToDouble(Console.ReadLine());
            sum += vet[i];
        }
        Console.WriteLine($"Valores Digitados: " + string.Join(", ", vet));
        Console.WriteLine($"Soma: {sum}");
        double avg = sum / n;
        Console.WriteLine($"Average: {avg}");


    }
    public void negativos() {
        Console.WriteLine("Quantos números você vai digitar?");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] vet = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            vet[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Números negativos:");
        for (int i = 0; i < n; i++)
        {
            if (vet[i] < 0)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}