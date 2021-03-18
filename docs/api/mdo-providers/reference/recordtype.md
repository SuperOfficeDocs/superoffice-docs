---
uid: recordtype
title: recordtype
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

# "recordtype" MDO List
A complete and generic mapping of record types to resource strings.
This is a simple, hard-coded list corresponding to Task table <see cref="!:SuperOffice.CRM.Data.Task" /> record_type column which is defined by a typed field <see cref="T:SuperOffice.Data.SQL.TaskTypeFieldInfo" /> using the TaskType enum AN.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.RecordTypeProvider">RecordTypeProvider</see> class.
The name of the MDO list is 'recordtype'.




## Sample Request

```http!
GET /api/v1/MDOList/recordtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("recordtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Unknown|||
|1|Appointment|||
|2|Document|||
|3|E-mail|||
|4|Fax|||
|5|Phone call|||
|6|Task|||
|7|Mail merge|||
|8|Mail merge|||
|9|Report|||
|10|Sales Intelligence (SAINT)|||
|100|Mailing|||
|200|Chat session|||
|300|Form submission|||


## Related MDO Lists

* "recordtypeheadings"
* "recordtypeheadingswithallitem"
* "recordtypeheadingswithallitemwithnoselection"
* "recordtypeheadingswithnoselection"
* "recordtypewithallitem"
* "recordtypewithallitemwithnoselection"
* "recordtypewithnoselection"
