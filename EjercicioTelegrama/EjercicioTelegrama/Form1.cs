using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EjercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
        }
        char tipoTelegrama = ' ';
        int numPalabras = 0;
        double coste;
        string variableUsuario2;
        string variableusuario1cambio1;
        string variableUsuario2.1;

        //Leo el telegrama  
        textoTelegrama = txtTelegrama.Text; 
// telegrama urgente? 
if (chkUrgente.Checked)  
{ 
 tipoTelegrama = 'u';  
 }
    //Obtengo el n�mero de palabras que forma el telegrama  
    numPalabras = textoTelegrama.Length; 
 
//Si el telegrama es ordinario 
if (tipoTelegrama == 'o')  
 { 
  if (numPalabras <= 10) 
  { 
           coste = 2.5;  
        }
  else
{
    coste = 0.5 * numPalabras;
} 
 } 
 else
//Si el telegrama es urgente 
{
    if (tipoTelegrama == 'u')
    {
        if (numPalabras <= 10)
        {
            coste = 5;
        }
        else
        {
            coste = 5 + 0.75 * (numPalabras - 10);
        }
    }
    else
    {
        coste = 0;
    }
}
txtPrecio.Text = coste.ToString() + " euros";  
} 
}
