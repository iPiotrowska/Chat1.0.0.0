﻿using System;
using System.Windows.Controls;

namespace Chat1._0._0._0
{
    public partial class UserControlMessageSent : UserControl
    {
        public UserControlMessageSent()
        {
            InitializeComponent();
        }

        public void changeMessage(String message)
        {
            TextBlock textBlock = (TextBlock)this.FindName("Message");
            textBlock.Text = message;
        }
    }
}
