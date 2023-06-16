---
uid: allpreferencekeys
title: allpreferencekeys
keywords: mdoprovider mdo provider allpreferencekeys
description: MDO Provider that retrieves all preference keys
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "allpreferencekeys" MDO List
MDO Provider that retrieves all preference keys

All preferences that are not sections are returned, grouped alphabetically.
If addidionalInfo is OrderBySection, it is first grouped alphabetically by section.
Preferences that have list of values are bolded.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.AllPreferenceKeysProvider">AllPreferenceKeysProvider</see> class.
The name of the MDO list is 'allpreferencekeys'.




## Sample Request

```http!
GET /api/v1/MDOList/allpreferencekeys
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("allpreferencekeys", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1000097|Use academic title||[SR_PD_Functions_NAME]|
|1000499|Enable sounds|bold|[SR_PD_Visual_NAME]|
|1000151|Address separator|bold|[SR_PD_Mail_NAME]|
|1000074|Alarm on follow-up||[SR_PD_DiaryView_NAME]|
|1000061|All-day end time|bold|[SR_PD_DiaryView_NAME]|
|1000062|All-day start time|bold|[SR_PD_DiaryView_NAME]|
|1000152|Archive sent appointments||[SR_PD_Mail_NAME]|
|1000153|Archive sent documents||[SR_PD_Mail_NAME]|
|1000154|Archive forwarded e-mail||[SR_PD_Mail_NAME]|
|1000098|Archive page size||[SR_PD_Functions_NAME]|
|1000155|Archive replies||[SR_PD_Mail_NAME]|
|1000156|Archive all e-mail|bold|[SR_PD_Mail_NAME]|
|1000157|Auto-archive e-mails sent from e-mail client.||[SR_PD_Mail_NAME]|
|1000158|Archive e-mail to associates||[SR_PD_Mail_NAME]|
|1000099|Ask to edit or read||[SR_PD_Functions_NAME]|
|1000159|Use iCalendar attachment||[SR_PD_Mail_NAME]|
|1000367|Automatically close tab when adding a message to request||[SR_PD_request_NAME]|
|1000401|Automatically create contact for new inbound request||[SR_PD_serviceSettings_NAME]|
|1000100|Limit for auto-loading||[SR_PD_Functions_NAME]|
|1000360|Autologout time||[SR_PD_PocketTasks_NAME]|
|1000370|Automatically quote the last message||[SR_PD_request_NAME]|


## Related MDO Lists

* "allpreferencekeysheadings"
* "allpreferencekeysheadingswithallitem"
* "allpreferencekeysheadingswithallitemwithnoselection"
* "allpreferencekeysheadingswithnoselection"
* "allpreferencekeyswithallitem"
* "allpreferencekeyswithallitemwithnoselection"
* "allpreferencekeyswithnoselection"
