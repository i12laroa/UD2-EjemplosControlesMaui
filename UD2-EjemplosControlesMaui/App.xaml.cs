namespace UD2_EjemplosControlesMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // No asignar MainPage aquí (evita la API obsoleta)
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
