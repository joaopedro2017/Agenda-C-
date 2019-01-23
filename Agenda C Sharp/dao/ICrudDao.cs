using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_C_Sharp.dao {
    public interface ICrudDao<T> {

        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T endidade);
        T retornaPorId(int id);
        IList<T> Consultar();

    }
}
