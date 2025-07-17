using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class Homeservice : IHomeservice
    {
        public ResponseModel GetWelcomeMessages(ContactModel model)
        {
            return new ResponseModel(
                message: model.Message+ "response",
                success: true,
                data: null
            );
        }
    }
    }
