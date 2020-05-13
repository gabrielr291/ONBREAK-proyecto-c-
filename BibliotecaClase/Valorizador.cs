using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDALC;
namespace BibliotecaClase
{
    public class Valorizador
    {
        private BibliotecaDALC.Contrato bdd = new BibliotecaDALC.Contrato();
        private OnBreakEntities bdd1 = new OnBreakEntities();
        public Valorizador()
        {

        }
        public float RecargoAsistente(int asistentes, string evento)
        {
            float v_nper = 0;
            int i = 0;
           
            switch (evento)
            {
                case "Coffee Break":
                    if (asistentes >= 20)
                    {
                        v_nper = 3;
                    }
                    if (asistentes >= 21 && asistentes <= 50)
                    {
                        v_nper = 5;
                    }
                    if (asistentes > 50)
                    {
                        v_nper =(float)(5 * ((0.5)*(asistentes-50)));
                       
                    }

                    break;
                case "Cocktail":
                    if (asistentes >= 20)
                    {
                        v_nper = 2;
                    }
                    if (asistentes >= 21 && asistentes <= 50)
                    {
                        v_nper = 3;
                    }
                    if (asistentes > 50)
                    {
                        v_nper = (float)(3.5 * ((0.5) * (asistentes - 50)));

                    }

                    break;
                case "Cenas":
                    if (asistentes >= 20)
                    {
                        v_nper = (float)1.5*asistentes;
                    }
                    if (asistentes >= 21 && asistentes <= 50)
                    {
                        v_nper = (float)1.2*asistentes;
                    }
                    if (asistentes > 50)
                    {
                        v_nper = (float)(5*asistentes);

                    }

                    break;

            }
            return v_nper;
        }

        public float PersonaAdicional(int personalAdicional, string evento)
        {
            float v_perAdic = 0;
            

            ////Just for you, only to play <3

            switch (evento)
            {
                case "Coffee Break":
                    switch (personalAdicional)
                    {

                        case 2:
                            v_perAdic = 2;
                            break;

                        case 3:
                            v_perAdic = 3;
                            break;
                        case 4:
                            v_perAdic = (float)(3.5);
                            break;
                        default:
                            v_perAdic = (float)(3.5 + (0.5 * personalAdicional));

                            break;
                    }

                    break;
                case "Cocktail":
                    switch (personalAdicional)
                    {

                        case 2:
                            v_perAdic = 2;
                            break;

                        case 3:
                            v_perAdic = 3;
                            break;
                        case 4:
                            v_perAdic = (float)(3.5);
                            break;
                        default:
                            v_perAdic = (float)(3.5 + (0.5 * personalAdicional));

                            break;
                    }

                    break;
                case "Cenas":
                    switch (personalAdicional)
                    {

                        case 2:
                            v_perAdic = 3;
                            break;

                        case 3:
                            v_perAdic = 4;
                            break;
                        case 4:
                            v_perAdic = (float)(5);
                            break;
                        default:
                            v_perAdic = (float)(5 + (0.5 * personalAdicional));

                            break;
                    }


                    break;

            }
            return v_perAdic;
        } 

        public double ValorBasetipo(string evento,int valorBasal ,bool musicaAmb, bool ambienta,bool amPerso, bool local, int convenido, bool alimVeg)
        {
            ModalidadServicio ti = new ModalidadServicio();

            var x = bdd1.TipoEvento.ToList();
            var x2 = bdd1.ModalidadServicio.ToList();
           
            double v_valor = 0;

            int v_musica = 0;
            int v_ambiente = 0;
            int v_local = 0;
            switch (evento)
            {
                case "Coffee Break":
                    v_valor = valorBasal;
                    
                    break;
                case "Cocktail":
                    if (musicaAmb == true)
                    {
                        v_musica = 1;
                    }
                    else
                    {
                        v_musica = 0;
                    }
                    if (ambienta == true)
                    {
                        v_ambiente = 2;
                    }
                    if (amPerso)
                    {
                        v_ambiente = 5;
                    }
                    v_valor = valorBasal + v_musica + v_ambiente;
                            break;
                        case "Cenas":
                            if (local == true)
                            {
                                v_local = 9;
                            }
                            else
                            {
                                v_valor = convenido;
                            }
                            if (musicaAmb == true)
                            {
                                v_musica = 1;
                            }
                            if (ambienta == true)
                            {
                                v_ambiente = 2;
                            }
                            if (amPerso ==true)
                            {
                                v_ambiente = 5;
                            }

                            v_valor = valorBasal + v_musica + v_ambiente + v_local;

                            break;
                
            }
            return v_valor;
        }

        public float ValorContrato(string tyEVEN,int valBase ,int personalAdicional, int asistentes, bool musicaAmb, bool ambienta,bool amPerso, bool local, int convenido, bool alimVeg)
        {
            // en contrato esta el personal adicional
            // y el valor base esta en Modalidad Servicio
            float valor_evento = 0;
            try
            {

                valor_evento = RecargoAsistente(asistentes, tyEVEN) + PersonaAdicional(personalAdicional, tyEVEN) + float.Parse("" + ValorBasetipo(tyEVEN,valBase,musicaAmb, ambienta,amPerso, local, convenido, alimVeg));
                return valor_evento;

            }
            catch (Exception)
            {

                throw;


            }
        }


    }
}

