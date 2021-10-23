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
using Ab3d.Utilities;
using Ab3d.Visuals;
using Ab3d.Common.EventManager3D;
using MessageBox = System.Windows.MessageBox;

using Craear_ventanas;

namespace Moro
{
    public partial class Form1 : Form
    {
        public CrearVentanas3D ventanaNueva = new CrearVentanas3D();


        public Grid _rootGrid = new Grid();
        public Border ViewportBack = new Border();
        public Viewport3D _viewport3D = new Viewport3D();
        public Viewport3DVisual _viewport3DS = new Viewport3DVisual();
        public TargetPositionCamera _targetPositionCamera = new TargetPositionCamera();
        public MouseCameraController _mouseCameraController = new MouseCameraController();
        public ViewCubeCameraController _vistaCubo = new ViewCubeCameraController();
        public EventManager3D _eventManager3D = new EventManager3D();
        public WireGridVisual3D _wireGridVisual3D = new WireGridVisual3D();
        public WireframeVisual3D wireFreme3D;

        //public WireframeVisual3D ObjectsGroupo = new WireframeVisual3D();
        public Model3DGroup ObjectsGroup = new Model3DGroup();

        public Viewport3D _rootGrid1 = new Viewport3D();


        public Form1()
        {
            InitializeComponent();
            ventanaNueva.CrearVentana3D(_rootGrid,_viewport3D,_targetPositionCamera,_mouseCameraController,_vistaCubo,_eventManager3D,_wireGridVisual3D);
            elementHost1.Child = _rootGrid;
        }
    }
}
