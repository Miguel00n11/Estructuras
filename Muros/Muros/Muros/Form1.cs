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
using Ab3d.Common.EventManager3D;
using MessageBox = System.Windows.MessageBox;

namespace Muros
{
    public partial class Form1 : Form
    {

        private Viewport3D ventana3D;
        private TargetPositionCamera _targetP;
        //private CrearMouse _mouse;


        public Form1()
        {
            InitializeComponent();

            CrearVentanas3D ventana = new CrearVentanas3D();
            CreaMouse _mouse = new CreaMouse();

            ventana.CrearVentana3D(elementHost1, ventana3D, _targetP);

            _mouse.CrearMouse();


            


        }
    }
}
