namespace LadybirdConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(12, 29);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(572, 136);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(12, 188);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(572, 147);
            this.tbOutput.TabIndex = 1;
            this.tbOutput.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(167, 340);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(129, 47);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output:";
            // 
            // btnConvertFolder
            // 
            this.btnConvertFolder.Location = new System.Drawing.Point(302, 340);
            this.btnConvertFolder.Name = "btnConvertFolder";
            this.btnConvertFolder.Size = new System.Drawing.Size(129, 47);
            this.btnConvertFolder.TabIndex = 5;
            this.btnConvertFolder.Text = "Convert folder...";
            this.btnConvertFolder.UseVisualStyleBackColor = true;
            this.btnConvertFolder.Click += new System.EventHandler(this.btnConvertFolder_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(597, 399);
            this.Controls.Add(this.btnConvertFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Ladybird Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvertFolder;
    }
}

