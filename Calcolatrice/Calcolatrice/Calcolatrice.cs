using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    class Calcolatrice
    {
        public decimal Display { get; set; }
        public decimal Result { get; set; }
        public string Operazione { get; set; }

        public Calcolatrice()
        {
            this.Display = 0;
            this.Result = 0;
        }

        public void Tastiera(string bottone)
        {
            switch (bottone)
            {
                case "+":svolgiOperazione();
                    this.Operazione = "+";
                    break;
                case "-":svolgiOperazione();
                    this.Operazione = "-";
                    break;
                case "*":svolgiOperazione();
                    this.Operazione = "*";
                    break;
                case "/":svolgiOperazione();
                    this.Operazione = "/";
                    break;
                case "=":svolgiOperazione();
                    this.Operazione = null;
                    break;
                case "C":this.Display = 0;
                    this.Result = 0;
                    break;
            }
        }

        private void svolgiOperazione() {
            switch (this.Operazione)
            {
                case "+":
                    this.somma();
                    break;
                case "-":
                    this.sottrazione();
                    break;
                case "*":
                    this.moltiplicazione();
                    break;
                case "/":
                    this.divisione();
                    break;
                default:Result=Display;
                    break;
            }
        }

        private void somma()
        {
            Result += Display;
        }
        private void sottrazione()
        {
            Result -= Display;
        }
        private void moltiplicazione()
        {
            Result *= Display;
        }
        private void divisione()
        {
            try
            {
                Result /= Display;

            }
            catch (DivideByZeroException d)
            {
                MessageBox.Show("ERRORE, DIVISIONE PER ZERO : " + d.StackTrace);
            }
        }
    }
}
