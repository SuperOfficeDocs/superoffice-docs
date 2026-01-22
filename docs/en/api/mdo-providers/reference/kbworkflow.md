---
uid: kbworkflow
title: kbworkflow
keywords: mdoprovider mdo provider kbworkflow
description: MDO list provider for KB Workflow.
generated: true
content_type: reference
envir: onsite, online
---

# "kbworkflow" MDO List
MDO list provider for KB Workflow.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.KbWorkflowProvider">KbWorkflowProvider</see> class.
The name of the MDO list is 'kbworkflow'.




## Sample Request

```http!
GET /api/v1/MDOList/kbworkflow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("kbworkflow", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|Unpublished||previous=-1&next=-2|
|-2|Published||previous=-1&next=-2|
|-3|Expired||previous=-2&next=-3|


## Related MDO Lists

* "kbworkflowheadings"
* "kbworkflowheadingswithallitem"
* "kbworkflowheadingswithallitemwithnoselection"
* "kbworkflowheadingswithnoselection"
* "kbworkflowwithallitem"
* "kbworkflowwithallitemwithnoselection"
* "kbworkflowwithnoselection"
