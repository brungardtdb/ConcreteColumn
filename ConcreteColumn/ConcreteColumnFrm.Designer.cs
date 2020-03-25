namespace ConcreteColumn
{
    partial class ConcreteColumnFrm
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
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.ColumnProfCatalog = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.ColumnProfile = new System.Windows.Forms.TextBox();
            this.ColumnProfileFlt = new System.Windows.Forms.CheckBox();
            this.RebarReinforcementCatalog = new Tekla.Structures.Dialog.UIControls.ReinforcementCatalog();
            this.RebarSizeFlt = new System.Windows.Forms.CheckBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblRebar = new System.Windows.Forms.Label();
            this.RebarSize = new System.Windows.Forms.TextBox();
            this.RebarGrade = new System.Windows.Forms.TextBox();
            this.RebarBendingRadius = new System.Windows.Forms.TextBox();
            this.RebarGradeFlt = new System.Windows.Forms.CheckBox();
            this.RebarBendingRadiusFlt = new System.Windows.Forms.CheckBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblBendingRadius = new System.Windows.Forms.Label();
            this.lblFooting = new System.Windows.Forms.Label();
            this.FootingSizeFlt = new System.Windows.Forms.CheckBox();
            this.FootingSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 312);
            this.okApplyModifyGetOnOffCancel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(800, 36);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 0;
            // 
            // saveLoad1
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad1, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(800, 53);
            this.saveLoad1.TabIndex = 1;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // ColumnProfCatalog
            // 
            this.structuresExtender.SetAttributeName(this.ColumnProfCatalog, null);
            this.structuresExtender.SetAttributeTypeName(this.ColumnProfCatalog, null);
            this.ColumnProfCatalog.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.ColumnProfCatalog, null);
            this.ColumnProfCatalog.Location = new System.Drawing.Point(214, 108);
            this.ColumnProfCatalog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColumnProfCatalog.Name = "ColumnProfCatalog";
            this.ColumnProfCatalog.SelectedProfile = "";
            this.ColumnProfCatalog.Size = new System.Drawing.Size(117, 33);
            this.ColumnProfCatalog.TabIndex = 2;
            this.ColumnProfCatalog.SelectClicked += new System.EventHandler(this.ColumnProfCatalog_SelectClicked);
            this.ColumnProfCatalog.SelectionDone += new System.EventHandler(this.ColumnProfCatalog_SelectionDone);
            // 
            // ColumnProfile
            // 
            this.structuresExtender.SetAttributeName(this.ColumnProfile, "ColumnProfile");
            this.structuresExtender.SetAttributeTypeName(this.ColumnProfile, "String");
            this.structuresExtender.SetBindPropertyName(this.ColumnProfile, "Text");
            this.ColumnProfile.Location = new System.Drawing.Point(100, 119);
            this.ColumnProfile.Name = "ColumnProfile";
            this.ColumnProfile.Size = new System.Drawing.Size(100, 22);
            this.ColumnProfile.TabIndex = 3;
            // 
            // ColumnProfileFlt
            // 
            this.structuresExtender.SetAttributeName(this.ColumnProfileFlt, "ColumnProfile");
            this.structuresExtender.SetAttributeTypeName(this.ColumnProfileFlt, null);
            this.ColumnProfileFlt.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.ColumnProfileFlt, null);
            this.structuresExtender.SetIsFilter(this.ColumnProfileFlt, true);
            this.ColumnProfileFlt.Location = new System.Drawing.Point(14, 123);
            this.ColumnProfileFlt.Name = "ColumnProfileFlt";
            this.ColumnProfileFlt.Size = new System.Drawing.Size(18, 17);
            this.ColumnProfileFlt.TabIndex = 4;
            this.ColumnProfileFlt.UseVisualStyleBackColor = true;
            // 
            // RebarReinforcementCatalog
            // 
            this.structuresExtender.SetAttributeName(this.RebarReinforcementCatalog, null);
            this.structuresExtender.SetAttributeTypeName(this.RebarReinforcementCatalog, null);
            this.RebarReinforcementCatalog.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.RebarReinforcementCatalog, null);
            this.RebarReinforcementCatalog.Location = new System.Drawing.Point(154, 161);
            this.RebarReinforcementCatalog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RebarReinforcementCatalog.Name = "RebarReinforcementCatalog";
            this.RebarReinforcementCatalog.SelectedRebarBendingRadius = 0D;
            this.RebarReinforcementCatalog.SelectedRebarGrade = "";
            this.RebarReinforcementCatalog.SelectedRebarSize = "";
            this.RebarReinforcementCatalog.Size = new System.Drawing.Size(117, 33);
            this.RebarReinforcementCatalog.TabIndex = 5;
            this.RebarReinforcementCatalog.SelectClicked += new System.EventHandler(this.RebarReinforcementCatalog_SelectClicked);
            this.RebarReinforcementCatalog.SelectionDone += new System.EventHandler(this.RebarReinforcementCatalog_SelectionDone);
            // 
            // RebarSizeFlt
            // 
            this.structuresExtender.SetAttributeName(this.RebarSizeFlt, "RebarSize");
            this.structuresExtender.SetAttributeTypeName(this.RebarSizeFlt, null);
            this.RebarSizeFlt.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.RebarSizeFlt, null);
            this.structuresExtender.SetIsFilter(this.RebarSizeFlt, true);
            this.RebarSizeFlt.Location = new System.Drawing.Point(13, 209);
            this.RebarSizeFlt.Name = "RebarSizeFlt";
            this.RebarSizeFlt.Size = new System.Drawing.Size(18, 17);
            this.RebarSizeFlt.TabIndex = 6;
            this.RebarSizeFlt.UseVisualStyleBackColor = true;
            // 
            // lblProfile
            // 
            this.structuresExtender.SetAttributeName(this.lblProfile, null);
            this.structuresExtender.SetAttributeTypeName(this.lblProfile, null);
            this.lblProfile.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.lblProfile, null);
            this.lblProfile.Location = new System.Drawing.Point(38, 123);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(56, 17);
            this.lblProfile.TabIndex = 7;
            this.lblProfile.Text = "Profile: ";
            // 
            // lblRebar
            // 
            this.structuresExtender.SetAttributeName(this.lblRebar, null);
            this.structuresExtender.SetAttributeTypeName(this.lblRebar, null);
            this.lblRebar.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.lblRebar, null);
            this.lblRebar.Location = new System.Drawing.Point(55, 177);
            this.lblRebar.Name = "lblRebar";
            this.lblRebar.Size = new System.Drawing.Size(51, 17);
            this.lblRebar.TabIndex = 8;
            this.lblRebar.Text = "Rebar:";
            // 
            // RebarSize
            // 
            this.structuresExtender.SetAttributeName(this.RebarSize, "RebarSize");
            this.structuresExtender.SetAttributeTypeName(this.RebarSize, "String");
            this.structuresExtender.SetBindPropertyName(this.RebarSize, "Text");
            this.RebarSize.Location = new System.Drawing.Point(154, 204);
            this.RebarSize.Name = "RebarSize";
            this.RebarSize.Size = new System.Drawing.Size(100, 22);
            this.RebarSize.TabIndex = 9;
            // 
            // RebarGrade
            // 
            this.structuresExtender.SetAttributeName(this.RebarGrade, "RebarGrade");
            this.structuresExtender.SetAttributeTypeName(this.RebarGrade, "String");
            this.structuresExtender.SetBindPropertyName(this.RebarGrade, "Text");
            this.RebarGrade.Location = new System.Drawing.Point(154, 232);
            this.RebarGrade.Name = "RebarGrade";
            this.RebarGrade.Size = new System.Drawing.Size(100, 22);
            this.RebarGrade.TabIndex = 10;
            // 
            // RebarBendingRadius
            // 
            this.structuresExtender.SetAttributeName(this.RebarBendingRadius, "RebarBendingRadius");
            this.structuresExtender.SetAttributeTypeName(this.RebarBendingRadius, "Double");
            this.structuresExtender.SetBindPropertyName(this.RebarBendingRadius, "Text");
            this.RebarBendingRadius.Location = new System.Drawing.Point(154, 260);
            this.RebarBendingRadius.Name = "RebarBendingRadius";
            this.RebarBendingRadius.Size = new System.Drawing.Size(100, 22);
            this.RebarBendingRadius.TabIndex = 11;
            // 
            // RebarGradeFlt
            // 
            this.structuresExtender.SetAttributeName(this.RebarGradeFlt, "RebarGrade");
            this.structuresExtender.SetAttributeTypeName(this.RebarGradeFlt, null);
            this.RebarGradeFlt.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.RebarGradeFlt, null);
            this.structuresExtender.SetIsFilter(this.RebarGradeFlt, true);
            this.RebarGradeFlt.Location = new System.Drawing.Point(13, 236);
            this.RebarGradeFlt.Name = "RebarGradeFlt";
            this.RebarGradeFlt.Size = new System.Drawing.Size(18, 17);
            this.RebarGradeFlt.TabIndex = 12;
            this.RebarGradeFlt.UseVisualStyleBackColor = true;
            // 
            // RebarBendingRadiusFlt
            // 
            this.structuresExtender.SetAttributeName(this.RebarBendingRadiusFlt, "RebarBendingRadius");
            this.structuresExtender.SetAttributeTypeName(this.RebarBendingRadiusFlt, null);
            this.RebarBendingRadiusFlt.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.RebarBendingRadiusFlt, null);
            this.structuresExtender.SetIsFilter(this.RebarBendingRadiusFlt, true);
            this.RebarBendingRadiusFlt.Location = new System.Drawing.Point(13, 265);
            this.RebarBendingRadiusFlt.Name = "RebarBendingRadiusFlt";
            this.RebarBendingRadiusFlt.Size = new System.Drawing.Size(18, 17);
            this.RebarBendingRadiusFlt.TabIndex = 13;
            this.RebarBendingRadiusFlt.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.structuresExtender.SetAttributeName(this.lblSize, null);
            this.structuresExtender.SetAttributeTypeName(this.lblSize, null);
            this.lblSize.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.lblSize, null);
            this.lblSize.Location = new System.Drawing.Point(109, 205);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 17);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Size:";
            // 
            // lblGrade
            // 
            this.structuresExtender.SetAttributeName(this.lblGrade, null);
            this.structuresExtender.SetAttributeTypeName(this.lblGrade, null);
            this.lblGrade.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.lblGrade, null);
            this.lblGrade.Location = new System.Drawing.Point(96, 233);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(52, 17);
            this.lblGrade.TabIndex = 15;
            this.lblGrade.Text = "Grade:";
            // 
            // lblBendingRadius
            // 
            this.structuresExtender.SetAttributeName(this.lblBendingRadius, null);
            this.structuresExtender.SetAttributeTypeName(this.lblBendingRadius, null);
            this.lblBendingRadius.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.lblBendingRadius, null);
            this.lblBendingRadius.Location = new System.Drawing.Point(41, 263);
            this.lblBendingRadius.Name = "lblBendingRadius";
            this.lblBendingRadius.Size = new System.Drawing.Size(112, 17);
            this.lblBendingRadius.TabIndex = 16;
            this.lblBendingRadius.Text = "Bending Radius:";
            // 
            // lblFooting
            // 
            this.structuresExtender.SetAttributeName(this.lblFooting, null);
            this.structuresExtender.SetAttributeTypeName(this.lblFooting, null);
            this.lblFooting.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.lblFooting, null);
            this.lblFooting.Location = new System.Drawing.Point(40, 71);
            this.lblFooting.Name = "lblFooting";
            this.lblFooting.Size = new System.Drawing.Size(94, 17);
            this.lblFooting.TabIndex = 17;
            this.lblFooting.Text = "Footing Size: ";
            // 
            // FootingSizeFlt
            // 
            this.structuresExtender.SetAttributeName(this.FootingSizeFlt, "FootingSize");
            this.structuresExtender.SetAttributeTypeName(this.FootingSizeFlt, null);
            this.FootingSizeFlt.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.FootingSizeFlt, null);
            this.structuresExtender.SetIsFilter(this.FootingSizeFlt, true);
            this.FootingSizeFlt.Location = new System.Drawing.Point(12, 72);
            this.FootingSizeFlt.Name = "FootingSizeFlt";
            this.FootingSizeFlt.Size = new System.Drawing.Size(18, 17);
            this.FootingSizeFlt.TabIndex = 18;
            this.FootingSizeFlt.UseVisualStyleBackColor = true;
            // 
            // FootingSize
            // 
            this.structuresExtender.SetAttributeName(this.FootingSize, "FootingSize");
            this.structuresExtender.SetAttributeTypeName(this.FootingSize, "String");
            this.structuresExtender.SetBindPropertyName(this.FootingSize, "Text");
            this.FootingSize.Location = new System.Drawing.Point(140, 68);
            this.FootingSize.Name = "FootingSize";
            this.FootingSize.Size = new System.Drawing.Size(100, 22);
            this.FootingSize.TabIndex = 19;
            this.FootingSize.TextChanged += new System.EventHandler(this.FootingSize_TextChanged);
            // 
            // ConcreteColumnFrm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.FootingSize);
            this.Controls.Add(this.FootingSizeFlt);
            this.Controls.Add(this.lblFooting);
            this.Controls.Add(this.lblBendingRadius);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.RebarBendingRadiusFlt);
            this.Controls.Add(this.RebarGradeFlt);
            this.Controls.Add(this.RebarBendingRadius);
            this.Controls.Add(this.RebarGrade);
            this.Controls.Add(this.RebarSize);
            this.Controls.Add(this.lblRebar);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.RebarSizeFlt);
            this.Controls.Add(this.RebarReinforcementCatalog);
            this.Controls.Add(this.ColumnProfileFlt);
            this.Controls.Add(this.ColumnProfile);
            this.Controls.Add(this.ColumnProfCatalog);
            this.Controls.Add(this.saveLoad1);
            this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
            this.Name = "ConcreteColumnFrm";
            this.Text = "Concrete Column";
            this.Load += new System.EventHandler(this.ConcreteColumnFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog ColumnProfCatalog;
        private System.Windows.Forms.TextBox ColumnProfile;
        private System.Windows.Forms.CheckBox ColumnProfileFlt;
        private Tekla.Structures.Dialog.UIControls.ReinforcementCatalog RebarReinforcementCatalog;
        private System.Windows.Forms.CheckBox RebarSizeFlt;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblRebar;
        private System.Windows.Forms.TextBox RebarSize;
        private System.Windows.Forms.TextBox RebarGrade;
        private System.Windows.Forms.TextBox RebarBendingRadius;
        private System.Windows.Forms.CheckBox RebarGradeFlt;
        private System.Windows.Forms.CheckBox RebarBendingRadiusFlt;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblBendingRadius;
        private System.Windows.Forms.Label lblFooting;
        private System.Windows.Forms.CheckBox FootingSizeFlt;
        private System.Windows.Forms.TextBox FootingSize;
    }
}

