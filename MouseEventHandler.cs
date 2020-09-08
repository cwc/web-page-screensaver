using System.Drawing;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    /// <summary>
    /// Screensavers, and especially multi-window apps, can get spurious WM_MOUSEMOVE events
    /// that don't actually involve any movement (cursor chnages and some mouse driver software
    /// can generate them, for example) - so we record the actual mouse position and compare
    /// against it for actual movement.
    /// </summary>
    internal class MouseEventHandler : IMessageFilter
    {
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MBUTTONDBLCLK = 0x209;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        private Point? _lastMousePosition;

        public delegate void UserEvent();

        public event UserEvent? Event;

        public bool PreFilterMessage(ref Message m)
        {
            if (_lastMousePosition == null && m.Msg == WM_MOUSEMOVE)
            {
                _lastMousePosition = Cursor.Position;
            }

            if ((m.Msg == WM_MOUSEMOVE && Cursor.Position != _lastMousePosition)
                || (m.Msg > WM_MOUSEMOVE && m.Msg <= WM_MBUTTONDBLCLK) || m.Msg == WM_KEYDOWN || m.Msg == WM_KEYUP)
            {

                Event?.Invoke();
            }

            // Always allow message to continue to the next filter control
            return false;
        }
    }
}
