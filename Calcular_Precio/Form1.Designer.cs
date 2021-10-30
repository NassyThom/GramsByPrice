
namespace Calcular_Precio
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvResultados = new System.Windows.Forms.DataGridView();
			this.cbUnidades = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(27, 55);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(100, 26);
			this.txtCosto.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Costo por Kilo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(546, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cantidad en Gramos";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(550, 62);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 26);
			this.txtCantidad.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(385, 55);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(117, 41);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.Location = new System.Drawing.Point(222, 55);
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.Size = new System.Drawing.Size(100, 26);
			this.txtEfectivo.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(221, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Efectivo";
			// 
			// dgvResultados
			// 
			this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResultados.Location = new System.Drawing.Point(16, 181);
			this.dgvResultados.Name = "dgvResultados";
			this.dgvResultados.RowHeadersWidth = 62;
			this.dgvResultados.RowTemplate.Height = 28;
			this.dgvResultados.Size = new System.Drawing.Size(708, 322);
			this.dgvResultados.TabIndex = 7;
			// 
			// cbUnidades
			// 
			this.cbUnidades.FormattingEnabled = true;
			this.cbUnidades.Items.AddRange(new object[] {
            "25 Gramos",
            "50 Gramos",
            "100 Gramos",
            "Cuarto",
            "3 Cuartos",
            "Medio"});
			this.cbUnidades.Location = new System.Drawing.Point(27, 116);
			this.cbUnidades.Name = "cbUnidades";
			this.cbUnidades.Size = new System.Drawing.Size(141, 28);
			this.cbUnidades.TabIndex = 8;
			this.cbUnidades.SelectedIndexChanged += new System.EventHandler(this.cbUnidades_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Calcular por unidad";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 543);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbUnidades);
			this.Controls.Add(this.dgvResultados);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEfectivo);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCosto);
			this.Name = "Form1";
			this.Text = "Calcula Gramos por precio";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtEfectivo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvResultados;
		private System.Windows.Forms.ComboBox cbUnidades;
		private System.Windows.Forms.Label label4;
	}
}

