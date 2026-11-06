using AppDeCitas.Clases;

namespace AppDeCitas.Pages;

public partial class SolicitarCitaPage : ContentPage
{
	public SolicitarCitaPage()
	{
		InitializeComponent();
        this.especialidades.ItemsSource = cargarOpciones();
	}
    private List<Especialidad> cargarOpciones()
    {
        return new List<Especialidad>
            {
                new Especialidad {imagen = "cardiologia.svg", nombre = "Cardiología", especialista = "Dra Laura Martín", espera = 25},
                new Especialidad {imagen = "dermatologia.svg", nombre = "Dermatologia", especialista = "Dr Javier Ruiz", espera = 25},
                new Especialidad {imagen = "oftalmologia.svg", nombre = "Oftalmologia", especialista = "Dra Elena Gomez", espera = 30},
                new Especialidad {imagen = "traumatologia.svg", nombre = "Cardiología", especialista = "Dra Laura Martín", espera = 55},
                new Especialidad {imagen = "pediatria.svg", nombre = "Pediatria", especialista = "Dra Marta Sanchez", espera = 7}
            };
        }
}