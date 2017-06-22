// IMessageDialog.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System;
using System.Collections.Generic;
using System.Text;

namespace androidandios
{
    public interface IMessageDialog
    {
        void SendMessage(string message, string title = null);
        void SendToast(string message);
        void SendConfirmation(string message, string title, Action<bool> confirmationAction);
    }
}
