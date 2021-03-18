---
uid: personphone
title: personphone
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

# "personphone" MDO List
Search phone numbers for matching values, restricted to a given company or person.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonPhoneProvider">PersonPhoneProvider</see> class.
The name of the MDO list is 'personphone'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Person id| itemId|23|
|Company id| extraId|23|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/personphone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("personphone", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "personphoneheadings"
* "personphoneheadingswithallitem"
* "personphoneheadingswithallitemwithnoselection"
* "personphoneheadingswithnoselection"
* "personphonewithallitem"
* "personphonewithallitemwithnoselection"
* "personphonewithnoselection"
