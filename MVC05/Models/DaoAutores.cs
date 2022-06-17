using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC05.Models
{
    public class DaoAutores
    {
        public void autoresIns(autores autor)
        {
            using(var db = new ModelFrases())
            {
                db.autores.Add(autor);
                db.SaveChanges();
            }
        }

        public void autoresDel(int idautor)
        {
            using (var db = new ModelFrases())
            {
                var autor = db.autores.Find(idautor);
                db.autores.Remove(autor);
                db.SaveChanges();
            }
        }

        public void autoresUpd(autores autor)
        {
            using (var db = new ModelFrases())
            {
                var a = db.autores.Find(autor.idautor);
                a.autor = autor.autor;
                db.SaveChanges();
            }
        }
    }
}