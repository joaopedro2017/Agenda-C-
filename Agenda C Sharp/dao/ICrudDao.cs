using System.Collections.Generic;

namespace Agenda_C_Sharp.dao {
    public interface ICrudDao<T> {

        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T endidade);
        T retornaPorId(int id);
        IList<T> Consultar();

    }
}
