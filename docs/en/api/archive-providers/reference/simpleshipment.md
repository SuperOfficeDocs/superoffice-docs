---
uid: simpleshipment
title: simpleshipment
description: Archive provider for the list of mailings
keywords: simpleshipment archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "simpleshipment"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SimpleShipmentProvider">SuperOffice.CRM.ArchiveLists.SimpleShipmentProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the list of mailings

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|All|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|mailingId|int|ID: Displays the ID of the mailing| x |
|mailingSelectionId|int|Selection ID: The database ID of the selection| x |
|mailingDescription|string|Name: Displays the name of the mailing| x |
|mailingSent|listAny|Sent: Displays the sent status of the mailing| x |
|mailingSimpleStatus|listAny|Status: Status| x |
|mailingEndDate|date|Date sent: Displays the date when the mailing was sent (completed)| x |
|mailingType|listAny|Type: Display the type of the mailing| x |
|mailingSubscriptionType|listAny|Subscription type: The subscription type for a mailing| x |
|mailingSentTo|int|Sent to: Displays to whom the mailing was sent| x |
|mailingOwner|associate|Owner: Displays the owner of the mailing| x |
|mailingFrom|string|From: Mailing from| x |
|mailingReplyTo|string|To: To| x |
|mailingSentCount|int|Number sent: Number of sent mailings| x |
|mailingOpenRate|decimal|Open rate: The open rate for a mailing| x |
|mailingClickRate|decimal|Click-through rate: Mailing click-through rate| x |
|mailingBounceRate|decimal|Bounce rate: Mailing bounce rate| x |
|mailingDeleted|bool|Deleted: Deleted|  |
|recipientStatus|listAny|Recipient status: Status of mailing recipient|  |
|icon| *None* |Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|type|listAny|Type: Displays the type of an activity| x |
|text|positiveString|Text: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|projectId|listAny|Project ID: Database ID of project record| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|mailingAddr/mailingAddrId|int|!!!Mailing addr Id: !!!Mailing addr Id Tooltip| x |
|mailingAddr/contact/contactId|int|Company - Company ID: Database ID of company| x |
|mailingAddr/contact/name|stringorPK|Company - Company name| x |
|mailingAddr/contact/department|string|Company - Department| x |
|mailingAddr/contact/nameDepartment| *None* |Company - Company: Displays the company an activity is linked to| x |
|mailingAddr/contact/hasInfoText|bool|Company - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|mailingAddr/contact/hasInterests|bool|Company - Has interests: Displays an Icon indicating if the contact has active interests| x |
|mailingAddr/contact/associateId|associate|Company - Our contact: Displays our contact| x |
|mailingAddr/contact/category|listAny|Company - Category| x |
|mailingAddr/contact/business|listAny|Company - Business| x |
|mailingAddr/contact/country|listAny|Company - Country: This criterion corresponds to the Country field on the Company card.| x |
|mailingAddr/contact/countryId|int|Company - Country ID: Country ID| x |
|mailingAddr/contact/number|string|Company - Number| x |
|mailingAddr/contact/code|string|Company - Code| x |
|mailingAddr/contact/orgnr|string|Company - VAT No.| x |
|mailingAddr/contact/stop|bool|Company - Stop| x |
|mailingAddr/contact/contactNoMail|bool|Company - No mailings (company)| x |
|mailingAddr/contact/updatedBy|associate|Company - Updated by: The user who last updated the data| x |
|mailingAddr/contact/updatedByFullName|associate|Company - Updated by - Full name: The user who last updated the data| x |
|mailingAddr/contact/updatedDate|date|Company - Updated: The date/time the data was last updated in UTC.| x |
|mailingAddr/contact/registeredBy|associate|Company - Registered by: The user who registered the data| x |
|mailingAddr/contact/registeredByFullName|associate|Company - Registered by - Full name: The user who registered the data| x |
|mailingAddr/contact/registeredDate|date|Company - Registered date: The date/time the data was registered in UTC.| x |
|mailingAddr/contact/contactSource|listAny|Company - Source: Source (Company)| x |
|mailingAddr/contact/contactDeleted|bool|Company - Deleted: Deleted| x |
|mailingAddr/contact/phone/formattedNumber|string|Company - Phone: Displays phone number|  |
|mailingAddr/contact/activeErpLinks|bool|Company - ERP connected: Is there an active ERP Sync?| x |
|mailingAddr/contact/deletedDate|datetime|Company - Deleted date: Deleted date|  |
|mailingAddr/contact/mainContact| *None* |Company - Main contact: Main contact for this company| x |
|mailingAddr/contact/contactPhone/formattedNumber|string|Company - Telephone - Phone: Displays phone number|  |
|mailingAddr/contact/contactPhone/description|string|Company - Telephone - Description: Phone number description| x |
|mailingAddr/contact/contactFax/formattedNumber|string|Company - Fax - Phone: Displays phone number|  |
|mailingAddr/contact/contactFax/description|string|Company - Fax - Description: Phone number description| x |
|mailingAddr/contact/searchPhone/formattedNumber|string|Company - Searchphone - Phone: Displays phone number|  |
|mailingAddr/contact/searchPhone/description|string|Company - Searchphone - Description: Phone number description| x |
|mailingAddr/contact/email/emailProtocol|string|Company - Protocol: E-mail protocol, such as SMTP| x |
|mailingAddr/contact/email/emailAddress|string|Company - E-mail| x |
|mailingAddr/contact/email/emailDescription|string|Company - Description| x |
|mailingAddr/contact/email/emailId|int|Company - ID| x |
|mailingAddr/contact/email/emailLastSent|datetime|Company - Last sent: The date and time an e-mail was last sent to this address| x |
|mailingAddr/contact/email/emailBounceCount|int|Company - Bounce count: Bounce count for this e-mail address| x |
|mailingAddr/contact/email/emailLastBounce|datetime|Company - Last bounce: Date and time for last bounce to this e-mail address| x |
|mailingAddr/contact/email/emailHasBounced|bool|Company - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|mailingAddr/contact/postAddress/addressId|int|Company - Postal address - Address ID: Database ID for the address record| x |
|mailingAddr/contact/postAddress/line1|string|Company - Postal address - Address 1: First line of the address| x |
|mailingAddr/contact/postAddress/line2|string|Company - Postal address - Address 2: Second line of the address| x |
|mailingAddr/contact/postAddress/line3|string|Company - Postal address - Address 3: Third line of the address| x |
|mailingAddr/contact/postAddress/county|string|Company - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|mailingAddr/contact/postAddress/city|string|Company - Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|mailingAddr/contact/postAddress/zip|string|Company - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|mailingAddr/contact/postAddress/state|string|Company - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|mailingAddr/contact/postAddress/wgs84latitude|decimal|Company - Postal address - Latitude: Latitude| x |
|mailingAddr/contact/postAddress/wgs84longitude|decimal|Company - Postal address - Longitude: Longitude| x |
|mailingAddr/contact/postAddress/formattedAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/postAddress/formattedMultiLineAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/streetAddress/addressId|int|Company - Street address - Address ID: Database ID for the address record| x |
|mailingAddr/contact/streetAddress/line1|string|Company - Street address - Address 1: First line of the address| x |
|mailingAddr/contact/streetAddress/line2|string|Company - Street address - Address 2: Second line of the address| x |
|mailingAddr/contact/streetAddress/line3|string|Company - Street address - Address 3: Third line of the address| x |
|mailingAddr/contact/streetAddress/county|string|Company - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|mailingAddr/contact/streetAddress/city|string|Company - Street address - City: This criterion corresponds to the City field on the Company card.| x |
|mailingAddr/contact/streetAddress/zip|string|Company - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|mailingAddr/contact/streetAddress/state|string|Company - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|mailingAddr/contact/streetAddress/wgs84latitude|decimal|Company - Street address - Latitude: Latitude| x |
|mailingAddr/contact/streetAddress/wgs84longitude|decimal|Company - Street address - Longitude: Longitude| x |
|mailingAddr/contact/streetAddress/formattedAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/contact/streetAddress/formattedMultiLineAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/restrictionAddress/addressId|int|Company - Search address - Address ID: Database ID for the address record| x |
|mailingAddr/contact/restrictionAddress/line1|string|Company - Search address - Address 1: First line of the address| x |
|mailingAddr/contact/restrictionAddress/line2|string|Company - Search address - Address 2: Second line of the address| x |
|mailingAddr/contact/restrictionAddress/line3|string|Company - Search address - Address 3: Third line of the address| x |
|mailingAddr/contact/restrictionAddress/county|string|Company - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|mailingAddr/contact/restrictionAddress/city|string|Company - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|mailingAddr/contact/restrictionAddress/zip|string|Company - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|mailingAddr/contact/restrictionAddress/state|string|Company - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|mailingAddr/contact/restrictionAddress/wgs84latitude|decimal|Company - Search address - Latitude: Latitude| x |
|mailingAddr/contact/restrictionAddress/wgs84longitude|decimal|Company - Search address - Longitude: Longitude| x |
|mailingAddr/contact/restrictionAddress/formattedAddress| *None* |Company - Search address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/restrictionAddress/formattedMultiLineAddress| *None* |Company - Search address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/url/URLAddress|string|Company - URL| x |
|mailingAddr/contact/url/URLDescription|string|Company - Description| x |
|mailingAddr/contact/contactAssociate/firstName|string|Company - First name: Displays the contact's first name| x |
|mailingAddr/contact/contactAssociate/lastName|string|Company - Last name: Displays the contact's last name| x |
|mailingAddr/contact/contactAssociate/middleName|string|Company - Middle Name: Displays the contact's middle name.| x |
|mailingAddr/contact/contactAssociate/fullName|string|Company - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|mailingAddr/contact/contactAssociate/contactId|int|Company - Company ID: Database ID of the company the user belongs to|  |
|mailingAddr/contact/contactAssociate/personId|int|Company - Contact ID: Database ID of the contact row|  |
|mailingAddr/contact/contactAssociate/mrMrs|string|Company - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|mailingAddr/contact/contactAssociate/title|string|Company - Title: Displays whether the contact is addressed as Mr or Ms| x |
|mailingAddr/contact/contactAssociate/associateDbId|associate|Company - ID| x |
|mailingAddr/contact/contactAssociate/contactName|string|Company - Owning company: Name of the company the user belongs to| x |
|mailingAddr/contact/contactAssociate/contactDepartment|string|Company - Owning department: Name of the department at the company the user belongs to| x |
|mailingAddr/contact/contactAssociate/usergroup|userGroup|Company - Primary group: The user's primary user group| x |
|mailingAddr/contact/contactAssociate/contactFullName|string|Company - Owner: Name and department of the company the user belongs to| x |
|mailingAddr/contact/contactAssociate/contactCategory|listAny|Company - Category: Category| x |
|mailingAddr/contact/contactAssociate/role|listAny|Company - Role: Role| x |
|mailingAddr/contact/contactAssociate/assocName|associate|Company - User ID: User ID| x |
|mailingAddr/contact/contactAssociate/assocTooltip|string|Company - Description: Description|  |
|mailingAddr/contact/contactAssociate/assocType|listAny|Company - Type: Type of user: associate, external user, system user, anonymous account| x |
|mailingAddr/contact/contactAssociate/ejUserId|int|Company - Service user ID: The database ID of a Service user|  |
|mailingAddr/contact/contactAssociate/simultaneousEjUser|bool|Company - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/contact/contactAssociate/ejDisplayName|string|Company - Nick name: User's nick name in Service| x |
|mailingAddr/contact/contactAssociate/ejStatus|int|Company - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/contact/contactAssociate/credentialType| *None* |Company - Auth. type: What type of credentials to use when this user logs in| x |
|mailingAddr/contact/contactAssociate/credentialDisplayValue| *None* |Company - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|mailingAddr/contact/contactAssociate/isActive|bool|Company - Active: Is this user active, and should be able to log in?| x |
|mailingAddr/contact/contactAssociate/isActiveText|bool|Company - Active status: Is this user active, and should be able to log in?| x |
|mailingAddr/contact/contactAssociate/portraitThumbnail| *None* |Company - Person image: Person image|  |
|mailingAddr/contact/contactAssociate/otherGroups|userGroup|Company - Other groups: Other groups|  |
|mailingAddr/contact/contactAssociate/userName|string|Company - User name: User name| x |
|mailingAddr/contact/contactAssociate/personEmail|string|Company - E-mail| x |
|mailingAddr/contact/contactInterestIds|listInterest|Company - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|mailingAddr/contact/contactUdef/SuperOffice:1|string|Company - companyshorttext: tooltipshorttext| x |
|mailingAddr/contact/contactUdef/SuperOffice:2|string|Company - companylongtext: tooltiplongtext| x |
|mailingAddr/contact/contactUdef/SuperOffice:3|int|Company - companynumber| x |
|mailingAddr/contact/contactUdef/SuperOffice:4|date|Company - companydate| x |
|mailingAddr/contact/contactUdef/SuperOffice:5|unlimitedDate|Company - companyunlimiteddate: tooltipunlimiteddate| x |
|mailingAddr/contact/contactUdef/SuperOffice:6|bool|Company - companycheckbox| x |
|mailingAddr/contact/contactUdef/SuperOffice:7|listAny|Company - companydropdownlistbox| x |
|mailingAddr/contact/contactUdef/SuperOffice:8|decimal|Company - companydecimal| x |
|mailingAddr/contact/contactUdef/SuperOffice:9|string|Company - page1saleonly| x |
|mailingAddr/contact/contactUdef/SuperOffice:10|string|Company - page1marketingonly| x |
|mailingAddr/contact/contactUdef/SuperOffice:11|string|Company - page1adminonly| x |
|mailingAddr/contact/contactUdef/SuperOffice:12|listAny|Company - Udlist one: Static tooltip for udlist one| x |
|mailingAddr/contact/contactUdef/SuperOffice:13|listAny|Company - Udlist two: Static tooltip for udlist two| x |
|mailingAddr/contact/contactExtra/x\_contact\_integer|int|Company - Extra Integer: Custom integer field| x |
|mailingAddr/contact/contactExtra/x\_contact\_hidden\_integer|int|Company - Extra hidden integer: Custom integer field - hidden| x |
|mailingAddr/contact/contactExtra/x\_contact\_default\_integer|int|Company - Extra Default Integer: Custom integer field with default value 123.| x |
|mailingAddr/contact/contactExtra/x\_contact\_float|decimal|Company - Extra Float: Custom float field with 3 decimals| x |
|mailingAddr/contact/contactExtra/x\_contact\_longtext|string|Company - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|mailingAddr/contact/contactExtra/x\_contact\_dropdown|listAny|Company - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|mailingAddr/contact/contactExtra/x\_contact\_date|date|Company - Extra date: Custom date field. User current as default.| x |
|mailingAddr/contact/contactExtra/x\_contact\_datetime|datetime|Company - Extra DateTime: Custom Date Time field. No default value. External| x |
|mailingAddr/contact/contactExtra/x\_contact\_time| *None* |Company - Extra time: Custom time field.| x |
|mailingAddr/contact/contactExtra/x\_contact\_boolean|bool|Company - Extra boolean: Custom boolean field.| x |
|mailingAddr/contact/contactExtra/x\_contact\_timespan|timeSpan|Company - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|mailingAddr/contact/contactExtra/x\_contact\_shorttext|string|Company - Extra short text: Custom short text field. Keep HTML tags.| x |
|mailingAddr/contact/contactExtra/x\_contact\_short\_dropdown|listAny|Company - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|mailingAddr/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Company - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|mailingAddr/contact/contactExtra/x\_contact\_request\_relation|stringorPK|Company - Extra Request relation: Request relation on company| x |
|mailingAddr/contact/contactExtra/x\_contact\_contact|stringorPK|Company - Extra contact relation: Contact relation on company| x |
|mailingAddr/contact/NumberOfActivities|int|Company - Number of activities|  |
|mailingAddr/contact/NumberOfActivitiesInPeriod|int|Company - Number of activities in last 90 days|  |
|mailingAddr/contact/NumberOfNotCompletedActivities|int|Company - Number of non-completed activities|  |
|mailingAddr/contact/NumberOfNotCompletedActivitiesInPeriod|int|Company - Number of non-completed activities in last 90 days|  |
|mailingAddr/contact/LastActivity|date|Company - Date of last activity|  |
|mailingAddr/contact/LastCompletedActivity|date|Company - Date of last completed activity|  |
|mailingAddr/contact/LastDoByActivity|date|Company - Date of last non-completed activity|  |
|mailingAddr/contact/NumberOfSales|int|Company - Number of sales|  |
|mailingAddr/contact/NumberOfSalesInPeriod|int|Company - Number of sales in last 90 days|  |
|mailingAddr/contact/NumberOfNotCompletedSales|int|Company - Number of non-completed sales|  |
|mailingAddr/contact/NumberOfNotCompletedSalesInPeriod|int|Company - Number of non-completed sales in last 90 days|  |
|mailingAddr/contact/LastSale|date|Company - Date of last sale|  |
|mailingAddr/contact/LastCompletedSale|date|Company - Date of last completed sale|  |
|mailingAddr/contact/LastDoBySale|date|Company - Date of last non-completed sale|  |
|mailingAddr/contact/NumberOfTickets|int|Company - Number of requests|  |
|mailingAddr/contact/NumberOfTicketsInPeriod|int|Company - Number of requests in last 90 days|  |
|mailingAddr/contact/NumberOfNotCompletedTickets|int|Company - Number of non-completed requests|  |
|mailingAddr/contact/NumberOfNotCompletedTicketsInPeriod|int|Company - Number of non-completed requests in last 90 days|  |
|mailingAddr/contact/LastTicket|date|Company - Date of last request|  |
|mailingAddr/contact/LastCompletedTicket|date|Company - Date of last completed request|  |
|mailingAddr/contact/LastDoByTicket|date|Company - Date of last non-completed request|  |
|mailingAddr/contact/SaintStatus1|saintStatus|Company - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|mailingAddr/contact/SaintStatus2|saintStatus|Company - C-company: Kundens navn starter med bokstaven C|  |
|mailingAddr/contact/saintSaleStatus|listAny|Company - With status|  |
|mailingAddr/contact/saintAmountClass|listAny|Company - Amount class|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/contact/saintActivityType|listAny|Company - SAINT type|  |
|mailingAddr/contact/saintDirection|listAny|Company - Direction|  |
|mailingAddr/contact/saintIntention|listAny|Company - Intention|  |
|mailingAddr/contact/saintTicketStatus|listAny|Company - Status|  |
|mailingAddr/contact/saintTicketCategory|listAny|Company - Category|  |
|mailingAddr/person/personId|int|Contact - DB ID: Displays the database ID of a contact| x |
|mailingAddr/person/firstName|string|Contact - First name: Displays the contact's first name| x |
|mailingAddr/person/lastName|string|Contact - Last name: Displays the contact's last name| x |
|mailingAddr/person/middleName|string|Contact - Middle name: Displays the contact's middle name.| x |
|mailingAddr/person/fullName|stringorPK|Contact - Contact: Displays the contact to which an item is linked| x |
|mailingAddr/person/contactId|int|Contact - Company ID: Database ID of company| x |
|mailingAddr/person/hasInfoText|bool|Contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|mailingAddr/person/hasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|mailingAddr/person/personHasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|mailingAddr/person/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|mailingAddr/person/position|listAny|Contact - Position| x |
|mailingAddr/person/personNumber|string|Contact - Number: Displays the contact's number| x |
|mailingAddr/person/title|string|Contact - Title: Displays the contact's job title| x |
|mailingAddr/person/personCountry|listAny|Contact - Country: Country| x |
|mailingAddr/person/personCountryId|int|Contact - Country ID: Country ID| x |
|mailingAddr/person/personNoMail|bool|Contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|mailingAddr/person/rank|int|Contact - Rank: Displays a contact's current rank| x |
|mailingAddr/person/birthdate| *None* |Contact - Birthdate: Displays the contact's date of birth|  |
|mailingAddr/person/associateType| *None* |Contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|mailingAddr/person/useAsMailingAddress|bool|Contact - Use as postal address: Use as postal address| x |
|mailingAddr/person/personSource|listAny|Contact - Source: Source (Contact)| x |
|mailingAddr/person/retired|bool|Contact - Former employee: Indicates whether the contact has retired/left the company| x |
|mailingAddr/person/birthYear|int|Contact - Birth year: Displays contact's birth year| x |
|mailingAddr/person/birthMonth|int|Contact - Birth month: Displays contact's birth month| x |
|mailingAddr/person/birthDay|int|Contact - Birth day: Displays contact's birth day (day of month)| x |
|mailingAddr/person/kanaFirstName|string|Contact - First name, kana: Contact's first name, in kana alphabet| x |
|mailingAddr/person/kanaLastName|string|Contact - Last name, kana: Contact's last name, in kana alphabet| x |
|mailingAddr/person/personUpdatedBy|associate|Contact - Updated by: The user who last updated the data| x |
|mailingAddr/person/personUpdatedByFullName|associate|Contact - Updated by - Full name: The user who last updated the data| x |
|mailingAddr/person/personUpdatedDate|date|Contact - Updated: The date/time the data was last updated in UTC.| x |
|mailingAddr/person/personRegisteredBy|associate|Contact - Registered by: The user who registered the data| x |
|mailingAddr/person/personRegisteredByFullName|associate|Contact - Registered by - Full name: The user who registered the data| x |
|mailingAddr/person/personRegisteredDate|date|Contact - Registered date: The date/time the data was registered in UTC.| x |
|mailingAddr/person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/personActiveErpLinks|bool|Contact - ERP connected: Is there an active ERP Sync?| x |
|mailingAddr/person/ticketPriority|listAny|Contact - Service priority: Default service priority for this contact| x |
|mailingAddr/person/supportLanguage|listAny|Contact - Preferred language: Preferred language used for reply templates and more| x |
|mailingAddr/person/supportAssociate|associate|Contact - Our service contact: Default service contact for this contact| x |
|mailingAddr/person/supportAssociateFullName|associate|Contact - Our service contact - Full name: Default service contact for this contact| x |
|mailingAddr/person/personAssociateId|associate|Contact - Our contact: Displays our contact| x |
|mailingAddr/person/personAssociateFullName|associate|Contact - Our contact - Full name: Displays our contact| x |
|mailingAddr/person/personCategory|listAny|Contact - Category| x |
|mailingAddr/person/personBusiness|listAny|Contact - Business| x |
|mailingAddr/person/personDeletedDate|datetime|Contact - Deleted date: Deleted date|  |
|mailingAddr/person/hasCompany|bool|Contact - Has company: The contact is associated with a company| x |
|mailingAddr/person/isProjectMember|bool|Contact - Is project member: This person is a project member| x |
|mailingAddr/person/isStakeholder|bool|Contact - Is stakeholder: This person is a sale stakeholder| x |
|mailingAddr/person/phone/formattedNumber|string|Contact - Phone: Displays phone number|  |
|mailingAddr/person/personDirectPhone/formattedNumber|string|Contact - Direct - Phone: Displays phone number|  |
|mailingAddr/person/personDirectPhone/description|string|Contact - Direct - Description: Phone number description| x |
|mailingAddr/person/personMobilePhone/formattedNumber|string|Contact - Mobile - Phone: Displays phone number|  |
|mailingAddr/person/personMobilePhone/description|string|Contact - Mobile - Description: Phone number description| x |
|mailingAddr/person/personPrivate/formattedNumber|string|Contact - Private - Phone: Displays phone number|  |
|mailingAddr/person/personPrivate/description|string|Contact - Private - Description: Phone number description| x |
|mailingAddr/person/personPager/formattedNumber|string|Contact - Other - Phone: Displays phone number|  |
|mailingAddr/person/personPager/description|string|Contact - Other - Description: Phone number description| x |
|mailingAddr/person/personDirectFax/formattedNumber|string|Contact - Fax - Phone: Displays phone number|  |
|mailingAddr/person/personDirectFax/description|string|Contact - Fax - Description: Phone number description| x |
|mailingAddr/person/searchPhone/formattedNumber|string|Contact - Phone: Displays phone number|  |
|mailingAddr/person/searchPhone/description|string|Contact - Description: Phone number description| x |
|mailingAddr/person/personInfo/textId|int|Contact - Text ID| x |
|mailingAddr/person/personInfo/infoText|positiveString|Contact - Information: Displays the text entered in the description field| x |
|mailingAddr/person/email/emailProtocol|string|Contact - Protocol: E-mail protocol, such as SMTP| x |
|mailingAddr/person/email/emailAddress|string|Contact - E-mail| x |
|mailingAddr/person/email/emailDescription|string|Contact - Description| x |
|mailingAddr/person/email/emailId|int|Contact - ID| x |
|mailingAddr/person/email/emailLastSent|datetime|Contact - Last sent: The date and time an e-mail was last sent to this address| x |
|mailingAddr/person/email/emailBounceCount|int|Contact - Bounce count: Bounce count for this e-mail address| x |
|mailingAddr/person/email/emailLastBounce|datetime|Contact - Last bounce: Date and time for last bounce to this e-mail address| x |
|mailingAddr/person/email/emailHasBounced|bool|Contact - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|mailingAddr/person/personUrl/URLAddress|string|Contact - URL| x |
|mailingAddr/person/personUrl/URLDescription|string|Contact - Description| x |
|mailingAddr/person/personAddress/addressId|int|Contact - Contact address - Address ID: Database ID for the address record| x |
|mailingAddr/person/personAddress/line1|string|Contact - Contact address - Address 1: First line of the address| x |
|mailingAddr/person/personAddress/line2|string|Contact - Contact address - Address 2: Second line of the address| x |
|mailingAddr/person/personAddress/line3|string|Contact - Contact address - Address 3: Third line of the address| x |
|mailingAddr/person/personAddress/county|string|Contact - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|mailingAddr/person/personAddress/city|string|Contact - Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|mailingAddr/person/personAddress/zip|string|Contact - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|mailingAddr/person/personAddress/state|string|Contact - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|mailingAddr/person/personAddress/wgs84latitude|decimal|Contact - Contact address - Latitude: Latitude| x |
|mailingAddr/person/personAddress/wgs84longitude|decimal|Contact - Contact address - Longitude: Longitude| x |
|mailingAddr/person/personAddress/formattedAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/personAddress/formattedMultiLineAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/restrictionAddress/addressId|int|Contact - Search address - Address ID: Database ID for the address record| x |
|mailingAddr/person/restrictionAddress/line1|string|Contact - Search address - Address 1: First line of the address| x |
|mailingAddr/person/restrictionAddress/line2|string|Contact - Search address - Address 2: Second line of the address| x |
|mailingAddr/person/restrictionAddress/line3|string|Contact - Search address - Address 3: Third line of the address| x |
|mailingAddr/person/restrictionAddress/county|string|Contact - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|mailingAddr/person/restrictionAddress/city|string|Contact - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|mailingAddr/person/restrictionAddress/zip|string|Contact - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|mailingAddr/person/restrictionAddress/state|string|Contact - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|mailingAddr/person/restrictionAddress/wgs84latitude|decimal|Contact - Search address - Latitude: Latitude| x |
|mailingAddr/person/restrictionAddress/wgs84longitude|decimal|Contact - Search address - Longitude: Longitude| x |
|mailingAddr/person/restrictionAddress/formattedAddress| *None* |Contact - Search address - {formattedAddress}: {formattedAddress}|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/person/restrictionAddress/formattedMultiLineAddress| *None* |Contact - Search address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/personInterestIds|listInterest|Contact - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|mailingAddr/person/personUdef/SuperOffice:1|string|Contact - contactshorttext: tooltipshorttext| x |
|mailingAddr/person/personUdef/SuperOffice:2|string|Contact - contactlongtext: tooltiplongtext| x |
|mailingAddr/person/personUdef/SuperOffice:3|int|Contact - contactnumber| x |
|mailingAddr/person/personUdef/SuperOffice:4|date|Contact - contactdate| x |
|mailingAddr/person/personUdef/SuperOffice:5|unlimitedDate|Contact - contactunlimiteddate: tooltipunlimiteddate| x |
|mailingAddr/person/personUdef/SuperOffice:6|bool|Contact - contactcheckbox| x |
|mailingAddr/person/personUdef/SuperOffice:7|listAny|Contact - contactdropdownlistbox| x |
|mailingAddr/person/personUdef/SuperOffice:8|decimal|Contact - contactdecimal| x |
|mailingAddr/person/personUdef/SuperOffice:9|string|Contact - page1saleonly| x |
|mailingAddr/person/personUdef/SuperOffice:10|string|Contact - page1marketingonly| x |
|mailingAddr/person/personUdef/SuperOffice:11|string|Contact - page1adminonly| x |
|mailingAddr/person/personExtra/x\_person\_integer|int|Contact - Extra Integer: Custom person integer| x |
|mailingAddr/person/personExtra/x\_person\_hidden\_integer|int|Contact - Extra hidden integer: Custom integer field that is hidden| x |
|mailingAddr/person/personExtra/x\_person\_float|decimal|Contact - Extra float: Custom float field| x |
|mailingAddr/person/personExtra/x\_person\_longtext|string|Contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|mailingAddr/person/personExtra/x\_person\_date|date|Contact - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|mailingAddr/person/personExtra/x\_person\_datetime|datetime|Contact - Extra DateTime: Custom person date and time field. No default| x |
|mailingAddr/person/personExtra/x\_person\_time| *None* |Contact - Extra time: Custom time field on person. Current time as default| x |
|mailingAddr/person/personExtra/x\_person\_boolean|bool|Contact - Extra Boolean: Custom boolean field on person. Default checked| x |
|mailingAddr/person/personExtra/x\_person\_timespan|timeSpan|Contact - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|mailingAddr/person/personExtra/x\_person\_shorttext|string|Contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|mailingAddr/person/personExtra/x\_person\_shorttext\_list|listAny|Contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|mailingAddr/person/personExtra/x\_person\_user\_relation|associate|Contact - Extra user relation: Custom person-user relation field| x |
|mailingAddr/person/personExtra/x\_person\_category\_relation|listAny|Contact - Extra category relation: Custom person-category relation| x |
|mailingAddr/person/personExtra/x\_person\_priority\_relation|listAny|Contact - Extra priority relation: Custom person-priority relation| x |
|mailingAddr/person/personExtra/x\_person\_request\_relation|stringorPK|Contact - Extra request relation: Request relation on contact| x |
|mailingAddr/person/personExtra/x\_person\_appointment\_relation|stringorPK|Contact - Extra appointment relation: Appointment relation on person| x |
|mailingAddr/person/personExtra/x\_person\_contact\_relation|stringorPK|Contact - Extra company relation: Company relation on contact| x |
|mailingAddr/person/personExtra/y\_rental/id|int|Contact - Rental - id: Displays the row's primary key (y\_rental)| x |
|mailingAddr/person/personExtra/y\_rental/x\_start|date|Contact - Rental - Start rental| x |
|mailingAddr/person/personExtra/y\_rental/x\_end|date|Contact - Rental - End| x |
|mailingAddr/person/personExtra/y\_rental/x\_amount|int|Contact - Rental - Amount: Number to rent. Default = 1| x |
|mailingAddr/person/personExtra/y\_rental/x\_contact|stringorPK|Contact - Rental - Renter: Company that rents equipment| x |
|mailingAddr/person/personExtra/y\_rental/y\_equipment/x\_name|string|Contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|mailingAddr/person/personAssociate/firstName|string|Contact - First name: Displays the contact's first name| x |
|mailingAddr/person/personAssociate/lastName|string|Contact - Last name: Displays the contact's last name| x |
|mailingAddr/person/personAssociate/middleName|string|Contact - Middle Name: Displays the contact's middle name.| x |
|mailingAddr/person/personAssociate/fullName|string|Contact - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|mailingAddr/person/personAssociate/contactId|int|Contact - Company ID: Database ID of the company the user belongs to|  |
|mailingAddr/person/personAssociate/personId|int|Contact - Contact ID: Database ID of the contact row|  |
|mailingAddr/person/personAssociate/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|mailingAddr/person/personAssociate/title|string|Contact - Title: Displays whether the contact is addressed as Mr or Ms| x |
|mailingAddr/person/personAssociate/associateDbId|associate|Contact - ID| x |
|mailingAddr/person/personAssociate/contactName|string|Contact - Owning company: Name of the company the user belongs to| x |
|mailingAddr/person/personAssociate/contactDepartment|string|Contact - Owning department: Name of the department at the company the user belongs to| x |
|mailingAddr/person/personAssociate/usergroup|userGroup|Contact - Primary group: The user's primary user group| x |
|mailingAddr/person/personAssociate/contactFullName|string|Contact - Owner: Name and department of the company the user belongs to| x |
|mailingAddr/person/personAssociate/contactCategory|listAny|Contact - Category: Category| x |
|mailingAddr/person/personAssociate/role|listAny|Contact - Role: Role| x |
|mailingAddr/person/personAssociate/assocName|associate|Contact - User ID: User ID| x |
|mailingAddr/person/personAssociate/assocTooltip|string|Contact - Description: Description|  |
|mailingAddr/person/personAssociate/assocType|listAny|Contact - Type: Type of user: associate, external user, system user, anonymous account| x |
|mailingAddr/person/personAssociate/ejUserId|int|Contact - Service user ID: The database ID of a Service user|  |
|mailingAddr/person/personAssociate/simultaneousEjUser|bool|Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/person/personAssociate/ejDisplayName|string|Contact - Nick name: User's nick name in Service| x |
|mailingAddr/person/personAssociate/ejStatus|int|Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/person/personAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in| x |
|mailingAddr/person/personAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|mailingAddr/person/personAssociate/isActive|bool|Contact - Active: Is this user active, and should be able to log in?| x |
|mailingAddr/person/personAssociate/isActiveText|bool|Contact - Active status: Is this user active, and should be able to log in?| x |
|mailingAddr/person/personAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/personAssociate/otherGroups|userGroup|Contact - Other groups: Other groups|  |
|mailingAddr/person/personAssociate/userName|string|Contact - User name: User name| x |
|mailingAddr/person/personAssociate/personEmail|string|Contact - E-mail| x |
|mailingAddr/person/correspondingAssociate/firstName|string|Contact - First name: Displays the contact's first name| x |
|mailingAddr/person/correspondingAssociate/lastName|string|Contact - Last name: Displays the contact's last name| x |
|mailingAddr/person/correspondingAssociate/middleName|string|Contact - Middle Name: Displays the contact's middle name.| x |
|mailingAddr/person/correspondingAssociate/fullName|string|Contact - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|mailingAddr/person/correspondingAssociate/contactId|int|Contact - Company ID: Database ID of the company the user belongs to|  |
|mailingAddr/person/correspondingAssociate/personId|int|Contact - Contact ID: Database ID of the contact row|  |
|mailingAddr/person/correspondingAssociate/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|mailingAddr/person/correspondingAssociate/title|string|Contact - Title: Displays whether the contact is addressed as Mr or Ms| x |
|mailingAddr/person/correspondingAssociate/associateDbId|associate|Contact - ID| x |
|mailingAddr/person/correspondingAssociate/contactName|string|Contact - Owning company: Name of the company the user belongs to| x |
|mailingAddr/person/correspondingAssociate/contactDepartment|string|Contact - Owning department: Name of the department at the company the user belongs to| x |
|mailingAddr/person/correspondingAssociate/usergroup|userGroup|Contact - Primary group: The user's primary user group| x |
|mailingAddr/person/correspondingAssociate/contactFullName|string|Contact - Owner: Name and department of the company the user belongs to| x |
|mailingAddr/person/correspondingAssociate/contactCategory|listAny|Contact - Category: Category| x |
|mailingAddr/person/correspondingAssociate/role|listAny|Contact - Role: Role| x |
|mailingAddr/person/correspondingAssociate/assocName|associate|Contact - User ID: User ID| x |
|mailingAddr/person/correspondingAssociate/assocTooltip|string|Contact - Description: Description|  |
|mailingAddr/person/correspondingAssociate/assocType|listAny|Contact - Type: Type of user: associate, external user, system user, anonymous account| x |
|mailingAddr/person/correspondingAssociate/ejUserId|int|Contact - Service user ID: The database ID of a Service user|  |
|mailingAddr/person/correspondingAssociate/simultaneousEjUser|bool|Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/person/correspondingAssociate/ejDisplayName|string|Contact - Nick name: User's nick name in Service| x |
|mailingAddr/person/correspondingAssociate/ejStatus|int|Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/person/correspondingAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in| x |
|mailingAddr/person/correspondingAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|mailingAddr/person/correspondingAssociate/isActive|bool|Contact - Active: Is this user active, and should be able to log in?| x |
|mailingAddr/person/correspondingAssociate/isActiveText|bool|Contact - Active status: Is this user active, and should be able to log in?| x |
|mailingAddr/person/correspondingAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/correspondingAssociate/otherGroups|userGroup|Contact - Other groups: Other groups|  |
|mailingAddr/person/correspondingAssociate/userName|string|Contact - User name: User name| x |
|mailingAddr/person/correspondingAssociate/personEmail|string|Contact - E-mail| x |
|mailingAddr/person/isMailingRecipient|bool|Contact - Is mailing recipient: isMailingRecipient| x |
|mailingAddr/person/hasStoreConsent|bool|Contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/withdrawnStoreConsent|bool|Contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/hasEmarketingConsent|bool|Contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/person/withdrawnEmarketingConsent|bool|Contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|mailingAddr/person/subscription|listAny|Contact - Subscription: Subscription for marketing| x |
|mailingAddr/person/legalBaseStore|listAny|Contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|mailingAddr/person/legalBaseEmarketing|listAny|Contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|mailingAddr/person/consentSourceStore|listAny|Contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|mailingAddr/person/consentSourceEmarketing|listAny|Contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
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
|associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|associate/contactCategory|listAny|Category: Category| x |
|associate/role|listAny|Role : Role| x |
|associate/assocName|associate|User ID : User ID| x |
|associate/assocTooltip|string|Description : Description|  |
|associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|associate/portraitThumbnail| *None* |Person image: Person image|  |
|associate/otherGroups|userGroup|Other groups: Other groups|  |
|associate/userName|string|User name: User name| x |
|associate/personEmail|string|E-mail| x |
|project/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|project/projectId|int|DB ID: Displays the database ID for a project row| x |
|project/name|stringorPK|Project name: Displays the Project's name| x |
|project/number|string|Number: Displays the project's number| x |
|project/type|listAny|Project type: Displays the project's type| x |
|project/status|listAny|Status: Displays the project's status| x |
|project/statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|project/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|project/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|project/icon| *None* |Category: Displays the icon for an activity type| x |
|project/text|string|Text: Displays a descriptive text for the item| x |
|project/description|string|Description : Description| x |
|project/updatedBy|associate|Updated by: The user who last updated the data| x |
|project/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|project/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|project/registeredBy|associate|Registered by: The user who registered the data| x |
|project/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|project/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|project/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|project/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|project/endDate|date|End date: End date of project| x |
|project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|project/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|project/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|project/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|project/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|project/projectEvent/eventDate|date|Event date: Event date| x |
|project/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|project/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|project/projectUrl/URLAddress|string|URL| x |
|project/projectUrl/URLDescription|string|Description| x |
|project/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|project/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|project/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|project/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|project/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|project/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|project/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/associateDbId|associate|ID| x |
|project/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|project/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|project/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|project/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|project/projectAssociate/contactCategory|listAny|Category: Category| x |
|project/projectAssociate/role|listAny|Role : Role| x |
|project/projectAssociate/assocName|associate|User ID : User ID| x |
|project/projectAssociate/assocTooltip|string|Description : Description|  |
|project/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|project/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|project/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|project/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|project/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|project/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|project/projectAssociate/userName|string|User name: User name| x |
|project/projectAssociate/personEmail|string|E-mail| x |
|project/projectUdef/SuperOffice:1|string|projectshorttext| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|project/projectUdef/SuperOffice:3|int|projectnumber| x |
|project/projectUdef/SuperOffice:4|date|projectdate| x |
|project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
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
|project/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|project/saintSaleStatus|listAny|With status|  |
|project/saintAmountClass|listAny|Amount class|  |
|project/saintActivityType|listAny|SAINT type|  |
|project/saintDirection|listAny|Direction|  |
|project/saintIntention|listAny|Intention|  |
|project/saintTicketStatus|listAny|Status|  |
|project/saintTicketCategory|listAny|Category|  |
|project/project/textId|int|Text ID| x |
|project/project/infoText|positiveString|Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/simpleshipment?$select=mailingAddr/contact/email/emailLastSent,mailingAddr/person/supportAssociateFullName,mailingAddr/person/searchPhone/formattedNumber,mailingAddr/person/correspondingAssociate/contactFullName,mailingAddr/person/correspondingAssociate/portraitThumbnail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

