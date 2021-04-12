---
uid: ContactPersonSelectionV2
title: ContactPersonSelectionV2
description: This is the archive Provider for the Selection contact/person archive.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ContactPersonSelectionV2"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ContactPersonSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionProviderV2">SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionProviderV2</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the Selection contact/person archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"staticContact"|Static company|
|"staticPerson"|Static contact|
|"contact"|Company|
|"person"|Contact|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|selectionId|int|Selection ID: The database ID of the selection|  |
|rowKind| *None* |Icon indicating whether the row comes from a static or a dynamic selection|  |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|contactId|int|Company ID: Database ID of company| x |
|name|stringorPK|Company name| x |
|department|string|Department| x |
|nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|associateId|associate|Our contact: Displays our contact| x |
|category|listAny|Category| x |
|business|listAny|Business| x |
|country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|number|string|Number| x |
|code|string|Code| x |
|orgnr|string|VAT No.| x |
|stop|bool|Stop| x |
|contactNoMail|bool|No mailings (company| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contactSource|listAny|Source: Source (Company)| x |
|contactDeleted|bool|Deleted: Deleted| x |
|phone/formattedNumber|string|Phone : Displays phone number|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|deletedDate|datetime|Deleted date: Deleted date|  |
|mainContact| *None* |Main contact: Main contact for this company| x |
|who| *None* |Company: Displays the name of a selection member's company| x |
|contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|contactPhone/description|string|Telephone - Description: Phone number description| x |
|contactFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|contactFax/description| *None* |Fax - Description: Phone number description| x |
|searchPhone/formattedNumber| *None* |Searchphone - Phone: Displays phone number|  |
|searchPhone/description| *None* |Searchphone - Description: Phone number description| x |
|email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|email/emailAddress|string|E-mail| x |
|email/emailDescription|string|Description| x |
|email/emailId|int|ID| x |
|email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|postAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|postAddress/line1|string|Postal address - Address 1: First line of the address| x |
|postAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|postAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/addressId|int|Street address - Address ID: Database ID for the address record| x |
|streetAddress/line1|string|Street address - Address 1: First line of the address| x |
|streetAddress/line2|string|Street address - Address 2: Second line of the address| x |
|streetAddress/line3|string|Street address - Address 3: Third line of the address| x |
|streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.| x |
|streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude| x |
|streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude| x |
|streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|url/URLAddress|string|URL| x |
|url/URLDescription|string|Description| x |
|contactAssociate/firstName|string|First name: Displays the contact's first name| x |
|contactAssociate/lastName|string|Last name: Displays the contact's last name| x |
|contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|contactAssociate/associateDbId|associate|ID| x |
|contactAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|contactAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|contactAssociate/contactCategory|listAny|Category: Category| x |
|contactAssociate/role|listAny|Role : Role| x |
|contactAssociate/assocName|associate|User ID : User ID| x |
|contactAssociate/assocTooltip|string|Description : Description|  |
|contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|contactAssociate/userName|string|User name: User name| x |
|contactAssociate/personEmail|string|E-mail| x |
|contactInterestIds| *None* |Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|contactUdef/SuperOffice:3|int|companynumber| x |
|contactUdef/SuperOffice:4|date|companydate| x |
|contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|contactUdef/SuperOffice:6|bool|companycheckbox| x |
|contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|contactUdef/SuperOffice:8|decimal|companydecimal| x |
|contactUdef/SuperOffice:9|string|page1saleonly| x |
|contactUdef/SuperOffice:10|string|page1marketingonly| x |
|contactUdef/SuperOffice:11|string|page1adminonly| x |
|contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|NumberOfActivities| *None* |Number of activities|  |
|NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|LastActivity| *None* |Date of last activity|  |
|LastCompletedActivity| *None* |Date of last completed activity|  |
|LastDoByActivity| *None* |Date of last non-completed activity|  |
|NumberOfSales| *None* |Number of sales|  |
|NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|LastSale| *None* |Date of last sale|  |
|LastCompletedSale| *None* |Date of last completed sale|  |
|LastDoBySale| *None* |Date of last non-completed sale|  |
|NumberOfTickets| *None* |Number of requests|  |
|NumberOfTicketsInPeriod| *None* |Number of requests in last 90 days|  |
|NumberOfNotCompletedTickets| *None* |Number of non-completed requests|  |
|NumberOfNotCompletedTicketsInPeriod| *None* |Number of non-completed requests in last 90 days|  |
|LastTicket| *None* |Date of last request|  |
|LastCompletedTicket| *None* |Date of last completed request|  |
|LastDoByTicket| *None* |Date of last non-completed request|  |
|SaintStatus1| *None* |Neglected customer|  |
|SaintStatus2| *None* |C-company|  |
|saintSaleStatus| *None* |With status|  |
|saintAmountClass| *None* |Amount class|  |
|saintActivityType| *None* |SAINT type|  |
|saintDirection| *None* |Direction|  |
|saintIntention| *None* |Intention|  |
|saintTicketStatus| *None* |Status|  |
|saintTicketCategory| *None* |Category|  |
|sourceRelation/contactId| *None* |Source - Company ID: Database ID of company| x |
|sourceRelation/name| *None* |Source - Company name| x |
|sourceRelation/department| *None* |Source - Department| x |
|sourceRelation/nameDepartment| *None* |Source - Company: Displays the company an activity is linked to| x |
|sourceRelation/hasInfoText| *None* |Source - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|sourceRelation/hasInterests| *None* |Source - Has interests: Displays an Icon indicating if the contact has active interests| x |
|sourceRelation/associateId| *None* |Source - Our contact: Displays our contact| x |
|sourceRelation/category| *None* |Source - Category| x |
|sourceRelation/business| *None* |Source - Business| x |
|sourceRelation/country| *None* |Source - Country: This criterion corresponds to the Country field on the Company card.| x |
|sourceRelation/number| *None* |Source - Number| x |
|sourceRelation/code| *None* |Source - Code| x |
|sourceRelation/orgnr| *None* |Source - VAT No.| x |
|sourceRelation/stop| *None* |Source - Stop| x |
|sourceRelation/contactNoMail| *None* |Source - No mailings (company)| x |
|sourceRelation/updatedBy| *None* |Source - Updated by: The user who last updated the data| x |
|sourceRelation/updatedDate| *None* |Source - Updated: The date/time the data was last updated in UTC.| x |
|sourceRelation/registeredBy| *None* |Source - Registered by: The user who registered the data| x |
|sourceRelation/registeredDate| *None* |Source - Registered date: The date/time the data was registered in UTC.| x |
|sourceRelation/contactSource| *None* |Source - Source: Source (Company)| x |
|sourceRelation/contactDeleted| *None* |Source - Deleted: Deleted| x |
|sourceRelation/activeErpLinks| *None* |Source - ERP connected: Is there an active ERP Sync?| x |
|sourceRelation/deletedDate| *None* |Source - Deleted date: Deleted date|  |
|sourceRelation/mainContact| *None* |Source - Main contact: Main contact for this company| x |
|sourceRelation/restrictionContactId| *None* |Source - Company ID: Database ID of company to fetch relations for|  |
|sourceRelation/who| *None* |Source - Full name: Full name of company/contact| x |
|sourceRelation/csRelation| *None* |Source - Relation: Name of relation, not taking into account the relation direction| x |
|targetRelation/contactId| *None* |Target - Company ID: Database ID of company| x |
|targetRelation/name| *None* |Target - Company name| x |
|targetRelation/department| *None* |Target - Department| x |
|targetRelation/nameDepartment| *None* |Target - Company: Displays the company an activity is linked to| x |
|targetRelation/hasInfoText| *None* |Target - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|targetRelation/hasInterests| *None* |Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|targetRelation/associateId| *None* |Target - Our contact: Displays our contact| x |
|targetRelation/category| *None* |Target - Category| x |
|targetRelation/business| *None* |Target - Business| x |
|targetRelation/country| *None* |Target - Country: This criterion corresponds to the Country field on the Company card.| x |
|targetRelation/number| *None* |Target - Number| x |
|targetRelation/code| *None* |Target - Code| x |
|targetRelation/orgnr| *None* |Target - VAT No.| x |
|targetRelation/stop| *None* |Target - Stop| x |
|targetRelation/contactNoMail| *None* |Target - No mailings (company)| x |
|targetRelation/updatedBy| *None* |Target - Updated by: The user who last updated the data| x |
|targetRelation/updatedDate| *None* |Target - Updated: The date/time the data was last updated in UTC.| x |
|targetRelation/registeredBy| *None* |Target - Registered by: The user who registered the data| x |
|targetRelation/registeredDate| *None* |Target - Registered date: The date/time the data was registered in UTC.| x |
|targetRelation/contactSource| *None* |Target - Source: Source (Company)| x |
|targetRelation/contactDeleted| *None* |Target - Deleted: Deleted| x |
|targetRelation/activeErpLinks| *None* |Target - ERP connected: Is there an active ERP Sync?| x |
|targetRelation/deletedDate| *None* |Target - Deleted date: Deleted date|  |
|targetRelation/mainContact| *None* |Target - Main contact: Main contact for this company| x |
|targetRelation/restrictionContactId| *None* |Target - Company ID: Database ID of company to fetch relations for|  |
|targetRelation/who| *None* |Target - Full name: Full name of company/contact| x |
|targetRelation/csRelation| *None* |Target - Relation: Name of relation, not taking into account the relation direction| x |
|sale/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed| x |
|sale/icon| *None* |Category: Displays the icon for an activity type| x |
|sale/date| *None* |Date: Displays start date of a follow-up / sale date of a sale| x |
|sale/time| *None* |Time: Time|  |
|sale/type| *None* |Type: Displays the type of an activity| x |
|sale/recordType| *None* |Record type : Shows the record type| x |
|sale/text| *None* |Text: Displays a descriptive text for the item| x |
|sale/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.| x |
|sale/contactId| *None* |Company ID: Database ID of company| x |
|sale/personId| *None* |Contact ID: Database ID of the contact row| x |
|sale/projectId| *None* |Project ID: Database ID of project record| x |
|sale/saleId| *None* |Sale ID: The database ID of the sale record| x |
|sale/userGroup| *None* |User group : The user group that owns the record| x |
|sale/who| *None* |Who: Contact and/or company|  |
|sale/updatedBy| *None* |Updated by: The user who last updated the data| x |
|sale/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.| x |
|sale/registeredBy| *None* |Registered by: The user who registered the data| x |
|sale/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.| x |
|sale/currencyId| *None* |Currency ID: The currency list item ID| x |
|sale/currency| *None* |Currency: The currency of the sale| x |
|sale/credited| *None* |Credited: The user to be credited with the sale| x |
|sale/lossReason| *None* |Reason (lost: The reason for losing the sale| x |
|sale/source| *None* |Source: The source (lead) of the sale| x |
|sale/competitor| *None* |Competitor: The competitor who won the sale| x |
|sale/heading| *None* |Sale: Displays a descriptive text for the item| x |
|sale/amount| *None* |Amount: The gross sales total| x |
|sale/amountWeighted| *None* |Weighted amount: Virtual field calculated from amount * probability percent.| x |
|sale/earning| *None* |Profit: Gross profit (gross sales total - cost) for the sale| x |
|sale/earningPercent| *None* |Profit as % : The profit as a percentage of the gross sales total| x |
|sale/probPercent| *None* |Probability as %: Probability as %| x |
|sale/originalStage| *None* |Stage: Displays the stage of the sale| x |
|sale/stage| *None* |Stage: Displays the stage of the sale| x |
|sale/saleStatus| *None* |Status: The status of the sale - open, lost or sold| x |
|sale/saleType| *None* |Sale type: Sale type, from list| x |
|sale/nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|sale/reopenDate| *None* |Reopen date: Displays the reopen date for the sale| x |
|sale/stalledComment| *None* |Reason (stalled: The reason the sale has been stalled| x |
|sale/soldReason| *None* |Reason (sold: Reason (sold)| x |
|sale/saleNumber| *None* |Number: Number| x |
|sale/hasStakeholders| *None* |Has stakeholders: Does this sale have stakeholders enabled| x |
|sale/hasQuote| *None* |Has quote?: Does the sale have a quote attached?| x |
|sale/hasGuide| *None* |Guided: Does this sale have a Sales Guide| x |
|sale/description| *None* |Description: The long description field on Sale|  |
|sale/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?| x |
|sale/visibleFor| *None* |Visible for|  |
|sale/sale/textId| *None* |Text ID| x |
|sale/sale/description| *None* |Text: Displays the text entered in the description field| x |
|sale/salePublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published| x |
|sale/salePublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date| x |
|sale/salePublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date| x |
|sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|sale/associate/firstName| *None* |First name: Displays the contact's first name| x |
|sale/associate/lastName| *None* |Last name: Displays the contact's last name| x |
|sale/associate/middleName| *None* |Middle Name : Displays the contact's middle name.| x |
|sale/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)| x |
|sale/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|sale/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|sale/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|sale/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms| x |
|sale/associate/associateDbId| *None* |ID| x |
|sale/associate/contactName| *None* |Owning company: Name of the company the user belongs to| x |
|sale/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to| x |
|sale/associate/usergroup| *None* |Primary group: The user's primary user group| x |
|sale/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to| x |
|sale/associate/contactCategory| *None* |Category: Category| x |
|sale/associate/role| *None* |Role : Role| x |
|sale/associate/assocName| *None* |User ID : User ID| x |
|sale/associate/assocTooltip| *None* |Description : Description|  |
|sale/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account| x |
|sale/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|sale/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|sale/associate/ejDisplayName| *None* |Nick name: User's nick name in Service| x |
|sale/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|sale/associate/isActive| *None* |Active: Is this user active, and should be able to log in?| x |
|sale/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?| x |
|sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|sale/associate/otherGroups| *None* |Other groups: Other groups|  |
|sale/associate/userName| *None* |User name: User name| x |
|sale/associate/personEmail| *None* |E-mail| x |
|sale/saleUdef/SuperOffice:1| *None* |saleshorttext| x |
|sale/saleUdef/SuperOffice:2| *None* |salelongtext| x |
|sale/saleUdef/SuperOffice:3| *None* |salenumber| x |
|sale/saleUdef/SuperOffice:4| *None* |saledate| x |
|sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate| x |
|sale/saleUdef/SuperOffice:6| *None* |salecheckbox| x |
|sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox| x |
|sale/saleUdef/SuperOffice:8| *None* |saledecimal| x |
|appointment/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed| x |
|appointment/icon| *None* |Category: Displays the icon for an activity type| x |
|appointment/date| *None* |Date: Displays start date of a follow-up / sale date of a sale| x |
|appointment/time| *None* |Time: Time|  |
|appointment/type| *None* |Type: Displays the type of an activity| x |
|appointment/recordType| *None* |Record type : Shows the record type| x |
|appointment/text| *None* |Text: Displays a descriptive text for the item| x |
|appointment/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.| x |
|appointment/contactId| *None* |Company ID: Database ID of company| x |
|appointment/personId| *None* |Contact ID: Database ID of the contact row| x |
|appointment/projectId| *None* |Project ID: Database ID of project record| x |
|appointment/saleId| *None* |Sale ID: The database ID of the sale record| x |
|appointment/userGroup| *None* |User group : The user group that owns the record| x |
|appointment/who| *None* |Who: Contact and/or company|  |
|appointment/updatedBy| *None* |Updated by: The user who last updated the data| x |
|appointment/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.| x |
|appointment/registeredBy| *None* |Registered by: The user who registered the data| x |
|appointment/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.| x |
|appointment/appointmentId| *None* |DB ID: Displays the database ID of a row| x |
|appointment/endDate| *None* |End date: Displays the deadline for a follow-up/sale| x |
|appointment/priority| *None* |Priority: Displays the priority of the activity| x |
|appointment/alarm| *None* |Has alarm: Displays the alarm state of a follow-up| x |
|appointment/recurring| *None* |Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|appointment/booking| *None* |Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|appointment/intention| *None* |Intention: Displays the intention of the follow-up type| x |
|appointment/location| *None* |Location: Display the location where the follow-up will take place.| x |
|appointment/recurrenceRuleId| *None* |RR-ID: Repetition rule ID of follow-up| x |
|appointment/rawType| *None* |Type: Type field for appointment, not decoded or formatted| x |
|appointment/rawStatus| *None* |Status: Status field for the follow-up, not decoded or formatted| x |
|appointment/cautionWarning| *None* |Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|appointment/visibleInDiary| *None* |ExcludeBook: Is the activity visible in the diary?| x |
|appointment/endTime| *None* |End time: End time of an activity|  |
|appointment/suggestedAppointmentId| *None* |Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|appointment/completedDate| *None* |Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|appointment/isMilestone| *None* |Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|appointment/invitedPersonId| *None* |ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|appointment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|appointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|appointment/visibleFor| *None* |Visible for|  |
|appointment/appointmentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published| x |
|appointment/appointmentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointment/appointmentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date| x |
|appointment/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointment/appointmentUdef/SuperOffice:1| *None* |followupshorttext| x |
|appointment/appointmentUdef/SuperOffice:2| *None* |followuplongtext| x |
|appointment/appointmentUdef/SuperOffice:3| *None* |followupnumber| x |
|appointment/appointmentUdef/SuperOffice:4| *None* |followupdate| x |
|appointment/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate| x |
|appointment/appointmentUdef/SuperOffice:6| *None* |followupcheckbox| x |
|appointment/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox| x |
|appointment/appointmentUdef/SuperOffice:8| *None* |followupdecimal| x |
|appointment/associate/firstName| *None* |First name: Displays the contact's first name| x |
|appointment/associate/lastName| *None* |Last name: Displays the contact's last name| x |
|appointment/associate/middleName| *None* |Middle Name : Displays the contact's middle name.| x |
|appointment/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)| x |
|appointment/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|appointment/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|appointment/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointment/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms| x |
|appointment/associate/associateDbId| *None* |ID| x |
|appointment/associate/contactName| *None* |Owning company: Name of the company the user belongs to| x |
|appointment/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to| x |
|appointment/associate/usergroup| *None* |Primary group: The user's primary user group| x |
|appointment/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to| x |
|appointment/associate/contactCategory| *None* |Category: Category| x |
|appointment/associate/role| *None* |Role : Role| x |
|appointment/associate/assocName| *None* |User ID : User ID| x |
|appointment/associate/assocTooltip| *None* |Description : Description|  |
|appointment/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account| x |
|appointment/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|appointment/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointment/associate/ejDisplayName| *None* |Nick name: User's nick name in Service| x |
|appointment/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointment/associate/isActive| *None* |Active: Is this user active, and should be able to log in?| x |
|appointment/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?| x |
|appointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointment/associate/otherGroups| *None* |Other groups: Other groups|  |
|appointment/associate/userName| *None* |User name: User name| x |
|appointment/associate/personEmail| *None* |E-mail| x |
|appointment/appointment/textId| *None* |Text ID| x |
|appointment/appointment/description| *None* |Text: Displays the text entered in the description field| x |
|document/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed| x |
|document/icon| *None* |Category: Displays the icon for an activity type| x |
|document/date| *None* |Date: Displays start date of a follow-up / sale date of a sale| x |
|document/time| *None* |Time: Time|  |
|document/type| *None* |Type: Displays the type of an activity| x |
|document/recordType| *None* |Record type : Shows the record type| x |
|document/text| *None* |Text: Displays a descriptive text for the item| x |
|document/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.| x |
|document/contactId| *None* |Company ID: Database ID of company| x |
|document/personId| *None* |Contact ID: Database ID of the contact row| x |
|document/projectId| *None* |Project ID: Database ID of project record| x |
|document/saleId| *None* |Sale ID: The database ID of the sale record| x |
|document/userGroup| *None* |User group : The user group that owns the record| x |
|document/who| *None* |Who: Contact and/or company|  |
|document/updatedBy| *None* |Updated by: The user who last updated the data| x |
|document/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.| x |
|document/registeredBy| *None* |Registered by: The user who registered the data| x |
|document/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.| x |
|document/documentId| *None* |Document ID: Database ID of document record| x |
|document/keywords| *None* |Keywords | x |
|document/ourref| *None* |Our ref.| x |
|document/yourref| *None* |Your ref.| x |
|document/attention| *None* |Salutation| x |
|document/subject| *None* |Subject| x |
|document/mailMergeDraft| *None* |Mail merge draft : Indicates whether the document is a mail merge template| x |
|document/snum| *None* |Document number: Serial number of document. It can be generated by the number allocation system for a dedicated document template.| x |
|document/isReport| *None* |Report: Is this document a saved report run?|  |
|document/suggestedDocumentId| *None* |Document ID (suggestion: The database ID of a document that originates in a suggestion| x |
|document/isMail| *None* |E-mail|  |
|document/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|document/visibleFor| *None* |Visible for|  |
|document/documentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published| x |
|document/documentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date| x |
|document/documentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date| x |
|document/documentPublish/publishedBy| *None* |Published by: Published by|  |
|document/associate/firstName| *None* |First name: Displays the contact's first name| x |
|document/associate/lastName| *None* |Last name: Displays the contact's last name| x |
|document/associate/middleName| *None* |Middle Name : Displays the contact's middle name.| x |
|document/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)| x |
|document/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|document/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|document/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|document/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms| x |
|document/associate/associateDbId| *None* |ID| x |
|document/associate/contactName| *None* |Owning company: Name of the company the user belongs to| x |
|document/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to| x |
|document/associate/usergroup| *None* |Primary group: The user's primary user group| x |
|document/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to| x |
|document/associate/contactCategory| *None* |Category: Category| x |
|document/associate/role| *None* |Role : Role| x |
|document/associate/assocName| *None* |User ID : User ID| x |
|document/associate/assocTooltip| *None* |Description : Description|  |
|document/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account| x |
|document/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|document/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|document/associate/ejDisplayName| *None* |Nick name: User's nick name in Service| x |
|document/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|document/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|document/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|document/associate/isActive| *None* |Active: Is this user active, and should be able to log in?| x |
|document/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?| x |
|document/associate/portraitThumbnail| *None* |Person image: Person image|  |
|document/associate/otherGroups| *None* |Other groups: Other groups|  |
|document/associate/userName| *None* |User name: User name| x |
|document/associate/personEmail| *None* |E-mail| x |
|document/documentUdef/SuperOffice:1| *None* |documentshorttext| x |
|document/documentUdef/SuperOffice:2| *None* |documentlongtext| x |
|document/documentUdef/SuperOffice:3| *None* |documentnumber| x |
|document/documentUdef/SuperOffice:4| *None* |documentdate| x |
|document/documentUdef/SuperOffice:5| *None* |documentunlimiteddate| x |
|document/documentUdef/SuperOffice:6| *None* |documentcheckbox| x |
|document/documentUdef/SuperOffice:7| *None* |documentdropdownlistbox| x |
|document/documentUdef/SuperOffice:8| *None* |documentdecimal| x |
|document/document/textId| *None* |Text ID| x |
|document/document/description| *None* |Text: Displays the text entered in the description field| x |
|personId|int|DB ID: Displays the database ID of a contact| x |
|firstName|string|First name: Displays the contact's first name| x |
|lastName|string|Last name: Displays the contact's last name| x |
|middleName|string|Middle name: Displays the contact's middle name.| x |
|fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
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
|personInfo/textId|int|Text ID| x |
|personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|personUdef/SuperOffice:3|int|contactnumber| x |
|personUdef/SuperOffice:4|date|contactdate| x |
|personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|personUdef/SuperOffice:6|bool|contactcheckbox| x |
|personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|personUdef/SuperOffice:8|decimal|contactdecimal| x |
|personUdef/SuperOffice:9|string|page1saleonly| x |
|personUdef/SuperOffice:10|string|page1marketingonly| x |
|personUdef/SuperOffice:11|string|page1adminonly| x |
|isMailingRecipient|bool|isMailingRecipient: isMailingRecipient| x |
|hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|subscription|listAny|Subscription: Subscription for marketing| x |
|legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|fullNameWithContact| *None* |Contact and company: The fully formatted contact name, and full company name| x |
|personDirectPhone/formattedNumber| *None* |Direct - Phone: Displays phone number|  |
|personDirectPhone/description| *None* |Direct - Description: Phone number description| x |
|personMobilePhone/formattedNumber| *None* |Mobile - Phone: Displays phone number|  |
|personMobilePhone/description| *None* |Mobile - Description: Phone number description| x |
|personPrivate/formattedNumber| *None* |Private - Phone: Displays phone number|  |
|personPrivate/description| *None* |Private - Description: Phone number description| x |
|personPager/formattedNumber| *None* |Other - Phone: Displays phone number|  |
|personPager/description| *None* |Other - Description: Phone number description| x |
|personDirectFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|personDirectFax/description| *None* |Fax - Description: Phone number description| x |
|personEmail/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP| x |
|personEmail/emailAddress| *None* |E-mail| x |
|personEmail/emailDescription| *None* |Description| x |
|personEmail/emailId| *None* |ID| x |
|personEmail/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address| x |
|personEmail/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address| x |
|personEmail/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address| x |
|personEmail/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|personUrl/URLAddress| *None* |URL| x |
|personUrl/URLDescription| *None* |Description| x |
|personAddress/addressId| *None* |Contact address - Address ID: Database ID for the address record| x |
|personAddress/line1| *None* |Contact address - Address 1: First line of the address| x |
|personAddress/line2| *None* |Contact address - Address 2: Second line of the address| x |
|personAddress/line3| *None* |Contact address - Address 3: Third line of the address| x |
|personAddress/county| *None* |Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|personAddress/city| *None* |Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|personAddress/zip| *None* |Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|personAddress/state| *None* |Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|personAddress/wgs84latitude| *None* |Contact address - Latitude: Latitude| x |
|personAddress/wgs84longitude| *None* |Contact address - Longitude: Longitude| x |
|personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|personInterestIds| *None* |Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|personAssociate/firstName| *None* |First name: Displays the contact's first name| x |
|personAssociate/lastName| *None* |Last name: Displays the contact's last name| x |
|personAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.| x |
|personAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|personAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|personAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms| x |
|personAssociate/associateDbId| *None* |ID| x |
|personAssociate/contactName| *None* |Owning company: Name of the company the user belongs to| x |
|personAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to| x |
|personAssociate/usergroup| *None* |Primary group: The user's primary user group| x |
|personAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to| x |
|personAssociate/contactCategory| *None* |Category: Category| x |
|personAssociate/role| *None* |Role : Role| x |
|personAssociate/assocName| *None* |User ID : User ID| x |
|personAssociate/assocTooltip| *None* |Description : Description|  |
|personAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account| x |
|personAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|personAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service| x |
|personAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?| x |
|personAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?| x |
|personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|personAssociate/otherGroups| *None* |Other groups: Other groups|  |
|personAssociate/userName| *None* |User name: User name| x |
|personAssociate/personEmail| *None* |E-mail| x |
|request/contactId| *None* |Company ID: Database ID of company| x |
|request/personId| *None* |Contact ID: Database ID of the contact row| x |
|request/ticketStatusName| *None* |Status: Request status| x |
|request/categoryFullName| *None* |Category: Request category| x |
|request/priorityName| *None* |Priority: Service priority| x |
|request/ticketId| *None* |ID: Displays request ID| x |
|request/title| *None* |Title: Displays the request title| x |
|request/createdAt| *None* |Created: Displays when the request was created| x |
|request/lastChanged| *None* |Last changed: Displays when the request was last changed| x |
|request/author| *None* |Author: Displays the author of the request| x |
|request/readByOwner| *None* |Read by owner: Displays when the request was read by the owner| x |
|request/firstReadByOwner| *None* |First read by owner: Displays when the request was read by owner for the first time| x |
|request/firstReadByUser| *None* |First read by user: Displays when the request was read by user for the first time| x |
|request/readByCustomer| *None* |Read by contact: Displays when the request was read by the contact| x |
|request/status| *None* |Internal status: Shows only system defined statuses for a request| x |
|request/origin| *None* |Origin: Origin| x |
|request/slevel| *None* |Access level: Access level| x |
|request/numberOfMessages| *None* |Number of messages: Number of messages| x |
|request/numberOfReplies| *None* |Number of replies: Number of replies| x |
|request/connectId| *None* |Merged with request: Merged with request| x |
|request/readStatus| *None* |Read: Read| x |
|request/realTimeSpentQueue| *None* |Real time in queue: Real time in queue| x |
|request/realTimeSpentExternally| *None* |Real time externally: Real time externally| x |
|request/realTimeSpentInternally| *None* |Real time internally: Real time internally| x |
|request/timeSpentQueue| *None* |Time spent in queue: Time spent in queue| x |
|request/timeSpentExternally| *None* |Time spent externally: Time spent externally| x |
|request/timeSpentInternally| *None* |Time spent internally: Time spent internally| x |
|request/timeToReply| *None* |Time to reply: Time to reply| x |
|request/timeToClose| *None* |Time to close: Time to close| x |
|request/realTimeToReply| *None* |Real time to reply: Real time to reply| x |
|request/realTimeToClose| *None* |Real time to close: Real time to close| x |
|request/repliedAt| *None* |Replied at: Replied at| x |
|request/closedAt| *None* |Closed at: Closed at| x |
|request/activated| *None* |Postponed to: Postponed to| x |
|request/deadline| *None* |Deadline: Deadline| x |
|request/has\_attachment| *None* |Has attachment: Indicates whether the e-mail has one or more attachments| x |
|request/tags| *None* |Tags: Tags connected to a request| x |
|request/ownedBy| *None* |Owner: The owner of the request| x |
|request/content| *None* |Content: Search for content in messages related to requests| x |
|request/createdBy/firstName| *None* |Created by - First name: Displays the contact's first name| x |
|request/createdBy/lastName| *None* |Created by - Last name: Displays the contact's last name| x |
|request/createdBy/middleName| *None* |Created by - Middle Name: Displays the contact's middle name.| x |
|request/createdBy/fullName| *None* |Created by - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|request/createdBy/contactId| *None* |Created by - Company ID: Database ID of the company the user belongs to|  |
|request/createdBy/personId| *None* |Created by - Contact ID: Database ID of the contact row|  |
|request/createdBy/mrMrs| *None* |Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|request/createdBy/title| *None* |Created by - Title: Displays whether the contact is addressed as Mr or Ms| x |
|request/createdBy/associateDbId| *None* |Created by - ID| x |
|request/createdBy/contactName| *None* |Created by - Owning company: Name of the company the user belongs to| x |
|request/createdBy/contactDepartment| *None* |Created by - Owning department: Name of the department at the company the user belongs to| x |
|request/createdBy/usergroup| *None* |Created by - Primary group: The user's primary user group| x |
|request/createdBy/contactFullName| *None* |Created by - Owner: Name and department of the company the user belongs to| x |
|request/createdBy/contactCategory| *None* |Created by - Category: Category| x |
|request/createdBy/role| *None* |Created by - Role: Role| x |
|request/createdBy/assocName| *None* |Created by - User ID: User ID| x |
|request/createdBy/assocTooltip| *None* |Created by - Description: Description|  |
|request/createdBy/assocType| *None* |Created by - Type: Type of user: associate, external user, system user, anonymous account| x |
|request/createdBy/ejUserId| *None* |Created by - Service user ID: The database ID of a Service user|  |
|request/createdBy/simultaneousEjUser| *None* |Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/createdBy/ejDisplayName| *None* |Created by - Nick name: User's nick name in Service| x |
|request/createdBy/ejStatus| *None* |Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in| x |
|request/createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|request/createdBy/isActive| *None* |Created by - Active: Is this user active, and should be able to log in?| x |
|request/createdBy/isActiveText| *None* |Created by - Active status: Is this user active, and should be able to log in?| x |
|request/createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|request/createdBy/otherGroups| *None* |Created by - Other groups: Other groups|  |
|request/createdBy/userName| *None* |Created by - User name: User name| x |
|request/createdBy/personEmail| *None* |Created by - E-mail| x |
|request/ownedBy/firstName| *None* |Owner - First name: Displays the contact's first name| x |
|request/ownedBy/lastName| *None* |Owner - Last name: Displays the contact's last name| x |
|request/ownedBy/middleName| *None* |Owner - Middle Name: Displays the contact's middle name.| x |
|request/ownedBy/fullName| *None* |Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|request/ownedBy/contactId| *None* |Owner - Company ID: Database ID of the company the user belongs to|  |
|request/ownedBy/personId| *None* |Owner - Contact ID: Database ID of the contact row|  |
|request/ownedBy/mrMrs| *None* |Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|request/ownedBy/title| *None* |Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |
|request/ownedBy/associateDbId| *None* |Owner - ID| x |
|request/ownedBy/contactName| *None* |Owner - Owning company: Name of the company the user belongs to| x |
|request/ownedBy/contactDepartment| *None* |Owner - Owning department: Name of the department at the company the user belongs to| x |
|request/ownedBy/usergroup| *None* |Owner - Primary group: The user's primary user group| x |
|request/ownedBy/contactFullName| *None* |Owner - Owner: Name and department of the company the user belongs to| x |
|request/ownedBy/contactCategory| *None* |Owner - Category: Category| x |
|request/ownedBy/role| *None* |Owner - Role: Role| x |
|request/ownedBy/assocName| *None* |Owner - User ID: User ID| x |
|request/ownedBy/assocTooltip| *None* |Owner - Description: Description|  |
|request/ownedBy/assocType| *None* |Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|request/ownedBy/ejUserId| *None* |Owner - Service user ID: The database ID of a Service user|  |
|request/ownedBy/simultaneousEjUser| *None* |Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/ownedBy/ejDisplayName| *None* |Owner - Nick name: User's nick name in Service| x |
|request/ownedBy/ejStatus| *None* |Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in| x |
|request/ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|request/ownedBy/isActive| *None* |Owner - Active: Is this user active, and should be able to log in?| x |
|request/ownedBy/isActiveText| *None* |Owner - Active status: Is this user active, and should be able to log in?| x |
|request/ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|request/ownedBy/otherGroups| *None* |Owner - Other groups: Other groups|  |
|request/ownedBy/userName| *None* |Owner - User name: User name| x |
|request/ownedBy/personEmail| *None* |Owner - E-mail| x |
|projectMembers/completed| *None* |Completed: Displays a check mark indicating if the project has been completed.| x |
|projectMembers/projectId| *None* |DB ID: Displays the database ID for a project row| x |
|projectMembers/name| *None* |Project name: Displays the Project's name| x |
|projectMembers/number| *None* |Number: Displays the project's number| x |
|projectMembers/type| *None* |Project type: Displays the project's type| x |
|projectMembers/status| *None* |Status: Displays the project's status| x |
|projectMembers/associateId| *None* |ID: Displays login ID of the associate who owns the project| x |
|projectMembers/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|projectMembers/icon| *None* |Category: Displays the icon for an activity type| x |
|projectMembers/text| *None* |Text: Displays a descriptive text for the item| x |
|projectMembers/description| *None* |Description : Description| x |
|projectMembers/updatedBy| *None* |Updated by: The user who last updated the data| x |
|projectMembers/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.| x |
|projectMembers/registeredBy| *None* |Registered by: The user who registered the data| x |
|projectMembers/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.| x |
|projectMembers/hasGuide| *None* |Guided: Does this sale have a Sales Guide| x |
|projectMembers/nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|projectMembers/endDate| *None* |End date: End date of project| x |
|projectMembers/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|projectMembers/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?| x |
|projectMembers/function| *None* |Function: Displays the project member's function in the project| x |
|projectMembers/projectPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published| x |
|projectMembers/projectPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date| x |
|projectMembers/projectPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date| x |
|projectMembers/projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectMembers/projectEvent/isExternalEvent| *None* |Event: Is this an external event| x |
|projectMembers/projectEvent/eventDate| *None* |Event date: Event date| x |
|projectMembers/projectEvent/hasSignOn| *None* |Sign On: Does this event have the Sign On function enabled| x |
|projectMembers/projectEvent/hasSignOff| *None* |Sign Off: Does this event have the Sign Off function enabled| x |
|projectMembers/projectUrl/URLAddress| *None* |URL| x |
|projectMembers/projectUrl/URLDescription| *None* |Description| x |
|projectMembers/projectAssociate/firstName| *None* |First name: Displays the contact's first name| x |
|projectMembers/projectAssociate/lastName| *None* |Last name: Displays the contact's last name| x |
|projectMembers/projectAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.| x |
|projectMembers/projectAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)| x |
|projectMembers/projectAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|projectMembers/projectAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|projectMembers/projectAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/associateDbId| *None* |ID| x |
|projectMembers/projectAssociate/contactName| *None* |Owning company: Name of the company the user belongs to| x |
|projectMembers/projectAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to| x |
|projectMembers/projectAssociate/usergroup| *None* |Primary group: The user's primary user group| x |
|projectMembers/projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to| x |
|projectMembers/projectAssociate/contactCategory| *None* |Category: Category| x |
|projectMembers/projectAssociate/role| *None* |Role : Role| x |
|projectMembers/projectAssociate/assocName| *None* |User ID : User ID| x |
|projectMembers/projectAssociate/assocTooltip| *None* |Description : Description|  |
|projectMembers/projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account| x |
|projectMembers/projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|projectMembers/projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectMembers/projectAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service| x |
|projectMembers/projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectMembers/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|projectMembers/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|projectMembers/projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?| x |
|projectMembers/projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?| x |
|projectMembers/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectMembers/projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|projectMembers/projectAssociate/userName| *None* |User name: User name| x |
|projectMembers/projectAssociate/personEmail| *None* |E-mail| x |
|projectMembers/projectUdef/SuperOffice:1| *None* |projectshorttext| x |
|projectMembers/projectUdef/SuperOffice:2| *None* |projectlongtext| x |
|projectMembers/projectUdef/SuperOffice:3| *None* |projectnumber| x |
|projectMembers/projectUdef/SuperOffice:4| *None* |projectdate| x |
|projectMembers/projectUdef/SuperOffice:5| *None* |projectunlimiteddate| x |
|projectMembers/projectUdef/SuperOffice:6| *None* |projectcheckbox| x |
|projectMembers/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox| x |
|projectMembers/projectUdef/SuperOffice:8| *None* |projectdecimal| x |
|projectMembers/projectUdef/SuperOffice:9| *None* |page1saleandmarketing| x |
|projectMembers/projectUdef/SuperOffice:10| *None* |page1saleandadmin| x |
|projectMembers/NumberOfActivities| *None* |Number of activities|  |
|projectMembers/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|projectMembers/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|projectMembers/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|projectMembers/LastActivity| *None* |Date of last activity|  |
|projectMembers/LastCompletedActivity| *None* |Date of last completed activity|  |
|projectMembers/LastDoByActivity| *None* |Date of last non-completed activity|  |
|projectMembers/NumberOfSales| *None* |Number of sales|  |
|projectMembers/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|projectMembers/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|projectMembers/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|projectMembers/LastSale| *None* |Date of last sale|  |
|projectMembers/LastCompletedSale| *None* |Date of last completed sale|  |
|projectMembers/LastDoBySale| *None* |Date of last non-completed sale|  |
|projectMembers/SaintStatus3| *None* |Not completed activites with intention sale|  |
|projectMembers/saintSaleStatus| *None* |With status|  |
|projectMembers/saintAmountClass| *None* |Amount class|  |
|projectMembers/saintActivityType| *None* |SAINT type|  |
|projectMembers/saintDirection| *None* |Direction|  |
|projectMembers/saintIntention| *None* |Intention|  |
|projectMembers/saintTicketStatus| *None* |Status|  |
|projectMembers/saintTicketCategory| *None* |Category|  |
|projectMembers/project/textId| *None* |Text ID| x |
|projectMembers/project/infoText| *None* |Information: Displays the text entered in the description field| x |
|personAppointment/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed| x |
|personAppointment/icon| *None* |Category: Displays the icon for an activity type| x |
|personAppointment/date| *None* |Date: Displays start date of a follow-up / sale date of a sale| x |
|personAppointment/time| *None* |Time: Time|  |
|personAppointment/type| *None* |Type: Displays the type of an activity| x |
|personAppointment/recordType| *None* |Record type : Shows the record type| x |
|personAppointment/text| *None* |Text: Displays a descriptive text for the item| x |
|personAppointment/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.| x |
|personAppointment/contactId| *None* |Company ID: Database ID of company| x |
|personAppointment/personId| *None* |Contact ID: Database ID of the contact row| x |
|personAppointment/projectId| *None* |Project ID: Database ID of project record| x |
|personAppointment/saleId| *None* |Sale ID: The database ID of the sale record| x |
|personAppointment/userGroup| *None* |User group : The user group that owns the record| x |
|personAppointment/who| *None* |Who: Contact and/or company|  |
|personAppointment/updatedBy| *None* |Updated by: The user who last updated the data| x |
|personAppointment/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.| x |
|personAppointment/registeredBy| *None* |Registered by: The user who registered the data| x |
|personAppointment/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.| x |
|personAppointment/appointmentId| *None* |DB ID: Displays the database ID of a row| x |
|personAppointment/endDate| *None* |End date: Displays the deadline for a follow-up/sale| x |
|personAppointment/priority| *None* |Priority: Displays the priority of the activity| x |
|personAppointment/alarm| *None* |Has alarm: Displays the alarm state of a follow-up| x |
|personAppointment/recurring| *None* |Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|personAppointment/booking| *None* |Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|personAppointment/intention| *None* |Intention: Displays the intention of the follow-up type| x |
|personAppointment/location| *None* |Location: Display the location where the follow-up will take place.| x |
|personAppointment/recurrenceRuleId| *None* |RR-ID: Repetition rule ID of follow-up| x |
|personAppointment/rawType| *None* |Type: Type field for appointment, not decoded or formatted| x |
|personAppointment/rawStatus| *None* |Status: Status field for the follow-up, not decoded or formatted| x |
|personAppointment/cautionWarning| *None* |Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|personAppointment/visibleInDiary| *None* |ExcludeBook: Is the activity visible in the diary?| x |
|personAppointment/endTime| *None* |End time: End time of an activity|  |
|personAppointment/suggestedAppointmentId| *None* |Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|personAppointment/completedDate| *None* |Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|personAppointment/isMilestone| *None* |Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|personAppointment/invitedPersonId| *None* |ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|personAppointment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|personAppointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|personAppointment/visibleFor| *None* |Visible for|  |
|personAppointment/appointmentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published| x |
|personAppointment/appointmentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date| x |
|personAppointment/appointmentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date| x |
|personAppointment/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|personAppointment/appointmentUdef/SuperOffice:1| *None* |followupshorttext| x |
|personAppointment/appointmentUdef/SuperOffice:2| *None* |followuplongtext| x |
|personAppointment/appointmentUdef/SuperOffice:3| *None* |followupnumber| x |
|personAppointment/appointmentUdef/SuperOffice:4| *None* |followupdate| x |
|personAppointment/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate| x |
|personAppointment/appointmentUdef/SuperOffice:6| *None* |followupcheckbox| x |
|personAppointment/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox| x |
|personAppointment/appointmentUdef/SuperOffice:8| *None* |followupdecimal| x |
|personAppointment/associate/firstName| *None* |First name: Displays the contact's first name| x |
|personAppointment/associate/lastName| *None* |Last name: Displays the contact's last name| x |
|personAppointment/associate/middleName| *None* |Middle Name : Displays the contact's middle name.| x |
|personAppointment/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personAppointment/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|personAppointment/associate/personId| *None* |Contact ID: Database ID of the contact row|  |
|personAppointment/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personAppointment/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms| x |
|personAppointment/associate/associateDbId| *None* |ID| x |
|personAppointment/associate/contactName| *None* |Owning company: Name of the company the user belongs to| x |
|personAppointment/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to| x |
|personAppointment/associate/usergroup| *None* |Primary group: The user's primary user group| x |
|personAppointment/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to| x |
|personAppointment/associate/contactCategory| *None* |Category: Category| x |
|personAppointment/associate/role| *None* |Role : Role| x |
|personAppointment/associate/assocName| *None* |User ID : User ID| x |
|personAppointment/associate/assocTooltip| *None* |Description : Description|  |
|personAppointment/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account| x |
|personAppointment/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|personAppointment/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAppointment/associate/ejDisplayName| *None* |Nick name: User's nick name in Service| x |
|personAppointment/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAppointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|personAppointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personAppointment/associate/isActive| *None* |Active: Is this user active, and should be able to log in?| x |
|personAppointment/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?| x |
|personAppointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|personAppointment/associate/otherGroups| *None* |Other groups: Other groups|  |
|personAppointment/associate/userName| *None* |User name: User name| x |
|personAppointment/associate/personEmail| *None* |E-mail| x |
|personAppointment/appointment/textId| *None* |Text ID| x |
|personAppointment/appointment/description| *None* |Text: Displays the text entered in the description field| x |
|includePersonRestriction| *None* |Include main contact: Specifies which contacts should be included in the result ('none', 'main', 'all')|  |
|includePersonWithNoDMRestriction| *None* |Include contacts with No Mailings: Should contacts with the 'No Mailings' flag set be included|  |

## Sample

```http!
GET /api/v1/archive/ContactPersonSelectionV2?$select=contactAssociate/isActiveText,contactUdef/SuperOffice:1,appointment/recordTypeText,appointment/associate/associateDbId,appointment/associate/contactName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

