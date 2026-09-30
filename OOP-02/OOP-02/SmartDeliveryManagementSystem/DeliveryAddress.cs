using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02.SmartDeliveryManagementSystem;

public struct DeliveryAdress
{
    #region Fields

    public string Street;
    public int BuildingNumber;
    public string City;

    #endregion

    #region Constructors
    public DeliveryAdress(string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }
    #endregion

    #region Methods
    public string GetFullAddress()
    {
        return $"{BuildingNumber} {Street}, {City}";
    }
    #endregion
}
