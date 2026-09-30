namespace OOP_02.SmartDeliveryManagementSystem;

internal class ExpressShipment : Shipment
{
    private decimal extraFee;

    #region Properties
    public decimal ExtraFee
    {
        get
        {
            return extraFee;
        }
        set
        {
            if (value >= 0)
            {
                extraFee = value;
            }
        }
    }

    public decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5) + ExtraFee;
        }
    } 
    #endregion

    #region Constructors
    public ExpressShipment(DeliveryAdress destination, string trackingCode, string description, decimal weight, decimal deliveryFee, decimal extraFee) : base(destination, trackingCode, description, weight, deliveryFee)
    {
        ExtraFee = extraFee;
    } 
    #endregion
}
