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
        ProductDto _product;
        public ProductForm()
        {
            _controle = new ProductController();
            InitializeComponent();
        }
        public ProductForm(int id) : this()
        {
            _product = _controle.GetById(id);
            PopularCampos();
        }
        private void PopularCampos()
        {
            this.txtNome.Text = _product.Nome;
            this.qtdEstoque.Text = _product.QtdEstoque.ToString();
            this.txtObservacoes.Text = _product.Observacoes;
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
                    Id = _product?.Id ?? 0,
                    Nome = Nome,
                    QtdEstoque = int.Parse(QtdEstoque),
                    Observacoes = Observacoes
                };

                if (_product != null)
                {
                    _controle.UpdateProduct(newProduct);
                    MessageBox.Show("Produto atualizado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _controle.CreateProduct(newProduct);
                    MessageBox.Show("Produto cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimparCampos()
        {
            this.txtNome.Clear();
            this.txtObservacoes.Clear();
            this.qtdEstoque.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
