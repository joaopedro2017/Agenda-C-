using Agenda_C_Sharp.model;
using Agenda_C_Sharp.util;
using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace Agenda_C_Sharp.dao {
    public class TelefoneDao : RepositoryCrudDao<Telefone> {

        public List<Telefone> retornarPorContato(int contato) {
            ISession session = FluentySessionFactory.AbrirSession();
            return (from e in session.Query<Telefone>() where e.id_contato.Equals(contato) select e).ToList();
        }

    }
}
