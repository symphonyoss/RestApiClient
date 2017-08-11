using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SymphonyOSS.RestApiClient.Entities
{
    public class NamedStream : MemoryStream
    {
        public NamedStream(string name, byte[] buffer) : base(buffer)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
