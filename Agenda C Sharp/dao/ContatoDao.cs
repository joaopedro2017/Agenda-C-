using Agenda_C_Sharp.model;
using Agenda_C_Sharp.util;
using System.Linq;
using NHibernate;

namespace Agenda_C_Sharp.dao {
    public class ContatoDao : RepositoryCrudDao<Contato> {

        public bool validarNome(string nome) {
            ISession session = FluentySessionFactory.AbrirSession();
            return (from e in session.Query<Contato>() where e.nome.Equals(nome) && e.status.Equals("A")
                    select e).Count() > 0;
        }

    }
}
