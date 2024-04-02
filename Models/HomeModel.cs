using Project.Util;
using System.Data;

namespace Project.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateOnly Data_Nascimento { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel model;
            List<HomeModel> list = new List<HomeModel>();

            return list;
        }
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
