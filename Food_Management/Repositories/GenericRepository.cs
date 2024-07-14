using Food_Management.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_Management.Repositories
{
	public class GenericRepository<T> where T: class, new() // 'T' for class
	{
		Context c = new Context();
		public List<T> TList()
		{
			return c.Set<T>().ToList(); // Set<T>() to arrange class
		}
		public void TAdd(T t)
		{
			c.Set<T>().Add(t);
			c.SaveChanges();
		}
		public void TDelete(T t)
		{
			c.Set<T>().Remove(t);
			c.SaveChanges();
		}
		public void TUpdate(T t)
		{
			c.Set<T>().Update(t);
			c.SaveChanges();
		}
		public void TGet(int id)
		{
			c.Set<T>().Find(id);
		}
		//to get name of category each food
        public List<T> TList(string p)
		{
			return c.Set<T>().Include(p).ToList();
		}
    }
}
