---
uid: archiveprovider
title: archiveprovider
keywords: mdoprovider mdo provider archiveprovider
description: MDO provider for available archive providers for Configurable screens. The items will be added by scanning ArchiveProviderFactory.KnownArchiveProviders for this pattern;
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "archiveprovider" MDO List
MDO provider for available archive providers for Configurable screens.
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
|0|Appointment||ProviderName=ConfigurableArchiveAppointment|
|1|Document||ProviderName=Document|
|2|QuoteLineConfiguration||ProviderName=QuoteLineConfiguration|
|3|Sale||ProviderName=Sale|


## Related MDO Lists

* "archiveproviderheadings"
* "archiveproviderheadingswithallitem"
* "archiveproviderheadingswithallitemwithnoselection"
* "archiveproviderheadingswithnoselection"
* "archiveproviderwithallitem"
* "archiveproviderwithallitemwithnoselection"
* "archiveproviderwithnoselection"
