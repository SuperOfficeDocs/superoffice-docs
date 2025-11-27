---
uid: ContactPersonDynamicSelectionSingleCriteriaGroup
title: ContactPersonDynamicSelectionSingleCriteriaGroup
description: Contact + Person selection archive using the selectionId as criterionmapping.
keywords: ContactPersonDynamicSelectionSingleCriteriaGroup archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ContactPersonDynamicSelectionSingleCriteriaGroup"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionDynamicProviderSingleCriteriaGroup">SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionDynamicProviderSingleCriteriaGroup</see> inside NetServer's SODatabase assembly.

Contact + Person selection archive using the selectionId as criterionmapping.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"contact"|Company|
|"person"|Contact|

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
|categoryGroup|listAny|Category group| x |
|companyCategoryRank|int|Category rank| x |
|business|listAny|Business| x |
|country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|countryId|int|Country ID: Country ID| x |
|number|string|Number| x |
|code|string|Code| x |
|orgnr|string|VAT No.| x |
|stop|bool|Stop| x |
|contactNoMail|bool|No mailings (company| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contactSource|listAny|Source: Source (Company)| x |
|contactDeleted|bool|Deleted: Deleted| x |
|phone/formattedNumber|string|Phone : Displays phone number|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|deletedDate|datetime|Deleted date: Deleted date|  |
|mainContact| *None* |Main contact: Main contact for this company| x |
|forceCompany|bool|Dummy: Dummy|  |
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
|contactAssociate/usergroupId|int|Group ID: The user's primary user group| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|contactAssociate/contactCategory|listAny|Category: Category| x |
|contactAssociate/role|listAny|Role : Role| x |
|contactAssociate/assocName|associate|User ID : User ID| x |
|contactAssociate/assocTooltip|string|Description : Description|  |
|contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactAssociate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|contactAssociate/userName|string|User name: User name| x |
|contactAssociate/personEmail|string|E-mail| x |
|contactAssociate/locationAddress|string|Location: Location| x |
|contactAssociate/isLocation|bool|Is a location: Is a location| x |
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
|contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
|contactExtra/y\_organization/x\_name|string|Organization - Name: Name| x |
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
|SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
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
|sourceRelation/categoryGroup|listAny|Source - Category group| x |
|sourceRelation/companyCategoryRank|int|Source - Category rank| x |
|sourceRelation/business|listAny|Source - Business| x |
|sourceRelation/country|listAny|Source - Country: This criterion corresponds to the Country field on the Company card.| x |
|sourceRelation/countryId|int|Source - Country ID: Country ID| x |
|sourceRelation/number|string|Source - Number| x |
|sourceRelation/code|string|Source - Code| x |
|sourceRelation/orgnr|string|Source - VAT No.| x |
|sourceRelation/stop|bool|Source - Stop| x |
|sourceRelation/contactNoMail|bool|Source - No mailings (company)| x |
|sourceRelation/updatedBy|associate|Source - Updated by: The user who last updated the data| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sourceRelation/updatedByFullName|associate|Source - Updated by - Full name: The user who last updated the data| x |
|sourceRelation/updatedDate|date|Source - Updated: The date/time the data was last updated in UTC.| x |
|sourceRelation/registeredBy|associate|Source - Registered by: The user who registered the data| x |
|sourceRelation/registeredByFullName|associate|Source - Registered by - Full name: The user who registered the data| x |
|sourceRelation/registeredDate|date|Source - Registered date: The date/time the data was registered in UTC.| x |
|sourceRelation/contactSource|listAny|Source - Source: Source (Company)| x |
|sourceRelation/contactDeleted|bool|Source - Deleted: Deleted| x |
|sourceRelation/activeErpLinks|bool|Source - ERP connected: Is there an active ERP Sync?| x |
|sourceRelation/deletedDate|datetime|Source - Deleted date: Deleted date|  |
|sourceRelation/mainContact| *None* |Source - Main contact: Main contact for this company| x |
|sourceRelation/forceCompany|bool|Source - Dummy: Dummy|  |
|sourceRelation/restrictionContactId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|sourceRelation/who| *None* |Source - Full name: Full name of company/contact| x |
|sourceRelation/csRelation|listAny|Source - Company-to-company relation: Name of relation, not taking into account the relation direction| x |
|targetRelation/contactId|int|Target - Company ID: Database ID of company| x |
|targetRelation/name|stringorPK|Target - Company name| x |
|targetRelation/department|string|Target - Department| x |
|targetRelation/nameDepartment| *None* |Target - Company: Displays the company an activity is linked to| x |
|targetRelation/hasInfoText|bool|Target - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|targetRelation/hasInterests|bool|Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|targetRelation/associateId|associate|Target - Our contact: Displays our contact| x |
|targetRelation/category|listAny|Target - Category| x |
|targetRelation/categoryGroup|listAny|Target - Category group| x |
|targetRelation/companyCategoryRank|int|Target - Category rank| x |
|targetRelation/business|listAny|Target - Business| x |
|targetRelation/country|listAny|Target - Country: This criterion corresponds to the Country field on the Company card.| x |
|targetRelation/countryId|int|Target - Country ID: Country ID| x |
|targetRelation/number|string|Target - Number| x |
|targetRelation/code|string|Target - Code| x |
|targetRelation/orgnr|string|Target - VAT No.| x |
|targetRelation/stop|bool|Target - Stop| x |
|targetRelation/contactNoMail|bool|Target - No mailings (company)| x |
|targetRelation/updatedBy|associate|Target - Updated by: The user who last updated the data| x |
|targetRelation/updatedByFullName|associate|Target - Updated by - Full name: The user who last updated the data| x |
|targetRelation/updatedDate|date|Target - Updated: The date/time the data was last updated in UTC.| x |
|targetRelation/registeredBy|associate|Target - Registered by: The user who registered the data| x |
|targetRelation/registeredByFullName|associate|Target - Registered by - Full name: The user who registered the data| x |
|targetRelation/registeredDate|date|Target - Registered date: The date/time the data was registered in UTC.| x |
|targetRelation/contactSource|listAny|Target - Source: Source (Company)| x |
|targetRelation/contactDeleted|bool|Target - Deleted: Deleted| x |
|targetRelation/activeErpLinks|bool|Target - ERP connected: Is there an active ERP Sync?| x |
|targetRelation/deletedDate|datetime|Target - Deleted date: Deleted date|  |
|targetRelation/mainContact| *None* |Target - Main contact: Main contact for this company| x |
|targetRelation/forceCompany|bool|Target - Dummy: Dummy|  |
|targetRelation/restrictionContactId|int|Target - Company ID: Database ID of company to fetch relations for|  |
|targetRelation/who| *None* |Target - Full name: Full name of company/contact| x |
|targetRelation/csRelation|listAny|Target - Company-to-company relation: Name of relation, not taking into account the relation direction| x |
|sourceRelation/contactPersonRelation|listAny|Source - Company-to-contact relation: Name of relation, not taking into account the relation direction| x |
|targetRelation/personContactRelation|listAny|Target - Contact-to-company relation: Name of relation, not taking into account the relation direction| x |
|sale/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|sale/icon|listAny|Category: Displays the icon for an activity type| x |
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
|sale/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|sale/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|sale/registeredBy|associate|Registered by: The user who registered the data| x |
|sale/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|sale/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|sale/currencyId|int|Currency ID: The currency list item ID| x |
|sale/currency|listAny|Currency: The currency of the sale| x |
|sale/credited|listAny|Credited: The user to be credited with the sale| x |
|sale/lossReason|listAny|Reason (lost: The reason for losing the sale| x |
|sale/source|listAny|Source: The source (lead) of the sale| x |
|sale/competitor|listAny|Competitor: The competitor who won the sale| x |
|sale/heading|stringorPK|Sale: The name of the sale| x |
|sale/amount|decimal|Amount: The gross sales total| x |
|sale/amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.| x |
|sale/earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale| x |
|sale/earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total| x |
|sale/probPercent|int|Probability as %: Probability as %| x |
|sale/originalStage|listAny|Stage when closed: Stage when closed| x |
|sale/stage|listAny|Stage: Displays the stage of the sale| x |
|sale/stageName| *None* |Stage name: Displays the stage of the sale| x |
|sale/saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|sale/stageRank| *None* |Stage rank: Rank of the sale stage in the stage list| x |
|sale/saleType|listAny|Sale type: Sale type, from list| x |
|sale/saleTypeId| *None* |Sale type ID: Sale type, from list| x |
|sale/stageId| *None* |Sale stage ID: Displays the stage of the sale| x |
|sale/nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|sale/reopenDate|date|Reopen date: Displays the reopen date for the sale| x |
|sale/stalledComment|listAny|Reason (stalled: The reason the sale has been stalled| x |
|sale/saleTypeCategory|listAny|Sale type category: Sale type category| x |
|sale/soldReason|listAny|Reason (sold: Reason (sold)| x |
|sale/saleNumber|string|Number: Number| x |
|sale/hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders| x |
|sale/stakeholdersEnabled|bool|Stakeholders enabled: Does this sale have stakeholders enabled| x |
|sale/hasQuote|bool|Has quote?: Does the sale have a quote attached?| x |
|sale/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|sale/description|string|Description: The long description field on Sale|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|sale/createdByWorkflow|listAny|Created by flow: Created by flow| x |
|sale/amountInBaseCurrency| *None* |Amount (BaseCurrency: The gross sales total| x |
|sale/amountWeightedInBaseCurrency| *None* |Weighted amount (BaseCurrency: Virtual field calculated from amount * probability percent.| x |
|sale/daysInStage| *None* |Days in stage: Total number of days in this stage| x |
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
|sale/associate/usergroupId|int|Group ID: The user's primary user group| x |
|sale/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|sale/associate/contactCategory|listAny|Category: Category| x |
|sale/associate/role|listAny|Role : Role| x |
|sale/associate/assocName|associate|User ID : User ID| x |
|sale/associate/assocTooltip|string|Description : Description|  |
|sale/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|sale/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|sale/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|sale/associate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|sale/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|sale/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|sale/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|sale/associate/otherGroups|userGroup|Other groups: Other groups|  |
|sale/associate/userName|string|User name: User name| x |
|sale/associate/personEmail|string|E-mail| x |
|sale/associate/locationAddress|string|Location: Location| x |
|sale/associate/isLocation|bool|Is a location: Is a location| x |
|sale/saleUdef/SuperOffice:1|string|saleshorttext| x |
|sale/saleUdef/SuperOffice:2|string|salelongtext| x |
|sale/saleUdef/SuperOffice:3|int|salenumber| x |
|sale/saleUdef/SuperOffice:4|date|saledate| x |
|sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|sale/saleUdef/SuperOffice:6|bool|salecheckbox| x |
|sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|sale/saleUdef/SuperOffice:8|decimal|saledecimal| x |
|appointment/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|appointment/icon|listAny|Category: Displays the icon for an activity type| x |
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
|appointment/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|appointment/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|appointment/registeredBy|associate|Registered by: The user who registered the data| x |
|appointment/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|appointment/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|appointment/appointmentId|int|DB ID: Displays the database ID of a row| x |
|appointment/endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|appointment/priority|listAny|Priority: Displays the priority of the activity| x |
|appointment/alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|appointment/isFree|bool|Is free: Displays whether the appointment should be considered free or busy| x |
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
|appointment/recordTypeText|listAny|Activity type: The type of the activity (appointment, phone call, etc)| x |
|appointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|appointment/duration|timeSpan|Duration: The duration of the chat session|  |
|appointment/createdByWorkflow|listAny|Created by flow: Created by flow| x |
|appointment/visibleFor|listAny|Visible for|  |
|appointment/appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|appointment/appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|appointment/appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|appointment/associate/usergroupId|int|Group ID: The user's primary user group| x |
|appointment/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|appointment/associate/contactCategory|listAny|Category: Category| x |
|appointment/associate/role|listAny|Role : Role| x |
|appointment/associate/assocName|associate|User ID : User ID| x |
|appointment/associate/assocTooltip|string|Description : Description|  |
|appointment/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|appointment/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|appointment/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|appointment/associate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|appointment/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|appointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|appointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|appointment/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|appointment/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|appointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|appointment/associate/otherGroups|userGroup|Other groups: Other groups|  |
|appointment/associate/userName|string|User name: User name| x |
|appointment/associate/personEmail|string|E-mail| x |
|appointment/associate/locationAddress|string|Location: Location| x |
|appointment/associate/isLocation|bool|Is a location: Is a location| x |
|appointment/appointment/description|positiveString|Text: Displays the text entered in the description field| x |
|appointment/appointment/title|positiveString|Title| x |
|appointment/appointment/titleHtml| *None* |!!Title Html| x |
|appointment/appointment/agenda|positiveString|Agenda| x |
|appointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|appointment/appointment/isConverted| *None* |!!Is Converted|  |
|appointment/appointment/textId|int|Text ID| x |
|appointment/appointment/internalNotes|positiveString|Internal notes: Displays the text entered in the description field| x |
|appointment/appointment/internalNotesHtml|positiveString|!!Internal Notes Html| x |
|document/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|document/icon|listAny|Category: Displays the icon for an activity type| x |
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
|document/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|document/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|document/registeredBy|associate|Registered by: The user who registered the data| x |
|document/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|document/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|document/documentId|int|Document ID: Database ID of document record| x |
|document/keywords|string|Keywords | x |
|document/ourref|string|Our ref.| x |
|document/yourref|string|Your ref.| x |
|document/attention|string|Salutation| x |
|document/subject|string|Subject| x |
|document/name|string|File name | x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|document/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|document/associate/usergroupId|int|Group ID: The user's primary user group| x |
|document/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|document/associate/contactCategory|listAny|Category: Category| x |
|document/associate/role|listAny|Role : Role| x |
|document/associate/assocName|associate|User ID : User ID| x |
|document/associate/assocTooltip|string|Description : Description|  |
|document/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|document/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|document/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|document/associate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|document/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|document/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|document/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|document/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|document/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|document/associate/portraitThumbnail| *None* |Person image: Person image|  |
|document/associate/otherGroups|userGroup|Other groups: Other groups|  |
|document/associate/userName|string|User name: User name| x |
|document/associate/personEmail|string|E-mail| x |
|document/associate/locationAddress|string|Location: Location| x |
|document/associate/isLocation|bool|Is a location: Is a location| x |
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
|personCountryId|int|Country ID: Country ID| x |
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
|personUpdatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|personRegisteredBy|associate|Registered by: The user who registered the data| x |
|personRegisteredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|portraitThumbnail| *None* |Person image: Person image|  |
|personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|ticketPriority|listAny|Service priority: Default service priority for this contact| x |
|supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|supportAssociateFullName|associate|Our service contact - Full name: Default service contact for this contact| x |
|personAssociateId|associate|Our contact: Displays our contact| x |
|personAssociateFullName|associate|Our contact - Full name: Displays our contact| x |
|personCategory|listAny|Category| x |
|personCategoryGroup|listAny|Category group| x |
|personCategoryRank|int|!!Category rank| x |
|personBusiness|listAny|Business| x |
|leadStatus|listAny|Lead status| x |
|leadstatusRank|int|!!Lead status RANK| x |
|personDeletedDate|datetime|Deleted date: Deleted date|  |
|hasCompany|bool|Has company: The contact is associated with a company| x |
|isProjectMember|bool|Is project member: This person is a project member| x |
|isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|updatedByWorkflow|listAny|Updated by flow: Updated by flow| x |
|whenUpdatedByWorkflow|datetime|When updated by flow: When updated by flow| x |
|createdByForm|listAny|Created by form: Created by form| x |
|includePersonRestriction|string|Include main contact: Specifies which contacts should be included in the result ('none', 'main', 'all')|  |
|includePersonWithNoDMRestriction|bool|Include contacts with No Mailings: Should contacts with the 'No Mailings' flag set be included|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|personExtra/x\_person\_integer|int|Extra Integer: Custom person integer| x |
|personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden| x |
|personExtra/x\_person\_float|decimal|Extra float: Custom float field| x |
|personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019| x |
|personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default| x |
|personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default| x |
|personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked| x |
|personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field| x |
|personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation| x |
|personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation| x |
|personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact| x |
|personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person| x |
|personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact| x |
|personExtra/y\_rental/id|int|Rental - id: Displays the row's primary key (y\_rental)| x |
|personExtra/y\_rental/x\_start|date|Rental - Start rental: Start rental| x |
|personExtra/y\_rental/x\_end|date|Rental - End: End| x |
|personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1| x |
|personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment| x |
|personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|personExtra/y\_car/id|int|Car - id: Displays the row's primary key (y\_car)| x |
|personSourceRelation/personId|int|Source - DB ID: Displays the database ID of a contact| x |
|personSourceRelation/firstName|string|Source - First name: Displays the contact's first name| x |
|personSourceRelation/lastName|string|Source - Last name: Displays the contact's last name| x |
|personSourceRelation/middleName|string|Source - Middle name: Displays the contact's middle name.| x |
|personSourceRelation/fullName|stringorPK|Source - Contact: Displays the contact to which an item is linked| x |
|personSourceRelation/contactId|int|Source - Company ID: Database ID of company| x |
|personSourceRelation/hasInfoText|bool|Source - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|personSourceRelation/hasInterests|bool|Source - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personSourceRelation/personHasInterests|bool|Source - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personSourceRelation/mrMrs|string|Source - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personSourceRelation/position|listAny|Source - Position| x |
|personSourceRelation/personNumber|string|Source - Number: Displays the contact's number| x |
|personSourceRelation/title|string|Source - Title: Displays the contact's job title| x |
|personSourceRelation/personCountry|listAny|Source - Country: Country| x |
|personSourceRelation/personCountryId|int|Source - Country ID: Country ID| x |
|personSourceRelation/personNoMail|bool|Source - No Mailings: Displays the contact's No Mailings checkbox| x |
|personSourceRelation/rank|int|Source - Rank: Displays a contact's current rank| x |
|personSourceRelation/birthdate| *None* |Source - Birthdate: Displays the contact's date of birth|  |
|personSourceRelation/associateType| *None* |Source - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personSourceRelation/useAsMailingAddress|bool|Source - Use as postal address: Use as postal address| x |
|personSourceRelation/personSource|listAny|Source - Source: Source (Contact)| x |
|personSourceRelation/retired|bool|Source - Former employee: Indicates whether the contact has retired/left the company| x |
|personSourceRelation/birthYear|int|Source - Birth year: Displays contact's birth year| x |
|personSourceRelation/birthMonth|int|Source - Birth month: Displays contact's birth month| x |
|personSourceRelation/birthDay|int|Source - Birth day: Displays contact's birth day (day of month)| x |
|personSourceRelation/kanaFirstName|string|Source - First name, kana: Contact's first name, in kana alphabet| x |
|personSourceRelation/kanaLastName|string|Source - Last name, kana: Contact's last name, in kana alphabet| x |
|personSourceRelation/personUpdatedBy|associate|Source - Updated by: The user who last updated the data| x |
|personSourceRelation/personUpdatedByFullName|associate|Source - Updated by - Full name: The user who last updated the data| x |
|personSourceRelation/personUpdatedDate|date|Source - Updated: The date/time the data was last updated in UTC.| x |
|personSourceRelation/personRegisteredBy|associate|Source - Registered by: The user who registered the data| x |
|personSourceRelation/personRegisteredByFullName|associate|Source - Registered by - Full name: The user who registered the data| x |
|personSourceRelation/personRegisteredDate|date|Source - Registered date: The date/time the data was registered in UTC.| x |
|personSourceRelation/portraitThumbnail| *None* |Source - Person image: Person image|  |
|personSourceRelation/personActiveErpLinks|bool|Source - ERP connected: Is there an active ERP Sync?| x |
|personSourceRelation/ticketPriority|listAny|Source - Service priority: Default service priority for this contact| x |
|personSourceRelation/supportLanguage|listAny|Source - Preferred language: Preferred language used for reply templates and more| x |
|personSourceRelation/supportAssociate|associate|Source - Our service contact: Default service contact for this contact| x |
|personSourceRelation/supportAssociateFullName|associate|Source - Our service contact - Full name: Default service contact for this contact| x |
|personSourceRelation/personAssociateId|associate|Source - Our contact: Displays our contact| x |
|personSourceRelation/personAssociateFullName|associate|Source - Our contact - Full name: Displays our contact| x |
|personSourceRelation/personCategory|listAny|Source - Category| x |
|personSourceRelation/personCategoryGroup|listAny|Source - Category group| x |
|personSourceRelation/personCategoryRank|int|Source - !!Category rank| x |
|personSourceRelation/personBusiness|listAny|Source - Business| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personSourceRelation/leadStatus|listAny|Source - Lead status| x |
|personSourceRelation/leadstatusRank|int|Source - !!Lead status RANK| x |
|personSourceRelation/personDeletedDate|datetime|Source - Deleted date: Deleted date|  |
|personSourceRelation/hasCompany|bool|Source - Has company: The contact is associated with a company| x |
|personSourceRelation/isProjectMember|bool|Source - Is project member: This person is a project member| x |
|personSourceRelation/isStakeholder|bool|Source - Is stakeholder: This person is a sale stakeholder| x |
|personSourceRelation/updatedByWorkflow|listAny|Source - Updated by flow: Updated by flow| x |
|personSourceRelation/whenUpdatedByWorkflow|datetime|Source - When updated by flow: When updated by flow| x |
|personSourceRelation/createdByForm|listAny|Source - Created by form: Created by form| x |
|personSourceRelation/restrictionContactId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/restrictionPersonId|int|Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/who| *None* |Source - Full name: Full name of company/contact| x |
|personSourceRelation/personPersonRelation|listAny|Source - Contact-to-contact relation: Name of relation, not taking into account the relation direction| x |
|personTargetRelation/personId|int|Target - DB ID: Displays the database ID of a contact| x |
|personTargetRelation/firstName|string|Target - First name: Displays the contact's first name| x |
|personTargetRelation/lastName|string|Target - Last name: Displays the contact's last name| x |
|personTargetRelation/middleName|string|Target - Middle name: Displays the contact's middle name.| x |
|personTargetRelation/fullName|stringorPK|Target - Contact: Displays the contact to which an item is linked| x |
|personTargetRelation/contactId|int|Target - Company ID: Database ID of company| x |
|personTargetRelation/hasInfoText|bool|Target - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|personTargetRelation/hasInterests|bool|Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personTargetRelation/personHasInterests|bool|Target - Has interests: Displays an Icon indicating if the contact has active interests| x |
|personTargetRelation/mrMrs|string|Target - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personTargetRelation/position|listAny|Target - Position| x |
|personTargetRelation/personNumber|string|Target - Number: Displays the contact's number| x |
|personTargetRelation/title|string|Target - Title: Displays the contact's job title| x |
|personTargetRelation/personCountry|listAny|Target - Country: Country| x |
|personTargetRelation/personCountryId|int|Target - Country ID: Country ID| x |
|personTargetRelation/personNoMail|bool|Target - No Mailings: Displays the contact's No Mailings checkbox| x |
|personTargetRelation/rank|int|Target - Rank: Displays a contact's current rank| x |
|personTargetRelation/birthdate| *None* |Target - Birthdate: Displays the contact's date of birth|  |
|personTargetRelation/associateType| *None* |Target - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personTargetRelation/useAsMailingAddress|bool|Target - Use as postal address: Use as postal address| x |
|personTargetRelation/personSource|listAny|Target - Source: Source (Contact)| x |
|personTargetRelation/retired|bool|Target - Former employee: Indicates whether the contact has retired/left the company| x |
|personTargetRelation/birthYear|int|Target - Birth year: Displays contact's birth year| x |
|personTargetRelation/birthMonth|int|Target - Birth month: Displays contact's birth month| x |
|personTargetRelation/birthDay|int|Target - Birth day: Displays contact's birth day (day of month)| x |
|personTargetRelation/kanaFirstName|string|Target - First name, kana: Contact's first name, in kana alphabet| x |
|personTargetRelation/kanaLastName|string|Target - Last name, kana: Contact's last name, in kana alphabet| x |
|personTargetRelation/personUpdatedBy|associate|Target - Updated by: The user who last updated the data| x |
|personTargetRelation/personUpdatedByFullName|associate|Target - Updated by - Full name: The user who last updated the data| x |
|personTargetRelation/personUpdatedDate|date|Target - Updated: The date/time the data was last updated in UTC.| x |
|personTargetRelation/personRegisteredBy|associate|Target - Registered by: The user who registered the data| x |
|personTargetRelation/personRegisteredByFullName|associate|Target - Registered by - Full name: The user who registered the data| x |
|personTargetRelation/personRegisteredDate|date|Target - Registered date: The date/time the data was registered in UTC.| x |
|personTargetRelation/portraitThumbnail| *None* |Target - Person image: Person image|  |
|personTargetRelation/personActiveErpLinks|bool|Target - ERP connected: Is there an active ERP Sync?| x |
|personTargetRelation/ticketPriority|listAny|Target - Service priority: Default service priority for this contact| x |
|personTargetRelation/supportLanguage|listAny|Target - Preferred language: Preferred language used for reply templates and more| x |
|personTargetRelation/supportAssociate|associate|Target - Our service contact: Default service contact for this contact| x |
|personTargetRelation/supportAssociateFullName|associate|Target - Our service contact - Full name: Default service contact for this contact| x |
|personTargetRelation/personAssociateId|associate|Target - Our contact: Displays our contact| x |
|personTargetRelation/personAssociateFullName|associate|Target - Our contact - Full name: Displays our contact| x |
|personTargetRelation/personCategory|listAny|Target - Category| x |
|personTargetRelation/personCategoryGroup|listAny|Target - Category group| x |
|personTargetRelation/personCategoryRank|int|Target - !!Category rank| x |
|personTargetRelation/personBusiness|listAny|Target - Business| x |
|personTargetRelation/leadStatus|listAny|Target - Lead status| x |
|personTargetRelation/leadstatusRank|int|Target - !!Lead status RANK| x |
|personTargetRelation/personDeletedDate|datetime|Target - Deleted date: Deleted date|  |
|personTargetRelation/hasCompany|bool|Target - Has company: The contact is associated with a company| x |
|personTargetRelation/isProjectMember|bool|Target - Is project member: This person is a project member| x |
|personTargetRelation/isStakeholder|bool|Target - Is stakeholder: This person is a sale stakeholder| x |
|personTargetRelation/updatedByWorkflow|listAny|Target - Updated by flow: Updated by flow| x |
|personTargetRelation/whenUpdatedByWorkflow|datetime|Target - When updated by flow: When updated by flow| x |
|personTargetRelation/createdByForm|listAny|Target - Created by form: Created by form| x |
|personTargetRelation/restrictionContactId|int|Target - Company ID: Database ID of company to fetch relations for|  |
|personTargetRelation/restrictionPersonId|int|Target - Company ID: Database ID of company to fetch relations for|  |
|personTargetRelation/who| *None* |Target - Full name: Full name of company/contact| x |
|personTargetRelation/personPersonRelation|listAny|Target - Contact-to-contact relation: Name of relation, not taking into account the relation direction| x |
|personSourceRelation/personContactRelation|listAny|Source - Contact-to-company relation: Name of relation, not taking into account the relation direction| x |
|personTargetRelation/contactPersonRelation|listAny|Target - Company-to-contact relation: Name of relation, not taking into account the relation direction| x |
|personAssociate/firstName|string|First name: Displays the contact's first name| x |
|personAssociate/lastName|string|Last name: Displays the contact's last name| x |
|personAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|personAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|personAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|personAssociate/associateDbId|associate|ID| x |
|personAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|personAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|personAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|personAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|personAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|personAssociate/contactCategory|listAny|Category: Category| x |
|personAssociate/role|listAny|Role : Role| x |
|personAssociate/assocName|associate|User ID : User ID| x |
|personAssociate/assocTooltip|string|Description : Description|  |
|personAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|personAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|personAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAssociate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|personAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|personAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|personAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|personAssociate/userName|string|User name: User name| x |
|personAssociate/personEmail|string|E-mail| x |
|personAssociate/locationAddress|string|Location: Location| x |
|personAssociate/isLocation|bool|Is a location: Is a location| x |
|correspondingAssociate/firstName|string|First name: Displays the contact's first name| x |
|correspondingAssociate/lastName|string|Last name: Displays the contact's last name| x |
|correspondingAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|correspondingAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|correspondingAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|correspondingAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|correspondingAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|correspondingAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|correspondingAssociate/associateDbId|associate|ID| x |
|correspondingAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|correspondingAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|correspondingAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|correspondingAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|correspondingAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|correspondingAssociate/contactCategory|listAny|Category: Category| x |
|correspondingAssociate/role|listAny|Role : Role| x |
|correspondingAssociate/assocName|associate|User ID : User ID| x |
|correspondingAssociate/assocTooltip|string|Description : Description|  |
|correspondingAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|correspondingAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|correspondingAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|correspondingAssociate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|correspondingAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|correspondingAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|correspondingAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|correspondingAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|correspondingAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|correspondingAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|correspondingAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|correspondingAssociate/userName|string|User name: User name| x |
|correspondingAssociate/personEmail|string|E-mail| x |
|correspondingAssociate/locationAddress|string|Location: Location| x |
|correspondingAssociate/isLocation|bool|Is a location: Is a location| x |
|isMailingRecipient|bool|Is mailing recipient: isMailingRecipient| x |
|hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|subscription|listAny|Subscription: Subscription for marketing| x |
|legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|request/contactId|int|Company ID: Database ID of company| x |
|request/personId|int|Contact ID: Database ID of the contact row| x |
|request/saleId|int|Sale ID: The database ID of the sale record| x |
|request/projectId|int|Project ID: Database ID of project record| x |
|request/ticketStatusId|int|Status ID: Status| x |
|request/priorityId|int|Priority ID: ID of priority in database| x |
|request/categoryId|int|Category ID: ID of ticket category in database| x |
|request/ticketTypeName|listAny|Request type: Request type| x |
|request/ticketStatusName|listAny|Status: Request status| x |
|request/categoryFullName|ejCategory|Category: Request category| x |
|request/priorityName|listAny|Priority: Service priority| x |
|request/ownedBy|ejUser|Owner: The owner of the request| x |
|request/ticketId|int|ID: Displays request ID| x |
|request/title|string|Title: Displays the request title| x |
|request/createdAt|datetime|Created: Displays when the request was created| x |
|request/lastChanged|datetime|Last changed: Displays when the request was last changed| x |
|request/author|string|Author: Displays the author of the request| x |
|request/readByOwner|datetime|Read by owner: Displays when the request was read by the owner| x |
|request/firstReadByOwner|datetime|First read by owner: Displays when the request was read by owner for the first time| x |
|request/firstReadByUser|datetime|First read by user: Displays when the request was read by user for the first time| x |
|request/readByCustomer|datetime|Read by contact: Displays when the request was read by the contact| x |
|request/status|listAny|Internal status: Shows only system defined statuses for a request| x |
|request/origin|listAny|Origin: Origin| x |
|request/slevel|listAny|Access level: Access level| x |
|request/numberOfMessages|int|Number of messages: Number of messages| x |
|request/numberOfReplies|int|Number of replies: Number of replies| x |
|request/connectId|int|Merged with request: Merged with request| x |
|request/readStatus|listAny|Read: Read| x |
|request/realTimeSpentQueue|timeSpan|Real time in queue: Real time in queue| x |
|request/realTimeSpentExternally|timeSpan|Real time externally: Real time externally| x |
|request/realTimeSpentInternally|timeSpan|Real time internally: Real time internally| x |
|request/timeSpentQueue|timeSpan|Time spent in queue: Time spent in queue| x |
|request/timeSpentExternally|timeSpan|Time spent externally: Time spent externally| x |
|request/timeSpentInternally|timeSpan|Time spent internally: Time spent internally| x |
|request/timeSpent|timeSpan|Time spent: Time spent| x |
|request/timeToReply|timeSpan|Time to reply: Time to reply| x |
|request/timeToClose|timeSpan|Time to close: Time to close| x |
|request/realTimeToReply|timeSpan|Real time to reply: Real time to reply| x |
|request/realTimeToClose|timeSpan|Real time to close: Real time to close| x |
|request/repliedAt|datetime|Replied at: Replied at| x |
|request/closedAt|datetime|Closed at: Closed at| x |
|request/activated|datetime|Postponed to: Postponed to| x |
|request/deadline|datetime|Deadline: Deadline| x |
|request/has\_attachment|bool|Has attachment: Indicates whether the e-mail has one or more attachments| x |
|request/tags|intArray|Tags: Tags connected to a request| x |
|request/createdBy|ejUser|Created by: Created by| x |
|request/content|string|Content: Search for content in messages related to requests| x |
|request/messageLanguage|listAny|Language: Recognized language in messages|  |
|request/sentimentScore|listAny|Sentiment: Sentiment score, -100 to +100|  |
|request/sentimentConfidence|int|Sentiment confidence: Sentiment confidence| x |
|request/suggestedCategory|listAny|Suggested category: Suggested service category|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|request/createdByWorkflow|listAny|Created by flow: Created by flow| x |
|request/createdBy/firstName|string|Created by - First name: Displays the contact's first name| x |
|request/createdBy/lastName|string|Created by - Last name: Displays the contact's last name| x |
|request/createdBy/middleName|string|Created by - Middle Name: Displays the contact's middle name.| x |
|request/createdBy/fullName|string|Created by - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|request/createdBy/contactId|int|Created by - Company ID: Database ID of the company the user belongs to|  |
|request/createdBy/personId|int|Created by - Contact ID: Database ID of the contact row|  |
|request/createdBy/mrMrs|string|Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|request/createdBy/title|string|Created by - Title: Displays whether the contact is addressed as Mr or Ms| x |
|request/createdBy/associateDbId|associate|Created by - ID| x |
|request/createdBy/contactName|string|Created by - Owning company: Name of the company the user belongs to| x |
|request/createdBy/contactDepartment|string|Created by - Owning department: Name of the department at the company the user belongs to| x |
|request/createdBy/usergroup|userGroup|Created by - Primary group: The user's primary user group| x |
|request/createdBy/usergroupId|int|Created by - Group ID: The user's primary user group| x |
|request/createdBy/contactFullName|string|Created by - Owner: Name and department of the company the user belongs to| x |
|request/createdBy/contactCategory|listAny|Created by - Category: Category| x |
|request/createdBy/role|listAny|Created by - Role: Role| x |
|request/createdBy/assocName|associate|Created by - User ID: User ID| x |
|request/createdBy/assocTooltip|string|Created by - Description: Description|  |
|request/createdBy/assocType|listAny|Created by - Type: Type of user: associate, external user, system user, anonymous account| x |
|request/createdBy/ejUserId|int|Created by - Service user ID: The database ID of a Service user|  |
|request/createdBy/simultaneousEjUser|bool|Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/createdBy/ejDisplayName|string|Created by - Nickname: User's nickname in Service| x |
|request/createdBy/ejStatus|int|Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in| x |
|request/createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|request/createdBy/isActive|bool|Created by - Active: Is this user active, and should be able to log in?| x |
|request/createdBy/isActiveText|bool|Created by - Active status: Is this user active, and should be able to log in?| x |
|request/createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|request/createdBy/otherGroups|userGroup|Created by - Other groups: Other groups|  |
|request/createdBy/userName|string|Created by - User name: User name| x |
|request/createdBy/personEmail|string|Created by - E-mail| x |
|request/createdBy/locationAddress|string|Created by - Location: Location| x |
|request/createdBy/isLocation|bool|Created by - Is a location: Is a location| x |
|request/ownedBy/firstName|string|Owner - First name: Displays the contact's first name| x |
|request/ownedBy/lastName|string|Owner - Last name: Displays the contact's last name| x |
|request/ownedBy/middleName|string|Owner - Middle Name: Displays the contact's middle name.| x |
|request/ownedBy/fullName|string|Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|request/ownedBy/contactId|int|Owner - Company ID: Database ID of the company the user belongs to|  |
|request/ownedBy/personId|int|Owner - Contact ID: Database ID of the contact row|  |
|request/ownedBy/mrMrs|string|Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|request/ownedBy/title|string|Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |
|request/ownedBy/associateDbId|associate|Owner - ID| x |
|request/ownedBy/contactName|string|Owner - Owning company: Name of the company the user belongs to| x |
|request/ownedBy/contactDepartment|string|Owner - Owning department: Name of the department at the company the user belongs to| x |
|request/ownedBy/usergroup|userGroup|Owner - Primary group: The user's primary user group| x |
|request/ownedBy/usergroupId|int|Owner - Group ID: The user's primary user group| x |
|request/ownedBy/contactFullName|string|Owner - Owner: Name and department of the company the user belongs to| x |
|request/ownedBy/contactCategory|listAny|Owner - Category: Category| x |
|request/ownedBy/role|listAny|Owner - Role: Role| x |
|request/ownedBy/assocName|associate|Owner - User ID: User ID| x |
|request/ownedBy/assocTooltip|string|Owner - Description: Description|  |
|request/ownedBy/assocType|listAny|Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|request/ownedBy/ejUserId|int|Owner - Service user ID: The database ID of a Service user|  |
|request/ownedBy/simultaneousEjUser|bool|Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/ownedBy/ejDisplayName|string|Owner - Nickname: User's nickname in Service| x |
|request/ownedBy/ejStatus|int|Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in| x |
|request/ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|request/ownedBy/isActive|bool|Owner - Active: Is this user active, and should be able to log in?| x |
|request/ownedBy/isActiveText|bool|Owner - Active status: Is this user active, and should be able to log in?| x |
|request/ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|request/ownedBy/otherGroups|userGroup|Owner - Other groups: Other groups|  |
|request/ownedBy/userName|string|Owner - User name: User name| x |
|request/ownedBy/personEmail|string|Owner - E-mail| x |
|request/ownedBy/locationAddress|string|Owner - Location: Location| x |
|request/ownedBy/isLocation|bool|Owner - Is a location: Is a location| x |
|request/ticketStatus/ticketStatusId|int|Status - ID: Displays request status ID| x |
|request/ticketStatus/name|string|Status - Name: Displays the name of the request status| x |
|request/ticketStatus/rank|int|Status - Status rank: Sort order of the status in the ticket status list| x |
|request/ticketPriority/ticketPriorityId|int|Priority - ID: Displays the ID of the priority| x |
|request/ticketPriority/name|string|Priority - Name: Displays the name of the priority| x |
|request/ticketPriority/rank|int|Priority - Priority rank: Sort order of priority in the priority list| x |
|request/extra/x\_ticket\_integer|int|Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|request/extra/x\_ticket\_float|decimal|Extra float: Custom float on Request. 2 decimal places| x |
|request/extra/x\_ticket\_longtext|string|Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|request/extra/x\_ticket\_date|date|Extra date: Custom date field on Request. No default value| x |
|request/extra/x\_ticket\_datetime|datetime|Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|request/extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|request/extra/x\_ticket\_boolean|bool|Extra boolean: Custom boolean on Ticket.| x |
|request/extra/x\_ticket\_timespan|timeSpan|Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|request/extra/x\_ticket\_short\_text|string|Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|request/extra/x\_ticket\_shorttext\_list|listAny|Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |
|request/extra/x\_ticket\_timestamp|datetime|Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|request/extra/x\_ticket\_project\_relation|stringorPK|Extra project: Custom project relation on Request| x |
|request/extra/x\_ticket\_faq|stringorPK|Extra FAQ Relation: Extra FAQ Relation| x |
|request/extra/x\_ticket\_category\_relation|listAny|Extra category relation: Category relation on request| x |
|request/extra/y\_equipment/x\_name|string|Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|request/extra/y\_car/id|int|Car - id: Displays the row's primary key (y\_car)| x |
|projectMembers/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|projectMembers/projectId|int|DB ID: Displays the database ID for a project row| x |
|projectMembers/name|stringorPK|Project name: Displays the Project's name| x |
|projectMembers/number|string|Number: Displays the project's number| x |
|projectMembers/type|listAny|Project type: Displays the project's type| x |
|projectMembers/status|listAny|Status: Displays the project's status| x |
|projectMembers/statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|projectMembers/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|projectMembers/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|projectMembers/icon| *None* |Category: Displays the icon for an activity type| x |
|projectMembers/text|string|Text: Displays a descriptive text for the item| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMembers/description|string|Description : Description| x |
|projectMembers/updatedBy|associate|Updated by: The user who last updated the data| x |
|projectMembers/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|projectMembers/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|projectMembers/registeredBy|associate|Registered by: The user who registered the data| x |
|projectMembers/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|projectMembers/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|projectMembers/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|projectMembers/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|projectMembers/endDate|date|End date: End date of project| x |
|projectMembers/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|projectMembers/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|projectMembers/function|listAny|Function: Displays the project member's function in the project| x |
|projectMembers/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|projectMembers/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|projectMembers/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|projectMembers/projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectMembers/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|projectMembers/projectEvent/eventDate|date|Event date: Event date| x |
|projectMembers/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|projectMembers/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|projectMembers/projectUrl/URLAddress|string|URL| x |
|projectMembers/projectUrl/URLDescription|string|Description| x |
|projectMembers/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|projectMembers/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|projectMembers/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|projectMembers/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|projectMembers/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|projectMembers/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|projectMembers/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|projectMembers/projectAssociate/associateDbId|associate|ID| x |
|projectMembers/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|projectMembers/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|projectMembers/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|projectMembers/projectAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|projectMembers/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|projectMembers/projectAssociate/contactCategory|listAny|Category: Category| x |
|projectMembers/projectAssociate/role|listAny|Role : Role| x |
|projectMembers/projectAssociate/assocName|associate|User ID : User ID| x |
|projectMembers/projectAssociate/assocTooltip|string|Description : Description|  |
|projectMembers/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|projectMembers/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|projectMembers/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectMembers/projectAssociate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|projectMembers/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectMembers/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|projectMembers/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|projectMembers/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|projectMembers/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|projectMembers/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectMembers/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|projectMembers/projectAssociate/userName|string|User name: User name| x |
|projectMembers/projectAssociate/personEmail|string|E-mail| x |
|projectMembers/projectAssociate/locationAddress|string|Location: Location| x |
|projectMembers/projectAssociate/isLocation|bool|Is a location: Is a location| x |
|projectMembers/projectUdef/SuperOffice:1|string|projectshorttext| x |
|projectMembers/projectUdef/SuperOffice:2|string|projectlongtext| x |
|projectMembers/projectUdef/SuperOffice:3|int|projectnumber| x |
|projectMembers/projectUdef/SuperOffice:4|date|projectdate| x |
|projectMembers/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|projectMembers/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|projectMembers/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|projectMembers/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|projectMembers/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|projectMembers/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|projectMembers/NumberOfActivities|int|Number of activities|  |
|projectMembers/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|projectMembers/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|projectMembers/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|projectMembers/LastActivity|date|Date of last activity|  |
|projectMembers/LastCompletedActivity|date|Date of last completed activity|  |
|projectMembers/LastDoByActivity|date|Date of last non-completed activity|  |
|projectMembers/NumberOfSales|int|Number of sales|  |
|projectMembers/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|projectMembers/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|projectMembers/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|projectMembers/LastSale|date|Date of last sale|  |
|projectMembers/LastCompletedSale|date|Date of last completed sale|  |
|projectMembers/LastDoBySale|date|Date of last non-completed sale|  |
|projectMembers/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|projectMembers/saintSaleStatus|listAny|With status|  |
|projectMembers/saintAmountClass|listAny|Amount class|  |
|projectMembers/saintActivityType|listAny|SAINT type|  |
|projectMembers/saintDirection|listAny|Direction|  |
|projectMembers/saintIntention|listAny|Intention|  |
|projectMembers/saintTicketStatus|listAny|Status|  |
|projectMembers/saintTicketCategory|listAny|Category|  |
|projectMembers/project/textId|int|Text ID| x |
|projectMembers/project/infoText|positiveString|Information: Displays the text entered in the description field| x |
|personAppointment/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|personAppointment/icon|listAny|Category: Displays the icon for an activity type| x |
|personAppointment/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|personAppointment/time| *None* |Time: Time|  |
|personAppointment/type|listAny|Type: Displays the type of an activity| x |
|personAppointment/recordType|string|Record type : Shows the record type| x |
|personAppointment/text|positiveString|Text: Displays a descriptive text for the item| x |
|personAppointment/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|personAppointment/contactId|listAny|Company ID: Database ID of company| x |
|personAppointment/personId|listAny|Contact ID: Database ID of the contact row| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAppointment/projectId|listAny|Project ID: Database ID of project record| x |
|personAppointment/saleId|int|Sale ID: The database ID of the sale record| x |
|personAppointment/userGroup|userGroup|User group : The user group that owns the record| x |
|personAppointment/who| *None* |Who: Contact and/or company|  |
|personAppointment/updatedBy|associate|Updated by: The user who last updated the data| x |
|personAppointment/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|personAppointment/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|personAppointment/registeredBy|associate|Registered by: The user who registered the data| x |
|personAppointment/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|personAppointment/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|personAppointment/appointmentId|int|DB ID: Displays the database ID of a row| x |
|personAppointment/endDate|date|End date: Displays the deadline for a follow-up/sale| x |
|personAppointment/priority|listAny|Priority: Displays the priority of the activity| x |
|personAppointment/alarm|bool|Has alarm: Displays the alarm state of a follow-up| x |
|personAppointment/isFree|bool|Is free: Displays whether the appointment should be considered free or busy| x |
|personAppointment/recurring|bool|Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up| x |
|personAppointment/booking|bool|Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.| x |
|personAppointment/intention|listAny|Intention: Displays the intention of the follow-up type| x |
|personAppointment/location|string|Location: Display the location where the follow-up will take place.| x |
|personAppointment/recurrenceRuleId|int|RR-ID: Repetition rule ID of follow-up| x |
|personAppointment/rawType|int|Type: Type field for appointment, not decoded or formatted| x |
|personAppointment/rawStatus|int|Status: Status field for the follow-up, not decoded or formatted| x |
|personAppointment/cautionWarning|listAny|Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.| x |
|personAppointment/visibleInDiary|bool|ExcludeBook: Is the activity visible in the diary?| x |
|personAppointment/endTime| *None* |End time: End time of an activity|  |
|personAppointment/suggestedAppointmentId|int|Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion| x |
|personAppointment/completedDate|date|Completed date: Displays the actual date a follow-up/sale was marked as completed| x |
|personAppointment/isMilestone|bool|Milestone: Shows whether or not the follow-ups in this row are milestones| x |
|personAppointment/invitedPersonId|int|ID of invited person: appointment.invitedpersonid record - utility for rd| x |
|personAppointment/recordTypeText|listAny|Activity type: The type of the activity (appointment, phone call, etc)| x |
|personAppointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting| x |
|personAppointment/duration|timeSpan|Duration: The duration of the chat session|  |
|personAppointment/createdByWorkflow|listAny|Created by flow: Created by flow| x |
|personAppointment/visibleFor|listAny|Visible for|  |
|personAppointment/appointmentPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|personAppointment/appointmentPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|personAppointment/appointmentPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|personAppointment/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|personAppointment/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|personAppointment/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|personAppointment/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|personAppointment/appointmentUdef/SuperOffice:4|date|followupdate| x |
|personAppointment/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|personAppointment/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|personAppointment/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|personAppointment/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|personAppointment/associate/firstName|string|First name: Displays the contact's first name| x |
|personAppointment/associate/lastName|string|Last name: Displays the contact's last name| x |
|personAppointment/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|personAppointment/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|personAppointment/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personAppointment/associate/personId|int|Contact ID: Database ID of the contact row|  |
|personAppointment/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|personAppointment/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|personAppointment/associate/associateDbId|associate|ID| x |
|personAppointment/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|personAppointment/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|personAppointment/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|personAppointment/associate/usergroupId|int|Group ID: The user's primary user group| x |
|personAppointment/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|personAppointment/associate/contactCategory|listAny|Category: Category| x |
|personAppointment/associate/role|listAny|Role : Role| x |
|personAppointment/associate/assocName|associate|User ID : User ID| x |
|personAppointment/associate/assocTooltip|string|Description : Description|  |
|personAppointment/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|personAppointment/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|personAppointment/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAppointment/associate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|personAppointment/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAppointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|personAppointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|personAppointment/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|personAppointment/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|personAppointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|personAppointment/associate/otherGroups|userGroup|Other groups: Other groups|  |
|personAppointment/associate/userName|string|User name: User name| x |
|personAppointment/associate/personEmail|string|E-mail| x |
|personAppointment/associate/locationAddress|string|Location: Location| x |
|personAppointment/associate/isLocation|bool|Is a location: Is a location| x |
|personAppointment/appointment/description|positiveString|Text: Displays the text entered in the description field| x |
|personAppointment/appointment/title|positiveString|Title| x |
|personAppointment/appointment/titleHtml| *None* |!!Title Html| x |
|personAppointment/appointment/agenda|positiveString|Agenda| x |
|personAppointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|personAppointment/appointment/isConverted| *None* |!!Is Converted|  |
|personAppointment/appointment/textId|int|Text ID| x |
|personAppointment/appointment/internalNotes|positiveString|Internal notes: Displays the text entered in the description field| x |
|personAppointment/appointment/internalNotesHtml|positiveString|!!Internal Notes Html| x |
|fullNameWithContact| *None* |Contact and company: The fully formatted contact name, and full company name| x |
|selectionMemberId|int|Selection member ID: The database ID of the selection member record|  |
|selectionIdRequest|int|Selection ID: Database ID of selection which members are to be fetched from|  |
|linkClicked/linkId|int|Link ID: Link ID|  |
|linkClicked/shipmentId|int|ID: Displays the ID of the mailing|  |
|formSubmission/formSubmissionId|int|Form submission ID: ID of the form submission record| x |
|formSubmission/formSubmissionFormId|int|Id: Id of the form| x |
|formSubmission/formSubmissionName|string|Form name: Displays a descriptive text for the item| x |
|formSubmission/formSubmissionStatus|listAny|Status: Status of the form submission record| x |
|formSubmission/formSubmissionEmail|string|E-mail: The e-mail address of the person who submitted the form| x |
|formSubmission/icon| *None* |Category: Displays the icon for an activity type| x |
|formSubmission/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|formSubmission/time| *None* |Time: Time|  |
|formSubmission/type|listAny|Type: Displays the type of an activity| x |
|formSubmission/text|positiveString|Text: Displays a descriptive text for the item| x |
|formSubmission/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|formSubmission/contactId|listAny|Company ID: Database ID of company| x |
|formSubmission/personId|listAny|Contact ID: Database ID of the contact row| x |
|formSubmission/updatedBy|associate|Updated by: The user who last updated the data| x |
|formSubmission/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|formSubmission/registeredBy|associate|Registered by: The user who registered the data| x |
|formSubmission/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|formSubmission/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|workflowInstance/workflowInstanceId|int|Instance id: Id of the running flow instance| x |
|workflowInstance/workflowInstanceStatus|listAny|Participant status: Status of the running flow instance| x |
|workflowInstance/workflowInstanceWaitUntil|date|Wait until: Wait until| x |
|workflowInstance/workflowInstanceStepStarted|date|Step started: Step started at this time| x |
|workflowInstance/workflowInstanceCurrentStepDescription| *None* |Current step: Current step description|  |
|workflowInstance/workflowInstanceCurrentStepId| *None* |!!workflowInstanceCurrentStepId: !!workflowInstanceCurrentStepId\_TOOLTIP|  |
|workflowInstance/workflowInstanceLastCommunicationStepDescription| *None* |Last communication: Last communication step description|  |
|workflowInstance/workflowInstanceDropoutReason| *None* |Dropout reason: Dropout reason|  |
|workflowInstance/workflowInstanceLastCommunicationBounceInfo| *None* |Bounce info: Bounce information for the last communication step|  |
|workflowInstance/workflowInstanceLastCommunicationTime|datetime|Sending time: When the message was sent| x |
|workflowInstance/workflowInstanceLastCommunicationStatus|listAny|Last e-mail status: Status of mailing recipient| x |
|workflowInstance/updatedBy|associate|Updated by: The user who last updated the data| x |
|workflowInstance/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|workflowInstance/registeredBy|associate|Registered by: The user who registered the data| x |
|workflowInstance/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|workflowInstance/emailFlow/emailFlowId|int|E-mail flow ID: The database ID of the e-mail flow| x |
|workflowInstance/emailFlow/emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|workflowInstance/emailFlow/shipmentType|listAny|Mailing type: Mailing type this e-mail flow represents| x |
|workflowInstance/emailFlow/overrideConsentSubscription|bool|Override consent: Should consent subscriptions be overridden for this flow?| x |
|workflowInstance/emailFlow/thumbnail| *None* |Thumbnail|  |
|workflowInstance/emailFlow/mediumThumbnail| *None* |Thumbnail|  |
|workflowInstance/emailFlow/workflowId|int|Flow id: Id of a flow definition| x |
|workflowInstance/emailFlow/workflowName|string|Name: Name of the flow definition| x |
|workflowInstance/emailFlow/workflowDescription|string|Description: Description of flow definition| x |
|workflowInstance/emailFlow/workflowDefinitionStatus|listAny|Status: Status of the flow definition| x |
|workflowInstance/emailFlow/workflowDefinitionStatusId|listAny|Status: Status of the flow definition| x |
|workflowInstance/emailFlow/jumpToFinish|bool|Jump to finish: Should participant jump to finish when the goals are met?| x |
|workflowInstance/emailFlow/startOnlyOnce|bool|Start only once: Should the participant enter the flow only once?| x |
|workflowInstance/emailFlow/workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this flow?|  |
|workflowInstance/emailFlow/workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|workflowInstance/emailFlow/workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|workflowInstance/emailFlow/workflowSucceededCount| *None* |Succeeded: How many participants have successfully completed the flow (goal criteria met)?|  |
|workflowInstance/emailFlow/workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|workflowInstance/emailFlow/updatedBy|associate|Updated by: The user who last updated the data| x |
|workflowInstance/emailFlow/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|workflowInstance/emailFlow/registeredBy|associate|Registered by: The user who registered the data| x |
|workflowInstance/emailFlow/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|chatSession/chatSessionId|int|Chat session ID: Database ID of the chat session| x |
|chatSession/firstMessage|string|First message: The first message submitted in the chat| x |
|chatSession/lastMessage|string|Last message: The last message submitted in the chat| x |
|chatSession/whenRequested|datetime|Chat requested: When was this chat requested by the customer?| x |
|chatSession/whenStarted|datetime|Chat started: When was this chat started between the customer and the agent?| x |
|chatSession/whenEnded|datetime|Chat ended: When did this chat end?| x |
|chatSession/duration|timeSpan|Duration: The duration of the chat session|  |
|chatSession/timeInQueue|timeSpan|Time in queue: The time spent waiting in the queue| x |
|chatSession/queueLength|int|Queue length: Queue length when the session was requested| x |
|chatSession/rating|int|Rating: Rating of chat session| x |
|chatSession/agent|ejUser|Agent: The agent of the chat| x |
|chatSession/status|listAny|Status: Status for the chat session| x |
|chatSession/icon| *None* |Category: Displays the icon for an activity type| x |
|chatSession/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|chatSession/type|listAny|Type: Displays the type of an activity| x |
|chatSession/text|positiveString|Text: Displays a descriptive text for the item| x |
|chatSession/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|chatSession/contactId|listAny|Company ID: Database ID of company| x |
|chatSession/personId|listAny|Contact ID: Database ID of the contact row| x |
|chatSession/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|chatSession/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|chatSession/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|chatSession/chatTopic/chatTopicId|int|ID: The database ID of the chat channel| x |
|chatSession/chatTopic/name|string|Name: Name| x |
|chatSession/chatTopic/description|string|Description: The description of the chat channel| x |
|chatSession/chatTopic/badgeHeader|string|Badge header: The value of the badge header for the chat channel| x |
|sale/quote/quoteId|int|Quote ID: SuperOffice database ID of quote record| x |
|sale/quote/poNumber|string|P.O. Number: Customer's purchase order number| x |
|sale/quote/orderComment|string|Comment: Customer's comment| x |
|sale/quote/connectionId|int|DB-ID: Database ID| x |
|sale/quote/registeredDate|date|Registered at: Displays the date when the quote was registered.| x |
|sale/quote/version/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|sale/quote/version/description|string|Description: Description of the quote version| x |
|sale/quote/version/number|string|Number: Reference number for the quote version| x |
|sale/quote/version/sent|date|Sent: The date the quote (version) was sent to the customer| x |
|sale/quote/version/expiration|date|Expiry date: The last date that the quote is valid| x |
|sale/quote/version/state|listAny|State: The current state the quote is in| x |
|sale/quote/version/status|listAny|Quote status: Status field showing the status of each line.| x |
|sale/quote/version/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|sale/quote/version/paymentTerms|listExternal|Payment terms: Payment terms|  |
|sale/quote/version/paymentType|listExternal|Payment type: Payment type|  |
|sale/quote/version/deliveryTerms|listExternal|Delivery terms: Delivery terms|  |
|sale/quote/version/deliveryType|listExternal|Delivery type: Delivery type|  |
|sale/quote/version/approvedBy|associate|Approved by: Associate who approved a quote that broke one or more of the workflow rules that trigger an approval process| x |
|sale/quote/version/approvalRegisteredBy|associate|Approval reg by: Associate who entered the approval of a quote that broke one or more of the workflow rules that trigger an approval process.  Not necessarily the person who approved the quote.| x |
|sale/quote/version/approvedText|string|Approval comment: Comment added to the approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|sale/quote/version/approvedDate|date|Approved date: Date of approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|sale/quote/version/extraField1|string|Extra field 1: One of the extra fields on the product; meaning is installation dependent| x |
|sale/quote/version/extraField2|string|Extra field 2: One of the extra fields on the product; meaning is installation dependent| x |
|sale/quote/version/extraField3|string|Extra field 3: One of the extra fields on the product; meaning is installation dependent| x |
|sale/quote/version/extraField4|string|Extra field 4: One of the extra fields on the product; meaning is installation dependent| x |
|sale/quote/version/extraField5|string|Extra field 5: One of the extra fields on the product; meaning is installation dependent| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/quote/version/alternative/quoteAlternativeId|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|sale/quote/version/alternative/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|sale/quote/version/alternative/name|string|Name: Name of the quote alternative| x |
|sale/quote/version/alternative/description|string|Description: Description of the quote alternative| x |
|sale/quote/version/alternative/status|listAny|Quote status: Status field showing the status of each line.| x |
|sale/quote/version/alternative/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|sale/quote/version/alternative/erpDiscountPercent|decimal|ERP Discount %: Discount percentage suggested by ERP system| x |
|sale/quote/version/alternative/erpDiscountAmount|decimal|ERP Discount: Discount amount suggested by ERP system| x |
|sale/quote/version/alternative/discountPercent|decimal|Discount %: Enter discount in percent for entire alternative| x |
|sale/quote/version/alternative/discountAmount|decimal|Discount: Enter total discount for entire alternative| x |
|sale/quote/version/alternative/vatInfo|string|VAT Info: Information about value-added and other taxes| x |
|sale/quote/version/alternative/vat|decimal|VAT: Value-added and other taxes, total amount| x |
|sale/quote/version/alternative/earningPercent|decimal|Earnings %: Total Earnings as a percentage of the total price, of all lines in the quote alternative, including all discounts| x |
|sale/quote/version/alternative/earningAmount|decimal|Earnings: Total Earnings for all lines in the quote alternative, including all discounts| x |
|sale/quote/version/alternative/totalPrice|decimal|Total: Total price of all items in the quote alternative, including all discounts| x |
|sale/quote/version/alternative/extraField1|string|Extra 1: Extra field 1 on the quote alternative| x |
|sale/quote/version/alternative/extraField2|string|Extra 2: Extra field 2 on the quote alternative| x |
|sale/quote/version/alternative/extraField3|string|Extra 3: Extra field 3on the quote alternative| x |
|sale/quote/version/alternative/extraField4|string|Extra 4: Extra field 4 on the quote alternative| x |
|sale/quote/version/alternative/extraField5|string|Extra 5: Extra field 5 on the quote alternative| x |
|sale/quote/version/alternative/alternativeOrdering|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|sale/quote/version/alternative/subTotal|decimal|Total before discount: Total of all lines, before applying the Alternative discount| x |
|sale/quote/version/alternative/totalPriceIncVAT|decimal|Total incl. VAT: Total of all lines, including VAT| x |
|sale/quote/version/alternative/vatAmount|decimal|VAT: VAT (amount) for the alternative| x |
|sale/quote/version/alternative/quoteline/quoteLineId|int|Quote line ID: Database identity of the quote line| x |
|sale/quote/version/alternative/quoteline/quoteAlternativeId|int|Alternative ID: The database identity of the quote alternative| x |
|sale/quote/version/alternative/quoteline/erpProductKey|string|Product key: The foreign key of the product the quote line is based on.| x |
|sale/quote/version/alternative/quoteline/rank|int|Rank: Shows the rank of a product| x |
|sale/quote/version/alternative/quoteline/quantity|decimal|Quantity: The quantity that is offered| x |
|sale/quote/version/alternative/quoteline/name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|sale/quote/version/alternative/quoteline/description|string|Description: Description of the product that is offered| x |
|sale/quote/version/alternative/quoteline/code|string|Code: The product or article code. This code is created to help you quickly find products you offer regularly.| x |
|sale/quote/version/alternative/quoteline/quantityUnit|string|Unit: The unit of the product that is offered.| x |
|sale/quote/version/alternative/quoteline/priceUnit|string|Price unit: What is the price unit defined in| x |
|sale/quote/version/alternative/quoteline/url|string|Web address: The web address of the product info.| x |
|sale/quote/version/alternative/quoteline/subscriptionUnit|string|Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month| x |
|sale/quote/version/alternative/quoteline/subscriptionQuantity|decimal|Subscription quantity: Number of subscription units offered| x |
|sale/quote/version/alternative/quoteline/UnitListPriceSubscriptionQuantity| *None* |Subscription list price: Unit price * subscription quantity|  |
|sale/quote/version/alternative/quoteline/PriceUnitSubscriptionUnit| *None* |P/S Unit: Price unit/subscription unit|  |
|sale/quote/version/alternative/quoteline/PriceUnitSubscriptionQuantityUnit| *None* |Expanded unit: Price unit @ subscription quantity + unit|  |
|sale/quote/version/alternative/quoteline/vatInfo|string|VAT info: | x |
|sale/quote/version/alternative/quoteline/vat|decimal|VAT: May be filled out by the ERP system| x |
|sale/quote/version/alternative/quoteline/unitCost|decimal|Cost: Cost per item.| x |
|sale/quote/version/alternative/quoteline/unitMinimumPrice|decimal|Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.| x |
|sale/quote/version/alternative/quoteline/unitListPrice|decimal|List price: List price of a unit| x |
|sale/quote/version/alternative/quoteline/totalPrice|decimal|Total: List price * Quantity - Discount Amount| x |
|sale/quote/version/alternative/quoteline/totalCost|decimal|Total cost|  |
|sale/quote/version/alternative/quoteline/quoteLineThumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|sale/quote/version/alternative/quoteline/quoteLineThumbnailLarge| *None* |Thumbnail: A miniature version of the product picture|  |
|sale/quote/version/alternative/quoteline/discountAmount|decimal|Discount: Discount amount given by salesperson| x |
|sale/quote/version/alternative/quoteline/discountPercent|decimal|Discount (%: Discount percent given by salesperson| x |
|sale/quote/version/alternative/quoteline/earningAmount|decimal|Earnings: Amount of Earnings (Total - Cost) on the line, after discount| x |
|sale/quote/version/alternative/quoteline/earningPercent|decimal|Earnings (%: Percentage Earnings on the line (Total - Cost / Total), after discount| x |
|sale/quote/version/alternative/quoteline/updatedBy|associate|Updated by: The user who last updated the data| x |
|sale/quote/version/alternative/quoteline/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|sale/quote/version/alternative/quoteline/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|sale/quote/version/alternative/quoteline/registeredBy|associate|Registered by: The user who registered the data| x |
|sale/quote/version/alternative/quoteline/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|sale/quote/version/alternative/quoteline/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|sale/quote/version/alternative/quoteline/productCategoryKey|listExternal|Product category: The category the product is defined in|  |
|sale/quote/version/alternative/quoteline/productFamilyKey|listExternal|Product family: The family the product is defined in|  |
|sale/quote/version/alternative/quoteline/productTypeKey|listExternal|Product type: The type of product|  |
|sale/quote/version/alternative/quoteline/status|listAny|Quote status: Status field showing the status of each line.| x |
|sale/quote/version/alternative/quoteline/subTotal|decimal|Sum: Sum of Quantity * Unit list price| x |
|sale/quote/version/alternative/quoteline/vatAmount|decimal|VAT (amount: The calculated VAT amount| x |
|sale/quote/version/alternative/quoteline/totalPriceIncVAT|decimal|Total incl. VAT: Total including VAT| x |
|sale/quote/version/alternative/quoteline/totalPriceWithAlternativeDiscount|decimal|Total incl. alt. disc: Total, including any discount percentage set on the alternative| x |

## Sample

```http!
GET /api/v1/archive/ContactPersonDynamicSelectionSingleCriteriaGroup?$select=email/emailLastSent,streetAddress/wgs84longitude,contactAssociate/middleName,contactAssociate/contactDepartment,contactAssociate/assocName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

