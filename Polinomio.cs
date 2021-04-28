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
	/// Description of Polinomio.
	/// </summary>
	sealed public class Polinomio
	{
		private Nodo _Primeiro;
		private int _NumTermos = 0; 
		//pus já a valer 0 de raiz porque um polinómio vazio é o mesmo que com 0 termos
		
		public Polinomio()
		{
			_Primeiro = null;
		}
		
		public Polinomio(params int[] coef)
		{
			for(int i = 0; i < coef.Length; i++)
				AddTermo(i, coef[i]); //eu pus a chamar o outro método AddTermo() para não haver
			//repetição de código desenecessário.
		}
		
		public void AddTermo(int grau, int coef) 
		{
			if(coef == 0 || grau < 0) //são erros que podia evitar ao pedir as informações mais achei bom
				return;				  //precaver.
			if(_Primeiro == null)
			{
				_Primeiro = new Nodo(new Termo(coef, grau)); //preferi criar direto o termo, ao invés de 
				_NumTermos++;								 //de tar a armazenar memória desnecessariamente
				return;
			}
			Nodo novo;
			if(_Primeiro.Termo.CompareTo(grau) < 0) //caso o novo grau seja maior que o atual
			{										//tentei incluir no while, mas não consegui
				novo = new Nodo(new Termo(coef,grau), _Primeiro);
				_Primeiro = novo;
				_NumTermos++;
				return;
			}
			Nodo aux = _Primeiro;
			while(true) //tentei outras condições e até do while, mas só assim que foi dando direito
			{
				if(aux.Termo.CompareTo(grau) == 0)
					return; //se o grau já existir termina, idealmente retornaria false, mas o metodo é void
				if(aux.Next == null)
					break; //não existem mais nodos, ou seja, o novo vai ser adicionado no fim
				if(aux.Next.Termo.CompareTo(grau) < 0)
					break; //aqui para no nodo anterior à posiçao que o novo vai estar
				aux = aux.Next;
			}
			novo = new Nodo(new Termo(coef,grau), aux.Next);
			aux.Next = novo;
			_NumTermos++;
		}
		
		public void RemoveTermo(int grau)
		{
			if(_Primeiro.Termo.CompareTo(grau) == 0) //se for o primeiro a ser removido
			{
				_Primeiro = _Primeiro.Next;
				_NumTermos--;
				return;
			}
			Nodo aux = _Primeiro;
			while(aux.Next != null)
			{
				if(aux.Next.Termo.CompareTo(grau) == 0) //para no nodo anterior ao que vai remover
				{
					aux.Next = aux.Next.Next; //salta os nodos
					_NumTermos--;
					return;
				}
				if(aux.Next.Termo.CompareTo(grau) < 0) //o grau do nodo a retirar é inferior ao
					return;							   //ao grau do aux, ou seja ele não existe
			}
		}
		
		public int Grau
		{	
			get{
				return _Primeiro.Termo.Grau; //Como o grau do _Primeiro será sempre o maior é desnecessário
			}							     //repetir essa informação, mesmo sendo necessário "viajar"
		}									 //é direto, sem estruturas de repetição ou até de seleção, 
											 //por isso continua O(1)
		
		public int NumTermos
		{ 
			get{
				return _NumTermos; //criei um atributo como que um contador, única forma de ser O(1)
			}
		}
		
		public double Valor(double vx) 
		{
			Nodo aux = _Primeiro;
			double soma = 0;
			while(aux != null)
			{
				double coef = aux.Termo.Coeficiente; // como ia ficar muito texto seguido, preferi
				double grau = aux.Termo.Grau;		 // armazenar as informações (coef, grau)
				soma += grau != 0 ? Math.Pow((coef*vx), grau) : coef; //termos com grau 0 não 
				aux = aux.Next;							//fazem multiplicações nem potência
			}											//por isso só soma o coef
			return soma;
		}
		
		public override string ToString()
		{
			if(_Primeiro == null)
				return "";
			string poli = _Primeiro.Termo.ToString();
			Nodo aux = _Primeiro.Next;
			while(aux != null)
			{
				string str = aux.Termo.ToString();
				if(str.Contains("-")) //se o coef do termo for negativo, o - já vem de antemão
					poli += str;
				else
					poli += "+" + str; //mas se o coef for positivo preciso de adicionar o +
				aux = aux.Next;
			}
			return poli;
		}

		public Polinomio Clone() 
		{
			Polinomio novo = new Polinomio();
			Nodo prim = this._Primeiro;
			while(prim != null)
			{
				novo.AddTermo(prim.Termo.Grau, prim.Termo.Coeficiente);
				prim = prim.Next;
			}
			return novo;
			//inicialmente pensei que so retornava this, mas testando o remover termo notei
			//que retirava em todos, por isso fiz de forma a que cria-se um polinomio novo de raiz.
		}				 
		
		public static Polinomio operator + (Polinomio P1, Polinomio P2)
		{
			Polinomio novo = new Polinomio();
			Nodo P1aux = P1._Primeiro;
			Nodo P2aux = P2._Primeiro;
			while(true)
			{	
				if(P1aux != null && P2aux != null && P1aux.Termo.CompareTo(P2aux.Termo.Grau) == 0)
				{	//se ambos os nodos nao forem nulos e os graus dos termos forem iguais soma eles.
					int coef;
					//no caso de soma não dar 0, coef fica com o resultado da soma
					if(P1aux.Termo.Coeficiente + P2aux.Termo.Coeficiente != 0)
						coef = P1aux.Termo.Coeficiente + P2aux.Termo.Coeficiente;
					else
						coef = 1;
					//mas se der 0, tipo -2 + 2, o coef passa a valer 1, visto que o coeficiente
					//não pode ser 0, e sendo 1 não afeta as contas nem o tostring
					novo.AddTermo(P1aux.Termo.Grau, coef);
					P1aux = P1aux.Next;
					P2aux = P2aux.Next;
					//ambos os nodos avançam para o proximo
					continue;
				}
				if((P2aux == null && P1aux != null) || (P1aux != null && P1aux.Termo.CompareTo(P2aux.Termo.Grau) > 0))
				{
					//caso P2 seja ja nulo, ou seja ja nao há mais nodos/termos de P2, e P1 ainda tenha
					//ou caso P1 e P2 tenham nodos, mas o grau de P1 seja maior que o de P2
					//adciona ao novo polinomio o termo de P1
					novo.AddTermo(P1aux.Termo.Grau, P1aux.Termo.Coeficiente);
					P1aux = P1aux.Next;
					continue;
				}
				if((P1aux == null && P2aux != null) || (P2aux != null && P2aux.Termo.CompareTo(P1aux.Termo.Grau) > 0))
				{
					//caso P1 seja ja nulo, ou seja ja nao há mais nodos/termos de P1, e P2 ainda tenha
					//ou caso P1 e P2 tenham nodos, mas o grau de P2 seja maior que o de P1
					//adciona ao novo polinomio o termo de P2
					novo.AddTermo(P2aux.Termo.Grau, P2aux.Termo.Coeficiente);
					P2aux = P2aux.Next;
					continue;
				}
				if(P1aux == null && P2aux == null)
					break; //se ambos forem nulos termina, eu tentei fazer com um while, e um do while
			}			   //com esta condição, mas ignorava o ultimo nodo quando entre polinomios
			return novo;   //com numtermos diferentes
		}
		
		public static Polinomio operator - (Polinomio P1, Polinomio P2)
		{
			//mesma coisa que +, a diferença é que nos termos com graus iguais
			//subtrai o coeficiente do termo de P2 ao de P1, tipo P2 coef 4, P1 coef 2. 2-4 = -2
			Polinomio novo = new Polinomio();
			Nodo P1aux = P1._Primeiro;
			Nodo P2aux = P2._Primeiro;
			while(true)
			{
				if(P1aux != null && P2aux != null && P1aux.Termo.CompareTo(P2aux.Termo.Grau) == 0)
				{
					int coef;
					if(P1aux.Termo.Coeficiente - P2aux.Termo.Coeficiente != 0)
						coef = P1aux.Termo.Coeficiente - P2aux.Termo.Coeficiente;
					else
						coef = 1;
					novo.AddTermo(P1aux.Termo.Grau, coef);
					P1aux = P1aux.Next;
					P2aux = P2aux.Next;
					continue;
				}
				if((P2aux == null && P1aux != null) || (P1aux != null && P1aux.Termo.CompareTo(P2aux.Termo.Grau) > 0))
				{
					novo.AddTermo(P1aux.Termo.Grau, P1aux.Termo.Coeficiente);
					P1aux = P1aux.Next;
					continue;
				}
				if((P1aux == null && P2aux != null) || (P2aux != null && P2aux.Termo.CompareTo(P1aux.Termo.Grau) > 0))
				{
					novo.AddTermo(P2aux.Termo.Grau, P2aux.Termo.Coeficiente);
					P2aux = P2aux.Next;
					continue;
				}
				if(P1aux == null && P2aux == null)
					break;
			}
			return novo;
		}
		
		public static Polinomio operator * (Polinomio P1, Polinomio P2)
		{
			Nodo P1aux = P1._Primeiro;
			Nodo P2aux = P2._Primeiro;
			int[] save = new int[P1aux.Termo.Grau + P1aux.Termo.Grau + 1];
			//cria um vetor que armazena até o maximo de graus possivel
			while(P1aux != null)
			{   //ele vai começando por multiplicar o primeiro termo de P1 por todos
				//os termos de P2, somando também os graus através do index onde armazena a multiplicação
				save[P1aux.Termo.Grau + P2aux.Termo.Grau] += (P1aux.Termo.Coeficiente * P2aux.Termo.Coeficiente);
				P2aux = P2aux.Next;
				if(P2aux == null)
				{	//Quando terminar P2, P1 avança para o proximo nodo, e P2 recomeça
					//Depois os coeficientes vao somando as novas multiplicações
					P1aux = P1aux.Next;
					P2aux = P2._Primeiro;
				}
			} //termina quando P1 tiver chegado ao fim
			return new Polinomio(save);
		}
		
		public static Polinomio operator * (Polinomio P1, int escalar)
		{
			Polinomio novo = new Polinomio();
			Nodo aux = P1._Primeiro;
			while(aux != null)
			{	//"viaja" pelo P1 multiplicando os coeficientes pelo escalar, mantendo a grau
				novo.AddTermo(aux.Termo.Grau, aux.Termo.Coeficiente * escalar);
				aux = aux.Next;
			}
			return novo;
		}
		
		public bool Completo //metodo para dizer se o polinomio é completo ou nao
		{
			get {
				if(_NumTermos-1 == Grau)
					return true;
				return false;
			}
		}
	}
}
