using Project.Util;
using System.Data;

namespace Project.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Data_Nascimento { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT ID, NOME, DATA_NASCIMENTO from usuario where email = '{Email}' and senha= '{Senha}'";
            DAL obj = new DAL();
            DataTable dt = obj.RetDataTable(sql);

            if(dt != null)
            {
                if(dt.Rows.Count == 1)
                {
                    Id = int.Parse(dt.Rows[0]["ID"].ToString());
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Data_Nascimento = DateTime.Parse(dt.Rows[0]["Data_Nascimento"].ToString());
                    return true;
                }
            }
            return false;
        }
    }
}
