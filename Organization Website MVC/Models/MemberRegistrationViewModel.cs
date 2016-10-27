using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Organization_Website_MVC.Models
{
    public class MemberRegistrationViewModel
    {

        public List<organization> organizations { get; set; }
        //public List<connection> connections { get; set; }

        public person person { get; set; }
        public connection connection { get; set; }

        public MemberRegistrationViewModel(List<organization> organizations)
        {
            this.organizations = organizations;
            person = new person();
            connection = new connection();
        }

        public MemberRegistrationViewModel()
        {
        }


    }
}