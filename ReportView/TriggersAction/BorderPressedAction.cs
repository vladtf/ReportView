
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace ReportView.TriggersAction
{
    public class BorderPressedAction : TriggerAction<Border>
    {
        protected override void Invoke(object parameter)
        {
            var myBorder = (Border)(parameter as MouseEventArgs).Source;

            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = 0.95;

            myBorder.RenderTransform = scaleTransform;
            
        }
    }
}