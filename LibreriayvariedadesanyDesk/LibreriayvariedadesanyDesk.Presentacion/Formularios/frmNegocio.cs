using LibreriayvariedadesanyDesk.Recursos.Cloudinary;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmNegocio : Form
    {
        private readonly INegocioServices _negocioServices;
        private readonly ICloudinaryServices _cloudinaryServices;
        private OpenFileDialog _openFileDialog = new OpenFileDialog();
        private Negocio Negocio = new Negocio();

        public frmNegocio(INegocioServices negocioServices, ICloudinaryServices cloudinaryServices)
        {
            InitializeComponent();
            _negocioServices = negocioServices;
            _cloudinaryServices = cloudinaryServices;
        }

        private async void frmNegocio_Load(object sender, EventArgs e)
        {
            _openFileDialog.Filter = "Escoger imagen (*.JPG;*.PNG)| *.jpg; *.png";
            PBLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            Negocio = await _negocioServices.Obtener();

            tbRazonSocial.Text = Negocio.razonSocial;
            tbNit.Text = Negocio.nit;
            tbDireccion.Text = Negocio.direccion;
            tbTelefono.Text = Negocio.telefono;
            tbEmail.Text = Negocio.email;
            tbSimboloM.Text = Negocio.simboloMoneda;
            if (Negocio.urlLogo != "")
                PBLogo.ImageLocation = Negocio.urlLogo;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _openFileDialog.OpenFile();
                PBLogo.Image = Image.FromFile(_openFileDialog.FileName);
                tbRutaImagen.Text = _openFileDialog.FileName;
            }
        }

        private async void btGuardarN_Click(object sender, EventArgs e)
        {
            CloudinaryResponse cloudinaryResponse = new CloudinaryResponse();
            Negocio objeto = new Negocio();

            if (_openFileDialog.FileName != "")
            {
                cloudinaryResponse =
                await _cloudinaryServices.SubirImagen(_openFileDialog.SafeFileName, _openFileDialog.OpenFile());
                if (cloudinaryResponse.PublicId != "")
                {
                    if (Negocio.nombreLogo != "")
                        await _cloudinaryServices.EliminarImagen(Negocio.nombreLogo);

                    objeto.nombreLogo = cloudinaryResponse.PublicId;
                    objeto.urlLogo = cloudinaryResponse.SecureUrl;
                    Negocio.nombreLogo = cloudinaryResponse.PublicId;
                    Negocio.urlLogo = cloudinaryResponse.SecureUrl;
                }
            }
            else
            {
                objeto.nombreLogo = Negocio.nombreLogo;
                objeto.urlLogo = Negocio.urlLogo;
            }

            objeto.razonSocial = tbRazonSocial.Text;
            objeto.nit = tbNit.Text;
            objeto.direccion = tbDireccion.Text;
            objeto.telefono = tbTelefono.Text;
            objeto.email = tbEmail.Text;
            objeto.simboloMoneda = tbSimboloM.Text;

            await _negocioServices.Editar(objeto);

            MessageBox.Show("La informacion del negocio ha sido actualizada");
            tbRutaImagen.Text = "";
            _openFileDialog = new OpenFileDialog();
        }
    }
}
