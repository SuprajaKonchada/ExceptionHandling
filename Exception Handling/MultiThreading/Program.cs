using System;
using System.Threading;

class MultithreadingApp
{
    static void Main()
    {
        // Create a new thread
        Thread workerThread = new Thread(WorkerMethod);

        try
        {
            workerThread.Start();

            // Do some other work in the main thread
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread working...");
                Thread.Sleep(500);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An exception occurred in the worker thread: " + ex.Message);
        }
        // Wait for the worker thread to finish
        workerThread.Join();

        Console.WriteLine("Main thread completed.");
        Console.ReadLine();
    }

    static void WorkerMethod()
    {
        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker thread working...");
                Thread.Sleep(1000);
            }
            throw new Exception("Worker thread exception!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An exception occurred in the worker thread: " + ex.Message);
        }
    }
}
