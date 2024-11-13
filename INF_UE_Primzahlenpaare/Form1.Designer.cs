namespace INF_UE_Primzahlenpaare
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
            label1 = new Label();
            tbInput = new TextBox();
            btmStart = new Button();
            lblTextOutput = new Label();
            lbOutput = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 0;
            label1.Text = "Primzahlen suchen bis:";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(289, 30);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(200, 39);
            tbInput.TabIndex = 1;
            // 
            // btmStart
            // 
            btmStart.Location = new Point(289, 87);
            btmStart.Name = "btmStart";
            btmStart.Size = new Size(200, 60);
            btmStart.TabIndex = 2;
            btmStart.Text = "Start";
            btmStart.UseVisualStyleBackColor = true;
            btmStart.Click += btmStart_Click;
            // 
            // lblTextOutput
            // 
            lblTextOutput.AutoSize = true;
            lblTextOutput.Location = new Point(26, 219);
            lblTextOutput.Name = "lblTextOutput";
            lblTextOutput.Size = new Size(25, 32);
            lblTextOutput.TabIndex = 3;
            lblTextOutput.Text = "?";
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.ItemHeight = 32;
            lbOutput.Location = new Point(561, 12);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(418, 612);
            lbOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 635);
            Controls.Add(lbOutput);
            Controls.Add(lblTextOutput);
            Controls.Add(btmStart);
            Controls.Add(tbInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbInput;
        private Button btmStart;
        private Label lblTextOutput;
        private ListBox lbOutput;
    }
}
