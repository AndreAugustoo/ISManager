using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISManager.Class
{
    public sealed class Crud
    {

        private static volatile Crud instance;
        private static object sync = new Object();

        private Crud() { }

        public static Crud Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Crud();
                        }
                    }
                }
                return instance;
            }

        }

        /// Propriedade para o tipo de crud <summary>
        /// 1 = create frmCrudClientes.btnCadastrar
        /// 2 = read frmCrudClientes.btnDetalhar -----------INATIVO------------
        /// 3 = update frmCrudClientes.btnAlterar
        /// 4 = delete frmCrudClientes.btnExcluir
        /// </summary>
        public int TipoCrud { get; set; }
        public bool darkTheme { get; set; }

    }
}
