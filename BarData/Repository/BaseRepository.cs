using BarData.Context;
using BarData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarData.Repository
{
    class BaseRepository<T> where T : BaseModel
    {
        public void Create(T model)
        {
            using (var context = new BarContext())
            {
                context.Set<T>().Add(model);
            }
        }
        public List<T> Read()
        {
            List<T> list = new List<T>();
            using (var context = new BarContext())
            {
                list.Add(context.Set<T>().Find());
            }
            return list;
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new BarContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public void Delete(int id)
        {
            using (var context = new BarContext())
            {
                context.Entry<T>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
            }
        }
        public void Edit(T model)
        {
            using (var context = new BarContext())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
            }
        }

    }
}
