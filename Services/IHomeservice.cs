using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IHomeservice
    {
       ResponseModel GetWelcomeMessages(ContactModel model);
          
    }
}