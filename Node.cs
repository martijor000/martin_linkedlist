using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martin_linkedlist
{
    class Node
    {
		private string _data;
		private Node _node;

        public Node()
        {

        }

		public string Data
		{
			get { return _data; }
			set { _data = value; }
		}

		public Node Next
		{
			get { return _node; }
			set { _node = value; }
		}
	}
}
