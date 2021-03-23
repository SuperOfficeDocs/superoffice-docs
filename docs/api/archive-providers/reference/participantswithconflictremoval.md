---
uid: ParticipantsWithConflictRemoval
title: ParticipantsWithConflictRemoval
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ParticipantsWithConflictRemoval"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ParticipantsWithConflictRemoval"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ParticipantsWithConflictRemovalProvider">SuperOffice.CRM.ArchiveLists.ParticipantsWithConflictRemovalProvider</see> inside NetServer's SODatabase assembly.

Archive provider that wraps the <see cref="T:SuperOffice.CRM.ArchiveLists.ParticipantsProvider" />, and adds a pseudo entity used to hide associates with conflicts.

This provider is used by the Assign To dialog, where an associate list with conflict markers is shown. This list has a checkbox
with the text 'hide conflicts', and its effect is to remove from the list those that do have a conflict.
<para />
This class implements the functionality by wrapping the existing participants provider, adds an optional entity to get
the checkbox, and performs filtering if the entity is chosen. It also ensures that the relevant column is ordered from the
inner participants provider, so that the conflict checking is performed.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"associate"|Associate|
|"resource"|Resource:|
|"externalPerson"|External users|
|"hideConflict"|Hide conflict|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownerAssociateIdInformation|associate|Owner's Associate ID: Associate ID of the user specified as owner of the follow-up|  |
|inhibitConflictsInformation|bool|No conflict checking: This restriction is used to turn off conflict checking in the participants list|  |
|startTimeInformation|datetime|Start time: Information for data fetcher, specifies start time for conflict checker|  |
|endTimeInformation|datetime|End time: Information for data fetcher, specifies end time for conflict checker|  |
|dateInformation|date|Date information: Date information, used by conflict checker|  |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|icon| *None* |Icon indicating participant type|  |
|sendEmail| *None* |Icon indicating whether the participant should be sent e-mail|  |
|seen| *None* |Icon indicating whether the participant has seen the invitation|  |
|status| *None* |Status: Shows any conflicts with other follow-ups|  |
|participantAssociateId| *None* |Associate ID: Database ID for an associate (user or resource) who is a meeting participant|  |
|participantPersonId| *None* |Contact ID: Database ID for a contact who is a meeting participant|  |
|associateEmailsInformation|int|E-mail ID: IDs of contacts that should receive invitation e-mails for a booking - column is only used as a restriction|  |
|appointmentRestrictionId|int|Follow-up ID: ID of the follow-up to fetch participants for|  |
|firstName|string|First name: Displays the contact's first name| x |
|lastName|string|Last name: Displays the contact's last name| x |
|middleName|string|Middle Name : Displays the contact's middle name.| x |
|fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personId|int|Contact ID: Database ID of the contact row|  |
|mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|associateDbId|associate|ID|  |
|contactName|string|Owning company: Name of the company the user belongs to|  |
|contactDepartment|string|Owning department: Name of the department at the company the user belongs to|  |
|usergroup|userGroup|Primary group: The user's primary user group|  |
|contactFullName|string|Owner: Name and department of the company the user belongs to|  |
|contactCategory|listAny|Category: Category|  |
|role|listAny|Role : Role|  |
|assocName|associate|User ID : User ID|  |
|assocTooltip|string|Description : Description|  |
|assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account|  |
|ejUserId|int|Service user ID: The database ID of a Service user|  |
|simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ejDisplayName|string|Nick name: User's nick name in Service|  |
|ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|isActive|bool|Active: Is this user active, and should be able to log in?|  |
|isActiveText|bool|Active status: Is this user active, and should be able to log in?|  |
|portraitThumbnail| *None* |Person image: Person image|  |
|otherGroups|userGroup|Other groups: Other groups|  |
|userName|string|User name: User name|  |
|personEmail|string|E-mail|  |
|personEmailsInformation|int|E-mail ID: IDs of contacts that should receive invitation e-mails for a booking - column is only used as a restriction|  |
|fullNameWithContact| *None* |Contact and company: The fully formatted contact name, and full company name|  |
|hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact|  |
|hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests|  |
|personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests|  |
|position|listAny|Position|  |
|personNumber|string|Number: Displays the contact's number|  |
|personCountry|listAny|Country: Country|  |
|personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox|  |
|rank|int|Rank: Displays a contact's current rank|  |
|birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|useAsMailingAddress|bool|Use as postal address: Use as postal address|  |
|personSource|listAny|Source: Source (Contact)|  |
|retired|bool|Former employee: Indicates whether the contact has retired/left the company|  |
|birthYear|int|Birth year: Displays contact's birth year|  |
|birthMonth|int|Birth month: Displays contact's birth month|  |
|birthDay|int|Birth day: Displays contact's birth day (day of month)|  |
|kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet|  |
|kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet|  |
|personUpdatedBy|associate|Updated by: The user who last updated the data|  |
|personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|personRegisteredBy|associate|Registered by: The user who registered the data|  |
|personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|ticketPriority|listAny|Service priority: Default service priority for this contact|  |
|supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more|  |
|supportAssociate|associate|Our service contact: Default service contact for this contact|  |
|personAssociateId|associate|Our contact: Displays our contact|  |
|personCategory|listAny|Category|  |
|personBusiness|listAny|Business|  |
|personDeletedDate|datetime|Deleted date: Deleted date|  |
|hasCompany|bool|Has company: The contact is associated with a company|  |
|isProjectMember|bool|Is project member: This person is a project member|  |
|isStakeholder|bool|Is stakeholder: This person is a sale stakeholder|  |
|email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP|  |
|email/emailAddress|string|E-mail|  |
|email/emailDescription|string|Description|  |
|email/emailId|int|ID|  |
|email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address|  |
|email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address|  |
|email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address|  |
|email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|personUrl/URLAddress|string|URL|  |
|personUrl/URLDescription|string|Description|  |
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
|personContact/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|personContact/deletedDate| *None* |Deleted date: Deleted date|  |
|personContact/mainContact| *None* |Main contact: Main contact for this company|  |
|personContact/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP|  |
|personContact/email/emailAddress|string|E-mail|  |
|personContact/email/emailDescription|string|Description|  |
|personContact/email/emailId|int|ID|  |
|personContact/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address|  |
|personContact/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address|  |
|personContact/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address|  |
|personContact/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|associateRestrictionId|int|Associate ID: IDs of associates to be displayed as participants|  |
|groupRestrictionId|int|Group ID: ID of group with members to be displayed as participants|  |
|resourceRestrictionId|int|Resource ID: ID of resources to be displayed as participants|  |
|externalPersonRestrictionId|int|Contact ID: ID of external contacts to be displayed as participants|  |

## Sample

```http!
GET /api/v1/archive/ParticipantsWithConflictRemoval?$select=personAssociateId,otherGroups,kanaFirstName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

