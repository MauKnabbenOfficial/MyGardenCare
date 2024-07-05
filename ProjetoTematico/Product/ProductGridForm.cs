using ProjetoTematico.Controllers;
using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Plant;
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
    public partial class ProductGridForm : Form
    {
        ProductController _controle;
        public ProductGridForm()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow.Cells[0].Value != null)
            {
                var planta = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                ProductForm productForm = new ProductForm(planta)
                {
                    TopLevel = true,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    Text = $"Editar Produto {planta}"
                };

                productForm.Show();
            }
        }

        private void ProductGridForm_Load(object sender, EventArgs e)
        {
            //var produtos = _controle.GetAll();
            var produtos = new List<ProductDto>();
            produtos.Add(new ProductDto()
            {
                Id = 1,
                Nome = "Adubo Premium",
                Observacoes = "Proporção 1:10; Manusear com Cuidado",
                QtdEstoque = 10
            });
            produtos.ForEach(p =>
            {
                dgvProdutos.Rows.Add(p.Id, p.Nome, p.QtdEstoque, p.Observacoes);
            });
        }
    }
}
