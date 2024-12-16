using Datos;
using Trabajo_Final_Final_Integrador;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Final_Integrador;

namespace Trabajo_Final_Final_Integrador
{


    public partial class FormsPrincipal : Form
    {
        ConectionApi ConexionApi;
        public List<ApiProducts> Productos;
        public List<string> Categorias;
        public List<ApiProducts> ProductosFiltrados;



        public FormsPrincipal()
        {
            InitializeComponent();
            Productos = new List<ApiProducts>();
            Categorias = new List<string>();
            ConexionApi = new ConectionApi();

        }

        private void FormsPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ConexionApi.GetProducts(Productos));
            ProductosFiltrados = new List<ApiProducts>();
            ConexionApi.GetCategories(Categorias);

            dataGridView1.DataSource = Productos;

            Categorias.Insert(0, "All");

            CmbBoxCategorias.DataSource = Categorias;

            CmbBoxCategorias.SelectedIndex = 0;

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            using (FormsNuevoProd form = new FormsNuevoProd(this.Productos))
            {

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.Productos = form.NuevosProductos;

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = this.Productos;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var IdsSeleccionados = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int IDseleccionado = Convert.ToInt32(row.Cells["Id"].Value);
                    IdsSeleccionados.Add(IDseleccionado);
                }

                dataGridView1.BindingContext[Productos].SuspendBinding();

                string MensajeResultado = ConexionApi.DeleteProducts(Productos, IdsSeleccionados);
                MessageBox.Show(MensajeResultado);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Productos;

                dataGridView1.BindingContext[Productos].ResumeBinding();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila, gracias.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string categoriaSeleccionada = CmbBoxCategorias.SelectedItem.ToString();

            if (categoriaSeleccionada != "All")
            {
                ConexionApi.SortResults(Productos, BtnOrdenar.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Productos
                    .Where(p => p.Category != null && p.Category.Equals(categoriaSeleccionada)).ToList();
            }
            else
            {
                ConexionApi.SortResults(Productos, BtnOrdenar.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Productos;
            }

            if (BtnOrdenar.Text == "Descendente")
            {
                BtnOrdenar.Text = "Ascendente";
            }
            else
            {
                BtnOrdenar.Text = "Descendente";
            }
        }

        private void CmbBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = CmbBoxCategorias.SelectedItem?.ToString();

            ProductosFiltrados = new List<ApiProducts>(Productos);
            if (selectedCategory == "All")
            {
                dataGridView1.DataSource = Productos;
            }
            else
            {
                ConexionApi.GetInCategory(ProductosFiltrados, selectedCategory);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductosFiltrados;
            }
        }


        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var productosFiltrados = (List<ApiProducts>)dataGridView1.DataSource;
            var productosSeleccionados = productosFiltrados[e.RowIndex];

            using (FormsEditar form = new FormsEditar(productosSeleccionados, this.Productos))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Refresh();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
