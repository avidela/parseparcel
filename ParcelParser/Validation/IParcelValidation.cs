using ParcelParser.Model;

namespace ParcelParser.Validation
{
    public interface IParcelValidation
    {
        bool IsValid(Parcel parcel,ParcelType type);
    }
}