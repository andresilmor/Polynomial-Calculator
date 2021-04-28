/*
 * Created by SharpDevelop.
 * User: Win10
 * Date: 25/12/2019
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrabalhoPraticoN1_Polinomios
{
	/// <summary>
	/// Description of Termo.
	/// </summary>
	public struct Termo
	{
		private int _Coeficiente;
		private int _Grau;
		
	//eu pus o grau já a valer 0 por default já que no minimo ele é grau 0, só para facilitar mais para a frente
		public Termo(int Coeficiente, int Grau = 0)
		{
			_Coeficiente = Coeficiente;
			_Grau = Grau;
		}
		
		public int CompareTo(int Grau)
		{
			return _Grau - Grau;
		}
		
		public int Coeficiente
		{
			get{
				return _Coeficiente;
			}
		}
		
		public int Grau
		{
			get{
				return _Grau;
			}
		}
		
		public override string ToString()
		{
	//pouco a dizer, fui testando e adicionando condições, fica mais fácil perceber assim que usando ?
			string str = "";
			if(_Coeficiente != 1 && _Grau > 1)
				return str += _Coeficiente + "n^" + _Grau;
			if(_Coeficiente != 1 && _Grau == 1)
				return str += _Coeficiente + "n";
			if(_Coeficiente == 1 && _Grau > 1)
				return str += "n^" + _Grau;
			if(_Coeficiente == 1 && _Grau == 1)
				return str += "n";
			if(_Grau == 0)
				return str += _Coeficiente;
			return str;
		}
	}
}
