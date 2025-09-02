---
uid: form
title: form
keywords: mdoprovider mdo provider form
description: Get all forms with folder hierarchy. Set ExtraInfo "onlyActive=true" if you only want to get active forms and "onlyNewTicket=true" if only forms that create tickets. Set extrainfo "onlyForms=true" if you do not want form templates.
generated: true
content_type: reference
envir: onsite, online
---

# "form" MDO List
Get all forms with folder hierarchy.
Set ExtraInfo "onlyActive=true" if you only want to get active forms and "onlyNewTicket=true" if only forms that create tickets.
Set extrainfo "onlyForms=true" if you do not want form templates.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FormProvider">FormProvider</see> class.
The name of the MDO list is 'form'.




## Sample Request

```http!
GET /api/v1/MDOList/form
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("form", forceFlatList: true);
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

* "formheadings"
* "formheadingswithallitem"
* "formheadingswithallitemwithnoselection"
* "formheadingswithnoselection"
* "formwithallitem"
* "formwithallitemwithnoselection"
* "formwithnoselection"
