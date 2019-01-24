using Agenda_C_Sharp.model;
using System.Linq;
using NHibernate;

namespace Agenda_C_Sharp.dao {
    public class UsuarioDao : RepositoryCrudDao<Usuario> {

        public bool validarLogin(string login) {
            ISession session = util.FluentySessionFactory.AbrirSession();
            return (from e in session.Query<Usuario>() where e.login.Equals(login) select e).Count() > 0;
        }
    }
}
