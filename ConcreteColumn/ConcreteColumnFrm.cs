﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

// Tekla Structures Namespaces
using TSM = Tekla.Structures.Model;
using TSD = Tekla.Structures.Dialog;
using TSDT = Tekla.Structures.Datatype;
using T3D = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;


namespace ConcreteColumn
{
    public partial class ConcreteColumnFrm : TSD.PluginFormBase
    {
        public ConcreteColumnFrm()
        {
            InitializeComponent();
        }

        private void ConcreteColumnFrm_Load(object sender, EventArgs e)
        {

        }

        #region okApplyModifyGetOnOffCancel
        private void OkApplyModifyGetOnOffCancel1_OkClicked_1(object sender, EventArgs e)
        {
            this.Apply();
            this.Close();

        }

        private void OkApplyModifyGetOnOffCancel1_ApplyClicked_1(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel1_ModifyClicked_1(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel1_GetClicked_1(object sender, EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel1_OnOffClicked_1(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel1_CancelClicked_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void ColumnProfCatalog_SelectClicked(object sender, EventArgs e)
        {   // Set selected profile according to value in the form
            ColumnProfCatalog.SelectedProfile = ColumnProfile.Text;
        }

        private void ColumnProfCatalog_SelectionDone(object sender, EventArgs e)
        {   // Update text in form based on selected value
            SetAttributeValue(ColumnProfile, ColumnProfCatalog.SelectedProfile);            
        }

        private void RebarReinforcementCatalog_SelectClicked(object sender, EventArgs e)
        {   // Set selected rebar values according to value in the form
            RebarReinforcementCatalog.SelectedRebarSize = RebarSize.Text;
            RebarReinforcementCatalog.SelectedRebarGrade = RebarGrade.Text;
            RebarReinforcementCatalog.SelectedRebarBendingRadius = TSDT.Distance.Parse(RebarBendingRadius.SelectedText, CultureInfo.InvariantCulture).Millimeters;            
        }

        private void RebarReinforcementCatalog_SelectionDone(object sender, EventArgs e)
        {   // Update text in form based on selected values
            
            SetAttributeValue(RebarSize, RebarReinforcementCatalog.SelectedRebarSize.ToString());
            SetAttributeValue(RebarGrade, RebarReinforcementCatalog.SelectedRebarGrade.ToString());
            SetAttributeValue(RebarBendingRadius, RebarReinforcementCatalog.SelectedRebarBendingRadius.ToString());
        }

        private void FootingSize_TextChanged(object sender, EventArgs e)
        {
            SetAttributeValue(FootingSize, FootingSize.Text);
        }
    }
}
