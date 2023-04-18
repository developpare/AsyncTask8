namespace AsyncTask8_Example1
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
            buttonOperazionePesante = new Button();
            progressBarOperazionePesante = new ProgressBar();
            labelCaption = new Label();
            LabelOperation = new Label();
            labelMessage = new Label();
            buttonTest1 = new Button();
            SuspendLayout();
            // 
            // buttonOperazionePesante
            // 
            buttonOperazionePesante.Location = new Point(30, 30);
            buttonOperazionePesante.Name = "buttonOperazionePesante";
            buttonOperazionePesante.Size = new Size(235, 23);
            buttonOperazionePesante.TabIndex = 0;
            buttonOperazionePesante.Text = "Operazione Pesante Start";
            buttonOperazionePesante.UseVisualStyleBackColor = true;
            buttonOperazionePesante.Click += buttonOperazionePesante_Click;
            // 
            // progressBarOperazionePesante
            // 
            progressBarOperazionePesante.Location = new Point(33, 76);
            progressBarOperazionePesante.Name = "progressBarOperazionePesante";
            progressBarOperazionePesante.Size = new Size(755, 23);
            progressBarOperazionePesante.TabIndex = 1;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Location = new Point(33, 176);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(67, 15);
            labelCaption.TabIndex = 2;
            labelCaption.Text = "Operazione";
            // 
            // LabelOperation
            // 
            LabelOperation.AutoSize = true;
            LabelOperation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelOperation.ForeColor = Color.Red;
            LabelOperation.Location = new Point(183, 176);
            LabelOperation.Name = "LabelOperation";
            LabelOperation.Size = new Size(15, 15);
            LabelOperation.TabIndex = 3;
            LabelOperation.Text = "[]";
            // 
            // labelMessage
            // 
            labelMessage.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            labelMessage.Location = new Point(32, 319);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(735, 103);
            labelMessage.TabIndex = 4;
            labelMessage.Text = "[]";
            // 
            // buttonTest1
            // 
            buttonTest1.Location = new Point(36, 112);
            buttonTest1.Name = "buttonTest1";
            buttonTest1.Size = new Size(75, 23);
            buttonTest1.TabIndex = 5;
            buttonTest1.Text = "Test1";
            buttonTest1.UseVisualStyleBackColor = true;
            buttonTest1.Click += buttonTest1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTest1);
            Controls.Add(labelMessage);
            Controls.Add(LabelOperation);
            Controls.Add(labelCaption);
            Controls.Add(progressBarOperazionePesante);
            Controls.Add(buttonOperazionePesante);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOperazionePesante;
        private ProgressBar progressBarOperazionePesante;
        private Label labelCaption;
        private Label LabelOperation;
        private Label labelMessage;
        private Button buttonTest1;
    }
}