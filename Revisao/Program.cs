using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceALuno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                
                switch(opcaoUsuario)
                {
                    case "1":
                        Console.Write("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.Write("Informe a nota: ");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        Console.WriteLine();
                        alunos[indiceALuno] = aluno;
                        indiceALuno++;
                        
                        break;
                    case "2":
                        foreach(Aluno a in alunos)
                        {   
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} Nota: {a.Nota}");
                            }
                            
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        int nrAlunos = 0;
                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        EConceito conceitoGeral;

                        if(mediaGeral < 2)
                        {
                            conceitoGeral = EConceito.E;
                        } 
                        else if(mediaGeral < 5)
                        {
                            conceitoGeral = EConceito.D;
                        }
                        else if(mediaGeral < 7)
                        {
                            conceitoGeral = EConceito.C;
                        }
                        else if(mediaGeral < 9)
                        {
                            conceitoGeral = EConceito.B;
                        } else
                        {
                            conceitoGeral = EConceito.A;
                        }

                        Console.WriteLine($"Media geral: {mediaGeral}");
                        Console.WriteLine($"Conceito nota geral: {conceitoGeral}");
                        Console.WriteLine();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Essa opcão é invalida");
                }

                opcaoUsuario = ObterOpcaoUsuario();
                Console.WriteLine();
            
            }

            
            
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Lista alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }   
    }
}
