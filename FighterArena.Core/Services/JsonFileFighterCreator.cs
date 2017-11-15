using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FighterArena.Core.Interfaces;
using Newtonsoft.Json;

namespace FighterArena.Core.Services
{
    public class JsonFileFighterCreator : IFighterCreator
    {
        public FighterBase Create()
        {
            Console.WriteLine("Choose between Bob(1) and Jorge(2)");
            var jorgeOrBob = CollectInt(1, 2);
            //NOTE: these paths are hard coded for stupid quick/dirty example because I didn't want to mess with figuring out a
            //file dialog in this kind of class library.
            var filePath = "C:\\Code\\GIT\\ErickTraining\\FighterArena\\SampleJson\\";
            if (jorgeOrBob == 1)
            {
                filePath += "bob.json";
            }
            else
            {
                filePath += "jorge.json";
            }
            var json = readFile(filePath);
            return JsonConvert.DeserializeObject<FighterBase>(json);

        }

        private string readFile(string path)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(path))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }
            return sb.ToString();
        }

        //NOTE:I wouldn't want to have collect int duplicated, but this is just a quick/dirty example of how you could change cretion methods
        private static int CollectInt(int min, int max)
        {
            var valid = false;
            int value = min - 1;
            while (!valid)
            {
                if (!int.TryParse(Console.ReadLine(), out value) || value > max || value < min)
                {
                    Console.WriteLine("invalid number, please try again.  Must be between {0} and {1}", min, max);
                }
                else
                {
                    valid = true;
                }
            }
            return value;
        }
    }
}
