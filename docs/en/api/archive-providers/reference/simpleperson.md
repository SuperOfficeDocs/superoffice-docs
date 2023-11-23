---
uid: SimplePerson
title: SimplePerson
description: 
keywords: SimplePerson archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "SimplePerson"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SimplePersonsProvider">SuperOffice.CRM.ArchiveLists.SimplePersonsProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"person"|Contact|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|personId|int|DB ID: Displays the database ID of a contact| x |
|firstName|string|First name: Displays the contact's first name| x |
|lastName|string|Last name: Displays the contact's last name| x |
|middleName|string|Middle name: Displays the contact's middle name.| x |
|fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
|fullNameWithContact| *None* |Contact and company: The fully formatted contact name, and full company name| x |
|contactId|int|Company ID: Database ID of company| x |
|hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|position|listAny|Position| x |
|personNumber|string|Number: Displays the contact's number| x |
|title|string|Title: Displays the contact's job title| x |
|personCountry|listAny|Country: Country| x |
|personCountryId|int|Country ID: Country ID| x |
|personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox| x |
|rank|int|Rank: Displays a contact's current rank| x |
|birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|useAsMailingAddress|bool|Use as postal address: Use as postal address| x |
|personSource|listAny|Source: Source (Contact)| x |
|retired|bool|Former employee: Indicates whether the contact has retired/left the company| x |
|birthYear|int|Birth year: Displays contact's birth year| x |
|birthMonth|int|Birth month: Displays contact's birth month| x |
|birthDay|int|Birth day: Displays contact's birth day (day of month)| x |
|kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet| x |
|kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet| x |
|personUpdatedBy|associate|Updated by: The user who last updated the data| x |
|personUpdatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|personRegisteredBy|associate|Registered by: The user who registered the data| x |
|personRegisteredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|portraitThumbnail| *None* |Person image: Person image|  |
|personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|ticketPriority|listAny|Service priority: Default service priority for this contact| x |
|supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|supportAssociateFullName|associate|Our service contact - Full name: Default service contact for this contact| x |
|personAssociateId|associate|Our contact: Displays our contact| x |
|personAssociateFullName|associate|Our contact - Full name: Displays our contact| x |
|personCategory|listAny|Category| x |
|personBusiness|listAny|Business| x |
|personDeletedDate|datetime|Deleted date: Deleted date|  |
|hasCompany|bool|Has company: The contact is associated with a company| x |
|isProjectMember|bool|Is project member: This person is a project member| x |
|isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|phone/formattedNumber|string|Phone : Displays phone number|  |
|personDirectPhone/formattedNumber|string|Direct - Phone: Displays phone number|  |
|personDirectPhone/description|string|Direct - Description: Phone number description| x |
|personMobilePhone/formattedNumber|string|Mobile - Phone: Displays phone number|  |
|personMobilePhone/description|string|Mobile - Description: Phone number description| x |
|personPrivate/formattedNumber|string|Private - Phone: Displays phone number|  |
|personPrivate/description|string|Private - Description: Phone number description| x |
|personPager/formattedNumber|string|Other - Phone: Displays phone number|  |
|personPager/description|string|Other - Description: Phone number description| x |
|personDirectFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|personDirectFax/description|string|Fax - Description: Phone number description| x |
|searchPhone/formattedNumber|string|Phone : Displays phone number|  |
|searchPhone/description|string|Description: Phone number description| x |
|personInfo/textId|int|Text ID| x |
|personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|email/emailAddress|string|E-mail| x |
|email/emailDescription|string|Description| x |
|email/emailId|int|ID| x |
|email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|personUrl/URLAddress|string|URL| x |
|personUrl/URLDescription|string|Description| x |
|personAddress/addressId|int|Contact address - Address ID: Database ID for the address record| x |
|personAddress/line1|string|Contact address - Address 1: First line of the address| x |
|personAddress/line2|string|Contact address - Address 2: Second line of the address| x |
|personAddress/line3|string|Contact address - Address 3: Third line of the address| x |
|personAddress/county|string|Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|personAddress/city|string|Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|personAddress/zip|string|Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|personAddress/state|string|Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|personAddress/wgs84latitude|decimal|Contact address - Latitude: Latitude| x |
|personAddress/wgs84longitude|decimal|Contact address - Longitude: Longitude| x |
|personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|personUdef/SuperOffice:3|int|contactnumber| x |
|personUdef/SuperOffice:4|date|contactdate| x |
|personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|personUdef/SuperOffice:6|bool|contactcheckbox| x |
|personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|personUdef/SuperOffice:8|decimal|contactdecimal| x |
|personUdef/SuperOffice:9|string|page1saleonly| x |
|personUdef/SuperOffice:10|string|page1marketingonly| x |
|personUdef/SuperOffice:11|string|page1adminonly| x |
|personExtra/x\_person\_integer|int|Extra Integer: Custom person integer| x |
|personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden| x |
|personExtra/x\_person\_float|decimal|Extra float: Custom float field| x |
|personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019| x |
|personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default| x |
|personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default| x |
|personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked| x |
|personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field| x |
|personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation| x |
|personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation| x |
|personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact| x |
|personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person| x |
|personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact| x |
|personExtra/y\_rental/id|int|Rental - id: Displays the row's primary key (y\_rental)| x |
|personExtra/y\_rental/x\_start|date|Rental - Start rental| x |
|personExtra/y\_rental/x\_end|date|Rental - End| x |
|personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1| x |
|personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment| x |
|personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|personSourceRelation/personId|int|Source - DB ID: Displays the database ID of a contact| x |
|personSourceRelation/firstName|string|Source - First name: Displays the contact's first name| x |
|personSourceRelation/lastName|string|Source - Last name: Displays the contact's last name| x |
|personSourceRelation/middleName|string|Source - Middle name: Displays the contact's middle name.| x |
|personSourceRelation/fullName|stringorPK|Source - Contact: Displays the contact to which an item is linked| x |
|personSourceRelation/contactId|int|Source - Company ID: Database ID of company| x |
|personSourceRelation/hasInfoText|bool|Source - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|personSourceRelation/hasInterests|bool|Source - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personSourceRelation/personHasInterests|bool|Source - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personSourceRelation/mrMrs|string|Source - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personSourceRelation/position|listAny|Source - Position| x |
|personSourceRelation/personNumber|string|Source - Number: Displays the contact's number| x |
|personSourceRelation/title|string|Source - Title: Displays the contact's job title| x |
|personSourceRelation/personCountry|listAny|Source - Country: Country| x |
|personSourceRelation/personCountryId|int|Source - Country ID: Country ID| x |
|personSourceRelation/personNoMail|bool|Source - No Mailings: Displays the contact's No Mailings checkbox| x |
|personSourceRelation/rank|int|Source - Rank: Displays a contact's current rank| x |
|personSourceRelation/birthdate| *None* |Source - Birthdate: Displays the contact's date of birth|  |
|personSourceRelation/associateType| *None* |Source - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personSourceRelation/useAsMailingAddress|bool|Source - Use as postal address: Use as postal address| x |
|personSourceRelation/personSource|listAny|Source - Source: Source (Contact)| x |
|personSourceRelation/retired|bool|Source - Former employee: Indicates whether the contact has retired/left the company| x |
|personSourceRelation/birthYear|int|Source - Birth year: Displays contact's birth year| x |
|personSourceRelation/birthMonth|int|Source - Birth month: Displays contact's birth month| x |
|personSourceRelation/birthDay|int|Source - Birth day: Displays contact's birth day (day of month)| x |
|personSourceRelation/kanaFirstName|string|Source - First name, kana: Contact's first name, in kana alphabet| x |
|personSourceRelation/kanaLastName|string|Source - Last name, kana: Contact's last name, in kana alphabet| x |
|personSourceRelation/personUpdatedBy|associate|Source - Updated by: The user who last updated the data| x |
|personSourceRelation/personUpdatedByFullName|associate|Source - Updated by - Full name: The user who last updated the data| x |
|personSourceRelation/personUpdatedDate|date|Source - Updated: The date/time the data was last updated in UTC.| x |
|personSourceRelation/personRegisteredBy|associate|Source - Registered by: The user who registered the data| x |
|personSourceRelation/personRegisteredByFullName|associate|Source - Registered by - Full name: The user who registered the data| x |
|personSourceRelation/personRegisteredDate|date|Source - Registered date: The date/time the data was registered in UTC.| x |
|personSourceRelation/portraitThumbnail| *None* |Source - Person image: Person image|  |
|personSourceRelation/personActiveErpLinks|bool|Source - ERP connected: Is there an active ERP Sync?| x |
|personSourceRelation/ticketPriority|listAny|Source - Service priority: Default service priority for this contact| x |
|personSourceRelation/supportLanguage|listAny|Source - Preferred language: Preferred language used for reply templates and more| x |
|personSourceRelation/supportAssociate|associate|Source - Our service contact: Default service contact for this contact| x |
|personSourceRelation/supportAssociateFullName|associate|Source - Our service contact - Full name: Default service contact for this contact| x |
|personSourceRelation/personAssociateId|associate|Source - Our contact: Displays our contact| x |
|personSourceRelation/personAssociateFullName|associate|Source - Our contact - Full name: Displays our contact| x |
|personSourceRelation/personCategory|listAny|Source - Category| x |
|personSourceRelation/personBusiness|listAny|Source - Business| x |
|personSourceRelation/personDeletedDate|datetime|Source - Deleted date: Deleted date|  |
|personSourceRelation/hasCompany|bool|Source - Has company: The contact is associated with a company| x |
|personSourceRelation/isProjectMember|bool|Source - Is project member: This person is a project member| x |
|personSourceRelation/isStakeholder|bool|Source - Is stakeholder: This person is a sale stakeholder| x |
|personSourceRelation/restrictionContactId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/restrictionPersonId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/who| *None* |Source - Full name: Full name of company/contact| x |
|personSourceRelation/personPersonRelation|listAny|Source - Contact-to-contact relation: Name of relation, not taking into account the relation direction| x |
|personTargetRelation/personId|int|Target - DB ID: Displays the database ID of a contact| x |
|personTargetRelation/firstName|string|Target - First name: Displays the contact's first name| x |
|personTargetRelation/lastName|string|Target - Last name: Displays the contact's last name| x |
|personTargetRelation/middleName|string|Target - Middle name: Displays the contact's middle name.| x |
|personTargetRelation/fullName|stringorPK|Target - Contact: Displays the contact to which an item is linked| x |
|personTargetRelation/contactId|int|Target - Company ID: Database ID of company| x |
|personTargetRelation/hasInfoText|bool|Target - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|personTargetRelation/hasInterests|bool|Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personTargetRelation/personHasInterests|bool|Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personTargetRelation/mrMrs|string|Target - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personTargetRelation/position|listAny|Target - Position| x |
|personTargetRelation/personNumber|string|Target - Number: Displays the contact's number| x |
|personTargetRelation/title|string|Target - Title: Displays the contact's job title| x |
|personTargetRelation/personCountry|listAny|Target - Country: Country| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personTargetRelation/personCountryId|int|Target - Country ID: Country ID| x |
|personTargetRelation/personNoMail|bool|Target - No Mailings: Displays the contact's No Mailings checkbox| x |
|personTargetRelation/rank|int|Target - Rank: Displays a contact's current rank| x |
|personTargetRelation/birthdate| *None* |Target - Birthdate: Displays the contact's date of birth|  |
|personTargetRelation/associateType| *None* |Target - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personTargetRelation/useAsMailingAddress|bool|Target - Use as postal address: Use as postal address| x |
|personTargetRelation/personSource|listAny|Target - Source: Source (Contact)| x |
|personTargetRelation/retired|bool|Target - Former employee: Indicates whether the contact has retired/left the company| x |
|personTargetRelation/birthYear|int|Target - Birth year: Displays contact's birth year| x |
|personTargetRelation/birthMonth|int|Target - Birth month: Displays contact's birth month| x |
|personTargetRelation/birthDay|int|Target - Birth day: Displays contact's birth day (day of month)| x |
|personTargetRelation/kanaFirstName|string|Target - First name, kana: Contact's first name, in kana alphabet| x |
|personTargetRelation/kanaLastName|string|Target - Last name, kana: Contact's last name, in kana alphabet| x |
|personTargetRelation/personUpdatedBy|associate|Target - Updated by: The user who last updated the data| x |
|personTargetRelation/personUpdatedByFullName|associate|Target - Updated by - Full name: The user who last updated the data| x |
|personTargetRelation/personUpdatedDate|date|Target - Updated: The date/time the data was last updated in UTC.| x |
|personTargetRelation/personRegisteredBy|associate|Target - Registered by: The user who registered the data| x |
|personTargetRelation/personRegisteredByFullName|associate|Target - Registered by - Full name: The user who registered the data| x |
|personTargetRelation/personRegisteredDate|date|Target - Registered date: The date/time the data was registered in UTC.| x |
|personTargetRelation/portraitThumbnail| *None* |Target - Person image: Person image|  |
|personTargetRelation/personActiveErpLinks|bool|Target - ERP connected: Is there an active ERP Sync?| x |
|personTargetRelation/ticketPriority|listAny|Target - Service priority: Default service priority for this contact| x |
|personTargetRelation/supportLanguage|listAny|Target - Preferred language: Preferred language used for reply templates and more| x |
|personTargetRelation/supportAssociate|associate|Target - Our service contact: Default service contact for this contact| x |
|personTargetRelation/supportAssociateFullName|associate|Target - Our service contact - Full name: Default service contact for this contact| x |
|personTargetRelation/personAssociateId|associate|Target - Our contact: Displays our contact| x |
|personTargetRelation/personAssociateFullName|associate|Target - Our contact - Full name: Displays our contact| x |
|personTargetRelation/personCategory|listAny|Target - Category| x |
|personTargetRelation/personBusiness|listAny|Target - Business| x |
|personTargetRelation/personDeletedDate|datetime|Target - Deleted date: Deleted date|  |
|personTargetRelation/hasCompany|bool|Target - Has company: The contact is associated with a company| x |
|personTargetRelation/isProjectMember|bool|Target - Is project member: This person is a project member| x |
|personTargetRelation/isStakeholder|bool|Target - Is stakeholder: This person is a sale stakeholder| x |
|personTargetRelation/restrictionContactId|int|Target - Company ID: Database ID of company to fetch relations for|  |
|personTargetRelation/restrictionPersonId|int|Target - Company ID: Database ID of company to fetch relations for|  |
|personTargetRelation/who| *None* |Target - Full name: Full name of company/contact| x |
|personTargetRelation/personPersonRelation|listAny|Target - Contact-to-contact relation: Name of relation, not taking into account the relation direction| x |
|personSourceRelation/personContactRelation|listAny|Source - Contact-to-company relation: Name of relation, not taking into account the relation direction| x |
|personTargetRelation/contactPersonRelation|listAny|Target - Company-to-contact relation: Name of relation, not taking into account the relation direction| x |
|personAssociate/firstName|string|First name: Displays the contact's first name| x |
|personAssociate/lastName|string|Last name: Displays the contact's last name| x |
|personAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|personAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|personAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|personAssociate/associateDbId|associate|ID| x |
|personAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|personAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|personAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|personAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|personAssociate/contactCategory|listAny|Category: Category| x |
|personAssociate/role|listAny|Role : Role| x |
|personAssociate/assocName|associate|User ID : User ID| x |
|personAssociate/assocTooltip|string|Description : Description|  |
|personAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|personAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|personAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|personAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|personAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|personAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|personAssociate/userName|string|User name: User name| x |
|personAssociate/personEmail|string|E-mail| x |
|correspondingAssociate/firstName|string|First name: Displays the contact's first name| x |
|correspondingAssociate/lastName|string|Last name: Displays the contact's last name| x |
|correspondingAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|correspondingAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|correspondingAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|correspondingAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|correspondingAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|correspondingAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|correspondingAssociate/associateDbId|associate|ID| x |
|correspondingAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|correspondingAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|correspondingAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|correspondingAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|correspondingAssociate/contactCategory|listAny|Category: Category| x |
|correspondingAssociate/role|listAny|Role : Role| x |
|correspondingAssociate/assocName|associate|User ID : User ID| x |
|correspondingAssociate/assocTooltip|string|Description : Description|  |
|correspondingAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|correspondingAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|correspondingAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|correspondingAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|correspondingAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|correspondingAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|correspondingAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|correspondingAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|correspondingAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|correspondingAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|correspondingAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|correspondingAssociate/userName|string|User name: User name| x |
|correspondingAssociate/personEmail|string|E-mail| x |
|personContact/contactId|int|Company ID: Database ID of company| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/name|stringorPK|Company name| x |
|personContact/department|string|Department| x |
|personContact/nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|personContact/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|personContact/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|personContact/associateId|associate|Our contact: Displays our contact| x |
|personContact/category|listAny|Category| x |
|personContact/business|listAny|Business| x |
|personContact/country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|personContact/countryId|int|Country ID: Country ID| x |
|personContact/number|string|Number| x |
|personContact/code|string|Code| x |
|personContact/orgnr|string|VAT No.| x |
|personContact/stop|bool|Stop| x |
|personContact/contactNoMail|bool|No mailings (company| x |
|personContact/updatedBy|associate|Updated by: The user who last updated the data| x |
|personContact/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|personContact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|personContact/registeredBy|associate|Registered by: The user who registered the data| x |
|personContact/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|personContact/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|personContact/contactSource|listAny|Source: Source (Company)| x |
|personContact/contactDeleted|bool|Deleted: Deleted| x |
|personContact/phone/formattedNumber|string|Phone : Displays phone number|  |
|personContact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|personContact/deletedDate|datetime|Deleted date: Deleted date|  |
|personContact/mainContact| *None* |Main contact: Main contact for this company| x |
|personContact/contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|personContact/contactPhone/description|string|Telephone - Description: Phone number description| x |
|personContact/contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|personContact/contactFax/description|string|Fax - Description: Phone number description| x |
|personContact/searchPhone/formattedNumber|string|Searchphone - Phone: Displays phone number|  |
|personContact/searchPhone/description|string|Searchphone - Description: Phone number description| x |
|personContact/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|personContact/email/emailAddress|string|E-mail| x |
|personContact/email/emailDescription|string|Description| x |
|personContact/email/emailId|int|ID| x |
|personContact/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|personContact/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|personContact/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|personContact/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|personContact/postAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|personContact/postAddress/line1|string|Postal address - Address 1: First line of the address| x |
|personContact/postAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|personContact/postAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|personContact/postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|personContact/postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|personContact/postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|personContact/postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|personContact/postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|personContact/postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|personContact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionPostalAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|personContact/restrictionPostalAddress/line1|string|Postal address - Address 1: First line of the address| x |
|personContact/restrictionPostalAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|personContact/restrictionPostalAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|personContact/restrictionPostalAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|personContact/restrictionPostalAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|personContact/restrictionPostalAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|personContact/restrictionPostalAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|personContact/restrictionPostalAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|personContact/restrictionPostalAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|personContact/restrictionPostalAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionPostalAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/addressId|int|Street address - Address ID: Database ID for the address record| x |
|personContact/streetAddress/line1|string|Street address - Address 1: First line of the address| x |
|personContact/streetAddress/line2|string|Street address - Address 2: Second line of the address| x |
|personContact/streetAddress/line3|string|Street address - Address 3: Third line of the address| x |
|personContact/streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|personContact/streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.| x |
|personContact/streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|personContact/streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|personContact/streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude| x |
|personContact/streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude| x |
|personContact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|personContact/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|personContact/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|personContact/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|personContact/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|personContact/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|personContact/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|personContact/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|personContact/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|personContact/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|personContact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|personContact/url/URLAddress|string|URL| x |
|personContact/url/URLDescription|string|Description| x |
|personContact/contactAssociate/firstName|string|First name: Displays the contact's first name| x |
|personContact/contactAssociate/lastName|string|Last name: Displays the contact's last name| x |
|personContact/contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|personContact/contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personContact/contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personContact/contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|personContact/contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personContact/contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|personContact/contactAssociate/associateDbId|associate|ID| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/contactAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|personContact/contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|personContact/contactAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|personContact/contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|personContact/contactAssociate/contactCategory|listAny|Category: Category| x |
|personContact/contactAssociate/role|listAny|Role : Role| x |
|personContact/contactAssociate/assocName|associate|User ID : User ID| x |
|personContact/contactAssociate/assocTooltip|string|Description : Description|  |
|personContact/contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|personContact/contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|personContact/contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personContact/contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|personContact/contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personContact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|personContact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personContact/contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|personContact/contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|personContact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|personContact/contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|personContact/contactAssociate/userName|string|User name: User name| x |
|personContact/contactAssociate/personEmail|string|E-mail| x |
|personContact/contactSupportAssociate/firstName|string|Our service contact - First name: Displays the contact's first name| x |
|personContact/contactSupportAssociate/lastName|string|Our service contact - Last name: Displays the contact's last name| x |
|personContact/contactSupportAssociate/middleName|string|Our service contact - Middle Name: Displays the contact's middle name.| x |
|personContact/contactSupportAssociate/fullName|string|Our service contact - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personContact/contactSupportAssociate/contactId|int|Our service contact - Company ID: Database ID of the company the user belongs to|  |
|personContact/contactSupportAssociate/personId|int|Our service contact - Contact ID: Database ID of the contact row|  |
|personContact/contactSupportAssociate/mrMrs|string|Our service contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personContact/contactSupportAssociate/title|string|Our service contact - Title: Displays whether the contact is addressed as Mr or Ms| x |
|personContact/contactSupportAssociate/associateDbId|associate|Our service contact - ID| x |
|personContact/contactSupportAssociate/contactName|string|Our service contact - Owning company: Name of the company the user belongs to| x |
|personContact/contactSupportAssociate/contactDepartment|string|Our service contact - Owning department: Name of the department at the company the user belongs to| x |
|personContact/contactSupportAssociate/usergroup|userGroup|Our service contact - Primary group: The user's primary user group| x |
|personContact/contactSupportAssociate/contactFullName|string|Our service contact - Owner: Name and department of the company the user belongs to| x |
|personContact/contactSupportAssociate/contactCategory|listAny|Our service contact - Category: Category| x |
|personContact/contactSupportAssociate/role|listAny|Our service contact - Role: Role| x |
|personContact/contactSupportAssociate/assocName|associate|Our service contact - User ID: User ID| x |
|personContact/contactSupportAssociate/assocTooltip|string|Our service contact - Description: Description|  |
|personContact/contactSupportAssociate/assocType|listAny|Our service contact - Type: Type of user: associate, external user, system user, anonymous account| x |
|personContact/contactSupportAssociate/ejUserId|int|Our service contact - Service user ID: The database ID of a Service user|  |
|personContact/contactSupportAssociate/simultaneousEjUser|bool|Our service contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personContact/contactSupportAssociate/ejDisplayName|string|Our service contact - Nick name: User's nick name in Service| x |
|personContact/contactSupportAssociate/ejStatus|int|Our service contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personContact/contactSupportAssociate/credentialType| *None* |Our service contact - Auth. type: What type of credentials to use when this user logs in| x |
|personContact/contactSupportAssociate/credentialDisplayValue| *None* |Our service contact - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personContact/contactSupportAssociate/isActive|bool|Our service contact - Active: Is this user active, and should be able to log in?| x |
|personContact/contactSupportAssociate/isActiveText|bool|Our service contact - Active status: Is this user active, and should be able to log in?| x |
|personContact/contactSupportAssociate/portraitThumbnail| *None* |Our service contact - Person image: Person image|  |
|personContact/contactSupportAssociate/otherGroups|userGroup|Our service contact - Other groups: Other groups|  |
|personContact/contactSupportAssociate/userName|string|Our service contact - User name: User name| x |
|personContact/contactSupportAssociate/personEmail|string|Our service contact - E-mail| x |
|personContact/contactSupportPerson/personId|int|User support contact - DB ID: Displays the database ID of a contact| x |
|personContact/contactSupportPerson/firstName|string|User support contact - First name: Displays the contact's first name| x |
|personContact/contactSupportPerson/lastName|string|User support contact - Last name: Displays the contact's last name| x |
|personContact/contactSupportPerson/middleName|string|User support contact - Middle name: Displays the contact's middle name.| x |
|personContact/contactSupportPerson/fullName|stringorPK|User support contact - Contact: Displays the contact to which an item is linked| x |
|personContact/contactSupportPerson/contactId|int|User support contact - Company ID: Database ID of company| x |
|personContact/contactSupportPerson/hasInfoText|bool|User support contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|personContact/contactSupportPerson/hasInterests|bool|User support contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personContact/contactSupportPerson/personHasInterests|bool|User support contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personContact/contactSupportPerson/mrMrs|string|User support contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personContact/contactSupportPerson/position|listAny|User support contact - Position| x |
|personContact/contactSupportPerson/personNumber|string|User support contact - Number: Displays the contact's number| x |
|personContact/contactSupportPerson/title|string|User support contact - Title: Displays the contact's job title| x |
|personContact/contactSupportPerson/personCountry|listAny|User support contact - Country: Country| x |
|personContact/contactSupportPerson/personCountryId|int|User support contact - Country ID: Country ID| x |
|personContact/contactSupportPerson/personNoMail|bool|User support contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|personContact/contactSupportPerson/rank|int|User support contact - Rank: Displays a contact's current rank| x |
|personContact/contactSupportPerson/birthdate| *None* |User support contact - Birthdate: Displays the contact's date of birth|  |
|personContact/contactSupportPerson/associateType| *None* |User support contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personContact/contactSupportPerson/useAsMailingAddress|bool|User support contact - Use as postal address: Use as postal address| x |
|personContact/contactSupportPerson/personSource|listAny|User support contact - Source: Source (Contact)| x |
|personContact/contactSupportPerson/retired|bool|User support contact - Former employee: Indicates whether the contact has retired/left the company| x |
|personContact/contactSupportPerson/birthYear|int|User support contact - Birth year: Displays contact's birth year| x |
|personContact/contactSupportPerson/birthMonth|int|User support contact - Birth month: Displays contact's birth month| x |
|personContact/contactSupportPerson/birthDay|int|User support contact - Birth day: Displays contact's birth day (day of month)| x |
|personContact/contactSupportPerson/kanaFirstName|string|User support contact - First name, kana: Contact's first name, in kana alphabet| x |
|personContact/contactSupportPerson/kanaLastName|string|User support contact - Last name, kana: Contact's last name, in kana alphabet| x |
|personContact/contactSupportPerson/personUpdatedBy|associate|User support contact - Updated by: The user who last updated the data| x |
|personContact/contactSupportPerson/personUpdatedByFullName|associate|User support contact - Updated by - Full name: The user who last updated the data| x |
|personContact/contactSupportPerson/personUpdatedDate|date|User support contact - Updated: The date/time the data was last updated in UTC.| x |
|personContact/contactSupportPerson/personRegisteredBy|associate|User support contact - Registered by: The user who registered the data| x |
|personContact/contactSupportPerson/personRegisteredByFullName|associate|User support contact - Registered by - Full name: The user who registered the data| x |
|personContact/contactSupportPerson/personRegisteredDate|date|User support contact - Registered date: The date/time the data was registered in UTC.| x |
|personContact/contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|personContact/contactSupportPerson/personActiveErpLinks|bool|User support contact - ERP connected: Is there an active ERP Sync?| x |
|personContact/contactSupportPerson/ticketPriority|listAny|User support contact - Service priority: Default service priority for this contact| x |
|personContact/contactSupportPerson/supportLanguage|listAny|User support contact - Preferred language: Preferred language used for reply templates and more| x |
|personContact/contactSupportPerson/supportAssociate|associate|User support contact - Our service contact: Default service contact for this contact| x |
|personContact/contactSupportPerson/supportAssociateFullName|associate|User support contact - Our service contact - Full name: Default service contact for this contact| x |
|personContact/contactSupportPerson/personAssociateId|associate|User support contact - Our contact: Displays our contact| x |
|personContact/contactSupportPerson/personAssociateFullName|associate|User support contact - Our contact - Full name: Displays our contact| x |
|personContact/contactSupportPerson/personCategory|listAny|User support contact - Category| x |
|personContact/contactSupportPerson/personBusiness|listAny|User support contact - Business| x |
|personContact/contactSupportPerson/personDeletedDate|datetime|User support contact - Deleted date: Deleted date|  |
|personContact/contactSupportPerson/hasCompany|bool|User support contact - Has company: The contact is associated with a company| x |
|personContact/contactSupportPerson/isProjectMember|bool|User support contact - Is project member: This person is a project member| x |
|personContact/contactSupportPerson/isStakeholder|bool|User support contact - Is stakeholder: This person is a sale stakeholder| x |
|personContact/contactSupportPerson/who| *None* |User support contact - Full name: Displays the contact's full name.| x |
|personContact/contactSupportPerson/personInfo/textId|int|User support contact - Text ID| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/contactSupportPerson/personInfo/infoText|positiveString|User support contact - Information: Displays the text entered in the description field| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:1|string|User support contact - contactshorttext: tooltipshorttext| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:2|string|User support contact - contactlongtext: tooltiplongtext| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:3|int|User support contact - contactnumber| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:4|date|User support contact - contactdate| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:5|unlimitedDate|User support contact - contactunlimiteddate: tooltipunlimiteddate| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:6|bool|User support contact - contactcheckbox| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:7|listAny|User support contact - contactdropdownlistbox| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:8|decimal|User support contact - contactdecimal| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:9|string|User support contact - page1saleonly| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:10|string|User support contact - page1marketingonly| x |
|personContact/contactSupportPerson/personUdef/SuperOffice:11|string|User support contact - page1adminonly| x |
|personContact/contactSupportPerson/personExtra/x\_person\_integer|int|User support contact - Extra Integer: Custom person integer| x |
|personContact/contactSupportPerson/personExtra/x\_person\_hidden\_integer|int|User support contact - Extra hidden integer: Custom integer field that is hidden| x |
|personContact/contactSupportPerson/personExtra/x\_person\_float|decimal|User support contact - Extra float: Custom float field| x |
|personContact/contactSupportPerson/personExtra/x\_person\_longtext|string|User support contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|personContact/contactSupportPerson/personExtra/x\_person\_date|date|User support contact - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|personContact/contactSupportPerson/personExtra/x\_person\_datetime|datetime|User support contact - Extra DateTime: Custom person date and time field. No default| x |
|personContact/contactSupportPerson/personExtra/x\_person\_time| *None* |User support contact - Extra time: Custom time field on person. Current time as default| x |
|personContact/contactSupportPerson/personExtra/x\_person\_boolean|bool|User support contact - Extra Boolean: Custom boolean field on person. Default checked| x |
|personContact/contactSupportPerson/personExtra/x\_person\_timespan|timeSpan|User support contact - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|personContact/contactSupportPerson/personExtra/x\_person\_shorttext|string|User support contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|personContact/contactSupportPerson/personExtra/x\_person\_shorttext\_list|listAny|User support contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|personContact/contactSupportPerson/personExtra/x\_person\_user\_relation|associate|User support contact - Extra user relation: Custom person-user relation field| x |
|personContact/contactSupportPerson/personExtra/x\_person\_category\_relation|listAny|User support contact - Extra category relation: Custom person-category relation| x |
|personContact/contactSupportPerson/personExtra/x\_person\_priority\_relation|listAny|User support contact - Extra priority relation: Custom person-priority relation| x |
|personContact/contactSupportPerson/personExtra/x\_person\_request\_relation|stringorPK|User support contact - Extra request relation: Request relation on contact| x |
|personContact/contactSupportPerson/personExtra/x\_person\_appointment\_relation|stringorPK|User support contact - Extra appointment relation: Appointment relation on person| x |
|personContact/contactSupportPerson/personExtra/x\_person\_contact\_relation|stringorPK|User support contact - Extra company relation: Company relation on contact| x |
|personContact/contactSupportPerson/personExtra/y\_rental/id|int|User support contact - Rental - id: Displays the row's primary key (y\_rental)| x |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_start|date|User support contact - Rental - Start rental| x |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_end|date|User support contact - Rental - End| x |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_amount|int|User support contact - Rental - Amount: Number to rent. Default = 1| x |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_contact|stringorPK|User support contact - Rental - Renter: Company that rents equipment| x |
|personContact/contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name|string|User support contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|personContact/contactSupportPerson/isMailingRecipient|bool|User support contact - Is mailing recipient: isMailingRecipient| x |
|personContact/contactSupportPerson/hasStoreConsent|bool|User support contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|personContact/contactSupportPerson/withdrawnStoreConsent|bool|User support contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|personContact/contactSupportPerson/hasEmarketingConsent|bool|User support contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|personContact/contactSupportPerson/withdrawnEmarketingConsent|bool|User support contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|personContact/contactSupportPerson/subscription|listAny|User support contact - Subscription: Subscription for marketing| x |
|personContact/contactSupportPerson/legalBaseStore|listAny|User support contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|personContact/contactSupportPerson/legalBaseEmarketing|listAny|User support contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|personContact/contactSupportPerson/consentSourceStore|listAny|User support contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|personContact/contactSupportPerson/consentSourceEmarketing|listAny|User support contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|personContact/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|personContact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|personContact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|personContact/contactUdef/SuperOffice:3|int|companynumber| x |
|personContact/contactUdef/SuperOffice:4|date|companydate| x |
|personContact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|personContact/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|personContact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|personContact/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|personContact/contactUdef/SuperOffice:9|string|page1saleonly| x |
|personContact/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|personContact/contactUdef/SuperOffice:11|string|page1adminonly| x |
|personContact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|personContact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|personContact/contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|personContact/contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|personContact/contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|personContact/contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|personContact/contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|personContact/contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|personContact/contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|personContact/contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|personContact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|personContact/contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|personContact/contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|personContact/contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|personContact/contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|personContact/contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|personContact/contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|personContact/contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
|personContact/NumberOfActivities|int|Number of activities|  |
|personContact/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|personContact/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|personContact/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|personContact/LastActivity|date|Date of last activity|  |
|personContact/LastCompletedActivity|date|Date of last completed activity|  |
|personContact/LastDoByActivity|date|Date of last non-completed activity|  |
|personContact/NumberOfSales|int|Number of sales|  |
|personContact/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|personContact/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|personContact/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|personContact/LastSale|date|Date of last sale|  |
|personContact/LastCompletedSale|date|Date of last completed sale|  |
|personContact/LastDoBySale|date|Date of last non-completed sale|  |
|personContact/NumberOfTickets|int|Number of requests|  |
|personContact/NumberOfTicketsInPeriod|int|Number of requests in last 90 days|  |
|personContact/NumberOfNotCompletedTickets|int|Number of non-completed requests|  |
|personContact/NumberOfNotCompletedTicketsInPeriod|int|Number of non-completed requests in last 90 days|  |
|personContact/LastTicket|date|Date of last request|  |
|personContact/LastCompletedTicket|date|Date of last completed request|  |
|personContact/LastDoByTicket|date|Date of last non-completed request|  |
|personContact/SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|personContact/SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|personContact/saintSaleStatus|listAny|With status|  |
|personContact/saintAmountClass|listAny|Amount class|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/saintActivityType|listAny|SAINT type|  |
|personContact/saintDirection|listAny|Direction|  |
|personContact/saintIntention|listAny|Intention|  |
|personContact/saintTicketStatus|listAny|Status|  |
|personContact/saintTicketCategory|listAny|Category|  |
|personContact/selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|personContact/selectionIdRequest|int|Selection ID: Database ID of selection which members are to be fetched from|  |
|isMailingRecipient|bool|Is mailing recipient: isMailingRecipient| x |
|hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|subscription|listAny|Subscription: Subscription for marketing| x |
|legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|request/contactId|int|Company ID: Database ID of company| x |
|request/personId|int|Contact ID: Database ID of the contact row| x |
|request/saleId|int|Sale ID: The database ID of the sale record| x |
|request/projectId|int|Project ID: Database ID of project record| x |
|request/ticketStatusName|listAny|Status: Request status| x |
|request/categoryFullName|ejCategory|Category: Request category| x |
|request/priorityName|listAny|Priority: Service priority| x |
|request/ticketId|int|ID: Displays request ID| x |
|request/title|string|Title: Displays the request title| x |
|request/createdAt|datetime|Created: Displays when the request was created| x |
|request/lastChanged|datetime|Last changed: Displays when the request was last changed| x |
|request/author|string|Author: Displays the author of the request| x |
|request/readByOwner|datetime|Read by owner: Displays when the request was read by the owner| x |
|request/firstReadByOwner|datetime|First read by owner: Displays when the request was read by owner for the first time| x |
|request/firstReadByUser|datetime|First read by user: Displays when the request was read by user for the first time| x |
|request/readByCustomer|datetime|Read by contact: Displays when the request was read by the contact| x |
|request/status|listAny|Internal status: Shows only system defined statuses for a request| x |
|request/origin|listAny|Origin: Origin| x |
|request/slevel|listAny|Access level: Access level| x |
|request/numberOfMessages|int|Number of messages: Number of messages| x |
|request/numberOfReplies|int|Number of replies: Number of replies| x |
|request/connectId|int|Merged with request: Merged with request| x |
|request/readStatus|listAny|Read: Read| x |
|request/realTimeSpentQueue|timeSpan|Real time in queue: Real time in queue| x |
|request/realTimeSpentExternally|timeSpan|Real time externally: Real time externally| x |
|request/realTimeSpentInternally|timeSpan|Real time internally: Real time internally| x |
|request/timeSpentQueue|timeSpan|Time spent in queue: Time spent in queue| x |
|request/timeSpentExternally|timeSpan|Time spent externally: Time spent externally| x |
|request/timeSpentInternally|timeSpan|Time spent internally: Time spent internally| x |
|request/timeSpent|timeSpan|Time spent: Time spent| x |
|request/timeToReply|timeSpan|Time to reply: Time to reply| x |
|request/timeToClose|timeSpan|Time to close: Time to close| x |
|request/realTimeToReply|timeSpan|Real time to reply: Real time to reply| x |
|request/realTimeToClose|timeSpan|Real time to close: Real time to close| x |
|request/repliedAt|datetime|Replied at: Replied at| x |
|request/closedAt|datetime|Closed at: Closed at| x |
|request/activated|datetime|Postponed to: Postponed to| x |
|request/deadline|datetime|Deadline: Deadline| x |
|request/has\_attachment|bool|Has attachment: Indicates whether the e-mail has one or more attachments| x |
|request/tags|intArray|Tags: Tags connected to a request| x |
|request/ownedBy|ejUser|Owner: The owner of the request| x |
|request/content|string|Content: Search for content in messages related to requests| x |
|request/messageLanguage|listAny|Language: Recognized language in messages|  |
|request/sentimentScore|listAny|Sentiment: Sentiment score, -100 to +100|  |
|request/suggestedCategory|listAny|Sugg.Cat.: Suggested service category|  |
|request/createdBy/firstName|string|Created by - First name: Displays the contact's first name| x |
|request/createdBy/lastName|string|Created by - Last name: Displays the contact's last name| x |
|request/createdBy/middleName|string|Created by - Middle Name: Displays the contact's middle name.| x |
|request/createdBy/fullName|string|Created by - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|request/createdBy/contactId|int|Created by - Company ID: Database ID of the company the user belongs to|  |
|request/createdBy/personId|int|Created by - Contact ID: Database ID of the contact row|  |
|request/createdBy/mrMrs|string|Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|request/createdBy/title|string|Created by - Title: Displays whether the contact is addressed as Mr or Ms| x |
|request/createdBy/associateDbId|associate|Created by - ID| x |
|request/createdBy/contactName|string|Created by - Owning company: Name of the company the user belongs to| x |
|request/createdBy/contactDepartment|string|Created by - Owning department: Name of the department at the company the user belongs to| x |
|request/createdBy/usergroup|userGroup|Created by - Primary group: The user's primary user group| x |
|request/createdBy/contactFullName|string|Created by - Owner: Name and department of the company the user belongs to| x |
|request/createdBy/contactCategory|listAny|Created by - Category: Category| x |
|request/createdBy/role|listAny|Created by - Role: Role| x |
|request/createdBy/assocName|associate|Created by - User ID: User ID| x |
|request/createdBy/assocTooltip|string|Created by - Description: Description|  |
|request/createdBy/assocType|listAny|Created by - Type: Type of user: associate, external user, system user, anonymous account| x |
|request/createdBy/ejUserId|int|Created by - Service user ID: The database ID of a Service user|  |
|request/createdBy/simultaneousEjUser|bool|Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/createdBy/ejDisplayName|string|Created by - Nick name: User's nick name in Service| x |
|request/createdBy/ejStatus|int|Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in| x |
|request/createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|request/createdBy/isActive|bool|Created by - Active: Is this user active, and should be able to log in?| x |
|request/createdBy/isActiveText|bool|Created by - Active status: Is this user active, and should be able to log in?| x |
|request/createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|request/createdBy/otherGroups|userGroup|Created by - Other groups: Other groups|  |
|request/createdBy/userName|string|Created by - User name: User name| x |
|request/createdBy/personEmail|string|Created by - E-mail| x |
|request/ownedBy/firstName|string|Owner - First name: Displays the contact's first name| x |
|request/ownedBy/lastName|string|Owner - Last name: Displays the contact's last name| x |
|request/ownedBy/middleName|string|Owner - Middle Name: Displays the contact's middle name.| x |
|request/ownedBy/fullName|string|Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|request/ownedBy/contactId|int|Owner - Company ID: Database ID of the company the user belongs to|  |
|request/ownedBy/personId|int|Owner - Contact ID: Database ID of the contact row|  |
|request/ownedBy/mrMrs|string|Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|request/ownedBy/title|string|Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|request/ownedBy/associateDbId|associate|Owner - ID| x |
|request/ownedBy/contactName|string|Owner - Owning company: Name of the company the user belongs to| x |
|request/ownedBy/contactDepartment|string|Owner - Owning department: Name of the department at the company the user belongs to| x |
|request/ownedBy/usergroup|userGroup|Owner - Primary group: The user's primary user group| x |
|request/ownedBy/contactFullName|string|Owner - Owner: Name and department of the company the user belongs to| x |
|request/ownedBy/contactCategory|listAny|Owner - Category: Category| x |
|request/ownedBy/role|listAny|Owner - Role: Role| x |
|request/ownedBy/assocName|associate|Owner - User ID: User ID| x |
|request/ownedBy/assocTooltip|string|Owner - Description: Description|  |
|request/ownedBy/assocType|listAny|Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|request/ownedBy/ejUserId|int|Owner - Service user ID: The database ID of a Service user|  |
|request/ownedBy/simultaneousEjUser|bool|Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/ownedBy/ejDisplayName|string|Owner - Nick name: User's nick name in Service| x |
|request/ownedBy/ejStatus|int|Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in| x |
|request/ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|request/ownedBy/isActive|bool|Owner - Active: Is this user active, and should be able to log in?| x |
|request/ownedBy/isActiveText|bool|Owner - Active status: Is this user active, and should be able to log in?| x |
|request/ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|request/ownedBy/otherGroups|userGroup|Owner - Other groups: Other groups|  |
|request/ownedBy/userName|string|Owner - User name: User name| x |
|request/ownedBy/personEmail|string|Owner - E-mail| x |
|request/extra/x\_ticket\_integer|int|Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|request/extra/x\_ticket\_float|decimal|Extra float: Custom float on Request. 2 decimal places| x |
|request/extra/x\_ticket\_longtext|string|Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|request/extra/x\_ticket\_date|date|Extra date: Custom date field on Request. No default value| x |
|request/extra/x\_ticket\_datetime|datetime|Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|request/extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|request/extra/x\_ticket\_boolean|bool|Extra boolean: Custom boolean on Ticket.| x |
|request/extra/x\_ticket\_timespan|timeSpan|Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|request/extra/x\_ticket\_short\_text|string|Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|request/extra/x\_ticket\_shorttext\_list|listAny|Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |
|request/extra/x\_ticket\_timestamp|datetime|Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|request/extra/x\_ticket\_project\_relation|stringorPK|Extra project: Custom project relation on Request| x |
|request/extra/x\_ticket\_faq|stringorPK|Extra FAQ Relation| x |
|request/extra/x\_ticket\_category\_relation|listAny|Extra category relation: Category relation on request| x |
|request/extra/y\_equipment/x\_name|string|Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|projectMembers/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|projectMembers/projectId|int|DB ID: Displays the database ID for a project row| x |
|projectMembers/name|stringorPK|Project name: Displays the Project's name| x |
|projectMembers/number|string|Number: Displays the project's number| x |
|projectMembers/type|listAny|Project type: Displays the project's type| x |
|projectMembers/status|listAny|Status: Displays the project's status| x |
|projectMembers/statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|projectMembers/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|projectMembers/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|projectMembers/icon| *None* |Category: Displays the icon for an activity type| x |
|projectMembers/text|string|Text: Displays a descriptive text for the item| x |
|projectMembers/description|string|Description : Description| x |
|projectMembers/updatedBy|associate|Updated by: The user who last updated the data| x |
|projectMembers/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|projectMembers/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|projectMembers/registeredBy|associate|Registered by: The user who registered the data| x |
|projectMembers/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|projectMembers/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|projectMembers/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|projectMembers/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|projectMembers/endDate|date|End date: End date of project| x |
|projectMembers/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|projectMembers/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|projectMembers/function|listAny|Function: Displays the project member's function in the project| x |
|projectMembers/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|projectMembers/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|projectMembers/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|projectMembers/projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectMembers/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|projectMembers/projectEvent/eventDate|date|Event date: Event date| x |
|projectMembers/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|projectMembers/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|projectMembers/projectUrl/URLAddress|string|URL| x |
|projectMembers/projectUrl/URLDescription|string|Description| x |
|projectMembers/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|projectMembers/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|projectMembers/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|projectMembers/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|projectMembers/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|projectMembers/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|projectMembers/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/associateDbId|associate|ID| x |
|projectMembers/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|projectMembers/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|projectMembers/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|projectMembers/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|projectMembers/projectAssociate/contactCategory|listAny|Category: Category| x |
|projectMembers/projectAssociate/role|listAny|Role : Role| x |
|projectMembers/projectAssociate/assocName|associate|User ID : User ID| x |
|projectMembers/projectAssociate/assocTooltip|string|Description : Description|  |
|projectMembers/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|projectMembers/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|projectMembers/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectMembers/projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|projectMembers/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectMembers/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|projectMembers/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|projectMembers/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|projectMembers/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|projectMembers/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectMembers/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|projectMembers/projectAssociate/userName|string|User name: User name| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMembers/projectAssociate/personEmail|string|E-mail| x |
|projectMembers/projectUdef/SuperOffice:1|string|projectshorttext| x |
|projectMembers/projectUdef/SuperOffice:2|string|projectlongtext| x |
|projectMembers/projectUdef/SuperOffice:3|int|projectnumber| x |
|projectMembers/projectUdef/SuperOffice:4|date|projectdate| x |
|projectMembers/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|projectMembers/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|projectMembers/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|projectMembers/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|projectMembers/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|projectMembers/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|projectMembers/NumberOfActivities|int|Number of activities|  |
|projectMembers/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|projectMembers/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|projectMembers/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|projectMembers/LastActivity|date|Date of last activity|  |
|projectMembers/LastCompletedActivity|date|Date of last completed activity|  |
|projectMembers/LastDoByActivity|date|Date of last non-completed activity|  |
|projectMembers/NumberOfSales|int|Number of sales|  |
|projectMembers/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|projectMembers/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|projectMembers/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|projectMembers/LastSale|date|Date of last sale|  |
|projectMembers/LastCompletedSale|date|Date of last completed sale|  |
|projectMembers/LastDoBySale|date|Date of last non-completed sale|  |
|projectMembers/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|projectMembers/saintSaleStatus|listAny|With status|  |
|projectMembers/saintAmountClass|listAny|Amount class|  |
|projectMembers/saintActivityType|listAny|SAINT type|  |
|projectMembers/saintDirection|listAny|Direction|  |
|projectMembers/saintIntention|listAny|Intention|  |
|projectMembers/saintTicketStatus|listAny|Status|  |
|projectMembers/saintTicketCategory|listAny|Category|  |
|projectMembers/project/textId|int|Text ID| x |
|projectMembers/project/infoText|positiveString|Information: Displays the text entered in the description field| x |
|personAppointment/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|personAppointment/icon|listAny|Category: Displays the icon for an activity type| x |
|personAppointment/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|personAppointment/time| *None* |Time: Time|  |
|personAppointment/type|listAny|Type: Displays the type of an activity| x |
|personAppointment/recordType|string|Record type : Shows the record type| x |
|personAppointment/text|positiveString|Text: Displays a descriptive text for the item| x |
|personAppointment/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|personAppointment/contactId|listAny|Company ID: Database ID of company| x |
|personAppointment/personId|listAny|Contact ID: Database ID of the contact row| x |
|personAppointment/projectId|listAny|Project ID: Database ID of project record| x |
|personAppointment/saleId|int|Sale ID: The database ID of the sale record| x |
|personAppointment/userGroup|userGroup|User group : The user group that owns the record| x |
|personAppointment/who| *None* |Who: Contact and/or company|  |
|personAppointment/updatedBy|associate|Updated by: The user who last updated the data| x |
|personAppointment/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|personAppointment/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|personAppointment/registeredBy|associate|Registered by: The user who registered the data| x |
|personAppointment/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|personAppointment/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|personAppointment/appointmentId|int|DB ID: Displays the database ID of a row| x |
|personAppointment/endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|personAppointment/priority|listAny|Priority: Displays the priority of the activity| x |
|personAppointment/alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|personAppointment/recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|personAppointment/booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|personAppointment/intention|listAny|Intention: Displays the intention of the follow-up type| x |
|personAppointment/location|string|Location: Display the location where the follow-up will take place.| x |
|personAppointment/recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up| x |
|personAppointment/rawType|int|Type: Type field for appointment, not decoded or formatted| x |
|personAppointment/rawStatus|int|Status: Status field for the follow-up, not decoded or formatted| x |
|personAppointment/cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|personAppointment/visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?| x |
|personAppointment/endTime| *None* |End time: End time of an activity|  |
|personAppointment/suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|personAppointment/completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|personAppointment/isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|personAppointment/invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|personAppointment/recordTypeText|listAny|Activity type: The type of the activity (appointment, phone call, etc)| x |
|personAppointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|personAppointment/duration|timeSpan|Duration: The duration of the chat session|  |
|personAppointment/visibleFor|listAny|Visible for|  |
|personAppointment/appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|personAppointment/appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|personAppointment/appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|personAppointment/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|personAppointment/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|personAppointment/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|personAppointment/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|personAppointment/appointmentUdef/SuperOffice:4|date|followupdate| x |
|personAppointment/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|personAppointment/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|personAppointment/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|personAppointment/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|personAppointment/associate/firstName|string|First name: Displays the contact's first name| x |
|personAppointment/associate/lastName|string|Last name: Displays the contact's last name| x |
|personAppointment/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|personAppointment/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personAppointment/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personAppointment/associate/personId|int|Contact ID: Database ID of the contact row|  |
|personAppointment/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personAppointment/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|personAppointment/associate/associateDbId|associate|ID| x |
|personAppointment/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|personAppointment/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAppointment/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|personAppointment/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|personAppointment/associate/contactCategory|listAny|Category: Category| x |
|personAppointment/associate/role|listAny|Role : Role| x |
|personAppointment/associate/assocName|associate|User ID : User ID| x |
|personAppointment/associate/assocTooltip|string|Description : Description|  |
|personAppointment/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|personAppointment/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|personAppointment/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAppointment/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|personAppointment/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAppointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|personAppointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personAppointment/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|personAppointment/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|personAppointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|personAppointment/associate/otherGroups|userGroup|Other groups: Other groups|  |
|personAppointment/associate/userName|string|User name: User name| x |
|personAppointment/associate/personEmail|string|E-mail| x |
|personAppointment/appointment/textId|int|Text ID| x |
|personAppointment/appointment/description|positiveString|Text: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/SimplePerson?$select=personAssociateId,personExtra/y_rental/x_start,personSourceRelation/lastName,personSourceRelation/contactId,personContact/code
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

