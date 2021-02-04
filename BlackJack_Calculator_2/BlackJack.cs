using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Calculator_2
{
    public class BlackJack
    {
        public BlackJack()
        {
            Cartas = new List<Carta>();
            ManoDealer = new List<Carta>();
            ManoPlayer1 = new List<Carta>();
            ManoPlayer2 = new List<Carta>();
        }

        public List<Carta> Cartas { get; set; }
        public List<Carta> ManoDealer { get; set; }
        public List<Carta> ManoPlayer1 { get; set; }
        public List<Carta> ManoPlayer2 { get; set; }

        /*public void ConstruirMazo(int NumMazos)
        {
            for (int i = 1; i < 14; i++)
            {
                var test = new Carta();

                if (i==1)
                {
                    test.Numero = 11;
                }
                else
                {
                    test.Numero = i;
                }
                test.Cantidad = 4 * NumMazos;

                if (i > 1 && i < 7)
                {
                    test.Valor = 1;
                }
                else if (i == 1 || i > 9)
                {
                    test.Valor = -1;
                }
                else
                {
                    test.Valor = 0;
                }
                Cartas.Add(test);
            }
        }*/

        public void ConstruirMazo(int NumMazos)
        {
            for (int i = 1; i < 11; i++)
            {
                var test = new Carta();

                if (i == 1)
                {
                    test.Numero = 11;
                    test.Cantidad = 4 * NumMazos;
                }
                else if (i==10)
                {
                    test.Numero = i;
                    test.Cantidad = 16 * NumMazos;
                }
                else
                {
                    test.Numero = i;
                    test.Cantidad = 4 * NumMazos;
                }

                if (i > 1 && i < 7)
                {
                    test.Valor = 1;
                }
                else if (i == 1 || i > 9)
                {
                    test.Valor = -1;
                }
                else
                {
                    test.Valor = 0;
                }
                Cartas.Add(test);
            }
        }

        public void AgregarCartaDealer(int numero)
        {
            for (int i = 0; i < Cartas.Count; i++)
            {
                if (Cartas[i].Numero == numero && Cartas[i].Cantidad != 0)
                {
                    var test = new Carta();
                    Cartas[i].Cantidad = Cartas[i].Cantidad - 1;
                    test.Numero = Cartas[i].Numero;
                    test.Valor = Cartas[i].Valor;
                    ManoDealer.Add(test);
                    break;
                }
            }
         }

        public int CalcularDealer()
        {
            int cuenta = 0;
            for (int i = 0; i < ManoDealer.Count; i++)
            {
                cuenta = cuenta + ManoDealer[i].Numero;
            }
            if (cuenta>21)
            {
                bool verif = false;
                for (int i = 0; i < ManoDealer.Count; i++)
                {
                    if (ManoDealer[i].Numero==11 && verif==false)
                    {
                        verif = true;
                    }
                    else if (ManoDealer[i].Numero == 11 && verif == true)
                    {
                        cuenta = cuenta - 10;
                    }
                }
            }
            return cuenta;
        }

        public void AgregarCartaPlayer1(int numero)
        {
            for (int i = 0; i < Cartas.Count; i++)
            {
                if (Cartas[i].Numero == numero && Cartas[i].Cantidad != 0)
                {
                    var test = new Carta();
                    Cartas[i].Cantidad = Cartas[i].Cantidad - 1;
                    test.Numero = Cartas[i].Numero;
                    test.Valor = Cartas[i].Valor;
                    ManoPlayer1.Add(test);
                    break;
                }
            }
        }

        public int CalcularPlayer1()
        {
            int cuenta = 0;
            for (int i = 0; i < ManoPlayer1.Count; i++)
            {
                cuenta = cuenta + ManoPlayer1[i].Numero;
            }
            if (cuenta > 21)
            {
                bool verif = false;
                for (int i = 0; i < ManoPlayer1.Count; i++)
                {
                    if (ManoPlayer1[i].Numero == 11 && verif == false)
                    {
                        cuenta = cuenta - 10;
                    }
                }
            }
            return cuenta;
        }

        public void AgregarCartaPlayer2(int numero)
        {
            for (int i = 0; i < Cartas.Count; i++)
            {
                if (Cartas[i].Numero == numero && Cartas[i].Cantidad != 0)
                {
                    var test = new Carta();
                    Cartas[i].Cantidad = Cartas[i].Cantidad - 1;
                    test.Numero = Cartas[i].Numero;
                    test.Valor = Cartas[i].Valor;
                    ManoPlayer2.Add(test);
                    break;
                }
            }
        }

        public int CalcularPlayer2()
        {
            int cuenta = 0;
            for (int i = 0; i < ManoPlayer2.Count; i++)
            {
                cuenta = cuenta + ManoPlayer2[i].Numero;
            }
            if (cuenta > 21)
            {
                bool verif = false;
                for (int i = 0; i < ManoPlayer2.Count; i++)
                {
                    if (ManoPlayer2[i].Numero == 11 && verif == false)
                    {
                        cuenta = cuenta - 10;
                    }
                }
            }
            return cuenta;
        }

        public int HighLow(int numero,int input)
        {
            int hl=0;
            for (int i = 0; i < Cartas.Count; i++)
            {
                if (Cartas[i].Numero==input)
                {
                    hl = numero + Cartas[i].Valor;
                    break;
                }
            }
            return hl;
        }

        public int ActualizarRestantes(int numero)
        {
            int restantes = 0;
            for (int i = 0; i < Cartas.Count; i++)
            {
                if (Cartas[i].Numero==numero)
                {
                    restantes = Cartas[i].Cantidad;
                    break;
                }
            }
            return restantes;
        }

        public void Split()
        {
            ManoPlayer1.Remove(ManoPlayer1[1]);
            ManoPlayer2.Add(ManoPlayer1[0]);
        }

        public bool RevisarIguales()
        {
            bool iguales = false;
            if (ManoPlayer1.Count == 2 && ManoPlayer1[0].Numero==ManoPlayer1[1].Numero)
            {
                iguales = true;
            }
            return iguales;
        }

        public void Ronda()
        {
            for (int i = 0; i < ManoPlayer1.Count; i++)
            {
                ManoPlayer1.Remove(ManoPlayer1[i]);
            }
            for (int i = 0; i < ManoPlayer2.Count; i++)
            {
                ManoPlayer2.Remove(ManoPlayer2[i]);
            }
            for (int i = 0; i < ManoDealer.Count; i++)
            {
                ManoDealer.Remove(ManoDealer[i]);
            }
        }

        public decimal BlackJackPlayer()
        {
            decimal prob = 0;
            decimal cantidad10 =0;
            decimal cantidadas = 0;
            decimal cantidadTotales =0;
            decimal prob10;
            decimal probas;
            for (int i = 0; i < Cartas.Count; i++)
            {
                if (Cartas[i].Numero==10)
                {
                    cantidad10 = cantidad10 + Cartas[i].Cantidad;
                }
                else if(Cartas[i].Numero==11)
                {
                    cantidadas = cantidadas + Cartas[i].Cantidad;
                }
            }
            for (int i = 0; i < Cartas.Count; i++)
            {
                cantidadTotales = cantidadTotales + Cartas[i].Cantidad;
            }
            prob10 = cantidad10 / cantidadTotales;
            probas = cantidadas / (cantidadTotales-1);
            prob = 2 * ((prob10) * (probas));
            prob = Math.Truncate(prob * 10000)/100;
            return prob;
        }

        public void Limpiar()
        {
            for (int i = 0; i < ManoPlayer1.Count; i++)
            {
                ManoPlayer1.Remove(ManoPlayer1[i]);
            }
            for (int i = 0; i < ManoPlayer2.Count; i++)
            {
                ManoPlayer2.Remove(ManoPlayer2[i]);
            }
            for (int i = 0; i < ManoDealer.Count; i++)
            {
                ManoDealer.Remove(ManoDealer[i]);
            }
            for (int i = 0; i < Cartas.Count; i++)
            {
                Cartas.Remove(Cartas[i]);
            }
        }

        public int Mazo()
        {
            int respuesta=0;
            for (int i = 0; i < Cartas.Count; i++)
            {
                respuesta = respuesta + Cartas[i].Cantidad;
            }
            return respuesta;
        }

        public decimal probCantidad(int cuenta,int objetivo)
        {
            decimal probTotal = 0;
            decimal prob;
            int falta = objetivo - cuenta;
            int mazo = Mazo();
            for (int i = 0; i < Cartas.Count; i++)
            {
                if (Cartas[i].Numero==falta)
                {
                    probTotal = probTotal + Cartas[i].Cantidad / mazo;
                }
                for (int j = 0; j < Cartas.Count; j++)
                {
                    if (Cartas[i].Numero+Cartas[j].Numero==falta)
                    {
                        prob = (Cartas[i].Cantidad / mazo) * (Cartas[j].Cantidad / (mazo - 1));
                        probTotal = probTotal + prob;
                    }
                    for (int k = 0; k < Cartas.Count; k++)
                    {
                        if (Cartas[i].Numero + Cartas[j].Numero + Cartas[k].Cantidad == falta)
                        {
                            prob = (Cartas[i].Cantidad / mazo) * (Cartas[j].Cantidad / (mazo - 1)) * (Cartas[k].Cantidad/(mazo-2));
                            probTotal = probTotal + prob;
                        }
                        for (int n = 0; n < Cartas.Count; n++)
                        {
                            if (Cartas[i].Numero + Cartas[j].Numero + Cartas[k].Cantidad + Cartas[n].Cantidad == falta)
                            {
                                prob = (Cartas[i].Cantidad / mazo) * (Cartas[j].Cantidad / (mazo - 1)) * (Cartas[k].Cantidad / (mazo - 2)) * (Cartas[n].Cantidad / (mazo - 3));
                                probTotal = probTotal + prob;
                            }
                        }
                    }
                }
            }
            return probTotal*100;
        }
    }
}