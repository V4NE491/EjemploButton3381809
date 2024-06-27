namespace EjemploButton3381809
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
             
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "PRESIONAME DE NUEVO ";
        }
    }

}
