using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace myProject
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string code_Module;
        string name_Module;
        int number_Credit;
        int class_HourWeeks;
        int number_weeks_sem;
        string date_Start;
        int number_self_study;
        int hour_spend;
        int self_hour_remain;

        ObservableCollection<Modules> mods = new ObservableCollection<Modules>();

        //DateTime date = new DateTime(2008, 5, 1);
        //Semester sem = new Semester(5, new DateTime(2022, 9, 9));
        //Modules mods = new Modules("PROG02", "Programing 06", 15, 6);
        public MainWindow()
        {
            InitializeComponent();
            myListView.ItemsSource = mods;
        }

        private void ClearText()
        {
            code_mod.Clear();
            name_mod.Clear();
            credit_mod.Clear();
            class_HW.Clear();
            sem_number_Weeks.Clear();
            hour_Spend.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Modules mods = new Modules();

            code_Module = code_mod.Text;
            name_Module = name_mod.Text;
            number_Credit = int.Parse(credit_mod.Text);
            class_HourWeeks = int.Parse(class_HW.Text);
            
            number_weeks_sem = int.Parse(sem_number_Weeks.Text);
            date_Start = sem_start_Date.Text;
            hour_spend = int.Parse(hour_Spend.Text);
            
            int operation1 = number_Credit * 10 / number_weeks_sem;
            int number_self_study = operation1 - class_HourWeeks;

            int self_hour_remain = class_HourWeeks - hour_spend;

            var query = from module in mods
                        orderby module ascending
                        select module;

            mods.Add(new Modules() { Code_Module = code_Module, Name_Module = name_Module,
                Number_Credit = number_Credit, Class_HourWeeks = class_HourWeeks,
                NOTW = number_weeks_sem, DSOF = date_Start, Spend_Hour = hour_spend,
                Number_self_study = number_self_study, Remain_Self_Hour = self_hour_remain
            });
            ClearText();
        }

        public int SelfHour()
        {
            Semester sem = new Semester();
            int operation1 = number_Credit * 10 / sem.NumberOfWeeks;
            int operation2 = operation1 - class_HourWeeks;

            return operation2;
        }

        public int HourSpend(int h)
        {
            int Remain_Self_Hour = class_HourWeeks - h;
            return Remain_Self_Hour;
        }
    }
}
