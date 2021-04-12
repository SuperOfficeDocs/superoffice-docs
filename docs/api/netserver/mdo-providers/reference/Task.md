---
uid: task
title: task
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "task"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "task" MDO List
Task table MDO list. Optional include "None" as first value.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TaskProvider">TaskProvider</see> class.
The name of the MDO list is 'task'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include a NO-SELECTION item first| includeNone|True|





## Sample Request

```http!
GET /api/v1/MDOList/task
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("task", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Møte inne|||
|2|Møte ute|||
|3|Telefon ut|||
|4|Telefon inn|||
|5|Oppfølging|||
|6|Planlegging|||
|7|Besøk|||
|8|Lunsj|||
|9|Tilbud|||
|10|Service|||
|11|Privat|||
|12|Annet|||
|13|Messe|||
|14|Kampanje|||


## Related MDO Lists

* "taskheadings"
* "taskheadingswithallitem"
* "taskheadingswithallitemwithnoselection"
* "taskheadingswithnoselection"
* "taskwithallitem"
* "taskwithallitemwithnoselection"
* "taskwithnoselection"
