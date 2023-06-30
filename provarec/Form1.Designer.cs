namespace provarec
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
            tx_name = new TextBox();
            tx_cpf = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cb_profissao = new ComboBox();
            tx_datadenasc = new TextBox();
            tx_inicioprof = new TextBox();
            label7 = new Label();
            cb_genero = new ComboBox();
            tx_confirmar = new Button();
            tx_cancelar = new Button();
            lb_confirm = new Label();
            SuspendLayout();
            // 
            // tx_name
            // 
            tx_name.Location = new Point(156, 117);
            tx_name.Name = "tx_name";
            tx_name.Size = new Size(365, 23);
            tx_name.TabIndex = 0;
            // 
            // tx_cpf
            // 
            tx_cpf.Location = new Point(156, 146);
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(180, 23);
            tx_cpf.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 125);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 216);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 154);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 246);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 5;
            label4.Text = "Data de nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 187);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 6;
            label5.Text = "Profissão:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 277);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 7;
            label6.Text = "Inicio da profissão:";
            // 
            // cb_profissao
            // 
            cb_profissao.FormattingEnabled = true;
            cb_profissao.Items.AddRange(new object[] { "Saúde", "Professor", "Agente de segurança", "Outra profissão" });
            cb_profissao.Location = new Point(156, 179);
            cb_profissao.Name = "cb_profissao";
            cb_profissao.Size = new Size(180, 23);
            cb_profissao.TabIndex = 8;
            // 
            // tx_datadenasc
            // 
            tx_datadenasc.Location = new Point(205, 237);
            tx_datadenasc.Name = "tx_datadenasc";
            tx_datadenasc.Size = new Size(180, 23);
            tx_datadenasc.TabIndex = 10;
            // 
            // tx_inicioprof
            // 
            tx_inicioprof.Location = new Point(205, 269);
            tx_inicioprof.Name = "tx_inicioprof";
            tx_inicioprof.Size = new Size(180, 23);
            tx_inicioprof.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Frank Ruhl Hofshi", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(327, 34);
            label7.Name = "label7";
            label7.Size = new Size(167, 31);
            label7.TabIndex = 12;
            label7.Text = "Aposentadoria";
            // 
            // cb_genero
            // 
            cb_genero.FormattingEnabled = true;
            cb_genero.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cb_genero.Location = new Point(156, 213);
            cb_genero.Name = "cb_genero";
            cb_genero.Size = new Size(180, 23);
            cb_genero.TabIndex = 13;
            // 
            // tx_confirmar
            // 
            tx_confirmar.Location = new Point(252, 355);
            tx_confirmar.Name = "tx_confirmar";
            tx_confirmar.Size = new Size(75, 23);
            tx_confirmar.TabIndex = 14;
            tx_confirmar.Text = "Confirmar";
            tx_confirmar.UseVisualStyleBackColor = true;
            tx_confirmar.Click += button1_Click;
            // 
            // tx_cancelar
            // 
            tx_cancelar.Location = new Point(419, 355);
            tx_cancelar.Name = "tx_cancelar";
            tx_cancelar.Size = new Size(75, 23);
            tx_cancelar.TabIndex = 15;
            tx_cancelar.Text = "Cancelar";
            tx_cancelar.UseVisualStyleBackColor = true;
            // 
            // lb_confirm
            // 
            lb_confirm.AutoSize = true;
            lb_confirm.Location = new Point(327, 400);
            lb_confirm.Name = "lb_confirm";
            lb_confirm.Size = new Size(151, 15);
            lb_confirm.TabIndex = 16;
            lb_confirm.Text = "quantidade de pontos é de:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_confirm);
            Controls.Add(tx_cancelar);
            Controls.Add(tx_confirmar);
            Controls.Add(cb_genero);
            Controls.Add(label7);
            Controls.Add(tx_inicioprof);
            Controls.Add(tx_datadenasc);
            Controls.Add(cb_profissao);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_cpf);
            Controls.Add(tx_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_name;
        private MaskedTextBox tx_cpf;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cb_profissao;
        private TextBox tx_datadenasc;
        private TextBox tx_inicioprof;
        private Label label7;
        private ComboBox cb_genero;
        private Button tx_confirmar;
        private Button tx_cancelar;
        private Label lb_confirm;
    }
}