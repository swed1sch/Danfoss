
namespace Danfoss.Models
{
    public class House
    {
        public string Address { get; set; }
        public int HouseID { get; set; }
        public WaterMeter waterMeter { get; set; }
    }
}
