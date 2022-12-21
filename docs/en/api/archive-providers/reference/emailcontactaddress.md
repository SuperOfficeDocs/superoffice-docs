---
uid: emailcontactaddress
title: emailcontactaddress
description: Contact subchannel for special purpose archive provider used to search for email addresses.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "emailcontactaddress"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "emailcontactaddress"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailContactAddressProvider">SuperOffice.CRM.ArchiveLists.EmailContactAddressProvider</see> inside NetServer's SODatabase assembly.

Contact subchannel for special purpose archive provider used to search for email addresses.

This channel will match on either the email address itself, or contact.name
<para />
The resulting rows will have entity name 'contact', but the primary key will always be
the email_id.

## Supported Entities

| Name | Description |
| ---- | ----------- |
|"email"|[email]|
|"contact"|Contact|

## Supported Columns

| Name | Restriction | Description | OrderBy |
| ---- | ----------- | ----------- | ------- |
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
|contactId|int|Company ID: Database ID of company| x |
|name|stringorPK|Company name| x |
|department|string|Department| x |
|nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|associateId|associate|Our contact: Displays our contact| x |
|category|listAny|Category| x |
|business|listAny|Business| x |
|country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|countryId|int|Country ID: Country ID| x |
|number|string|Number| x |
|code|string|Code| x |
|orgnr|string|VAT No.| x |
|stop|bool|Stop| x |
|contactNoMail|bool|No mailings (company| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contactSource|listAny|Source: Source (Company)| x |
|contactDeleted|bool|Deleted: Deleted| x |
|phone/formattedNumber|string|Phone : Displays phone number|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|deletedDate|datetime|Deleted date: Deleted date|  |
|mainContact| *None* |Main contact: Main contact for this company| x |
|who| *None* |Company: Displays the name of a selection member's company| x |
|contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|contactPhone/description|string|Telephone - Description: Phone number description| x |
|contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|contactFax/description|string|Fax - Description: Phone number description| x |
|searchPhone/formattedNumber|string|Searchphone - Phone: Displays phone number|  |
|searchPhone/description|string|Searchphone - Description: Phone number description| x |
|email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|email/emailAddress|string|E-mail| x |
|email/emailDescription|string|Description| x |
|email/emailId|int|ID| x |
|email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|postAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|postAddress/line1|string|Postal address - Address 1: First line of the address| x |
|postAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|postAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|restrictionPostalAddress/line1|string|Postal address - Address 1: First line of the address| x |
|restrictionPostalAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|restrictionPostalAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|restrictionPostalAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|restrictionPostalAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|restrictionPostalAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|restrictionPostalAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|restrictionPostalAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|restrictionPostalAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|restrictionPostalAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/addressId|int|Street address - Address ID: Database ID for the address record| x |
|streetAddress/line1|string|Street address - Address 1: First line of the address| x |
|streetAddress/line2|string|Street address - Address 2: Second line of the address| x |
|streetAddress/line3|string|Street address - Address 3: Third line of the address| x |
|streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.| x |
|streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude| x |
|streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude| x |
|streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|url/URLAddress|string|URL| x |
|url/URLDescription|string|Description| x |
|contactAssociate/firstName|string|First name: Displays the contact's first name| x |
|contactAssociate/lastName|string|Last name: Displays the contact's last name| x |
|contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|contactAssociate/associateDbId|associate|ID| x |
|contactAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|contactAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|contactAssociate/contactCategory|listAny|Category: Category| x |
|contactAssociate/role|listAny|Role : Role| x |
|contactAssociate/assocName|associate|User ID : User ID| x |
|contactAssociate/assocTooltip|string|Description : Description|  |
|contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|contactAssociate/userName|string|User name: User name| x |
|contactAssociate/personEmail|string|E-mail| x |
|contactSupportAssociate/firstName|string|Our service contact - First name: Displays the contact's first name| x |
|contactSupportAssociate/lastName|string|Our service contact - Last name: Displays the contact's last name| x |
|contactSupportAssociate/middleName|string|Our service contact - Middle Name: Displays the contact's middle name.| x |
|contactSupportAssociate/fullName|string|Our service contact - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contactSupportAssociate/contactId|int|Our service contact - Company ID: Database ID of the company the user belongs to|  |
|contactSupportAssociate/personId|int|Our service contact - Contact ID: Database ID of the contact row|  |
|contactSupportAssociate/mrMrs|string|Our service contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|contactSupportAssociate/title|string|Our service contact - Title: Displays whether the contact is addressed as Mr or Ms| x |
|contactSupportAssociate/associateDbId|associate|Our service contact - ID| x |
|contactSupportAssociate/contactName|string|Our service contact - Owning company: Name of the company the user belongs to| x |
|contactSupportAssociate/contactDepartment|string|Our service contact - Owning department: Name of the department at the company the user belongs to| x |
|contactSupportAssociate/usergroup|userGroup|Our service contact - Primary group: The user's primary user group| x |
|contactSupportAssociate/contactFullName|string|Our service contact - Owner: Name and department of the company the user belongs to| x |
|contactSupportAssociate/contactCategory|listAny|Our service contact - Category: Category| x |
|contactSupportAssociate/role|listAny|Our service contact - Role: Role| x |
|contactSupportAssociate/assocName|associate|Our service contact - User ID: User ID| x |
|contactSupportAssociate/assocTooltip|string|Our service contact - Description: Description|  |
|contactSupportAssociate/assocType|listAny|Our service contact - Type: Type of user: associate, external user, system user, anonymous account| x |
|contactSupportAssociate/ejUserId|int|Our service contact - Service user ID: The database ID of a Service user|  |
|contactSupportAssociate/simultaneousEjUser|bool|Our service contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactSupportAssociate/ejDisplayName|string|Our service contact - Nick name: User's nick name in Service| x |
|contactSupportAssociate/ejStatus|int|Our service contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactSupportAssociate/credentialType| *None* |Our service contact - Auth. type: What type of credentials to use when this user logs in| x |
|contactSupportAssociate/credentialDisplayValue| *None* |Our service contact - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|contactSupportAssociate/isActive|bool|Our service contact - Active: Is this user active, and should be able to log in?| x |
|contactSupportAssociate/isActiveText|bool|Our service contact - Active status: Is this user active, and should be able to log in?| x |
|contactSupportAssociate/portraitThumbnail| *None* |Our service contact - Person image: Person image|  |
|contactSupportAssociate/otherGroups|userGroup|Our service contact - Other groups: Other groups|  |
|contactSupportAssociate/userName|string|Our service contact - User name: User name| x |
|contactSupportAssociate/personEmail|string|Our service contact - E-mail| x |
|contactSupportPerson/personId|int|User support contact - DB ID: Displays the database ID of a contact| x |
|contactSupportPerson/firstName|string|User support contact - First name: Displays the contact's first name| x |
|contactSupportPerson/lastName|string|User support contact - Last name: Displays the contact's last name| x |
|contactSupportPerson/middleName|string|User support contact - Middle name: Displays the contact's middle name.| x |
|contactSupportPerson/fullName|stringorPK|User support contact - Contact: Displays the contact to which an item is linked| x |
|contactSupportPerson/contactId|int|User support contact - Company ID: Database ID of company| x |
|contactSupportPerson/hasInfoText|bool|User support contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|contactSupportPerson/hasInterests|bool|User support contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|contactSupportPerson/personHasInterests|bool|User support contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|contactSupportPerson/mrMrs|string|User support contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|contactSupportPerson/position|listAny|User support contact - Position| x |
|contactSupportPerson/personNumber|string|User support contact - Number: Displays the contact's number| x |
|contactSupportPerson/title|string|User support contact - Title: Displays the contact's job title| x |
|contactSupportPerson/personCountry|listAny|User support contact - Country: Country| x |
|contactSupportPerson/personCountryId|int|User support contact - Country ID: Country ID| x |
|contactSupportPerson/personNoMail|bool|User support contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|contactSupportPerson/rank|int|User support contact - Rank: Displays a contact's current rank| x |
|contactSupportPerson/birthdate| *None* |User support contact - Birthdate: Displays the contact's date of birth|  |
|contactSupportPerson/associateType| *None* |User support contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|contactSupportPerson/useAsMailingAddress|bool|User support contact - Use as postal address: Use as postal address| x |
|contactSupportPerson/personSource|listAny|User support contact - Source: Source (Contact)| x |
|contactSupportPerson/retired|bool|User support contact - Former employee: Indicates whether the contact has retired/left the company| x |
|contactSupportPerson/birthYear|int|User support contact - Birth year: Displays contact's birth year| x |
|contactSupportPerson/birthMonth|int|User support contact - Birth month: Displays contact's birth month| x |
|contactSupportPerson/birthDay|int|User support contact - Birth day: Displays contact's birth day (day of month)| x |
|contactSupportPerson/kanaFirstName|string|User support contact - First name, kana: Contact's first name, in kana alphabet| x |
|contactSupportPerson/kanaLastName|string|User support contact - Last name, kana: Contact's last name, in kana alphabet| x |
|contactSupportPerson/personUpdatedBy|associate|User support contact - Updated by: The user who last updated the data| x |
|contactSupportPerson/personUpdatedByFullName|associate|User support contact - Updated by - Full name: The user who last updated the data| x |
|contactSupportPerson/personUpdatedDate|date|User support contact - Updated: The date/time the data was last updated in UTC.| x |
|contactSupportPerson/personRegisteredBy|associate|User support contact - Registered by: The user who registered the data| x |
|contactSupportPerson/personRegisteredByFullName|associate|User support contact - Registered by - Full name: The user who registered the data| x |
|contactSupportPerson/personRegisteredDate|date|User support contact - Registered date: The date/time the data was registered in UTC.| x |
|contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|contactSupportPerson/personActiveErpLinks|bool|User support contact - ERP connected: Is there an active ERP Sync?| x |
|contactSupportPerson/ticketPriority|listAny|User support contact - Service priority: Default service priority for this contact| x |
|contactSupportPerson/supportLanguage|listAny|User support contact - Preferred language: Preferred language used for reply templates and more| x |
|contactSupportPerson/supportAssociate|associate|User support contact - Our service contact: Default service contact for this contact| x |
|contactSupportPerson/supportAssociateFullName|associate|User support contact - Our service contact - Full name: Default service contact for this contact| x |
|contactSupportPerson/personAssociateId|associate|User support contact - Our contact: Displays our contact| x |
|contactSupportPerson/personAssociateFullName|associate|User support contact - Our contact - Full name: Displays our contact| x |
|contactSupportPerson/personCategory|listAny|User support contact - Category| x |
|contactSupportPerson/personBusiness|listAny|User support contact - Business| x |
|contactSupportPerson/personDeletedDate|datetime|User support contact - Deleted date: Deleted date|  |
|contactSupportPerson/hasCompany|bool|User support contact - Has company: The contact is associated with a company| x |
|contactSupportPerson/isProjectMember|bool|User support contact - Is project member: This person is a project member| x |
|contactSupportPerson/isStakeholder|bool|User support contact - Is stakeholder: This person is a sale stakeholder| x |
|contactSupportPerson/who| *None* |User support contact - Full name: Displays the contact's full name.| x |
|contactSupportPerson/personInfo/textId|int|User support contact - Text ID| x |
|contactSupportPerson/personInfo/infoText|positiveString|User support contact - Information: Displays the text entered in the description field| x |
|contactSupportPerson/personUdef/SuperOffice:1|string|User support contact - contactshorttext: tooltipshorttext| x |
|contactSupportPerson/personUdef/SuperOffice:2|string|User support contact - contactlongtext: tooltiplongtext| x |
|contactSupportPerson/personUdef/SuperOffice:3|int|User support contact - contactnumber| x |
|contactSupportPerson/personUdef/SuperOffice:4|date|User support contact - contactdate| x |
|contactSupportPerson/personUdef/SuperOffice:5|unlimitedDate|User support contact - contactunlimiteddate: tooltipunlimiteddate| x |
|contactSupportPerson/personUdef/SuperOffice:6|bool|User support contact - contactcheckbox| x |
|contactSupportPerson/personUdef/SuperOffice:7|listAny|User support contact - contactdropdownlistbox| x |
|contactSupportPerson/personUdef/SuperOffice:8|decimal|User support contact - contactdecimal| x |
|contactSupportPerson/personUdef/SuperOffice:9|string|User support contact - page1saleonly| x |
|contactSupportPerson/personUdef/SuperOffice:10|string|User support contact - page1marketingonly| x |
|contactSupportPerson/personUdef/SuperOffice:11|string|User support contact - page1adminonly| x |
|contactSupportPerson/personExtra/x\_person\_integer|int|User support contact - Extra Integer: Custom person integer| x |
|contactSupportPerson/personExtra/x\_person\_hidden\_integer|int|User support contact - Extra hidden integer: Custom integer field that is hidden| x |
|contactSupportPerson/personExtra/x\_person\_float|decimal|User support contact - Extra float: Custom float field| x |
|contactSupportPerson/personExtra/x\_person\_longtext|string|User support contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|contactSupportPerson/personExtra/x\_person\_date|date|User support contact - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|contactSupportPerson/personExtra/x\_person\_datetime|datetime|User support contact - Extra DateTime: Custom person date and time field. No default| x |
|contactSupportPerson/personExtra/x\_person\_time| *None* |User support contact - Extra time: Custom time field on person. Current time as default| x |
|contactSupportPerson/personExtra/x\_person\_boolean|bool|User support contact - Extra Boolean: Custom boolean field on person. Default checked| x |
|contactSupportPerson/personExtra/x\_person\_timespan|timeSpan|User support contact - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|contactSupportPerson/personExtra/x\_person\_shorttext|string|User support contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|contactSupportPerson/personExtra/x\_person\_shorttext\_list|listAny|User support contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|contactSupportPerson/personExtra/x\_person\_user\_relation|associate|User support contact - Extra user relation: Custom person-user relation field| x |
|contactSupportPerson/personExtra/x\_person\_category\_relation|listAny|User support contact - Extra category relation: Custom person-category relation| x |
|contactSupportPerson/personExtra/x\_person\_priority\_relation|listAny|User support contact - Extra priority relation: Custom person-priority relation| x |
|contactSupportPerson/personExtra/x\_person\_request\_relation|stringorPK|User support contact - Extra request relation: Request relation on contact| x |
|contactSupportPerson/personExtra/x\_person\_appointment\_relation|stringorPK|User support contact - Extra appointment relation: Appointment relation on person| x |
|contactSupportPerson/personExtra/x\_person\_contact\_relation|stringorPK|User support contact - Extra company relation: Company relation on contact| x |
|contactSupportPerson/personExtra/y\_rental/id|int|User support contact - Rental - id: Displays the row's primary key (y\_rental)| x |
|contactSupportPerson/personExtra/y\_rental/x\_start|date|User support contact - Rental - Start rental| x |
|contactSupportPerson/personExtra/y\_rental/x\_end|date|User support contact - Rental - End| x |
|contactSupportPerson/personExtra/y\_rental/x\_amount|int|User support contact - Rental - Amount: Number to rent. Default = 1| x |
|contactSupportPerson/personExtra/y\_rental/x\_contact|stringorPK|User support contact - Rental - Renter: Company that rents equipment| x |
|contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name|string|User support contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|contactSupportPerson/isMailingRecipient|bool|User support contact - Is mailing recipient: isMailingRecipient| x |
|contactSupportPerson/hasStoreConsent|bool|User support contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/withdrawnStoreConsent|bool|User support contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/hasEmarketingConsent|bool|User support contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/withdrawnEmarketingConsent|bool|User support contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/subscription|listAny|User support contact - Subscription: Subscription for marketing| x |
|contactSupportPerson/legalBaseStore|listAny|User support contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contactSupportPerson/legalBaseEmarketing|listAny|User support contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contactSupportPerson/consentSourceStore|listAny|User support contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contactSupportPerson/consentSourceEmarketing|listAny|User support contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|contactUdef/SuperOffice:3|int|companynumber| x |
|contactUdef/SuperOffice:4|date|companydate| x |
|contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|contactUdef/SuperOffice:6|bool|companycheckbox| x |
|contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|contactUdef/SuperOffice:8|decimal|companydecimal| x |
|contactUdef/SuperOffice:9|string|page1saleonly| x |
|contactUdef/SuperOffice:10|string|page1marketingonly| x |
|contactUdef/SuperOffice:11|string|page1adminonly| x |
|contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
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
|NumberOfTickets|int|Number of requests|  |
|NumberOfTicketsInPeriod|int|Number of requests in last 90 days|  |
|NumberOfNotCompletedTickets|int|Number of non-completed requests|  |
|NumberOfNotCompletedTicketsInPeriod|int|Number of non-completed requests in last 90 days|  |
|LastTicket|date|Date of last request|  |
|LastCompletedTicket|date|Date of last completed request|  |
|LastDoByTicket|date|Date of last non-completed request|  |
|SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|saintSaleStatus|listAny|With status|  |
|saintAmountClass|listAny|Amount class|  |
|saintActivityType|listAny|SAINT type|  |
|saintDirection|listAny|Direction|  |
|saintIntention|listAny|Intention|  |
|saintTicketStatus|listAny|Status|  |
|saintTicketCategory|listAny|Category|  |
|selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|selectionIdRequest|int|Selection ID: Database ID of selection which members are to be fetched from|  |

## Sample

```http!
GET /api/v1/archive/emailcontactaddress?$select=postAddress/formattedAddress,restrictionPostalAddress/city,contactAssociate/middleName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>
