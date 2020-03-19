using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
// Tekla Structures namespaces
using Tekla.Structures.Model;
using Tekla.Structures.Dialog.UIControls;

namespace ConcreteColumn.ModelerClasses.AbstractClasses
{
    public abstract class BeamModeler
    {
        /// <summary>
        /// Fields for BeamModeler class
        /// </summary>
        protected Model classModel; // tekla model we will be working in
        protected Beam classBeam; // beam we will be modeling

        /// <summary>
        /// Constructor for modeler class
        /// </summary>
        protected BeamModeler()
        {

        }

        /// <summary>
        /// Method for retrieving class beam
        /// </summary>
        /// <returns></returns>
        public Beam getBeam()
        {
            try
            {
                return this.classBeam;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to set profile for beam
        /// </summary>
        /// <param name="beamProfile"></param>
        public void setProfile(String beamProfile)
        {
            try
            {
                this.classBeam.Profile.ProfileString = beamProfile;
            }
            catch
            {
                MessageBox.Show("Invalid profile was entered.");
            }
        }

        /// <summary>
        /// Method to retrieve profile for beam
        /// </summary>
        /// <returns></returns>
        public string getProfile()
        {
            try
            {
                return classBeam.Profile.ProfileString;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// Method to set name for beam
        /// </summary>
        /// <param name="beamName"></param>
        public void setName(string beamName)
        {
            try
            {
                this.classBeam.Name = beamName;
            }
            catch
            {

                MessageBox.Show("Something went wrong.");
            }
        }

        /// <summary>
        /// Method to retrieve name for beam
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            try
            {
                return classBeam.Name;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        /// <summary>
        /// Method to set finish for beam
        /// </summary>
        /// <param name="beamFinish"></param>
        public void setFinish(string beamFinish)
        {
            try
            {
                this.classBeam.Finish = beamFinish;
            }
            catch
            {

                MessageBox.Show("Invalid finish.");
            }
        }

        /// <summary>
        /// Method to get finish for beam
        /// </summary>
        /// <returns></returns>
        public string getFinish()
        {
            try
            {
                return classBeam.Finish;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Method to set class for beam
        /// </summary>
        /// <param name="beamClass"></param>
        public void setClass(string beamClass)
        {
            try
            {
                this.classBeam.Class = beamClass;
            }
            catch
            {

                MessageBox.Show("Invalid class.");
            }
        }

        /// <summary>
        /// Method to get class for beam
        /// </summary>
        /// <returns></returns>
        public string getClass()
        {
            try
            {
                return classBeam.Class;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Method to set assembly number prefix for beam
        /// </summary>
        /// <param name="assemblyNumPrefix"></param>
        public void setAssemblyNumPrefix(string assemblyNumPrefix)
        {
            try
            {
                this.classBeam.AssemblyNumber.Prefix = assemblyNumPrefix;
            }
            catch
            {

                MessageBox.Show("Something went wrong.");
            }
        }

        /// <summary>
        /// Method to set assembly number start number
        /// </summary>
        /// <param name="assemblyStartNum"></param>
        public void setAssemblyStartNum(int assemblyStartNum)
        {
            try
            {
                this.classBeam.AssemblyNumber.StartNumber = assemblyStartNum;
            }
            catch
            {

                MessageBox.Show("Invalid start number for assembly.");
            }
        }

        /// <summary>
        /// Method to set assembly number prefix for beam
        /// </summary>
        /// <param name="partNumPrefix"></param>
        public void setPartNumPrefix(string partNumPrefix)
        {
            try
            {
                this.classBeam.PartNumber.Prefix = partNumPrefix;
            }
            catch
            {

                MessageBox.Show("Something went wrong.");
            }
        }

        /// <summary>
        /// Method to set assembly number prefix for beam
        /// </summary>
        /// <param name="partStartNum"></param>
        public void setPartStartNum(int partStartNum)
        {
            try
            {
                this.classBeam.PartNumber.StartNumber = partStartNum;
            }
            catch
            {

                MessageBox.Show("Something went wrong.");
            }
        }

        /// <summary>
        /// Method to set assembly number prefix for beam
        /// </summary>
        /// <param name="beamMaterial"></param>
        public void setMaterialString(string beamMaterial)
        {
            try
            {
                this.classBeam.Material.MaterialString = beamMaterial;
            }
            catch
            {

                MessageBox.Show("Invalid material.");
            }
        }

        /// <summary>
        /// Method to set "On plane" position for beam.
        /// 0 = MIDDLE
        /// 1 = RIGHT
        /// 2 = LEFT
        /// Defaults to 0
        /// </summary>
        /// <param name="position"></param>
        public void SetOnPlanePosition(int position)
        {
            switch (position)
            {
                case 0:
                    this.classBeam.Position.Plane = Position.PlaneEnum.MIDDLE;
                    break;
                case 1:
                    this.classBeam.Position.Plane = Position.PlaneEnum.RIGHT;
                    break;
                case 2:
                    this.classBeam.Position.Plane = Position.PlaneEnum.LEFT;
                    break;
                default:
                    this.classBeam.Position.Plane = Position.PlaneEnum.MIDDLE;
                    break;
            }
        }

        /// <summary>
        /// Method to set plane offset 
        /// </summary>
        /// <param name="offset"></param>
        public void SetOnPlaneOffset(double offset)
        {
            this.classBeam.Position.PlaneOffset = offset;
        }

        /// <summary>
        /// Method to get plane offset 
        /// </summary>
        /// <returns></returns>
        public double getPlaneOffset()
        {
            try
            {
                return classBeam.Position.PlaneOffset;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Method to set "Rotation" position for beam.
        /// 0 = FRONT
        /// 1 = TOP
        /// 2 = BACK
        /// 3 = BELOW
        /// Defaults to 0
        /// </summary>
        /// <param name="position"></param>
        public void SetRotationPosition(int position)
        {
            switch (position)
            {
                case 0:
                    this.classBeam.Position.Rotation = Position.RotationEnum.FRONT;
                    break;
                case 1:
                    this.classBeam.Position.Rotation = Position.RotationEnum.TOP;
                    break;
                case 2:
                    this.classBeam.Position.Rotation = Position.RotationEnum.BACK;
                    break;
                case 3:
                    this.classBeam.Position.Rotation = Position.RotationEnum.BELOW;
                    break;
                default:
                    this.classBeam.Position.Rotation = Position.RotationEnum.FRONT;
                    break;
            }
        }

        /// <summary>
        /// Method to set rotation offset 
        /// </summary>
        /// <param name="offset"></param>
        public void SetRotationOffset(double offset)
        {
            this.classBeam.Position.RotationOffset = offset;
        }

        /// <summary>
        /// Method to get rotation offset 
        /// </summary>
        /// <returns></returns>
        public double getRotationOffset()
        {
            try
            {
                return classBeam.Position.RotationOffset;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Method to set "At Depth" position for beam.
        /// 0 = MIDDLE
        /// 1 = FRONT
        /// 2 = BEHIND
        /// DEFAULTS TO 0
        /// </summary>
        /// <param name="position"></param>
        public void SetDepthPosition(int position)
        {
            switch (position)
            {
                case 0:
                    this.classBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                    break;
                case 1:
                    this.classBeam.Position.Depth = Position.DepthEnum.FRONT;
                    break;
                case 2:
                    this.classBeam.Position.Depth = Position.DepthEnum.BEHIND;
                    break;
                default:
                    this.classBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                    break;
            }
        }

        /// <summary>
        /// Method to set depth offset 
        /// </summary>
        /// <param name="offset"></param>
        public void SetDepthOffset(double offset)
        {
            this.classBeam.Position.DepthOffset = offset;
        }

        /// <summary>
        /// Method to get depth offset 
        /// </summary>
        /// <returns></returns>
        public double getDepthOffset()
        {
            try
            {
                return classBeam.Position.DepthOffset;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Method to insert beam
        /// </summary>
        public void insertBeam()
        {
            try
            {
                this.classBeam.Insert();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Method to update model
        /// </summary>
        public void updateModel()
        {
            try
            {
                this.classModel.CommitChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

    }
}
