﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LearningWpfCaliburnMicro.Color
{
    [Export(typeof(ColorViewModel))]
    public class ColorViewModel : PropertyChangedBase
    {
        // Get the event aggregator through the constructor and store it in a field so we can publish messages later.
        private readonly IEventAggregator _events;

        [ImportingConstructor]
        public ColorViewModel(IEventAggregator events)
        {
            _events = events;
        }

        // When a radio button is clicked, publish a message containing the appropriate color:

        public void Red()
        {
            _events.PublishOnUIThread(new ColorEvent(new SolidColorBrush(Colors.Red)));
        }

        public void Green()
        {
            _events.PublishOnUIThread(new ColorEvent(new SolidColorBrush(Colors.Green)));
        }

        public void Blue()
        {
            _events.PublishOnUIThread(new ColorEvent(new SolidColorBrush(Colors.Blue)));
        }
    }
}
