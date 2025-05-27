using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.forms.MainWindow
{
    public class CollapsibleSidebar : MenuStrip
    {
        private bool _expanded = false;
        private const int CollapsedWidth = 50;
        private const int ExpandedWidth = 200;

        public event Action<string> MenuItemClicked;

        private class MenuItemData
        {
            public string Icon { get; set; }
            public string Text { get; set; }
            public bool Checked { get; set; }
        }

        public CollapsibleSidebar()
        {
            InitializeSidebar();
            SetupMenuItems();
        }

        private void InitializeSidebar()
        {
            this.Width = CollapsedWidth;
            this.Dock = DockStyle.Left;
            this.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ShowItemToolTips = false;
            this.AutoSize = false;
        }

        private void SetupMenuItems()
        {
            var menuItems = new[]
            {
                new MenuItemData { Icon = "📊", Text = "Управление объектами", Checked = false },
                new MenuItemData { Icon = "✅", Text = "Задачи", Checked = true },
                new MenuItemData { Icon = "📄", Text = "Документация", Checked = false },
                new MenuItemData { Icon = "👥", Text = "Сотрудники", Checked = false },
                new MenuItemData { Icon = "👤", Text = "Учетная запись", Checked = false },
                new MenuItemData { Icon = "🚪", Text = "Выход", Checked = false }
            };

            foreach (var item in menuItems)
            {
                var menuItem = new ToolStripButton
                {
                    Text = _expanded ? $"{item.Icon} {item.Text}" : item.Icon,
                    Tag = item,
                    DisplayStyle = ToolStripItemDisplayStyle.Text,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = false,
                    Width = _expanded ? ExpandedWidth - 10 : CollapsedWidth - 10,
                    Checked = item.Checked
                };

                menuItem.MouseEnter += (s, e) => ShowButtonText(menuItem);
                menuItem.MouseLeave += (s, e) => HideButtonText(menuItem);
                menuItem.Click += MenuItem_Click;

                this.Items.Add(menuItem);
            }
        }

        private void ShowButtonText(ToolStripButton btn)
        {
            if (btn.Tag is MenuItemData item)
            {
                btn.Text = $"{item.Icon} {item.Text}";
                btn.Width = ExpandedWidth - 10;
            }
        }

        private void HideButtonText(ToolStripButton btn)
        {
            if (btn.Tag is MenuItemData item && !_expanded)
            {
                btn.Text = item.Icon;
                btn.Width = CollapsedWidth - 10;
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton btn && btn.Tag is MenuItemData item)
            { MenuItemClicked?.Invoke(item.Text);}
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!_expanded)
            {
                this.Width = ExpandedWidth;
                _expanded = true;
                UpdateButtonsState();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (_expanded && !this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                this.Width = CollapsedWidth;
                _expanded = false;
                UpdateButtonsState();
            }
        }

        private void UpdateButtonsState()
        {
            foreach (ToolStripItem item in this.Items)
            {
                if (item is ToolStripButton btn)
                {
                    if (_expanded)
                    { ShowButtonText(btn);}
                    else
                    { HideButtonText(btn);}
                }
            }
        }

        public void ToggleSidebar()
        {
            _expanded = !_expanded;
            this.Width = _expanded ? ExpandedWidth : CollapsedWidth;
            UpdateButtonsState();
        }
    }
}
