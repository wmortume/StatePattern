using System.Windows.Media;
using System.Windows.Shapes;

namespace StatePattern
{
    class YellowLightState
    {
        public YellowLightState(Ellipse ellipse)
        {
            ellipse.Fill = Brushes.Yellow;
        }
    }
}
