using System.Threading.Tasks;

namespace nilnul.web.svr.app_.api.controller.action.io.binding_._nakedBody.task_
{

	/// <summary>
	/// A do nothing task that can be returned
	/// from functions that require task results
	/// when there's nothing to do.
	/// 
	/// This essentially returns a completed task
	/// with an empty value structure result.
	/// </summary>
	static public class _EmptyX
	{
		public static Task Start()
		{
			TaskCompletionSource<AsyncVoid> taskSource = new TaskCompletionSource<AsyncVoid>();
			taskSource.SetResult(default(AsyncVoid));
			return taskSource.Task as Task;
		}

		private struct AsyncVoid
		{
		}
	}
}
