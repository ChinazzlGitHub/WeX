﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu.Buttons
{
    public class ScancodePushButton : IClickMenuButton
    {
        public MenuButtonType Type
        {
            get { return MenuButtonType.scancode_push; }
        }

        public string Name
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }
    }
}
