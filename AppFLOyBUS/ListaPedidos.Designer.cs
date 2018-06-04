namespace AppFLOyBUS
{
    partial class ListaPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensionJardinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDineroUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdJardineriaDataSet = new AppFLOyBUS.bdJardineriaDataSet();
            this.pedidoTableAdapter = new AppFLOyBUS.bdJardineriaDataSetTableAdapters.PedidoTableAdapter();
            this.Pedidos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdJardineriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.fechaPedidoDataGridViewTextBoxColumn,
            this.cantidadTotalDataGridViewTextBoxColumn,
            this.dimensionJardinDataGridViewTextBoxColumn,
            this.cantidadDineroUsuarioDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.idPlantaDataGridViewTextBoxColumn,
            this.idAdornoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(751, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            this.fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "fechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.HeaderText = "fechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            this.fechaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadTotalDataGridViewTextBoxColumn
            // 
            this.cantidadTotalDataGridViewTextBoxColumn.DataPropertyName = "cantidadTotal";
            this.cantidadTotalDataGridViewTextBoxColumn.HeaderText = "cantidadTotal";
            this.cantidadTotalDataGridViewTextBoxColumn.Name = "cantidadTotalDataGridViewTextBoxColumn";
            this.cantidadTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dimensionJardinDataGridViewTextBoxColumn
            // 
            this.dimensionJardinDataGridViewTextBoxColumn.DataPropertyName = "dimensionJardin";
            this.dimensionJardinDataGridViewTextBoxColumn.HeaderText = "dimensionJardin";
            this.dimensionJardinDataGridViewTextBoxColumn.Name = "dimensionJardinDataGridViewTextBoxColumn";
            this.dimensionJardinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDineroUsuarioDataGridViewTextBoxColumn
            // 
            this.cantidadDineroUsuarioDataGridViewTextBoxColumn.DataPropertyName = "cantidadDineroUsuario";
            this.cantidadDineroUsuarioDataGridViewTextBoxColumn.HeaderText = "cantidadDineroUsuario";
            this.cantidadDineroUsuarioDataGridViewTextBoxColumn.Name = "cantidadDineroUsuarioDataGridViewTextBoxColumn";
            this.cantidadDineroUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPlantaDataGridViewTextBoxColumn
            // 
            this.idPlantaDataGridViewTextBoxColumn.DataPropertyName = "idPlanta";
            this.idPlantaDataGridViewTextBoxColumn.HeaderText = "idPlanta";
            this.idPlantaDataGridViewTextBoxColumn.Name = "idPlantaDataGridViewTextBoxColumn";
            this.idPlantaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAdornoDataGridViewTextBoxColumn
            // 
            this.idAdornoDataGridViewTextBoxColumn.DataPropertyName = "idAdorno";
            this.idAdornoDataGridViewTextBoxColumn.HeaderText = "idAdorno";
            this.idAdornoDataGridViewTextBoxColumn.Name = "idAdornoDataGridViewTextBoxColumn";
            this.idAdornoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.bdJardineriaDataSet;
            // 
            // bdJardineriaDataSet
            // 
            this.bdJardineriaDataSet.DataSetName = "bdJardineriaDataSet";
            this.bdJardineriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // Pedidos
            // 
            this.Pedidos.AutoSize = true;
            this.Pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedidos.Location = new System.Drawing.Point(32, 25);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(402, 25);
            this.Pedidos.TabIndex = 1;
            this.Pedidos.Text = "Pedidos Realizados Por Los Clientes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(37, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "< Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaPedidos";
            this.Text = "Lista de Pedidos";
            this.Load += new System.EventHandler(this.ListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdJardineriaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdJardineriaDataSet bdJardineriaDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private bdJardineriaDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensionJardinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDineroUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Pedidos;
        private System.Windows.Forms.Button button1;
    }
}