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
        UserController _userController;
        public ProductGridForm(UserDto usuarioLogado)
        {
            InitializeComponent();
            _controle = new ProductController(usuarioLogado);
            _userController = new UserController(usuarioLogado);

            try
            {
                _userController.CheckSysAdmin();

            }
            catch
            {
                btnExcluir.Visible = false;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow.Cells[0].Value != null)
            {
                var res = MessageBox.Show($"Tem certeza que deseja excluir o produto {dgvProdutos.CurrentRow.Cells[1].Value}", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                    _controle.DeleteProduct(id);
                }
                ProductGridForm_Load(sender, e);
            }
        }
    }
}
