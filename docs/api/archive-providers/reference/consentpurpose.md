---
uid: ConsentPurpose
title: ConsentPurpose
description: This is the archive Consent Purpose Provider for GDPR Admin
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ConsentPurpose"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ConsentPurpose"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ConsentPurposeProvider">SuperOffice.CRM.ArchiveLists.ConsentPurposeProvider</see> inside NetServer's SODatabase assembly.

This is the archive Consent Purpose Provider for GDPR Admin
and for GDPR relations to person, if you join and restrict on person

## Supported Entities
| Name | Description |
| ---- | ----- |
|"consentPurpose"|Consent purpose|
|"deletedConsentPurpose"|Deleted|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|consentPurposeId|int|Consent purpose ID: Consent purpose ID| x |
|active|bool|Active: | x |
|key|string|Purpose ID: | x |
|name|string|Purpose name: The name of the consent purpose| x |
|tooltip|string|Description: | x |
|privacyStatementDescription|string|External privacy statement: Privacy statement| x |
|privacyStatementUrl|string|External privacy statement URL: Privacy statement URL| x |
|updatedBy|associate|Updated by: The user who last updated the data|  |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|rank|int|Rank| x |
|consentPerson/consentPersonId|int|Consent ID: ID of consent| x |
|consentPerson/personId|int|Contact ID: Database ID of the contact row| x |
|consentPerson/active|bool|Active: Consent has been given| x |
|consentPerson/legalBase|listAny|Legal basis: Legal basis of this consent| x |
|consentPerson/consentSource|listAny|Source: Source of this consent| x |
|consentPerson/comment|string|Comment: Comment| x |
|consentPerson/hasComment|bool|Has comment: Has comment| x |
|consentPerson/updatedBy|associate|Updated by: The user who last updated the data| x |
|consentPerson/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|consentPerson/person/personId|int|Contact - DB ID: Displays the database ID of a contact| x |
|consentPerson/person/firstName|string|Contact - First name: Displays the contact's first name| x |
|consentPerson/person/lastName|string|Contact - Last name: Displays the contact's last name| x |
|consentPerson/person/middleName|string|Contact - Middle name: Displays the contact's middle name.| x |
|consentPerson/person/fullName|stringorPK|Contact - Contact: Displays the contact to which an item is linked| x |
|consentPerson/person/contactId|int|Contact - Company ID: Database ID of company| x |
|consentPerson/person/hasInfoText|bool|Contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|consentPerson/person/hasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|consentPerson/person/personHasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|consentPerson/person/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|consentPerson/person/position|listAny|Contact - Position| x |
|consentPerson/person/personNumber|string|Contact - Number: Displays the contact's number| x |
|consentPerson/person/title|string|Contact - Title: Displays the contact's job title| x |
|consentPerson/person/personCountry|listAny|Contact - Country: Country| x |
|consentPerson/person/personNoMail|bool|Contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|consentPerson/person/rank|int|Contact - Rank: Displays a contact's current rank| x |
|consentPerson/person/birthdate| *None* |Contact - Birthdate: Displays the contact's date of birth|  |
|consentPerson/person/associateType| *None* |Contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|consentPerson/person/useAsMailingAddress|bool|Contact - Use as postal address: Use as postal address| x |
|consentPerson/person/personSource|listAny|Contact - Source: Source (Contact)| x |
|consentPerson/person/retired|bool|Contact - Former employee: Indicates whether the contact has retired/left the company| x |
|consentPerson/person/birthYear|int|Contact - Birth year: Displays contact's birth year| x |
|consentPerson/person/birthMonth|int|Contact - Birth month: Displays contact's birth month| x |
|consentPerson/person/birthDay|int|Contact - Birth day: Displays contact's birth day (day of month)| x |
|consentPerson/person/kanaFirstName|string|Contact - First name, kana: Contact's first name, in kana alphabet| x |
|consentPerson/person/kanaLastName|string|Contact - Last name, kana: Contact's last name, in kana alphabet| x |
|consentPerson/person/personUpdatedBy|associate|Contact - Updated by: The user who last updated the data| x |
|consentPerson/person/personUpdatedDate|date|Contact - Updated: The date/time the data was last updated in UTC.| x |
|consentPerson/person/personRegisteredBy|associate|Contact - Registered by: The user who registered the data| x |
|consentPerson/person/personRegisteredDate|date|Contact - Registered date: The date/time the data was registered in UTC.| x |
|consentPerson/person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|consentPerson/person/personActiveErpLinks|bool|Contact - ERP connected: Is there an active ERP Sync?| x |
|consentPerson/person/ticketPriority|listAny|Contact - Service priority: Default service priority for this contact| x |
|consentPerson/person/supportLanguage|listAny|Contact - Preferred language: Preferred language used for reply templates and more| x |
|consentPerson/person/supportAssociate|associate|Contact - Our service contact: Default service contact for this contact| x |
|consentPerson/person/personAssociateId|associate|Contact - Our contact: Displays our contact| x |
|consentPerson/person/personCategory|listAny|Contact - Category| x |
|consentPerson/person/personBusiness|listAny|Contact - Business| x |
|consentPerson/person/personDeletedDate|datetime|Contact - Deleted date: Deleted date|  |
|consentPerson/person/hasCompany|bool|Contact - Has company: The contact is associated with a company| x |
|consentPerson/person/isProjectMember|bool|Contact - Is project member: This person is a project member| x |
|consentPerson/person/isStakeholder|bool|Contact - Is stakeholder: This person is a sale stakeholder| x |
|consentPerson/person/phone/formattedNumber|string|Contact - Phone: Displays phone number|  |
|consentPerson/person/personDirectPhone/formattedNumber|string|Contact - Direct - Phone: Displays phone number|  |
|consentPerson/person/personDirectPhone/description|string|Contact - Direct - Description: Phone number description| x |
|consentPerson/person/personMobilePhone/formattedNumber|string|Contact - Mobile - Phone: Displays phone number|  |
|consentPerson/person/personMobilePhone/description|string|Contact - Mobile - Description: Phone number description| x |
|consentPerson/person/personPrivate/formattedNumber|string|Contact - Private - Phone: Displays phone number|  |
|consentPerson/person/personPrivate/description|string|Contact - Private - Description: Phone number description| x |
|consentPerson/person/personPager/formattedNumber|string|Contact - Other - Phone: Displays phone number|  |
|consentPerson/person/personPager/description|string|Contact - Other - Description: Phone number description| x |
|consentPerson/person/personDirectFax/formattedNumber|string|Contact - Fax - Phone: Displays phone number|  |
|consentPerson/person/personDirectFax/description|string|Contact - Fax - Description: Phone number description| x |
|consentPerson/person/personInfo/textId|int|Contact - Text ID| x |
|consentPerson/person/personInfo/infoText|positiveString|Contact - Information: Displays the text entered in the description field| x |
|consentPerson/person/email/emailProtocol|string|Contact - Protocol: E-mail protocol, such as SMTP| x |
|consentPerson/person/email/emailAddress|string|Contact - E-mail| x |
|consentPerson/person/email/emailDescription|string|Contact - Description| x |
|consentPerson/person/email/emailId|int|Contact - ID| x |
|consentPerson/person/email/emailLastSent|datetime|Contact - Last sent: The date and time an e-mail was last sent to this address| x |
|consentPerson/person/email/emailBounceCount|int|Contact - Bounce count: Bounce count for this e-mail address| x |
|consentPerson/person/email/emailLastBounce|datetime|Contact - Last bounce: Date and time for last bounce to this e-mail address| x |
|consentPerson/person/email/emailHasBounced|bool|Contact - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|consentPerson/person/personUrl/URLAddress|string|Contact - URL| x |
|consentPerson/person/personUrl/URLDescription|string|Contact - Description| x |
|consentPerson/person/personAddress/addressId|int|Contact - Contact address - Address ID: Database ID for the address record| x |
|consentPerson/person/personAddress/line1|string|Contact - Contact address - Address 1: First line of the address| x |
|consentPerson/person/personAddress/line2|string|Contact - Contact address - Address 2: Second line of the address| x |
|consentPerson/person/personAddress/line3|string|Contact - Contact address - Address 3: Third line of the address| x |
|consentPerson/person/personAddress/county|string|Contact - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|consentPerson/person/personAddress/city|string|Contact - Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|consentPerson/person/personAddress/zip|string|Contact - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|consentPerson/person/personAddress/state|string|Contact - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|consentPerson/person/personAddress/wgs84latitude|decimal|Contact - Contact address - Latitude: Latitude| x |
|consentPerson/person/personAddress/wgs84longitude|decimal|Contact - Contact address - Longitude: Longitude| x |
|consentPerson/person/personAddress/formattedAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|consentPerson/person/personAddress/formattedMultiLineAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|consentPerson/person/personUdef/SuperOffice:1|string|Contact - contactshorttext: tooltipshorttext| x |
|consentPerson/person/personUdef/SuperOffice:2|string|Contact - contactlongtext: tooltiplongtext| x |
|consentPerson/person/personUdef/SuperOffice:3|int|Contact - contactnumber| x |
|consentPerson/person/personUdef/SuperOffice:4|date|Contact - contactdate| x |
|consentPerson/person/personUdef/SuperOffice:5|unlimitedDate|Contact - contactunlimiteddate: tooltipunlimiteddate| x |
|consentPerson/person/personUdef/SuperOffice:6|bool|Contact - contactcheckbox| x |
|consentPerson/person/personUdef/SuperOffice:7|listAny|Contact - contactdropdownlistbox| x |
|consentPerson/person/personUdef/SuperOffice:8|decimal|Contact - contactdecimal| x |
|consentPerson/person/personUdef/SuperOffice:9|string|Contact - page1saleonly| x |
|consentPerson/person/personUdef/SuperOffice:10|string|Contact - page1marketingonly| x |
|consentPerson/person/personUdef/SuperOffice:11|string|Contact - page1adminonly| x |
|consentPerson/consentPurpose/consentPurposeId|int|Consent purpose - Consent purpose ID: Consent purpose ID| x |
|consentPerson/consentPurpose/active|bool|Consent purpose - Active: | x |
|consentPerson/consentPurpose/key|string|Consent purpose - Purpose ID: | x |
|consentPerson/consentPurpose/name|string|Consent purpose - Purpose name: The name of the consent purpose| x |
|consentPerson/consentPurpose/tooltip|string|Consent purpose - Description: | x |
|consentPerson/consentPurpose/privacyStatementDescription|string|Consent purpose - External privacy statement: Privacy statement| x |
|consentPerson/consentPurpose/privacyStatementUrl|string|Consent purpose - External privacy statement URL: Privacy statement URL| x |
|consentPerson/consentPurpose/updatedBy|associate|Consent purpose - Updated by: The user who last updated the data|  |
|consentPerson/consentPurpose/updatedDate|date|Consent purpose - Updated: The date/time the data was last updated in UTC.| x |
|consentPerson/consentPurpose/rank|int|Consent purpose - Rank| x |

## Sample

```http!
GET /api/v1/archive/ConsentPurpose?$select=consentPerson/person/kanaFirstName,consentPerson/consentPurpose/rank,consentPerson/person/useAsMailingAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

