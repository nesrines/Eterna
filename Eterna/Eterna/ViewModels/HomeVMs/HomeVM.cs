using Eterna.Models;

namespace Eterna.ViewModels.HomeVMs;
public class HomeVM
{
    public List<Slide> Slides { get; set; }
    public List<Feature> Features { get; set; }
    public List<Service> Services { get; set; }
    public List<Client> Clients { get; set; }
}