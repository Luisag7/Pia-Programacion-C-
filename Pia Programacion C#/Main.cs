using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pia_Programacion_C_
{
    public partial class Main : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public Main()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }


        #region EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenDetailsDialog();


        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Edit")
            {
                Details details = new Details();
                details.LoadContact(new Contact
                {
                    Id = int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Nombre = gridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Detalle = gridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Tarifa = int.Parse(gridContacts.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    Ocupantes = int.Parse(gridContacts.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    MetrosCuadrados = int.Parse(gridContacts.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    FechaCreacion = DateTime.Parse(gridContacts.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    FechaActualizacion = DateTime.Parse(gridContacts.Rows[e.RowIndex].Cells[7].Value.ToString()),
                    ImagenUrl = gridContacts.Rows[e.RowIndex].Cells[8].Value.ToString(),
                    Amenidad = gridContacts.Rows[e.RowIndex].Cells[9].Value.ToString()
                });
                details.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                DeleteContact(int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateContacts();
            }

        }

        #endregion

        #region PRIVATE METHODS

        private void OpenDetailsDialog()
        {
            Details details = new Details();
            details.ShowDialog(this);
        }

        private void DeleteContact(int Id)
        {
            _businessLogicLayer.DeleteContact(Id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateContacts(txtSearch.Text);
            txtSearch.Text = string.Empty;
        }

        #endregion

        #region PUBLIC METHODS
        public void PopulateContacts(string searchText = null)
        {
            List<Contact> contacts = _businessLogicLayer.GetContacts(searchText);
            gridContacts.DataSource = contacts;
        }
        #endregion









    }

}   
