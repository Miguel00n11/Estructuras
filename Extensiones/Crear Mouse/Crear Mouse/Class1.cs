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
//using Craear_ventanas;

using Ab3d;
using Ab3d.Cameras;
using Ab3d.Common.Cameras;
using Ab3d.Controls;
using Ab3d.Visuals;
using Ab3d.Common.EventManager3D;
using MessageBox = System.Windows.MessageBox;
namespace Crear_Mouse
{
    public class Class1
    {

        private MouseCameraController _mouseControl;


        public void CrearMouse(Grid _rootGrid)
        {
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
