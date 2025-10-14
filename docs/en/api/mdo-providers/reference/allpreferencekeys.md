---
uid: allpreferencekeys
title: allpreferencekeys
keywords: mdoprovider mdo provider allpreferencekeys
description: MDO Provider that retrieves all preference keys
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("allpreferencekeys", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1000105|Use academic title||[SR_PD_Functions_NAME]|
|1000524|Enable sounds|bold|[SR_PD_Visual_NAME]|
|1000161|Address separator|bold|[SR_PD_Mail_NAME]|
|1000080|Alarm on follow-up||[SR_PD_DiaryView_NAME]|
|1000068|All-day end time|bold|[SR_PD_DiaryView_NAME]|
|1000069|All-day start time|bold|[SR_PD_DiaryView_NAME]|
|1000550|Allow Copilot access to the web.||[SR_PD_Copilot_NAME]|
|1000446|Anonymise users on reply||[SR_PD_serviceSettings_NAME]|
|1000162|Archive sent follow-ups||[SR_PD_Mail_NAME]|
|1000163|Archive sent documents||[SR_PD_Mail_NAME]|
|1000164|Archive forwarded e-mail||[SR_PD_Mail_NAME]|
|1000106|Archive page size||[SR_PD_Functions_NAME]|
|1000165|Archive replies||[SR_PD_Mail_NAME]|
|1000166|Archive all e-mail|bold|[SR_PD_Mail_NAME]|
|1000167|Auto-archive e-mails sent from e-mail client.||[SR_PD_Mail_NAME]|
|1000168|Archive e-mail to associates||[SR_PD_Mail_NAME]|
|1000107|Ask to edit or read||[SR_PD_Functions_NAME]|
|1000169|Use iCalendar attachment||[SR_PD_Mail_NAME]|
|1000388|Automatically close tab when adding a message to request|bold|[SR_PD_request_NAME]|
|1000443|Automatically create contact for new inbound request||[SR_PD_serviceSettings_NAME]|
|1000552|Automatically generate reply to a message||[SR_PD_Copilot_NAME]|


## Related MDO Lists

* "allpreferencekeysheadings"
* "allpreferencekeysheadingswithallitem"
* "allpreferencekeysheadingswithallitemwithnoselection"
* "allpreferencekeysheadingswithnoselection"
* "allpreferencekeyswithallitem"
* "allpreferencekeyswithallitemwithnoselection"
* "allpreferencekeyswithnoselection"
