using System;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace ModificadoresDeAcesso
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            Console.WriteLine("Hello World");
        }
        // private classe fica privada
        // , protected apenas itens filho ou seja que herda do pai consegue acessa
        // , internal 
        // e public base.  Para usar henrença
        public class Pagamento
        {   // Propriedades
            DateTime Vencimento;
            // Métodos
            void Pagar() { }
        }
        // Todas as classes são tipos complexos..
    }   
    Classes: são tipos complexos que definem objetos com propriedades e métodos. São usadas para criar objetos com comportamentos específicos e podem ser usadas como base para a criação de outras classes.

    Structs: semelhantes às classes, são tipos complexos que definem objetos com propriedades e métodos, mas com algumas diferenças em relação às classes.Por exemplo, structs são tipos de valor(ao contrário de classes, que são tipos de referência) e não suportam herança.

    Enums: são tipos complexos que definem um conjunto de valores constantes (ou constantes enumeradas) com um tipo base subjacente.São úteis para definir conjuntos de opções ou estados relacionados.

    Arrays: são tipos complexos que representam coleções de elementos do mesmo tipo. Permitem armazenar vários valores em uma única variável e acessá-los por meio de índices.
    Interfaces: são tipos complexos que definem um conjunto de métodos, propriedades e eventos que uma classe deve implementar para seguir um determinado contrato.São usadas para definir comportamentos comuns entre objetos de diferentes classes.

    Delegates: são tipos complexos que representam referências a métodos com uma assinatura específica. São usados para criar métodos genéricos que podem
}