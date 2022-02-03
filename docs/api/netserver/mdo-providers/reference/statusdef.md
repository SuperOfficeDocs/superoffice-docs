---
uid: statusdef
title: statusdef
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "statusdef"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "statusdef" MDO List
Return list of status monitors defined in the system.
Additional info query parameter = "Contact" or "project".



Implemented by the <see cref="T:SuperOffice.CRM.Lists.StatusDefProvider">StatusDefProvider</see> class.
The name of the MDO list is 'statusdef'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include deleted records| GetDeletedStatusDefs|True|
|Name of owner table| GetOwnerTable|Project|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/statusdef
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("statusdef", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|C-company||IsVisual=True&OwnerTable=contact&BinaryObjectId=306|
|3|Not completed activites with intention sale||IsVisual=True&OwnerTable=project&BinaryObjectId=445|
|1|Neglected customer||IsVisual=True&OwnerTable=contact&BinaryObjectId=307|


## Related MDO Lists

* "statusdefheadings"
* "statusdefheadingswithallitem"
* "statusdefheadingswithallitemwithnoselection"
* "statusdefheadingswithnoselection"
* "statusdefwithallitem"
* "statusdefwithallitemwithnoselection"
* "statusdefwithnoselection"
