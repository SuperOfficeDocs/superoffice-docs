---
uid: quoteapprreason
title: quoteapprreason
keywords: mdoprovider mdo provider quoteapprreason
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "quoteapprreason" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'quoteapprreason'.




## Sample Request

```http!
GET /api/v1/MDOList/quoteapprreason
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("quoteapprreason", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Anything to make this customer happy|||
|1|Go ahead|||
|2|Only this time|||
|4|Yes|||


## Related MDO Lists

* "quoteapprreasonheadings"
* "quoteapprreasonheadingswithallitem"
* "quoteapprreasonheadingswithallitemwithnoselection"
* "quoteapprreasonheadingswithnoselection"
* "quoteapprreasonwithallitem"
* "quoteapprreasonwithallitemwithnoselection"
* "quoteapprreasonwithnoselection"
