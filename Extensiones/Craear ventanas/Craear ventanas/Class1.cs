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

        private Grid _rootGrid;

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
                TargetPosition = new Point3D(0, -1.5, 0),
                Distance = 20,
                Heading = 30,
                Attitude = -20,
                ShowCameraLight = ShowCameraLightType.Always,


            };
            _targetP.RotateCamera(45, 0);
            _rootGrid.Children.Add(_targetP);






        }
        


    }
    public class CreaMouse
    {

        private MouseCameraController _mouseControl;
        private Grid _rootGrid;

        public void CrearMouse()
        {
            _rootGrid = new Grid()
            _mouseControl = new MouseCameraController()
            {
                RotateCameraConditions = MouseCameraController.MouseAndKeyboardConditions.RightMouseButtonPressed,
                MoveCameraConditions = MouseCameraController.MouseAndKeyboardConditions.RightMouseButtonPressed | MouseCameraController.MouseAndKeyboardConditions.ControlKey,
                EventsSourceElement = _rootGrid,
                //TargetCamera = _targetP


            };
            _rootGrid.Children.Add(_mouseControl);



        }


    }

}
