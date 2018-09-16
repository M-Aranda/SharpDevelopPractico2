/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/15/2018
 * Time: 8:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProcesadorDeTxt.Model;
using System.IO; // necesario para usar StreamReader
using System.Linq; //necesario para usar .Count();


namespace ProcesadorDeTxt
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			Escritura eeb = new Escritura();
			Escritura voc = new Escritura();
			Escritura con = new Escritura();
			
			eeb.Nombre="Espacios en blanco";
			voc.Nombre="Vocales";
			con.Nombre="Consonantes";
			
			List<Escritura> esc= new List<Escritura>();
			
			esc.Add(eeb);
			esc.Add(voc);
			esc.Add(con);
			
			cboQuitar.DropDownStyle=ComboBoxStyle.DropDownList;
			cboQuitar.DataSource=esc;
			cboQuitar.DisplayMember="nombre";
			cboQuitar.ValueMember="nombre";
			
		
		}
		
		
		
		
		void BtnExaminarClick(object sender, EventArgs e)
		{
			OpenFileDialog oFDText = new OpenFileDialog(); // inicializa un nuevo objeto del tipo OpenFileDialog
			oFDText.InitialDirectory = @"C:\"; //fija la ruta inicial en donde se busca
			oFDText.Title = "Buscar archivos txt"; //el nombre del cuadro de dialogo

    		oFDText.CheckFileExists = true; //se fija que el archivo exista
			oFDText.CheckPathExists = true; // se fija que la ruta exista
			oFDText.DefaultExt = "txt"; // fijar extesion por defecto

    		oFDText.Filter = "Text files (*.txt)|*.txt";//|All files (*.*)|*.*  // filtro (el combo box del tipo de archivo del file dialog)

    		oFDText.FilterIndex = 2; //filtrar indice
			oFDText.RestoreDirectory = true; // restaurar directorio
			oFDText.ReadOnlyChecked = true; // solo archivos de lectura
			oFDText.ShowReadOnly = true; //mostrar solo archivos de lectura
			
			if (oFDText.ShowDialog() == DialogResult.OK) // si el en dialogo hubo confirmacion
   			 {
				txtRutaAqui.Text = oFDText.FileName; //escribir la ruta del archivo
        		StreamReader sr = new StreamReader(oFDText.FileName); // crear objeto del tipo StreamReader
    			rtxTexto.Text = sr.ReadToEnd(); // leer de principio a fin
    			sr.Close(); // cerrar lector de corriente
    			
    			
    			int cantPalabras = rtxTexto.Text.Split(' ', '\n', '\t').Count(); //contar palabras, ' ' es espacio
    			// '\n' es linea nueva y '\t' es tabulador
    		
				
				
				

    			
				int caracteres=rtxTexto.Text.Length-(1*rtxTexto.Lines.Count()-1); //cuenta caracteres

    			char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
    			char[] consantes = new char[]{'b','c','d','f','g','h','j','k','l', 'm', 'n', 'p', 'q', 'r',
    					's', 't', 'u','v', 'w', 'x', 'y', 'z'};
    			char[] espacios = new char[] { ' ' };
    			char[] tabuladores= new char[]{'	'};
    			
    			
    			int cantEspacios = rtxTexto.Text.Count(x => espacios.Any(y => char.ToLower(x) == y)); // cuenta espacios
    			int canTabuladores= rtxTexto.Text.Count(x => tabuladores.Any(y => char.ToLower(x) == y)); // cuenta tabuladores
    			int cantLineas = rtxTexto.Lines.Count();
    			int cantVocales = rtxTexto.Text.Count(x => vocales.Any(y => char.ToLower(x) == y)); //cuenta vocales
    			int cantConsonantes = rtxTexto.Text.Count(x => consantes.Any(y => char.ToLower(x) == y)); //cuenta consonanntes
    			
    			
    			lblPalabras.Text="Palabras                                                                                                                     :"+cantPalabras;
    			lblCaracteres.Text="Caracteres                                                                                                                 :"+caracteres;
    			lblEspaciosEnBlanco.Text="Espacios en blanco                                                                                                   :"+cantEspacios;
    			lblTabuladores.Text="Tabuladores                                                                                                               :"+canTabuladores;
    			lblLineas.Text="Líneas                                                                                                                        :"+cantLineas;
    			lblVocales.Text="Vocales                                                                                                                      :"+cantVocales;
    			lblConsonantes.Text="Consonantes                                                                                                              :"+cantConsonantes;

    			
    			}
		}
		
		
		
	}
}
