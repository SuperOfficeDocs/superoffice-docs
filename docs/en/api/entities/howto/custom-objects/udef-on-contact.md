---
title: Udef on contact
uid: udef_on_contact
description: Udef on contact
author: SuperOffice Product and Engineering
keywords: entity
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/custom-objects/udef/howto/entity/udef-on-contact
  - /en/api/netserver/entities/howto/custom-objects/udef-on-contact
---

# Udef on contact

The `UdefHelper` uses the `ProgId` field to identify a user-defined field. If `UdefField.ProgId` is blank, then the `UdefField.Identity` field is used, along with a prefix ("SuperOffice:").

The progid and the identity are both constant over the lifetime of a user-defined field, even field-name or type changes.

The identity is generated automatically by the system, while the progid is a string field that is usually blank.

The progid is for third-parties to set to recognizable values.

This example assumes udef fields have been created and published on the contact already, but that no progid values have been set.

```csharp
using SuperOffice.CRM.Entities;
using (SoSession session = SoSession.Authenticate("Tje0", "Tje0"))
{
  Contact contact = Contact.GetFromIdxContactId(3);
  List<string> myStrings = new List<string>(contact.UdefHelper.ProgIds.Count);
  foreach( string progId in contact.UdefHelper.ProgIds )
    myStrings.Add( contact.UdefHelper.ConvertSpecificTypeToString( progId, contact.UdefHelper[progId] ) );

  myStrings.ForEach( delegate(string item) { Console.WriteLine( item);} );
  string originalString = (string)contact.UdefHelper["SuperOffice:1"];
  string testString = DateTime.Now.Ticks.ToString().Substring(0, 6);
  contact.UdefHelper["SuperOffice:1"] = testString;
  contact.UdefHelper["SuperOffice:2"] = "long text";
  contact.UdefHelper["SuperOffice:3"] = 1234;
  contact.UdefHelper["SuperOffice:3"] = "1234"; // also legal!!

  DateTime testDate = new DateTime( 1981, 11, 25 );
  contact.UdefHelper["SuperOffice:4"] = testDate;
  contact.UdefHelper["SuperOffice:4"] = (int)(((TimeSpan)(testDate - new DateTime(1970, 1, 1))).TotalSeconds);
  contact.UdefHelper["SuperOffice:4"] = testDate.ToString(System.Globalization.DateTimeFormatInfo.InvariantInfo);
  testDate = new DateTime( 1964, 10, 30 );
  contact.UdefHelper["SuperOffice:5"] = testDate;
  contact.UdefHelper["SuperOffice:5"] = testDate.ToString(System.Globalization.DateTimeFormatInfo.InvariantInfo);
  contact.UdefHelper["SuperOffice:6"] = true;
  contact.UdefHelper["SuperOffice:6"] = 1;
  contact.UdefHelper["SuperOffice:6"] = true.ToString();
  contact.UdefHelper["SuperOffice:7"] = 1;
  contact.UdefHelper["SuperOffice:7"] = "2";
  contact.UdefHelper["SuperOffice:8"] = 1.234;
  contact.UdefHelper["SuperOffice:8"] = "2.345";
  contact.Save();

  //Load the contact again
  contact = Contact.GetFromIdxContactId(3);
  string s = (string)contact.UdefHelper["SuperOffice:1"];

  //reset string
  contact.UdefHelper["SuperOffice:1"] = originalString;
  contact.Save();
  contact = Contact.GetFromIdxContactId(3);
  s = (string)contact.UdefHelper["SuperOffice:1"];
  Assert.AreEqual(s, originalString, "Udef field was not saved correctly back to the original string");
}
```
