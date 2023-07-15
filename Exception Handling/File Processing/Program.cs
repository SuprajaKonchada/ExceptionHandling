using System;
using System.IO;

class FileProcessingApp
{
    static void Main()
    {
        string filePath = "C:\\Users\\Supraja Konchada\\Desktop\\FP.txt";

        try
        {
            // Open the file
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read and process the file data
                string line;
                int sum = 0;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    // Convert the line to an integer
                    if (int.TryParse(line, out int number))
                    {
                        // Perform calculations on the number
                        sum += number;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid data found: {line}");
                    }
                }

                // Display the results
                Console.WriteLine($"Sum of the numbers: {sum}");
                Console.WriteLine($"Count of valid numbers: {count}");
            }

            // File processing completed successfully
            Console.WriteLine("File processed successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please provide a valid file path.");
        }
        catch (IOException)
        {
            Console.WriteLine("An error occurred while reading the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Insufficient file permissions. Please make sure you have appropriate access rights.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        Console.ReadLine();
    }
}
