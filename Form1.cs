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

            for (int i = 0; i < cadena.Length; i++)
            {

                switch (estado)
                {
                    case INICIO:
                        break;


                    case Q1:
                        break;


                    case Q2:
                        break;

                    case Q3:
                        break;



                    case Q4:
                        break;


                    case Q5:
                        break;

                    case Q6:
                        break;


                    case Q7:
                        break;


                    case Q8:
                        break;

                    case Q9:
                        break;


                    case Q10:
                        break;

                    case Q11:
                        break;


                    case Q12:
                        break;

                    case Q13:
                        break;


                    case Q14:
                        break;



                    case Q15:
                        break;

                    case Q16:
                        break;

                    case Q17:
                        break;

                    case Q18:
                        break;


                    case Q19:
                        break;


                    case Q20:
                        break;

                    case Q21:
                        break;


                    case Q22:
                        break;

                    case Q23:
                        break;


                    case ERROR:
                        break;


                }

            }

        }




    }
}