using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TestSilverlightApp.Web
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Text { get; set; }

        [DataMember]
        public DateTime Created { get; set; }
    }
}