﻿using Jaya.Ui.Models;

namespace Jaya.Ui.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public ToolbarConfigModel ToolbarConfiguration => Shared.Instance.ToolbarConfiguration;
    }
}