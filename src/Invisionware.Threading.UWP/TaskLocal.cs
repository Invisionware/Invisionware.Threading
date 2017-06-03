using System.Threading;

namespace Invisionware.Threading.UWP
{
	// This project can output the Class library as a NuGet Package.
	// To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
	public class TaskLocal<T> : ITaskLocal<T>
	{
		private readonly AsyncLocal<T> _asyncLocal;

		public TaskLocal()
		{
			_asyncLocal = new AsyncLocal<T>();
		}

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public T Value
		{
			get { return _asyncLocal.Value; }
			set { _asyncLocal.Value = value; }
		}
	}
}
