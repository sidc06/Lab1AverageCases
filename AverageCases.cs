///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// File Name: AverageCases.cs
/// Author Name: Siddharth Choudhury
/// Date: May 23, 2021
/// Description: A form that takes user input for daily cases for seven days of the week and shows average weekly cases.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageCases
{
    public partial class formAverageCases : Form
    {
        // Declare class-level variables.
        int currentDay = 1;
        int totalCases = 0;

        public formAverageCases()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCaseList_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This exits the application.
        /// </summary>
       
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Clears all the fields and resets the form to its default state.
        /// </summary>
       
        private void ResetClick(object sender, EventArgs e)
        {
            // Clear input and output controls
            textBoxCaseEntry.Clear();
            textBoxCaseList.Clear();
            labelOutput.Text = String.Empty;

            // Re-enable all controls which could be disabled
            textBoxCaseEntry.Enabled = true;
            buttonEnter.Enabled = true;

            // Reset the values of the class-level variables
            currentDay = 1;
            totalCases = 0;

            // Set displayed day back to default
            labelDay.Text = "Day" + currentDay;

            // Set the focus
            textBoxCaseEntry.Focus();

        }
        /// <summary>
        /// Validates and accepts the value for the number of cases entered by the user. When it is valid,  
        /// records the value and adds it to a running total. Once all the values for 7 days are entered,
        /// calculates and displays the average of those values.
        /// </summary>
        private void EnterClick(object sender, EventArgs e)
        {
            // Declare a constant representing the number of days
            const int  NumberOfDays = 7;
            // Declare a variable for storing the user's last numeric input
            int enteredCases;

            // If the contents of the textbox are a whole number...
            if (int.TryParse(textBoxCaseEntry.Text, out enteredCases))
            {
                // If the contents are within a valid range...
                if (enteredCases >= 0 && enteredCases <= int.MaxValue)
                {
                    // Increment number of cases based on user input
                    totalCases += enteredCases;
                    // Add the last entered value to large textbox
                    textBoxCaseList.Text += enteredCases + Environment.NewLine;
                    // Increment the day
                    currentDay++;

                    // If the day is greater than 7...
                    if (currentDay > NumberOfDays)
                    {
                        // Set the day equal to 7
                        currentDay = 7;

                        // Calculate average
                        double averageCases = (double)totalCases / NumberOfDays;

                        // Display the average
                        labelOutput.Text = "Average cases per day: " + Math.Round(averageCases, 2);

                        // Disable input-related controls
                        textBoxCaseEntry.Enabled = false;
                        buttonEnter.Enabled = false;
                    }

                    // Update the label that displays the current day.
                    labelDay.Text = "Day " + currentDay;

                    // Set the focus to the input textbox.
                    textBoxCaseEntry.Clear();
                    textBoxCaseEntry.Focus();
                }
                // Contents not in range. Report error.
                else
                {
                    MessageBox.Show("Your entry must be between 0 and " + int.MaxValue, "Entry Error!!!");
                    textBoxCaseEntry.SelectAll();
                    textBoxCaseEntry.Focus();
                }

             }
             // The contents are not a whole number. Report an error.
             else
              {
                  MessageBox.Show("Your entry must be a whole number.", "Entry Error!!!");
                  textBoxCaseEntry.SelectAll();
                  textBoxCaseEntry.Focus();
              }
            }

        private void formAverageCases_Load(object sender, EventArgs e)
        {

        }
    }
    }
