// See https://aka.ms/new-console-template for more information

using System;

/// <properties>

class Program
{
    static void Main(string[] args)
    {
        string nome = "Bruno";
        string[] array = {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"
        };

        int contador = 0;

        for (contador = 0; contador < array.Length; contador++)
        {
            Console.WriteLine(array[contador]);
        }

        // Variável do tipo byte
        byte meuByte = 127;
        Console.WriteLine("Variável byte: " + meuByte);

        //int idade; //Certo
        int idade1 = 25; //Certo
        Console.WriteLine("Variável inteira idade1: " + idade1);
        //var idade2 = 25; //Certo
        //var idade3; // Errado

        //const int IDADE_MINIMA;
        const int IDADE_MINIMA1 = 25;
        Console.WriteLine("Constante inteira IDADE_MINIMA1: " + IDADE_MINIMA1);
        //const var IDADE_MINIMA2 = 25; // Errado, pois não se usa constante com var
        //const var IDADE_MINIMA3; // Não se usa constantes com var

        //// Ctrl+K+C comentar / Crlt+K+U descomentar 



        //var texto = "Testando";
        //Console.WriteLine(texto);

        // Números inteiros

        // Tipos de números inteiros
        short sInt1 = 1; // Números pequenos
        ushort sInt2 = 2; // Números pequenos não negativos

        int int1 = 3; // Números padrão, de tamanho rasoável
        uint int2 = 4; // Números padrão não negativos

        long lInt1 = 99999999; // Números longos
        ulong lInt2 = 455468547; // Números longos não negativos

        // Números reais

        // Tipos de números reais
        float numFloat = 10.5f; // Utiliza o sufixo f
        Console.WriteLine("Número float: " + numFloat);

        double numDouble = 10.5;
        Console.WriteLine("Número double: " + numDouble); // Padrão para números flutuantes

        decimal numDecimal = 10.5m; // Utiliza o sufixo m
        Console.WriteLine("Número decimal: " + numDecimal);

        // Dados booleanos
        bool usuario = false;

        if (usuario)
        {
            Console.WriteLine("Usuário " + nome + " já está cadastrado.");
        }
        else
        {
            Console.WriteLine("Usuário " + nome + " ainda não foi cadastrado.");
        }

        // Variável char
        char letra = 'a'; // Na atribuição de variáveis char, utiliza-se sempre aspas simples, pois aramzena apenas 1 caractere.
        Console.WriteLine("Varável char/caractere único: " + letra);

        // Variável string: aramzena uma lista de char
        string palavra = "Palavra"; // Strings utilizam sempre aspas duplas, mesmo que armazenem apenas um caractere.
        Console.WriteLine("String/cadeia de caracteres: " + palavra);

        // Variável var: recebe o tipo de dado da primeira atribuição que lhe for dada. Não pode ser alterado o tipo de dado no decorrer do código.
        var varNome = "Bruno";
        var varIdade = 25;
        var varUser = true;
        var varNota = 6.5;
        var varChar = 'A';

        if (varUser && varNota >= 7)
        {
            Console.WriteLine("Aluno: " + varNome + "\n"
                               + "Idade: " + varIdade + "\n"
                               + "Nota: " + varNota + "\n"
                               + "Situaçao: Aprovado");
        }
        else if (varUser && varNota < 7 && varNota >= 3)
        {
            Console.WriteLine("Aluno: " + varNome + "\n"
                               + "Idade: " + varIdade + "\n"
                               + "Nota: " + varNota + "\n"
                               + "Situaçao: Recuperação");
        }
        else
        {
            Console.WriteLine("Aluno: " + varNome + "\n"
                               + "Idade: " + varIdade + "\n"
                               + "Nota: " + varNota + "\n"
                               + "Situaçao: Reprovado");
        }

        // Variáveis do tipo object: objeto. Podem ter seu tipo alterado no decorrer do código.
        object valor = "Nome";
        Console.WriteLine("Variável object, tendo seu valor inicial como uma string: " + valor);
        valor = 10;
        Console.WriteLine("Variável object, tendo seu valor alterado para um inteiro: " + valor);

        // Variáveis Nullable Type: variáveis nulas.
        int? num = null; // Colocar sempre ? na frente do tipo para atribuir uma variável nula.
        Console.WriteLine("Variável nula: " + num);

        // Valores padrão de de cada tipo de variável
        /*
         
        int => 0
        float => 0
        bool => false
        char => '\0'
        string => ""
         
         */

        // Conversão de dados

        // Conversão implícita
        float valFloat = 25.8f;
        Console.WriteLine("Valor float antes da conversão: " + valFloat);    
        int valInt = 25;
        valFloat = valInt;
        Console.WriteLine("Valor float após a conversão: " + valFloat);

        // Conversão explícita
        int inteiro = 100;
        Console.WriteLine("Inteiro normal: " + inteiro);
        uint uInteiro = (uint)inteiro; // Convertendo de positivo para negativo
        Console.WriteLine("Inteiro não negativo: " + uInteiro);

        // Parse: converter string para valor numérico
        string strNum1 = "100";
        string strNum2 = "50";

        int div = int.Parse(strNum1) / int.Parse(strNum2);

        Console.WriteLine("Resultado divisão: " + div);

        // Convert: Converte qualquer tipo de dado em outro tipo
        int div2 = Convert.ToInt32(strNum1) / Convert.ToInt32(strNum2);
        Console.WriteLine("Divisão com números usando classe Convert: " + div2);

        // Converter número para string
        int value = 100;
        float fValue = 25.8f;
        Console.WriteLine("Valor numérico antes da conversão para string: " + fValue.GetType() + " " + fValue);
        string valString = fValue.ToString();
        Console.WriteLine("Valor numérico convertido para string: " + valString.GetType() + " " + fValue);
        value = Convert.ToInt32(fValue);
        Console.WriteLine("Valor numérico de float para inteiro: " + value.GetType() + " " + value);
        Console.WriteLine("Valor negativo para booleano: " + Convert.ToBoolean(-255));

        // Operadores aritméticos
        int numero = 2;
        int soma = numero + numero;
        int subtracao = numero - numero;
        int multiplicacao = numero * numero;
        int divisao = numero / numero;

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);
        Console.WriteLine("Divisão: " + divisao);

        // Switch 
        switch (numero)
        {
            case 1:
                Console.WriteLine("Primeiro");
                break;

            case 2:
                Console.WriteLine("Segundo");
                break;

            case 3:
                Console.WriteLine("Terceiro");
                break;

            case 4:
                Console.WriteLine("Quarto");
                break;

            default:
                Console.WriteLine("Desclassificado");
                break;
        }

    }
}

