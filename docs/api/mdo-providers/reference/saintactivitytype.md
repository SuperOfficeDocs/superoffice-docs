---
uid: saintactivitytype
title: saintactivitytype
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

# "saintactivitytype" MDO List
This SoList provider generates the appointment/task type list for the Saint criteria. This is a simple, hard-coded list corresponding
to the type field of the <see cref="!:SuperOffice.CRM.Rows.DocTmpl" /> and <see cref="!:SuperOffice.CRM.Rows.Task" /> tables. Tasks are both
appointments and documents.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintActivityTypeProvider">SaintActivityTypeProvider</see> class.
The name of the MDO list is 'saintactivitytype'.




## Sample Request

```http!
GET /api/v1/MDOList/saintactivitytype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saintactivitytype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|All|||
|1|Follow-up|||
|5|Phone call|||
|6|Task|||
|2|Document|||
|4|Fax|||
|3|E-mail|||
|8|Mail merge|||


## Related MDO Lists

* "saintactivitytypeheadings"
* "saintactivitytypeheadingswithallitem"
* "saintactivitytypeheadingswithallitemwithnoselection"
* "saintactivitytypeheadingswithnoselection"
* "saintactivitytypewithallitem"
* "saintactivitytypewithallitemwithnoselection"
* "saintactivitytypewithnoselection"
