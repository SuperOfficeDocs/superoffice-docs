---
uid: archiveprovider
title: archiveprovider
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "archiveprovider"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "archiveprovider" MDO List
MDO provider for available archive providera.
The items will be added by scanning ArchiveProviderFactory.KnownArchiveProviders for this pattern;



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ArchiveProviderList">ArchiveProviderList</see> class.
The name of the MDO list is 'archiveprovider'.




## Sample Request

```http!
GET /api/v1/MDOList/archiveprovider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("archiveprovider", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Document||Document|
|1|Appointment||Appointment|
|2|Sale||Sale|


## Related MDO Lists

* "archiveproviderheadings"
* "archiveproviderheadingswithallitem"
* "archiveproviderheadingswithallitemwithnoselection"
* "archiveproviderheadingswithnoselection"
* "archiveproviderwithallitem"
* "archiveproviderwithallitemwithnoselection"
* "archiveproviderwithnoselection"
