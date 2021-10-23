using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
//using DevExpress.XtraEditors;

using System.Windows.Media.Media3D;
using Ab3d.Cameras;
using Ab3d.Common.Cameras;
using Ab3d.Common.EventManager3D;
using Ab3d.Controls;
using Ab3d.Utilities;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

using Ab3d;
using Ab3d.Visuals;
using System.Windows.Media;
using MessageBox = System.Windows.Forms.MessageBox;
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


        public void CrearVentana3D( Grid _rootGrid, 
                                    Viewport3D _viewport3D, 
                                    TargetPositionCamera _targetPositionCamera, 
                                    MouseCameraController _mouseCameraController, 
                                    ViewCubeCameraController vistaCubo,
                                    EventManager3D _eventManager3D,
                                     WireGridVisual3D wireGridVisual3D)
        {
            _rootGrid.Background = Brushes.DarkGray;
            //_viewport3D.Name = Nombre;


            _rootGrid.Children.Add(_viewport3D);

            _targetPositionCamera = new Ab3d.Cameras.TargetPositionCamera()
            {
                TargetPosition = new Point3D(0, -1.5, 0),
                Distance = 20,
                Heading = 30,
                Attitude = -20,
                ShowCameraLight = ShowCameraLightType.Always,
                TargetViewport3D = _viewport3D
            };

            _rootGrid.Children.Add(_targetPositionCamera);

            _mouseCameraController = new Ab3d.Controls.MouseCameraController()
            {
                RotateCameraConditions = MouseCameraController.MouseAndKeyboardConditions.LeftMouseButtonPressed,
                MoveCameraConditions = MouseCameraController.MouseAndKeyboardConditions.RightMouseButtonPressed,
                //MoveCameraConditions = MouseCameraController.MouseAndKeyboardConditions.RightMouseButtonPressed | MouseCameraController.MouseAndKeyboardConditions.ControlKey,
                EventsSourceElement = _rootGrid
                //TargetCamera = _targetPositionCamera
            };

            _rootGrid.Children.Add(_mouseCameraController);

            var cameraControlPanel = new Ab3d.Controls.CameraControlPanel()
            {
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(5, 5, 5, 5),
                Width = 225,
                Height = 75,
                ShowMoveButtons = false
                // TargetCamera = _targetPositionCamera
            };

            _rootGrid.Children.Add(cameraControlPanel);

            var ejes = new Ab3d.Controls.CameraAxisPanel()
            {
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(5, 5, 5, 5),
                Width = 100,
                Height = 75
                //TargetCamera = _targetPositionCamera
            };

            _rootGrid.Children.Add(ejes);

            StackPanel panel = new StackPanel()
            {
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top


            };
            _rootGrid.Children.Add(panel);

            vistaCubo = new Ab3d.Controls.ViewCubeCameraController()
            {
                Width = 200,
                Height = 200,

                DefaultCubePlaneTexts = new string[] { "Derecha", "Izquierda", "Arriba", "Abajo", "Atras", "Frente" }

            };
            Color Pincel;
            Pincel = Color.FromArgb(255, 255, 0, 0);
            Color PincelVerde = Colors.LightGray;
            vistaCubo.Foreground = new SolidColorBrush(PincelVerde);

            vistaCubo.TargetCamera = _targetPositionCamera;

            panel.Children.Add(vistaCubo);

            // The event manager will be used to manage the mouse events on our boxes
            _eventManager3D = new Ab3d.Utilities.EventManager3D(_viewport3D);


            // Add a wire grid


            wireGridVisual3D.Size = new Size(15, 15);
            wireGridVisual3D.HeightCellsCount = 20;
            wireGridVisual3D.WidthCellsCount = 20;
            wireGridVisual3D.IsClosed = true;
            wireGridVisual3D.LineThickness = 1;
            wireGridVisual3D.LineColor = Colors.Gray;



            _viewport3D.Children.Add(wireGridVisual3D);


            // ToggleCameraAnimation(); // Start camer animation

        }



    }

}
