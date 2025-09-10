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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonCreate = new DevExpress.XtraEditors.SimpleButton();
            this.GridTasks = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.ModalDesciption = new DevExpress.XtraEditors.LabelControl();
            this.ModalTitle = new DevExpress.XtraEditors.LabelControl();
            this.HTProfile = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
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
            this.GridTasks.MainView = this.gridView1;
            this.GridTasks.Name = "GridTasks";
            this.GridTasks.Size = new System.Drawing.Size(897, 424);
            this.GridTasks.TabIndex = 1;
            this.GridTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridTasks;
            this.gridView1.Name = "gridView1";
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
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.GridTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ButtonCreate;
        private DevExpress.XtraGrid.GridControl GridTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.LabelControl ModalDesciption;
        private DevExpress.XtraEditors.LabelControl ModalTitle;
        private DevExpress.XtraEditors.HyperlinkLabelControl HTProfile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

