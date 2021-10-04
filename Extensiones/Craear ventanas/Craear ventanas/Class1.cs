using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Controls;
using System.Windows.Forms;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Forms.Integration;

using Ab3d;
using Ab3d.Cameras;
using Ab3d.Common.Cameras;
using Ab3d.Controls;
using Ab3d.Visuals;
using Ab3d.Common.EventManager3D;
using MessageBox = System.Windows.MessageBox;

namespace Craear_ventanas
{
    public class CrearVentanas3D
    {

        public Grid _rootGrid;
        public MouseCameraController _mouseControl;
        public WireGridVisual3D crearGrid;
        public double distt;
        public double altt;
        public double att;


        public void CrearVentana3D(ElementHost elementHost1, Viewport3D ventana3D, TargetPositionCamera _targetP)
        {
            _rootGrid = new Grid()
            {
                Background = Brushes.LightGray
            };
            elementHost1.Child = _rootGrid;

            ventana3D = new Viewport3D();
            _rootGrid.Children.Add(ventana3D);

            _targetP = new TargetPositionCamera()
            {
                //TargetPosition = new Point3D(0, 20, 0),
                Distance = 120,
                Heading = 1200,
                Attitude = -att,
                ShowCameraLight = ShowCameraLightType.Always,


            };
            _targetP.RotateCamera(45, 0);
            _rootGrid.Children.Add(_targetP);


            //_rootGrid = new Grid();
            _mouseControl = new MouseCameraController()
            {
                RotateCameraConditions = MouseCameraController.MouseAndKeyboardConditions.RightMouseButtonPressed,
                MoveCameraConditions = MouseCameraController.MouseAndKeyboardConditions.RightMouseButtonPressed | MouseCameraController.MouseAndKeyboardConditions.ControlKey,
                EventsSourceElement = _rootGrid,
                //TargetCamera = _targetP


            };
            _rootGrid.Children.Add(_mouseControl);

            crearGrid = new WireGridVisual3D()
            {
                CenterPosition = new Point3D(0, 0, 0),
                Size = new Size(5000, 5000),
                HeightCellsCount = 20,
                WidthCellsCount = 20,
                LineThickness = 1


            };
            ventana3D.Children.Add(crearGrid);


        }



    }

}
