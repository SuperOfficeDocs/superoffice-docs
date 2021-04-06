---
uid: crmscript_ref_NSTaskListItem_SetDefaultVideomeetingStatus
title: SetDefaultVideomeetingStatus(Integer defaultVideomeetingStatus)
intellisense: NSTaskListItem.SetDefaultVideomeetingStatus
keywords: NSTaskListItem, GetDefaultVideomeetingStatus
so.topic: reference
---

Default video-meeting status for meetings created in SuperOffice CRM.

**Parameter:** 
 - **defaultVideomeetingStatus** Integer
     - Enum: 0 = NoChange 
     - Enum: 1 = VideoMeetingOn 
     - Enum: 2 = VideoMeetingOff 

```crmscript
NSTaskListItem thing;
Integer defaultVideomeetingStatus;
thing.SetDefaultVideomeetingStatus(defaultVideomeetingStatus);
```

