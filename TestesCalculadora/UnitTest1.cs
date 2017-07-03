using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace TesteCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        private Calc calc = new Calc();
        private string caso, pos;

        // Variaveis para usar em todos os casos de teste
        private Variavel[] vars = new Variavel[7];

        private void InitVars()
        {
            vars[0] = new Variavel() { Nome = "A", Valor = 1 };
            vars[1] = new Variavel() { Nome = "B", Valor = 2 };
            vars[2] = new Variavel() { Nome = "C", Valor = 3 };
            vars[3] = new Variavel() { Nome = "D", Valor = 4 };
            vars[4] = new Variavel() { Nome = "E", Valor = 5 };
            vars[5] = new Variavel() { Nome = "F", Valor = 6 };
            vars[6] = new Variavel() { Nome = "G", Valor = 7 };
        }

        #region Testes da Prova

        /// <summary>
        /// Operador Troca: Crie na calculadora o operador de troca (&). 
        /// Basicamente, ele troca o valor de duas variáveis, retornando sempre o valor 1.
        /// Este operador só pode ser aplicando entre duas variáveis, nunca entre uma variável e uma expressão.
        /// </summary>
        [TestMethod]
        public void P2_OperadorTroca()
        {
            InitVars();
            caso = "A&B+A";
            pos = calc.Converter(caso);
            Assert.AreEqual(3, calc.Calcular(pos, vars));

            InitVars();
            caso = "A&B+B";
            pos = calc.Converter(caso);
            Assert.AreEqual(2, calc.Calcular(pos, vars));
        }
        [TestMethod]
        public void P3_OperadorTrocaNinja()
        {
            InitVars();
            caso = "A*C+B*D+A&B+A*C+B*D";
            pos = calc.Converter(caso);
            Assert.AreEqual(22, calc.Calcular(pos, vars));

            InitVars();
            caso = "A*C+B*D+A+A*C+B*D";
            pos = calc.Converter(caso);
            Assert.AreEqual(23, calc.Calcular(pos, vars));
        }
        /// <summary>
        /// Operador Repetir: Crie na calculadora o operador de repetição (@). 
        /// Basicamente, ele repete a última operação do escopo realizada N vezes, onde N é o operando, acumulando os resultados. 
        /// (A+B)@N repetiria a operação A+B N vezes, acumulando os resultados.  
        /// </summary>
        [TestMethod]
        public void P2_OperadorRepetir()
        {
            InitVars();
            caso = "(A+B*C)@D";
            pos = calc.Converter(caso);
            Assert.AreEqual(28, calc.Calcular(pos, vars));
        }
        [TestMethod]
        public void P3_OperadorRepetirNinja()
        {
            InitVars();
            caso = "(A*C+B*D+A&B)@C+(A*C+B*D)";
            pos = calc.Converter(caso);
            Assert.AreEqual(46, calc.Calcular(pos, vars));
        }

        #endregion

        #region Testes Padrão

        [TestMethod]
        public void AnaliseExpressoes()
        {
            caso = "(A+B)*C)";
            Assert.AreEqual(calc.Analisar(caso), false);

            caso = "[(A+B]*C)";
            Assert.AreEqual(calc.Analisar(caso), false);
        }

        [TestMethod]
        public void ContasSimples()
        {
            InitVars();
            caso = "[(A+B)*C]";
            Assert.AreEqual(calc.Analisar(caso), true);
            pos = calc.Converter(caso);
            Assert.AreEqual(pos, "AB+C*");
            Assert.AreEqual(calc.Calcular(pos, vars), 9);

            InitVars();
            caso = "A+B*C";
            Assert.AreEqual(calc.Analisar(caso), true);
            pos = calc.Converter(caso);
            Assert.AreEqual(pos, "ABC*+");
            Assert.AreEqual(calc.Calcular(pos, vars), 7);

        }

        [TestMethod]
        public void ContasComplexas()
        {
            InitVars();
            caso = "{A+[B-C*D/(A^B*C)+E]*C}";
            Assert.AreEqual(calc.Analisar(caso), true);
            pos = calc.Converter(caso);
            Assert.AreEqual(pos, "ABCD*AB^C*/-E+C*+");
            Assert.AreEqual(calc.Calcular(pos, vars), 10);
        }

        #endregion
    }
}