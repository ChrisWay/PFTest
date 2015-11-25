using DLToolkit.PageFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest
{
    public class HelloViewModel : BaseViewModel
    {
        public HelloViewModel() {
            HelloLabelText = "Hello World";
        }

        public string HelloLabelText {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
    }
}
