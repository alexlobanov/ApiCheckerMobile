using System;
namespace ApiChecker.Validations
{
    public class IsValidUrlRule : IValidationRule<string>
    {
        public string ValidationMessage { get; set; }

        public bool Check(string value)
        {
            var validationResult = Uri.TryCreate(value, UriKind.Absolute, out var uriResult);
            return validationResult
                    && ((uriResult.Scheme == Uri.UriSchemeHttp) //only allow HTTP and HTTPS type of urls 
                    || (uriResult.Scheme == Uri.UriSchemeHttps));
        }
    }
}
