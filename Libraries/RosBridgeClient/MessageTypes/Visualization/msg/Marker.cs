using System.Collections.Generic;
using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Geometry;
using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Visualization
{
    public class Marker : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "visualization_msgs/Marker";

        public struct Duration
        {
            public Duration(int sec, int nsec)
            {
                this.sec = sec;
                this.nsec = nsec;
            }

            public int sec { get; set; }
            public int nsec { get; set; }

            public override string ToString() => $"({sec}, {nsec})";
        }

        //  A representation of pose in free space, composed of position and orientation. 
        public const byte ARROW = 0;
        public const byte CUBE = 1;
        public const byte SPHERE = 2;
        public const byte CYLINDER = 3;
        public const byte LINE_STRIP = 4;
        public const byte CUBE_LIST = 6;
        public const byte SPHERE_LIST = 7;
        public const byte POINTS = 8;
        public const byte TEXT_VIEW_FACING = 9;
        public const byte MESH_RESOURCE = 10;
        public const byte TRIANGLE_LIST = 11;

        public const byte ADD = 0;
        public const byte MODIFY = 1;
        public const byte DELETE = 2;
        public const byte DELETEALL = 3;

        public Header header;
        public string ns;
        public int id;

        public int type;
        public int action;

        public Pose pose;
        public Vector3 scale;
        public ColorRGBA color;
        public Duration lifetime;
        public bool frame_locked;

        public List<Point> points;

        List<ColorRGBA> colors;

        public string text;

        public string mesh_resource;
        public bool mesh_use_embedded_materials;

        public Marker()
        {
            this.header = new Header();
            this.ns = "";
            this.id = 0;
            this.type = CUBE;
            this.action = ADD;
            this.pose = new Pose();
            this.scale = new Vector3();
            this.color = new ColorRGBA();
            this.lifetime = new Duration(0,0);
            this.frame_locked = false;
            this.points = new List<Point>();
            this.colors = new List<ColorRGBA>();
            this.text = "";
            this.mesh_resource = "";
            this.mesh_use_embedded_materials = false;
        }
    }
}
