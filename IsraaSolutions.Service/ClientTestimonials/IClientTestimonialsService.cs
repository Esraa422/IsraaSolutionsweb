using System.Collections.Generic;
using IsraaApp.Core.Entities;

namespace IsraaApp.Service
{
    public interface IClietTestimonialsService
    {
        IEnumerable<ClientTestimonials> GetActiveTestimonials();
        IEnumerable<ClientTestimonials> GetActiveClients();

        IEnumerable<ClientTestimonials> GetTestimonials();
        IEnumerable<ClientTestimonials> GetClients();

        ClientTestimonials GetById(int id);
        bool Delete(ClientTestimonials testimonials);
        bool Insert(ClientTestimonials testimonials);
        bool Update(ClientTestimonials testimonials);
    }
}