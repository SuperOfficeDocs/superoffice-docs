---
uid: emailreplytotype
title: emailreplytotype
keywords: mdoprovider mdo provider emailreplytotype
description: MDO provider for the EmailReplyToType enum
generated: true
content_type: reference
envir: onsite, online
---

# "emailreplytotype" MDO List
MDO provider for the EmailReplyToType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailReplyToTypeProvider">EmailReplyToTypeProvider</see> class.
The name of the MDO list is 'emailreplytotype'.




## Sample Request

```http!
GET /api/v1/MDOList/emailreplytotype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("emailreplytotype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Always use:|||
|1|Use our contact where specified, otherwise use:|||
|2|Use our support contact where specified, otherwise use:|||
|3|Use 'From' as 'Reply' address|||


## Related MDO Lists

* "emailreplytotypeheadings"
* "emailreplytotypeheadingswithallitem"
* "emailreplytotypeheadingswithallitemwithnoselection"
* "emailreplytotypeheadingswithnoselection"
* "emailreplytotypewithallitem"
* "emailreplytotypewithallitemwithnoselection"
* "emailreplytotypewithnoselection"
