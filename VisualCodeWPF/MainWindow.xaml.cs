using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace VisualCodeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set Fullscreen content to "Fullscreen"
            FullBtn.Content = "Fullscreen";
        }

        string mainPath = @"C:\VisualProjects\";

        private string projectFolder;


        private string projectCode1, projectCode2, projectCode3, projectCode4, projectCode5, projectCode6;

        private string code1, code2, code3, code4, code5, code6;

        private void CreateProjectBtn_Click(object sender, RoutedEventArgs e)
        {
            // Creates Project Folder
            projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            Directory.CreateDirectory(projectFolder);

            // Shows Code Area
            VisualCodeBack.Visibility = Visibility.Visible;

            // Shows Code ComboBoxes
            VisualCommandGrid.Visibility = Visibility.Visible;

            // Change "VisualCode" to User's Project Name
            ProjectLabel.Content = ProjectNameTextbox.Text;

            // Enable Help, Save All, Fullscreen and Build Buttons
            HelpBtn.IsEnabled = true;
            SaveAllBtn.IsEnabled = true;
            BuildBtn.IsEnabled = true;
            FullBtn.IsEnabled = true;

        }


        // Command ComboBoxes

        private void CommandCombo1_DropDownClosed(object sender, EventArgs e)
        {
            if (CommandCombo1.SelectedIndex == 0)
            {
                //Disable all Values Boxes
                //Null
                ValueTextboxOne1.IsEnabled = false;
                ValueTextboxTwo1.IsEnabled = false;
                //Clear Text in all TextBoxes
                ValueTextboxOne1.Text = "";
                ValueTextboxTwo1.Text = "";
            }
            else if (CommandCombo1.SelectedIndex == 1)
            {
                //Disable 2nd Value Box and Enable 1st Value Box
                //Write
                ValueTextboxTwo1.IsEnabled = false;
                ValueTextboxOne1.IsEnabled = true;
                //Set ValueBox1 Text to "" and clear the 2nd
                ValueTextboxOne1.Text = "\"\"";
                ValueTextboxTwo1.Text = "";
            }
            else if (CommandCombo1.SelectedIndex == 2)
            {
                //Disable 2nd ValueBox and Enable 1st Value Box
                // Listen
                ValueTextboxTwo1.IsEnabled = false;
                ValueTextboxOne1.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Type" and Clear the 2nd
                ValueTextboxOne1.Text = "Variable Name";
                ValueTextboxTwo1.Text = "";
            }
            else if (CommandCombo1.SelectedIndex == 3)
            {
                //Enable Both Value Boxes
                //Declare Variable
                ValueTextboxOne1.IsEnabled = true;
                ValueTextboxTwo1.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Name" and the 2nd one to "Value"
                ValueTextboxOne1.Text = "Variable Name";
                ValueTextboxTwo1.Text = "Value";
            }
            else
            {
                // Else enable both
                ValueTextboxOne1.IsEnabled = true;
                ValueTextboxTwo1.IsEnabled = true;
            }
        }

        private void CommandCombo3_DropDownClosed(object sender, EventArgs e)
        {
            if (CommandCombo3.SelectedIndex == 0)
            {
                //Disable all Values Boxes
                //Null
                ValueTextboxOne3.IsEnabled = false;
                ValueTextboxTwo3.IsEnabled = false;
                //Clear Text in all TextBoxes
                ValueTextboxOne3.Text = "";
                ValueTextboxTwo3.Text = "";
            }
            else if (CommandCombo3.SelectedIndex == 1)
            {
                //Disable 2nd Value Box and Enable 1st Value Box
                //Write
                ValueTextboxTwo3.IsEnabled = false;
                ValueTextboxOne3.IsEnabled = true;
                //Set ValueBox1 Text to "" and clear the 2nd
                ValueTextboxOne3.Text = "\"\"";
                ValueTextboxTwo3.Text = "";
            }
            else if (CommandCombo3.SelectedIndex == 2)
            {
                //Disable 2nd ValueBox and Enable 1st Value Box
                // Listen
                ValueTextboxTwo3.IsEnabled = false;
                ValueTextboxOne3.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Type" and Clear the 2nd
                ValueTextboxOne3.Text = "Variable Name";
                ValueTextboxTwo3.Text = "";
            }
            else if (CommandCombo3.SelectedIndex == 3)
            {
                //Enable Both Value Boxes
                //Declare Variable
                ValueTextboxOne3.IsEnabled = true;
                ValueTextboxTwo3.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Name" and the 2nd one to "Value"
                ValueTextboxOne3.Text = "Variable Name";
                ValueTextboxTwo3.Text = "Value";
            }
            else
            {
                // Else enable both
                ValueTextboxOne3.IsEnabled = true;
                ValueTextboxTwo3.IsEnabled = true;
            }
        }

        private void CommandCombo2_DropDownClosed(object sender, EventArgs e)
        {
            if (CommandCombo2.SelectedIndex == 0)
            {
                //Disable all Values Boxes
                //Null
                ValueTextboxOne2.IsEnabled = false;
                ValueTextboxTwo2.IsEnabled = false;
                //Clear Text in all TextBoxes
                ValueTextboxOne2.Text = "";
                ValueTextboxTwo2.Text = "";
            }
            else if (CommandCombo2.SelectedIndex == 1)
            {
                //Disable 2nd Value Box and Enable 1st Value Box
                //Write
                ValueTextboxTwo2.IsEnabled = false;
                ValueTextboxOne2.IsEnabled = true;
                //Set ValueBox1 Text to "" and clear the 2nd
                ValueTextboxOne2.Text = "\"\"";
                ValueTextboxTwo2.Text = "";
            }
            else if (CommandCombo2.SelectedIndex == 2)
            {
                //Disable 2nd ValueBox and Enable 1st Value Box
                // Listen
                ValueTextboxTwo2.IsEnabled = false;
                ValueTextboxOne2.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Type" and Clear the 2nd
                ValueTextboxOne2.Text = "Variable Name";
                ValueTextboxTwo2.Text = "";
            }
            else if (CommandCombo2.SelectedIndex == 3)
            {
                //Enable Both Value Boxes
                //Declare Variable
                ValueTextboxOne2.IsEnabled = true;
                ValueTextboxTwo2.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Name" and the 2nd one to "Value"
                ValueTextboxOne2.Text = "Variable Name";
                ValueTextboxTwo2.Text = "Value";
            }
            else
            {
                // Else enable both
                ValueTextboxOne2.IsEnabled = true;
                ValueTextboxTwo2.IsEnabled = true;
            }
        }

        private void CommandCombo4_DropDownClosed(object sender, EventArgs e)
        {
                if (CommandCombo4.SelectedIndex == 0)
                {
                    //Disable all Values Boxes
                    //Null
                    ValueTextboxOne4.IsEnabled = false;
                    ValueTextboxTwo4.IsEnabled = false;
                    //Clear Text in all TextBoxes
                    ValueTextboxOne4.Text = "";
                    ValueTextboxTwo4.Text = "";
                }
                else if (CommandCombo4.SelectedIndex == 1)
                {
                    //Disable 2nd Value Box and Enable 1st Value Box
                    //Write
                    ValueTextboxTwo4.IsEnabled = false;
                    ValueTextboxOne4.IsEnabled = true;
                    //Set ValueBox1 Text to "" and clear the 2nd
                    ValueTextboxOne4.Text = "\"\"";
                    ValueTextboxTwo4.Text = "";
                }
                else if (CommandCombo4.SelectedIndex == 2)
                {
                    //Disable 2nd ValueBox and Enable 1st Value Box
                    // Listen
                    ValueTextboxTwo4.IsEnabled = false;
                    ValueTextboxOne4.IsEnabled = true;
                    //Set ValueBox1 Text to "Variable Type" and Clear the 2nd
                    ValueTextboxOne4.Text = "Variable Name";
                    ValueTextboxTwo4.Text = "";
                }
                else if (CommandCombo2.SelectedIndex == 3)
                {
                    //Enable Both Value Boxes
                    //Declare Variable
                    ValueTextboxOne4.IsEnabled = true;
                    ValueTextboxTwo4.IsEnabled = true;
                    //Set ValueBox1 Text to "Variable Name" and the 2nd one to "Value"
                    ValueTextboxOne4.Text = "Variable Name";
                    ValueTextboxTwo4.Text = "Value";
                }
                else
                {
                    // Else enable both
                    ValueTextboxOne4.IsEnabled = true;
                    ValueTextboxTwo4.IsEnabled = true;
                }
        }

        private void CommandCombo5_DropDownClosed(object sender, EventArgs e)
        {
            if (CommandCombo5.SelectedIndex == 0)
            {
                //Disable all Values Boxes
                //Null
                ValueTextboxOne5.IsEnabled = false;
                ValueTextboxTwo5.IsEnabled = false;
                //Clear Text in all TextBoxes
                ValueTextboxOne5.Text = "";
                ValueTextboxTwo5.Text = "";
            }
            else if (CommandCombo5.SelectedIndex == 1)
            {
                //Disable 2nd Value Box and Enable 1st Value Box
                //Write
                ValueTextboxTwo5.IsEnabled = false;
                ValueTextboxOne5.IsEnabled = true;
                //Set ValueBox1 Text to "" and clear the 2nd
                ValueTextboxOne5.Text = "\"\"";
                ValueTextboxTwo5.Text = "";
            }
            else if (CommandCombo5.SelectedIndex == 2)
            {
                //Disable 2nd ValueBox and Enable 1st Value Box
                // Listen
                ValueTextboxTwo5.IsEnabled = false;
                ValueTextboxOne5.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Type" and Clear the 2nd
                ValueTextboxOne5.Text = "Variable Name";
                ValueTextboxTwo5.Text = "";
            }
            else if (CommandCombo5.SelectedIndex == 3)
            {
                //Enable Both Value Boxes
                //Declare Variable
                ValueTextboxOne5.IsEnabled = true;
                ValueTextboxTwo5.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Name" and the 2nd one to "Value"
                ValueTextboxOne5.Text = "Variable Name";
                ValueTextboxTwo5.Text = "Value";
            }
            else
            {
                // Else enable both
                ValueTextboxOne5.IsEnabled = true;
                ValueTextboxTwo5.IsEnabled = true;
            }
        }

        private void CommandCombo6_DropDownClosed(object sender, EventArgs e)
        {
            if (CommandCombo6.SelectedIndex == 0)
            {
                //Disable all Values Boxes
                //Null
                ValueTextboxOne6.IsEnabled = false;
                ValueTextboxTwo6.IsEnabled = false;
                //Clear Text in all TextBoxes
                ValueTextboxOne6.Text = "";
                ValueTextboxTwo6.Text = "";
            }
            else if (CommandCombo6.SelectedIndex == 1)
            {
                //Disable 2nd Value Box and Enable 1st Value Box
                //Write
                ValueTextboxTwo6.IsEnabled = false;
                ValueTextboxOne6.IsEnabled = true;
                //Set ValueBox1 Text to "" and clear the 2nd
                ValueTextboxOne6.Text = "\"\"";
                ValueTextboxTwo6.Text = "";
            }
            else if (CommandCombo6.SelectedIndex == 2)
            {
                //Disable 2nd ValueBox and Enable 1st Value Box
                // Listen
                ValueTextboxTwo6.IsEnabled = false;
                ValueTextboxOne6.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Type" and Clear the 2nd
                ValueTextboxOne6.Text = "Variable Name";
                ValueTextboxTwo6.Text = "";
            }
            else if (CommandCombo5.SelectedIndex == 3)
            {
                //Enable Both Value Boxes
                //Declare Variable
                ValueTextboxOne6.IsEnabled = true;
                ValueTextboxTwo6.IsEnabled = true;
                //Set ValueBox1 Text to "Variable Name" and the 2nd one to "Value"
                ValueTextboxOne6.Text = "Variable Name";
                ValueTextboxTwo6.Text = "Value";
            }
            else
            {
                // Else enable both
                ValueTextboxOne6.IsEnabled = true;
                ValueTextboxTwo6.IsEnabled = true;
            }
        }



        // Saving
        private void SaveAllBtn_Click(object sender, RoutedEventArgs e)
        {
            // Save 1
            if (CommandCombo1.SelectedIndex == 1)
            {
                // If Write Selected
                string code = "Console.WriteLine(" + ValueTextboxOne1.Text + ");";

                // Being Saved to code1.txt
                string fileName = "code1.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode1 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo1.SelectedIndex == 2)
            {
                // If Listen Selected
                string code = "string " + ValueTextboxOne1.Text + " = Console.ReadLine();";

                // Being Saved to code1.txt
                string fileName = "code1.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode1 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo1.SelectedIndex == 3)
            {
                // If Declare Variable Selected
                string code = "string " + ValueTextboxOne1.Text + " = " + ValueTextboxTwo1.Text + ";";

                // Being Saved to code1.txt
                string fileName = "code1.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode1 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }


            // Save 2
            if (CommandCombo2.SelectedIndex == 1)
            {
                // If Write Selected
                string code = "Console.WriteLine(" + ValueTextboxOne2.Text + ");";

                // Being Saved to code2.txt
                string fileName = "code2.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode2 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo2.SelectedIndex == 2)
            {
                // If Listen Selected
                string code = "string " + ValueTextboxOne2.Text + " = Console.ReadLine();";

                // Being Saved to code2.txt
                string fileName = "code2.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode2 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo2.SelectedIndex == 3)
            {
                // If Declare Variable Selected
                string code = "string " + ValueTextboxOne2.Text + " = " + ValueTextboxTwo2.Text + ";";

                // Being Saved to code2.txt
                string fileName = "code2.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode2 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }



            // Save 3
            if (CommandCombo3.SelectedIndex == 1)
            {
                // If Write Selected
                string code = "Console.WriteLine(" + ValueTextboxOne3.Text + ");";

                // Being Saved to code3.txt
                string fileName = "code3.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode3 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo3.SelectedIndex == 2)
            {
                // If Listen Selected
                string code = "string " + ValueTextboxOne3.Text + " = Console.ReadLine();";

                // Being Saved to code3.txt
                string fileName = "code3.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode3 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo3.SelectedIndex == 3)
            {
                // If Declare Variable Selected
                string code = "string " + ValueTextboxOne3.Text + " = " + ValueTextboxTwo3.Text + ";";

                // Being Saved to code3.txt
                string fileName = "code3.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode3 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }


            // Save 4
            if (CommandCombo4.SelectedIndex == 1)
            {
                // If Write Selected
                string code = "Console.WriteLine(" + ValueTextboxOne4.Text + ");";

                // Being Saved to code4.txt
                string fileName = "code4.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode4 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo4.SelectedIndex == 2)
            {
                // If Listen Selected
                string code = "string " + ValueTextboxOne4.Text + " = Console.ReadLine();";

                // Being Saved to code4.txt
                string fileName = "code4.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode4 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo4.SelectedIndex == 3)
            {
                // If Declare Variable Selected
                string code = "string " + ValueTextboxOne4.Text + " = " + ValueTextboxTwo4.Text + ";";

                // Being Saved to code4.txt
                string fileName = "code4.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode4 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }


            // Save 5
            if (CommandCombo5.SelectedIndex == 1)
            {
                // If Write Selected
                string code = "Console.WriteLine(" + ValueTextboxOne5.Text + ");";

                // Being Saved to code5.txt
                string fileName = "code5.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode5 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo5.SelectedIndex == 2)
            {
                // If Listen Selected
                string code = "string " + ValueTextboxOne5.Text + " = Console.ReadLine();";

                // Being Saved to code5.txt
                string fileName = "code5.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode5 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo5.SelectedIndex == 3)
            {
                // If Declare Variable Selected
                string code = "string " + ValueTextboxOne5.Text + " = " + ValueTextboxTwo5.Text + ";";

                // Being Saved to code5.txt
                string fileName = "code5.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode5 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }


            // Save 6
            if (CommandCombo6.SelectedIndex == 1)
            {
                // If Write Selected
                string code = "Console.WriteLine(" + ValueTextboxOne6.Text + ");";

                // Being Saved to code6.txt
                string fileName = "code6.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode6 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo6.SelectedIndex == 2)
            {
                // If Listen Selected
                string code = "string " + ValueTextboxOne6.Text + " = Console.ReadLine();";

                // Being Saved to code6.txt
                string fileName = "code6.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode6 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }

            else if (CommandCombo6.SelectedIndex == 3)
            {
                // If Declare Variable Selected
                string code = "string " + ValueTextboxOne6.Text + " = " + ValueTextboxTwo6.Text + ";";

                // Being Saved to code6.txt
                string fileName = "code6.txt";

                // Write code to file
                projectFolder = System.IO.Path.Combine(projectFolder, fileName);
                System.IO.File.WriteAllText(projectFolder, code);

                // Save path for building
                projectCode6 = projectFolder;

                // Reset projectFolder for Re-use
                projectFolder = System.IO.Path.Combine(mainPath, ProjectNameTextbox.Text);
            }
        }


        // Building
        private void BuildBtn_Click(object sender, RoutedEventArgs e)
        {
            // Read Files and see if paths = null
            if (projectCode1 != null)
            {
                code1 = System.IO.File.ReadAllText(projectCode1);
            }
            if (projectCode2 != null)
            {
                code2 = System.IO.File.ReadAllText(projectCode2);
            }
            if (projectCode3 != null)
            {
                code3 = System.IO.File.ReadAllText(projectCode3);
            }
            if (projectCode4 != null)
            {
                code4 = System.IO.File.ReadAllText(projectCode4);
            }
            if (projectCode5 != null)
            {
                code5 = System.IO.File.ReadAllText(projectCode5);
            }
            if (projectCode6 != null)
            {
                code6 = System.IO.File.ReadAllText(projectCode6);
            }
            
            // Cram all code into single file
            string[] allCode = { code1, code2, code3, code4, code5, code6 };
            string fileName = "allcode.txt";
            string path = System.IO.Path.Combine(projectFolder, fileName);
            System.IO.File.WriteAllLines(path, allCode);

            // Show it to user!
            System.Diagnostics.Process.Start(path);
        }

        // Fullscreen button
        private void FullBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FullBtn.Content == "Fullscreen")
            {
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.None;
                FullBtn.Content = "Windowed";
            }
            else
            {
                WindowState = WindowState.Normal;
                WindowStyle = WindowStyle.SingleBorderWindow;
                FullBtn.Content = "Fullscreen";
            }
            
        }

        // Help button
        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
