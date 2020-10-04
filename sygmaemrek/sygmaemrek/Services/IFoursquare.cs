using sygmaemrek.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace sygmaemrek.Services
{
    public interface IFoursquare
    {
        Task<Place> getvenue(double lat, double lon);
    }
}
