using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using Master_Micro_internship_task_1;

namespace Equation.Tests

{
    [TestFixture]
    public class EquationsTests
    {
        [Test]
        public void Equation_Y_Values_Testcases()
        {

            List<int> xValues = new List<int>();
            List<double> yValues = new List<double>();
            List<string> equations = new List<string>();
            StreamReader sr = new StreamReader("D:/Coding/Master Micro internship task 1/Equation.Tests/Equation Testcases.txt");
            string data = sr.ReadLine();
            while (data != null)
            {
                string[] values = data.Split(',');
                equations.Add(values[0]);
                xValues.Add(int.Parse(values[1]));
                xValues.Add(int.Parse(values[2]));
                yValues.Add(double.Parse(values[3]));
                yValues.Add(double.Parse(values[4]));
                data = sr.ReadLine();
            }
            sr.Close();
            for (int i = 0; i < equations.Count; i++)
            {
                Form1 obj = new Form1();
                obj.minimumX = xValues[i * 2];
                obj.maximumX = xValues[(i * 2) + 1];
                obj.equation = equations[i];
                bool pass = obj.validateEquation();
                obj.calculateYvalues();

                Assert.Multiple(() =>
                {
                    Assert.AreEqual(yValues[i * 2], obj.y1, "Y minimum");
                    Assert.AreEqual(yValues[(i * 2) + 1], obj.y2, "Y maximum");
                });
            }
        }
    }
}
