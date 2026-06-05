using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVCTechCrew.Models
{
    public class Aadhar
    {
        [Key]
        public int AadharNo { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }

        public Pan pan { get; set; }  // navigation

    }

    public class Pan
    {
        [Key]
        public int PanNo { get; set; }

        public string PanUserName { get; set; }

        public int AadharRefNo { get; set; }  // foreig key

        [ForeignKey("AadharRefNo")] 
        public Aadhar aaddhar { get; set; }  //  navigation key
    }
}
