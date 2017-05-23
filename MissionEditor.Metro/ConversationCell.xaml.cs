﻿using System;
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

namespace MissionEditor.Metro
{
    /// <summary>
    /// ConversationCell.xaml 的交互逻辑
    /// </summary>
    public partial class ConversationCell : UserControl
    {
        public ConversationCell(string npcName, BitmapSource headBitmapSource,string conversation)
        {
            InitializeComponent();
            NPCHeadImage.Source = headBitmapSource;
            NPCNameTextBox.Text = npcName;
            Conversation.Text = conversation;
        }
    }
}
