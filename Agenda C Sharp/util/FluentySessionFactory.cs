using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Agenda_C_Sharp.util {
    public class FluentySessionFactory {

        private static string ConnectionString = "Server=localhost; Port=5432; User Id=postgres;" +
                                                    "Password=1234; Database=agenda";
        private static ISessionFactory session;

        public static ISessionFactory CriarSession() {
            if (session != null) {
                return session;
            }

            IPersistenceConfigurer configBD = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
            var configMap = Fluently.Configure().Database(configBD).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.ContatosMap>());
            session = configMap.BuildSessionFactory();

            return session;
        }

        public static ISession AbrirSession() {
            return CriarSession().OpenSession();
        }

    }
}
