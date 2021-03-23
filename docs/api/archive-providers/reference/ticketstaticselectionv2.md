---
uid: TicketStaticSelectionV2
title: TicketStaticSelectionV2
description: Static archive Provider for a Selection of tickets archive.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "TicketStaticSelectionV2"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "TicketStaticSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.TicketSelectionStaticProviderV2">SuperOffice.CRM.ArchiveLists.Archive.TicketSelectionStaticProviderV2</see> inside NetServer's SODatabase assembly.

Static archive Provider for a Selection of tickets archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticket"|Request|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|contactId|int|Company ID: Database ID of company| x |
|personId|int|Contact ID: Database ID of the contact row| x |
|ticketStatusName|listAny|Status: Request status| x |
|categoryFullName|listAny|Category: Request category| x |
|priorityName|listAny|Priority: Service priority| x |
|ticketId|int|ID: Displays request ID| x |
|title|string|Title: Displays the request title| x |
|createdAt|datetime|Created: Displays when the request was created| x |
|lastChanged|datetime|Last changed: Displays when the request was last changed| x |
|author|string|Author: Displays the author of the request| x |
|readByOwner|datetime|Read by owner: Displays when the request was read by the owner| x |
|firstReadByOwner|datetime|First read by owner: Displays when the request was read by owner for the first time| x |
|firstReadByUser|datetime|First read by user: Displays when the request was read by user for the first time| x |
|readByCustomer|datetime|Read by contact: Displays when the request was read by the contact| x |
|status|listAny|Internal status: Shows only system defined statuses for a request| x |
|origin|listAny|Origin: Origin| x |
|slevel|listAny|Access level: Access level| x |
|numberOfMessages|int|Number of messages: Number of messages| x |
|numberOfReplies|int|Number of replies: Number of replies| x |
|connectId|int|Merged with request: Merged with request| x |
|readStatus|listAny|Read: Read| x |
|realTimeSpentQueue|timeSpan|Real time in queue: Real time in queue| x |
|realTimeSpentExternally|timeSpan|Real time externally: Real time externally| x |
|realTimeSpentInternally|timeSpan|Real time internally: Real time internally| x |
|timeSpentQueue|timeSpan|Time spent in queue: Time spent in queue| x |
|timeSpentExternally|timeSpan|Time spent externally: Time spent externally| x |
|timeSpentInternally|timeSpan|Time spent internally: Time spent internally| x |
|timeToReply|timeSpan|Time to reply: Time to reply| x |
|timeToClose|timeSpan|Time to close: Time to close| x |
|realTimeToReply|timeSpan|Real time to reply: Real time to reply| x |
|realTimeToClose|timeSpan|Real time to close: Real time to close| x |
|repliedAt|datetime|Replied at: Replied at| x |
|closedAt|datetime|Closed at: Closed at| x |
|activated|datetime|Postponed to: Postponed to| x |
|deadline|datetime|Deadline: Deadline| x |
|has\_attachment|bool|Has attachment: Indicates whether the e-mail has one or more attachments| x |
|tags|intArray|Tags: Tags connected to a request| x |
|ownedBy|ejUser|Owner: The owner of the request| x |
|content|string|Content: Search for content in messages related to requests| x |
|createdBy/firstName|string|Created by - First name: Displays the contact's first name| x |
|createdBy/lastName|string|Created by - Last name: Displays the contact's last name| x |
|createdBy/middleName|string|Created by - Middle Name: Displays the contact's middle name.| x |
|createdBy/fullName|string|Created by - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|createdBy/contactId|int|Created by - Company ID: Database ID of the company the user belongs to|  |
|createdBy/personId|int|Created by - Contact ID: Database ID of the contact row|  |
|createdBy/mrMrs|string|Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|createdBy/title|string|Created by - Title: Displays whether the contact is addressed as Mr or Ms| x |
|createdBy/associateDbId|associate|Created by - ID| x |
|createdBy/contactName|string|Created by - Owning company: Name of the company the user belongs to| x |
|createdBy/contactDepartment|string|Created by - Owning department: Name of the department at the company the user belongs to| x |
|createdBy/usergroup|userGroup|Created by - Primary group: The user's primary user group| x |
|createdBy/contactFullName|string|Created by - Owner: Name and department of the company the user belongs to| x |
|createdBy/contactCategory|listAny|Created by - Category: Category| x |
|createdBy/role|listAny|Created by - Role: Role| x |
|createdBy/assocName|associate|Created by - User ID: User ID| x |
|createdBy/assocTooltip|string|Created by - Description: Description|  |
|createdBy/assocType|listAny|Created by - Type: Type of user: associate, external user, system user, anonymous account| x |
|createdBy/ejUserId|int|Created by - Service user ID: The database ID of a Service user|  |
|createdBy/simultaneousEjUser|bool|Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|createdBy/ejDisplayName|string|Created by - Nick name: User's nick name in Service| x |
|createdBy/ejStatus|int|Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in| x |
|createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|createdBy/isActive|bool|Created by - Active: Is this user active, and should be able to log in?| x |
|createdBy/isActiveText|bool|Created by - Active status: Is this user active, and should be able to log in?| x |
|createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|createdBy/otherGroups|userGroup|Created by - Other groups: Other groups|  |
|createdBy/userName|string|Created by - User name: User name| x |
|createdBy/personEmail|string|Created by - E-mail| x |
|ownedBy/firstName|string|Owner - First name: Displays the contact's first name| x |
|ownedBy/lastName|string|Owner - Last name: Displays the contact's last name| x |
|ownedBy/middleName|string|Owner - Middle Name: Displays the contact's middle name.| x |
|ownedBy/fullName|string|Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ownedBy/contactId|int|Owner - Company ID: Database ID of the company the user belongs to|  |
|ownedBy/personId|int|Owner - Contact ID: Database ID of the contact row|  |
|ownedBy/mrMrs|string|Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ownedBy/title|string|Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |
|ownedBy/associateDbId|associate|Owner - ID| x |
|ownedBy/contactName|string|Owner - Owning company: Name of the company the user belongs to| x |
|ownedBy/contactDepartment|string|Owner - Owning department: Name of the department at the company the user belongs to| x |
|ownedBy/usergroup|userGroup|Owner - Primary group: The user's primary user group| x |
|ownedBy/contactFullName|string|Owner - Owner: Name and department of the company the user belongs to| x |
|ownedBy/contactCategory|listAny|Owner - Category: Category| x |
|ownedBy/role|listAny|Owner - Role: Role| x |
|ownedBy/assocName|associate|Owner - User ID: User ID| x |
|ownedBy/assocTooltip|string|Owner - Description: Description|  |
|ownedBy/assocType|listAny|Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|ownedBy/ejUserId|int|Owner - Service user ID: The database ID of a Service user|  |
|ownedBy/simultaneousEjUser|bool|Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ownedBy/ejDisplayName|string|Owner - Nick name: User's nick name in Service| x |
|ownedBy/ejStatus|int|Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in| x |
|ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ownedBy/isActive|bool|Owner - Active: Is this user active, and should be able to log in?| x |
|ownedBy/isActiveText|bool|Owner - Active status: Is this user active, and should be able to log in?| x |
|ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|ownedBy/otherGroups|userGroup|Owner - Other groups: Other groups|  |
|ownedBy/userName|string|Owner - User name: User name| x |
|ownedBy/personEmail|string|Owner - E-mail| x |
|person/personId|int|DB ID: Displays the database ID of a contact| x |
|person/firstName|string|First name: Displays the contact's first name| x |
|person/lastName|string|Last name: Displays the contact's last name| x |
|person/middleName|string|Middle name: Displays the contact's middle name.| x |
|person/fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
|person/contactId|int|Company ID: Database ID of company| x |
|person/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|person/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/position|listAny|Position| x |
|person/personNumber|string|Number: Displays the contact's number| x |
|person/title|string|Title: Displays the contact's job title| x |
|person/personCountry|listAny|Country: Country| x |
|person/personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox| x |
|person/rank|int|Rank: Displays a contact's current rank| x |
|person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|person/useAsMailingAddress|bool|Use as postal address: Use as postal address| x |
|person/personSource|listAny|Source: Source (Contact)| x |
|person/retired|bool|Former employee: Indicates whether the contact has retired/left the company| x |
|person/birthYear|int|Birth year: Displays contact's birth year| x |
|person/birthMonth|int|Birth month: Displays contact's birth month| x |
|person/birthDay|int|Birth day: Displays contact's birth day (day of month)| x |
|person/kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet| x |
|person/kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet| x |
|person/personUpdatedBy|associate|Updated by: The user who last updated the data| x |
|person/personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|person/personRegisteredBy|associate|Registered by: The user who registered the data| x |
|person/personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|person/portraitThumbnail| *None* |Person image: Person image|  |
|person/personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|person/ticketPriority|listAny|Service priority: Default service priority for this contact| x |
|person/supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|person/supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|person/personAssociateId|associate|Our contact: Displays our contact| x |
|person/personCategory|listAny|Category| x |
|person/personBusiness|listAny|Business| x |
|person/personDeletedDate|datetime|Deleted date: Deleted date|  |
|person/hasCompany|bool|Has company: The contact is associated with a company| x |
|person/isProjectMember|bool|Is project member: This person is a project member| x |
|person/isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|person/phone/formattedNumber|string|Phone : Displays phone number|  |
|person/personDirectPhone/formattedNumber|string|Direct - Phone: Displays phone number|  |
|person/personDirectPhone/description|string|Direct - Description: Phone number description| x |
|person/personMobilePhone/formattedNumber|string|Mobile - Phone: Displays phone number|  |
|person/personMobilePhone/description|string|Mobile - Description: Phone number description| x |
|person/personPrivate/formattedNumber|string|Private - Phone: Displays phone number|  |
|person/personPrivate/description|string|Private - Description: Phone number description| x |
|person/personPager/formattedNumber|string|Other - Phone: Displays phone number|  |
|person/personPager/description|string|Other - Description: Phone number description| x |
|person/personDirectFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|person/personDirectFax/description|string|Fax - Description: Phone number description| x |
|person/searchPhone/formattedNumber|string|Phone : Displays phone number|  |
|person/searchPhone/description|string|Description: Phone number description| x |
|person/personInfo/textId|int|Text ID| x |
|person/personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|person/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|person/email/emailAddress|string|E-mail| x |
|person/email/emailDescription|string|Description| x |
|person/email/emailId|int|ID| x |
|person/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|person/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|person/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|person/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|person/personUrl/URLAddress|string|URL| x |
|person/personUrl/URLDescription|string|Description| x |
|person/personAddress/addressId|int|Contact address - Address ID: Database ID for the address record| x |
|person/personAddress/line1|string|Contact address - Address 1: First line of the address| x |
|person/personAddress/line2|string|Contact address - Address 2: Second line of the address| x |
|person/personAddress/line3|string|Contact address - Address 3: Third line of the address| x |
|person/personAddress/county|string|Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|person/personAddress/city|string|Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|person/personAddress/zip|string|Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|person/personAddress/state|string|Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|person/personAddress/wgs84latitude|decimal|Contact address - Latitude: Latitude| x |
|person/personAddress/wgs84longitude|decimal|Contact address - Longitude: Longitude| x |
|person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|person/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|person/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|person/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|person/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|person/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|person/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|person/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|person/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|person/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|person/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|person/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|person/personUdef/SuperOffice:3|int|contactnumber| x |
|person/personUdef/SuperOffice:4|date|contactdate| x |
|person/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|person/personUdef/SuperOffice:6|bool|contactcheckbox| x |
|person/personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|person/personUdef/SuperOffice:8|decimal|contactdecimal| x |
|person/personUdef/SuperOffice:9|string|page1saleonly| x |
|person/personUdef/SuperOffice:10|string|page1marketingonly| x |
|person/personUdef/SuperOffice:11|string|page1adminonly| x |
|person/isMailingRecipient|bool|isMailingRecipient: isMailingRecipient| x |
|person/hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/subscription|listAny|Subscription: Subscription for marketing| x |
|person/legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|person/consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contact/contactId|int|Company ID: Database ID of company| x |
|contact/name|stringorPK|Company name| x |
|contact/department|string|Department| x |
|contact/nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|contact/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|contact/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|contact/associateId|associate|Our contact: Displays our contact| x |
|contact/category|listAny|Category| x |
|contact/business|listAny|Business| x |
|contact/country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|contact/number|string|Number| x |
|contact/code|string|Code| x |
|contact/orgnr|string|VAT No.| x |
|contact/stop|bool|Stop| x |
|contact/contactNoMail|bool|No mailings (company| x |
|contact/updatedBy|associate|Updated by: The user who last updated the data| x |
|contact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|contact/registeredBy|associate|Registered by: The user who registered the data| x |
|contact/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contact/contactSource|listAny|Source: Source (Company)| x |
|contact/contactDeleted|bool|Deleted: Deleted| x |
|contact/phone/formattedNumber|string|Phone : Displays phone number|  |
|contact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|contact/deletedDate|datetime|Deleted date: Deleted date|  |
|contact/mainContact| *None* |Main contact: Main contact for this company| x |
|contact/contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|contact/contactPhone/description|string|Telephone - Description: Phone number description| x |
|contact/contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|contact/contactFax/description|string|Fax - Description: Phone number description| x |
|contact/searchPhone/formattedNumber|string|Searchphone - Phone: Displays phone number|  |
|contact/searchPhone/description|string|Searchphone - Description: Phone number description| x |
|contact/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|contact/email/emailAddress|string|E-mail| x |
|contact/email/emailDescription|string|Description| x |
|contact/email/emailId|int|ID| x |
|contact/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|contact/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|contact/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|contact/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|contact/postAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|contact/postAddress/line1|string|Postal address - Address 1: First line of the address| x |
|contact/postAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|contact/postAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|contact/postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|contact/postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|contact/postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|contact/postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|contact/postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|contact/postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/addressId|int|Street address - Address ID: Database ID for the address record| x |
|contact/streetAddress/line1|string|Street address - Address 1: First line of the address| x |
|contact/streetAddress/line2|string|Street address - Address 2: Second line of the address| x |
|contact/streetAddress/line3|string|Street address - Address 3: Third line of the address| x |
|contact/streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|contact/streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.| x |
|contact/streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|contact/streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|contact/streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude| x |
|contact/streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude| x |
|contact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|contact/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|contact/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|contact/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|contact/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|contact/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|contact/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|contact/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|contact/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|contact/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|contact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|contact/url/URLAddress|string|URL| x |
|contact/url/URLDescription|string|Description| x |
|contact/contactAssociate/firstName|string|First name: Displays the contact's first name| x |
|contact/contactAssociate/lastName|string|Last name: Displays the contact's last name| x |
|contact/contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|contact/contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contact/contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|contact/contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|contact/contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|contact/contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|contact/contactAssociate/associateDbId|associate|ID| x |
|contact/contactAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|contact/contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|contact/contactAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|contact/contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|contact/contactAssociate/contactCategory|listAny|Category: Category| x |
|contact/contactAssociate/role|listAny|Role : Role| x |
|contact/contactAssociate/assocName|associate|User ID : User ID| x |
|contact/contactAssociate/assocTooltip|string|Description : Description|  |
|contact/contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|contact/contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|contact/contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contact/contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|contact/contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|contact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|contact/contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|contact/contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|contact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contact/contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|contact/contactAssociate/userName|string|User name: User name| x |
|contact/contactAssociate/personEmail|string|E-mail| x |
|contact/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|contact/contactUdef/SuperOffice:3|int|companynumber| x |
|contact/contactUdef/SuperOffice:4|date|companydate| x |
|contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|contact/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|contact/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|contact/contactUdef/SuperOffice:9|string|page1saleonly| x |
|contact/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|contact/contactUdef/SuperOffice:11|string|page1adminonly| x |
|contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
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
|selectionId|int|Selection ID: The database ID of the selection|  |
|selectionMemberId|int|Selection member ID: The database ID of the selection member record|  |
|rowKind| *None* |Icon indicating whether the row comes from a static or a dynamic selection|  |
|targetTableNumber|int|TargetTableNumber: TargetTableNumber| x |
|targetRecordId|int|TargetRecordId: TargetRecordId| x |

## Sample

```http!
GET /api/v1/archive/TicketStaticSelectionV2?$select=ownedBy/ejDisplayName,person/personUpdatedDate,person/personUdef/SuperOffice:1,person/personUdef/SuperOffice:6,person/subscription
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

