namespace Base_Learning.AsyncAwait
{
    public class AsyncAwaits
    {
        static string synchronous()
        {
            Thread.Sleep(1000);
            return "sync 1";
        }

        static string synchronous2()
        {
            Thread.Sleep(500);
            return "sync 2";
        }

        static async Task<string> Asyncsynchronous()
        {
            await Task.Delay(500);
            return "a sync 1";
        }

        static async Task<string> Asyncsynchronous2()
        {
            await Task.Delay(300);
            return "a sync 2";
        }
    }
}
