
namespace MauiApp1.Controls
{
    class MyLabel : Label
    {
        public static readonly BindableProperty MyIntProperty =
        BindableProperty.Create("MyInt", typeof(int), typeof(MyLabel), 0);
        public int MyInt
        {
            set
            {
                SetValue(MyIntProperty, value);
            }
            get
            {
                return (int)GetValue(MyIntProperty);
            }
        }
    }
}
