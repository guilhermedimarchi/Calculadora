using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace TestesCalculadora
{
    [TestClass]
    public class TesteCalc
    {
        [TestClass]
        public class UnitTestCalculadora
        {
            private Calc calc = new Calc();
            private string caso, pos;

            // Variaveis para usar em todos os casos de teste
            private Variavel[] vars = { new Variavel() {Nome="A", Valor=1}, 
                                new Variavel() {Nome="B", Valor=2}, 
                                new Variavel() {Nome="C", Valor=3}, 
                                new Variavel() {Nome="D", Valor=4}, 
                                new Variavel() {Nome="E", Valor=5}, 
                                new Variavel() {Nome="F", Valor=6}, 
                                new Variavel() {Nome="G", Valor=7} 
                              };


            private void Init()
            {
            }

            [TestMethod]
            public void AnaliseExpressoes()
            {
                caso = "(A+B)*C)";
                Assert.AreEqual(calc.Analisar(caso), false);

                caso = "[(A+B]*C)";
                Assert.AreEqual(calc.Analisar(caso), false);

                caso = "[(A+B)*C]";
                Assert.AreEqual(calc.Analisar(caso), true);
            }

            [TestMethod]
            public void ContasSimples()
            {
                caso = "[(A+B)*C]";
                Assert.AreEqual(calc.Analisar(caso), true);
                pos = calc.Converter(caso);
                Assert.AreEqual(pos, "AB+C*");
              //  Assert.AreEqual(calc.Calcular(pos, vars), 9);

                caso = "A+B*C";
                Assert.AreEqual(calc.Analisar(caso), true);
                pos = calc.Converter(caso);
                Assert.AreEqual(pos, "ABC*+");
               // Assert.AreEqual(calc.Calcular(pos, vars), 7);

            }

            [TestMethod]
            public void ContasComplexas()
            {
                caso = "{A+[B-C*D/(A^B*C)+E]*C}";
                Assert.AreEqual(calc.Analisar(caso), true);
                pos = calc.Converter(caso);
                Assert.AreEqual(pos, "ABCD*AB^C*/-E+C*+");
                //Assert.AreEqual(calc.Calcular(pos, vars), 10);
            }


        }
    }
}
