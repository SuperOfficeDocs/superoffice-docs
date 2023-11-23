---
uid: TicketMessage
title: TicketMessage
description: Messages on support tickets. Messages are typically e-mail messages with attachments, but not always.
keywords: TicketMessage archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "TicketMessage"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TicketMessageProvider">SuperOffice.CRM.ArchiveLists.TicketMessageProvider</see> inside NetServer's SODatabase assembly.

Messages on support tickets. Messages are typically e-mail messages with attachments, but not always.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticketmessage"|[Ticket Message]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|searchTitle|string|Title| x |
|header|string|Header| x |
|ticketId|int|TicketId| x |
|author|string|Author: Displays the author of the request| x |
|createdAt|datetime|Created: Displays when the request was created| x |
|body|string|TextBody|  |
|htmlBody|string|HtmlBody|  |
|messageId|string|MessageId| x |
|debugInfo|string|DebugInfo|  |
|important|bool|Important?| x |
|slevel|listAny|SLevel| x |
|ticket/contactId|int|Request - Company ID: Database ID of company| x |
|ticket/personId|int|Request - Contact ID: Database ID of the contact row| x |
|ticket/saleId|int|Request - Sale ID: The database ID of the sale record| x |
|ticket/projectId|int|Request - Project ID: Database ID of project record| x |
|ticket/ticketStatusName|listAny|Request - Status: Request status| x |
|ticket/categoryFullName|ejCategory|Request - Category: Request category| x |
|ticket/priorityName|listAny|Request - Priority: Service priority| x |
|ticket/ticketId|int|Request - ID: Displays request ID| x |
|ticket/title|string|Request - Title: Displays the request title| x |
|ticket/createdAt|datetime|Request - Created: Displays when the request was created| x |
|ticket/lastChanged|datetime|Request - Last changed: Displays when the request was last changed| x |
|ticket/author|string|Request - Author: Displays the author of the request| x |
|ticket/readByOwner|datetime|Request - Read by owner: Displays when the request was read by the owner| x |
|ticket/firstReadByOwner|datetime|Request - First read by owner: Displays when the request was read by owner for the first time| x |
|ticket/firstReadByUser|datetime|Request - First read by user: Displays when the request was read by user for the first time| x |
|ticket/readByCustomer|datetime|Request - Read by contact: Displays when the request was read by the contact| x |
|ticket/status|listAny|Request - Internal status: Shows only system defined statuses for a request| x |
|ticket/origin|listAny|Request - Origin: Origin| x |
|ticket/slevel|listAny|Request - Access level: Access level| x |
|ticket/numberOfMessages|int|Request - Number of messages: Number of messages| x |
|ticket/numberOfReplies|int|Request - Number of replies: Number of replies| x |
|ticket/connectId|int|Request - Merged with request: Merged with request| x |
|ticket/readStatus|listAny|Request - Read: Read| x |
|ticket/realTimeSpentQueue|timeSpan|Request - Real time in queue: Real time in queue| x |
|ticket/realTimeSpentExternally|timeSpan|Request - Real time externally: Real time externally| x |
|ticket/realTimeSpentInternally|timeSpan|Request - Real time internally: Real time internally| x |
|ticket/timeSpentQueue|timeSpan|Request - Time spent in queue: Time spent in queue| x |
|ticket/timeSpentExternally|timeSpan|Request - Time spent externally: Time spent externally| x |
|ticket/timeSpentInternally|timeSpan|Request - Time spent internally: Time spent internally| x |
|ticket/timeSpent|timeSpan|Request - Time spent: Time spent| x |
|ticket/timeToReply|timeSpan|Request - Time to reply: Time to reply| x |
|ticket/timeToClose|timeSpan|Request - Time to close: Time to close| x |
|ticket/realTimeToReply|timeSpan|Request - Real time to reply: Real time to reply| x |
|ticket/realTimeToClose|timeSpan|Request - Real time to close: Real time to close| x |
|ticket/repliedAt|datetime|Request - Replied at: Replied at| x |
|ticket/closedAt|datetime|Request - Closed at: Closed at| x |
|ticket/activated|datetime|Request - Postponed to: Postponed to| x |
|ticket/deadline|datetime|Request - Deadline: Deadline| x |
|ticket/has\_attachment|bool|Request - Has attachment: Indicates whether the e-mail has one or more attachments| x |
|ticket/tags|intArray|Request - Tags: Tags connected to a request| x |
|ticket/ownedBy|ejUser|Request - Owner: The owner of the request| x |
|ticket/content|string|Request - Content: Search for content in messages related to requests| x |
|ticket/messageLanguage|listAny|Request - Language: Recognized language in messages|  |
|ticket/sentimentScore|listAny|Request - Sentiment: Sentiment score, -100 to +100|  |
|ticket/suggestedCategory|listAny|Request - Sugg.Cat.: Suggested service category|  |
|ticket/createdBy/firstName|string|Request - Created by - First name: Displays the contact's first name| x |
|ticket/createdBy/lastName|string|Request - Created by - Last name: Displays the contact's last name| x |
|ticket/createdBy/middleName|string|Request - Created by - Middle Name: Displays the contact's middle name.| x |
|ticket/createdBy/fullName|string|Request - Created by - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ticket/createdBy/contactId|int|Request - Created by - Company ID: Database ID of the company the user belongs to|  |
|ticket/createdBy/personId|int|Request - Created by - Contact ID: Database ID of the contact row|  |
|ticket/createdBy/mrMrs|string|Request - Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/createdBy/title|string|Request - Created by - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/createdBy/associateDbId|associate|Request - Created by - ID| x |
|ticket/createdBy/contactName|string|Request - Created by - Owning company: Name of the company the user belongs to| x |
|ticket/createdBy/contactDepartment|string|Request - Created by - Owning department: Name of the department at the company the user belongs to| x |
|ticket/createdBy/usergroup|userGroup|Request - Created by - Primary group: The user's primary user group| x |
|ticket/createdBy/contactFullName|string|Request - Created by - Owner: Name and department of the company the user belongs to| x |
|ticket/createdBy/contactCategory|listAny|Request - Created by - Category: Category| x |
|ticket/createdBy/role|listAny|Request - Created by - Role: Role| x |
|ticket/createdBy/assocName|associate|Request - Created by - User ID: User ID| x |
|ticket/createdBy/assocTooltip|string|Request - Created by - Description: Description|  |
|ticket/createdBy/assocType|listAny|Request - Created by - Type: Type of user: associate, external user, system user, anonymous account| x |
|ticket/createdBy/ejUserId|int|Request - Created by - Service user ID: The database ID of a Service user|  |
|ticket/createdBy/simultaneousEjUser|bool|Request - Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ticket/createdBy/ejDisplayName|string|Request - Created by - Nick name: User's nick name in Service| x |
|ticket/createdBy/ejStatus|int|Request - Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ticket/createdBy/credentialType| *None* |Request - Created by - Auth. type: What type of credentials to use when this user logs in| x |
|ticket/createdBy/credentialDisplayValue| *None* |Request - Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ticket/createdBy/isActive|bool|Request - Created by - Active: Is this user active, and should be able to log in?| x |
|ticket/createdBy/isActiveText|bool|Request - Created by - Active status: Is this user active, and should be able to log in?| x |
|ticket/createdBy/portraitThumbnail| *None* |Request - Created by - Person image: Person image|  |
|ticket/createdBy/otherGroups|userGroup|Request - Created by - Other groups: Other groups|  |
|ticket/createdBy/userName|string|Request - Created by - User name: User name| x |
|ticket/createdBy/personEmail|string|Request - Created by - E-mail| x |
|ticket/ownedBy/firstName|string|Request - Owner - First name: Displays the contact's first name| x |
|ticket/ownedBy/lastName|string|Request - Owner - Last name: Displays the contact's last name| x |
|ticket/ownedBy/middleName|string|Request - Owner - Middle Name: Displays the contact's middle name.| x |
|ticket/ownedBy/fullName|string|Request - Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ticket/ownedBy/contactId|int|Request - Owner - Company ID: Database ID of the company the user belongs to|  |
|ticket/ownedBy/personId|int|Request - Owner - Contact ID: Database ID of the contact row|  |
|ticket/ownedBy/mrMrs|string|Request - Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/ownedBy/title|string|Request - Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/ownedBy/associateDbId|associate|Request - Owner - ID| x |
|ticket/ownedBy/contactName|string|Request - Owner - Owning company: Name of the company the user belongs to| x |
|ticket/ownedBy/contactDepartment|string|Request - Owner - Owning department: Name of the department at the company the user belongs to| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/ownedBy/usergroup|userGroup|Request - Owner - Primary group: The user's primary user group| x |
|ticket/ownedBy/contactFullName|string|Request - Owner - Owner: Name and department of the company the user belongs to| x |
|ticket/ownedBy/contactCategory|listAny|Request - Owner - Category: Category| x |
|ticket/ownedBy/role|listAny|Request - Owner - Role: Role| x |
|ticket/ownedBy/assocName|associate|Request - Owner - User ID: User ID| x |
|ticket/ownedBy/assocTooltip|string|Request - Owner - Description: Description|  |
|ticket/ownedBy/assocType|listAny|Request - Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|ticket/ownedBy/ejUserId|int|Request - Owner - Service user ID: The database ID of a Service user|  |
|ticket/ownedBy/simultaneousEjUser|bool|Request - Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ticket/ownedBy/ejDisplayName|string|Request - Owner - Nick name: User's nick name in Service| x |
|ticket/ownedBy/ejStatus|int|Request - Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ticket/ownedBy/credentialType| *None* |Request - Owner - Auth. type: What type of credentials to use when this user logs in| x |
|ticket/ownedBy/credentialDisplayValue| *None* |Request - Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ticket/ownedBy/isActive|bool|Request - Owner - Active: Is this user active, and should be able to log in?| x |
|ticket/ownedBy/isActiveText|bool|Request - Owner - Active status: Is this user active, and should be able to log in?| x |
|ticket/ownedBy/portraitThumbnail| *None* |Request - Owner - Person image: Person image|  |
|ticket/ownedBy/otherGroups|userGroup|Request - Owner - Other groups: Other groups|  |
|ticket/ownedBy/userName|string|Request - Owner - User name: User name| x |
|ticket/ownedBy/personEmail|string|Request - Owner - E-mail| x |
|ticket/person/personId|int|Request - DB ID: Displays the database ID of a contact| x |
|ticket/person/firstName|string|Request - First name: Displays the contact's first name| x |
|ticket/person/lastName|string|Request - Last name: Displays the contact's last name| x |
|ticket/person/middleName|string|Request - Middle name: Displays the contact's middle name.| x |
|ticket/person/fullName|stringorPK|Request - Contact: Displays the contact to which an item is linked| x |
|ticket/person/contactId|int|Request - Company ID: Database ID of company| x |
|ticket/person/hasInfoText|bool|Request - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|ticket/person/hasInterests|bool|Request - Has interests: Displays an Icon indicating if the contact has active interests| x |
|ticket/person/personHasInterests|bool|Request - Has interests: Displays an Icon indicating if the contact has active interests| x |
|ticket/person/mrMrs|string|Request - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/person/position|listAny|Request - Position| x |
|ticket/person/personNumber|string|Request - Number: Displays the contact's number| x |
|ticket/person/title|string|Request - Title: Displays the contact's job title| x |
|ticket/person/personCountry|listAny|Request - Country: Country| x |
|ticket/person/personCountryId|int|Request - Country ID: Country ID| x |
|ticket/person/personNoMail|bool|Request - No Mailings: Displays the contact's No Mailings checkbox| x |
|ticket/person/rank|int|Request - Rank: Displays a contact's current rank| x |
|ticket/person/birthdate| *None* |Request - Birthdate: Displays the contact's date of birth|  |
|ticket/person/associateType| *None* |Request - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|ticket/person/useAsMailingAddress|bool|Request - Use as postal address: Use as postal address| x |
|ticket/person/personSource|listAny|Request - Source: Source (Contact)| x |
|ticket/person/retired|bool|Request - Former employee: Indicates whether the contact has retired/left the company| x |
|ticket/person/birthYear|int|Request - Birth year: Displays contact's birth year| x |
|ticket/person/birthMonth|int|Request - Birth month: Displays contact's birth month| x |
|ticket/person/birthDay|int|Request - Birth day: Displays contact's birth day (day of month)| x |
|ticket/person/kanaFirstName|string|Request - First name, kana: Contact's first name, in kana alphabet| x |
|ticket/person/kanaLastName|string|Request - Last name, kana: Contact's last name, in kana alphabet| x |
|ticket/person/personUpdatedBy|associate|Request - Updated by: The user who last updated the data| x |
|ticket/person/personUpdatedByFullName|associate|Request - Updated by - Full name: The user who last updated the data| x |
|ticket/person/personUpdatedDate|date|Request - Updated: The date/time the data was last updated in UTC.| x |
|ticket/person/personRegisteredBy|associate|Request - Registered by: The user who registered the data| x |
|ticket/person/personRegisteredByFullName|associate|Request - Registered by - Full name: The user who registered the data| x |
|ticket/person/personRegisteredDate|date|Request - Registered date: The date/time the data was registered in UTC.| x |
|ticket/person/portraitThumbnail| *None* |Request - Person image: Person image|  |
|ticket/person/personActiveErpLinks|bool|Request - ERP connected: Is there an active ERP Sync?| x |
|ticket/person/ticketPriority|listAny|Request - Service priority: Default service priority for this contact| x |
|ticket/person/supportLanguage|listAny|Request - Preferred language: Preferred language used for reply templates and more| x |
|ticket/person/supportAssociate|associate|Request - Our service contact: Default service contact for this contact| x |
|ticket/person/supportAssociateFullName|associate|Request - Our service contact - Full name: Default service contact for this contact| x |
|ticket/person/personAssociateId|associate|Request - Our contact: Displays our contact| x |
|ticket/person/personAssociateFullName|associate|Request - Our contact - Full name: Displays our contact| x |
|ticket/person/personCategory|listAny|Request - Category| x |
|ticket/person/personBusiness|listAny|Request - Business| x |
|ticket/person/personDeletedDate|datetime|Request - Deleted date: Deleted date|  |
|ticket/person/hasCompany|bool|Request - Has company: The contact is associated with a company| x |
|ticket/person/isProjectMember|bool|Request - Is project member: This person is a project member| x |
|ticket/person/isStakeholder|bool|Request - Is stakeholder: This person is a sale stakeholder| x |
|ticket/person/phone/formattedNumber|string|Request - Phone: Displays phone number|  |
|ticket/person/personDirectPhone/formattedNumber|string|Request - Direct - Phone: Displays phone number|  |
|ticket/person/personDirectPhone/description|string|Request - Direct - Description: Phone number description| x |
|ticket/person/personMobilePhone/formattedNumber|string|Request - Mobile - Phone: Displays phone number|  |
|ticket/person/personMobilePhone/description|string|Request - Mobile - Description: Phone number description| x |
|ticket/person/personPrivate/formattedNumber|string|Request - Private - Phone: Displays phone number|  |
|ticket/person/personPrivate/description|string|Request - Private - Description: Phone number description| x |
|ticket/person/personPager/formattedNumber|string|Request - Other - Phone: Displays phone number|  |
|ticket/person/personPager/description|string|Request - Other - Description: Phone number description| x |
|ticket/person/personDirectFax/formattedNumber|string|Request - Fax - Phone: Displays phone number|  |
|ticket/person/personDirectFax/description|string|Request - Fax - Description: Phone number description| x |
|ticket/person/searchPhone/formattedNumber|string|Request - Phone: Displays phone number|  |
|ticket/person/searchPhone/description|string|Request - Description: Phone number description| x |
|ticket/person/personInfo/textId|int|Request - Text ID| x |
|ticket/person/personInfo/infoText|positiveString|Request - Information: Displays the text entered in the description field| x |
|ticket/person/email/emailProtocol|string|Request - Protocol: E-mail protocol, such as SMTP| x |
|ticket/person/email/emailAddress|string|Request - E-mail| x |
|ticket/person/email/emailDescription|string|Request - Description| x |
|ticket/person/email/emailId|int|Request - ID| x |
|ticket/person/email/emailLastSent|datetime|Request - Last sent: The date and time an e-mail was last sent to this address| x |
|ticket/person/email/emailBounceCount|int|Request - Bounce count: Bounce count for this e-mail address| x |
|ticket/person/email/emailLastBounce|datetime|Request - Last bounce: Date and time for last bounce to this e-mail address| x |
|ticket/person/email/emailHasBounced|bool|Request - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|ticket/person/personUrl/URLAddress|string|Request - URL| x |
|ticket/person/personUrl/URLDescription|string|Request - Description| x |
|ticket/person/personAddress/addressId|int|Request - Contact address - Address ID: Database ID for the address record| x |
|ticket/person/personAddress/line1|string|Request - Contact address - Address 1: First line of the address| x |
|ticket/person/personAddress/line2|string|Request - Contact address - Address 2: Second line of the address| x |
|ticket/person/personAddress/line3|string|Request - Contact address - Address 3: Third line of the address| x |
|ticket/person/personAddress/county|string|Request - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|ticket/person/personAddress/city|string|Request - Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|ticket/person/personAddress/zip|string|Request - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|ticket/person/personAddress/state|string|Request - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|ticket/person/personAddress/wgs84latitude|decimal|Request - Contact address - Latitude: Latitude| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/person/personAddress/wgs84longitude|decimal|Request - Contact address - Longitude: Longitude| x |
|ticket/person/personAddress/formattedAddress| *None* |Request - Contact address - {formattedAddress}: {formattedAddress}|  |
|ticket/person/personAddress/formattedMultiLineAddress| *None* |Request - Contact address - {formattedAddress}: {formattedAddress}|  |
|ticket/person/restrictionAddress/addressId|int|Request - Search address - Address ID: Database ID for the address record| x |
|ticket/person/restrictionAddress/line1|string|Request - Search address - Address 1: First line of the address| x |
|ticket/person/restrictionAddress/line2|string|Request - Search address - Address 2: Second line of the address| x |
|ticket/person/restrictionAddress/line3|string|Request - Search address - Address 3: Third line of the address| x |
|ticket/person/restrictionAddress/county|string|Request - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|ticket/person/restrictionAddress/city|string|Request - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|ticket/person/restrictionAddress/zip|string|Request - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|ticket/person/restrictionAddress/state|string|Request - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|ticket/person/restrictionAddress/wgs84latitude|decimal|Request - Search address - Latitude: Latitude| x |
|ticket/person/restrictionAddress/wgs84longitude|decimal|Request - Search address - Longitude: Longitude| x |
|ticket/person/restrictionAddress/formattedAddress| *None* |Request - Search address - {formattedAddress}: {formattedAddress}|  |
|ticket/person/restrictionAddress/formattedMultiLineAddress| *None* |Request - Search address - {formattedAddress}: {formattedAddress}|  |
|ticket/person/personInterestIds|listInterest|Request - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|ticket/person/personUdef/SuperOffice:1|string|Request - contactshorttext: tooltipshorttext| x |
|ticket/person/personUdef/SuperOffice:2|string|Request - contactlongtext: tooltiplongtext| x |
|ticket/person/personUdef/SuperOffice:3|int|Request - contactnumber| x |
|ticket/person/personUdef/SuperOffice:4|date|Request - contactdate| x |
|ticket/person/personUdef/SuperOffice:5|unlimitedDate|Request - contactunlimiteddate: tooltipunlimiteddate| x |
|ticket/person/personUdef/SuperOffice:6|bool|Request - contactcheckbox| x |
|ticket/person/personUdef/SuperOffice:7|listAny|Request - contactdropdownlistbox| x |
|ticket/person/personUdef/SuperOffice:8|decimal|Request - contactdecimal| x |
|ticket/person/personUdef/SuperOffice:9|string|Request - page1saleonly| x |
|ticket/person/personUdef/SuperOffice:10|string|Request - page1marketingonly| x |
|ticket/person/personUdef/SuperOffice:11|string|Request - page1adminonly| x |
|ticket/person/personExtra/x\_person\_integer|int|Request - Extra Integer: Custom person integer| x |
|ticket/person/personExtra/x\_person\_hidden\_integer|int|Request - Extra hidden integer: Custom integer field that is hidden| x |
|ticket/person/personExtra/x\_person\_float|decimal|Request - Extra float: Custom float field| x |
|ticket/person/personExtra/x\_person\_longtext|string|Request - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|ticket/person/personExtra/x\_person\_date|date|Request - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|ticket/person/personExtra/x\_person\_datetime|datetime|Request - Extra DateTime: Custom person date and time field. No default| x |
|ticket/person/personExtra/x\_person\_time| *None* |Request - Extra time: Custom time field on person. Current time as default| x |
|ticket/person/personExtra/x\_person\_boolean|bool|Request - Extra Boolean: Custom boolean field on person. Default checked| x |
|ticket/person/personExtra/x\_person\_timespan|timeSpan|Request - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|ticket/person/personExtra/x\_person\_shorttext|string|Request - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|ticket/person/personExtra/x\_person\_shorttext\_list|listAny|Request - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|ticket/person/personExtra/x\_person\_user\_relation|associate|Request - Extra user relation: Custom person-user relation field| x |
|ticket/person/personExtra/x\_person\_category\_relation|listAny|Request - Extra category relation: Custom person-category relation| x |
|ticket/person/personExtra/x\_person\_priority\_relation|listAny|Request - Extra priority relation: Custom person-priority relation| x |
|ticket/person/personExtra/x\_person\_request\_relation|stringorPK|Request - Extra request relation: Request relation on contact| x |
|ticket/person/personExtra/x\_person\_appointment\_relation|stringorPK|Request - Extra appointment relation: Appointment relation on person| x |
|ticket/person/personExtra/x\_person\_contact\_relation|stringorPK|Request - Extra company relation: Company relation on contact| x |
|ticket/person/personExtra/y\_rental/id|int|Request - Rental - id: Displays the row's primary key (y\_rental)| x |
|ticket/person/personExtra/y\_rental/x\_start|date|Request - Rental - Start rental| x |
|ticket/person/personExtra/y\_rental/x\_end|date|Request - Rental - End| x |
|ticket/person/personExtra/y\_rental/x\_amount|int|Request - Rental - Amount: Number to rent. Default = 1| x |
|ticket/person/personExtra/y\_rental/x\_contact|stringorPK|Request - Rental - Renter: Company that rents equipment| x |
|ticket/person/personExtra/y\_rental/y\_equipment/x\_name|string|Request - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|ticket/person/personAssociate/firstName|string|Request - First name: Displays the contact's first name| x |
|ticket/person/personAssociate/lastName|string|Request - Last name: Displays the contact's last name| x |
|ticket/person/personAssociate/middleName|string|Request - Middle Name: Displays the contact's middle name.| x |
|ticket/person/personAssociate/fullName|string|Request - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ticket/person/personAssociate/contactId|int|Request - Company ID: Database ID of the company the user belongs to|  |
|ticket/person/personAssociate/personId|int|Request - Contact ID: Database ID of the contact row|  |
|ticket/person/personAssociate/mrMrs|string|Request - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/person/personAssociate/title|string|Request - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/person/personAssociate/associateDbId|associate|Request - ID| x |
|ticket/person/personAssociate/contactName|string|Request - Owning company: Name of the company the user belongs to| x |
|ticket/person/personAssociate/contactDepartment|string|Request - Owning department: Name of the department at the company the user belongs to| x |
|ticket/person/personAssociate/usergroup|userGroup|Request - Primary group: The user's primary user group| x |
|ticket/person/personAssociate/contactFullName|string|Request - Owner: Name and department of the company the user belongs to| x |
|ticket/person/personAssociate/contactCategory|listAny|Request - Category: Category| x |
|ticket/person/personAssociate/role|listAny|Request - Role: Role| x |
|ticket/person/personAssociate/assocName|associate|Request - User ID: User ID| x |
|ticket/person/personAssociate/assocTooltip|string|Request - Description: Description|  |
|ticket/person/personAssociate/assocType|listAny|Request - Type: Type of user: associate, external user, system user, anonymous account| x |
|ticket/person/personAssociate/ejUserId|int|Request - Service user ID: The database ID of a Service user|  |
|ticket/person/personAssociate/simultaneousEjUser|bool|Request - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ticket/person/personAssociate/ejDisplayName|string|Request - Nick name: User's nick name in Service| x |
|ticket/person/personAssociate/ejStatus|int|Request - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ticket/person/personAssociate/credentialType| *None* |Request - Auth. type: What type of credentials to use when this user logs in| x |
|ticket/person/personAssociate/credentialDisplayValue| *None* |Request - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ticket/person/personAssociate/isActive|bool|Request - Active: Is this user active, and should be able to log in?| x |
|ticket/person/personAssociate/isActiveText|bool|Request - Active status: Is this user active, and should be able to log in?| x |
|ticket/person/personAssociate/portraitThumbnail| *None* |Request - Person image: Person image|  |
|ticket/person/personAssociate/otherGroups|userGroup|Request - Other groups: Other groups|  |
|ticket/person/personAssociate/userName|string|Request - User name: User name| x |
|ticket/person/personAssociate/personEmail|string|Request - E-mail| x |
|ticket/person/correspondingAssociate/firstName|string|Request - First name: Displays the contact's first name| x |
|ticket/person/correspondingAssociate/lastName|string|Request - Last name: Displays the contact's last name| x |
|ticket/person/correspondingAssociate/middleName|string|Request - Middle Name: Displays the contact's middle name.| x |
|ticket/person/correspondingAssociate/fullName|string|Request - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ticket/person/correspondingAssociate/contactId|int|Request - Company ID: Database ID of the company the user belongs to|  |
|ticket/person/correspondingAssociate/personId|int|Request - Contact ID: Database ID of the contact row|  |
|ticket/person/correspondingAssociate/mrMrs|string|Request - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/person/correspondingAssociate/title|string|Request - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/person/correspondingAssociate/associateDbId|associate|Request - ID| x |
|ticket/person/correspondingAssociate/contactName|string|Request - Owning company: Name of the company the user belongs to| x |
|ticket/person/correspondingAssociate/contactDepartment|string|Request - Owning department: Name of the department at the company the user belongs to| x |
|ticket/person/correspondingAssociate/usergroup|userGroup|Request - Primary group: The user's primary user group| x |
|ticket/person/correspondingAssociate/contactFullName|string|Request - Owner: Name and department of the company the user belongs to| x |
|ticket/person/correspondingAssociate/contactCategory|listAny|Request - Category: Category| x |
|ticket/person/correspondingAssociate/role|listAny|Request - Role: Role| x |
|ticket/person/correspondingAssociate/assocName|associate|Request - User ID: User ID| x |
|ticket/person/correspondingAssociate/assocTooltip|string|Request - Description: Description|  |
|ticket/person/correspondingAssociate/assocType|listAny|Request - Type: Type of user: associate, external user, system user, anonymous account| x |
|ticket/person/correspondingAssociate/ejUserId|int|Request - Service user ID: The database ID of a Service user|  |
|ticket/person/correspondingAssociate/simultaneousEjUser|bool|Request - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/person/correspondingAssociate/ejDisplayName|string|Request - Nick name: User's nick name in Service| x |
|ticket/person/correspondingAssociate/ejStatus|int|Request - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ticket/person/correspondingAssociate/credentialType| *None* |Request - Auth. type: What type of credentials to use when this user logs in| x |
|ticket/person/correspondingAssociate/credentialDisplayValue| *None* |Request - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ticket/person/correspondingAssociate/isActive|bool|Request - Active: Is this user active, and should be able to log in?| x |
|ticket/person/correspondingAssociate/isActiveText|bool|Request - Active status: Is this user active, and should be able to log in?| x |
|ticket/person/correspondingAssociate/portraitThumbnail| *None* |Request - Person image: Person image|  |
|ticket/person/correspondingAssociate/otherGroups|userGroup|Request - Other groups: Other groups|  |
|ticket/person/correspondingAssociate/userName|string|Request - User name: User name| x |
|ticket/person/correspondingAssociate/personEmail|string|Request - E-mail| x |
|ticket/person/isMailingRecipient|bool|Request - Is mailing recipient: isMailingRecipient| x |
|ticket/person/hasStoreConsent|bool|Request - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|ticket/person/withdrawnStoreConsent|bool|Request - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|ticket/person/hasEmarketingConsent|bool|Request - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|ticket/person/withdrawnEmarketingConsent|bool|Request - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|ticket/person/subscription|listAny|Request - Subscription: Subscription for marketing| x |
|ticket/person/legalBaseStore|listAny|Request - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|ticket/person/legalBaseEmarketing|listAny|Request - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|ticket/person/consentSourceStore|listAny|Request - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|ticket/person/consentSourceEmarketing|listAny|Request - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|ticket/contact/contactId|int|Request - Company ID: Database ID of company| x |
|ticket/contact/name|stringorPK|Request - Company name| x |
|ticket/contact/department|string|Request - Department| x |
|ticket/contact/nameDepartment| *None* |Request - Company: Displays the company an activity is linked to| x |
|ticket/contact/hasInfoText|bool|Request - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|ticket/contact/hasInterests|bool|Request - Has interests: Displays an Icon indicating if the contact has active interests| x |
|ticket/contact/associateId|associate|Request - Our contact: Displays our contact| x |
|ticket/contact/category|listAny|Request - Category| x |
|ticket/contact/business|listAny|Request - Business| x |
|ticket/contact/country|listAny|Request - Country: This criterion corresponds to the Country field on the Company card.| x |
|ticket/contact/countryId|int|Request - Country ID: Country ID| x |
|ticket/contact/number|string|Request - Number| x |
|ticket/contact/code|string|Request - Code| x |
|ticket/contact/orgnr|string|Request - VAT No.| x |
|ticket/contact/stop|bool|Request - Stop| x |
|ticket/contact/contactNoMail|bool|Request - No mailings (company)| x |
|ticket/contact/updatedBy|associate|Request - Updated by: The user who last updated the data| x |
|ticket/contact/updatedByFullName|associate|Request - Updated by - Full name: The user who last updated the data| x |
|ticket/contact/updatedDate|date|Request - Updated: The date/time the data was last updated in UTC.| x |
|ticket/contact/registeredBy|associate|Request - Registered by: The user who registered the data| x |
|ticket/contact/registeredByFullName|associate|Request - Registered by - Full name: The user who registered the data| x |
|ticket/contact/registeredDate|date|Request - Registered date: The date/time the data was registered in UTC.| x |
|ticket/contact/contactSource|listAny|Request - Source: Source (Company)| x |
|ticket/contact/contactDeleted|bool|Request - Deleted: Deleted| x |
|ticket/contact/phone/formattedNumber|string|Request - Phone: Displays phone number|  |
|ticket/contact/activeErpLinks|bool|Request - ERP connected: Is there an active ERP Sync?| x |
|ticket/contact/deletedDate|datetime|Request - Deleted date: Deleted date|  |
|ticket/contact/mainContact| *None* |Request - Main contact: Main contact for this company| x |
|ticket/contact/contactPhone/formattedNumber|string|Request - Telephone - Phone: Displays phone number|  |
|ticket/contact/contactPhone/description|string|Request - Telephone - Description: Phone number description| x |
|ticket/contact/contactFax/formattedNumber|string|Request - Fax - Phone: Displays phone number|  |
|ticket/contact/contactFax/description|string|Request - Fax - Description: Phone number description| x |
|ticket/contact/searchPhone/formattedNumber|string|Request - Searchphone - Phone: Displays phone number|  |
|ticket/contact/searchPhone/description|string|Request - Searchphone - Description: Phone number description| x |
|ticket/contact/email/emailProtocol|string|Request - Protocol: E-mail protocol, such as SMTP| x |
|ticket/contact/email/emailAddress|string|Request - E-mail| x |
|ticket/contact/email/emailDescription|string|Request - Description| x |
|ticket/contact/email/emailId|int|Request - ID| x |
|ticket/contact/email/emailLastSent|datetime|Request - Last sent: The date and time an e-mail was last sent to this address| x |
|ticket/contact/email/emailBounceCount|int|Request - Bounce count: Bounce count for this e-mail address| x |
|ticket/contact/email/emailLastBounce|datetime|Request - Last bounce: Date and time for last bounce to this e-mail address| x |
|ticket/contact/email/emailHasBounced|bool|Request - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|ticket/contact/postAddress/addressId|int|Request - Postal address - Address ID: Database ID for the address record| x |
|ticket/contact/postAddress/line1|string|Request - Postal address - Address 1: First line of the address| x |
|ticket/contact/postAddress/line2|string|Request - Postal address - Address 2: Second line of the address| x |
|ticket/contact/postAddress/line3|string|Request - Postal address - Address 3: Third line of the address| x |
|ticket/contact/postAddress/county|string|Request - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|ticket/contact/postAddress/city|string|Request - Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|ticket/contact/postAddress/zip|string|Request - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|ticket/contact/postAddress/state|string|Request - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|ticket/contact/postAddress/wgs84latitude|decimal|Request - Postal address - Latitude: Latitude| x |
|ticket/contact/postAddress/wgs84longitude|decimal|Request - Postal address - Longitude: Longitude| x |
|ticket/contact/postAddress/formattedAddress| *None* |Request - Postal address - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/postAddress/formattedMultiLineAddress| *None* |Request - Postal address - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/streetAddress/addressId|int|Request - Street address - Address ID: Database ID for the address record| x |
|ticket/contact/streetAddress/line1|string|Request - Street address - Address 1: First line of the address| x |
|ticket/contact/streetAddress/line2|string|Request - Street address - Address 2: Second line of the address| x |
|ticket/contact/streetAddress/line3|string|Request - Street address - Address 3: Third line of the address| x |
|ticket/contact/streetAddress/county|string|Request - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|ticket/contact/streetAddress/city|string|Request - Street address - City: This criterion corresponds to the City field on the Company card.| x |
|ticket/contact/streetAddress/zip|string|Request - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|ticket/contact/streetAddress/state|string|Request - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|ticket/contact/streetAddress/wgs84latitude|decimal|Request - Street address - Latitude: Latitude| x |
|ticket/contact/streetAddress/wgs84longitude|decimal|Request - Street address - Longitude: Longitude| x |
|ticket/contact/streetAddress/formattedAddress| *None* |Request - Street address - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/streetAddress/formattedMultiLineAddress| *None* |Request - Street address - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/restrictionAddress/addressId|int|Request - Search address - Address ID: Database ID for the address record| x |
|ticket/contact/restrictionAddress/line1|string|Request - Search address - Address 1: First line of the address| x |
|ticket/contact/restrictionAddress/line2|string|Request - Search address - Address 2: Second line of the address| x |
|ticket/contact/restrictionAddress/line3|string|Request - Search address - Address 3: Third line of the address| x |
|ticket/contact/restrictionAddress/county|string|Request - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|ticket/contact/restrictionAddress/city|string|Request - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|ticket/contact/restrictionAddress/zip|string|Request - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|ticket/contact/restrictionAddress/state|string|Request - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|ticket/contact/restrictionAddress/wgs84latitude|decimal|Request - Search address - Latitude: Latitude| x |
|ticket/contact/restrictionAddress/wgs84longitude|decimal|Request - Search address - Longitude: Longitude| x |
|ticket/contact/restrictionAddress/formattedAddress| *None* |Request - Search address - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/restrictionAddress/formattedMultiLineAddress| *None* |Request - Search address - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/url/URLAddress|string|Request - URL| x |
|ticket/contact/url/URLDescription|string|Request - Description| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/contact/contactAssociate/firstName|string|Request - First name: Displays the contact's first name| x |
|ticket/contact/contactAssociate/lastName|string|Request - Last name: Displays the contact's last name| x |
|ticket/contact/contactAssociate/middleName|string|Request - Middle Name: Displays the contact's middle name.| x |
|ticket/contact/contactAssociate/fullName|string|Request - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ticket/contact/contactAssociate/contactId|int|Request - Company ID: Database ID of the company the user belongs to|  |
|ticket/contact/contactAssociate/personId|int|Request - Contact ID: Database ID of the contact row|  |
|ticket/contact/contactAssociate/mrMrs|string|Request - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/contact/contactAssociate/title|string|Request - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/contact/contactAssociate/associateDbId|associate|Request - ID| x |
|ticket/contact/contactAssociate/contactName|string|Request - Owning company: Name of the company the user belongs to| x |
|ticket/contact/contactAssociate/contactDepartment|string|Request - Owning department: Name of the department at the company the user belongs to| x |
|ticket/contact/contactAssociate/usergroup|userGroup|Request - Primary group: The user's primary user group| x |
|ticket/contact/contactAssociate/contactFullName|string|Request - Owner: Name and department of the company the user belongs to| x |
|ticket/contact/contactAssociate/contactCategory|listAny|Request - Category: Category| x |
|ticket/contact/contactAssociate/role|listAny|Request - Role: Role| x |
|ticket/contact/contactAssociate/assocName|associate|Request - User ID: User ID| x |
|ticket/contact/contactAssociate/assocTooltip|string|Request - Description: Description|  |
|ticket/contact/contactAssociate/assocType|listAny|Request - Type: Type of user: associate, external user, system user, anonymous account| x |
|ticket/contact/contactAssociate/ejUserId|int|Request - Service user ID: The database ID of a Service user|  |
|ticket/contact/contactAssociate/simultaneousEjUser|bool|Request - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ticket/contact/contactAssociate/ejDisplayName|string|Request - Nick name: User's nick name in Service| x |
|ticket/contact/contactAssociate/ejStatus|int|Request - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ticket/contact/contactAssociate/credentialType| *None* |Request - Auth. type: What type of credentials to use when this user logs in| x |
|ticket/contact/contactAssociate/credentialDisplayValue| *None* |Request - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ticket/contact/contactAssociate/isActive|bool|Request - Active: Is this user active, and should be able to log in?| x |
|ticket/contact/contactAssociate/isActiveText|bool|Request - Active status: Is this user active, and should be able to log in?| x |
|ticket/contact/contactAssociate/portraitThumbnail| *None* |Request - Person image: Person image|  |
|ticket/contact/contactAssociate/otherGroups|userGroup|Request - Other groups: Other groups|  |
|ticket/contact/contactAssociate/userName|string|Request - User name: User name| x |
|ticket/contact/contactAssociate/personEmail|string|Request - E-mail| x |
|ticket/contact/contactInterestIds|listInterest|Request - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|ticket/contact/contactUdef/SuperOffice:1|string|Request - companyshorttext: tooltipshorttext| x |
|ticket/contact/contactUdef/SuperOffice:2|string|Request - companylongtext: tooltiplongtext| x |
|ticket/contact/contactUdef/SuperOffice:3|int|Request - companynumber| x |
|ticket/contact/contactUdef/SuperOffice:4|date|Request - companydate| x |
|ticket/contact/contactUdef/SuperOffice:5|unlimitedDate|Request - companyunlimiteddate: tooltipunlimiteddate| x |
|ticket/contact/contactUdef/SuperOffice:6|bool|Request - companycheckbox| x |
|ticket/contact/contactUdef/SuperOffice:7|listAny|Request - companydropdownlistbox| x |
|ticket/contact/contactUdef/SuperOffice:8|decimal|Request - companydecimal| x |
|ticket/contact/contactUdef/SuperOffice:9|string|Request - page1saleonly| x |
|ticket/contact/contactUdef/SuperOffice:10|string|Request - page1marketingonly| x |
|ticket/contact/contactUdef/SuperOffice:11|string|Request - page1adminonly| x |
|ticket/contact/contactUdef/SuperOffice:12|listAny|Request - Udlist one: Static tooltip for udlist one| x |
|ticket/contact/contactUdef/SuperOffice:13|listAny|Request - Udlist two: Static tooltip for udlist two| x |
|ticket/contact/contactExtra/x\_contact\_integer|int|Request - Extra Integer: Custom integer field| x |
|ticket/contact/contactExtra/x\_contact\_hidden\_integer|int|Request - Extra hidden integer: Custom integer field - hidden| x |
|ticket/contact/contactExtra/x\_contact\_default\_integer|int|Request - Extra Default Integer: Custom integer field with default value 123.| x |
|ticket/contact/contactExtra/x\_contact\_float|decimal|Request - Extra Float: Custom float field with 3 decimals| x |
|ticket/contact/contactExtra/x\_contact\_longtext|string|Request - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|ticket/contact/contactExtra/x\_contact\_dropdown|listAny|Request - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|ticket/contact/contactExtra/x\_contact\_date|date|Request - Extra date: Custom date field. User current as default.| x |
|ticket/contact/contactExtra/x\_contact\_datetime|datetime|Request - Extra DateTime: Custom Date Time field. No default value. External| x |
|ticket/contact/contactExtra/x\_contact\_time| *None* |Request - Extra time: Custom time field.| x |
|ticket/contact/contactExtra/x\_contact\_boolean|bool|Request - Extra boolean: Custom boolean field.| x |
|ticket/contact/contactExtra/x\_contact\_timespan|timeSpan|Request - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|ticket/contact/contactExtra/x\_contact\_shorttext|string|Request - Extra short text: Custom short text field. Keep HTML tags.| x |
|ticket/contact/contactExtra/x\_contact\_short\_dropdown|listAny|Request - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|ticket/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Request - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|ticket/contact/contactExtra/x\_contact\_request\_relation|stringorPK|Request - Extra Request relation: Request relation on company| x |
|ticket/contact/contactExtra/x\_contact\_contact|stringorPK|Request - Extra contact relation: Contact relation on company| x |
|ticket/contact/NumberOfActivities|int|Request - Number of activities|  |
|ticket/contact/NumberOfActivitiesInPeriod|int|Request - Number of activities in last 90 days|  |
|ticket/contact/NumberOfNotCompletedActivities|int|Request - Number of non-completed activities|  |
|ticket/contact/NumberOfNotCompletedActivitiesInPeriod|int|Request - Number of non-completed activities in last 90 days|  |
|ticket/contact/LastActivity|date|Request - Date of last activity|  |
|ticket/contact/LastCompletedActivity|date|Request - Date of last completed activity|  |
|ticket/contact/LastDoByActivity|date|Request - Date of last non-completed activity|  |
|ticket/contact/NumberOfSales|int|Request - Number of sales|  |
|ticket/contact/NumberOfSalesInPeriod|int|Request - Number of sales in last 90 days|  |
|ticket/contact/NumberOfNotCompletedSales|int|Request - Number of non-completed sales|  |
|ticket/contact/NumberOfNotCompletedSalesInPeriod|int|Request - Number of non-completed sales in last 90 days|  |
|ticket/contact/LastSale|date|Request - Date of last sale|  |
|ticket/contact/LastCompletedSale|date|Request - Date of last completed sale|  |
|ticket/contact/LastDoBySale|date|Request - Date of last non-completed sale|  |
|ticket/contact/NumberOfTickets|int|Request - Number of requests|  |
|ticket/contact/NumberOfTicketsInPeriod|int|Request - Number of requests in last 90 days|  |
|ticket/contact/NumberOfNotCompletedTickets|int|Request - Number of non-completed requests|  |
|ticket/contact/NumberOfNotCompletedTicketsInPeriod|int|Request - Number of non-completed requests in last 90 days|  |
|ticket/contact/LastTicket|date|Request - Date of last request|  |
|ticket/contact/LastCompletedTicket|date|Request - Date of last completed request|  |
|ticket/contact/LastDoByTicket|date|Request - Date of last non-completed request|  |
|ticket/contact/SaintStatus1|saintStatus|Request - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|ticket/contact/SaintStatus2|saintStatus|Request - C-company: Kundens navn starter med bokstaven C|  |
|ticket/contact/saintSaleStatus|listAny|Request - With status|  |
|ticket/contact/saintAmountClass|listAny|Request - Amount class|  |
|ticket/contact/saintActivityType|listAny|Request - SAINT type|  |
|ticket/contact/saintDirection|listAny|Request - Direction|  |
|ticket/contact/saintIntention|listAny|Request - Intention|  |
|ticket/contact/saintTicketStatus|listAny|Request - Status|  |
|ticket/contact/saintTicketCategory|listAny|Request - Category|  |
|ticket/extra/x\_ticket\_integer|int|Request - Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|ticket/extra/x\_ticket\_float|decimal|Request - Extra float: Custom float on Request. 2 decimal places| x |
|ticket/extra/x\_ticket\_longtext|string|Request - Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|ticket/extra/x\_ticket\_date|date|Request - Extra date: Custom date field on Request. No default value| x |
|ticket/extra/x\_ticket\_datetime|datetime|Request - Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|ticket/extra/x\_ticket\_time| *None* |Request - Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|ticket/extra/x\_ticket\_boolean|bool|Request - Extra boolean: Custom boolean on Ticket.| x |
|ticket/extra/x\_ticket\_timespan|timeSpan|Request - Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|ticket/extra/x\_ticket\_short\_text|string|Request - Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|ticket/extra/x\_ticket\_shorttext\_list|listAny|Request - Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/extra/x\_ticket\_timestamp|datetime|Request - Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|ticket/extra/x\_ticket\_project\_relation|stringorPK|Request - Extra project: Custom project relation on Request| x |
|ticket/extra/x\_ticket\_faq|stringorPK|Request - Extra FAQ Relation| x |
|ticket/extra/x\_ticket\_category\_relation|listAny|Request - Extra category relation: Category relation on request| x |
|ticket/extra/y\_equipment/x\_name|string|Request - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|ticket/sale/completed|bool|Request - Completed: Displays a checkbox showing if an appointment is completed| x |
|ticket/sale/icon|listAny|Request - Category: Displays the icon for an activity type| x |
|ticket/sale/date|date|Request - Date: Displays start date of a follow-up / sale date of a sale| x |
|ticket/sale/time| *None* |Request - Time: Time|  |
|ticket/sale/type|listAny|Request - Type: Displays the type of an activity| x |
|ticket/sale/recordType|string|Request - Record type: Shows the record type| x |
|ticket/sale/text|positiveString|Request - Text: Displays a descriptive text for the item| x |
|ticket/sale/associateId|associate|Request - ID: Displays the login ID of the associate who owns the activity.| x |
|ticket/sale/contactId|listAny|Request - Company ID: Database ID of company| x |
|ticket/sale/personId|listAny|Request - Contact ID: Database ID of the contact row| x |
|ticket/sale/projectId|listAny|Request - Project ID: Database ID of project record| x |
|ticket/sale/saleId|int|Request - Sale ID: The database ID of the sale record| x |
|ticket/sale/userGroup|userGroup|Request - User group: The user group that owns the record| x |
|ticket/sale/who| *None* |Request - Who: Contact and/or company|  |
|ticket/sale/updatedBy|associate|Request - Updated by: The user who last updated the data| x |
|ticket/sale/updatedByFullName|associate|Request - Updated by - Full name: The user who last updated the data| x |
|ticket/sale/updatedDate|date|Request - Updated: The date/time the data was last updated in UTC.| x |
|ticket/sale/registeredBy|associate|Request - Registered by: The user who registered the data| x |
|ticket/sale/registeredByFullName|associate|Request - Registered by - Full name: The user who registered the data| x |
|ticket/sale/registeredDate|date|Request - Registered date: The date/time the data was registered in UTC.| x |
|ticket/sale/currencyId|int|Request - Currency ID: The currency list item ID| x |
|ticket/sale/currency|listAny|Request - Currency: The currency of the sale| x |
|ticket/sale/credited|listAny|Request - Credited: The user to be credited with the sale| x |
|ticket/sale/lossReason|listAny|Request - Reason (lost): The reason for losing the sale| x |
|ticket/sale/source|listAny|Request - Source: The source (lead) of the sale| x |
|ticket/sale/competitor|listAny|Request - Competitor: The competitor who won the sale| x |
|ticket/sale/heading|stringorPK|Request - Sale: The name of the sale| x |
|ticket/sale/amount|decimal|Request - Amount: The gross sales total| x |
|ticket/sale/amountWeighted|decimal|Request - Weighted amount: Virtual field calculated from amount * probability percent.| x |
|ticket/sale/earning|decimal|Request - Profit: Gross profit (gross sales total - cost) for the sale| x |
|ticket/sale/earningPercent|decimal|Request - Profit as %: The profit as a percentage of the gross sales total| x |
|ticket/sale/probPercent|int|Request - Probability as %: Probability as %| x |
|ticket/sale/originalStage|listAny|Request - Stage: Displays the stage of the sale| x |
|ticket/sale/stage|listAny|Request - Stage: Displays the stage of the sale| x |
|ticket/sale/saleStatus|listAny|Request - Status: The status of the sale - open, lost or sold| x |
|ticket/sale/stageRank| *None* |Request - Stage rank: Rank of the sale stage in the stage list| x |
|ticket/sale/saleType|listAny|Request - Sale type: Sale type, from list| x |
|ticket/sale/nextDueDate|date|Request - Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|ticket/sale/reopenDate|date|Request - Reopen date: Displays the reopen date for the sale| x |
|ticket/sale/stalledComment|listAny|Request - Reason (stalled): The reason the sale has been stalled| x |
|ticket/sale/saleTypeCategory|listAny|Request - Sale type category: Sale type category| x |
|ticket/sale/soldReason|listAny|Request - Reason (sold): Reason (sold)| x |
|ticket/sale/saleNumber|string|Request - Number: Number| x |
|ticket/sale/hasStakeholders|bool|Request - Has stakeholders: Does this sale have stakeholders enabled| x |
|ticket/sale/hasQuote|bool|Request - Has quote?: Does the sale have a quote attached?| x |
|ticket/sale/hasGuide|bool|Request - Guided: Does this sale have a Sales Guide| x |
|ticket/sale/description|string|Request - Description: The long description field on Sale|  |
|ticket/sale/activeErpLinks|bool|Request - ERP connected: Is there an active ERP Sync?| x |
|ticket/sale/visibleFor|listAny|Request - Visible for|  |
|ticket/sale/sale/textId|int|Request - Text ID| x |
|ticket/sale/sale/description|positiveString|Request - Text: Displays the text entered in the description field| x |
|ticket/sale/salePublish/isPublished|bool|Request - Published: Displays an icon indicating if the project or sale has been published| x |
|ticket/sale/salePublish/publishedFrom|date|Request - From date: Start date for publishing. The record will not be visible prior to this date| x |
|ticket/sale/salePublish/publishedTo|date|Request - To date: End date for publishing. The record will not be visible after this date| x |
|ticket/sale/salePublish/publishedBy| *None* |Request - Published by: Published by|  |
|ticket/sale/associate/firstName|string|Request - First name: Displays the contact's first name| x |
|ticket/sale/associate/lastName|string|Request - Last name: Displays the contact's last name| x |
|ticket/sale/associate/middleName|string|Request - Middle Name: Displays the contact's middle name.| x |
|ticket/sale/associate/fullName|string|Request - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ticket/sale/associate/contactId|int|Request - Company ID: Database ID of the company the user belongs to|  |
|ticket/sale/associate/personId|int|Request - Contact ID: Database ID of the contact row|  |
|ticket/sale/associate/mrMrs|string|Request - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/sale/associate/title|string|Request - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/sale/associate/associateDbId|associate|Request - ID| x |
|ticket/sale/associate/contactName|string|Request - Owning company: Name of the company the user belongs to| x |
|ticket/sale/associate/contactDepartment|string|Request - Owning department: Name of the department at the company the user belongs to| x |
|ticket/sale/associate/usergroup|userGroup|Request - Primary group: The user's primary user group| x |
|ticket/sale/associate/contactFullName|string|Request - Owner: Name and department of the company the user belongs to| x |
|ticket/sale/associate/contactCategory|listAny|Request - Category: Category| x |
|ticket/sale/associate/role|listAny|Request - Role: Role| x |
|ticket/sale/associate/assocName|associate|Request - User ID: User ID| x |
|ticket/sale/associate/assocTooltip|string|Request - Description: Description|  |
|ticket/sale/associate/assocType|listAny|Request - Type: Type of user: associate, external user, system user, anonymous account| x |
|ticket/sale/associate/ejUserId|int|Request - Service user ID: The database ID of a Service user|  |
|ticket/sale/associate/simultaneousEjUser|bool|Request - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ticket/sale/associate/ejDisplayName|string|Request - Nick name: User's nick name in Service| x |
|ticket/sale/associate/ejStatus|int|Request - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ticket/sale/associate/credentialType| *None* |Request - Auth. type: What type of credentials to use when this user logs in| x |
|ticket/sale/associate/credentialDisplayValue| *None* |Request - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ticket/sale/associate/isActive|bool|Request - Active: Is this user active, and should be able to log in?| x |
|ticket/sale/associate/isActiveText|bool|Request - Active status: Is this user active, and should be able to log in?| x |
|ticket/sale/associate/portraitThumbnail| *None* |Request - Person image: Person image|  |
|ticket/sale/associate/otherGroups|userGroup|Request - Other groups: Other groups|  |
|ticket/sale/associate/userName|string|Request - User name: User name| x |
|ticket/sale/associate/personEmail|string|Request - E-mail| x |
|ticket/sale/saleUdef/SuperOffice:1|string|Request - saleshorttext| x |
|ticket/sale/saleUdef/SuperOffice:2|string|Request - salelongtext| x |
|ticket/sale/saleUdef/SuperOffice:3|int|Request - salenumber| x |
|ticket/sale/saleUdef/SuperOffice:4|date|Request - saledate| x |
|ticket/sale/saleUdef/SuperOffice:5|unlimitedDate|Request - saleunlimiteddate| x |
|ticket/sale/saleUdef/SuperOffice:6|bool|Request - salecheckbox| x |
|ticket/sale/saleUdef/SuperOffice:7|listAny|Request - saledropdownlistbox| x |
|ticket/sale/saleUdef/SuperOffice:8|decimal|Request - saledecimal| x |
|ticket/project/completed|bool|Request - Completed: Displays a check mark indicating if the project has been completed.| x |
|ticket/project/projectId|int|Request - DB ID: Displays the database ID for a project row| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/project/name|stringorPK|Request - Project name: Displays the Project's name| x |
|ticket/project/number|string|Request - Number: Displays the project's number| x |
|ticket/project/type|listAny|Request - Project type: Displays the project's type| x |
|ticket/project/status|listAny|Request - Status: Displays the project's status| x |
|ticket/project/statusRank| *None* |Request - Status rank: Rank of the project status in the status list| x |
|ticket/project/associateId|associate|Request - ID: Displays login ID of the associate who owns the project| x |
|ticket/project/hasInfoText|bool|Request - Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|ticket/project/icon| *None* |Request - Category: Displays the icon for an activity type| x |
|ticket/project/text|string|Request - Text: Displays a descriptive text for the item| x |
|ticket/project/description|string|Request - Description: Description| x |
|ticket/project/updatedBy|associate|Request - Updated by: The user who last updated the data| x |
|ticket/project/updatedByFullName|associate|Request - Updated by - Full name: The user who last updated the data| x |
|ticket/project/updatedDate|date|Request - Updated: The date/time the data was last updated in UTC.| x |
|ticket/project/registeredBy|associate|Request - Registered by: The user who registered the data| x |
|ticket/project/registeredByFullName|associate|Request - Registered by - Full name: The user who registered the data| x |
|ticket/project/registeredDate|date|Request - Registered date: The date/time the data was registered in UTC.| x |
|ticket/project/hasGuide|bool|Request - Guided: Does this sale have a Sales Guide| x |
|ticket/project/nextMilestone|date|Request - Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|ticket/project/endDate|date|Request - End date: End date of project| x |
|ticket/project/imageThumbnail| *None* |Request - Thumbnail: Scaled-down image of project image|  |
|ticket/project/activeErpLinks|bool|Request - ERP connected: Is there an active ERP Sync?| x |
|ticket/project/projectPublish/isPublished|bool|Request - Published: Displays an icon indicating if the project or sale has been published| x |
|ticket/project/projectPublish/publishedFrom|date|Request - From date: Start date for publishing. The record will not be visible prior to this date| x |
|ticket/project/projectPublish/publishedTo|date|Request - To date: End date for publishing. The record will not be visible after this date| x |
|ticket/project/projectPublish/publishedBy| *None* |Request - Published by: Published by|  |
|ticket/project/projectEvent/isExternalEvent|bool|Request - Event: Is this an external event| x |
|ticket/project/projectEvent/eventDate|date|Request - Event date: Event date| x |
|ticket/project/projectEvent/hasSignOn|bool|Request - Sign On: Does this event have the Sign On function enabled| x |
|ticket/project/projectEvent/hasSignOff|bool|Request - Sign Off: Does this event have the Sign Off function enabled| x |
|ticket/project/projectUrl/URLAddress|string|Request - URL| x |
|ticket/project/projectUrl/URLDescription|string|Request - Description| x |
|ticket/project/projectAssociate/firstName|string|Request - First name: Displays the contact's first name| x |
|ticket/project/projectAssociate/lastName|string|Request - Last name: Displays the contact's last name| x |
|ticket/project/projectAssociate/middleName|string|Request - Middle Name: Displays the contact's middle name.| x |
|ticket/project/projectAssociate/fullName|string|Request - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ticket/project/projectAssociate/contactId|int|Request - Company ID: Database ID of the company the user belongs to|  |
|ticket/project/projectAssociate/personId|int|Request - Contact ID: Database ID of the contact row|  |
|ticket/project/projectAssociate/mrMrs|string|Request - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/project/projectAssociate/title|string|Request - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ticket/project/projectAssociate/associateDbId|associate|Request - ID| x |
|ticket/project/projectAssociate/contactName|string|Request - Owning company: Name of the company the user belongs to| x |
|ticket/project/projectAssociate/contactDepartment|string|Request - Owning department: Name of the department at the company the user belongs to| x |
|ticket/project/projectAssociate/usergroup|userGroup|Request - Primary group: The user's primary user group| x |
|ticket/project/projectAssociate/contactFullName|string|Request - Owner: Name and department of the company the user belongs to| x |
|ticket/project/projectAssociate/contactCategory|listAny|Request - Category: Category| x |
|ticket/project/projectAssociate/role|listAny|Request - Role: Role| x |
|ticket/project/projectAssociate/assocName|associate|Request - User ID: User ID| x |
|ticket/project/projectAssociate/assocTooltip|string|Request - Description: Description|  |
|ticket/project/projectAssociate/assocType|listAny|Request - Type: Type of user: associate, external user, system user, anonymous account| x |
|ticket/project/projectAssociate/ejUserId|int|Request - Service user ID: The database ID of a Service user|  |
|ticket/project/projectAssociate/simultaneousEjUser|bool|Request - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ticket/project/projectAssociate/ejDisplayName|string|Request - Nick name: User's nick name in Service| x |
|ticket/project/projectAssociate/ejStatus|int|Request - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ticket/project/projectAssociate/credentialType| *None* |Request - Auth. type: What type of credentials to use when this user logs in| x |
|ticket/project/projectAssociate/credentialDisplayValue| *None* |Request - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ticket/project/projectAssociate/isActive|bool|Request - Active: Is this user active, and should be able to log in?| x |
|ticket/project/projectAssociate/isActiveText|bool|Request - Active status: Is this user active, and should be able to log in?| x |
|ticket/project/projectAssociate/portraitThumbnail| *None* |Request - Person image: Person image|  |
|ticket/project/projectAssociate/otherGroups|userGroup|Request - Other groups: Other groups|  |
|ticket/project/projectAssociate/userName|string|Request - User name: User name| x |
|ticket/project/projectAssociate/personEmail|string|Request - E-mail| x |
|ticket/project/projectUdef/SuperOffice:1|string|Request - projectshorttext| x |
|ticket/project/projectUdef/SuperOffice:2|string|Request - projectlongtext| x |
|ticket/project/projectUdef/SuperOffice:3|int|Request - projectnumber| x |
|ticket/project/projectUdef/SuperOffice:4|date|Request - projectdate| x |
|ticket/project/projectUdef/SuperOffice:5|unlimitedDate|Request - projectunlimiteddate| x |
|ticket/project/projectUdef/SuperOffice:6|bool|Request - projectcheckbox| x |
|ticket/project/projectUdef/SuperOffice:7|listAny|Request - projectdropdownlistbox| x |
|ticket/project/projectUdef/SuperOffice:8|decimal|Request - projectdecimal| x |
|ticket/project/projectUdef/SuperOffice:9|int|Request - page1saleandmarketing| x |
|ticket/project/projectUdef/SuperOffice:10|int|Request - page1saleandadmin| x |
|ticket/project/NumberOfActivities|int|Request - Number of activities|  |
|ticket/project/NumberOfActivitiesInPeriod|int|Request - Number of activities in last 90 days|  |
|ticket/project/NumberOfNotCompletedActivities|int|Request - Number of non-completed activities|  |
|ticket/project/NumberOfNotCompletedActivitiesInPeriod|int|Request - Number of non-completed activities in last 90 days|  |
|ticket/project/LastActivity|date|Request - Date of last activity|  |
|ticket/project/LastCompletedActivity|date|Request - Date of last completed activity|  |
|ticket/project/LastDoByActivity|date|Request - Date of last non-completed activity|  |
|ticket/project/NumberOfSales|int|Request - Number of sales|  |
|ticket/project/NumberOfSalesInPeriod|int|Request - Number of sales in last 90 days|  |
|ticket/project/NumberOfNotCompletedSales|int|Request - Number of non-completed sales|  |
|ticket/project/NumberOfNotCompletedSalesInPeriod|int|Request - Number of non-completed sales in last 90 days|  |
|ticket/project/LastSale|date|Request - Date of last sale|  |
|ticket/project/LastCompletedSale|date|Request - Date of last completed sale|  |
|ticket/project/LastDoBySale|date|Request - Date of last non-completed sale|  |
|ticket/project/SaintStatus3|saintStatus|Request - Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|ticket/project/saintSaleStatus|listAny|Request - With status|  |
|ticket/project/saintAmountClass|listAny|Request - Amount class|  |
|ticket/project/saintActivityType|listAny|Request - SAINT type|  |
|ticket/project/saintDirection|listAny|Request - Direction|  |
|ticket/project/saintIntention|listAny|Request - Intention|  |
|ticket/project/saintTicketStatus|listAny|Request - Status|  |
|ticket/project/saintTicketCategory|listAny|Request - Category|  |
|ticket/project/project/textId|int|Request - Text ID| x |
|ticket/project/project/infoText|positiveString|Request - Information: Displays the text entered in the description field| x |
|person/personId|int|Contact - DB ID: Displays the database ID of a contact| x |
|person/firstName|string|Contact - First name: Displays the contact's first name| x |
|person/lastName|string|Contact - Last name: Displays the contact's last name| x |
|person/middleName|string|Contact - Middle name: Displays the contact's middle name.| x |
|person/fullName|stringorPK|Contact - Contact: Displays the contact to which an item is linked| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/contactId|int|Contact - Company ID: Database ID of company| x |
|person/hasInfoText|bool|Contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|person/hasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/personHasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/position|listAny|Contact - Position| x |
|person/personNumber|string|Contact - Number: Displays the contact's number| x |
|person/title|string|Contact - Title: Displays the contact's job title| x |
|person/personCountry|listAny|Contact - Country: Country| x |
|person/personCountryId|int|Contact - Country ID: Country ID| x |
|person/personNoMail|bool|Contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|person/rank|int|Contact - Rank: Displays a contact's current rank| x |
|person/birthdate| *None* |Contact - Birthdate: Displays the contact's date of birth|  |
|person/associateType| *None* |Contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|person/useAsMailingAddress|bool|Contact - Use as postal address: Use as postal address| x |
|person/personSource|listAny|Contact - Source: Source (Contact)| x |
|person/retired|bool|Contact - Former employee: Indicates whether the contact has retired/left the company| x |
|person/birthYear|int|Contact - Birth year: Displays contact's birth year| x |
|person/birthMonth|int|Contact - Birth month: Displays contact's birth month| x |
|person/birthDay|int|Contact - Birth day: Displays contact's birth day (day of month)| x |
|person/kanaFirstName|string|Contact - First name, kana: Contact's first name, in kana alphabet| x |
|person/kanaLastName|string|Contact - Last name, kana: Contact's last name, in kana alphabet| x |
|person/personUpdatedBy|associate|Contact - Updated by: The user who last updated the data| x |
|person/personUpdatedByFullName|associate|Contact - Updated by - Full name: The user who last updated the data| x |
|person/personUpdatedDate|date|Contact - Updated: The date/time the data was last updated in UTC.| x |
|person/personRegisteredBy|associate|Contact - Registered by: The user who registered the data| x |
|person/personRegisteredByFullName|associate|Contact - Registered by - Full name: The user who registered the data| x |
|person/personRegisteredDate|date|Contact - Registered date: The date/time the data was registered in UTC.| x |
|person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|person/personActiveErpLinks|bool|Contact - ERP connected: Is there an active ERP Sync?| x |
|person/ticketPriority|listAny|Contact - Service priority: Default service priority for this contact| x |
|person/supportLanguage|listAny|Contact - Preferred language: Preferred language used for reply templates and more| x |
|person/supportAssociate|associate|Contact - Our service contact: Default service contact for this contact| x |
|person/supportAssociateFullName|associate|Contact - Our service contact - Full name: Default service contact for this contact| x |
|person/personAssociateId|associate|Contact - Our contact: Displays our contact| x |
|person/personAssociateFullName|associate|Contact - Our contact - Full name: Displays our contact| x |
|person/personCategory|listAny|Contact - Category| x |
|person/personBusiness|listAny|Contact - Business| x |
|person/personDeletedDate|datetime|Contact - Deleted date: Deleted date|  |
|person/hasCompany|bool|Contact - Has company: The contact is associated with a company| x |
|person/isProjectMember|bool|Contact - Is project member: This person is a project member| x |
|person/isStakeholder|bool|Contact - Is stakeholder: This person is a sale stakeholder| x |
|ticketMessageExtra/x\_message\_integer|int|Extra integer: Custom integer on message. Hidden. Default 123| x |
|ticketMessageExtra/x\_message\_float|decimal|Extra float: Custom float on message. Hidden| x |
|ticketMessageExtra/x\_message\_longtext|string|Extra long text: Custom long text on Message. Hidden, do not keep HTML| x |
|ticketMessageExtra/x\_message\_date|date|Extra date: Custom date field on message. Hidden.| x |
|ticketMessageExtra/x\_message\_datetime|datetime|Extra DateTime: Custom datetime on message. Hidden. Use current as default| x |
|ticketMessageExtra/x\_message\_time| *None* |Extra Time: Custom time field on message. Hidden| x |
|ticketMessageExtra/x\_message\_boolean|bool|Extra Boolean: Custom boolean field on message. Hidden| x |
|ticketMessageExtra/x\_message\_timespan|timeSpan|Extra timespan: Custom timespan field on message. Hidden| x |
|ticketMessageExtra/x\_message\_short\_text|string|Extra short text: Custom short text field. Hidden.| x |
|ticketMessageExtra/x\_message\_sale\_relation|stringorPK|Extra sale relation: Custom sale relation field. Hidden| x |

## Sample

```http!
GET /api/v1/archive/TicketMessage?$select=ticket/contact/searchPhone/description,ticket/contact/streetAddress/addressId,ticket/extra/x_ticket_short_text,ticket/sale/projectId,ticket/sale/competitor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

