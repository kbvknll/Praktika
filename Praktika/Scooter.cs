using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Scooter : Transport
    {
        public override string _type { get; set; }
        public override int _speed { get; set; }
        public override string _color { get; set; }
        public override string _model { get; set; }
        public override string _rightscategory { get; set; }
        public override bool _rent { get; set; }
        public override int _wheels { get; set; }
        public override string _motor { get; set; }
        public override void Move()
        {
            Console.WriteLine();
        }
    }
}
