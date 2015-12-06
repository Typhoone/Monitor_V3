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

        private static string PRINTFORMAT = "Time    \tRPM\tDuty\tDelay\tBox\tCoil\tTrig\tHz\tM\n\t\t\t\t\tTemp\tTemp\tRPM";

        List<Log> data;
        TextBox notesBox;

        string fileName;
        string path;
        int lastLogSaved = 0;

        int logsAdded = 0;// how many logs have been added since last save


        public FileManager(List<Log> data, TextBox notes)
        {
            this.data = data;
            this.notesBox = notes;

            this.fileName = DateTime.Now.ToString("yyyy-M-d");
            path = Directory.GetCurrentDirectory();
            if (!File.Exists(@path + "\\" + fileName + LOG_APPEND))
            {
                createLogFile();
            }
            if (!File.Exists(@path + "\\" + fileName + NOTE_APPEND))
            {
                createNotesFile();
            }
        }

        private void createLogFile()
        {

            try
            {
                using (StreamWriter file = File.CreateText(@path + "\\" + fileName + LOG_APPEND))
                {
                    file.WriteLine(PRINTFORMAT);
                }

            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void createNotesFile()
        {

            try
            {
                using (StreamWriter file = File.CreateText(@path + "\\" + fileName + NOTE_APPEND))
                {
                    file.WriteLine(PRINTFORMAT);
                }

            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void appendLogFile()
        {
            try
            {
                using (StreamWriter file = File.CreateText(@path + "\\" + fileName + LOG_APPEND))
                {
                    int length = data.Count();
                    for (int i = lastLogSaved; i < length; i++)
                    {
                        file.WriteLine(data.ElementAt(i).print());
                    }
                    lastLogSaved = length - 1;
                }
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        public void saveNoteFile()
        {
            try
            {
                File.WriteAllText(@path + "\\" + fileName + NOTE_APPEND, notesBox.Text);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public void logLogAdded()
        {
            this.logsAdded++;

            if(logsAdded >= LOGS_BEFORE_SAVE)
            {
                logsAdded = 0;
                appendLogFile();
            }
        }

        public string loadFile(string fileName)
        {
            string notes = "";
            data.Clear();
            try
            {
                Boolean loadingNotes = true;
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    if(loadingNotes && line.Equals(ENDLINE))
                    {
                        loadingNotes = false;
                    }

                    if (loadingNotes)
                    {
                        notes = notes + line;
                    }
                    else
                    {
                        data.Add(new Log(line));
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            return notes;
        }
    }
}
