using System;
using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class N_Users
    {
        D_Users objData = new D_Users();

        public DataTable N_user(E_Users obj)
        {
            return objData.D_User(obj);
        }

    }
}
