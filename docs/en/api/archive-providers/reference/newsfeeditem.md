---
uid: NewsFeedItem
title: NewsFeedItem
description: Archive provider for the user's list of newsfeed items. Handled and expired items are filtered out of the list.
keywords: NewsFeedItem archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "NewsFeedItem"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.NewsFeedItemProvider">SuperOffice.CRM.ArchiveLists.NewsFeedItemProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the user's list of newsfeed items. Handled and expired items are filtered out of the list.


Name: "NewsFeedItem"


Entity name: "newsfeeditem"

## Supported Entities
| Name | Description |
| ---- | ----- |
|"newsfeeditem"|NewsFeedItem|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|newsFeedItemId|int|Id: Primary key| x |
|title|string|Title: Headline| x |
|summary|string|Summary: Short text| x |
|fromName|string|From: Sender's name| x |
|fromCategory|string|Category: Sender's category| x |
|sourceLink|string|Source link: Link to source material| x |
|imageLink|string|Image link: Link to image| x |
|previewHint|string|Preview hint: Preview hint| x |
|status|listAny|Status: Newsfeed item processing status| x |
|priority|listAny|Priority: Newsfeed item priority – how important an item is| x |
|expiresAt|datetime|Expires at: When the newsfeed item is no longer relevant and can be hidden| x |
|applicationId|string|Application ID: Application ID| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contact/contactId|int|Company - Company ID: Database ID of company| x |
|contact/name|stringorPK|Company - Company name| x |
|contact/department|string|Company - Department| x |
|contact/nameDepartment|string|Company - Company: Displays the company an activity is linked to| x |
|contact/hasInfoText|bool|Company - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|contact/hasInterests|bool|Company - Has interests: Displays an Icon indicating if the contact has active interests| x |
|contact/associateId|associate|Company - Our contact: Displays our contact| x |
|contact/category|listAny|Company - Category| x |
|contact/categoryGroup|listAny|Company - Category group| x |
|contact/companyCategoryRank|int|Company - Category rank| x |
|contact/business|listAny|Company - Business| x |
|contact/country|listAny|Company - Country: This criterion corresponds to the Country field on the Company card.| x |
|contact/countryId|int|Company - Country ID: Country ID| x |
|contact/number|string|Company - Number| x |
|contact/code|string|Company - Code| x |
|contact/orgnr|string|Company - VAT No.| x |
|contact/stop|bool|Company - Stop| x |
|contact/contactNoMail|bool|Company - No mailings (company)| x |
|contact/updatedBy|associate|Company - Updated by: The user who last updated the data| x |
|contact/updatedByFullName|associate|Company - Updated by - Full name: The user who last updated the data| x |
|contact/updatedDate|date|Company - Updated: The date/time the data was last updated in UTC.| x |
|contact/registeredBy|associate|Company - Registered by: The user who registered the data| x |
|contact/registeredByFullName|associate|Company - Registered by - Full name: The user who registered the data| x |
|contact/registeredDate|date|Company - Registered date: The date/time the data was registered in UTC.| x |
|contact/contactSource|listAny|Company - Source: Source (Company)| x |
|contact/contactDeleted|bool|Company - Deleted: Deleted| x |
|contact/activeErpLinks|bool|Company - ERP connected: Is there an active ERP Sync?| x |
|contact/deletedDate|datetime|Company - Deleted date: Deleted date|  |
|contact/mainContact| *None* |Company - Main contact: Main contact for this company| x |
|contact/forceCompany|bool|Company - Dummy: Dummy|  |
|contact/email/emailProtocol|string|Company - Protocol: E-mail protocol, such as SMTP| x |
|contact/email/emailAddress|string|Company - E-mail| x |
|contact/email/emailDescription|string|Company - Description| x |
|contact/email/emailId|int|Company - ID| x |
|contact/email/emailLastSent|datetime|Company - Last sent: The date and time an e-mail was last sent to this address| x |
|contact/email/emailBounceCount|int|Company - Bounce count: Bounce count for this e-mail address| x |
|contact/email/emailLastBounce|datetime|Company - Last bounce: Date and time for last bounce to this e-mail address| x |
|contact/email/emailHasBounced|bool|Company - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|contact/postAddress/addressId|int|Company - Postal address - Address ID: Database ID for the address record| x |
|contact/postAddress/line1|string|Company - Postal address - Address 1: First line of the address| x |
|contact/postAddress/line2|string|Company - Postal address - Address 2: Second line of the address| x |
|contact/postAddress/line3|string|Company - Postal address - Address 3: Third line of the address| x |
|contact/postAddress/county|string|Company - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|contact/postAddress/city|string|Company - Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|contact/postAddress/zip|string|Company - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|contact/postAddress/state|string|Company - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|contact/postAddress/wgs84latitude|decimal|Company - Postal address - Latitude: Latitude| x |
|contact/postAddress/wgs84longitude|decimal|Company - Postal address - Longitude: Longitude| x |
|contact/postAddress/formattedAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |Company - Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/addressId|int|Company - Street address - Address ID: Database ID for the address record| x |
|contact/streetAddress/line1|string|Company - Street address - Address 1: First line of the address| x |
|contact/streetAddress/line2|string|Company - Street address - Address 2: Second line of the address| x |
|contact/streetAddress/line3|string|Company - Street address - Address 3: Third line of the address| x |
|contact/streetAddress/county|string|Company - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|contact/streetAddress/city|string|Company - Street address - City: This criterion corresponds to the City field on the Company card.| x |
|contact/streetAddress/zip|string|Company - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|contact/streetAddress/state|string|Company - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|contact/streetAddress/wgs84latitude|decimal|Company - Street address - Latitude: Latitude| x |
|contact/streetAddress/wgs84longitude|decimal|Company - Street address - Longitude: Longitude| x |
|contact/streetAddress/formattedAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/formattedMultiLineAddress| *None* |Company - Street address - {formattedAddress}: {formattedAddress}|  |
|contact/url/URLAddress|string|Company - URL| x |
|contact/url/URLDescription|string|Company - Description| x |
|person/personId|int|Contact - DB ID: Displays the database ID of a contact| x |
|person/firstName|string|Contact - First name: Displays the contact's first name| x |
|person/lastName|string|Contact - Last name: Displays the contact's last name| x |
|person/middleName|string|Contact - Middle name: Displays the contact's middle name.| x |
|person/fullName|string|Contact - Contact: Displays the contact to which an item is linked| x |
|person/contactId|int|Contact - Company ID: Database ID of company| x |
|person/hasInfoText|bool|Contact - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|person/hasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/personHasInterests|bool|Contact - Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/mrMrs|string|Contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/position|listAny|Contact - Position| x |
|person/personNumber|string|Contact - Number: Displays the contact's number| x |
|person/title|string|Contact - Title: Displays the contact's job title| x |
|person/personCountry|listAny|Contact - Country: Country| x |
|person/personCountryId|int|Contact - Country ID: Country ID| x |
|person/personNoMail|bool|Contact - No Mailings: Displays the contact's No Mailings checkbox| x |
|person/rank|int|Contact - Rank: Displays a contact's current rank| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|person/personUpdatedByFullName|associate|Contact - Updated by - Full name: The user who last updated the data| x |
|person/personUpdatedDate|date|Contact - Updated: The date/time the data was last updated in UTC.| x |
|person/personRegisteredBy|associate|Contact - Registered by: The user who registered the data| x |
|person/personRegisteredByFullName|associate|Contact - Registered by - Full name: The user who registered the data| x |
|person/personRegisteredDate|date|Contact - Registered date: The date/time the data was registered in UTC.| x |
|person/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|person/personActiveErpLinks|bool|Contact - ERP connected: Is there an active ERP Sync?| x |
|person/ticketPriority|listAny|Contact - Service priority: Default service priority for this contact| x |
|person/supportLanguage|listAny|Contact - Preferred language: Preferred language used for reply templates and more| x |
|person/supportAssociate|associate|Contact - Our service contact: Default service contact for this contact| x |
|person/supportAssociateFullName|associate|Contact - Our service contact - Full name: Default service contact for this contact| x |
|person/personAssociateId|associate|Contact - Our contact: Displays our contact| x |
|person/personAssociateFullName|associate|Contact - Our contact - Full name: Displays our contact| x |
|person/personCategory|listAny|Contact - Category| x |
|person/personCategoryGroup|listAny|Contact - Category group| x |
|person/personCategoryRank|int|Contact - !!Category rank| x |
|person/personBusiness|listAny|Contact - Business| x |
|person/leadStatus|listAny|Contact - Lead status| x |
|person/leadstatusRank|int|Contact - !!Lead status RANK| x |
|person/personDeletedDate|datetime|Contact - Deleted date: Deleted date|  |
|person/hasCompany|bool|Contact - Has company: The contact is associated with a company| x |
|person/isProjectMember|bool|Contact - Is project member: This person is a project member| x |
|person/isStakeholder|bool|Contact - Is stakeholder: This person is a sale stakeholder| x |
|person/updatedByWorkflow|listAny|Contact - Updated by flow: Updated by flow| x |
|person/whenUpdatedByWorkflow|datetime|Contact - When updated by flow: When updated by flow| x |
|person/createdByForm|listAny|Contact - Created by form: Created by form| x |
|person/phone/formattedNumber|string|Contact - Phone: Displays phone number|  |
|person/personDirectPhone/formattedNumber|string|Contact - Direct - Phone: Displays phone number|  |
|person/personDirectPhone/description|string|Contact - Direct - Description: Phone number description| x |
|person/personMobilePhone/formattedNumber|string|Contact - Mobile - Phone: Displays phone number|  |
|person/personMobilePhone/description|string|Contact - Mobile - Description: Phone number description| x |
|person/personPrivate/formattedNumber|string|Contact - Private - Phone: Displays phone number|  |
|person/personPrivate/description|string|Contact - Private - Description: Phone number description| x |
|person/personPager/formattedNumber|string|Contact - Other - Phone: Displays phone number|  |
|person/personPager/description|string|Contact - Other - Description: Phone number description| x |
|person/personDirectFax/formattedNumber|string|Contact - Fax - Phone: Displays phone number|  |
|person/personDirectFax/description|string|Contact - Fax - Description: Phone number description| x |
|person/email/emailProtocol|string|Contact - Protocol: E-mail protocol, such as SMTP| x |
|person/email/emailAddress|string|Contact - E-mail| x |
|person/email/emailDescription|string|Contact - Description| x |
|person/email/emailId|int|Contact - ID| x |
|person/email/emailLastSent|datetime|Contact - Last sent: The date and time an e-mail was last sent to this address| x |
|person/email/emailBounceCount|int|Contact - Bounce count: Bounce count for this e-mail address| x |
|person/email/emailLastBounce|datetime|Contact - Last bounce: Date and time for last bounce to this e-mail address| x |
|person/email/emailHasBounced|bool|Contact - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|person/personUrl/URLAddress|string|Contact - URL| x |
|person/personUrl/URLDescription|string|Contact - Description| x |
|person/personAddress/addressId|int|Contact - Contact address - Address ID: Database ID for the address record| x |
|person/personAddress/line1|string|Contact - Contact address - Address 1: First line of the address| x |
|person/personAddress/line2|string|Contact - Contact address - Address 2: Second line of the address| x |
|person/personAddress/line3|string|Contact - Contact address - Address 3: Third line of the address| x |
|person/personAddress/county|string|Contact - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|person/personAddress/city|string|Contact - Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|person/personAddress/zip|string|Contact - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|person/personAddress/state|string|Contact - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|person/personAddress/wgs84latitude|decimal|Contact - Contact address - Latitude: Latitude| x |
|person/personAddress/wgs84longitude|decimal|Contact - Contact address - Longitude: Longitude| x |
|person/personAddress/formattedAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|person/personAddress/formattedMultiLineAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|project/completed|bool|Project - Completed: Displays a check mark indicating if the project has been completed.| x |
|project/projectId|int|Project - DB ID: Displays the database ID for a project row| x |
|project/name|stringorPK|Project - Project name: Displays the Project's name| x |
|project/number|string|Project - Number: Displays the project's number| x |
|project/type|listAny|Project - Project type: Displays the project's type| x |
|project/status|listAny|Project - Status: Displays the project's status| x |
|project/statusRank| *None* |Project - Status rank: Rank of the project status in the status list| x |
|project/associateId|associate|Project - ID: Displays login ID of the associate who owns the project| x |
|project/hasInfoText|bool|Project - Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|project/icon| *None* |Project - Category: Displays the icon for an activity type| x |
|project/text|string|Project - Text: Displays a descriptive text for the item| x |
|project/description|string|Project - Description: Description| x |
|project/updatedBy|associate|Project - Updated by: The user who last updated the data| x |
|project/updatedByFullName|associate|Project - Updated by - Full name: The user who last updated the data| x |
|project/updatedDate|date|Project - Updated: The date/time the data was last updated in UTC.| x |
|project/registeredBy|associate|Project - Registered by: The user who registered the data| x |
|project/registeredByFullName|associate|Project - Registered by - Full name: The user who registered the data| x |
|project/registeredDate|date|Project - Registered date: The date/time the data was registered in UTC.| x |
|project/hasGuide|bool|Project - Guided: Does this sale have a Sales Guide| x |
|project/nextMilestone|date|Project - Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|project/endDate|date|Project - End date: End date of project| x |
|project/imageThumbnail| *None* |Project - Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks|bool|Project - ERP connected: Is there an active ERP Sync?| x |
|project/eventId|int|Project - Event ID: Event ID| x |
|project/startDate|date|Project - Start date: Project start date| x |
|project/projectUrl/URLAddress|string|Project - URL| x |
|project/projectUrl/URLDescription|string|Project - Description| x |
|project/project/textId|int|Project - Text ID| x |
|project/project/infoText|positiveString|Project - Information: Displays the text entered in the description field| x |
|sale/completed|bool|Sale - Completed: Displays a checkbox showing if an appointment is completed| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/icon|listAny|Sale - Category: Displays the icon for an activity type| x |
|sale/date|date|Sale - Date: Displays start date of a follow-up / sale date of a sale| x |
|sale/time| *None* |Sale - Time: Time|  |
|sale/type|listAny|Sale - Type: Displays the type of an activity| x |
|sale/recordType|string|Sale - Record type: Shows the record type| x |
|sale/text|positiveString|Sale - Text: Displays a descriptive text for the item| x |
|sale/associateId|associate|Sale - ID: Displays the login ID of the associate who owns the activity.| x |
|sale/contactId|listAny|Sale - Company ID: Database ID of company| x |
|sale/personId|listAny|Sale - Contact ID: Database ID of the contact row| x |
|sale/projectId|listAny|Sale - Project ID: Database ID of project record| x |
|sale/saleId|int|Sale - Sale ID: The database ID of the sale record| x |
|sale/userGroup|userGroup|Sale - User group: The user group that owns the record| x |
|sale/who| *None* |Sale - Who: Contact and/or company|  |
|sale/updatedBy|associate|Sale - Updated by: The user who last updated the data| x |
|sale/updatedByFullName|associate|Sale - Updated by - Full name: The user who last updated the data| x |
|sale/updatedDate|date|Sale - Updated: The date/time the data was last updated in UTC.| x |
|sale/registeredBy|associate|Sale - Registered by: The user who registered the data| x |
|sale/registeredByFullName|associate|Sale - Registered by - Full name: The user who registered the data| x |
|sale/registeredDate|date|Sale - Registered date: The date/time the data was registered in UTC.| x |
|sale/currencyId|int|Sale - Currency ID: The currency list item ID| x |
|sale/currency|listAny|Sale - Currency: The currency of the sale| x |
|sale/credited|listAny|Sale - Credited: The user to be credited with the sale| x |
|sale/lossReason|listAny|Sale - Reason (lost): The reason for losing the sale| x |
|sale/source|listAny|Sale - Source: The source (lead) of the sale| x |
|sale/competitor|listAny|Sale - Competitor: The competitor who won the sale| x |
|sale/heading|stringorPK|Sale - Sale: The name of the sale| x |
|sale/amount|decimal|Sale - Amount: The gross sales total| x |
|sale/amountWeighted|decimal|Sale - Weighted amount: Virtual field calculated from amount * probability percent.| x |
|sale/earning|decimal|Sale - Profit: Gross profit (gross sales total - cost) for the sale| x |
|sale/earningPercent|decimal|Sale - Profit as %: The profit as a percentage of the gross sales total| x |
|sale/probPercent|int|Sale - Probability as %: Probability as %| x |
|sale/originalStage|listAny|Sale - Stage when closed: Stage when closed| x |
|sale/stage|listAny|Sale - Stage: Displays the stage of the sale| x |
|sale/stageName| *None* |Sale - Stage name: Displays the stage of the sale| x |
|sale/saleStatus|listAny|Sale - Status: The status of the sale - open, lost or sold| x |
|sale/stageRank| *None* |Sale - Stage rank: Rank of the sale stage in the stage list| x |
|sale/saleType|listAny|Sale - Sale type: Sale type, from list| x |
|sale/saleTypeId| *None* |Sale - Sale type ID: Sale type, from list| x |
|sale/stageId| *None* |Sale - Sale stage ID: Displays the stage of the sale| x |
|sale/nextDueDate|date|Sale - Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|sale/reopenDate|date|Sale - Reopen date: Displays the reopen date for the sale| x |
|sale/stalledComment|listAny|Sale - Reason (stalled): The reason the sale has been stalled| x |
|sale/saleTypeCategory|listAny|Sale - Sale type category: Sale type category| x |
|sale/soldReason|listAny|Sale - Reason (sold): Reason (sold)| x |
|sale/saleNumber|string|Sale - Number: Number| x |
|sale/hasStakeholders|bool|Sale - Has stakeholders: Does this sale have stakeholders| x |
|sale/stakeholdersEnabled|bool|Sale - Stakeholders enabled: Possibility to add stakeholders to the sale| x |
|sale/hasQuote|bool|Sale - Has quote?: Does the sale have a quote attached?| x |
|sale/hasGuide|bool|Sale - Guided: Does this sale have a Sales Guide| x |
|sale/description|string|Sale - Description: The long description field on Sale|  |
|sale/activeErpLinks|bool|Sale - ERP connected: Is there an active ERP Sync?| x |
|sale/createdByWorkflow|listAny|Sale - Created by flow: Created by flow| x |
|sale/amountInBaseCurrency| *None* |Sale - Amount (BaseCurrency: The gross sales total| x |
|sale/amountWeightedInBaseCurrency| *None* |Sale - Weighted amount (BaseCurrency: Virtual field calculated from amount * probability percent.| x |
|sale/daysInStage|int|Sale - Days in stage: Total number of days in this stage| x |
|sale/saleCycle|int|Sale - Sale cycle: Number of days from a sale was registered until it was closed (sold or lost)| x |
|sale/visibleFor|listAny|Sale - Visible for|  |
|sale/sale/textId|int|Sale - Text ID| x |
|sale/sale/description|positiveString|Sale - Text: Displays the text entered in the description field| x |
|isRead|bool|Is read: Has the item been seen?| x |
|readAt|datetime|Read at: When was the item seen| x |

## Sample

```http!
GET /api/v1/archive/NewsFeedItem?$select=contact/contactSource,person/firstName,person/fullName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

