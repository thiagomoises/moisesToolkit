using System;
using System.Threading.Tasks;

namespace System.Threading.Tasks.Extensions
{
    public static class TaskExtension
    {
        public static bool TryExecute<T>(this System.Threading.Tasks.Task<T> task, out T result, int limitWait = 1000)
        {
            if (task.Wait(limitWait))
            {
                result = task.Result;
                return task.IsCompleted;
            }
            result = default(T);
            return false;
        }

        public static bool TryExecute(this System.Threading.Tasks.Task task, int limitWait = 1000)
        {
            if (task.Wait(limitWait))
            {
                return task.IsCompleted;
            }
            return false;
        }
    }
}
