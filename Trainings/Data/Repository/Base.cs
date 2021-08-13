using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Models;

namespace Data.Repository
{
        class Base<T> where T : Base
        {
            public void Create(T model)
            {
                using (var context = new TrainingsContext())
                {
                    context.Set<T>().Add(model);
                    context.SaveChanges();
                }
            }
            public List<T> Read(T model)
            {
                List<T> list = new List<T>();
                using (var context = new TrainingsContext())
                {
                    list = context.Set<T>().ToList();
                }
                return list;
            }
            public T ReadById(int id)
            {
                T model = Activator.CreateInstance<T>();
                using (var context = new TrainingsContext())
                {
                    model = context.Set<T>().Find(id);
                }
                return model;
            }
            public void Update(T model)
            {
                using (var context = new TrainingsContext())
                {
                    context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            public void Delete(int id)
            {
                using (var context = new TrainingsContext())
                {
                    context.Entry<T>(this.ReadById(id)).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }
}
