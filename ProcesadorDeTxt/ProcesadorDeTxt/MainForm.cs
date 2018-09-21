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
using System.Text.RegularExpressions; // necesario para Regex;


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
		
		
		public void ContarTodo(){

				
			//int caracteres=rtxTexto.Text.Length; //cuenta caracteres en cada linea
			/*
			char[] numeroOSimbolo= new char[]{'1','2','3','4','5','6','7','8','9','#','Å','@','฿','¢','¢','©','º','$',
			'£','§','™','&','¶','+','-','/','*','%','|',',','.',':',';','(',')','?','!','{','}','[',']','-','_'}; */
    		char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u','á', 'é', 'í', 'ó', 'ú' };
    		char[] consantes = new char[]{'b','c','d','f','g','h','j','k','l', 'm', 'n','ñ', 'p', 'q', 'r',
    		's', 't','v', 'w', 'x', 'y', 'z'};
    		char[] espacios = new char[] { ' ' };
    		char[] tabuladores= new char[]{'	'};
    			
			int cantPalabras = 0;
			int cantVocalesEstaString =  0;
			int cantConsonantesEstaString = 0; 		
			int cantLineas = 0;
			
			
			//int cantNum=0;
			
		
			
			for (int i = 0; i <= rtxTexto.Lines.Count()-1; i++)
			{
					
			String actual = rtxTexto.Lines[ i ];
			cantVocalesEstaString=rtxTexto.Lines[i].Count(x => vocales.Any(y => char.ToLower(x) == y));
			cantConsonantesEstaString =rtxTexto.Lines[i].Count(x => consantes.Any(y => char.ToLower(x) == y));
			//cantNum+=rtxTexto.Lines[i].Count(x => Char.IsDigit(x));
			//|| cantNum>0
				
			if(actual.Contains(" ") || actual.Contains("	") || cantConsonantesEstaString>0 || cantVocalesEstaString>0){
				cantLineas++;			
			}
			
			Char [] para={' ','	'};
			String [] palabras=actual.Split(para);
			List<String>pa=new List<String>();
			
			foreach (var element in palabras) {
				pa.Add(element);
			}
			
			foreach (var element in pa) {
				//MessageBox.Show(element);
				// if con multiples condiciones. Para mayor info, preguntele a Marcelo Aranda
				if(element.Contains("a") || element.Contains("b") || element.Contains("c") || element.Contains("d") ||
				   element.Contains("e") || element.Contains("f") || element.Contains("g") || element.Contains("h") ||
				   element.Contains("i") || element.Contains("j") || element.Contains("k") || element.Contains("l") ||
				   element.Contains("m") || element.Contains("n") || element.Contains("ñ") || element.Contains("o") ||
				   element.Contains("p") || element.Contains("q") || element.Contains("r") || element.Contains("s") ||
				   element.Contains("t") || element.Contains("u") || element.Contains("v") || element.Contains("w") ||
				   element.Contains("x") || element.Contains("y") || element.Contains("z") || element.Contains("á") ||
				   element.Contains("é") || element.Contains("í") || element.Contains("ó") || element.Contains("ú") ||
				   element.Contains("A") || element.Contains("B") || element.Contains("C") || element.Contains("D") ||
				   element.Contains("E") || element.Contains("F") || element.Contains("G") || element.Contains("H") ||
				   element.Contains("I") || element.Contains("J") || element.Contains("K") || element.Contains("L") ||
				   element.Contains("M") || element.Contains("N") || element.Contains("Ñ") || element.Contains("O") ||
				   element.Contains("P") || element.Contains("Q") || element.Contains("R") || element.Contains("S") ||
				   element.Contains("T") || element.Contains("U") || element.Contains("V") || element.Contains("W") ||
				   element.Contains("X") || element.Contains("Y") || element.Contains("Z") || element.Contains("Á") ||
				   element.Contains("É") || element.Contains("Í") || element.Contains("Ó") || element.Contains("Ú")
					){
					cantPalabras++;
				}
			}
			

			}//

    			
    			
    			int cantEspacios = rtxTexto.Text.Count(x => espacios.Any(y => char.ToLower(x) == y)); // cuenta espacios
    			int canTabuladores= rtxTexto.Text.Count(x => tabuladores.Any(y => char.ToLower(x) == y)); // cuenta tabuladores
    			//int cantLineas = rtxTexto.Lines.Count();
    			int cantVocales = rtxTexto.Text.Count(x => vocales.Any(y => char.ToLower(x) == y)); //cuenta vocales
    			int cantConsonantes = rtxTexto.Text.Count(x => consantes.Any(y => char.ToLower(x) == y)); //cuenta consonantes
    			//int cantNumOSimbolo = rtxTexto.Text.Count(x => numeroOSimbolo.Any()); //cuenta numeros y simbolos
    			
    			int caracteres= cantVocales+cantConsonantes;//+cantNum;
    			
    			
    			lblPalabras.Text="Palabras                     :"+cantPalabras;
    			lblCaracteres.Text="Caracteres                 :"+caracteres;
    			lblEspaciosEnBlanco.Text="Espacios en blanco   :"+cantEspacios;
    			lblTabuladores.Text="Tabuladores               :"+canTabuladores;
    			lblLineas.Text="Líneas                        :"+cantLineas;
    			lblVocales.Text="Vocales                      :"+cantVocales;
    			lblConsonantes.Text="Consonantes              :"+cantConsonantes;
    			
			
    		if(cantVocales==0 && cantConsonantes==0){
    			lblPalabras.Text="Palabras                     :"+0;
    			lblCaracteres.Text="Caracteres                 :"+0;
    		}
		}
 
		

		
		
		void BtnExaminarClick(object sender, EventArgs e)
		{
			OpenFileDialog oFDText = new OpenFileDialog(); // inicializa un nuevo objeto del tipo OpenFileDialog
			oFDText.InitialDirectory = @"C:\"; //fija la ruta inicial en donde se busca
			oFDText.Title = "Buscar archivos txt"; //el nombre del cuadro de dialogo

    		oFDText.CheckFileExists = true; //se fija que el archivo exista
			oFDText.CheckPathExists = true; // se fija que la ruta exista
			oFDText.DefaultExt = "txt"; // fijar extesion por defecto

    		oFDText.Filter = "Text files (*.txt)|*.txt";//|All files (*.*)|*.*";  // filtro (el combo box del tipo de archivo del file dialog)

    		oFDText.FilterIndex = 2; //filtrar indice
			oFDText.RestoreDirectory = true; // restaurar directorio
			oFDText.ReadOnlyChecked = true; // solo archivos de lectura
			oFDText.ShowReadOnly = true; //mostrar solo archivos de lectura
			
			if (oFDText.ShowDialog() == DialogResult.OK) // si el en dialogo hubo confirmacion
   			 {
				txtRutaAqui.Text = oFDText.FileName; //escribir la ruta del archivo
        		StreamReader sr = new StreamReader(oFDText.FileName,System.Text.Encoding.Default, false, 512); // crear objeto del tipo StreamReader
        		//La propiedad de Encoding, Default, permite reconocer tildes del español
    			rtxTexto.Text = sr.ReadToEnd(); // leer de principio a fin
    			
    			
    			sr.Close(); // cerrar lector de corriente
    			ContarTodo();
    			}
			
			
		}
		void BtnProcesarClick(object sender, EventArgs e)
		{
			Escritura opcionSeleccionada=(Escritura)cboQuitar.SelectedItem;
			
			
			if(opcionSeleccionada.Nombre=="Espacios en blanco"){
				//rtxTexto.Text = Regex.Replace(rtxTexto.Text, @"\s+", ""); // remueve y junta todo	
				rtxTexto.Text = rtxTexto.Text.Replace(" ","");//espacios
				rtxTexto.Text = rtxTexto.Text.Replace("	","");//tabs

		
			}else if(opcionSeleccionada.Nombre=="Vocales"){

			rtxTexto.Text = rtxTexto.Text.Replace("a","");
			rtxTexto.Text = rtxTexto.Text.Replace("e","");
			rtxTexto.Text = rtxTexto.Text.Replace("i","");
			rtxTexto.Text = rtxTexto.Text.Replace("o","");
			rtxTexto.Text = rtxTexto.Text.Replace("u","");
			rtxTexto.Text = rtxTexto.Text.Replace("A","");
			rtxTexto.Text = rtxTexto.Text.Replace("E","");
			rtxTexto.Text = rtxTexto.Text.Replace("I","");
			rtxTexto.Text = rtxTexto.Text.Replace("O","");
			rtxTexto.Text = rtxTexto.Text.Replace("U","");
			
			rtxTexto.Text = rtxTexto.Text.Replace("á","");
			rtxTexto.Text = rtxTexto.Text.Replace("é","");
			rtxTexto.Text = rtxTexto.Text.Replace("í","");
			rtxTexto.Text = rtxTexto.Text.Replace("ó","");
			rtxTexto.Text = rtxTexto.Text.Replace("ú","");
			rtxTexto.Text = rtxTexto.Text.Replace("Á","");
			rtxTexto.Text = rtxTexto.Text.Replace("É","");
			rtxTexto.Text = rtxTexto.Text.Replace("Í","");
			rtxTexto.Text = rtxTexto.Text.Replace("Ó","");
			rtxTexto.Text = rtxTexto.Text.Replace("Ú","");
			
			
			}else if(opcionSeleccionada.Nombre=="Consonantes"){
			
			rtxTexto.Text = rtxTexto.Text.Replace("b","");
			rtxTexto.Text = rtxTexto.Text.Replace("c","");
			rtxTexto.Text = rtxTexto.Text.Replace("d","");
			rtxTexto.Text = rtxTexto.Text.Replace("f","");
			rtxTexto.Text = rtxTexto.Text.Replace("g","");
			rtxTexto.Text = rtxTexto.Text.Replace("h","");
			rtxTexto.Text = rtxTexto.Text.Replace("j","");
			rtxTexto.Text = rtxTexto.Text.Replace("k","");
			rtxTexto.Text = rtxTexto.Text.Replace("l","");
			rtxTexto.Text = rtxTexto.Text.Replace("m","");
			rtxTexto.Text = rtxTexto.Text.Replace("n","");
			rtxTexto.Text = rtxTexto.Text.Replace("ñ","");
			rtxTexto.Text = rtxTexto.Text.Replace("p","");
			rtxTexto.Text = rtxTexto.Text.Replace("q","");
			rtxTexto.Text = rtxTexto.Text.Replace("r","");
			rtxTexto.Text = rtxTexto.Text.Replace("s","");
			rtxTexto.Text = rtxTexto.Text.Replace("t","");
			rtxTexto.Text = rtxTexto.Text.Replace("v","");
			rtxTexto.Text = rtxTexto.Text.Replace("w","");
			rtxTexto.Text = rtxTexto.Text.Replace("x","");
			rtxTexto.Text = rtxTexto.Text.Replace("y","");	
			rtxTexto.Text = rtxTexto.Text.Replace("z","");
			rtxTexto.Text = rtxTexto.Text.Replace("B","");
			rtxTexto.Text = rtxTexto.Text.Replace("C","");
			rtxTexto.Text = rtxTexto.Text.Replace("D","");
			rtxTexto.Text = rtxTexto.Text.Replace("F","");
			rtxTexto.Text = rtxTexto.Text.Replace("G","");
			rtxTexto.Text = rtxTexto.Text.Replace("H","");
			rtxTexto.Text = rtxTexto.Text.Replace("J","");
			rtxTexto.Text = rtxTexto.Text.Replace("K","");
			rtxTexto.Text = rtxTexto.Text.Replace("L","");
			rtxTexto.Text = rtxTexto.Text.Replace("M","");
			rtxTexto.Text = rtxTexto.Text.Replace("N","");
			rtxTexto.Text = rtxTexto.Text.Replace("Ñ","");
			rtxTexto.Text = rtxTexto.Text.Replace("P","");
			rtxTexto.Text = rtxTexto.Text.Replace("Q","");
			rtxTexto.Text = rtxTexto.Text.Replace("R","");
			rtxTexto.Text = rtxTexto.Text.Replace("S","");
			rtxTexto.Text = rtxTexto.Text.Replace("T","");
			rtxTexto.Text = rtxTexto.Text.Replace("V","");
			rtxTexto.Text = rtxTexto.Text.Replace("W","");
			rtxTexto.Text = rtxTexto.Text.Replace("X","");
			rtxTexto.Text = rtxTexto.Text.Replace("Y","");	
			rtxTexto.Text = rtxTexto.Text.Replace("Z","");			
		
			}
			

			ContarTodo();
			
	
		}
		
		void SFDGuardarComoFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			MessageBox.Show("Guardado exitoso!");
		}
		
		void BtnGuardarComoClick(object sender, EventArgs e)
		{
			var sFDGuardarComo = new SaveFileDialog();
			sFDGuardarComo.Title="Guardar como...";
			sFDGuardarComo.Filter = "Text Files (*.txt)|*.txt";//|RTF Files (*.rtf)|*.rtf"; limitar a formato txt
			sFDGuardarComo.AddExtension = true;
			if (sFDGuardarComo.ShowDialog() == System.Windows.Forms.DialogResult.OK){
    			var extension = Path.GetExtension(sFDGuardarComo.FileName);
    			if(extension.ToLower()==".txt") {
        		rtxTexto.SaveFile(sFDGuardarComo.FileName, RichTextBoxStreamType.PlainText);
    			}/*else{
        		rtxTexto.SaveFile(sFDGuardarComo.FileName, RichTextBoxStreamType.RichText);//innecesario en este caso
    			}*/
			}
	
		}
		
		
		
	}
}
