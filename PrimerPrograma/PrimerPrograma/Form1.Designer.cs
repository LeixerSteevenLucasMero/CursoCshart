namespace PrimerPrograma
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
            btnVerMensaje = new Button();
            txtNota1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            SuspendLayout();
            // 
            // btnVerMensaje
            // 
            btnVerMensaje.Location = new Point(89, 191);
            btnVerMensaje.Name = "btnVerMensaje";
            btnVerMensaje.Size = new Size(102, 27);
            btnVerMensaje.TabIndex = 0;
            btnVerMensaje.Text = "Ver Mensaje";
            btnVerMensaje.UseVisualStyleBackColor = true;
            btnVerMensaje.Click += btnVerMensaje_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(24, 44);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(249, 23);
            txtNota1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 134);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota 3";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(25, 98);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(249, 23);
            txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(24, 152);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(249, 23);
            txtNota3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 230);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNota1);
            Controls.Add(btnVerMensaje);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerMensaje;
        private TextBox txtNota1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNota2;
        private TextBox txtNota3;
    }
}