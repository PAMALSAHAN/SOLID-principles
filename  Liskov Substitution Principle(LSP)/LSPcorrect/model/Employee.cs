using LSPcorrect.model;

namespace LSPlib
{ 
    public class Employee : BaseEmployee ,IManage
    {
       
        public IEmployee Manager { get; set; } = null;
       
        public virtual void AssignManager(IEmployee manager)
        {
            //property ekata assign karana eka thama wenne methana 
            Manager = manager;  
        }

       

    }
}