---
uid: SaleGuideAppointment
title: SaleGuideAppointment
description: Specific provider for Sale Guide Items of type Appointment
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "SaleGuideAppointment"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "SaleGuideAppointment"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SaleGuideAppointmentProvider">SuperOffice.CRM.ArchiveLists.SaleGuideAppointmentProvider</see> inside NetServer's SODatabase assembly.

Specific provider for Sale Guide Items of type Appointment

This class provides the needed overrides and concrete implementations needed by the base class
to drive the sentry calculations, as well as the specialization with the correct root extender

## Supported Entities
| Name | Description |
| ---- | ----- |
|"suggestedAppointment"|Follow-ups|
|"appointment"|Follow-ups|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|saleId|int|Sale ID: The database ID of the sale record| x |
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
|isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|appointmentInstance/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|appointmentInstance/icon| *None* |Category: Displays the icon for an activity type| x |
|appointmentInstance/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|appointmentInstance/time| *None* |Time: Time|  |
|appointmentInstance/type|listAny|Type: Displays the type of an activity| x |
|appointmentInstance/recordType|string|Record type : Shows the record type| x |
|appointmentInstance/text|positiveString|Text: Displays a descriptive text for the item| x |
|appointmentInstance/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|appointmentInstance/contactId|listAny|Company ID: Database ID of company| x |
|appointmentInstance/personId|listAny|Contact ID: Database ID of the contact row| x |
|appointmentInstance/projectId|listAny|Project ID: Database ID of project record| x |
|appointmentInstance/saleId|int|Sale ID: The database ID of the sale record| x |
|appointmentInstance/userGroup|userGroup|User group : The user group that owns the record| x |
|appointmentInstance/who| *None* |Who: Contact and/or company|  |
|appointmentInstance/updatedBy|associate|Updated by: The user who last updated the data| x |
|appointmentInstance/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointmentInstance/registeredBy|associate|Registered by: The user who registered the data| x |
|appointmentInstance/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointmentInstance/appointmentId|int|DB ID: Displays the database ID of a row| x |
|appointmentInstance/endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|appointmentInstance/priority|listAny|Priority: Displays the priority of the activity| x |
|appointmentInstance/alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|appointmentInstance/recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|appointmentInstance/booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|appointmentInstance/intention|listAny|Intention: Displays the intention of the follow-up type| x |
|appointmentInstance/location|string|Location: Display the location where the follow-up will take place.| x |
|appointmentInstance/recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up| x |
|appointmentInstance/rawType|int|Type: Type field for appointment, not decoded or formatted| x |
|appointmentInstance/rawStatus|int|Status: Status field for the follow-up, not decoded or formatted| x |
|appointmentInstance/cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|appointmentInstance/visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?| x |
|appointmentInstance/endTime| *None* |End time: End time of an activity|  |
|appointmentInstance/suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|appointmentInstance/completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|appointmentInstance/isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|appointmentInstance/invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|appointmentInstance/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|appointmentInstance/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|appointmentInstance/visibleFor|listAny|Visible for|  |
|appointmentInstance/appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointmentInstance/appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointmentInstance/appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|appointmentInstance/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointmentInstance/contact/contactId|int|Company ID: Database ID of company| x |
|appointmentInstance/contact/name|stringorPK|Company name| x |
|appointmentInstance/contact/department|string|Department| x |
|appointmentInstance/contact/nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|appointmentInstance/contact/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|appointmentInstance/contact/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|appointmentInstance/contact/associateId|associate|Our contact: Displays our contact| x |
|appointmentInstance/contact/category|listAny|Category| x |
|appointmentInstance/contact/business|listAny|Business| x |
|appointmentInstance/contact/country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|appointmentInstance/contact/number|string|Number| x |
|appointmentInstance/contact/code|string|Code| x |
|appointmentInstance/contact/orgnr|string|VAT No.| x |
|appointmentInstance/contact/stop|bool|Stop| x |
|appointmentInstance/contact/contactNoMail|bool|No mailings (company| x |
|appointmentInstance/contact/updatedBy|associate|Updated by: The user who last updated the data| x |
|appointmentInstance/contact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointmentInstance/contact/registeredBy|associate|Registered by: The user who registered the data| x |
|appointmentInstance/contact/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointmentInstance/contact/contactSource|listAny|Source: Source (Company)| x |
|appointmentInstance/contact/contactDeleted|bool|Deleted: Deleted| x |
|appointmentInstance/contact/phone/formattedNumber|string|Phone : Displays phone number|  |
|appointmentInstance/contact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|appointmentInstance/contact/deletedDate|datetime|Deleted date: Deleted date|  |
|appointmentInstance/contact/mainContact| *None* |Main contact: Main contact for this company| x |
|appointmentInstance/contact/contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|appointmentInstance/contact/contactPhone/description|string|Telephone - Description: Phone number description| x |
|appointmentInstance/contact/contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|appointmentInstance/contact/contactFax/description|string|Fax - Description: Phone number description| x |
|appointmentInstance/contact/searchPhone/formattedNumber|string|Searchphone - Phone: Displays phone number|  |
|appointmentInstance/contact/searchPhone/description|string|Searchphone - Description: Phone number description| x |
|appointmentInstance/contact/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|appointmentInstance/contact/email/emailAddress|string|E-mail| x |
|appointmentInstance/contact/email/emailDescription|string|Description| x |
|appointmentInstance/contact/email/emailId|int|ID| x |
|appointmentInstance/contact/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|appointmentInstance/contact/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|appointmentInstance/contact/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|appointmentInstance/contact/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|appointmentInstance/contact/postAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|appointmentInstance/contact/postAddress/line1|string|Postal address - Address 1: First line of the address| x |
|appointmentInstance/contact/postAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|appointmentInstance/contact/postAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|appointmentInstance/contact/postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|appointmentInstance/contact/postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|appointmentInstance/contact/postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|appointmentInstance/contact/postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|appointmentInstance/contact/postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|appointmentInstance/contact/postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|appointmentInstance/contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/streetAddress/addressId|int|Street address - Address ID: Database ID for the address record| x |
|appointmentInstance/contact/streetAddress/line1|string|Street address - Address 1: First line of the address| x |
|appointmentInstance/contact/streetAddress/line2|string|Street address - Address 2: Second line of the address| x |
|appointmentInstance/contact/streetAddress/line3|string|Street address - Address 3: Third line of the address| x |
|appointmentInstance/contact/streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|appointmentInstance/contact/streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.| x |
|appointmentInstance/contact/streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|appointmentInstance/contact/streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|appointmentInstance/contact/streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude| x |
|appointmentInstance/contact/streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude| x |
|appointmentInstance/contact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|appointmentInstance/contact/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|appointmentInstance/contact/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|appointmentInstance/contact/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|appointmentInstance/contact/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|appointmentInstance/contact/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|appointmentInstance/contact/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|appointmentInstance/contact/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|appointmentInstance/contact/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|appointmentInstance/contact/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|appointmentInstance/contact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/url/URLAddress|string|URL| x |
|appointmentInstance/contact/url/URLDescription|string|Description| x |
|appointmentInstance/contact/contactAssociate/firstName|string|First name: Displays the contact's first name| x |
|appointmentInstance/contact/contactAssociate/lastName|string|Last name: Displays the contact's last name| x |
|appointmentInstance/contact/contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|appointmentInstance/contact/contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|appointmentInstance/contact/contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/contact/contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|appointmentInstance/contact/contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/contact/contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/contact/contactAssociate/associateDbId|associate|ID| x |
|appointmentInstance/contact/contactAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|appointmentInstance/contact/contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|appointmentInstance/contact/contactAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|appointmentInstance/contact/contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|appointmentInstance/contact/contactAssociate/contactCategory|listAny|Category: Category| x |
|appointmentInstance/contact/contactAssociate/role|listAny|Role : Role| x |
|appointmentInstance/contact/contactAssociate/assocName|associate|User ID : User ID| x |
|appointmentInstance/contact/contactAssociate/assocTooltip|string|Description : Description|  |
|appointmentInstance/contact/contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|appointmentInstance/contact/contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|appointmentInstance/contact/contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/contact/contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|appointmentInstance/contact/contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/contact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointmentInstance/contact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointmentInstance/contact/contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|appointmentInstance/contact/contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|appointmentInstance/contact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/contact/contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|appointmentInstance/contact/contactAssociate/userName|string|User name: User name| x |
|appointmentInstance/contact/contactAssociate/personEmail|string|E-mail| x |
|appointmentInstance/contact/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|appointmentInstance/contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|appointmentInstance/contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|appointmentInstance/contact/contactUdef/SuperOffice:3|int|companynumber| x |
|appointmentInstance/contact/contactUdef/SuperOffice:4|date|companydate| x |
|appointmentInstance/contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|appointmentInstance/contact/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|appointmentInstance/contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|appointmentInstance/contact/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|appointmentInstance/contact/contactUdef/SuperOffice:9|string|page1saleonly| x |
|appointmentInstance/contact/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|appointmentInstance/contact/contactUdef/SuperOffice:11|string|page1adminonly| x |
|appointmentInstance/contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|appointmentInstance/contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|appointmentInstance/contact/NumberOfActivities|int|Number of activities|  |
|appointmentInstance/contact/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|appointmentInstance/contact/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|appointmentInstance/contact/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|appointmentInstance/contact/LastActivity|date|Date of last activity|  |
|appointmentInstance/contact/LastCompletedActivity|date|Date of last completed activity|  |
|appointmentInstance/contact/LastDoByActivity|date|Date of last non-completed activity|  |
|appointmentInstance/contact/NumberOfSales|int|Number of sales|  |
|appointmentInstance/contact/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|appointmentInstance/contact/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|appointmentInstance/contact/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|appointmentInstance/contact/LastSale|date|Date of last sale|  |
|appointmentInstance/contact/LastCompletedSale|date|Date of last completed sale|  |
|appointmentInstance/contact/LastDoBySale|date|Date of last non-completed sale|  |
|appointmentInstance/contact/NumberOfTickets|int|Number of requests|  |
|appointmentInstance/contact/NumberOfTicketsInPeriod|int|Number of requests in last 90 days|  |
|appointmentInstance/contact/NumberOfNotCompletedTickets|int|Number of non-completed requests|  |
|appointmentInstance/contact/NumberOfNotCompletedTicketsInPeriod|int|Number of non-completed requests in last 90 days|  |
|appointmentInstance/contact/LastTicket|date|Date of last request|  |
|appointmentInstance/contact/LastCompletedTicket|date|Date of last completed request|  |
|appointmentInstance/contact/LastDoByTicket|date|Date of last non-completed request|  |
|appointmentInstance/contact/SaintStatus1|saintStatus|Neglected customer|  |
|appointmentInstance/contact/SaintStatus2|saintStatus|C-company|  |
|appointmentInstance/contact/saintSaleStatus|listAny|With status|  |
|appointmentInstance/contact/saintAmountClass|listAny|Amount class|  |
|appointmentInstance/contact/saintActivityType|listAny|SAINT type|  |
|appointmentInstance/contact/saintDirection|listAny|Direction|  |
|appointmentInstance/contact/saintIntention|listAny|Intention|  |
|appointmentInstance/contact/saintTicketStatus|listAny|Status|  |
|appointmentInstance/contact/saintTicketCategory|listAny|Category|  |
|appointmentInstance/person/personId|int|DB ID: Displays the database ID of a contact| x |
|appointmentInstance/person/firstName|string|First name: Displays the contact's first name| x |
|appointmentInstance/person/lastName|string|Last name: Displays the contact's last name| x |
|appointmentInstance/person/middleName|string|Middle name: Displays the contact's middle name.| x |
|appointmentInstance/person/fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
|appointmentInstance/person/contactId|int|Company ID: Database ID of company| x |
|appointmentInstance/person/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|appointmentInstance/person/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|appointmentInstance/person/personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|appointmentInstance/person/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/person/position|listAny|Position| x |
|appointmentInstance/person/personNumber|string|Number: Displays the contact's number| x |
|appointmentInstance/person/title|string|Title: Displays the contact's job title| x |
|appointmentInstance/person/personCountry|listAny|Country: Country| x |
|appointmentInstance/person/personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox| x |
|appointmentInstance/person/rank|int|Rank: Displays a contact's current rank| x |
|appointmentInstance/person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|appointmentInstance/person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|appointmentInstance/person/useAsMailingAddress|bool|Use as postal address: Use as postal address| x |
|appointmentInstance/person/personSource|listAny|Source: Source (Contact)| x |
|appointmentInstance/person/retired|bool|Former employee: Indicates whether the contact has retired/left the company| x |
|appointmentInstance/person/birthYear|int|Birth year: Displays contact's birth year| x |
|appointmentInstance/person/birthMonth|int|Birth month: Displays contact's birth month| x |
|appointmentInstance/person/birthDay|int|Birth day: Displays contact's birth day (day of month)| x |
|appointmentInstance/person/kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet| x |
|appointmentInstance/person/kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet| x |
|appointmentInstance/person/personUpdatedBy|associate|Updated by: The user who last updated the data| x |
|appointmentInstance/person/personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointmentInstance/person/personRegisteredBy|associate|Registered by: The user who registered the data| x |
|appointmentInstance/person/personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointmentInstance/person/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/person/personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|appointmentInstance/person/ticketPriority|listAny|Service priority: Default service priority for this contact| x |
|appointmentInstance/person/supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|appointmentInstance/person/supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|appointmentInstance/person/personAssociateId|associate|Our contact: Displays our contact| x |
|appointmentInstance/person/personCategory|listAny|Category| x |
|appointmentInstance/person/personBusiness|listAny|Business| x |
|appointmentInstance/person/personDeletedDate|datetime|Deleted date: Deleted date|  |
|appointmentInstance/person/hasCompany|bool|Has company: The contact is associated with a company| x |
|appointmentInstance/person/isProjectMember|bool|Is project member: This person is a project member| x |
|appointmentInstance/person/isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|appointmentInstance/person/phone/formattedNumber|string|Phone : Displays phone number|  |
|appointmentInstance/person/personDirectPhone/formattedNumber|string|Direct - Phone: Displays phone number|  |
|appointmentInstance/person/personDirectPhone/description|string|Direct - Description: Phone number description| x |
|appointmentInstance/person/personMobilePhone/formattedNumber|string|Mobile - Phone: Displays phone number|  |
|appointmentInstance/person/personMobilePhone/description|string|Mobile - Description: Phone number description| x |
|appointmentInstance/person/personPrivate/formattedNumber|string|Private - Phone: Displays phone number|  |
|appointmentInstance/person/personPrivate/description|string|Private - Description: Phone number description| x |
|appointmentInstance/person/personPager/formattedNumber|string|Other - Phone: Displays phone number|  |
|appointmentInstance/person/personPager/description|string|Other - Description: Phone number description| x |
|appointmentInstance/person/personDirectFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|appointmentInstance/person/personDirectFax/description|string|Fax - Description: Phone number description| x |
|appointmentInstance/person/searchPhone/formattedNumber|string|Phone : Displays phone number|  |
|appointmentInstance/person/searchPhone/description|string|Description: Phone number description| x |
|appointmentInstance/person/personInfo/textId|int|Text ID| x |
|appointmentInstance/person/personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|appointmentInstance/person/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|appointmentInstance/person/email/emailAddress|string|E-mail| x |
|appointmentInstance/person/email/emailDescription|string|Description| x |
|appointmentInstance/person/email/emailId|int|ID| x |
|appointmentInstance/person/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|appointmentInstance/person/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|appointmentInstance/person/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|appointmentInstance/person/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|appointmentInstance/person/personUrl/URLAddress|string|URL| x |
|appointmentInstance/person/personUrl/URLDescription|string|Description| x |
|appointmentInstance/person/personAddress/addressId|int|Contact address - Address ID: Database ID for the address record| x |
|appointmentInstance/person/personAddress/line1|string|Contact address - Address 1: First line of the address| x |
|appointmentInstance/person/personAddress/line2|string|Contact address - Address 2: Second line of the address| x |
|appointmentInstance/person/personAddress/line3|string|Contact address - Address 3: Third line of the address| x |
|appointmentInstance/person/personAddress/county|string|Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|appointmentInstance/person/personAddress/city|string|Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|appointmentInstance/person/personAddress/zip|string|Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|appointmentInstance/person/personAddress/state|string|Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|appointmentInstance/person/personAddress/wgs84latitude|decimal|Contact address - Latitude: Latitude| x |
|appointmentInstance/person/personAddress/wgs84longitude|decimal|Contact address - Longitude: Longitude| x |
|appointmentInstance/person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|appointmentInstance/person/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|appointmentInstance/person/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|appointmentInstance/person/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|appointmentInstance/person/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|appointmentInstance/person/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|appointmentInstance/person/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|appointmentInstance/person/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|appointmentInstance/person/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|appointmentInstance/person/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|appointmentInstance/person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|appointmentInstance/person/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|appointmentInstance/person/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|appointmentInstance/person/personUdef/SuperOffice:3|int|contactnumber| x |
|appointmentInstance/person/personUdef/SuperOffice:4|date|contactdate| x |
|appointmentInstance/person/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|appointmentInstance/person/personUdef/SuperOffice:6|bool|contactcheckbox| x |
|appointmentInstance/person/personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|appointmentInstance/person/personUdef/SuperOffice:8|decimal|contactdecimal| x |
|appointmentInstance/person/personUdef/SuperOffice:9|string|page1saleonly| x |
|appointmentInstance/person/personUdef/SuperOffice:10|string|page1marketingonly| x |
|appointmentInstance/person/personUdef/SuperOffice:11|string|page1adminonly| x |
|appointmentInstance/person/isMailingRecipient|bool|isMailingRecipient: isMailingRecipient| x |
|appointmentInstance/person/hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/subscription|listAny|Subscription: Subscription for marketing| x |
|appointmentInstance/person/legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|appointmentInstance/person/legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|appointmentInstance/person/consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|appointmentInstance/person/consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|appointmentInstance/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|appointmentInstance/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|appointmentInstance/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|appointmentInstance/appointmentUdef/SuperOffice:4|date|followupdate| x |
|appointmentInstance/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|appointmentInstance/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|appointmentInstance/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|appointmentInstance/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|appointmentInstance/project/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|appointmentInstance/project/projectId|int|DB ID: Displays the database ID for a project row| x |
|appointmentInstance/project/name|stringorPK|Project name: Displays the Project's name| x |
|appointmentInstance/project/number|string|Number: Displays the project's number| x |
|appointmentInstance/project/type|listAny|Project type: Displays the project's type| x |
|appointmentInstance/project/status|listAny|Status: Displays the project's status| x |
|appointmentInstance/project/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|appointmentInstance/project/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|appointmentInstance/project/icon| *None* |Category: Displays the icon for an activity type| x |
|appointmentInstance/project/text|string|Text: Displays a descriptive text for the item| x |
|appointmentInstance/project/description|string|Description : Description| x |
|appointmentInstance/project/updatedBy|associate|Updated by: The user who last updated the data| x |
|appointmentInstance/project/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointmentInstance/project/registeredBy|associate|Registered by: The user who registered the data| x |
|appointmentInstance/project/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointmentInstance/project/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|appointmentInstance/project/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|appointmentInstance/project/endDate|date|End date: End date of project| x |
|appointmentInstance/project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|appointmentInstance/project/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|appointmentInstance/project/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointmentInstance/project/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointmentInstance/project/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|appointmentInstance/project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|appointmentInstance/project/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|appointmentInstance/project/projectEvent/eventDate|date|Event date: Event date| x |
|appointmentInstance/project/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|appointmentInstance/project/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|appointmentInstance/project/projectUrl/URLAddress|string|URL| x |
|appointmentInstance/project/projectUrl/URLDescription|string|Description| x |
|appointmentInstance/project/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|appointmentInstance/project/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|appointmentInstance/project/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|appointmentInstance/project/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|appointmentInstance/project/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/project/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|appointmentInstance/project/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/project/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/project/projectAssociate/associateDbId|associate|ID| x |
|appointmentInstance/project/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|appointmentInstance/project/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|appointmentInstance/project/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|appointmentInstance/project/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|appointmentInstance/project/projectAssociate/contactCategory|listAny|Category: Category| x |
|appointmentInstance/project/projectAssociate/role|listAny|Role : Role| x |
|appointmentInstance/project/projectAssociate/assocName|associate|User ID : User ID| x |
|appointmentInstance/project/projectAssociate/assocTooltip|string|Description : Description|  |
|appointmentInstance/project/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|appointmentInstance/project/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|appointmentInstance/project/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/project/projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|appointmentInstance/project/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointmentInstance/project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointmentInstance/project/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|appointmentInstance/project/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|appointmentInstance/project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/project/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|appointmentInstance/project/projectAssociate/userName|string|User name: User name| x |
|appointmentInstance/project/projectAssociate/personEmail|string|E-mail| x |
|appointmentInstance/project/projectUdef/SuperOffice:1|string|projectshorttext| x |
|appointmentInstance/project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|appointmentInstance/project/projectUdef/SuperOffice:3|int|projectnumber| x |
|appointmentInstance/project/projectUdef/SuperOffice:4|date|projectdate| x |
|appointmentInstance/project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|appointmentInstance/project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|appointmentInstance/project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|appointmentInstance/project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|appointmentInstance/project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|appointmentInstance/project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|appointmentInstance/project/NumberOfActivities|int|Number of activities|  |
|appointmentInstance/project/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|appointmentInstance/project/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|appointmentInstance/project/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|appointmentInstance/project/LastActivity|date|Date of last activity|  |
|appointmentInstance/project/LastCompletedActivity|date|Date of last completed activity|  |
|appointmentInstance/project/LastDoByActivity|date|Date of last non-completed activity|  |
|appointmentInstance/project/NumberOfSales|int|Number of sales|  |
|appointmentInstance/project/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|appointmentInstance/project/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|appointmentInstance/project/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|appointmentInstance/project/LastSale|date|Date of last sale|  |
|appointmentInstance/project/LastCompletedSale|date|Date of last completed sale|  |
|appointmentInstance/project/LastDoBySale|date|Date of last non-completed sale|  |
|appointmentInstance/project/SaintStatus3|saintStatus|Not completed activites with intention sale|  |
|appointmentInstance/project/saintSaleStatus|listAny|With status|  |
|appointmentInstance/project/saintAmountClass|listAny|Amount class|  |
|appointmentInstance/project/saintActivityType|listAny|SAINT type|  |
|appointmentInstance/project/saintDirection|listAny|Direction|  |
|appointmentInstance/project/saintIntention|listAny|Intention|  |
|appointmentInstance/project/saintTicketStatus|listAny|Status|  |
|appointmentInstance/project/saintTicketCategory|listAny|Category|  |
|appointmentInstance/project/project/textId|int|Text ID| x |
|appointmentInstance/project/project/infoText|positiveString|Information: Displays the text entered in the description field| x |
|appointmentInstance/sale/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|appointmentInstance/sale/icon| *None* |Category: Displays the icon for an activity type| x |
|appointmentInstance/sale/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|appointmentInstance/sale/time| *None* |Time: Time|  |
|appointmentInstance/sale/type|listAny|Type: Displays the type of an activity| x |
|appointmentInstance/sale/recordType|string|Record type : Shows the record type| x |
|appointmentInstance/sale/text|positiveString|Text: Displays a descriptive text for the item| x |
|appointmentInstance/sale/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|appointmentInstance/sale/contactId|listAny|Company ID: Database ID of company| x |
|appointmentInstance/sale/personId|listAny|Contact ID: Database ID of the contact row| x |
|appointmentInstance/sale/projectId|listAny|Project ID: Database ID of project record| x |
|appointmentInstance/sale/saleId|int|Sale ID: The database ID of the sale record| x |
|appointmentInstance/sale/userGroup|userGroup|User group : The user group that owns the record| x |
|appointmentInstance/sale/who| *None* |Who: Contact and/or company|  |
|appointmentInstance/sale/updatedBy|associate|Updated by: The user who last updated the data| x |
|appointmentInstance/sale/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointmentInstance/sale/registeredBy|associate|Registered by: The user who registered the data| x |
|appointmentInstance/sale/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointmentInstance/sale/currencyId|int|Currency ID: The currency list item ID| x |
|appointmentInstance/sale/currency|listAny|Currency: The currency of the sale| x |
|appointmentInstance/sale/credited|listAny|Credited: The user to be credited with the sale| x |
|appointmentInstance/sale/lossReason|listAny|Reason (lost: The reason for losing the sale| x |
|appointmentInstance/sale/source|listAny|Source: The source (lead) of the sale| x |
|appointmentInstance/sale/competitor|listAny|Competitor: The competitor who won the sale| x |
|appointmentInstance/sale/heading|stringorPK|Sale: Displays a descriptive text for the item| x |
|appointmentInstance/sale/amount|decimal|Amount: The gross sales total| x |
|appointmentInstance/sale/amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.| x |
|appointmentInstance/sale/earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale| x |
|appointmentInstance/sale/earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total| x |
|appointmentInstance/sale/probPercent|int|Probability as %: Probability as %| x |
|appointmentInstance/sale/originalStage|listAny|Stage: Displays the stage of the sale| x |
|appointmentInstance/sale/stage|listAny|Stage: Displays the stage of the sale| x |
|appointmentInstance/sale/saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|appointmentInstance/sale/saleType|listAny|Sale type: Sale type, from list| x |
|appointmentInstance/sale/nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|appointmentInstance/sale/reopenDate|date|Reopen date: Displays the reopen date for the sale| x |
|appointmentInstance/sale/stalledComment|listAny|Reason (stalled: The reason the sale has been stalled| x |
|appointmentInstance/sale/soldReason|listAny|Reason (sold: Reason (sold)| x |
|appointmentInstance/sale/saleNumber|string|Number: Number| x |
|appointmentInstance/sale/hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders enabled| x |
|appointmentInstance/sale/hasQuote|bool|Has quote?: Does the sale have a quote attached?| x |
|appointmentInstance/sale/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|appointmentInstance/sale/description|string|Description: The long description field on Sale|  |
|appointmentInstance/sale/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|appointmentInstance/sale/visibleFor|listAny|Visible for|  |
|appointmentInstance/sale/sale/textId|int|Text ID| x |
|appointmentInstance/sale/sale/description|positiveString|Text: Displays the text entered in the description field| x |
|appointmentInstance/sale/salePublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointmentInstance/sale/salePublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointmentInstance/sale/salePublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|appointmentInstance/sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|appointmentInstance/sale/associate/firstName|string|First name: Displays the contact's first name| x |
|appointmentInstance/sale/associate/lastName|string|Last name: Displays the contact's last name| x |
|appointmentInstance/sale/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|appointmentInstance/sale/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|appointmentInstance/sale/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/sale/associate/personId|int|Contact ID: Database ID of the contact row|  |
|appointmentInstance/sale/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/sale/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/sale/associate/associateDbId|associate|ID| x |
|appointmentInstance/sale/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|appointmentInstance/sale/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|appointmentInstance/sale/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|appointmentInstance/sale/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|appointmentInstance/sale/associate/contactCategory|listAny|Category: Category| x |
|appointmentInstance/sale/associate/role|listAny|Role : Role| x |
|appointmentInstance/sale/associate/assocName|associate|User ID : User ID| x |
|appointmentInstance/sale/associate/assocTooltip|string|Description : Description|  |
|appointmentInstance/sale/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|appointmentInstance/sale/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|appointmentInstance/sale/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/sale/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|appointmentInstance/sale/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointmentInstance/sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointmentInstance/sale/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|appointmentInstance/sale/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|appointmentInstance/sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/sale/associate/otherGroups|userGroup|Other groups: Other groups|  |
|appointmentInstance/sale/associate/userName|string|User name: User name| x |
|appointmentInstance/sale/associate/personEmail|string|E-mail| x |
|appointmentInstance/sale/saleUdef/SuperOffice:1|string|saleshorttext| x |
|appointmentInstance/sale/saleUdef/SuperOffice:2|string|salelongtext| x |
|appointmentInstance/sale/saleUdef/SuperOffice:3|int|salenumber| x |
|appointmentInstance/sale/saleUdef/SuperOffice:4|date|saledate| x |
|appointmentInstance/sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|appointmentInstance/sale/saleUdef/SuperOffice:6|bool|salecheckbox| x |
|appointmentInstance/sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|appointmentInstance/sale/saleUdef/SuperOffice:8|decimal|saledecimal| x |
|appointmentInstance/associate/firstName|string|First name: Displays the contact's first name| x |
|appointmentInstance/associate/lastName|string|Last name: Displays the contact's last name| x |
|appointmentInstance/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|appointmentInstance/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|appointmentInstance/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|appointmentInstance/associate/personId|int|Contact ID: Database ID of the contact row|  |
|appointmentInstance/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|appointmentInstance/associate/associateDbId|associate|ID| x |
|appointmentInstance/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|appointmentInstance/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|appointmentInstance/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|appointmentInstance/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|appointmentInstance/associate/contactCategory|listAny|Category: Category| x |
|appointmentInstance/associate/role|listAny|Role : Role| x |
|appointmentInstance/associate/assocName|associate|User ID : User ID| x |
|appointmentInstance/associate/assocTooltip|string|Description : Description|  |
|appointmentInstance/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|appointmentInstance/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|appointmentInstance/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointmentInstance/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|appointmentInstance/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointmentInstance/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointmentInstance/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointmentInstance/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|appointmentInstance/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|appointmentInstance/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointmentInstance/associate/otherGroups|userGroup|Other groups: Other groups|  |
|appointmentInstance/associate/userName|string|User name: User name| x |
|appointmentInstance/associate/personEmail|string|E-mail| x |
|appointmentInstance/appointment/textId|int|Text ID| x |
|appointmentInstance/appointment/description|positiveString|Text: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/SaleGuideAppointment?$select=appointmentInstance/sale/description,appointmentInstance/sale/associate/isActive,appointmentInstance/associate/fullName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

