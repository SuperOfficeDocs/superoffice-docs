---
uid: RecyclePerson
title: RecyclePerson
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "RecyclePerson"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.RecyclePersonProvider">SuperOffice.CRM.ArchiveLists.RecyclePersonProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"person"|Contact|
|"forAllUsers"|View deleted contacts for all users|

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
|personContact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|personContact/deletedDate|datetime|Deleted date: Deleted date|  |
|personContact/mainContact| *None* |Main contact: Main contact for this company| x |
|personContact/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|personContact/email/emailAddress|string|E-mail| x |
|personContact/email/emailDescription|string|Description| x |
|personContact/email/emailId|int|ID| x |
|personContact/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|personContact/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|personContact/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|personContact/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |

## Sample

```http!
GET /api/v1/archive/RecyclePerson?$select=mrMrs,personUpdatedBy,isProjectMember
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

