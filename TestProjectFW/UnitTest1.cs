using Cursed;
using NUnit.Framework;
using System.Collections.Generic;
namespace TestProjectFW
{
    public class Tests
    {
        FW FloydW = new FW();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double[,] arraytest = new double[3, 3] { { 99999, 2, 7 }, { 2, 99999, 3 }, { 7, 3, 99999 } };
            double[,] arrayFW = FloydW.FloydWarshall(3, arraytest);
            double[,] arrayTrue = new double[3, 3] { { 4, 2, 5 }, { 2, 4, 3 }, { 5, 3, 6 } };
            string lineFW = "";
            string lineTrue = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineFW = lineFW + arrayFW[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineTrue = lineTrue + arrayTrue[i, j];
                }
            }
            Assert.Pass(lineFW, lineTrue);

        }
        [Test]
        public void Test2()
        {
            double[,] arraytest = new double[3, 3] { { 99999, 2, 7 }, { 2, 99999, 3 }, { 7, 3, 99999 } };
            string[,] arrayFW = FloydW.FloydWarshallWay(3, arraytest);
            string[,] arrayTrue = new string[3, 3] { { "2->1", "2", "2->3" }, { "1", "1->2", "3" }, { "2->1", "2", "2->3" } };
            string lineFW = "";
            string lineTrue = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineFW = lineFW + arrayFW[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineTrue = lineTrue + arrayTrue[i, j];
                }
            }
            Assert.Pass(lineFW, lineTrue);
        }
        [Test]
        public void Test3()
        {
            double[,] arraytest = new double[3, 3] { { 99999, 99999, 99999 }, { 99999, 99999, 3 }, { 99999, 3, 99999 } };
            string[,] arrayFW = FloydW.FloydWarshallWay(3, arraytest);
            string[,] arrayTrue = new string[3, 3] { { "Пути между точками нет", "Пути между точками нет", "Пути между точками нет" },
                                                   { "Пути между точками нет", "3->2", "3" },
                                                   { "Пути между точками нет", "2", "2->3" }};
            string lineFW = "";
            string lineTrue = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineFW = lineFW + arrayFW[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineTrue = lineTrue + arrayTrue[i, j];
                }
            }
            Assert.Pass(lineFW, lineTrue);
        }
        [Test]
        public void Test4()
        {
            double[,] arraytest = new double[3, 3] { { 99999, 99999, 99999 }, { 99999, 99999, 3 }, { 99999, 3, 99999 } };
            double[,] arrayFW = FloydW.FloydWarshall(3, arraytest);
            double[,] arrayTrue = new double[3, 3] { { 99999, 99999, 99999 }, { 99999, 6, 3 }, { 99999, 3, 6 } };
            string lineFW = "";
            string lineTrue = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineFW = lineFW + arrayFW[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lineTrue = lineTrue + arrayTrue[i, j];
                }
            }
            Assert.Pass(lineFW, lineTrue);
        }
    }
}