namespace boas_vinda
{
    partial class form1
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
            lblNome = new Label();
            txtNome = new TextBox();
            btnSaudacao = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.ControlText;
            lblNome.Location = new Point(53, 36);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(131, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Digite seu Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(140, 23);
            txtNome.TabIndex = 1;
            // 
            // btnSaudacao
            // 
            btnSaudacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaudacao.ForeColor = SystemColors.MenuHighlight;
            btnSaudacao.Location = new Point(200, 84);
            btnSaudacao.Name = "btnSaudacao";
            btnSaudacao.Size = new Size(118, 28);
            btnSaudacao.TabIndex = 2;
            btnSaudacao.Text = "Exibir Saudação";
            btnSaudacao.UseVisualStyleBackColor = true;
            btnSaudacao.Click += btnSaudacao_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaudacao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "form1";
            Text = "Boas Vindas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button btnSaudacao;
    }
}
