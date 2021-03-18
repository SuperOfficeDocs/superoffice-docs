---
uid: ejcategory
title: ejcategory
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
|2|Administration||parentId=0|
|4|Administration/Accounting||parentId=2|
|7|Administration/Accounting/Fraud||parentId=4|
|9|Administration/Accounting/Fraud/Serious||parentId=7|
|10|Administration/Accounting/Fraud/Silly||parentId=7|
|8|Administration/Accounting/Overdue||parentId=4|
|11|Administration/Accounting/Overdue/Long||parentId=8|
|13|Administration/Catering||parentId=2|
|12|Administration/IT||parentId=2|
|3|Sale||parentId=0|
|1|Support||parentId=0|
|6|Support/On-line||parentId=1|
|5|Support/Out-call||parentId=1|


## Related MDO Lists

* "ejcategoryheadings"
* "ejcategoryheadingswithallitem"
* "ejcategoryheadingswithallitemwithnoselection"
* "ejcategoryheadingswithnoselection"
* "ejcategorywithallitem"
* "ejcategorywithallitemwithnoselection"
* "ejcategorywithnoselection"
