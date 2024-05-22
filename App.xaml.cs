namespace Shutdown
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            window.MinimumHeight = 650; // altura mínima da janela
            window.MinimumWidth = 450; // largura mínima da janela

            window.Width = 800;
            window.Height = 660;

            window.SizeChanged += OnWindowSizeChanged; // largura mínima da janela

            return window;
        }

        private void OnWindowSizeChanged(object sender, EventArgs e)
        {
            // Verifica se o objeto sender é uma janela
            if (sender is Window window)
            {
                if(window.Width < 800)
                {
                    window.MinimumHeight = 850;
                }
                    
                if (window.Width >= 800)
                {
                    window.MinimumHeight = 650;
                }
            }
        }
    }
}
