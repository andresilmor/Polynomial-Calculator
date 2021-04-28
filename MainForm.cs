/*
 * Created by SharpDevelop.
 * User: Win10
 * Date: 25/12/2019
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoPraticoN1_Polinomios
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Eu usei forms por ser mais facil de usar a aplicaçao e mais bonito visualmente
		//Não vou justificar o que cada botao faz em especifico mas em geral tem um conjunto de
		//botoes, label e textbox que vao se adaptando de acordo com o que é para fazer
		//fiz deste modo para evitar o uso de janelas assim como para nao haver sobrecarga
		//de botos/opçoes no janela
		//Tentei evitar possiveis erros como polinomios constantes, e proibir outros como coeficiente 0
		private Polinomio[] _Conjunto = new Polinomio[20];
		private bool[] _bConjunto = new bool[20];
		private byte cont = 0;
		//novo e pos sao variaveis muito usadas por isso decidi criar já de raiz
		private Polinomio novo;
		private byte pos;
		
		public MainForm()
		{
			InitializeComponent();
			mostrarTodos();
			hideAll();
		}
		
		public void hideAll()
		{
			btn1.Hide();
			btn2.Hide();
			btn3.Hide();
			btnCancelar.Hide();
			btnConcluir.Hide();
			tb1.Hide();
			tb2.Hide();
			lbItalico.Hide();
			lbNegrito.Hide();
			tb1.Text = "";
			tb2.Text = "";
			lbItalico.Text = "";
			lbNegrito.Text = "";
			
		}
		
		public void mostrarTodos()
		{
			lbOrdem.Text = "";
			lbShow.Text = "";
			lbGrau.Text = "";
			lbNT.Text = "";
			lbCompleto.Text = "";
			pos = 1;
			for(int i = 0; i < _Conjunto.Length; i++)
			{
				if(_bConjunto[i])
				{
					lbShow.Text += _Conjunto[i].ToString() + "\n";
					lbOrdem.Text += (pos++) + "\n";
					lbGrau.Text += _Conjunto[i].Grau + "\n";
					lbNT.Text += _Conjunto[i].NumTermos + "\n";
					lbCompleto.Text += _Conjunto[i].Completo ? "Completo\n" : "Incompleto\n";
				}
			}
			if(lbShow.Text == "")
			{
				lbShow.Text = "Não foi inserido nenhum Polinónimo";
			}
		}
		
		void Btn1Click(object sender, EventArgs e)
		{
			if(btn1.Text == "Adicionar Termo")
			{
				var termo = tb1.Text.Split(',');
				if(termo.Length > 2)
				{
					MessageBox.Show("Informações em Excesso","Erro!", MessageBoxButtons.OK);
					return;
				}
				int coef;
				int grau = 0;
				if(!int.TryParse(termo[0], out coef) || coef == 0)
				{
					MessageBox.Show("Coeficiente Inválido!", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(termo.Length == 2)
				{
					if(!int.TryParse(termo[1], out grau) || grau < 0)
					{
						MessageBox.Show("Grau Inválido!", "Erro!", MessageBoxButtons.OK);
						return;
					}
				}
				novo.AddTermo(grau,coef);
				lbNegrito.Text = "P(n)= " + novo.ToString();
				return;
			}
			if(btn1.Text == "Adicionar Vetores (Desc)")
			{
				novo = new Polinomio();
				string[] vetor = tb1.Text.Split(',');
				int cont = 0;
				for(int i = 0; i < vetor.Length; i++)
				{
					int coef;
					if(!int.TryParse(vetor[i], out coef))
						cont++;
					novo.AddTermo(i,coef);
				}
				if(cont > 0)
					MessageBox.Show("Foram inseridos " + cont +" coeficiente(s) Inválido(s)!", "Erro!", MessageBoxButtons.OK);
				lbNegrito.Text = "P(n)= " + novo.ToString();
				return;
			}
			if(btn1.Text == "Remover Polinómio")
			{
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				for(int i = 0; i < _bConjunto.Length; i++)
				{
					if(_bConjunto[i])
					{
						pos--;
						if(pos == 0)
						{
							_bConjunto[i] = false;
							MessageBox.Show("Polinómio Removido", "Sucesso",MessageBoxButtons.OK);
							cont--;
							mostrarTodos();
							return;
						}
					}
				}
			}
			if(btn1.Text == "Remover Termo")
			{
				int grau;
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição Inválida", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(novo.NumTermos == 0)
				{
					MessageBox.Show("Sem Termos para remover.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(!int.TryParse(tb2.Text, out grau) || grau < 0 || _Conjunto[pos-1].Grau < grau)
				{
					MessageBox.Show("Grau Inválido", "Erro!", MessageBoxButtons.OK);
					return;
				}
				novo = _Conjunto[pos-1];
				novo.RemoveTermo(grau);
				lbNegrito.Text = "P(n)=" + novo.ToString();
			}
			if(btn1.Text == "Calcular")
			{
				double valor;
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(!double.TryParse(tb2.Text, out valor))
				{
					MessageBox.Show("Valor Inválido.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				lbNegrito.Text = "P(n)= " + _Conjunto[pos-1].ToString() +"\nP(" + valor + ")= " + _Conjunto[pos-1].Valor(valor);
			}
			if(btn1.Text == "Somar")
			{
				byte pos2;
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição 1 Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(!byte.TryParse(tb2.Text, out pos2) || pos2 > cont || pos2 <= 0)
				{
					MessageBox.Show("Posição 2 Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				novo = new Polinomio();
				novo = _Conjunto[pos-1] + _Conjunto[pos2-1];
				lbNegrito.Text = "P(n)= " + novo.ToString();
			}
			if(btn1.Text == "Subtrair")
			{
				byte pos2;
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição 1 Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(!byte.TryParse(tb2.Text, out pos2) || pos2 > cont || pos2 <= 0)
				{
					MessageBox.Show("Posição 2 Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				novo = new Polinomio();
				novo = _Conjunto[pos-1] - _Conjunto[pos2-1];
				lbNegrito.Text = "P(n)= " + novo.ToString();
			}
			if(btn1.Text == "Multiplicar")
			{
				byte pos2;
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição 1 Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(!byte.TryParse(tb2.Text, out pos2) || pos2 > cont || pos2 <= 0)
				{
					MessageBox.Show("Posição 2 Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				novo = new Polinomio();
				novo = _Conjunto[pos-1] * _Conjunto[pos2-1];
				lbNegrito.Text = "P(n)= " + novo.ToString();
			}
			if(btn1.Text == "Multiplicar por Escalar")
			{
				byte esc;
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(!byte.TryParse(tb2.Text, out esc) || esc == 0)
				{
					MessageBox.Show("Escalar Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				novo = new Polinomio();
				novo = _Conjunto[pos-1] * esc;
				lbNegrito.Text = "P(n)= " + novo.ToString();
			}
			if(btn1.Text == "Criar Clone")
			{
				if(!byte.TryParse(tb1.Text, out pos) || pos > cont || pos <= 0)
				{
					MessageBox.Show("Posição Inválida.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				novo = _Conjunto[pos-1].Clone();
				lbNegrito.Text = "P(n)= " + novo.ToString();
			}
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
			if(btn2.Text == "Adicionar Vetores (Asc)")
			{
				novo = new Polinomio();
				string[] vetor = tb1.Text.Split(',');
				Array.Reverse(vetor);
				int cont = 0;
				for(int i = 0; i < vetor.Length; i++)
				{
					int coef;
					if(!int.TryParse(vetor[i], out coef))
						cont++;
					novo.AddTermo(i,coef);
				}
				if(cont > 0)
					MessageBox.Show("Foram inseridos " + cont +" coeficiente(s) Inválido(s)!", "Erro!", MessageBoxButtons.OK);
				lbNegrito.Text = "P(n)= " + novo.ToString();
				return;
			}
			if(btn2.Text == "Save")
			{
				if(novo.NumTermos == 0)
				{
					MessageBox.Show("Não existe nenhum Polinómio para salvar.", "Erro!", MessageBoxButtons.OK);
					return;
				}
				if(_Conjunto.Length == cont)
				{
					DialogResult ch = MessageBox.Show("Máximo de Polinómios atingido, recomeçar?", "Erro!", MessageBoxButtons.YesNo);
					switch(ch)
					{
							case DialogResult.Yes:
								cont = 0;
								_Conjunto[cont] = novo.Clone();
								_bConjunto[cont] = true;
								break;
							case DialogResult.No:
								break;
					}
				}
				_Conjunto[cont] = novo.Clone();
				_bConjunto[cont++] = true;
				mostrarTodos();
			}
		}
		
		void Btn3Click(object sender, EventArgs e)
		{
			if(btn3.Text == "Reset")
			{
				novo = new Polinomio();
				lbNegrito.Text = "P(n)= " + novo.ToString();
				tb1.Text = "";
			}
		}
		
		void BtnConcluirClick(object sender, EventArgs e)
		{
			if(novo.NumTermos == 0 && btn1.Text != "Remover Polinómio" && btn1.Text != "Remover Termo" && btn1.Text != "Multiplicar" && btn1.Text != "Somar" && btn1.Text != "Subtrair" && btn1.Text != "Multiplicar por Termo" )
			{
				MessageBox.Show("Polinómio Vazio", "Erro!", MessageBoxButtons.OK);
				return;
			}
			if(btn1.Text == "Adicionar Termo" || btn1.Text == "Criar Clone" || (btn2.Text == "Adicionar Vetores (Asc)" && btn1.Text == "Adicionar Vetores (Desc)"))
			{
				if(_Conjunto.Length == cont)
				{
					DialogResult ch = MessageBox.Show("Máximo de Polinómios atingido, recomeçar?", "Erro!", MessageBoxButtons.YesNo);
					switch(ch)
					{
							case DialogResult.Yes:
								cont = 0;
								_Conjunto[cont] = novo.Clone();
								_bConjunto[cont] = true;
								break;
							case DialogResult.No:
								break;
					}
				}
				if(novo.Grau == 0 && novo.NumTermos == 1)
				{
					DialogResult ch = MessageBox.Show("O Polinómio em questão é um Polinómio constante, deseja continuar?", "Erro!", MessageBoxButtons.YesNo);
					switch(ch)
					{
							case DialogResult.Yes:
								_Conjunto[cont] = novo.Clone();
								_bConjunto[cont] = true;
								break;
							case DialogResult.No:
								break;
					}
				}
				_Conjunto[cont] = novo.Clone();
				_bConjunto[cont] = true;
				cont++;
				tb1.Text = "";
			}
			if(btn1.Text == "Remover Termo")
			{
				if(novo.NumTermos == 0)
					_bConjunto[pos-1] = false;
				_Conjunto[pos-1] =  novo.Clone();
			}
			mostrarTodos();
			hideAll();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			hideAll();
			mostrarTodos();
		}
		
		void OpcAdicionarPorTermosClick(object sender, EventArgs e)
		{
			novo = new Polinomio();
			hideAll();
			btn1.Show();
			tb1.Show();
			lbItalico.Show();
			lbNegrito.Show();
			btnConcluir.Show();
			btnCancelar.Show();
			btn1.Text = "Adicionar Termo";
			lbItalico.Text = "Nota: Virgula(,) para separar.";
			lbNegrito.Text = "P(n)= ";
		}
		void OpcAdicionarPorVetorClick(object sender, EventArgs e)
		{
			hideAll();
			btn1.Show();
			btn2.Show();
			btn3.Show();
			tb1.Show();
			lbItalico.Show();
			lbNegrito.Show();
			btnConcluir.Show();
			btnCancelar.Show();
			btn2.Text = "Adicionar Vetores (Asc)";
			btn1.Text = "Adicionar Vetores (Desc)";
			btn3.Text = "Reset";
			lbItalico.Text = "Nota: Virgula(,) para separar.";
			lbNegrito.Text = "P(n)= ";
		}
		
		void OpcRemoverPolinomioClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Nenhum Polinómio para remover.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			btn1.Show();
			btn1.Text = "Remover Polinómio";
			tb1.Show();
			lbItalico.Show();
			lbItalico.Text = "Nota: Insira o Nº do Polinómio a remover.";
			btnConcluir.Show();
			btnCancelar.Show();
		}
		void OpcRemoverTermoPoliClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Nenhum Polinómio.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			btn1.Show();
			btn1.Text = "Remover Termo";
			tb1.Show();
			tb2.Show();
			lbItalico.Show();
			lbItalico.Text = "Nº do Polinómio            Grau do Termo";
			lbNegrito.Show();
			btnConcluir.Show();
		}
		
		void OpcSomaClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Polinómios Insuficientes.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			btn1.Show();
			btn1.Text = "Somar";
			btn2.Show();
			btn2.Text = "Save";
			tb1.Show();
			tb2.Show();
			btnConcluir.Show();
			btnCancelar.Show();
			lbItalico.Show();
			lbItalico.Text = "Nº do Polinómio            Nº do Polinómio";
			lbNegrito.Show();
		}
		void OpcSubtracaoClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Polinómios Insuficientes.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			btn1.Show();
			btn1.Text = "Subtrair";
			btn2.Show();
			btn2.Text = "Save";
			tb1.Show();
			tb2.Show();
			btnConcluir.Show();
			btnCancelar.Show();
			lbItalico.Show();
			lbItalico.Text = "Nº do Polinómio            Nº do Polinómio";
			lbNegrito.Show();
		}
		void OpcMultiplicacaoClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Polinómios Insuficientes.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			btn1.Show();
			btn1.Text = "Multiplicar";
			btn2.Show();
			btn2.Text = "Save";
			tb1.Show();
			tb2.Show();
			btnConcluir.Show();
			btnCancelar.Show();
			lbItalico.Show();
			lbItalico.Text = "Nº do Polinómio            Nº do Polinómio";
			lbNegrito.Show();
		}
		void OpcMultiplicarEscalarClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Polinómios Insuficientes.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			btn1.Show();
			btn1.Text = "Multiplicar por Escalar";
			btn2.Show();
			btn2.Text = "Save";
			tb1.Show();
			tb2.Show();
			btnConcluir.Show();
			btnCancelar.Show();
			lbItalico.Show();
			lbItalico.Text = "Nº do Polinómio            Escalar";
			lbNegrito.Show();
		}
		void OpcRemoverTodosPolinómiosClick(object sender, EventArgs e)
		{
			hideAll();
			for(int i = 0; i < _bConjunto.Length; i++)
				_bConjunto[i] = false;
			cont = 0;
			mostrarTodos();
		}
		void OpcCalcularPolinomioClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Polinómios Insuficientes.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			btn1.Show();
			btn1.Text = "Calcular";
			lbItalico.Show();
			tb1.Show();
			tb2.Show();
			lbNegrito.Show();
			lbItalico.Text = "Nº do Polinómio            Valor";
			lbNegrito.Text = "P()";
			btnConcluir.Show();
		}
		void OpcAdicionarCloneClick(object sender, EventArgs e)
		{
			if(cont == 0)
			{
				MessageBox.Show("Nenhum Polinómio para clonar.", "Erro!", MessageBoxButtons.OK);
				return;
			}
			hideAll();
			novo = new Polinomio();
			btn1.Show();
			btn1.Text = "Criar Clone";
			btnConcluir.Show();
			btnCancelar.Show();
			tb1.Show();
			lbItalico.Show();
			lbItalico.Text = "Nº do Polinómio a clonar.";
			lbNegrito.Show();
		}
	}
}
