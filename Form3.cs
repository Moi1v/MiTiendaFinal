using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//nose

namespace MiTienda
{
    public partial class Employee_management : Form
    {
        public Employee_management()
        {
            InitializeComponent();
            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvEmpleados.AutoGenerateColumns = true;
            cmbSucursal.Items.AddRange(new string[] { "Sucursal 1", "Sucursal 2", "Sucursal 3" });
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime mesSeleccionado = dtpMes.Value;
            string sucursalSeleccionada = cmbSucursal.SelectedItem?.ToString();
            string nombreEmpleado = txtNombre.Text.Trim();
            string idEmpleado = txtIdEmpleado.Text.Trim();

            var empleados = ObtenerEmpleados();

            var datosFiltrados = empleados.Where(emp =>
                (string.IsNullOrEmpty(nombreEmpleado) || emp.Nombre.Contains(nombreEmpleado, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(idEmpleado) || emp.Id == idEmpleado) &&
                (mesSeleccionado == DateTime.MinValue || (emp.Fecha.Month == mesSeleccionado.Month && emp.Fecha.Year == mesSeleccionado.Year)) &&
                (string.IsNullOrEmpty(sucursalSeleccionada) || emp.Sucursal == sucursalSeleccionada)
            ).ToList();

            dgvEmpleados.DataSource = datosFiltrados;

            if (!datosFiltrados.Any())
            {
                MessageBox.Show("No se encontraron registros para los filtros aplicados.");
            }
            else
            {
                lblResumen.Text = $"Total de empleados encontrados: {datosFiltrados.Count}";
            }
        }

        private List<Empleado> ObtenerEmpleados()
        {
            return new List<Empleado>
            {
                new Empleado { Id = "001", Nombre = "Juan Pérez", Fecha = new DateTime(2023, 11, 1), HorasLaboradas = 160, VentasTotales = 5000.00, Sucursal = "Sucursal 1" },
                new Empleado { Id = "002", Nombre = "María López", Fecha = new DateTime(2023, 11, 15), HorasLaboradas = 170, VentasTotales = 5500.00, Sucursal = "Sucursal 2" },
                new Empleado { Id = "003", Nombre = "Carlos Gómez", Fecha = new DateTime(2023, 12, 1), HorasLaboradas = 150, VentasTotales = 4800.00, Sucursal = "Sucursal 1" }
            };
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        public class Empleado
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public DateTime Fecha { get; set; }
            public int HorasLaboradas { get; set; }
            public double VentasTotales { get; set; }
            public string Sucursal { get; set; }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Menu desingform = new Menu();
            desingform.Show();
            this.Hide();
        }
    }
}

