using System;
using System.IO;
using System.Collections.Generic;

namespace atv_inicial
{
    class Aluno
    {
        public int Matricula { get; set; }
        public double Altura { get; set; }
    }

    class Usuario 
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public long Rg { get; set; }
    }

    class Pessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do{
                Console.WriteLine("Escolha a questão que deseja 1 - 10");
                op = Int32.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(op <= 10 &&  op >=1 ? "### Questão " + op + " ###": "Só existe as questões 1 até 10");
                switch (op)
                {
                    case 1 : question1(); break;
                    case 2 : question2(); break;
                    case 3 : question3(); break;
                    case 4 : question4(); break;
                    case 5 : question5(); break;
                    case 6 : question6(); break;
                    case 7 : question7(); break;
                    case 8 : question8(); break;
                    case 9 : question9(); break;
                    case 10 : question10(); break;
                    default:
                        Console.WriteLine("Opção inválida"); 
                        break;
                }

            }while(op != 0);
           
        }

        static void question1()
        {
            String valor = "";
            do
            {
                Console.WriteLine("Informe um valor: ");
                valor = Console.ReadLine();
                try
                {
                    if (Int32.Parse(valor) % 2 == 0)
                        Console.WriteLine("Número é par");
                    else
                        Console.WriteLine("Número é ímpar");
                }
                catch (Exception)
                {
                    if (!valor.Equals("Sair"))
                        Console.WriteLine("Valor inválido!!!");
                }
            } while (!valor.Equals("Sair"));
        }

        static void question2()
        {
            var invert = "";
            Console.WriteLine("Informe um nome: ");
            var nome = Console.ReadLine();
            for (int i = (nome.Length - 1); i >= 0; i--)
            {
                invert += nome[i];
            }
            Console.WriteLine("Nome Invertido: " + invert);
        }

        static void question3()
        {
            char op;
            Double v1, v2, res = 0;
            Console.WriteLine("Informe a Operação: ");
            op = Char.Parse(Console.ReadLine());

            Console.WriteLine("Informe os dois valores: ");
            v1 = Double.Parse(Console.ReadLine());
            v2 = Double.Parse(Console.ReadLine());
            switch (op)
            {
                case '+': res = v1 + v2; break;
                case '-': res = v1 + v2; break;
                case '*': res = v1 + v2; break;
                case '/':
                    if (v2 != 0)
                        res = v1 + v2;
                    else
                        Console.WriteLine("Valor ideterminado");
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            Console.WriteLine("Resposta: " + v1 + " " + op + " " + v2 + " = " + res);
        }

        static void question4()
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine(idade >= 18 ? "Permissão concedida" : "Sem Permissão");
        }

        static void question5()
        {
            Console.WriteLine("Informe o nome: ");
            Console.WriteLine(showNome(Console.ReadLine()));
        }

        static void question6()
        {
            String fraseModif = "", frase;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            foreach (var c in frase)
            {
                fraseModif += (c == 'A' || c == 'a') ? '&' : c;
            }

            Console.WriteLine("Frase modificada: " + fraseModif);
        }

        static void question7()
        {
            Console.WriteLine("Informe o salário");
            Double salario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Salário antes do ajuste: " + salario);

            salario += (salario < 1700) ? 300 : 200;

            Console.WriteLine("Salário depois do ajuste: " + salario);
        }

        static void question8() 
        {
            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            String mail = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            String fone = Console.ReadLine();
            Console.WriteLine("RG: ");
            long rg = Int64.Parse(Console.ReadLine());

            Usuario usuario = new Usuario() {Nome = nome, Email = mail, Telefone = fone, Rg = rg};
            //usando a instrução using os recursos são liberados após a conclusão da operação
            // 1: Escreve um linha para o novo arquivo
            using (StreamWriter writer = new StreamWriter("qt8.txt", false))
            {
                writer.WriteLine("Nome: " + usuario.Nome);
                writer.WriteLine("Email: " + usuario.Email);
                writer.WriteLine("Telefone: " + usuario.Telefone);
                writer.WriteLine("RG: " + usuario.Rg);
            }
            Console.Clear();
            String line;
            StreamReader reader = new StreamReader("qt8.txt");
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            reader.Close();
        }

        static void question9()
        {
            Console.WriteLine("1 - Consultar existentes \n2 - Cadastrar uma pessoa\n ");
            int op = Int32.Parse(Console.ReadLine());
            
            if(op == 1) {
                String line;
                StreamReader reader = new StreamReader("qt8.txt");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                reader.Close();
            } else if (op == 2) {
                Console.WriteLine("Nome: ");
                String nome = Console.ReadLine();
                Console.WriteLine("Idade: ");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Peso: ");
                double weight = Double.Parse(Console.ReadLine());
                Console.WriteLine("Altura: ");
                double heigth = Double.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa() { Nome = nome, Idade = age, Peso = weight, Altura = heigth };

                using (StreamWriter writer = new StreamWriter("qt8.txt", true))
                {
                    writer.WriteLine("Nome: " + pessoa.Nome);
                    writer.WriteLine("Idade: " + pessoa.Idade);
                    writer.WriteLine("Peso: " + pessoa.Peso);
                    writer.WriteLine("Altura: " + pessoa.Altura);
                    writer.WriteLine("IMC: " + imc(pessoa));
                }
            } else 
                Console.WriteLine("Opção inválida");
        }

        static void question10() 
        {
            List<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe os dados do " + (i + 1) + "º Aluno");
                Console.WriteLine("Informe sua Matricula: ");
                int mat = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Informe sua altura: ");
                double heigth = Double.Parse(Console.ReadLine());
                Aluno a = new Aluno() { Matricula = mat, Altura = heigth };
                alunos.Add(a);
                Console.Clear();
            }

            Console.WriteLine("Mátricula do menor aluno: " + menor(alunos).Matricula);
            Console.WriteLine("Mátricula do maior aluno: " + maior(alunos).Matricula + "\n");
        }

        static double imc(Pessoa p) 
        {
            return p.Peso/(Math.Pow(p.Altura, 2));
        }
        static String showNome(String nome)
        {
            return "Olá meu nome é: " + nome;
        }

        static Aluno maior(List<Aluno> alunos)
        {
            Aluno alunoMaior = new Aluno();
            foreach (var aluno in alunos)
            {
                if (aluno.Altura > alunoMaior.Altura)
                    alunoMaior = aluno;
            }
            return alunoMaior;
        }

        static Aluno menor(List<Aluno> alunos)
        {
            Aluno alunoMenor = alunos[0];
            foreach (var aluno in alunos)
            {
                if (aluno.Altura < alunoMenor.Altura)
                    alunoMenor = aluno;
            }
            return alunoMenor;
        }

    }
}
