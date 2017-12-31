// indexer.cs
// aeguements: any file you like to see

using System;
using System.IO;

// Class to provide access to large file 
// as if it were a byte array
public class FileByteArray
{
    // Hold the undelying stream
    // used to access the file
    Stream stream; 

    // Create a new file encasulating a particular file 
    public FileByteArray(string FileName)
    {
        stream = new FileStream(FileName, FileMode.Open);
    }

    // Close the stream.
    // This is the last thing done when you finished
    public void Close()
    {
        stream.Close();
        stream = null;
    }

    // Indexer to peovide read/write access to the file.
    public byte this[long index] // long is 64-bit integer
    {
        // Read One byte at offset index and return it.
        get 
        {
            byte[] buffer = new byte[1];
            stream.Seek(index, SeekOrigin.Begin);
            stream.Read(buffer, 0, 1);
            return buffer[0];
        }
        set 
        {
            byte[] buffer = new byte[1] {value};
            stream.Seek(index, SeekOrigin.Begin);
            stream.Write(buffer, 0, 1);
        }
    }

    // Get the total length of the file
    public long Length 
    {
        get 
        {
            return stream.Seek(0, SeekOrigin.End);
        }
    }
}

// Reverses the bytes in a file.
public class Reverse
{
    public static void Main(String[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("indexer <FileName>");
            return ;
        }

        FileByteArray file = new FileByteArray(args[0]);
        long len = file.Length;
        // Swap bytes in the file to reverse it.
        for (long i = 0; i < len/2; i++)
        {
            byte t;

            t = file[i];
            file[i] = file[len - i - 1];
            file[len - i -1] = t;
        }
        file.Close();
    }
}
