using Dinner.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Dinner.Async.Wpf
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnMakeDinner_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //[1] 밥 만들기
            Rice rice = await (new Cooking()).MakeRiceAsync();
            lblDisplay.Content = $"밥 준비 완료 - {rice.GetHashCode()}";

            //[2] 국 만들기
            Soup soup = await (new Cooking()).MakeSoupAsync();
            lblDisplay.Content = $"국 준비 완료 - {soup.GetHashCode()}";

            //[3] 달걀 만들기
            Egg egg = await (new Cooking()).MakeEggAsync();
            lblDisplay.Content = $"달걀 준비 완료 - {egg.GetHashCode()}";

            stopwatch.Stop();
            lblDisplay.Content = $"\n시간: {stopwatch.ElapsedMilliseconds}밀리초";

            lblDisplay.Content = ("비동기 방식으로 식사 준비 완료");
        }

        private void btnWachingTV_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content =
                "TV 보는 중... " + DateTime.Now.Millisecond.ToString();
        }
    }
}
