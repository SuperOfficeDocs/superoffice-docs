---
uid: ProjectGuide
title: ProjectGuide
description: Provider for the Project Guide, common to both Appointment and Document guide items and instances
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ProjectGuide"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ProjectGuide"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ProjectGuideProvider">SuperOffice.CRM.ArchiveLists.ProjectGuideProvider</see> inside NetServer's SODatabase assembly.

Provider for the Project Guide, common to both Appointment and Document guide items and instances

This provider is a trivial aggregation of the Appointment and Document providers

## Supported Entities
| Name | Description |
| ---- | ----- |
|"suggestedAppointment"|Follow-ups|
|"onlyInstance"|Created only|
|"appointment"|Follow-ups|
|"milestone"|Milestones only|
|"suggestedDocument"|Documents|
|"document"|Documents|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|projectId|int|Project ID: Database ID of project record| x |
|milestone| *None* |milestone: milestone|  |
|completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|text|string|Text: Displays a descriptive text for the item| x |
|stageName|string|Stage: Name of sale stages| x |
|stageId|int|Stage ID: Database ID of a sale stage.| x |
|stageOrderBy|int|Sort order for stages: Sort algorithm for sales stages| x |
|suggestedItemId|int|Database ID (suggestion: The database ID of an entity (follow-up or document) that originates in a suggestion| x |
|suggestedItemText|string|Name of entity (suggestion: The name of an entity (follow-up or document) that originates in a suggestion| x |
|suggestedItemOrderBy|int|Sort order for suggestions: Sort algorithm for suggestions| x |
|suggestedItemTooltip|string|Description: Description of a suggested item| x |
|instanceItemId| *None* |Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion|  |
|instanceItemText| *None* |Instance name (suggestion: Description of a follow-up or heading in a document that originates in a suggestion|  |
|hasInstance| *None* |Has instance: Does this suggested item have an instance?|  |
|deleted|bool|Deleted: Has this suggestion been deleted by the administrator?| x |
|isMilestone| *None* |Milestone: Shows whether or not the follow-ups in this row are milestones|  |
|appointmentInstance/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed|  |
|appointmentInstance/icon| *None* |Category: Displays the icon for an activity type|  |
|appointmentInstance/date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|appointmentInstance/time| *None* |Time: Time|  |
|appointmentInstance/type| *None* |Type: Displays the type of an activity|  |
|appointmentInstance/recordType| *None* |Record type : Shows the record type|  |
|appointmentInstance/text| *None* |Text: Displays a descriptive text for the item|  |
|appointmentInstance/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|appointmentInstance/contactId| *None* |Company ID: Database ID of company|  |
|appointmentInstance/personId| *None* |Contact ID: Database ID of the contact row|  |
|appointmentInstance/projectId| *None* |Project ID: Database ID of project record|  |
|appointmentInstance/saleId| *None* |Sale ID: The database ID of the sale record|  |
|appointmentInstance/userGroup| *None* |User group : The user group that owns the record|  |
|appointmentInstance/who| *None* |Who: Contact and/or company|  |
|appointmentInstance/updatedBy| *None* |Updated by: The user who last updated the data|  |
|appointmentInstance/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|appointmentInstance/registeredBy| *None* |Registered by: The user who registered the data|  |
|appointmentInstance/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|appointmentInstance/appointmentId| *None* |DB ID: Displays the database ID of a row|  |
|appointmentInstance/endDate| *None* |End date: Displays the deadline for a follow-up/sale|  |
|appointmentInstance/priority| *None* |Priority: Displays the priority of the activity|  |
|appointmentInstance/alarm| *None* |Has alarm: Displays the alarm state of a follow-up|  |
|appointmentInstance/recurring| *None* |Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up|  |
|appointmentInstance/booking| *None* |Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.|  |
|appointmentInstance/intention| *None* |Intention: Displays the intention of the follow-up type|  |
|appointmentInstance/location| *None* |Location: Display the location where the follow-up will take place.|  |
|appointmentInstance/recurrenceRuleId| *None* |RR-ID: Repetition rule ID of follow-up|  |
|appointmentInstance/rawType| *None* |Type: Type field for appointment, not decoded or formatted|  |
|appointmentInstance/rawStatus| *None* |Status: Status field for the follow-up, not decoded or formatted|  |
|appointmentInstance/cautionWarning| *None* |Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.|  |
|appointmentInstance/visibleInDiary| *None* |ExcludeBook: Is the activity visible in the diary?|  |
|appointmentInstance/endTime| *None* |End time: End time of an activity|  |
|appointmentInstance/suggestedAppointmentId| *None* |Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion|  |
|appointmentInstance/completedDate| *None* |Completed date: Displays the actual date a follow-up/sale was marked as completed|  |
|appointmentInstance/isMilestone| *None* |Milestone: Shows whether or not the follow-ups in this row are milestones|  |
|appointmentInstance/invitedPersonId| *None* |ID of invited person: appointment.invitedpersonid record - utility for rd|  |
|appointmentInstance/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
|appointmentInstance/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting|  |
|appointmentInstance/visibleFor| *None* |Visible for|  |
|appointmentInstance/appointmentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|appointmentInstance/appointmentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|appointmentInstance/appointmentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|appointmentInstance/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointmentInstance/contact/contactId| *None* |Company ID: Database ID of company|  |
|appointmentInstance/contact/name| *None* |Company name|  |
|appointmentInstance/contact/department| *None* |Department|  |
|appointmentInstance/contact/nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|appointmentInstance/contact/hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|appointmentInstance/contact/hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|appointmentInstance/contact/associateId| *None* |Our contact: Displays our contact|  |
|appointmentInstance/contact/category| *None* |Category|  |
|appointmentInstance/contact/business| *None* |Business|  |
|appointmentInstance/contact/country| *None* |Country: This criterion corresponds to the Country field on the Company card.|  |
|appointmentInstance/contact/number| *None* |Number|  |
|appointmentInstance/contact/code| *None* |Code|  |
|appointmentInstance/contact/orgnr| *None* |VAT No.|  |
|appointmentInstance/contact/stop| *None* |Stop|  |
|appointmentInstance/contact/contactNoMail| *None* |No mailings (company|  |
|appointmentInstance/contact/updatedBy| *None* |Updated by: The user who last updated the data|  |
|appointmentInstance/contact/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|appointmentInstance/contact/registeredBy| *None* |Registered by: The user who registered the data|  |
|appointmentInstance/contact/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|appointmentInstance/contact/contactSource| *None* |Source: Source (Company)|  |
|appointmentInstance/contact/contactDeleted| *None* |Deleted: Deleted|  |
|appointmentInstance/contact/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|appointmentInstance/contact/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|appointmentInstance/contact/deletedDate| *None* |Deleted date: Deleted date|  |
|appointmentInstance/contact/mainContact| *None* |Main contact: Main contact for this company|  |
|appointmentInstance/contact/contactPhone/formattedNumber| *None* |Telephone - Phone: Displays phone number|  |
|appointmentInstance/contact/contactPhone/description| *None* |Telephone - Description: Phone number description|  |
|appointmentInstance/contact/contactFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|appointmentInstance/contact/contactFax/description| *None* |Fax - Description: Phone number description|  |
|appointmentInstance/contact/searchPhone/formattedNumber| *None* |Searchphone - Phone: Displays phone number|  |
|appointmentInstance/contact/searchPhone/description| *None* |Searchphone - Description: Phone number description|  |
|appointmentInstance/contact/email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|appointmentInstance/contact/email/emailAddress| *None* |E-mail|  |
|appointmentInstance/contact/email/emailDescription| *None* |Description|  |
|appointmentInstance/contact/email/emailId| *None* |ID|  |
|appointmentInstance/contact/email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|appointmentInstance/contact/email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|appointmentInstance/contact/email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|appointmentInstance/contact/email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|appointmentInstance/contact/postAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|appointmentInstance/contact/postAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|appointmentInstance/contact/postAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|appointmentInstance/contact/postAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|appointmentInstance/contact/postAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|appointmentInstance/contact/postAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|appointmentInstance/contact/postAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|appointmentInstance/contact/postAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|appointmentInstance/contact/postAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|appointmentInstance/contact/postAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|appointmentInstance/contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|appointmentInstance/contact/streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|appointmentInstance/contact/streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|appointmentInstance/contact/streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|appointmentInstance/contact/streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|appointmentInstance/contact/streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|appointmentInstance/contact/streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|appointmentInstance/contact/streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|appointmentInstance/contact/streetAddress/wgs84latitude| *None* |Street address - Latitude: Latitude|  |
|appointmentInstance/contact/streetAddress/wgs84longitude| *None* |Street address - Longitude: Longitude|  |
|appointmentInstance/contact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|appointmentInstance/contact/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|appointmentInstance/contact/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|appointmentInstance/contact/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|appointmentInstance/contact/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|appointmentInstance/contact/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|appointmentInstance/contact/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|appointmentInstance/contact/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|appointmentInstance/contact/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|appointmentInstance/contact/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|appointmentInstance/contact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/url/URLAddress| *None* |URL|  |
|appointmentInstance/contact/url/URLDescription| *None* |Description|  |
|appointmentInstance/contact/contactAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|appointmentInstance/contact/contactAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|appointmentInstance/contact/contactAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|appointmentInstance/contact/contactAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|appointmentInstance/contact/contactAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/contact/contactAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|appointmentInstance/contact/contactAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/contact/contactAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/contact/contactAssociate/associateDbId| *None* |ID|  |
|appointmentInstance/contact/contactAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|appointmentInstance/contact/contactAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|appointmentInstance/contact/contactAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|appointmentInstance/contact/contactAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|appointmentInstance/contact/contactAssociate/contactCategory| *None* |Category: Category|  |
|appointmentInstance/contact/contactAssociate/role| *None* |Role : Role|  |
|appointmentInstance/contact/contactAssociate/assocName| *None* |User ID : User ID|  |
|appointmentInstance/contact/contactAssociate/assocTooltip| *None* |Description : Description|  |
|appointmentInstance/contact/contactAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|appointmentInstance/contact/contactAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|appointmentInstance/contact/contactAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/contact/contactAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|appointmentInstance/contact/contactAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/contact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|appointmentInstance/contact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|appointmentInstance/contact/contactAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|appointmentInstance/contact/contactAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|appointmentInstance/contact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/contact/contactAssociate/otherGroups| *None* |Other groups: Other groups|  |
|appointmentInstance/contact/contactAssociate/userName| *None* |User name: User name|  |
|appointmentInstance/contact/contactAssociate/personEmail| *None* |E-mail|  |
|appointmentInstance/contact/contactInterestIds| *None* |Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|appointmentInstance/contact/contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|appointmentInstance/contact/contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|appointmentInstance/contact/contactUdef/SuperOffice:3| *None* |companynumber|  |
|appointmentInstance/contact/contactUdef/SuperOffice:4| *None* |companydate|  |
|appointmentInstance/contact/contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|appointmentInstance/contact/contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|appointmentInstance/contact/contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|appointmentInstance/contact/contactUdef/SuperOffice:8| *None* |companydecimal|  |
|appointmentInstance/contact/contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|appointmentInstance/contact/contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|appointmentInstance/contact/contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|appointmentInstance/contact/contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|appointmentInstance/contact/contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|appointmentInstance/contact/NumberOfActivities| *None* |Number of activities|  |
|appointmentInstance/contact/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|appointmentInstance/contact/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|appointmentInstance/contact/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|appointmentInstance/contact/LastActivity| *None* |Date of last activity|  |
|appointmentInstance/contact/LastCompletedActivity| *None* |Date of last completed activity|  |
|appointmentInstance/contact/LastDoByActivity| *None* |Date of last non-completed activity|  |
|appointmentInstance/contact/NumberOfSales| *None* |Number of sales|  |
|appointmentInstance/contact/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|appointmentInstance/contact/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|appointmentInstance/contact/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|appointmentInstance/contact/LastSale| *None* |Date of last sale|  |
|appointmentInstance/contact/LastCompletedSale| *None* |Date of last completed sale|  |
|appointmentInstance/contact/LastDoBySale| *None* |Date of last non-completed sale|  |
|appointmentInstance/contact/NumberOfTickets| *None* |Number of requests|  |
|appointmentInstance/contact/NumberOfTicketsInPeriod| *None* |Number of requests in last 90 days|  |
|appointmentInstance/contact/NumberOfNotCompletedTickets| *None* |Number of non-completed requests|  |
|appointmentInstance/contact/NumberOfNotCompletedTicketsInPeriod| *None* |Number of non-completed requests in last 90 days|  |
|appointmentInstance/contact/LastTicket| *None* |Date of last request|  |
|appointmentInstance/contact/LastCompletedTicket| *None* |Date of last completed request|  |
|appointmentInstance/contact/LastDoByTicket| *None* |Date of last non-completed request|  |
|appointmentInstance/contact/SaintStatus1| *None* |Neglected customer|  |
|appointmentInstance/contact/SaintStatus2| *None* |C-company|  |
|appointmentInstance/contact/saintSaleStatus| *None* |With status|  |
|appointmentInstance/contact/saintAmountClass| *None* |Amount class|  |
|appointmentInstance/contact/saintActivityType| *None* |SAINT type|  |
|appointmentInstance/contact/saintDirection| *None* |Direction|  |
|appointmentInstance/contact/saintIntention| *None* |Intention|  |
|appointmentInstance/contact/saintTicketStatus| *None* |Status|  |
|appointmentInstance/contact/saintTicketCategory| *None* |Category|  |
|appointmentInstance/person/personId| *None* |DB ID: Displays the database ID of a contact|  |
|appointmentInstance/person/firstName| *None* |First name: Displays the contact's first name|  |
|appointmentInstance/person/lastName| *None* |Last name: Displays the contact's last name|  |
|appointmentInstance/person/middleName| *None* |Middle name: Displays the contact's middle name.|  |
|appointmentInstance/person/fullName| *None* |Contact: Displays the contact to which an item is linked|  |
|appointmentInstance/person/contactId| *None* |Company ID: Database ID of company|  |
|appointmentInstance/person/hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|appointmentInstance/person/hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|appointmentInstance/person/personHasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|appointmentInstance/person/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/person/position| *None* |Position|  |
|appointmentInstance/person/personNumber| *None* |Number: Displays the contact's number|  |
|appointmentInstance/person/title| *None* |Title: Displays the contact's job title|  |
|appointmentInstance/person/personCountry| *None* |Country: Country|  |
|appointmentInstance/person/personNoMail| *None* |No Mailings: Displays the contact's No Mailings checkbox|  |
|appointmentInstance/person/rank| *None* |Rank: Displays a contact's current rank|  |
|appointmentInstance/person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|appointmentInstance/person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|appointmentInstance/person/useAsMailingAddress| *None* |Use as postal address: Use as postal address|  |
|appointmentInstance/person/personSource| *None* |Source: Source (Contact)|  |
|appointmentInstance/person/retired| *None* |Former employee: Indicates whether the contact has retired/left the company|  |
|appointmentInstance/person/birthYear| *None* |Birth year: Displays contact's birth year|  |
|appointmentInstance/person/birthMonth| *None* |Birth month: Displays contact's birth month|  |
|appointmentInstance/person/birthDay| *None* |Birth day: Displays contact's birth day (day of month)|  |
|appointmentInstance/person/kanaFirstName| *None* |First name, kana: Contact's first name, in kana alphabet|  |
|appointmentInstance/person/kanaLastName| *None* |Last name, kana: Contact's last name, in kana alphabet|  |
|appointmentInstance/person/personUpdatedBy| *None* |Updated by: The user who last updated the data|  |
|appointmentInstance/person/personUpdatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|appointmentInstance/person/personRegisteredBy| *None* |Registered by: The user who registered the data|  |
|appointmentInstance/person/personRegisteredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|appointmentInstance/person/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/person/personActiveErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|appointmentInstance/person/ticketPriority| *None* |Service priority: Default service priority for this contact|  |
|appointmentInstance/person/supportLanguage| *None* |Preferred language: Preferred language used for reply templates and more|  |
|appointmentInstance/person/supportAssociate| *None* |Our service contact: Default service contact for this contact|  |
|appointmentInstance/person/personAssociateId| *None* |Our contact: Displays our contact|  |
|appointmentInstance/person/personCategory| *None* |Category|  |
|appointmentInstance/person/personBusiness| *None* |Business|  |
|appointmentInstance/person/personDeletedDate| *None* |Deleted date: Deleted date|  |
|appointmentInstance/person/hasCompany| *None* |Has company: The contact is associated with a company|  |
|appointmentInstance/person/isProjectMember| *None* |Is project member: This person is a project member|  |
|appointmentInstance/person/isStakeholder| *None* |Is stakeholder: This person is a sale stakeholder|  |
|appointmentInstance/person/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|appointmentInstance/person/personDirectPhone/formattedNumber| *None* |Direct - Phone: Displays phone number|  |
|appointmentInstance/person/personDirectPhone/description| *None* |Direct - Description: Phone number description|  |
|appointmentInstance/person/personMobilePhone/formattedNumber| *None* |Mobile - Phone: Displays phone number|  |
|appointmentInstance/person/personMobilePhone/description| *None* |Mobile - Description: Phone number description|  |
|appointmentInstance/person/personPrivate/formattedNumber| *None* |Private - Phone: Displays phone number|  |
|appointmentInstance/person/personPrivate/description| *None* |Private - Description: Phone number description|  |
|appointmentInstance/person/personPager/formattedNumber| *None* |Other - Phone: Displays phone number|  |
|appointmentInstance/person/personPager/description| *None* |Other - Description: Phone number description|  |
|appointmentInstance/person/personDirectFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|appointmentInstance/person/personDirectFax/description| *None* |Fax - Description: Phone number description|  |
|appointmentInstance/person/searchPhone/formattedNumber| *None* |Phone : Displays phone number|  |
|appointmentInstance/person/searchPhone/description| *None* |Description: Phone number description|  |
|appointmentInstance/person/personInfo/textId| *None* |Text ID|  |
|appointmentInstance/person/personInfo/infoText| *None* |Information: Displays the text entered in the description field|  |
|appointmentInstance/person/email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|appointmentInstance/person/email/emailAddress| *None* |E-mail|  |
|appointmentInstance/person/email/emailDescription| *None* |Description|  |
|appointmentInstance/person/email/emailId| *None* |ID|  |
|appointmentInstance/person/email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|appointmentInstance/person/email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|appointmentInstance/person/email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|appointmentInstance/person/email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|appointmentInstance/person/personUrl/URLAddress| *None* |URL|  |
|appointmentInstance/person/personUrl/URLDescription| *None* |Description|  |
|appointmentInstance/person/personAddress/addressId| *None* |Contact address - Address ID: Database ID for the address record|  |
|appointmentInstance/person/personAddress/line1| *None* |Contact address - Address 1: First line of the address|  |
|appointmentInstance/person/personAddress/line2| *None* |Contact address - Address 2: Second line of the address|  |
|appointmentInstance/person/personAddress/line3| *None* |Contact address - Address 3: Third line of the address|  |
|appointmentInstance/person/personAddress/county| *None* |Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|appointmentInstance/person/personAddress/city| *None* |Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|appointmentInstance/person/personAddress/zip| *None* |Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|appointmentInstance/person/personAddress/state| *None* |Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|appointmentInstance/person/personAddress/wgs84latitude| *None* |Contact address - Latitude: Latitude|  |
|appointmentInstance/person/personAddress/wgs84longitude| *None* |Contact address - Longitude: Longitude|  |
|appointmentInstance/person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|appointmentInstance/person/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|appointmentInstance/person/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|appointmentInstance/person/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|appointmentInstance/person/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|appointmentInstance/person/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|appointmentInstance/person/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|appointmentInstance/person/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|appointmentInstance/person/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|appointmentInstance/person/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|appointmentInstance/person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/personInterestIds| *None* |Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|appointmentInstance/person/personUdef/SuperOffice:1| *None* |contactshorttext: tooltipshorttext|  |
|appointmentInstance/person/personUdef/SuperOffice:2| *None* |contactlongtext: tooltiplongtext|  |
|appointmentInstance/person/personUdef/SuperOffice:3| *None* |contactnumber|  |
|appointmentInstance/person/personUdef/SuperOffice:4| *None* |contactdate|  |
|appointmentInstance/person/personUdef/SuperOffice:5| *None* |contactunlimiteddate: tooltipunlimiteddate|  |
|appointmentInstance/person/personUdef/SuperOffice:6| *None* |contactcheckbox|  |
|appointmentInstance/person/personUdef/SuperOffice:7| *None* |contactdropdownlistbox|  |
|appointmentInstance/person/personUdef/SuperOffice:8| *None* |contactdecimal|  |
|appointmentInstance/person/personUdef/SuperOffice:9| *None* |page1saleonly|  |
|appointmentInstance/person/personUdef/SuperOffice:10| *None* |page1marketingonly|  |
|appointmentInstance/person/personUdef/SuperOffice:11| *None* |page1adminonly|  |
|appointmentInstance/person/isMailingRecipient| *None* |isMailingRecipient: isMailingRecipient|  |
|appointmentInstance/person/hasStoreConsent| *None* |Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/withdrawnStoreConsent| *None* |Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/hasEmarketingConsent| *None* |Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/withdrawnEmarketingConsent| *None* |Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/subscription| *None* |Subscription: Subscription for marketing|  |
|appointmentInstance/person/legalBaseStore| *None* |Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/legalBaseEmarketing| *None* |Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/consentSourceStore| *None* |Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/consentSourceEmarketing| *None* |Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/appointmentUdef/SuperOffice:1| *None* |followupshorttext|  |
|appointmentInstance/appointmentUdef/SuperOffice:2| *None* |followuplongtext|  |
|appointmentInstance/appointmentUdef/SuperOffice:3| *None* |followupnumber|  |
|appointmentInstance/appointmentUdef/SuperOffice:4| *None* |followupdate|  |
|appointmentInstance/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate|  |
|appointmentInstance/appointmentUdef/SuperOffice:6| *None* |followupcheckbox|  |
|appointmentInstance/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox|  |
|appointmentInstance/appointmentUdef/SuperOffice:8| *None* |followupdecimal|  |
|appointmentInstance/project/completed| *None* |Completed: Displays a check mark indicating if the project has been completed.|  |
|appointmentInstance/project/projectId| *None* |DB ID: Displays the database ID for a project row|  |
|appointmentInstance/project/name| *None* |Project name: Displays the Project's name|  |
|appointmentInstance/project/number| *None* |Number: Displays the project's number|  |
|appointmentInstance/project/type| *None* |Project type: Displays the project's type|  |
|appointmentInstance/project/status| *None* |Status: Displays the project's status|  |
|appointmentInstance/project/associateId| *None* |ID: Displays login ID of the associate who owns the project|  |
|appointmentInstance/project/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|appointmentInstance/project/icon| *None* |Category: Displays the icon for an activity type|  |
|appointmentInstance/project/text| *None* |Text: Displays a descriptive text for the item|  |
|appointmentInstance/project/description| *None* |Description : Description|  |
|appointmentInstance/project/updatedBy| *None* |Updated by: The user who last updated the data|  |
|appointmentInstance/project/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|appointmentInstance/project/registeredBy| *None* |Registered by: The user who registered the data|  |
|appointmentInstance/project/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|appointmentInstance/project/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|appointmentInstance/project/nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|appointmentInstance/project/endDate| *None* |End date: End date of project|  |
|appointmentInstance/project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|appointmentInstance/project/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|appointmentInstance/project/projectPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|appointmentInstance/project/projectPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|appointmentInstance/project/projectPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|appointmentInstance/project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|appointmentInstance/project/projectEvent/isExternalEvent| *None* |Event: Is this an external event|  |
|appointmentInstance/project/projectEvent/eventDate| *None* |Event date: Event date|  |
|appointmentInstance/project/projectEvent/hasSignOn| *None* |Sign On: Does this event have the Sign On function enabled|  |
|appointmentInstance/project/projectEvent/hasSignOff| *None* |Sign Off: Does this event have the Sign Off function enabled|  |
|appointmentInstance/project/projectUrl/URLAddress| *None* |URL|  |
|appointmentInstance/project/projectUrl/URLDescription| *None* |Description|  |
|appointmentInstance/project/projectAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|appointmentInstance/project/projectAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|appointmentInstance/project/projectAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|appointmentInstance/project/projectAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|appointmentInstance/project/projectAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/project/projectAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|appointmentInstance/project/projectAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/project/projectAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/project/projectAssociate/associateDbId| *None* |ID|  |
|appointmentInstance/project/projectAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|appointmentInstance/project/projectAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|appointmentInstance/project/projectAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|appointmentInstance/project/projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|appointmentInstance/project/projectAssociate/contactCategory| *None* |Category: Category|  |
|appointmentInstance/project/projectAssociate/role| *None* |Role : Role|  |
|appointmentInstance/project/projectAssociate/assocName| *None* |User ID : User ID|  |
|appointmentInstance/project/projectAssociate/assocTooltip| *None* |Description : Description|  |
|appointmentInstance/project/projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|appointmentInstance/project/projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|appointmentInstance/project/projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/project/projectAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|appointmentInstance/project/projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|appointmentInstance/project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|appointmentInstance/project/projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|appointmentInstance/project/projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|appointmentInstance/project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/project/projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|appointmentInstance/project/projectAssociate/userName| *None* |User name: User name|  |
|appointmentInstance/project/projectAssociate/personEmail| *None* |E-mail|  |
|appointmentInstance/project/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|appointmentInstance/project/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|appointmentInstance/project/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|appointmentInstance/project/projectUdef/SuperOffice:4| *None* |projectdate|  |
|appointmentInstance/project/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|appointmentInstance/project/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|appointmentInstance/project/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|appointmentInstance/project/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|appointmentInstance/project/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|appointmentInstance/project/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|appointmentInstance/project/NumberOfActivities| *None* |Number of activities|  |
|appointmentInstance/project/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|appointmentInstance/project/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|appointmentInstance/project/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|appointmentInstance/project/LastActivity| *None* |Date of last activity|  |
|appointmentInstance/project/LastCompletedActivity| *None* |Date of last completed activity|  |
|appointmentInstance/project/LastDoByActivity| *None* |Date of last non-completed activity|  |
|appointmentInstance/project/NumberOfSales| *None* |Number of sales|  |
|appointmentInstance/project/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|appointmentInstance/project/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|appointmentInstance/project/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|appointmentInstance/project/LastSale| *None* |Date of last sale|  |
|appointmentInstance/project/LastCompletedSale| *None* |Date of last completed sale|  |
|appointmentInstance/project/LastDoBySale| *None* |Date of last non-completed sale|  |
|appointmentInstance/project/SaintStatus3| *None* |Not completed activites with intention sale|  |
|appointmentInstance/project/saintSaleStatus| *None* |With status|  |
|appointmentInstance/project/saintAmountClass| *None* |Amount class|  |
|appointmentInstance/project/saintActivityType| *None* |SAINT type|  |
|appointmentInstance/project/saintDirection| *None* |Direction|  |
|appointmentInstance/project/saintIntention| *None* |Intention|  |
|appointmentInstance/project/saintTicketStatus| *None* |Status|  |
|appointmentInstance/project/saintTicketCategory| *None* |Category|  |
|appointmentInstance/project/project/textId| *None* |Text ID|  |
|appointmentInstance/project/project/infoText| *None* |Information: Displays the text entered in the description field|  |
|appointmentInstance/sale/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed|  |
|appointmentInstance/sale/icon| *None* |Category: Displays the icon for an activity type|  |
|appointmentInstance/sale/date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|appointmentInstance/sale/time| *None* |Time: Time|  |
|appointmentInstance/sale/type| *None* |Type: Displays the type of an activity|  |
|appointmentInstance/sale/recordType| *None* |Record type : Shows the record type|  |
|appointmentInstance/sale/text| *None* |Text: Displays a descriptive text for the item|  |
|appointmentInstance/sale/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|appointmentInstance/sale/contactId| *None* |Company ID: Database ID of company|  |
|appointmentInstance/sale/personId| *None* |Contact ID: Database ID of the contact row|  |
|appointmentInstance/sale/projectId| *None* |Project ID: Database ID of project record|  |
|appointmentInstance/sale/saleId| *None* |Sale ID: The database ID of the sale record|  |
|appointmentInstance/sale/userGroup| *None* |User group : The user group that owns the record|  |
|appointmentInstance/sale/who| *None* |Who: Contact and/or company|  |
|appointmentInstance/sale/updatedBy| *None* |Updated by: The user who last updated the data|  |
|appointmentInstance/sale/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|appointmentInstance/sale/registeredBy| *None* |Registered by: The user who registered the data|  |
|appointmentInstance/sale/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|appointmentInstance/sale/currencyId| *None* |Currency ID: The currency list item ID|  |
|appointmentInstance/sale/currency| *None* |Currency: The currency of the sale|  |
|appointmentInstance/sale/credited| *None* |Credited: The user to be credited with the sale|  |
|appointmentInstance/sale/lossReason| *None* |Reason (lost: The reason for losing the sale|  |
|appointmentInstance/sale/source| *None* |Source: The source (lead) of the sale|  |
|appointmentInstance/sale/competitor| *None* |Competitor: The competitor who won the sale|  |
|appointmentInstance/sale/heading| *None* |Sale: Displays a descriptive text for the item|  |
|appointmentInstance/sale/amount| *None* |Amount: The gross sales total|  |
|appointmentInstance/sale/amountWeighted| *None* |Weighted amount: Virtual field calculated from amount * probability percent.|  |
|appointmentInstance/sale/earning| *None* |Profit: Gross profit (gross sales total - cost) for the sale|  |
|appointmentInstance/sale/earningPercent| *None* |Profit as % : The profit as a percentage of the gross sales total|  |
|appointmentInstance/sale/probPercent| *None* |Probability as %: Probability as %|  |
|appointmentInstance/sale/originalStage| *None* |Stage: Displays the stage of the sale|  |
|appointmentInstance/sale/stage| *None* |Stage: Displays the stage of the sale|  |
|appointmentInstance/sale/saleStatus| *None* |Status: The status of the sale - open, lost or sold|  |
|appointmentInstance/sale/saleType| *None* |Sale type: Sale type, from list|  |
|appointmentInstance/sale/nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|appointmentInstance/sale/reopenDate| *None* |Reopen date: Displays the reopen date for the sale|  |
|appointmentInstance/sale/stalledComment| *None* |Reason (stalled: The reason the sale has been stalled|  |
|appointmentInstance/sale/soldReason| *None* |Reason (sold: Reason (sold)|  |
|appointmentInstance/sale/saleNumber| *None* |Number: Number|  |
|appointmentInstance/sale/hasStakeholders| *None* |Has stakeholders: Does this sale have stakeholders enabled|  |
|appointmentInstance/sale/hasQuote| *None* |Has quote?: Does the sale have a quote attached?|  |
|appointmentInstance/sale/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|appointmentInstance/sale/description| *None* |Description: The long description field on Sale|  |
|appointmentInstance/sale/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|appointmentInstance/sale/visibleFor| *None* |Visible for|  |
|appointmentInstance/sale/sale/textId| *None* |Text ID|  |
|appointmentInstance/sale/sale/description| *None* |Text: Displays the text entered in the description field|  |
|appointmentInstance/sale/salePublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|appointmentInstance/sale/salePublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|appointmentInstance/sale/salePublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|appointmentInstance/sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|appointmentInstance/sale/associate/firstName| *None* |First name: Displays the contact's first name|  |
|appointmentInstance/sale/associate/lastName| *None* |Last name: Displays the contact's last name|  |
|appointmentInstance/sale/associate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|appointmentInstance/sale/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|appointmentInstance/sale/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/sale/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|appointmentInstance/sale/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/sale/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/sale/associate/associateDbId| *None* |ID|  |
|appointmentInstance/sale/associate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|appointmentInstance/sale/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|appointmentInstance/sale/associate/usergroup| *None* |Primary group: The user's primary user group|  |
|appointmentInstance/sale/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|appointmentInstance/sale/associate/contactCategory| *None* |Category: Category|  |
|appointmentInstance/sale/associate/role| *None* |Role : Role|  |
|appointmentInstance/sale/associate/assocName| *None* |User ID : User ID|  |
|appointmentInstance/sale/associate/assocTooltip| *None* |Description : Description|  |
|appointmentInstance/sale/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|appointmentInstance/sale/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|appointmentInstance/sale/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/sale/associate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|appointmentInstance/sale/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|appointmentInstance/sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|appointmentInstance/sale/associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|appointmentInstance/sale/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|appointmentInstance/sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/sale/associate/otherGroups| *None* |Other groups: Other groups|  |
|appointmentInstance/sale/associate/userName| *None* |User name: User name|  |
|appointmentInstance/sale/associate/personEmail| *None* |E-mail|  |
|appointmentInstance/sale/saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|appointmentInstance/sale/saleUdef/SuperOffice:2| *None* |salelongtext|  |
|appointmentInstance/sale/saleUdef/SuperOffice:3| *None* |salenumber|  |
|appointmentInstance/sale/saleUdef/SuperOffice:4| *None* |saledate|  |
|appointmentInstance/sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|appointmentInstance/sale/saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|appointmentInstance/sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|appointmentInstance/sale/saleUdef/SuperOffice:8| *None* |saledecimal|  |
|appointmentInstance/associate/firstName| *None* |First name: Displays the contact's first name|  |
|appointmentInstance/associate/lastName| *None* |Last name: Displays the contact's last name|  |
|appointmentInstance/associate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|appointmentInstance/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|appointmentInstance/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|appointmentInstance/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|appointmentInstance/associate/associateDbId| *None* |ID|  |
|appointmentInstance/associate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|appointmentInstance/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|appointmentInstance/associate/usergroup| *None* |Primary group: The user's primary user group|  |
|appointmentInstance/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|appointmentInstance/associate/contactCategory| *None* |Category: Category|  |
|appointmentInstance/associate/role| *None* |Role : Role|  |
|appointmentInstance/associate/assocName| *None* |User ID : User ID|  |
|appointmentInstance/associate/assocTooltip| *None* |Description : Description|  |
|appointmentInstance/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|appointmentInstance/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|appointmentInstance/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/associate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|appointmentInstance/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|appointmentInstance/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|appointmentInstance/associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|appointmentInstance/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|appointmentInstance/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/associate/otherGroups| *None* |Other groups: Other groups|  |
|appointmentInstance/associate/userName| *None* |User name: User name|  |
|appointmentInstance/associate/personEmail| *None* |E-mail|  |
|appointmentInstance/appointment/textId| *None* |Text ID|  |
|appointmentInstance/appointment/description| *None* |Text: Displays the text entered in the description field|  |
|documentInstance/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed|  |
|documentInstance/icon| *None* |Category: Displays the icon for an activity type|  |
|documentInstance/date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|documentInstance/time| *None* |Time: Time|  |
|documentInstance/type| *None* |Type: Displays the type of an activity|  |
|documentInstance/recordType| *None* |Record type : Shows the record type|  |
|documentInstance/text| *None* |Text: Displays a descriptive text for the item|  |
|documentInstance/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|documentInstance/contactId| *None* |Company ID: Database ID of company|  |
|documentInstance/personId| *None* |Contact ID: Database ID of the contact row|  |
|documentInstance/projectId| *None* |Project ID: Database ID of project record|  |
|documentInstance/saleId| *None* |Sale ID: The database ID of the sale record|  |
|documentInstance/userGroup| *None* |User group : The user group that owns the record|  |
|documentInstance/who| *None* |Who: Contact and/or company|  |
|documentInstance/updatedBy| *None* |Updated by: The user who last updated the data|  |
|documentInstance/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|documentInstance/registeredBy| *None* |Registered by: The user who registered the data|  |
|documentInstance/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|documentInstance/documentId| *None* |Document ID: Database ID of document record|  |
|documentInstance/keywords| *None* |Keywords |  |
|documentInstance/ourref| *None* |Our ref.|  |
|documentInstance/yourref| *None* |Your ref.|  |
|documentInstance/attention| *None* |Salutation|  |
|documentInstance/subject| *None* |Subject|  |
|documentInstance/mailMergeDraft| *None* |Mail merge draft : Indicates whether the document is a mail merge template|  |
|documentInstance/snum| *None* |Document number: Serial number of document. It can be generated by the number allocation system for a dedicated document template.|  |
|documentInstance/isReport| *None* |Report: Is this document a saved report run?|  |
|documentInstance/suggestedDocumentId| *None* |Document ID (suggestion: The database ID of a document that originates in a suggestion|  |
|documentInstance/isMail| *None* |E-mail|  |
|documentInstance/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
|documentInstance/visibleFor| *None* |Visible for|  |
|documentInstance/documentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|documentInstance/documentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|documentInstance/documentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|documentInstance/documentPublish/publishedBy| *None* |Published by: Published by|  |
|documentInstance/person/personId| *None* |DB ID: Displays the database ID of a contact|  |
|documentInstance/person/firstName| *None* |First name: Displays the contact's first name|  |
|documentInstance/person/lastName| *None* |Last name: Displays the contact's last name|  |
|documentInstance/person/middleName| *None* |Middle name: Displays the contact's middle name.|  |
|documentInstance/person/fullName| *None* |Contact: Displays the contact to which an item is linked|  |
|documentInstance/person/contactId| *None* |Company ID: Database ID of company|  |
|documentInstance/person/hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|documentInstance/person/hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|documentInstance/person/personHasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|documentInstance/person/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/person/position| *None* |Position|  |
|documentInstance/person/personNumber| *None* |Number: Displays the contact's number|  |
|documentInstance/person/title| *None* |Title: Displays the contact's job title|  |
|documentInstance/person/personCountry| *None* |Country: Country|  |
|documentInstance/person/personNoMail| *None* |No Mailings: Displays the contact's No Mailings checkbox|  |
|documentInstance/person/rank| *None* |Rank: Displays a contact's current rank|  |
|documentInstance/person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|documentInstance/person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|documentInstance/person/useAsMailingAddress| *None* |Use as postal address: Use as postal address|  |
|documentInstance/person/personSource| *None* |Source: Source (Contact)|  |
|documentInstance/person/retired| *None* |Former employee: Indicates whether the contact has retired/left the company|  |
|documentInstance/person/birthYear| *None* |Birth year: Displays contact's birth year|  |
|documentInstance/person/birthMonth| *None* |Birth month: Displays contact's birth month|  |
|documentInstance/person/birthDay| *None* |Birth day: Displays contact's birth day (day of month)|  |
|documentInstance/person/kanaFirstName| *None* |First name, kana: Contact's first name, in kana alphabet|  |
|documentInstance/person/kanaLastName| *None* |Last name, kana: Contact's last name, in kana alphabet|  |
|documentInstance/person/personUpdatedBy| *None* |Updated by: The user who last updated the data|  |
|documentInstance/person/personUpdatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|documentInstance/person/personRegisteredBy| *None* |Registered by: The user who registered the data|  |
|documentInstance/person/personRegisteredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|documentInstance/person/portraitThumbnail| *None* |Person image: Person image|  |
|documentInstance/person/personActiveErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|documentInstance/person/ticketPriority| *None* |Service priority: Default service priority for this contact|  |
|documentInstance/person/supportLanguage| *None* |Preferred language: Preferred language used for reply templates and more|  |
|documentInstance/person/supportAssociate| *None* |Our service contact: Default service contact for this contact|  |
|documentInstance/person/personAssociateId| *None* |Our contact: Displays our contact|  |
|documentInstance/person/personCategory| *None* |Category|  |
|documentInstance/person/personBusiness| *None* |Business|  |
|documentInstance/person/personDeletedDate| *None* |Deleted date: Deleted date|  |
|documentInstance/person/hasCompany| *None* |Has company: The contact is associated with a company|  |
|documentInstance/person/isProjectMember| *None* |Is project member: This person is a project member|  |
|documentInstance/person/isStakeholder| *None* |Is stakeholder: This person is a sale stakeholder|  |
|documentInstance/person/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|documentInstance/person/personDirectPhone/formattedNumber| *None* |Direct - Phone: Displays phone number|  |
|documentInstance/person/personDirectPhone/description| *None* |Direct - Description: Phone number description|  |
|documentInstance/person/personMobilePhone/formattedNumber| *None* |Mobile - Phone: Displays phone number|  |
|documentInstance/person/personMobilePhone/description| *None* |Mobile - Description: Phone number description|  |
|documentInstance/person/personPrivate/formattedNumber| *None* |Private - Phone: Displays phone number|  |
|documentInstance/person/personPrivate/description| *None* |Private - Description: Phone number description|  |
|documentInstance/person/personPager/formattedNumber| *None* |Other - Phone: Displays phone number|  |
|documentInstance/person/personPager/description| *None* |Other - Description: Phone number description|  |
|documentInstance/person/personDirectFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|documentInstance/person/personDirectFax/description| *None* |Fax - Description: Phone number description|  |
|documentInstance/person/searchPhone/formattedNumber| *None* |Phone : Displays phone number|  |
|documentInstance/person/searchPhone/description| *None* |Description: Phone number description|  |
|documentInstance/person/personInfo/textId| *None* |Text ID|  |
|documentInstance/person/personInfo/infoText| *None* |Information: Displays the text entered in the description field|  |
|documentInstance/person/email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|documentInstance/person/email/emailAddress| *None* |E-mail|  |
|documentInstance/person/email/emailDescription| *None* |Description|  |
|documentInstance/person/email/emailId| *None* |ID|  |
|documentInstance/person/email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|documentInstance/person/email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|documentInstance/person/email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|documentInstance/person/email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|documentInstance/person/personUrl/URLAddress| *None* |URL|  |
|documentInstance/person/personUrl/URLDescription| *None* |Description|  |
|documentInstance/person/personAddress/addressId| *None* |Contact address - Address ID: Database ID for the address record|  |
|documentInstance/person/personAddress/line1| *None* |Contact address - Address 1: First line of the address|  |
|documentInstance/person/personAddress/line2| *None* |Contact address - Address 2: Second line of the address|  |
|documentInstance/person/personAddress/line3| *None* |Contact address - Address 3: Third line of the address|  |
|documentInstance/person/personAddress/county| *None* |Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|documentInstance/person/personAddress/city| *None* |Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|documentInstance/person/personAddress/zip| *None* |Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|documentInstance/person/personAddress/state| *None* |Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|documentInstance/person/personAddress/wgs84latitude| *None* |Contact address - Latitude: Latitude|  |
|documentInstance/person/personAddress/wgs84longitude| *None* |Contact address - Longitude: Longitude|  |
|documentInstance/person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|documentInstance/person/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|documentInstance/person/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|documentInstance/person/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|documentInstance/person/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|documentInstance/person/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|documentInstance/person/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|documentInstance/person/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|documentInstance/person/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|documentInstance/person/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|documentInstance/person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/personInterestIds| *None* |Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|documentInstance/person/personUdef/SuperOffice:1| *None* |contactshorttext: tooltipshorttext|  |
|documentInstance/person/personUdef/SuperOffice:2| *None* |contactlongtext: tooltiplongtext|  |
|documentInstance/person/personUdef/SuperOffice:3| *None* |contactnumber|  |
|documentInstance/person/personUdef/SuperOffice:4| *None* |contactdate|  |
|documentInstance/person/personUdef/SuperOffice:5| *None* |contactunlimiteddate: tooltipunlimiteddate|  |
|documentInstance/person/personUdef/SuperOffice:6| *None* |contactcheckbox|  |
|documentInstance/person/personUdef/SuperOffice:7| *None* |contactdropdownlistbox|  |
|documentInstance/person/personUdef/SuperOffice:8| *None* |contactdecimal|  |
|documentInstance/person/personUdef/SuperOffice:9| *None* |page1saleonly|  |
|documentInstance/person/personUdef/SuperOffice:10| *None* |page1marketingonly|  |
|documentInstance/person/personUdef/SuperOffice:11| *None* |page1adminonly|  |
|documentInstance/person/isMailingRecipient| *None* |isMailingRecipient: isMailingRecipient|  |
|documentInstance/person/hasStoreConsent| *None* |Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/withdrawnStoreConsent| *None* |Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/hasEmarketingConsent| *None* |Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/person/withdrawnEmarketingConsent| *None* |Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/person/subscription| *None* |Subscription: Subscription for marketing|  |
|documentInstance/person/legalBaseStore| *None* |Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/legalBaseEmarketing| *None* |Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/person/consentSourceStore| *None* |Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/consentSourceEmarketing| *None* |Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/contact/contactId| *None* |Company ID: Database ID of company|  |
|documentInstance/contact/name| *None* |Company name|  |
|documentInstance/contact/department| *None* |Department|  |
|documentInstance/contact/nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|documentInstance/contact/hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|documentInstance/contact/hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|documentInstance/contact/associateId| *None* |Our contact: Displays our contact|  |
|documentInstance/contact/category| *None* |Category|  |
|documentInstance/contact/business| *None* |Business|  |
|documentInstance/contact/country| *None* |Country: This criterion corresponds to the Country field on the Company card.|  |
|documentInstance/contact/number| *None* |Number|  |
|documentInstance/contact/code| *None* |Code|  |
|documentInstance/contact/orgnr| *None* |VAT No.|  |
|documentInstance/contact/stop| *None* |Stop|  |
|documentInstance/contact/contactNoMail| *None* |No mailings (company|  |
|documentInstance/contact/updatedBy| *None* |Updated by: The user who last updated the data|  |
|documentInstance/contact/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|documentInstance/contact/registeredBy| *None* |Registered by: The user who registered the data|  |
|documentInstance/contact/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|documentInstance/contact/contactSource| *None* |Source: Source (Company)|  |
|documentInstance/contact/contactDeleted| *None* |Deleted: Deleted|  |
|documentInstance/contact/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|documentInstance/contact/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|documentInstance/contact/deletedDate| *None* |Deleted date: Deleted date|  |
|documentInstance/contact/mainContact| *None* |Main contact: Main contact for this company|  |
|documentInstance/contact/contactPhone/formattedNumber| *None* |Telephone - Phone: Displays phone number|  |
|documentInstance/contact/contactPhone/description| *None* |Telephone - Description: Phone number description|  |
|documentInstance/contact/contactFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|documentInstance/contact/contactFax/description| *None* |Fax - Description: Phone number description|  |
|documentInstance/contact/searchPhone/formattedNumber| *None* |Searchphone - Phone: Displays phone number|  |
|documentInstance/contact/searchPhone/description| *None* |Searchphone - Description: Phone number description|  |
|documentInstance/contact/email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|documentInstance/contact/email/emailAddress| *None* |E-mail|  |
|documentInstance/contact/email/emailDescription| *None* |Description|  |
|documentInstance/contact/email/emailId| *None* |ID|  |
|documentInstance/contact/email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|documentInstance/contact/email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|documentInstance/contact/email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|documentInstance/contact/email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|documentInstance/contact/postAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|documentInstance/contact/postAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|documentInstance/contact/postAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|documentInstance/contact/postAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|documentInstance/contact/postAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|documentInstance/contact/postAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|documentInstance/contact/postAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|documentInstance/contact/postAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|documentInstance/contact/postAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|documentInstance/contact/postAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|documentInstance/contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|documentInstance/contact/streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|documentInstance/contact/streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|documentInstance/contact/streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|documentInstance/contact/streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|documentInstance/contact/streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|documentInstance/contact/streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|documentInstance/contact/streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|documentInstance/contact/streetAddress/wgs84latitude| *None* |Street address - Latitude: Latitude|  |
|documentInstance/contact/streetAddress/wgs84longitude| *None* |Street address - Longitude: Longitude|  |
|documentInstance/contact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|documentInstance/contact/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|documentInstance/contact/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|documentInstance/contact/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|documentInstance/contact/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|documentInstance/contact/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|documentInstance/contact/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|documentInstance/contact/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|documentInstance/contact/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|documentInstance/contact/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|documentInstance/contact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/url/URLAddress| *None* |URL|  |
|documentInstance/contact/url/URLDescription| *None* |Description|  |
|documentInstance/contact/contactAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|documentInstance/contact/contactAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|documentInstance/contact/contactAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|documentInstance/contact/contactAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|documentInstance/contact/contactAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|documentInstance/contact/contactAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|documentInstance/contact/contactAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/contact/contactAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/contact/contactAssociate/associateDbId| *None* |ID|  |
|documentInstance/contact/contactAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|documentInstance/contact/contactAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|documentInstance/contact/contactAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|documentInstance/contact/contactAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|documentInstance/contact/contactAssociate/contactCategory| *None* |Category: Category|  |
|documentInstance/contact/contactAssociate/role| *None* |Role : Role|  |
|documentInstance/contact/contactAssociate/assocName| *None* |User ID : User ID|  |
|documentInstance/contact/contactAssociate/assocTooltip| *None* |Description : Description|  |
|documentInstance/contact/contactAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|documentInstance/contact/contactAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|documentInstance/contact/contactAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|documentInstance/contact/contactAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|documentInstance/contact/contactAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|documentInstance/contact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|documentInstance/contact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|documentInstance/contact/contactAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|documentInstance/contact/contactAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|documentInstance/contact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|documentInstance/contact/contactAssociate/otherGroups| *None* |Other groups: Other groups|  |
|documentInstance/contact/contactAssociate/userName| *None* |User name: User name|  |
|documentInstance/contact/contactAssociate/personEmail| *None* |E-mail|  |
|documentInstance/contact/contactInterestIds| *None* |Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|documentInstance/contact/contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|documentInstance/contact/contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|documentInstance/contact/contactUdef/SuperOffice:3| *None* |companynumber|  |
|documentInstance/contact/contactUdef/SuperOffice:4| *None* |companydate|  |
|documentInstance/contact/contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|documentInstance/contact/contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|documentInstance/contact/contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|documentInstance/contact/contactUdef/SuperOffice:8| *None* |companydecimal|  |
|documentInstance/contact/contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|documentInstance/contact/contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|documentInstance/contact/contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|documentInstance/contact/contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|documentInstance/contact/contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|documentInstance/contact/NumberOfActivities| *None* |Number of activities|  |
|documentInstance/contact/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|documentInstance/contact/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|documentInstance/contact/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|documentInstance/contact/LastActivity| *None* |Date of last activity|  |
|documentInstance/contact/LastCompletedActivity| *None* |Date of last completed activity|  |
|documentInstance/contact/LastDoByActivity| *None* |Date of last non-completed activity|  |
|documentInstance/contact/NumberOfSales| *None* |Number of sales|  |
|documentInstance/contact/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|documentInstance/contact/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|documentInstance/contact/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|documentInstance/contact/LastSale| *None* |Date of last sale|  |
|documentInstance/contact/LastCompletedSale| *None* |Date of last completed sale|  |
|documentInstance/contact/LastDoBySale| *None* |Date of last non-completed sale|  |
|documentInstance/contact/NumberOfTickets| *None* |Number of requests|  |
|documentInstance/contact/NumberOfTicketsInPeriod| *None* |Number of requests in last 90 days|  |
|documentInstance/contact/NumberOfNotCompletedTickets| *None* |Number of non-completed requests|  |
|documentInstance/contact/NumberOfNotCompletedTicketsInPeriod| *None* |Number of non-completed requests in last 90 days|  |
|documentInstance/contact/LastTicket| *None* |Date of last request|  |
|documentInstance/contact/LastCompletedTicket| *None* |Date of last completed request|  |
|documentInstance/contact/LastDoByTicket| *None* |Date of last non-completed request|  |
|documentInstance/contact/SaintStatus1| *None* |Neglected customer|  |
|documentInstance/contact/SaintStatus2| *None* |C-company|  |
|documentInstance/contact/saintSaleStatus| *None* |With status|  |
|documentInstance/contact/saintAmountClass| *None* |Amount class|  |
|documentInstance/contact/saintActivityType| *None* |SAINT type|  |
|documentInstance/contact/saintDirection| *None* |Direction|  |
|documentInstance/contact/saintIntention| *None* |Intention|  |
|documentInstance/contact/saintTicketStatus| *None* |Status|  |
|documentInstance/contact/saintTicketCategory| *None* |Category|  |
|documentInstance/project/completed| *None* |Completed: Displays a check mark indicating if the project has been completed.|  |
|documentInstance/project/projectId| *None* |DB ID: Displays the database ID for a project row|  |
|documentInstance/project/name| *None* |Project name: Displays the Project's name|  |
|documentInstance/project/number| *None* |Number: Displays the project's number|  |
|documentInstance/project/type| *None* |Project type: Displays the project's type|  |
|documentInstance/project/status| *None* |Status: Displays the project's status|  |
|documentInstance/project/associateId| *None* |ID: Displays login ID of the associate who owns the project|  |
|documentInstance/project/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|documentInstance/project/icon| *None* |Category: Displays the icon for an activity type|  |
|documentInstance/project/text| *None* |Text: Displays a descriptive text for the item|  |
|documentInstance/project/description| *None* |Description : Description|  |
|documentInstance/project/updatedBy| *None* |Updated by: The user who last updated the data|  |
|documentInstance/project/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|documentInstance/project/registeredBy| *None* |Registered by: The user who registered the data|  |
|documentInstance/project/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|documentInstance/project/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|documentInstance/project/nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|documentInstance/project/endDate| *None* |End date: End date of project|  |
|documentInstance/project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|documentInstance/project/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|documentInstance/project/projectPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|documentInstance/project/projectPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|documentInstance/project/projectPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|documentInstance/project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|documentInstance/project/projectEvent/isExternalEvent| *None* |Event: Is this an external event|  |
|documentInstance/project/projectEvent/eventDate| *None* |Event date: Event date|  |
|documentInstance/project/projectEvent/hasSignOn| *None* |Sign On: Does this event have the Sign On function enabled|  |
|documentInstance/project/projectEvent/hasSignOff| *None* |Sign Off: Does this event have the Sign Off function enabled|  |
|documentInstance/project/projectUrl/URLAddress| *None* |URL|  |
|documentInstance/project/projectUrl/URLDescription| *None* |Description|  |
|documentInstance/project/projectAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|documentInstance/project/projectAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|documentInstance/project/projectAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|documentInstance/project/projectAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|documentInstance/project/projectAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|documentInstance/project/projectAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|documentInstance/project/projectAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/project/projectAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/project/projectAssociate/associateDbId| *None* |ID|  |
|documentInstance/project/projectAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|documentInstance/project/projectAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|documentInstance/project/projectAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|documentInstance/project/projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|documentInstance/project/projectAssociate/contactCategory| *None* |Category: Category|  |
|documentInstance/project/projectAssociate/role| *None* |Role : Role|  |
|documentInstance/project/projectAssociate/assocName| *None* |User ID : User ID|  |
|documentInstance/project/projectAssociate/assocTooltip| *None* |Description : Description|  |
|documentInstance/project/projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|documentInstance/project/projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|documentInstance/project/projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|documentInstance/project/projectAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|documentInstance/project/projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|documentInstance/project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|documentInstance/project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|documentInstance/project/projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|documentInstance/project/projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|documentInstance/project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|documentInstance/project/projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|documentInstance/project/projectAssociate/userName| *None* |User name: User name|  |
|documentInstance/project/projectAssociate/personEmail| *None* |E-mail|  |
|documentInstance/project/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|documentInstance/project/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|documentInstance/project/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|documentInstance/project/projectUdef/SuperOffice:4| *None* |projectdate|  |
|documentInstance/project/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|documentInstance/project/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|documentInstance/project/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|documentInstance/project/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|documentInstance/project/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|documentInstance/project/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|documentInstance/project/NumberOfActivities| *None* |Number of activities|  |
|documentInstance/project/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|documentInstance/project/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|documentInstance/project/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|documentInstance/project/LastActivity| *None* |Date of last activity|  |
|documentInstance/project/LastCompletedActivity| *None* |Date of last completed activity|  |
|documentInstance/project/LastDoByActivity| *None* |Date of last non-completed activity|  |
|documentInstance/project/NumberOfSales| *None* |Number of sales|  |
|documentInstance/project/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|documentInstance/project/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|documentInstance/project/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|documentInstance/project/LastSale| *None* |Date of last sale|  |
|documentInstance/project/LastCompletedSale| *None* |Date of last completed sale|  |
|documentInstance/project/LastDoBySale| *None* |Date of last non-completed sale|  |
|documentInstance/project/SaintStatus3| *None* |Not completed activites with intention sale|  |
|documentInstance/project/saintSaleStatus| *None* |With status|  |
|documentInstance/project/saintAmountClass| *None* |Amount class|  |
|documentInstance/project/saintActivityType| *None* |SAINT type|  |
|documentInstance/project/saintDirection| *None* |Direction|  |
|documentInstance/project/saintIntention| *None* |Intention|  |
|documentInstance/project/saintTicketStatus| *None* |Status|  |
|documentInstance/project/saintTicketCategory| *None* |Category|  |
|documentInstance/project/project/textId| *None* |Text ID|  |
|documentInstance/project/project/infoText| *None* |Information: Displays the text entered in the description field|  |
|documentInstance/associate/firstName| *None* |First name: Displays the contact's first name|  |
|documentInstance/associate/lastName| *None* |Last name: Displays the contact's last name|  |
|documentInstance/associate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|documentInstance/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|documentInstance/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|documentInstance/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|documentInstance/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/associate/associateDbId| *None* |ID|  |
|documentInstance/associate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|documentInstance/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|documentInstance/associate/usergroup| *None* |Primary group: The user's primary user group|  |
|documentInstance/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|documentInstance/associate/contactCategory| *None* |Category: Category|  |
|documentInstance/associate/role| *None* |Role : Role|  |
|documentInstance/associate/assocName| *None* |User ID : User ID|  |
|documentInstance/associate/assocTooltip| *None* |Description : Description|  |
|documentInstance/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|documentInstance/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|documentInstance/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|documentInstance/associate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|documentInstance/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|documentInstance/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|documentInstance/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|documentInstance/associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|documentInstance/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|documentInstance/associate/portraitThumbnail| *None* |Person image: Person image|  |
|documentInstance/associate/otherGroups| *None* |Other groups: Other groups|  |
|documentInstance/associate/userName| *None* |User name: User name|  |
|documentInstance/associate/personEmail| *None* |E-mail|  |
|documentInstance/documentUdef/SuperOffice:1| *None* |documentshorttext|  |
|documentInstance/documentUdef/SuperOffice:2| *None* |documentlongtext|  |
|documentInstance/documentUdef/SuperOffice:3| *None* |documentnumber|  |
|documentInstance/documentUdef/SuperOffice:4| *None* |documentdate|  |
|documentInstance/documentUdef/SuperOffice:5| *None* |documentunlimiteddate|  |
|documentInstance/documentUdef/SuperOffice:6| *None* |documentcheckbox|  |
|documentInstance/documentUdef/SuperOffice:7| *None* |documentdropdownlistbox|  |
|documentInstance/documentUdef/SuperOffice:8| *None* |documentdecimal|  |
|documentInstance/sale/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed|  |
|documentInstance/sale/icon| *None* |Category: Displays the icon for an activity type|  |
|documentInstance/sale/date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|documentInstance/sale/time| *None* |Time: Time|  |
|documentInstance/sale/type| *None* |Type: Displays the type of an activity|  |
|documentInstance/sale/recordType| *None* |Record type : Shows the record type|  |
|documentInstance/sale/text| *None* |Text: Displays a descriptive text for the item|  |
|documentInstance/sale/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|documentInstance/sale/contactId| *None* |Company ID: Database ID of company|  |
|documentInstance/sale/personId| *None* |Contact ID: Database ID of the contact row|  |
|documentInstance/sale/projectId| *None* |Project ID: Database ID of project record|  |
|documentInstance/sale/saleId| *None* |Sale ID: The database ID of the sale record|  |
|documentInstance/sale/userGroup| *None* |User group : The user group that owns the record|  |
|documentInstance/sale/who| *None* |Who: Contact and/or company|  |
|documentInstance/sale/updatedBy| *None* |Updated by: The user who last updated the data|  |
|documentInstance/sale/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|documentInstance/sale/registeredBy| *None* |Registered by: The user who registered the data|  |
|documentInstance/sale/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|documentInstance/sale/currencyId| *None* |Currency ID: The currency list item ID|  |
|documentInstance/sale/currency| *None* |Currency: The currency of the sale|  |
|documentInstance/sale/credited| *None* |Credited: The user to be credited with the sale|  |
|documentInstance/sale/lossReason| *None* |Reason (lost: The reason for losing the sale|  |
|documentInstance/sale/source| *None* |Source: The source (lead) of the sale|  |
|documentInstance/sale/competitor| *None* |Competitor: The competitor who won the sale|  |
|documentInstance/sale/heading| *None* |Sale: Displays a descriptive text for the item|  |
|documentInstance/sale/amount| *None* |Amount: The gross sales total|  |
|documentInstance/sale/amountWeighted| *None* |Weighted amount: Virtual field calculated from amount * probability percent.|  |
|documentInstance/sale/earning| *None* |Profit: Gross profit (gross sales total - cost) for the sale|  |
|documentInstance/sale/earningPercent| *None* |Profit as % : The profit as a percentage of the gross sales total|  |
|documentInstance/sale/probPercent| *None* |Probability as %: Probability as %|  |
|documentInstance/sale/originalStage| *None* |Stage: Displays the stage of the sale|  |
|documentInstance/sale/stage| *None* |Stage: Displays the stage of the sale|  |
|documentInstance/sale/saleStatus| *None* |Status: The status of the sale - open, lost or sold|  |
|documentInstance/sale/saleType| *None* |Sale type: Sale type, from list|  |
|documentInstance/sale/nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|documentInstance/sale/reopenDate| *None* |Reopen date: Displays the reopen date for the sale|  |
|documentInstance/sale/stalledComment| *None* |Reason (stalled: The reason the sale has been stalled|  |
|documentInstance/sale/soldReason| *None* |Reason (sold: Reason (sold)|  |
|documentInstance/sale/saleNumber| *None* |Number: Number|  |
|documentInstance/sale/hasStakeholders| *None* |Has stakeholders: Does this sale have stakeholders enabled|  |
|documentInstance/sale/hasQuote| *None* |Has quote?: Does the sale have a quote attached?|  |
|documentInstance/sale/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|documentInstance/sale/description| *None* |Description: The long description field on Sale|  |
|documentInstance/sale/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|documentInstance/sale/visibleFor| *None* |Visible for|  |
|documentInstance/sale/sale/textId| *None* |Text ID|  |
|documentInstance/sale/sale/description| *None* |Text: Displays the text entered in the description field|  |
|documentInstance/sale/salePublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|documentInstance/sale/salePublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|documentInstance/sale/salePublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|documentInstance/sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|documentInstance/sale/associate/firstName| *None* |First name: Displays the contact's first name|  |
|documentInstance/sale/associate/lastName| *None* |Last name: Displays the contact's last name|  |
|documentInstance/sale/associate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|documentInstance/sale/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|documentInstance/sale/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|documentInstance/sale/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|documentInstance/sale/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/sale/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|documentInstance/sale/associate/associateDbId| *None* |ID|  |
|documentInstance/sale/associate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|documentInstance/sale/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|documentInstance/sale/associate/usergroup| *None* |Primary group: The user's primary user group|  |
|documentInstance/sale/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|documentInstance/sale/associate/contactCategory| *None* |Category: Category|  |
|documentInstance/sale/associate/role| *None* |Role : Role|  |
|documentInstance/sale/associate/assocName| *None* |User ID : User ID|  |
|documentInstance/sale/associate/assocTooltip| *None* |Description : Description|  |
|documentInstance/sale/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|documentInstance/sale/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|documentInstance/sale/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|documentInstance/sale/associate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|documentInstance/sale/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|documentInstance/sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|documentInstance/sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|documentInstance/sale/associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|documentInstance/sale/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|documentInstance/sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|documentInstance/sale/associate/otherGroups| *None* |Other groups: Other groups|  |
|documentInstance/sale/associate/userName| *None* |User name: User name|  |
|documentInstance/sale/associate/personEmail| *None* |E-mail|  |
|documentInstance/sale/saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|documentInstance/sale/saleUdef/SuperOffice:2| *None* |salelongtext|  |
|documentInstance/sale/saleUdef/SuperOffice:3| *None* |salenumber|  |
|documentInstance/sale/saleUdef/SuperOffice:4| *None* |saledate|  |
|documentInstance/sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|documentInstance/sale/saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|documentInstance/sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|documentInstance/sale/saleUdef/SuperOffice:8| *None* |saledecimal|  |
|documentInstance/document/textId| *None* |Text ID|  |
|documentInstance/document/description| *None* |Text: Displays the text entered in the description field|  |

## Sample

```http!
GET /api/v1/archive/ProjectGuide?$select=appointmentInstance/isMilestone,appointmentInstance/contact/contactUdef/SuperOffice:4,appointmentInstance/contact/NumberOfActivities,appointmentInstance/person/personAddress/line3,appointmentInstance/project/projectUdef/SuperOffice:5
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

