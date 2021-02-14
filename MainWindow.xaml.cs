using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CablesConnectingDepartment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToDBButton_Click(object sender, RoutedEventArgs e)
        {
            string fName = FName.Text;
            string sName = LName.Text;
            string mobPhone = MobPhone.Text;
            double costph = Convert.ToDouble(CostPHour.Text);
            DBEmployeeTable dbempt = new DBEmployeeTable();
            dbempt.AddRowToEmployeeTable(fName, sName, mobPhone, costph);
        }
        public class DBEmployeeTable
        {
            public void AddRowToEmployeeTable(string fname, string sname, string mobphone, double costPerHour)
            {
                CablesDbContext db = new CablesDbContext();
                Employees employees = new Employees();
                employees.FirstName = fname;
                employees.LastName = sname;
                employees.MobilePhone = mobphone;
                employees.CostPerHour = costPerHour;
                db.Employees.Add(employees);
                db.SaveChanges();
            }
        }
    }
    [Table("Employees ")]
    public class Employees
    {
        [Key]
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public double CostPerHour { get; set; }
    }
    [Table("Cables")]
    public class CableType
    {
        [Key]
        public int CableId { get; set; }
        public string Description { get; set; }
        public int PricePerMeter { get; set; }
    }
    [Table("ConnectionTable")]
    public class CableList
    {
        [Key]
        public int CableNumber { get; set; }
        public int CableTypeId { get; set; }
        public int Lenght { get; set; }
        public int ResponsiblePersonId { get; set; }
        public string ConnectionDescription { get; set; }
        public bool PriorityMarker { get; set; }
    }
}
