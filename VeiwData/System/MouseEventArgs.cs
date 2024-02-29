





namespace System
{
    internal class MouseEventArgs
    {
        private Action<object, Windows.Forms.MouseEventArgs> wfgAllData_CursorChanged;

        public MouseEventArgs(Action<object, Windows.Forms.MouseEventArgs> wfgAllData_CursorChanged)
        {
            this.wfgAllData_CursorChanged = wfgAllData_CursorChanged;
        }
    }
}