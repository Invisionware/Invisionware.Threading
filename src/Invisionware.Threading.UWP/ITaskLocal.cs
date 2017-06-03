namespace Invisionware.Threading
{
	public interface ITaskLocal<T>
	{
		T Value { get; set; }
	}
}
