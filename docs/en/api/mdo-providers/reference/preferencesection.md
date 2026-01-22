---
uid: preferencesection
title: preferencesection
keywords: mdoprovider mdo provider preferencesection
description: MDO Provider that retrieves a list of preference sections
generated: true
content_type: reference
envir: onsite, online
---

# "preferencesection" MDO List
MDO Provider that retrieves a list of preference sections

Preferences are described in the prefdesc table. This provider will retrieve descriptions for all sections.


Each item contains the programmatic section name in the extraInfo field.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PreferenceSectionProvider">PreferenceSectionProvider</see> class.
The name of the MDO list is 'preferencesection'.




## Sample Request

```http!
GET /api/v1/MDOList/preferencesection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("preferencesection", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1000010|Customer Centre password policy||ccAuthentication|
|1000007|Client||Client|
|1000551|SuperOffice Copilot||Copilot|
|1000020|Statistics||DataCollection|
|1000032|Default values||Defaults|
|1000067|Diary||DiaryView|
|1000325|Notifications for e-mail||emailNotification|
|1000094|Filter Dialog||FilterDialog|
|1000096|Freetext search||Freetext|
|1000104|Functions||Functions|
|1000546|In-app communication||InApp|
|1000159|E-mail||Mail|
|1000222|Marketing||Mailing|
|1000230|Grouped lists||MDOList|
|1000543|Data mirroring||Mirroring|
|1000301|Web Services||NetServices|
|1000331|Notifications via popup||notification|
|1000339|Notifications via e-mail||notificationEmail|
|1000347|Notifications via SMS||notificationSms|
|1000363|Contact||Person|
|1000382|Mobile CRM||PocketTasks|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
