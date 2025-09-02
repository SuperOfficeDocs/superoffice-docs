---
uid: replytemplate
title: replytemplate
keywords: mdoprovider mdo provider replytemplate
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "replytemplate" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ReplyTemplateProvider">ReplyTemplateProvider</see> class.
The name of the MDO list is 'replytemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/replytemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("replytemplate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|13|Example of an automated FAQ response|||
|15|System Template - A request in the favourites list has been activated|||
|17|System Template - A request in the favourites list has been reassigned|||
|16|System Template - A request in the favourites list has escalated|||
|21|System template – chat log|||
|19|System template - confirm customer email|||
|3|System template - customer password|||
|2|System template - customer reply|||
|1|System template - new customer|||
|22|System template - new link|||
|5|System template - new message|||
|14|System Template - New Message in the favourites list|||
|8|System template - new request|||
|4|System template - open requests|||
|11|System template - publish FAQ answer|||
|10|System template - publish FAQ question|||
|6|System template - request activated|||
|7|System template - request escalated|||
|9|System template - request taken over|||
|18|System template - warning of expiring licence|||
|12|System template - weekly statistics|||


## Related MDO Lists

* "replytemplateheadings"
* "replytemplateheadingswithallitem"
* "replytemplateheadingswithallitemwithnoselection"
* "replytemplateheadingswithnoselection"
* "replytemplatewithallitem"
* "replytemplatewithallitemwithnoselection"
* "replytemplatewithnoselection"
