---
uid: saintdirection
title: saintdirection
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "saintdirection"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "saintdirection" MDO List
This SoList provider generates the appointment/task direction list for the Saint criteria. This is a simple, hard-coded list corresponding
to the direction field of the <see cref="!:SuperOffice.CRM.Rows.DocTmpl" /> and <see cref="!:SuperOffice.CRM.Rows.Task" /> tables. Tasks are both
appointments and documents.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintDirectionProvider">SaintDirectionProvider</see> class.
The name of the MDO list is 'saintdirection'.




## Sample Request

```http!
GET /api/v1/MDOList/saintdirection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saintdirection", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|All|||
|1|Incoming|||
|2|Outgoing|||


## Related MDO Lists

* "saintdirectionheadings"
* "saintdirectionheadingswithallitem"
* "saintdirectionheadingswithallitemwithnoselection"
* "saintdirectionheadingswithnoselection"
* "saintdirectionwithallitem"
* "saintdirectionwithallitemwithnoselection"
* "saintdirectionwithnoselection"
