---
uid: faqcategory
title: faqcategory
keywords: mdoprovider mdo provider faqcategory
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "faqcategory" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.FaqCategoryProvider">FaqCategoryProvider</see> class.
The name of the MDO list is 'faqcategory'.




## Sample Request

```http!
GET /api/v1/MDOList/faqcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("faqcategory", forceFlatList: true);
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

* "faqcategoryheadings"
* "faqcategoryheadingswithallitem"
* "faqcategoryheadingswithallitemwithnoselection"
* "faqcategoryheadingswithnoselection"
* "faqcategorywithallitem"
* "faqcategorywithallitemwithnoselection"
* "faqcategorywithnoselection"
