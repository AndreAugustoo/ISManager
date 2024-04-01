using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISManager.Class
{
    public static class Exit
    {
        public static void ConfigurarBotaoFechar(Button btnSair)
        {
            btnSair.Click += (sender, e) =>
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente sair do sistema?", "ISManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                }
            };
        }
    }
}