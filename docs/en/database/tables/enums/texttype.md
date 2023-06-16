---
uid: enum-texttype
title: Enum values for TextType
description: Lists the enum values for TextType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TextType Enum

Text type, enum that specifies owning table and role

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing|
|ContactInfo|1|A Post-it (paperclip) on the  contact card|
|PersonInfo|2|A Post-it in the person dialog, shown as a descriptive text box in the info panel|
|Reserved1|3|PersonEmail - currently not in use (4.5 legacy, removed by conversion program)|
|AppointmentText|4|Descriptive text area in the appointment dialog. |
|DocumentText|5|Document optional long description (keywords). Owner is document.|
|ProjectText|6|Descriptive text area on the project card. |
|SaleText|7|Descriptive text area in the sale dialog.|
|Notepad|8|Personal notepad as used extensively in 4.5.  |
|Reserved2|9|MailAppointmentText - currently not in use (4.5 legacy, removed by conversion program)|
|Reserved3|10|ContactUrl - currently not in use (4.5 legacy, removed by conversion program)|
|ProjectInfo|11|A Post-it (paperclip) on the project card. |
|SelectionInfo|12|A Post-it (paperclip) on the selection card. |
|ProjectMemberText|13|Descriptive text area in the project member dialog. |
|SelectionText|14|Descriptive text area on the selection card. |
|DayInfo|15|A Post-it attached to a specific day (via an appointment)|
|LongPreference|16|Extra information for a saved set of search criteria|
|SearchCriteriaInfo|17|Extra information for a saved search criteria subgroup|
|SearchCriteriaGroupInfo|18|Extra information about a user role|
|RoleInfo|19|Extra information about a user role|
|UdefListSQL|20|SQL text to be executed when populating a user-defined fields' drop-down box|
|StatusMonitorInfo|21|Extra information about a status monitor (linked to statusdef)|
|AudienceSignOnConfirmation|22|Confirmation text to be shown to users who 'sign on' to an event, in Audience|
|AudienceSignOffConfirmation|23|Confirmation text to be shown to users who 'sign off' from an event, in Audience|
|StatusMonitorDefaultTaskText|24|Default task text for new tasks created in response to a status monitor watermark (linked to statusdef)|
|SaleInfo|25|A Post-it (paperclip) on the Sale panel|
|NameExtension|26|Extension of NAME of MDO list|
|TooltipExtension|27|Extension of TOOLTIP of MDO list|

## Usage

* [text](../text.md).type - Long text fields from all over the system
