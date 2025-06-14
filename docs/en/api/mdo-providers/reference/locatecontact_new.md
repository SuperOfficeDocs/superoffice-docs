---
uid: locatecontact_new
title: locatecontact_new
keywords: mdoprovider mdo provider locatecontact_new
description: Provider for selecting a Contact, including search on persons that match as well as contacts. this provider will return contact records, even for person matches.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "locatecontact_new" MDO List
Provider for selecting a Contact, including search on persons that match as well as contacts. this provider will
return contact records, even for person matches.

This does the same contact + person search as the base class ("contactWithPersonSearch" provider)
but always returns contact info. So you will still get a result for "John Rowling (Liberty Comm)"
but the id = contact-id, not John Rowling's person id.
The type is always "Contact".


Returns Contact items:


id = contact id,


Name = contact.name + department or person first+last name (contact name + department)


ExtraInfo = contact_id,


Type = "Contact"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.LocateContactProvider">LocateContactProvider</see> class.
The name of the MDO list is 'locatecontact_new'.




## Sample Request

```http!
GET /api/v1/MDOList/locatecontact_new
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("locatecontact_new", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|statezerodatabase||2|
|3|Amadeus AS, AAvdeling||3|
|4|Arne'S Kebab, AAvdeling||4|
|5|Bjørge AS, BAvdeling||5|
|6|Bever Inc, BAvdeling||6|
|7|Colina AS, CAvdeling||7|
|8|Chevrolet Norge AS, CAvdeling||8|
|9|Delta Produkter AS, DAvdeling||9|
|10|Dansukker AS, DAvdeling||10|
|11|Endorfin Import AS, EAvdeling||11|
|12|Elan Hoppski, EAvdeling||12|
|13|Fritz & Frantz Import, FAvdeling||13|
|14|Familien AS, FAvdeling||14|
|15|Galliano Liquer, GAvdeling||15|
|16|Golf-Import A/S, GAvdeling||16|
|17|Hotel Lord Nelson, HAvdeling||17|
|18|Hard Core Imports Inc., HAvdeling||18|
|19|Indian Carpets AS, IAvdeling||19|
|20|Illinoise Market Fare INC, IAvdeling||20|
|21|Jensen Madrasser, JAvdeling||21|
|22|Juul & Hansen AS, JAvdeling||22|


## Related MDO Lists

* "locatecontact_newheadings"
* "locatecontact_newheadingswithallitem"
* "locatecontact_newheadingswithallitemwithnoselection"
* "locatecontact_newheadingswithnoselection"
* "locatecontact_newwithallitem"
* "locatecontact_newwithallitemwithnoselection"
* "locatecontact_newwithnoselection"
