---
uid: resourcerestrictions
title: resourcerestrictions
keywords: mdoprovider mdo provider resourcerestrictions
description: MDO provider for resources (from the associate table) that uses restrictions to include conflict checking
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("resourcerestrictions", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|41|ResourceItem 1: No heading||person_id=0&contact_id=0|
|42|ResourceItem 2: No heading||person_id=0&contact_id=0|
|43|ResourceItem 3: No heading||person_id=0&contact_id=0|
|79|ResourceItem 12: Heading 1 og 3||person_id=0&contact_id=0|
|44|ResourceItem 4: Heading 1||person_id=0&contact_id=0|
|45|ResourceItem 5: Heading 1||person_id=0&contact_id=0|
|46|ResourceItem 6: Heading 1||person_id=0&contact_id=0|
|80|ResourceItem 13: Heading 2 og 3||person_id=0&contact_id=0|
|47|ResourceItem 7: Heading 2||person_id=0&contact_id=0|
|48|ResourceItem 8: Heading 2||person_id=0&contact_id=0|
|49|ResourceItem 9: Heading 2||person_id=0&contact_id=0|
|50|ResourceItem 10: Heading 3||person_id=0&contact_id=0|
|51|ResourceItem 11: Heading 3||person_id=0&contact_id=0|


## Related MDO Lists

* "resourcerestrictionsheadings"
* "resourcerestrictionsheadingswithallitem"
* "resourcerestrictionsheadingswithallitemwithnoselection"
* "resourcerestrictionsheadingswithnoselection"
* "resourcerestrictionswithallitem"
* "resourcerestrictionswithallitemwithnoselection"
* "resourcerestrictionswithnoselection"
