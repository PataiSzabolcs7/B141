using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euroskill2025
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            client = new HttpClient();
            listBox_Containers.DisplayMember = "Id";
            listBox_Containers.Sorted = true;

            await kontenerListaFrissitese();
        }

        private async Task kontenerListaFrissitese()
        {
            string urlContainers = "http://localhost:3000/containers";
            listBox_Containers.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(urlContainers);
                if(response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JArray listbox_Containers=(JArray)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);
                    listBox_Containers.Items.AddRange(listbox_Containers.ToObject<Container[]>());
                    
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Hiba történt:" + ex.Message);
            }
        }
    }
}
