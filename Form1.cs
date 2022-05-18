using System;
using System.Text.RegularExpressions;


namespace Analizador
{
    
    public partial class Form1 : Form
    {

        const int INICIO = 0;
        const int ERROR = -1;
        const int Q1 = 1;
        const int Q2 = 2;
        const int Q3 = 3;
        const int Q4 = 4;
        const int Q5 = 5;
        const int Q6 = 6;
        const int Q7 = 7;
        const int Q8 = 8;
        const int Q9 = 9;
        const int Q10 = 10;
        const int Q11 = 11;
        const int Q12 = 12;
        const int Q13 = 13;
        const int Q14 = 14;
        const int Q15 = 15;
        const int Q16 = 16;
        const int Q17 = 17;
        const int Q18 = 18;
        const int Q19 = 19;
        const int Q20 = 20;
        const int Q21 = 21;
        const int Q22 = 22;
        const int Q23 = 23;



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
            string cadena = textBoxInput.Text;
            int estado = INICIO;


            for(int i=0; i<cadena.Length; i++) {

                switch(estado) {
                    case INICIO:
                        if(cadena[i].ToString() == "-")
                            estado = Q1;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q2;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[a-hj-z]"))
                            estado = Q5;
                        else if (cadena[i].ToString() == "i")
                            estado = Q15;
                        
                        else
                            estado = ERROR;
                        break;


                    case Q1:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q2;
                        else if(cadena[i].ToString() == ".")
                            estado = Q3;
                        else
                            estado = ERROR;
                        break;


                    case Q2:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q2;
                        else if(cadena[i].ToString() == ".")
                            estado = Q3;
                        else
                            estado = ERROR;
                        break;


                    case Q3:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q4;
                        else
                            estado = ERROR;
                        break;


                    case Q4:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q4;
                        else
                            estado = ERROR;
                        break;


                    case Q5:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]"))
                            estado = Q5;
                        else if(cadena[i].ToString() == "=")
                            estado = Q6;
                        else
                            estado = ERROR;
                        break;


                    case Q6:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q7;
                        else if(cadena[i].ToString() == "-")
                            estado = Q12;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[a-z]"))
                            estado = Q13;
                        else
                            estado = ERROR;
                        break;


                    case Q7:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[\x2B\x2D\x2A\x2F]"))
                            estado = Q6;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q7;
                        else if(cadena[i].ToString() == ".")
                            estado = Q8;
                        else if(cadena[i].ToString() == ";")
                            estado = Q11;
                        else
                            estado = ERROR;
                        break;


                    case Q8:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q9;
                        else
                            estado = ERROR;
                        break;


                    case Q9:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q9;
                        else if(cadena[i].ToString() == ";")
                            estado = Q10;
                        else
                            estado = ERROR;
                        break;


                    case Q10:
                        break;


                    case Q11:
                        break;


                    case Q12:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q7;
                        else if(cadena[i].ToString() == ".")
                            estado = Q8;
                        else
                            estado = ERROR;
                        break;


                    case Q13:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]"))
                            estado = Q13;
                        else if(cadena[i].ToString() == ";")
                            estado = Q14;
                        else
                            estado = ERROR;
                        break;


                    case Q14:
                        break;


                    case Q15:
                        if(cadena[i].ToString() == "f")
                            estado = Q16;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]"))
                            estado = Q5;
                        else if (cadena[i].ToString() == "=")
                            estado = Q6;
                        else
                            estado = ERROR;
                        break;


                    case Q16:
                        if(cadena[i].ToString() == "(")
                            estado = Q17;
                        else
                            estado = ERROR;
                        break;


                    case Q17:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]"))
                            estado = Q18;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q19;
                        else
                            estado = ERROR;
                        break;


                    case Q18:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]"))
                            estado = Q18;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[\x3E\x3D|\x3C\x3D|\x3E|\x3C|\x21\x3D|\x3D\x3D]"))
                            estado = Q20;
                        else
                            estado = ERROR;
                        break;


                    case Q19:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q19;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[\x3E\x3D|\x3C\x3D|\x3E|\x3C|\x21\x3D|\x3D\x3D]"))
                            estado = Q20;
                        else
                            estado = ERROR;
                        break;


                    case Q20:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]"))
                            estado = Q21;
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q23;
                        else
                            estado = ERROR;
                        break;


                    case Q21:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]"))
                            estado = Q21;
                        else if(cadena[i].ToString() == ")")
                            estado = Q22;
                        else
                            estado = ERROR;
                        break;


                    case Q22:
                        break;


                    case Q23:
                        if (Regex.IsMatch(cadena[i].ToString(), @"\d"))
                            estado = Q23;
                        else if (cadena[i].ToString() == ")")
                            estado = Q22;
                        break;


                    case ERROR:
                        estado = ERROR;
                    break;
                }

            }

                detalles(estado, cadena);
        }


        





    }
}