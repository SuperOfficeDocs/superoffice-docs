---
uid: saintticketcategory
title: saintticketcategory
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

# "saintticketcategory" MDO List
This SoList provider generates the eJournal top-level categories, meant for the saint system



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintTicketCategoryProvider">SaintTicketCategoryProvider</see> class.
The name of the MDO list is 'saintticketcategory'.




## Sample Request

```http!
GET /api/v1/MDOList/saintticketcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saintticketcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|All|||
|1|Support|||
|2|Administration|||
|3|Sale|||


## Related MDO Lists

* "saintticketcategoryheadings"
* "saintticketcategoryheadingswithallitem"
* "saintticketcategoryheadingswithallitemwithnoselection"
* "saintticketcategoryheadingswithnoselection"
* "saintticketcategorywithallitem"
* "saintticketcategorywithallitemwithnoselection"
* "saintticketcategorywithnoselection"
