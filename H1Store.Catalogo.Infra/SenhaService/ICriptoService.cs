using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Infra.SenhaService
{
    public interface ICriptoService
    {
        public string SenhaCriptografada(string senha);
    }
}
