---
uid: TargetValueSub
title: TargetValueSub
description: Archive of TargetValue - used by .
keywords: TargetValueSub archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "TargetValueSub"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TargetValueSubProvider">SuperOffice.CRM.ArchiveLists.TargetValueSubProvider</see> inside NetServer's SODatabase assembly.

Archive of TargetValue - used by .

## Supported Entities
| Name | Description |
| ---- | ----- |
|"targetValue"|[targetValue]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|targetValue|int|!!Target value: !!Target value|  |
|targetPeriodNumber|int|!!TargetPeriodNumber: !!TargetPeriodNumber|  |
|targetAssociate|associate|!!TargetAssociate: !!TargetAssociate|  |
|targetContactId|int|!!TargetContact: !!TargetContact|  |
|targetUserGroup|userGroup|Primary group: The user's primary user group|  |
|targetYear|int|!!TargetYear: !!TargetYear|  |
|targetCurrency|listAny|Currency: The currency of the sale|  |
|targetPeriod|date|Date: Displays start date of a follow-up / sale date of a sale|  |
|targetPeriodType|int|targetPeriodType: targetPeriodType|  |
|targetAssignmentId|int|targetAssignmentId: targetAssignmentId|  |
|targetDimensionEntityType|listAny|!!targetDimensionEntityType: !!targetDimensionEntityType|  |
|targetDimensionMeasurementUnit|listAny|!!targetDimensionMeasurementUnit: !!targetDimensionMeasurementUnit|  |
|targetDimensionListField|string|!!targetDimensionListField: !!targetDimensionListField|  |
|targetAssignmentDimensionItemId|intArray|!!targetAssignmentDimensionItemId: !!targetAssignmentDimensionItemId|  |
|targetDimensionTargetTypeName|listAny|!!targetDimensionTargetTypeName: !!targetDimensionTargetTypeName|  |
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
|contact/countryId|int|Country ID: Country ID| x |
|contact/number|string|Number| x |
|contact/code|string|Code| x |
|contact/orgnr|string|VAT No.| x |
|contact/stop|bool|Stop| x |
|contact/contactNoMail|bool|No mailings (company| x |
|contact/updatedBy|associate|Updated by: The user who last updated the data| x |
|contact/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|contact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|contact/registeredBy|associate|Registered by: The user who registered the data| x |
|contact/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionPostalAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|contact/restrictionPostalAddress/line1|string|Postal address - Address 1: First line of the address| x |
|contact/restrictionPostalAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|contact/restrictionPostalAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|contact/restrictionPostalAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|contact/restrictionPostalAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|contact/restrictionPostalAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|contact/restrictionPostalAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|contact/restrictionPostalAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|contact/restrictionPostalAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|contact/restrictionPostalAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionPostalAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
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
|contact/contactSupportAssociate/firstName|string|Our service contact - First name: Displays the contact's first name| x |
|contact/contactSupportAssociate/lastName|string|Our service contact - Last name: Displays the contact's last name| x |
|contact/contactSupportAssociate/middleName|string|Our service contact - Middle Name: Displays the contact's middle name.| x |
|contact/contactSupportAssociate/fullName|string|Our service contact - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contact/contactSupportAssociate/contactId|int|Our service contact - Company ID: Database ID of the company the user belongs to|  |
|contact/contactSupportAssociate/personId|int|Our service contact - Contact ID: Database ID of the contact row|  |
|contact/contactSupportAssociate/mrMrs|string|Our service contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|contact/contactSupportAssociate/title|string|Our service contact - Title: Displays whether the contact is addressed as Mr or Ms| x |
|contact/contactSupportAssociate/associateDbId|associate|Our service contact - ID| x |
|contact/contactSupportAssociate/contactName|string|Our service contact - Owning company: Name of the company the user belongs to| x |
|contact/contactSupportAssociate/contactDepartment|string|Our service contact - Owning department: Name of the department at the company the user belongs to| x |
|contact/contactSupportAssociate/usergroup|userGroup|Our service contact - Primary group: The user's primary user group| x |
|contact/contactSupportAssociate/contactFullName|string|Our service contact - Owner: Name and department of the company the user belongs to| x |
|contact/contactSupportAssociate/contactCategory|listAny|Our service contact - Category: Category| x |
|contact/contactSupportAssociate/role|listAny|Our service contact - Role: Role| x |
|contact/contactSupportAssociate/assocName|associate|Our service contact - User ID: User ID| x |
|contact/contactSupportAssociate/assocTooltip|string|Our service contact - Description: Description|  |
|contact/contactSupportAssociate/assocType|listAny|Our service contact - Type: Type of user: associate, external user, system user, anonymous account| x |
|contact/contactSupportAssociate/ejUserId|int|Our service contact - Service user ID: The database ID of a Service user|  |
|contact/contactSupportAssociate/simultaneousEjUser|bool|Our service contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contact/contactSupportAssociate/ejDisplayName|string|Our service contact - Nick name: User's nick name in Service| x |
|contact/contactSupportAssociate/ejStatus|int|Our service contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contact/contactSupportAssociate/credentialType| *None* |Our service contact - Auth. type: What type of credentials to use when this user logs in| x |
|contact/contactSupportAssociate/credentialDisplayValue| *None* |Our service contact - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|contact/contactSupportAssociate/isActive|bool|Our service contact - Active: Is this user active, and should be able to log in?| x |
|contact/contactSupportAssociate/isActiveText|bool|Our service contact - Active status: Is this user active, and should be able to log in?| x |
|contact/contactSupportAssociate/portraitThumbnail| *None* |Our service contact - Person image: Person image|  |
|contact/contactSupportAssociate/otherGroups|userGroup|Our service contact - Other groups: Other groups|  |
|contact/contactSupportAssociate/userName|string|Our service contact - User name: User name| x |
|contact/contactSupportAssociate/personEmail|string|Our service contact - E-mail| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactSupportPerson/personId|int|User support contact - DB ID: Displays the database ID of a contact| x |
|contact/contactSupportPerson/firstName|string|User support contact - First name: Displays the contact's first name| x |
|contact/contactSupportPerson/lastName|string|User support contact - Last name: Displays the contact's last name| x |
|contact/contactSupportPerson/middleName|string|User support contact - Middle name: Displays the contact's middle name.| x |
|contact/contactSupportPerson/fullName|stringorPK|User support contact - Contact: Displays the contact to which an item is linked| x |
|contact/contactSupportPerson/contactId|int|User support contact - Company ID: Database ID of company| x |
|contact/contactSupportPerson/hasInfoText|bool|User support contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|contact/contactSupportPerson/hasInterests|bool|User support contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|contact/contactSupportPerson/personHasInterests|bool|User support contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|contact/contactSupportPerson/mrMrs|string|User support contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|contact/contactSupportPerson/position|listAny|User support contact - Position| x |
|contact/contactSupportPerson/personNumber|string|User support contact - Number: Displays the contact's number| x |
|contact/contactSupportPerson/title|string|User support contact - Title: Displays the contact's job title| x |
|contact/contactSupportPerson/personCountry|listAny|User support contact - Country: Country| x |
|contact/contactSupportPerson/personCountryId|int|User support contact - Country ID: Country ID| x |
|contact/contactSupportPerson/personNoMail|bool|User support contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|contact/contactSupportPerson/rank|int|User support contact - Rank: Displays a contact's current rank| x |
|contact/contactSupportPerson/birthdate| *None* |User support contact - Birthdate: Displays the contact's date of birth|  |
|contact/contactSupportPerson/associateType| *None* |User support contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|contact/contactSupportPerson/useAsMailingAddress|bool|User support contact - Use as postal address: Use as postal address| x |
|contact/contactSupportPerson/personSource|listAny|User support contact - Source: Source (Contact)| x |
|contact/contactSupportPerson/retired|bool|User support contact - Former employee: Indicates whether the contact has retired/left the company| x |
|contact/contactSupportPerson/birthYear|int|User support contact - Birth year: Displays contact's birth year| x |
|contact/contactSupportPerson/birthMonth|int|User support contact - Birth month: Displays contact's birth month| x |
|contact/contactSupportPerson/birthDay|int|User support contact - Birth day: Displays contact's birth day (day of month)| x |
|contact/contactSupportPerson/kanaFirstName|string|User support contact - First name, kana: Contact's first name, in kana alphabet| x |
|contact/contactSupportPerson/kanaLastName|string|User support contact - Last name, kana: Contact's last name, in kana alphabet| x |
|contact/contactSupportPerson/personUpdatedBy|associate|User support contact - Updated by: The user who last updated the data| x |
|contact/contactSupportPerson/personUpdatedByFullName|associate|User support contact - Updated by - Full name: The user who last updated the data| x |
|contact/contactSupportPerson/personUpdatedDate|date|User support contact - Updated: The date/time the data was last updated in UTC.| x |
|contact/contactSupportPerson/personRegisteredBy|associate|User support contact - Registered by: The user who registered the data| x |
|contact/contactSupportPerson/personRegisteredByFullName|associate|User support contact - Registered by - Full name: The user who registered the data| x |
|contact/contactSupportPerson/personRegisteredDate|date|User support contact - Registered date: The date/time the data was registered in UTC.| x |
|contact/contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|contact/contactSupportPerson/personActiveErpLinks|bool|User support contact - ERP connected: Is there an active ERP Sync?| x |
|contact/contactSupportPerson/ticketPriority|listAny|User support contact - Service priority: Default service priority for this contact| x |
|contact/contactSupportPerson/supportLanguage|listAny|User support contact - Preferred language: Preferred language used for reply templates and more| x |
|contact/contactSupportPerson/supportAssociate|associate|User support contact - Our service contact: Default service contact for this contact| x |
|contact/contactSupportPerson/supportAssociateFullName|associate|User support contact - Our service contact - Full name: Default service contact for this contact| x |
|contact/contactSupportPerson/personAssociateId|associate|User support contact - Our contact: Displays our contact| x |
|contact/contactSupportPerson/personAssociateFullName|associate|User support contact - Our contact - Full name: Displays our contact| x |
|contact/contactSupportPerson/personCategory|listAny|User support contact - Category| x |
|contact/contactSupportPerson/personBusiness|listAny|User support contact - Business| x |
|contact/contactSupportPerson/personDeletedDate|datetime|User support contact - Deleted date: Deleted date|  |
|contact/contactSupportPerson/hasCompany|bool|User support contact - Has company: The contact is associated with a company| x |
|contact/contactSupportPerson/isProjectMember|bool|User support contact - Is project member: This person is a project member| x |
|contact/contactSupportPerson/isStakeholder|bool|User support contact - Is stakeholder: This person is a sale stakeholder| x |
|contact/contactSupportPerson/who| *None* |User support contact - Full name: Displays the contact's full name.| x |
|contact/contactSupportPerson/personInfo/textId|int|User support contact - Text ID| x |
|contact/contactSupportPerson/personInfo/infoText|positiveString|User support contact - Information: Displays the text entered in the description field| x |
|contact/contactSupportPerson/personUdef/SuperOffice:1|string|User support contact - contactshorttext: tooltipshorttext| x |
|contact/contactSupportPerson/personUdef/SuperOffice:2|string|User support contact - contactlongtext: tooltiplongtext| x |
|contact/contactSupportPerson/personUdef/SuperOffice:3|int|User support contact - contactnumber| x |
|contact/contactSupportPerson/personUdef/SuperOffice:4|date|User support contact - contactdate| x |
|contact/contactSupportPerson/personUdef/SuperOffice:5|unlimitedDate|User support contact - contactunlimiteddate: tooltipunlimiteddate| x |
|contact/contactSupportPerson/personUdef/SuperOffice:6|bool|User support contact - contactcheckbox| x |
|contact/contactSupportPerson/personUdef/SuperOffice:7|listAny|User support contact - contactdropdownlistbox| x |
|contact/contactSupportPerson/personUdef/SuperOffice:8|decimal|User support contact - contactdecimal| x |
|contact/contactSupportPerson/personUdef/SuperOffice:9|string|User support contact - page1saleonly| x |
|contact/contactSupportPerson/personUdef/SuperOffice:10|string|User support contact - page1marketingonly| x |
|contact/contactSupportPerson/personUdef/SuperOffice:11|string|User support contact - page1adminonly| x |
|contact/contactSupportPerson/personExtra/x\_person\_integer|int|User support contact - Extra Integer: Custom person integer| x |
|contact/contactSupportPerson/personExtra/x\_person\_hidden\_integer|int|User support contact - Extra hidden integer: Custom integer field that is hidden| x |
|contact/contactSupportPerson/personExtra/x\_person\_float|decimal|User support contact - Extra float: Custom float field| x |
|contact/contactSupportPerson/personExtra/x\_person\_longtext|string|User support contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|contact/contactSupportPerson/personExtra/x\_person\_date|date|User support contact - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|contact/contactSupportPerson/personExtra/x\_person\_datetime|datetime|User support contact - Extra DateTime: Custom person date and time field. No default| x |
|contact/contactSupportPerson/personExtra/x\_person\_time| *None* |User support contact - Extra time: Custom time field on person. Current time as default| x |
|contact/contactSupportPerson/personExtra/x\_person\_boolean|bool|User support contact - Extra Boolean: Custom boolean field on person. Default checked| x |
|contact/contactSupportPerson/personExtra/x\_person\_timespan|timeSpan|User support contact - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|contact/contactSupportPerson/personExtra/x\_person\_shorttext|string|User support contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|contact/contactSupportPerson/personExtra/x\_person\_shorttext\_list|listAny|User support contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|contact/contactSupportPerson/personExtra/x\_person\_user\_relation|associate|User support contact - Extra user relation: Custom person-user relation field| x |
|contact/contactSupportPerson/personExtra/x\_person\_category\_relation|listAny|User support contact - Extra category relation: Custom person-category relation| x |
|contact/contactSupportPerson/personExtra/x\_person\_priority\_relation|listAny|User support contact - Extra priority relation: Custom person-priority relation| x |
|contact/contactSupportPerson/personExtra/x\_person\_request\_relation|stringorPK|User support contact - Extra request relation: Request relation on contact| x |
|contact/contactSupportPerson/personExtra/x\_person\_appointment\_relation|stringorPK|User support contact - Extra appointment relation: Appointment relation on person| x |
|contact/contactSupportPerson/personExtra/x\_person\_contact\_relation|stringorPK|User support contact - Extra company relation: Company relation on contact| x |
|contact/contactSupportPerson/personExtra/y\_rental/id|int|User support contact - Rental - id: Displays the row's primary key (y\_rental)| x |
|contact/contactSupportPerson/personExtra/y\_rental/x\_start|date|User support contact - Rental - Start rental| x |
|contact/contactSupportPerson/personExtra/y\_rental/x\_end|date|User support contact - Rental - End| x |
|contact/contactSupportPerson/personExtra/y\_rental/x\_amount|int|User support contact - Rental - Amount: Number to rent. Default = 1| x |
|contact/contactSupportPerson/personExtra/y\_rental/x\_contact|stringorPK|User support contact - Rental - Renter: Company that rents equipment| x |
|contact/contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name|string|User support contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|contact/contactSupportPerson/isMailingRecipient|bool|User support contact - Is mailing recipient: isMailingRecipient| x |
|contact/contactSupportPerson/hasStoreConsent|bool|User support contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contact/contactSupportPerson/withdrawnStoreConsent|bool|User support contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contact/contactSupportPerson/hasEmarketingConsent|bool|User support contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contact/contactSupportPerson/withdrawnEmarketingConsent|bool|User support contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contact/contactSupportPerson/subscription|listAny|User support contact - Subscription: Subscription for marketing| x |
|contact/contactSupportPerson/legalBaseStore|listAny|User support contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contact/contactSupportPerson/legalBaseEmarketing|listAny|User support contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contact/contactSupportPerson/consentSourceStore|listAny|User support contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contact/contactSupportPerson/consentSourceEmarketing|listAny|User support contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contact/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|contact/contactUdef/SuperOffice:3|int|companynumber| x |
|contact/contactUdef/SuperOffice:4|date|companydate| x |
|contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|contact/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|contact/contactUdef/SuperOffice:9|string|page1saleonly| x |
|contact/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|contact/contactUdef/SuperOffice:11|string|page1adminonly| x |
|contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|contact/contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|contact/contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|contact/contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|contact/contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|contact/contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|contact/contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|contact/contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|contact/contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|contact/contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|contact/contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|contact/contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|contact/contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|contact/contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|contact/contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
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
|contact/SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|contact/SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|contact/saintSaleStatus|listAny|With status|  |
|contact/saintAmountClass|listAny|Amount class|  |
|contact/saintActivityType|listAny|SAINT type|  |
|contact/saintDirection|listAny|Direction|  |
|contact/saintIntention|listAny|Intention|  |
|contact/saintTicketStatus|listAny|Status|  |
|contact/saintTicketCategory|listAny|Category|  |
|contact/selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|contact/selectionIdRequest|int|Selection ID: Database ID of selection which members are to be fetched from|  |

## Sample

```http!
GET /api/v1/archive/TargetValueSub?$select=contact/country,contact/contactExtra/x_contact_hidden_integer,contact/streetAddress/city
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

