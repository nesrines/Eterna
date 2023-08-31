namespace Eterna.Models;
public class PricingDetail : BaseEntity
{
    public int PricingId { get; set; }
    public Pricing Pricing { get; set; }

    public int DetailId { get; set; }
    public Detail Detail { get; set; }
}