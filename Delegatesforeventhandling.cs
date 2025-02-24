using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    // Step 1: Define a delegate
    public delegate void ClickEventHandler(object sender, EventArgs e);

    class Button
    {
        // Step 2: Define an event using the delegate
        public event ClickEventHandler OnClick;

        // Step 3: Implement a method to trigger the event
        public void Click()
        {
            // Check if there are any subscribers
            if (OnClick != null)
            {
                OnClick(this, EventArgs.Empty);
            }
        }
    }
}
