using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios;

namespace Presentacion
{
    public partial class FormularioPersonas : Form
    {
        PersonasModel PersonasModel = new PersonasModel();
        private string personaID = null;
        private bool editar = false;
        public FormularioPersonas()
        {
            InitializeComponent();
        }

        private void FormularioPersonas_Load(object sender, EventArgs e)
        {
            MostrarPersona();
        }

        public void MostrarPersona()
        {
            PersonasModel personas = new PersonasModel();
            dataGridViewPersona.DataSource = personas.MostrarPersona();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> datos = new Dictionary<string, object>
                {
                    { "nombre", txtNombres.Text },
                    { "apellidoPaterno", txtPaterno.Text },
                    { "apellidoMaterno", txtMaterno.Text },
                    { "fechaNacimiento", txtNacimiento.Text },
                    { "email", txtCorreo.Text },
                    { "numeroDoc", txtDocumento.Text },
                    { "direccion", txtDireccion.Text },
                    { "telefono", txtCelular.Text },
                    { "personaID", personaID},
                };
            if (editar)
            {
                try
                {
                    PersonasModel.EditarPersona(datos);
                    MessageBox.Show("Se edito corectamente Es un EXITO");
                    //limpiarForms();
                    MostrarPersona();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            } 
            else
            
            try
            {
                PersonasModel personas = new PersonasModel();

                Dictionary<string, object> resultado = personas.InsertarPerosna(datos);
                if (Convert.ToInt32(resultado["Error"]) == 1)
                {
                    MessageBox.Show("ERROR: " + resultado["Mensaje"].ToString(), "Mensaje de Error");
                }
                else
                {
                    MessageBox.Show("Se inserto corectamente Es un EXITO");
                    //limpiarForms();
                    MostrarPersona();
                }
                //editar = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersona.SelectedRows.Count > 0)
            {
                personaID = dataGridViewPersona.CurrentRow.Cells["PersonaID"].Value.ToString();
                PersonasModel.EliminarPersona(int.Parse(personaID));
                MessageBox.Show("Se elimino corectamente");
                MostrarPersona();

            }
            else
            {
                MessageBox.Show("Seleccione una fila porfavor");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersona.SelectedRows.Count > 0)
            {
                editar = true;
                txtNombres.Text = dataGridViewPersona.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPaterno.Text = dataGridViewPersona.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
                txtMaterno.Text = dataGridViewPersona.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
                txtNacimiento.Text = dataGridViewPersona.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                txtCorreo.Text = dataGridViewPersona.CurrentRow.Cells["Email"].Value.ToString();
                txtDocumento.Text = dataGridViewPersona.CurrentRow.Cells["NumeroDOC"].Value.ToString();
                txtDireccion.Text = dataGridViewPersona.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCelular.Text = dataGridViewPersona.CurrentRow.Cells["Telefono"].Value.ToString();
                personaID = dataGridViewPersona.CurrentRow.Cells["PersonaID"].Value.ToString();
            }
            else
            {
                //Diego Frank Lipa Choque Dlipa;
                MessageBox.Show("Seleccione una fila porfavor");
            }
        }
    }
}
