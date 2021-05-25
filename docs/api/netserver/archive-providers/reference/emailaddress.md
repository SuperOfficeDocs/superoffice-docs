---
uid: EmailAddress
title: EmailAddress
description: Special purpose archive provider used to search for email addresses.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "EmailAddress"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "EmailAddress"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EMailAddressProvider">SuperOffice.CRM.ArchiveLists.EMailAddressProvider</see> inside NetServer's SODatabase assembly.

Special purpose archive provider used to search for email addresses.

This provider combines two subchannels, one for Person and one for Contact related addresses.
Each channel will match on either the email address itself, or some relevant naming information
(such as contact name or person name or whatever).

The resulting rows will have entity names reflecting the type of match, but the primary key will always be
the email_id.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"email"|[email]|
|"person"|Contacts|
|"contact"|Contact|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|emailMatch|string|emailMatch: Restriction only: (partial) email / person / contact to match|  |
|emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|emailAddress|string|E-mail| x |
|emailDescription|string|Description| x |
|emailId|int|ID| x |
|emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|personId| *None* |DB ID: Displays the database ID of a contact|  |
|firstName| *None* |First name: Displays the contact's first name|  |
|lastName| *None* |Last name: Displays the contact's last name|  |
|middleName| *None* |Middle name: Displays the contact's middle name.|  |
|fullName| *None* |Contact: Displays the contact to which an item is linked|  |
|fullNameWithContact| *None* |Contact and company: The fully formatted contact name, and full company name|  |
|contactId|int|Company ID: Database ID of company| x |
|hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|personHasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|position| *None* |Position|  |
|personNumber| *None* |Number: Displays the contact's number|  |
|title| *None* |Title: Displays the contact's job title|  |
|personCountry| *None* |Country: Country|  |
|personNoMail| *None* |No Mailings: Displays the contact's No Mailings checkbox|  |
|rank| *None* |Rank: Displays a contact's current rank|  |
|birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|useAsMailingAddress| *None* |Use as postal address: Use as postal address|  |
|personSource| *None* |Source: Source (Contact)|  |
|retired| *None* |Former employee: Indicates whether the contact has retired/left the company|  |
|birthYear| *None* |Birth year: Displays contact's birth year|  |
|birthMonth| *None* |Birth month: Displays contact's birth month|  |
|birthDay| *None* |Birth day: Displays contact's birth day (day of month)|  |
|kanaFirstName| *None* |First name, kana: Contact's first name, in kana alphabet|  |
|kanaLastName| *None* |Last name, kana: Contact's last name, in kana alphabet|  |
|personUpdatedBy| *None* |Updated by: The user who last updated the data|  |
|personUpdatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personRegisteredBy| *None* |Registered by: The user who registered the data|  |
|personRegisteredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|portraitThumbnail| *None* |Person image: Person image|  |
|personActiveErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|ticketPriority| *None* |Service priority: Default service priority for this contact|  |
|supportLanguage| *None* |Preferred language: Preferred language used for reply templates and more|  |
|supportAssociate| *None* |Our service contact: Default service contact for this contact|  |
|personAssociateId| *None* |Our contact: Displays our contact|  |
|personCategory| *None* |Category|  |
|personBusiness| *None* |Business|  |
|personDeletedDate| *None* |Deleted date: Deleted date|  |
|hasCompany| *None* |Has company: The contact is associated with a company|  |
|isProjectMember| *None* |Is project member: This person is a project member|  |
|isStakeholder| *None* |Is stakeholder: This person is a sale stakeholder|  |
|phone/formattedNumber|string|Phone : Displays phone number|  |
|who| *None* |Full name: Displays the contact's full name.| x |
|personDirectPhone/formattedNumber| *None* |Direct - Phone: Displays phone number|  |
|personDirectPhone/description| *None* |Direct - Description: Phone number description|  |
|personMobilePhone/formattedNumber| *None* |Mobile - Phone: Displays phone number|  |
|personMobilePhone/description| *None* |Mobile - Description: Phone number description|  |
|personPrivate/formattedNumber| *None* |Private - Phone: Displays phone number|  |
|personPrivate/description| *None* |Private - Description: Phone number description|  |
|personPager/formattedNumber| *None* |Other - Phone: Displays phone number|  |
|personPager/description| *None* |Other - Description: Phone number description|  |
|personDirectFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|personDirectFax/description| *None* |Fax - Description: Phone number description|  |
|personAddress/addressId| *None* |Contact address - Address ID: Database ID for the address record|  |
|personAddress/line1| *None* |Contact address - Address 1: First line of the address|  |
|personAddress/line2| *None* |Contact address - Address 2: Second line of the address|  |
|personAddress/line3| *None* |Contact address - Address 3: Third line of the address|  |
|personAddress/county| *None* |Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personAddress/city| *None* |Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|personAddress/zip| *None* |Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personAddress/state| *None* |Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personAddress/wgs84latitude| *None* |Contact address - Latitude: Latitude|  |
|personAddress/wgs84longitude| *None* |Contact address - Longitude: Longitude|  |
|personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|personContact/contactId| *None* |Company ID: Database ID of company|  |
|personContact/name| *None* |Company name|  |
|personContact/department| *None* |Department|  |
|personContact/nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|personContact/hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|personContact/hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|personContact/associateId| *None* |Our contact: Displays our contact|  |
|personContact/category| *None* |Category|  |
|personContact/business| *None* |Business|  |
|personContact/country| *None* |Country: This criterion corresponds to the Country field on the Company card.|  |
|personContact/number| *None* |Number|  |
|personContact/code| *None* |Code|  |
|personContact/orgnr| *None* |VAT No.|  |
|personContact/stop| *None* |Stop|  |
|personContact/contactNoMail| *None* |No mailings (company|  |
|personContact/updatedBy| *None* |Updated by: The user who last updated the data|  |
|personContact/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personContact/registeredBy| *None* |Registered by: The user who registered the data|  |
|personContact/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|personContact/contactSource| *None* |Source: Source (Company)|  |
|personContact/contactDeleted| *None* |Deleted: Deleted|  |
|personContact/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|personContact/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|personContact/deletedDate| *None* |Deleted date: Deleted date|  |
|personContact/mainContact| *None* |Main contact: Main contact for this company|  |
|personContact/contactPhone/formattedNumber| *None* |Telephone - Phone: Displays phone number|  |
|personContact/contactPhone/description| *None* |Telephone - Description: Phone number description|  |
|personContact/postAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|personContact/postAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|personContact/postAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|personContact/postAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|personContact/postAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personContact/postAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|personContact/postAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personContact/postAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personContact/postAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|personContact/postAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|personContact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|personContact/streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|personContact/streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|personContact/streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|personContact/streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personContact/streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|personContact/streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personContact/streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personContact/streetAddress/wgs84latitude| *None* |Street address - Latitude: Latitude|  |
|personContact/streetAddress/wgs84longitude| *None* |Street address - Longitude: Longitude|  |
|personContact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|personContact/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|personContact/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|personContact/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|personContact/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personContact/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|personContact/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personContact/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personContact/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|personContact/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|personContact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|name| *None* |Company name|  |
|department| *None* |Department|  |
|nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|associateId| *None* |Our contact: Displays our contact|  |
|category| *None* |Category|  |
|business| *None* |Business|  |
|country| *None* |Country: This criterion corresponds to the Country field on the Company card.|  |
|number| *None* |Number|  |
|code| *None* |Code|  |
|orgnr| *None* |VAT No.|  |
|stop| *None* |Stop|  |
|contactNoMail| *None* |No mailings (company|  |
|updatedBy| *None* |Updated by: The user who last updated the data|  |
|updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|registeredBy| *None* |Registered by: The user who registered the data|  |
|registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|contactSource| *None* |Source: Source (Company)|  |
|contactDeleted| *None* |Deleted: Deleted|  |
|activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|deletedDate| *None* |Deleted date: Deleted date|  |
|mainContact| *None* |Main contact: Main contact for this company|  |
|contactPhone/formattedNumber| *None* |Telephone - Phone: Displays phone number|  |
|contactPhone/description| *None* |Telephone - Description: Phone number description|  |
|contactFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|contactFax/description| *None* |Fax - Description: Phone number description|  |
|searchPhone/formattedNumber| *None* |Searchphone - Phone: Displays phone number|  |
|searchPhone/description| *None* |Searchphone - Description: Phone number description|  |
|email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|email/emailAddress| *None* |E-mail|  |
|email/emailDescription| *None* |Description|  |
|email/emailId| *None* |ID|  |
|email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|postAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|postAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|postAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|postAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|postAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|postAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|postAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|postAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|postAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|postAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|restrictionPostalAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|restrictionPostalAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|restrictionPostalAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|restrictionPostalAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|restrictionPostalAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|restrictionPostalAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|restrictionPostalAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|restrictionPostalAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|restrictionPostalAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|restrictionPostalAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|streetAddress/wgs84latitude| *None* |Street address - Latitude: Latitude|  |
|streetAddress/wgs84longitude| *None* |Street address - Longitude: Longitude|  |
|streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|url/URLAddress| *None* |URL|  |
|url/URLDescription| *None* |Description|  |
|contactAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|contactAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|contactAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|contactAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|contactAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|contactAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|contactAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contactAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|contactAssociate/associateDbId| *None* |ID|  |
|contactAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|contactAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|contactAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|contactAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|contactAssociate/contactCategory| *None* |Category: Category|  |
|contactAssociate/role| *None* |Role : Role|  |
|contactAssociate/assocName| *None* |User ID : User ID|  |
|contactAssociate/assocTooltip| *None* |Description : Description|  |
|contactAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|contactAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|contactAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|contactAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|contactAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|contactAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contactAssociate/otherGroups| *None* |Other groups: Other groups|  |
|contactAssociate/userName| *None* |User name: User name|  |
|contactAssociate/personEmail| *None* |E-mail|  |
|contactSupportAssociate/firstName| *None* |Our service contact - First name: Displays the contact's first name|  |
|contactSupportAssociate/lastName| *None* |Our service contact - Last name: Displays the contact's last name|  |
|contactSupportAssociate/middleName| *None* |Our service contact - Middle Name: Displays the contact's middle name.|  |
|contactSupportAssociate/fullName| *None* |Our service contact - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|contactSupportAssociate/contactId| *None* |Our service contact - Company ID: Database ID of the company the user belongs to|  |
|contactSupportAssociate/personId| *None* |Our service contact - Contact ID: Database ID of the contact row|  |
|contactSupportAssociate/mrMrs| *None* |Our service contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contactSupportAssociate/title| *None* |Our service contact - Title: Displays whether the contact is addressed as Mr or Ms|  |
|contactSupportAssociate/associateDbId| *None* |Our service contact - ID|  |
|contactSupportAssociate/contactName| *None* |Our service contact - Owning company: Name of the company the user belongs to|  |
|contactSupportAssociate/contactDepartment| *None* |Our service contact - Owning department: Name of the department at the company the user belongs to|  |
|contactSupportAssociate/usergroup| *None* |Our service contact - Primary group: The user's primary user group|  |
|contactSupportAssociate/contactFullName| *None* |Our service contact - Owner: Name and department of the company the user belongs to|  |
|contactSupportAssociate/contactCategory| *None* |Our service contact - Category: Category|  |
|contactSupportAssociate/role| *None* |Our service contact - Role: Role|  |
|contactSupportAssociate/assocName| *None* |Our service contact - User ID: User ID|  |
|contactSupportAssociate/assocTooltip| *None* |Our service contact - Description: Description|  |
|contactSupportAssociate/assocType| *None* |Our service contact - Type: Type of user: associate, external user, system user, anonymous account|  |
|contactSupportAssociate/ejUserId| *None* |Our service contact - Service user ID: The database ID of a Service user|  |
|contactSupportAssociate/simultaneousEjUser| *None* |Our service contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactSupportAssociate/ejDisplayName| *None* |Our service contact - Nick name: User's nick name in Service|  |
|contactSupportAssociate/ejStatus| *None* |Our service contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactSupportAssociate/credentialType| *None* |Our service contact - Auth. type: What type of credentials to use when this user logs in|  |
|contactSupportAssociate/credentialDisplayValue| *None* |Our service contact - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|contactSupportAssociate/isActive| *None* |Our service contact - Active: Is this user active, and should be able to log in?|  |
|contactSupportAssociate/isActiveText| *None* |Our service contact - Active status: Is this user active, and should be able to log in?|  |
|contactSupportAssociate/portraitThumbnail| *None* |Our service contact - Person image: Person image|  |
|contactSupportAssociate/otherGroups| *None* |Our service contact - Other groups: Other groups|  |
|contactSupportAssociate/userName| *None* |Our service contact - User name: User name|  |
|contactSupportAssociate/personEmail| *None* |Our service contact - E-mail|  |
|contactSupportPerson/personId| *None* |User support contact - DB ID: Displays the database ID of a contact|  |
|contactSupportPerson/firstName| *None* |User support contact - First name: Displays the contact's first name|  |
|contactSupportPerson/lastName| *None* |User support contact - Last name: Displays the contact's last name|  |
|contactSupportPerson/middleName| *None* |User support contact - Middle name: Displays the contact's middle name.|  |
|contactSupportPerson/fullName| *None* |User support contact - Contact: Displays the contact to which an item is linked|  |
|contactSupportPerson/contactId| *None* |User support contact - Company ID: Database ID of company|  |
|contactSupportPerson/hasInfoText| *None* |User support contact - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|contactSupportPerson/hasInterests| *None* |User support contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|contactSupportPerson/personHasInterests| *None* |User support contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|contactSupportPerson/mrMrs| *None* |User support contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contactSupportPerson/position| *None* |User support contact - Position|  |
|contactSupportPerson/personNumber| *None* |User support contact - Number: Displays the contact's number|  |
|contactSupportPerson/title| *None* |User support contact - Title: Displays the contact's job title|  |
|contactSupportPerson/personCountry| *None* |User support contact - Country: Country|  |
|contactSupportPerson/personNoMail| *None* |User support contact - No Mailings: Displays the contact's No Mailings checkbox|  |
|contactSupportPerson/rank| *None* |User support contact - Rank: Displays a contact's current rank|  |
|contactSupportPerson/birthdate| *None* |User support contact - Birthdate: Displays the contact's date of birth|  |
|contactSupportPerson/associateType| *None* |User support contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|contactSupportPerson/useAsMailingAddress| *None* |User support contact - Use as postal address: Use as postal address|  |
|contactSupportPerson/personSource| *None* |User support contact - Source: Source (Contact)|  |
|contactSupportPerson/retired| *None* |User support contact - Former employee: Indicates whether the contact has retired/left the company|  |
|contactSupportPerson/birthYear| *None* |User support contact - Birth year: Displays contact's birth year|  |
|contactSupportPerson/birthMonth| *None* |User support contact - Birth month: Displays contact's birth month|  |
|contactSupportPerson/birthDay| *None* |User support contact - Birth day: Displays contact's birth day (day of month)|  |
|contactSupportPerson/kanaFirstName| *None* |User support contact - First name, kana: Contact's first name, in kana alphabet|  |
|contactSupportPerson/kanaLastName| *None* |User support contact - Last name, kana: Contact's last name, in kana alphabet|  |
|contactSupportPerson/personUpdatedBy| *None* |User support contact - Updated by: The user who last updated the data|  |
|contactSupportPerson/personUpdatedDate| *None* |User support contact - Updated: The date/time the data was last updated in UTC.|  |
|contactSupportPerson/personRegisteredBy| *None* |User support contact - Registered by: The user who registered the data|  |
|contactSupportPerson/personRegisteredDate| *None* |User support contact - Registered date: The date/time the data was registered in UTC.|  |
|contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|contactSupportPerson/personActiveErpLinks| *None* |User support contact - ERP connected: Is there an active ERP Sync?|  |
|contactSupportPerson/ticketPriority| *None* |User support contact - Service priority: Default service priority for this contact|  |
|contactSupportPerson/supportLanguage| *None* |User support contact - Preferred language: Preferred language used for reply templates and more|  |
|contactSupportPerson/supportAssociate| *None* |User support contact - Our service contact: Default service contact for this contact|  |
|contactSupportPerson/personAssociateId| *None* |User support contact - Our contact: Displays our contact|  |
|contactSupportPerson/personCategory| *None* |User support contact - Category|  |
|contactSupportPerson/personBusiness| *None* |User support contact - Business|  |
|contactSupportPerson/personDeletedDate| *None* |User support contact - Deleted date: Deleted date|  |
|contactSupportPerson/hasCompany| *None* |User support contact - Has company: The contact is associated with a company|  |
|contactSupportPerson/isProjectMember| *None* |User support contact - Is project member: This person is a project member|  |
|contactSupportPerson/isStakeholder| *None* |User support contact - Is stakeholder: This person is a sale stakeholder|  |
|contactSupportPerson/who| *None* |User support contact - Full name: Displays the contact's full name.|  |
|contactSupportPerson/personInfo/textId| *None* |User support contact - Text ID|  |
|contactSupportPerson/personInfo/infoText| *None* |User support contact - Information: Displays the text entered in the description field|  |
|contactSupportPerson/personUdef/SuperOffice:1| *None* |User support contact - contactshorttext: tooltipshorttext|  |
|contactSupportPerson/personUdef/SuperOffice:2| *None* |User support contact - contactlongtext: tooltiplongtext|  |
|contactSupportPerson/personUdef/SuperOffice:3| *None* |User support contact - contactnumber|  |
|contactSupportPerson/personUdef/SuperOffice:4| *None* |User support contact - contactdate|  |
|contactSupportPerson/personUdef/SuperOffice:5| *None* |User support contact - contactunlimiteddate: tooltipunlimiteddate|  |
|contactSupportPerson/personUdef/SuperOffice:6| *None* |User support contact - contactcheckbox|  |
|contactSupportPerson/personUdef/SuperOffice:7| *None* |User support contact - contactdropdownlistbox|  |
|contactSupportPerson/personUdef/SuperOffice:8| *None* |User support contact - contactdecimal|  |
|contactSupportPerson/personUdef/SuperOffice:9| *None* |User support contact - page1saleonly|  |
|contactSupportPerson/personUdef/SuperOffice:10| *None* |User support contact - page1marketingonly|  |
|contactSupportPerson/personUdef/SuperOffice:11| *None* |User support contact - page1adminonly|  |
|contactSupportPerson/isMailingRecipient| *None* |User support contact - isMailingRecipient: isMailingRecipient|  |
|contactSupportPerson/hasStoreConsent| *None* |User support contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/withdrawnStoreConsent| *None* |User support contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/hasEmarketingConsent| *None* |User support contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/withdrawnEmarketingConsent| *None* |User support contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/subscription| *None* |User support contact - Subscription: Subscription for marketing|  |
|contactSupportPerson/legalBaseStore| *None* |User support contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/legalBaseEmarketing| *None* |User support contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/consentSourceStore| *None* |User support contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/consentSourceEmarketing| *None* |User support contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactInterestIds| *None* |Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|contactUdef/SuperOffice:3| *None* |companynumber|  |
|contactUdef/SuperOffice:4| *None* |companydate|  |
|contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|contactUdef/SuperOffice:8| *None* |companydecimal|  |
|contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|NumberOfActivities| *None* |Number of activities|  |
|NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|LastActivity| *None* |Date of last activity|  |
|LastCompletedActivity| *None* |Date of last completed activity|  |
|LastDoByActivity| *None* |Date of last non-completed activity|  |
|NumberOfSales| *None* |Number of sales|  |
|NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|LastSale| *None* |Date of last sale|  |
|LastCompletedSale| *None* |Date of last completed sale|  |
|LastDoBySale| *None* |Date of last non-completed sale|  |
|NumberOfTickets| *None* |Number of requests|  |
|NumberOfTicketsInPeriod| *None* |Number of requests in last 90 days|  |
|NumberOfNotCompletedTickets| *None* |Number of non-completed requests|  |
|NumberOfNotCompletedTicketsInPeriod| *None* |Number of non-completed requests in last 90 days|  |
|LastTicket| *None* |Date of last request|  |
|LastCompletedTicket| *None* |Date of last completed request|  |
|LastDoByTicket| *None* |Date of last non-completed request|  |
|SaintStatus1| *None* |Neglected customer|  |
|SaintStatus2| *None* |C-company|  |
|saintSaleStatus| *None* |With status|  |
|saintAmountClass| *None* |Amount class|  |
|saintActivityType| *None* |SAINT type|  |
|saintDirection| *None* |Direction|  |
|saintIntention| *None* |Intention|  |
|saintTicketStatus| *None* |Status|  |
|saintTicketCategory| *None* |Category|  |
|selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|selectionIdRequest| *None* |Selection ID: Database ID of selection which members are to be fetched from|  |

## Sample

```http!
GET /api/v1/archive/EmailAddress?$select=who,personContact/restrictionAddress/line2,restrictionPostalAddress/line2,contactSupportPerson/rank,NumberOfTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

