using System.Windows.Media;
using System.Windows.Shapes;

namespace StatePattern
{
    public class Light
    {
        public static void StartLight(int time, Ellipse ellipse)
        {
            if (time == 7)
            {
                new GreenLightState(ellipse);
            }
            else if (time == 4)
            {
                new YellowLightState(ellipse);
            }
            else if (time == 2)
            {
                new RedLightState(ellipse);
            }
        }

        public static int ChangeLight(Ellipse ellipse)
        {
            int time = 0;

            if (ellipse.Fill == Brushes.Green)
            {
                time = 4;
            }
            else if (ellipse.Fill == Brushes.Yellow)
            {
                time = 2;
            }
            else
            {
                time = 7;
            }

            return time;
        }
    }
}
