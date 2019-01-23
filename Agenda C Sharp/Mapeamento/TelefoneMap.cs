using FluentNHibernate.Mapping;
using Agenda_C_Sharp.model;

namespace Agenda_C_Sharp.Mapeamento {
    public class TelefoneMap : ClassMap<Telefone> {

        public TelefoneMap() {
            Id(c => c.id);
            Map(c => c.email);
            Map(c => c.id_Contatos);
            Map(c => c.site);
            Map(c => c.telefone);
            Table("telefone");
        }
    }
}
