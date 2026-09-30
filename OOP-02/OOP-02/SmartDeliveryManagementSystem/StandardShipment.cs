
namespace OOP_02.SmartDeliveryManagementSystem
{
    internal class StandardShipment : Shipment
    {
        #region constructors
        public StandardShipment(DeliveryAdress destination, string trackingCode, string description, decimal weight, decimal deliveryFee) : base(destination, trackingCode, description, weight, deliveryFee)
        {
        }

        #endregion
        
    }
}
