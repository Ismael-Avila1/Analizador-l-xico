using System;
using System.Text.RegularExpressions;


namespace Analizador
{
    
    public partial class Form1 : Form
    {
        //estados
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

            textBoxEstados.Text = "";

            for (int i=0; i<cadena.Length; i++) { // se recorre la cadena ingresada

                switch(estado) {    // selecciona opcion segun el estado 
                    case INICIO:    // estado de inicio
                        if(cadena[i].ToString() == "-") { // se busca un -
                            estado = Q1;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d")) { // se busca un digito
                            estado = Q2;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ".") { // se busca un punto decimal
                            estado = Q3;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[a-hj-z]")) {   // se busca una letra de la a-h y de j-z
                            estado = Q5;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == "i") { // se busca la letra i
                            estado = Q15;
                        }
                        else { // se envia al estado de error
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        } 
                        break;


                    case Q1:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q2;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ".") { // se busca un punto
                            estado = Q3;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q2:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q2;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ".") {
                            estado = Q3;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q3:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q4;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q4:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q4;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q5:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]")) { // se busca letra de a-z o digito del 0 al 9
                            estado = Q5;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == "=") { // se busca el =
                            estado = Q6;
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q6:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q7;
                            textBoxEstados.Text += "Q" + estado + ", ";

                        }
                        else if(cadena[i].ToString() == "-")                         {
                            estado = Q12;
                            textBoxEstados.Text += "Q" + estado + ", ";

                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[a-z]")) { // se busca letra de la a-z
                            estado = Q13;
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";

                        }
                        break;


