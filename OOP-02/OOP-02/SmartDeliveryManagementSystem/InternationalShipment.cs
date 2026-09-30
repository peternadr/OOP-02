namespace OOP_02.SmartDeliveryManagementSystem;

internal class InternationalShipment : Shipment
{
    #region Fields
    private string destinationCountry;
    private decimal customsFee;
    
    #endregion

    #region Properties
    public string DestinationCountry
    {
        get
        {
            return destinationCountry;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                destinationCountry = value;
            }
        }
    }

    public decimal CustomsFee
    {
        get
        {
            return customsFee;
        }
        set
        {
            if (value >= 0)
            {
                customsFee = value;
            }
        }
    } 

    public decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5) + CustomsFee;
        }
    }
    #endregion

    #region Constructors
    public InternationalShipment(DeliveryAdress destination, string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry, decimal customsFee) : base(destination, trackingCode, description, weight, deliveryFee)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    } 
    #endregion
}
