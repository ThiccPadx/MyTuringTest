using System.Windows.Forms;

namespace Reader01
{
    class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int PBS_VERTICAL = 0x04;
                CreateParams cp = base.CreateParams;
                cp.Style |= PBS_VERTICAL;
                return cp;
            }
        }
    }
}
