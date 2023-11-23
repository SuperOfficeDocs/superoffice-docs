---
uid: EmailFlowContent
title: EmailFlowContent
description: Archive of Email flow content.
keywords: EmailFlowContent archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "EmailFlowContent"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider">SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider</see> inside NetServer's SODatabase assembly.

Archive of Email flow content.
Lists all email flow content

## Supported Entities
| Name | Description |
| ---- | ----- |
|"SMessage"|[SMessage]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|shipmentMessageId|int|ID: ID| x |
|shipmentMessagePictureFolderId|int|Folder: Folder| x |
|shipmentMessageThumbnail| *None* |Thumbnail|  |
|shipmentMessageSubject|string|Subject: Subject| x |
|shipmentMessageDescription|string|Description : Description| x |
|nameOrDescription|string|Description : Description| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|emailFlow/emailFlowId|int|Email flow Id: The database Id of the email flow| x |
|emailFlow/emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|emailFlow/shipmentType|listAny|Mailing type: Mailing type this e-mail flow represents| x |
|emailFlow/overrideConsentSubscription|bool|Override consent: Should consent subscriptions be overridden for this workflow?| x |
|emailFlow/thumbnail| *None* |Thumbnail|  |
|emailFlow/updatedBy|associate|Updated by: The user who last updated the data| x |
|emailFlow/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|emailFlow/registeredBy|associate|Registered by: The user who registered the data| x |
|emailFlow/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|emailFlow/workflowId|int|Workflow id: Id of a worflow definition| x |
|emailFlow/workflowDescription|string|Description: Description of the workflow definition| x |
|emailFlow/workflowDefinitionStatus|listAny|E-mail flow status: Status of the workflow definition| x |
|emailFlow/jumpToFinish|bool|Jump to finish: Should participant jump to finish when the goals are met?| x |
|emailFlow/startOnlyOnce|bool|Start only once: Should the participant enter the workflow only once?| x |
|emailFlow/workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this workflow|  |
|emailFlow/workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|emailFlow/workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|emailFlow/workflowSucceededCount| *None* |Succeeded: How many participants has successfully finished the workflow (goals criteria met)|  |
|emailFlow/workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|emailFlow/workflowAssociate/firstName|string|First name: Displays the contact's first name| x |
|emailFlow/workflowAssociate/lastName|string|Last name: Displays the contact's last name| x |
|emailFlow/workflowAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|emailFlow/workflowAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|emailFlow/workflowAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|emailFlow/workflowAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|emailFlow/workflowAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|emailFlow/workflowAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|emailFlow/workflowAssociate/associateDbId|associate|ID| x |
|emailFlow/workflowAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|emailFlow/workflowAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|emailFlow/workflowAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|emailFlow/workflowAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|emailFlow/workflowAssociate/contactCategory|listAny|Category: Category| x |
|emailFlow/workflowAssociate/role|listAny|Role : Role| x |
|emailFlow/workflowAssociate/assocName|associate|User ID : User ID| x |
|emailFlow/workflowAssociate/assocTooltip|string|Description : Description|  |
|emailFlow/workflowAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|emailFlow/workflowAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|emailFlow/workflowAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|emailFlow/workflowAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|emailFlow/workflowAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|emailFlow/workflowAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|emailFlow/workflowAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|emailFlow/workflowAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|emailFlow/workflowAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|emailFlow/workflowAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|emailFlow/workflowAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|emailFlow/workflowAssociate/userName|string|User name: User name| x |
|emailFlow/workflowAssociate/personEmail|string|E-mail| x |
|emailFlow/hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|emailFlow/hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|emailFlow/hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|emailFlow/hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|emailFlow/hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |
|shipment/mailingId|int|ID: Displays the ID of the mailing| x |
|shipment/mailingSelectionId|int|Selection ID: The database ID of the selection| x |
|shipment/mailingSent|listAny|Sent: Displays the sent status of the mailing| x |
|shipment/mailingSimpleStatus|listAny|Status: Status| x |
|shipment/mailingEndDate|date|Date sent: Displays the date when the mailing was sent (completed)| x |
|shipment/mailingType|listAny|Type: Display the type of the mailing| x |
|shipment/mailingSubscriptionType|listAny|Subscription type: The subscription type for a mailing| x |
|shipment/mailingSentTo|int|Sent to: Displays to whom the mailing was sent| x |
|shipment/mailingOwner|associate|Owner: Displays the owner of the mailing| x |
|shipment/mailingFrom|string|From: Mailing from| x |
|shipment/mailingReplyTo|string|To: To| x |
|shipment/mailingSentCount|int|Number sent: Number of sent mailings| x |
|shipment/mailingOpenRate|decimal|Open rate: The open rate for a mailing| x |
|shipment/mailingClickRate|decimal|Click-through rate: Mailing click-through rate| x |
|shipment/mailingBounceRate|decimal|Bounce rate: Mailing bounce rate| x |
|shipment/mailingDeleted|bool|Deleted: Deleted|  |
|shipment/recipientStatus|listAny|Recipient status: Status of mailing recipient|  |
|shipment/icon| *None* |Category: Displays the icon for an activity type| x |
|shipment/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|shipment/type|listAny|Type: Displays the type of an activity| x |
|shipment/text|positiveString|Text: Displays a descriptive text for the item| x |
|shipment/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|shipment/contactId|listAny|Company ID: Database ID of company| x |
|shipment/personId|listAny|Contact ID: Database ID of the contact row| x |
|shipment/projectId|listAny|Project ID: Database ID of project record| x |
|shipment/updatedBy|associate|Updated by: The user who last updated the data| x |
|shipment/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|shipment/registeredBy|associate|Registered by: The user who registered the data| x |
|shipment/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|shipment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|shipment/mailingAddr/mailingAddrId|int|!!!Mailing addr Id: !!!Mailing addr Id Tooltip| x |
|shipment/mailingAddr/status|listAny|Recipient status: Status of mailing recipient|  |
|shipment/mailingAddr/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/mailingAddr/contactId|int|Company ID: Database ID of company| x |
|shipment/mailingAddr/personId|int|Contact ID: Database ID of the contact row| x |
|shipment/mailingAddr/contact/contactId|int|Company - Company ID: Database ID of company| x |
|shipment/mailingAddr/contact/name|stringorPK|Company - Company name| x |
|shipment/mailingAddr/contact/department|string|Company - Department| x |
|shipment/mailingAddr/contact/nameDepartment| *None* |Company - Company: Displays the company an activity is linked to| x |
|shipment/mailingAddr/contact/hasInfoText|bool|Company - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|shipment/mailingAddr/contact/hasInterests|bool|Company - Has interests: Displays an Icon indicating if the contact has active interests| x |
|shipment/mailingAddr/contact/associateId|associate|Company - Our contact: Displays our contact| x |
|shipment/mailingAddr/contact/category|listAny|Company - Category| x |
|shipment/mailingAddr/contact/business|listAny|Company - Business| x |
|shipment/mailingAddr/contact/country|listAny|Company - Country: This criterion corresponds to the Country field on the Company card.| x |
|shipment/mailingAddr/contact/countryId|int|Company - Country ID: Country ID| x |
|shipment/mailingAddr/contact/number|string|Company - Number| x |
|shipment/mailingAddr/contact/code|string|Company - Code| x |
|shipment/mailingAddr/contact/orgnr|string|Company - VAT No.| x |
|shipment/mailingAddr/contact/stop|bool|Company - Stop| x |
|shipment/mailingAddr/contact/contactNoMail|bool|Company - No mailings (company)| x |
|shipment/mailingAddr/contact/updatedBy|associate|Company - Updated by: The user who last updated the data| x |
|shipment/mailingAddr/contact/updatedByFullName|associate|Company - Updated by - Full name: The user who last updated the data| x |
|shipment/mailingAddr/contact/updatedDate|date|Company - Updated: The date/time the data was last updated in UTC.| x |
|shipment/mailingAddr/contact/registeredBy|associate|Company - Registered by: The user who registered the data| x |
|shipment/mailingAddr/contact/registeredByFullName|associate|Company - Registered by - Full name: The user who registered the data| x |
|shipment/mailingAddr/contact/registeredDate|date|Company - Registered date: The date/time the data was registered in UTC.| x |
|shipment/mailingAddr/contact/contactSource|listAny|Company - Source: Source (Company)| x |
|shipment/mailingAddr/contact/contactDeleted|bool|Company - Deleted: Deleted| x |
|shipment/mailingAddr/contact/phone/formattedNumber|string|Company - Phone: Displays phone number|  |
|shipment/mailingAddr/contact/activeErpLinks|bool|Company - ERP connected: Is there an active ERP Sync?| x |
|shipment/mailingAddr/contact/deletedDate|datetime|Company - Deleted date: Deleted date|  |
|shipment/mailingAddr/contact/mainContact| *None* |Company - Main contact: Main contact for this company| x |
|shipment/mailingAddr/contact/contactPhone/formattedNumber|string|Company - Telephone - Phone: Displays phone number|  |
|shipment/mailingAddr/contact/contactPhone/description|string|Company - Telephone - Description: Phone number description| x |
|shipment/mailingAddr/contact/contactFax/formattedNumber|string|Company - Fax - Phone: Displays phone number|  |
|shipment/mailingAddr/contact/contactFax/description|string|Company - Fax - Description: Phone number description| x |
|shipment/mailingAddr/contact/searchPhone/formattedNumber|string|Company - Searchphone - Phone: Displays phone number|  |
|shipment/mailingAddr/contact/searchPhone/description|string|Company - Searchphone - Description: Phone number description| x |
|shipment/mailingAddr/contact/email/emailProtocol|string|Company - Protocol: E-mail protocol, such as SMTP| x |
|shipment/mailingAddr/contact/email/emailAddress|string|Company - E-mail| x |
|shipment/mailingAddr/contact/email/emailDescription|string|Company - Description| x |
|shipment/mailingAddr/contact/email/emailId|int|Company - ID| x |
|shipment/mailingAddr/contact/email/emailLastSent|datetime|Company - Last sent: The date and time an e-mail was last sent to this address| x |
|shipment/mailingAddr/contact/email/emailBounceCount|int|Company - Bounce count: Bounce count for this e-mail address| x |
|shipment/mailingAddr/contact/email/emailLastBounce|datetime|Company - Last bounce: Date and time for last bounce to this e-mail address| x |
|shipment/mailingAddr/contact/email/emailHasBounced|bool|Company - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|shipment/mailingAddr/contact/postAddress/addressId|int|Company - Postal address - Address ID: Database ID for the address record| x |
|shipment/mailingAddr/contact/postAddress/line1|string|Company - Postal address - Address 1: First line of the address| x |
|shipment/mailingAddr/contact/postAddress/line2|string|Company - Postal address - Address 2: Second line of the address| x |
|shipment/mailingAddr/contact/postAddress/line3|string|Company - Postal address - Address 3: Third line of the address| x |
|shipment/mailingAddr/contact/postAddress/county|string|Company - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/contact/postAddress/city|string|Company - Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|shipment/mailingAddr/contact/postAddress/zip|string|Company - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|shipment/mailingAddr/contact/postAddress/state|string|Company - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/contact/postAddress/wgs84latitude|decimal|Company - Postal address - Latitude: Latitude| x |
|shipment/mailingAddr/contact/postAddress/wgs84longitude|decimal|Company - Postal address - Longitude: Longitude| x |
|shipment/mailingAddr/contact/postAddress/formattedAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/contact/postAddress/formattedMultiLineAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/contact/streetAddress/addressId|int|Company - Street address - Address ID: Database ID for the address record| x |
|shipment/mailingAddr/contact/streetAddress/line1|string|Company - Street address - Address 1: First line of the address| x |
|shipment/mailingAddr/contact/streetAddress/line2|string|Company - Street address - Address 2: Second line of the address| x |
|shipment/mailingAddr/contact/streetAddress/line3|string|Company - Street address - Address 3: Third line of the address| x |
|shipment/mailingAddr/contact/streetAddress/county|string|Company - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/contact/streetAddress/city|string|Company - Street address - City: This criterion corresponds to the City field on the Company card.| x |
|shipment/mailingAddr/contact/streetAddress/zip|string|Company - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|shipment/mailingAddr/contact/streetAddress/state|string|Company - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/contact/streetAddress/wgs84latitude|decimal|Company - Street address - Latitude: Latitude| x |
|shipment/mailingAddr/contact/streetAddress/wgs84longitude|decimal|Company - Street address - Longitude: Longitude| x |
|shipment/mailingAddr/contact/streetAddress/formattedAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/contact/streetAddress/formattedMultiLineAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/contact/restrictionAddress/addressId|int|Company - Search address - Address ID: Database ID for the address record| x |
|shipment/mailingAddr/contact/restrictionAddress/line1|string|Company - Search address - Address 1: First line of the address| x |
|shipment/mailingAddr/contact/restrictionAddress/line2|string|Company - Search address - Address 2: Second line of the address| x |
|shipment/mailingAddr/contact/restrictionAddress/line3|string|Company - Search address - Address 3: Third line of the address| x |
|shipment/mailingAddr/contact/restrictionAddress/county|string|Company - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/contact/restrictionAddress/city|string|Company - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|shipment/mailingAddr/contact/restrictionAddress/zip|string|Company - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|shipment/mailingAddr/contact/restrictionAddress/state|string|Company - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/contact/restrictionAddress/wgs84latitude|decimal|Company - Search address - Latitude: Latitude| x |
|shipment/mailingAddr/contact/restrictionAddress/wgs84longitude|decimal|Company - Search address - Longitude: Longitude| x |
|shipment/mailingAddr/contact/restrictionAddress/formattedAddress| *None* |Company - Search address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/contact/restrictionAddress/formattedMultiLineAddress| *None* |Company - Search address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/contact/url/URLAddress|string|Company - URL| x |
|shipment/mailingAddr/contact/url/URLDescription|string|Company - Description| x |
|shipment/mailingAddr/contact/contactAssociate/firstName|string|Company - First name: Displays the contact's first name| x |
|shipment/mailingAddr/contact/contactAssociate/lastName|string|Company - Last name: Displays the contact's last name| x |
|shipment/mailingAddr/contact/contactAssociate/middleName|string|Company - Middle Name: Displays the contact's middle name.| x |
|shipment/mailingAddr/contact/contactAssociate/fullName|string|Company - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|shipment/mailingAddr/contact/contactAssociate/contactId|int|Company - Company ID: Database ID of the company the user belongs to|  |
|shipment/mailingAddr/contact/contactAssociate/personId|int|Company - Contact ID: Database ID of the contact row|  |
|shipment/mailingAddr/contact/contactAssociate/mrMrs|string|Company - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/mailingAddr/contact/contactAssociate/title|string|Company - Title: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/mailingAddr/contact/contactAssociate/associateDbId|associate|Company - ID| x |
|shipment/mailingAddr/contact/contactAssociate/contactName|string|Company - Owning company: Name of the company the user belongs to| x |
|shipment/mailingAddr/contact/contactAssociate/contactDepartment|string|Company - Owning department: Name of the department at the company the user belongs to| x |
|shipment/mailingAddr/contact/contactAssociate/usergroup|userGroup|Company - Primary group: The user's primary user group| x |
|shipment/mailingAddr/contact/contactAssociate/contactFullName|string|Company - Owner: Name and department of the company the user belongs to| x |
|shipment/mailingAddr/contact/contactAssociate/contactCategory|listAny|Company - Category: Category| x |
|shipment/mailingAddr/contact/contactAssociate/role|listAny|Company - Role: Role| x |
|shipment/mailingAddr/contact/contactAssociate/assocName|associate|Company - User ID: User ID| x |
|shipment/mailingAddr/contact/contactAssociate/assocTooltip|string|Company - Description: Description|  |
|shipment/mailingAddr/contact/contactAssociate/assocType|listAny|Company - Type: Type of user: associate, external user, system user, anonymous account| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/mailingAddr/contact/contactAssociate/ejUserId|int|Company - Service user ID: The database ID of a Service user|  |
|shipment/mailingAddr/contact/contactAssociate/simultaneousEjUser|bool|Company - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/mailingAddr/contact/contactAssociate/ejDisplayName|string|Company - Nick name: User's nick name in Service| x |
|shipment/mailingAddr/contact/contactAssociate/ejStatus|int|Company - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/mailingAddr/contact/contactAssociate/credentialType| *None* |Company - Auth. type: What type of credentials to use when this user logs in| x |
|shipment/mailingAddr/contact/contactAssociate/credentialDisplayValue| *None* |Company - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|shipment/mailingAddr/contact/contactAssociate/isActive|bool|Company - Active: Is this user active, and should be able to log in?| x |
|shipment/mailingAddr/contact/contactAssociate/isActiveText|bool|Company - Active status: Is this user active, and should be able to log in?| x |
|shipment/mailingAddr/contact/contactAssociate/portraitThumbnail| *None* |Company - Person image: Person image|  |
|shipment/mailingAddr/contact/contactAssociate/otherGroups|userGroup|Company - Other groups: Other groups|  |
|shipment/mailingAddr/contact/contactAssociate/userName|string|Company - User name: User name| x |
|shipment/mailingAddr/contact/contactAssociate/personEmail|string|Company - E-mail| x |
|shipment/mailingAddr/contact/contactInterestIds|listInterest|Company - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:1|string|Company - companyshorttext: tooltipshorttext| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:2|string|Company - companylongtext: tooltiplongtext| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:3|int|Company - companynumber| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:4|date|Company - companydate| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:5|unlimitedDate|Company - companyunlimiteddate: tooltipunlimiteddate| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:6|bool|Company - companycheckbox| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:7|listAny|Company - companydropdownlistbox| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:8|decimal|Company - companydecimal| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:9|string|Company - page1saleonly| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:10|string|Company - page1marketingonly| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:11|string|Company - page1adminonly| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:12|listAny|Company - Udlist one: Static tooltip for udlist one| x |
|shipment/mailingAddr/contact/contactUdef/SuperOffice:13|listAny|Company - Udlist two: Static tooltip for udlist two| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_integer|int|Company - Extra Integer: Custom integer field| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_hidden\_integer|int|Company - Extra hidden integer: Custom integer field - hidden| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_default\_integer|int|Company - Extra Default Integer: Custom integer field with default value 123.| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_float|decimal|Company - Extra Float: Custom float field with 3 decimals| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_longtext|string|Company - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_dropdown|listAny|Company - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_date|date|Company - Extra date: Custom date field. User current as default.| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_datetime|datetime|Company - Extra DateTime: Custom Date Time field. No default value. External| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_time| *None* |Company - Extra time: Custom time field.| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_boolean|bool|Company - Extra boolean: Custom boolean field.| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_timespan|timeSpan|Company - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_shorttext|string|Company - Extra short text: Custom short text field. Keep HTML tags.| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_short\_dropdown|listAny|Company - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Company - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_request\_relation|stringorPK|Company - Extra Request relation: Request relation on company| x |
|shipment/mailingAddr/contact/contactExtra/x\_contact\_contact|stringorPK|Company - Extra contact relation: Contact relation on company| x |
|shipment/mailingAddr/contact/NumberOfActivities|int|Company - Number of activities|  |
|shipment/mailingAddr/contact/NumberOfActivitiesInPeriod|int|Company - Number of activities in last 90 days|  |
|shipment/mailingAddr/contact/NumberOfNotCompletedActivities|int|Company - Number of non-completed activities|  |
|shipment/mailingAddr/contact/NumberOfNotCompletedActivitiesInPeriod|int|Company - Number of non-completed activities in last 90 days|  |
|shipment/mailingAddr/contact/LastActivity|date|Company - Date of last activity|  |
|shipment/mailingAddr/contact/LastCompletedActivity|date|Company - Date of last completed activity|  |
|shipment/mailingAddr/contact/LastDoByActivity|date|Company - Date of last non-completed activity|  |
|shipment/mailingAddr/contact/NumberOfSales|int|Company - Number of sales|  |
|shipment/mailingAddr/contact/NumberOfSalesInPeriod|int|Company - Number of sales in last 90 days|  |
|shipment/mailingAddr/contact/NumberOfNotCompletedSales|int|Company - Number of non-completed sales|  |
|shipment/mailingAddr/contact/NumberOfNotCompletedSalesInPeriod|int|Company - Number of non-completed sales in last 90 days|  |
|shipment/mailingAddr/contact/LastSale|date|Company - Date of last sale|  |
|shipment/mailingAddr/contact/LastCompletedSale|date|Company - Date of last completed sale|  |
|shipment/mailingAddr/contact/LastDoBySale|date|Company - Date of last non-completed sale|  |
|shipment/mailingAddr/contact/NumberOfTickets|int|Company - Number of requests|  |
|shipment/mailingAddr/contact/NumberOfTicketsInPeriod|int|Company - Number of requests in last 90 days|  |
|shipment/mailingAddr/contact/NumberOfNotCompletedTickets|int|Company - Number of non-completed requests|  |
|shipment/mailingAddr/contact/NumberOfNotCompletedTicketsInPeriod|int|Company - Number of non-completed requests in last 90 days|  |
|shipment/mailingAddr/contact/LastTicket|date|Company - Date of last request|  |
|shipment/mailingAddr/contact/LastCompletedTicket|date|Company - Date of last completed request|  |
|shipment/mailingAddr/contact/LastDoByTicket|date|Company - Date of last non-completed request|  |
|shipment/mailingAddr/contact/SaintStatus1|saintStatus|Company - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|shipment/mailingAddr/contact/SaintStatus2|saintStatus|Company - C-company: Kundens navn starter med bokstaven C|  |
|shipment/mailingAddr/contact/saintSaleStatus|listAny|Company - With status|  |
|shipment/mailingAddr/contact/saintAmountClass|listAny|Company - Amount class|  |
|shipment/mailingAddr/contact/saintActivityType|listAny|Company - SAINT type|  |
|shipment/mailingAddr/contact/saintDirection|listAny|Company - Direction|  |
|shipment/mailingAddr/contact/saintIntention|listAny|Company - Intention|  |
|shipment/mailingAddr/contact/saintTicketStatus|listAny|Company - Status|  |
|shipment/mailingAddr/contact/saintTicketCategory|listAny|Company - Category|  |
|shipment/mailingAddr/person/personId|int|Contact - DB ID: Displays the database ID of a contact| x |
|shipment/mailingAddr/person/firstName|string|Contact - First name: Displays the contact's first name| x |
|shipment/mailingAddr/person/lastName|string|Contact - Last name: Displays the contact's last name| x |
|shipment/mailingAddr/person/middleName|string|Contact - Middle name: Displays the contact's middle name.| x |
|shipment/mailingAddr/person/fullName|stringorPK|Contact - Contact: Displays the contact to which an item is linked| x |
|shipment/mailingAddr/person/contactId|int|Contact - Company ID: Database ID of company| x |
|shipment/mailingAddr/person/hasInfoText|bool|Contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|shipment/mailingAddr/person/hasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|shipment/mailingAddr/person/personHasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|shipment/mailingAddr/person/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/mailingAddr/person/position|listAny|Contact - Position| x |
|shipment/mailingAddr/person/personNumber|string|Contact - Number: Displays the contact's number| x |
|shipment/mailingAddr/person/title|string|Contact - Title: Displays the contact's job title| x |
|shipment/mailingAddr/person/personCountry|listAny|Contact - Country: Country| x |
|shipment/mailingAddr/person/personCountryId|int|Contact - Country ID: Country ID| x |
|shipment/mailingAddr/person/personNoMail|bool|Contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|shipment/mailingAddr/person/rank|int|Contact - Rank: Displays a contact's current rank| x |
|shipment/mailingAddr/person/birthdate| *None* |Contact - Birthdate: Displays the contact's date of birth|  |
|shipment/mailingAddr/person/associateType| *None* |Contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|shipment/mailingAddr/person/useAsMailingAddress|bool|Contact - Use as postal address: Use as postal address| x |
|shipment/mailingAddr/person/personSource|listAny|Contact - Source: Source (Contact)| x |
|shipment/mailingAddr/person/retired|bool|Contact - Former employee: Indicates whether the contact has retired/left the company| x |
|shipment/mailingAddr/person/birthYear|int|Contact - Birth year: Displays contact's birth year| x |
|shipment/mailingAddr/person/birthMonth|int|Contact - Birth month: Displays contact's birth month| x |
|shipment/mailingAddr/person/birthDay|int|Contact - Birth day: Displays contact's birth day (day of month)| x |
|shipment/mailingAddr/person/kanaFirstName|string|Contact - First name, kana: Contact's first name, in kana alphabet| x |
|shipment/mailingAddr/person/kanaLastName|string|Contact - Last name, kana: Contact's last name, in kana alphabet| x |
|shipment/mailingAddr/person/personUpdatedBy|associate|Contact - Updated by: The user who last updated the data| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/mailingAddr/person/personUpdatedByFullName|associate|Contact - Updated by - Full name: The user who last updated the data| x |
|shipment/mailingAddr/person/personUpdatedDate|date|Contact - Updated: The date/time the data was last updated in UTC.| x |
|shipment/mailingAddr/person/personRegisteredBy|associate|Contact - Registered by: The user who registered the data| x |
|shipment/mailingAddr/person/personRegisteredByFullName|associate|Contact - Registered by - Full name: The user who registered the data| x |
|shipment/mailingAddr/person/personRegisteredDate|date|Contact - Registered date: The date/time the data was registered in UTC.| x |
|shipment/mailingAddr/person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|shipment/mailingAddr/person/personActiveErpLinks|bool|Contact - ERP connected: Is there an active ERP Sync?| x |
|shipment/mailingAddr/person/ticketPriority|listAny|Contact - Service priority: Default service priority for this contact| x |
|shipment/mailingAddr/person/supportLanguage|listAny|Contact - Preferred language: Preferred language used for reply templates and more| x |
|shipment/mailingAddr/person/supportAssociate|associate|Contact - Our service contact: Default service contact for this contact| x |
|shipment/mailingAddr/person/supportAssociateFullName|associate|Contact - Our service contact - Full name: Default service contact for this contact| x |
|shipment/mailingAddr/person/personAssociateId|associate|Contact - Our contact: Displays our contact| x |
|shipment/mailingAddr/person/personAssociateFullName|associate|Contact - Our contact - Full name: Displays our contact| x |
|shipment/mailingAddr/person/personCategory|listAny|Contact - Category| x |
|shipment/mailingAddr/person/personBusiness|listAny|Contact - Business| x |
|shipment/mailingAddr/person/personDeletedDate|datetime|Contact - Deleted date: Deleted date|  |
|shipment/mailingAddr/person/hasCompany|bool|Contact - Has company: The contact is associated with a company| x |
|shipment/mailingAddr/person/isProjectMember|bool|Contact - Is project member: This person is a project member| x |
|shipment/mailingAddr/person/isStakeholder|bool|Contact - Is stakeholder: This person is a sale stakeholder| x |
|shipment/mailingAddr/person/phone/formattedNumber|string|Contact - Phone: Displays phone number|  |
|shipment/mailingAddr/person/personDirectPhone/formattedNumber|string|Contact - Direct - Phone: Displays phone number|  |
|shipment/mailingAddr/person/personDirectPhone/description|string|Contact - Direct - Description: Phone number description| x |
|shipment/mailingAddr/person/personMobilePhone/formattedNumber|string|Contact - Mobile - Phone: Displays phone number|  |
|shipment/mailingAddr/person/personMobilePhone/description|string|Contact - Mobile - Description: Phone number description| x |
|shipment/mailingAddr/person/personPrivate/formattedNumber|string|Contact - Private - Phone: Displays phone number|  |
|shipment/mailingAddr/person/personPrivate/description|string|Contact - Private - Description: Phone number description| x |
|shipment/mailingAddr/person/personPager/formattedNumber|string|Contact - Other - Phone: Displays phone number|  |
|shipment/mailingAddr/person/personPager/description|string|Contact - Other - Description: Phone number description| x |
|shipment/mailingAddr/person/personDirectFax/formattedNumber|string|Contact - Fax - Phone: Displays phone number|  |
|shipment/mailingAddr/person/personDirectFax/description|string|Contact - Fax - Description: Phone number description| x |
|shipment/mailingAddr/person/searchPhone/formattedNumber|string|Contact - Phone: Displays phone number|  |
|shipment/mailingAddr/person/searchPhone/description|string|Contact - Description: Phone number description| x |
|shipment/mailingAddr/person/personInfo/textId|int|Contact - Text ID| x |
|shipment/mailingAddr/person/personInfo/infoText|positiveString|Contact - Information: Displays the text entered in the description field| x |
|shipment/mailingAddr/person/email/emailProtocol|string|Contact - Protocol: E-mail protocol, such as SMTP| x |
|shipment/mailingAddr/person/email/emailAddress|string|Contact - E-mail| x |
|shipment/mailingAddr/person/email/emailDescription|string|Contact - Description| x |
|shipment/mailingAddr/person/email/emailId|int|Contact - ID| x |
|shipment/mailingAddr/person/email/emailLastSent|datetime|Contact - Last sent: The date and time an e-mail was last sent to this address| x |
|shipment/mailingAddr/person/email/emailBounceCount|int|Contact - Bounce count: Bounce count for this e-mail address| x |
|shipment/mailingAddr/person/email/emailLastBounce|datetime|Contact - Last bounce: Date and time for last bounce to this e-mail address| x |
|shipment/mailingAddr/person/email/emailHasBounced|bool|Contact - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|shipment/mailingAddr/person/personUrl/URLAddress|string|Contact - URL| x |
|shipment/mailingAddr/person/personUrl/URLDescription|string|Contact - Description| x |
|shipment/mailingAddr/person/personAddress/addressId|int|Contact - Contact address - Address ID: Database ID for the address record| x |
|shipment/mailingAddr/person/personAddress/line1|string|Contact - Contact address - Address 1: First line of the address| x |
|shipment/mailingAddr/person/personAddress/line2|string|Contact - Contact address - Address 2: Second line of the address| x |
|shipment/mailingAddr/person/personAddress/line3|string|Contact - Contact address - Address 3: Third line of the address| x |
|shipment/mailingAddr/person/personAddress/county|string|Contact - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/person/personAddress/city|string|Contact - Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|shipment/mailingAddr/person/personAddress/zip|string|Contact - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|shipment/mailingAddr/person/personAddress/state|string|Contact - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/person/personAddress/wgs84latitude|decimal|Contact - Contact address - Latitude: Latitude| x |
|shipment/mailingAddr/person/personAddress/wgs84longitude|decimal|Contact - Contact address - Longitude: Longitude| x |
|shipment/mailingAddr/person/personAddress/formattedAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/person/personAddress/formattedMultiLineAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/person/restrictionAddress/addressId|int|Contact - Search address - Address ID: Database ID for the address record| x |
|shipment/mailingAddr/person/restrictionAddress/line1|string|Contact - Search address - Address 1: First line of the address| x |
|shipment/mailingAddr/person/restrictionAddress/line2|string|Contact - Search address - Address 2: Second line of the address| x |
|shipment/mailingAddr/person/restrictionAddress/line3|string|Contact - Search address - Address 3: Third line of the address| x |
|shipment/mailingAddr/person/restrictionAddress/county|string|Contact - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/person/restrictionAddress/city|string|Contact - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|shipment/mailingAddr/person/restrictionAddress/zip|string|Contact - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|shipment/mailingAddr/person/restrictionAddress/state|string|Contact - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|shipment/mailingAddr/person/restrictionAddress/wgs84latitude|decimal|Contact - Search address - Latitude: Latitude| x |
|shipment/mailingAddr/person/restrictionAddress/wgs84longitude|decimal|Contact - Search address - Longitude: Longitude| x |
|shipment/mailingAddr/person/restrictionAddress/formattedAddress| *None* |Contact - Search address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/person/restrictionAddress/formattedMultiLineAddress| *None* |Contact - Search address - {formattedAddress}: {formattedAddress}|  |
|shipment/mailingAddr/person/personInterestIds|listInterest|Contact - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|shipment/mailingAddr/person/personUdef/SuperOffice:1|string|Contact - contactshorttext: tooltipshorttext| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:2|string|Contact - contactlongtext: tooltiplongtext| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:3|int|Contact - contactnumber| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:4|date|Contact - contactdate| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:5|unlimitedDate|Contact - contactunlimiteddate: tooltipunlimiteddate| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:6|bool|Contact - contactcheckbox| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:7|listAny|Contact - contactdropdownlistbox| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:8|decimal|Contact - contactdecimal| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:9|string|Contact - page1saleonly| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:10|string|Contact - page1marketingonly| x |
|shipment/mailingAddr/person/personUdef/SuperOffice:11|string|Contact - page1adminonly| x |
|shipment/mailingAddr/person/personExtra/x\_person\_integer|int|Contact - Extra Integer: Custom person integer| x |
|shipment/mailingAddr/person/personExtra/x\_person\_hidden\_integer|int|Contact - Extra hidden integer: Custom integer field that is hidden| x |
|shipment/mailingAddr/person/personExtra/x\_person\_float|decimal|Contact - Extra float: Custom float field| x |
|shipment/mailingAddr/person/personExtra/x\_person\_longtext|string|Contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|shipment/mailingAddr/person/personExtra/x\_person\_date|date|Contact - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|shipment/mailingAddr/person/personExtra/x\_person\_datetime|datetime|Contact - Extra DateTime: Custom person date and time field. No default| x |
|shipment/mailingAddr/person/personExtra/x\_person\_time| *None* |Contact - Extra time: Custom time field on person. Current time as default| x |
|shipment/mailingAddr/person/personExtra/x\_person\_boolean|bool|Contact - Extra Boolean: Custom boolean field on person. Default checked| x |
|shipment/mailingAddr/person/personExtra/x\_person\_timespan|timeSpan|Contact - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|shipment/mailingAddr/person/personExtra/x\_person\_shorttext|string|Contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|shipment/mailingAddr/person/personExtra/x\_person\_shorttext\_list|listAny|Contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|shipment/mailingAddr/person/personExtra/x\_person\_user\_relation|associate|Contact - Extra user relation: Custom person-user relation field| x |
|shipment/mailingAddr/person/personExtra/x\_person\_category\_relation|listAny|Contact - Extra category relation: Custom person-category relation| x |
|shipment/mailingAddr/person/personExtra/x\_person\_priority\_relation|listAny|Contact - Extra priority relation: Custom person-priority relation| x |
|shipment/mailingAddr/person/personExtra/x\_person\_request\_relation|stringorPK|Contact - Extra request relation: Request relation on contact| x |
|shipment/mailingAddr/person/personExtra/x\_person\_appointment\_relation|stringorPK|Contact - Extra appointment relation: Appointment relation on person| x |
|shipment/mailingAddr/person/personExtra/x\_person\_contact\_relation|stringorPK|Contact - Extra company relation: Company relation on contact| x |
|shipment/mailingAddr/person/personExtra/y\_rental/id|int|Contact - Rental - id: Displays the row's primary key (y\_rental)| x |
|shipment/mailingAddr/person/personExtra/y\_rental/x\_start|date|Contact - Rental - Start rental| x |
|shipment/mailingAddr/person/personExtra/y\_rental/x\_end|date|Contact - Rental - End| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/mailingAddr/person/personExtra/y\_rental/x\_amount|int|Contact - Rental - Amount: Number to rent. Default = 1| x |
|shipment/mailingAddr/person/personExtra/y\_rental/x\_contact|stringorPK|Contact - Rental - Renter: Company that rents equipment| x |
|shipment/mailingAddr/person/personExtra/y\_rental/y\_equipment/x\_name|string|Contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|shipment/mailingAddr/person/personAssociate/firstName|string|Contact - First name: Displays the contact's first name| x |
|shipment/mailingAddr/person/personAssociate/lastName|string|Contact - Last name: Displays the contact's last name| x |
|shipment/mailingAddr/person/personAssociate/middleName|string|Contact - Middle Name: Displays the contact's middle name.| x |
|shipment/mailingAddr/person/personAssociate/fullName|string|Contact - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|shipment/mailingAddr/person/personAssociate/contactId|int|Contact - Company ID: Database ID of the company the user belongs to|  |
|shipment/mailingAddr/person/personAssociate/personId|int|Contact - Contact ID: Database ID of the contact row|  |
|shipment/mailingAddr/person/personAssociate/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/mailingAddr/person/personAssociate/title|string|Contact - Title: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/mailingAddr/person/personAssociate/associateDbId|associate|Contact - ID| x |
|shipment/mailingAddr/person/personAssociate/contactName|string|Contact - Owning company: Name of the company the user belongs to| x |
|shipment/mailingAddr/person/personAssociate/contactDepartment|string|Contact - Owning department: Name of the department at the company the user belongs to| x |
|shipment/mailingAddr/person/personAssociate/usergroup|userGroup|Contact - Primary group: The user's primary user group| x |
|shipment/mailingAddr/person/personAssociate/contactFullName|string|Contact - Owner: Name and department of the company the user belongs to| x |
|shipment/mailingAddr/person/personAssociate/contactCategory|listAny|Contact - Category: Category| x |
|shipment/mailingAddr/person/personAssociate/role|listAny|Contact - Role: Role| x |
|shipment/mailingAddr/person/personAssociate/assocName|associate|Contact - User ID: User ID| x |
|shipment/mailingAddr/person/personAssociate/assocTooltip|string|Contact - Description: Description|  |
|shipment/mailingAddr/person/personAssociate/assocType|listAny|Contact - Type: Type of user: associate, external user, system user, anonymous account| x |
|shipment/mailingAddr/person/personAssociate/ejUserId|int|Contact - Service user ID: The database ID of a Service user|  |
|shipment/mailingAddr/person/personAssociate/simultaneousEjUser|bool|Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/mailingAddr/person/personAssociate/ejDisplayName|string|Contact - Nick name: User's nick name in Service| x |
|shipment/mailingAddr/person/personAssociate/ejStatus|int|Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/mailingAddr/person/personAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in| x |
|shipment/mailingAddr/person/personAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|shipment/mailingAddr/person/personAssociate/isActive|bool|Contact - Active: Is this user active, and should be able to log in?| x |
|shipment/mailingAddr/person/personAssociate/isActiveText|bool|Contact - Active status: Is this user active, and should be able to log in?| x |
|shipment/mailingAddr/person/personAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|shipment/mailingAddr/person/personAssociate/otherGroups|userGroup|Contact - Other groups: Other groups|  |
|shipment/mailingAddr/person/personAssociate/userName|string|Contact - User name: User name| x |
|shipment/mailingAddr/person/personAssociate/personEmail|string|Contact - E-mail| x |
|shipment/mailingAddr/person/correspondingAssociate/firstName|string|Contact - First name: Displays the contact's first name| x |
|shipment/mailingAddr/person/correspondingAssociate/lastName|string|Contact - Last name: Displays the contact's last name| x |
|shipment/mailingAddr/person/correspondingAssociate/middleName|string|Contact - Middle Name: Displays the contact's middle name.| x |
|shipment/mailingAddr/person/correspondingAssociate/fullName|string|Contact - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|shipment/mailingAddr/person/correspondingAssociate/contactId|int|Contact - Company ID: Database ID of the company the user belongs to|  |
|shipment/mailingAddr/person/correspondingAssociate/personId|int|Contact - Contact ID: Database ID of the contact row|  |
|shipment/mailingAddr/person/correspondingAssociate/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/mailingAddr/person/correspondingAssociate/title|string|Contact - Title: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/mailingAddr/person/correspondingAssociate/associateDbId|associate|Contact - ID| x |
|shipment/mailingAddr/person/correspondingAssociate/contactName|string|Contact - Owning company: Name of the company the user belongs to| x |
|shipment/mailingAddr/person/correspondingAssociate/contactDepartment|string|Contact - Owning department: Name of the department at the company the user belongs to| x |
|shipment/mailingAddr/person/correspondingAssociate/usergroup|userGroup|Contact - Primary group: The user's primary user group| x |
|shipment/mailingAddr/person/correspondingAssociate/contactFullName|string|Contact - Owner: Name and department of the company the user belongs to| x |
|shipment/mailingAddr/person/correspondingAssociate/contactCategory|listAny|Contact - Category: Category| x |
|shipment/mailingAddr/person/correspondingAssociate/role|listAny|Contact - Role: Role| x |
|shipment/mailingAddr/person/correspondingAssociate/assocName|associate|Contact - User ID: User ID| x |
|shipment/mailingAddr/person/correspondingAssociate/assocTooltip|string|Contact - Description: Description|  |
|shipment/mailingAddr/person/correspondingAssociate/assocType|listAny|Contact - Type: Type of user: associate, external user, system user, anonymous account| x |
|shipment/mailingAddr/person/correspondingAssociate/ejUserId|int|Contact - Service user ID: The database ID of a Service user|  |
|shipment/mailingAddr/person/correspondingAssociate/simultaneousEjUser|bool|Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/mailingAddr/person/correspondingAssociate/ejDisplayName|string|Contact - Nick name: User's nick name in Service| x |
|shipment/mailingAddr/person/correspondingAssociate/ejStatus|int|Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/mailingAddr/person/correspondingAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in| x |
|shipment/mailingAddr/person/correspondingAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|shipment/mailingAddr/person/correspondingAssociate/isActive|bool|Contact - Active: Is this user active, and should be able to log in?| x |
|shipment/mailingAddr/person/correspondingAssociate/isActiveText|bool|Contact - Active status: Is this user active, and should be able to log in?| x |
|shipment/mailingAddr/person/correspondingAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|shipment/mailingAddr/person/correspondingAssociate/otherGroups|userGroup|Contact - Other groups: Other groups|  |
|shipment/mailingAddr/person/correspondingAssociate/userName|string|Contact - User name: User name| x |
|shipment/mailingAddr/person/correspondingAssociate/personEmail|string|Contact - E-mail| x |
|shipment/mailingAddr/person/isMailingRecipient|bool|Contact - Is mailing recipient: isMailingRecipient| x |
|shipment/mailingAddr/person/hasStoreConsent|bool|Contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|shipment/mailingAddr/person/withdrawnStoreConsent|bool|Contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|shipment/mailingAddr/person/hasEmarketingConsent|bool|Contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|shipment/mailingAddr/person/withdrawnEmarketingConsent|bool|Contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|shipment/mailingAddr/person/subscription|listAny|Contact - Subscription: Subscription for marketing| x |
|shipment/mailingAddr/person/legalBaseStore|listAny|Contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|shipment/mailingAddr/person/legalBaseEmarketing|listAny|Contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|shipment/mailingAddr/person/consentSourceStore|listAny|Contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|shipment/mailingAddr/person/consentSourceEmarketing|listAny|Contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|shipment/associate/firstName|string|First name: Displays the contact's first name| x |
|shipment/associate/lastName|string|Last name: Displays the contact's last name| x |
|shipment/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|shipment/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|shipment/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|shipment/associate/personId|int|Contact ID: Database ID of the contact row|  |
|shipment/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/associate/associateDbId|associate|ID| x |
|shipment/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|shipment/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|shipment/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|shipment/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|shipment/associate/contactCategory|listAny|Category: Category| x |
|shipment/associate/role|listAny|Role : Role| x |
|shipment/associate/assocName|associate|User ID : User ID| x |
|shipment/associate/assocTooltip|string|Description : Description|  |
|shipment/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|shipment/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|shipment/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|shipment/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|shipment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|shipment/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|shipment/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|shipment/associate/portraitThumbnail| *None* |Person image: Person image|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/associate/otherGroups|userGroup|Other groups: Other groups|  |
|shipment/associate/userName|string|User name: User name| x |
|shipment/associate/personEmail|string|E-mail| x |
|shipment/project/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|shipment/project/projectId|int|DB ID: Displays the database ID for a project row| x |
|shipment/project/name|stringorPK|Project name: Displays the Project's name| x |
|shipment/project/number|string|Number: Displays the project's number| x |
|shipment/project/type|listAny|Project type: Displays the project's type| x |
|shipment/project/status|listAny|Status: Displays the project's status| x |
|shipment/project/statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|shipment/project/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|shipment/project/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|shipment/project/icon| *None* |Category: Displays the icon for an activity type| x |
|shipment/project/text|string|Text: Displays a descriptive text for the item| x |
|shipment/project/description|string|Description : Description| x |
|shipment/project/updatedBy|associate|Updated by: The user who last updated the data| x |
|shipment/project/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|shipment/project/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|shipment/project/registeredBy|associate|Registered by: The user who registered the data| x |
|shipment/project/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|shipment/project/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|shipment/project/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|shipment/project/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|shipment/project/endDate|date|End date: End date of project| x |
|shipment/project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|shipment/project/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|shipment/project/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|shipment/project/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|shipment/project/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|shipment/project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|shipment/project/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|shipment/project/projectEvent/eventDate|date|Event date: Event date| x |
|shipment/project/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|shipment/project/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|shipment/project/projectUrl/URLAddress|string|URL| x |
|shipment/project/projectUrl/URLDescription|string|Description| x |
|shipment/project/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|shipment/project/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|shipment/project/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|shipment/project/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|shipment/project/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|shipment/project/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|shipment/project/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/project/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/project/projectAssociate/associateDbId|associate|ID| x |
|shipment/project/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|shipment/project/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|shipment/project/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|shipment/project/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|shipment/project/projectAssociate/contactCategory|listAny|Category: Category| x |
|shipment/project/projectAssociate/role|listAny|Role : Role| x |
|shipment/project/projectAssociate/assocName|associate|User ID : User ID| x |
|shipment/project/projectAssociate/assocTooltip|string|Description : Description|  |
|shipment/project/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|shipment/project/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|shipment/project/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/project/projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|shipment/project/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|shipment/project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|shipment/project/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|shipment/project/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|shipment/project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|shipment/project/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|shipment/project/projectAssociate/userName|string|User name: User name| x |
|shipment/project/projectAssociate/personEmail|string|E-mail| x |
|shipment/project/projectUdef/SuperOffice:1|string|projectshorttext| x |
|shipment/project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|shipment/project/projectUdef/SuperOffice:3|int|projectnumber| x |
|shipment/project/projectUdef/SuperOffice:4|date|projectdate| x |
|shipment/project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|shipment/project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|shipment/project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|shipment/project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|shipment/project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|shipment/project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|shipment/project/NumberOfActivities|int|Number of activities|  |
|shipment/project/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|shipment/project/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|shipment/project/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|shipment/project/LastActivity|date|Date of last activity|  |
|shipment/project/LastCompletedActivity|date|Date of last completed activity|  |
|shipment/project/LastDoByActivity|date|Date of last non-completed activity|  |
|shipment/project/NumberOfSales|int|Number of sales|  |
|shipment/project/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|shipment/project/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|shipment/project/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|shipment/project/LastSale|date|Date of last sale|  |
|shipment/project/LastCompletedSale|date|Date of last completed sale|  |
|shipment/project/LastDoBySale|date|Date of last non-completed sale|  |
|shipment/project/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|shipment/project/saintSaleStatus|listAny|With status|  |
|shipment/project/saintAmountClass|listAny|Amount class|  |
|shipment/project/saintActivityType|listAny|SAINT type|  |
|shipment/project/saintDirection|listAny|Direction|  |
|shipment/project/saintIntention|listAny|Intention|  |
|shipment/project/saintTicketStatus|listAny|Status|  |
|shipment/project/saintTicketCategory|listAny|Category|  |
|shipment/project/project/textId|int|Text ID| x |
|shipment/project/project/infoText|positiveString|Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/EmailFlowContent?$select=shipment/mailingSentTo,shipment/mailingAddr/contact/contactAssociate/userName,shipment/mailingAddr/person/personDirectPhone/description,shipment/project/projectAssociate/userName,shipment/project/projectUdef/SuperOffice:1
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