                    case Q7:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[\x2B\x2D\x2A\x2F]")) { // se busca entre + - * /
                            estado = Q6;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d"))                         {
                            estado = Q7;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ".") {
                            estado = Q8;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ";") {
                            estado = Q11;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q8:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q9;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q9:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[\x2B\x2D\x2A\x2F]")) { // se busca entre + - * /
                            estado = Q6;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q9;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ";") {
                            estado = Q10;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q10:
                        break;


                    case Q11:
                        break;


                    case Q12:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q7;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q13:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]")) {
                            estado = Q13;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ";") {
                            estado = Q14;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q14:
                        break;


                    case Q15:
                        if(cadena[i].ToString() == "f") {
                            estado = Q16;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]")) {
                            estado = Q5;
                            textBoxEstados.Text += "Q" + estado + ", ";

                        }
                        else if(cadena[i].ToString() == "=") {
                            estado = Q6;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q16:
                        if(cadena[i].ToString() == "(") {
                            estado = Q17;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q17:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]")) {
                            estado = Q18;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q19;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        break;


                    case Q18:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]")) {
                            estado = Q18;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[\x3E\x3D|\x3C\x3D|\x3E|\x3C|\x21\x3D|\x3D\x3D]")) {
                            // se busca entre >= <= > < != ==
                            estado = Q20;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q19:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q19;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[\x3E\x3D|\x3C\x3D|\x3E|\x3C|\x21\x3D|\x3D\x3D]")) {   // se busca entre >= <= > < != ==
                            estado = Q20;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q20:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[\x3E\x3D|\x3C\x3D|\x3E|\x3C|\x21\x3D|\x3D\x3D]")) {    // se busca entre >= <= > < != ==
                            estado = Q20;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]")) {
                            estado = Q21;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q23;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q21:
                        if(Regex.IsMatch(cadena[i].ToString(), @"[a-z0-9]")) {
                            estado = Q21;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ")") {
                            estado = Q22;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else {
                            estado = ERROR;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case Q22:
                        break;


                    case Q23:
                        if(Regex.IsMatch(cadena[i].ToString(), @"\d")) {
                            estado = Q23;
                            textBoxEstados.Text += "Q" + estado + ", ";
                        }
                        else if(cadena[i].ToString() == ")") {
                            estado = Q22;
                            textBoxEstados.Text += "ERROR";
                        }
                        break;


                    case ERROR:
                        estado = ERROR;
                    break;
                }

            }

                detalles(estado, cadena); // se pide el detalle de la cadena
        }


        void detalles(int estado, string cadena)
        {

            if (estado == ERROR) // si es el estado de error
                MessageBox.Show("La cadena ingresada es inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if(estado == Q2) { // si es el estado final Q2
                string s = "La cadena ingresada es un número. " + "Los detalles de la cadena son los siguientes: \n\n";
                s += "• Es un número con signo positivo\n";
                s += "• Es un número entero\n";
                s += "• El valor del número es: ";
                for(int i=0; i<cadena.Length; i++)
                    s += cadena[i].ToString();

                MessageBox.Show(s, "Detalles de la Cadena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 


            else if(estado == Q4) { // si es el estado final q4
                bool isReal = false;
                string s = "La cadena ingresada es un número. \n" + "Los detalles de la cadena son los siguientes: \n\n";


                if(cadena[0].ToString() == "-")
                    s += "• Es un número con signo negativo\n";
                else
                    s += "• Es un número con signo positivo\n";

                for(int i=0; i<cadena.Length; i++)
                    if(cadena[i].ToString() == ".") {
                        isReal = true;
                        break;
                    }

                if(isReal)
                    s += "• Es un número real\n";
                else
                    s += "• Es un número entero\n";


                s += "• El valor del número es: ";

                for(int i=0; i<cadena.Length; i++)
                    s += cadena[i].ToString();

                MessageBox.Show(s, "Detalles de la Cadena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else if(estado == Q10) { // si termina en el estado q10
                string s = "La cadena ingresada es una asignación de variable con un entero. " + "Los detalles de la cadena son los siguientes: \n\n";

                s += "• Nombre de la variable: ";
                for(int i=0; i<cadena.Length; i++) {
                    if(cadena[i].ToString() == "=")
                        break;

                    s += cadena[i].ToString();
                }

                s += "\n• El operador '=' es un operador de asignación\n";

                s += "• El valor asignado a la variable es una operación entre dos números\n";
                
                s += "• La operación es:";

                for(int i=0; i<cadena.Length; i++)
                    if(cadena[i].ToString() == "+" || cadena[i].ToString() == "-" || cadena[i].ToString() == "*" || cadena[i].ToString() == "/") {
                        s += cadena[i].ToString();
                        break;
                    }

                s += "• El valor asignado a la variable es: ";

                int indiceValor = 0;
                for(int i=0; i<cadena.Length; i++)
                    if(cadena[i].ToString() == "=") {
                        indiceValor = i + 1;
                        break;
                    }

                for(int i=indiceValor; i<cadena.Length - 1; i++)
                    s += cadena[i].ToString();

                s += "\n• El símbolo ';' es símbolo terminal\n";

                MessageBox.Show(s, "Detalles de la Cadena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else if(estado == Q11) { // si termina en el estado q11
                string s = "La cadena ingresada es una asignación de variable con un real. " + "Los detalles de la cadena son los siguientes: \n\n";
                bool hayOperacion = false;

                s += "• Nombre de la variable: ";
                for(int i=0; i<cadena.Length; i++) {
                    if(cadena[i].ToString() == "=")
                        break;

                    s += cadena[i].ToString();
                }

                s += "\n• El operador '=' es un operador de asignación\n";

                for(int i=0; i<cadena.Length; i++)
                    if(cadena[i].ToString() == "+" || cadena[i].ToString() == "-" || cadena[i].ToString() == "*" || cadena[i].ToString() == "/") {
                        hayOperacion = true;
                        break;
                    }

                if(hayOperacion) {
                    s += "• El valor asignado a la variable es una operación entre dos números\n";

                    s += "• La operación es:";

                    for(int i=0; i<cadena.Length; i++)
                        if(cadena[i].ToString() == "+" || cadena[i].ToString() == "-" || cadena[i].ToString() == "*" || cadena[i].ToString() == "/") {
                            s += cadena[i].ToString();
                            break;
                        }
                }


                s += "• El valor asignado a la variable es: ";

                int indiceValor = 0;
                for(int i=0; i<cadena.Length; i++)
                    if(cadena[i].ToString() == "=") {
                        indiceValor = i + 1;
                        break;
                    }

                for(int i=indiceValor; i<cadena.Length - 1; i++)
                    s += cadena[i].ToString();

                s += "\n• El símbolo ';' es símbolo terminal\n";

                MessageBox.Show(s, "Detalles de la Cadena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else if (estado == Q14) { // si termina en el estado q14
                string s = "La cadena ingresada es una asignación de variable con otra variable. " + "Los detalles de la cadena son los siguientes: \n\n";

                s += "• Nombre de la variable: ";
                for(int i=0; i<cadena.Length; i++) {
                    if(cadena[i].ToString() == "=")
                        break;

                    s += cadena[i].ToString();
                }

                s += "\n• El operador '=' es un operador de asignación\n";

                s += "• El valor asignado a la variable es: ";

                int indiceValor = 0;
                for(int i=0; i<cadena.Length; i++)
                    if(cadena[i].ToString() == "=") {
                        indiceValor = i + 1;
                        break;
                    }

                for(int i=indiceValor; i<cadena.Length - 1; i++)
                    s += cadena[i].ToString();

                s += "\n• El símbolo ';' es símbolo terminal\n";

                MessageBox.Show(s, "Detalles de la Cadena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else if (estado == Q22) { // si termina en el estado q22
                string s = "La cadena ingresada es una condicional. " + "Los detalles de la cadena son los siguientes: \n\n";
                int indAux = 0;

                s += "• if es la instrucción de comparación\n";

                s += "• El primer operando es: ";
                for(int i=3; i<cadena.Length; i++) {
                    if(cadena[i].ToString() == ">=" || cadena[i].ToString() == "<=" || cadena[i].ToString() == ">" || cadena[i].ToString() == "<" || cadena[i].ToString() == "!=" || cadena[i].ToString() == "==") {
                        break;
                    }

                    s += cadena[i].ToString();
                }

                s += "\n• El operador usado para la comparación es: ";

                for(int i=0; i<cadena.Length; i++)
                    if(cadena[i].ToString() == ">" || cadena[i].ToString() == "<" || cadena[i].ToString() == "!" || cadena[i].ToString() == "=") {
                        s += cadena[i].ToString();
                        indAux = i;
                    }

                s += "\n• El segundo operando es: ";
                for(int i=indAux+1; i<cadena.Length-1; i++)
                    s += cadena[i].ToString();

                MessageBox.Show(s, "Detalles de la Cadena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


    }
}