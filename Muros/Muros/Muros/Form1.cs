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

        public Viewport3D ventana3D;
        public TargetPositionCamera _targetP=new TargetPositionCamera();
        public EventManager3D _eventManager3D;
        public WireGridVisual3D crearGrid = new WireGridVisual3D();
        public CrearVentanas3D ventana;

        public Form1()
        {
            InitializeComponent();

            ventana = new CrearVentanas3D();
            ventana.CrearVentana3D(elementHost1, ventana3D, _targetP);

            ventana.distt = 1200;
            //ventana.altt = 1200;
            ventana.att = 20;

            //_targetP.TargetPosition = new Point3D(1, 1, 1);
            //_targetP.Distance = 1;
            //_targetP.Heading = 11111;
            //_targetP.Attitude = -1;

            _eventManager3D = new Ab3d.Utilities.EventManager3D(ventana3D);


        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
}
