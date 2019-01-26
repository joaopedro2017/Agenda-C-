using Agenda_C_Sharp.model;
using System.Linq;
using NHibernate;
using System.Collections.Generic;

namespace Agenda_C_Sharp.dao {
    public class UsuarioDao : RepositoryCrudDao<Usuario> {

        public bool validarLogin(string login) {
            ISession session = util.FluentySessionFactory.AbrirSession();
            return (from e in session.Query<Usuario>() where e.login.Equals(login) select e).Count() > 0;
        }

        public IList<Usuario> ordernarPorNome() {
            ISession session = util.FluentySessionFactory.AbrirSession();
            IList<Usuario> list = (from e in session.Query<Usuario>() select e).ToList();            
            IEnumerable<Usuario> sortEnum = list.OrderBy(u => u.nome);           
            return sortEnum.ToList();            
        }

        public IList<Usuario> ordernarPorLogin() {
            ISession session = util.FluentySessionFactory.AbrirSession();
            IList<Usuario> list = (from e in session.Query<Usuario>() select e).ToList();
            IEnumerable<Usuario> sortEnum = list.OrderBy(u => u.login);
            return sortEnum.ToList();            
        }
    }
}
