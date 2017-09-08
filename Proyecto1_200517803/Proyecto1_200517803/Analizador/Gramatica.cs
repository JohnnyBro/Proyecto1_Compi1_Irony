using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;


namespace Proyecto1_200517803.Analizador
{
    class Gramatica : Grammar
    {
        public Gramatica(): base(caseSensitive: true)
        {


            //Palabras Reservadas
            #region Reservadas
            MarkReservedWords("class");
            MarkReservedWords("public");
            MarkReservedWords("private");
            MarkReservedWords("protected");
            MarkReservedWords("extends");
            MarkReservedWords("int");
            MarkReservedWords("String");
            MarkReservedWords("bool");
            MarkReservedWords("double");
            MarkReservedWords("char");
            MarkReservedWords("this");
            MarkReservedWords("else");
            MarkReservedWords("if");
            MarkReservedWords("case");
            MarkReservedWords("break");
            MarkReservedWords("while");
            MarkReservedWords("do");
            MarkReservedWords("for");
            MarkReservedWords("return");
            MarkReservedWords("continue");
            MarkReservedWords("Override");
            MarkReservedWords("void");
            MarkReservedWords("switch");
            MarkReservedWords("default");
            MarkReservedWords("null");
            MarkReservedWords("new");
            #endregion

            #region Terminales
            //asignacion palabras reservadas
            var clase = ToTerm("class");
            var publica = ToTerm("public");
            var privada = ToTerm("private");
            var protegida = ToTerm("protected");
            var extendida = ToTerm("extends");
            var entero = ToTerm("int");
            var cadena = ToTerm("String");
            var boleano = ToTerm("boolean");
            var doble = ToTerm("double");
            var caracter = ToTerm("char");
            var este = ToTerm("this");
            var sino = ToTerm("else");
            var si = ToTerm("if");
            var caso = ToTerm("case");
            var romper = ToTerm("break");
            var mientras = ToTerm("while");
            var hacer = ToTerm("do");
            var por = ToTerm("for");
            var retornar = ToTerm("return");
            var continuar = ToTerm("continue");
            var anular = ToTerm("Override");
            var vacio = ToTerm("void");
            var interruptor = ToTerm("switch");
            var porDefecto = ToTerm("default");
            var nulo = ToTerm("null");
            var verdadero = ToTerm("true");
            var falso = ToTerm("false");
            var nuevo = ToTerm("new");

            //resto del alfabeto
            var principal = ToTerm("main");
            var and = ToTerm("&&");
            var or = ToTerm("||");
            var not = ToTerm("!");
            var menor = ToTerm("<");
            var mayor = ToTerm(">");
            var menorIgual = ToTerm("<=");
            var mayorIgual = ToTerm(">=");
            var igual2 = ToTerm("==");
            var diferente = ToTerm("!=");
            var suma = ToTerm("+");
            var resta = ToTerm("-");
            var multi = ToTerm("*");
            var divi = ToTerm("/");
            var apar = ToTerm("(");
            var cpar = ToTerm(")");
            var dosp = ToTerm(":");
            var pcoma = ToTerm(";");
            var punto = ToTerm(".");
            var coma = ToTerm(",");
            var acor = ToTerm("[");
            var ccor = ToTerm("]");
            var allave = ToTerm("{");
            var cllave = ToTerm("}");
            var igual = ToTerm("=");
            #endregion

            //Expresiones Regulares
            #region ER
            NumberLiteral numero = TerminalFactory.CreateCSharpNumber("numero");
            IdentifierTerminal id = TerminalFactory.CreateCSharpIdentifier("id");
            var tstring = new StringLiteral("tstring", "\"", StringOptions.AllowsDoubledQuote);
            var tchar = new StringLiteral("tchar", "'", StringOptions.AllowsDoubledQuote);
            CommentTerminal COMENTARIO_SIMPLE = new CommentTerminal("comentario_simple", "//", "\n", "\r\n");
            CommentTerminal COMENTARIO_MULT = new CommentTerminal("comentario_mult", "/*", "*/");
            NonGrammarTerminals.Add(COMENTARIO_SIMPLE);
            NonGrammarTerminals.Add(COMENTARIO_MULT);
            #endregion

            #region No terminales
            //se declaran todas las variables no terminales
            var INICIO = new NonTerminal("INICIO");
            var CUERPO= new NonTerminal("CUERPO");
            var ACCESO = new NonTerminal("ACCESO");
            var FIN_CLASE = new NonTerminal("FIN_CLASE");
            var SENTENCIAS = new NonTerminal("SENTENCIAS");
            var SENTENCIA = new NonTerminal("SENTENCIA");
            var EXP = new NonTerminal("EXP");
            var DECLARACION = new NonTerminal("DECLARACION");
            var ASIGNACION = new NonTerminal("ASIGNACION");
            var DECLARA_ASIGNA = new NonTerminal("DECLARA_ASIGNA");
            var TIPO = new NonTerminal("TIPO");
            var LISTA = new NonTerminal("LISTA");
            var PARAMETROS = new NonTerminal("PARAMETROS");
            var PARAMETROS2 = new NonTerminal("PARAMETROS2");
            var TIPOS =new NonTerminal("TIPOS");
            var TIPOS2 = new NonTerminal("TIPOS2");
            var CONSTRUCTORES = new NonTerminal("CONSTRUCTORES");
            var CONSTRUCTOR = new NonTerminal("CONSTRUCTOR");
            

           

            #endregion

            #region Gramatica
            INICIO.Rule = CUERPO;
            CUERPO.Rule = ACCESO + clase + id + FIN_CLASE
                        | clase + id + FIN_CLASE;

            ACCESO.Rule = publica
                            |privada
                            |protegida;

            FIN_CLASE.Rule = extendida + id + allave + SENTENCIAS + cllave
                            | allave + SENTENCIAS + cllave;

         

            SENTENCIAS.Rule = MakeStarRule(SENTENCIAS , SENTENCIA);


            SENTENCIA.Rule = DECLARACION
                            | DECLARA_ASIGNA
                            | ASIGNACION
                            | CONSTRUCTORES;


            DECLARACION.Rule = TIPO + LISTA + pcoma
                            | ACCESO + TIPO + LISTA + pcoma;


            DECLARA_ASIGNA.Rule = TIPO + LISTA + igual + EXP + pcoma
                                | ACCESO + TIPO + LISTA + igual + EXP + pcoma
                                | ACCESO + id + id + igual + nuevo + EXP + pcoma
                                | id + id + igual + nuevo + EXP + pcoma
                                | ACCESO + id + id + igual + nulo + pcoma
                                | id + id + igual + nulo + pcoma
                                | id + id + igual + EXP + pcoma;

            ASIGNACION.Rule = id + igual + EXP + pcoma;

            LISTA.Rule=LISTA+coma+id
                       |id;

            PARAMETROS.Rule = PARAMETROS + coma + TIPOS
                            | TIPOS;

            PARAMETROS2.Rule = PARAMETROS2 + coma + TIPOS2
                            | TIPOS2;

            TIPOS.Rule = TIPO + id
                       | TIPO + numero
                       | TIPO + tstring;

            TIPOS2.Rule = id
                        | numero
                        | tstring;


            TIPO.Rule = entero
                    | boleano
                    | caracter
                    | cadena
                    | doble;

            CONSTRUCTORES.Rule = MakeStarRule(CONSTRUCTORES, CONSTRUCTOR);

            CONSTRUCTOR.Rule = ACCESO + id + apar + cpar + allave + cllave
                             | ACCESO + id + apar + cpar + allave + SENTENCIAS + cllave
                             | id + apar + cpar + allave + cllave
                             | id + apar + cpar + allave + SENTENCIAS + cllave
                             | ACCESO + id + apar + PARAMETROS + cpar + allave + cllave
                             | ACCESO + id + apar + PARAMETROS + cpar + allave + SENTENCIAS + cllave
                             | id + apar + PARAMETROS + cpar + allave + cllave
                             | id + apar + PARAMETROS + cpar + allave + SENTENCIAS + cllave;
                             


            EXP.Rule = EXP + ToTerm("||") + EXP
                | EXP + ToTerm("&&") + EXP
                | EXP + ToTerm("==") + EXP
                | EXP + ToTerm("!=") + EXP
                | EXP + ToTerm(">") + EXP
                | EXP + ToTerm("<") + EXP
                | EXP + ToTerm(">=") + EXP
                | EXP + ToTerm("<=") + EXP
                | EXP + ToTerm("+") + EXP
                | EXP + ToTerm("-") + EXP
                | EXP + ToTerm("*") + EXP
                | EXP + ToTerm("/") + EXP
                | EXP + ToTerm(".") + EXP
                | apar + EXP + cpar
                | ToTerm("!") + EXP
                | id
                | numero
                | tstring
                | tchar
                | falso
                | verdadero
                | id + apar + PARAMETROS2 + cpar
                | id + apar + cpar;
               
            #endregion

            #region Preferencias
            this.Root = INICIO;
            #endregion
        }
    }
}
