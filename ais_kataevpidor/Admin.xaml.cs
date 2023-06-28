using System;
using System.Collections.Generic;
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

namespace ais_kataevpidor
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        Employees emp = new Employees();
        public Admin(Employees currectUser)
        {
            InitializeComponent();
            emp = currectUser;
            var product = Model1.GetContext().Student.ToList();
            LViewProduct.ItemsSource = product;
            UpdateData();
            Employees();
        }
        private void Employees()
        {
            if (emp != null)
            {
                txtFullname.Text = emp.LastName.ToString() + emp.FirstName.ToString() + " " + emp.Patronymic.ToString();
            }
            else
            {
                txtFullname.Text = "Гость";
            }
        }
        List<Student> orderProducts = new List<Student>();
        private void btnAddProduct_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            orderProducts.Add(LViewProduct.SelectedItem as Student);

            
        }

        private void UpdateData()
        {
            var result = Model1.GetContext().Student.ToList();
        }
        private void txtSearch_SelectionChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            UpdateData();
        }
        private void LViewProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //NavigationService.Navigate(new AddEditProductPage(LViewProduct.SelectedItem as Product));
        }
    }

    
}
