﻿namespace CodeTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("SecondPage", typeof(CodeTest.Pages.SecondPage));
        }
    }
}
