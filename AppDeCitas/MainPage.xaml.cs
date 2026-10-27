namespace AppDeCitas;



    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void SolicitarCitaBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.SolicitarCitaPage());
        }

        
}

