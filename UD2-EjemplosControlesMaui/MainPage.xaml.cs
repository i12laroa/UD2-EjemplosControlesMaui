namespace UD2_EjemplosControlesMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Prueba", "prueba", "ok");
        }
    }

}
