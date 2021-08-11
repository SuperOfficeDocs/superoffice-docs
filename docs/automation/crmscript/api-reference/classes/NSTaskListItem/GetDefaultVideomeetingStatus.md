---
uid: crmscript_ref_NSTaskListItem_GetDefaultVideomeetingStatus
title: Integer GetDefaultVideomeetingStatus()
intellisense: NSTaskListItem.GetDefaultVideomeetingStatus
keywords: NSTaskListItem, GetDefaultVideomeetingStatus
so.topic: reference
---

# Integer GetDefaultVideomeetingStatus()

Default video-meeting status for meetings created in SuperOffice CRM.

**Returns:** Integer

     - Enum: 0 = NoChange 
     - Enum: 1 = VideoMeetingOn 
     - Enum: 2 = VideoMeetingOff 

```crmscript
NSTaskListItem thing;
Integer defaultVideomeetingStatus  = thing.GetDefaultVideomeetingStatus();
```

