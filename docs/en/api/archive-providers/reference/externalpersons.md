---
uid: ExternalPersons
title: ExternalPersons
description: 
keywords: ExternalPersons archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "ExternalPersons"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ExternalPersonsProvider">SuperOffice.CRM.ArchiveLists.ExternalPersonsProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"person"|Contacts|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|userId|string|User ID : User ID| x |
|isActive|bool|This is an associate.| x |
|isDeleted|bool|deleted: (deleted)| x |
|roleName|string|Role: Role| x |
|personId|int|DB ID: Displays the database ID of a contact| x |
|firstName|string|First name: Displays the contact's first name| x |
|lastName|string|Last name: Displays the contact's last name| x |
|middleName|string|Middle name: Displays the contact's middle name.| x |
|fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
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
|updatedByWorkflow|listAny|Updated by flow: Updated by flow| x |
|whenUpdatedByWorkflow|datetime|When updated by flow: When updated by flow| x |
|createdByForm|listAny|Created by form: Created by form| x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
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
|personExtra/y\_car/id|int|Car - id: Displays the row's primary key (y\_car)| x |
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
|personSourceRelation/updatedByWorkflow|listAny|Source - Updated by flow: Updated by flow| x |
|personSourceRelation/whenUpdatedByWorkflow|datetime|Source - When updated by flow: When updated by flow| x |
|personSourceRelation/createdByForm|listAny|Source - Created by form: Created by form| x |
|personSourceRelation/restrictionContactId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/restrictionPersonId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/who| *None* |Source - Full name: Full name of company/contact| x |
|personSourceRelation/personPersonRelation|listAny|Source - Contact-to-contact relation: Name of relation, not taking into account the relation direction| x |
|personTargetRelation/personId|int|Target - DB ID: Displays the database ID of a contact| x |
|personTargetRelation/firstName|string|Target - First name: Displays the contact's first name| x |
|personTargetRelation/lastName|string|Target - Last name: Displays the contact's last name| x |
|personTargetRelation/middleName|string|Target - Middle name: Displays the contact's middle name.| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|personTargetRelation/updatedByWorkflow|listAny|Target - Updated by flow: Updated by flow| x |
|personTargetRelation/whenUpdatedByWorkflow|datetime|Target - When updated by flow: When updated by flow| x |
|personTargetRelation/createdByForm|listAny|Target - Created by form: Created by form| x |
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
|personAssociate/usergroupId|int|Group ID: The user's primary user group| x |
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
|personAssociate/locationAddress|string|Location: Location| x |
|personAssociate/isLocation|bool|Is a location: Is a location| x |
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
|correspondingAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|correspondingAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|correspondingAssociate/contactCategory|listAny|Category: Category| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|correspondingAssociate/locationAddress|string|Location: Location| x |
|correspondingAssociate/isLocation|bool|Is a location: Is a location| x |
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
|request/ticketStatusId|int|Status ID: Status| x |
|request/priorityId|int|Priority ID: ID of priority in database| x |
|request/categoryId|int|Category ID: ID of ticket category in database| x |
|request/ticketTypeName|listAny|Request type: Request type| x |
|request/ticketStatusName|listAny|Status: Request status| x |
|request/categoryFullName|ejCategory|Category: Request category| x |
|request/priorityName|listAny|Priority: Service priority| x |
|request/ownedBy|ejUser|Owner: The owner of the request| x |
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
|request/createdBy|ejUser|Created by: Created by| x |
|request/content|string|Content: Search for content in messages related to requests| x |
|request/messageLanguage|listAny|Language: Recognized language in messages|  |
|request/sentimentScore|listAny|Sentiment: Sentiment score, -100 to +100|  |
|request/sentimentConfidence|int|Sentiment confidence: Sentiment confidence| x |
|request/suggestedCategory|listAny|Suggested category: Suggested service category|  |
|request/createdByWorkflow|listAny|Created by flow: Created by flow| x |
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
|request/createdBy/usergroupId|int|Created by - Group ID: The user's primary user group| x |
|request/createdBy/contactFullName|string|Created by - Owner: Name and department of the company the user belongs to| x |
|request/createdBy/contactCategory|listAny|Created by - Category: Category| x |
|request/createdBy/role|listAny|Created by - Role: Role| x |
|request/createdBy/assocName|associate|Created by - User ID: User ID| x |
|request/createdBy/assocTooltip|string|Created by - Description: Description|  |
|request/createdBy/assocType|listAny|Created by - Type: Type of user: associate, external user, system user, anonymous account| x |
|request/createdBy/ejUserId|int|Created by - Service user ID: The database ID of a Service user|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|request/createdBy/locationAddress|string|Created by - Location: Location| x |
|request/createdBy/isLocation|bool|Created by - Is a location: Is a location| x |
|request/ownedBy/firstName|string|Owner - First name: Displays the contact's first name| x |
|request/ownedBy/lastName|string|Owner - Last name: Displays the contact's last name| x |
|request/ownedBy/middleName|string|Owner - Middle Name: Displays the contact's middle name.| x |
|request/ownedBy/fullName|string|Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|request/ownedBy/contactId|int|Owner - Company ID: Database ID of the company the user belongs to|  |
|request/ownedBy/personId|int|Owner - Contact ID: Database ID of the contact row|  |
|request/ownedBy/mrMrs|string|Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|request/ownedBy/title|string|Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |
|request/ownedBy/associateDbId|associate|Owner - ID| x |
|request/ownedBy/contactName|string|Owner - Owning company: Name of the company the user belongs to| x |
|request/ownedBy/contactDepartment|string|Owner - Owning department: Name of the department at the company the user belongs to| x |
|request/ownedBy/usergroup|userGroup|Owner - Primary group: The user's primary user group| x |
|request/ownedBy/usergroupId|int|Owner - Group ID: The user's primary user group| x |
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
|request/ownedBy/locationAddress|string|Owner - Location: Location| x |
|request/ownedBy/isLocation|bool|Owner - Is a location: Is a location| x |
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
|request/extra/y\_car/id|int|Car - id: Displays the row's primary key (y\_car)| x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMembers/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|projectMembers/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|projectMembers/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/associateDbId|associate|ID| x |
|projectMembers/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|projectMembers/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|projectMembers/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|projectMembers/projectAssociate/usergroupId|int|Group ID: The user's primary user group| x |
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
|projectMembers/projectAssociate/personEmail|string|E-mail| x |
|projectMembers/projectAssociate/locationAddress|string|Location: Location| x |
|projectMembers/projectAssociate/isLocation|bool|Is a location: Is a location| x |
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
|personAppointment/isFree|bool|Is free: Displays whether the appointment should be considered free or busy| x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAppointment/isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|personAppointment/invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|personAppointment/recordTypeText|listAny|Activity type: The type of the activity (appointment, phone call, etc)| x |
|personAppointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|personAppointment/duration|timeSpan|Duration: The duration of the chat session|  |
|personAppointment/createdByWorkflow|listAny|Created by flow: Created by flow| x |
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
|personAppointment/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|personAppointment/associate/usergroupId|int|Group ID: The user's primary user group| x |
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
|personAppointment/associate/locationAddress|string|Location: Location| x |
|personAppointment/associate/isLocation|bool|Is a location: Is a location| x |
|personAppointment/appointment/description|positiveString|Text: Displays the text entered in the description field| x |
|personAppointment/appointment/title|positiveString|Title| x |
|personAppointment/appointment/titleHtml| *None* |!!Title Html| x |
|personAppointment/appointment/agenda|positiveString|Agenda| x |
|personAppointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|personAppointment/appointment/isConverted| *None* |!!Is Converted|  |
|personAppointment/appointment/textId|int|Text ID| x |
|personAppointment/appointment/internalNotes|positiveString|Internal notes: Displays the text entered in the description field| x |
|personAppointment/appointment/internalNotesHtml|positiveString|!!Internal Notes Html| x |

## Sample

```http!
GET /api/v1/archive/ExternalPersons?$select=personAppointment/associate/contactCategory,personTargetRelation/kanaFirstName,request/projectId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

