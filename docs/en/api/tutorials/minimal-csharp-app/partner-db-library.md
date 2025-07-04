---
title: Customer data source
uid: partner_db_library
description: Customer data source
author: SuperOffice Product and Engineering
keywords:
content_type: tutorial
deployment: online
platform: web
---

# Customer data source

This project is a shared XML serialization data source that reads and writes customer data to an XML document.

The SuperOffice.DevNet.Online.SystemUser.PartnerDBLibrary project contains one customer model and one customer data source class.

## CustomerInfo customer model

The customer model CustomerInfo contains 6 properties that represent a single customer tenant.

```csharp
namespace SuperOffice.DevNet.Online.SystemUser.PartnerDBLibrary.Models
{
    public class CustomerInfo
    {
        public int ID { get; set; }
        public int AssociateID { get; set; }
        public bool IsActive { get; set; }
        public string SystemUserToken { get; set; }
        public string ContextIdentifier { get; set; }
        public DateTime LastSync { get; set; }
    }
}
```

## CustomerDataSource class

The `CustomerDataSource` class could not be more simple. Its sole responsibility is to read CustomerInfo data from and save new CustomerInfo data to, an XML file. This project and data source classes are used by both the MVC website and the console application.

```csharp
public class CustomerDataSource
{
    private const string _dataSource = @"C:\Temp\Customers.xml";

    public CustomerDataSource()
    {
        Deserialize();
    }

    public List<CustomerInfo> Customers = new List<CustomerInfo>();

    public void Save()
    {
         XmlSerializer serializer = new XmlSerializer(typeof(List<CustomerInfo>));

        using (TextWriter writer = new StreamWriter( _dataSource))
        {
             serializer.Serialize(writer, Customers);
        }
    }

    private void Deserialize()
    {
        if (!File.Exists(_dataSource))
        {
            return;
        }

        XmlSerializer deserializer = new XmlSerializer(typeof(List<CustomerInfo>));
        using(TextReader reader = new StreamReader(_dataSource))
        {
            object obj = deserializer.Deserialize(reader);
            Customers = (List<CustomerInfo>)obj;
            reader.Close();
        }
    }
}
```

## Earlier versions of this example

The first version of this example had an SQL Server dependency: A database with a single table to hold customer information was used as a means to share data between both the MVC application and the console service application.

This sharing proved to be cumbersome for those unfamiliar with SQL Server and over-complicated this example. This has since been replaced with another data source.
