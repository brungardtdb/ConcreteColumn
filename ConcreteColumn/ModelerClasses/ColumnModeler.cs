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
    class ColumnModeler : BeamModeler
    {
        public ColumnModeler(Model classModel)
        {
            // Pass model reference value into base class
            base.classModel = classModel;

            // create new beam
            Beam columnBeam = new Beam();
            base.classBeam = columnBeam;
            base.setName("Concrete Column");
        }

        public void SetHeight(T3D.Point columnLocation, double columnHeight)
        {
            T3D.Point TopOfColumn;

            base.classBeam.StartPoint = columnLocation;
            TopOfColumn = columnLocation;
            TopOfColumn.Z += columnHeight;
            base.classBeam.EndPoint = TopOfColumn;
        }
    }
}
