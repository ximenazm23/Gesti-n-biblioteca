using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallersgb_Ximena_zamudio
{
    public interface IBliblioteca
    {

        void Mostrarcatalogo();

        void Devolverlibro(string titulo);
    }
}
