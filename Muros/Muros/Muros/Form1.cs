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
using Craear_ventanas;

using Ab3d;
using Ab3d.Cameras;
using Ab3d.Common.Cameras;
using Ab3d.Controls;
using Ab3d.Visuals;
using Ab3d.Utilities;
using Ab3d.Common.EventManager3D;
using MessageBox = System.Windows.MessageBox;

namespace Muros
{
    public partial class Form1 : Form
    {

        private Viewport3D ventana3D;
        private TargetPositionCamera _targetP;
        private EventManager3D _eventManager3D;
        public WireGridVisual3D crearGrid = new WireGridVisual3D();


        public Form1()
        {
            InitializeComponent();

            CrearVentanas3D ventana = new CrearVentanas3D();
            //CreaMouse _mouse = new CreaMouse();

            ventana.CrearVentana3D(elementHost1, ventana3D, _targetP);


            //_mouse.CrearMouse();

            _eventManager3D = new Ab3d.Utilities.EventManager3D(ventana3D);


            // Add a wire grid


            //crearGrid = new WireGridVisual3D()
            //{
            //    CenterPosition = new Point3D(0, 0, 0),
            //    Size = new Size(5000, 5000),
            //    HeightCellsCount = 20,
            //    WidthCellsCount = 20,
            //    LineThickness = 1


            //};
            //ventana3D.Children.Add(crearGrid);



        }
    }
}
