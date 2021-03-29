using System;
using System.Linq;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    internal partial class PrefsByScreenUserControl : UserControl
    {
        public PrefsByScreenUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves the selected preferences for a specific screen.
        /// This method must be called by the general Save method of the Preferences window, and must pass each available screen number.
        /// </summary>
        /// <param name="screenNumber">The specific screen number for which these preferences must be saved.</param>
        public void Save(int screenNumber)
        {
            ScreenInformation currentScreen = Preferences.Screens[screenNumber];
            currentScreen.URLs = (from ListViewItem item in _listViewURLs.Items.Cast<ListViewItem>() select item.Text);
            currentScreen.RotationInterval = (int)_numericUpDownRotationInterval.Value;
            currentScreen.Shuffle = _checkBoxShuffle.Checked;
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            // TODO: make button grey out when none selected OR when all selected ones are in a bunch at the bottom.
            bool gapFound = false;

            // scan from the bottom up, but don't start moving selected items down until
            // we find an unselected gap to move items(s) down in to.
            for (int i = _listViewURLs.Items.Count - 1; i >= 0; i--)
            {
                if (_listViewURLs.Items[i].Selected)
                {
                    if (gapFound)
                    {
                        Swap(_listViewURLs.Items, i, i + 1);
                    }
                }
                else
                {
                    gapFound = true;
                }
            }

            // 'select'ing the list makes sure the selections of items within it are being displayed.
            // Otherwise the button becomes the 'selected' control and the selections within the list
            // are invisible or hard to see.
            _listViewURLs.Select();
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            // TODO: make button grey out when none selected OR when all selected ones are in a bunch at the top.
            bool gapFound = false;

            // scan through for all selected, but don't start moving selected items up until
            // we find an unselected gap to move items(s) up in to.
            for (int i = 0; i < _listViewURLs.Items.Count; i++)
            {
                if (_listViewURLs.Items[i].Selected)
                {
                    if (gapFound)
                    {
                        Swap(_listViewURLs.Items, i, i - 1);
                    }
                }
                else
                {
                    gapFound = true;
                }
            }

            // 'select'ing the list makes sure the selections of items within it are being displayed.
            // Otherwise the button becomes the 'selected' control and the selections within the list
            // are invisible or hard to see.
            _listViewURLs.Select();
        }

        private void ButtonDeleteURL_Click(object sender, EventArgs e)
        {
            // TODO: undo capability?
            // TODO: make button grey out when no selection.
            // work from the bottom up, deleting any we find
            for (int i = _listViewURLs.Items.Count - 1; i >= 0; i--)
            {
                if (_listViewURLs.Items[i].Selected)
                {
                    _listViewURLs.Items[i].Remove();
                }
            }
        }

        private void ButtonAddURL_Click(object sender, EventArgs e)
        {
            ListViewItem item = _listViewURLs.Items.Add(string.Empty);
            item.BeginEdit();
        }

        /// <summary>
        /// Swap the positions of 2 items in a ListViewItemCollection, maintaining Selected status.
        /// Any indexes given outside the bounds of the list are treated as if they point to
        /// the nearest end of the list.
        /// </summary>
        private static void Swap(ListView.ListViewItemCollection itemsList, int indexA, int indexB)
        {
            var a = Math.Min(itemsList.Count - 1, Math.Max(0, indexA));
            var b = Math.Min(itemsList.Count - 1, Math.Max(0, indexB));
            if (a != b)
            {
                var itemA = (ListViewItem)itemsList[a].Clone();
                bool itemASelected = itemsList[a].Selected;
                var itemB = (ListViewItem)itemsList[b].Clone();
                bool itemBSelected = itemsList[b].Selected;
                itemsList[a] = itemB;
                itemsList[a].Selected = itemBSelected;
                itemsList[b] = itemA;
                itemsList[b].Selected = itemASelected;
            }
        }
    }
}
