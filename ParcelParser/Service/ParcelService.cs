using System;
using ParcelParser.Model;
using ParcelParser.Validation;

namespace ParcelParser.Service
{
    public class ParcelService
    {
        private readonly IParcelValidation _parcelValidation;
        private readonly IParcelFeeCalculator _parcelFeeCalculator;

        public ParcelService(IParcelValidation parcelValidation,IParcelFeeCalculator parcelFeeCalculator)
        {
            _parcelValidation = parcelValidation;
            _parcelFeeCalculator = parcelFeeCalculator;
        }

        public double CalculateParcelPrice(Parcel parcel)
        {
            var parcelType = GetParcelType(parcel);
            var isValid = _parcelValidation.IsValid(parcel, parcelType);
            if (!isValid)
            {
                throw new Exception("Invalid Parcel");
            }
           return _parcelFeeCalculator.GetFee(parcel, parcelType);
        }

        private ParcelType GetParcelType(Parcel parcel)
        {
            return  ParcelType.Large;
        }
    }
}
