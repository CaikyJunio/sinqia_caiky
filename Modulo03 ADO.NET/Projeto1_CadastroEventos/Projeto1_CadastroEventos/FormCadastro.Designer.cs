namespace Projeto1_CadastroEventos
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
			this.incluireventoButton = new System.Windows.Forms.Button();
			this.precoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.responsavelMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.descricaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.convidadosdataGridView = new System.Windows.Forms.DataGridView();
			this.buscarconvidadosButton = new System.Windows.Forms.Button();
			this.incluirConvidadoButton = new System.Windows.Forms.Button();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.telefoneLabel = new System.Windows.Forms.Label();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.nomeLabel = new System.Windows.Forms.Label();
			this.cpfTextBox = new System.Windows.Forms.TextBox();
			this.cpfLabel = new System.Windows.Forms.Label();
			this.EventocomboBox = new System.Windows.Forms.ComboBox();
			this.Eventolabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluireventoButton);
			this.groupBox1.Controls.Add(this.precoMaskedTextBox);
			this.groupBox1.Controls.Add(this.dataMaskedTextBox);
			this.groupBox1.Controls.Add(this.responsavelMaskedTextBox2);
			this.groupBox1.Controls.Add(this.descricaoMaskedTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(47, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(244, 402);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Evento";
			// 
			// incluireventoButton
			// 
			this.incluireventoButton.Location = new System.Drawing.Point(10, 240);
			this.incluireventoButton.Name = "incluireventoButton";
			this.incluireventoButton.Size = new System.Drawing.Size(91, 23);
			this.incluireventoButton.TabIndex = 8;
			this.incluireventoButton.Text = "Incluir Evento";
			this.incluireventoButton.UseVisualStyleBackColor = true;
			this.incluireventoButton.Click += new System.EventHandler(this.incluireventoButton_Click);
			// 
			// precoMaskedTextBox
			// 
			this.precoMaskedTextBox.Location = new System.Drawing.Point(94, 121);
			this.precoMaskedTextBox.Name = "precoMaskedTextBox";
			this.precoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
			this.precoMaskedTextBox.TabIndex = 7;
			// 
			// dataMaskedTextBox
			// 
			this.dataMaskedTextBox.Location = new System.Drawing.Point(95, 95);
			this.dataMaskedTextBox.Mask = "00/00/0000";
			this.dataMaskedTextBox.Name = "dataMaskedTextBox";
			this.dataMaskedTextBox.Size = new System.Drawing.Size(100, 20);
			this.dataMaskedTextBox.TabIndex = 6;
			// 
			// responsavelMaskedTextBox2
			// 
			this.responsavelMaskedTextBox2.Location = new System.Drawing.Point(94, 66);
			this.responsavelMaskedTextBox2.Name = "responsavelMaskedTextBox2";
			this.responsavelMaskedTextBox2.Size = new System.Drawing.Size(144, 20);
			this.responsavelMaskedTextBox2.TabIndex = 5;
			// 
			// descricaoMaskedTextBox
			// 
			this.descricaoMaskedTextBox.Location = new System.Drawing.Point(94, 36);
			this.descricaoMaskedTextBox.Name = "descricaoMaskedTextBox";
			this.descricaoMaskedTextBox.Size = new System.Drawing.Size(144, 20);
			this.descricaoMaskedTextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Preço";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data do Evento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Responsável";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.convidadosdataGridView);
			this.groupBox2.Controls.Add(this.buscarconvidadosButton);
			this.groupBox2.Controls.Add(this.incluirConvidadoButton);
			this.groupBox2.Controls.Add(this.emailTextBox);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.emailLabel);
			this.groupBox2.Controls.Add(this.telefoneLabel);
			this.groupBox2.Controls.Add(this.nomeTextBox);
			this.groupBox2.Controls.Add(this.nomeLabel);
			this.groupBox2.Controls.Add(this.cpfTextBox);
			this.groupBox2.Controls.Add(this.cpfLabel);
			this.groupBox2.Controls.Add(this.EventocomboBox);
			this.groupBox2.Controls.Add(this.Eventolabel);
			this.groupBox2.Location = new System.Drawing.Point(382, 26);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(346, 402);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Convidado";
			// 
			// convidadosdataGridView
			// 
			this.convidadosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.convidadosdataGridView.Location = new System.Drawing.Point(10, 240);
			this.convidadosdataGridView.Name = "convidadosdataGridView";
			this.convidadosdataGridView.Size = new System.Drawing.Size(316, 150);
			this.convidadosdataGridView.TabIndex = 12;
			// 
			// buscarconvidadosButton
			// 
			this.buscarconvidadosButton.Location = new System.Drawing.Point(254, 34);
			this.buscarconvidadosButton.Name = "buscarconvidadosButton";
			this.buscarconvidadosButton.Size = new System.Drawing.Size(75, 23);
			this.buscarconvidadosButton.TabIndex = 11;
			this.buscarconvidadosButton.Text = "Buscar";
			this.buscarconvidadosButton.UseVisualStyleBackColor = true;
			this.buscarconvidadosButton.Click += new System.EventHandler(this.buscarconvidadosButton_Click);
			// 
			// incluirConvidadoButton
			// 
			this.incluirConvidadoButton.Location = new System.Drawing.Point(13, 189);
			this.incluirConvidadoButton.Name = "incluirConvidadoButton";
			this.incluirConvidadoButton.Size = new System.Drawing.Size(123, 23);
			this.incluirConvidadoButton.TabIndex = 10;
			this.incluirConvidadoButton.Text = "Incluir Convidado";
			this.incluirConvidadoButton.UseVisualStyleBackColor = true;
			this.incluirConvidadoButton.Click += new System.EventHandler(this.incluirConvidadoButton_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(76, 163);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(157, 20);
			this.emailTextBox.TabIndex = 9;
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(76, 128);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(157, 20);
			this.telefoneTextBox.TabIndex = 8;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(10, 163);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(32, 13);
			this.emailLabel.TabIndex = 7;
			this.emailLabel.Text = "Email";
			// 
			// telefoneLabel
			// 
			this.telefoneLabel.AutoSize = true;
			this.telefoneLabel.Location = new System.Drawing.Point(10, 128);
			this.telefoneLabel.Name = "telefoneLabel";
			this.telefoneLabel.Size = new System.Drawing.Size(49, 13);
			this.telefoneLabel.TabIndex = 6;
			this.telefoneLabel.Text = "Telefone";
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.Location = new System.Drawing.Point(76, 98);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(157, 20);
			this.nomeTextBox.TabIndex = 5;
			// 
			// nomeLabel
			// 
			this.nomeLabel.AutoSize = true;
			this.nomeLabel.Location = new System.Drawing.Point(10, 98);
			this.nomeLabel.Name = "nomeLabel";
			this.nomeLabel.Size = new System.Drawing.Size(35, 13);
			this.nomeLabel.TabIndex = 4;
			this.nomeLabel.Text = "Nome";
			// 
			// cpfTextBox
			// 
			this.cpfTextBox.Location = new System.Drawing.Point(76, 65);
			this.cpfTextBox.Name = "cpfTextBox";
			this.cpfTextBox.Size = new System.Drawing.Size(157, 20);
			this.cpfTextBox.TabIndex = 3;
			// 
			// cpfLabel
			// 
			this.cpfLabel.AutoSize = true;
			this.cpfLabel.Location = new System.Drawing.Point(10, 68);
			this.cpfLabel.Name = "cpfLabel";
			this.cpfLabel.Size = new System.Drawing.Size(27, 13);
			this.cpfLabel.TabIndex = 2;
			this.cpfLabel.Text = "CPF";
			// 
			// EventocomboBox
			// 
			this.EventocomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.EventocomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.EventocomboBox.FormattingEnabled = true;
			this.EventocomboBox.Location = new System.Drawing.Point(76, 35);
			this.EventocomboBox.Name = "EventocomboBox";
			this.EventocomboBox.Size = new System.Drawing.Size(157, 21);
			this.EventocomboBox.TabIndex = 1;
			// 
			// Eventolabel
			// 
			this.Eventolabel.AutoSize = true;
			this.Eventolabel.Location = new System.Drawing.Point(7, 35);
			this.Eventolabel.Name = "Eventolabel";
			this.Eventolabel.Size = new System.Drawing.Size(41, 13);
			this.Eventolabel.TabIndex = 0;
			this.Eventolabel.Text = "Evento";
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCadastro";
			this.Text = "Cadastro de Eventos e Convidados";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosdataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button incluireventoButton;
		private System.Windows.Forms.MaskedTextBox precoMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox responsavelMaskedTextBox2;
		private System.Windows.Forms.MaskedTextBox descricaoMaskedTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox EventocomboBox;
		private System.Windows.Forms.Label Eventolabel;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label telefoneLabel;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.Label nomeLabel;
		private System.Windows.Forms.TextBox cpfTextBox;
		private System.Windows.Forms.Label cpfLabel;
		private System.Windows.Forms.Button incluirConvidadoButton;
		private System.Windows.Forms.DataGridView convidadosdataGridView;
		private System.Windows.Forms.Button buscarconvidadosButton;
	}
}

