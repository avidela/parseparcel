using ParcelParser.Model;

namespace ParcelParser.Service
{
    public interface IParcelFeeCalculator
    {
        double GetFee(Parcel parcel, ParcelType parcelType);
    }
}