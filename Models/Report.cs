using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Management.Models
{
    public class Report
    {
        public int Report_Id { get; set; }
    public string Explain { get; set; }

        public int Total { get; set;}

        public string Status {  get; set; }

        
        public ICollection<User>user { get; set;} = new List<User>();
    }


}
