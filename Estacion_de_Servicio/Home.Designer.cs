namespace Estacion_de_Servicio
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stock = new System.Windows.Forms.ToolStripMenuItem();
            this.productos = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table_stock = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_prodcuctos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_prodcuctos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stock,
            this.productos,
            this.comprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1076, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // stock
            // 
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(68, 26);
            this.stock.Text = "Stock";
            this.stock.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // productos
            // 
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(106, 26);
            this.productos.Text = "Productos";
            this.productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva Compra";
            // 
            // table_stock
            // 
            this.table_stock.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.cantidad,
            this.fecha_creacion});
            this.table_stock.Location = new System.Drawing.Point(0, 33);
            this.table_stock.Name = "table_stock";
            this.table_stock.Size = new System.Drawing.Size(352, 192);
            this.table_stock.TabIndex = 1;
            this.table_stock.UseWaitCursor = true;
            this.table_stock.Visible = false;
            this.table_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Id Producto";
            this.id_producto.Name = "id_producto";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.HeaderText = "Fecha de Creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            // 
            // table_prodcuctos
            // 
            this.table_prodcuctos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_prodcuctos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.precio,
            this.id_proveedor,
            this.estado,
            this.fechacreacion});
            this.table_prodcuctos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.table_prodcuctos.ImeMode = System.Windows.Forms.ImeMode.On;
            this.table_prodcuctos.Location = new System.Drawing.Point(362, 33);
            this.table_prodcuctos.Name = "table_prodcuctos";
            this.table_prodcuctos.Size = new System.Drawing.Size(644, 192);
            this.table_prodcuctos.TabIndex = 2;
            this.table_prodcuctos.UseWaitCursor = true;
            this.table_prodcuctos.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "Id Proveedor";
            this.id_proveedor.Name = "id_proveedor";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // fechacreacion
            // 
            this.fechacreacion.HeaderText = "Fecha Creacion";
            this.fechacreacion.Name = "fechacreacion";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1076, 580);
            this.Controls.Add(this.table_prodcuctos);
            this.Controls.Add(this.table_stock);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_prodcuctos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stock;
        private System.Windows.Forms.ToolStripMenuItem productos;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        private System.Windows.Forms.DataGridView table_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridView table_prodcuctos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacion;
    }
}