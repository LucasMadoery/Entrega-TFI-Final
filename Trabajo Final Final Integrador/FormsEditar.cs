using Datos;
using Negocio;
using System.ComponentModel;

namespace Trabajo_Final_Integrador
{
    public partial class FormsEditar : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider();
        private ApiProducts producto;
        private readonly ConectionApi conexionApi;
        

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ApiProducts> ProductosEditados { get; private set; }

        public FormsEditar(ApiProducts producto, List<ApiProducts> ListaVieja)
        {
            InitializeComponent();
            this.producto = producto;
            ProductosEditados = ListaVieja;
            conexionApi = new ConectionApi();

            InitializeProductFields(producto);
        }

        private void InitializeProductFields(ApiProducts producto)
        {
            txtBoxIdEdit.Text = producto.Id.ToString();
            txtBoxCategoryEdit.Text = producto.Category;
            txtBoxDescriptionEdit.Text = producto.Description;
            txtBoxTitleEdit.Text = producto.Title;
            txtBoxPriceEdit.Text = producto.Price.ToString();
        }

        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Se necesita corregir los errores para continuar", "Error en la validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updatedProduct = GetUpdatedProductFromFields();

            MessageBox.Show(conexionApi.PutProducts(ProductosEditados, updatedProduct));

            this.Close();
        }

        private ApiProducts GetUpdatedProductFromFields()
        {
            return new ApiProducts
            {
                Id = int.Parse(txtBoxIdEdit.Text),
                Title = txtBoxTitleEdit.Text,
                Price = decimal.Parse(txtBoxPriceEdit.Text),
                Description = txtBoxDescriptionEdit.Text,
                Category = txtBoxCategoryEdit.Text
            };
        }

        private bool ValidateFields()
        {
            bool isValid = true ;

            if (string.IsNullOrWhiteSpace(txtBoxTitleEdit.Text))
            {
                errorProvider.SetError(txtBoxTitleEdit, "Title es obligatorio.")  ;
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtBoxTitleEdit, string.Empty);
            }

            if (!ValidatePrice())
            {
                isValid = false ;
            }

            return isValid ;
        }

        private bool ValidatePrice()
        {
            if (string.IsNullOrWhiteSpace(txtBoxPriceEdit.Text) || !decimal.TryParse(txtBoxPriceEdit.Text, out decimal price) || price <= 0)
            {
                errorProvider.SetError(txtBoxPriceEdit, "El precio debe ser mayor que cero.");
                
               return false ;
            }
            else
            {
                errorProvider.SetError(txtBoxPriceEdit, string.Empty);
                return true;
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormsEdit_Load(object sender, EventArgs e)
        {

        }
    }

}
