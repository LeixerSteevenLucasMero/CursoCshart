namespace MesCombo
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
            comboMes = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textMes = new TextBox();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // comboMes
            // 
            comboMes.FormattingEnabled = true;
            comboMes.Location = new Point(41, 49);
            comboMes.Name = "comboMes";
            comboMes.Size = new Size(121, 23);
            comboMes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 86);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes Selecionado";
            // 
            // textMes
            // 
            textMes.Location = new Point(45, 113);
            textMes.Name = "textMes";
            textMes.Size = new Size(100, 23);
            textMes.TabIndex = 3;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(55, 142);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 233);
            Controls.Add(btnConsultar);
            Controls.Add(textMes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboMes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboMes;
        private Label label1;
        private Label label2;
        private TextBox textMes;
        private Button btnConsultar;
    }
}