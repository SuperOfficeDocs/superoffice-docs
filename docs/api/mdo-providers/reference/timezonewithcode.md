---
uid: timezonewithcode
title: timezonewithcode
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

# "timezonewithcode" MDO List
Provides the timezone list. The country code is given in the type field.
If no search value is passed in the list is restricted to 'available' timezones



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TimeZoneWithCodeProvider">TimeZoneWithCodeProvider</see> class.
The name of the MDO list is 'timezonewithcode'.




## Sample Request

```http!
GET /api/v1/MDOList/timezonewithcode
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("timezonewithcode", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|UTC/GMT (GMT+00.00)||0|
|498|Western European Time (GMT+00.00)||0|
|499|Central European Time (GMT+01.00)||0|
|500|Eastern European Time (GMT+02.00)||0|
|2|Afghanistan (GMT+04.30)||4|
|3|Albania (GMT+01.00)||8|
|4|Algeria (GMT+01.00)||12|
|5|American Samoa (GMT-11.00)||16|
|6|Andorra (GMT+01.00)||20|
|7|Angola (GMT+01.00)||24|
|8|Anguilla (GMT-04.00)||660|
|9|Antigua and Barbuda (GMT-04.00)||28|
|10|Buenos Aires (GMT-03.00)||32|
|11|Catamarca (GMT-03.00)||32|
|12|Chaco (GMT-03.00)||32|
|13|Chubut (GMT-03.00)||32|
|14|Ciudad de Buenos Aires (GMT-03.00)||32|
|15|Córdoba (GMT-03.00)||32|
|16|Corrientes (GMT-03.00)||32|
|17|Entre Rios (GMT-03.00)||32|
|18|Formosa (GMT-03.00)||32|


## Related MDO Lists

* "timezonewithcodeheadings"
* "timezonewithcodeheadingswithallitem"
* "timezonewithcodeheadingswithallitemwithnoselection"
* "timezonewithcodeheadingswithnoselection"
* "timezonewithcodewithallitem"
* "timezonewithcodewithallitemwithnoselection"
* "timezonewithcodewithnoselection"
