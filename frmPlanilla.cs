using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCaso72
{
    public partial class frmPlanilla : Form
    {
        public frmPlanilla()
        {
            InitializeComponent();
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            mostrarFecha();
            mostrarMesActual();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Capturando los datos
            string empleado = txtEmpleado.Text;
            string cargo = cboCargo.Text;
            DateTime fechaIngreso = dtFechaIngreso.Value;
            int años = int.Parse(txtAños.Text);

            // Objeto de la clase Planilla
            Planilla objP = new Planilla();
            objP.empleado = empleado;
            objP.cargo = cargo;
            objP.fechaIngreso = fechaIngreso;
            objP.años = años;

            // Realizando la impresion de valores
            txtMes.Text = objP.mesConsultado();
            lblBasico.Text = objP.determinaBasico().ToString("C");
            lblGratificacion.Text = objP.determinaGratificacion().ToString("C");
            lblComision.Text = objP.determinaComision().ToString("C");
            lblAFP.Text = objP.determinaDescuentoAFP().ToString("C");
            lblCooperativa.Text = objP.determinaDescuentoCooperativa().ToString("C");
            lblSeguro.Text = objP.determinaAportacionSeguro().ToString("C");

            lblTotalIngresos.Text = objP.calculaTotalIngresos().ToString("C");
            lblTotalDescuentos.Text = objP.calculaTotalDescuento().ToString("C");
            lblTotalAportaciones.Text = objP.calculaTotalAportaciones().ToString("C");

            lblTotal.Text = objP.determinaNeto().ToString("C");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            dtFechaIngreso.Value = DateTime.Now;
            cboCargo.Text = "(Seleccione cargo)";
            txtMes.Clear();
            txtAños.Clear();

            lblBasico.Text = (0).ToString("C");
            lblGratificacion.Text = (0).ToString("C");
            lblComision.Text = (0).ToString("C");
            lblAFP.Text = (0).ToString("C");
            lblCooperativa.Text = (0).ToString("C");
            lblSeguro.Text = (0).ToString("C");

            lblTotalAportaciones.Text = (0).ToString("C");
            lblTotalDescuentos.Text = (0).ToString("C");
            lblTotalIngresos.Text = (0).ToString("C");
            lblTotal.Text = (0).ToString("C");

            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        // IMPLEMENTACIONES DE METODOS
        // 1. Mostrar la fecha Actual
        void mostrarFecha()
        {
            lblFechaActual.Text = DateTime.Now.ToShortDateString();
        }

        void mostrarMesActual()
        {
            txtMes.Text = DateTime.Now.Month.ToString();
        }

        private void dtFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            txtAños.Text = (DateTime.Now.Year - dtFechaIngreso.Value.Year).ToString();
        }
    }
}
