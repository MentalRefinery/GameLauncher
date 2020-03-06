using GameLauncher.Contract;
using GameLauncher.Domain;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;

namespace ChatApp.Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single )]
    public class MessageService : IMessageService
    {
        private IMessageServiceCallback _callBack = null;
        private ObservableCollection<User> _users;
        private readonly Dictionary<string, IMessageServiceCallback> _clients;

        public MessageService()
        {
            _users = new ObservableCollection<User>();
            _clients = new Dictionary<string, IMessageServiceCallback>();

        }
        public void Connect(User user)
        {
            _callBack = OperationContext.Current.GetCallbackChannel<IMessageServiceCallback>();
            if (_callBack != null)
            {
                _clients.Add(user.UserId, _callBack);
                _users.Add(user);
                _clients?.ToList().ForEach(c => c.Value.UserConnected(_users));
                System.Console.WriteLine($"{ user.Name} Just Connected");

            }
        }

        public ObservableCollection<User> GetConnectedUsers()
        {
            return _users;
        }

        public void SendMessage(Message message)
        {
            var sendto = _clients?.First(c => c.Key == message.ToUserId).Value;
            sendto?.ForwardToClient(message);
            
        }
    }
}
