using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class FrmEst : Form
    {
        private List<Vehiculo> vehiculos;
        private Vehiculo vehiculo;
        private VehiculoConsultas vehiculoConsultas;
        public FrmEst()
        {
            InitializeComponent();
            vehiculos = new List<Vehiculo>();
            vehiculoConsultas = new VehiculoConsultas();
            vehiculo = new Vehiculo();
            cargarVehiculos();
        }
        private void cargarVehiculos(string filtro = "")
        {
            dtGrdVw.Rows.Clear();
            dtGrdVw.Refresh();
            vehiculos.Clear();
            vehiculos = vehiculoConsultas.ConsultarVehiculos(filtro);

            if (dtGrdVw.Columns.Count == 0)
            {
                dtGrdVw.Columns.Add("Column1", "Placa");
                dtGrdVw.Columns.Add("Column2", "Tipo");
                dtGrdVw.Columns.Add("Column3", "Entrada");
                dtGrdVw.Columns.Add("Column4", "Salida");
                dtGrdVw.Columns.Add("Column5", "Tiempo");
            }


            for (int i = 0; i < vehiculos.Count; i++)
            {
                dtGrdVw.Rows.Add();
                dtGrdVw.Rows[i].Cells[0].Value = vehiculos[i].num_placa;
                dtGrdVw.Rows[i].Cells[1].Value = vehiculos[i].tipo;
                dtGrdVw.Rows[i].Cells[2].Value = vehiculos[i].entrada.ToString("dd/MM/yyyy HH:mm:ss");
                dtGrdVw.Rows[i].Cells[3].Value = vehiculos[i].salida.ToString("dd/MM/yyyy HH:mm:ss");
                dtGrdVw.Rows[i].Cells[4].Value = vehiculos[i].tiempo.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;

            cargarDatosVehiculo();
            if(vehiculoConsultas.AgregarVehiculo(vehiculo))
            {
                MessageBox.Show("Vehiculo agregado correctamente");
                cargarVehiculos();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar vehiculo");
            }
        }
        private void limpiarCampos()
        {
            txtBxPlaca.Clear();
            cmBxTipo.SelectedIndex = -1;
        }
        private void cargarDatosVehiculo()
        {
            vehiculo.idregistro = 0; // Asignar un ID por defecto o manejarlo en la base de datos
            vehiculo.num_placa = txtBxPlaca.Text;
            switch (cmBxTipo.SelectedIndex)
            {
                case 0:
                    vehiculo.tipo = "Residente";
                    break;
                case 1:
                    vehiculo.tipo = "No residente";
                    break;
                case 2:
                    vehiculo.tipo = "Vehiculo oficial";
                    break;
                default:
                    MessageBox.Show("Favor de seleccionar un tipo de vehiculo");
                    return;
            }
            vehiculo.entrada = DateTime.Now;
            vehiculo.create_date = DateTime.Now;
            vehiculo.moified_date = DateTime.Now;
        }
        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtBxPlaca.Text))
            {
                MessageBox.Show("Favor de ingresar un numero de placa");
                return false;
            }
            return true;
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;

            cargarDatosVehiculo();
            if (vehiculoConsultas.modificarVehiculo(vehiculo))
            {
                MessageBox.Show("Salida agregada correctamente");
                cargarVehiculos();
                limpiarCampos();
            }
        }

        private void dtGrdVw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGrdVw.Rows[e.RowIndex];
            txtBxPlaca.Text = row.Cells[0].Value.ToString();
            cmBxTipo.SelectedIndex = 1;
        }
    }
}
