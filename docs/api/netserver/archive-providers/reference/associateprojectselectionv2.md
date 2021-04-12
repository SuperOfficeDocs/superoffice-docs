---
uid: AssociateProjectSelectionV2
title: AssociateProjectSelectionV2
description: This is the archive Provider for the Selection Project archive.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "AssociateProjectSelectionV2"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "AssociateProjectSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.AssociateProjectSelectionProviderV2">SuperOffice.CRM.ArchiveLists.Archive.AssociateProjectSelectionProviderV2</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the Selection Project archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"project"|Project|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|projectId|int|DB ID: Displays the database ID for a project row| x |
|name|stringorPK|Project name: Displays the Project's name| x |
|number|string|Number: Displays the project's number| x |
|type|listAny|Project type: Displays the project's type| x |
|status|listAny|Status: Displays the project's status| x |
|associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|string|Text: Displays a descriptive text for the item| x |
|description|string|Description : Description| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|endDate|date|End date: End date of project| x |
|imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|projectEvent/eventDate|date|Event date: Event date| x |
|projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|projectUrl/URLAddress|string|URL| x |
|projectUrl/URLDescription|string|Description| x |
|projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|projectAssociate/associateDbId|associate|ID| x |
|projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|projectAssociate/contactCategory|listAny|Category: Category| x |
|projectAssociate/role|listAny|Role : Role| x |
|projectAssociate/assocName|associate|User ID : User ID| x |
|projectAssociate/assocTooltip|string|Description : Description|  |
|projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|projectAssociate/userName|string|User name: User name| x |
|projectAssociate/personEmail|string|E-mail| x |
|projectUdef/SuperOffice:1|string|projectshorttext| x |
|projectUdef/SuperOffice:2|string|projectlongtext| x |
|projectUdef/SuperOffice:3|int|projectnumber| x |
|projectUdef/SuperOffice:4|date|projectdate| x |
|projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|NumberOfActivities|int|Number of activities|  |
|NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|LastActivity|date|Date of last activity|  |
|LastCompletedActivity|date|Date of last completed activity|  |
|LastDoByActivity|date|Date of last non-completed activity|  |
|NumberOfSales|int|Number of sales|  |
|NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|LastSale|date|Date of last sale|  |
|LastCompletedSale|date|Date of last completed sale|  |
|LastDoBySale|date|Date of last non-completed sale|  |
|SaintStatus3|saintStatus|Not completed activites with intention sale|  |
|saintSaleStatus|listAny|With status|  |
|saintAmountClass|listAny|Amount class|  |
|saintActivityType|listAny|SAINT type|  |
|saintDirection|listAny|Direction|  |
|saintIntention|listAny|Intention|  |
|saintTicketStatus|listAny|Status|  |
|saintTicketCategory|listAny|Category|  |
|sale/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|sale/icon| *None* |Category: Displays the icon for an activity type| x |
|sale/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|sale/time| *None* |Time: Time|  |
|sale/type|listAny|Type: Displays the type of an activity| x |
|sale/recordType|string|Record type : Shows the record type| x |
|sale/text|positiveString|Text: Displays a descriptive text for the item| x |
|sale/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|sale/contactId|listAny|Company ID: Database ID of company| x |
|sale/personId|listAny|Contact ID: Database ID of the contact row| x |
|sale/projectId|listAny|Project ID: Database ID of project record| x |
|sale/saleId|int|Sale ID: The database ID of the sale record| x |
|sale/userGroup|userGroup|User group : The user group that owns the record| x |
|sale/who| *None* |Who: Contact and/or company|  |
|sale/updatedBy|associate|Updated by: The user who last updated the data| x |
|sale/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|sale/registeredBy|associate|Registered by: The user who registered the data| x |
|sale/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|sale/currencyId|int|Currency ID: The currency list item ID| x |
|sale/currency|listAny|Currency: The currency of the sale| x |
|sale/credited|listAny|Credited: The user to be credited with the sale| x |
|sale/lossReason|listAny|Reason (lost: The reason for losing the sale| x |
|sale/source|listAny|Source: The source (lead) of the sale| x |
|sale/competitor|listAny|Competitor: The competitor who won the sale| x |
|sale/heading|stringorPK|Sale: Displays a descriptive text for the item| x |
|sale/amount|decimal|Amount: The gross sales total| x |
|sale/amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.| x |
|sale/earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale| x |
|sale/earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total| x |
|sale/probPercent|int|Probability as %: Probability as %| x |
|sale/originalStage|listAny|Stage: Displays the stage of the sale| x |
|sale/stage|listAny|Stage: Displays the stage of the sale| x |
|sale/saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|sale/saleType|listAny|Sale type: Sale type, from list| x |
|sale/nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|sale/reopenDate|date|Reopen date: Displays the reopen date for the sale| x |
|sale/stalledComment|listAny|Reason (stalled: The reason the sale has been stalled| x |
|sale/soldReason|listAny|Reason (sold: Reason (sold)| x |
|sale/saleNumber|string|Number: Number| x |
|sale/hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders enabled| x |
|sale/hasQuote|bool|Has quote?: Does the sale have a quote attached?| x |
|sale/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|sale/description|string|Description: The long description field on Sale|  |
|sale/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|sale/visibleFor|listAny|Visible for|  |
|sale/sale/textId|int|Text ID| x |
|sale/sale/description|positiveString|Text: Displays the text entered in the description field| x |
|sale/salePublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|sale/salePublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|sale/salePublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|sale/associate/firstName|string|First name: Displays the contact's first name| x |
|sale/associate/lastName|string|Last name: Displays the contact's last name| x |
|sale/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|sale/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|sale/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|sale/associate/personId|int|Contact ID: Database ID of the contact row|  |
|sale/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|sale/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|sale/associate/associateDbId|associate|ID| x |
|sale/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|sale/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|sale/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|sale/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|sale/associate/contactCategory|listAny|Category: Category| x |
|sale/associate/role|listAny|Role : Role| x |
|sale/associate/assocName|associate|User ID : User ID| x |
|sale/associate/assocTooltip|string|Description : Description|  |
|sale/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|sale/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|sale/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|sale/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|sale/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|sale/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|sale/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|sale/associate/otherGroups|userGroup|Other groups: Other groups|  |
|sale/associate/userName|string|User name: User name| x |
|sale/associate/personEmail|string|E-mail| x |
|sale/saleUdef/SuperOffice:1|string|saleshorttext| x |
|sale/saleUdef/SuperOffice:2|string|salelongtext| x |
|sale/saleUdef/SuperOffice:3|int|salenumber| x |
|sale/saleUdef/SuperOffice:4|date|saledate| x |
|sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|sale/saleUdef/SuperOffice:6|bool|salecheckbox| x |
|sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|sale/saleUdef/SuperOffice:8|decimal|saledecimal| x |
|appointment/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|appointment/icon| *None* |Category: Displays the icon for an activity type| x |
|appointment/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|appointment/time| *None* |Time: Time|  |
|appointment/type|listAny|Type: Displays the type of an activity| x |
|appointment/recordType|string|Record type : Shows the record type| x |
|appointment/text|positiveString|Text: Displays a descriptive text for the item| x |
|appointment/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|appointment/contactId|listAny|Company ID: Database ID of company| x |
|appointment/personId|listAny|Contact ID: Database ID of the contact row| x |
|appointment/projectId|listAny|Project ID: Database ID of project record| x |
|appointment/saleId|int|Sale ID: The database ID of the sale record| x |
|appointment/userGroup|userGroup|User group : The user group that owns the record| x |
|appointment/who| *None* |Who: Contact and/or company|  |
|appointment/updatedBy|associate|Updated by: The user who last updated the data| x |
|appointment/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointment/registeredBy|associate|Registered by: The user who registered the data| x |
|appointment/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointment/appointmentId|int|DB ID: Displays the database ID of a row| x |
|appointment/endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|appointment/priority|listAny|Priority: Displays the priority of the activity| x |
|appointment/alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|appointment/recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|appointment/booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|appointment/intention|listAny|Intention: Displays the intention of the follow-up type| x |
|appointment/location|string|Location: Display the location where the follow-up will take place.| x |
|appointment/recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up| x |
|appointment/rawType|int|Type: Type field for appointment, not decoded or formatted| x |
|appointment/rawStatus|int|Status: Status field for the follow-up, not decoded or formatted| x |
|appointment/cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|appointment/visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?| x |
|appointment/endTime| *None* |End time: End time of an activity|  |
|appointment/suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|appointment/completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|appointment/isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|appointment/invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|appointment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|appointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|appointment/visibleFor|listAny|Visible for|  |
|appointment/appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointment/appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointment/appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|appointment/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointment/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|appointment/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|appointment/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|appointment/appointmentUdef/SuperOffice:4|date|followupdate| x |
|appointment/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|appointment/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|appointment/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|appointment/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|appointment/associate/firstName|string|First name: Displays the contact's first name| x |
|appointment/associate/lastName|string|Last name: Displays the contact's last name| x |
|appointment/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|appointment/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|appointment/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|appointment/associate/personId|int|Contact ID: Database ID of the contact row|  |
|appointment/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointment/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|appointment/associate/associateDbId|associate|ID| x |
|appointment/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|appointment/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|appointment/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|appointment/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|appointment/associate/contactCategory|listAny|Category: Category| x |
|appointment/associate/role|listAny|Role : Role| x |
|appointment/associate/assocName|associate|User ID : User ID| x |
|appointment/associate/assocTooltip|string|Description : Description|  |
|appointment/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|appointment/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|appointment/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointment/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|appointment/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointment/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|appointment/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|appointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointment/associate/otherGroups|userGroup|Other groups: Other groups|  |
|appointment/associate/userName|string|User name: User name| x |
|appointment/associate/personEmail|string|E-mail| x |
|appointment/appointment/textId|int|Text ID| x |
|appointment/appointment/description|positiveString|Text: Displays the text entered in the description field| x |
|document/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|document/icon| *None* |Category: Displays the icon for an activity type| x |
|document/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|document/time| *None* |Time: Time|  |
|document/type|listAny|Type: Displays the type of an activity| x |
|document/recordType|string|Record type : Shows the record type| x |
|document/text|positiveString|Text: Displays a descriptive text for the item| x |
|document/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|document/contactId|listAny|Company ID: Database ID of company| x |
|document/personId|listAny|Contact ID: Database ID of the contact row| x |
|document/projectId|listAny|Project ID: Database ID of project record| x |
|document/saleId|int|Sale ID: The database ID of the sale record| x |
|document/userGroup|userGroup|User group : The user group that owns the record| x |
|document/who| *None* |Who: Contact and/or company|  |
|document/updatedBy|associate|Updated by: The user who last updated the data| x |
|document/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|document/registeredBy|associate|Registered by: The user who registered the data| x |
|document/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|document/documentId|int|Document ID: Database ID of document record| x |
|document/keywords|string|Keywords | x |
|document/ourref|string|Our ref.| x |
|document/yourref|string|Your ref.| x |
|document/attention|string|Salutation| x |
|document/subject|string|Subject| x |
|document/mailMergeDraft|bool|Mail merge draft : Indicates whether the document is a mail merge template| x |
|document/snum|int|Document number: Serial number of document. It can be generated by the number allocation system for a dedicated document template.| x |
|document/isReport|bool|Report: Is this document a saved report run?|  |
|document/suggestedDocumentId|int|Document ID (suggestion: The database ID of a document that originates in a suggestion| x |
|document/isMail|bool|E-mail|  |
|document/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|document/visibleFor|listAny|Visible for|  |
|document/documentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|document/documentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|document/documentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|document/documentPublish/publishedBy| *None* |Published by: Published by|  |
|document/associate/firstName|string|First name: Displays the contact's first name| x |
|document/associate/lastName|string|Last name: Displays the contact's last name| x |
|document/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|document/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|document/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|document/associate/personId|int|Contact ID: Database ID of the contact row|  |
|document/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|document/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|document/associate/associateDbId|associate|ID| x |
|document/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|document/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|document/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|document/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|document/associate/contactCategory|listAny|Category: Category| x |
|document/associate/role|listAny|Role : Role| x |
|document/associate/assocName|associate|User ID : User ID| x |
|document/associate/assocTooltip|string|Description : Description|  |
|document/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|document/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|document/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|document/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|document/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|document/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|document/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|document/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|document/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|document/associate/portraitThumbnail| *None* |Person image: Person image|  |
|document/associate/otherGroups|userGroup|Other groups: Other groups|  |
|document/associate/userName|string|User name: User name| x |
|document/associate/personEmail|string|E-mail| x |
|document/documentUdef/SuperOffice:1|string|documentshorttext| x |
|document/documentUdef/SuperOffice:2|string|documentlongtext| x |
|document/documentUdef/SuperOffice:3|int|documentnumber| x |
|document/documentUdef/SuperOffice:4|date|documentdate| x |
|document/documentUdef/SuperOffice:5|unlimitedDate|documentunlimiteddate| x |
|document/documentUdef/SuperOffice:6|bool|documentcheckbox| x |
|document/documentUdef/SuperOffice:7|listAny|documentdropdownlistbox| x |
|document/documentUdef/SuperOffice:8|decimal|documentdecimal| x |
|document/document/textId|int|Text ID| x |
|document/document/description|positiveString|Text: Displays the text entered in the description field| x |
|projectMember/projectMemberId|int|Project member ID: Database ID of project member record| x |
|projectMember/projectId|int|Project ID: Project ID| x |
|projectMember/contactId|int|Company ID: Database ID of company| x |
|projectMember/personId|int|Contact ID: Database ID of the contact row| x |
|projectMember/function|listAny|Function: Displays the project member's function in the project| x |
|projectMember/hasInfoText|bool|Project member information: Displays an icon indicating that there is additional information available for the project member| x |
|projectMember/textId|int|Text ID| x |
|projectMember/infoText|positiveString|Information: Displays the text entered in the description field| x |
|projectMember/firstName|string|First name: Displays the contact's first name| x |
|projectMember/lastName|string|Last name: Displays the contact's last name| x |
|projectMember/middleName|string|Middle name: Displays the contact's middle name.| x |
|projectMember/fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
|projectMember/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|projectMember/personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|projectMember/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectMember/position|listAny|Position| x |
|projectMember/personNumber|string|Number: Displays the contact's number| x |
|projectMember/title|string|Title: Displays the contact's job title| x |
|projectMember/personCountry|listAny|Country: Country| x |
|projectMember/personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox| x |
|projectMember/rank|int|Rank: Displays a contact's current rank| x |
|projectMember/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|projectMember/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|projectMember/useAsMailingAddress|bool|Use as postal address: Use as postal address| x |
|projectMember/personSource|listAny|Source: Source (Contact)| x |
|projectMember/retired|bool|Former employee: Indicates whether the contact has retired/left the company| x |
|projectMember/birthYear|int|Birth year: Displays contact's birth year| x |
|projectMember/birthMonth|int|Birth month: Displays contact's birth month| x |
|projectMember/birthDay|int|Birth day: Displays contact's birth day (day of month)| x |
|projectMember/kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet| x |
|projectMember/kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet| x |
|projectMember/personUpdatedBy|associate|Updated by: The user who last updated the data| x |
|projectMember/personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|projectMember/personRegisteredBy|associate|Registered by: The user who registered the data| x |
|projectMember/personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|projectMember/portraitThumbnail| *None* |Person image: Person image|  |
|projectMember/personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|projectMember/ticketPriority|listAny|Service priority: Default service priority for this contact| x |
|projectMember/supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|projectMember/supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|projectMember/personAssociateId|associate|Our contact: Displays our contact| x |
|projectMember/personCategory|listAny|Category| x |
|projectMember/personBusiness|listAny|Business| x |
|projectMember/personDeletedDate|datetime|Deleted date: Deleted date|  |
|projectMember/hasCompany|bool|Has company: The contact is associated with a company| x |
|projectMember/isProjectMember|bool|Is project member: This person is a project member| x |
|projectMember/isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|projectMember/phone/formattedNumber|string|Phone : Displays phone number|  |
|projectMember/personDirectPhone/formattedNumber|string|Direct - Phone: Displays phone number|  |
|projectMember/personDirectPhone/description|string|Direct - Description: Phone number description| x |
|projectMember/personMobilePhone/formattedNumber|string|Mobile - Phone: Displays phone number|  |
|projectMember/personMobilePhone/description|string|Mobile - Description: Phone number description| x |
|projectMember/personPrivate/formattedNumber|string|Private - Phone: Displays phone number|  |
|projectMember/personPrivate/description|string|Private - Description: Phone number description| x |
|projectMember/personPager/formattedNumber|string|Other - Phone: Displays phone number|  |
|projectMember/personPager/description|string|Other - Description: Phone number description| x |
|projectMember/personDirectFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|projectMember/personDirectFax/description|string|Fax - Description: Phone number description| x |
|projectMember/searchPhone/formattedNumber|string|Phone : Displays phone number|  |
|projectMember/searchPhone/description|string|Description: Phone number description| x |
|projectMember/personInfo/textId|int|Text ID| x |
|projectMember/personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|projectMember/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|projectMember/email/emailAddress|string|E-mail| x |
|projectMember/email/emailDescription|string|Description| x |
|projectMember/email/emailId|int|ID| x |
|projectMember/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|projectMember/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|projectMember/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|projectMember/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|projectMember/personUrl/URLAddress|string|URL| x |
|projectMember/personUrl/URLDescription|string|Description| x |
|projectMember/personAddress/addressId|int|Contact address - Address ID: Database ID for the address record| x |
|projectMember/personAddress/line1|string|Contact address - Address 1: First line of the address| x |
|projectMember/personAddress/line2|string|Contact address - Address 2: Second line of the address| x |
|projectMember/personAddress/line3|string|Contact address - Address 3: Third line of the address| x |
|projectMember/personAddress/county|string|Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|projectMember/personAddress/city|string|Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|projectMember/personAddress/zip|string|Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|projectMember/personAddress/state|string|Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|projectMember/personAddress/wgs84latitude|decimal|Contact address - Latitude: Latitude| x |
|projectMember/personAddress/wgs84longitude|decimal|Contact address - Longitude: Longitude| x |
|projectMember/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|projectMember/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|projectMember/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|projectMember/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|projectMember/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|projectMember/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|projectMember/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|projectMember/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|projectMember/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|projectMember/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|projectMember/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|projectMember/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|projectMember/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|projectMember/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|projectMember/personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|projectMember/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|projectMember/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|projectMember/personUdef/SuperOffice:3|int|contactnumber| x |
|projectMember/personUdef/SuperOffice:4|date|contactdate| x |
|projectMember/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|projectMember/personUdef/SuperOffice:6|bool|contactcheckbox| x |
|projectMember/personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|projectMember/personUdef/SuperOffice:8|decimal|contactdecimal| x |
|projectMember/personUdef/SuperOffice:9|string|page1saleonly| x |
|projectMember/personUdef/SuperOffice:10|string|page1marketingonly| x |
|projectMember/personUdef/SuperOffice:11|string|page1adminonly| x |
|projectMember/isMailingRecipient|bool|isMailingRecipient: isMailingRecipient| x |
|projectMember/hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|projectMember/withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|projectMember/hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|projectMember/withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|projectMember/subscription|listAny|Subscription: Subscription for marketing| x |
|projectMember/legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|projectMember/legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|projectMember/consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|projectMember/consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|projectMember/name|stringorPK|Company name| x |
|projectMember/department|string|Department| x |
|projectMember/nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|projectMember/associateId|associate|Our contact: Displays our contact| x |
|projectMember/category|listAny|Category| x |
|projectMember/business|listAny|Business| x |
|projectMember/country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|projectMember/number|string|Number| x |
|projectMember/code|string|Code| x |
|projectMember/orgnr|string|VAT No.| x |
|projectMember/stop|bool|Stop| x |
|projectMember/contactNoMail|bool|No mailings (company| x |
|projectMember/updatedBy|associate|Updated by: The user who last updated the data| x |
|projectMember/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|projectMember/registeredBy|associate|Registered by: The user who registered the data| x |
|projectMember/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|projectMember/contactSource|listAny|Source: Source (Company)| x |
|projectMember/contactDeleted|bool|Deleted: Deleted| x |
|projectMember/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|projectMember/deletedDate|datetime|Deleted date: Deleted date|  |
|projectMember/mainContact| *None* |Main contact: Main contact for this company| x |
|projectMember/contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|projectMember/contactPhone/description|string|Telephone - Description: Phone number description| x |
|projectMember/contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|projectMember/contactFax/description|string|Fax - Description: Phone number description| x |
|projectMember/postAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|projectMember/postAddress/line1|string|Postal address - Address 1: First line of the address| x |
|projectMember/postAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|projectMember/postAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|projectMember/postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|projectMember/postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|projectMember/postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|projectMember/postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|projectMember/postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|projectMember/postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|projectMember/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|projectMember/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|projectMember/streetAddress/addressId|int|Street address - Address ID: Database ID for the address record| x |
|projectMember/streetAddress/line1|string|Street address - Address 1: First line of the address| x |
|projectMember/streetAddress/line2|string|Street address - Address 2: Second line of the address| x |
|projectMember/streetAddress/line3|string|Street address - Address 3: Third line of the address| x |
|projectMember/streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|projectMember/streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.| x |
|projectMember/streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|projectMember/streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|projectMember/streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude| x |
|projectMember/streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude| x |
|projectMember/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|projectMember/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|projectMember/url/URLAddress|string|URL| x |
|projectMember/url/URLDescription|string|Description| x |
|projectMember/contactAssociate/firstName|string|First name: Displays the contact's first name| x |
|projectMember/contactAssociate/lastName|string|Last name: Displays the contact's last name| x |
|projectMember/contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|projectMember/contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|projectMember/contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|projectMember/contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|projectMember/contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectMember/contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|projectMember/contactAssociate/associateDbId|associate|ID| x |
|projectMember/contactAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|projectMember/contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|projectMember/contactAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|projectMember/contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|projectMember/contactAssociate/contactCategory|listAny|Category: Category| x |
|projectMember/contactAssociate/role|listAny|Role : Role| x |
|projectMember/contactAssociate/assocName|associate|User ID : User ID| x |
|projectMember/contactAssociate/assocTooltip|string|Description : Description|  |
|projectMember/contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|projectMember/contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|projectMember/contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectMember/contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|projectMember/contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectMember/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|projectMember/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|projectMember/contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|projectMember/contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|projectMember/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectMember/contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|projectMember/contactAssociate/userName|string|User name: User name| x |
|projectMember/contactAssociate/personEmail|string|E-mail| x |
|projectMember/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|projectMember/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|projectMember/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|projectMember/contactUdef/SuperOffice:3|int|companynumber| x |
|projectMember/contactUdef/SuperOffice:4|date|companydate| x |
|projectMember/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|projectMember/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|projectMember/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|projectMember/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|projectMember/contactUdef/SuperOffice:9|string|page1saleonly| x |
|projectMember/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|projectMember/contactUdef/SuperOffice:11|string|page1adminonly| x |
|projectMember/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|projectMember/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|projectMember/NumberOfActivities|int|Number of activities|  |
|projectMember/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|projectMember/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|projectMember/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|projectMember/LastActivity|date|Date of last activity|  |
|projectMember/LastCompletedActivity|date|Date of last completed activity|  |
|projectMember/LastDoByActivity|date|Date of last non-completed activity|  |
|projectMember/NumberOfSales|int|Number of sales|  |
|projectMember/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|projectMember/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|projectMember/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|projectMember/LastSale|date|Date of last sale|  |
|projectMember/LastCompletedSale|date|Date of last completed sale|  |
|projectMember/LastDoBySale|date|Date of last non-completed sale|  |
|projectMember/NumberOfTickets|int|Number of requests|  |
|projectMember/NumberOfTicketsInPeriod|int|Number of requests in last 90 days|  |
|projectMember/NumberOfNotCompletedTickets|int|Number of non-completed requests|  |
|projectMember/NumberOfNotCompletedTicketsInPeriod|int|Number of non-completed requests in last 90 days|  |
|projectMember/LastTicket|date|Date of last request|  |
|projectMember/LastCompletedTicket|date|Date of last completed request|  |
|projectMember/LastDoByTicket|date|Date of last non-completed request|  |
|projectMember/SaintStatus1|saintStatus|Neglected customer|  |
|projectMember/SaintStatus2|saintStatus|C-company|  |
|projectMember/saintSaleStatus|listAny|With status|  |
|projectMember/saintAmountClass|listAny|Amount class|  |
|projectMember/saintActivityType|listAny|SAINT type|  |
|projectMember/saintDirection|listAny|Direction|  |
|projectMember/saintIntention|listAny|Intention|  |
|projectMember/saintTicketStatus|listAny|Status|  |
|projectMember/saintTicketCategory|listAny|Category|  |
|project/textId|int|Text ID| x |
|project/infoText|positiveString|Information: Displays the text entered in the description field| x |
|selectionId|int|Selection ID: The database ID of the selection|  |
|selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|rowKind| *None* |Icon indicating whether the row comes from a static or a dynamic selection|  |
|targetTableNumber| *None* |TargetTableNumber: TargetTableNumber| x |
|targetRecordId| *None* |TargetRecordId: TargetRecordId| x |
|contactId| *None* |Company ID: Database ID of company| x |
|personId| *None* |Contact ID: Database ID of the contact row| x |
|projectMember/contactEmail/emailProtocol| *None* |Company - Protocol: E-mail protocol, such as SMTP| x |
|projectMember/contactEmail/emailAddress| *None* |Company - E-mail| x |
|projectMember/contactEmail/emailDescription| *None* |Company - Description| x |
|projectMember/contactEmail/emailId| *None* |Company - ID| x |
|projectMember/contactEmail/emailLastSent| *None* |Company - Last sent: The date and time an e-mail was last sent to this address| x |
|projectMember/contactEmail/emailBounceCount| *None* |Company - Bounce count: Bounce count for this e-mail address| x |
|projectMember/contactEmail/emailLastBounce| *None* |Company - Last bounce: Date and time for last bounce to this e-mail address| x |
|projectMember/contactEmail/emailHasBounced| *None* |Company - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |

## Sample

```http!
GET /api/v1/archive/AssociateProjectSelectionV2?$select=saintDirection,sale/saleUdef/SuperOffice:8,projectMember/firstName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

