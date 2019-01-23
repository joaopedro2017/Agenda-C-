using FluentNHibernate.Mapping;
using Agenda_C_Sharp.model;

namespace Agenda_C_Sharp.Mapeamento {
    public class ContatoMap : ClassMap<Contato> {

        public ContatoMap() {
            Id(c => c.id);
            Map(c => c.bairro);
            Map(c => c.nome);
            Map(c => c.cep);
            Map(c => c.cidade);
            Map(c => c.endereco);
            Map(c => c.estado);
            Map(c => c.numero);
            Map(c => c.status);
            Table("contato");
        }
    }
}
