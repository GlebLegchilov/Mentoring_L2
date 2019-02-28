using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait.Task2
{
    public partial class RequestManagerForm : Form
    {
        private const string GoogleUri = "https://www.google.by/";
        private const string YandexUri = "https://yandex.by/";

        private RequestManager _dowloadManager = new RequestManager();
        private CancellationTokenSource _ctsForFirstRequest = new CancellationTokenSource();
        private CancellationTokenSource _ctsForSecondRequest = new CancellationTokenSource();

        public RequestManagerForm()
        {
            InitializeComponent();

            firstRequestTextBox.Text = GoogleUri;
            secondRequestTextBox.Text = YandexUri;
        }

        private void sendRequestButton_Click(object sender, EventArgs e)
        {
            MakeRequest(
                firstRequestTextBox,
                firstRequestCancelButton,
                firstRequestResultLabel,
                _ctsForFirstRequest.Token);

            MakeRequest(
                secondRequestTextBox,
                secondRequestCancelButton,
                secondRequestResultLabel,
                _ctsForSecondRequest.Token);

        }

        private void firstRequestCancelButton_Click(object sender, EventArgs e)
        {
            _ctsForFirstRequest.Cancel();
            _ctsForFirstRequest = new CancellationTokenSource();
        }

        private void secondRequestCancelButton_Click(object sender, EventArgs e)
        {
            _ctsForSecondRequest.Cancel();
            _ctsForSecondRequest = new CancellationTokenSource();
        }

        private void MakeRequest(
            TextBox requestUrlTextBox,
            Button cancelButton,
            Label resultLabel,
            CancellationToken token)
        {
            if (!string.IsNullOrWhiteSpace(requestUrlTextBox.Text))
            {
                cancelButton.Show();
                var requestTask = _dowloadManager.GetResponseAsync(
                    requestUrlTextBox.Text,
                    token);
                setRequestResult(
                    resultLabel,
                    cancelButton,
                    requestTask);
            }
        }

        private async void setRequestResult(Label label, Button cancelButton, Task<string> requestTask)
        {
            label.Text = await requestTask;
            cancelButton.Hide();
        }
    }
}
