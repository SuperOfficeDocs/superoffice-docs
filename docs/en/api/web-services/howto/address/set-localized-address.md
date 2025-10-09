---
uid: set-localized-address
title: Set LocalizedAddress
description: Set the LocalizedAddress
keywords: globalization, address
author: Tony Yates
date: 05.15.2017
version: 9
content_type: howto
redirect_from:
  - /en/globalization-and-localization/address/howto/services/set-localized-address
  - /en/api/netserver/web-services/howto/address/set-localized-address
---

# Set LocalizedAddress

Writing address information back to this data structure is often complex when the consumer application does not share the same dynamic address structure as SuperOffice. In that case, the application must develop a strategy to format their address data structure into one SuperOffice understands.

Assuming the company or person from SuperOffice has the correctly formatted address, each line contains one or more field key names that can be used to locate the same field in a different but corresponding address data structure.

There are 3 groups of pre-defined address field names:

[!include[ALT](../../../localization/address/includes/pre-defined-address-fields.md)]

Knowing what the field key names are for each address type makes it easy to flatten the address data structure into a Dictionary, Map, or key-value pairs. Then, it becomes easy to access each address field value and get or set the address information.

## Solution 1: key-value pairs

Ideally, consumers of SuperOffice CRM Web Service APIs could work with address information in a more intuitive way. One such possibility would be to work with key-value pairs, where field key names are the key part. Here is an example:

```csharp
using (PersonAgent pa = new PersonAgent())
{
  // get person
  var personEntity = pa.GetPersonEntity(215);

  // get person address as a Dictionary<string,string>.
  var addressDictionary = personEntity.GetAddress();

  // update a field
  addressDictionary["City"] = "TimbuckToo";

  // set the changed person address
  personEntity.SetAddress(addressDictionary);

  // save the person in the database
  pa.SavePersonEntity(personEntity);
}
```

## Solution 2: AddressFieldExtensions

Since web service entities are POCO objects, they don't contain methods. Below, however, I have created two extension methods to get and set the address based on a generic `Dictionary<string, string>`. With this structure, it becomes easy to both read and write address fields, and persist those changes back to SuperOffice CRM.

### AddressConstants

The first thing is to define a set of constants that represent each `AddressType`, as well as each address field name:

```csharp
public class AddressConstants
{
  // Address types
  public const string ContactPostalAddress = "ContactPostalAddress";
  public const string ContactStreetAddress = "ContactStreetAddress";
  public const string PersonPrivateAddress = "PersonStreetAddress";

  // Contact address fields
  public const string ContactPostalAddress1 = "PostalAddress1";
  public const string ContactPostalAddress2 = "PostalAddress2";
  public const string ContactPostalAddress3 = "PostalAddress3";
  public const string ContactPostalCity     = "PostalCity";
  public const string ContactPostalCounty   = "PostalCounty";
  public const string ContactPostalState    = "PostalState";
  public const string ContactPostalZip      = "PostalZipcode";
  public const string ContactStreetAddress1 = "StreetAddress1";
  public const string ContactStreetAddress2 = "StreetAddress2";
  public const string ContactStreetAddress3 = "StreetAddress3";
  public const string ContactStreetCity     = "StreetCity";
  public const string ContactStreetCounty   = "StreetCounty";
  public const string ContactStreetState    = "StreetState";
  public const string ContactStreetZip      = "StreetZipcode";

  // Person address fields
  public const string PersonAddress1 = "Address1";
  public const string PersonAddress2 = "Address2";
  public const string PersonAddress3 = "Address3";
  public const string PersonCity     = "City";
  public const string PersonCounty   = "County";
  public const string PersonState    = "State";
  public const string PersonZip      = "Zipcode";
}
```

### AddressFieldExtensions

Next are the extension methods that simplify how to get and set address information as key-value pairs.

```csharp

public static class AddressFieldExtensions
{
  /// <summary>
  /// Get a PersonEntity.Address as a Dictionary&lt;string, string&gt;.
  /// </summary>
  /// <param name="personEntity">The person entity.</param>
  /// <returns>Key/Value pair of address fields.</returns>
  public static Dictionary<string, string> GetAddress(this PersonEntity personEntity)
  {
      return new AddressHelper().GetAddressAsDictionary(personEntity.Address);
  }

  /// <summary>
  /// Get a ContactEntity.Address as a Dictionary&lt;string, string&gt;.
  /// </summary>
  /// <param name="contactEntity">The contact entity.</param>
  /// <returns>Key/Value pair of address field name and values.</returns>
  public static Dictionary<string, string> GetAddress(this ContactEntity contactEntity)
  {
      return new AddressHelper().GetAddressAsDictionary(contactEntity.Address);
  }

  /// <summary>
  /// Populates the PersonEntity.Address property from a Dictionary&lt;string, string&gt; of key value pairs.
  /// </summary>
  /// <param name="personEntity">The PersonEntity</param>
  /// <param name="addressInformation">Key/Value pairs that represent address field name and values.</param>
  public static void SetAddress(this PersonEntity personEntity, Dictionary<string, string>addressInformation)
  {
      var helper = new AddressHelper();
      helper.SetAddressFromDictionary(personEntity.Address, addressInformation);
  }

  /// <summary>
  /// Populates the ContactEntity.Address property from a Dictionary&lt;string, string&gt; of key value pairs.
  /// </summary>
  /// <param name="contactEntity">The ContactEntity</param>
  /// <param name="addressInformation">Key/Value pairs that represent address field name and values.</param>
  public static void SetAddress(this ContactEntity contactEntity, Dictionary<string, string>addressInformation)
  {
      var helper = new AddressHelper();
      helper.SetAddressFromDictionary(contactEntity.Address, addressInformation);
  }
}
```

### Change address format

Changing address formats are easy, and accomplished by changing the entity country ID.

Before changing the `countryId`, make sure to first get the original address information to preserve the existing data, then change the country ID of the entity and save it.

Next, the returned entity will now contain the new address format and you can again get this as a Dictionary and merge it with the previous one.

Finally, change any of the address information and persist the changes.

```csharp
using (ContactAgent ca = new ContactAgent())
{
  // get company
  var contactEntity = ca.GetContactEntity(144);

  // get company address as a Dictionary<string,string>.
  var oldAddressDictionary = contactEntity.GetAddress();

  // change the country id
  contactEntity.Country.CountryId = 36; //Australia

  // save the company in the database
  contactEntity = ca.SaveContactEntity(contactEntity);

  // get the new address as Dictionary<string,string>
  var newAddressDictionary = contactEntity.GetAddress();

  // merge the new and old fields into one dictionary
  var dictionary = newAddressDictionary.Union(oldAddressDictionary).ToDictionary(d=>d.Key, d=>d.Value);

  // update field(s)
  dictionary[AddressConstants.ContactPostalAddress2] = "TimbuckTwo";

  // set the changed address
  contactEntity.SetAddress(dictionary);

  // save the company in the database
  contactEntity = ca.SaveContactEntity(contactEntity);
}
```
