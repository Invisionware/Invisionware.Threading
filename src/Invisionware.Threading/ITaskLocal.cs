using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invisionware.Threading
{
	public interface ITaskLocal<T>
	{
		T Value { get; set; }
	}
}
