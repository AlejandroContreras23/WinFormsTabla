namespace WinFormsTabla
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
            panelprincipal = new Panel();
            label1 = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 255, 128);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(10, 10);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(779, 430);
            panelprincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 373);
            label1.Name = "label1";
            label1.Size = new Size(335, 25);
            label1.TabIndex = 5;
            label1.Text = "Jose Alejandro Contreras Becerra 350876";
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxresultados.Location = new Point(444, 78);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(208, 294);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Location = new Point(109, 263);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(125, 37);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver Tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(109, 171);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(125, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(90, 98);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(177, 25);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cual tabla quieres?";
            labelnumero.Click += label1_Click;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(254, 26);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(287, 32);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            labeltitulo.Click += labeltitulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private Label labelnumero;
        private Button buttonver;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxresultados;
        private Label label1;
    }
}
