using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace GOOGLESOFT
{
    public partial class SearchResultControl : UserControl
    {
        public SearchResultControl(VideoJson info)
        {
            InitializeComponent();
            this.Thumbnail.Load(info.ThumbnailURL);
            this.Title.Text = info.title;
            this.Description.Text = info.description;
        }
    }
}
