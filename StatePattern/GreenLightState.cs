using System.Windows.Media;
using System.Windows.Shapes;

namespace StatePattern
{
    public class GreenLightState
    {
        public GreenLightState(Ellipse ellipse)
        {
            ellipse.Fill = Brushes.Green;
        }
    }
}
