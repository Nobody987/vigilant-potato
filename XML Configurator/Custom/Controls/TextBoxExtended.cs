using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XML_Configurator.Custom.Controls
{
    public class TextBoxExtended : TextBox
    {
        private List<string> _autoCompleteSource = new List<string>();
        private string _startString = null;
        private ToolStripDropDown _dropDown = null;
        private ListBox _box = null;

        public List<string> MyAutoCompleteSource
        {
            get { return _autoCompleteSource; }
            set { _autoCompleteSource = value; }
        }

        public string StartString
        {
            get { return _startString; }
            set { _startString = value; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text != "")
            {
                //foreach (var item in _autoCompleteSource)
                //{
                //    if (item.StartsWith(this.Text.Trim())
                //    {

                //    }
                //}
                //var legalStrings = 
                var legalStrings = from item in _autoCompleteSource where item.StartsWith(this.Text.Trim(), true, null) select item;
                if (legalStrings.Count<string>() > 0)
                {
                    _box.Items.Clear();
                    if (string.IsNullOrEmpty(_startString) == false)
                        _box.Items.Add(_startString);
                    else
                        _box.Items.Add("select a value");
                    foreach (string str in legalStrings)
                        _box.Items.Add(str);
                    _dropDown.Show(this, new Point(0, this.Height));
                }
            }
        }

        //Check if a value is in the auto complete source
        public bool IsValueInSource
        {
            get
            {
                if (_autoCompleteSource == null) return true;
                else
                {
                    var data = from item in _autoCompleteSource where item == this.Text.Trim() select item;
                    if (data.Count<string>() > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            _dropDown = new ToolStripDropDown();
            _box = new ListBox();
            _box.Width = this.Width - 2;
            _box.SelectedIndexChanged += (EventHandler)((sender, arg) =>
            { if (_box.SelectedIndex == 0) _box.SelectedIndex = 1; });
            _box.KeyDown += (KeyEventHandler)((sender, k) =>
            {
                if (k.KeyCode == Keys.Enter && _box.SelectedIndex != 0)
                {
                    this.Text = _box.SelectedItem.ToString();
                    _dropDown.Close();
                }
            });
            _box.Click += (EventHandler)((sender, arg) =>
            { this.Text = _box.SelectedItem.ToString(); _dropDown.Close(); });
            ToolStripControlHost host = new ToolStripControlHost(_box);
            host.AutoSize = false;
            host.Margin = Padding.Empty;
            host.Padding = Padding.Empty;
            _dropDown.Items.Add(host);
            _dropDown.Height = _box.Height;
            _dropDown.AutoSize = false;
            _dropDown.Margin = Padding.Empty;
            _dropDown.Padding = Padding.Empty;
            _dropDown.Size = host.Size = _box.Size;
        }
    }
}
