using System;

namespace _3._2
{
    internal class Redactor
    {
        private AbstractHandler handler;

        public void ChoiseDocument(string filename)
        {
            if (filename != null && filename != "")
            {
                string ext = filename.Substring(filename.Length - 4);
                switch (ext.ToLower())
                {
                    case ".doc":
                        handler = new DOCHandler();
                        break;

                    case ".txt":
                        handler = new TXTHandler();
                        break;

                    case ".xml":
                        handler = new XMLHandler();
                        break;

                    default:
                        Console.WriteLine("unrecognized format");
                        break;
                }
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Change()
        {
            handler.Chenge();
        }

        public void Save()
        {
            handler.Save();
        }

        public void Create()
        {
            handler.Create();
        }
    }
}