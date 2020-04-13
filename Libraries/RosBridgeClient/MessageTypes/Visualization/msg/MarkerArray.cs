using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Visualization
{
    public class MarkerArray : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "visualization_msgs/MarkerArray";

        public List<Marker> markers;

        public MarkerArray()
        {
            this.markers = new List<Marker>();
        }
    }
}

