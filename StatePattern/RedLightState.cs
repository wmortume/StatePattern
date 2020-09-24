using System.Windows.Media;
using System.Windows.Shapes;

namespace StatePattern
{
    class RedLightState
    {
        public RedLightState(Ellipse ellipse)
        {
            ellipse.Fill = Brushes.Red;
        }
    }
}
