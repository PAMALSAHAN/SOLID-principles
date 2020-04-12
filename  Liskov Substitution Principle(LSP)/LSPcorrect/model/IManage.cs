using LSPcorrect.model;
namespace LSPcorrect.model
{
   public interface IManage
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);      

    }
}