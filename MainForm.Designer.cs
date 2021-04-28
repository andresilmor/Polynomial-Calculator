/*
 * Created by SharpDevelop.
 * User: Win10
 * Date: 25/12/2019
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabalhoPraticoN1_Polinomios
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbOrdem;
		private System.Windows.Forms.Label lbShow;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbGrau;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbNT;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label lbCompleto;
		private System.Windows.Forms.Button btnConcluir;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox tb1;
		private System.Windows.Forms.TextBox tb2;
		private System.Windows.Forms.Label lbItalico;
		private System.Windows.Forms.Label lbNegrito;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem Adicionar;
		private System.Windows.Forms.ToolStripMenuItem opcAdicionarPorTermos;
		private System.Windows.Forms.ToolStripMenuItem opcAdicionarPorVetor;
		private System.Windows.Forms.ToolStripMenuItem Remover;
		private System.Windows.Forms.ToolStripMenuItem opcRemoverTodosPolinómios;
		private System.Windows.Forms.ToolStripMenuItem opcRemoverPolinomio;
		private System.Windows.Forms.ToolStripMenuItem opcRemoverTermoPoli;
		private System.Windows.Forms.ToolStripMenuItem Calcular;
		private System.Windows.Forms.ToolStripMenuItem opcCalcularPolinomio;
		private System.Windows.Forms.ToolStripMenuItem opcSoma;
		private System.Windows.Forms.ToolStripMenuItem opcSubtracao;
		private System.Windows.Forms.ToolStripMenuItem opcMultiplicacao;
		private System.Windows.Forms.ToolStripMenuItem opcMultiplicarEscalar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem opcAdicionarClone;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbOrdem = new System.Windows.Forms.Label();
			this.lbShow = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbGrau = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbNT = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.lbCompleto = new System.Windows.Forms.Label();
			this.btnConcluir = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.tb1 = new System.Windows.Forms.TextBox();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.lbItalico = new System.Windows.Forms.Label();
			this.lbNegrito = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.Adicionar = new System.Windows.Forms.ToolStripMenuItem();
			this.opcAdicionarPorTermos = new System.Windows.Forms.ToolStripMenuItem();
			this.opcAdicionarPorVetor = new System.Windows.Forms.ToolStripMenuItem();
			this.Remover = new System.Windows.Forms.ToolStripMenuItem();
			this.opcRemoverTodosPolinómios = new System.Windows.Forms.ToolStripMenuItem();
			this.opcRemoverPolinomio = new System.Windows.Forms.ToolStripMenuItem();
			this.opcRemoverTermoPoli = new System.Windows.Forms.ToolStripMenuItem();
			this.Calcular = new System.Windows.Forms.ToolStripMenuItem();
			this.opcCalcularPolinomio = new System.Windows.Forms.ToolStripMenuItem();
			this.opcSoma = new System.Windows.Forms.ToolStripMenuItem();
			this.opcSubtracao = new System.Windows.Forms.ToolStripMenuItem();
			this.opcMultiplicacao = new System.Windows.Forms.ToolStripMenuItem();
			this.opcMultiplicarEscalar = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.opcAdicionarClone = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(642, 86);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(104, 74);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "btn1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(764, 86);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(104, 74);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "btn2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(886, 86);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(104, 74);
			this.btn3.TabIndex = 2;
			this.btn3.Text = "btn3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nº";
			// 
			// lbOrdem
			// 
			this.lbOrdem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbOrdem.Location = new System.Drawing.Point(26, 77);
			this.lbOrdem.Name = "lbOrdem";
			this.lbOrdem.Size = new System.Drawing.Size(37, 322);
			this.lbOrdem.TabIndex = 4;
			// 
			// lbShow
			// 
			this.lbShow.AutoSize = true;
			this.lbShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbShow.Location = new System.Drawing.Point(0, 0);
			this.lbShow.MinimumSize = new System.Drawing.Size(268, 322);
			this.lbShow.Name = "lbShow";
			this.lbShow.Size = new System.Drawing.Size(268, 322);
			this.lbShow.TabIndex = 0;
			this.lbShow.Text = "Nenhum Polinómio";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(74, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Polinómio";
			// 
			// lbGrau
			// 
			this.lbGrau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbGrau.Location = new System.Drawing.Point(353, 77);
			this.lbGrau.Name = "lbGrau";
			this.lbGrau.Size = new System.Drawing.Size(53, 322);
			this.lbGrau.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(353, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Grau";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(417, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Nº Termos";
			// 
			// lbNT
			// 
			this.lbNT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbNT.Location = new System.Drawing.Point(417, 77);
			this.lbNT.Name = "lbNT";
			this.lbNT.Size = new System.Drawing.Size(90, 322);
			this.lbNT.TabIndex = 9;
			// 
			// label
			// 
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(518, 54);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(90, 23);
			this.label.TabIndex = 12;
			this.label.Text = "Completo?";
			// 
			// lbCompleto
			// 
			this.lbCompleto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbCompleto.Location = new System.Drawing.Point(518, 77);
			this.lbCompleto.Name = "lbCompleto";
			this.lbCompleto.Size = new System.Drawing.Size(90, 322);
			this.lbCompleto.TabIndex = 11;
			// 
			// btnConcluir
			// 
			this.btnConcluir.Location = new System.Drawing.Point(642, 354);
			this.btnConcluir.Name = "btnConcluir";
			this.btnConcluir.Size = new System.Drawing.Size(121, 44);
			this.btnConcluir.TabIndex = 13;
			this.btnConcluir.Text = "Concluir";
			this.btnConcluir.UseVisualStyleBackColor = true;
			this.btnConcluir.Click += new System.EventHandler(this.BtnConcluirClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(778, 354);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(121, 44);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// tb1
			// 
			this.tb1.Location = new System.Drawing.Point(642, 177);
			this.tb1.Name = "tb1";
			this.tb1.Size = new System.Drawing.Size(131, 22);
			this.tb1.TabIndex = 15;
			// 
			// tb2
			// 
			this.tb2.Location = new System.Drawing.Point(792, 177);
			this.tb2.Name = "tb2";
			this.tb2.Size = new System.Drawing.Size(131, 22);
			this.tb2.TabIndex = 16;
			// 
			// lbItalico
			// 
			this.lbItalico.Location = new System.Drawing.Point(641, 202);
			this.lbItalico.Name = "lbItalico";
			this.lbItalico.Size = new System.Drawing.Size(281, 23);
			this.lbItalico.TabIndex = 17;
			// 
			// lbNegrito
			// 
			this.lbNegrito.AutoSize = true;
			this.lbNegrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNegrito.Location = new System.Drawing.Point(642, 241);
			this.lbNegrito.MaximumSize = new System.Drawing.Size(348, 97);
			this.lbNegrito.Name = "lbNegrito";
			this.lbNegrito.Size = new System.Drawing.Size(0, 17);
			this.lbNegrito.TabIndex = 18;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Adicionar,
			this.Remover,
			this.Calcular});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
			this.menuStrip1.TabIndex = 19;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Adicionar
			// 
			this.Adicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.opcAdicionarPorTermos,
			this.opcAdicionarPorVetor,
			this.opcAdicionarClone});
			this.Adicionar.Name = "Adicionar";
			this.Adicionar.Size = new System.Drawing.Size(85, 24);
			this.Adicionar.Text = "Adicionar";
			// 
			// opcAdicionarPorTermos
			// 
			this.opcAdicionarPorTermos.Name = "opcAdicionarPorTermos";
			this.opcAdicionarPorTermos.Size = new System.Drawing.Size(181, 26);
			this.opcAdicionarPorTermos.Text = "Por Termos";
			this.opcAdicionarPorTermos.Click += new System.EventHandler(this.OpcAdicionarPorTermosClick);
			// 
			// opcAdicionarPorVetor
			// 
			this.opcAdicionarPorVetor.Name = "opcAdicionarPorVetor";
			this.opcAdicionarPorVetor.Size = new System.Drawing.Size(181, 26);
			this.opcAdicionarPorVetor.Text = "Por Vetores";
			this.opcAdicionarPorVetor.Click += new System.EventHandler(this.OpcAdicionarPorVetorClick);
			// 
			// Remover
			// 
			this.Remover.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.opcRemoverTodosPolinómios,
			this.opcRemoverPolinomio,
			this.opcRemoverTermoPoli});
			this.Remover.Name = "Remover";
			this.Remover.Size = new System.Drawing.Size(80, 24);
			this.Remover.Text = "Remover";
			// 
			// opcRemoverTodosPolinómios
			// 
			this.opcRemoverTodosPolinómios.Name = "opcRemoverTodosPolinómios";
			this.opcRemoverTodosPolinómios.Size = new System.Drawing.Size(220, 26);
			this.opcRemoverTodosPolinómios.Text = "Todos os Polinómios";
			this.opcRemoverTodosPolinómios.Click += new System.EventHandler(this.OpcRemoverTodosPolinómiosClick);
			// 
			// opcRemoverPolinomio
			// 
			this.opcRemoverPolinomio.Name = "opcRemoverPolinomio";
			this.opcRemoverPolinomio.Size = new System.Drawing.Size(220, 26);
			this.opcRemoverPolinomio.Text = "Polinómio";
			this.opcRemoverPolinomio.Click += new System.EventHandler(this.OpcRemoverPolinomioClick);
			// 
			// opcRemoverTermoPoli
			// 
			this.opcRemoverTermoPoli.Name = "opcRemoverTermoPoli";
			this.opcRemoverTermoPoli.Size = new System.Drawing.Size(220, 26);
			this.opcRemoverTermoPoli.Text = "Termo";
			this.opcRemoverTermoPoli.Click += new System.EventHandler(this.OpcRemoverTermoPoliClick);
			// 
			// Calcular
			// 
			this.Calcular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.opcCalcularPolinomio,
			this.opcSoma,
			this.opcSubtracao,
			this.opcMultiplicacao,
			this.opcMultiplicarEscalar});
			this.Calcular.Name = "Calcular";
			this.Calcular.Size = new System.Drawing.Size(74, 24);
			this.Calcular.Text = "Calcular";
			// 
			// opcCalcularPolinomio
			// 
			this.opcCalcularPolinomio.Name = "opcCalcularPolinomio";
			this.opcCalcularPolinomio.Size = new System.Drawing.Size(242, 26);
			this.opcCalcularPolinomio.Text = "Polinómio";
			this.opcCalcularPolinomio.Click += new System.EventHandler(this.OpcCalcularPolinomioClick);
			// 
			// opcSoma
			// 
			this.opcSoma.Name = "opcSoma";
			this.opcSoma.Size = new System.Drawing.Size(242, 26);
			this.opcSoma.Text = "Somar";
			this.opcSoma.Click += new System.EventHandler(this.OpcSomaClick);
			// 
			// opcSubtracao
			// 
			this.opcSubtracao.Name = "opcSubtracao";
			this.opcSubtracao.Size = new System.Drawing.Size(242, 26);
			this.opcSubtracao.Text = "Subtrair";
			this.opcSubtracao.Click += new System.EventHandler(this.OpcSubtracaoClick);
			// 
			// opcMultiplicacao
			// 
			this.opcMultiplicacao.Name = "opcMultiplicacao";
			this.opcMultiplicacao.Size = new System.Drawing.Size(242, 26);
			this.opcMultiplicacao.Text = "Multiplicar (Polinómios)";
			this.opcMultiplicacao.Click += new System.EventHandler(this.OpcMultiplicacaoClick);
			// 
			// opcMultiplicarEscalar
			// 
			this.opcMultiplicarEscalar.Name = "opcMultiplicarEscalar";
			this.opcMultiplicarEscalar.Size = new System.Drawing.Size(242, 26);
			this.opcMultiplicarEscalar.Text = "Multiplicar (Escalar)";
			this.opcMultiplicarEscalar.Click += new System.EventHandler(this.OpcMultiplicarEscalarClick);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.lbShow);
			this.panel1.Location = new System.Drawing.Point(74, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(268, 343);
			this.panel1.TabIndex = 20;
			// 
			// opcAdicionarClone
			// 
			this.opcAdicionarClone.Name = "opcAdicionarClone";
			this.opcAdicionarClone.Size = new System.Drawing.Size(181, 26);
			this.opcAdicionarClone.Text = "Clone";
			this.opcAdicionarClone.Click += new System.EventHandler(this.OpcAdicionarCloneClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 442);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbNegrito);
			this.Controls.Add(this.lbItalico);
			this.Controls.Add(this.tb2);
			this.Controls.Add(this.tb1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConcluir);
			this.Controls.Add(this.label);
			this.Controls.Add(this.lbCompleto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbNT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbGrau);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbOrdem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1038, 489);
			this.MinimumSize = new System.Drawing.Size(1038, 489);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Polinómios";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
