---
uid: phonesearch
title: phonesearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
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
<para />
id = person or contact id
<para />
Name = company name + phone number or person name + company name + phone number
<para />
ExtraInfo + Tooltip = GSM formatted phone number (with country prefix)
<para />
Full Name = person name or company name
<para />
Type = "Person" or "Contact"
<para />
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
|20|Arnt Arntsen (Amadeus AS, AAvdeling) 22544545|Person|+4722544545|
|23|Britt Bærum (Bever Inc, BAvdeling) 2342354|Person|+472342354|
|25|Bjørn Bjørnsen (Bjørge AS, BAvdeling) 5467546745|Person|+475467546745|
|27|Carl-Oskar Cederström (Chevrolet Norge AS, CAvdeling) 5684564|Person|+475684564|
|29|Cecilie Carlsen (Colina AS, CAvdeling) 56765754|Person|+4756765754|
|31|Dina Didriksen (Dansukker AS, DAvdeling) 675676756|Person|+47675676756|
|33|David Derstad (Delta Produkter AS, DAvdeling) 56784567|Person|+4756784567|
|35|Eva Evaldsson (Elan Hoppski, EAvdeling) 56757547|Person|+4756757547|
|39|Frida Fredriksen (Familien AS, FAvdeling) 56756757|Person|+4756756757|
|41|Fritz Fernley (Fritz & Frantz Import, FAvdeling) 56745674|Person|+4756745674|
|43|Geir Grønbeck (Galliano Liquer, GAvdeling) 56757556|Person|+4756757556|
|45|Guro Gjelsten (Golf-Import A/S, GAvdeling) 5675467|Person|+475675467|
|47|Hilde Hummelvold (Hard Core Imports Inc., HAvdeling) 78678678|Person|+4778678678|
|49|Hans Haugen (Hotel Lord Nelson, HAvdeling) 6786856|Person|+476786856|
|51|Ida Iversen (Illinoise Market Fare INC, IAvdeling) 6785678|Person|+476785678|
|53|Ivar Ivarson (Indian Carpets AS, IAvdeling) 678657856|Person|+47678657856|
|55|Niels Jensen (Jensen Madrasser, JAvdeling) 678657856|Person|+47678657856|
|57|Julie Jansen (Juul & Hansen AS, JAvdeling) 678678567|Person|+47678678567|
|59|Kent Karlsen (Kavaler ASA, KAvdeling) 67865867|Person|+4767865867|
|61|Kristine Krystad (Kongsberg Amunisjon, KAvdeling) 678567857|Person|+47678567857|
|63|Lars Ludvigsen (Lena Trevare AS, LAvdeling) 678657856|Person|+47678657856|


## Related MDO Lists

* "phonesearchheadings"
* "phonesearchheadingswithallitem"
* "phonesearchheadingswithallitemwithnoselection"
* "phonesearchheadingswithnoselection"
* "phonesearchwithallitem"
* "phonesearchwithallitemwithnoselection"
* "phonesearchwithnoselection"
