using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Pia_Programacion_C_
{
    public partial class Details : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private Contact _contact;
        public Details()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
            ((Main)this.Owner).PopulateContacts();
            
        }

        private void SaveContact()
        {
            Contact contact = new Contact();
            contact.Nombre = txtNombre.Text;
            contact.Detalle = txtDetalle.Text;
            contact.Tarifa = int.Parse(txtTarifa.Text);
            contact.Ocupantes = int.Parse(txtOcupantes.Text);
            contact.MetrosCuadrados = int.Parse(txtMetros2.Text);
            contact.FechaCreacion = dateCreacion.Value;
            contact.FechaActualizacion = dateActualizacion.Value;
            contact.ImagenUrl = txtUrl.Text;
            contact.Amenidad = txtAmenidad.Text;

            contact.Id = _contact != null ? _contact.Id : 0;


            _businessLogicLayer.SaveContact(contact);
        }

        public void LoadContact(Contact contact)
        {
            _contact = contact;
            if (contact != null)
            {
                ClearForm();

                txtNombre.Text = contact.Nombre;
                txtDetalle.Text = contact.Detalle;
                txtTarifa.Text = contact.Tarifa.ToString();
                txtOcupantes.Text = contact.Ocupantes.ToString();
                txtMetros2.Text = contact.MetrosCuadrados.ToString();
                txtUrl.Text = contact.ImagenUrl.ToString();
                txtAmenidad.Text = contact.Amenidad.ToString();
                //txtCreacion.Text = contact.FechaCreacion.ToString();

            }
        } 

        private void ClearForm()
        {
            txtNombre.Text = string.Empty; 
            txtDetalle.Text = string.Empty;
            txtOcupantes.Text = string.Empty;
            txtMetros2.Text= string.Empty;
            txtTarifa.Text = string.Empty;
            txtUrl.Text = string.Empty;
            txtAmenidad.Text= string.Empty;
            //txtCreacion.Text= string.Empty;
           // txtModificacion.Text= string.Empty;
        }

        private void dateCreacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtOcupantes_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOcupantes.Text))
            {
                if (!int.TryParse(txtOcupantes.Text, out int result))
                {
                    MessageBox.Show("Solo se permiten números. Por favor, ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOcupantes.Text = ""; // Limpia el contenido del TextBox
                }
            }
        }

        private void dateActualizacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTarifa.Text))
            {
                if (!int.TryParse(txtTarifa.Text, out int result))
                {
                    MessageBox.Show("Solo se permiten números. Por favor, ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTarifa.Text = ""; // Limpia el contenido del TextBox
                }
            }
        }

        private void txtMetros2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMetros2.Text))
            {
                if (!decimal.TryParse(txtMetros2.Text, out decimal result))
                {
                    MessageBox.Show("Solo se permiten números. Por favor, ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetros2.Text = ""; // Limpia el contenido del TextBox
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string input = txtNombre.Text;
            string pattern = "^[a-zA-Z ]+$"; // Patrón de expresión regular para aceptar solo letras y espacios

            if (!Regex.IsMatch(input, pattern))
            {
                MessageBox.Show("Solo se permite texto. Por favor, ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = ""; // Limpia el contenido del TextBox
            }
        }
    }   
}
