using Food_Management.Data.Models;

namespace Food_Management.Repositories
{
	public class GenericRepository<T> where T: class, new()
	{
		Context c = new Context();
		public List<T> CategoryList()
		{
			return c.Set<T>().ToList();
		}
		public void CategoryAdd(T t)
		{
			c.Set<T>().Add(t);
			c.SaveChanges();
		}
		public void CategoryDelete(T t)
		{
			c.Set<T>().Remove(t);
			c.SaveChanges();
		}
		public void CategoryUpdate(T t)
		{
			c.Set<T>().Update(t);
			c.SaveChanges();
		}
		public void GetCategory(int id)
		{
			c.Set<T>().Find(id);
		}
	}
}
