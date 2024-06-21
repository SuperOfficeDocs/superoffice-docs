---
uid: quoteapprovalassociate
title: quoteapprovalassociate
keywords: mdoprovider mdo provider quoteapprovalassociate
description: MDO provider for associates that are allowed to approve a quote.
generated: true
topic: reference
envir: onsite, online
---

# "quoteapprovalassociate" MDO List
MDO provider for associates that are allowed to approve a quote.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteApprovalAssociateMDOProvider">QuoteApprovalAssociateMDOProvider</see> class.
The name of the MDO list is 'quoteapprovalassociate'.




## Sample Request

```http!
GET /api/v1/MDOList/quoteapprovalassociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quoteapprovalassociate", forceFlatList: true);
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

* "quoteapprovalassociateheadings"
* "quoteapprovalassociateheadingswithallitem"
* "quoteapprovalassociateheadingswithallitemwithnoselection"
* "quoteapprovalassociateheadingswithnoselection"
* "quoteapprovalassociatewithallitem"
* "quoteapprovalassociatewithallitemwithnoselection"
* "quoteapprovalassociatewithnoselection"
