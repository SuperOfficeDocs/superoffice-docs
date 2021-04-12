---
uid: Relation
title: Relation
description: Data provider class for the 'Relation' archive under the company card. This class combines output from
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "Relation"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Relation"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.RelationProvider">SuperOffice.CRM.ArchiveLists.RelationProvider</see> inside NetServer's SODatabase assembly.

Data provider class for the 'Relation' archive under the company card. This class combines output from
the up to eight basic sub-providers (CC, PC, PP and CP plus their reversed cousins) into one data stream.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"relation"|[Relation]|
|"retired"|Former employees|
|"stop"|Companies flagged with Stop|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|relationName|string|Name: Name of relation, not taking into account the relation direction| x |
|relationComment|string|Comment: Comment on the relation| x |
|reversedName|string|Passive form : The name of the relation in the passive direction| x |
|processedName| *None* |has relations: Has the given relationship to|  |
|relationId|int|ID: Database ID of the relation record| x |
|relationDefinitionId|int|Definition ID: Database ID of the definition record for this relation| x |
|direction|int|Direction: The direction of this relation (active or passive)| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|source/personId| *None* |Source - DB ID: Displays the database ID of a contact|  |
|source/firstName| *None* |Source - First name: Displays the contact's first name|  |
|source/lastName| *None* |Source - Last name: Displays the contact's last name|  |
|source/middleName| *None* |Source - Middle name: Displays the contact's middle name.|  |
|source/fullName| *None* |Source - Contact: Displays the contact to which an item is linked|  |
|source/fullNameWithContact| *None* |Source - Contact and company: The fully formatted contact name, and full company name|  |
|source/contactId|int|Source - Company ID: Database ID of company| x |
|source/hasInfoText|bool|Source - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|source/hasInterests|bool|Source - Has interests: Displays an Icon indicating if the contact has active interests| x |
|source/personHasInterests| *None* |Source - Has interests: Displays an Icon indicating if the contact has active interests|  |
|source/mrMrs| *None* |Source - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|source/position| *None* |Source - Position|  |
|source/personNumber| *None* |Source - Number: Displays the contact's number|  |
|source/title| *None* |Source - Title: Displays the contact's job title|  |
|source/personCountry| *None* |Source - Country: Country|  |
|source/personNoMail| *None* |Source - No Mailings: Displays the contact's No Mailings checkbox|  |
|source/rank| *None* |Source - Rank: Displays a contact's current rank|  |
|source/birthdate| *None* |Source - Birthdate: Displays the contact's date of birth|  |
|source/associateType| *None* |Source - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|source/useAsMailingAddress| *None* |Source - Use as postal address: Use as postal address|  |
|source/personSource| *None* |Source - Source: Source (Contact)|  |
|source/retired| *None* |Source - Former employee: Indicates whether the contact has retired/left the company|  |
|source/birthYear| *None* |Source - Birth year: Displays contact's birth year|  |
|source/birthMonth| *None* |Source - Birth month: Displays contact's birth month|  |
|source/birthDay| *None* |Source - Birth day: Displays contact's birth day (day of month)|  |
|source/kanaFirstName| *None* |Source - First name, kana: Contact's first name, in kana alphabet|  |
|source/kanaLastName| *None* |Source - Last name, kana: Contact's last name, in kana alphabet|  |
|source/personUpdatedBy| *None* |Source - Updated by: The user who last updated the data|  |
|source/personUpdatedDate| *None* |Source - Updated: The date/time the data was last updated in UTC.|  |
|source/personRegisteredBy| *None* |Source - Registered by: The user who registered the data|  |
|source/personRegisteredDate| *None* |Source - Registered date: The date/time the data was registered in UTC.|  |
|source/portraitThumbnail| *None* |Source - Person image: Person image|  |
|source/personActiveErpLinks| *None* |Source - ERP connected: Is there an active ERP Sync?|  |
|source/ticketPriority| *None* |Source - Service priority: Default service priority for this contact|  |
|source/supportLanguage| *None* |Source - Preferred language: Preferred language used for reply templates and more|  |
|source/supportAssociate| *None* |Source - Our service contact: Default service contact for this contact|  |
|source/personAssociateId| *None* |Source - Our contact: Displays our contact|  |
|source/personCategory| *None* |Source - Category|  |
|source/personBusiness| *None* |Source - Business|  |
|source/personDeletedDate| *None* |Source - Deleted date: Deleted date|  |
|source/hasCompany| *None* |Source - Has company: The contact is associated with a company|  |
|source/isProjectMember| *None* |Source - Is project member: This person is a project member|  |
|source/isStakeholder| *None* |Source - Is stakeholder: This person is a sale stakeholder|  |
|source/phone/formattedNumber|string|Source - Phone: Displays phone number|  |
|source/restrictionContactId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|source/restrictionPersonId| *None* |Source - Company ID: Database ID of company to fetch relations for|  |
|source/who| *None* |Source - Full name: Full name of company/contact| x |
|source/personDirectPhone/formattedNumber| *None* |Source - Direct - Phone: Displays phone number|  |
|source/personDirectPhone/description| *None* |Source - Direct - Description: Phone number description|  |
|source/personMobilePhone/formattedNumber| *None* |Source - Mobile - Phone: Displays phone number|  |
|source/personMobilePhone/description| *None* |Source - Mobile - Description: Phone number description|  |
|source/personPrivate/formattedNumber| *None* |Source - Private - Phone: Displays phone number|  |
|source/personPrivate/description| *None* |Source - Private - Description: Phone number description|  |
|source/personPager/formattedNumber| *None* |Source - Other - Phone: Displays phone number|  |
|source/personPager/description| *None* |Source - Other - Description: Phone number description|  |
|source/personDirectFax/formattedNumber| *None* |Source - Fax - Phone: Displays phone number|  |
|source/personDirectFax/description| *None* |Source - Fax - Description: Phone number description|  |
|source/name|stringorPK|Source - Company name| x |
|source/department|string|Source - Department| x |
|source/nameDepartment| *None* |Source - Company: Displays the company an activity is linked to| x |
|source/associateId|associate|Source - Our contact: Displays our contact| x |
|source/category|listAny|Source - Category| x |
|source/business|listAny|Source - Business| x |
|source/country|listAny|Source - Country: This criterion corresponds to the Country field on the Company card.| x |
|source/number|string|Source - Number| x |
|source/code|string|Source - Code| x |
|source/orgnr|string|Source - VAT No.| x |
|source/stop|bool|Source - Stop| x |
|source/contactNoMail|bool|Source - No mailings (company)| x |
|source/updatedBy|associate|Source - Updated by: The user who last updated the data| x |
|source/updatedDate|date|Source - Updated: The date/time the data was last updated in UTC.| x |
|source/registeredBy|associate|Source - Registered by: The user who registered the data| x |
|source/registeredDate|date|Source - Registered date: The date/time the data was registered in UTC.| x |
|source/contactSource|listAny|Source - Source: Source (Company)| x |
|source/contactDeleted|bool|Source - Deleted: Deleted| x |
|source/activeErpLinks|bool|Source - ERP connected: Is there an active ERP Sync?| x |
|source/deletedDate|datetime|Source - Deleted date: Deleted date|  |
|source/mainContact| *None* |Source - Main contact: Main contact for this company| x |
|source/contactPhone/formattedNumber|string|Source - Telephone - Phone: Displays phone number|  |
|source/contactPhone/description|string|Source - Telephone - Description: Phone number description| x |
|target/contactId|int|Target - Company ID: Database ID of company| x |
|target/name|stringorPK|Target - Company name| x |
|target/department|string|Target - Department| x |
|target/nameDepartment| *None* |Target - Company: Displays the company an activity is linked to| x |
|target/hasInfoText|bool|Target - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|target/hasInterests|bool|Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|target/associateId|associate|Target - Our contact: Displays our contact| x |
|target/category|listAny|Target - Category| x |
|target/business|listAny|Target - Business| x |
|target/country|listAny|Target - Country: This criterion corresponds to the Country field on the Company card.| x |
|target/number|string|Target - Number| x |
|target/code|string|Target - Code| x |
|target/orgnr|string|Target - VAT No.| x |
|target/stop|bool|Target - Stop| x |
|target/contactNoMail|bool|Target - No mailings (company)| x |
|target/updatedBy|associate|Target - Updated by: The user who last updated the data| x |
|target/updatedDate|date|Target - Updated: The date/time the data was last updated in UTC.| x |
|target/registeredBy|associate|Target - Registered by: The user who registered the data| x |
|target/registeredDate|date|Target - Registered date: The date/time the data was registered in UTC.| x |
|target/contactSource|listAny|Target - Source: Source (Company)| x |
|target/contactDeleted|bool|Target - Deleted: Deleted| x |
|target/phone/formattedNumber|string|Target - Phone: Displays phone number|  |
|target/activeErpLinks|bool|Target - ERP connected: Is there an active ERP Sync?| x |
|target/deletedDate|datetime|Target - Deleted date: Deleted date|  |
|target/mainContact| *None* |Target - Main contact: Main contact for this company| x |
|target/restrictionContactId|int|Target - Company ID: Database ID of company to fetch relations for|  |
|target/who| *None* |Target - Full name: Full name of company/contact| x |
|target/contactPhone/formattedNumber|string|Target - Telephone - Phone: Displays phone number|  |
|target/contactPhone/description|string|Target - Telephone - Description: Phone number description| x |
|target/contactFax/formattedNumber| *None* |Target - Fax - Phone: Displays phone number|  |
|target/contactFax/description| *None* |Target - Fax - Description: Phone number description|  |
|target/searchPhone/formattedNumber| *None* |Target - Searchphone - Phone: Displays phone number|  |
|target/searchPhone/description| *None* |Target - Searchphone - Description: Phone number description|  |
|target/email/emailProtocol| *None* |Target - Protocol: E-mail protocol, such as SMTP|  |
|target/email/emailAddress| *None* |Target - E-mail|  |
|target/email/emailDescription| *None* |Target - Description|  |
|target/email/emailId| *None* |Target - ID|  |
|target/email/emailLastSent| *None* |Target - Last sent: The date and time an e-mail was last sent to this address|  |
|target/email/emailBounceCount| *None* |Target - Bounce count: Bounce count for this e-mail address|  |
|target/email/emailLastBounce| *None* |Target - Last bounce: Date and time for last bounce to this e-mail address|  |
|target/email/emailHasBounced| *None* |Target - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|target/postAddress/addressId| *None* |Target - Postal address - Address ID: Database ID for the address record|  |
|target/postAddress/line1| *None* |Target - Postal address - Address 1: First line of the address|  |
|target/postAddress/line2| *None* |Target - Postal address - Address 2: Second line of the address|  |
|target/postAddress/line3| *None* |Target - Postal address - Address 3: Third line of the address|  |
|target/postAddress/county| *None* |Target - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|target/postAddress/city| *None* |Target - Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|target/postAddress/zip| *None* |Target - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|target/postAddress/state| *None* |Target - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|target/postAddress/wgs84latitude| *None* |Target - Postal address - Latitude: Latitude|  |
|target/postAddress/wgs84longitude| *None* |Target - Postal address - Longitude: Longitude|  |
|target/postAddress/formattedAddress| *None* |Target - Postal address - {formattedAddress}: {formattedAddress}|  |
|target/postAddress/formattedMultiLineAddress| *None* |Target - Postal address - {formattedAddress}: {formattedAddress}|  |
|target/streetAddress/addressId| *None* |Target - Street address - Address ID: Database ID for the address record|  |
|target/streetAddress/line1| *None* |Target - Street address - Address 1: First line of the address|  |
|target/streetAddress/line2| *None* |Target - Street address - Address 2: Second line of the address|  |
|target/streetAddress/line3| *None* |Target - Street address - Address 3: Third line of the address|  |
|target/streetAddress/county| *None* |Target - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|target/streetAddress/city| *None* |Target - Street address - City: This criterion corresponds to the City field on the Company card.|  |
|target/streetAddress/zip| *None* |Target - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|target/streetAddress/state| *None* |Target - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|target/streetAddress/wgs84latitude| *None* |Target - Street address - Latitude: Latitude|  |
|target/streetAddress/wgs84longitude| *None* |Target - Street address - Longitude: Longitude|  |
|target/streetAddress/formattedAddress| *None* |Target - Street address - {formattedAddress}: {formattedAddress}|  |
|target/streetAddress/formattedMultiLineAddress| *None* |Target - Street address - {formattedAddress}: {formattedAddress}|  |
|target/restrictionAddress/addressId| *None* |Target - Search address - Address ID: Database ID for the address record|  |
|target/restrictionAddress/line1| *None* |Target - Search address - Address 1: First line of the address|  |
|target/restrictionAddress/line2| *None* |Target - Search address - Address 2: Second line of the address|  |
|target/restrictionAddress/line3| *None* |Target - Search address - Address 3: Third line of the address|  |
|target/restrictionAddress/county| *None* |Target - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|target/restrictionAddress/city| *None* |Target - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|target/restrictionAddress/zip| *None* |Target - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|target/restrictionAddress/state| *None* |Target - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|target/restrictionAddress/wgs84latitude| *None* |Target - Search address - Latitude: Latitude|  |
|target/restrictionAddress/wgs84longitude| *None* |Target - Search address - Longitude: Longitude|  |
|target/restrictionAddress/formattedAddress| *None* |Target - Search address - {formattedAddress}: {formattedAddress}|  |
|target/restrictionAddress/formattedMultiLineAddress| *None* |Target - Search address - {formattedAddress}: {formattedAddress}|  |
|target/url/URLAddress| *None* |Target - URL|  |
|target/url/URLDescription| *None* |Target - Description|  |
|target/contactAssociate/firstName| *None* |Target - First name: Displays the contact's first name|  |
|target/contactAssociate/lastName| *None* |Target - Last name: Displays the contact's last name|  |
|target/contactAssociate/middleName| *None* |Target - Middle Name: Displays the contact's middle name.|  |
|target/contactAssociate/fullName| *None* |Target - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|target/contactAssociate/contactId| *None* |Target - Company ID: Database ID of the company the user belongs to|  |
|target/contactAssociate/personId| *None* |Target - Contact ID: Database ID of the contact row|  |
|target/contactAssociate/mrMrs| *None* |Target - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|target/contactAssociate/title| *None* |Target - Title: Displays whether the contact is addressed as Mr or Ms|  |
|target/contactAssociate/associateDbId| *None* |Target - ID|  |
|target/contactAssociate/contactName| *None* |Target - Owning company: Name of the company the user belongs to|  |
|target/contactAssociate/contactDepartment| *None* |Target - Owning department: Name of the department at the company the user belongs to|  |
|target/contactAssociate/usergroup| *None* |Target - Primary group: The user's primary user group|  |
|target/contactAssociate/contactFullName| *None* |Target - Owner: Name and department of the company the user belongs to|  |
|target/contactAssociate/contactCategory| *None* |Target - Category: Category|  |
|target/contactAssociate/role| *None* |Target - Role: Role|  |
|target/contactAssociate/assocName| *None* |Target - User ID: User ID|  |
|target/contactAssociate/assocTooltip| *None* |Target - Description: Description|  |
|target/contactAssociate/assocType| *None* |Target - Type: Type of user: associate, external user, system user, anonymous account|  |
|target/contactAssociate/ejUserId| *None* |Target - Service user ID: The database ID of a Service user|  |
|target/contactAssociate/simultaneousEjUser| *None* |Target - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|target/contactAssociate/ejDisplayName| *None* |Target - Nick name: User's nick name in Service|  |
|target/contactAssociate/ejStatus| *None* |Target - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|target/contactAssociate/credentialType| *None* |Target - Auth. type: What type of credentials to use when this user logs in|  |
|target/contactAssociate/credentialDisplayValue| *None* |Target - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|target/contactAssociate/isActive| *None* |Target - Active: Is this user active, and should be able to log in?|  |
|target/contactAssociate/isActiveText| *None* |Target - Active status: Is this user active, and should be able to log in?|  |
|target/contactAssociate/portraitThumbnail| *None* |Target - Person image: Person image|  |
|target/contactAssociate/otherGroups| *None* |Target - Other groups: Other groups|  |
|target/contactAssociate/userName| *None* |Target - User name: User name|  |
|target/contactAssociate/personEmail| *None* |Target - E-mail|  |
|target/contactInterestIds| *None* |Target - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|target/contactUdef/SuperOffice:1| *None* |Target - companyshorttext: tooltipshorttext|  |
|target/contactUdef/SuperOffice:2| *None* |Target - companylongtext: tooltiplongtext|  |
|target/contactUdef/SuperOffice:3| *None* |Target - companynumber|  |
|target/contactUdef/SuperOffice:4| *None* |Target - companydate|  |
|target/contactUdef/SuperOffice:5| *None* |Target - companyunlimiteddate: tooltipunlimiteddate|  |
|target/contactUdef/SuperOffice:6| *None* |Target - companycheckbox|  |
|target/contactUdef/SuperOffice:7| *None* |Target - companydropdownlistbox|  |
|target/contactUdef/SuperOffice:8| *None* |Target - companydecimal|  |
|target/contactUdef/SuperOffice:9| *None* |Target - page1saleonly|  |
|target/contactUdef/SuperOffice:10| *None* |Target - page1marketingonly|  |
|target/contactUdef/SuperOffice:11| *None* |Target - page1adminonly|  |
|target/contactUdef/SuperOffice:12| *None* |Target - Udlist one: Static tooltip for udlist one|  |
|target/contactUdef/SuperOffice:13| *None* |Target - Udlist two: Static tooltip for udlist two|  |
|target/NumberOfActivities| *None* |Target - Number of activities|  |
|target/NumberOfActivitiesInPeriod| *None* |Target - Number of activities in last 90 days|  |
|target/NumberOfNotCompletedActivities| *None* |Target - Number of non-completed activities|  |
|target/NumberOfNotCompletedActivitiesInPeriod| *None* |Target - Number of non-completed activities in last 90 days|  |
|target/LastActivity| *None* |Target - Date of last activity|  |
|target/LastCompletedActivity| *None* |Target - Date of last completed activity|  |
|target/LastDoByActivity| *None* |Target - Date of last non-completed activity|  |
|target/NumberOfSales| *None* |Target - Number of sales|  |
|target/NumberOfSalesInPeriod| *None* |Target - Number of sales in last 90 days|  |
|target/NumberOfNotCompletedSales| *None* |Target - Number of non-completed sales|  |
|target/NumberOfNotCompletedSalesInPeriod| *None* |Target - Number of non-completed sales in last 90 days|  |
|target/LastSale| *None* |Target - Date of last sale|  |
|target/LastCompletedSale| *None* |Target - Date of last completed sale|  |
|target/LastDoBySale| *None* |Target - Date of last non-completed sale|  |
|target/NumberOfTickets| *None* |Target - Number of requests|  |
|target/NumberOfTicketsInPeriod| *None* |Target - Number of requests in last 90 days|  |
|target/NumberOfNotCompletedTickets| *None* |Target - Number of non-completed requests|  |
|target/NumberOfNotCompletedTicketsInPeriod| *None* |Target - Number of non-completed requests in last 90 days|  |
|target/LastTicket| *None* |Target - Date of last request|  |
|target/LastCompletedTicket| *None* |Target - Date of last completed request|  |
|target/LastDoByTicket| *None* |Target - Date of last non-completed request|  |
|target/SaintStatus1| *None* |Target - Neglected customer|  |
|target/SaintStatus2| *None* |Target - C-company|  |
|target/saintSaleStatus| *None* |Target - With status|  |
|target/saintAmountClass| *None* |Target - Amount class|  |
|target/saintActivityType| *None* |Target - SAINT type|  |
|target/saintDirection| *None* |Target - Direction|  |
|target/saintIntention| *None* |Target - Intention|  |
|target/saintTicketStatus| *None* |Target - Status|  |
|target/saintTicketCategory| *None* |Target - Category|  |
|firstName|string|First name: Displays the contact's first name| x |
|lastName|string|Last name: Displays the contact's last name| x |
|middleName|string|Middle Name : Displays the contact's middle name.| x |
|fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personId|int|Contact ID: Database ID of the contact row|  |
|mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|associateDbId|associate|ID| x |
|contactName|string|Owning company: Name of the company the user belongs to| x |
|contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|usergroup|userGroup|Primary group: The user's primary user group| x |
|contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|contactCategory|listAny|Category: Category| x |
|role|listAny|Role : Role| x |
|assocName|associate|User ID : User ID| x |
|assocTooltip|string|Description : Description|  |
|assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|ejUserId|int|Service user ID: The database ID of a Service user|  |
|simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ejDisplayName|string|Nick name: User's nick name in Service| x |
|ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|isActive|bool|Active: Is this user active, and should be able to log in?| x |
|isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|portraitThumbnail| *None* |Person image: Person image|  |
|otherGroups|userGroup|Other groups: Other groups|  |
|userName|string|User name: User name| x |
|personEmail|string|E-mail| x |
|target/personId| *None* |Target - DB ID: Displays the database ID of a contact|  |
|target/firstName| *None* |Target - First name: Displays the contact's first name|  |
|target/lastName| *None* |Target - Last name: Displays the contact's last name|  |
|target/middleName| *None* |Target - Middle name: Displays the contact's middle name.|  |
|target/fullName| *None* |Target - Contact: Displays the contact to which an item is linked|  |
|target/fullNameWithContact| *None* |Target - Contact and company: The fully formatted contact name, and full company name|  |
|target/personHasInterests| *None* |Target - Has interests: Displays an Icon indicating if the contact has active interests|  |
|target/mrMrs| *None* |Target - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|target/position| *None* |Target - Position|  |
|target/personNumber| *None* |Target - Number: Displays the contact's number|  |
|target/title| *None* |Target - Title: Displays the contact's job title|  |
|target/personCountry| *None* |Target - Country: Country|  |
|target/personNoMail| *None* |Target - No Mailings: Displays the contact's No Mailings checkbox|  |
|target/rank| *None* |Target - Rank: Displays a contact's current rank|  |
|target/birthdate| *None* |Target - Birthdate: Displays the contact's date of birth|  |
|target/associateType| *None* |Target - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|target/useAsMailingAddress| *None* |Target - Use as postal address: Use as postal address|  |
|target/personSource| *None* |Target - Source: Source (Contact)|  |
|target/retired| *None* |Target - Former employee: Indicates whether the contact has retired/left the company|  |
|target/birthYear| *None* |Target - Birth year: Displays contact's birth year|  |
|target/birthMonth| *None* |Target - Birth month: Displays contact's birth month|  |
|target/birthDay| *None* |Target - Birth day: Displays contact's birth day (day of month)|  |
|target/kanaFirstName| *None* |Target - First name, kana: Contact's first name, in kana alphabet|  |
|target/kanaLastName| *None* |Target - Last name, kana: Contact's last name, in kana alphabet|  |
|target/personUpdatedBy| *None* |Target - Updated by: The user who last updated the data|  |
|target/personUpdatedDate| *None* |Target - Updated: The date/time the data was last updated in UTC.|  |
|target/personRegisteredBy| *None* |Target - Registered by: The user who registered the data|  |
|target/personRegisteredDate| *None* |Target - Registered date: The date/time the data was registered in UTC.|  |
|target/portraitThumbnail| *None* |Target - Person image: Person image|  |
|target/personActiveErpLinks| *None* |Target - ERP connected: Is there an active ERP Sync?|  |
|target/ticketPriority| *None* |Target - Service priority: Default service priority for this contact|  |
|target/supportLanguage| *None* |Target - Preferred language: Preferred language used for reply templates and more|  |
|target/supportAssociate| *None* |Target - Our service contact: Default service contact for this contact|  |
|target/personAssociateId| *None* |Target - Our contact: Displays our contact|  |
|target/personCategory| *None* |Target - Category|  |
|target/personBusiness| *None* |Target - Business|  |
|target/personDeletedDate| *None* |Target - Deleted date: Deleted date|  |
|target/hasCompany| *None* |Target - Has company: The contact is associated with a company|  |
|target/isProjectMember| *None* |Target - Is project member: This person is a project member|  |
|target/isStakeholder| *None* |Target - Is stakeholder: This person is a sale stakeholder|  |
|target/restrictionPersonId| *None* |Target - Company ID: Database ID of company to fetch relations for|  |
|target/personDirectPhone/formattedNumber| *None* |Target - Direct - Phone: Displays phone number|  |
|target/personDirectPhone/description| *None* |Target - Direct - Description: Phone number description|  |
|target/personMobilePhone/formattedNumber| *None* |Target - Mobile - Phone: Displays phone number|  |
|target/personMobilePhone/description| *None* |Target - Mobile - Description: Phone number description|  |
|target/personPrivate/formattedNumber| *None* |Target - Private - Phone: Displays phone number|  |
|target/personPrivate/description| *None* |Target - Private - Description: Phone number description|  |
|target/personPager/formattedNumber| *None* |Target - Other - Phone: Displays phone number|  |
|target/personPager/description| *None* |Target - Other - Description: Phone number description|  |
|target/personDirectFax/formattedNumber| *None* |Target - Fax - Phone: Displays phone number|  |
|target/personDirectFax/description| *None* |Target - Fax - Description: Phone number description|  |
|source/contactFax/formattedNumber| *None* |Source - Fax - Phone: Displays phone number|  |
|source/contactFax/description| *None* |Source - Fax - Description: Phone number description|  |
|source/searchPhone/formattedNumber| *None* |Source - Searchphone - Phone: Displays phone number|  |
|source/searchPhone/description| *None* |Source - Searchphone - Description: Phone number description|  |
|source/email/emailProtocol| *None* |Source - Protocol: E-mail protocol, such as SMTP|  |
|source/email/emailAddress| *None* |Source - E-mail|  |
|source/email/emailDescription| *None* |Source - Description|  |
|source/email/emailId| *None* |Source - ID|  |
|source/email/emailLastSent| *None* |Source - Last sent: The date and time an e-mail was last sent to this address|  |
|source/email/emailBounceCount| *None* |Source - Bounce count: Bounce count for this e-mail address|  |
|source/email/emailLastBounce| *None* |Source - Last bounce: Date and time for last bounce to this e-mail address|  |
|source/email/emailHasBounced| *None* |Source - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|source/postAddress/addressId| *None* |Source - Postal address - Address ID: Database ID for the address record|  |
|source/postAddress/line1| *None* |Source - Postal address - Address 1: First line of the address|  |
|source/postAddress/line2| *None* |Source - Postal address - Address 2: Second line of the address|  |
|source/postAddress/line3| *None* |Source - Postal address - Address 3: Third line of the address|  |
|source/postAddress/county| *None* |Source - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|source/postAddress/city| *None* |Source - Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|source/postAddress/zip| *None* |Source - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|source/postAddress/state| *None* |Source - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|source/postAddress/wgs84latitude| *None* |Source - Postal address - Latitude: Latitude|  |
|source/postAddress/wgs84longitude| *None* |Source - Postal address - Longitude: Longitude|  |
|source/postAddress/formattedAddress| *None* |Source - Postal address - {formattedAddress}: {formattedAddress}|  |
|source/postAddress/formattedMultiLineAddress| *None* |Source - Postal address - {formattedAddress}: {formattedAddress}|  |
|source/streetAddress/addressId| *None* |Source - Street address - Address ID: Database ID for the address record|  |
|source/streetAddress/line1| *None* |Source - Street address - Address 1: First line of the address|  |
|source/streetAddress/line2| *None* |Source - Street address - Address 2: Second line of the address|  |
|source/streetAddress/line3| *None* |Source - Street address - Address 3: Third line of the address|  |
|source/streetAddress/county| *None* |Source - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|source/streetAddress/city| *None* |Source - Street address - City: This criterion corresponds to the City field on the Company card.|  |
|source/streetAddress/zip| *None* |Source - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|source/streetAddress/state| *None* |Source - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|source/streetAddress/wgs84latitude| *None* |Source - Street address - Latitude: Latitude|  |
|source/streetAddress/wgs84longitude| *None* |Source - Street address - Longitude: Longitude|  |
|source/streetAddress/formattedAddress| *None* |Source - Street address - {formattedAddress}: {formattedAddress}|  |
|source/streetAddress/formattedMultiLineAddress| *None* |Source - Street address - {formattedAddress}: {formattedAddress}|  |
|source/restrictionAddress/addressId| *None* |Source - Search address - Address ID: Database ID for the address record|  |
|source/restrictionAddress/line1| *None* |Source - Search address - Address 1: First line of the address|  |
|source/restrictionAddress/line2| *None* |Source - Search address - Address 2: Second line of the address|  |
|source/restrictionAddress/line3| *None* |Source - Search address - Address 3: Third line of the address|  |
|source/restrictionAddress/county| *None* |Source - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|source/restrictionAddress/city| *None* |Source - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|source/restrictionAddress/zip| *None* |Source - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|source/restrictionAddress/state| *None* |Source - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|source/restrictionAddress/wgs84latitude| *None* |Source - Search address - Latitude: Latitude|  |
|source/restrictionAddress/wgs84longitude| *None* |Source - Search address - Longitude: Longitude|  |
|source/restrictionAddress/formattedAddress| *None* |Source - Search address - {formattedAddress}: {formattedAddress}|  |
|source/restrictionAddress/formattedMultiLineAddress| *None* |Source - Search address - {formattedAddress}: {formattedAddress}|  |
|source/url/URLAddress| *None* |Source - URL|  |
|source/url/URLDescription| *None* |Source - Description|  |
|source/contactAssociate/firstName| *None* |Source - First name: Displays the contact's first name|  |
|source/contactAssociate/lastName| *None* |Source - Last name: Displays the contact's last name|  |
|source/contactAssociate/middleName| *None* |Source - Middle Name: Displays the contact's middle name.|  |
|source/contactAssociate/fullName| *None* |Source - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|source/contactAssociate/contactId| *None* |Source - Company ID: Database ID of the company the user belongs to|  |
|source/contactAssociate/personId| *None* |Source - Contact ID: Database ID of the contact row|  |
|source/contactAssociate/mrMrs| *None* |Source - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|source/contactAssociate/title| *None* |Source - Title: Displays whether the contact is addressed as Mr or Ms|  |
|source/contactAssociate/associateDbId| *None* |Source - ID|  |
|source/contactAssociate/contactName| *None* |Source - Owning company: Name of the company the user belongs to|  |
|source/contactAssociate/contactDepartment| *None* |Source - Owning department: Name of the department at the company the user belongs to|  |
|source/contactAssociate/usergroup| *None* |Source - Primary group: The user's primary user group|  |
|source/contactAssociate/contactFullName| *None* |Source - Owner: Name and department of the company the user belongs to|  |
|source/contactAssociate/contactCategory| *None* |Source - Category: Category|  |
|source/contactAssociate/role| *None* |Source - Role: Role|  |
|source/contactAssociate/assocName| *None* |Source - User ID: User ID|  |
|source/contactAssociate/assocTooltip| *None* |Source - Description: Description|  |
|source/contactAssociate/assocType| *None* |Source - Type: Type of user: associate, external user, system user, anonymous account|  |
|source/contactAssociate/ejUserId| *None* |Source - Service user ID: The database ID of a Service user|  |
|source/contactAssociate/simultaneousEjUser| *None* |Source - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|source/contactAssociate/ejDisplayName| *None* |Source - Nick name: User's nick name in Service|  |
|source/contactAssociate/ejStatus| *None* |Source - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|source/contactAssociate/credentialType| *None* |Source - Auth. type: What type of credentials to use when this user logs in|  |
|source/contactAssociate/credentialDisplayValue| *None* |Source - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|source/contactAssociate/isActive| *None* |Source - Active: Is this user active, and should be able to log in?|  |
|source/contactAssociate/isActiveText| *None* |Source - Active status: Is this user active, and should be able to log in?|  |
|source/contactAssociate/portraitThumbnail| *None* |Source - Person image: Person image|  |
|source/contactAssociate/otherGroups| *None* |Source - Other groups: Other groups|  |
|source/contactAssociate/userName| *None* |Source - User name: User name|  |
|source/contactAssociate/personEmail| *None* |Source - E-mail|  |
|source/contactInterestIds| *None* |Source - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|source/contactUdef/SuperOffice:1| *None* |Source - companyshorttext: tooltipshorttext|  |
|source/contactUdef/SuperOffice:2| *None* |Source - companylongtext: tooltiplongtext|  |
|source/contactUdef/SuperOffice:3| *None* |Source - companynumber|  |
|source/contactUdef/SuperOffice:4| *None* |Source - companydate|  |
|source/contactUdef/SuperOffice:5| *None* |Source - companyunlimiteddate: tooltipunlimiteddate|  |
|source/contactUdef/SuperOffice:6| *None* |Source - companycheckbox|  |
|source/contactUdef/SuperOffice:7| *None* |Source - companydropdownlistbox|  |
|source/contactUdef/SuperOffice:8| *None* |Source - companydecimal|  |
|source/contactUdef/SuperOffice:9| *None* |Source - page1saleonly|  |
|source/contactUdef/SuperOffice:10| *None* |Source - page1marketingonly|  |
|source/contactUdef/SuperOffice:11| *None* |Source - page1adminonly|  |
|source/contactUdef/SuperOffice:12| *None* |Source - Udlist one: Static tooltip for udlist one|  |
|source/contactUdef/SuperOffice:13| *None* |Source - Udlist two: Static tooltip for udlist two|  |
|source/NumberOfActivities| *None* |Source - Number of activities|  |
|source/NumberOfActivitiesInPeriod| *None* |Source - Number of activities in last 90 days|  |
|source/NumberOfNotCompletedActivities| *None* |Source - Number of non-completed activities|  |
|source/NumberOfNotCompletedActivitiesInPeriod| *None* |Source - Number of non-completed activities in last 90 days|  |
|source/LastActivity| *None* |Source - Date of last activity|  |
|source/LastCompletedActivity| *None* |Source - Date of last completed activity|  |
|source/LastDoByActivity| *None* |Source - Date of last non-completed activity|  |
|source/NumberOfSales| *None* |Source - Number of sales|  |
|source/NumberOfSalesInPeriod| *None* |Source - Number of sales in last 90 days|  |
|source/NumberOfNotCompletedSales| *None* |Source - Number of non-completed sales|  |
|source/NumberOfNotCompletedSalesInPeriod| *None* |Source - Number of non-completed sales in last 90 days|  |
|source/LastSale| *None* |Source - Date of last sale|  |
|source/LastCompletedSale| *None* |Source - Date of last completed sale|  |
|source/LastDoBySale| *None* |Source - Date of last non-completed sale|  |
|source/NumberOfTickets| *None* |Source - Number of requests|  |
|source/NumberOfTicketsInPeriod| *None* |Source - Number of requests in last 90 days|  |
|source/NumberOfNotCompletedTickets| *None* |Source - Number of non-completed requests|  |
|source/NumberOfNotCompletedTicketsInPeriod| *None* |Source - Number of non-completed requests in last 90 days|  |
|source/LastTicket| *None* |Source - Date of last request|  |
|source/LastCompletedTicket| *None* |Source - Date of last completed request|  |
|source/LastDoByTicket| *None* |Source - Date of last non-completed request|  |
|source/SaintStatus1| *None* |Source - Neglected customer|  |
|source/SaintStatus2| *None* |Source - C-company|  |
|source/saintSaleStatus| *None* |Source - With status|  |
|source/saintAmountClass| *None* |Source - Amount class|  |
|source/saintActivityType| *None* |Source - SAINT type|  |
|source/saintDirection| *None* |Source - Direction|  |
|source/saintIntention| *None* |Source - Intention|  |
|source/saintTicketStatus| *None* |Source - Status|  |
|source/saintTicketCategory| *None* |Source - Category|  |

## Sample

```http!
GET /api/v1/archive/Relation?$select=target/LastCompletedTicket,isActiveText,target/mrMrs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

