using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Micro_internship_task_1
{
    public partial class Form1 : Form
    {
        public int minimumX, maximumX;
        public double y1, y2;
        public string equation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eqlbl2.Hide();
            eqLabel.Hide();
            minX.TextChanged += new System.EventHandler(this.validateText);
            maxX.TextChanged += new System.EventHandler(this.validateText);
            equationBox.TextChanged += new System.EventHandler(this.validateEquationText);
        }

        private void plotBtn_Click(object sender, EventArgs e)
        {
            if (validateEmptyFields())
                return;
            if (maxX.Text == "-" || minX.Text == "-")
            {
                MessageBox.Show("You need to input actual numbers in the X values fields", "X Values Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            minimumX = int.Parse(minX.Text);
            maximumX = int.Parse(maxX.Text);
            equation = equationBox.Text.ToString();
            if (validateXvalues())
                return;
            if (validateEquation())
                return;
            calculateYvalues();
            plot();
        }
        public bool validateEquation()
        {
            string allowedSymbols = "*^/+-";
            for (int i = 0; i < equation.Length; i++)
            {
                if (i < (equation.Length - 1))
                {
                    if (allowedSymbols.Contains(equation[i]) && allowedSymbols.Contains(equation[i + 1]) && equation[i + 1] != '-')
                    {
                        MessageBox.Show("Your equation has two consecutive operators!", "Equation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    if (allowedSymbols.Contains(equation[i]) && allowedSymbols.Contains(equation[i + 1]) && equation[i + 1] == equation[i])
                    {
                        MessageBox.Show("Your equation has two consecutive operators!", "Equation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    if (equation[i] == 'x' && equation[i + 1] == 'x')
                    {
                        MessageBox.Show("Your equation has two consecutive Xs!", "Equation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    if (equation[i] == 'x' && !allowedSymbols.Contains(equation[i + 1]))
                    {
                        MessageBox.Show("Your equation has a X not followed by operators!", "Equation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    if (i != 0)
                    {
                        if (equation[i] == 'x' && !allowedSymbols.Contains(equation[i - 1]))
                        {
                            MessageBox.Show("Your equation has a number not followed by operators!", "Equation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return true;
                        }
                    }
                }
                if ((i == 0 || i == (equation.Length - 1)) && allowedSymbols.Contains(equation[i]) && equation[i] != '-')
                {
                    MessageBox.Show("Your equation can't start or end with operators!", "Equation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        public void calculateYvalues()
        {
            string allowedSymbols = "*^/+-";
            string minimumEquation = "";
            string maximumEquation = "";
            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == 'x')
                {
                    if (i == 0)
                    {
                        minimumEquation = minimumX.ToString();
                        maximumEquation = maximumX.ToString();
                    }
                    else
                    {
                        minimumEquation = minimumEquation.Insert(minimumEquation.Length, minimumX.ToString());
                        maximumEquation = maximumEquation.Insert(maximumEquation.Length, maximumX.ToString());
                    }
                }
                else
                {
                    minimumEquation = minimumEquation.Insert(minimumEquation.Length, equation[i].ToString());
                    maximumEquation = maximumEquation.Insert(maximumEquation.Length, equation[i].ToString());
                }
            }

            List<double> nums1 = new List<double>();
            List<double> nums2 = new List<double>();
            List<char> ops1 = new List<char>();
            List<char> ops2 = new List<char>();
            string newNum = "";
            for (int i = 0; i < minimumEquation.Length; i++)
            {
                if (allowedSymbols.Contains(minimumEquation[i]))
                {
                    if (minimumEquation[i] == '-' && i == 0)
                    {
                        newNum += minimumEquation[i];
                        continue;
                    }
                    if (minimumEquation[i] == '-' && allowedSymbols.Contains(minimumEquation[i - 1]))
                    {
                        newNum += minimumEquation[i];
                        continue;
                    }
                    nums1.Add(double.Parse(newNum));
                    newNum = "";
                    ops1.Add(minimumEquation[i]);
                }
                else
                {
                    newNum += minimumEquation[i];
                }
            }
            nums1.Add(int.Parse(newNum));
            for (int i = 0; i < ops1.Count; i++)
            {
                if (ops1[i] == '^')
                {
                    double tempRes = Math.Pow(nums1[i], nums1[i + 1]);
                    nums1[i] = tempRes;
                    nums1.RemoveAt(i + 1);
                    ops1.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < ops1.Count; i++)
            {
                if (ops1[i] == '*')
                {
                    double tempRes = nums1[i] * nums1[i + 1];
                    nums1[i] = tempRes;
                    nums1.RemoveAt(i + 1);
                    ops1.RemoveAt(i);
                    i--;
                }
                else if (ops1[i] == '/')
                {
                    double tempRes = nums1[i] / nums1[i + 1];
                    nums1[i] = tempRes;
                    nums1.RemoveAt(i + 1);
                    ops1.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < ops1.Count; i++)
            {
                if (ops1[i] == '+')
                {
                    double tempRes = nums1[i] + nums1[i + 1];
                    nums1[i] = tempRes;
                    nums1.RemoveAt(i + 1);
                    ops1.RemoveAt(i);
                    i--;
                }
                else if (ops1[i] == '-')
                {
                    double tempRes = nums1[i] - nums1[i + 1];
                    nums1[i] = tempRes;
                    nums1.RemoveAt(i + 1);
                    ops1.RemoveAt(i);
                    i--;
                }
            }
            newNum = "";
            //MessageBox.Show("Maximum Equation: " + maximumEquation + " || Minimum Equation: " + minimumEquation);
            for (int i = 0; i < maximumEquation.Length; i++)
            {
                if (allowedSymbols.Contains(maximumEquation[i]))
                {
                    if (maximumEquation[i] == '-' && i == 0)
                    {
                        newNum += maximumEquation[i];
                        continue;
                    }
                    if (maximumEquation[i] == '-' && allowedSymbols.Contains(maximumEquation[i - 1]))
                    {
                        newNum += maximumEquation[i];
                        continue;
                    }
                    nums2.Add(double.Parse(newNum));
                    //eqLabel.Text += newNum + " || ";
                    //eqlbl2.Text += maximumEquation[i] + " || ";
                    newNum = "";
                    ops2.Add(maximumEquation[i]);
                }
                else
                {
                    newNum += maximumEquation[i];
                }
            }
            nums2.Add(int.Parse(newNum));
            for (int i = 0; i < ops2.Count; i++)
            {
                if (ops2[i] == '^')
                {
                    double tempRes = Math.Pow(nums2[i], nums2[i + 1]);
                    nums2[i] = tempRes;
                    nums2.RemoveAt(i + 1);
                    ops2.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < ops2.Count; i++)
            {
                if (ops2[i] == '*')
                {
                    double tempRes = nums2[i] * nums2[i + 1];
                    nums2[i] = tempRes;
                    nums2.RemoveAt(i + 1);
                    ops2.RemoveAt(i);
                    i--;
                }
                else if (ops2[i] == '/')
                {
                    double tempRes = nums2[i] / nums2[i + 1];
                    nums2[i] = tempRes;
                    nums2.RemoveAt(i + 1);
                    ops2.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < ops2.Count; i++)
            {
                if (ops2[i] == '+')
                {
                    double tempRes = nums2[i] + nums2[i + 1];
                    nums2[i] = tempRes;
                    nums2.RemoveAt(i + 1);
                    ops2.RemoveAt(i);
                    i--;
                }
                else if (ops2[i] == '-')
                {
                    double tempRes = nums2[i] - nums2[i + 1];
                    nums2[i] = tempRes;
                    nums2.RemoveAt(i + 1);
                    ops2.RemoveAt(i);
                    i--;
                }
            }
            y2 = nums2[0];
            y1 = nums1[0];
            eqLabel.Text = nums1[0].ToString();
            eqlbl2.Text = (nums1.Count + " || " + ops1.Count).ToString();
        }


        private bool validateEmptyFields()
        {
            if (minX.Text.ToString() == "" || maxX.Text.ToString() == "" || equationBox.Text.ToString() == "")
            {
                MessageBox.Show("You need to fill all fields first!", "Empty Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool validateXvalues()
        {

            if (minimumX == maximumX)
            {
                MessageBox.Show("The minimum and maximum values of X can't be equal!", "X Values Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (minimumX > maximumX)
            {
                MessageBox.Show("The minimum value of X can't be bigger than the maximum value of X!", "X Values Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void plot()
        {

            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add("Plot");
            this.chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(200, 200, 200);
            this.chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(200, 200, 200);
            chart.Series.Add("Equation");
            chart.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart.Series[0].Color = Color.FromArgb(0, 0, 0);
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[0].Points.AddXY(minimumX, y1);
            chart.Series[0].Points[0].Label = "(" + minimumX + "," + y1 + ")";
            chart.Series[0].Points.AddXY(maximumX, y2);
            chart.Series[0].Points[1].Label = "(" + maximumX + "," + y2 + ")";


        }



        private void validateText(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            string tempText = temp.Text.ToString();
            string allowedCharacters = "012345678910";
            for (int i = 0; i < tempText.Length; i++)
            {
                if (i != 0 && !allowedCharacters.Contains(tempText[i]))
                {
                    tempText = tempText.Remove(i, 1);
                    i--;
                }
                else if (i == 0 && tempText[i] == '-')
                {
                    continue;
                }
                else if (i == 0 && (!allowedCharacters.Contains(tempText[i]) || tempText[i] == '0'))
                {
                    tempText = tempText.Remove(i, 1);
                    i--;
                }
            }
            temp.Text = tempText;
            sender = temp;
        }

        private void validateEquationText(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            string tempText = temp.Text.ToString();
            string allowedCharacters = "012345678910x*^/+-";
            for (int i = 0; i < tempText.Length; i++)
            {
                if (!allowedCharacters.Contains(tempText[i]))
                {
                    tempText = tempText.Remove(i, 1);
                    i--;
                }

            }
            temp.Text = tempText;
            sender = temp;
        }
    }
}
