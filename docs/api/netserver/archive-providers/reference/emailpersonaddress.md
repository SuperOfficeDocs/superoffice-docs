---
uid: emailpersonaddress
title: emailpersonaddress
description: Person subchannel for special purpose archive provider used to search for email addresses.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "emailpersonaddress"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "emailpersonaddress"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailPersonAddressProvider">SuperOffice.CRM.ArchiveLists.EmailPersonAddressProvider</see> inside NetServer's SODatabase assembly.

Person subchannel for special purpose archive provider used to search for email addresses.

This channel will match on either the email address itself, or person.firstname or person.lastname

The resulting rows will have entity name 'contact', but the primary key will always be
the email_id.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"email"|[email]|
|"person"|Contacts|

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
|personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|personRegisteredBy|associate|Registered by: The user who registered the data| x |
|personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|portraitThumbnail| *None* |Person image: Person image|  |
|personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|ticketPriority|listAny|Service priority: Default service priority for this contact| x |
|supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|personAssociateId|associate|Our contact: Displays our contact| x |
|personCategory|listAny|Category| x |
|personBusiness|listAny|Business| x |
|personDeletedDate|datetime|Deleted date: Deleted date|  |
|hasCompany|bool|Has company: The contact is associated with a company| x |
|isProjectMember|bool|Is project member: This person is a project member| x |
|isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|phone/formattedNumber|string|Phone : Displays phone number|  |
|who| *None* |Full name: Displays the contact's full name.| x |
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
|personContact/contactId|int|Company ID: Database ID of company| x |
|personContact/name|stringorPK|Company name| x |
|personContact/department|string|Department| x |
|personContact/nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|personContact/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|personContact/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|personContact/associateId|associate|Our contact: Displays our contact| x |
|personContact/category|listAny|Category| x |
|personContact/business|listAny|Business| x |
|personContact/country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|personContact/number|string|Number| x |
|personContact/code|string|Code| x |
|personContact/orgnr|string|VAT No.| x |
|personContact/stop|bool|Stop| x |
|personContact/contactNoMail|bool|No mailings (company| x |
|personContact/updatedBy|associate|Updated by: The user who last updated the data| x |
|personContact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|personContact/registeredBy|associate|Registered by: The user who registered the data| x |
|personContact/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|personContact/contactSource|listAny|Source: Source (Company)| x |
|personContact/contactDeleted|bool|Deleted: Deleted| x |
|personContact/phone/formattedNumber|string|Phone : Displays phone number|  |
|personContact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|personContact/deletedDate|datetime|Deleted date: Deleted date|  |
|personContact/mainContact| *None* |Main contact: Main contact for this company| x |
|personContact/contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|personContact/contactPhone/description|string|Telephone - Description: Phone number description| x |
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

## Sample

```http!
GET /api/v1/archive/emailpersonaddress?$select=lastName,personNoMail,retired
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

