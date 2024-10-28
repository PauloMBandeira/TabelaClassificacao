using System;
using System.Globalization;

//Criação das classes de cada time, onde é definido os atributos do objeto da classe
public class Time1
{
    public string Nome { get; set; }
    public int Pontos { get; set; }
    public int Vitorias { get; set; }

    //Cria o metodo que irá mostrar as informações/atributos de cada clube/time
    public void MostraTime1()

    {
        Console.WriteLine($" O {Nome} Possui {Pontos} pontos e esta com {Vitorias} vitorias no campeonato gaucho");
    }
}

public class Time2
{
    public string Nome { get; set; }
    public int Pontos { get; set; }
    public int Vitorias { get; set; }
    public void MostraTime2()
    {
        Console.WriteLine($" O {Nome} Possui {Pontos} pontos e esta com {Vitorias} vitorias no campeonato gaucho");
    }

}

public class Time3
{
    public string Nome { get; set; }
    public int Pontos { get; set; }
    public int Vitorias { get; set; }
    public void MostraTime3()
    {
        Console.WriteLine($" O {Nome} Possui {Pontos} pontos e esta com {Vitorias} vitorias no campeonato gaucho");
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto para cada classe/Time1,2,3...
        Time1 Inter = new Time1();
        Time2 Grebbbio = new Time2();
        Time3 Juventude = new Time3();

        // Definindo valores dos atributos de cada objeto/Clube
        Inter.Nome = "S.C.Internacional";
        Inter.Pontos = 27;
        Inter.Vitorias = 1;

        Grebbbio.Nome = "Grebbbio";
        Grebbbio.Pontos = 27;
        Grebbbio.Vitorias = 1;

        Juventude.Nome = "Juventude";
        Juventude.Pontos = 27;
        Juventude.Vitorias = 1;

        // Chamando o método criado para mostrar as informacoes de cada clube/time
        Inter.MostraTime1();
        Grebbbio.MostraTime2();
        Juventude.MostraTime3();

        //Identifica o primeiro colocado criterio desempate por pontos

        //TESTE INTER
        if (Inter.Pontos > Grebbbio.Pontos && Inter.Pontos > Juventude.Pontos)

        {
            string primeiro = Inter.Nome;
            int pontuacao = Inter.Pontos;
            int vitorias = Inter.Vitorias;

            Console.WriteLine($"|1°|{primeiro}|{pontuacao}|{vitorias}|");
        }

        //TESTE GREMIO
        else if (Grebbbio.Pontos > Inter.Pontos && Grebbbio.Pontos > Juventude.Pontos)
        {
            string primeiro = Grebbbio.Nome;
            int pontuacao = Grebbbio.Pontos;
            int vitorias = Grebbbio.Vitorias;

            Console.WriteLine($"|1°|{primeiro}|{pontuacao}|{vitorias}|");
        }

        //TESTE JUVENTUDE
        else if (Juventude.Pontos > Inter.Pontos && Juventude.Pontos > Grebbbio.Pontos)
        {
            string primeiro = Juventude.Nome;
            int pontuacao = Juventude.Pontos;
            int vitorias = Juventude.Vitorias;

            Console.WriteLine($"|1°|{primeiro}|{pontuacao}|{vitorias}|");
        }



        //Identifica o primeiro colocado criterio desempate por Vitorias

        //TESTA INTER PRIMEIRO
        else if (Inter.Pontos == Grebbbio.Pontos && Inter.Pontos == Juventude.Pontos)
        {
            if (Inter.Vitorias > Grebbbio.Vitorias && Inter.Vitorias > Juventude.Vitorias)

            {
                string primeiro = Inter.Nome;
                int pontuacao = Inter.Pontos;
                int vitorias = Inter.Vitorias;

                Console.WriteLine($"|1°|{primeiro}|{pontuacao}|{vitorias}|");
            }
            //TESTE GREMIO 
            else if (Grebbbio.Pontos == Inter.Pontos && Grebbbio.Pontos == Juventude.Pontos)
            {
                if (Grebbbio.Vitorias > Inter.Vitorias && Grebbbio.Vitorias > Juventude.Vitorias)

                {
                    string primeiro = Grebbbio.Nome;
                    int pontuacao = Grebbbio.Pontos;
                    int vitorias = Grebbbio.Vitorias;

                    Console.WriteLine($"|1°|{primeiro}|{pontuacao}|{vitorias}|");
                }

            }

            else if (Juventude.Pontos == Inter.Pontos && Juventude.Pontos == Grebbbio.Pontos)
            {
                if (Juventude.Vitorias > Inter.Vitorias && Juventude.Vitorias > Grebbbio.Vitorias)

                {
                    string primeiro = Juventude.Nome;
                    int pontuacao = Juventude.Pontos;
                    int vitorias = Juventude.Vitorias;

                    Console.WriteLine($"|1°|{primeiro}|{pontuacao}|{vitorias}|");
                }

            }
            //TESTE JUVENTUDE PRIMEIRO


            //else
            //{
            //    Console.WriteLine("ocorreu empate por vitorias Int");
            //} //ESTA ACABANDO O FLUXo AQUI MESMO TODOS ESTANDO COM MESMOS PONTOS E VITORIAS A MAIS QUE O INTER


        }
   

     } //Encerra void Main

    }//Encerra toda public class

    



    


