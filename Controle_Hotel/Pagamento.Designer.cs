namespace Controle_Hotel
{
    partial class Pagamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_codigoQuarto = new System.Windows.Forms.Label();
            this.lbl_codeQuartoOcupado = new System.Windows.Forms.Label();
            this.lbl_codigoCliente = new System.Windows.Forms.Label();
            this.lbl_valorServiços = new System.Windows.Forms.Label();
            this.lbl_precoQuarto = new System.Windows.Forms.Label();
            this.lbl_quantidadeDias = new System.Windows.Forms.Label();
            this.txt_codigoQuarto = new System.Windows.Forms.TextBox();
            this.txt_codigoCliente = new System.Windows.Forms.TextBox();
            this.txt_codeQuartoOcupado = new System.Windows.Forms.TextBox();
            this.txt_preçoQuarto = new System.Windows.Forms.TextBox();
            this.txt_valorServiços = new System.Windows.Forms.TextBox();
            this.txt_quantidadeDias = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codeQuartoOcupado);
            this.groupBox1.Controls.Add(this.txt_codigoCliente);
            this.groupBox1.Controls.Add(this.txt_codigoQuarto);
            this.groupBox1.Controls.Add(this.lbl_codigoCliente);
            this.groupBox1.Controls.Add(this.lbl_codeQuartoOcupado);
            this.groupBox1.Controls.Add(this.lbl_codigoQuarto);
            this.groupBox1.Location = new System.Drawing.Point(49, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_preçoQuarto);
            this.groupBox2.Controls.Add(this.txt_valorServiços);
            this.groupBox2.Controls.Add(this.lbl_precoQuarto);
            this.groupBox2.Controls.Add(this.txt_quantidadeDias);
            this.groupBox2.Controls.Add(this.lbl_valorServiços);
            this.groupBox2.Controls.Add(this.lbl_quantidadeDias);
            this.groupBox2.Location = new System.Drawing.Point(49, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento";
            // 
            // lbl_codigoQuarto
            // 
            this.lbl_codigoQuarto.AutoSize = true;
            this.lbl_codigoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoQuarto.Location = new System.Drawing.Point(45, 62);
            this.lbl_codigoQuarto.Name = "lbl_codigoQuarto";
            this.lbl_codigoQuarto.Size = new System.Drawing.Size(117, 16);
            this.lbl_codigoQuarto.TabIndex = 0;
            this.lbl_codigoQuarto.Text = "Código do Quarto:";
            // 
            // lbl_codeQuartoOcupado
            // 
            this.lbl_codeQuartoOcupado.AutoSize = true;
            this.lbl_codeQuartoOcupado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codeQuartoOcupado.Location = new System.Drawing.Point(45, 109);
            this.lbl_codeQuartoOcupado.Name = "lbl_codeQuartoOcupado";
            this.lbl_codeQuartoOcupado.Size = new System.Drawing.Size(176, 16);
            this.lbl_codeQuartoOcupado.TabIndex = 1;
            this.lbl_codeQuartoOcupado.Text = "Código do Quarto Ocupado:";
            // 
            // lbl_codigoCliente
            // 
            this.lbl_codigoCliente.AutoSize = true;
            this.lbl_codigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoCliente.Location = new System.Drawing.Point(45, 153);
            this.lbl_codigoCliente.Name = "lbl_codigoCliente";
            this.lbl_codigoCliente.Size = new System.Drawing.Size(118, 16);
            this.lbl_codigoCliente.TabIndex = 2;
            this.lbl_codigoCliente.Text = "Código do Cliente:";
            // 
            // lbl_valorServiços
            // 
            this.lbl_valorServiços.AutoSize = true;
            this.lbl_valorServiços.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorServiços.Location = new System.Drawing.Point(45, 154);
            this.lbl_valorServiços.Name = "lbl_valorServiços";
            this.lbl_valorServiços.Size = new System.Drawing.Size(125, 16);
            this.lbl_valorServiços.TabIndex = 6;
            this.lbl_valorServiços.Text = "Valor dos Serviços:";
            // 
            // lbl_precoQuarto
            // 
            this.lbl_precoQuarto.AutoSize = true;
            this.lbl_precoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precoQuarto.Location = new System.Drawing.Point(45, 110);
            this.lbl_precoQuarto.Name = "lbl_precoQuarto";
            this.lbl_precoQuarto.Size = new System.Drawing.Size(109, 16);
            this.lbl_precoQuarto.TabIndex = 5;
            this.lbl_precoQuarto.Text = "Preço do Quarto:";
            // 
            // lbl_quantidadeDias
            // 
            this.lbl_quantidadeDias.AutoSize = true;
            this.lbl_quantidadeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidadeDias.Location = new System.Drawing.Point(45, 63);
            this.lbl_quantidadeDias.Name = "lbl_quantidadeDias";
            this.lbl_quantidadeDias.Size = new System.Drawing.Size(131, 16);
            this.lbl_quantidadeDias.TabIndex = 4;
            this.lbl_quantidadeDias.Text = "Quantidade de Dias:";
            // 
            // txt_codigoQuarto
            // 
            this.txt_codigoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoQuarto.Location = new System.Drawing.Point(240, 62);
            this.txt_codigoQuarto.Name = "txt_codigoQuarto";
            this.txt_codigoQuarto.Size = new System.Drawing.Size(100, 21);
            this.txt_codigoQuarto.TabIndex = 4;
            // 
            // txt_codigoCliente
            // 
            this.txt_codigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoCliente.Location = new System.Drawing.Point(240, 153);
            this.txt_codigoCliente.Name = "txt_codigoCliente";
            this.txt_codigoCliente.Size = new System.Drawing.Size(100, 21);
            this.txt_codigoCliente.TabIndex = 5;
            // 
            // txt_codeQuartoOcupado
            // 
            this.txt_codeQuartoOcupado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeQuartoOcupado.Location = new System.Drawing.Point(240, 109);
            this.txt_codeQuartoOcupado.Name = "txt_codeQuartoOcupado";
            this.txt_codeQuartoOcupado.Size = new System.Drawing.Size(100, 21);
            this.txt_codeQuartoOcupado.TabIndex = 7;
            // 
            // txt_preçoQuarto
            // 
            this.txt_preçoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preçoQuarto.Location = new System.Drawing.Point(240, 110);
            this.txt_preçoQuarto.Name = "txt_preçoQuarto";
            this.txt_preçoQuarto.Size = new System.Drawing.Size(100, 21);
            this.txt_preçoQuarto.TabIndex = 11;
            // 
            // txt_valorServiços
            // 
            this.txt_valorServiços.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorServiços.Location = new System.Drawing.Point(240, 154);
            this.txt_valorServiços.Name = "txt_valorServiços";
            this.txt_valorServiços.Size = new System.Drawing.Size(100, 21);
            this.txt_valorServiços.TabIndex = 9;
            // 
            // txt_quantidadeDias
            // 
            this.txt_quantidadeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidadeDias.Location = new System.Drawing.Point(240, 63);
            this.txt_quantidadeDias.Name = "txt_quantidadeDias";
            this.txt_quantidadeDias.Size = new System.Drawing.Size(100, 21);
            this.txt_quantidadeDias.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 299);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_voltar);
            this.groupBox3.Controls.Add(this.btn_sair);
            this.groupBox3.Controls.Add(this.btn_limpar);
            this.groupBox3.Controls.Add(this.btn_verificar);
            this.groupBox3.Controls.Add(this.btn_deletar);
            this.groupBox3.Controls.Add(this.btn_alterar);
            this.groupBox3.Controls.Add(this.btn_cadastrar);
            this.groupBox3.Location = new System.Drawing.Point(537, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 169);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opções";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(382, 87);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 6;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(295, 103);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(55, 103);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(171, 103);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar.TabIndex = 3;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(295, 38);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 2;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(171, 38);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(59, 38);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_codeQuartoOcupado;
        private System.Windows.Forms.TextBox txt_codigoCliente;
        private System.Windows.Forms.TextBox txt_codigoQuarto;
        private System.Windows.Forms.Label lbl_codigoCliente;
        private System.Windows.Forms.Label lbl_codeQuartoOcupado;
        private System.Windows.Forms.Label lbl_codigoQuarto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_preçoQuarto;
        private System.Windows.Forms.TextBox txt_valorServiços;
        private System.Windows.Forms.Label lbl_precoQuarto;
        private System.Windows.Forms.TextBox txt_quantidadeDias;
        private System.Windows.Forms.Label lbl_valorServiços;
        private System.Windows.Forms.Label lbl_quantidadeDias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}