---
uid: mailingdomains
title: mailingdomains
keywords: mdoprovider mdo provider mailingdomains
description: MDO list provider for Mailing domains, including leading @
generated: true
content_type: reference
envir: onsite, online
---

# "mailingdomains" MDO List
MDO list provider for Mailing domains, including leading @



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingDomainsProvider">MailingDomainsProvider</see> class.
The name of the MDO list is 'mailingdomains'.




## Sample Request

```http!
GET /api/v1/MDOList/mailingdomains
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mailingdomains", forceFlatList: true);
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

* "mailingdomainsheadings"
* "mailingdomainsheadingswithallitem"
* "mailingdomainsheadingswithallitemwithnoselection"
* "mailingdomainsheadingswithnoselection"
* "mailingdomainswithallitem"
* "mailingdomainswithallitemwithnoselection"
* "mailingdomainswithnoselection"
