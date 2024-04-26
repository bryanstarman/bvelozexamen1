namespace bvelozexamen1.Vistas;

public partial class Principal : ContentPage
{
	public Principal(String usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido " + usuario, "OK");
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }
    private void btnPK_Clicked(object sender, EventArgs e)
    {
        if (pkCiudades.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione uno", "OK");
        }
        else
        {
            string dato = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            DisplayAlert("Alert", "Dato seleccionado " + dato, "OK");
            lblDato.Text = dato;
        }

    }

    private void bntfecha_Clicked(object sender, EventArgs e)
    {
        string fecha = dpFecha.Date.ToString();
        lblDato.Text = fecha;
    }
}