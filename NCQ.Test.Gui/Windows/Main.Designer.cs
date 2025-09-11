namespace NCQ.Test.Gui
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonCreate = new DevExpress.XtraEditors.SimpleButton();
            this.GridTasks = new DevExpress.XtraGrid.GridControl();
            this.GidViewTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriorityRepository = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCommitment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusRepository = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.ModalDesciption = new DevExpress.XtraEditors.LabelControl();
            this.ModalTitle = new DevExpress.XtraEditors.LabelControl();
            this.HTProfile = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ContextMenuRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuBtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuBtnRemove = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.ContextMenuRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(816, 43);
            this.ButtonCreate.LookAndFeel.SkinName = "WXI";
            this.ButtonCreate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(93, 36);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Crear";
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // GridTasks
            // 
            this.GridTasks.Location = new System.Drawing.Point(12, 95);
            this.GridTasks.MainView = this.GidViewTasks;
            this.GridTasks.Name = "GridTasks";
            this.GridTasks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.StatusRepository,
            this.PriorityRepository});
            this.GridTasks.Size = new System.Drawing.Size(897, 424);
            this.GridTasks.TabIndex = 1;
            this.GridTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GidViewTasks});
            this.GridTasks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridTasks_MouseDown);
            // 
            // GidViewTasks
            // 
            this.GidViewTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnId,
            this.ColumnDescription,
            this.ColumnPriority,
            this.ColumnCommitment,
            this.ColumnStatus});
            this.GidViewTasks.GridControl = this.GridTasks;
            this.GidViewTasks.Name = "GidViewTasks";
            this.GidViewTasks.OptionsBehavior.ReadOnly = true;
            // 
            // ColumnId
            // 
            this.ColumnId.Caption = "Id";
            this.ColumnId.FieldName = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = true;
            this.ColumnId.VisibleIndex = 0;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.Caption = "Descripción";
            this.ColumnDescription.FieldName = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.Visible = true;
            this.ColumnDescription.VisibleIndex = 1;
            // 
            // ColumnPriority
            // 
            this.ColumnPriority.Caption = "Prioridad";
            this.ColumnPriority.ColumnEdit = this.PriorityRepository;
            this.ColumnPriority.FieldName = "PriorityId";
            this.ColumnPriority.Name = "ColumnPriority";
            this.ColumnPriority.Visible = true;
            this.ColumnPriority.VisibleIndex = 2;
            // 
            // PriorityRepository
            // 
            this.PriorityRepository.AutoHeight = false;
            this.PriorityRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PriorityRepository.Name = "PriorityRepository";
            this.PriorityRepository.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnCommitment
            // 
            this.ColumnCommitment.Caption = "Compromiso";
            this.ColumnCommitment.FieldName = "Commitment";
            this.ColumnCommitment.Name = "ColumnCommitment";
            this.ColumnCommitment.Visible = true;
            this.ColumnCommitment.VisibleIndex = 3;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.Caption = "Estado";
            this.ColumnStatus.ColumnEdit = this.StatusRepository;
            this.ColumnStatus.FieldName = "StatusId";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Visible = true;
            this.ColumnStatus.VisibleIndex = 4;
            // 
            // StatusRepository
            // 
            this.StatusRepository.AutoHeight = false;
            this.StatusRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusRepository.Name = "StatusRepository";
            this.StatusRepository.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svgImageBox1.Location = new System.Drawing.Point(15, 20);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(61, 59);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 19;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // ModalDesciption
            // 
            this.ModalDesciption.Location = new System.Drawing.Point(96, 53);
            this.ModalDesciption.Name = "ModalDesciption";
            this.ModalDesciption.Size = new System.Drawing.Size(282, 13);
            this.ModalDesciption.TabIndex = 18;
            this.ModalDesciption.Text = "Aquí podrá visualizar el contenido de las tareas registradas";
            // 
            // ModalTitle
            // 
            this.ModalTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalTitle.Appearance.Options.UseFont = true;
            this.ModalTitle.Location = new System.Drawing.Point(96, 21);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Size = new System.Drawing.Size(71, 25);
            this.ModalTitle.TabIndex = 17;
            this.ModalTitle.Text = "Tareas";
            // 
            // HTProfile
            // 
            this.HTProfile.Location = new System.Drawing.Point(15, 527);
            this.HTProfile.Name = "HTProfile";
            this.HTProfile.Size = new System.Drawing.Size(78, 13);
            this.HTProfile.TabIndex = 20;
            this.HTProfile.Text = "Brayan Martinez";
            this.HTProfile.Click += new System.EventHandler(this.HTProfile_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(853, 529);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "NCQ - 2025";
            // 
            // ContextMenuRow
            // 
            this.ContextMenuRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuBtnEdit,
            this.ContextMenuBtnRemove});
            this.ContextMenuRow.Name = "ContextMenuRow";
            this.ContextMenuRow.Size = new System.Drawing.Size(181, 70);
            // 
            // ContextMenuBtnEdit
            // 
            this.ContextMenuBtnEdit.Name = "ContextMenuBtnEdit";
            this.ContextMenuBtnEdit.Size = new System.Drawing.Size(180, 22);
            this.ContextMenuBtnEdit.Text = "Editar";
            this.ContextMenuBtnEdit.Click += new System.EventHandler(this.ContextMenuEditBtn_Click);
            // 
            // ContextMenuBtnRemove
            // 
            this.ContextMenuBtnRemove.Name = "ContextMenuBtnRemove";
            this.ContextMenuBtnRemove.Size = new System.Drawing.Size(180, 22);
            this.ContextMenuBtnRemove.Text = "Eliminar";
            this.ContextMenuBtnRemove.Click += new System.EventHandler(this.ContextMenuRemoveBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.HTProfile);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.ModalDesciption);
            this.Controls.Add(this.ModalTitle);
            this.Controls.Add(this.GridTasks);
            this.Controls.Add(this.ButtonCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.GridTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ContextMenuRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ButtonCreate;
        private DevExpress.XtraGrid.GridControl GridTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView GidViewTasks;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.LabelControl ModalDesciption;
        private DevExpress.XtraEditors.LabelControl ModalTitle;
        private DevExpress.XtraEditors.HyperlinkLabelControl HTProfile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPriority;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCommitment;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit PriorityRepository;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit StatusRepository;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.ContextMenuStrip ContextMenuRow;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuBtnEdit;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuBtnRemove;
    }
}

