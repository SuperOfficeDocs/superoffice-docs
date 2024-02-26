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
|1000003|Customer Centre password policy||ccAuthentication|
|1000013|Statistics||DataCollection|
|1000025|Default values||Defaults|
|1000060|Diary||DiaryView|
|1000086|Filter Dialog||FilterDialog|
|1000088|Freetext search||Freetext|
|1000096|Functions||Functions|
|1000531|In-app communication||InApp|
|1000151|E-mail||Mail|
|1000213|Marketing||Mailing|
|1000219|Grouped lists||MDOList|
|1000528|Data mirroring||Mirroring|
|1000290|Web Services||NetServices|
|1000318|Notifications via popup||notification|
|1000326|Notifications via e-mail||notificationEmail|
|1000334|Notifications via SMS||notificationSms|
|1000350|Contact||Person|
|1000369|Mobile CRM||PocketTasks|
|1000373|Request||request|
|1000393|Sale||Sale|
|1000309|Notifications for appointments||salesNotification|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
