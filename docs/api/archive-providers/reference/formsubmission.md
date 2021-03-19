---
uid: FormSubmission
title: FormSubmission
description: Archive provider for listing form submissions
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

# "FormSubmission"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FormSubmissionProvider">SuperOffice.CRM.ArchiveLists.FormSubmissionProvider</see> inside NetServer's SODatabase assembly.

Archive provider for listing form submissions

## Supported Entities
| Name | Description |
| ---- | ----- |
|"formSubmission"|Form submissions|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|formSubmissionId|int|Form submission ID: ID of the form submission record| x |
|formSubmissionStatus|listAny|Status: Status of the form submission record| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|time| *None* |Time: Time|  |
|type|listAny|Type: Displays the type of an activity| x |
|text|positiveString|Text: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|associate/firstName|string|Associate - First name: Displays the contact's first name| x |
|associate/lastName|string|Associate - Last name: Displays the contact's last name| x |
|associate/middleName|string|Associate - Middle Name: Displays the contact's middle name.| x |
|associate/fullName|string|Associate - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|associate/contactId|int|Associate - Company ID: Database ID of the company the user belongs to|  |
|associate/personId|int|Associate - Contact ID: Database ID of the contact row|  |
|associate/mrMrs|string|Associate - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|associate/title|string|Associate - Title: Displays whether the contact is addressed as Mr or Ms| x |
|associate/contactName|string|Associate - Owning company: Name of the company the user belongs to| x |
|associate/contactDepartment|string|Associate - Owning department: Name of the department at the company the user belongs to| x |
|associate/usergroup|userGroup|Associate - Primary group: The user's primary user group| x |
|associate/contactFullName|string|Associate - Owner: Name and department of the company the user belongs to| x |
|associate/contactCategory|listAny|Associate - Category: Category| x |
|associate/role|listAny|Associate - Role: Role| x |
|associate/assocName|associate|Associate - User ID: User ID| x |
|associate/assocTooltip|string|Associate - Description: Description|  |
|associate/assocType|listAny|Associate - Type: Type of user: associate, external user, system user, anonymous account| x |
|associate/ejUserId|int|Associate - Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Associate - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Associate - Nick name: User's nick name in Service| x |
|associate/ejStatus|int|Associate - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Associate - Auth. type: What type of credentials to use when this user logs in| x |
|associate/credentialDisplayValue| *None* |Associate - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|associate/isActive|bool|Associate - Active: Is this user active, and should be able to log in?| x |
|associate/isActiveText|bool|Associate - Active status: Is this user active, and should be able to log in?| x |
|associate/portraitThumbnail| *None* |Associate - Person image: Person image|  |
|associate/otherGroups|userGroup|Associate - Other groups: Other groups|  |
|associate/userName|string|Associate - User name: User name| x |
|associate/personEmail|string|Associate - E-mail| x |
|person/personId|int|Contact - DB ID: Displays the database ID of a contact| x |
|person/firstName|string|Contact - First name: Displays the contact's first name| x |
|person/lastName|string|Contact - Last name: Displays the contact's last name| x |
|person/middleName|string|Contact - Middle name: Displays the contact's middle name.| x |
|person/fullName|stringorPK|Contact - Contact: Displays the contact to which an item is linked| x |
|person/contactId|int|Contact - Company ID: Database ID of company| x |
|person/hasInfoText|bool|Contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|person/hasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/personHasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/position|listAny|Contact - Position| x |
|person/personNumber|string|Contact - Number: Displays the contact's number| x |
|person/title|string|Contact - Title: Displays the contact's job title| x |
|person/personCountry|listAny|Contact - Country: Country| x |
|person/personNoMail|bool|Contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|person/rank|int|Contact - Rank: Displays a contact's current rank| x |
|person/birthdate| *None* |Contact - Birthdate: Displays the contact's date of birth|  |
|person/associateType| *None* |Contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|person/useAsMailingAddress|bool|Contact - Use as postal address: Use as postal address| x |
|person/personSource|listAny|Contact - Source: Source (Contact)| x |
|person/retired|bool|Contact - Former employee: Indicates whether the contact has retired/left the company| x |
|person/birthYear|int|Contact - Birth year: Displays contact's birth year| x |
|person/birthMonth|int|Contact - Birth month: Displays contact's birth month| x |
|person/birthDay|int|Contact - Birth day: Displays contact's birth day (day of month)| x |
|person/kanaFirstName|string|Contact - First name, kana: Contact's first name, in kana alphabet| x |
|person/kanaLastName|string|Contact - Last name, kana: Contact's last name, in kana alphabet| x |
|person/personUpdatedBy|associate|Contact - Updated by: The user who last updated the data| x |
|person/personUpdatedDate|date|Contact - Updated: The date/time the data was last updated in UTC.| x |
|person/personRegisteredBy|associate|Contact - Registered by: The user who registered the data| x |
|person/personRegisteredDate|date|Contact - Registered date: The date/time the data was registered in UTC.| x |
|person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|person/personActiveErpLinks|bool|Contact - ERP connected: Is there an active ERP Sync?| x |
|person/ticketPriority|listAny|Contact - Service priority: Default service priority for this contact| x |
|person/supportLanguage|listAny|Contact - Preferred language: Preferred language used for reply templates and more| x |
|person/supportAssociate|associate|Contact - Our service contact: Default service contact for this contact| x |
|person/personAssociateId|associate|Contact - Our contact: Displays our contact| x |
|person/personCategory|listAny|Contact - Category| x |
|person/personBusiness|listAny|Contact - Business| x |
|person/personDeletedDate|datetime|Contact - Deleted date: Deleted date|  |
|person/hasCompany|bool|Contact - Has company: The contact is associated with a company| x |
|person/isProjectMember|bool|Contact - Is project member: This person is a project member| x |
|person/isStakeholder|bool|Contact - Is stakeholder: This person is a sale stakeholder| x |
|contact/contactId|int|Company - Company ID: Database ID of company| x |
|contact/name|stringorPK|Company - Company name| x |
|contact/department|string|Company - Department| x |
|contact/nameDepartment| *None* |Company - Company: Displays the company an activity is linked to| x |
|contact/hasInfoText|bool|Company - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|contact/hasInterests|bool|Company - Has interests: Displays an Icon indicating if the contact has active interests| x |
|contact/associateId|associate|Company - Our contact: Displays our contact| x |
|contact/category|listAny|Company - Category| x |
|contact/business|listAny|Company - Business| x |
|contact/country|listAny|Company - Country: This criterion corresponds to the Country field on the Company card.| x |
|contact/number|string|Company - Number| x |
|contact/code|string|Company - Code| x |
|contact/orgnr|string|Company - VAT No.| x |
|contact/stop|bool|Company - Stop| x |
|contact/contactNoMail|bool|Company - No mailings (company)| x |
|contact/updatedBy|associate|Company - Updated by: The user who last updated the data| x |
|contact/updatedDate|date|Company - Updated: The date/time the data was last updated in UTC.| x |
|contact/registeredBy|associate|Company - Registered by: The user who registered the data| x |
|contact/registeredDate|date|Company - Registered date: The date/time the data was registered in UTC.| x |
|contact/contactSource|listAny|Company - Source: Source (Company)| x |
|contact/contactDeleted|bool|Company - Deleted: Deleted| x |
|contact/activeErpLinks|bool|Company - ERP connected: Is there an active ERP Sync?| x |
|contact/deletedDate|datetime|Company - Deleted date: Deleted date|  |
|contact/mainContact| *None* |Company - Main contact: Main contact for this company| x |

## Sample

```http!
GET /api/v1/archive/FormSubmission?$select=associate/ejStatus,person/position
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

