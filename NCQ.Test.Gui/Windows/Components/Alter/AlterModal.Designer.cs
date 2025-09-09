namespace NCQ.Test.Gui.Windows.Components
{
    partial class AlterModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterModal));
            this.WinAccept = new DevExpress.XtraEditors.SimpleButton();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.WinCancel = new DevExpress.XtraEditors.SimpleButton();
            this.CtrlDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CtrlNotes = new DevExpress.XtraEditors.MemoEdit();
            this.CtrlState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CtrlPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ModalTitle = new DevExpress.XtraEditors.LabelControl();
            this.ModalDesciption = new DevExpress.XtraEditors.LabelControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.CtrlCommitmentEnd = new DevExpress.XtraEditors.DateEdit();
            this.CtrlCommitmentStart = new DevExpress.XtraEditors.DateEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ResumenText = new DevExpress.XtraEditors.LabelControl();
            this.FormError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormError)).BeginInit();
            this.SuspendLayout();
            // 
            // WinAccept
            // 
            this.WinAccept.Location = new System.Drawing.Point(598, 17);
            this.WinAccept.Name = "WinAccept";
            this.WinAccept.Size = new System.Drawing.Size(96, 41);
            this.WinAccept.TabIndex = 1;
            this.WinAccept.Text = "Guardar";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.WinAccept);
            this.stackPanel1.Controls.Add(this.WinCancel);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel1.Location = new System.Drawing.Point(0, 438);
            this.stackPanel1.LookAndFeel.SkinName = "WXI";
            this.stackPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(711, 76);
            this.stackPanel1.TabIndex = 2;
            this.stackPanel1.UseSkinIndents = true;
            // 
            // WinCancel
            // 
            this.WinCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WinCancel.Location = new System.Drawing.Point(496, 17);
            this.WinCancel.Name = "WinCancel";
            this.WinCancel.Size = new System.Drawing.Size(96, 41);
            this.WinCancel.TabIndex = 2;
            this.WinCancel.Text = "Cancelar";
            // 
            // CtrlDescription
            // 
            this.CtrlDescription.Location = new System.Drawing.Point(13, 59);
            this.CtrlDescription.Name = "CtrlDescription";
            this.CtrlDescription.Size = new System.Drawing.Size(306, 96);
            this.CtrlDescription.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Descripción";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 221);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Notas";
            // 
            // CtrlNotes
            // 
            this.CtrlNotes.Location = new System.Drawing.Point(14, 240);
            this.CtrlNotes.Name = "CtrlNotes";
            this.CtrlNotes.Size = new System.Drawing.Size(305, 72);
            this.CtrlNotes.TabIndex = 6;
            // 
            // CtrlState
            // 
            this.CtrlState.Location = new System.Drawing.Point(13, 186);
            this.CtrlState.Name = "CtrlState";
            this.CtrlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlState.Size = new System.Drawing.Size(150, 28);
            this.CtrlState.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Estado";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(168, 167);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Prioridad";
            // 
            // CtrlPriority
            // 
            this.CtrlPriority.Location = new System.Drawing.Point(169, 186);
            this.CtrlPriority.Name = "CtrlPriority";
            this.CtrlPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlPriority.Size = new System.Drawing.Size(150, 28);
            this.CtrlPriority.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.CtrlDescription);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.CtrlPriority);
            this.groupControl1.Controls.Add(this.CtrlState);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.CtrlNotes);
            this.groupControl1.Location = new System.Drawing.Point(15, 102);
            this.groupControl1.LookAndFeel.SkinName = "WXI";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(332, 330);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Datos básicos";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(212, 167);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(6, 13);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "*";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(70, 39);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(6, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(49, 167);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(6, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "*";
            // 
            // ModalTitle
            // 
            this.ModalTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalTitle.Appearance.Options.UseFont = true;
            this.ModalTitle.Location = new System.Drawing.Point(96, 21);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Size = new System.Drawing.Size(60, 25);
            this.ModalTitle.TabIndex = 14;
            this.ModalTitle.Text = "Tarea";
            // 
            // ModalDesciption
            // 
            this.ModalDesciption.Location = new System.Drawing.Point(96, 53);
            this.ModalDesciption.Name = "ModalDesciption";
            this.ModalDesciption.Size = new System.Drawing.Size(312, 13);
            this.ModalDesciption.TabIndex = 15;
            this.ModalDesciption.Text = "Aquí podrá visualizar, crear y modificar el contenido de una tarea";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svgImageBox1.Location = new System.Drawing.Point(15, 20);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(61, 59);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 16;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.CtrlCommitmentEnd);
            this.groupControl2.Controls.Add(this.CtrlCommitmentStart);
            this.groupControl2.Location = new System.Drawing.Point(362, 102);
            this.groupControl2.LookAndFeel.SkinName = "WXI";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(334, 94);
            this.groupControl2.TabIndex = 17;
            this.groupControl2.Text = "Datos de compromiso";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(193, 32);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(6, 13);
            this.labelControl11.TabIndex = 15;
            this.labelControl11.Text = "*";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(41, 32);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(6, 13);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(169, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Final";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Inicio";
            // 
            // CtrlCommitmentEnd
            // 
            this.CtrlCommitmentEnd.EditValue = null;
            this.CtrlCommitmentEnd.Location = new System.Drawing.Point(169, 51);
            this.CtrlCommitmentEnd.Name = "CtrlCommitmentEnd";
            this.CtrlCommitmentEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlCommitmentEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlCommitmentEnd.Size = new System.Drawing.Size(150, 28);
            this.CtrlCommitmentEnd.TabIndex = 2;
            // 
            // CtrlCommitmentStart
            // 
            this.CtrlCommitmentStart.EditValue = null;
            this.CtrlCommitmentStart.Location = new System.Drawing.Point(14, 51);
            this.CtrlCommitmentStart.Name = "CtrlCommitmentStart";
            this.CtrlCommitmentStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlCommitmentStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlCommitmentStart.Size = new System.Drawing.Size(149, 28);
            this.CtrlCommitmentStart.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ResumenText);
            this.groupControl3.Location = new System.Drawing.Point(362, 214);
            this.groupControl3.LookAndFeel.SkinName = "WXI";
            this.groupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(334, 218);
            this.groupControl3.TabIndex = 18;
            this.groupControl3.Text = "Resumen";
            // 
            // ResumenText
            // 
            this.ResumenText.Location = new System.Drawing.Point(14, 45);
            this.ResumenText.Name = "ResumenText";
            this.ResumenText.Size = new System.Drawing.Size(191, 13);
            this.ResumenText.TabIndex = 0;
            this.ResumenText.Text = "Aquí se mostrará el resumen de la tarea";
            // 
            // FormError
            // 
            this.FormError.ContainerControl = this;
            // 
            // AlterModal
            // 
            this.AcceptButton = this.WinAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.WinCancel;
            this.ClientSize = new System.Drawing.Size(711, 514);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.ModalDesciption);
            this.Controls.Add(this.ModalTitle);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.stackPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterModal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CtrlDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCommitmentStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton WinAccept;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton WinCancel;
        private DevExpress.XtraEditors.MemoEdit CtrlDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit CtrlNotes;
        private DevExpress.XtraEditors.ComboBoxEdit CtrlState;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit CtrlPriority;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl ModalTitle;
        private DevExpress.XtraEditors.LabelControl ModalDesciption;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit CtrlCommitmentStart;
        private DevExpress.XtraEditors.DateEdit CtrlCommitmentEnd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl ResumenText;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider FormError;
    }
}