using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class TeacherNameChangeArgs:EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }
        public TeacherNameChangeArgs(string oldName, string newName)
        {
            OldName = oldName;  
            NewName = newName;  
        }
    }
    public class Teacher
    {
        public event EventHandler<TeacherNameChangeArgs> TeacherNameChange;
        private string _name;
        private string _description;

        public Teacher(string name, string description)
        {
            _name = name;   
            _description = description; 
        }

        public void SetName(string newName)
        {
            var args = new TeacherNameChangeArgs(_name, newName);
            _name = newName;
            TeacherNameChange.Invoke(this, args);
        }
    }

    public class TeacherChangeNameLogger
    {
        public void Log(object sender, TeacherNameChangeArgs args)
        {
            Console.WriteLine($"old name is {args.OldName} new name is {args.NewName}");
        }
    }
}
