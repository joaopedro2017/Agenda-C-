﻿namespace Agenda_C_Sharp.model {
    public class Contato {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual string endereco { get; set; }
        public virtual string bairro { get; set; }
        public virtual string cidade { get; set; }
        public virtual string estado { get; set; }
        public virtual string numero { get; set; }
        public virtual string cep { get; set; }
        public virtual string status { get; set; }
    }
}
