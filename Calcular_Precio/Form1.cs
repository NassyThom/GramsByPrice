using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calcular_Precio
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}
		public int Caso = 0;
		const int kilo = 1000;
		public int costo, TotalDinero = 0;

		private void Form1_Load(object sender, EventArgs e)
		{



		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidaDatos())
				{
					costo = Convert.ToInt32(txtCosto.Text);
					TotalDinero = Convert.ToInt32(txtEfectivo.Text);
					var precio = (TotalDinero * kilo) / costo;
					txtCantidad.Text = precio.ToString();
					//Se divide en 10 partes la variable kilo se agrega en una lista
					Caso = 0;
					LlenarGridView(kilo, ObtieneUnidad(), costo);

				}
				else
				{
					MessageBox.Show("¡Ingresa datos validos en Costo por Kilo y Efectivo!");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("ops.. error en conversión de datos! \n Error: " + ex.Message);
			}


		}


		private void cbUnidades_SelectedIndexChanged(object sender, EventArgs e)
		{

			LlenarGridView(kilo, ObtieneUnidad(), costo);
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Realiza calculos para llenar el Listado con relación del Gramo y Costo
		/// </summary>
		/// <param name="kilo">El total de gramos de un kilo</param>
		/// <param name="unidad">Cantidad de veces que debe divir la varible kilo</param>
		/// <param name="costo">Costo equivalente por kilo</param>
		private void LlenarGridView(int kilo, int unidad, int costo)
		{
			List<clsCantidadPrecio> lstCantidadPrecio = new List<clsCantidadPrecio>();
			for (int i = 1; i <= (kilo / unidad); i++)
			{
				lstCantidadPrecio.Add(new clsCantidadPrecio() { Costo = Convert.ToInt32(Convert.ToDecimal(costo) / Convert.ToDecimal(kilo) * (i * unidad)), Gramos = i * unidad });
			}
			dgvResultados.DataSource = lstCantidadPrecio;
		}

		/// <summary>
		/// Obtiene el valor del enumerable
		/// </summary>
		/// <returns>Caso</returns>
		public int ObtieneUnidad()
		{
			switch (cbUnidades.SelectedItem)
			{
				case "25 Gramos":
					Caso = (int)EnumUnidades.Gramos25;
					break;
				case "50 Gramos":
					Caso = (int)EnumUnidades.Gramos50;
					break;
				case "100 Gramos":
					Caso = (int)EnumUnidades.Gramos100;
					break;
				case "Cuarto":
					Caso = (int)EnumUnidades.Cuarto;
					break;
				case "3 Cuartos":
					Caso = (int)EnumUnidades.Cuatos3;
					break;
				case "Medio":
					Caso = (int)EnumUnidades.Medio;
					break;
				default:
					Caso = (int)EnumUnidades.Gramos100;
					break;
			}
			return Caso;

		}

		public bool ValidaDatos()
		{
			if (String.IsNullOrWhiteSpace(txtCosto.Text) || String.IsNullOrWhiteSpace(txtEfectivo.Text))
				return false;
			return true;

		}
	}
}
