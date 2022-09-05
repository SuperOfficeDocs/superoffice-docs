---
uid: Participants
title: Participants
description: Archive list provider for the participants list of a booking (multi-person appointment)
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "Participants"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Participants"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ParticipantsProvider">SuperOffice.CRM.ArchiveLists.ParticipantsProvider</see> inside NetServer's SODatabase assembly.

Archive list provider for the participants list of a booking (multi-person appointment)

This provider, like the <see cref="T:SuperOffice.CRM.ArchiveLists.LinksProvider" />, offers two alternative ways of accessing
the data. For existing appointments, the appointment_id is used as search criterion. This will retrieve
all participants in this appointment, regardless of whether the given appointment is the mother
or one of the slaves.
<para />
For appointments under construction, where the data have not yet been saved to the database, the
caller must specify all data through the use of restrictions - some of which are then used for
information, and some as keys to fetch actual person or associate/resource records from the database.
<list type="table"><listheader><term>Restriction</term><description>Meaning</description></listheader><item><term>appointmentRestrictionId</term><description>Single appointment id, using the = operator.
This restriction is used on its own for fetching information from existing appointment records.
The id may be of any appointment in the booking, and all participants will be fetched (limited
by entity selection).</description></item><item><term>associateRestrictionId</term><description>Operator: IN, Value: array of
associate id's. These will be returned as participants of type associate, if the associate entity has been selected.</description></item><item><term>groupRestrictionId</term><description>Operator: =, Value: group id.
The group will be translated into associate id's, and these will be returned as participants of type associate, if the associate entity has been selected.
This is an alternative to specifying the associates one by one and cannot be used together with the associateRestrictionId.</description></item><item><term>externalPersonRestrictionId</term><description>Operator: IN, Value: array of
of person id's. These will be returned as participants of type external person, if the externalPerson entity has been selected.
<i>Note: Persons who are actually associates</i> will be detected as such, and be returned as associates.</description></item><item><term>resourceRestrictionId</term><description>Operator: IN, Value: array of
of associate id's. These will be returned as participants of type resource, if the resource entity has been selected.</description></item><item><term>personEmailsInformation</term><description>Operator: IN, Value: array of
of person id's. This restriction is optionally used together with externalPersonRestrictionId, and
specifies which of the persons should have an email icon set.</description></item><item><term>associateEmailsInformation</term><description>Operator: IN, Value: array of
of associate id's. This restriction is optionally used together with associatePersonRestrictionId, and
specifies which of the associates should have an email icon set. Note that resources do not
get invitation emails, so there is no corresponding resourceEmailsInformation restriction.</description></item><item><term>startTimeInformation</term><description>Datetime of appointment start, needed when fetching
data through the explicit restrictions (not appointmentRestrictionId) and if you want collision detection.</description></item><item><term>endTimeInformation</term><description>Datetime of appointment end, needed when fetching
data through the explicit restrictions (not appointmentRestrictionId) and if you want collision detection.</description></item><item><term>ownerAssociateIdInformation</term><description>Operator: =, value: associate id. This is the Id of associate who is the owner of the whole booking. If this is not
given, and appointmentRestrictionId is given, the system will look up the associate of the master booking record
(mother_id = appointment_id) and use that as the owner. If ownerAssociateIdInformation is given, it overrides
(disables) this lookup. If neither are given, then there is no owner associate. The owner associate always
comes at the top of the list, and has the 'owner' row style hint.</description></item><item><term>inhibitConflictsInformation</term><description>Operator: =, value: boolean.
If you provide either an appointmentRestrictionId or startTime/EndTime, then conflicts will be
detected. However, if the appointment is of type Free, then no conflict detetction will occur. To force
'free' behaviour on an under-construction appointment that does not have an appointment id, or
on an appointment that is being changed, include this restriction with the value true. That will turn off
conflict detection.</description></item><!--
<item><term>dateInformation</term><description>Dates of multiple appointments, override the date part of startTimeInformation and endTimeInformation.
Needed when fetching
data through the explicit restrictions (not appointmentRestrictionId) and if you want collision detection on
multiple (such as recurring) occasions.</description></item>
--></list>
If you do not use the appointmentRestrictionId, you can instead specify
external persons by a list (use the IN operator) of externalPersonRestrictionId,
internal associates through a list of associateRestrictionId, and resources through resourceRestrictionId.
All three restrictions can be given simultaneously, with an implied OR operator. In this case no appointment
records are required or fetched.
<para />
Conflict detection is provided if the status column is requested. For non-saved data, this also
requires the presence of startTimeInformation and endTimeInformation restrictions (dates in InvariantCulture format),
so that the conflicts may be calculated.
<para />
Finally, the email status (should emails be sent for invitations and changes) is read from the database
if the appointmentRestrictionId is used; if explicit person or associate restrictions are used, then email
status information must be passed in through the associateEmailsInformation and personEmailsInformation
restrictions. The value of each restriction is a list of associate resp. person id's who have
the email flag set. If all this sounds complex - well, it is.
<para />
Being the tolerant sort, the provider will accept both associates and resources in each of associateRestrictionId
and resourceRestrictionId, and internally sort out which is which. Similarly, if any of the person id's you happen to pass
in through the externalPersonRestrictionId are actually associates, then that too will be sorted out.

## Supported Entities

| Name | Description |
| ---- | ----------- |
|"associate"|Associate|
|"resource"|Resource:|
|"externalPerson"|External users|

## Supported Columns

| Name | Restriction | Description | OrderBy |
| ---- | ----------- | ----------- | ------- |
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
|personCountryId|int|Country ID: Country ID|  |
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
|personUpdatedByFullName|associate|Updated by - Full name: The user who last updated the data|  |
|personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|personRegisteredBy|associate|Registered by: The user who registered the data|  |
|personRegisteredByFullName|associate|Registered by - Full name: The user who registered the data|  |
|personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.|  |
|personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?|  |
|ticketPriority|listAny|Service priority: Default service priority for this contact|  |
|supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more|  |
|supportAssociate|associate|Our service contact: Default service contact for this contact|  |
|supportAssociateFullName|associate|Our service contact - Full name: Default service contact for this contact|  |
|personAssociateId|associate|Our contact: Displays our contact|  |
|personAssociateFullName|associate|Our contact - Full name: Displays our contact|  |
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
|personContact/countryId| *None* |Country ID: Country ID|  |
|personContact/number| *None* |Number|  |
|personContact/code| *None* |Code|  |
|personContact/orgnr| *None* |VAT No.|  |
|personContact/stop| *None* |Stop|  |
|personContact/contactNoMail| *None* |No mailings (company|  |
|personContact/updatedBy| *None* |Updated by: The user who last updated the data|  |
|personContact/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|personContact/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personContact/registeredBy| *None* |Registered by: The user who registered the data|  |
|personContact/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
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
GET /api/v1/archive/Participants?$select=personEmail,personUpdatedByFullName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

