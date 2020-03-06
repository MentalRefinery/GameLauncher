using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GameLauncher.Domain;
using System.Collections.ObjectModel;

namespace GameLauncher.Contract
{
    public interface IMessageServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void ForwardToClient(Message message);

        [OperationContract(IsOneWay = true)]
        void UserConnected(ObservableCollection<User> users);

    }
}
