---
uid: documentcategory
title: documentcategory
keywords: mdoprovider mdo provider documentcategory
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "documentcategory" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentCategoryListProvider">DocumentCategoryListProvider</see> class.
The name of the MDO list is 'documentcategory'.




## Sample Request

```http!
GET /api/v1/MDOList/documentcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documentcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|E-mail|||
|2|Document|||


## Related MDO Lists

* "documentcategoryheadings"
* "documentcategoryheadingswithallitem"
* "documentcategoryheadingswithallitemwithnoselection"
* "documentcategoryheadingswithnoselection"
* "documentcategorywithallitem"
* "documentcategorywithallitemwithnoselection"
* "documentcategorywithnoselection"
