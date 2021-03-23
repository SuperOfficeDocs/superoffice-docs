---
uid: FindContactWithoutPhoneAddressEmail
title: FindContactWithoutPhoneAddressEmail
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "FindContactWithoutPhoneAddressEmail"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "FindContactWithoutPhoneAddressEmail"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FindContactSubProvider">SuperOffice.CRM.ArchiveLists.FindContactSubProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"contact"|Company|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
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
|contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|contactFax/description|string|Fax - Description: Phone number description| x |
|searchPhone/formattedNumber|string|Searchphone - Phone: Displays phone number|  |
|searchPhone/description|string|Searchphone - Description: Phone number description| x |
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
|contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
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
|NumberOfActivities|int|Number of activities|  |
|NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|LastActivity|date|Date of last activity|  |
|LastCompletedActivity|date|Date of last completed activity|  |
|LastDoByActivity|date|Date of last non-completed activity|  |
|NumberOfSales|int|Number of sales|  |
|NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|LastSale|date|Date of last sale|  |
|LastCompletedSale|date|Date of last completed sale|  |
|LastDoBySale|date|Date of last non-completed sale|  |
|NumberOfTickets|int|Number of requests|  |
|NumberOfTicketsInPeriod|int|Number of requests in last 90 days|  |
|NumberOfNotCompletedTickets|int|Number of non-completed requests|  |
|NumberOfNotCompletedTicketsInPeriod|int|Number of non-completed requests in last 90 days|  |
|LastTicket|date|Date of last request|  |
|LastCompletedTicket|date|Date of last completed request|  |
|LastDoByTicket|date|Date of last non-completed request|  |
|SaintStatus1|saintStatus|Neglected customer|  |
|SaintStatus2|saintStatus|C-company|  |
|saintSaleStatus|listAny|With status|  |
|saintAmountClass|listAny|Amount class|  |
|saintActivityType|listAny|SAINT type|  |
|saintDirection|listAny|Direction|  |
|saintIntention|listAny|Intention|  |
|saintTicketStatus|listAny|Status|  |
|saintTicketCategory|listAny|Category|  |
|sourceRelation/contactId|int|Source - Company ID: Database ID of company| x |
|sourceRelation/name|stringorPK|Source - Company name| x |
|sourceRelation/department|string|Source - Department| x |
|sourceRelation/nameDepartment| *None* |Source - Company: Displays the company an activity is linked to| x |
|sourceRelation/hasInfoText|bool|Source - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|sourceRelation/hasInterests|bool|Source - Has interests: Displays an Icon indicating if the contact has active interests| x |
|sourceRelation/associateId|associate|Source - Our contact: Displays our contact| x |
|sourceRelation/category|listAny|Source - Category| x |
|sourceRelation/business|listAny|Source - Business| x |
|sourceRelation/country|listAny|Source - Country: This criterion corresponds to the Country field on the Company card.| x |
|sourceRelation/number|string|Source - Number| x |
|sourceRelation/code|string|Source - Code| x |
|sourceRelation/orgnr|string|Source - VAT No.| x |
|sourceRelation/stop|bool|Source - Stop| x |
|sourceRelation/contactNoMail|bool|Source - No mailings (company)| x |
|sourceRelation/updatedBy|associate|Source - Updated by: The user who last updated the data| x |
|sourceRelation/updatedDate|date|Source - Updated: The date/time the data was last updated in UTC.| x |
|sourceRelation/registeredBy|associate|Source - Registered by: The user who registered the data| x |
|sourceRelation/registeredDate|date|Source - Registered date: The date/time the data was registered in UTC.| x |
|sourceRelation/contactSource|listAny|Source - Source: Source (Company)| x |
|sourceRelation/contactDeleted|bool|Source - Deleted: Deleted| x |
|sourceRelation/activeErpLinks|bool|Source - ERP connected: Is there an active ERP Sync?| x |
|sourceRelation/deletedDate|datetime|Source - Deleted date: Deleted date|  |
|sourceRelation/mainContact| *None* |Source - Main contact: Main contact for this company| x |
|sourceRelation/restrictionContactId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|sourceRelation/who| *None* |Source - Full name: Full name of company/contact| x |
|sourceRelation/csRelation|listAny|Source - Relation: Name of relation, not taking into account the relation direction| x |
|targetRelation/contactId|int|Target - Company ID: Database ID of company| x |
|targetRelation/name|stringorPK|Target - Company name| x |
|targetRelation/department|string|Target - Department| x |
|targetRelation/nameDepartment| *None* |Target - Company: Displays the company an activity is linked to| x |
|targetRelation/hasInfoText|bool|Target - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|targetRelation/hasInterests|bool|Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|targetRelation/associateId|associate|Target - Our contact: Displays our contact| x |
|targetRelation/category|listAny|Target - Category| x |
|targetRelation/business|listAny|Target - Business| x |
|targetRelation/country|listAny|Target - Country: This criterion corresponds to the Country field on the Company card.| x |
|targetRelation/number|string|Target - Number| x |
|targetRelation/code|string|Target - Code| x |
|targetRelation/orgnr|string|Target - VAT No.| x |
|targetRelation/stop|bool|Target - Stop| x |
|targetRelation/contactNoMail|bool|Target - No mailings (company)| x |
|targetRelation/updatedBy|associate|Target - Updated by: The user who last updated the data| x |
|targetRelation/updatedDate|date|Target - Updated: The date/time the data was last updated in UTC.| x |
|targetRelation/registeredBy|associate|Target - Registered by: The user who registered the data| x |
|targetRelation/registeredDate|date|Target - Registered date: The date/time the data was registered in UTC.| x |
|targetRelation/contactSource|listAny|Target - Source: Source (Company)| x |
|targetRelation/contactDeleted|bool|Target - Deleted: Deleted| x |
|targetRelation/activeErpLinks|bool|Target - ERP connected: Is there an active ERP Sync?| x |
|targetRelation/deletedDate|datetime|Target - Deleted date: Deleted date|  |
|targetRelation/mainContact| *None* |Target - Main contact: Main contact for this company| x |
|targetRelation/restrictionContactId|int|Target - Company ID: Database ID of company to fetch relations for|  |
|targetRelation/who| *None* |Target - Full name: Full name of company/contact| x |
|targetRelation/csRelation|listAny|Target - Relation: Name of relation, not taking into account the relation direction| x |
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
|appointment/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|appointment/icon| *None* |Category: Displays the icon for an activity type| x |
|appointment/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|appointment/time| *None* |Time: Time|  |
|appointment/type|listAny|Type: Displays the type of an activity| x |
|appointment/recordType|string|Record type : Shows the record type| x |
|appointment/text|positiveString|Text: Displays a descriptive text for the item| x |
|appointment/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|appointment/contactId|listAny|Company ID: Database ID of company| x |
|appointment/personId|listAny|Contact ID: Database ID of the contact row| x |
|appointment/projectId|listAny|Project ID: Database ID of project record| x |
|appointment/saleId|int|Sale ID: The database ID of the sale record| x |
|appointment/userGroup|userGroup|User group : The user group that owns the record| x |
|appointment/who| *None* |Who: Contact and/or company|  |
|appointment/updatedBy|associate|Updated by: The user who last updated the data| x |
|appointment/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointment/registeredBy|associate|Registered by: The user who registered the data| x |
|appointment/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointment/appointmentId|int|DB ID: Displays the database ID of a row| x |
|appointment/endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|appointment/priority|listAny|Priority: Displays the priority of the activity| x |
|appointment/alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|appointment/recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|appointment/booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|appointment/intention|listAny|Intention: Displays the intention of the follow-up type| x |
|appointment/location|string|Location: Display the location where the follow-up will take place.| x |
|appointment/recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up| x |
|appointment/rawType|int|Type: Type field for appointment, not decoded or formatted| x |
|appointment/rawStatus|int|Status: Status field for the follow-up, not decoded or formatted| x |
|appointment/cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|appointment/visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?| x |
|appointment/endTime| *None* |End time: End time of an activity|  |
|appointment/suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|appointment/completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|appointment/isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|appointment/invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|appointment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|appointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|appointment/visibleFor|listAny|Visible for|  |
|appointment/appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointment/appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointment/appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|appointment/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointment/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|appointment/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|appointment/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|appointment/appointmentUdef/SuperOffice:4|date|followupdate| x |
|appointment/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|appointment/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|appointment/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|appointment/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|appointment/associate/firstName|string|First name: Displays the contact's first name| x |
|appointment/associate/lastName|string|Last name: Displays the contact's last name| x |
|appointment/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|appointment/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|appointment/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|appointment/associate/personId|int|Contact ID: Database ID of the contact row|  |
|appointment/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|appointment/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|appointment/associate/associateDbId|associate|ID| x |
|appointment/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|appointment/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|appointment/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|appointment/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|appointment/associate/contactCategory|listAny|Category: Category| x |
|appointment/associate/role|listAny|Role : Role| x |
|appointment/associate/assocName|associate|User ID : User ID| x |
|appointment/associate/assocTooltip|string|Description : Description|  |
|appointment/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|appointment/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|appointment/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointment/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|appointment/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointment/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|appointment/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|appointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointment/associate/otherGroups|userGroup|Other groups: Other groups|  |
|appointment/associate/userName|string|User name: User name| x |
|appointment/associate/personEmail|string|E-mail| x |
|appointment/appointment/textId|int|Text ID| x |
|appointment/appointment/description|positiveString|Text: Displays the text entered in the description field| x |
|document/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|document/icon| *None* |Category: Displays the icon for an activity type| x |
|document/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|document/time| *None* |Time: Time|  |
|document/type|listAny|Type: Displays the type of an activity| x |
|document/recordType|string|Record type : Shows the record type| x |
|document/text|positiveString|Text: Displays a descriptive text for the item| x |
|document/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|document/contactId|listAny|Company ID: Database ID of company| x |
|document/personId|listAny|Contact ID: Database ID of the contact row| x |
|document/projectId|listAny|Project ID: Database ID of project record| x |
|document/saleId|int|Sale ID: The database ID of the sale record| x |
|document/userGroup|userGroup|User group : The user group that owns the record| x |
|document/who| *None* |Who: Contact and/or company|  |
|document/updatedBy|associate|Updated by: The user who last updated the data| x |
|document/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|document/registeredBy|associate|Registered by: The user who registered the data| x |
|document/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|document/documentId|int|Document ID: Database ID of document record| x |
|document/keywords|string|Keywords | x |
|document/ourref|string|Our ref.| x |
|document/yourref|string|Your ref.| x |
|document/attention|string|Salutation| x |
|document/subject|string|Subject| x |
|document/mailMergeDraft|bool|Mail merge draft : Indicates whether the document is a mail merge template| x |
|document/snum|int|Document number: Serial number of document. It can be generated by the number allocation system for a dedicated document template.| x |
|document/isReport|bool|Report: Is this document a saved report run?|  |
|document/suggestedDocumentId|int|Document ID (suggestion: The database ID of a document that originates in a suggestion| x |
|document/isMail|bool|E-mail|  |
|document/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|document/visibleFor|listAny|Visible for|  |
|document/documentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|document/documentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|document/documentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|document/documentPublish/publishedBy| *None* |Published by: Published by|  |
|document/associate/firstName|string|First name: Displays the contact's first name| x |
|document/associate/lastName|string|Last name: Displays the contact's last name| x |
|document/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|document/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|document/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|document/associate/personId|int|Contact ID: Database ID of the contact row|  |
|document/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|document/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|document/associate/associateDbId|associate|ID| x |
|document/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|document/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|document/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|document/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|document/associate/contactCategory|listAny|Category: Category| x |
|document/associate/role|listAny|Role : Role| x |
|document/associate/assocName|associate|User ID : User ID| x |
|document/associate/assocTooltip|string|Description : Description|  |
|document/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|document/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|document/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|document/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|document/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|document/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|document/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|document/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|document/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|document/associate/portraitThumbnail| *None* |Person image: Person image|  |
|document/associate/otherGroups|userGroup|Other groups: Other groups|  |
|document/associate/userName|string|User name: User name| x |
|document/associate/personEmail|string|E-mail| x |
|document/documentUdef/SuperOffice:1|string|documentshorttext| x |
|document/documentUdef/SuperOffice:2|string|documentlongtext| x |
|document/documentUdef/SuperOffice:3|int|documentnumber| x |
|document/documentUdef/SuperOffice:4|date|documentdate| x |
|document/documentUdef/SuperOffice:5|unlimitedDate|documentunlimiteddate| x |
|document/documentUdef/SuperOffice:6|bool|documentcheckbox| x |
|document/documentUdef/SuperOffice:7|listAny|documentdropdownlistbox| x |
|document/documentUdef/SuperOffice:8|decimal|documentdecimal| x |
|document/document/textId|int|Text ID| x |
|document/document/description|positiveString|Text: Displays the text entered in the description field| x |
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
|personInfo/textId|int|Text ID| x |
|personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|personEmail/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|personEmail/emailAddress|string|E-mail| x |
|personEmail/emailDescription|string|Description| x |
|personEmail/emailId|int|ID| x |
|personEmail/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|personEmail/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|personEmail/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|personEmail/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|personUrl/URLAddress|string|URL| x |
|personUrl/URLDescription|string|Description| x |
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
|personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
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

## Sample

```http!
GET /api/v1/archive/FindContactWithoutPhoneAddressEmail?$select=associateId,appointment/associate/contactDepartment,document/snum,document/associate/ejUserId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

