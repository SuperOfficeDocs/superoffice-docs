---
uid: quotedenyreason
title: quotedenyreason
keywords: mdoprovider mdo provider quotedenyreason
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "quotedenyreason" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'quotedenyreason'.




## Sample Request

```http!
GET /api/v1/MDOList/quotedenyreason
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("quotedenyreason", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Customer is not a priority|||
|1|Discounted amount is too high|||
|3|Please adjust and try again|||


## Related MDO Lists

* "quotedenyreasonheadings"
* "quotedenyreasonheadingswithallitem"
* "quotedenyreasonheadingswithallitemwithnoselection"
* "quotedenyreasonheadingswithnoselection"
* "quotedenyreasonwithallitem"
* "quotedenyreasonwithallitemwithnoselection"
* "quotedenyreasonwithnoselection"
