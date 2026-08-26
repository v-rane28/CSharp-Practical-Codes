using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProjectDetails
{
    private long project_budget;
    private string project_name;
    private string project_clientName;
    private int project_id;
    public void set(long project_budget, string project_name,string project_clientName, int project_id)
    {
        this.project_budget = project_budget;
        this.project_name = project_name;
        this.project_clientName = project_clientName;
        this.project_id = project_id;
    }
    public long getPBudget()
    {
        return project_budget;
    }
    public string getPName()
    {
        return project_name;
    }
    public string getCName()
    {
        return project_clientName;
    }
    public int getPid()
    {
        return project_id;
    }
}
class Encapsulation1
{
    public static void Main()
    {
        ProjectDetails p = new ProjectDetails();
        p.set(12000000, "ATM Software","elon musk", 23);
        Console.WriteLine("Project ID:" + p.getPid());
        Console.WriteLine("Project Budget:" + p.getPBudget());
        Console.WriteLine("Project Name:" + p.getPName());
        Console.WriteLine("Project Client Name:" + p.getCName());
        
    }
}