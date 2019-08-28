namespace WFA.morganmckinley.Interview
{
    partial class OrdersForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcOrders = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.referenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.beRefreshOrders = new DevExpress.XtraEditors.ButtonEdit();
            this.cbDisableDbDelay = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beRefreshOrders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDisableDbDelay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOrders
            // 
            this.gcOrders.Location = new System.Drawing.Point(12, 40);
            this.gcOrders.MainView = this.gridView;
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.buttonEdit});
            this.gcOrders.Size = new System.Drawing.Size(776, 398);
            this.gcOrders.TabIndex = 0;
            this.gcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.referenceNumber,
            this.orderValue,
            this.orderDate,
            this.customerName,
            this.customerId});
            this.gridView.GridControl = this.gcOrders;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // referenceNumber
            // 
            this.referenceNumber.Caption = "Reference Number";
            this.referenceNumber.FieldName = "ReferenceNumber";
            this.referenceNumber.Name = "referenceNumber";
            this.referenceNumber.OptionsColumn.AllowEdit = false;
            this.referenceNumber.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.referenceNumber.Visible = true;
            this.referenceNumber.VisibleIndex = 0;
            // 
            // orderValue
            // 
            this.orderValue.Caption = "Value";
            this.orderValue.DisplayFormat.FormatString = "{0:c}";
            this.orderValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.orderValue.FieldName = "OrderValue";
            this.orderValue.Name = "orderValue";
            this.orderValue.OptionsColumn.AllowEdit = false;
            this.orderValue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.orderValue.Visible = true;
            this.orderValue.VisibleIndex = 1;
            // 
            // orderDate
            // 
            this.orderDate.Caption = "Date";
            this.orderDate.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.orderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.orderDate.FieldName = "OrderDate";
            this.orderDate.Name = "orderDate";
            this.orderDate.OptionsColumn.AllowEdit = false;
            this.orderDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.orderDate.Visible = true;
            this.orderDate.VisibleIndex = 2;
            // 
            // customerName
            // 
            this.customerName.Caption = "Customer";
            this.customerName.FieldName = "CustomerName";
            this.customerName.Name = "customerName";
            this.customerName.OptionsColumn.AllowEdit = false;
            this.customerName.Visible = true;
            this.customerName.VisibleIndex = 3;
            // 
            // customerId
            // 
            this.customerId.Caption = " ";
            this.customerId.ColumnEdit = this.buttonEdit;
            this.customerId.FieldName = "customerId";
            this.customerId.Name = "customerId";
            this.customerId.Visible = true;
            this.customerId.VisibleIndex = 4;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.buttonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.buttonEdit.Click += new System.EventHandler(this.CustomerClick);
            // 
            // beRefreshOrders
            // 
            this.beRefreshOrders.Location = new System.Drawing.Point(744, 12);
            this.beRefreshOrders.Name = "beRefreshOrders";
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.beRefreshOrders.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beRefreshOrders.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.beRefreshOrders.Size = new System.Drawing.Size(44, 22);
            this.beRefreshOrders.TabIndex = 3;
            this.beRefreshOrders.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beRefreshOrders_ButtonClick);
            // 
            // cbDisableDbDelay
            // 
            this.cbDisableDbDelay.Location = new System.Drawing.Point(12, 12);
            this.cbDisableDbDelay.Name = "cbDisableDbDelay";
            this.cbDisableDbDelay.Properties.Caption = "Disable fake db delay";
            this.cbDisableDbDelay.Size = new System.Drawing.Size(131, 19);
            this.cbDisableDbDelay.TabIndex = 4;
            this.cbDisableDbDelay.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Refresh Orders";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDisableDbDelay);
            this.Controls.Add(this.beRefreshOrders);
            this.Controls.Add(this.gcOrders);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beRefreshOrders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDisableDbDelay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn referenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn orderValue;
        private DevExpress.XtraGrid.Columns.GridColumn orderDate;
        private DevExpress.XtraGrid.Columns.GridColumn customerId;
        private DevExpress.XtraGrid.Columns.GridColumn customerName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonEdit;
        private DevExpress.XtraEditors.ButtonEdit beRefreshOrders;
        private DevExpress.XtraEditors.CheckEdit cbDisableDbDelay;
        private System.Windows.Forms.Label label1;
    }
}

