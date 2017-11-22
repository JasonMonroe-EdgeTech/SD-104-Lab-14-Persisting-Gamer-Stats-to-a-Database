using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI
{
    class FileAccessor
    {
        FileStream stream;
        StreamReader textIn;
        public string FilePath { get; set; }

        /// <summary>
        /// Creates an instance of a FileAccessor, setting
        /// the FilePath property to the passed value.  
        /// </summary>
        /// <param name="filePath">Path of the file to be opened.</param>
        public FileAccessor(string filePath)
        {
            FilePath = filePath;
            stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            textIn = new StreamReader(stream);
        }

        /// <summary>
        /// Returns a random line from the current file.
        /// </summary>
        /// <returns></returns>
        public string GetRandomLine()
        {
            //get random line
            Random rand = new Random();
            int randNum = rand.Next(1, GetUpperBounds());

            //read to that line
            for (int n = 0; n < randNum; n++)
            {
                textIn.ReadLine();
            }
            string text = textIn.ReadLine();
            return text;

        }

        /// <summary>
        /// Returns the upper bounds of the current file
        /// </summary>
        /// <returns></returns>
        private int GetUpperBounds()
        {
            int fileUpperBounds = 0;
            stream.Position = 0;//start at beginning

            while (!textIn.EndOfStream)
            {
                textIn.ReadLine();
                fileUpperBounds++;
            }

            //reset stream to beginning before exiting
            stream.Position = 0;

            return fileUpperBounds;
        }
    }
}
