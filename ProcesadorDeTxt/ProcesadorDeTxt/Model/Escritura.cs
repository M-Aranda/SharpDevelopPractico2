/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/15/2018
 * Time: 8:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProcesadorDeTxt.Model
{
	/// <summary>
	/// Description of Escritura.
	/// </summary>
	public class Escritura
	{
		
		String nombre;
		
		public Escritura()
		{
			
			
		}

		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}
		
	}
}
