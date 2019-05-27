using Forms4Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Forms4Demo.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public List<Conversation> Messages { get; set; } = Conversations.All;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
