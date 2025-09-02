---
uid: comptr
title: comptr
keywords: mdoprovider mdo provider comptr
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "comptr" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'comptr'.




## Sample Request

```http!
GET /api/v1/MDOList/comptr
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("comptr", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|"Dobbelfnutt|||
|3|*Star Company|||
|2|800 Grader|||
|1|Ülwa Nowèn AB|||


## Related MDO Lists

* "comptrheadings"
* "comptrheadingswithallitem"
* "comptrheadingswithallitemwithnoselection"
* "comptrheadingswithnoselection"
* "comptrwithallitem"
* "comptrwithallitemwithnoselection"
* "comptrwithnoselection"
