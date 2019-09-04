namespace Projeto01_CadastroEscolas
{
	partial class FormCadastro
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.precoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.cargaHorariamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.descricaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.codigoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.precoLabel = new System.Windows.Forms.Label();
			this.cargaHorariaLabel = new System.Windows.Forms.Label();
			this.descricaoLabel = new System.Windows.Forms.Label();
			this.codigoLabel = new System.Windows.Forms.Label();
			this.incluirCursobutton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.descricaoEscolaLabel = new System.Windows.Forms.Label();
			this.enderecoLabel = new System.Windows.Forms.Label();
			this.telefoneLabel = new System.Windows.Forms.Label();
			this.enderecoTextBox = new System.Windows.Forms.TextBox();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.incluirEscolaButton = new System.Windows.Forms.Button();
			this.escolaDataGridView = new System.Windows.Forms.DataGridView();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.escolaDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluirCursobutton);
			this.groupBox1.Controls.Add(this.precoMaskedTextBox);
			this.groupBox1.Controls.Add(this.cargaHorariamaskedTextBox);
			this.groupBox1.Controls.Add(this.descricaoMaskedTextBox);
			this.groupBox1.Controls.Add(this.codigoMaskedTextBox);
			this.groupBox1.Controls.Add(this.precoLabel);
			this.groupBox1.Controls.Add(this.cargaHorariaLabel);
			this.groupBox1.Controls.Add(this.descricaoLabel);
			this.groupBox1.Controls.Add(this.codigoLabel);
			this.groupBox1.Location = new System.Drawing.Point(12, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(236, 397);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Curso";
			// 
			// precoMaskedTextBox
			// 
			this.precoMaskedTextBox.Location = new System.Drawing.Point(93, 169);
			this.precoMaskedTextBox.Name = "precoMaskedTextBox";
			this.precoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
			this.precoMaskedTextBox.TabIndex = 6;
			// 
			// cargaHorariamaskedTextBox
			// 
			this.cargaHorariamaskedTextBox.Location = new System.Drawing.Point(93, 128);
			this.cargaHorariamaskedTextBox.Name = "cargaHorariamaskedTextBox";
			this.cargaHorariamaskedTextBox.Size = new System.Drawing.Size(100, 20);
			this.cargaHorariamaskedTextBox.TabIndex = 5;
			// 
			// descricaoMaskedTextBox
			// 
			this.descricaoMaskedTextBox.Location = new System.Drawing.Point(93, 80);
			this.descricaoMaskedTextBox.Name = "descricaoMaskedTextBox";
			this.descricaoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
			this.descricaoMaskedTextBox.TabIndex = 4;
			// 
			// codigoMaskedTextBox
			// 
			this.codigoMaskedTextBox.Location = new System.Drawing.Point(93, 35);
			this.codigoMaskedTextBox.Name = "codigoMaskedTextBox";
			this.codigoMaskedTextBox.Size = new System.Drawing.Size(41, 20);
			this.codigoMaskedTextBox.TabIndex = 1;
			// 
			// precoLabel
			// 
			this.precoLabel.AutoSize = true;
			this.precoLabel.Location = new System.Drawing.Point(7, 169);
			this.precoLabel.Name = "precoLabel";
			this.precoLabel.Size = new System.Drawing.Size(35, 13);
			this.precoLabel.TabIndex = 3;
			this.precoLabel.Text = "Preço";
			// 
			// cargaHorariaLabel
			// 
			this.cargaHorariaLabel.AutoSize = true;
			this.cargaHorariaLabel.Location = new System.Drawing.Point(7, 128);
			this.cargaHorariaLabel.Name = "cargaHorariaLabel";
			this.cargaHorariaLabel.Size = new System.Drawing.Size(72, 13);
			this.cargaHorariaLabel.TabIndex = 2;
			this.cargaHorariaLabel.Text = "Carga Horária";
			// 
			// descricaoLabel
			// 
			this.descricaoLabel.AutoSize = true;
			this.descricaoLabel.Location = new System.Drawing.Point(7, 80);
			this.descricaoLabel.Name = "descricaoLabel";
			this.descricaoLabel.Size = new System.Drawing.Size(55, 13);
			this.descricaoLabel.TabIndex = 1;
			this.descricaoLabel.Text = "Descrição";
			// 
			// codigoLabel
			// 
			this.codigoLabel.AutoSize = true;
			this.codigoLabel.Location = new System.Drawing.Point(7, 38);
			this.codigoLabel.Name = "codigoLabel";
			this.codigoLabel.Size = new System.Drawing.Size(40, 13);
			this.codigoLabel.TabIndex = 0;
			this.codigoLabel.Text = "Código";
			// 
			// incluirCursobutton
			// 
			this.incluirCursobutton.Location = new System.Drawing.Point(10, 238);
			this.incluirCursobutton.Name = "incluirCursobutton";
			this.incluirCursobutton.Size = new System.Drawing.Size(75, 23);
			this.incluirCursobutton.TabIndex = 1;
			this.incluirCursobutton.Text = "Incluir Curso";
			this.incluirCursobutton.UseVisualStyleBackColor = true;
			this.incluirCursobutton.Click += new System.EventHandler(this.incluirCursobutton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.descricaoTextBox);
			this.groupBox2.Controls.Add(this.escolaDataGridView);
			this.groupBox2.Controls.Add(this.incluirEscolaButton);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.enderecoTextBox);
			this.groupBox2.Controls.Add(this.telefoneLabel);
			this.groupBox2.Controls.Add(this.enderecoLabel);
			this.groupBox2.Controls.Add(this.descricaoEscolaLabel);
			this.groupBox2.Location = new System.Drawing.Point(364, 26);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 397);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados da Escola";
			// 
			// descricaoEscolaLabel
			// 
			this.descricaoEscolaLabel.AutoSize = true;
			this.descricaoEscolaLabel.Location = new System.Drawing.Point(18, 42);
			this.descricaoEscolaLabel.Name = "descricaoEscolaLabel";
			this.descricaoEscolaLabel.Size = new System.Drawing.Size(55, 13);
			this.descricaoEscolaLabel.TabIndex = 0;
			this.descricaoEscolaLabel.Text = "Descrição";
			// 
			// enderecoLabel
			// 
			this.enderecoLabel.AutoSize = true;
			this.enderecoLabel.Location = new System.Drawing.Point(18, 87);
			this.enderecoLabel.Name = "enderecoLabel";
			this.enderecoLabel.Size = new System.Drawing.Size(53, 13);
			this.enderecoLabel.TabIndex = 1;
			this.enderecoLabel.Text = "Endereço";
			// 
			// telefoneLabel
			// 
			this.telefoneLabel.AutoSize = true;
			this.telefoneLabel.Location = new System.Drawing.Point(18, 135);
			this.telefoneLabel.Name = "telefoneLabel";
			this.telefoneLabel.Size = new System.Drawing.Size(49, 13);
			this.telefoneLabel.TabIndex = 2;
			this.telefoneLabel.Text = "Telefone";
			// 
			// enderecoTextBox
			// 
			this.enderecoTextBox.Location = new System.Drawing.Point(120, 87);
			this.enderecoTextBox.Name = "enderecoTextBox";
			this.enderecoTextBox.Size = new System.Drawing.Size(144, 20);
			this.enderecoTextBox.TabIndex = 4;
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(120, 135);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(144, 20);
			this.telefoneTextBox.TabIndex = 5;
			// 
			// incluirEscolaButton
			// 
			this.incluirEscolaButton.Location = new System.Drawing.Point(21, 169);
			this.incluirEscolaButton.Name = "incluirEscolaButton";
			this.incluirEscolaButton.Size = new System.Drawing.Size(109, 23);
			this.incluirEscolaButton.TabIndex = 6;
			this.incluirEscolaButton.Text = "Incluir Escola";
			this.incluirEscolaButton.UseVisualStyleBackColor = true;
			this.incluirEscolaButton.Click += new System.EventHandler(this.incluirEscolaButton_Click);
			// 
			// escolaDataGridView
			// 
			this.escolaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.escolaDataGridView.Location = new System.Drawing.Point(6, 227);
			this.escolaDataGridView.Name = "escolaDataGridView";
			this.escolaDataGridView.Size = new System.Drawing.Size(268, 150);
			this.escolaDataGridView.TabIndex = 7;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(120, 38);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(144, 20);
			this.descricaoTextBox.TabIndex = 8;
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCadastro";
			this.Text = "Cadastro de Cursos e Escolas";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.escolaDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox precoMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox cargaHorariamaskedTextBox;
		private System.Windows.Forms.MaskedTextBox descricaoMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox codigoMaskedTextBox;
		private System.Windows.Forms.Label precoLabel;
		private System.Windows.Forms.Label cargaHorariaLabel;
		private System.Windows.Forms.Label descricaoLabel;
		private System.Windows.Forms.Label codigoLabel;
		private System.Windows.Forms.Button incluirCursobutton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView escolaDataGridView;
		private System.Windows.Forms.Button incluirEscolaButton;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox enderecoTextBox;
		private System.Windows.Forms.Label telefoneLabel;
		private System.Windows.Forms.Label enderecoLabel;
		private System.Windows.Forms.Label descricaoEscolaLabel;
		private System.Windows.Forms.TextBox descricaoTextBox;
	}
}

