using Google.GenAI;
using Google.GenAI.Types;
using System.Security.Policy;
using System.Configuration;

namespace chatbot
{
    public partial class Form1 : Form
    {
        // 1. Setup the Client and the Model
        private Client _client;
        // This reads the key from the hidden config file
        private string MyApiKey = ConfigurationManager.AppSettings["GeminiApiKey"];

        public Form1()
        {
            InitializeComponent();
            // Initialize the AI client when the app starts
            _client = new Client(apiKey: MyApiKey);
        }


        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userPrompt = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(userPrompt)) return;

            // Display your message in the chat box
            rtbChat.AppendText($"\n\nYou: {userPrompt}");
            txtInput.Clear();
            lblStatus.Text = "Gemini is thinking...";

            try
            {
                // 2. Ask Gemini for a response
                // We use 'gemini-2.0-flash' for the best speed/performance balance
                var response = await _client.Models.GenerateContentAsync(
                model: "gemini-2.5-flash-lite",
                    contents: userPrompt
                );

                // 3. Show the AI's answer
                rtbChat.AppendText($"\n\nGemini: {response.Text}");
                lblStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to AI: " + ex.Message);
                lblStatus.Text = "Error";
            }
        }
    }


}


