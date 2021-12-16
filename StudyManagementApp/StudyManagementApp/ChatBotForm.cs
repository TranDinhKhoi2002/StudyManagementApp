﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace StudyManagementApp
{
    public partial class ChatBotForm : Form
    {
        public ChatBotForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtbSending.Text == "")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Bot nhắc nhở", "Hãy hỏi điều gì đó!");
                customMessageBox.ShowDialog();
                return;
            }

            Bot botAI = new Bot();
            // Load default settings from its config folder
            botAI.loadSettings();
            // Load AIML files form AIML folder
            botAI.loadAIMLFromFiles();
            botAI.isAcceptingUserInput = false;
            User user = new User("dinhkhoi", botAI);
            botAI.isAcceptingUserInput = true;
            Request req = new Request(rtbSending.Text, user, botAI);
            Result res = botAI.Chat(req);

            rtxbChatBot.Text = "Chat bot: " + res.Output;
            rtbSending.Text = "";
        }

        private void rtbSending_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(this, new EventArgs());
            }
        }
    }
}
