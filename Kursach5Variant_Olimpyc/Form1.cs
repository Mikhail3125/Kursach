using Kursach5Variant_Olimpyc.Utility;
using Kursach5Variant_Olympyc.Model.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach5Variant_Olimpyc
{
    public partial class Form1 : Form
    {
        private int registrationID = 0;
        private readonly WinterOlimpic WinterOlimpic;
        public Form1()
        {
            InitializeComponent();
            WinterOlimpic = new WinterOlimpic();
        }

        private void saveToDBButton_Click(object sender, EventArgs e)
        {
            string errorField = null;
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text)
                || string.IsNullOrEmpty(patronymicTextBox.Text) || string.IsNullOrEmpty(countryTextBox.Text)
                || string.IsNullOrEmpty(competitionTextBox.Text) || string.IsNullOrEmpty(placeTextBox.Text))
            {
                MessageBox.Show("Not all text boxes were filled");
            }
            else if (Correct.CorrectName(firstNameTextBox.Text, out errorField) || Correct.CorrectName(lastNameTextBox.Text, out errorField)
                || Correct.CorrectName(patronymicTextBox.Text, out errorField) || Correct.CorrectCountry(countryTextBox.Text, out errorField)
                || Correct.CorrectCompetition(competitionTextBox.Text, out errorField) || Correct.CorrectOlimpicPlace(placeTextBox.Text, out errorField))
            {
                MessageBox.Show($"Not correct {errorField}", "Validation Error");
            }
            else
            {
                registrationID++;
                RegistrationDataView.Rows.Add(registrationID, firstNameTextBox.Text, lastNameTextBox.Text, patronymicTextBox.Text,
                    countryTextBox.Text, competitionTextBox.Text, placeTextBox.Text);

                EditDataView.Rows.Add(registrationID, firstNameTextBox.Text, lastNameTextBox.Text, patronymicTextBox.Text,
                    countryTextBox.Text, competitionTextBox.Text, placeTextBox.Text);

                WinterOlimpic.Sporstmens.Add(new Sporstman
                {
                    Registration_ID = registrationID,
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Patronymic = patronymicTextBox.Text,
                    Country = countryTextBox.Text,
                    TypeOfCompetition = competitionTextBox.Text,
                    Place = int.Parse(placeTextBox.Text)
                });
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Winter Olimpic inforamtion base", "About");
        }

        private void EditSaveChangesButton_Click(object sender, EventArgs e)
        {
            string editString = null;
            for (int i = 0; i < registrationID; i++)
            {
                bool result = true;
                string[] str = new string[7];
                for (int j = 1; j < RegistrationDataView.ColumnCount; j++)
                {
                    /*Каждый иф проверяет одну из 7 ячеек на итерации, если проверки типа CorrectName не выполняется то происходит 
                     вызов бокса сообщений, и так для кажого поля в таблице пока не введешь правильно значения*/

                    if ((j == 1 || j == 2 || j == 3) && Correct.CorrectName(EditDataView.Rows[i].Cells[j].Value.ToString(), out editString))
                    {
                        result = false;
                        MessageBox.Show($"Invalid {editString}", "Edit Info");
                    }

                    if (j == 4 && Correct.CorrectCountry(EditDataView.Rows[i].Cells[j].Value.ToString(), out editString))
                    {
                        result = false;
                        MessageBox.Show($"Invalid {editString}", "Edit Info");
                    }

                    if (j == 5 && Correct.CorrectCompetition(EditDataView.Rows[i].Cells[j].Value.ToString(), out editString))
                    {
                        result = false;
                        MessageBox.Show($"Invalid {editString}", "Edit Info");
                    }

                    if (j == 6 && Correct.CorrectOlimpicPlace(EditDataView.Rows[i].Cells[j].Value.ToString(), out editString))
                    {
                        result = false;
                        MessageBox.Show($"Invalid {editString}", "Edit Info");
                    }
                    str[j] = EditDataView.Rows[i].Cells[j].Value.ToString();

                    if (result)
                    {
                        for (int k = 1; k < 7; k++)
                        {
                            RegistrationDataView.Rows[i].Cells[k].Value = str[k];
                        }
                        WinterOlimpic.Sporstmens.ElementAt(i).FirstName = EditDataView.Rows[i].Cells[1].Value.ToString();
                        WinterOlimpic.Sporstmens.ElementAt(i).LastName = EditDataView.Rows[i].Cells[2].Value.ToString();
                        WinterOlimpic.Sporstmens.ElementAt(i).Patronymic = EditDataView.Rows[i].Cells[3].Value.ToString();
                        WinterOlimpic.Sporstmens.ElementAt(i).Country = EditDataView.Rows[i].Cells[4].Value.ToString();
                        WinterOlimpic.Sporstmens.ElementAt(i).TypeOfCompetition = EditDataView.Rows[i].Cells[5].Value.ToString();
                        WinterOlimpic.Sporstmens.ElementAt(i).Place = Convert.ToInt32(EditDataView.Rows[i].Cells[6].Value.ToString());
                    }
                }
            }
        }

        private void sportSearchButton_Click(object sender, EventArgs e)
        {
            searchDataView.Rows.Clear();
            if (!String.IsNullOrWhiteSpace(searchSportTextBox.Text))
            {
                int count = 0;
                for (int i = 0; i < registrationID; i++)
                {
                    if (searchSportTextBox.Text == WinterOlimpic.Sporstmens.ElementAt(i).TypeOfCompetition)
                    {
                        count++;
                        searchDataView.Rows.Add(count,
                            WinterOlimpic.Sporstmens.ElementAt(i).FirstName,
                            WinterOlimpic.Sporstmens.ElementAt(i).LastName,
                            WinterOlimpic.Sporstmens.ElementAt(i).Patronymic,
                            WinterOlimpic.Sporstmens.ElementAt(i).Country,
                            WinterOlimpic.Sporstmens.ElementAt(i).TypeOfCompetition,
                            WinterOlimpic.Sporstmens.ElementAt(i).Place);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }
            else
            {
                MessageBox.Show("Invalid box");
            }
        }

        private void infoAboutPlacesButton_Click(object sender, EventArgs e)
        {
            searchDataView.Rows.Clear();
            int first = 0;
            int second = 0;
            int third = 0;
            List<Sporstman> winners = new List<Sporstman>();

            if (!String.IsNullOrWhiteSpace(countrySearchTextBox.Text))
            {
                WinterOlimpic.GetInformationAboutPlacesEveryCountry(countrySearchTextBox.Text, out first, out second, out third, out winners);
                MessageBox.Show($"Country {countrySearchTextBox.Text} has:{Environment.NewLine}First places -{first}{Environment.NewLine}Second places - {second}" +
                    $"{Environment.NewLine}Third places - {third}", "Places Information");
                for (int i = 0; i < winners.Count; i++)
                {
                    searchDataView.Rows.Add(winners.ElementAt(i).Registration_ID,
                    winners.ElementAt(i).FirstName,
                    winners.ElementAt(i).LastName,
                    winners.ElementAt(i).Patronymic,
                    winners.ElementAt(i).Country,
                    winners.ElementAt(i).TypeOfCompetition,
                    winners.ElementAt(i).Place);
                }
            }
            else
            {
                MessageBox.Show("Write Country name!", "Country Exception");
            }

        }

        private void removeSearchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(removeSearchTextBox.Text))
            {
                for (int i = 0; i < WinterOlimpic.Sporstmens.Count; i++)
                {
                    if (removeSearchTextBox.Text == WinterOlimpic.Sporstmens.ElementAt(i).LastName)
                    {
                        if (WinterOlimpic.Sporstmens.Count(item => item.LastName == removeSearchTextBox.Text) > 1)
                        {
                            MessageBox.Show("Error, two or more similar sporstman. Check Edit Data View", "Count sporstman exception");
                            return;
                        }
                        else
                        {
                            if (doppingSearchCheckBox.Checked == true)
                            {
                                WinterOlimpic.Sporstmens.RemoveAt(i);
                                EditDataView.Rows.RemoveAt(i);
                                RegistrationDataView.Rows.RemoveAt(i);
                            }
                            else
                            {
                                MessageBox.Show("Can't delete. This sportsman didn't use doping", "Doping Eception");
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This sportsman doesn't exist", "Exist exception");
                    }
                }
            }
            else
            {
                MessageBox.Show("Input sportsman name", "Name Exception");
            }
        }

        private void saveToFiletxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TextWriter writer = new StreamWriter(File.Create($@"C:\Users\{SystemInformation.UserName}\Desktop\info.txt"), Encoding.Default))
            {
                try
                {
                    if (RegistrationDataView.Rows.Count - 1 != 0)
                    {
                        for (int i = 0; i < RegistrationDataView.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < RegistrationDataView.Columns.Count; j++)
                            {
                                if (j == 7)
                                    writer.Write(RegistrationDataView.Rows[i].Cells[j].Value.ToString() + '\n');
                                else
                                    writer.Write(RegistrationDataView.Rows[i].Cells[j].Value.ToString() + '\t');
                            }
                        }
                        MessageBox.Show("Info cashed");
                    }
                    else
                    {
                        MessageBox.Show("Need more info");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    writer.Close();
                }
            }
        }

        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TextReader text = new StreamReader(File.OpenRead($@"C:\Users\{SystemInformation.UserName}\Desktop\info.txt"), Encoding.Default))
            {
                try
                {
                    var str = text.ReadLine();
                    if (str.Length != 0)
                    {
                        foreach (var item in str.Replace('\t', '\n'))
                        {
                            InfoFromFileRichTextBoxTaabIndex.Text += item.ToString();
                        }
                        MessageBox.Show("Information has been added");
                    }
                    else
                    {
                        MessageBox.Show("Empty file");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    text.Close();
                }
            }
        }

        private void InfoFromFileRichTextBoxTaabIndex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}