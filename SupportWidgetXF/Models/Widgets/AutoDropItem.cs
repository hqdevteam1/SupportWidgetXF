﻿using System;
namespace SupportWidgetXF.Models.Widgets
{
    public class AutoDropItem : IAutoDropItem
    {
        public string Description { set; get; }
        public string Title { set; get; }
        public string Icon { set; get; }

        public AutoDropItem()
        {
        }

        public string IF_GetDescription()
        {
            return Description;
        }

        public string IF_GetIcon()
        {
            return Icon;
        }

        public string IF_GetTitle()
        {
            return Title;
        }
    }
}