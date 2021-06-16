
namespace AverageCases
{
    partial class formAverageCases
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDailyCasePrompt = new System.Windows.Forms.Label();
            this.textBoxCaseEntry = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxCaseList = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelDailyCasePrompt
            // 
            this.labelDailyCasePrompt.Location = new System.Drawing.Point(24, 24);
            this.labelDailyCasePrompt.Name = "labelDailyCasePrompt";
            this.labelDailyCasePrompt.Size = new System.Drawing.Size(100, 25);
            this.labelDailyCasePrompt.TabIndex = 0;
            this.labelDailyCasePrompt.Text = "Daily &Cases: ";
            this.labelDailyCasePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCaseEntry
            // 
            this.textBoxCaseEntry.Location = new System.Drawing.Point(122, 22);
            this.textBoxCaseEntry.Name = "textBoxCaseEntry";
            this.textBoxCaseEntry.Size = new System.Drawing.Size(119, 27);
            this.textBoxCaseEntry.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxCaseEntry, "Enter the number of confirmed cases for the current day");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(370, 27);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(100, 20);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCaseList
            // 
            this.textBoxCaseList.Location = new System.Drawing.Point(122, 67);
            this.textBoxCaseList.Multiline = true;
            this.textBoxCaseList.Name = "textBoxCaseList";
            this.textBoxCaseList.ReadOnly = true;
            this.textBoxCaseList.Size = new System.Drawing.Size(239, 236);
            this.textBoxCaseList.TabIndex = 3;
            this.textBoxCaseList.TabStop = false;
            this.toolTip.SetToolTip(this.textBoxCaseList, "Displays the number of cases for each day of this week");
            this.textBoxCaseList.TextChanged += new System.EventHandler(this.textBoxCaseList_TextChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Location = new System.Drawing.Point(18, 322);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(446, 31);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(24, 374);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to enter the daily number of cases");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(195, 374);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset the form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(376, 374);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // formAverageCases
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxCaseList);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxCaseEntry);
            this.Controls.Add(this.labelDailyCasePrompt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "formAverageCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Cases";
            this.Load += new System.EventHandler(this.formAverageCases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDailyCasePrompt;
        private System.Windows.Forms.TextBox textBoxCaseEntry;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxCaseList;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

