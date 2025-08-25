using KeePassLib;
using KeePassLib.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeePassRDPLite
{
    public partial class FolderPicker : Form
    {
        //private readonly PwEntry _pe;
        //private readonly KprEntrySettings _peSettings;
        private readonly PwDatabase _database;
        private readonly KprConfig _config;
        private string _credFolder;

        public string CredFolder
        {
            get
            {
               return (_credFolder);
            }
        }

        public FolderPicker(/*PwEntry pe, KprEntrySettings peSettings, ,*/ KprConfig config, PwDatabase database)
        {
            _credFolder = "";
            //_pe = pe;
            //_peSettings = peSettings;
            _database = database;
            _config = config;
            InitializeComponent();

            this.Load += FolderPicker_Load;
            this.btnSelect.Click += Select_Click;
        }

        private void FolderPicker_Load(object sender, System.EventArgs e)
        {
            if (_database == null || _database.IsOpen == false)
                return;
                    
            treeFolders.Nodes.Clear();
            PwGroup _root = _database.RootGroup;
            if (_root == null)
                return;
            TreeNode _node = treeFolders.Nodes.Add(_root.Uuid.ToHexString(), _root.Name);

            RecurseGroups(_root, _node);
        }

        private void RecurseGroups(PwGroup _group, TreeNode _node)
        {
            foreach (PwGroup grp in _group.Groups)
            {
                TreeNode _newNode = _node.Nodes.Add(grp.Uuid.ToHexString(), grp.Name);
                RecurseGroups(grp, _newNode);
            }
            _node.Expand();
        }

        private void Select_Click(object sender, System.EventArgs e)
        {
            TreeNode _node = treeFolders.SelectedNode;
            if (_node != null)
            {
                //MessageBox.Show(_node.Name);
                //byte[] uuidBytes = MemUtil.HexStringToByteArray(_node.Name);
                _credFolder = _node.Name;
            }
            this.Close();
        }

    }
}
