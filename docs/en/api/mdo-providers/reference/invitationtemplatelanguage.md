---
uid: invitationtemplatelanguage
title: invitationtemplatelanguage
keywords: mdoprovider mdo provider invitationtemplatelanguage
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "invitationtemplatelanguage" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.InvitationTemplateLanguageProvider">InvitationTemplateLanguageProvider</see> class.
The name of the MDO list is 'invitationtemplatelanguage'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Appointment-id| appointmentId|0|





## Sample Request

```http!
GET /api/v1/MDOList/invitationtemplatelanguage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("invitationtemplatelanguage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Default||DEFAULT|


## Related MDO Lists

* "invitationtemplatelanguageheadings"
* "invitationtemplatelanguageheadingswithallitem"
* "invitationtemplatelanguageheadingswithallitemwithnoselection"
* "invitationtemplatelanguageheadingswithnoselection"
* "invitationtemplatelanguagewithallitem"
* "invitationtemplatelanguagewithallitemwithnoselection"
* "invitationtemplatelanguagewithnoselection"
