using MauiApp_Examen_SosaGeraldyne.Models;

namespace MauiApp_Examen_SosaGeraldyne;

public partial class Page1 : ContentPage
{
    private string ApiUrl = "https://appanimalesapi2024trujillo.azurewebsites.net/api/Animales";
    public Page1()
    { 
        InitializeComponent();
    }
    private void cmdCreate_Clicked(object sender, EventArgs e)
    {
        var resultado = ConsumeAPI.Crud<Animal>.Create(ApiUrl, new Animal
        {
            Id = 0,
            Nombre = txtNombre.Text,
            Descripcion = txtDescripcion.Text,
            GrupoId = int.Parse(txtGrupoId.Text)
        });

        if (resultado != null)
        {
            txtId.Text = resultado.Id.ToString();
        }
    }

    private void cmdRead_Clicked(object sender, EventArgs e)
    {
        var resultado = ConsumeAPI.Crud<Animal>.Read_ById(ApiUrl, int.Parse(txtId.Text));
        if (resultado != null)
        {
            txtId.Text = resultado.Id.ToString();
            txtNombre.Text = resultado.Nombre;
            txtDescripcion.Text = resultado.Descripcion;
            txtGrupoId.Text = resultado.GrupoId.ToString();
        }
    }

    private void cmdUpdate_Clicked(object sender, EventArgs e)
    {
        ConsumeAPI.Crud<Animal>.Update(ApiUrl, int.Parse(txtId.Text), new Animal
        {
            Id = int.Parse(txtId.Text),
            Nombre = txtNombre.Text,
            Descripcion = txtDescripcion.Text,
            GrupoId = int.Parse(txtGrupoId.Text)
        });
    }

    private void cmdDelete_Clicked(object sender, EventArgs e)
    {
        ConsumeAPI.Crud<Animal>.Delete(ApiUrl, int.Parse(txtId.Text));
        txtNombre.Text = "";
        txtDescripcion.Text = "";
        txtGrupoId.Text = "";
        txtId.Text = "";
    }

    private void cmdNextClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}