---
uid: MailingsAndFolders
title: MailingsAndFolders
description: Combined archive of mailings (s_shipment) and mailing folders
keywords: MailingsAndFolders archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "MailingsAndFolders"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MailingsAndFoldersProvider">SuperOffice.CRM.ArchiveLists.MailingsAndFoldersProvider</see> inside NetServer's SODatabase assembly.

Combined archive of mailings (s_shipment) and mailing folders
(s_picture_folder, folder_type = shipmentFolder) — analogous to
<see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowsAndFoldersProvider" />.

Unified row schema (after the column-name overrides set up below):
- PrimaryKey      — row's own id
- mailingFolderId — row's container folder id (for filtering)
- name            — display label (mailing description on mailings,
folder name on folders), via overrides
- thumbnail       — preview image / folder icon hint (native on both)

Client filter `mailingFolderId = N` returns mailings whose
s_shipment.FolderId = N AND folders whose s_picture_folder.ParentId = N
— i.e. everything contained in folder N.

The name overrides are applied here (not by renaming the underlying
extender columns) so MailingsExtenderBase keeps its native
`mailingDescription` column for every OTHER archive that uses it
(Contact / Person / Project / Sale cards). Same approach as
EmailFlowsAndFoldersProvider (workflowName / hierarchyName both → name).

