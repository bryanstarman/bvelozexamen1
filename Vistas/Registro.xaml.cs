namespace bvelozexamen1.Vistas;

public partial class Registro : ContentPage
{
	public Registro(String usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void btnMensual_Clicked(object sender, EventArgs e)
    {
        double inicial=double.Parse(txtMontoInicial.Text);
        double mensual = (1500 - inicial);
        double mensual2 = (mensual / 4)+60;
        txtMontoMensual.Text=""+mensual2;

    }
}