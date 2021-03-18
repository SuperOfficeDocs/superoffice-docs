---
uid: faqcategory
title: faqcategory
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("faqcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|FAQ|||


## Related MDO Lists

* "faqcategoryheadings"
* "faqcategoryheadingswithallitem"
* "faqcategoryheadingswithallitemwithnoselection"
* "faqcategoryheadingswithnoselection"
* "faqcategorywithallitem"
* "faqcategorywithallitemwithnoselection"
* "faqcategorywithnoselection"
