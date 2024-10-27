using EntityLayer.Concrate;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_ticElbise.Models.Classes
{
    public class PCSViewModel
    {
        public Products ProductVm { get; set; }
        public IEnumerable<Colors> ColorsVm { get; set; }
        public IEnumerable<Sizes> SizesVm { get; set; }
        public IEnumerable<TemporanyColors> T_Colors { get; set; }



    }
}
