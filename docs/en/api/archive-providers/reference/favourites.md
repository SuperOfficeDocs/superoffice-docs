---
uid: Favourites
title: Favourites
description: Archive provider for the list of favourites
keywords: Favourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Favourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FavouritesProvider">SuperOffice.CRM.ArchiveLists.FavouritesProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the list of favourites

## Supported Entities
| Name | Description |
| ---- | ----- |
|"sale"|Favourite sale|
|"contact"|Favourite company|
|"person"|Favourite contact|
|"project"|Favourite project|
|"selection"|Favourite selection|
|"mailing"|Favourite mailing|
|"document"|Favourite document|
|"appointment"|Favourite appointment|
|"ticket"|Favourite request|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed| *None* |Completed: Displays a checkbox showing if an appointment is completed|  |
|icon| *None* |Category: Displays the icon for an activity type| x |
|date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|time| *None* |Time: Time|  |
|type| *None* |Type: Displays the type of an activity|  |
|recordType| *None* |Record type : Shows the record type|  |
|text|positiveString|Favourite: Displays a descriptive text for the item| x |
|associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|contactId| *None* |Company ID: Database ID of company|  |
|personId| *None* |Contact ID: Database ID of the contact row|  |
|projectId| *None* |Project ID: Database ID of project record|  |
|saleId| *None* |Sale ID: The database ID of the sale record|  |
|userGroup| *None* |User group : The user group that owns the record|  |
|who| *None* |Who: Contact and/or company|  |
|updatedBy| *None* |Updated by: The user who last updated the data|  |
|updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|registeredBy| *None* |Registered by: The user who registered the data|  |
|registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|currencyId| *None* |Currency ID: The currency list item ID|  |
|currency| *None* |Currency: The currency of the sale|  |
|credited| *None* |Credited: The user to be credited with the sale|  |
|lossReason| *None* |Reason (lost: The reason for losing the sale|  |
|source| *None* |Source: The source (lead) of the sale|  |
|competitor| *None* |Competitor: The competitor who won the sale|  |
|heading| *None* |Sale: The name of the sale|  |
|amount| *None* |Amount: The gross sales total|  |
|amountWeighted| *None* |Weighted amount: Virtual field calculated from amount * probability percent.|  |
|earning| *None* |Profit: Gross profit (gross sales total - cost) for the sale|  |
|earningPercent| *None* |Profit as % : The profit as a percentage of the gross sales total|  |
|probPercent| *None* |Probability as %: Probability as %|  |
|originalStage| *None* |Stage when closed: Stage when closed|  |
|stage| *None* |Stage: Displays the stage of the sale|  |
|stageName| *None* |Stage name: Displays the stage of the sale|  |
|saleStatus| *None* |Status: The status of the sale - open, lost or sold|  |
|stageRank| *None* |Stage rank: Rank of the sale stage in the stage list|  |
|saleType| *None* |Sale type: Sale type, from list|  |
|saleTypeId| *None* |Sale type ID: Sale type, from list|  |
|stageId| *None* |Sale stage ID: Displays the stage of the sale|  |
|nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|reopenDate| *None* |Reopen date: Displays the reopen date for the sale|  |
|stalledComment| *None* |Reason (stalled: The reason the sale has been stalled|  |
|saleTypeCategory| *None* |Sale type category: Sale type category|  |
|soldReason| *None* |Reason (sold: Reason (sold)|  |
|saleNumber| *None* |Number: Number|  |
|hasStakeholders| *None* |Has stakeholders: Does this sale have stakeholders|  |
|stakeholdersEnabled| *None* |Stakeholders enabled: Does this sale have stakeholders enabled|  |
|hasQuote| *None* |Has quote?: Does the sale have a quote attached?|  |
|hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|description| *None* |Description: The long description field on Sale|  |
|activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|createdByWorkflow| *None* |Created by flow: Created by flow|  |
|amountInBaseCurrency| *None* |Amount (BaseCurrency: The gross sales total|  |
|amountWeightedInBaseCurrency| *None* |Weighted amount (BaseCurrency: Virtual field calculated from amount * probability percent.|  |
|daysInStage| *None* |Days in stage: Total number of days in this stage|  |
|entityIcon| *None* |Row specific icon: Row specific icon| x |
|favouriteAssociateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|visibleFor| *None* |Visible for|  |
|sale/textId| *None* |Text ID|  |
|sale/description| *None* |Text: Displays the text entered in the description field|  |
|salePublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|salePublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|salePublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|salePublish/publishedBy| *None* |Published by: Published by|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|associate/isLocation| *None* |Is a location: Is a location|  |
|saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|saleUdef/SuperOffice:2| *None* |salelongtext|  |
|saleUdef/SuperOffice:3| *None* |salenumber|  |
|saleUdef/SuperOffice:4| *None* |saledate|  |
|saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|saleUdef/SuperOffice:8| *None* |saledecimal|  |
|name| *None* |Company name|  |
|department| *None* |Department|  |
|nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|category| *None* |Category|  |
|categoryGroup| *None* |Category group|  |
|companyCategoryRank| *None* |Category rank|  |
|business| *None* |Business|  |
|country| *None* |Country: This criterion corresponds to the Country field on the Company card.|  |
|countryId| *None* |Country ID: Country ID|  |
|number| *None* |Number|  |
|code| *None* |Code|  |
|orgnr| *None* |VAT No.|  |
|stop| *None* |Stop|  |
|contactNoMail| *None* |No mailings (company|  |
|contactSource| *None* |Source: Source (Company)|  |
|contactDeleted| *None* |Deleted: Deleted|  |
|phone/formattedNumber| *None* |Phone : Displays phone number|  |
|deletedDate| *None* |Deleted date: Deleted date|  |
|mainContact| *None* |Main contact: Main contact for this company|  |
|forceCompany| *None* |Dummy: Dummy|  |
|contactPhone/formattedNumber| *None* |Telephone - Phone: Displays phone number|  |
|contactPhone/description| *None* |Telephone - Description: Phone number description|  |
|contactFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|contactFax/description| *None* |Fax - Description: Phone number description|  |
|searchPhone/formattedNumber| *None* |Searchphone - Phone: Displays phone number|  |
|searchPhone/description| *None* |Searchphone - Description: Phone number description|  |
|email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|email/emailAddress| *None* |E-mail|  |
|email/emailDescription| *None* |Description|  |
|email/emailId| *None* |ID|  |
|email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|postAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|postAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|postAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|postAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|postAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|postAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|postAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|postAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|postAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|postAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|streetAddress/wgs84latitude| *None* |Street address - Latitude: Latitude|  |
|streetAddress/wgs84longitude| *None* |Street address - Longitude: Longitude|  |
|streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|url/URLAddress| *None* |URL|  |
|url/URLDescription| *None* |Description|  |
|contactAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|contactAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|contactAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|contactAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|contactAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|contactAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|contactAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contactAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|contactAssociate/associateDbId| *None* |ID|  |
|contactAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|contactAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|contactAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|contactAssociate/usergroupId| *None* |Group ID: The user's primary user group|  |
|contactAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|contactAssociate/contactCategory| *None* |Category: Category|  |
|contactAssociate/role| *None* |Role : Role|  |
|contactAssociate/assocName| *None* |User ID : User ID|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactAssociate/assocTooltip| *None* |Description : Description|  |
|contactAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|contactAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|contactAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactAssociate/ejDisplayName| *None* |Nickname: User's nickname in Service|  |
|contactAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|contactAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|contactAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contactAssociate/otherGroups| *None* |Other groups: Other groups|  |
|contactAssociate/userName| *None* |User name: User name|  |
|contactAssociate/personEmail| *None* |E-mail|  |
|contactAssociate/locationAddress| *None* |Location: Location|  |
|contactAssociate/isLocation| *None* |Is a location: Is a location|  |
|contactInterestIds| *None* |Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|contactUdef/SuperOffice:3| *None* |companynumber|  |
|contactUdef/SuperOffice:4| *None* |companydate|  |
|contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|contactUdef/SuperOffice:8| *None* |companydecimal|  |
|contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|contactExtra/x\_contact\_integer| *None* |Extra Integer: Custom integer field|  |
|contactExtra/x\_contact\_hidden\_integer| *None* |Extra hidden integer: Custom integer field - hidden|  |
|contactExtra/x\_contact\_default\_integer| *None* |Extra Default Integer: Custom integer field with default value 123.|  |
|contactExtra/x\_contact\_float| *None* |Extra Float: Custom float field with 3 decimals|  |
|contactExtra/x\_contact\_longtext| *None* |Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|contactExtra/x\_contact\_dropdown| *None* |Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|contactExtra/x\_contact\_date| *None* |Extra date: Custom date field. User current as default.|  |
|contactExtra/x\_contact\_datetime| *None* |Extra DateTime: Custom Date Time field. No default value. External|  |
|contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.|  |
|contactExtra/x\_contact\_boolean| *None* |Extra boolean: Custom boolean field.|  |
|contactExtra/x\_contact\_timespan| *None* |Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|contactExtra/x\_contact\_shorttext| *None* |Extra short text: Custom short text field. Keep HTML tags.|  |
|contactExtra/x\_contact\_short\_dropdown| *None* |Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|contactExtra/x\_contact\_contact\_relation| *None* |Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|contactExtra/x\_contact\_request\_relation| *None* |Extra Request relation: Request relation on company|  |
|contactExtra/x\_contact\_contact| *None* |Extra contact relation: Contact relation on company|  |
|contactExtra/y\_organization/x\_name| *None* |Organization - Name: Name|  |
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
|SaintStatus1| *None* |Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|SaintStatus2| *None* |C-company: Kundens navn starter med bokstaven C|  |
|saintSaleStatus| *None* |With status|  |
|saintAmountClass| *None* |Amount class|  |
|saintActivityType| *None* |SAINT type|  |
|saintDirection| *None* |Direction|  |
|saintIntention| *None* |Intention|  |
|saintTicketStatus| *None* |Status|  |
|saintTicketCategory| *None* |Category|  |
|firstName| *None* |First name: Displays the contact's first name|  |
|lastName| *None* |Last name: Displays the contact's last name|  |
|middleName| *None* |Middle name: Displays the contact's middle name.|  |
|fullName| *None* |Contact: Displays the contact to which an item is linked|  |
|fullNameWithContact| *None* |Contact and company: The fully formatted contact name, and full company name|  |
|personHasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|position| *None* |Position|  |
|personNumber| *None* |Number: Displays the contact's number|  |
|title| *None* |Title: Displays the contact's job title|  |
|personCountry| *None* |Country: Country|  |
|personCountryId| *None* |Country ID: Country ID|  |
|personNoMail| *None* |No Mailings: Displays the contact's No Mailings checkbox|  |
|rank| *None* |Rank: Displays a contact's current rank|  |
|birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|useAsMailingAddress| *None* |Use as postal address: Use as postal address|  |
|personSource| *None* |Source: Source (Contact)|  |
|retired| *None* |Former employee: Indicates whether the contact has retired/left the company|  |
|birthYear| *None* |Birth year: Displays contact's birth year|  |
|birthMonth| *None* |Birth month: Displays contact's birth month|  |
|birthDay| *None* |Birth day: Displays contact's birth day (day of month)|  |
|kanaFirstName| *None* |First name, kana: Contact's first name, in kana alphabet|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|kanaLastName| *None* |Last name, kana: Contact's last name, in kana alphabet|  |
|personUpdatedBy| *None* |Updated by: The user who last updated the data|  |
|personUpdatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|personUpdatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personRegisteredBy| *None* |Registered by: The user who registered the data|  |
|personRegisteredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|personRegisteredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|portraitThumbnail| *None* |Person image: Person image|  |
|personActiveErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|ticketPriority| *None* |Service priority: Default service priority for this contact|  |
|supportLanguage| *None* |Preferred language: Preferred language used for reply templates and more|  |
|supportAssociate| *None* |Our service contact: Default service contact for this contact|  |
|supportAssociateFullName| *None* |Our service contact - Full name: Default service contact for this contact|  |
|personAssociateId| *None* |Our contact: Displays our contact|  |
|personAssociateFullName| *None* |Our contact - Full name: Displays our contact|  |
|personCategory| *None* |Category|  |
|personCategoryGroup| *None* |Category group|  |
|personCategoryRank| *None* |!!Category rank|  |
|personBusiness| *None* |Business|  |
|leadStatus| *None* |Lead status|  |
|leadstatusRank| *None* |!!Lead status RANK|  |
|personDeletedDate| *None* |Deleted date: Deleted date|  |
|hasCompany| *None* |Has company: The contact is associated with a company|  |
|isProjectMember| *None* |Is project member: This person is a project member|  |
|isStakeholder| *None* |Is stakeholder: This person is a sale stakeholder|  |
|updatedByWorkflow| *None* |Updated by flow: Updated by flow|  |
|whenUpdatedByWorkflow| *None* |When updated by flow: When updated by flow|  |
|createdByForm| *None* |Created by form: Created by form|  |
|favouritePersonAssociateId| *None* |Associate ID: Associate ID|  |
|emailAddress| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|personDirectPhone/formattedNumber| *None* |Direct - Phone: Displays phone number|  |
|personDirectPhone/description| *None* |Direct - Description: Phone number description|  |
|personMobilePhone/formattedNumber| *None* |Mobile - Phone: Displays phone number|  |
|personMobilePhone/description| *None* |Mobile - Description: Phone number description|  |
|personPrivate/formattedNumber| *None* |Private - Phone: Displays phone number|  |
|personPrivate/description| *None* |Private - Description: Phone number description|  |
|personPager/formattedNumber| *None* |Other - Phone: Displays phone number|  |
|personPager/description| *None* |Other - Description: Phone number description|  |
|personDirectFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|personDirectFax/description| *None* |Fax - Description: Phone number description|  |
|personInfo/textId| *None* |Text ID|  |
|personInfo/infoText| *None* |Information: Displays the text entered in the description field|  |
|personUrl/URLAddress| *None* |URL|  |
|personUrl/URLDescription| *None* |Description|  |
|personAddress/addressId| *None* |Contact address - Address ID: Database ID for the address record|  |
|personAddress/line1| *None* |Contact address - Address 1: First line of the address|  |
|personAddress/line2| *None* |Contact address - Address 2: Second line of the address|  |
|personAddress/line3| *None* |Contact address - Address 3: Third line of the address|  |
|personAddress/county| *None* |Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personAddress/city| *None* |Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|personAddress/zip| *None* |Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personAddress/state| *None* |Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personAddress/wgs84latitude| *None* |Contact address - Latitude: Latitude|  |
|personAddress/wgs84longitude| *None* |Contact address - Longitude: Longitude|  |
|personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|personInterestIds| *None* |Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|personUdef/SuperOffice:1| *None* |contactshorttext: tooltipshorttext|  |
|personUdef/SuperOffice:2| *None* |contactlongtext: tooltiplongtext|  |
|personUdef/SuperOffice:3| *None* |contactnumber|  |
|personUdef/SuperOffice:4| *None* |contactdate|  |
|personUdef/SuperOffice:5| *None* |contactunlimiteddate: tooltipunlimiteddate|  |
|personUdef/SuperOffice:6| *None* |contactcheckbox|  |
|personUdef/SuperOffice:7| *None* |contactdropdownlistbox|  |
|personUdef/SuperOffice:8| *None* |contactdecimal|  |
|personUdef/SuperOffice:9| *None* |page1saleonly|  |
|personUdef/SuperOffice:10| *None* |page1marketingonly|  |
|personUdef/SuperOffice:11| *None* |page1adminonly|  |
|personExtra/x\_person\_integer| *None* |Extra Integer: Custom person integer|  |
|personExtra/x\_person\_hidden\_integer| *None* |Extra hidden integer: Custom integer field that is hidden|  |
|personExtra/x\_person\_float| *None* |Extra float: Custom float field|  |
|personExtra/x\_person\_longtext| *None* |Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|personExtra/x\_person\_date| *None* |Extra date: Custom date field on person. Default value = 28.03.2019|  |
|personExtra/x\_person\_datetime| *None* |Extra DateTime: Custom person date and time field. No default|  |
|personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default|  |
|personExtra/x\_person\_boolean| *None* |Extra Boolean: Custom boolean field on person. Default checked|  |
|personExtra/x\_person\_timespan| *None* |Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|personExtra/x\_person\_shorttext| *None* |Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|personExtra/x\_person\_shorttext\_list| *None* |Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|personExtra/x\_person\_user\_relation| *None* |Extra user relation: Custom person-user relation field|  |
|personExtra/x\_person\_category\_relation| *None* |Extra category relation: Custom person-category relation|  |
|personExtra/x\_person\_priority\_relation| *None* |Extra priority relation: Custom person-priority relation|  |
|personExtra/x\_person\_request\_relation| *None* |Extra request relation: Request relation on contact|  |
|personExtra/x\_person\_appointment\_relation| *None* |Extra appointment relation: Appointment relation on person|  |
|personExtra/x\_person\_contact\_relation| *None* |Extra company relation: Company relation on contact|  |
|personExtra/y\_rental/id| *None* |Rental - id: Displays the row's primary key (y\_rental)|  |
|personExtra/y\_rental/x\_start| *None* |Rental - Start rental: Start rental|  |
|personExtra/y\_rental/x\_end| *None* |Rental - End: End|  |
|personExtra/y\_rental/x\_amount| *None* |Rental - Amount: Number to rent. Default = 1|  |
|personExtra/y\_rental/x\_contact| *None* |Rental - Renter: Company that rents equipment|  |
|personExtra/y\_rental/y\_equipment/x\_name| *None* |Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|personExtra/y\_car/id| *None* |Car - id: Displays the row's primary key (y\_car)|  |
|personAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|personAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|personAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|personAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|personAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|personAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|personAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAssociate/associateDbId| *None* |ID|  |
|personAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|personAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|personAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|personAssociate/usergroupId| *None* |Group ID: The user's primary user group|  |
|personAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|personAssociate/contactCategory| *None* |Category: Category|  |
|personAssociate/role| *None* |Role : Role|  |
|personAssociate/assocName| *None* |User ID : User ID|  |
|personAssociate/assocTooltip| *None* |Description : Description|  |
|personAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|personAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|personAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAssociate/ejDisplayName| *None* |Nickname: User's nickname in Service|  |
|personAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|personAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|personAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|personAssociate/otherGroups| *None* |Other groups: Other groups|  |
|personAssociate/userName| *None* |User name: User name|  |
|personAssociate/personEmail| *None* |E-mail|  |
|personAssociate/locationAddress| *None* |Location: Location|  |
|personAssociate/isLocation| *None* |Is a location: Is a location|  |
|correspondingAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|correspondingAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|correspondingAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|correspondingAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|correspondingAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|correspondingAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|correspondingAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|correspondingAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|correspondingAssociate/associateDbId| *None* |ID|  |
|correspondingAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|correspondingAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|correspondingAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|correspondingAssociate/usergroupId| *None* |Group ID: The user's primary user group|  |
|correspondingAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|correspondingAssociate/contactCategory| *None* |Category: Category|  |
|correspondingAssociate/role| *None* |Role : Role|  |
|correspondingAssociate/assocName| *None* |User ID : User ID|  |
|correspondingAssociate/assocTooltip| *None* |Description : Description|  |
|correspondingAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|correspondingAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|correspondingAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|correspondingAssociate/ejDisplayName| *None* |Nickname: User's nickname in Service|  |
|correspondingAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|correspondingAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|correspondingAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|correspondingAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|correspondingAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|correspondingAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|correspondingAssociate/otherGroups| *None* |Other groups: Other groups|  |
|correspondingAssociate/userName| *None* |User name: User name|  |
|correspondingAssociate/personEmail| *None* |E-mail|  |
|correspondingAssociate/locationAddress| *None* |Location: Location|  |
|correspondingAssociate/isLocation| *None* |Is a location: Is a location|  |
|isMailingRecipient| *None* |Is mailing recipient: isMailingRecipient|  |
|hasStoreConsent| *None* |Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|withdrawnStoreConsent| *None* |Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|hasEmarketingConsent| *None* |Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|withdrawnEmarketingConsent| *None* |Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|subscription| *None* |Subscription: Subscription for marketing|  |
|legalBaseStore| *None* |Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|legalBaseEmarketing| *None* |Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|consentSourceStore| *None* |Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|consentSourceEmarketing| *None* |Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|status| *None* |Status: Displays the project's status|  |
|statusRank| *None* |Status rank: Rank of the project status in the status list|  |
|nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|endDate| *None* |End date: End date of project|  |
|imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|project/textId| *None* |Text ID|  |
|project/infoText| *None* |Information: Displays the text entered in the description field|  |
|selectionId| *None* |Selection ID: The database ID of the selection|  |
|kind| *None* |Selection is : The kind of selection (static, dynamic or combined)|  |
|targetTableNumber| *None* |Selection of: Displays what the selection consists of|  |
|combinationType| *None* |Combination type: Displays the combination type for a selection|  |
|done| *None* |Completed: Shows whether the selection has been completed|  |
|lastLoaded| *None* |Last used: When was the result list for the selection last shown|  |
|lastLoadedBy| *None* |Last used by: Who was the last person to show the result list for the selection|  |
|lastLoadedByFullName| *None* |Last used by - Full name: Who was the last person to show the result list for the selection|  |
|lastMembershipChange| *None* |Members changed: When was the result list for the selection last changed, for instance due to a change in the criteria|  |
|lastMembershipChangeBy| *None* |Members changed by: Who was the last person to change the result list for the selection, for instance by changing the criteria|  |
|lastMembershipChangeByFullName| *None* |Members changed by - Full name: Who was the last person to change the result list for the selection, for instance by changing the criteria|  |
|memberCount| *None* |Members: How many members were in the selection, the last time all were fetched. May be imprecise/outdated.|  |
|selectionAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|selectionAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|selectionAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|selectionAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|selectionAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|selectionAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|selectionAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|selectionAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|selectionAssociate/associateDbId| *None* |ID|  |
|selectionAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|selectionAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|selectionAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|selectionAssociate/usergroupId| *None* |Group ID: The user's primary user group|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|selectionAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|selectionAssociate/contactCategory| *None* |Category: Category|  |
|selectionAssociate/role| *None* |Role : Role|  |
|selectionAssociate/assocName| *None* |User ID : User ID|  |
|selectionAssociate/assocTooltip| *None* |Description : Description|  |
|selectionAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|selectionAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|selectionAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|selectionAssociate/ejDisplayName| *None* |Nickname: User's nickname in Service|  |
|selectionAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|selectionAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|selectionAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|selectionAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|selectionAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|selectionAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|selectionAssociate/otherGroups| *None* |Other groups: Other groups|  |
|selectionAssociate/userName| *None* |User name: User name|  |
|selectionAssociate/personEmail| *None* |E-mail|  |
|selectionAssociate/locationAddress| *None* |Location: Location|  |
|selectionAssociate/isLocation| *None* |Is a location: Is a location|  |
|mailingId| *None* |ID: Displays the ID of the mailing|  |
|mailingSelectionId| *None* |Selection ID: The database ID of the selection|  |
|mailingDescription| *None* |Name: Displays the name of the mailing|  |
|mailingSent| *None* |Sent: Displays the sent status of the mailing|  |
|mailingSimpleStatus| *None* |Status: Status|  |
|mailingEndDate| *None* |Date sent: Displays the date when the mailing was sent (completed)|  |
|mailingType| *None* |Type: Display the type of the mailing|  |
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
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|documentId| *None* |Document ID: Database ID of document record|  |
|keywords| *None* |Keywords |  |
|ourref| *None* |Our ref.|  |
|yourref| *None* |Your ref.|  |
|attention| *None* |Salutation|  |
|subject| *None* |Subject|  |
|mailMergeDraft| *None* |Mail merge draft : Indicates whether the document is a mail merge template|  |
|snum| *None* |Document number: Serial number of document. It can be generated by the number allocation system for a dedicated document template.|  |
|isReport| *None* |Report: Is this document a saved report run?|  |
|suggestedDocumentId| *None* |Document ID (suggestion: The database ID of a document that originates in a suggestion|  |
|isMail| *None* |E-mail|  |
|documentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|documentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|documentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|documentPublish/publishedBy| *None* |Published by: Published by|  |
|documentUdef/SuperOffice:1| *None* |documentshorttext|  |
|documentUdef/SuperOffice:2| *None* |documentlongtext|  |
|documentUdef/SuperOffice:3| *None* |documentnumber|  |
|documentUdef/SuperOffice:4| *None* |documentdate|  |
|documentUdef/SuperOffice:5| *None* |documentunlimiteddate|  |
|documentUdef/SuperOffice:6| *None* |documentcheckbox|  |
|documentUdef/SuperOffice:7| *None* |documentdropdownlistbox|  |
|documentUdef/SuperOffice:8| *None* |documentdecimal|  |
|document/textId| *None* |Text ID|  |
|document/description| *None* |Text: Displays the text entered in the description field|  |
|appointmentId| *None* |DB ID: Displays the database ID of a row|  |
|priority| *None* |Priority: Displays the priority of the activity|  |
|alarm| *None* |Has alarm: Displays the alarm state of a follow-up|  |
|isFree| *None* |Is free: Displays whether the appointment should be considered free or busy|  |
|recurring| *None* |Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up|  |
|booking| *None* |Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.|  |
|intention| *None* |Intention: Displays the intention of the follow-up type|  |
|location| *None* |Location: Display the location where the follow-up will take place.|  |
|recurrenceRuleId| *None* |RR-ID: Repetition rule ID of follow-up|  |
|rawType| *None* |Type: Type field for appointment, not decoded or formatted|  |
|rawStatus| *None* |Status: Status field for the follow-up, not decoded or formatted|  |
|cautionWarning| *None* |Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.|  |
|visibleInDiary| *None* |ExcludeBook: Is the activity visible in the diary?|  |
|endTime| *None* |End time: End time of an activity|  |
|suggestedAppointmentId| *None* |Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion|  |
|completedDate| *None* |Completed date: Displays the actual date a follow-up/sale was marked as completed|  |
|isMilestone| *None* |Milestone: Shows whether or not the follow-ups in this row are milestones|  |
|invitedPersonId| *None* |ID of invited person: appointment.invitedpersonid record - utility for rd|  |
|joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting|  |
|duration| *None* |Duration: The duration of the chat session|  |
|appointmentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|appointmentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|appointmentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|appointmentUdef/SuperOffice:1| *None* |followupshorttext|  |
|appointmentUdef/SuperOffice:2| *None* |followuplongtext|  |
|appointmentUdef/SuperOffice:3| *None* |followupnumber|  |
|appointmentUdef/SuperOffice:4| *None* |followupdate|  |
|appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate|  |
|appointmentUdef/SuperOffice:6| *None* |followupcheckbox|  |
|appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox|  |
|appointmentUdef/SuperOffice:8| *None* |followupdecimal|  |
|appointment/description| *None* |Text: Displays the text entered in the description field|  |
|appointment/title| *None* |Title|  |
|appointment/titleHtml| *None* |!!Title Html|  |
|appointment/agenda| *None* |Agenda|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/agendaHtml| *None* |!!Agenda Html|  |
|appointment/isConverted| *None* |!!Is Converted|  |
|appointment/textId| *None* |Text ID|  |
|appointment/internalNotes| *None* |Internal notes: Displays the text entered in the description field|  |
|appointment/internalNotesHtml| *None* |!!Internal Notes Html|  |
|ticketStatusId| *None* |Status ID: Status|  |
|priorityId| *None* |Priority ID: ID of priority in database|  |
|categoryId| *None* |Category ID: ID of ticket category in database|  |
|ticketTypeName| *None* |Request type: Request type|  |
|ticketStatusName| *None* |Status: Request status|  |
|categoryFullName| *None* |Category: Request category|  |
|priorityName| *None* |Priority: Service priority|  |
|ownedBy| *None* |Owner: The owner of the request|  |
|ticketId| *None* |ID: Displays request ID|  |
|createdAt| *None* |Created: Displays when the request was created|  |
|lastChanged| *None* |Last changed: Displays when the request was last changed|  |
|author| *None* |Author: Displays the author of the request|  |
|readByOwner| *None* |Read by owner: Displays when the request was read by the owner|  |
|firstReadByOwner| *None* |First read by owner: Displays when the request was read by owner for the first time|  |
|firstReadByUser| *None* |First read by user: Displays when the request was read by user for the first time|  |
|readByCustomer| *None* |Read by contact: Displays when the request was read by the contact|  |
|origin| *None* |Origin: Origin|  |
|slevel| *None* |Access level: Access level|  |
|numberOfMessages| *None* |Number of messages: Number of messages|  |
|numberOfReplies| *None* |Number of replies: Number of replies|  |
|connectId| *None* |Merged with request: Merged with request|  |
|readStatus| *None* |Read: Read|  |
|realTimeSpentQueue| *None* |Real time in queue: Real time in queue|  |
|realTimeSpentExternally| *None* |Real time externally: Real time externally|  |
|realTimeSpentInternally| *None* |Real time internally: Real time internally|  |
|timeSpentQueue| *None* |Time spent in queue: Time spent in queue|  |
|timeSpentExternally| *None* |Time spent externally: Time spent externally|  |
|timeSpentInternally| *None* |Time spent internally: Time spent internally|  |
|timeSpent| *None* |Time spent: Time spent|  |
|timeToReply| *None* |Time to reply: Time to reply|  |
|timeToClose| *None* |Time to close: Time to close|  |
|realTimeToReply| *None* |Real time to reply: Real time to reply|  |
|realTimeToClose| *None* |Real time to close: Real time to close|  |
|repliedAt| *None* |Replied at: Replied at|  |
|closedAt| *None* |Closed at: Closed at|  |
|activated| *None* |Postponed to: Postponed to|  |
|deadline| *None* |Deadline: Deadline|  |
|has\_attachment| *None* |Has attachment: Indicates whether the e-mail has one or more attachments|  |
|tags| *None* |Tags: Tags connected to a request|  |
|createdBy| *None* |Created by: Created by|  |
|content| *None* |Content: Search for content in messages related to requests|  |
|messageLanguage| *None* |Language: Recognized language in messages|  |
|sentimentScore| *None* |Sentiment: Sentiment score, -100 to +100|  |
|sentimentConfidence| *None* |Sentiment confidence: Sentiment confidence|  |
|suggestedCategory| *None* |Suggested category: Suggested service category|  |
|createdBy/firstName| *None* |Created by - First name: Displays the contact's first name|  |
|createdBy/lastName| *None* |Created by - Last name: Displays the contact's last name|  |
|createdBy/middleName| *None* |Created by - Middle Name: Displays the contact's middle name.|  |
|createdBy/fullName| *None* |Created by - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|createdBy/contactId| *None* |Created by - Company ID: Database ID of the company the user belongs to|  |
|createdBy/personId| *None* |Created by - Contact ID: Database ID of the contact row|  |
|createdBy/mrMrs| *None* |Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|createdBy/title| *None* |Created by - Title: Displays whether the contact is addressed as Mr or Ms|  |
|createdBy/associateDbId| *None* |Created by - ID|  |
|createdBy/contactName| *None* |Created by - Owning company: Name of the company the user belongs to|  |
|createdBy/contactDepartment| *None* |Created by - Owning department: Name of the department at the company the user belongs to|  |
|createdBy/usergroup| *None* |Created by - Primary group: The user's primary user group|  |
|createdBy/usergroupId| *None* |Created by - Group ID: The user's primary user group|  |
|createdBy/contactFullName| *None* |Created by - Owner: Name and department of the company the user belongs to|  |
|createdBy/contactCategory| *None* |Created by - Category: Category|  |
|createdBy/role| *None* |Created by - Role: Role|  |
|createdBy/assocName| *None* |Created by - User ID: User ID|  |
|createdBy/assocTooltip| *None* |Created by - Description: Description|  |
|createdBy/assocType| *None* |Created by - Type: Type of user: associate, external user, system user, anonymous account|  |
|createdBy/ejUserId| *None* |Created by - Service user ID: The database ID of a Service user|  |
|createdBy/simultaneousEjUser| *None* |Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|createdBy/ejDisplayName| *None* |Created by - Nickname: User's nickname in Service|  |
|createdBy/ejStatus| *None* |Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in|  |
|createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|createdBy/isActive| *None* |Created by - Active: Is this user active, and should be able to log in?|  |
|createdBy/isActiveText| *None* |Created by - Active status: Is this user active, and should be able to log in?|  |
|createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|createdBy/otherGroups| *None* |Created by - Other groups: Other groups|  |
|createdBy/userName| *None* |Created by - User name: User name|  |
|createdBy/personEmail| *None* |Created by - E-mail|  |
|createdBy/locationAddress| *None* |Created by - Location: Location|  |
|createdBy/isLocation| *None* |Created by - Is a location: Is a location|  |
|ownedBy/firstName| *None* |Owner - First name: Displays the contact's first name|  |
|ownedBy/lastName| *None* |Owner - Last name: Displays the contact's last name|  |
|ownedBy/middleName| *None* |Owner - Middle Name: Displays the contact's middle name.|  |
|ownedBy/fullName| *None* |Owner - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|ownedBy/contactId| *None* |Owner - Company ID: Database ID of the company the user belongs to|  |
|ownedBy/personId| *None* |Owner - Contact ID: Database ID of the contact row|  |
|ownedBy/mrMrs| *None* |Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|ownedBy/title| *None* |Owner - Title: Displays whether the contact is addressed as Mr or Ms|  |
|ownedBy/associateDbId| *None* |Owner - ID|  |
|ownedBy/contactName| *None* |Owner - Owning company: Name of the company the user belongs to|  |
|ownedBy/contactDepartment| *None* |Owner - Owning department: Name of the department at the company the user belongs to|  |
|ownedBy/usergroup| *None* |Owner - Primary group: The user's primary user group|  |
|ownedBy/usergroupId| *None* |Owner - Group ID: The user's primary user group|  |
|ownedBy/contactFullName| *None* |Owner - Owner: Name and department of the company the user belongs to|  |
|ownedBy/contactCategory| *None* |Owner - Category: Category|  |
|ownedBy/role| *None* |Owner - Role: Role|  |
|ownedBy/assocName| *None* |Owner - User ID: User ID|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownedBy/assocTooltip| *None* |Owner - Description: Description|  |
|ownedBy/assocType| *None* |Owner - Type: Type of user: associate, external user, system user, anonymous account|  |
|ownedBy/ejUserId| *None* |Owner - Service user ID: The database ID of a Service user|  |
|ownedBy/simultaneousEjUser| *None* |Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ownedBy/ejDisplayName| *None* |Owner - Nickname: User's nickname in Service|  |
|ownedBy/ejStatus| *None* |Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in|  |
|ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|ownedBy/isActive| *None* |Owner - Active: Is this user active, and should be able to log in?|  |
|ownedBy/isActiveText| *None* |Owner - Active status: Is this user active, and should be able to log in?|  |
|ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|ownedBy/otherGroups| *None* |Owner - Other groups: Other groups|  |
|ownedBy/userName| *None* |Owner - User name: User name|  |
|ownedBy/personEmail| *None* |Owner - E-mail|  |
|ownedBy/locationAddress| *None* |Owner - Location: Location|  |
|ownedBy/isLocation| *None* |Owner - Is a location: Is a location|  |
|ticketStatus/ticketStatusId| *None* |Status - ID: Displays request status ID|  |
|ticketStatus/name| *None* |Status - Name: Displays the name of the request status|  |
|ticketStatus/rank| *None* |Status - Status rank: Sort order of the status in the ticket status list|  |
|ticketPriority/ticketPriorityId| *None* |Priority - ID: Displays the ID of the priority|  |
|ticketPriority/name| *None* |Priority - Name: Displays the name of the priority|  |
|ticketPriority/rank| *None* |Priority - Priority rank: Sort order of priority in the priority list|  |
|extra/x\_ticket\_integer| *None* |Extra integer: Custom ticket integer. Default 123. External. Show in properties|  |
|extra/x\_ticket\_float| *None* |Extra float: Custom float on Request. 2 decimal places|  |
|extra/x\_ticket\_longtext| *None* |Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props|  |
|extra/x\_ticket\_date| *None* |Extra date: Custom date field on Request. No default value|  |
|extra/x\_ticket\_datetime| *None* |Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request|  |
|extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.|  |
|extra/x\_ticket\_boolean| *None* |Extra boolean: Custom boolean on Ticket.|  |
|extra/x\_ticket\_timespan| *None* |Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props|  |
|extra/x\_ticket\_short\_text| *None* |Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request|  |
|extra/x\_ticket\_shorttext\_list| *None* |Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot|  |
|extra/x\_ticket\_timestamp| *None* |Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field|  |
|extra/x\_ticket\_project\_relation| *None* |Extra project: Custom project relation on Request|  |
|extra/x\_ticket\_faq| *None* |Extra FAQ Relation: Extra FAQ Relation|  |
|extra/x\_ticket\_category\_relation| *None* |Extra category relation: Category relation on request|  |
|extra/y\_equipment/x\_name| *None* |Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|extra/y\_car/id| *None* |Car - id: Displays the row's primary key (y\_car)|  |

## Sample

```http!
GET /api/v1/archive/Favourites?$select=salePublish/publishedBy,retired,personUdef/SuperOffice:3,project/completed,appointmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

