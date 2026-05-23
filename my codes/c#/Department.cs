class Departament
{
    public string Name { get; set; }
    public Manager DepartmentManager { get; set; }

    public Departament(string name)
    {
        Name = name;
        DepartmentManager = null;
    }

    public void AddManager(Manager manager)
    {
        if(DepartmentManager != null)
        {
            DepartmentManager.IsManager = false;
            DepartmentManager.ManagedDepartment = null;

        } if(manager.ManagedDepartment != null)
        {
            manager.ManagedDepartment.DepartmentManager = null;
        }
        DepartmentManager = manager;
        DepartmentManager.IsManager = true;
        DepartmentManager.ManagedDepartment = this;
    }

}
class Manager
{
    public string Name { get; set; }

    public bool IsManager { get; set; }
    public Departament ManagedDepartment { get; set; }

    public Manager(string name)
    {
        Name = name;
        IsManager = false;
        ManagedDepartment = null;

    }

    


}
