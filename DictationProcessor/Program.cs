using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Iterate through subfolders
            foreach(var subfolder in Directory.GetDirectories("/mnt/uploads"))
            {
                // get metadata file
                var metadataFilePath = Path.Combine(subfolder, "metadata.json");
                // extract metadata file, incluing audio file info inside metadata file

                // for each audio file listed in metadata:
                // - get absolute file path
                // - verify file checksum
                // - generate a unique identifier
                // - compress it
                // - create a standalone metadata file

            }

        }
    }
}
