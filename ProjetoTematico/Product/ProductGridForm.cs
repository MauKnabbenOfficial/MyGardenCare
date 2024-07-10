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
            _controle = new ProductController();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow.Cells[0].Value != null)
            {
                var id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                ProductForm productForm = new ProductForm(id)
                {
                    TopLevel = true,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    Text = $"Editar Produto {id}"
                };

                productForm.ShowDialog();
                ProductGridForm_Load(sender, e);
            }
        }

        private void ProductGridForm_Load(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();

            var produtos = _controle.GetAll();            
            produtos.ForEach(p =>
            {
                dgvProdutos.Rows.Add(p.Id, p.Nome, p.QtdEstoque, p.Observacoes);
            });
        }
    }
}
