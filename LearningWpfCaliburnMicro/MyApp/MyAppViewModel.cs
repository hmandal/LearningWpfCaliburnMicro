using Caliburn.Micro;
using LearningWpfCaliburnMicro.Color;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LearningWpfCaliburnMicro.MyApp
{
    [Export(typeof(MyAppViewModel))]
    public class MyAppViewModel : PropertyChangedBase, IHandle<ColorEvent>
    {
        //for supporting DesignInstance
        public MyAppViewModel()
        {

        }

        public MyAppViewModel(IWindowManager windowManager, ColorViewModel colorModel)
        {
            _windowManager = windowManager;
            ColorModel = colorModel;
        }

        [ImportingConstructor]
        public MyAppViewModel(IWindowManager windowManager, ColorViewModel colorModel, IEventAggregator events)
        {
            ColorModel = colorModel;

            // Get the event aggregator through the constructor and subscribe this ColorViewModel so it can listen for ColorEvent messages.
            events.Subscribe(this);

            _windowManager = windowManager;
        }

        public void NewWindow()
        {
            _windowManager.ShowWindow(new MyAppViewModel(_windowManager, ColorModel));
        }


        private int _Count = 50;

        public int Count
        {
            get { return _Count; }
            set
            {
                _Count = value;
                NotifyOfPropertyChange(() => Count);
                NotifyOfPropertyChange(() => CanIncrementCount);
            }
        }

        public void IncrementCount(int delta)
        {
            Count += delta;
        }

        public bool CanIncrementCount
        {
            get
            {
                return Count < 100;
            }
        }


        private SolidColorBrush _Color;

        private readonly IWindowManager _windowManager;

        public ColorViewModel ColorModel { get; private set; }

        // This property is for changing the color of the rectangle.
        public SolidColorBrush Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                NotifyOfPropertyChange(() => Color);
            }
        }

        // This method is called after a ColorEvent message is published from somewhere else in the application.
        public void Handle(ColorEvent message)
        {
            Color = message.Color;
        }
    }
}
