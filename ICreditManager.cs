using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager // şablon
    {
        void Calculate();
        void DoSomething();    
        
    }
}
// eğer ki birisi bu interface'i kullanırsa içerideki tüm metotları içermek zorundadır.
// interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.