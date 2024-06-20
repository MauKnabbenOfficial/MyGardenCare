using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico
{
    public class BaseControl : Form
    {
        /// <summary>
        /// Utilizado para renderizar formulário como filho em um obj panel pai
        /// </summary>
        public void SetToPanelChildForm()
        {
            // Ajustar propriedades do formulário filho
            this.TopLevel = false; // Define que este formulário não é um formulário de nível superior
            this.FormBorderStyle = FormBorderStyle.None; // Remove a borda e os botões de controle
            this.Dock = DockStyle.Fill; // Faz com que o formulário ocupe todo o espaço disponível no container
        }
    }
}
