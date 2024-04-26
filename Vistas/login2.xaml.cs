namespace bvelozexamen1.Vistas;

public partial class login2 : ContentPage
{
    string[] usuarios = { "estudiante2024", "examen1" };
    string[] claves = { "uisrael2024", "parcial1" };
    public login2()
    {

        InitializeComponent();
    }

    private void btnIngresar2_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string clave = txtClave.Text;
        bool verificar = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuario && claves[i] == clave)
            {
                verificar = true;
                break;
            }
        }
        if (verificar)
        {
            Navigation.PushAsync(new Registro(usuario));

        }
        else
        {
            DisplayAlert("Alerta", "Usuario o clave incorrecta", "cerrar");

        }
    }
}