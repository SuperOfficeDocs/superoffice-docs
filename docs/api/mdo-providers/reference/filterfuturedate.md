---
uid: filterfuturedate
title: filterfuturedate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "filterfuturedate"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "filterfuturedate" MDO List
MDO provider for the hard-coded list of future date alternatives in the Filter dialog.
Each items' extraInfo contains the number of days into the future that this choice represents,
slightly simplified (30 days per month and no leap years).



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FilterFutureDateList">FilterFutureDateList</see> class.
The name of the MDO list is 'filterfuturedate'.




## Sample Request

```http!
GET /api/v1/MDOList/filterfuturedate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("filterfuturedate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|+3 Months||90|
|2|+4 Months||120|
|3|+6 Months||180|
|4|+1 Year||365|
|5|+2 Years||730|


## Related MDO Lists

* "filterfuturedateheadings"
* "filterfuturedateheadingswithallitem"
* "filterfuturedateheadingswithallitemwithnoselection"
* "filterfuturedateheadingswithnoselection"
* "filterfuturedatewithallitem"
* "filterfuturedatewithallitemwithnoselection"
* "filterfuturedatewithnoselection"
