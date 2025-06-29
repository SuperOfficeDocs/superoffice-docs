---
uid: contact_new
title: contact_new
keywords: mdoprovider mdo provider contact_new
description: Provider for selecting a Contact - without person search. Does keyword matching and scoring across multiple string fields. Checks name, department, soundex fields.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "contact_new" MDO List
Provider for selecting a Contact - without person search.
Does keyword matching and scoring across multiple
string fields. Checks name, department, soundex fields.

User's own contacts, recently added + modified contacts, contacts modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.
Contacts with lots of activity or lots of recent activity (according to the SAINT counters) are also
preferred.


Returns contact items only: Id = ExtraInfo = contact_id, Type = "Contact", StyleHint = "stop"


Stopped contacts are marked with stylehint = "stop" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactListProvider">ContactListProvider</see> class.
The name of the MDO list is 'contact_new'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Comma separated list of one or more contact ids.| contact_id|1234,5678,9012|





## Sample Request

```http!
GET /api/v1/MDOList/contact_new
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("contact_new", forceFlatList: true);
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

* "contact_newheadings"
* "contact_newheadingswithallitem"
* "contact_newheadingswithallitemwithnoselection"
* "contact_newheadingswithnoselection"
* "contact_newwithallitem"
* "contact_newwithallitemwithnoselection"
* "contact_newwithnoselection"
