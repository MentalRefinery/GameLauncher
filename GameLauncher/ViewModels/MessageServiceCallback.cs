using GameLauncher.Contract;
using GameLauncher.Domain;
using System.Collections.ObjectModel;

namespace GameLauncher.ViewModels
{ 


    public class MessageServiceCallback : IMessageServiceCallback
    {
        public void ForwardToClient(Message message)
        {
        throw new System.NotImplementedException();
        }

        public void UserConnected(ObservableCollection<User> users)
        {
            throw new System.NotImplementedException();
        }
    }
}
