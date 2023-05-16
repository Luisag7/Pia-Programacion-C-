namespace Pia_Programacion_C_
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridContacts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupantesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrosCuadradosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaActualizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amenidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContacts
            // 
            this.gridContacts.AutoGenerateColumns = false;
            this.gridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.tarifaDataGridViewTextBoxColumn,
            this.ocupantesDataGridViewTextBoxColumn,
            this.metrosCuadradosDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaActualizacionDataGridViewTextBoxColumn,
            this.imagenUrlDataGridViewTextBoxColumn,
            this.amenidadDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.gridContacts.DataSource = this.contactBindingSource;
            this.gridContacts.Location = new System.Drawing.Point(2, 89);
            this.gridContacts.Name = "gridContacts";
            this.gridContacts.Size = new System.Drawing.Size(1219, 360);
            this.gridContacts.TabIndex = 0;
            this.gridContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContacts_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(169, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(473, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(680, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(797, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(Pia_Programacion_C_.Contact);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "Detalle";
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            // 
            // tarifaDataGridViewTextBoxColumn
            // 
            this.tarifaDataGridViewTextBoxColumn.DataPropertyName = "Tarifa";
            this.tarifaDataGridViewTextBoxColumn.HeaderText = "Tarifa";
            this.tarifaDataGridViewTextBoxColumn.Name = "tarifaDataGridViewTextBoxColumn";
            // 
            // ocupantesDataGridViewTextBoxColumn
            // 
            this.ocupantesDataGridViewTextBoxColumn.DataPropertyName = "Ocupantes";
            this.ocupantesDataGridViewTextBoxColumn.HeaderText = "Ocupantes";
            this.ocupantesDataGridViewTextBoxColumn.Name = "ocupantesDataGridViewTextBoxColumn";
            // 
            // metrosCuadradosDataGridViewTextBoxColumn
            // 
            this.metrosCuadradosDataGridViewTextBoxColumn.DataPropertyName = "MetrosCuadrados";
            this.metrosCuadradosDataGridViewTextBoxColumn.HeaderText = "MetrosCuadrados";
            this.metrosCuadradosDataGridViewTextBoxColumn.Name = "metrosCuadradosDataGridViewTextBoxColumn";
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            // 
            // fechaActualizacionDataGridViewTextBoxColumn
            // 
            this.fechaActualizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaActualizacion";
            this.fechaActualizacionDataGridViewTextBoxColumn.HeaderText = "FechaActualizacion";
            this.fechaActualizacionDataGridViewTextBoxColumn.Name = "fechaActualizacionDataGridViewTextBoxColumn";
            // 
            // imagenUrlDataGridViewTextBoxColumn
            // 
            this.imagenUrlDataGridViewTextBoxColumn.DataPropertyName = "ImagenUrl";
            this.imagenUrlDataGridViewTextBoxColumn.HeaderText = "ImagenUrl";
            this.imagenUrlDataGridViewTextBoxColumn.Name = "imagenUrlDataGridViewTextBoxColumn";
            // 
            // amenidadDataGridViewTextBoxColumn
            // 
            this.amenidadDataGridViewTextBoxColumn.DataPropertyName = "Amenidad";
            this.amenidadDataGridViewTextBoxColumn.HeaderText = "Amenidad";
            this.amenidadDataGridViewTextBoxColumn.Name = "amenidadDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 451);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridContacts);
            this.Name = "Main";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupantesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrosCuadradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaActualizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amenidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.BindingSource contactBindingSource;
    }
}

