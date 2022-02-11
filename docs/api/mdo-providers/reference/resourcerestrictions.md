---
uid: resourcerestrictions
title: resourcerestrictions
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "resourcerestrictions"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "resourcerestrictions" MDO List
MDO provider for resources (from the associate table) that uses restrictions to include
conflict checking



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ResourceRestrictionsMDOProvider">ResourceRestrictionsMDOProvider</see> class.
The name of the MDO list is 'resourcerestrictions'.




## Sample Request

```http!
GET /api/v1/MDOList/resourcerestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("resourcerestrictions", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|41|ResourceItem 1: No heading|||
|42|ResourceItem 2: No heading|||
|43|ResourceItem 3: No heading|||
|79|ResourceItem 12: Heading 1 og 3|||
|44|ResourceItem 4: Heading 1|||
|45|ResourceItem 5: Heading 1|||
|46|ResourceItem 6: Heading 1|||
|80|ResourceItem 13: Heading 2 og 3|||
|47|ResourceItem 7: Heading 2|||
|48|ResourceItem 8: Heading 2|||
|49|ResourceItem 9: Heading 2|||
|50|ResourceItem 10: Heading 3|||
|51|ResourceItem 11: Heading 3|||


## Related MDO Lists

* "resourcerestrictionsheadings"
* "resourcerestrictionsheadingswithallitem"
* "resourcerestrictionsheadingswithallitemwithnoselection"
* "resourcerestrictionsheadingswithnoselection"
* "resourcerestrictionswithallitem"
* "resourcerestrictionswithallitemwithnoselection"
* "resourcerestrictionswithnoselection"
