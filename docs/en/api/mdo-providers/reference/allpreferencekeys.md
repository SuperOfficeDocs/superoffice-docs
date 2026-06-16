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
|1000105|[SR_PD_Functions_AcademicTitle_NAME]||[SR_PD_Functions_NAME]|
|1000525|[SR_PD_Visual_ActiveSound_NAME]|bold|[SR_PD_Visual_NAME]|
|1000161|[SR_PD_Mail_AddressSeparator_NAME]|bold|[SR_PD_Mail_NAME]|
|1000080|[SR_PD_DiaryView_AlarmOnFollowUp_NAME]||[SR_PD_DiaryView_NAME]|
|1000068|[SR_PD_DiaryView_AllDayEndTime_NAME]|bold|[SR_PD_DiaryView_NAME]|
|1000069|[SR_PD_DiaryView_AllDayStartTime_NAME]|bold|[SR_PD_DiaryView_NAME]|
|1000550|[SR_PD_Copilot_allowWebAccess_NAME]||[SR_PD_Copilot_NAME]|
|1000448|[SR_PD_serviceSettings_anonymizeUsersOnReply_NAME]||[SR_PD_serviceSettings_NAME]|
|1000162|[SR_PD_Mail_ArchiveAppointments_NAME]||[SR_PD_Mail_NAME]|
|1000163|[SR_PD_Mail_ArchiveDocuments_NAME]||[SR_PD_Mail_NAME]|
|1000164|[SR_PD_Mail_ArchiveForwards_NAME]||[SR_PD_Mail_NAME]|
|1000106|[SR_PD_Functions_ArchivePageSize_NAME]||[SR_PD_Functions_NAME]|
|1000165|[SR_PD_Mail_ArchiveReplies_NAME]||[SR_PD_Mail_NAME]|
|1000166|[SR_PD_Mail_ArchiveSentMsg_NAME]|bold|[SR_PD_Mail_NAME]|
|1000167|[SR_PD_Mail_ArchiveSentMsgFromMailClient_NAME]||[SR_PD_Mail_NAME]|
|1000168|[SR_PD_Mail_ArchiveToAssocs_NAME]||[SR_PD_Mail_NAME]|
|1000107|[SR_PD_Functions_AskToEditOrRead_NAME]||[SR_PD_Functions_NAME]|
|1000169|[SR_PD_Mail_AttachiCal_NAME]||[SR_PD_Mail_NAME]|
|1000390|[SR_PD_request_autoCloseTab_NAME]|bold|[SR_PD_request_NAME]|
|1000445|[SR_PD_serviceSettings_autoCreatePerson_NAME]||[SR_PD_serviceSettings_NAME]|
|1000552|[SR_PD_Copilot_autoGenerateReply_NAME]||[SR_PD_Copilot_NAME]|


## Related MDO Lists

* "allpreferencekeysheadings"
* "allpreferencekeysheadingswithallitem"
* "allpreferencekeysheadingswithallitemwithnoselection"
* "allpreferencekeysheadingswithnoselection"
* "allpreferencekeyswithallitem"
* "allpreferencekeyswithallitemwithnoselection"
* "allpreferencekeyswithnoselection"
