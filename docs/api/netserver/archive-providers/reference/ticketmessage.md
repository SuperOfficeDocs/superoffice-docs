---
uid: TicketMessage
title: TicketMessage
description: Messages on support tickets. Messages are typically e-mail messages with attachments, but not always.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "TicketMessage"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
|ticket/ticketStatusName|listAny|Request - Status: Request status| x |
|ticket/categoryFullName|listAny|Request - Category: Request category| x |
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
|ticket/person/personUpdatedDate|date|Request - Updated: The date/time the data was last updated in UTC.| x |
|ticket/person/personRegisteredBy|associate|Request - Registered by: The user who registered the data| x |
|ticket/person/personRegisteredDate|date|Request - Registered date: The date/time the data was registered in UTC.| x |
|ticket/person/portraitThumbnail| *None* |Request - Person image: Person image|  |
|ticket/person/personActiveErpLinks|bool|Request - ERP connected: Is there an active ERP Sync?| x |
|ticket/person/ticketPriority|listAny|Request - Service priority: Default service priority for this contact| x |
|ticket/person/supportLanguage|listAny|Request - Preferred language: Preferred language used for reply templates and more| x |
|ticket/person/supportAssociate|associate|Request - Our service contact: Default service contact for this contact| x |
|ticket/person/personAssociateId|associate|Request - Our contact: Displays our contact| x |
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
|ticket/person/isMailingRecipient|bool|Request - isMailingRecipient: isMailingRecipient| x |
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
|ticket/contact/number|string|Request - Number| x |
|ticket/contact/code|string|Request - Code| x |
|ticket/contact/orgnr|string|Request - VAT No.| x |
|ticket/contact/stop|bool|Request - Stop| x |
|ticket/contact/contactNoMail|bool|Request - No mailings (company)| x |
|ticket/contact/updatedBy|associate|Request - Updated by: The user who last updated the data| x |
|ticket/contact/updatedDate|date|Request - Updated: The date/time the data was last updated in UTC.| x |
|ticket/contact/registeredBy|associate|Request - Registered by: The user who registered the data| x |
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
|ticket/contact/SaintStatus1|saintStatus|Request - Neglected customer|  |
|ticket/contact/SaintStatus2|saintStatus|Request - C-company|  |
|ticket/contact/saintSaleStatus|listAny|Request - With status|  |
|ticket/contact/saintAmountClass|listAny|Request - Amount class|  |
|ticket/contact/saintActivityType|listAny|Request - SAINT type|  |
|ticket/contact/saintDirection|listAny|Request - Direction|  |
|ticket/contact/saintIntention|listAny|Request - Intention|  |
|ticket/contact/saintTicketStatus|listAny|Request - Status|  |
|ticket/contact/saintTicketCategory|listAny|Request - Category|  |
|person/personId|int|Contact - DB ID: Displays the database ID of a contact| x |
|person/firstName|string|Contact - First name: Displays the contact's first name| x |
|person/lastName|string|Contact - Last name: Displays the contact's last name| x |
|person/middleName|string|Contact - Middle name: Displays the contact's middle name.| x |
|person/fullName|stringorPK|Contact - Contact: Displays the contact to which an item is linked| x |
|person/contactId|int|Contact - Company ID: Database ID of company| x |
|person/hasInfoText|bool|Contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|person/hasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/personHasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/position|listAny|Contact - Position| x |
|person/personNumber|string|Contact - Number: Displays the contact's number| x |
|person/title|string|Contact - Title: Displays the contact's job title| x |
|person/personCountry|listAny|Contact - Country: Country| x |
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
|person/personUpdatedDate|date|Contact - Updated: The date/time the data was last updated in UTC.| x |
|person/personRegisteredBy|associate|Contact - Registered by: The user who registered the data| x |
|person/personRegisteredDate|date|Contact - Registered date: The date/time the data was registered in UTC.| x |
|person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|person/personActiveErpLinks|bool|Contact - ERP connected: Is there an active ERP Sync?| x |
|person/ticketPriority|listAny|Contact - Service priority: Default service priority for this contact| x |
|person/supportLanguage|listAny|Contact - Preferred language: Preferred language used for reply templates and more| x |
|person/supportAssociate|associate|Contact - Our service contact: Default service contact for this contact| x |
|person/personAssociateId|associate|Contact - Our contact: Displays our contact| x |
|person/personCategory|listAny|Contact - Category| x |
|person/personBusiness|listAny|Contact - Business| x |
|person/personDeletedDate|datetime|Contact - Deleted date: Deleted date|  |
|person/hasCompany|bool|Contact - Has company: The contact is associated with a company| x |
|person/isProjectMember|bool|Contact - Is project member: This person is a project member| x |
|person/isStakeholder|bool|Contact - Is stakeholder: This person is a sale stakeholder| x |

## Sample

```http!
GET /api/v1/archive/TicketMessage?$select=ticket/contact/restrictionAddress/zip,ticket/contact/NumberOfActivities,ticket/person/personUpdatedDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

