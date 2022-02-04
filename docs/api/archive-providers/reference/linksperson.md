---
uid: LinksPerson
title: LinksPerson
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "LinksPerson"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "LinksPerson"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksPersonProvider">SuperOffice.CRM.ArchiveLists.LinksPersonProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"person"|Contact|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|sourceAppointmentRestrictionId|int|Source follow-up ID: Unique ID of follow-up to fetch link data for|  |
|sourceSaleRestrictionId|int|Source sale ID: Unique ID of sale to fetch link data for|  |
|sourceDocumentRestrictionId|int|Source document ID: Unique ID of document to fetch link data for|  |
|sourceProjectRestrictionId|int|Source project ID: Unique ID of project there is a link from|  |
|sourcePersonRestrictionId|int|Contact ID: Database ID of the contact row|  |
|sourceContactRestrictionId|int|Company ID: Database ID of company|  |
|sourceSelectionRestrictionId|int|Selection ID: The database ID of the selection|  |
|linkId|int|Link ID: Unique ID of relation between linked entities|  |
|linkDescription|string|Link description: A description of the relation between linked entities|  |
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
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|string|Text: Displays a descriptive text for the item| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|type|listAny|Type: Displays the type of an activity| x |
|completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
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
|contact/number|string|Number| x |
|contact/code|string|Code| x |
|contact/orgnr|string|VAT No.| x |
|contact/stop|bool|Stop| x |
|contact/contactNoMail|bool|No mailings (company| x |
|contact/updatedBy|associate|Updated by: The user who last updated the data| x |
|contact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|contact/registeredBy|associate|Registered by: The user who registered the data| x |
|contact/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contact/contactSource|listAny|Source: Source (Company)| x |
|contact/contactDeleted|bool|Deleted: Deleted| x |
|contact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|contact/deletedDate|datetime|Deleted date: Deleted date|  |
|contact/mainContact| *None* |Main contact: Main contact for this company| x |
|destinationPersonRestrictionId|int|ADD LINK Person DESTINATION RESOURCE: ADD LINK Person DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksPerson?$select=contact/stop,associateType,personActiveErpLinks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

