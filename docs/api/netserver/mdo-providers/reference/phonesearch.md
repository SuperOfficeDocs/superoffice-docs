---
uid: phonesearch
title: phonesearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "phonesearch"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "phonesearch" MDO List
Search phone numbers for matching stripped numbers, across person and contacts.
Return company name + department, or person name.
Use AdditionInfo to restrict search to just Person or Contact phone numbers using "P" or "C".

Returns: list item with

id = person or contact id

Name = company name + phone number or person name + company name + phone number

ExtraInfo + Tooltip = GSM formatted phone number (with country prefix)

Full Name = person name or company name

Type = "Person" or "Contact"

IconHint = "Person" or "Contact"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PhoneSearchProvider">PhoneSearchProvider</see> class.
The name of the MDO list is 'phonesearch'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Person only search| |P|
|Company only search| |C|





## Sample Request

```http!
GET /api/v1/MDOList/phonesearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("phonesearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Amadeus AS, AAvdeling 01|Contact|+4701|
|4|Arne'S Kebab, AAvdeling 02|Contact|+4702|
|5|Bjørge AS, BAvdeling 04|Contact|+4704|
|6|Bever Inc, BAvdeling 03|Contact|+4703|
|7|Colina AS, CAvdeling 06|Contact|+4706|
|8|Chevrolet Norge AS, CAvdeling 05|Contact|+4705|
|9|Delta Produkter AS, DAvdeling 12|Contact|+4712|
|10|Dansukker AS, DAvdeling 11|Contact|+4711|
|11|Endorfin Import AS, EAvdeling 14|Contact|+4714|
|12|Elan Hoppski, EAvdeling 13|Contact|+4713|
|13|Fritz & Frantz Import, FAvdeling 16|Contact|+4716|
|14|Familien AS, FAvdeling 15|Contact|+4715|
|15|Galliano Liquer, GAvdeling 21|Contact|+4721|
|16|Golf-Import A/S, GAvdeling 22|Contact|+4722|
|17|Hotel Lord Nelson, HAvdeling 24|Contact|+4724|
|18|Hard Core Imports Inc., HAvdeling 23|Contact|+4723|
|19|Indian Carpets AS, IAvdeling 26|Contact|+4726|
|20|Illinoise Market Fare INC, IAvdeling 25|Contact|+4725|
|20|Arnt Arntsen (Amadeus AS, AAvdeling) 22544545|Person|+4722544545|
|21|Jensen Madrasser, JAvdeling 31|Contact|+4731|
|22|Juul & Hansen AS, JAvdeling 32|Contact|+4732|


## Related MDO Lists

* "phonesearchheadings"
* "phonesearchheadingswithallitem"
* "phonesearchheadingswithallitemwithnoselection"
* "phonesearchheadingswithnoselection"
* "phonesearchwithallitem"
* "phonesearchwithallitemwithnoselection"
* "phonesearchwithnoselection"
