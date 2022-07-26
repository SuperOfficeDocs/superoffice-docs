---
uid: ContactActivity
title: ContactActivity
description: Activity archive provider for the Company card
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ContactActivity"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ContactActivity"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ContactActivityArchiveProvider">SuperOffice.CRM.ArchiveLists.ContactActivityArchiveProvider</see> inside NetServer's SODatabase assembly.

Activity archive provider for the Company card

## Supported Entities

| Name | Description |
| ---- | ----- |
|"chat"|Other|
|"mailing"|Mailings|
|"formSubmission"|Form submissions|
|"document"|Documents|
|"appointment"|Follow-ups|

## Supported Columns

| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|chatSessionId|int|Chat session ID: Database ID of the chat session| x |
|firstMessage|string|First message: The first message submitted in the chat| x |
|lastMessage|string|Last message: The last message submitted in the chat| x |
|whenRequested|datetime|Chat requested: When was this chat requested by the customer?| x |
|whenStarted|datetime|Chat started: When was this chat started between the customer and the agent?| x |
|whenEnded|datetime|Chat ended: When did this chat end?| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|type|listAny|Type: Displays the type of an activity| x |
|text|positiveString|Text: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|chatTopic/chatTopicId|int|Chat channel - ID: The database ID of the chat channel| x |
|chatTopic/name|string|Chat channel - Name: Name| x |
|chatTopic/description|string|Chat channel - Description: The description of the chat channel| x |
|chatTopic/badgeHeader|string|Chat channel - Badge header: The value of the badge header for the chat channel| x |
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
|mailingId|int|ID: Displays the ID of the mailing| x |
|selectionId|int|Selection ID: The database ID of the selection| x |
|mailingDescription|string|Name: Displays the name of the mailing| x |
|mailingSent|string|Sent: Displays the sent status of the mailing| x |
|mailingEndDate|date|Date: Displays the date of the mailing| x |
|mailingType|listAny|Type: Display the type of the mailing| x |
|mailingSentTo|int|Sent to: Displays to whom the mailing was sent| x |
|mailingOwner|associate|Owner: Displays the owner of the mailing| x |
|mailingDeleted|int|Deleted: Deleted|  |
|recipientStatus|int|Reception status: Status of mailing reception|  |
|projectId|listAny|Project ID: Database ID of project record| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|associate/associateDbId|associate|Associate - ID| x |
|project/completed|bool|Project - Completed: Displays a check mark indicating if the project has been completed.| x |
|project/projectId|int|Project - DB ID: Displays the database ID for a project row| x |
|project/name|stringorPK|Project - Project name: Displays the Project's name| x |
|project/number|string|Project - Number: Displays the project's number| x |
|project/type|listAny|Project - Project type: Displays the project's type| x |
|project/status|listAny|Project - Status: Displays the project's status| x |
|project/associateId|associate|Project - ID: Displays login ID of the associate who owns the project| x |
|project/hasInfoText|bool|Project - Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|project/icon| *None* |Project - Category: Displays the icon for an activity type| x |
|project/text|string|Project - Text: Displays a descriptive text for the item| x |
|project/description|string|Project - Description: Description| x |
|project/updatedBy|associate|Project - Updated by: The user who last updated the data| x |
|project/updatedDate|date|Project - Updated: The date/time the data was last updated in UTC.| x |
|project/registeredBy|associate|Project - Registered by: The user who registered the data| x |
|project/registeredDate|date|Project - Registered date: The date/time the data was registered in UTC.| x |
|project/hasGuide|bool|Project - Guided: Does this sale have a Sales Guide| x |
|project/nextMilestone|date|Project - Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|project/endDate|date|Project - End date: End date of project| x |
|project/imageThumbnail| *None* |Project - Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks|bool|Project - ERP connected: Is there an active ERP Sync?| x |
|project/projectPublish/isPublished|bool|Project - Published: Displays an icon indicating if the project or sale has been published| x |
|project/projectPublish/publishedFrom|date|Project - From date: Start date for publishing. The record will not be visible prior to this date| x |
|project/projectPublish/publishedTo|date|Project - To date: End date for publishing. The record will not be visible after this date| x |
|project/projectPublish/publishedBy| *None* |Project - Published by: Published by|  |
|project/projectEvent/isExternalEvent|bool|Project - Event: Is this an external event| x |
|project/projectEvent/eventDate|date|Project - Event date: Event date| x |
|project/projectEvent/hasSignOn|bool|Project - Sign On: Does this event have the Sign On function enabled| x |
|project/projectEvent/hasSignOff|bool|Project - Sign Off: Does this event have the Sign Off function enabled| x |
|project/projectUrl/URLAddress|string|Project - URL| x |
|project/projectUrl/URLDescription|string|Project - Description| x |
|project/projectAssociate/firstName|string|Project - First name: Displays the contact's first name| x |
|project/projectAssociate/lastName|string|Project - Last name: Displays the contact's last name| x |
|project/projectAssociate/middleName|string|Project - Middle Name: Displays the contact's middle name.| x |
|project/projectAssociate/fullName|string|Project - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|project/projectAssociate/contactId|int|Project - Company ID: Database ID of the company the user belongs to|  |
|project/projectAssociate/personId|int|Project - Contact ID: Database ID of the contact row|  |
|project/projectAssociate/mrMrs|string|Project - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/title|string|Project - Title: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/associateDbId|associate|Project - ID| x |
|project/projectAssociate/contactName|string|Project - Owning company: Name of the company the user belongs to| x |
|project/projectAssociate/contactDepartment|string|Project - Owning department: Name of the department at the company the user belongs to| x |
|project/projectAssociate/usergroup|userGroup|Project - Primary group: The user's primary user group| x |
|project/projectAssociate/contactFullName|string|Project - Owner: Name and department of the company the user belongs to| x |
|project/projectAssociate/contactCategory|listAny|Project - Category: Category| x |
|project/projectAssociate/role|listAny|Project - Role: Role| x |
|project/projectAssociate/assocName|associate|Project - User ID: User ID| x |
|project/projectAssociate/assocTooltip|string|Project - Description: Description|  |
|project/projectAssociate/assocType|listAny|Project - Type: Type of user: associate, external user, system user, anonymous account| x |
|project/projectAssociate/ejUserId|int|Project - Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser|bool|Project - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName|string|Project - Nick name: User's nick name in Service| x |
|project/projectAssociate/ejStatus|int|Project - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Project - Auth. type: What type of credentials to use when this user logs in| x |
|project/projectAssociate/credentialDisplayValue| *None* |Project - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|project/projectAssociate/isActive|bool|Project - Active: Is this user active, and should be able to log in?| x |
|project/projectAssociate/isActiveText|bool|Project - Active status: Is this user active, and should be able to log in?| x |
|project/projectAssociate/portraitThumbnail| *None* |Project - Person image: Person image|  |
|project/projectAssociate/otherGroups|userGroup|Project - Other groups: Other groups|  |
|project/projectAssociate/userName|string|Project - User name: User name| x |
|project/projectAssociate/personEmail|string|Project - E-mail| x |
|project/projectUdef/SuperOffice:1|string|Project - projectshorttext| x |
|project/projectUdef/SuperOffice:2|string|Project - projectlongtext| x |
|project/projectUdef/SuperOffice:3|int|Project - projectnumber| x |
|project/projectUdef/SuperOffice:4|date|Project - projectdate| x |
|project/projectUdef/SuperOffice:5|unlimitedDate|Project - projectunlimiteddate| x |
|project/projectUdef/SuperOffice:6|bool|Project - projectcheckbox| x |
|project/projectUdef/SuperOffice:7|listAny|Project - projectdropdownlistbox| x |
|project/projectUdef/SuperOffice:8|decimal|Project - projectdecimal| x |
|project/projectUdef/SuperOffice:9|int|Project - page1saleandmarketing| x |
|project/projectUdef/SuperOffice:10|int|Project - page1saleandadmin| x |
|project/NumberOfActivities|int|Project - Number of activities|  |
|project/NumberOfActivitiesInPeriod|int|Project - Number of activities in last 90 days|  |
|project/NumberOfNotCompletedActivities|int|Project - Number of non-completed activities|  |
|project/NumberOfNotCompletedActivitiesInPeriod|int|Project - Number of non-completed activities in last 90 days|  |
|project/LastActivity|date|Project - Date of last activity|  |
|project/LastCompletedActivity|date|Project - Date of last completed activity|  |
|project/LastDoByActivity|date|Project - Date of last non-completed activity|  |
|project/NumberOfSales|int|Project - Number of sales|  |
|project/NumberOfSalesInPeriod|int|Project - Number of sales in last 90 days|  |
|project/NumberOfNotCompletedSales|int|Project - Number of non-completed sales|  |
|project/NumberOfNotCompletedSalesInPeriod|int|Project - Number of non-completed sales in last 90 days|  |
|project/LastSale|date|Project - Date of last sale|  |
|project/LastCompletedSale|date|Project - Date of last completed sale|  |
|project/LastDoBySale|date|Project - Date of last non-completed sale|  |
|project/SaintStatus3|saintStatus|Project - Not completed activites with intention sale|  |
|project/saintSaleStatus|listAny|Project - With status|  |
|project/saintAmountClass|listAny|Project - Amount class|  |
|project/saintActivityType|listAny|Project - SAINT type|  |
|project/saintDirection|listAny|Project - Direction|  |
|project/saintIntention|listAny|Project - Intention|  |
|project/saintTicketStatus|listAny|Project - Status|  |
|project/saintTicketCategory|listAny|Project - Category|  |
|project/project/textId|int|Project - Text ID| x |
|project/project/infoText|positiveString|Project - Information: Displays the text entered in the description field| x |
|formSubmissionId|int|Form submission ID: ID of the form submission record| x |
|formSubmissionStatus|listAny|Status: Status of the form submission record| x |
|time| *None* |Time: Time|  |
|completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|recordType|string|Record type : Shows the record type| x |
|saleId|int|Sale ID: The database ID of the sale record| x |
|userGroup|userGroup|User group : The user group that owns the record| x |
|who| *None* |Who: Contact and/or company|  |
|documentId|int|Document ID: Database ID of document record| x |
|keywords|string|Keywords | x |
|ourref|string|Our ref.| x |
|yourref|string|Your ref.| x |
|attention|string|Salutation| x |
|subject|string|Subject| x |
|mailMergeDraft|bool|Mail merge draft : Indicates whether the document is a mail merge template| x |
|snum|int|Document number: Serial number of document. It can be generated by the number allocation system for a dedicated document template.| x |
|isReport|bool|Report: Is this document a saved report run?|  |
|suggestedDocumentId|int|Document ID (suggestion: The database ID of a document that originates in a suggestion| x |
|isMail|bool|E-mail|  |
|visibleFor|listAny|Visible for|  |
|documentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|documentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|documentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|documentPublish/publishedBy| *None* |Published by: Published by|  |
|person/phone/formattedNumber|string|Phone : Displays phone number|  |
|person/personDirectPhone/formattedNumber|string|Direct - Phone: Displays phone number|  |
|person/personDirectPhone/description|string|Direct - Description: Phone number description| x |
|person/personMobilePhone/formattedNumber|string|Mobile - Phone: Displays phone number|  |
|person/personMobilePhone/description|string|Mobile - Description: Phone number description| x |
|person/personPrivate/formattedNumber|string|Private - Phone: Displays phone number|  |
|person/personPrivate/description|string|Private - Description: Phone number description| x |
|person/personPager/formattedNumber|string|Other - Phone: Displays phone number|  |
|person/personPager/description|string|Other - Description: Phone number description| x |
|person/personDirectFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|person/personDirectFax/description|string|Fax - Description: Phone number description| x |
|person/searchPhone/formattedNumber|string|Phone : Displays phone number|  |
|person/searchPhone/description|string|Description: Phone number description| x |
|person/personInfo/textId|int|Text ID| x |
|person/personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|person/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|person/email/emailAddress|string|E-mail| x |
|person/email/emailDescription|string|Description| x |
|person/email/emailId|int|ID| x |
|person/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|person/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|person/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|person/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|person/personUrl/URLAddress|string|URL| x |
|person/personUrl/URLDescription|string|Description| x |
|person/personAddress/addressId|int|Contact address - Address ID: Database ID for the address record| x |
|person/personAddress/line1|string|Contact address - Address 1: First line of the address| x |
|person/personAddress/line2|string|Contact address - Address 2: Second line of the address| x |
|person/personAddress/line3|string|Contact address - Address 3: Third line of the address| x |
|person/personAddress/county|string|Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|person/personAddress/city|string|Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|person/personAddress/zip|string|Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|person/personAddress/state|string|Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|person/personAddress/wgs84latitude|decimal|Contact address - Latitude: Latitude| x |
|person/personAddress/wgs84longitude|decimal|Contact address - Longitude: Longitude| x |
|person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|person/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|person/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|person/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|person/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|person/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|person/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|person/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|person/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|person/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|person/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|person/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|person/personUdef/SuperOffice:3|int|contactnumber| x |
|person/personUdef/SuperOffice:4|date|contactdate| x |
|person/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|person/personUdef/SuperOffice:6|bool|contactcheckbox| x |
|person/personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|person/personUdef/SuperOffice:8|decimal|contactdecimal| x |
|person/personUdef/SuperOffice:9|string|page1saleonly| x |
|person/personUdef/SuperOffice:10|string|page1marketingonly| x |
|person/personUdef/SuperOffice:11|string|page1adminonly| x |
|person/isMailingRecipient|bool|isMailingRecipient: isMailingRecipient| x |
|person/hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/subscription|listAny|Subscription: Subscription for marketing| x |
|person/legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|person/consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contact/phone/formattedNumber|string|Phone : Displays phone number|  |
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
|contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
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
|contact/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|contact/contactUdef/SuperOffice:3|int|companynumber| x |
|contact/contactUdef/SuperOffice:4|date|companydate| x |
|contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|contact/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|contact/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|contact/contactUdef/SuperOffice:9|string|page1saleonly| x |
|contact/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|contact/contactUdef/SuperOffice:11|string|page1adminonly| x |
|contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
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
|contact/SaintStatus1|saintStatus|Neglected customer|  |
|contact/SaintStatus2|saintStatus|C-company|  |
|contact/saintSaleStatus|listAny|With status|  |
|contact/saintAmountClass|listAny|Amount class|  |
|contact/saintActivityType|listAny|SAINT type|  |
|contact/saintDirection|listAny|Direction|  |
|contact/saintIntention|listAny|Intention|  |
|contact/saintTicketStatus|listAny|Status|  |
|contact/saintTicketCategory|listAny|Category|  |
|documentUdef/SuperOffice:1|string|documentshorttext| x |
|documentUdef/SuperOffice:2|string|documentlongtext| x |
|documentUdef/SuperOffice:3|int|documentnumber| x |
|documentUdef/SuperOffice:4|date|documentdate| x |
|documentUdef/SuperOffice:5|unlimitedDate|documentunlimiteddate| x |
|documentUdef/SuperOffice:6|bool|documentcheckbox| x |
|documentUdef/SuperOffice:7|listAny|documentdropdownlistbox| x |
|documentUdef/SuperOffice:8|decimal|documentdecimal| x |
|sale/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|sale/icon| *None* |Category: Displays the icon for an activity type| x |
|sale/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|sale/time| *None* |Time: Time|  |
|sale/type|listAny|Type: Displays the type of an activity| x |
|sale/recordType|string|Record type : Shows the record type| x |
|sale/text|positiveString|Text: Displays a descriptive text for the item| x |
|sale/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|sale/contactId|listAny|Company ID: Database ID of company| x |
|sale/personId|listAny|Contact ID: Database ID of the contact row| x |
|sale/projectId|listAny|Project ID: Database ID of project record| x |
|sale/saleId|int|Sale ID: The database ID of the sale record| x |
|sale/userGroup|userGroup|User group : The user group that owns the record| x |
|sale/who| *None* |Who: Contact and/or company|  |
|sale/updatedBy|associate|Updated by: The user who last updated the data| x |
|sale/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|sale/registeredBy|associate|Registered by: The user who registered the data| x |
|sale/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|sale/currencyId|int|Currency ID: The currency list item ID| x |
|sale/currency|listAny|Currency: The currency of the sale| x |
|sale/credited|listAny|Credited: The user to be credited with the sale| x |
|sale/lossReason|listAny|Reason (lost: The reason for losing the sale| x |
|sale/source|listAny|Source: The source (lead) of the sale| x |
|sale/competitor|listAny|Competitor: The competitor who won the sale| x |
|sale/heading|stringorPK|Sale: Displays a descriptive text for the item| x |
|sale/amount|decimal|Amount: The gross sales total| x |
|sale/amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.| x |
|sale/earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale| x |
|sale/earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total| x |
|sale/probPercent|int|Probability as %: Probability as %| x |
|sale/originalStage|listAny|Stage: Displays the stage of the sale| x |
|sale/stage|listAny|Stage: Displays the stage of the sale| x |
|sale/saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|sale/saleType|listAny|Sale type: Sale type, from list| x |
|sale/nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|sale/reopenDate|date|Reopen date: Displays the reopen date for the sale| x |
|sale/stalledComment|listAny|Reason (stalled: The reason the sale has been stalled| x |
|sale/soldReason|listAny|Reason (sold: Reason (sold)| x |
|sale/saleNumber|string|Number: Number| x |
|sale/hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders enabled| x |
|sale/hasQuote|bool|Has quote?: Does the sale have a quote attached?| x |
|sale/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|sale/description|string|Description: The long description field on Sale|  |
|sale/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|sale/visibleFor|listAny|Visible for|  |
|sale/sale/textId|int|Text ID| x |
|sale/sale/description|positiveString|Text: Displays the text entered in the description field| x |
|sale/salePublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|sale/salePublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|sale/salePublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|sale/associate/firstName|string|First name: Displays the contact's first name| x |
|sale/associate/lastName|string|Last name: Displays the contact's last name| x |
|sale/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|sale/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|sale/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|sale/associate/personId|int|Contact ID: Database ID of the contact row|  |
|sale/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|sale/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|sale/associate/associateDbId|associate|ID| x |
|sale/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|sale/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|sale/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|sale/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|sale/associate/contactCategory|listAny|Category: Category| x |
|sale/associate/role|listAny|Role : Role| x |
|sale/associate/assocName|associate|User ID : User ID| x |
|sale/associate/assocTooltip|string|Description : Description|  |
|sale/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|sale/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|sale/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|sale/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|sale/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|sale/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|sale/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|sale/associate/otherGroups|userGroup|Other groups: Other groups|  |
|sale/associate/userName|string|User name: User name| x |
|sale/associate/personEmail|string|E-mail| x |
|sale/saleUdef/SuperOffice:1|string|saleshorttext| x |
|sale/saleUdef/SuperOffice:2|string|salelongtext| x |
|sale/saleUdef/SuperOffice:3|int|salenumber| x |
|sale/saleUdef/SuperOffice:4|date|saledate| x |
|sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|sale/saleUdef/SuperOffice:6|bool|salecheckbox| x |
|sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|sale/saleUdef/SuperOffice:8|decimal|saledecimal| x |
|document/textId|int|Text ID| x |
|document/description|positiveString|Text: Displays the text entered in the description field| x |
|participating|bool|Participating?: Am I among the participants in a meeting?|  |
|appointmentId|int|DB ID: Displays the database ID of a row| x |
|endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|priority|listAny|Priority: Displays the priority of the activity| x |
|alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|intention|listAny|Intention: Displays the intention of the follow-up type| x |
|location|string|Location: Display the location where the follow-up will take place.| x |
|recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up| x |
|rawType|int|Type: Type field for appointment, not decoded or formatted| x |
|rawStatus|int|Status: Status field for the follow-up, not decoded or formatted| x |
|cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?| x |
|endTime| *None* |End time: End time of an activity|  |
|suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|appointmentUdef/SuperOffice:3|int|followupnumber| x |
|appointmentUdef/SuperOffice:4|date|followupdate| x |
|appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|appointment/textId|int|Text ID| x |
|appointment/description|positiveString|Text: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/ContactActivity?$select=contact/updatedBy,userGroup,person/restrictionAddress/formattedMultiLineAddress,contact/contactPhone/formattedNumber,contact/restrictionAddress/wgs84latitude
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.
