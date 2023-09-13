namespace TablaMultiplicar
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
            textNum = new TextBox();
            label1 = new Label();
            listBoxTabla = new ListBox();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // textNum
            // 
            textNum.Location = new Point(60, 57);
            textNum.Name = "textNum";
            textNum.Size = new Size(100, 23);
            textNum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 21);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un numero";
            // 
            // listBoxTabla
            // 
            listBoxTabla.FormattingEnabled = true;
            listBoxTabla.ItemHeight = 15;
            listBoxTabla.Location = new Point(59, 106);
            listBoxTabla.Name = "listBoxTabla";
            listBoxTabla.Size = new Size(120, 94);
            listBoxTabla.TabIndex = 2;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(85, 206);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "button1";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 254);
            Controls.Add(btnProcesar);
            Controls.Add(listBoxTabla);
            Controls.Add(label1);
            Controls.Add(textNum);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNum;
        private Label label1;
        private ListBox listBoxTabla;
        private Button btnProcesar;
    }
}