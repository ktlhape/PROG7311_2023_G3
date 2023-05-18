namespace ConnectToDB.Models
{
    public class Modules
    {
        public string ModuleID { get; set; }
        public string ModuleName { get; set; }
        public int Credits { get; set; }

        public Modules(string moduleID, string moduleName, int credits)
        {
            ModuleID = moduleID;
            ModuleName = moduleName;
            Credits = credits;
        }
    }
}
