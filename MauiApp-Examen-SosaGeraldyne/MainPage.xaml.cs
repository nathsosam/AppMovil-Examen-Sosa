using MauiApp_Examen_SosaGeraldyne.Models;

namespace MauiApp_Examen_SosaGeraldyne
{
    public partial class MainPage : ContentPage
    {
        private string ApiUrl = "https://appanimalesapi2024trujillo.azurewebsites.net/api/Grupos";

        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdCreate_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Grupo>.Create(ApiUrl, new Grupo
            {
                Id = 0,
                Nombre = txtNombre.Text,
                Caracteristica = txtCaracteristica.Text
            });

            if (resultado != null)
            {
                txtId.Text = resultado.Id.ToString();
            }
        }

        private void cmdRead_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Grupo>.Read_ById(ApiUrl, int.Parse(txtId.Text));
            if (resultado != null)
            {
                txtId.Text = resultado.Id.ToString();
                txtNombre.Text = resultado.Nombre;
                txtCaracteristica.Text = resultado.Caracteristica;
            }
        }

        private void cmdUpdate_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Grupo>.Update(ApiUrl, int.Parse(txtId.Text), new Grupo
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Caracteristica = txtCaracteristica.Text
            });
        }

        private void cmdDelete_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Grupo>.Delete(ApiUrl, int.Parse(txtId.Text));
            txtNombre.Text = "";
            txtCaracteristica.Text = "";
            txtId.Text = "";
        }

        private void cmdNextClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }

}
