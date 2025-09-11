using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NCQ.Test.Gui.Windows
{
    internal class MainContextMenuSettingFactory
    {
        private readonly string prefix;
        private readonly IDictionary<string, Action<ContextMenuStrip>> _settings;

        public MainContextMenuSettingFactory(string prefix)
        {
            _settings = new Dictionary<string, Action<ContextMenuStrip>>()
            {
                { "STATES_PENDING", Pending },
                { "STATES_PROCESSING", Processing },
                { "STATES_ENDED", Ended }
            };
            this.prefix = prefix;
        }

        internal void Pending(ContextMenuStrip contextMenu)
        {
            var editBtn = contextMenu.Items.Find($"{prefix}Edit", true)
                .FirstOrDefault();
            if (editBtn != null)
            {
                editBtn.Enabled = true;
            }
            var removeBtn = contextMenu.Items.Find($"{prefix}Remove", true)
                .FirstOrDefault();
            if (removeBtn != null)
            {
                removeBtn.Enabled = true;
            }
        }

        internal void Processing(ContextMenuStrip contextMenu)
        {
            var editBtn = contextMenu.Items.Find($"{prefix}Edit", true)
                .FirstOrDefault();
            if (editBtn != null)
            {
                editBtn.Enabled = true;
            }
            var removeBtn = contextMenu.Items.Find($"{prefix}Remove", true)
                .FirstOrDefault();
            if (removeBtn != null)
            {
                removeBtn.Enabled = false;
            }
        }

        internal void Ended(ContextMenuStrip contextMenu)
        {
            var editBtn = contextMenu.Items.Find($"{prefix}Edit", true)
                .FirstOrDefault();
            if (editBtn != null)
            {
                editBtn.Enabled = false;
            }
            var removeBtn = contextMenu.Items.Find($"{prefix}Remove", true)
                .FirstOrDefault();
            if (removeBtn != null)
            {
                removeBtn.Enabled = true;
            }
        }

        internal Action<ContextMenuStrip> Setup(string code)
        {
            return _settings[code];
        }
    }
}
