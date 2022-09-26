namespace _ABRAMS__CST_150_Activity_4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.timeElapsedInput = new System.Windows.Forms.TextBox();
            this.readInputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeElapsedOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the # of seconds elapsed:";
            // 
            // timeElapsedInput
            // 
            this.timeElapsedInput.Location = new System.Drawing.Point(188, 6);
            this.timeElapsedInput.Name = "timeElapsedInput";
            this.timeElapsedInput.Size = new System.Drawing.Size(193, 23);
            this.timeElapsedInput.TabIndex = 1;
            // 
            // readInputButton
            // 
            this.readInputButton.Location = new System.Drawing.Point(387, 6);
            this.readInputButton.Name = "readInputButton";
            this.readInputButton.Size = new System.Drawing.Size(75, 23);
            this.readInputButton.TabIndex = 2;
            this.readInputButton.Text = "Calculate";
            this.readInputButton.UseVisualStyleBackColor = true;
            this.readInputButton.Click += new System.EventHandler(this.readInputButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Elapsed:";
            // 
            // timeElapsedOutput
            // 
            this.timeElapsedOutput.Location = new System.Drawing.Point(188, 35);
            this.timeElapsedOutput.Name = "timeElapsedOutput";
            this.timeElapsedOutput.ReadOnly = true;
            this.timeElapsedOutput.Size = new System.Drawing.Size(193, 23);
            this.timeElapsedOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 65);
            this.Controls.Add(this.timeElapsedOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readInputButton);
            this.Controls.Add(this.timeElapsedInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "[ABRAMS] CST-150 Activity 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox timeElapsedInput;
        private Button readInputButton;
        private Label label2;
        private TextBox timeElapsedOutput;
    }
}