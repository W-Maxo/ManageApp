using System.Windows.Forms;

namespace ManageApp
{
    class MyListViewEx : ListView 
    {
        public MyListViewEx()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            ResumeLayout(false);

        }
    }
}