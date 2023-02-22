namespace studentManager_GUI
{
    partial class HomaPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomaPage));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(431, 434);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement4,
            this.accordionControlElement6});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 434);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Trang chủ";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Học viên";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5});
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Giảng viên";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Element5";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement7});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Cơ sở vậy chất";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement7.ImageOptions.Image")));
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Đăng ký lớp học";
            this.accordionControlElement7.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // HomaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "HomaPage";
            this.NavigationControl = this.accordionControl1;
            this.Text = "HomaPage";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
    }
}