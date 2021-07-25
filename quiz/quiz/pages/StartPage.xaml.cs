using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
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
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Newtonsoft.Json;

namespace quiz.pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public int button1WasClicked1;
        public int button1WasClicked2;
        public int button1WasClicked3;
        public int button1WasClicked4;

        int[] mas = new int[6];
        int t = 0;

        List<Test> newTestJS;
        public StartPage()
        {
            InitializeComponent();

            initial();
            Count();


            BitmapImage myBitmapImage1 = new BitmapImage();

            myBitmapImage1.BeginInit();
            myBitmapImage1.UriSource = new Uri(@"C:\\Users\\dowra\\Desktop\\quiz\\quiz\\bin\\Debug\images\\dowr.png", UriKind.RelativeOrAbsolute);
            myBitmapImage1.EndInit();

            img1.Source = myBitmapImage1;
        }

        private void o1_Click(object sender, RoutedEventArgs e)
        {
            Check(button1WasClicked1,o1);
           
            Count();
            
        }

        private void o2_Click(object sender, RoutedEventArgs e)
        {
            Check(button1WasClicked2, o2);
            Count();
             
        } 
        private void o3_Click(object sender, RoutedEventArgs e)
        {
            Check(button1WasClicked3, o3);
            Count();
            
        }

        private void o4_Click(object sender, RoutedEventArgs e)
        {
            Check(button1WasClicked4, o4); 
            Count();
            
        }

        public void Check(int ch, Button o)
        {
            if (ch == 1)
            {
               // label1.Content = "ВЕРНО!\nмолодец";
                //label1.Foreground = Brushes.Green;
               
               MessageBox.Show("ВЕРНО!\nмолодец!");
                // o.Background = Brushes.Green; 
            }
            else
            {
                //label1.Content = "АЙ АЙ АЙ!";
                //label1.Foreground = Brushes.Red;
                
                //o.Background = Brushes.Red;
                MessageBox.Show("НЕ ВЕРНО!\nАЙ АЙ АЙ");
            }
        }

        public void Count()
        {

            foreach (var x in newTestJS)
            {
                if (x.index == mas[t])
                {
                    question.Content = x.question;
                    button1WasClicked1 = x.truefalse1;
                    button1WasClicked2 = x.truefalse2;
                    button1WasClicked3 = x.truefalse3;
                    button1WasClicked4 = x.truefalse4;
                    o1.Content = x.answer1;
                    o2.Content = x.answer2;
                    o3.Content = x.answer3;
                    o4.Content = x.answer4;

                   
                    t++;
                    break;
                }
            }
        }
        public void initial()
        {
            DataContractJsonSerializerSettings setting = new DataContractJsonSerializerSettings { };
            DataContractJsonSerializer jsonSerializerForList = new DataContractJsonSerializer(typeof(List<Test>),setting);
            using (Stream fs = new FileStream("list22.json", FileMode.OpenOrCreate))
            {
                newTestJS = (List<Test>)jsonSerializerForList.ReadObject(fs);
                 
            }
            //Создание объекта для генерации чисел 

            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(1, 6);
                if (!mas.Contains(a))
                {
                    mas[i] = a;
                }
                else
                    i--;
            } 
        }

        
    }
}
