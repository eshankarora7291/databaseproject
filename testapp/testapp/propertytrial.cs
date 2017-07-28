using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class propertytrial
    {

        //delegate - a variable to reference a method.
        public delegate void Writer(string message);
        private string _name;


        public string Name
        {
            get//invoked when someone accesses Name
            {
                return _name;
            }
            set// will be invoked any time someone tries to write value into this Name property
            {
                //whatever value someone tries to pass will be implicitly stored in the variable value.
                if(!String.IsNullOrEmpty(value))
                {
                    if(_name!=value)
                    {
                        //delegate
                        NameChanged(_name, value);
                    }
                    _name = value;
                }
                //auto implemented property with only {get ;set};
                // it will automatically create a field to store the value and access it
            }
        }
        public NameChanged nameCh;


        internal Writer Write { get => write; set => write = value; }
    }
}
