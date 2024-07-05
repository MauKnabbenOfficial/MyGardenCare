using ProjetoTematico.Controllers;
using ProjetoTematico.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico.Product
{
    public partial class ProductForm : Form
    {
        ProductController _controle;
        public ProductForm()
        {
            _controle = new ProductController();
            InitializeComponent();
        }
        public ProductForm(int id) : this()
        {
            //var product = _controle.GetById(id);
            var product = new ProductDto()
            {
                Id = id,
                Nome = "Adubo",
                Observacoes = "Manusear com luvas",
                QtdEstoque = 10
            };
            popularCampos(product);
        }
        private void popularCampos(ProductDto product)
        {
            this.txtNome.Text = product.Nome;
            this.qtdEstoque.Text = product.QtdEstoque.ToString();
            this.txtObservacoes.Text = product.Observacoes;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var Nome = this.txtNome.Text;
            var QtdEstoque = this.qtdEstoque.Text;
            var Observacoes = this.txtObservacoes.Text;

            try
            {
                ProductDto newProduct = new ProductDto
                {
                    Nome = Nome,
                    QtdEstoque = int.Parse(QtdEstoque),
                    Observacoes = Observacoes
                };

                _controle.CreateProduct(newProduct);

                MessageBox.Show("Planta cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
