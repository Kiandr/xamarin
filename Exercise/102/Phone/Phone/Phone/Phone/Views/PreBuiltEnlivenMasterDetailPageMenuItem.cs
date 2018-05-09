using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Views
{

    public class PreBuiltEnlivenMasterDetailPageMenuItem
    {
        public PreBuiltEnlivenMasterDetailPageMenuItem()
        {
            TargetType = typeof(PreBuiltEnlivenMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}