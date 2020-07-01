using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicornDemoApi.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private UnicornDemoContext NetCoreX;
         private BaseRepository<Usuario> _user;
        private BaseRepository<Contacto> _contact;

        public UnitOfWork(UnicornDemoContext dbContext)
        {
            dbContext = DbContext;
        }

        public IRepository<Usuario> Usuarios
             {
            get
            { 
                return _usuario ?? (_usuario = new BaseRepository<User>(dbContext));

            }
        }

        public IRpository<Contacto> Contactos
         {
            get
             {
                return _contact ??
                                    (_contacto = new BaseRepository<Contact>(dbContext));

            }
        }

         public void Save()
        {
            dbContext.SaveChanges();

        }

}
}
