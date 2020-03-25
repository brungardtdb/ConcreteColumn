using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tekla Structures Namespaces
using TSM = Tekla.Structures.Model;
using TSD = Tekla.Structures.Dialog;
using TSDT = Tekla.Structures.Datatype;
using T3D = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using Tekla.Structures.Model.Operations;

namespace ConcreteColumn
{

    class StructuresData 
    {
        [StructuresField("ColumnProfile")]
        public string ColumnProfile;
        [StructuresField("RebarSize")]
        public string RebarSize;
        [StructuresField("RebarGrade")]
        public string RebarGrade;
        [StructuresField("RebarBendingRadius")]
        public string RebarBendingRadius;
        [StructuresField("FootingSize")]
        public string FootingSize;
    }

    [Plugin("ConcreteColumn.ConcreteColumnPlugin")] // Mandatory field which defines that the class is a plug-in-and stores the name of the plug-in to the system.
    [PluginUserInterface("ConcreteColumn.ConcreteColumnFrm")] // Mandatory field which defines the user interface the plug-in uses - A windows form class

    class ConcreteColumnPlugin : PluginBase
    {

        private StructuresData Data { get; set; }

        // Fields for ConcreteColumn class
        private TSM.Model _pluginModel;
        private TSM.TransformationPlane _transformationPlane;
        private string _columnProfile;
        private string _rebarSize;
        private string _rebarGrade;
        private string _footingProfile;
        private string _rebarBendingRadius;
        private double _footingSize;
        private string _materialString = "K30-2";
        private string _classString = "8";
        private double _footingDepth = -500.0;
        private double _columnHeight = 8000.00;
        private T3D.Point _insertionPoint;


        public ConcreteColumnPlugin(StructuresData data)
        {
            Data = data;
            _pluginModel = new TSM.Model();

            _columnProfile = data.ColumnProfile;
            _rebarSize = data.RebarSize;
            _rebarGrade = data.RebarGrade;
            _rebarBendingRadius = data.RebarBendingRadius;

            if (!Double.TryParse(data.FootingSize, out _footingSize))
            {
                _footingSize = 100 * 25.4;
            }

            _footingProfile = Convert.ToString(_footingSize) + "*" + Convert.ToString(_footingSize);
            
        }

        public override List<InputDefinition> DefineInput()
        {
            // create new instance of TSMUI.Picker and input definition list
            TSMUI.Picker columnPicker = new TSMUI.Picker();
            List<InputDefinition> InputList = new List<InputDefinition>();


            try
            {
                // Get insertion point from user
                _insertionPoint = columnPicker.PickPoint() as T3D.Point;
                InputDefinition Input1 = new InputDefinition(_insertionPoint);
                InputList.Add(Input1);
            }
            catch (Exception ex)
            {

                throw;
            }

            return InputList;            
        }

        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                T3D.Point columnInsertionPoint = (T3D.Point)Input.ElementAt(0).GetInput();
            }
            catch (Exception ex)
            {

                throw;
            }

            return true;
        }

        
    }

   


}
