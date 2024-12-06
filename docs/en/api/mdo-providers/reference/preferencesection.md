---
uid: preferencesection
title: preferencesection
keywords: mdoprovider mdo provider preferencesection
description: MDO Provider that retrieves a list of preference sections
so.generated: true
so.topic: reference
so.envir: onsite, online
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("preferencesection", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1000007|Customer Centre password policy||ccAuthentication|
|1000017|Statistics||DataCollection|
|1000029|Default values||Defaults|
|1000064|Diary||DiaryView|
|1000090|Filter Dialog||FilterDialog|
|1000092|Freetext search||Freetext|
|1000100|Functions||Functions|
|1000536|In-app communication||InApp|
|1000155|E-mail||Mail|
|1000217|Marketing||Mailing|
|1000223|Grouped lists||MDOList|
|1000533|Data mirroring||Mirroring|
|1000294|Web Services||NetServices|
|1000322|Notifications via popup||notification|
|1000330|Notifications via e-mail||notificationEmail|
|1000338|Notifications via SMS||notificationSms|
|1000354|Contact||Person|
|1000373|Mobile CRM||PocketTasks|
|1000377|Request||request|
|1000398|Sale||Sale|
|1000313|Notifications for appointments||salesNotification|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
