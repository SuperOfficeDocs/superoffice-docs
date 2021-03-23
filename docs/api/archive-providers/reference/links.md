---
uid: Links
title: Links
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "Links"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Links"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksProvider">SuperOffice.CRM.ArchiveLists.LinksProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointment"|Follow-ups|
|"sale"|Sales|
|"project"|Project|
|"document"|Documents|
|"url"|[url]|
|"person"|Contact|
|"Contact"|Company|
|"Selection"|Selection|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|sourceAppointmentRestrictionId|int|Source follow-up ID: Unique ID of follow-up to fetch link data for|  |
|sourceSaleRestrictionId|int|Source sale ID: Unique ID of sale to fetch link data for|  |
|sourceDocumentRestrictionId|int|Source document ID: Unique ID of document to fetch link data for|  |
|sourceProjectRestrictionId|int|Source project ID: Unique ID of project there is a link from|  |
|sourcePersonRestrictionId|int|Contact ID: Database ID of the contact row|  |
|sourceContactRestrictionId|int|Company ID: Database ID of company|  |
|sourceSelectionRestrictionId|int|Selection ID: The database ID of the selection|  |
|linkId|int|Link ID: Unique ID of relation between linked entities|  |
|linkDescription|string|Link description: A description of the relation between linked entities|  |
|completed|bool|Completed: Displays a checkbox showing if an appointment is completed|  |
|icon| *None* |Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale|  |
|time| *None* |Time: Time|  |
|type|listAny|Type: Displays the type of an activity|  |
|recordType|string|Record type : Shows the record type|  |
|text|positiveString|Text: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.|  |
|contactId|listAny|Company ID: Database ID of company|  |
|personId|listAny|Contact ID: Database ID of the contact row|  |
|projectId|listAny|Project ID: Database ID of project record|  |
|saleId|int|Sale ID: The database ID of the sale record|  |
|userGroup|userGroup|User group : The user group that owns the record|  |
|who| *None* |Who: Contact and/or company|  |
|updatedBy|associate|Updated by: The user who last updated the data|  |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|registeredBy|associate|Registered by: The user who registered the data|  |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|appointmentId|int|DB ID: Displays the database ID of a row|  |
|endDate|date|End date: Displays the deadline for a follow-up/sale|  |
|priority|listAny|Priority: Displays the priority of the activity|  |
|alarm|bool|Has alarm: Displays the alarm state of a follow-up|  |
|recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up|  |
|booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.|  |
|intention|listAny|Intention: Displays the intention of the follow-up type|  |
|location|string|Location: Display the location where the follow-up will take place.|  |
|recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up|  |
|rawType|int|Type: Type field for appointment, not decoded or formatted|  |
|rawStatus|int|Status: Status field for the follow-up, not decoded or formatted|  |
|cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.|  |
|visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?|  |
|endTime| *None* |End time: End time of an activity|  |
|suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion|  |
|completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed|  |
|isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones|  |
|invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd|  |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
|joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting|  |
|visibleFor|listAny|Visible for|  |
|appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published|  |
|appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date|  |
|appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date|  |
|appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|contact/contactId|int|Company ID: Database ID of company|  |
|contact/name|stringorPK|Company name|  |
|contact/department|string|Department|  |
|contact/nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|contact/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact|  |
|contact/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests|  |
|contact/associateId|associate|Our contact: Displays our contact|  |
|contact/category|listAny|Category|  |
|contact/business|listAny|Business|  |
|contact/country|listAny|Country: This criterion corresponds to the Country field on the Company card.|  |
|contact/number|string|Number|  |
|contact/code|string|Code|  |
|contact/orgnr|string|VAT No.|  |
|contact/stop|bool|Stop|  |
|contact/contactNoMail|bool|No mailings (company|  |
|contact/updatedBy|associate|Updated by: The user who last updated the data|  |
|contact/updatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|contact/registeredBy|associate|Registered by: The user who registered the data|  |
|contact/registeredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|contact/contactSource|listAny|Source: Source (Company)|  |
|contact/contactDeleted|bool|Deleted: Deleted|  |
|contact/phone/formattedNumber|string|Phone : Displays phone number|  |
|contact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|contact/deletedDate|datetime|Deleted date: Deleted date|  |
|contact/mainContact| *None* |Main contact: Main contact for this company|  |
|contact/contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|contact/contactPhone/description|string|Telephone - Description: Phone number description|  |
|contact/contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|contact/contactFax/description|string|Fax - Description: Phone number description|  |
|contact/searchPhone/formattedNumber|string|Searchphone - Phone: Displays phone number|  |
|contact/searchPhone/description|string|Searchphone - Description: Phone number description|  |
|contact/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP|  |
|contact/email/emailAddress|string|E-mail|  |
|contact/email/emailDescription|string|Description|  |
|contact/email/emailId|int|ID|  |
|contact/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address|  |
|contact/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address|  |
|contact/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address|  |
|contact/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|contact/postAddress/addressId|int|Postal address - Address ID: Database ID for the address record|  |
|contact/postAddress/line1|string|Postal address - Address 1: First line of the address|  |
|contact/postAddress/line2|string|Postal address - Address 2: Second line of the address|  |
|contact/postAddress/line3|string|Postal address - Address 3: Third line of the address|  |
|contact/postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|contact/postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|contact/postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|contact/postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|contact/postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude|  |
|contact/postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude|  |
|contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/addressId|int|Street address - Address ID: Database ID for the address record|  |
|contact/streetAddress/line1|string|Street address - Address 1: First line of the address|  |
|contact/streetAddress/line2|string|Street address - Address 2: Second line of the address|  |
|contact/streetAddress/line3|string|Street address - Address 3: Third line of the address|  |
|contact/streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|contact/streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.|  |
|contact/streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|contact/streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|contact/streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude|  |
|contact/streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude|  |
|contact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record|  |
|contact/restrictionAddress/line1|string|Search address - Address 1: First line of the address|  |
|contact/restrictionAddress/line2|string|Search address - Address 2: Second line of the address|  |
|contact/restrictionAddress/line3|string|Search address - Address 3: Third line of the address|  |
|contact/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|contact/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.|  |
|contact/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|contact/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|contact/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude|  |
|contact/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude|  |
|contact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|contact/url/URLAddress|string|URL|  |
|contact/url/URLDescription|string|Description|  |
|contact/contactAssociate/firstName|string|First name: Displays the contact's first name|  |
|contact/contactAssociate/lastName|string|Last name: Displays the contact's last name|  |
|contact/contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.|  |
|contact/contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)|  |
|contact/contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|contact/contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|contact/contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contact/contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms|  |
|contact/contactAssociate/associateDbId|associate|ID|  |
|contact/contactAssociate/contactName|string|Owning company: Name of the company the user belongs to|  |
|contact/contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to|  |
|contact/contactAssociate/usergroup|userGroup|Primary group: The user's primary user group|  |
|contact/contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to|  |
|contact/contactAssociate/contactCategory|listAny|Category: Category|  |
|contact/contactAssociate/role|listAny|Role : Role|  |
|contact/contactAssociate/assocName|associate|User ID : User ID|  |
|contact/contactAssociate/assocTooltip|string|Description : Description|  |
|contact/contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account|  |
|contact/contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|contact/contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contact/contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service|  |
|contact/contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|contact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|contact/contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?|  |
|contact/contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?|  |
|contact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contact/contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|contact/contactAssociate/userName|string|User name: User name|  |
|contact/contactAssociate/personEmail|string|E-mail|  |
|contact/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext|  |
|contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext|  |
|contact/contactUdef/SuperOffice:3|int|companynumber|  |
|contact/contactUdef/SuperOffice:4|date|companydate|  |
|contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate|  |
|contact/contactUdef/SuperOffice:6|bool|companycheckbox|  |
|contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox|  |
|contact/contactUdef/SuperOffice:8|decimal|companydecimal|  |
|contact/contactUdef/SuperOffice:9|string|page1saleonly|  |
|contact/contactUdef/SuperOffice:10|string|page1marketingonly|  |
|contact/contactUdef/SuperOffice:11|string|page1adminonly|  |
|contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one|  |
|contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two|  |
|contact/NumberOfActivities|int|Number of activities|  |
|contact/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|contact/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|contact/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|contact/LastActivity|date|Date of last activity|  |
|contact/LastCompletedActivity|date|Date of last completed activity|  |
|contact/LastDoByActivity|date|Date of last non-completed activity|  |
|contact/NumberOfSales|int|Number of sales|  |
|contact/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|contact/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|contact/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|contact/LastSale|date|Date of last sale|  |
|contact/LastCompletedSale|date|Date of last completed sale|  |
|contact/LastDoBySale|date|Date of last non-completed sale|  |
|contact/NumberOfTickets|int|Number of requests|  |
|contact/NumberOfTicketsInPeriod|int|Number of requests in last 90 days|  |
|contact/NumberOfNotCompletedTickets|int|Number of non-completed requests|  |
|contact/NumberOfNotCompletedTicketsInPeriod|int|Number of non-completed requests in last 90 days|  |
|contact/LastTicket|date|Date of last request|  |
|contact/LastCompletedTicket|date|Date of last completed request|  |
|contact/LastDoByTicket|date|Date of last non-completed request|  |
|contact/SaintStatus1|saintStatus|Neglected customer|  |
|contact/SaintStatus2|saintStatus|C-company|  |
|contact/saintSaleStatus|listAny|With status|  |
|contact/saintAmountClass|listAny|Amount class|  |
|contact/saintActivityType|listAny|SAINT type|  |
|contact/saintDirection|listAny|Direction|  |
|contact/saintIntention|listAny|Intention|  |
|contact/saintTicketStatus|listAny|Status|  |
|contact/saintTicketCategory|listAny|Category|  |
|person/personId|int|DB ID: Displays the database ID of a contact|  |
|person/firstName|string|First name: Displays the contact's first name|  |
|person/lastName|string|Last name: Displays the contact's last name|  |
|person/middleName|string|Middle name: Displays the contact's middle name.|  |
|person/fullName|stringorPK|Contact: Displays the contact to which an item is linked|  |
|person/contactId|int|Company ID: Database ID of company|  |
|person/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact|  |
|person/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests|  |
|person/personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests|  |
|person/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|person/position|listAny|Position|  |
|person/personNumber|string|Number: Displays the contact's number|  |
|person/title|string|Title: Displays the contact's job title|  |
|person/personCountry|listAny|Country: Country|  |
|person/personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox|  |
|person/rank|int|Rank: Displays a contact's current rank|  |
|person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|person/useAsMailingAddress|bool|Use as postal address: Use as postal address|  |
|person/personSource|listAny|Source: Source (Contact)|  |
|person/retired|bool|Former employee: Indicates whether the contact has retired/left the company|  |
|person/birthYear|int|Birth year: Displays contact's birth year|  |
|person/birthMonth|int|Birth month: Displays contact's birth month|  |
|person/birthDay|int|Birth day: Displays contact's birth day (day of month)|  |
|person/kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet|  |
|person/kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet|  |
|person/personUpdatedBy|associate|Updated by: The user who last updated the data|  |
|person/personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|person/personRegisteredBy|associate|Registered by: The user who registered the data|  |
|person/personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|person/portraitThumbnail| *None* |Person image: Person image|  |
|person/personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|person/ticketPriority|listAny|Service priority: Default service priority for this contact|  |
|person/supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more|  |
|person/supportAssociate|associate|Our service contact: Default service contact for this contact|  |
|person/personAssociateId|associate|Our contact: Displays our contact|  |
|person/personCategory|listAny|Category|  |
|person/personBusiness|listAny|Business|  |
|person/personDeletedDate|datetime|Deleted date: Deleted date|  |
|person/hasCompany|bool|Has company: The contact is associated with a company|  |
|person/isProjectMember|bool|Is project member: This person is a project member|  |
|person/isStakeholder|bool|Is stakeholder: This person is a sale stakeholder|  |
|person/phone/formattedNumber|string|Phone : Displays phone number|  |
|person/personDirectPhone/formattedNumber|string|Direct - Phone: Displays phone number|  |
|person/personDirectPhone/description|string|Direct - Description: Phone number description|  |
|person/personMobilePhone/formattedNumber|string|Mobile - Phone: Displays phone number|  |
|person/personMobilePhone/description|string|Mobile - Description: Phone number description|  |
|person/personPrivate/formattedNumber|string|Private - Phone: Displays phone number|  |
|person/personPrivate/description|string|Private - Description: Phone number description|  |
|person/personPager/formattedNumber|string|Other - Phone: Displays phone number|  |
|person/personPager/description|string|Other - Description: Phone number description|  |
|person/personDirectFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|person/personDirectFax/description|string|Fax - Description: Phone number description|  |
|person/searchPhone/formattedNumber|string|Phone : Displays phone number|  |
|person/searchPhone/description|string|Description: Phone number description|  |
|person/personInfo/textId|int|Text ID|  |
|person/personInfo/infoText|positiveString|Information: Displays the text entered in the description field|  |
|person/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP|  |
|person/email/emailAddress|string|E-mail|  |
|person/email/emailDescription|string|Description|  |
|person/email/emailId|int|ID|  |
|person/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address|  |
|person/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address|  |
|person/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address|  |
|person/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|person/personUrl/URLAddress|string|URL|  |
|person/personUrl/URLDescription|string|Description|  |
|person/personAddress/addressId|int|Contact address - Address ID: Database ID for the address record|  |
|person/personAddress/line1|string|Contact address - Address 1: First line of the address|  |
|person/personAddress/line2|string|Contact address - Address 2: Second line of the address|  |
|person/personAddress/line3|string|Contact address - Address 3: Third line of the address|  |
|person/personAddress/county|string|Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|person/personAddress/city|string|Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|person/personAddress/zip|string|Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|person/personAddress/state|string|Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|person/personAddress/wgs84latitude|decimal|Contact address - Latitude: Latitude|  |
|person/personAddress/wgs84longitude|decimal|Contact address - Longitude: Longitude|  |
|person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record|  |
|person/restrictionAddress/line1|string|Search address - Address 1: First line of the address|  |
|person/restrictionAddress/line2|string|Search address - Address 2: Second line of the address|  |
|person/restrictionAddress/line3|string|Search address - Address 3: Third line of the address|  |
|person/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|person/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.|  |
|person/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|person/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|person/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude|  |
|person/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude|  |
|person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|person/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext|  |
|person/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext|  |
|person/personUdef/SuperOffice:3|int|contactnumber|  |
|person/personUdef/SuperOffice:4|date|contactdate|  |
|person/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate|  |
|person/personUdef/SuperOffice:6|bool|contactcheckbox|  |
|person/personUdef/SuperOffice:7|listAny|contactdropdownlistbox|  |
|person/personUdef/SuperOffice:8|decimal|contactdecimal|  |
|person/personUdef/SuperOffice:9|string|page1saleonly|  |
|person/personUdef/SuperOffice:10|string|page1marketingonly|  |
|person/personUdef/SuperOffice:11|string|page1adminonly|  |
|person/isMailingRecipient|bool|isMailingRecipient: isMailingRecipient|  |
|person/hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/subscription|listAny|Subscription: Subscription for marketing|  |
|person/legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentUdef/SuperOffice:1|string|followupshorttext|  |
|appointmentUdef/SuperOffice:2|string|followuplongtext|  |
|appointmentUdef/SuperOffice:3|int|followupnumber|  |
|appointmentUdef/SuperOffice:4|date|followupdate|  |
|appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate|  |
|appointmentUdef/SuperOffice:6|bool|followupcheckbox|  |
|appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox|  |
|appointmentUdef/SuperOffice:8|decimal|followupdecimal|  |
|project/completed|bool|Completed: Displays a check mark indicating if the project has been completed.|  |
|project/projectId|int|DB ID: Displays the database ID for a project row|  |
|project/name|stringorPK|Project name: Displays the Project's name|  |
|project/number|string|Number: Displays the project's number|  |
|project/type|listAny|Project type: Displays the project's type|  |
|project/status|listAny|Status: Displays the project's status|  |
|project/associateId|associate|ID: Displays login ID of the associate who owns the project|  |
|project/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|project/icon| *None* |Category: Displays the icon for an activity type|  |
|project/text|string|Text: Displays a descriptive text for the item|  |
|project/description|string|Description : Description|  |
|project/updatedBy|associate|Updated by: The user who last updated the data|  |
|project/updatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|project/registeredBy|associate|Registered by: The user who registered the data|  |
|project/registeredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|project/hasGuide|bool|Guided: Does this sale have a Sales Guide|  |
|project/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|project/endDate|date|End date: End date of project|  |
|project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|project/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published|  |
|project/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date|  |
|project/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date|  |
|project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|project/projectEvent/isExternalEvent|bool|Event: Is this an external event|  |
|project/projectEvent/eventDate|date|Event date: Event date|  |
|project/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled|  |
|project/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled|  |
|project/projectUrl/URLAddress|string|URL|  |
|project/projectUrl/URLDescription|string|Description|  |
|project/projectAssociate/firstName|string|First name: Displays the contact's first name|  |
|project/projectAssociate/lastName|string|Last name: Displays the contact's last name|  |
|project/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.|  |
|project/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)|  |
|project/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|project/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|project/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|project/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms|  |
|project/projectAssociate/associateDbId|associate|ID|  |
|project/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to|  |
|project/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to|  |
|project/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group|  |
|project/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to|  |
|project/projectAssociate/contactCategory|listAny|Category: Category|  |
|project/projectAssociate/role|listAny|Role : Role|  |
|project/projectAssociate/assocName|associate|User ID : User ID|  |
|project/projectAssociate/assocTooltip|string|Description : Description|  |
|project/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account|  |
|project/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service|  |
|project/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|project/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?|  |
|project/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?|  |
|project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|project/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|project/projectAssociate/userName|string|User name: User name|  |
|project/projectAssociate/personEmail|string|E-mail|  |
|project/projectUdef/SuperOffice:1|string|projectshorttext|  |
|project/projectUdef/SuperOffice:2|string|projectlongtext|  |
|project/projectUdef/SuperOffice:3|int|projectnumber|  |
|project/projectUdef/SuperOffice:4|date|projectdate|  |
|project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate|  |
|project/projectUdef/SuperOffice:6|bool|projectcheckbox|  |
|project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox|  |
|project/projectUdef/SuperOffice:8|decimal|projectdecimal|  |
|project/projectUdef/SuperOffice:9|int|page1saleandmarketing|  |
|project/projectUdef/SuperOffice:10|int|page1saleandadmin|  |
|project/NumberOfActivities|int|Number of activities|  |
|project/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|project/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|project/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|project/LastActivity|date|Date of last activity|  |
|project/LastCompletedActivity|date|Date of last completed activity|  |
|project/LastDoByActivity|date|Date of last non-completed activity|  |
|project/NumberOfSales|int|Number of sales|  |
|project/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|project/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|project/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|project/LastSale|date|Date of last sale|  |
|project/LastCompletedSale|date|Date of last completed sale|  |
|project/LastDoBySale|date|Date of last non-completed sale|  |
|project/SaintStatus3|saintStatus|Not completed activites with intention sale|  |
|project/saintSaleStatus|listAny|With status|  |
|project/saintAmountClass|listAny|Amount class|  |
|project/saintActivityType|listAny|SAINT type|  |
|project/saintDirection|listAny|Direction|  |
|project/saintIntention|listAny|Intention|  |
|project/saintTicketStatus|listAny|Status|  |
|project/saintTicketCategory|listAny|Category|  |
|project/project/textId|int|Text ID|  |
|project/project/infoText|positiveString|Information: Displays the text entered in the description field|  |
|sale/completed|bool|Completed: Displays a checkbox showing if an appointment is completed|  |
|sale/icon| *None* |Category: Displays the icon for an activity type|  |
|sale/date|date|Date: Displays start date of a follow-up / sale date of a sale|  |
|sale/time| *None* |Time: Time|  |
|sale/type|listAny|Type: Displays the type of an activity|  |
|sale/recordType|string|Record type : Shows the record type|  |
|sale/text|positiveString|Text: Displays a descriptive text for the item|  |
|sale/associateId|associate|ID: Displays the login ID of the associate who owns the activity.|  |
|sale/contactId|listAny|Company ID: Database ID of company|  |
|sale/personId|listAny|Contact ID: Database ID of the contact row|  |
|sale/projectId|listAny|Project ID: Database ID of project record|  |
|sale/saleId|int|Sale ID: The database ID of the sale record|  |
|sale/userGroup|userGroup|User group : The user group that owns the record|  |
|sale/who| *None* |Who: Contact and/or company|  |
|sale/updatedBy|associate|Updated by: The user who last updated the data|  |
|sale/updatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|sale/registeredBy|associate|Registered by: The user who registered the data|  |
|sale/registeredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|sale/currencyId|int|Currency ID: The currency list item ID|  |
|sale/currency|listAny|Currency: The currency of the sale|  |
|sale/credited|listAny|Credited: The user to be credited with the sale|  |
|sale/lossReason|listAny|Reason (lost: The reason for losing the sale|  |
|sale/source|listAny|Source: The source (lead) of the sale|  |
|sale/competitor|listAny|Competitor: The competitor who won the sale|  |
|sale/heading|stringorPK|Sale: Displays a descriptive text for the item|  |
|sale/amount|decimal|Amount: The gross sales total|  |
|sale/amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.|  |
|sale/earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale|  |
|sale/earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total|  |
|sale/probPercent|int|Probability as %: Probability as %|  |
|sale/originalStage|listAny|Stage: Displays the stage of the sale|  |
|sale/stage|listAny|Stage: Displays the stage of the sale|  |
|sale/saleStatus|listAny|Status: The status of the sale - open, lost or sold|  |
|sale/saleType|listAny|Sale type: Sale type, from list|  |
|sale/nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|sale/reopenDate|date|Reopen date: Displays the reopen date for the sale|  |
|sale/stalledComment|listAny|Reason (stalled: The reason the sale has been stalled|  |
|sale/soldReason|listAny|Reason (sold: Reason (sold)|  |
|sale/saleNumber|string|Number: Number|  |
|sale/hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders enabled|  |
|sale/hasQuote|bool|Has quote?: Does the sale have a quote attached?|  |
|sale/hasGuide|bool|Guided: Does this sale have a Sales Guide|  |
|sale/description|string|Description: The long description field on Sale|  |
|sale/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|sale/visibleFor|listAny|Visible for|  |
|sale/sale/textId|int|Text ID|  |
|sale/sale/description|positiveString|Text: Displays the text entered in the description field|  |
|sale/salePublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published|  |
|sale/salePublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date|  |
|sale/salePublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date|  |
|sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|sale/associate/firstName|string|First name: Displays the contact's first name|  |
|sale/associate/lastName|string|Last name: Displays the contact's last name|  |
|sale/associate/middleName|string|Middle Name : Displays the contact's middle name.|  |
|sale/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)|  |
|sale/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|sale/associate/personId|int|Contact ID: Database ID of the contact row|  |
|sale/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|sale/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms|  |
|sale/associate/associateDbId|associate|ID|  |
|sale/associate/contactName|string|Owning company: Name of the company the user belongs to|  |
|sale/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to|  |
|sale/associate/usergroup|userGroup|Primary group: The user's primary user group|  |
|sale/associate/contactFullName|string|Owner: Name and department of the company the user belongs to|  |
|sale/associate/contactCategory|listAny|Category: Category|  |
|sale/associate/role|listAny|Role : Role|  |
|sale/associate/assocName|associate|User ID : User ID|  |
|sale/associate/assocTooltip|string|Description : Description|  |
|sale/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account|  |
|sale/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|sale/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|sale/associate/ejDisplayName|string|Nick name: User's nick name in Service|  |
|sale/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|sale/associate/isActive|bool|Active: Is this user active, and should be able to log in?|  |
|sale/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?|  |
|sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|sale/associate/otherGroups|userGroup|Other groups: Other groups|  |
|sale/associate/userName|string|User name: User name|  |
|sale/associate/personEmail|string|E-mail|  |
|sale/saleUdef/SuperOffice:1|string|saleshorttext|  |
|sale/saleUdef/SuperOffice:2|string|salelongtext|  |
|sale/saleUdef/SuperOffice:3|int|salenumber|  |
|sale/saleUdef/SuperOffice:4|date|saledate|  |
|sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate|  |
|sale/saleUdef/SuperOffice:6|bool|salecheckbox|  |
|sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox|  |
|sale/saleUdef/SuperOffice:8|decimal|saledecimal|  |
|associate/firstName|string|First name: Displays the contact's first name|  |
|associate/lastName|string|Last name: Displays the contact's last name|  |
|associate/middleName|string|Middle Name : Displays the contact's middle name.|  |
|associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)|  |
|associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|associate/personId|int|Contact ID: Database ID of the contact row|  |
|associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms|  |
|associate/associateDbId|associate|ID|  |
|associate/contactName|string|Owning company: Name of the company the user belongs to|  |
|associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to|  |
|associate/usergroup|userGroup|Primary group: The user's primary user group|  |
|associate/contactFullName|string|Owner: Name and department of the company the user belongs to|  |
|associate/contactCategory|listAny|Category: Category|  |
|associate/role|listAny|Role : Role|  |
|associate/assocName|associate|User ID : User ID|  |
|associate/assocTooltip|string|Description : Description|  |
|associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account|  |
|associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Nick name: User's nick name in Service|  |
|associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|associate/isActive|bool|Active: Is this user active, and should be able to log in?|  |
|associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?|  |
|associate/portraitThumbnail| *None* |Person image: Person image|  |
|associate/otherGroups|userGroup|Other groups: Other groups|  |
|associate/userName|string|User name: User name|  |
|associate/personEmail|string|E-mail|  |
|appointment/textId|int|Text ID|  |
|appointment/description|positiveString|Text: Displays the text entered in the description field|  |
|destinationAppointmentRestrictionId|int|Destination follow-up ID: IDs of follow-ups which are linked to|  |
|currencyId|int|Currency ID: The currency list item ID|  |
|currency|listAny|Currency: The currency of the sale|  |
|credited|listAny|Credited: The user to be credited with the sale|  |
|lossReason|listAny|Reason (lost: The reason for losing the sale|  |
|source|listAny|Source: The source (lead) of the sale|  |
|competitor|listAny|Competitor: The competitor who won the sale|  |
|heading|stringorPK|Sale: Displays a descriptive text for the item|  |
|amount|decimal|Amount: The gross sales total|  |
|amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.|  |
|earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale|  |
|earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total|  |
|probPercent|int|Probability as %: Probability as %|  |
|originalStage|listAny|Stage: Displays the stage of the sale|  |
|stage|listAny|Stage: Displays the stage of the sale|  |
|saleStatus|listAny|Status: The status of the sale - open, lost or sold|  |
|saleType|listAny|Sale type: Sale type, from list|  |
|nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|reopenDate|date|Reopen date: Displays the reopen date for the sale|  |
|stalledComment|listAny|Reason (stalled: The reason the sale has been stalled|  |
|soldReason|listAny|Reason (sold: Reason (sold)|  |
|saleNumber|string|Number: Number|  |
|hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders enabled|  |
|hasQuote|bool|Has quote?: Does the sale have a quote attached?|  |
|hasGuide|bool|Guided: Does this sale have a Sales Guide|  |
|description|string|Description: The long description field on Sale|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|sale/textId|int|Text ID|  |
|salePublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published|  |
|salePublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date|  |
|salePublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date|  |
|salePublish/publishedBy| *None* |Published by: Published by|  |
|saleUdef/SuperOffice:1|string|saleshorttext|  |
|saleUdef/SuperOffice:2|string|salelongtext|  |
|saleUdef/SuperOffice:3|int|salenumber|  |
|saleUdef/SuperOffice:4|date|saledate|  |
|saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate|  |
|saleUdef/SuperOffice:6|bool|salecheckbox|  |
|saleUdef/SuperOffice:7|listAny|saledropdownlistbox|  |
|saleUdef/SuperOffice:8|decimal|saledecimal|  |
|saleStakeholder/saleStakeholderId|int|Stakeholder - Stakeholder ID: Database ID of the stakeholder row|  |
|saleStakeholder/saleId|int|Stakeholder - Sale ID: The database ID of the sale record|  |
|saleStakeholder/comment|string|Stakeholder - Sales role comment text: Sales role comment text|  |
|saleStakeholder/salesRoleId|listAny|Stakeholder - Sales role: Sales role|  |
|saleStakeholder/hasInfoText|bool|Stakeholder - Sales role comment: Sales role comment|  |
|saleStakeholder/person/personId|int|Stakeholder - DB ID: Displays the database ID of a contact|  |
|saleStakeholder/person/firstName|string|Stakeholder - First name: Displays the contact's first name|  |
|saleStakeholder/person/lastName|string|Stakeholder - Last name: Displays the contact's last name|  |
|saleStakeholder/person/middleName|string|Stakeholder - Middle name: Displays the contact's middle name.|  |
|saleStakeholder/person/fullName|stringorPK|Stakeholder - Contact: Displays the contact to which an item is linked|  |
|saleStakeholder/person/contactId|int|Stakeholder - Company ID: Database ID of company|  |
|saleStakeholder/person/hasInfoText|bool|Stakeholder - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|saleStakeholder/person/hasInterests|bool|Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests|  |
|saleStakeholder/person/personHasInterests|bool|Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests|  |
|saleStakeholder/person/mrMrs|string|Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/person/position|listAny|Stakeholder - Position|  |
|saleStakeholder/person/personNumber|string|Stakeholder - Number: Displays the contact's number|  |
|saleStakeholder/person/title|string|Stakeholder - Title: Displays the contact's job title|  |
|saleStakeholder/person/personCountry|listAny|Stakeholder - Country: Country|  |
|saleStakeholder/person/personNoMail|bool|Stakeholder - No Mailings: Displays the contact's No Mailings checkbox|  |
|saleStakeholder/person/rank|int|Stakeholder - Rank: Displays a contact's current rank|  |
|saleStakeholder/person/birthdate| *None* |Stakeholder - Birthdate: Displays the contact's date of birth|  |
|saleStakeholder/person/associateType| *None* |Stakeholder - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|saleStakeholder/person/useAsMailingAddress|bool|Stakeholder - Use as postal address: Use as postal address|  |
|saleStakeholder/person/personSource|listAny|Stakeholder - Source: Source (Contact)|  |
|saleStakeholder/person/retired|bool|Stakeholder - Former employee: Indicates whether the contact has retired/left the company|  |
|saleStakeholder/person/birthYear|int|Stakeholder - Birth year: Displays contact's birth year|  |
|saleStakeholder/person/birthMonth|int|Stakeholder - Birth month: Displays contact's birth month|  |
|saleStakeholder/person/birthDay|int|Stakeholder - Birth day: Displays contact's birth day (day of month)|  |
|saleStakeholder/person/kanaFirstName|string|Stakeholder - First name, kana: Contact's first name, in kana alphabet|  |
|saleStakeholder/person/kanaLastName|string|Stakeholder - Last name, kana: Contact's last name, in kana alphabet|  |
|saleStakeholder/person/personUpdatedBy|associate|Stakeholder - Updated by: The user who last updated the data|  |
|saleStakeholder/person/personUpdatedDate|date|Stakeholder - Updated: The date/time the data was last updated in UTC.|  |
|saleStakeholder/person/personRegisteredBy|associate|Stakeholder - Registered by: The user who registered the data|  |
|saleStakeholder/person/personRegisteredDate|date|Stakeholder - Registered date: The date/time the data was registered in UTC.|  |
|saleStakeholder/person/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/personActiveErpLinks|bool|Stakeholder - ERP connected: Is there an active ERP Sync?|  |
|saleStakeholder/person/ticketPriority|listAny|Stakeholder - Service priority: Default service priority for this contact|  |
|saleStakeholder/person/supportLanguage|listAny|Stakeholder - Preferred language: Preferred language used for reply templates and more|  |
|saleStakeholder/person/supportAssociate|associate|Stakeholder - Our service contact: Default service contact for this contact|  |
|saleStakeholder/person/personAssociateId|associate|Stakeholder - Our contact: Displays our contact|  |
|saleStakeholder/person/personCategory|listAny|Stakeholder - Category|  |
|saleStakeholder/person/personBusiness|listAny|Stakeholder - Business|  |
|saleStakeholder/person/personDeletedDate|datetime|Stakeholder - Deleted date: Deleted date|  |
|saleStakeholder/person/hasCompany|bool|Stakeholder - Has company: The contact is associated with a company|  |
|saleStakeholder/person/isProjectMember|bool|Stakeholder - Is project member: This person is a project member|  |
|saleStakeholder/person/isStakeholder|bool|Stakeholder - Is stakeholder: This person is a sale stakeholder|  |
|saleStakeholder/person/phone/formattedNumber|string|Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectPhone/formattedNumber|string|Stakeholder - Direct - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectPhone/description|string|Stakeholder - Direct - Description: Phone number description|  |
|saleStakeholder/person/personMobilePhone/formattedNumber|string|Stakeholder - Mobile - Phone: Displays phone number|  |
|saleStakeholder/person/personMobilePhone/description|string|Stakeholder - Mobile - Description: Phone number description|  |
|saleStakeholder/person/personPrivate/formattedNumber|string|Stakeholder - Private - Phone: Displays phone number|  |
|saleStakeholder/person/personPrivate/description|string|Stakeholder - Private - Description: Phone number description|  |
|saleStakeholder/person/personPager/formattedNumber|string|Stakeholder - Other - Phone: Displays phone number|  |
|saleStakeholder/person/personPager/description|string|Stakeholder - Other - Description: Phone number description|  |
|saleStakeholder/person/personDirectFax/formattedNumber|string|Stakeholder - Fax - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectFax/description|string|Stakeholder - Fax - Description: Phone number description|  |
|saleStakeholder/person/searchPhone/formattedNumber|string|Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/person/searchPhone/description|string|Stakeholder - Description: Phone number description|  |
|saleStakeholder/person/personInfo/textId|int|Stakeholder - Text ID|  |
|saleStakeholder/person/personInfo/infoText|positiveString|Stakeholder - Information: Displays the text entered in the description field|  |
|saleStakeholder/person/email/emailProtocol|string|Stakeholder - Protocol: E-mail protocol, such as SMTP|  |
|saleStakeholder/person/email/emailAddress|string|Stakeholder - E-mail|  |
|saleStakeholder/person/email/emailDescription|string|Stakeholder - Description|  |
|saleStakeholder/person/email/emailId|int|Stakeholder - ID|  |
|saleStakeholder/person/email/emailLastSent|datetime|Stakeholder - Last sent: The date and time an e-mail was last sent to this address|  |
|saleStakeholder/person/email/emailBounceCount|int|Stakeholder - Bounce count: Bounce count for this e-mail address|  |
|saleStakeholder/person/email/emailLastBounce|datetime|Stakeholder - Last bounce: Date and time for last bounce to this e-mail address|  |
|saleStakeholder/person/email/emailHasBounced|bool|Stakeholder - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|saleStakeholder/person/personUrl/URLAddress|string|Stakeholder - URL|  |
|saleStakeholder/person/personUrl/URLDescription|string|Stakeholder - Description|  |
|saleStakeholder/person/personAddress/addressId|int|Stakeholder - Contact address - Address ID: Database ID for the address record|  |
|saleStakeholder/person/personAddress/line1|string|Stakeholder - Contact address - Address 1: First line of the address|  |
|saleStakeholder/person/personAddress/line2|string|Stakeholder - Contact address - Address 2: Second line of the address|  |
|saleStakeholder/person/personAddress/line3|string|Stakeholder - Contact address - Address 3: Third line of the address|  |
|saleStakeholder/person/personAddress/county|string|Stakeholder - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/personAddress/city|string|Stakeholder - Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/person/personAddress/zip|string|Stakeholder - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/person/personAddress/state|string|Stakeholder - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/personAddress/wgs84latitude|decimal|Stakeholder - Contact address - Latitude: Latitude|  |
|saleStakeholder/person/personAddress/wgs84longitude|decimal|Stakeholder - Contact address - Longitude: Longitude|  |
|saleStakeholder/person/personAddress/formattedAddress| *None* |Stakeholder - Contact address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personAddress/formattedMultiLineAddress| *None* |Stakeholder - Contact address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/addressId|int|Stakeholder - Search address - Address ID: Database ID for the address record|  |
|saleStakeholder/person/restrictionAddress/line1|string|Stakeholder - Search address - Address 1: First line of the address|  |
|saleStakeholder/person/restrictionAddress/line2|string|Stakeholder - Search address - Address 2: Second line of the address|  |
|saleStakeholder/person/restrictionAddress/line3|string|Stakeholder - Search address - Address 3: Third line of the address|  |
|saleStakeholder/person/restrictionAddress/county|string|Stakeholder - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/restrictionAddress/city|string|Stakeholder - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/person/restrictionAddress/zip|string|Stakeholder - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/person/restrictionAddress/state|string|Stakeholder - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/restrictionAddress/wgs84latitude|decimal|Stakeholder - Search address - Latitude: Latitude|  |
|saleStakeholder/person/restrictionAddress/wgs84longitude|decimal|Stakeholder - Search address - Longitude: Longitude|  |
|saleStakeholder/person/restrictionAddress/formattedAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/formattedMultiLineAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personInterestIds|listInterest|Stakeholder - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|saleStakeholder/person/personUdef/SuperOffice:1|string|Stakeholder - contactshorttext: tooltipshorttext|  |
|saleStakeholder/person/personUdef/SuperOffice:2|string|Stakeholder - contactlongtext: tooltiplongtext|  |
|saleStakeholder/person/personUdef/SuperOffice:3|int|Stakeholder - contactnumber|  |
|saleStakeholder/person/personUdef/SuperOffice:4|date|Stakeholder - contactdate|  |
|saleStakeholder/person/personUdef/SuperOffice:5|unlimitedDate|Stakeholder - contactunlimiteddate: tooltipunlimiteddate|  |
|saleStakeholder/person/personUdef/SuperOffice:6|bool|Stakeholder - contactcheckbox|  |
|saleStakeholder/person/personUdef/SuperOffice:7|listAny|Stakeholder - contactdropdownlistbox|  |
|saleStakeholder/person/personUdef/SuperOffice:8|decimal|Stakeholder - contactdecimal|  |
|saleStakeholder/person/personUdef/SuperOffice:9|string|Stakeholder - page1saleonly|  |
|saleStakeholder/person/personUdef/SuperOffice:10|string|Stakeholder - page1marketingonly|  |
|saleStakeholder/person/personUdef/SuperOffice:11|string|Stakeholder - page1adminonly|  |
|saleStakeholder/person/isMailingRecipient|bool|Stakeholder - isMailingRecipient: isMailingRecipient|  |
|saleStakeholder/person/hasStoreConsent|bool|Stakeholder - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/withdrawnStoreConsent|bool|Stakeholder - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/hasEmarketingConsent|bool|Stakeholder - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/withdrawnEmarketingConsent|bool|Stakeholder - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/subscription|listAny|Stakeholder - Subscription: Subscription for marketing|  |
|saleStakeholder/person/legalBaseStore|listAny|Stakeholder - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/legalBaseEmarketing|listAny|Stakeholder - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/consentSourceStore|listAny|Stakeholder - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/consentSourceEmarketing|listAny|Stakeholder - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/contact/contactId|int|Stakeholder - Company ID: Database ID of company|  |
|saleStakeholder/contact/name|stringorPK|Stakeholder - Company name|  |
|saleStakeholder/contact/department|string|Stakeholder - Department|  |
|saleStakeholder/contact/nameDepartment| *None* |Stakeholder - Company: Displays the company an activity is linked to|  |
|saleStakeholder/contact/hasInfoText|bool|Stakeholder - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|saleStakeholder/contact/hasInterests|bool|Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests|  |
|saleStakeholder/contact/associateId|associate|Stakeholder - Our contact: Displays our contact|  |
|saleStakeholder/contact/category|listAny|Stakeholder - Category|  |
|saleStakeholder/contact/business|listAny|Stakeholder - Business|  |
|saleStakeholder/contact/country|listAny|Stakeholder - Country: This criterion corresponds to the Country field on the Company card.|  |
|saleStakeholder/contact/number|string|Stakeholder - Number|  |
|saleStakeholder/contact/code|string|Stakeholder - Code|  |
|saleStakeholder/contact/orgnr|string|Stakeholder - VAT No.|  |
|saleStakeholder/contact/stop|bool|Stakeholder - Stop|  |
|saleStakeholder/contact/contactNoMail|bool|Stakeholder - No mailings (company)|  |
|saleStakeholder/contact/updatedBy|associate|Stakeholder - Updated by: The user who last updated the data|  |
|saleStakeholder/contact/updatedDate|date|Stakeholder - Updated: The date/time the data was last updated in UTC.|  |
|saleStakeholder/contact/registeredBy|associate|Stakeholder - Registered by: The user who registered the data|  |
|saleStakeholder/contact/registeredDate|date|Stakeholder - Registered date: The date/time the data was registered in UTC.|  |
|saleStakeholder/contact/contactSource|listAny|Stakeholder - Source: Source (Company)|  |
|saleStakeholder/contact/contactDeleted|bool|Stakeholder - Deleted: Deleted|  |
|saleStakeholder/contact/phone/formattedNumber|string|Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/contact/activeErpLinks|bool|Stakeholder - ERP connected: Is there an active ERP Sync?|  |
|saleStakeholder/contact/deletedDate|datetime|Stakeholder - Deleted date: Deleted date|  |
|saleStakeholder/contact/mainContact| *None* |Stakeholder - Main contact: Main contact for this company|  |
|saleStakeholder/contact/contactPhone/formattedNumber|string|Stakeholder - Telephone - Phone: Displays phone number|  |
|saleStakeholder/contact/contactPhone/description|string|Stakeholder - Telephone - Description: Phone number description|  |
|saleStakeholder/contact/contactFax/formattedNumber|string|Stakeholder - Fax - Phone: Displays phone number|  |
|saleStakeholder/contact/contactFax/description|string|Stakeholder - Fax - Description: Phone number description|  |
|saleStakeholder/contact/searchPhone/formattedNumber|string|Stakeholder - Searchphone - Phone: Displays phone number|  |
|saleStakeholder/contact/searchPhone/description|string|Stakeholder - Searchphone - Description: Phone number description|  |
|saleStakeholder/contact/email/emailProtocol|string|Stakeholder - Protocol: E-mail protocol, such as SMTP|  |
|saleStakeholder/contact/email/emailAddress|string|Stakeholder - E-mail|  |
|saleStakeholder/contact/email/emailDescription|string|Stakeholder - Description|  |
|saleStakeholder/contact/email/emailId|int|Stakeholder - ID|  |
|saleStakeholder/contact/email/emailLastSent|datetime|Stakeholder - Last sent: The date and time an e-mail was last sent to this address|  |
|saleStakeholder/contact/email/emailBounceCount|int|Stakeholder - Bounce count: Bounce count for this e-mail address|  |
|saleStakeholder/contact/email/emailLastBounce|datetime|Stakeholder - Last bounce: Date and time for last bounce to this e-mail address|  |
|saleStakeholder/contact/email/emailHasBounced|bool|Stakeholder - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|saleStakeholder/contact/postAddress/addressId|int|Stakeholder - Postal address - Address ID: Database ID for the address record|  |
|saleStakeholder/contact/postAddress/line1|string|Stakeholder - Postal address - Address 1: First line of the address|  |
|saleStakeholder/contact/postAddress/line2|string|Stakeholder - Postal address - Address 2: Second line of the address|  |
|saleStakeholder/contact/postAddress/line3|string|Stakeholder - Postal address - Address 3: Third line of the address|  |
|saleStakeholder/contact/postAddress/county|string|Stakeholder - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/postAddress/city|string|Stakeholder - Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/contact/postAddress/zip|string|Stakeholder - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/contact/postAddress/state|string|Stakeholder - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/postAddress/wgs84latitude|decimal|Stakeholder - Postal address - Latitude: Latitude|  |
|saleStakeholder/contact/postAddress/wgs84longitude|decimal|Stakeholder - Postal address - Longitude: Longitude|  |
|saleStakeholder/contact/postAddress/formattedAddress| *None* |Stakeholder - Postal address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/postAddress/formattedMultiLineAddress| *None* |Stakeholder - Postal address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/addressId|int|Stakeholder - Street address - Address ID: Database ID for the address record|  |
|saleStakeholder/contact/streetAddress/line1|string|Stakeholder - Street address - Address 1: First line of the address|  |
|saleStakeholder/contact/streetAddress/line2|string|Stakeholder - Street address - Address 2: Second line of the address|  |
|saleStakeholder/contact/streetAddress/line3|string|Stakeholder - Street address - Address 3: Third line of the address|  |
|saleStakeholder/contact/streetAddress/county|string|Stakeholder - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/streetAddress/city|string|Stakeholder - Street address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/contact/streetAddress/zip|string|Stakeholder - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/contact/streetAddress/state|string|Stakeholder - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/streetAddress/wgs84latitude|decimal|Stakeholder - Street address - Latitude: Latitude|  |
|saleStakeholder/contact/streetAddress/wgs84longitude|decimal|Stakeholder - Street address - Longitude: Longitude|  |
|saleStakeholder/contact/streetAddress/formattedAddress| *None* |Stakeholder - Street address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/formattedMultiLineAddress| *None* |Stakeholder - Street address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/addressId|int|Stakeholder - Search address - Address ID: Database ID for the address record|  |
|saleStakeholder/contact/restrictionAddress/line1|string|Stakeholder - Search address - Address 1: First line of the address|  |
|saleStakeholder/contact/restrictionAddress/line2|string|Stakeholder - Search address - Address 2: Second line of the address|  |
|saleStakeholder/contact/restrictionAddress/line3|string|Stakeholder - Search address - Address 3: Third line of the address|  |
|saleStakeholder/contact/restrictionAddress/county|string|Stakeholder - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/restrictionAddress/city|string|Stakeholder - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/contact/restrictionAddress/zip|string|Stakeholder - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/contact/restrictionAddress/state|string|Stakeholder - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/restrictionAddress/wgs84latitude|decimal|Stakeholder - Search address - Latitude: Latitude|  |
|saleStakeholder/contact/restrictionAddress/wgs84longitude|decimal|Stakeholder - Search address - Longitude: Longitude|  |
|saleStakeholder/contact/restrictionAddress/formattedAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/formattedMultiLineAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/url/URLAddress|string|Stakeholder - URL|  |
|saleStakeholder/contact/url/URLDescription|string|Stakeholder - Description|  |
|saleStakeholder/contact/contactAssociate/firstName|string|Stakeholder - First name: Displays the contact's first name|  |
|saleStakeholder/contact/contactAssociate/lastName|string|Stakeholder - Last name: Displays the contact's last name|  |
|saleStakeholder/contact/contactAssociate/middleName|string|Stakeholder - Middle Name: Displays the contact's middle name.|  |
|saleStakeholder/contact/contactAssociate/fullName|string|Stakeholder - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|saleStakeholder/contact/contactAssociate/contactId|int|Stakeholder - Company ID: Database ID of the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/personId|int|Stakeholder - Contact ID: Database ID of the contact row|  |
|saleStakeholder/contact/contactAssociate/mrMrs|string|Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/contact/contactAssociate/title|string|Stakeholder - Title: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/contact/contactAssociate/associateDbId|associate|Stakeholder - ID|  |
|saleStakeholder/contact/contactAssociate/contactName|string|Stakeholder - Owning company: Name of the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/contactDepartment|string|Stakeholder - Owning department: Name of the department at the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/usergroup|userGroup|Stakeholder - Primary group: The user's primary user group|  |
|saleStakeholder/contact/contactAssociate/contactFullName|string|Stakeholder - Owner: Name and department of the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/contactCategory|listAny|Stakeholder - Category: Category|  |
|saleStakeholder/contact/contactAssociate/role|listAny|Stakeholder - Role: Role|  |
|saleStakeholder/contact/contactAssociate/assocName|associate|Stakeholder - User ID: User ID|  |
|saleStakeholder/contact/contactAssociate/assocTooltip|string|Stakeholder - Description: Description|  |
|saleStakeholder/contact/contactAssociate/assocType|listAny|Stakeholder - Type: Type of user: associate, external user, system user, anonymous account|  |
|saleStakeholder/contact/contactAssociate/ejUserId|int|Stakeholder - Service user ID: The database ID of a Service user|  |
|saleStakeholder/contact/contactAssociate/simultaneousEjUser|bool|Stakeholder - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|saleStakeholder/contact/contactAssociate/ejDisplayName|string|Stakeholder - Nick name: User's nick name in Service|  |
|saleStakeholder/contact/contactAssociate/ejStatus|int|Stakeholder - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|saleStakeholder/contact/contactAssociate/credentialType| *None* |Stakeholder - Auth. type: What type of credentials to use when this user logs in|  |
|saleStakeholder/contact/contactAssociate/credentialDisplayValue| *None* |Stakeholder - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|saleStakeholder/contact/contactAssociate/isActive|bool|Stakeholder - Active: Is this user active, and should be able to log in?|  |
|saleStakeholder/contact/contactAssociate/isActiveText|bool|Stakeholder - Active status: Is this user active, and should be able to log in?|  |
|saleStakeholder/contact/contactAssociate/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/contact/contactAssociate/otherGroups|userGroup|Stakeholder - Other groups: Other groups|  |
|saleStakeholder/contact/contactAssociate/userName|string|Stakeholder - User name: User name|  |
|saleStakeholder/contact/contactAssociate/personEmail|string|Stakeholder - E-mail|  |
|saleStakeholder/contact/contactInterestIds|listInterest|Stakeholder - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|saleStakeholder/contact/contactUdef/SuperOffice:1|string|Stakeholder - companyshorttext: tooltipshorttext|  |
|saleStakeholder/contact/contactUdef/SuperOffice:2|string|Stakeholder - companylongtext: tooltiplongtext|  |
|saleStakeholder/contact/contactUdef/SuperOffice:3|int|Stakeholder - companynumber|  |
|saleStakeholder/contact/contactUdef/SuperOffice:4|date|Stakeholder - companydate|  |
|saleStakeholder/contact/contactUdef/SuperOffice:5|unlimitedDate|Stakeholder - companyunlimiteddate: tooltipunlimiteddate|  |
|saleStakeholder/contact/contactUdef/SuperOffice:6|bool|Stakeholder - companycheckbox|  |
|saleStakeholder/contact/contactUdef/SuperOffice:7|listAny|Stakeholder - companydropdownlistbox|  |
|saleStakeholder/contact/contactUdef/SuperOffice:8|decimal|Stakeholder - companydecimal|  |
|saleStakeholder/contact/contactUdef/SuperOffice:9|string|Stakeholder - page1saleonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:10|string|Stakeholder - page1marketingonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:11|string|Stakeholder - page1adminonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:12|listAny|Stakeholder - Udlist one: Static tooltip for udlist one|  |
|saleStakeholder/contact/contactUdef/SuperOffice:13|listAny|Stakeholder - Udlist two: Static tooltip for udlist two|  |
|saleStakeholder/contact/NumberOfActivities|int|Stakeholder - Number of activities|  |
|saleStakeholder/contact/NumberOfActivitiesInPeriod|int|Stakeholder - Number of activities in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedActivities|int|Stakeholder - Number of non-completed activities|  |
|saleStakeholder/contact/NumberOfNotCompletedActivitiesInPeriod|int|Stakeholder - Number of non-completed activities in last 90 days|  |
|saleStakeholder/contact/LastActivity|date|Stakeholder - Date of last activity|  |
|saleStakeholder/contact/LastCompletedActivity|date|Stakeholder - Date of last completed activity|  |
|saleStakeholder/contact/LastDoByActivity|date|Stakeholder - Date of last non-completed activity|  |
|saleStakeholder/contact/NumberOfSales|int|Stakeholder - Number of sales|  |
|saleStakeholder/contact/NumberOfSalesInPeriod|int|Stakeholder - Number of sales in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedSales|int|Stakeholder - Number of non-completed sales|  |
|saleStakeholder/contact/NumberOfNotCompletedSalesInPeriod|int|Stakeholder - Number of non-completed sales in last 90 days|  |
|saleStakeholder/contact/LastSale|date|Stakeholder - Date of last sale|  |
|saleStakeholder/contact/LastCompletedSale|date|Stakeholder - Date of last completed sale|  |
|saleStakeholder/contact/LastDoBySale|date|Stakeholder - Date of last non-completed sale|  |
|saleStakeholder/contact/NumberOfTickets|int|Stakeholder - Number of requests|  |
|saleStakeholder/contact/NumberOfTicketsInPeriod|int|Stakeholder - Number of requests in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedTickets|int|Stakeholder - Number of non-completed requests|  |
|saleStakeholder/contact/NumberOfNotCompletedTicketsInPeriod|int|Stakeholder - Number of non-completed requests in last 90 days|  |
|saleStakeholder/contact/LastTicket|date|Stakeholder - Date of last request|  |
|saleStakeholder/contact/LastCompletedTicket|date|Stakeholder - Date of last completed request|  |
|saleStakeholder/contact/LastDoByTicket|date|Stakeholder - Date of last non-completed request|  |
|saleStakeholder/contact/SaintStatus1|saintStatus|Stakeholder - Neglected customer|  |
|saleStakeholder/contact/SaintStatus2|saintStatus|Stakeholder - C-company|  |
|saleStakeholder/contact/saintSaleStatus|listAny|Stakeholder - With status|  |
|saleStakeholder/contact/saintAmountClass|listAny|Stakeholder - Amount class|  |
|saleStakeholder/contact/saintActivityType|listAny|Stakeholder - SAINT type|  |
|saleStakeholder/contact/saintDirection|listAny|Stakeholder - Direction|  |
|saleStakeholder/contact/saintIntention|listAny|Stakeholder - Intention|  |
|saleStakeholder/contact/saintTicketStatus|listAny|Stakeholder - Status|  |
|saleStakeholder/contact/saintTicketCategory|listAny|Stakeholder - Category|  |
|quote/quoteId|int|Quote ID: SuperOffice database ID of quote record|  |
|quote/poNumber|string|P.O. Number: Customer's purchase order number|  |
|quote/orderComment|string|Comment: Customer's comment|  |
|quote/connectionId|int|DB-ID: Database ID|  |
|quote/registeredDate|date|Registered at: Displays the date when the quote was registered.|  |
|quote/version/quoteVersionId|int|ID: Database ID of QuoteVersion record|  |
|quote/version/description|string|Description: Description of the quote version|  |
|quote/version/number|string|Number: Reference number for the quote version|  |
|quote/version/sent|date|Sent: The date the quote (version) was sent to the customer|  |
|quote/version/expiration|date|Expiry date: The last date that the quote is valid|  |
|quote/version/state|listAny|State: The current state the quote is in|  |
|quote/version/status|listAny|Quote status: Status field showing the status of each line.|  |
|quote/version/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.|  |
|quote/version/paymentTerms|listExternal|Payment terms: Payment terms|  |
|quote/version/paymentType|listExternal|Payment type: Payment type|  |
|quote/version/deliveryTerms|listExternal|Delivery terms: Delivery terms|  |
|quote/version/deliveryType|listExternal|Delivery type: Delivery type|  |
|quote/version/approvedBy|associate|Approved by: Associate who approved a quote that broke one or more of the workflow rules that trigger an approval process|  |
|quote/version/approvalRegisteredBy|associate|Approval reg by: Associate who entered the approval of a quote that broke one or more of the workflow rules that trigger an approval process.  Not necessarily the person who approved the quote.|  |
|quote/version/approvedText|string|Approval comment: Comment added to the approval of a quote that broke one or more of the workflow rules that trigger an approval process|  |
|quote/version/approvedDate|date|Approved date: Date of approval of a quote that broke one or more of the workflow rules that trigger an approval process|  |
|quote/version/extraField1|string|Extra field 1: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField2|string|Extra field 2: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField3|string|Extra field 3: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField4|string|Extra field 4: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField5|string|Extra field 5: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/alternative/quoteAlternativeId|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record|  |
|quote/version/alternative/quoteVersionId|int|ID: Database ID of QuoteVersion record|  |
|quote/version/alternative/name|string|Name: Name of the quote alternative|  |
|quote/version/alternative/description|string|Description: Description of the quote alternative|  |
|quote/version/alternative/status|listAny|Quote status: Status field showing the status of each line.|  |
|quote/version/alternative/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.|  |
|quote/version/alternative/erpDiscountPercent|decimal|ERP Discount %: Discount percentage suggested by ERP system|  |
|quote/version/alternative/erpDiscountAmount|decimal|ERP Discount: Discount amount suggested by ERP system|  |
|quote/version/alternative/discountPercent|decimal|Discount %: Enter discount in percent for entire alternative|  |
|quote/version/alternative/discountAmount|decimal|Discount: Enter total discount for entire alternative|  |
|quote/version/alternative/vatInfo|string|VAT Info: Information about value-added and other taxes|  |
|quote/version/alternative/vat|decimal|VAT: Value-added and other taxes, total amount|  |
|quote/version/alternative/earningPercent|decimal|Earnings %: Total Earnings as a percentage of the total price, of all lines in the quote alternative, including all discounts|  |
|quote/version/alternative/earningAmount|decimal|Earnings: Total Earnings for all lines in the quote alternative, including all discounts|  |
|quote/version/alternative/totalPrice|decimal|Total: Total price of all items in the quote alternative, including all discounts|  |
|quote/version/alternative/extraField1|string|Extra 1: Extra field 1 on the quote alternative|  |
|quote/version/alternative/extraField2|string|Extra 2: Extra field 2 on the quote alternative|  |
|quote/version/alternative/extraField3|string|Extra 3: Extra field 3on the quote alternative|  |
|quote/version/alternative/extraField4|string|Extra 4: Extra field 4 on the quote alternative|  |
|quote/version/alternative/extraField5|string|Extra 5: Extra field 5 on the quote alternative|  |
|quote/version/alternative/alternativeOrdering|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record|  |
|quote/version/alternative/subTotal|decimal|Total before discount: Total of all lines, before applying the Alternative discount|  |
|quote/version/alternative/totalPriceIncVAT|decimal|Total incl. VAT: Total of all lines, including VAT|  |
|quote/version/alternative/vatAmount|decimal|VAT: VAT (amount) for the alternative|  |
|quote/version/alternative/quoteline/quoteLineId|int|Quote line ID: Database identity of the quote line|  |
|quote/version/alternative/quoteline/quoteAlternativeId|int|Alternative ID: The database identity of the quote alternative|  |
|quote/version/alternative/quoteline/erpProductKey|string|Product key: The foreign key of the product the quote line is based on.|  |
|quote/version/alternative/quoteline/rank|int|Rank: Shows the rank of a product|  |
|quote/version/alternative/quoteline/quantity|decimal|Quantity: The quantity that is offered|  |
|quote/version/alternative/quoteline/name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.|  |
|quote/version/alternative/quoteline/description|string|Description: Description of the product that is offered|  |
|quote/version/alternative/quoteline/code|string|Code: The product or article code. This code is created to help you quickly find products you offer regularly.|  |
|quote/version/alternative/quoteline/quantityUnit|string|Unit: The unit of the product that is offered.|  |
|quote/version/alternative/quoteline/priceUnit|string|Price unit: What is the price unit defined in|  |
|quote/version/alternative/quoteline/url|string|Web address: The web address of the product info.|  |
|quote/version/alternative/quoteline/subscriptionUnit|string|Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month|  |
|quote/version/alternative/quoteline/subscriptionQuantity|decimal|Subscription quantity: Number of subscription units offered|  |
|quote/version/alternative/quoteline/UnitListPriceSubscriptionQuantity| *None* |Subscription list price: Unit price * subscription quantity|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionUnit| *None* |P/S Unit: Price unit/subscription unit|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionQuantityUnit| *None* |Expanded unit: Price unit @ subscription quantity + unit|  |
|quote/version/alternative/quoteline/vatInfo|string|VAT info: |  |
|quote/version/alternative/quoteline/vat|decimal|VAT: May be filled out by the ERP system|  |
|quote/version/alternative/quoteline/unitCost|decimal|Cost: Cost per item.|  |
|quote/version/alternative/quoteline/unitMinimumPrice|decimal|Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.|  |
|quote/version/alternative/quoteline/unitListPrice|decimal|List price: List price of a unit|  |
|quote/version/alternative/quoteline/totalPrice|decimal|Total: List price * Quantity - Discount Amount|  |
|quote/version/alternative/quoteline/totalCost|decimal|Total cost|  |
|quote/version/alternative/quoteline/quoteLineThumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|quote/version/alternative/quoteline/quoteLineThumbnailLarge| *None* |Thumbnail: A miniature version of the product picture|  |
|quote/version/alternative/quoteline/discountAmount|decimal|Discount: Discount amount given by salesperson|  |
|quote/version/alternative/quoteline/discountPercent|decimal|Discount (%: Discount percent given by salesperson|  |
|quote/version/alternative/quoteline/earningAmount|decimal|Earnings: Amount of Earnings (Total - Cost) on the line, after discount|  |
|quote/version/alternative/quoteline/earningPercent|decimal|Earnings (%: Percentage Earnings on the line (Total - Cost / Total), after discount|  |
|quote/version/alternative/quoteline/updatedBy|associate|Updated by: The user who last updated the data|  |
|quote/version/alternative/quoteline/updatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|quote/version/alternative/quoteline/registeredBy|associate|Registered by: The user who registered the data|  |
|quote/version/alternative/quoteline/registeredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|quote/version/alternative/quoteline/productCategoryKey|listExternal|Product category: The category the product is defined in|  |
|quote/version/alternative/quoteline/productFamilyKey|listExternal|Product family: The family the product is defined in|  |
|quote/version/alternative/quoteline/productTypeKey|listExternal|Product type: The type of product|  |
|quote/version/alternative/quoteline/status|listAny|Quote status: Status field showing the status of each line.|  |
|quote/version/alternative/quoteline/subTotal|decimal|Sum: Sum of Quantity * Unit list price|  |
|quote/version/alternative/quoteline/vatAmount|decimal|VAT (amount: The calculated VAT amount|  |
|quote/version/alternative/quoteline/totalPriceIncVAT|decimal|Total incl. VAT: Total including VAT|  |
|quote/version/alternative/quoteline/totalPriceWithAlternativeDiscount|decimal|Total incl. alt. disc: Total, including any discount percentage set on the alternative|  |
|destinationSaleRestrictionId|int|Destination sale ID: IDs of sales which are linked to|  |
|name|stringorPK|Project name: Displays the Project's name|  |
|number|string|Number: Displays the project's number|  |
|status|listAny|Status: Displays the project's status|  |
|hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published|  |
|projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date|  |
|projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date|  |
|projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectEvent/isExternalEvent|bool|Event: Is this an external event|  |
|projectEvent/eventDate|date|Event date: Event date|  |
|projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled|  |
|projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled|  |
|projectUrl/URLAddress|string|URL|  |
|projectUrl/URLDescription|string|Description|  |
|projectAssociate/firstName|string|First name: Displays the contact's first name|  |
|projectAssociate/lastName|string|Last name: Displays the contact's last name|  |
|projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.|  |
|projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)|  |
|projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms|  |
|projectAssociate/associateDbId|associate|ID|  |
|projectAssociate/contactName|string|Owning company: Name of the company the user belongs to|  |
|projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to|  |
|projectAssociate/usergroup|userGroup|Primary group: The user's primary user group|  |
|projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to|  |
|projectAssociate/contactCategory|listAny|Category: Category|  |
|projectAssociate/role|listAny|Role : Role|  |
|projectAssociate/assocName|associate|User ID : User ID|  |
|projectAssociate/assocTooltip|string|Description : Description|  |
|projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account|  |
|projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service|  |
|projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?|  |
|projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?|  |
|projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|projectAssociate/userName|string|User name: User name|  |
|projectAssociate/personEmail|string|E-mail|  |
|projectUdef/SuperOffice:1|string|projectshorttext|  |
|projectUdef/SuperOffice:2|string|projectlongtext|  |
|projectUdef/SuperOffice:3|int|projectnumber|  |
|projectUdef/SuperOffice:4|date|projectdate|  |
|projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate|  |
|projectUdef/SuperOffice:6|bool|projectcheckbox|  |
|projectUdef/SuperOffice:7|listAny|projectdropdownlistbox|  |
|projectUdef/SuperOffice:8|decimal|projectdecimal|  |
|projectUdef/SuperOffice:9|int|page1saleandmarketing|  |
|projectUdef/SuperOffice:10|int|page1saleandadmin|  |
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
|project/textId|int|Text ID|  |
|project/infoText|positiveString|Information: Displays the text entered in the description field|  |
|destinationProjectRestrictionId|int|ADD LINK PROJECT DESTINATION RESOURCE: ADD LINK PROJECT DESTINATION TOOLTIP RESOURCE|  |
|documentId|int|Document ID: Database ID of document record|  |
|keywords|string|Keywords |  |
|ourref|string|Our ref.|  |
|yourref|string|Your ref.|  |
|attention|string|Salutation|  |
|subject|string|Subject|  |
|mailMergeDraft|bool|Mail merge draft : Indicates whether the document is a mail merge template|  |
|snum|int|Document number: Serial number of document. It can be generated by the number allocation system for a dedicated document template.|  |
|isReport|bool|Report: Is this document a saved report run?|  |
|suggestedDocumentId|int|Document ID (suggestion: The database ID of a document that originates in a suggestion|  |
|isMail|bool|E-mail|  |
|documentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published|  |
|documentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date|  |
|documentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date|  |
|documentPublish/publishedBy| *None* |Published by: Published by|  |
|documentUdef/SuperOffice:1|string|documentshorttext|  |
|documentUdef/SuperOffice:2|string|documentlongtext|  |
|documentUdef/SuperOffice:3|int|documentnumber|  |
|documentUdef/SuperOffice:4|date|documentdate|  |
|documentUdef/SuperOffice:5|unlimitedDate|documentunlimiteddate|  |
|documentUdef/SuperOffice:6|bool|documentcheckbox|  |
|documentUdef/SuperOffice:7|listAny|documentdropdownlistbox|  |
|documentUdef/SuperOffice:8|decimal|documentdecimal|  |
|destinationDocumentRestrictionId|int|Destination document ID: IDs of documents which are linked to|  |
|document/textId|int|Text ID|  |
|document/description|positiveString|Text: Displays the text entered in the description field|  |
|URLAddress|string|URL|  |
|URLDescription|string|Description|  |
|destinationURLRestrictionId|int|ADD LINK URL DESTINATION RESOURCE: ADD LINK URL DESTINATION TOOLTIP RESOURCE|  |
|firstName|string|First name: Displays the contact's first name|  |
|lastName|string|Last name: Displays the contact's last name|  |
|middleName|string|Middle name: Displays the contact's middle name.|  |
|fullName|stringorPK|Contact: Displays the contact to which an item is linked|  |
|hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests|  |
|personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests|  |
|mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|position|listAny|Position|  |
|personNumber|string|Number: Displays the contact's number|  |
|title|string|Title: Displays the contact's job title|  |
|personCountry|listAny|Country: Country|  |
|personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox|  |
|rank|int|Rank: Displays a contact's current rank|  |
|birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|useAsMailingAddress|bool|Use as postal address: Use as postal address|  |
|personSource|listAny|Source: Source (Contact)|  |
|retired|bool|Former employee: Indicates whether the contact has retired/left the company|  |
|birthYear|int|Birth year: Displays contact's birth year|  |
|birthMonth|int|Birth month: Displays contact's birth month|  |
|birthDay|int|Birth day: Displays contact's birth day (day of month)|  |
|kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet|  |
|kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet|  |
|personUpdatedBy|associate|Updated by: The user who last updated the data|  |
|personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|personRegisteredBy|associate|Registered by: The user who registered the data|  |
|personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|portraitThumbnail| *None* |Person image: Person image|  |
|personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|ticketPriority|listAny|Service priority: Default service priority for this contact|  |
|supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more|  |
|supportAssociate|associate|Our service contact: Default service contact for this contact|  |
|personAssociateId|associate|Our contact: Displays our contact|  |
|personCategory|listAny|Category|  |
|personBusiness|listAny|Business|  |
|personDeletedDate|datetime|Deleted date: Deleted date|  |
|hasCompany|bool|Has company: The contact is associated with a company|  |
|isProjectMember|bool|Is project member: This person is a project member|  |
|isStakeholder|bool|Is stakeholder: This person is a sale stakeholder|  |
|destinationPersonRestrictionId|int|ADD LINK Person DESTINATION RESOURCE: ADD LINK Person DESTINATION TOOLTIP RESOURCE|  |
|department|string|Department|  |
|nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|category|listAny|Category|  |
|business|listAny|Business|  |
|country|listAny|Country: This criterion corresponds to the Country field on the Company card.|  |
|code|string|Code|  |
|orgnr|string|VAT No.|  |
|stop|bool|Stop|  |
|contactNoMail|bool|No mailings (company|  |
|contactSource|listAny|Source: Source (Company)|  |
|contactDeleted|bool|Deleted: Deleted|  |
|deletedDate|datetime|Deleted date: Deleted date|  |
|mainContact| *None* |Main contact: Main contact for this company|  |
|destinationContactRestrictionId|int|ADD LINK Contact DESTINATION RESOURCE: ADD LINK Contact DESTINATION TOOLTIP RESOURCE|  |
|selectionId|int|Selection ID: The database ID of the selection|  |
|kind|listAny|Selection is : The kind of selection (static, dynamic or combined)|  |
|targetTableNumber|listAny|Selection of: Displays what the selection consists of|  |
|combinationType|listAny|Combination type: Displays the combination type for a selection|  |
|done|bool|Completed: Shows whether the selection has been completed|  |
|lastLoaded|date|Viewed: When was the result list for the selection last shown|  |
|lastLoadedBy|associate|Viewed by: Who was the last person to show the result list for the selection|  |
|lastMembershipChange|date|Members changed: When was the result list for the selection last changed, for instance due to a change in the criteria|  |
|lastMembershipChangeBy|associate|Members changed by: Who was the last person to change the result list for the selection, for instance by changing the criteria|  |
|memberCount|int|Members: How many members were in the selection, the last time all were fetched. May be imprecise/outdated.|  |
|destinationSelectionRestrictionId|int|ADD LINK Selection DESTINATION RESOURCE: ADD LINK Selection DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/Links?$select=time,booking,contact/postAddress/county,contact/contactAssociate/contactName,saleStakeholder/person/personDirectFax/description
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

