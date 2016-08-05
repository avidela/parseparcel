using System.Collections.Generic;
using System.Linq;
using ParcelParser.Model;

namespace ParcelParser.Validation
{
    public class ParselValidator : IParcelValidation
    {
        private readonly IEnumerable<IParcelValidation> _validators;

        public ParselValidator(IEnumerable<IParcelValidation> validators)
        {
            _validators = validators;
        }
      
        public bool IsValid(Parcel parcel, ParcelType type)
        {
            return _validators.All(x => x.IsValid(parcel,type));
        }
    }
}