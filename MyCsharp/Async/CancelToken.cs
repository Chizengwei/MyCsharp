using System;

namespace MyCsharp.Async
{
    public class CancelToken
    {
        public bool IsCancelRequested { get; private set; }

        public void Cancel()
        {
            IsCancelRequested = true;
        }

        public void ThrowCancelRequese()
        {
            if (IsCancelRequested)
                throw new OperationCanceledException();
        }
    }
}