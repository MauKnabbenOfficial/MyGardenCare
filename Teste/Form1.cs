using Microsoft.EntityFrameworkCore;
using ProjetoTematico.Domain;
using ProjetoTematico.Persistence;
using System.Globalization;

namespace Teste
{
    public partial class Form1 : Form
    {
        private List<Jardim> jardins = new List<Jardim>();
        private MyGardenCareContext context = new MyGardenCareContext();
        public Form1()
        {
            InitializeComponent();
            MontaListaJardim();
            MontaComboBoxjaridm();
        }

        private void MontaListaJardim()
        {
            jardins.Add(new Jardim(1, "Jardim1"));
            jardins.Add(new Jardim(2, "Jardim2"));
            jardins.Add(new Jardim(3, "Jardim3"));
            jardins.Add(new Jardim(4, "Jardim4"));
            jardins.Add(new Jardim(5, "Jardim5"));
        }

        private void MontaComboBoxjaridm()
        {
            cbx1Teste.DisplayMember = "Name";
            cbx1Teste.ValueMember = "Id";
            cbx1Teste.DataSource = jardins;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jardim = new Garden();

            context.Add(jardim);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
