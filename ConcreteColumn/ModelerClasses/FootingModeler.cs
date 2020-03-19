using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcreteColumn.ModelerClasses.AbstractClasses;

// Tekla Structures namespaces
using Tekla.Structures.Model;
using Tekla.Structures.Dialog.UIControls;
using T3D = Tekla.Structures.Geometry3d;


namespace ConcreteColumn.ModelerClasses
{
    class FootingModeler : BeamModeler
    {
        public FootingModeler(Model classModel)
        {
            // Pass model reference value into base class
            base.classModel = classModel;

            // create new beam
            Beam columnBeam = new Beam();
            base.classBeam = columnBeam;
            base.setName("Pad Footing");
        }

        public void SetDepth(T3D.Point columnLocation, double footingDepth)
        {
            T3D.Point TopOfColumn;

            base.classBeam.StartPoint = columnLocation;
            TopOfColumn = columnLocation;
            // offset z coordinate of start point by footing depth
            base.classBeam.StartPoint.Z -= footingDepth;
            // assign selection point as top of column
            base.classBeam.EndPoint = TopOfColumn;
        }
    }
}
