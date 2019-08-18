using System.Collections.Generic;

namespace smashgg.net.Models
{
    public class BaseNode<TClass>
    {
        public List<TClass> Nodes { get; set; }
    }
}