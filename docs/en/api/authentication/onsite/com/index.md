---
title: Authentication
uid: authentication_com
description: Overview of SuperOffice COM API authentication.
author: AnthonyYates
date: 05.08.2018
keywords: security, authentication, COM, IApplication, IDatabase
content_type: concept
deployment: onsite
platform: win
redirect_from: /en/authentication/onsite/com/index
---

# COM

This section assumes that you have a working installation of the SuperOffice Windows client on your development machine. If not, perhaps you want to [try the NetServer options][1].

In contrast to NetServer-based development, COM-based SuperOffice development is the one case where you don't need to worry about configuration files. The only thing you need to decide at this point is whether you will interact with the Windows client or not.

## COM IApplication interface

If you are required to interact with the **Windows client**, you will need only to make a COM reference to the SuperOffice Application Server 1.0 Type Library. Alternatively, you could reference the SuperOffice-generated COM interop DLL.

**COM Reference Dialog - filtered to see SuperOffice libraries:**

![com-app -screenshot][img2]

With a reference made, and the **SuperOffice.COM.Application using** statement declared, all it takes to instantiate the `IApplication` interface is to instantiate a new object of the `SoApplication` class:

![com-app -screenshot][img3]

* If the SuperOffice application was not already open, it will open now.
* If the application is not configured for single sign-on, you will be prompted for credentials now.

Using the `SoApplication` type, you have complete access to both the SuperOffice Windows client, as well as access to the `IDatabase` interface, exposed in the `SoApplication.Database` property.

```csharp
using SuperOffice.COM.Application;
using SuperOffice.COM.SuperOfficeDB;
using SuperOffice.Configuration;

// If not running, this line starts SuperOffice Window client
IApplication superoffice = new SOApplicationClass();
Database database = so.Database;

MessageBox.Show(superoffice.CurrentContact.Name);
```

> [!TIP]
> There are multiple examples of how to use `IApplication` in the old [IApplication COM SDK Help][2], available for download (15 MB).

## COM IDatabase interface

> [!NOTE]
> Use the `IDatabase` interface when you must use COM and don't want to interact with the Windows client application.

1. Make a COM reference to the SuperOfficeDB 7.0 Type Library.

    Alternatively, you could reference the SuperOffice-generated COM interop DLL *SuperOfficeDB.Interop.dll* located in the SDK Interop folder (*C:\Program Files (x86)\SuperOffice\Expander SDK\7.5.5154.200\Interop*).

2. With a reference made, and the **SuperOffice.COM.SuperOfficeDB using** statement declared, it's possible to instantiate a new object of the `Database` class:

    ![com-app -screenshot][img4]

3. Using the `Database` class instance, call the `Login` method with either a normal user, external user, or system user credentials.

4. When login is successful, you have a wide range of methods for reading and writing data to the SuperOffice database.

```csharp
using SuperOffice.COM.SuperOfficeDB;

Database newDb = new DatabaseClass();
bool isOK = newDb.Login("USERNAME", "PASSWORD");
if (isOK)
{
   //create a new Contact instance
   SOContact newContact = newDb.CreateContact();
   //Assign default values to the created Contact
   newContact.SetDefaults();
   //Set values to the properties of the Contact
   newContact.Name = "Dylan Hunt";
   newContact.Department = "Additional Docs";
   newContact.PostalAddress.Address1 = "1236/4 Lake Road, Lake View. lake Land.";
   newContact.PostalAddress.City = "Lake Land";             
   newContact.Emails.Add("dylan@hunt.com", "This my primary email");
   newContact.Country = newDb.GetListItem(SOTableId.enTableCntry, 10);
   newContact.Business = newDb.GetListItem(SOTableId.enTableBusiness, 1);
   newContact.Phones.Add("123456789", "Dylans Personal phone", 1);
   //Save the created Contact
   newContact.Save();               
}
else
   Console.WriteLine("Incorrect Username or Password");

```

Please read more about the `IDatabase` APIs in the old [IDatabase COM SDK Help][3], available for download (12 MB).

<!-- Referenced links -->
[1]: ../../overview.md#options
[2]: ../../../../../assets/downloads/api/COM/SO.COM.IApplication.zip
[3]: ../../../../../assets/downloads/api/COM/SO.COM.IDatabase.zip

<!-- Referenced images -->
[img2]: media/com-add-reference.png
[img3]: media/com-application-code.png
[img4]: media/com-database-code.png
