using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor_V3
{
    class FileManager
    {
        private const int LOGS_BEFORE_SAVE = 4; // amount of logs before a save is run
        private const string LOG_APPEND = "_Logs.txt";
        private const string NOTE_APPEND = "_Notes.txt";
        private const string ENDLINE = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";

        private static string PRINTFORMAT = "Time       " + string.Format("{0,15}{1,12}{2,14}{3,14}{4,22}{5,24}{6,13}{7,16}", "RM", "Duty", "Delay", "CoilTemp", "ControlTemp", "EStartRPM", "Frequency", "Magnets");

        List<Log> data;
        TextBox notesBox;

        string fileName;
        string path;

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }

        public FileManager(List<Log> data, TextBox notes)
        {
            //Console.WriteLine(PRINTFORMAT);
            this.data = data;
            this.notesBox = notes;

            this.FileName = DateTime.Now.ToString("yyyy-M-d") + ".txt";
            path = Directory.GetCurrentDirectory();
        }

        

        public string loadFile(string fileName)
        {
            string[] split = fileName.Split('\\');
            this.fileName = split[split.Count() - 1];
            string notes = "";
            data.Clear();
            try
            {
                string fileText = File.ReadAllText(fileName);

                notes = fileText.Split(new string[] { ENDLINE }, StringSplitOptions.None)[0];

                string logs = fileText.Split(new string[] { ENDLINE }, StringSplitOptions.None)[1];

                using (StringReader str = new StringReader(logs))
                {
                    String line = str.ReadLine();

                    while((line = str.ReadLine()) != null)
                    {
                        
                        if (!line.Contains("Time"))
                        {
                            //Console.WriteLine(line);
                            data.Add(new Log(line));
                        }
                    }
                }


               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + '\n' + e.StackTrace);
                
            }

            return notes;
        }


        public void saveAll(string notes)
        {
            string text = notes;
            text += "\n" + ENDLINE;
            text += "\n" + PRINTFORMAT;

            foreach(Log log in data)
            {
                text += "\n" + log.print();
            }

            try
            {
                File.WriteAllText(@path + "\\" + FileName, text);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
