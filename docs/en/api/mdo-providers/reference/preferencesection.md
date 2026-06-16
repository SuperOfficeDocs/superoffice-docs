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
|1000010|[SR_PD_ccAuthentication_NAME]||ccAuthentication|
|1000007|[SR_PD_Client_NAME]||Client|
|1000545|[SR_PD_Copilot_NAME]||Copilot|
|1000020|[SR_PD_DataCollection_NAME]||DataCollection|
|1000032|[SR_PD_Defaults_NAME]||Defaults|
|1000067|[SR_PD_DiaryView_NAME]||DiaryView|
|1000321|[SR_PD_emailNotification_NAME]||emailNotification|
|1000094|[SR_PD_FilterDialog_NAME]||FilterDialog|
|1000096|[SR_PD_Freetext_NAME]||Freetext|
|1000100|[SR_PD_Functions_NAME]||Functions|
|1000540|[SR_PD_InApp_NAME]||InApp|
|1000155|[SR_PD_Mail_NAME]||Mail|
|1000218|[SR_PD_Mailing_NAME]||Mailing|
|1000226|[SR_PD_MDOList_NAME]||MDOList|
|1000537|[SR_PD_Mirroring_NAME]||Mirroring|
|1000297|[SR_PD_NetServices_NAME]||NetServices|
|1000327|[SR_PD_notification_NAME]||notification|
|1000335|[SR_PD_notificationEmail_NAME]||notificationEmail|
|1000343|[SR_PD_notificationSms_NAME]||notificationSms|
|1000359|[SR_PD_Person_NAME]||Person|
|1000378|[SR_PD_PocketTasks_NAME]||PocketTasks|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
