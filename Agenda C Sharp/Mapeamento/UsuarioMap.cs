using FluentNHibernate.Mapping;
using Agenda_C_Sharp.model;

namespace Agenda_C_Sharp.Mapeamento {
    public class UsuarioMap : ClassMap<Usuario> {

        public UsuarioMap() {
            Id(c => c.id);
            Map(c => c.login);
            Map(c => c.nome);
            Map(c => c.senha);
            Map(c => c.status);
            Table("usuario");
        }
    }
}
