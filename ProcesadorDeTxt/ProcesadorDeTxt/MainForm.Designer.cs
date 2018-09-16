/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/15/2018
 * Time: 8:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProcesadorDeTxt
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnExaminar;
		private System.Windows.Forms.Button btnProcesar;
		private System.Windows.Forms.Button btnGuardarComo;
		private System.Windows.Forms.Label lblQuitar;
		private System.Windows.Forms.Label lblArchivo;
		private System.Windows.Forms.ComboBox cboQuitar;
		private System.Windows.Forms.RichTextBox rtxTexto;
		private System.Windows.Forms.Label lblPalabras;
		private System.Windows.Forms.Label lblCaracteres;
		private System.Windows.Forms.Label lblEspaciosEnBlanco;
		private System.Windows.Forms.Label lblLineas;
		private System.Windows.Forms.Label lblTabuladores;
		private System.Windows.Forms.Label lblVocales;
		private System.Windows.Forms.Label lblConsonantes;
		private System.Windows.Forms.TextBox txtRutaAqui;
		private System.Windows.Forms.OpenFileDialog oFDTxt;
		private System.Windows.Forms.SaveFileDialog sFDGuardarComo;
		
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
			this.btnExaminar = new System.Windows.Forms.Button();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.btnGuardarComo = new System.Windows.Forms.Button();
			this.lblQuitar = new System.Windows.Forms.Label();
			this.lblArchivo = new System.Windows.Forms.Label();
			this.cboQuitar = new System.Windows.Forms.ComboBox();
			this.rtxTexto = new System.Windows.Forms.RichTextBox();
			this.lblPalabras = new System.Windows.Forms.Label();
			this.lblCaracteres = new System.Windows.Forms.Label();
			this.lblEspaciosEnBlanco = new System.Windows.Forms.Label();
			this.lblLineas = new System.Windows.Forms.Label();
			this.lblTabuladores = new System.Windows.Forms.Label();
			this.lblVocales = new System.Windows.Forms.Label();
			this.lblConsonantes = new System.Windows.Forms.Label();
			this.txtRutaAqui = new System.Windows.Forms.TextBox();
			this.oFDTxt = new System.Windows.Forms.OpenFileDialog();
			this.sFDGuardarComo = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// btnExaminar
			// 
			this.btnExaminar.Location = new System.Drawing.Point(636, 4);
			this.btnExaminar.Name = "btnExaminar";
			this.btnExaminar.Size = new System.Drawing.Size(103, 23);
			this.btnExaminar.TabIndex = 0;
			this.btnExaminar.Text = "Examinar";
			this.btnExaminar.UseVisualStyleBackColor = true;
			this.btnExaminar.Click += new System.EventHandler(this.BtnExaminarClick);
			// 
			// btnProcesar
			// 
			this.btnProcesar.Location = new System.Drawing.Point(518, 356);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(75, 23);
			this.btnProcesar.TabIndex = 1;
			this.btnProcesar.Text = "Procesar";
			this.btnProcesar.UseVisualStyleBackColor = true;
			// 
			// btnGuardarComo
			// 
			this.btnGuardarComo.Location = new System.Drawing.Point(636, 356);
			this.btnGuardarComo.Name = "btnGuardarComo";
			this.btnGuardarComo.Size = new System.Drawing.Size(103, 23);
			this.btnGuardarComo.TabIndex = 2;
			this.btnGuardarComo.Text = "Guardar como ...";
			this.btnGuardarComo.UseVisualStyleBackColor = true;
			// 
			// lblQuitar
			// 
			this.lblQuitar.Location = new System.Drawing.Point(12, 356);
			this.lblQuitar.Name = "lblQuitar";
			this.lblQuitar.Size = new System.Drawing.Size(40, 23);
			this.lblQuitar.TabIndex = 3;
			this.lblQuitar.Text = "Quitar:";
			// 
			// lblArchivo
			// 
			this.lblArchivo.Location = new System.Drawing.Point(12, 9);
			this.lblArchivo.Name = "lblArchivo";
			this.lblArchivo.Size = new System.Drawing.Size(49, 23);
			this.lblArchivo.TabIndex = 4;
			this.lblArchivo.Text = "Archivo:";
			// 
			// cboQuitar
			// 
			this.cboQuitar.FormattingEnabled = true;
			this.cboQuitar.Location = new System.Drawing.Point(61, 356);
			this.cboQuitar.Name = "cboQuitar";
			this.cboQuitar.Size = new System.Drawing.Size(121, 21);
			this.cboQuitar.TabIndex = 5;
			// 
			// rtxTexto
			// 
			this.rtxTexto.Enabled = false;
			this.rtxTexto.Location = new System.Drawing.Point(26, 35);
			this.rtxTexto.Name = "rtxTexto";
			this.rtxTexto.Size = new System.Drawing.Size(713, 147);
			this.rtxTexto.TabIndex = 6;
			this.rtxTexto.Text = "";
			// 
			// lblPalabras
			// 
			this.lblPalabras.Location = new System.Drawing.Point(26, 185);
			this.lblPalabras.Name = "lblPalabras";
			this.lblPalabras.Size = new System.Drawing.Size(65, 23);
			this.lblPalabras.TabIndex = 7;
			this.lblPalabras.Text = "Palabras";
			// 
			// lblCaracteres
			// 
			this.lblCaracteres.Location = new System.Drawing.Point(26, 208);
			this.lblCaracteres.Name = "lblCaracteres";
			this.lblCaracteres.Size = new System.Drawing.Size(68, 19);
			this.lblCaracteres.TabIndex = 8;
			this.lblCaracteres.Text = "Caracteres";
			// 
			// lblEspaciosEnBlanco
			// 
			this.lblEspaciosEnBlanco.Location = new System.Drawing.Point(26, 227);
			this.lblEspaciosEnBlanco.Name = "lblEspaciosEnBlanco";
			this.lblEspaciosEnBlanco.Size = new System.Drawing.Size(100, 23);
			this.lblEspaciosEnBlanco.TabIndex = 9;
			this.lblEspaciosEnBlanco.Text = "Espacios en blanco";
			// 
			// lblLineas
			// 
			this.lblLineas.Location = new System.Drawing.Point(26, 273);
			this.lblLineas.Name = "lblLineas";
			this.lblLineas.Size = new System.Drawing.Size(100, 23);
			this.lblLineas.TabIndex = 10;
			this.lblLineas.Text = "Líneas";
			// 
			// lblTabuladores
			// 
			this.lblTabuladores.Location = new System.Drawing.Point(26, 250);
			this.lblTabuladores.Name = "lblTabuladores";
			this.lblTabuladores.Size = new System.Drawing.Size(100, 23);
			this.lblTabuladores.TabIndex = 11;
			this.lblTabuladores.Text = "Tabuladores";
			// 
			// lblVocales
			// 
			this.lblVocales.Location = new System.Drawing.Point(26, 296);
			this.lblVocales.Name = "lblVocales";
			this.lblVocales.Size = new System.Drawing.Size(100, 23);
			this.lblVocales.TabIndex = 12;
			this.lblVocales.Text = "Vocales";
			// 
			// lblConsonantes
			// 
			this.lblConsonantes.Location = new System.Drawing.Point(26, 319);
			this.lblConsonantes.Name = "lblConsonantes";
			this.lblConsonantes.Size = new System.Drawing.Size(79, 22);
			this.lblConsonantes.TabIndex = 13;
			this.lblConsonantes.Text = "Consonantes";
			// 
			// txtRutaAqui
			// 
			this.txtRutaAqui.Enabled = false;
			this.txtRutaAqui.Location = new System.Drawing.Point(67, 9);
			this.txtRutaAqui.Name = "txtRutaAqui";
			this.txtRutaAqui.Size = new System.Drawing.Size(536, 20);
			this.txtRutaAqui.TabIndex = 14;
			// 
			// oFDTxt
			// 
			this.oFDTxt.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 383);
			this.Controls.Add(this.txtRutaAqui);
			this.Controls.Add(this.lblConsonantes);
			this.Controls.Add(this.lblVocales);
			this.Controls.Add(this.lblTabuladores);
			this.Controls.Add(this.lblLineas);
			this.Controls.Add(this.lblEspaciosEnBlanco);
			this.Controls.Add(this.lblCaracteres);
			this.Controls.Add(this.lblPalabras);
			this.Controls.Add(this.rtxTexto);
			this.Controls.Add(this.cboQuitar);
			this.Controls.Add(this.lblArchivo);
			this.Controls.Add(this.lblQuitar);
			this.Controls.Add(this.btnGuardarComo);
			this.Controls.Add(this.btnProcesar);
			this.Controls.Add(this.btnExaminar);
			this.Name = "MainForm";
			this.Text = "Procesador de archivos txt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
