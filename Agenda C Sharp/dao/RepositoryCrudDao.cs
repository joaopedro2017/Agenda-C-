using Agenda_C_Sharp.util;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Agenda_C_Sharp.dao {
    public class RepositoryCrudDao<T> : ICrudDao<T> where T : class {
        public void Alterar(T entidade) {
            ISession session = FluentySessionFactory.AbrirSession();
            ITransaction transaction = session.BeginTransaction();

            try {
                session.Update(entidade);
                transaction.Commit();
            } catch (Exception e) {
                if (!transaction.WasCommitted) {
                    transaction.Rollback();
                }
                throw new Exception("Erro ao alterar entidade: " + e.Message);
            }
        }

        public IList<T> Consultar() {
            ISession session = FluentySessionFactory.AbrirSession();
            return (from e in session.Query<T>() select e).ToList();
        }

        public void Excluir(T entidade) {
            ISession session = FluentySessionFactory.AbrirSession();
            ITransaction transaction = session.BeginTransaction();

            try {
                session.Delete(entidade);
                transaction.Commit();
            } catch (Exception e) {
                if (!transaction.WasCommitted) {
                    transaction.Rollback();
                }
                throw new Exception("Erro ao excluir entidade: " + e.Message);
            }
        }

        public void Inserir(T entidade) {
            ISession session = FluentySessionFactory.AbrirSession();
            ITransaction transaction = session.BeginTransaction();

            try {
                session.Save(entidade);
                transaction.Commit();
            } catch (Exception e) {
                if (!transaction.WasCommitted) {
                    transaction.Rollback();
                }
                throw new Exception("Erro ao inserir entidade: " + e.Message);
            }

        }

        public T retornaPorId(int id) {
            ISession session = FluentySessionFactory.AbrirSession();
            return session.Get<T>(id);
        }
    }
}
