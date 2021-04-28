/*
 * Created by SharpDevelop.
 * User: Win10
 * Date: 25/12/2019
 * Time: 23:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrabalhoPraticoN1_Polinomios
{
	/// <summary>
	/// Description of Nodo.
	/// </summary>
	
	// eu pus a classe como sealed porque nenhuma classe irá herdar nada dela
	sealed public class Nodo 
	{
	//Preferi usar ja as classes próprias ao invés de K's e T's porque assim diminui possibilidade de erros
	//além que fica mais fácil de manipular a informação, pelo menos para mim.

	//eu também pus os atributos das classes como private por uma maior segurança, menor liberdade de manipulação
	//de informação	e chances de erro, usando depois set e get
		private Termo _Termo;
		private Nodo _Next;
		
		public Nodo(Termo Termo, Nodo Next = null)
		{
	//eu uso _ para atributos de classe porque ouvi uma vez que era uma prática do c# e achei bom, além
	//que não gosto de usar this desnecessariamente, e assim posso repetir nomes de variaveis.
			_Termo = Termo;
			_Next = Next;
		}
		
		public Termo Termo
		{
			get{return _Termo;}
			set{_Termo = value;}
		}
		
		public Nodo Next
		{
			get{return _Next;}
			set{_Next = value;}
		}
	}
}
