using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_C_Sharp.Helper {
    public class Funcoes {
        
        public static bool validarEmail(TextBox textBox, ErrorProvider errorProvider) {
            string email = textBox.Text;
            string modelo = @"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+";

            if (Regex.IsMatch(email, modelo)) {
                errorProvider.SetError(textBox, "");
                return true;
            } else {
                errorProvider.SetError(textBox, "Email inválido.");
                return false;
            }
        }

        public static bool validarURL(TextBox textBox, ErrorProvider errorProvider) {
            string site = textBox.Text;
            string modelo = @"((https?|ftp|gopher|telnet|file|notes|ms-help):((//)|(\\\\))+[\w\d:#@%/;$()~_?\+-=\\\.&]*)";

            if (Regex.IsMatch(site, modelo)) {
                errorProvider.SetError(textBox, "");
                return true;
            } else {
                errorProvider.SetError(textBox, "Site inválido.");
                return false;
            }
        }

    }
}
