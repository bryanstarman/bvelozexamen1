

namespace bvelozexamen1.Vistas;



    public partial class login : ContentPage
    {
        string[] usuarios = { "estudiante2024", "examen1" };
        string[] claves = { "uisrael2024", "parcial1" };
        public login()
        {

            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            
                Navigation.PushAsync(new Registro("starman"));
               
           
        }
    }