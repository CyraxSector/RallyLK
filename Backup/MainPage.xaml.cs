using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Threading;

namespace RallyLK
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private ManualResetEvent allDone = new ManualResetEvent(false);

        private void log_Click(object sender, RoutedEventArgs e)
        {
            string user = name.Text;
            string pass = password.Password.ToString();
            string json = "{\"username\":\"" + user + "\",\"password\" : \"" + pass + "\"}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://rdeshapriya.com/vnotifications/webService.php?action=login&data=" + json);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.BeginGetRequestStream(new AsyncCallback(GetRequestStreamCallback), httpWebRequest);  
        }

        private void GetRequestStreamCallback(IAsyncResult asynchronousResult)
        {
            HttpWebRequest request = (HttpWebRequest)asynchronousResult.AsyncState;
            Stream postStream = request.EndGetRequestStream(asynchronousResult);
            string postData = "null";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            postStream.Write(byteArray, 0, postData.Length);
            postStream.Close();
            request.BeginGetResponse(new AsyncCallback(GetResponseCallback), request);
        }

        private void GetResponseCallback(IAsyncResult asynchronousResult)
        {
            HttpWebRequest request = (HttpWebRequest)asynchronousResult.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(asynchronousResult);
            Stream streamResponse = response.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResponse);
            string responseString = streamRead.ReadToEnd();
            var rootObject = JsonConvert.DeserializeObject<RootObject>(responseString);

            if (rootObject.message.Equals("SUCCESS"))
            {
                Deployment.Current.Dispatcher.BeginInvoke(() => { NavigationService.Navigate(new Uri("/Controllers/Home.xaml", UriKind.Relative)); });
            }

            else
            {
                Deployment.Current.Dispatcher.BeginInvoke(() => { MessageBox.Show("Invalid Cridentials!!!"); });
            }

            streamResponse.Close();
            streamRead.Close();
            response.Close();
            allDone.Set();

        }       

    }

    public class RootObject
    {
        public string message { get; set; }
    }
}