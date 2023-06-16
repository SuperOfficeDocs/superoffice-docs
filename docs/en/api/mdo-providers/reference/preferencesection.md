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
<para />
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
|1000519|In-app communication||InApp|
|1000150|E-mail||Mail|
|1000212|Marketing||Mailing|
|1000218|Grouped lists||MDOList|
|1000516|Data mirroring||Mirroring|
|1000289|Web Services||NetServices|
|1000308|Notifications via popup||notification|
|1000316|Notifications via e-mail||notificationEmail|
|1000324|Notifications via SMS||notificationSms|
|1000340|Contact||Person|
|1000359|Mobile CRM||PocketTasks|
|1000363|Request||request|
|1000383|Sale||Sale|
|1000400|SuperOffice Service system settings||serviceSettings|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
