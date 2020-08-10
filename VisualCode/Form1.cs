using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualCode
{
    public partial class Form1 : Form
    {
        private string mode1, mode2, mode3, mode4, mode5, mode6, mode7;
        private string empty;
        private string commandElse1;
        
        public Form1()
        {
            InitializeComponent();
            print1.Enabled = false;
            button1.Enabled = false;
            Save2.Enabled = false;
            print2.Enabled = false;
            Save1.Enabled = false;
            value1.Visible = false;
            value2.Visible = false;
            ifBox1.Visible = false;
            ifBox2.Visible = false;
            print3.Enabled = false;
            Save3.Enabled = false;
            value3.Visible = false;
            ifBox3.Visible = false;
            value4.Visible = false;
            print4.Enabled = false;
            Save4.Enabled = false;
            value5.Visible = false;
            print5.Enabled = false;
            Save5.Enabled = false;
            value6.Visible = false;
            print6.Enabled = false;
            Save6.Enabled = false;
            value7.Visible = false;
            print7.Enabled = false;
            Save7.Enabled = false;

            if (!System.IO.Directory.Exists(@"C:\visualCodeCSharp"))
            {
                System.IO.Directory.CreateDirectory(@"C:\visualCodeCSharp");
            }
        }

        // USELESS STUFF ////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////

        // VC ONE ////////////////////////////////////////////
        private void commandOne_DropDownClosed(object sender, EventArgs e)
        {
            if (commandOne.SelectedIndex == 1)
            {
                print1.Enabled = true;
                print1.Text = "\"\"";
                Save1.Enabled = true;
                value1.Visible = false;
                print1.Visible = true;
                ifBox1.Visible = false;
                elseCommand1.Visible = false;
            }
            else if (commandOne.SelectedIndex == 2)
            {
                print1.Enabled = true;
                print1.Text = "Variable Name";
                Save1.Enabled = true;
                value1.Visible = false;
                print1.Visible = true;
                ifBox1.Visible = false;
                elseCommand1.Visible = false;
            }
            else if (commandOne.SelectedIndex == 3)
            {
                print1.Enabled = true;
                print1.Text = "Variable name";
                value1.Visible = true;
                value1.Text = "Value";
                Save1.Enabled = true;
                print1.Visible = true;
                ifBox1.Visible = false;
                elseCommand1.Visible = false;
            }
            else if (commandOne.SelectedIndex == 4)
            {
                print1.Visible = false;
                value1.Visible = false;
                Save1.Enabled = true;
                ifBox1.Visible = true;
                thenDoWhat1.Text = "\"\"";
                elseCommand1.Visible = false;
            }
            else if (commandOne.SelectedIndex == 5)
            {
                print1.Visible = false;
                value1.Visible = true;
                Save1.Enabled = true;
                ifBox1.Visible = false;
                elseCommand1.Visible = true;
            }
            else
            {
                print1.Enabled = false;
                Save1.Enabled = false;
                value1.Visible = false;
                print1.Text = "";
                ifBox1.Visible = false;
                elseCommand1.Visible = false;
            }
            button1.Enabled = true;
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            if (commandOne.SelectedIndex == 1)
            {
                string code1 = "Console.WriteLine(" + print1.Text + ");";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code1.txt", code1);
                
            }
            else if (commandOne.SelectedIndex == 2)
            {
                string code1 = "string " + print1.Text + " = " + "Console.ReadLine();";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code1.txt", code1);
               
            }
            else if (commandOne.SelectedIndex == 3)
            {
                string code1 = "var " + print1.Text + " = " + value1.Text + ";";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code1.txt", code1);
               
            }
            else if (commandOne.SelectedIndex == 4)
            {
                if (ifEqual1.SelectedIndex == 0)
                {
                    mode1 = " == ";
                }
                if (ifEqual1.SelectedIndex == 1)
                {
                    mode1 = " < ";
                }
                if (ifEqual1.SelectedIndex == 2)
                {
                    mode1 = " <= ";
                }
                if (ifEqual1.SelectedIndex == 3)
                {
                    mode1 = " > ";
                }
                if (ifEqual1.SelectedIndex == 4)
                {
                    mode1 = " >= ";
                }
                if (ifEqual1.SelectedIndex == 5)
                {
                    mode1 = " != ";
                }
                string code1 = "if (" + ifValue1.Text + " " + mode1 + " " + ifValueTwo1.Text + ")" + "{" + " Console.WriteLine(" + thenDoWhat1.Text + ") " + "}";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code1.txt", code1);
            }
            else if (commandOne.SelectedIndex == 5)
            {
                if (elseCommand1.SelectedIndex == 0)
                {
                    string code1 = "else { Console.WriteLine(\"" + value1.Text + "\"); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code1.txt", code1);
                }
                else if (elseCommand1.SelectedIndex == 1)
                {
                    string code1 = "else { string " + value1.Text + " = Console.ReadLine(); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code1.txt", code1);
                }
            }
        }
        private void Open1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\code1.txt");
        }
        ////////////////////////////////////////////////////////

        // VC TWO ////////////////////////////////////////////

        private void commandTwo_DropDownClosed(object sender, EventArgs e)
        {
            if (commandTwo.SelectedIndex == 1)
            {
                print2.Enabled = true;
                print2.Visible = true;
                print2.Text = "\"\"";
                Save2.Enabled = true;
                value2.Visible = false;
                ifBox2.Visible = false;
                elseCommand2.Visible = false;
            }
            else if (commandTwo.SelectedIndex == 2)
            {
                print2.Enabled = true;
                print2.Visible = true;
                print2.Visible = true;
                print2.Text = "Variable Name";
                Save2.Enabled = true;
                value2.Visible = false;
                ifBox2.Visible = false;
                elseCommand2.Visible = false;
            }
            else if (commandTwo.SelectedIndex == 3)
            {
                print2.Enabled = true;
                print2.Visible = true;
                print2.Text = "Variable name";
                value2.Visible = true;
                value2.Text = "value";
                Save2.Enabled = true;
                ifBox2.Visible = false;
                elseCommand2.Visible = false;
            }
            else if (commandTwo.SelectedIndex == 4)
            {
                print2.Visible = false;
                value2.Visible = false;
                Save2.Enabled = true;
                ifBox2.Visible = true;
                thenDoWhat2.Text = "\"\"";
                elseCommand2.Visible = false;
            }
            else if (commandTwo.SelectedIndex == 5)
            {
                print2.Visible = false;
                value2.Visible = true;
                Save2.Enabled = true;
                ifBox2.Visible = false;
                elseCommand2.Visible = true;
            }
            else
            {
                print2.Enabled = false;
                Save2.Enabled = false;
                print2.Text = "";
                value2.Visible = false;
                ifBox2.Visible = false;
                elseCommand2.Visible = false;
            }
        }

        private void save2_Click(object sender, EventArgs e)
        {
            
        }

        private void Save2_Click_1(object sender, EventArgs e)
        {
            if (commandTwo.SelectedIndex == 1)
            {
                string code2 = "Console.WriteLine(" + print2.Text + ");";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code2.txt", code2);
                
            }
            else if (commandTwo.SelectedIndex == 2)
            {
                string code2 = "string " + print2.Text + " = " + "Console.ReadLine();";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code2.txt", code2);
                
            }
            else if (commandTwo.SelectedIndex == 3)
            {
                string code2 = "var " + print2.Text + " = " + value2.Text + ";";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code2.txt", code2);
                
            }
            else if (commandTwo.SelectedIndex == 4)
            {
                if (ifEqual2.SelectedIndex == 0)
                {
                    mode2 = " == ";
                }
                if (ifEqual2.SelectedIndex == 1)
                {
                    mode2 = " < ";
                }
                if (ifEqual2.SelectedIndex == 2)
                {
                    mode2 = " <= ";
                }
                if (ifEqual2.SelectedIndex == 3)
                { 
                    mode2 = " > ";
                }
                if (ifEqual2.SelectedIndex == 4)
                {
                    mode2 = " >= ";
                }
                if (ifEqual2.SelectedIndex == 5)
                {
                    mode2 = " != ";
                }
                string code2 = "if (" + ifValue2.Text + " " + mode2 + " " + ifValueTwo2.Text + ")" + "{" + " Console.WriteLine(" + thenDoWhat2.Text + ") " + "}";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code2.txt", code2);
            }
            else if (commandTwo.SelectedIndex == 5)
            {
                if (elseCommand2.SelectedIndex == 0)
                {
                    string code = "else { Console.WriteLine(\"" + value2.Text + "\"); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code2.txt", code);
                }
                else if (elseCommand2.SelectedIndex == 1)
                {
                    string code = "else { string " + value2.Text + " = Console.ReadLine(); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code2.txt", code);
                }
            }
        }

     

        private void Open2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\code2.txt");
        }

        

        ////////////////////////////////////////////////////////

        // VC THREE////////////////////////////////////////////
        private void commandThree_DropDownClosed(object sender, EventArgs e)
        {
            if (commandThree.SelectedIndex == 1)
            {
                print3.Enabled = true;
                print3.Visible = true;
                print3.Text = "\"\"";
                Save3.Enabled = true;
                value3.Visible = false;
                ifBox3.Visible = false;
                elseCommand3.Visible = false;
            }
            else if (commandThree.SelectedIndex == 2)
            {
                print3.Enabled = true;
                print3.Visible = true;
                print3.Visible = true;
                print3.Text = "Variable Name";
                Save3.Enabled = true;
                value3.Visible = false;
                ifBox3.Visible = false;
                elseCommand3.Visible = false;
            }
            else if (commandThree.SelectedIndex == 3)
            {
                print3.Enabled = true;
                print3.Visible = true;
                print3.Text = "Variable name";
                value3.Visible = true;
                value3.Text = "value";
                Save3.Enabled = true;
                ifBox3.Visible = false;
                elseCommand3.Visible = false;
            }
            else if (commandThree.SelectedIndex == 4)
            {
                print3.Visible = false;
                value3.Visible = false;
                Save3.Enabled = true;
                ifBox3.Visible = true;
                thenDoWhat3.Text = "\"\"";
                elseCommand3.Visible = false;
            }
            else if (commandThree.SelectedIndex == 5)
            {
                print3.Visible = false;
                value3.Visible = true;
                Save3.Enabled = true;
                ifBox3.Visible = false;
                elseCommand3.Visible = true;
            }
            else
            {
                print3.Enabled = false;
                Save3.Enabled = false;
                print3.Text = "";
                value3.Visible = false;
                ifBox3.Visible = false;
                elseCommand3.Visible = false;
            }
        }

        

        private void Save3_Click(object sender, EventArgs e)
        {
            if (commandThree.SelectedIndex == 1)
            {
                string code3 = "Console.WriteLine(" + print3.Text + ");";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code3.txt", code3);

            }
            else if (commandThree.SelectedIndex == 2)
            {
                string code3 = "string " + print3.Text + " = " + "Console.ReadLine();";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code3.txt", code3);

            }
            else if (commandThree.SelectedIndex == 3)
            {
                string code3 = "var " + print3.Text + " = " + value3.Text + ";";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code3.txt", code3);

            }
            else if (commandThree.SelectedIndex == 4)
            {
                if (ifEqual3.SelectedIndex == 0)
                {
                    mode3 = " == ";
                }
                if (ifEqual3.SelectedIndex == 1)
                {
                    mode3 = " < ";
                }
                if (ifEqual3.SelectedIndex == 2)
                {
                    mode3 = " <= ";
                }
                if (ifEqual3.SelectedIndex == 3)
                {
                    mode3 = " > ";
                }
                if (ifEqual3.SelectedIndex == 4)
                {
                    mode3 = " >= ";
                }
                if (ifEqual3.SelectedIndex == 5)
                {
                    mode3 = " != ";
                }
                string code3 = "if (" + ifValue3.Text + " " + mode3 + " " + ifValueTwo3.Text + ")" + "{" + " Console.WriteLine(" + thenDoWhat3.Text + ") " + "}";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code3.txt", code3);
            }
            else if (commandThree.SelectedIndex == 5)
            {
                if (elseCommand3.SelectedIndex == 0)
                {
                    string code = "else { Console.WriteLine(\"" + value3.Text + "\"); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code3.txt", code);
                }
                else if (elseCommand3.SelectedIndex == 1)
                {
                    string code = "else { string " + value3.Text + " = Console.ReadLine(); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code3.txt", code);
                }
            }
        }

        private void Open3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\code3.txt");
        }

        ////////////////////////////////////////////////////////

        // VC FOUR/////////////////////////////////////////////
        private void commandFour_DropDownClosed(object sender, EventArgs e)
        {
            if (commandFour.SelectedIndex == 1)
            {
                print4.Enabled = true;
                print4.Visible = true;
                print4.Text = "\"\"";
                Save4.Enabled = true;
                value4.Visible = false;
                ifBox4.Visible = false;
                elseCommand4.Visible = false;
            }
            else if (commandFour.SelectedIndex == 2)
            {
                print4.Enabled = true;
                print4.Visible = true;
                print4.Visible = true;
                print4.Text = "Variable Name";
                Save4.Enabled = true;
                value4.Visible = false;
                ifBox4.Visible = false;
                elseCommand4.Visible = false;
            }
            else if (commandFour.SelectedIndex == 3)
            {
                print4.Enabled = true;
                print4.Visible = true;
                print4.Text = "Variable name";
                value4.Visible = true;
                value4.Text = "value";
                Save4.Enabled = true;
                ifBox4.Visible = false;
                elseCommand4.Visible = false;
            }
            else if (commandFour.SelectedIndex == 4)
            {
                print4.Visible = false;
                value4.Visible = false;
                Save4.Enabled = true;
                ifBox4.Visible = true;
                thenDoWhat4.Text = "\"\"";
                elseCommand4.Visible = false;
            }
            else if (commandFour.SelectedIndex == 5)
            {
                print4.Visible = false;
                value4.Visible = true;
                Save4.Enabled = true;
                ifBox4.Visible = false;
                elseCommand4.Visible = true;
            }
            else
            {
                print4.Enabled = false;
                Save4.Enabled = false;
                print4.Text = "";
                value4.Visible = false;
                ifBox4.Visible = false;
                elseCommand4.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Save 4
            if (commandFour.SelectedIndex == 1)
            {
                string code = "Console.WriteLine(" + print4.Text + ");";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code4.txt", code);

            }
            else if (commandFour.SelectedIndex == 2)
            {
                string code = "string " + print4.Text + " = " + "Console.ReadLine();";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code4.txt", code);

            }
            else if (commandFour.SelectedIndex == 3)
            {
                string code = "var " + print4.Text + " = " + value4.Text + ";";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code4.txt", code);

            }
            else if (commandFour.SelectedIndex == 4)
            {
                if (ifEqual4.SelectedIndex == 0)
                {
                    mode4 = " == ";
                }
                if (ifEqual4.SelectedIndex == 1)
                {
                    mode4 = " < ";
                }
                if (ifEqual4.SelectedIndex == 2)
                {
                    mode4 = " <= ";
                }
                if (ifEqual4.SelectedIndex == 3)
                {
                    mode4 = " > ";
                }
                if (ifEqual4.SelectedIndex == 4)
                {
                    mode4 = " >= ";
                }
                if (ifEqual4.SelectedIndex == 5)
                {
                    mode4 = " != ";
                }
                string code = "if (" + ifValue4.Text + " " + mode4 + " " + ifValueTwo4.Text + ")" + "{" + " Console.WriteLine(" + thenDoWhat4.Text + ") " + "}";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code4.txt", code);
            }
            else if (commandFour.SelectedIndex == 5)
            {
                if (elseCommand4.SelectedIndex == 0)
                {
                    string code = "else { Console.WriteLine(\"" + value4.Text + "\"); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code4.txt", code);
                }
                else if (elseCommand4.SelectedIndex == 1)
                {
                    string code = "else { string " + value4.Text + " = Console.ReadLine(); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code4.txt", code);
                }
            }

        }

        private void Open4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\code4.txt");
        }

        ////////////////////////////////////////////////////////

        // VC FIVE/////////////////////////////////////////////
        private void commandFive_DropDownClosed(object sender, EventArgs e)
        {
            if (commandFive.SelectedIndex == 1)
            {
                print5.Enabled = true;
                print5.Visible = true;
                print5.Text = "\"\"";
                Save5.Enabled = true;
                value5.Visible = false;
                ifBox5.Visible = false;
                elseCommand5.Visible = false;
            }
            else if (commandFive.SelectedIndex == 2)
            {
                print5.Enabled = true;
                print5.Visible = true;
                print5.Visible = true;
                print5.Text = "Variable Name";
                Save5.Enabled = true;
                value5.Visible = false;
                ifBox5.Visible = false;
                elseCommand5.Visible = false;
            }
            else if (commandFive.SelectedIndex == 3)
            {
                print5.Enabled = true;
                print5.Visible = true;
                print5.Text = "Variable name";
                value5.Visible = true;
                value5.Text = "value";
                Save5.Enabled = true;
                ifBox5.Visible = false;
                elseCommand5.Visible = false;
            }
            else if (commandFive.SelectedIndex == 4)
            {
                print5.Visible = false;
                value5.Visible = false;
                Save5.Enabled = true;
                ifBox5.Visible = true;
                thenDoWhat5.Text = "\"\"";
                elseCommand5.Visible = false;
            }
            else if (commandFive.SelectedIndex == 5)
            {
                print5.Visible = false;
                value5.Visible = true;
                Save5.Enabled = true;
                ifBox5.Visible = false;
                elseCommand5.Visible = true;
            }
            else
            {
                print5.Enabled = false;
                Save5.Enabled = false;
                print5.Text = "";
                value5.Visible = false;
                ifBox5.Visible = false;
                elseCommand5.Visible = false;
            }
        }

        private void Save5_Click(object sender, EventArgs e)
        {
            if (commandFive.SelectedIndex == 1)
            {
                string code = "Console.WriteLine(" + print5.Text + ");";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code5.txt", code);

            }
            else if (commandFive.SelectedIndex == 2)
            {
                string code = "string " + print5.Text + " = " + "Console.ReadLine();";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code5.txt", code);

            }
            else if (commandFive.SelectedIndex == 3)
            {
                string code = "var " + print5.Text + " = " + value5.Text + ";";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code5.txt", code);

            }
            else if (commandFive.SelectedIndex == 4)
            {
                if (ifEqual5.SelectedIndex == 0)
                {
                    mode5 = " == ";
                }
                if (ifEqual5.SelectedIndex == 1)
                {
                    mode5 = " < ";
                }
                if (ifEqual5.SelectedIndex == 2)
                {
                    mode5 = " <= ";
                }
                if (ifEqual5.SelectedIndex == 3)
                {
                    mode5 = " > ";
                }
                if (ifEqual5.SelectedIndex == 4)
                {
                    mode5 = " >= ";
                }
                if (ifEqual5.SelectedIndex == 5)
                {
                    mode5 = " != ";
                }
                string code = "if (" + ifValue5.Text + " " + mode5 + " " + ifValueTwo5.Text + ")" + "{" + " Console.WriteLine(" + thenDoWhat5.Text + ") " + "}";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code5.txt", code);
            }
            else if (commandFive.SelectedIndex == 5)
            {
                if (elseCommand5.SelectedIndex == 0)
                {
                    string code = "else { Console.WriteLine(\"" + value5.Text + "\"); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code5.txt", code);
                }
                else if (elseCommand5.SelectedIndex == 1)
                {
                    string code = "else { string " + value5.Text + " = Console.ReadLine(); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code5.txt", code);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Open5
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\code5.txt");
        }

        

        ////////////////////////////////////////////////////////

        // VC SIX/////////////////////////////////////////////
        private void commandSix_DropDownClosed(object sender, EventArgs e)
        {
            if (commandSix.SelectedIndex == 1)
            {
                print6.Enabled = true;
                print6.Visible = true;
                print6.Text = "\"\"";
                Save6.Enabled = true;
                value6.Visible = false;
                ifBox6.Visible = false;
                elseCommand6.Visible = false;
            }
            else if (commandSix.SelectedIndex == 2)
            {
                print6.Enabled = true;
                print6.Visible = true;
                print6.Visible = true;
                print6.Text = "Variable Name";
                Save6.Enabled = true;
                value6.Visible = false;
                ifBox6.Visible = false;
                elseCommand6.Visible = false;
            }
            else if (commandSix.SelectedIndex == 3)
            {
                print6.Enabled = true;
                print6.Visible = true;
                print6.Text = "Variable name";
                value6.Visible = true;
                value6.Text = "value";
                Save6.Enabled = true;
                ifBox6.Visible = false;
                elseCommand6.Visible = false;
            }
            else if (commandSix.SelectedIndex == 4)
            {
                print6.Visible = false;
                value6.Visible = false;
                Save6.Enabled = true;
                ifBox6.Visible = true;
                thenDoWhat6.Text = "\"\"";
                elseCommand6.Visible = false;
            }
            else if (commandSix.SelectedIndex == 5)
            {
                print6.Visible = false;
                value6.Visible = true;
                Save6.Enabled = true;
                ifBox6.Visible = false;
                elseCommand6.Visible = true;
            }
            else
            {
                print6.Enabled = false;
                Save6.Enabled = false;
                print6.Text = "";
                value6.Visible = false;
                ifBox6.Visible = false;
                elseCommand6.Visible = false;
            }
        }

        private void Save6_Click(object sender, EventArgs e)
        {
            if (commandSix.SelectedIndex == 1)
            {
                string code = "Console.WriteLine(" + print6.Text + ");";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code6.txt", code);

            }
            else if (commandSix.SelectedIndex == 2)
            {
                string code = "string " + print6.Text + " = " + "Console.ReadLine();";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code6.txt", code);

            }
            else if (commandSix.SelectedIndex == 3)
            {
                string code = "var " + print6.Text + " = " + value6.Text + ";";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code6.txt", code);

            }
            else if (commandSix.SelectedIndex == 4)
            {
                if (ifEqual6.SelectedIndex == 0)
                {
                    mode6 = " == ";
                }
                if (ifEqual6.SelectedIndex == 1)
                {
                    mode6 = " < ";
                }
                if (ifEqual6.SelectedIndex == 2)
                {
                    mode6 = " <= ";
                }
                if (ifEqual6.SelectedIndex == 3)
                {
                    mode6 = " > ";
                }
                if (ifEqual6.SelectedIndex == 4)
                {
                    mode6 = " >= ";
                }
                if (ifEqual6.SelectedIndex == 5)
                {
                    mode6 = " != ";
                }
                string code = "if (" + ifValue6.Text + " " + mode6 + " " + ifValueTwo6.Text + ")" + "{" + " Console.WriteLine(" + thenDoWhat6.Text + ") " + "}";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code6.txt", code);
            }
            else if (commandSix.SelectedIndex == 5)
            {
                if (elseCommand6.SelectedIndex == 0)
                {
                    string code = "else { Console.WriteLine(\"" + value6.Text + "\"); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code6.txt", code);
                }
                else if (elseCommand6.SelectedIndex == 1)
                {
                    string code = "else { string " + value6.Text + " = Console.ReadLine(); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code6.txt", code);
                }
            }
        }

        //Help Button
        private void Helpbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void elseCommand6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void elseCommand7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Open6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\code6.txt");
        }

        ////////////////////////////////////////////////////////

        // VC SEVEN/////////////////////////////////////////////
        private void commandSeven_DropDownClosed(object sender, EventArgs e)
        {
            if (commandSeven.SelectedIndex == 1)
            {
                print7.Enabled = true;
                print7.Visible = true;
                print7.Text = "\"\"";
                Save7.Enabled = true;
                value7.Visible = false;
                ifBox7.Visible = false;
                elseCommand7.Visible = false;
            }
            else if (commandSeven.SelectedIndex == 2)
            {
                print7.Enabled = true;
                print7.Visible = true;
                print7.Visible = true;
                print7.Text = "Variable Name";
                Save7.Enabled = true;
                value7.Visible = false;
                ifBox7.Visible = false;
                elseCommand7.Visible = false;
            }
            else if (commandSeven.SelectedIndex == 3)
            {
                print7.Enabled = true;
                print7.Visible = true;
                print7.Text = "Variable name";
                value7.Visible = true;
                value7.Text = "value";
                Save7.Enabled = true;
                ifBox7.Visible = false;
                elseCommand7.Visible = false;
            }
            else if (commandSeven.SelectedIndex == 4)
            {
                print7.Visible = false;
                value7.Visible = false;
                Save7.Enabled = true;
                ifBox7.Visible = true;
                thenDoWhat7.Text = "\"\"";
                elseCommand7.Visible = false;
            }
            else if (commandSeven.SelectedIndex == 5)
            {
                print7.Visible = false;
                value7.Visible = true;
                Save7.Enabled = true;
                ifBox7.Visible = false;
                elseCommand7.Visible = true;
            }
            else
            {
                print7.Enabled = false;
                Save7.Enabled = false;
                print7.Text = "";
                value7.Visible = false;
                ifBox7.Visible = false;
                elseCommand7.Visible = false;
            }
        }

        private void Save7_Click(object sender, EventArgs e)
        {
            if (commandSeven.SelectedIndex == 1)
            {
                string code = "Console.WriteLine(" + print7.Text + ");";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code7.txt", code);

            }
            else if (commandSeven.SelectedIndex == 2)
            {
                string code = "string " + print7.Text + " = " + "Console.ReadLine();";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code7.txt", code);

            }
            else if (commandSeven.SelectedIndex == 3)
            {
                string code = "var " + print7.Text + " = " + value7.Text + ";";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code7.txt", code);

            }
            else if (commandSeven.SelectedIndex == 4)
            {
                if (ifEqual7.SelectedIndex == 0)
                {
                    mode7 = " == ";
                }
                if (ifEqual7.SelectedIndex == 1)
                {
                    mode7 = " < ";
                }
                if (ifEqual7.SelectedIndex == 2)
                {
                    mode7 = " <= ";
                }
                if (ifEqual7.SelectedIndex == 3)
                {
                    mode7 = " > ";
                }
                if (ifEqual7.SelectedIndex == 4)
                {
                    mode7 = " >= ";
                }
                if (ifEqual7.SelectedIndex == 5)
                {
                    mode7 = " != ";
                }
                string code = "if (" + ifValue7.Text + " " + mode7 + " " + ifValueTwo7.Text + ")" + "{" + " Console.WriteLine(" + thenDoWhat7.Text + ") " + "}";
                System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code7.txt", code);
            }
            else if (commandSeven.SelectedIndex == 5)
            {
                if (elseCommand7.SelectedIndex == 0)
                {
                    string code = "else { Console.WriteLine(\"" + value7.Text + "\"); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code7.txt", code);
                }
                else if (elseCommand7.SelectedIndex == 1)
                {
                    string code = "else { string " + value7.Text + " = Console.ReadLine(); }";
                    System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code7.txt", code);
                }
            }
        }

        private void Open7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\code7.txt");
        }

        ////////////////////////////////////////////////////////

        // BUILDING ////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            string code1 = System.IO.File.ReadAllText(@"C:\visualCodeCSharp\code1.txt");
            string code2 = System.IO.File.ReadAllText(@"C:\visualCodeCSharp\code2.txt");
            string code3 = System.IO.File.ReadAllText(@"C:\visualCodeCSharp\code3.txt");
            string code4 = System.IO.File.ReadAllText(@"C:\visualCodeCSharp\code4.txt");
            string code5 = System.IO.File.ReadAllText(@"C:\visualCodeCSharp\code5.txt");
            string code6 = System.IO.File.ReadAllText(@"C:\visualCodeCSharp\code6.txt");
            string code7 = System.IO.File.ReadAllText(@"C:\visualCodeCSharp\code7.txt");
            string[] allCode = { code1, code2, code3, code4, code5, code6, code7 };
            System.IO.File.WriteAllLines(@"C:\visualCodeCSharp\allCode.txt", allCode);
            System.Diagnostics.Process.Start(@"C:\visualCodeCSharp\allCode.txt");
        }
        ////////////////////////////////////////////////////////
        
        //empty code files
        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code1.txt", empty);
            System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code2.txt", empty);
            System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code3.txt", empty);
            System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code4.txt", empty);
            System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code5.txt", empty);
            System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code6.txt", empty);
            System.IO.File.WriteAllText(@"C:\visualCodeCSharp\code7.txt", empty);
        }
    }
    
}