## Supported Entities
| Name | Description |
| ---- | ----- |
|"mailingfolder"|mailingfolder|
|"all"|All|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|folderId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|mailingFolderId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|name|string|Hierarchy name: The full name/path from table hierarchy| x |
|thumbnail| *None* |Thumbnail|  |
|mailingId| *None* |ID: Displays the ID of the mailing|  |
|mailingSelectionId| *None* |Selection ID: The database ID of the selection|  |
|mailingSent| *None* |Sent: Displays the sent status of the mailing|  |
|mailingSimpleStatus| *None* |Status: Status|  |
|mailingEndDate| *None* |Date sent: Displays the date when the mailing was sent (completed)|  |
|mailingType| *None* |Type: Display the type of the mailing|  |
|mailingTypeId| *None* |Type: Display the type of the mailing|  |
|mailingStatusId| *None* |Status: Status|  |
|mailingSubscriptionType| *None* |Subscription type: The subscription type for a mailing|  |
|mailingSentTo| *None* |Sent to: Displays to whom the mailing was sent|  |
|mailingOwner| *None* |Owner: Displays the owner of the mailing|  |
|mailingFrom| *None* |From: Mailing from|  |
|mailingReplyTo| *None* |To: To|  |
|mailingSentCount| *None* |Number sent: Number of sent mailings|  |
|mailingOpenRate| *None* |Open rate: The open rate for a mailing|  |
|mailingClickRate| *None* |Click-through rate: Mailing click-through rate|  |
|mailingBounceRate| *None* |Bounce rate: Mailing bounce rate|  |
|mailingDeleted| *None* |Deleted: Deleted|  |
|recipientStatus| *None* |Recipient status: Status of mailing recipient|  |
|icon| *None* |Category: Displays the icon for an activity type|  |
|date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|type| *None* |Type: Displays the type of an activity|  |
|text| *None* |Text: Displays a descriptive text for the item|  |
|associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|contactId| *None* |Company ID: Database ID of company|  |
|personId| *None* |Contact ID: Database ID of the contact row|  |
|projectId| *None* |Project ID: Database ID of project record|  |
|updatedBy| *None* |Updated by: The user who last updated the data|  |
|updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|registeredBy| *None* |Registered by: The user who registered the data|  |
|registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
|mailingAddr/mailingAddrId| *None* |!!!Mailing addr Id: !!!Mailing addr Id Tooltip|  |
|mailingAddr/contact/contactId| *None* |Company - Company ID: Database ID of company|  |
|mailingAddr/contact/name| *None* |Company - Company name|  |
|mailingAddr/contact/department| *None* |Company - Department|  |
|mailingAddr/contact/nameDepartment| *None* |Company - Company: Displays the company an activity is linked to|  |
|mailingAddr/contact/hasInfoText| *None* |Company - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|mailingAddr/contact/hasInterests| *None* |Company - Has interests: Displays an Icon indicating if the contact has active interests|  |
|mailingAddr/contact/associateId| *None* |Company - Our contact: Displays our contact|  |
|mailingAddr/contact/category| *None* |Company - Category|  |
|mailingAddr/contact/categoryGroup| *None* |Company - Category group|  |
|mailingAddr/contact/companyCategoryRank| *None* |Company - Category rank|  |
|mailingAddr/contact/business| *None* |Company - Business|  |
|mailingAddr/contact/country| *None* |Company - Country: This criterion corresponds to the Country field on the Company card.|  |
|mailingAddr/contact/countryId| *None* |Company - Country ID: Country ID|  |
|mailingAddr/contact/number| *None* |Company - Number|  |
|mailingAddr/contact/code| *None* |Company - Code|  |
|mailingAddr/contact/orgnr| *None* |Company - VAT No.|  |
|mailingAddr/contact/stop| *None* |Company - Stop|  |
|mailingAddr/contact/contactNoMail| *None* |Company - No mailings (company)|  |
|mailingAddr/contact/updatedBy| *None* |Company - Updated by: The user who last updated the data|  |
|mailingAddr/contact/updatedByFullName| *None* |Company - Updated by - Full name: The user who last updated the data|  |
|mailingAddr/contact/updatedDate| *None* |Company - Updated: The date/time the data was last updated in UTC.|  |
|mailingAddr/contact/registeredBy| *None* |Company - Registered by: The user who registered the data|  |
|mailingAddr/contact/registeredByFullName| *None* |Company - Registered by - Full name: The user who registered the data|  |
|mailingAddr/contact/registeredDate| *None* |Company - Registered date: The date/time the data was registered in UTC.|  |
|mailingAddr/contact/contactSource| *None* |Company - Source: Source (Company)|  |
|mailingAddr/contact/contactDeleted| *None* |Company - Deleted: Deleted|  |
|mailingAddr/contact/phone/formattedNumber| *None* |Company - Phone: Displays phone number|  |
|mailingAddr/contact/activeErpLinks| *None* |Company - ERP connected: Is there an active ERP Sync?|  |
|mailingAddr/contact/deletedDate| *None* |Company - Deleted date: Deleted date|  |
|mailingAddr/contact/mainContact| *None* |Company - Main contact: Main contact for this company|  |
|mailingAddr/contact/forceCompany| *None* |Company - Dummy: Dummy|  |
|mailingAddr/contact/contactPhone/formattedNumber| *None* |Company - Telephone - Phone: Displays phone number|  |
|mailingAddr/contact/contactPhone/description| *None* |Company - Telephone - Description: Phone number description|  |
|mailingAddr/contact/contactFax/formattedNumber| *None* |Company - Fax - Phone: Displays phone number|  |
|mailingAddr/contact/contactFax/description| *None* |Company - Fax - Description: Phone number description|  |
|mailingAddr/contact/searchPhone/formattedNumber| *None* |Company - Searchphone - Phone: Displays phone number|  |
|mailingAddr/contact/searchPhone/description| *None* |Company - Searchphone - Description: Phone number description|  |
|mailingAddr/contact/email/emailProtocol| *None* |Company - Protocol: E-mail protocol, such as SMTP|  |
|mailingAddr/contact/email/emailAddress| *None* |Company - E-mail|  |
|mailingAddr/contact/email/emailDescription| *None* |Company - Description|  |
|mailingAddr/contact/email/emailId| *None* |Company - ID|  |
|mailingAddr/contact/email/emailLastSent| *None* |Company - Last sent: The date and time an e-mail was last sent to this address|  |
|mailingAddr/contact/email/emailBounceCount| *None* |Company - Bounce count: Bounce count for this e-mail address|  |
|mailingAddr/contact/email/emailLastBounce| *None* |Company - Last bounce: Date and time for last bounce to this e-mail address|  |
|mailingAddr/contact/email/emailHasBounced| *None* |Company - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|mailingAddr/contact/postAddress/addressId| *None* |Company - Postal address - Address ID: Database ID for the address record|  |
|mailingAddr/contact/postAddress/line1| *None* |Company - Postal address - Address 1: First line of the address|  |
|mailingAddr/contact/postAddress/line2| *None* |Company - Postal address - Address 2: Second line of the address|  |
|mailingAddr/contact/postAddress/line3| *None* |Company - Postal address - Address 3: Third line of the address|  |
|mailingAddr/contact/postAddress/county| *None* |Company - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|mailingAddr/contact/postAddress/city| *None* |Company - Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|mailingAddr/contact/postAddress/zip| *None* |Company - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|mailingAddr/contact/postAddress/state| *None* |Company - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|mailingAddr/contact/postAddress/wgs84latitude| *None* |Company - Postal address - Latitude: Latitude|  |
|mailingAddr/contact/postAddress/wgs84longitude| *None* |Company - Postal address - Longitude: Longitude|  |
|mailingAddr/contact/postAddress/formattedAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/postAddress/formattedMultiLineAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/streetAddress/addressId| *None* |Company - Street address - Address ID: Database ID for the address record|  |
|mailingAddr/contact/streetAddress/line1| *None* |Company - Street address - Address 1: First line of the address|  |
|mailingAddr/contact/streetAddress/line2| *None* |Company - Street address - Address 2: Second line of the address|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/contact/streetAddress/line3| *None* |Company - Street address - Address 3: Third line of the address|  |
|mailingAddr/contact/streetAddress/county| *None* |Company - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|mailingAddr/contact/streetAddress/city| *None* |Company - Street address - City: This criterion corresponds to the City field on the Company card.|  |
|mailingAddr/contact/streetAddress/zip| *None* |Company - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|mailingAddr/contact/streetAddress/state| *None* |Company - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|mailingAddr/contact/streetAddress/wgs84latitude| *None* |Company - Street address - Latitude: Latitude|  |
|mailingAddr/contact/streetAddress/wgs84longitude| *None* |Company - Street address - Longitude: Longitude|  |
|mailingAddr/contact/streetAddress/formattedAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/streetAddress/formattedMultiLineAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/restrictionAddress/addressId| *None* |Company - Search address - Address ID: Database ID for the address record|  |
|mailingAddr/contact/restrictionAddress/line1| *None* |Company - Search address - Address 1: First line of the address|  |
|mailingAddr/contact/restrictionAddress/line2| *None* |Company - Search address - Address 2: Second line of the address|  |
|mailingAddr/contact/restrictionAddress/line3| *None* |Company - Search address - Address 3: Third line of the address|  |
|mailingAddr/contact/restrictionAddress/county| *None* |Company - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|mailingAddr/contact/restrictionAddress/city| *None* |Company - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|mailingAddr/contact/restrictionAddress/zip| *None* |Company - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|mailingAddr/contact/restrictionAddress/state| *None* |Company - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|mailingAddr/contact/restrictionAddress/wgs84latitude| *None* |Company - Search address - Latitude: Latitude|  |
|mailingAddr/contact/restrictionAddress/wgs84longitude| *None* |Company - Search address - Longitude: Longitude|  |
|mailingAddr/contact/restrictionAddress/formattedAddress| *None* |Company - Search address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/restrictionAddress/formattedMultiLineAddress| *None* |Company - Search address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/url/URLAddress| *None* |Company - URL|  |
|mailingAddr/contact/url/URLDescription| *None* |Company - Description|  |
|mailingAddr/contact/contactAssociate/firstName| *None* |Company - First name: Displays the contact's first name|  |
|mailingAddr/contact/contactAssociate/lastName| *None* |Company - Last name: Displays the contact's last name|  |
|mailingAddr/contact/contactAssociate/middleName| *None* |Company - Middle Name: Displays the contact's middle name.|  |
|mailingAddr/contact/contactAssociate/fullName| *None* |Company - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|mailingAddr/contact/contactAssociate/contactId| *None* |Company - Company ID: Database ID of the company the user belongs to|  |
|mailingAddr/contact/contactAssociate/personId| *None* |Company - Contact ID: Database ID of the contact row|  |
|mailingAddr/contact/contactAssociate/mrMrs| *None* |Company - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|mailingAddr/contact/contactAssociate/title| *None* |Company - Title: Displays whether the contact is addressed as Mr or Ms|  |
|mailingAddr/contact/contactAssociate/associateDbId| *None* |Company - ID|  |
|mailingAddr/contact/contactAssociate/contactName| *None* |Company - Owning company: Name of the company the user belongs to|  |
|mailingAddr/contact/contactAssociate/contactDepartment| *None* |Company - Owning department: Name of the department at the company the user belongs to|  |
|mailingAddr/contact/contactAssociate/usergroup| *None* |Company - Primary group: The user's primary user group|  |
|mailingAddr/contact/contactAssociate/usergroupId| *None* |Company - Group ID: The user's primary user group|  |
|mailingAddr/contact/contactAssociate/contactFullName| *None* |Company - Owner: Name and department of the company the user belongs to|  |
|mailingAddr/contact/contactAssociate/contactCategory| *None* |Company - Category: Category|  |
|mailingAddr/contact/contactAssociate/role| *None* |Company - Role: Role|  |
|mailingAddr/contact/contactAssociate/assocName| *None* |Company - User ID: User ID|  |
|mailingAddr/contact/contactAssociate/assocTooltip| *None* |Company - Description: Description|  |
|mailingAddr/contact/contactAssociate/assocType| *None* |Company - Type: Type of user: associate, external user, system user, anonymous account|  |
|mailingAddr/contact/contactAssociate/ejUserId| *None* |Company - Service user ID: The database ID of a Service user|  |
|mailingAddr/contact/contactAssociate/simultaneousEjUser| *None* |Company - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/contact/contactAssociate/ejDisplayName| *None* |Company - Nickname: User's nickname in Service|  |
|mailingAddr/contact/contactAssociate/ejStatus| *None* |Company - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/contact/contactAssociate/credentialType| *None* |Company - Auth. type: What type of credentials to use when this user logs in|  |
|mailingAddr/contact/contactAssociate/credentialDisplayValue| *None* |Company - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|mailingAddr/contact/contactAssociate/isActive| *None* |Company - Active: Is this user active, and should be able to log in?|  |
|mailingAddr/contact/contactAssociate/isActiveText| *None* |Company - Active status: Is this user active, and should be able to log in?|  |
|mailingAddr/contact/contactAssociate/portraitThumbnail| *None* |Company - Person image: Person image|  |
|mailingAddr/contact/contactAssociate/otherGroups| *None* |Company - Other groups: Other groups|  |
|mailingAddr/contact/contactAssociate/userName| *None* |Company - User name: User name|  |
|mailingAddr/contact/contactAssociate/personEmail| *None* |Company - E-mail|  |
|mailingAddr/contact/contactAssociate/locationAddress| *None* |Company - Location: Location|  |
|mailingAddr/contact/contactAssociate/isLocation| *None* |Company - Is a location: Is a location|  |
|mailingAddr/contact/contactInterestIds| *None* |Company - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|mailingAddr/contact/contactUdef/SuperOffice:1| *None* |Company - companyshorttext: tooltipshorttext|  |
|mailingAddr/contact/contactUdef/SuperOffice:2| *None* |Company - companylongtext: tooltiplongtext|  |
|mailingAddr/contact/contactUdef/SuperOffice:3| *None* |Company - companynumber|  |
|mailingAddr/contact/contactUdef/SuperOffice:4| *None* |Company - companydate|  |
|mailingAddr/contact/contactUdef/SuperOffice:5| *None* |Company - companyunlimiteddate: tooltipunlimiteddate|  |
|mailingAddr/contact/contactUdef/SuperOffice:6| *None* |Company - companycheckbox|  |
|mailingAddr/contact/contactUdef/SuperOffice:7| *None* |Company - companydropdownlistbox|  |
|mailingAddr/contact/contactUdef/SuperOffice:8| *None* |Company - companydecimal|  |
|mailingAddr/contact/contactUdef/SuperOffice:9| *None* |Company - page1saleonly|  |
|mailingAddr/contact/contactUdef/SuperOffice:10| *None* |Company - page1marketingonly|  |
|mailingAddr/contact/contactUdef/SuperOffice:11| *None* |Company - page1adminonly|  |
|mailingAddr/contact/contactUdef/SuperOffice:12| *None* |Company - Udlist one: Static tooltip for udlist one|  |
|mailingAddr/contact/contactUdef/SuperOffice:13| *None* |Company - Udlist two: Static tooltip for udlist two|  |
|mailingAddr/contact/contactExtra/x\_contact\_integer| *None* |Company - Extra Integer: Custom integer field|  |
|mailingAddr/contact/contactExtra/x\_contact\_hidden\_integer| *None* |Company - Extra hidden integer: Custom integer field - hidden|  |
|mailingAddr/contact/contactExtra/x\_contact\_default\_integer| *None* |Company - Extra Default Integer: Custom integer field with default value 123.|  |
|mailingAddr/contact/contactExtra/x\_contact\_float| *None* |Company - Extra Float: Custom float field with 3 decimals|  |
|mailingAddr/contact/contactExtra/x\_contact\_longtext| *None* |Company - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|mailingAddr/contact/contactExtra/x\_contact\_dropdown| *None* |Company - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|mailingAddr/contact/contactExtra/x\_contact\_date| *None* |Company - Extra date: Custom date field. User current as default.|  |
|mailingAddr/contact/contactExtra/x\_contact\_datetime| *None* |Company - Extra DateTime: Custom Date Time field. No default value. External|  |
|mailingAddr/contact/contactExtra/x\_contact\_time| *None* |Company - Extra time: Custom time field.|  |
|mailingAddr/contact/contactExtra/x\_contact\_boolean| *None* |Company - Extra boolean: Custom boolean field.|  |
|mailingAddr/contact/contactExtra/x\_contact\_timespan| *None* |Company - Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|mailingAddr/contact/contactExtra/x\_contact\_shorttext| *None* |Company - Extra short text: Custom short text field. Keep HTML tags.|  |
|mailingAddr/contact/contactExtra/x\_contact\_short\_dropdown| *None* |Company - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|mailingAddr/contact/contactExtra/x\_contact\_contact\_relation| *None* |Company - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|mailingAddr/contact/contactExtra/x\_contact\_request\_relation| *None* |Company - Extra Request relation: Request relation on company|  |
|mailingAddr/contact/contactExtra/x\_contact\_contact| *None* |Company - Extra contact relation: Contact relation on company|  |
|mailingAddr/contact/contactExtra/y\_organization/x\_name| *None* |Company - Organization - Name: Name|  |
|mailingAddr/contact/NumberOfActivities| *None* |Company - Number of activities|  |
|mailingAddr/contact/NumberOfActivitiesInPeriod| *None* |Company - Number of activities in last 90 days|  |
|mailingAddr/contact/NumberOfNotCompletedActivities| *None* |Company - Number of non-completed activities|  |
|mailingAddr/contact/NumberOfNotCompletedActivitiesInPeriod| *None* |Company - Number of non-completed activities in last 90 days|  |
|mailingAddr/contact/LastActivity| *None* |Company - Date of last activity|  |
|mailingAddr/contact/LastCompletedActivity| *None* |Company - Date of last completed activity|  |
|mailingAddr/contact/LastDoByActivity| *None* |Company - Date of last non-completed activity|  |
|mailingAddr/contact/NumberOfSales| *None* |Company - Number of sales|  |
|mailingAddr/contact/NumberOfSalesInPeriod| *None* |Company - Number of sales in last 90 days|  |
|mailingAddr/contact/NumberOfNotCompletedSales| *None* |Company - Number of non-completed sales|  |
|mailingAddr/contact/NumberOfNotCompletedSalesInPeriod| *None* |Company - Number of non-completed sales in last 90 days|  |
|mailingAddr/contact/LastSale| *None* |Company - Date of last sale|  |
|mailingAddr/contact/LastCompletedSale| *None* |Company - Date of last completed sale|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/contact/LastDoBySale| *None* |Company - Date of last non-completed sale|  |
|mailingAddr/contact/NumberOfTickets| *None* |Company - Number of requests|  |
|mailingAddr/contact/NumberOfTicketsInPeriod| *None* |Company - Number of requests in last 90 days|  |
|mailingAddr/contact/NumberOfNotCompletedTickets| *None* |Company - Number of non-completed requests|  |
|mailingAddr/contact/NumberOfNotCompletedTicketsInPeriod| *None* |Company - Number of non-completed requests in last 90 days|  |
|mailingAddr/contact/LastTicket| *None* |Company - Date of last request|  |
|mailingAddr/contact/LastCompletedTicket| *None* |Company - Date of last completed request|  |
|mailingAddr/contact/LastDoByTicket| *None* |Company - Date of last non-completed request|  |
|mailingAddr/contact/SaintStatus1| *None* |Company - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|mailingAddr/contact/SaintStatus2| *None* |Company - C-company: Kundens navn starter med bokstaven C|  |
|mailingAddr/contact/saintSaleStatus| *None* |Company - With status|  |
|mailingAddr/contact/saintAmountClass| *None* |Company - Amount class|  |
|mailingAddr/contact/saintActivityType| *None* |Company - SAINT type|  |
|mailingAddr/contact/saintDirection| *None* |Company - Direction|  |
|mailingAddr/contact/saintIntention| *None* |Company - Intention|  |
|mailingAddr/contact/saintTicketStatus| *None* |Company - Status|  |
|mailingAddr/contact/saintTicketCategory| *None* |Company - Category|  |
|mailingAddr/person/personId| *None* |Contact - DB ID: Displays the database ID of a contact|  |
|mailingAddr/person/firstName| *None* |Contact - First name: Displays the contact's first name|  |
|mailingAddr/person/lastName| *None* |Contact - Last name: Displays the contact's last name|  |
|mailingAddr/person/middleName| *None* |Contact - Middle name: Displays the contact's middle name.|  |
|mailingAddr/person/fullName| *None* |Contact - Contact: Displays the contact to which an item is linked|  |
|mailingAddr/person/contactId| *None* |Contact - Company ID: Database ID of company|  |
|mailingAddr/person/hasInfoText| *None* |Contact - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|mailingAddr/person/hasInterests| *None* |Contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|mailingAddr/person/personHasInterests| *None* |Contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|mailingAddr/person/mrMrs| *None* |Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|mailingAddr/person/position| *None* |Contact - Position|  |
|mailingAddr/person/personNumber| *None* |Contact - Number: Displays the contact's number|  |
|mailingAddr/person/title| *None* |Contact - Title: Displays the contact's job title|  |
|mailingAddr/person/personCountry| *None* |Contact - Country: Country|  |
|mailingAddr/person/personCountryId| *None* |Contact - Country ID: Country ID|  |
|mailingAddr/person/personNoMail| *None* |Contact - No Mailings: Displays the contact's No Mailings checkbox|  |
|mailingAddr/person/rank| *None* |Contact - Rank: Displays a contact's current rank|  |
|mailingAddr/person/birthdate| *None* |Contact - Birthdate: Displays the contact's date of birth|  |
|mailingAddr/person/associateType| *None* |Contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|mailingAddr/person/useAsMailingAddress| *None* |Contact - Use as postal address: Use as postal address|  |
|mailingAddr/person/personSource| *None* |Contact - Source: Source (Contact)|  |
|mailingAddr/person/retired| *None* |Contact - Former employee: Indicates whether the contact has retired/left the company|  |
|mailingAddr/person/birthYear| *None* |Contact - Birth year: Displays contact's birth year|  |
|mailingAddr/person/birthMonth| *None* |Contact - Birth month: Displays contact's birth month|  |
|mailingAddr/person/birthDay| *None* |Contact - Birth day: Displays contact's birth day (day of month)|  |
|mailingAddr/person/kanaFirstName| *None* |Contact - First name, kana: Contact's first name, in kana alphabet|  |
|mailingAddr/person/kanaLastName| *None* |Contact - Last name, kana: Contact's last name, in kana alphabet|  |
|mailingAddr/person/personUpdatedBy| *None* |Contact - Updated by: The user who last updated the data|  |
|mailingAddr/person/personUpdatedByFullName| *None* |Contact - Updated by - Full name: The user who last updated the data|  |
|mailingAddr/person/personUpdatedDate| *None* |Contact - Updated: The date/time the data was last updated in UTC.|  |
|mailingAddr/person/personRegisteredBy| *None* |Contact - Registered by: The user who registered the data|  |
|mailingAddr/person/personRegisteredByFullName| *None* |Contact - Registered by - Full name: The user who registered the data|  |
|mailingAddr/person/personRegisteredDate| *None* |Contact - Registered date: The date/time the data was registered in UTC.|  |
|mailingAddr/person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/personActiveErpLinks| *None* |Contact - ERP connected: Is there an active ERP Sync?|  |
|mailingAddr/person/ticketPriority| *None* |Contact - Service priority: Default service priority for this contact|  |
|mailingAddr/person/supportLanguage| *None* |Contact - Preferred language: Preferred language used for reply templates and more|  |
|mailingAddr/person/supportAssociate| *None* |Contact - Our service contact: Default service contact for this contact|  |
|mailingAddr/person/supportAssociateFullName| *None* |Contact - Our service contact - Full name: Default service contact for this contact|  |
|mailingAddr/person/personAssociateId| *None* |Contact - Our contact: Displays our contact|  |
|mailingAddr/person/personAssociateFullName| *None* |Contact - Our contact - Full name: Displays our contact|  |
|mailingAddr/person/personCategory| *None* |Contact - Category|  |
|mailingAddr/person/personCategoryGroup| *None* |Contact - Category group|  |
|mailingAddr/person/personCategoryRank| *None* |Contact - !!Category rank|  |
|mailingAddr/person/personBusiness| *None* |Contact - Business|  |
|mailingAddr/person/leadStatus| *None* |Contact - Lead status|  |
|mailingAddr/person/leadstatusRank| *None* |Contact - !!Lead status RANK|  |
|mailingAddr/person/personDeletedDate| *None* |Contact - Deleted date: Deleted date|  |
|mailingAddr/person/hasCompany| *None* |Contact - Has company: The contact is associated with a company|  |
|mailingAddr/person/isProjectMember| *None* |Contact - Is project member: This person is a project member|  |
|mailingAddr/person/isStakeholder| *None* |Contact - Is stakeholder: This person is a sale stakeholder|  |
|mailingAddr/person/updatedByWorkflow| *None* |Contact - Updated by flow: Updated by flow|  |
|mailingAddr/person/whenUpdatedByWorkflow| *None* |Contact - When updated by flow: When updated by flow|  |
|mailingAddr/person/createdByForm| *None* |Contact - Created by form: Created by form|  |
|mailingAddr/person/phone/formattedNumber| *None* |Contact - Phone: Displays phone number|  |
|mailingAddr/person/personDirectPhone/formattedNumber| *None* |Contact - Direct - Phone: Displays phone number|  |
|mailingAddr/person/personDirectPhone/description| *None* |Contact - Direct - Description: Phone number description|  |
|mailingAddr/person/personMobilePhone/formattedNumber| *None* |Contact - Mobile - Phone: Displays phone number|  |
|mailingAddr/person/personMobilePhone/description| *None* |Contact - Mobile - Description: Phone number description|  |
|mailingAddr/person/personPrivate/formattedNumber| *None* |Contact - Private - Phone: Displays phone number|  |
|mailingAddr/person/personPrivate/description| *None* |Contact - Private - Description: Phone number description|  |
|mailingAddr/person/personPager/formattedNumber| *None* |Contact - Other - Phone: Displays phone number|  |
|mailingAddr/person/personPager/description| *None* |Contact - Other - Description: Phone number description|  |
|mailingAddr/person/personDirectFax/formattedNumber| *None* |Contact - Fax - Phone: Displays phone number|  |
|mailingAddr/person/personDirectFax/description| *None* |Contact - Fax - Description: Phone number description|  |
|mailingAddr/person/searchPhone/formattedNumber| *None* |Contact - Phone: Displays phone number|  |
|mailingAddr/person/searchPhone/description| *None* |Contact - Description: Phone number description|  |
|mailingAddr/person/personInfo/textId| *None* |Contact - Text ID|  |
|mailingAddr/person/personInfo/infoText| *None* |Contact - Information: Displays the text entered in the description field|  |
|mailingAddr/person/email/emailProtocol| *None* |Contact - Protocol: E-mail protocol, such as SMTP|  |
|mailingAddr/person/email/emailAddress| *None* |Contact - E-mail|  |
|mailingAddr/person/email/emailDescription| *None* |Contact - Description|  |
|mailingAddr/person/email/emailId| *None* |Contact - ID|  |
|mailingAddr/person/email/emailLastSent| *None* |Contact - Last sent: The date and time an e-mail was last sent to this address|  |
|mailingAddr/person/email/emailBounceCount| *None* |Contact - Bounce count: Bounce count for this e-mail address|  |
|mailingAddr/person/email/emailLastBounce| *None* |Contact - Last bounce: Date and time for last bounce to this e-mail address|  |
|mailingAddr/person/email/emailHasBounced| *None* |Contact - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|mailingAddr/person/personUrl/URLAddress| *None* |Contact - URL|  |
|mailingAddr/person/personUrl/URLDescription| *None* |Contact - Description|  |
|mailingAddr/person/personAddress/addressId| *None* |Contact - Contact address - Address ID: Database ID for the address record|  |
|mailingAddr/person/personAddress/line1| *None* |Contact - Contact address - Address 1: First line of the address|  |
|mailingAddr/person/personAddress/line2| *None* |Contact - Contact address - Address 2: Second line of the address|  |
|mailingAddr/person/personAddress/line3| *None* |Contact - Contact address - Address 3: Third line of the address|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/person/personAddress/county| *None* |Contact - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|mailingAddr/person/personAddress/city| *None* |Contact - Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|mailingAddr/person/personAddress/zip| *None* |Contact - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|mailingAddr/person/personAddress/state| *None* |Contact - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|mailingAddr/person/personAddress/wgs84latitude| *None* |Contact - Contact address - Latitude: Latitude|  |
|mailingAddr/person/personAddress/wgs84longitude| *None* |Contact - Contact address - Longitude: Longitude|  |
|mailingAddr/person/personAddress/formattedAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/personAddress/formattedMultiLineAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/restrictionAddress/addressId| *None* |Contact - Search address - Address ID: Database ID for the address record|  |
|mailingAddr/person/restrictionAddress/line1| *None* |Contact - Search address - Address 1: First line of the address|  |
|mailingAddr/person/restrictionAddress/line2| *None* |Contact - Search address - Address 2: Second line of the address|  |
|mailingAddr/person/restrictionAddress/line3| *None* |Contact - Search address - Address 3: Third line of the address|  |
|mailingAddr/person/restrictionAddress/county| *None* |Contact - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|mailingAddr/person/restrictionAddress/city| *None* |Contact - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|mailingAddr/person/restrictionAddress/zip| *None* |Contact - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|mailingAddr/person/restrictionAddress/state| *None* |Contact - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|mailingAddr/person/restrictionAddress/wgs84latitude| *None* |Contact - Search address - Latitude: Latitude|  |
|mailingAddr/person/restrictionAddress/wgs84longitude| *None* |Contact - Search address - Longitude: Longitude|  |
|mailingAddr/person/restrictionAddress/formattedAddress| *None* |Contact - Search address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/restrictionAddress/formattedMultiLineAddress| *None* |Contact - Search address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/personInterestIds| *None* |Contact - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|mailingAddr/person/personUdef/SuperOffice:1| *None* |Contact - contactshorttext: tooltipshorttext|  |
|mailingAddr/person/personUdef/SuperOffice:2| *None* |Contact - contactlongtext: tooltiplongtext|  |
|mailingAddr/person/personUdef/SuperOffice:3| *None* |Contact - contactnumber|  |
|mailingAddr/person/personUdef/SuperOffice:4| *None* |Contact - contactdate|  |
|mailingAddr/person/personUdef/SuperOffice:5| *None* |Contact - contactunlimiteddate: tooltipunlimiteddate|  |
|mailingAddr/person/personUdef/SuperOffice:6| *None* |Contact - contactcheckbox|  |
|mailingAddr/person/personUdef/SuperOffice:7| *None* |Contact - contactdropdownlistbox|  |
|mailingAddr/person/personUdef/SuperOffice:8| *None* |Contact - contactdecimal|  |
|mailingAddr/person/personUdef/SuperOffice:9| *None* |Contact - page1saleonly|  |
|mailingAddr/person/personUdef/SuperOffice:10| *None* |Contact - page1marketingonly|  |
|mailingAddr/person/personUdef/SuperOffice:11| *None* |Contact - page1adminonly|  |
|mailingAddr/person/personExtra/x\_person\_integer| *None* |Contact - Extra Integer: Custom person integer|  |
|mailingAddr/person/personExtra/x\_person\_hidden\_integer| *None* |Contact - Extra hidden integer: Custom integer field that is hidden|  |
|mailingAddr/person/personExtra/x\_person\_float| *None* |Contact - Extra float: Custom float field|  |
|mailingAddr/person/personExtra/x\_person\_longtext| *None* |Contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|mailingAddr/person/personExtra/x\_person\_date| *None* |Contact - Extra date: Custom date field on person. Default value = 28.03.2019|  |
|mailingAddr/person/personExtra/x\_person\_datetime| *None* |Contact - Extra DateTime: Custom person date and time field. No default|  |
|mailingAddr/person/personExtra/x\_person\_time| *None* |Contact - Extra time: Custom time field on person. Current time as default|  |
|mailingAddr/person/personExtra/x\_person\_boolean| *None* |Contact - Extra Boolean: Custom boolean field on person. Default checked|  |
|mailingAddr/person/personExtra/x\_person\_timespan| *None* |Contact - Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|mailingAddr/person/personExtra/x\_person\_shorttext| *None* |Contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|mailingAddr/person/personExtra/x\_person\_shorttext\_list| *None* |Contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|mailingAddr/person/personExtra/x\_person\_user\_relation| *None* |Contact - Extra user relation: Custom person-user relation field|  |
|mailingAddr/person/personExtra/x\_person\_category\_relation| *None* |Contact - Extra category relation: Custom person-category relation|  |
|mailingAddr/person/personExtra/x\_person\_priority\_relation| *None* |Contact - Extra priority relation: Custom person-priority relation|  |
|mailingAddr/person/personExtra/x\_person\_request\_relation| *None* |Contact - Extra request relation: Request relation on contact|  |
|mailingAddr/person/personExtra/x\_person\_appointment\_relation| *None* |Contact - Extra appointment relation: Appointment relation on person|  |
|mailingAddr/person/personExtra/x\_person\_contact\_relation| *None* |Contact - Extra company relation: Company relation on contact|  |
|mailingAddr/person/personExtra/y\_rental/id| *None* |Contact - Rental - id: Displays the row's primary key (y\_rental)|  |
|mailingAddr/person/personExtra/y\_rental/x\_start| *None* |Contact - Rental - Start rental: Start rental|  |
|mailingAddr/person/personExtra/y\_rental/x\_end| *None* |Contact - Rental - End: End|  |
|mailingAddr/person/personExtra/y\_rental/x\_amount| *None* |Contact - Rental - Amount: Number to rent. Default = 1|  |
|mailingAddr/person/personExtra/y\_rental/x\_contact| *None* |Contact - Rental - Renter: Company that rents equipment|  |
|mailingAddr/person/personExtra/y\_rental/y\_equipment/x\_name| *None* |Contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|mailingAddr/person/personExtra/y\_car/id| *None* |Contact - Car - id: Displays the row's primary key (y\_car)|  |
|mailingAddr/person/personAssociate/firstName| *None* |Contact - First name: Displays the contact's first name|  |
|mailingAddr/person/personAssociate/lastName| *None* |Contact - Last name: Displays the contact's last name|  |
|mailingAddr/person/personAssociate/middleName| *None* |Contact - Middle Name: Displays the contact's middle name.|  |
|mailingAddr/person/personAssociate/fullName| *None* |Contact - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|mailingAddr/person/personAssociate/contactId| *None* |Contact - Company ID: Database ID of the company the user belongs to|  |
|mailingAddr/person/personAssociate/personId| *None* |Contact - Contact ID: Database ID of the contact row|  |
|mailingAddr/person/personAssociate/mrMrs| *None* |Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|mailingAddr/person/personAssociate/title| *None* |Contact - Title: Displays whether the contact is addressed as Mr or Ms|  |
|mailingAddr/person/personAssociate/associateDbId| *None* |Contact - ID|  |
|mailingAddr/person/personAssociate/contactName| *None* |Contact - Owning company: Name of the company the user belongs to|  |
|mailingAddr/person/personAssociate/contactDepartment| *None* |Contact - Owning department: Name of the department at the company the user belongs to|  |
|mailingAddr/person/personAssociate/usergroup| *None* |Contact - Primary group: The user's primary user group|  |
|mailingAddr/person/personAssociate/usergroupId| *None* |Contact - Group ID: The user's primary user group|  |
|mailingAddr/person/personAssociate/contactFullName| *None* |Contact - Owner: Name and department of the company the user belongs to|  |
|mailingAddr/person/personAssociate/contactCategory| *None* |Contact - Category: Category|  |
|mailingAddr/person/personAssociate/role| *None* |Contact - Role: Role|  |
|mailingAddr/person/personAssociate/assocName| *None* |Contact - User ID: User ID|  |
|mailingAddr/person/personAssociate/assocTooltip| *None* |Contact - Description: Description|  |
|mailingAddr/person/personAssociate/assocType| *None* |Contact - Type: Type of user: associate, external user, system user, anonymous account|  |
|mailingAddr/person/personAssociate/ejUserId| *None* |Contact - Service user ID: The database ID of a Service user|  |
|mailingAddr/person/personAssociate/simultaneousEjUser| *None* |Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/person/personAssociate/ejDisplayName| *None* |Contact - Nickname: User's nickname in Service|  |
|mailingAddr/person/personAssociate/ejStatus| *None* |Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/person/personAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in|  |
|mailingAddr/person/personAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|mailingAddr/person/personAssociate/isActive| *None* |Contact - Active: Is this user active, and should be able to log in?|  |
|mailingAddr/person/personAssociate/isActiveText| *None* |Contact - Active status: Is this user active, and should be able to log in?|  |
|mailingAddr/person/personAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/personAssociate/otherGroups| *None* |Contact - Other groups: Other groups|  |
|mailingAddr/person/personAssociate/userName| *None* |Contact - User name: User name|  |
|mailingAddr/person/personAssociate/personEmail| *None* |Contact - E-mail|  |
|mailingAddr/person/personAssociate/locationAddress| *None* |Contact - Location: Location|  |
|mailingAddr/person/personAssociate/isLocation| *None* |Contact - Is a location: Is a location|  |
|mailingAddr/person/correspondingAssociate/firstName| *None* |Contact - First name: Displays the contact's first name|  |
|mailingAddr/person/correspondingAssociate/lastName| *None* |Contact - Last name: Displays the contact's last name|  |
|mailingAddr/person/correspondingAssociate/middleName| *None* |Contact - Middle Name: Displays the contact's middle name.|  |
|mailingAddr/person/correspondingAssociate/fullName| *None* |Contact - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|mailingAddr/person/correspondingAssociate/contactId| *None* |Contact - Company ID: Database ID of the company the user belongs to|  |
|mailingAddr/person/correspondingAssociate/personId| *None* |Contact - Contact ID: Database ID of the contact row|  |
|mailingAddr/person/correspondingAssociate/mrMrs| *None* |Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|mailingAddr/person/correspondingAssociate/title| *None* |Contact - Title: Displays whether the contact is addressed as Mr or Ms|  |
|mailingAddr/person/correspondingAssociate/associateDbId| *None* |Contact - ID|  |
|mailingAddr/person/correspondingAssociate/contactName| *None* |Contact - Owning company: Name of the company the user belongs to|  |
|mailingAddr/person/correspondingAssociate/contactDepartment| *None* |Contact - Owning department: Name of the department at the company the user belongs to|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/person/correspondingAssociate/usergroup| *None* |Contact - Primary group: The user's primary user group|  |
|mailingAddr/person/correspondingAssociate/usergroupId| *None* |Contact - Group ID: The user's primary user group|  |
|mailingAddr/person/correspondingAssociate/contactFullName| *None* |Contact - Owner: Name and department of the company the user belongs to|  |
|mailingAddr/person/correspondingAssociate/contactCategory| *None* |Contact - Category: Category|  |
|mailingAddr/person/correspondingAssociate/role| *None* |Contact - Role: Role|  |
|mailingAddr/person/correspondingAssociate/assocName| *None* |Contact - User ID: User ID|  |
|mailingAddr/person/correspondingAssociate/assocTooltip| *None* |Contact - Description: Description|  |
|mailingAddr/person/correspondingAssociate/assocType| *None* |Contact - Type: Type of user: associate, external user, system user, anonymous account|  |
|mailingAddr/person/correspondingAssociate/ejUserId| *None* |Contact - Service user ID: The database ID of a Service user|  |
|mailingAddr/person/correspondingAssociate/simultaneousEjUser| *None* |Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/person/correspondingAssociate/ejDisplayName| *None* |Contact - Nickname: User's nickname in Service|  |
|mailingAddr/person/correspondingAssociate/ejStatus| *None* |Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/person/correspondingAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in|  |
|mailingAddr/person/correspondingAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|mailingAddr/person/correspondingAssociate/isActive| *None* |Contact - Active: Is this user active, and should be able to log in?|  |
|mailingAddr/person/correspondingAssociate/isActiveText| *None* |Contact - Active status: Is this user active, and should be able to log in?|  |
|mailingAddr/person/correspondingAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/correspondingAssociate/otherGroups| *None* |Contact - Other groups: Other groups|  |
|mailingAddr/person/correspondingAssociate/userName| *None* |Contact - User name: User name|  |
|mailingAddr/person/correspondingAssociate/personEmail| *None* |Contact - E-mail|  |
|mailingAddr/person/correspondingAssociate/locationAddress| *None* |Contact - Location: Location|  |
|mailingAddr/person/correspondingAssociate/isLocation| *None* |Contact - Is a location: Is a location|  |
|mailingAddr/person/isMailingRecipient| *None* |Contact - Is mailing recipient: isMailingRecipient|  |
|mailingAddr/person/hasStoreConsent| *None* |Contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/withdrawnStoreConsent| *None* |Contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/hasEmarketingConsent| *None* |Contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|mailingAddr/person/withdrawnEmarketingConsent| *None* |Contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|mailingAddr/person/subscription| *None* |Contact - Subscription: Subscription for marketing|  |
|mailingAddr/person/legalBaseStore| *None* |Contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/legalBaseEmarketing| *None* |Contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|mailingAddr/person/consentSourceStore| *None* |Contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/consentSourceEmarketing| *None* |Contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|associate/firstName| *None* |First name: Displays the contact's first name|  |
|associate/lastName| *None* |Last name: Displays the contact's last name|  |
|associate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|associate/associateDbId| *None* |ID|  |
|associate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|associate/usergroup| *None* |Primary group: The user's primary user group|  |
|associate/usergroupId| *None* |Group ID: The user's primary user group|  |
|associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|associate/contactCategory| *None* |Category: Category|  |
|associate/role| *None* |Role : Role|  |
|associate/assocName| *None* |User ID : User ID|  |
|associate/assocTooltip| *None* |Description : Description|  |
|associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName| *None* |Nickname: User's nickname in Service|  |
|associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|associate/portraitThumbnail| *None* |Person image: Person image|  |
|associate/otherGroups| *None* |Other groups: Other groups|  |
|associate/userName| *None* |User name: User name|  |
|associate/personEmail| *None* |E-mail|  |
|associate/locationAddress| *None* |Location: Location|  |
|associate/isLocation| *None* |Is a location: Is a location|  |
|emailFlow/emailFlowId| *None* |E-mail flow ID: The database ID of the e-mail flow|  |
|emailFlow/emailFlowHierarchyId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|emailFlow/shipmentType| *None* |Mailing type: Mailing type this e-mail flow represents|  |
|emailFlow/overrideConsentSubscription| *None* |Override consent: Should consent subscriptions be overridden for this flow?|  |
|emailFlow/thumbnail| *None* |Thumbnail|  |
|emailFlow/mediumThumbnail| *None* |Thumbnail|  |
|emailFlow/workflowId| *None* |Flow id: Id of a flow definition|  |
|emailFlow/workflowName| *None* |Name: Name of the flow definition|  |
|emailFlow/workflowDescription| *None* |Description: Description of flow definition|  |
|emailFlow/workflowDefinitionStatus| *None* |Status: Status of the flow definition|  |
|emailFlow/workflowDefinitionStatusId| *None* |Status: Status of the flow definition|  |
|emailFlow/jumpToFinish| *None* |Jump to finish: Should participant jump to finish when the goals are met?|  |
|emailFlow/startOnlyOnce| *None* |Start only once: Should the participant enter the flow only once?|  |
|emailFlow/workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this flow?|  |
|emailFlow/workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|emailFlow/workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|emailFlow/workflowSucceededCount| *None* |Succeeded: How many participants have successfully completed the flow (goal criteria met)?|  |
|emailFlow/workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|emailFlow/updatedBy| *None* |Updated by: The user who last updated the data|  |
|emailFlow/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|emailFlow/registeredBy| *None* |Registered by: The user who registered the data|  |
|emailFlow/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|emailFlow/workflowAssociate/firstName| *None* |Owner - First name: Displays the contact's first name|  |
|emailFlow/workflowAssociate/lastName| *None* |Owner - Last name: Displays the contact's last name|  |
|emailFlow/workflowAssociate/middleName| *None* |Owner - Middle Name: Displays the contact's middle name.|  |
|emailFlow/workflowAssociate/fullName| *None* |Owner - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|emailFlow/workflowAssociate/contactId| *None* |Owner - Company ID: Database ID of the company the user belongs to|  |
|emailFlow/workflowAssociate/personId| *None* |Owner - Contact ID: Database ID of the contact row|  |
|emailFlow/workflowAssociate/mrMrs| *None* |Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|emailFlow/workflowAssociate/title| *None* |Owner - Title: Displays whether the contact is addressed as Mr or Ms|  |
|emailFlow/workflowAssociate/associateDbId| *None* |Owner - ID|  |
|emailFlow/workflowAssociate/contactName| *None* |Owner - Owning company: Name of the company the user belongs to|  |
|emailFlow/workflowAssociate/contactDepartment| *None* |Owner - Owning department: Name of the department at the company the user belongs to|  |
|emailFlow/workflowAssociate/usergroup| *None* |Owner - Primary group: The user's primary user group|  |
|emailFlow/workflowAssociate/usergroupId| *None* |Owner - Group ID: The user's primary user group|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|emailFlow/workflowAssociate/contactFullName| *None* |Owner - Owner: Name and department of the company the user belongs to|  |
|emailFlow/workflowAssociate/contactCategory| *None* |Owner - Category: Category|  |
|emailFlow/workflowAssociate/role| *None* |Owner - Role: Role|  |
|emailFlow/workflowAssociate/assocName| *None* |Owner - User ID: User ID|  |
|emailFlow/workflowAssociate/assocTooltip| *None* |Owner - Description: Description|  |
|emailFlow/workflowAssociate/assocType| *None* |Owner - Type: Type of user: associate, external user, system user, anonymous account|  |
|emailFlow/workflowAssociate/ejUserId| *None* |Owner - Service user ID: The database ID of a Service user|  |
|emailFlow/workflowAssociate/simultaneousEjUser| *None* |Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|emailFlow/workflowAssociate/ejDisplayName| *None* |Owner - Nickname: User's nickname in Service|  |
|emailFlow/workflowAssociate/ejStatus| *None* |Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|emailFlow/workflowAssociate/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in|  |
|emailFlow/workflowAssociate/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|emailFlow/workflowAssociate/isActive| *None* |Owner - Active: Is this user active, and should be able to log in?|  |
|emailFlow/workflowAssociate/isActiveText| *None* |Owner - Active status: Is this user active, and should be able to log in?|  |
|emailFlow/workflowAssociate/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|emailFlow/workflowAssociate/otherGroups| *None* |Owner - Other groups: Other groups|  |
|emailFlow/workflowAssociate/userName| *None* |Owner - User name: User name|  |
|emailFlow/workflowAssociate/personEmail| *None* |Owner - E-mail|  |
|emailFlow/workflowAssociate/locationAddress| *None* |Owner - Location: Location|  |
|emailFlow/workflowAssociate/isLocation| *None* |Owner - Is a location: Is a location|  |
|emailFlow/hierarchyId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|emailFlow/hierarchyFullname| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|emailFlow/hierarchyName| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|emailFlow/hierarchyParentId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|emailFlow/hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |
|project/completed| *None* |Completed: Displays a check mark indicating if the project has been completed.|  |
|project/projectId| *None* |DB ID: Displays the database ID for a project row|  |
|project/name| *None* |Project name: Displays the Project's name|  |
|project/number| *None* |Number: Displays the project's number|  |
|project/type| *None* |Project type: Displays the project's type|  |
|project/status| *None* |Status: Displays the project's status|  |
|project/statusRank| *None* |Status rank: Rank of the project status in the status list|  |
|project/associateId| *None* |ID: Displays login ID of the associate who owns the project|  |
|project/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|project/icon| *None* |Category: Displays the icon for an activity type|  |
|project/text| *None* |Text: Displays a descriptive text for the item|  |
|project/description| *None* |Description : Description|  |
|project/updatedBy| *None* |Updated by: The user who last updated the data|  |
|project/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|project/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|project/registeredBy| *None* |Registered by: The user who registered the data|  |
|project/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|project/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|project/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|project/nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|project/endDate| *None* |End date: End date of project|  |
|project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|project/eventId| *None* |Event ID: Event ID|  |
|project/startDate| *None* |Start date: Project start date|  |
|project/projectPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|project/projectPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|project/projectPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|project/projectEvent/isExternalEvent| *None* |Event: Is this an external event|  |
|project/projectEvent/eventDate| *None* |Event date: Event date|  |
|project/projectEvent/hasSignOn| *None* |Sign On: Does this event have the Sign On function enabled|  |
|project/projectEvent/hasSignOff| *None* |Sign Off: Does this event have the Sign Off function enabled|  |
|project/projectUrl/URLAddress| *None* |URL|  |
|project/projectUrl/URLDescription| *None* |Description|  |
|project/projectAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|project/projectAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|project/projectAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|project/projectAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|project/projectAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|project/projectAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|project/projectAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|project/projectAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|project/projectAssociate/associateDbId| *None* |ID|  |
|project/projectAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|project/projectAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|project/projectAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|project/projectAssociate/usergroupId| *None* |Group ID: The user's primary user group|  |
|project/projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|project/projectAssociate/contactCategory| *None* |Category: Category|  |
|project/projectAssociate/role| *None* |Role : Role|  |
|project/projectAssociate/assocName| *None* |User ID : User ID|  |
|project/projectAssociate/assocTooltip| *None* |Description : Description|  |
|project/projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|project/projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName| *None* |Nickname: User's nickname in Service|  |
|project/projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|project/projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|project/projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|project/projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|project/projectAssociate/userName| *None* |User name: User name|  |
|project/projectAssociate/personEmail| *None* |E-mail|  |
|project/projectAssociate/locationAddress| *None* |Location: Location|  |
|project/projectAssociate/isLocation| *None* |Is a location: Is a location|  |
|project/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|project/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|project/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|project/projectUdef/SuperOffice:4| *None* |projectdate|  |
|project/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|project/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|project/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|project/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|project/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|project/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|project/NumberOfActivities| *None* |Number of activities|  |
|project/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|project/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|project/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|project/LastActivity| *None* |Date of last activity|  |
|project/LastCompletedActivity| *None* |Date of last completed activity|  |
|project/LastDoByActivity| *None* |Date of last non-completed activity|  |
|project/NumberOfSales| *None* |Number of sales|  |
|project/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|project/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|project/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|project/LastSale| *None* |Date of last sale|  |
|project/LastCompletedSale| *None* |Date of last completed sale|  |
|project/LastDoBySale| *None* |Date of last non-completed sale|  |
|project/SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|project/saintSaleStatus| *None* |With status|  |
|project/saintAmountClass| *None* |Amount class|  |
|project/saintActivityType| *None* |SAINT type|  |
|project/saintDirection| *None* |Direction|  |
|project/saintIntention| *None* |Intention|  |
|project/saintTicketStatus| *None* |Status|  |
|project/saintTicketCategory| *None* |Category|  |
|project/project/textId| *None* |Text ID|  |
|project/project/infoText| *None* |Information: Displays the text entered in the description field|  |
|historyRank| *None* |Rank: Rank of list item, if available|  |

## Sample

```http!
GET /api/v1/archive/MailingsAndFolders?$select=getAllRows,mailingAddr/contact/contactAssociate/ejDisplayName,mailingAddr/contact/saintSaleStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

