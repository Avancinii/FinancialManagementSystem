namespace Project.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel model;
            List<HomeModel> list = new List<HomeModel>();

            model = new HomeModel();
            model.Id = 1;
            model.Name = "Gustavo Avancini";
            list.Add(model);

            model = new HomeModel();
            model.Id = 2;
            model.Name = "Alexandre Fialho";
            list.Add(model);

            return list;
        }
    }
}
