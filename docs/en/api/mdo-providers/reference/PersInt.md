---
uid: persint
title: persint
keywords: mdoprovider mdo provider persint
description: MDO list provider for PersInt (Person interests)
generated: true
content_type: reference
envir: onsite, online
---

# "persint" MDO List
MDO list provider for PersInt (Person interests)



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersIntProvider">PersIntProvider</see> class.
The name of the MDO list is 'persint'.




## Sample Request

```http!
GET /api/v1/MDOList/persint
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("persint", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Referanse person|||
|2|Teknisk kontakt|||
|3|Administrativ kontakt|||
|4|Beslutningstaker|||
|5|Salgskontakt|||
|6|Produkt nyheter|||
|7|Prislister|||
|8|Pressemeldinger|||
|9|Teknisk informasjon|||
|10|Hilsen / Julekort|||
|11|Invitasjon - Seminar|||
|12|Invitasjon - Kurs|||


## Related MDO Lists

* "persintheadings"
* "persintheadingswithallitem"
* "persintheadingswithallitemwithnoselection"
* "persintheadingswithnoselection"
* "persintwithallitem"
* "persintwithallitemwithnoselection"
* "persintwithnoselection"
