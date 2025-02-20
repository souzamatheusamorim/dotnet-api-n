using Library.Communication.Requests;
using Library.Communication.Responses;
using Library.Exception;
using System.Reflection.Metadata.Ecma335;

namespace nwl.useCases.Users.Register
{
    public class RegisterUserUseCase
    {
       public ResponseRegisteredUserJson Execute(RequestUserJson request)
        {
            Validate(request);

            return new ResponseRegisteredUserJson
            {

            }; 
        }

        private void Validate(RequestUserJson request)
        {
            var validator = new RegisterUserValidator();
            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(error => error.ErrorMessage).ToList();

                throw new ErrorOnValidationExcepton(errorMessages);
            }
        }
    }
}
