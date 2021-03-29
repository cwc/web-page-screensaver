using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    internal class MultiFormContext : ApplicationContext
    {
        public MultiFormContext(List<Form> forms)
        {
            if (forms == null)
            {
                throw new ArgumentNullException(nameof(forms));
            }

            foreach (Form form in forms)
            {
                form.FormClosed += (s, args) => ExitThread();
                form.Show();
            }
        }
    }
}
