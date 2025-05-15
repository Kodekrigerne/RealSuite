using Models;

namespace RealSuite.Events
{
    public class UpdatePropertyEventArgs : EventArgs
    {
        public Property Property { get; }

        public UpdatePropertyEventArgs(Property property)
        {
            Property = property;
        }
    }
}
