using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestSilverlightApp.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MessageService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MessageService.svc or MessageService.svc.cs at the Solution Explorer and start debugging.
    public class MessageService : IMessageService
    {
        private static int index = 2;

        private static List<Message> source = new List<Message>(){ 
			new Message(){ Id=0, Created = DateTime.Now, Text = "First Message"},
			new Message(){ Id=1, Created = DateTime.Now, Text = "One More Message"}
		};
        public void Add(String message)
        {
            source.Add(new Message() { Id = index, Created = DateTime.Now, Text = message });
            index++;
            return;
        }

        public IEnumerable<Message> List()
        {
            return source.AsEnumerable();

        }
    }
}
