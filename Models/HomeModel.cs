using Project.Util;
using System.Data;

namespace Project.Models
{
    public class HomeModel
    {
        public string LerNomeUsuario()
        {
            DAL dal = new DAL();
            DataTable dt = dal.RetDataTable("select * from usuario");

            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["Nome"].ToString();
                }
            }

            return "Nome não encontrado";
        }
    }
}
