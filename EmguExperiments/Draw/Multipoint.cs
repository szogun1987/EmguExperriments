using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguExperiments.Draw
{
    public partial class Multipoint : Form
    {
        public Multipoint()
        {
            InitializeComponent();
        }

        private void newPoint_Click(object sender, EventArgs e)
        {
            var point = new Point();
            points.Items.Add(point);
            points.SelectedItem = point;
        }

        private void points_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point selected = points.SelectedItem as Point;
            pointX.Enabled = pointY.Enabled = selected != null;
            pointX.Value = pointY.Value = 0;

            pointX.DataBindings.Clear();
            pointY.DataBindings.Clear();

            if (selected != null)
            {
                pointX.DataBindings.Add("Value", selected, "X");
                pointY.DataBindings.Add("Value", selected, "Y");
            }
        }

        public List<Point> Points
        {
            get
            {
                return points.Items.Cast<Point>().ToList();
            }
        }

        public class Point : INotifyPropertyChanged
        {
            private int x;

            private int y;

            private string description;

            public event PropertyChangedEventHandler PropertyChanged;

            public Point()
            {
                ComputeDesc();
            }

            public int X
            {
                get { return x; }
                set 
                {
                    x = value;
                    OnPropertyChanged();
                    ComputeDesc();
                }
            }

            public int Y
            {
                get { return y; }
                set 
                {
                    y = value;
                    OnPropertyChanged();
                    ComputeDesc();
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                    OnPropertyChanged();
                }
            }

            protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
            {
                var ev = PropertyChanged;
                if (ev != null)
                {
                    ev(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            private void ComputeDesc()
            {
                Description = string.Format("[{0};{1}]", X, Y);
            }
        }
    }
}
