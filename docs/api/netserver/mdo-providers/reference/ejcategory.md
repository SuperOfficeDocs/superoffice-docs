---
uid: ejcategory
title: ejcategory
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ejcategory"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ejcategory" MDO List
EjCategoryProvider creates a flat or tree list based on the table: EJ_CATEGORY



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EjCategoryProvider">EjCategoryProvider</see> class.
The name of the MDO list is 'ejcategory'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Use hierarchy| hierarchy|true|
|Return short names instead of full path| shortNames|false|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/ejcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ejcategory", forceFlatList: true);
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

* "ejcategoryheadings"
* "ejcategoryheadingswithallitem"
* "ejcategoryheadingswithallitemwithnoselection"
* "ejcategoryheadingswithnoselection"
* "ejcategorywithallitem"
* "ejcategorywithallitemwithnoselection"
* "ejcategorywithnoselection"
