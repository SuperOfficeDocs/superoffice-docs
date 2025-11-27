---
uid: appointmentfavourites
title: appointmentfavourites
description: 
keywords: appointmentfavourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "appointmentfavourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.AppointmentFavouritesProvider">SuperOffice.CRM.ArchiveLists.AppointmentFavouritesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointment"|Favourite appointment|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|icon|listAny|Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|time| *None* |Time: Time|  |
|type|listAny|Type: Displays the type of an activity| x |
|recordType|string|Record type : Shows the record type| x |
|text|positiveString|Favourite: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|projectId|listAny|Project ID: Database ID of project record| x |
|saleId|int|Sale ID: The database ID of the sale record| x |
|userGroup|userGroup|User group : The user group that owns the record| x |
|who| *None* |Who: Contact and/or company|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointmentId|int|DB ID: Displays the database ID of a row| x |
|endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|priority|listAny|Priority: Displays the priority of the activity| x |
|alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|isFree|bool|Is free: Displays whether the appointment should be considered free or busy| x |
|recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|intention|listAny|Intention: Displays the intention of the follow-up type| x |
|location|string|Location: Display the location where the follow-up will take place.| x |
|recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up| x |
|rawType|int|Type: Type field for appointment, not decoded or formatted| x |
|rawStatus|int|Status: Status field for the follow-up, not decoded or formatted| x |
|cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?| x |
|endTime| *None* |End time: End time of an activity|  |
|suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|recordTypeText|listAny|Activity type: The type of the activity (appointment, phone call, etc)| x |
|joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|duration|timeSpan|Duration: The duration of the chat session|  |
|createdByWorkflow|listAny|Created by flow: Created by flow| x |
|entityIcon| *None* |Row specific icon: Row specific icon| x |
|favouriteAssociateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|visibleFor|listAny|Visible for|  |
|appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|appointmentUdef/SuperOffice:3|int|followupnumber| x |
|appointmentUdef/SuperOffice:4|date|followupdate| x |
|appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|associate/firstName|string|First name: Displays the contact's first name| x |
|associate/lastName|string|Last name: Displays the contact's last name| x |
|associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|associate/personId|int|Contact ID: Database ID of the contact row|  |
|associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|associate/associateDbId|associate|ID| x |
|associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|associate/usergroupId|int|Group ID: The user's primary user group| x |
|associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|associate/contactCategory|listAny|Category: Category| x |
|associate/role|listAny|Role : Role| x |
|associate/assocName|associate|User ID : User ID| x |
|associate/assocTooltip|string|Description : Description|  |
|associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|associate/portraitThumbnail| *None* |Person image: Person image|  |
|associate/otherGroups|userGroup|Other groups: Other groups|  |
|associate/userName|string|User name: User name| x |
|associate/personEmail|string|E-mail| x |
|associate/locationAddress|string|Location: Location| x |
|associate/isLocation|bool|Is a location: Is a location| x |
|appointment/description|positiveString|Text: Displays the text entered in the description field| x |
|appointment/title|positiveString|Title| x |
|appointment/titleHtml| *None* |!!Title Html| x |
|appointment/agenda|positiveString|Agenda| x |
|appointment/agendaHtml| *None* |!!Agenda Html| x |
|appointment/isConverted| *None* |!!Is Converted|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/textId|int|Text ID| x |
|appointment/internalNotes|positiveString|Internal notes: Displays the text entered in the description field| x |
|appointment/internalNotesHtml|positiveString|!!Internal Notes Html| x |

## Sample

```http!
GET /api/v1/archive/appointmentfavourites?$select=associate/lastName,associate/locationAddress,cautionWarning
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

