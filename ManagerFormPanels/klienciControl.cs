using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem.paneleKierownika
{
    public partial class klienciControl : UserControl
    {
        public klienciControl()
        {
            InitializeComponent();
        }

        #region Properties
        private string _who;
        private string listElId;
        private string _desc;
        private string _descType;
        private string _idName;
            [Category("Custom Props")]
        public string indexName
        {
            get { return _idName; }
            set { _idName = value; indexNameLb.Text = value; }
        }
        [Category("Custom Props")]
        public string ListElementId
        {
            get { return listElId; }
            set { listElId = value; idLb.Text = value; }
        }
        [Category("Custom Props")]

        public string Who
        { 
            get { return _who; } 
            set { _who = value; whoLb.Text = value; } 
        }
        [Category("Custom Props")]

        public string DescriptionType
        {
            get { return _descType; }
            set { _descType = value; descTypeLb.Text = value; }
        }

        [Category("Custom Props")]

        public string Description
        {
            get { return _desc; }
            set { _desc = value; descLb.Text = value; }
        }


        #endregion
    }
}
