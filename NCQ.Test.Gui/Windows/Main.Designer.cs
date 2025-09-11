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
            this.CommitmentStart = new DevExpress.XtraEditors.DateEdit();
            this.CommitmentEnd = new DevExpress.XtraEditors.DateEdit();
            this.CtrlStatusId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CtrlPriorityId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.BtnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.ContextMenuRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStatusId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPriorityId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(808, 154);
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
            this.GridTasks.Location = new System.Drawing.Point(18, 205);
            this.GridTasks.MainView = this.GidViewTasks;
            this.GridTasks.Name = "GridTasks";
            this.GridTasks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.StatusRepository,
            this.PriorityRepository});
            this.GridTasks.Size = new System.Drawing.Size(883, 319);
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
            this.HTProfile.Location = new System.Drawing.Point(15, 530);
            this.HTProfile.Name = "HTProfile";
            this.HTProfile.Size = new System.Drawing.Size(78, 13);
            this.HTProfile.TabIndex = 20;
            this.HTProfile.Text = "Brayan Martinez";
            this.HTProfile.Click += new System.EventHandler(this.HTProfile_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(845, 532);
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
            this.ContextMenuRow.Size = new System.Drawing.Size(118, 48);
            // 
            // ContextMenuBtnEdit
            // 
            this.ContextMenuBtnEdit.Name = "ContextMenuBtnEdit";
            this.ContextMenuBtnEdit.Size = new System.Drawing.Size(117, 22);
            this.ContextMenuBtnEdit.Text = "Editar";
            this.ContextMenuBtnEdit.Click += new System.EventHandler(this.ContextMenuEditBtn_Click);
            // 
            // ContextMenuBtnRemove
            // 
            this.ContextMenuBtnRemove.Name = "ContextMenuBtnRemove";
            this.ContextMenuBtnRemove.Size = new System.Drawing.Size(117, 22);
            this.ContextMenuBtnRemove.Text = "Eliminar";
            this.ContextMenuBtnRemove.Click += new System.EventHandler(this.ContextMenuRemoveBtn_Click);
            // 
            // CommitmentStart
            // 
            this.CommitmentStart.EditValue = null;
            this.CommitmentStart.Location = new System.Drawing.Point(13, 53);
            this.CommitmentStart.Name = "CommitmentStart";
            this.CommitmentStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommitmentStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommitmentStart.Properties.LookAndFeel.SkinName = "WXI";
            this.CommitmentStart.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CommitmentStart.Size = new System.Drawing.Size(100, 28);
            this.CommitmentStart.TabIndex = 3;
            // 
            // CommitmentEnd
            // 
            this.CommitmentEnd.EditValue = null;
            this.CommitmentEnd.Location = new System.Drawing.Point(119, 53);
            this.CommitmentEnd.Name = "CommitmentEnd";
            this.CommitmentEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommitmentEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommitmentEnd.Properties.LookAndFeel.SkinName = "WXI";
            this.CommitmentEnd.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CommitmentEnd.Size = new System.Drawing.Size(115, 28);
            this.CommitmentEnd.TabIndex = 4;
            // 
            // CtrlStatusId
            // 
            this.CtrlStatusId.Location = new System.Drawing.Point(12, 51);
            this.CtrlStatusId.Name = "CtrlStatusId";
            this.CtrlStatusId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlStatusId.Properties.LookAndFeel.SkinName = "WXI";
            this.CtrlStatusId.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CtrlStatusId.Properties.NullText = "";
            this.CtrlStatusId.Properties.PopupView = this.gridLookUpEdit1View;
            this.CtrlStatusId.Size = new System.Drawing.Size(100, 28);
            this.CtrlStatusId.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // CtrlPriorityId
            // 
            this.CtrlPriorityId.Location = new System.Drawing.Point(118, 51);
            this.CtrlPriorityId.Name = "CtrlPriorityId";
            this.CtrlPriorityId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlPriorityId.Properties.LookAndFeel.SkinName = "WXI";
            this.CtrlPriorityId.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CtrlPriorityId.Properties.NullText = "";
            this.CtrlPriorityId.Properties.PopupView = this.gridLookUpEdit2View;
            this.CtrlPriorityId.Size = new System.Drawing.Size(100, 28);
            this.CtrlPriorityId.TabIndex = 8;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Desde";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(119, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Hasta";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Estado";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(118, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Prioridad";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(515, 154);
            this.BtnFilter.LookAndFeel.SkinName = "WXI";
            this.BtnFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(93, 36);
            this.BtnFilter.TabIndex = 13;
            this.BtnFilter.Text = "Filtrar";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(515, 112);
            this.simpleButton2.LookAndFeel.SkinName = "WXI";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 36);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Limpiar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CommitmentStart);
            this.groupControl1.Controls.Add(this.CommitmentEnd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(18, 96);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(242, 94);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Fecha de compromiso";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.CtrlPriorityId);
            this.groupControl2.Controls.Add(this.CtrlStatusId);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(271, 96);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(232, 94);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "General";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 557);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.HTProfile);
            this.Controls.Add(this.GridTasks);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.ModalDesciption);
            this.Controls.Add(this.ModalTitle);
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
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommitmentEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStatusId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPriorityId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
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
        private DevExpress.XtraEditors.DateEdit CommitmentStart;
        private DevExpress.XtraEditors.DateEdit CommitmentEnd;
        private DevExpress.XtraEditors.GridLookUpEdit CtrlPriorityId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit CtrlStatusId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnFilter;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}

