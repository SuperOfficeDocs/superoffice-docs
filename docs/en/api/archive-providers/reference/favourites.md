---
uid: Favourites
title: Favourites
description: Archive provider for the list of favourites
keywords: Favourites archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "Favourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FavouritesProvider">SuperOffice.CRM.ArchiveLists.FavouritesProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the list of favourites

Blah...
<para />
blah....
<para />
...
<para />
........

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
|originalStage| *None* |Stage: Displays the stage of the sale|  |
|stage| *None* |Stage: Displays the stage of the sale|  |
|saleStatus| *None* |Status: The status of the sale - open, lost or sold|  |
|stageRank| *None* |Stage rank: Rank of the sale stage in the stage list|  |
|saleType| *None* |Sale type: Sale type, from list|  |
|nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|reopenDate| *None* |Reopen date: Displays the reopen date for the sale|  |
|stalledComment| *None* |Reason (stalled: The reason the sale has been stalled|  |
|saleTypeCategory| *None* |Sale type category: Sale type category|  |
|soldReason| *None* |Reason (sold: Reason (sold)|  |
|saleNumber| *None* |Number: Number|  |
|hasStakeholders| *None* |Has stakeholders: Does this sale have stakeholders enabled|  |
|hasQuote| *None* |Has quote?: Does the sale have a quote attached?|  |
|hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|description| *None* |Description: The long description field on Sale|  |
|activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|entityIcon| *None* |Row specific icon: Row specific icon| x |
|favouriteAssociateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|visibleFor| *None* |Visible for|  |
|sale/textId| *None* |Text ID|  |
|sale/description| *None* |Text: Displays the text entered in the description field|  |
|salePublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|salePublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|salePublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|salePublish/publishedBy| *None* |Published by: Published by|  |
|person/personId| *None* |DB ID: Displays the database ID of a contact|  |
|person/firstName| *None* |First name: Displays the contact's first name|  |
|person/lastName| *None* |Last name: Displays the contact's last name|  |
|person/middleName| *None* |Middle name: Displays the contact's middle name.|  |
|person/fullName| *None* |Contact: Displays the contact to which an item is linked|  |
|person/contactId| *None* |Company ID: Database ID of company|  |
|person/hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|person/hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|person/personHasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|person/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|person/position| *None* |Position|  |
|person/personNumber| *None* |Number: Displays the contact's number|  |
|person/title| *None* |Title: Displays the contact's job title|  |
|person/personCountry| *None* |Country: Country|  |
|person/personCountryId| *None* |Country ID: Country ID|  |
|person/personNoMail| *None* |No Mailings: Displays the contact's No Mailings checkbox|  |
|person/rank| *None* |Rank: Displays a contact's current rank|  |
|person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|person/useAsMailingAddress| *None* |Use as postal address: Use as postal address|  |
|person/personSource| *None* |Source: Source (Contact)|  |
|person/retired| *None* |Former employee: Indicates whether the contact has retired/left the company|  |
|person/birthYear| *None* |Birth year: Displays contact's birth year|  |
|person/birthMonth| *None* |Birth month: Displays contact's birth month|  |
|person/birthDay| *None* |Birth day: Displays contact's birth day (day of month)|  |
|person/kanaFirstName| *None* |First name, kana: Contact's first name, in kana alphabet|  |
|person/kanaLastName| *None* |Last name, kana: Contact's last name, in kana alphabet|  |
|person/personUpdatedBy| *None* |Updated by: The user who last updated the data|  |
|person/personUpdatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|person/personUpdatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|person/personRegisteredBy| *None* |Registered by: The user who registered the data|  |
|person/personRegisteredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|person/personRegisteredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|person/portraitThumbnail| *None* |Person image: Person image|  |
|person/personActiveErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|person/ticketPriority| *None* |Service priority: Default service priority for this contact|  |
|person/supportLanguage| *None* |Preferred language: Preferred language used for reply templates and more|  |
|person/supportAssociate| *None* |Our service contact: Default service contact for this contact|  |
|person/supportAssociateFullName| *None* |Our service contact - Full name: Default service contact for this contact|  |
|person/personAssociateId| *None* |Our contact: Displays our contact|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/personAssociateFullName| *None* |Our contact - Full name: Displays our contact|  |
|person/personCategory| *None* |Category|  |
|person/personBusiness| *None* |Business|  |
|person/personDeletedDate| *None* |Deleted date: Deleted date|  |
|person/hasCompany| *None* |Has company: The contact is associated with a company|  |
|person/isProjectMember| *None* |Is project member: This person is a project member|  |
|person/isStakeholder| *None* |Is stakeholder: This person is a sale stakeholder|  |
|person/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|person/personDirectPhone/formattedNumber| *None* |Direct - Phone: Displays phone number|  |
|person/personDirectPhone/description| *None* |Direct - Description: Phone number description|  |
|person/personMobilePhone/formattedNumber| *None* |Mobile - Phone: Displays phone number|  |
|person/personMobilePhone/description| *None* |Mobile - Description: Phone number description|  |
|person/personPrivate/formattedNumber| *None* |Private - Phone: Displays phone number|  |
|person/personPrivate/description| *None* |Private - Description: Phone number description|  |
|person/personPager/formattedNumber| *None* |Other - Phone: Displays phone number|  |
|person/personPager/description| *None* |Other - Description: Phone number description|  |
|person/personDirectFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|person/personDirectFax/description| *None* |Fax - Description: Phone number description|  |
|person/searchPhone/formattedNumber| *None* |Phone : Displays phone number|  |
|person/searchPhone/description| *None* |Description: Phone number description|  |
|person/personInfo/textId| *None* |Text ID|  |
|person/personInfo/infoText| *None* |Information: Displays the text entered in the description field|  |
|person/email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|person/email/emailAddress| *None* |E-mail|  |
|person/email/emailDescription| *None* |Description|  |
|person/email/emailId| *None* |ID|  |
|person/email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|person/email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|person/email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|person/email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|person/personUrl/URLAddress| *None* |URL|  |
|person/personUrl/URLDescription| *None* |Description|  |
|person/personAddress/addressId| *None* |Contact address - Address ID: Database ID for the address record|  |
|person/personAddress/line1| *None* |Contact address - Address 1: First line of the address|  |
|person/personAddress/line2| *None* |Contact address - Address 2: Second line of the address|  |
|person/personAddress/line3| *None* |Contact address - Address 3: Third line of the address|  |
|person/personAddress/county| *None* |Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|person/personAddress/city| *None* |Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|person/personAddress/zip| *None* |Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|person/personAddress/state| *None* |Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|person/personAddress/wgs84latitude| *None* |Contact address - Latitude: Latitude|  |
|person/personAddress/wgs84longitude| *None* |Contact address - Longitude: Longitude|  |
|person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|person/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|person/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|person/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|person/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|person/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|person/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|person/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|person/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|person/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|person/personInterestIds| *None* |Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|person/personUdef/SuperOffice:1| *None* |contactshorttext: tooltipshorttext|  |
|person/personUdef/SuperOffice:2| *None* |contactlongtext: tooltiplongtext|  |
|person/personUdef/SuperOffice:3| *None* |contactnumber|  |
|person/personUdef/SuperOffice:4| *None* |contactdate|  |
|person/personUdef/SuperOffice:5| *None* |contactunlimiteddate: tooltipunlimiteddate|  |
|person/personUdef/SuperOffice:6| *None* |contactcheckbox|  |
|person/personUdef/SuperOffice:7| *None* |contactdropdownlistbox|  |
|person/personUdef/SuperOffice:8| *None* |contactdecimal|  |
|person/personUdef/SuperOffice:9| *None* |page1saleonly|  |
|person/personUdef/SuperOffice:10| *None* |page1marketingonly|  |
|person/personUdef/SuperOffice:11| *None* |page1adminonly|  |
|person/personExtra/x\_person\_integer| *None* |Extra Integer: Custom person integer|  |
|person/personExtra/x\_person\_hidden\_integer| *None* |Extra hidden integer: Custom integer field that is hidden|  |
|person/personExtra/x\_person\_float| *None* |Extra float: Custom float field|  |
|person/personExtra/x\_person\_longtext| *None* |Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|person/personExtra/x\_person\_date| *None* |Extra date: Custom date field on person. Default value = 28.03.2019|  |
|person/personExtra/x\_person\_datetime| *None* |Extra DateTime: Custom person date and time field. No default|  |
|person/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default|  |
|person/personExtra/x\_person\_boolean| *None* |Extra Boolean: Custom boolean field on person. Default checked|  |
|person/personExtra/x\_person\_timespan| *None* |Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|person/personExtra/x\_person\_shorttext| *None* |Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|person/personExtra/x\_person\_shorttext\_list| *None* |Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|person/personExtra/x\_person\_user\_relation| *None* |Extra user relation: Custom person-user relation field|  |
|person/personExtra/x\_person\_category\_relation| *None* |Extra category relation: Custom person-category relation|  |
|person/personExtra/x\_person\_priority\_relation| *None* |Extra priority relation: Custom person-priority relation|  |
|person/personExtra/x\_person\_request\_relation| *None* |Extra request relation: Request relation on contact|  |
|person/personExtra/x\_person\_appointment\_relation| *None* |Extra appointment relation: Appointment relation on person|  |
|person/personExtra/x\_person\_contact\_relation| *None* |Extra company relation: Company relation on contact|  |
|person/personExtra/y\_rental/id| *None* |Rental - id: Displays the row's primary key (y\_rental)|  |
|person/personExtra/y\_rental/x\_start| *None* |Rental - Start rental|  |
|person/personExtra/y\_rental/x\_end| *None* |Rental - End|  |
|person/personExtra/y\_rental/x\_amount| *None* |Rental - Amount: Number to rent. Default = 1|  |
|person/personExtra/y\_rental/x\_contact| *None* |Rental - Renter: Company that rents equipment|  |
|person/personExtra/y\_rental/y\_equipment/x\_name| *None* |Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|person/personAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|person/personAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|person/personAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|person/personAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|person/personAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|person/personAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|person/personAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|person/personAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|person/personAssociate/associateDbId| *None* |ID|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/personAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|person/personAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|person/personAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|person/personAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|person/personAssociate/contactCategory| *None* |Category: Category|  |
|person/personAssociate/role| *None* |Role : Role|  |
|person/personAssociate/assocName| *None* |User ID : User ID|  |
|person/personAssociate/assocTooltip| *None* |Description : Description|  |
|person/personAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|person/personAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|person/personAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|person/personAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|person/personAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|person/personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|person/personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|person/personAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|person/personAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|person/personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|person/personAssociate/otherGroups| *None* |Other groups: Other groups|  |
|person/personAssociate/userName| *None* |User name: User name|  |
|person/personAssociate/personEmail| *None* |E-mail|  |
|person/correspondingAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|person/correspondingAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|person/correspondingAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|person/correspondingAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|person/correspondingAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|person/correspondingAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|person/correspondingAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|person/correspondingAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|person/correspondingAssociate/associateDbId| *None* |ID|  |
|person/correspondingAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|person/correspondingAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|person/correspondingAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|person/correspondingAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|person/correspondingAssociate/contactCategory| *None* |Category: Category|  |
|person/correspondingAssociate/role| *None* |Role : Role|  |
|person/correspondingAssociate/assocName| *None* |User ID : User ID|  |
|person/correspondingAssociate/assocTooltip| *None* |Description : Description|  |
|person/correspondingAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|person/correspondingAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|person/correspondingAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|person/correspondingAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|person/correspondingAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|person/correspondingAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|person/correspondingAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|person/correspondingAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|person/correspondingAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|person/correspondingAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|person/correspondingAssociate/otherGroups| *None* |Other groups: Other groups|  |
|person/correspondingAssociate/userName| *None* |User name: User name|  |
|person/correspondingAssociate/personEmail| *None* |E-mail|  |
|person/isMailingRecipient| *None* |Is mailing recipient: isMailingRecipient|  |
|person/hasStoreConsent| *None* |Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/withdrawnStoreConsent| *None* |Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/hasEmarketingConsent| *None* |Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/withdrawnEmarketingConsent| *None* |Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/subscription| *None* |Subscription: Subscription for marketing|  |
|person/legalBaseStore| *None* |Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/legalBaseEmarketing| *None* |Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/consentSourceStore| *None* |Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/consentSourceEmarketing| *None* |Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contact/contactId| *None* |Company ID: Database ID of company|  |
|contact/name| *None* |Company name|  |
|contact/department| *None* |Department|  |
|contact/nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|contact/hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|contact/hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|contact/associateId| *None* |Our contact: Displays our contact|  |
|contact/category| *None* |Category|  |
|contact/business| *None* |Business|  |
|contact/country| *None* |Country: This criterion corresponds to the Country field on the Company card.|  |
|contact/countryId| *None* |Country ID: Country ID|  |
|contact/number| *None* |Number|  |
|contact/code| *None* |Code|  |
|contact/orgnr| *None* |VAT No.|  |
|contact/stop| *None* |Stop|  |
|contact/contactNoMail| *None* |No mailings (company|  |
|contact/updatedBy| *None* |Updated by: The user who last updated the data|  |
|contact/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|contact/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|contact/registeredBy| *None* |Registered by: The user who registered the data|  |
|contact/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|contact/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|contact/contactSource| *None* |Source: Source (Company)|  |
|contact/contactDeleted| *None* |Deleted: Deleted|  |
|contact/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|contact/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|contact/deletedDate| *None* |Deleted date: Deleted date|  |
|contact/mainContact| *None* |Main contact: Main contact for this company|  |
|contact/contactPhone/formattedNumber| *None* |Telephone - Phone: Displays phone number|  |
|contact/contactPhone/description| *None* |Telephone - Description: Phone number description|  |
|contact/contactFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|contact/contactFax/description| *None* |Fax - Description: Phone number description|  |
|contact/searchPhone/formattedNumber| *None* |Searchphone - Phone: Displays phone number|  |
|contact/searchPhone/description| *None* |Searchphone - Description: Phone number description|  |
|contact/email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|contact/email/emailAddress| *None* |E-mail|  |
|contact/email/emailDescription| *None* |Description|  |
|contact/email/emailId| *None* |ID|  |
|contact/email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|contact/email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|contact/email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|contact/postAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|contact/postAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|contact/postAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|contact/postAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|contact/postAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|contact/postAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|contact/postAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|contact/postAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|contact/postAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|contact/postAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|contact/streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|contact/streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|contact/streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|contact/streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|contact/streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|contact/streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|contact/streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|contact/streetAddress/wgs84latitude| *None* |Street address - Latitude: Latitude|  |
|contact/streetAddress/wgs84longitude| *None* |Street address - Longitude: Longitude|  |
|contact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|contact/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|contact/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|contact/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|contact/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|contact/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|contact/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|contact/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|contact/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|contact/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|contact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|contact/url/URLAddress| *None* |URL|  |
|contact/url/URLDescription| *None* |Description|  |
|contact/contactAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|contact/contactAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|contact/contactAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|contact/contactAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|contact/contactAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|contact/contactAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|contact/contactAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contact/contactAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|contact/contactAssociate/associateDbId| *None* |ID|  |
|contact/contactAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|contact/contactAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|contact/contactAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|contact/contactAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|contact/contactAssociate/contactCategory| *None* |Category: Category|  |
|contact/contactAssociate/role| *None* |Role : Role|  |
|contact/contactAssociate/assocName| *None* |User ID : User ID|  |
|contact/contactAssociate/assocTooltip| *None* |Description : Description|  |
|contact/contactAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|contact/contactAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|contact/contactAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contact/contactAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|contact/contactAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|contact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|contact/contactAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|contact/contactAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|contact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contact/contactAssociate/otherGroups| *None* |Other groups: Other groups|  |
|contact/contactAssociate/userName| *None* |User name: User name|  |
|contact/contactAssociate/personEmail| *None* |E-mail|  |
|contact/contactInterestIds| *None* |Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|contact/contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|contact/contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|contact/contactUdef/SuperOffice:3| *None* |companynumber|  |
|contact/contactUdef/SuperOffice:4| *None* |companydate|  |
|contact/contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|contact/contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|contact/contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|contact/contactUdef/SuperOffice:8| *None* |companydecimal|  |
|contact/contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|contact/contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|contact/contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|contact/contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|contact/contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|contact/contactExtra/x\_contact\_integer| *None* |Extra Integer: Custom integer field|  |
|contact/contactExtra/x\_contact\_hidden\_integer| *None* |Extra hidden integer: Custom integer field - hidden|  |
|contact/contactExtra/x\_contact\_default\_integer| *None* |Extra Default Integer: Custom integer field with default value 123.|  |
|contact/contactExtra/x\_contact\_float| *None* |Extra Float: Custom float field with 3 decimals|  |
|contact/contactExtra/x\_contact\_longtext| *None* |Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|contact/contactExtra/x\_contact\_dropdown| *None* |Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|contact/contactExtra/x\_contact\_date| *None* |Extra date: Custom date field. User current as default.|  |
|contact/contactExtra/x\_contact\_datetime| *None* |Extra DateTime: Custom Date Time field. No default value. External|  |
|contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.|  |
|contact/contactExtra/x\_contact\_boolean| *None* |Extra boolean: Custom boolean field.|  |
|contact/contactExtra/x\_contact\_timespan| *None* |Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|contact/contactExtra/x\_contact\_shorttext| *None* |Extra short text: Custom short text field. Keep HTML tags.|  |
|contact/contactExtra/x\_contact\_short\_dropdown| *None* |Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|contact/contactExtra/x\_contact\_contact\_relation| *None* |Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|contact/contactExtra/x\_contact\_request\_relation| *None* |Extra Request relation: Request relation on company|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactExtra/x\_contact\_contact| *None* |Extra contact relation: Contact relation on company|  |
|contact/NumberOfActivities| *None* |Number of activities|  |
|contact/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|contact/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|contact/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|contact/LastActivity| *None* |Date of last activity|  |
|contact/LastCompletedActivity| *None* |Date of last completed activity|  |
|contact/LastDoByActivity| *None* |Date of last non-completed activity|  |
|contact/NumberOfSales| *None* |Number of sales|  |
|contact/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|contact/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|contact/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|contact/LastSale| *None* |Date of last sale|  |
|contact/LastCompletedSale| *None* |Date of last completed sale|  |
|contact/LastDoBySale| *None* |Date of last non-completed sale|  |
|contact/NumberOfTickets| *None* |Number of requests|  |
|contact/NumberOfTicketsInPeriod| *None* |Number of requests in last 90 days|  |
|contact/NumberOfNotCompletedTickets| *None* |Number of non-completed requests|  |
|contact/NumberOfNotCompletedTicketsInPeriod| *None* |Number of non-completed requests in last 90 days|  |
|contact/LastTicket| *None* |Date of last request|  |
|contact/LastCompletedTicket| *None* |Date of last completed request|  |
|contact/LastDoByTicket| *None* |Date of last non-completed request|  |
|contact/SaintStatus1| *None* |Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|contact/SaintStatus2| *None* |C-company: Kundens navn starter med bokstaven C|  |
|contact/saintSaleStatus| *None* |With status|  |
|contact/saintAmountClass| *None* |Amount class|  |
|contact/saintActivityType| *None* |SAINT type|  |
|contact/saintDirection| *None* |Direction|  |
|contact/saintIntention| *None* |Intention|  |
|contact/saintTicketStatus| *None* |Status|  |
|contact/saintTicketCategory| *None* |Category|  |
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
|associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|associate/contactCategory| *None* |Category: Category|  |
|associate/role| *None* |Role : Role|  |
|associate/assocName| *None* |User ID : User ID|  |
|associate/assocTooltip| *None* |Description : Description|  |
|associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|associate/portraitThumbnail| *None* |Person image: Person image|  |
|associate/otherGroups| *None* |Other groups: Other groups|  |
|associate/userName| *None* |User name: User name|  |
|associate/personEmail| *None* |E-mail|  |
|saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|saleUdef/SuperOffice:2| *None* |salelongtext|  |
|saleUdef/SuperOffice:3| *None* |salenumber|  |
|saleUdef/SuperOffice:4| *None* |saledate|  |
|saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|saleUdef/SuperOffice:8| *None* |saledecimal|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|project/projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|project/projectAssociate/contactCategory| *None* |Category: Category|  |
|project/projectAssociate/role| *None* |Role : Role|  |
|project/projectAssociate/assocName| *None* |User ID : User ID|  |
|project/projectAssociate/assocTooltip| *None* |Description : Description|  |
|project/projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|project/projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|project/projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|project/projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|project/projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|project/projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|project/projectAssociate/userName| *None* |User name: User name|  |
|project/projectAssociate/personEmail| *None* |E-mail|  |
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
|saleStakeholder/saleStakeholderId| *None* |Stakeholder - Stakeholder ID: Database ID of the stakeholder row|  |
|saleStakeholder/saleId| *None* |Stakeholder - Sale ID: The database ID of the sale record|  |
|saleStakeholder/comment| *None* |Stakeholder - Sales role comment text: Sales role comment text|  |
|saleStakeholder/salesRoleId| *None* |Stakeholder - Sales role: Sales role|  |
|saleStakeholder/hasInfoText| *None* |Stakeholder - Sales role comment: Sales role comment|  |
|saleStakeholder/person/personId| *None* |Stakeholder - DB ID: Displays the database ID of a contact|  |
|saleStakeholder/person/firstName| *None* |Stakeholder - First name: Displays the contact's first name|  |
|saleStakeholder/person/lastName| *None* |Stakeholder - Last name: Displays the contact's last name|  |
|saleStakeholder/person/middleName| *None* |Stakeholder - Middle name: Displays the contact's middle name.|  |
|saleStakeholder/person/fullName| *None* |Stakeholder - Contact: Displays the contact to which an item is linked|  |
|saleStakeholder/person/contactId| *None* |Stakeholder - Company ID: Database ID of company|  |
|saleStakeholder/person/hasInfoText| *None* |Stakeholder - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|saleStakeholder/person/hasInterests| *None* |Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests|  |
|saleStakeholder/person/personHasInterests| *None* |Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests|  |
|saleStakeholder/person/mrMrs| *None* |Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/person/position| *None* |Stakeholder - Position|  |
|saleStakeholder/person/personNumber| *None* |Stakeholder - Number: Displays the contact's number|  |
|saleStakeholder/person/title| *None* |Stakeholder - Title: Displays the contact's job title|  |
|saleStakeholder/person/personCountry| *None* |Stakeholder - Country: Country|  |
|saleStakeholder/person/personCountryId| *None* |Stakeholder - Country ID: Country ID|  |
|saleStakeholder/person/personNoMail| *None* |Stakeholder - No Mailings: Displays the contact's No Mailings checkbox|  |
|saleStakeholder/person/rank| *None* |Stakeholder - Rank: Displays a contact's current rank|  |
|saleStakeholder/person/birthdate| *None* |Stakeholder - Birthdate: Displays the contact's date of birth|  |
|saleStakeholder/person/associateType| *None* |Stakeholder - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|saleStakeholder/person/useAsMailingAddress| *None* |Stakeholder - Use as postal address: Use as postal address|  |
|saleStakeholder/person/personSource| *None* |Stakeholder - Source: Source (Contact)|  |
|saleStakeholder/person/retired| *None* |Stakeholder - Former employee: Indicates whether the contact has retired/left the company|  |
|saleStakeholder/person/birthYear| *None* |Stakeholder - Birth year: Displays contact's birth year|  |
|saleStakeholder/person/birthMonth| *None* |Stakeholder - Birth month: Displays contact's birth month|  |
|saleStakeholder/person/birthDay| *None* |Stakeholder - Birth day: Displays contact's birth day (day of month)|  |
|saleStakeholder/person/kanaFirstName| *None* |Stakeholder - First name, kana: Contact's first name, in kana alphabet|  |
|saleStakeholder/person/kanaLastName| *None* |Stakeholder - Last name, kana: Contact's last name, in kana alphabet|  |
|saleStakeholder/person/personUpdatedBy| *None* |Stakeholder - Updated by: The user who last updated the data|  |
|saleStakeholder/person/personUpdatedByFullName| *None* |Stakeholder - Updated by - Full name: The user who last updated the data|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/personUpdatedDate| *None* |Stakeholder - Updated: The date/time the data was last updated in UTC.|  |
|saleStakeholder/person/personRegisteredBy| *None* |Stakeholder - Registered by: The user who registered the data|  |
|saleStakeholder/person/personRegisteredByFullName| *None* |Stakeholder - Registered by - Full name: The user who registered the data|  |
|saleStakeholder/person/personRegisteredDate| *None* |Stakeholder - Registered date: The date/time the data was registered in UTC.|  |
|saleStakeholder/person/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/personActiveErpLinks| *None* |Stakeholder - ERP connected: Is there an active ERP Sync?|  |
|saleStakeholder/person/ticketPriority| *None* |Stakeholder - Service priority: Default service priority for this contact|  |
|saleStakeholder/person/supportLanguage| *None* |Stakeholder - Preferred language: Preferred language used for reply templates and more|  |
|saleStakeholder/person/supportAssociate| *None* |Stakeholder - Our service contact: Default service contact for this contact|  |
|saleStakeholder/person/supportAssociateFullName| *None* |Stakeholder - Our service contact - Full name: Default service contact for this contact|  |
|saleStakeholder/person/personAssociateId| *None* |Stakeholder - Our contact: Displays our contact|  |
|saleStakeholder/person/personAssociateFullName| *None* |Stakeholder - Our contact - Full name: Displays our contact|  |
|saleStakeholder/person/personCategory| *None* |Stakeholder - Category|  |
|saleStakeholder/person/personBusiness| *None* |Stakeholder - Business|  |
|saleStakeholder/person/personDeletedDate| *None* |Stakeholder - Deleted date: Deleted date|  |
|saleStakeholder/person/hasCompany| *None* |Stakeholder - Has company: The contact is associated with a company|  |
|saleStakeholder/person/isProjectMember| *None* |Stakeholder - Is project member: This person is a project member|  |
|saleStakeholder/person/isStakeholder| *None* |Stakeholder - Is stakeholder: This person is a sale stakeholder|  |
|saleStakeholder/person/phone/formattedNumber| *None* |Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectPhone/formattedNumber| *None* |Stakeholder - Direct - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectPhone/description| *None* |Stakeholder - Direct - Description: Phone number description|  |
|saleStakeholder/person/personMobilePhone/formattedNumber| *None* |Stakeholder - Mobile - Phone: Displays phone number|  |
|saleStakeholder/person/personMobilePhone/description| *None* |Stakeholder - Mobile - Description: Phone number description|  |
|saleStakeholder/person/personPrivate/formattedNumber| *None* |Stakeholder - Private - Phone: Displays phone number|  |
|saleStakeholder/person/personPrivate/description| *None* |Stakeholder - Private - Description: Phone number description|  |
|saleStakeholder/person/personPager/formattedNumber| *None* |Stakeholder - Other - Phone: Displays phone number|  |
|saleStakeholder/person/personPager/description| *None* |Stakeholder - Other - Description: Phone number description|  |
|saleStakeholder/person/personDirectFax/formattedNumber| *None* |Stakeholder - Fax - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectFax/description| *None* |Stakeholder - Fax - Description: Phone number description|  |
|saleStakeholder/person/searchPhone/formattedNumber| *None* |Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/person/searchPhone/description| *None* |Stakeholder - Description: Phone number description|  |
|saleStakeholder/person/personInfo/textId| *None* |Stakeholder - Text ID|  |
|saleStakeholder/person/personInfo/infoText| *None* |Stakeholder - Information: Displays the text entered in the description field|  |
|saleStakeholder/person/email/emailProtocol| *None* |Stakeholder - Protocol: E-mail protocol, such as SMTP|  |
|saleStakeholder/person/email/emailAddress| *None* |Stakeholder - E-mail|  |
|saleStakeholder/person/email/emailDescription| *None* |Stakeholder - Description|  |
|saleStakeholder/person/email/emailId| *None* |Stakeholder - ID|  |
|saleStakeholder/person/email/emailLastSent| *None* |Stakeholder - Last sent: The date and time an e-mail was last sent to this address|  |
|saleStakeholder/person/email/emailBounceCount| *None* |Stakeholder - Bounce count: Bounce count for this e-mail address|  |
|saleStakeholder/person/email/emailLastBounce| *None* |Stakeholder - Last bounce: Date and time for last bounce to this e-mail address|  |
|saleStakeholder/person/email/emailHasBounced| *None* |Stakeholder - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|saleStakeholder/person/personUrl/URLAddress| *None* |Stakeholder - URL|  |
|saleStakeholder/person/personUrl/URLDescription| *None* |Stakeholder - Description|  |
|saleStakeholder/person/personAddress/addressId| *None* |Stakeholder - Contact address - Address ID: Database ID for the address record|  |
|saleStakeholder/person/personAddress/line1| *None* |Stakeholder - Contact address - Address 1: First line of the address|  |
|saleStakeholder/person/personAddress/line2| *None* |Stakeholder - Contact address - Address 2: Second line of the address|  |
|saleStakeholder/person/personAddress/line3| *None* |Stakeholder - Contact address - Address 3: Third line of the address|  |
|saleStakeholder/person/personAddress/county| *None* |Stakeholder - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/personAddress/city| *None* |Stakeholder - Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/person/personAddress/zip| *None* |Stakeholder - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/person/personAddress/state| *None* |Stakeholder - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/personAddress/wgs84latitude| *None* |Stakeholder - Contact address - Latitude: Latitude|  |
|saleStakeholder/person/personAddress/wgs84longitude| *None* |Stakeholder - Contact address - Longitude: Longitude|  |
|saleStakeholder/person/personAddress/formattedAddress| *None* |Stakeholder - Contact address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personAddress/formattedMultiLineAddress| *None* |Stakeholder - Contact address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/addressId| *None* |Stakeholder - Search address - Address ID: Database ID for the address record|  |
|saleStakeholder/person/restrictionAddress/line1| *None* |Stakeholder - Search address - Address 1: First line of the address|  |
|saleStakeholder/person/restrictionAddress/line2| *None* |Stakeholder - Search address - Address 2: Second line of the address|  |
|saleStakeholder/person/restrictionAddress/line3| *None* |Stakeholder - Search address - Address 3: Third line of the address|  |
|saleStakeholder/person/restrictionAddress/county| *None* |Stakeholder - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/restrictionAddress/city| *None* |Stakeholder - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/person/restrictionAddress/zip| *None* |Stakeholder - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/person/restrictionAddress/state| *None* |Stakeholder - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/person/restrictionAddress/wgs84latitude| *None* |Stakeholder - Search address - Latitude: Latitude|  |
|saleStakeholder/person/restrictionAddress/wgs84longitude| *None* |Stakeholder - Search address - Longitude: Longitude|  |
|saleStakeholder/person/restrictionAddress/formattedAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/formattedMultiLineAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personInterestIds| *None* |Stakeholder - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|saleStakeholder/person/personUdef/SuperOffice:1| *None* |Stakeholder - contactshorttext: tooltipshorttext|  |
|saleStakeholder/person/personUdef/SuperOffice:2| *None* |Stakeholder - contactlongtext: tooltiplongtext|  |
|saleStakeholder/person/personUdef/SuperOffice:3| *None* |Stakeholder - contactnumber|  |
|saleStakeholder/person/personUdef/SuperOffice:4| *None* |Stakeholder - contactdate|  |
|saleStakeholder/person/personUdef/SuperOffice:5| *None* |Stakeholder - contactunlimiteddate: tooltipunlimiteddate|  |
|saleStakeholder/person/personUdef/SuperOffice:6| *None* |Stakeholder - contactcheckbox|  |
|saleStakeholder/person/personUdef/SuperOffice:7| *None* |Stakeholder - contactdropdownlistbox|  |
|saleStakeholder/person/personUdef/SuperOffice:8| *None* |Stakeholder - contactdecimal|  |
|saleStakeholder/person/personUdef/SuperOffice:9| *None* |Stakeholder - page1saleonly|  |
|saleStakeholder/person/personUdef/SuperOffice:10| *None* |Stakeholder - page1marketingonly|  |
|saleStakeholder/person/personUdef/SuperOffice:11| *None* |Stakeholder - page1adminonly|  |
|saleStakeholder/person/personExtra/x\_person\_integer| *None* |Stakeholder - Extra Integer: Custom person integer|  |
|saleStakeholder/person/personExtra/x\_person\_hidden\_integer| *None* |Stakeholder - Extra hidden integer: Custom integer field that is hidden|  |
|saleStakeholder/person/personExtra/x\_person\_float| *None* |Stakeholder - Extra float: Custom float field|  |
|saleStakeholder/person/personExtra/x\_person\_longtext| *None* |Stakeholder - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|saleStakeholder/person/personExtra/x\_person\_date| *None* |Stakeholder - Extra date: Custom date field on person. Default value = 28.03.2019|  |
|saleStakeholder/person/personExtra/x\_person\_datetime| *None* |Stakeholder - Extra DateTime: Custom person date and time field. No default|  |
|saleStakeholder/person/personExtra/x\_person\_time| *None* |Stakeholder - Extra time: Custom time field on person. Current time as default|  |
|saleStakeholder/person/personExtra/x\_person\_boolean| *None* |Stakeholder - Extra Boolean: Custom boolean field on person. Default checked|  |
|saleStakeholder/person/personExtra/x\_person\_timespan| *None* |Stakeholder - Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|saleStakeholder/person/personExtra/x\_person\_shorttext| *None* |Stakeholder - Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|saleStakeholder/person/personExtra/x\_person\_shorttext\_list| *None* |Stakeholder - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|saleStakeholder/person/personExtra/x\_person\_user\_relation| *None* |Stakeholder - Extra user relation: Custom person-user relation field|  |
|saleStakeholder/person/personExtra/x\_person\_category\_relation| *None* |Stakeholder - Extra category relation: Custom person-category relation|  |
|saleStakeholder/person/personExtra/x\_person\_priority\_relation| *None* |Stakeholder - Extra priority relation: Custom person-priority relation|  |
|saleStakeholder/person/personExtra/x\_person\_request\_relation| *None* |Stakeholder - Extra request relation: Request relation on contact|  |
|saleStakeholder/person/personExtra/x\_person\_appointment\_relation| *None* |Stakeholder - Extra appointment relation: Appointment relation on person|  |
|saleStakeholder/person/personExtra/x\_person\_contact\_relation| *None* |Stakeholder - Extra company relation: Company relation on contact|  |
|saleStakeholder/person/personExtra/y\_rental/id| *None* |Stakeholder - Rental - id: Displays the row's primary key (y\_rental)|  |
|saleStakeholder/person/personExtra/y\_rental/x\_start| *None* |Stakeholder - Rental - Start rental|  |
|saleStakeholder/person/personExtra/y\_rental/x\_end| *None* |Stakeholder - Rental - End|  |
|saleStakeholder/person/personExtra/y\_rental/x\_amount| *None* |Stakeholder - Rental - Amount: Number to rent. Default = 1|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/personExtra/y\_rental/x\_contact| *None* |Stakeholder - Rental - Renter: Company that rents equipment|  |
|saleStakeholder/person/personExtra/y\_rental/y\_equipment/x\_name| *None* |Stakeholder - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|saleStakeholder/person/personAssociate/firstName| *None* |Stakeholder - First name: Displays the contact's first name|  |
|saleStakeholder/person/personAssociate/lastName| *None* |Stakeholder - Last name: Displays the contact's last name|  |
|saleStakeholder/person/personAssociate/middleName| *None* |Stakeholder - Middle Name: Displays the contact's middle name.|  |
|saleStakeholder/person/personAssociate/fullName| *None* |Stakeholder - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|saleStakeholder/person/personAssociate/contactId| *None* |Stakeholder - Company ID: Database ID of the company the user belongs to|  |
|saleStakeholder/person/personAssociate/personId| *None* |Stakeholder - Contact ID: Database ID of the contact row|  |
|saleStakeholder/person/personAssociate/mrMrs| *None* |Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/person/personAssociate/title| *None* |Stakeholder - Title: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/person/personAssociate/associateDbId| *None* |Stakeholder - ID|  |
|saleStakeholder/person/personAssociate/contactName| *None* |Stakeholder - Owning company: Name of the company the user belongs to|  |
|saleStakeholder/person/personAssociate/contactDepartment| *None* |Stakeholder - Owning department: Name of the department at the company the user belongs to|  |
|saleStakeholder/person/personAssociate/usergroup| *None* |Stakeholder - Primary group: The user's primary user group|  |
|saleStakeholder/person/personAssociate/contactFullName| *None* |Stakeholder - Owner: Name and department of the company the user belongs to|  |
|saleStakeholder/person/personAssociate/contactCategory| *None* |Stakeholder - Category: Category|  |
|saleStakeholder/person/personAssociate/role| *None* |Stakeholder - Role: Role|  |
|saleStakeholder/person/personAssociate/assocName| *None* |Stakeholder - User ID: User ID|  |
|saleStakeholder/person/personAssociate/assocTooltip| *None* |Stakeholder - Description: Description|  |
|saleStakeholder/person/personAssociate/assocType| *None* |Stakeholder - Type: Type of user: associate, external user, system user, anonymous account|  |
|saleStakeholder/person/personAssociate/ejUserId| *None* |Stakeholder - Service user ID: The database ID of a Service user|  |
|saleStakeholder/person/personAssociate/simultaneousEjUser| *None* |Stakeholder - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|saleStakeholder/person/personAssociate/ejDisplayName| *None* |Stakeholder - Nick name: User's nick name in Service|  |
|saleStakeholder/person/personAssociate/ejStatus| *None* |Stakeholder - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|saleStakeholder/person/personAssociate/credentialType| *None* |Stakeholder - Auth. type: What type of credentials to use when this user logs in|  |
|saleStakeholder/person/personAssociate/credentialDisplayValue| *None* |Stakeholder - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|saleStakeholder/person/personAssociate/isActive| *None* |Stakeholder - Active: Is this user active, and should be able to log in?|  |
|saleStakeholder/person/personAssociate/isActiveText| *None* |Stakeholder - Active status: Is this user active, and should be able to log in?|  |
|saleStakeholder/person/personAssociate/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/personAssociate/otherGroups| *None* |Stakeholder - Other groups: Other groups|  |
|saleStakeholder/person/personAssociate/userName| *None* |Stakeholder - User name: User name|  |
|saleStakeholder/person/personAssociate/personEmail| *None* |Stakeholder - E-mail|  |
|saleStakeholder/person/correspondingAssociate/firstName| *None* |Stakeholder - First name: Displays the contact's first name|  |
|saleStakeholder/person/correspondingAssociate/lastName| *None* |Stakeholder - Last name: Displays the contact's last name|  |
|saleStakeholder/person/correspondingAssociate/middleName| *None* |Stakeholder - Middle Name: Displays the contact's middle name.|  |
|saleStakeholder/person/correspondingAssociate/fullName| *None* |Stakeholder - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|saleStakeholder/person/correspondingAssociate/contactId| *None* |Stakeholder - Company ID: Database ID of the company the user belongs to|  |
|saleStakeholder/person/correspondingAssociate/personId| *None* |Stakeholder - Contact ID: Database ID of the contact row|  |
|saleStakeholder/person/correspondingAssociate/mrMrs| *None* |Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/person/correspondingAssociate/title| *None* |Stakeholder - Title: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/person/correspondingAssociate/associateDbId| *None* |Stakeholder - ID|  |
|saleStakeholder/person/correspondingAssociate/contactName| *None* |Stakeholder - Owning company: Name of the company the user belongs to|  |
|saleStakeholder/person/correspondingAssociate/contactDepartment| *None* |Stakeholder - Owning department: Name of the department at the company the user belongs to|  |
|saleStakeholder/person/correspondingAssociate/usergroup| *None* |Stakeholder - Primary group: The user's primary user group|  |
|saleStakeholder/person/correspondingAssociate/contactFullName| *None* |Stakeholder - Owner: Name and department of the company the user belongs to|  |
|saleStakeholder/person/correspondingAssociate/contactCategory| *None* |Stakeholder - Category: Category|  |
|saleStakeholder/person/correspondingAssociate/role| *None* |Stakeholder - Role: Role|  |
|saleStakeholder/person/correspondingAssociate/assocName| *None* |Stakeholder - User ID: User ID|  |
|saleStakeholder/person/correspondingAssociate/assocTooltip| *None* |Stakeholder - Description: Description|  |
|saleStakeholder/person/correspondingAssociate/assocType| *None* |Stakeholder - Type: Type of user: associate, external user, system user, anonymous account|  |
|saleStakeholder/person/correspondingAssociate/ejUserId| *None* |Stakeholder - Service user ID: The database ID of a Service user|  |
|saleStakeholder/person/correspondingAssociate/simultaneousEjUser| *None* |Stakeholder - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|saleStakeholder/person/correspondingAssociate/ejDisplayName| *None* |Stakeholder - Nick name: User's nick name in Service|  |
|saleStakeholder/person/correspondingAssociate/ejStatus| *None* |Stakeholder - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|saleStakeholder/person/correspondingAssociate/credentialType| *None* |Stakeholder - Auth. type: What type of credentials to use when this user logs in|  |
|saleStakeholder/person/correspondingAssociate/credentialDisplayValue| *None* |Stakeholder - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|saleStakeholder/person/correspondingAssociate/isActive| *None* |Stakeholder - Active: Is this user active, and should be able to log in?|  |
|saleStakeholder/person/correspondingAssociate/isActiveText| *None* |Stakeholder - Active status: Is this user active, and should be able to log in?|  |
|saleStakeholder/person/correspondingAssociate/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/correspondingAssociate/otherGroups| *None* |Stakeholder - Other groups: Other groups|  |
|saleStakeholder/person/correspondingAssociate/userName| *None* |Stakeholder - User name: User name|  |
|saleStakeholder/person/correspondingAssociate/personEmail| *None* |Stakeholder - E-mail|  |
|saleStakeholder/person/isMailingRecipient| *None* |Stakeholder - Is mailing recipient: isMailingRecipient|  |
|saleStakeholder/person/hasStoreConsent| *None* |Stakeholder - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/withdrawnStoreConsent| *None* |Stakeholder - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/hasEmarketingConsent| *None* |Stakeholder - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/withdrawnEmarketingConsent| *None* |Stakeholder - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/subscription| *None* |Stakeholder - Subscription: Subscription for marketing|  |
|saleStakeholder/person/legalBaseStore| *None* |Stakeholder - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/legalBaseEmarketing| *None* |Stakeholder - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/consentSourceStore| *None* |Stakeholder - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/consentSourceEmarketing| *None* |Stakeholder - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/contact/contactId| *None* |Stakeholder - Company ID: Database ID of company|  |
|saleStakeholder/contact/name| *None* |Stakeholder - Company name|  |
|saleStakeholder/contact/department| *None* |Stakeholder - Department|  |
|saleStakeholder/contact/nameDepartment| *None* |Stakeholder - Company: Displays the company an activity is linked to|  |
|saleStakeholder/contact/hasInfoText| *None* |Stakeholder - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|saleStakeholder/contact/hasInterests| *None* |Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests|  |
|saleStakeholder/contact/associateId| *None* |Stakeholder - Our contact: Displays our contact|  |
|saleStakeholder/contact/category| *None* |Stakeholder - Category|  |
|saleStakeholder/contact/business| *None* |Stakeholder - Business|  |
|saleStakeholder/contact/country| *None* |Stakeholder - Country: This criterion corresponds to the Country field on the Company card.|  |
|saleStakeholder/contact/countryId| *None* |Stakeholder - Country ID: Country ID|  |
|saleStakeholder/contact/number| *None* |Stakeholder - Number|  |
|saleStakeholder/contact/code| *None* |Stakeholder - Code|  |
|saleStakeholder/contact/orgnr| *None* |Stakeholder - VAT No.|  |
|saleStakeholder/contact/stop| *None* |Stakeholder - Stop|  |
|saleStakeholder/contact/contactNoMail| *None* |Stakeholder - No mailings (company)|  |
|saleStakeholder/contact/updatedBy| *None* |Stakeholder - Updated by: The user who last updated the data|  |
|saleStakeholder/contact/updatedByFullName| *None* |Stakeholder - Updated by - Full name: The user who last updated the data|  |
|saleStakeholder/contact/updatedDate| *None* |Stakeholder - Updated: The date/time the data was last updated in UTC.|  |
|saleStakeholder/contact/registeredBy| *None* |Stakeholder - Registered by: The user who registered the data|  |
|saleStakeholder/contact/registeredByFullName| *None* |Stakeholder - Registered by - Full name: The user who registered the data|  |
|saleStakeholder/contact/registeredDate| *None* |Stakeholder - Registered date: The date/time the data was registered in UTC.|  |
|saleStakeholder/contact/contactSource| *None* |Stakeholder - Source: Source (Company)|  |
|saleStakeholder/contact/contactDeleted| *None* |Stakeholder - Deleted: Deleted|  |
|saleStakeholder/contact/phone/formattedNumber| *None* |Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/contact/activeErpLinks| *None* |Stakeholder - ERP connected: Is there an active ERP Sync?|  |
|saleStakeholder/contact/deletedDate| *None* |Stakeholder - Deleted date: Deleted date|  |
|saleStakeholder/contact/mainContact| *None* |Stakeholder - Main contact: Main contact for this company|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/contact/contactPhone/formattedNumber| *None* |Stakeholder - Telephone - Phone: Displays phone number|  |
|saleStakeholder/contact/contactPhone/description| *None* |Stakeholder - Telephone - Description: Phone number description|  |
|saleStakeholder/contact/contactFax/formattedNumber| *None* |Stakeholder - Fax - Phone: Displays phone number|  |
|saleStakeholder/contact/contactFax/description| *None* |Stakeholder - Fax - Description: Phone number description|  |
|saleStakeholder/contact/searchPhone/formattedNumber| *None* |Stakeholder - Searchphone - Phone: Displays phone number|  |
|saleStakeholder/contact/searchPhone/description| *None* |Stakeholder - Searchphone - Description: Phone number description|  |
|saleStakeholder/contact/email/emailProtocol| *None* |Stakeholder - Protocol: E-mail protocol, such as SMTP|  |
|saleStakeholder/contact/email/emailAddress| *None* |Stakeholder - E-mail|  |
|saleStakeholder/contact/email/emailDescription| *None* |Stakeholder - Description|  |
|saleStakeholder/contact/email/emailId| *None* |Stakeholder - ID|  |
|saleStakeholder/contact/email/emailLastSent| *None* |Stakeholder - Last sent: The date and time an e-mail was last sent to this address|  |
|saleStakeholder/contact/email/emailBounceCount| *None* |Stakeholder - Bounce count: Bounce count for this e-mail address|  |
|saleStakeholder/contact/email/emailLastBounce| *None* |Stakeholder - Last bounce: Date and time for last bounce to this e-mail address|  |
|saleStakeholder/contact/email/emailHasBounced| *None* |Stakeholder - Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|saleStakeholder/contact/postAddress/addressId| *None* |Stakeholder - Postal address - Address ID: Database ID for the address record|  |
|saleStakeholder/contact/postAddress/line1| *None* |Stakeholder - Postal address - Address 1: First line of the address|  |
|saleStakeholder/contact/postAddress/line2| *None* |Stakeholder - Postal address - Address 2: Second line of the address|  |
|saleStakeholder/contact/postAddress/line3| *None* |Stakeholder - Postal address - Address 3: Third line of the address|  |
|saleStakeholder/contact/postAddress/county| *None* |Stakeholder - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/postAddress/city| *None* |Stakeholder - Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/contact/postAddress/zip| *None* |Stakeholder - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/contact/postAddress/state| *None* |Stakeholder - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/postAddress/wgs84latitude| *None* |Stakeholder - Postal address - Latitude: Latitude|  |
|saleStakeholder/contact/postAddress/wgs84longitude| *None* |Stakeholder - Postal address - Longitude: Longitude|  |
|saleStakeholder/contact/postAddress/formattedAddress| *None* |Stakeholder - Postal address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/postAddress/formattedMultiLineAddress| *None* |Stakeholder - Postal address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/addressId| *None* |Stakeholder - Street address - Address ID: Database ID for the address record|  |
|saleStakeholder/contact/streetAddress/line1| *None* |Stakeholder - Street address - Address 1: First line of the address|  |
|saleStakeholder/contact/streetAddress/line2| *None* |Stakeholder - Street address - Address 2: Second line of the address|  |
|saleStakeholder/contact/streetAddress/line3| *None* |Stakeholder - Street address - Address 3: Third line of the address|  |
|saleStakeholder/contact/streetAddress/county| *None* |Stakeholder - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/streetAddress/city| *None* |Stakeholder - Street address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/contact/streetAddress/zip| *None* |Stakeholder - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/contact/streetAddress/state| *None* |Stakeholder - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/streetAddress/wgs84latitude| *None* |Stakeholder - Street address - Latitude: Latitude|  |
|saleStakeholder/contact/streetAddress/wgs84longitude| *None* |Stakeholder - Street address - Longitude: Longitude|  |
|saleStakeholder/contact/streetAddress/formattedAddress| *None* |Stakeholder - Street address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/formattedMultiLineAddress| *None* |Stakeholder - Street address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/addressId| *None* |Stakeholder - Search address - Address ID: Database ID for the address record|  |
|saleStakeholder/contact/restrictionAddress/line1| *None* |Stakeholder - Search address - Address 1: First line of the address|  |
|saleStakeholder/contact/restrictionAddress/line2| *None* |Stakeholder - Search address - Address 2: Second line of the address|  |
|saleStakeholder/contact/restrictionAddress/line3| *None* |Stakeholder - Search address - Address 3: Third line of the address|  |
|saleStakeholder/contact/restrictionAddress/county| *None* |Stakeholder - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/restrictionAddress/city| *None* |Stakeholder - Search address - City: This criterion corresponds to the City field on the Company card.|  |
|saleStakeholder/contact/restrictionAddress/zip| *None* |Stakeholder - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|saleStakeholder/contact/restrictionAddress/state| *None* |Stakeholder - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|saleStakeholder/contact/restrictionAddress/wgs84latitude| *None* |Stakeholder - Search address - Latitude: Latitude|  |
|saleStakeholder/contact/restrictionAddress/wgs84longitude| *None* |Stakeholder - Search address - Longitude: Longitude|  |
|saleStakeholder/contact/restrictionAddress/formattedAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/formattedMultiLineAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/url/URLAddress| *None* |Stakeholder - URL|  |
|saleStakeholder/contact/url/URLDescription| *None* |Stakeholder - Description|  |
|saleStakeholder/contact/contactAssociate/firstName| *None* |Stakeholder - First name: Displays the contact's first name|  |
|saleStakeholder/contact/contactAssociate/lastName| *None* |Stakeholder - Last name: Displays the contact's last name|  |
|saleStakeholder/contact/contactAssociate/middleName| *None* |Stakeholder - Middle Name: Displays the contact's middle name.|  |
|saleStakeholder/contact/contactAssociate/fullName| *None* |Stakeholder - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|saleStakeholder/contact/contactAssociate/contactId| *None* |Stakeholder - Company ID: Database ID of the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/personId| *None* |Stakeholder - Contact ID: Database ID of the contact row|  |
|saleStakeholder/contact/contactAssociate/mrMrs| *None* |Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/contact/contactAssociate/title| *None* |Stakeholder - Title: Displays whether the contact is addressed as Mr or Ms|  |
|saleStakeholder/contact/contactAssociate/associateDbId| *None* |Stakeholder - ID|  |
|saleStakeholder/contact/contactAssociate/contactName| *None* |Stakeholder - Owning company: Name of the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/contactDepartment| *None* |Stakeholder - Owning department: Name of the department at the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/usergroup| *None* |Stakeholder - Primary group: The user's primary user group|  |
|saleStakeholder/contact/contactAssociate/contactFullName| *None* |Stakeholder - Owner: Name and department of the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/contactCategory| *None* |Stakeholder - Category: Category|  |
|saleStakeholder/contact/contactAssociate/role| *None* |Stakeholder - Role: Role|  |
|saleStakeholder/contact/contactAssociate/assocName| *None* |Stakeholder - User ID: User ID|  |
|saleStakeholder/contact/contactAssociate/assocTooltip| *None* |Stakeholder - Description: Description|  |
|saleStakeholder/contact/contactAssociate/assocType| *None* |Stakeholder - Type: Type of user: associate, external user, system user, anonymous account|  |
|saleStakeholder/contact/contactAssociate/ejUserId| *None* |Stakeholder - Service user ID: The database ID of a Service user|  |
|saleStakeholder/contact/contactAssociate/simultaneousEjUser| *None* |Stakeholder - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|saleStakeholder/contact/contactAssociate/ejDisplayName| *None* |Stakeholder - Nick name: User's nick name in Service|  |
|saleStakeholder/contact/contactAssociate/ejStatus| *None* |Stakeholder - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|saleStakeholder/contact/contactAssociate/credentialType| *None* |Stakeholder - Auth. type: What type of credentials to use when this user logs in|  |
|saleStakeholder/contact/contactAssociate/credentialDisplayValue| *None* |Stakeholder - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|saleStakeholder/contact/contactAssociate/isActive| *None* |Stakeholder - Active: Is this user active, and should be able to log in?|  |
|saleStakeholder/contact/contactAssociate/isActiveText| *None* |Stakeholder - Active status: Is this user active, and should be able to log in?|  |
|saleStakeholder/contact/contactAssociate/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/contact/contactAssociate/otherGroups| *None* |Stakeholder - Other groups: Other groups|  |
|saleStakeholder/contact/contactAssociate/userName| *None* |Stakeholder - User name: User name|  |
|saleStakeholder/contact/contactAssociate/personEmail| *None* |Stakeholder - E-mail|  |
|saleStakeholder/contact/contactInterestIds| *None* |Stakeholder - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|saleStakeholder/contact/contactUdef/SuperOffice:1| *None* |Stakeholder - companyshorttext: tooltipshorttext|  |
|saleStakeholder/contact/contactUdef/SuperOffice:2| *None* |Stakeholder - companylongtext: tooltiplongtext|  |
|saleStakeholder/contact/contactUdef/SuperOffice:3| *None* |Stakeholder - companynumber|  |
|saleStakeholder/contact/contactUdef/SuperOffice:4| *None* |Stakeholder - companydate|  |
|saleStakeholder/contact/contactUdef/SuperOffice:5| *None* |Stakeholder - companyunlimiteddate: tooltipunlimiteddate|  |
|saleStakeholder/contact/contactUdef/SuperOffice:6| *None* |Stakeholder - companycheckbox|  |
|saleStakeholder/contact/contactUdef/SuperOffice:7| *None* |Stakeholder - companydropdownlistbox|  |
|saleStakeholder/contact/contactUdef/SuperOffice:8| *None* |Stakeholder - companydecimal|  |
|saleStakeholder/contact/contactUdef/SuperOffice:9| *None* |Stakeholder - page1saleonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:10| *None* |Stakeholder - page1marketingonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:11| *None* |Stakeholder - page1adminonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:12| *None* |Stakeholder - Udlist one: Static tooltip for udlist one|  |
|saleStakeholder/contact/contactUdef/SuperOffice:13| *None* |Stakeholder - Udlist two: Static tooltip for udlist two|  |
|saleStakeholder/contact/contactExtra/x\_contact\_integer| *None* |Stakeholder - Extra Integer: Custom integer field|  |
|saleStakeholder/contact/contactExtra/x\_contact\_hidden\_integer| *None* |Stakeholder - Extra hidden integer: Custom integer field - hidden|  |
|saleStakeholder/contact/contactExtra/x\_contact\_default\_integer| *None* |Stakeholder - Extra Default Integer: Custom integer field with default value 123.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_float| *None* |Stakeholder - Extra Float: Custom float field with 3 decimals|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/contact/contactExtra/x\_contact\_longtext| *None* |Stakeholder - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|saleStakeholder/contact/contactExtra/x\_contact\_dropdown| *None* |Stakeholder - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_date| *None* |Stakeholder - Extra date: Custom date field. User current as default.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_datetime| *None* |Stakeholder - Extra DateTime: Custom Date Time field. No default value. External|  |
|saleStakeholder/contact/contactExtra/x\_contact\_time| *None* |Stakeholder - Extra time: Custom time field.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_boolean| *None* |Stakeholder - Extra boolean: Custom boolean field.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_timespan| *None* |Stakeholder - Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|saleStakeholder/contact/contactExtra/x\_contact\_shorttext| *None* |Stakeholder - Extra short text: Custom short text field. Keep HTML tags.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_short\_dropdown| *None* |Stakeholder - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_contact\_relation| *None* |Stakeholder - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|saleStakeholder/contact/contactExtra/x\_contact\_request\_relation| *None* |Stakeholder - Extra Request relation: Request relation on company|  |
|saleStakeholder/contact/contactExtra/x\_contact\_contact| *None* |Stakeholder - Extra contact relation: Contact relation on company|  |
|saleStakeholder/contact/NumberOfActivities| *None* |Stakeholder - Number of activities|  |
|saleStakeholder/contact/NumberOfActivitiesInPeriod| *None* |Stakeholder - Number of activities in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedActivities| *None* |Stakeholder - Number of non-completed activities|  |
|saleStakeholder/contact/NumberOfNotCompletedActivitiesInPeriod| *None* |Stakeholder - Number of non-completed activities in last 90 days|  |
|saleStakeholder/contact/LastActivity| *None* |Stakeholder - Date of last activity|  |
|saleStakeholder/contact/LastCompletedActivity| *None* |Stakeholder - Date of last completed activity|  |
|saleStakeholder/contact/LastDoByActivity| *None* |Stakeholder - Date of last non-completed activity|  |
|saleStakeholder/contact/NumberOfSales| *None* |Stakeholder - Number of sales|  |
|saleStakeholder/contact/NumberOfSalesInPeriod| *None* |Stakeholder - Number of sales in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedSales| *None* |Stakeholder - Number of non-completed sales|  |
|saleStakeholder/contact/NumberOfNotCompletedSalesInPeriod| *None* |Stakeholder - Number of non-completed sales in last 90 days|  |
|saleStakeholder/contact/LastSale| *None* |Stakeholder - Date of last sale|  |
|saleStakeholder/contact/LastCompletedSale| *None* |Stakeholder - Date of last completed sale|  |
|saleStakeholder/contact/LastDoBySale| *None* |Stakeholder - Date of last non-completed sale|  |
|saleStakeholder/contact/NumberOfTickets| *None* |Stakeholder - Number of requests|  |
|saleStakeholder/contact/NumberOfTicketsInPeriod| *None* |Stakeholder - Number of requests in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedTickets| *None* |Stakeholder - Number of non-completed requests|  |
|saleStakeholder/contact/NumberOfNotCompletedTicketsInPeriod| *None* |Stakeholder - Number of non-completed requests in last 90 days|  |
|saleStakeholder/contact/LastTicket| *None* |Stakeholder - Date of last request|  |
|saleStakeholder/contact/LastCompletedTicket| *None* |Stakeholder - Date of last completed request|  |
|saleStakeholder/contact/LastDoByTicket| *None* |Stakeholder - Date of last non-completed request|  |
|saleStakeholder/contact/SaintStatus1| *None* |Stakeholder - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|saleStakeholder/contact/SaintStatus2| *None* |Stakeholder - C-company: Kundens navn starter med bokstaven C|  |
|saleStakeholder/contact/saintSaleStatus| *None* |Stakeholder - With status|  |
|saleStakeholder/contact/saintAmountClass| *None* |Stakeholder - Amount class|  |
|saleStakeholder/contact/saintActivityType| *None* |Stakeholder - SAINT type|  |
|saleStakeholder/contact/saintDirection| *None* |Stakeholder - Direction|  |
|saleStakeholder/contact/saintIntention| *None* |Stakeholder - Intention|  |
|saleStakeholder/contact/saintTicketStatus| *None* |Stakeholder - Status|  |
|saleStakeholder/contact/saintTicketCategory| *None* |Stakeholder - Category|  |
|quote/quoteId| *None* |Quote ID: SuperOffice database ID of quote record|  |
|quote/poNumber| *None* |P.O. Number: Customer's purchase order number|  |
|quote/orderComment| *None* |Comment: Customer's comment|  |
|quote/connectionId| *None* |DB-ID: Database ID|  |
|quote/registeredDate| *None* |Registered at: Displays the date when the quote was registered.|  |
|quote/version/quoteVersionId| *None* |ID: Database ID of QuoteVersion record|  |
|quote/version/description| *None* |Description: Description of the quote version|  |
|quote/version/number| *None* |Number: Reference number for the quote version|  |
|quote/version/sent| *None* |Sent: The date the quote (version) was sent to the customer|  |
|quote/version/expiration| *None* |Expiry date: The last date that the quote is valid|  |
|quote/version/state| *None* |State: The current state the quote is in|  |
|quote/version/status| *None* |Quote status: Status field showing the status of each line.|  |
|quote/version/reason| *None* |Quote reason: The reason or explanation for any status other than 'OK'.|  |
|quote/version/paymentTerms| *None* |Payment terms: Payment terms|  |
|quote/version/paymentType| *None* |Payment type: Payment type|  |
|quote/version/deliveryTerms| *None* |Delivery terms: Delivery terms|  |
|quote/version/deliveryType| *None* |Delivery type: Delivery type|  |
|quote/version/approvedBy| *None* |Approved by: Associate who approved a quote that broke one or more of the workflow rules that trigger an approval process|  |
|quote/version/approvalRegisteredBy| *None* |Approval reg by: Associate who entered the approval of a quote that broke one or more of the workflow rules that trigger an approval process.  Not necessarily the person who approved the quote.|  |
|quote/version/approvedText| *None* |Approval comment: Comment added to the approval of a quote that broke one or more of the workflow rules that trigger an approval process|  |
|quote/version/approvedDate| *None* |Approved date: Date of approval of a quote that broke one or more of the workflow rules that trigger an approval process|  |
|quote/version/extraField1| *None* |Extra field 1: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField2| *None* |Extra field 2: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField3| *None* |Extra field 3: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField4| *None* |Extra field 4: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/extraField5| *None* |Extra field 5: One of the extra fields on the product; meaning is installation dependent|  |
|quote/version/alternative/quoteAlternativeId| *None* |QuoteAlternative ID: SuperOffice database ID of the quote alternative record|  |
|quote/version/alternative/quoteVersionId| *None* |ID: Database ID of QuoteVersion record|  |
|quote/version/alternative/name| *None* |Name: Name of the quote alternative|  |
|quote/version/alternative/description| *None* |Description: Description of the quote alternative|  |
|quote/version/alternative/status| *None* |Quote status: Status field showing the status of each line.|  |
|quote/version/alternative/reason| *None* |Quote reason: The reason or explanation for any status other than 'OK'.|  |
|quote/version/alternative/erpDiscountPercent| *None* |ERP Discount %: Discount percentage suggested by ERP system|  |
|quote/version/alternative/erpDiscountAmount| *None* |ERP Discount: Discount amount suggested by ERP system|  |
|quote/version/alternative/discountPercent| *None* |Discount %: Enter discount in percent for entire alternative|  |
|quote/version/alternative/discountAmount| *None* |Discount: Enter total discount for entire alternative|  |
|quote/version/alternative/vatInfo| *None* |VAT Info: Information about value-added and other taxes|  |
|quote/version/alternative/vat| *None* |VAT: Value-added and other taxes, total amount|  |
|quote/version/alternative/earningPercent| *None* |Earnings %: Total Earnings as a percentage of the total price, of all lines in the quote alternative, including all discounts|  |
|quote/version/alternative/earningAmount| *None* |Earnings: Total Earnings for all lines in the quote alternative, including all discounts|  |
|quote/version/alternative/totalPrice| *None* |Total: Total price of all items in the quote alternative, including all discounts|  |
|quote/version/alternative/extraField1| *None* |Extra 1: Extra field 1 on the quote alternative|  |
|quote/version/alternative/extraField2| *None* |Extra 2: Extra field 2 on the quote alternative|  |
|quote/version/alternative/extraField3| *None* |Extra 3: Extra field 3on the quote alternative|  |
|quote/version/alternative/extraField4| *None* |Extra 4: Extra field 4 on the quote alternative|  |
|quote/version/alternative/extraField5| *None* |Extra 5: Extra field 5 on the quote alternative|  |
|quote/version/alternative/alternativeOrdering| *None* |QuoteAlternative ID: SuperOffice database ID of the quote alternative record|  |
|quote/version/alternative/subTotal| *None* |Total before discount: Total of all lines, before applying the Alternative discount|  |
|quote/version/alternative/totalPriceIncVAT| *None* |Total incl. VAT: Total of all lines, including VAT|  |
|quote/version/alternative/vatAmount| *None* |VAT: VAT (amount) for the alternative|  |
|quote/version/alternative/quoteline/quoteLineId| *None* |Quote line ID: Database identity of the quote line|  |
|quote/version/alternative/quoteline/quoteAlternativeId| *None* |Alternative ID: The database identity of the quote alternative|  |
|quote/version/alternative/quoteline/erpProductKey| *None* |Product key: The foreign key of the product the quote line is based on.|  |
|quote/version/alternative/quoteline/rank| *None* |Rank: Shows the rank of a product|  |
|quote/version/alternative/quoteline/quantity| *None* |Quantity: The quantity that is offered|  |
|quote/version/alternative/quoteline/name| *None* |Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.|  |
|quote/version/alternative/quoteline/description| *None* |Description: Description of the product that is offered|  |
|quote/version/alternative/quoteline/code| *None* |Code: The product or article code. This code is created to help you quickly find products you offer regularly.|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|quote/version/alternative/quoteline/quantityUnit| *None* |Unit: The unit of the product that is offered.|  |
|quote/version/alternative/quoteline/priceUnit| *None* |Price unit: What is the price unit defined in|  |
|quote/version/alternative/quoteline/url| *None* |Web address: The web address of the product info.|  |
|quote/version/alternative/quoteline/subscriptionUnit| *None* |Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month|  |
|quote/version/alternative/quoteline/subscriptionQuantity| *None* |Subscription quantity: Number of subscription units offered|  |
|quote/version/alternative/quoteline/UnitListPriceSubscriptionQuantity| *None* |Subscription list price: Unit price * subscription quantity|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionUnit| *None* |P/S Unit: Price unit/subscription unit|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionQuantityUnit| *None* |Expanded unit: Price unit @ subscription quantity + unit|  |
|quote/version/alternative/quoteline/vatInfo| *None* |VAT info: |  |
|quote/version/alternative/quoteline/vat| *None* |VAT: May be filled out by the ERP system|  |
|quote/version/alternative/quoteline/unitCost| *None* |Cost: Cost per item.|  |
|quote/version/alternative/quoteline/unitMinimumPrice| *None* |Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.|  |
|quote/version/alternative/quoteline/unitListPrice| *None* |List price: List price of a unit|  |
|quote/version/alternative/quoteline/totalPrice| *None* |Total: List price * Quantity - Discount Amount|  |
|quote/version/alternative/quoteline/totalCost| *None* |Total cost|  |
|quote/version/alternative/quoteline/quoteLineThumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|quote/version/alternative/quoteline/quoteLineThumbnailLarge| *None* |Thumbnail: A miniature version of the product picture|  |
|quote/version/alternative/quoteline/discountAmount| *None* |Discount: Discount amount given by salesperson|  |
|quote/version/alternative/quoteline/discountPercent| *None* |Discount (%: Discount percent given by salesperson|  |
|quote/version/alternative/quoteline/earningAmount| *None* |Earnings: Amount of Earnings (Total - Cost) on the line, after discount|  |
|quote/version/alternative/quoteline/earningPercent| *None* |Earnings (%: Percentage Earnings on the line (Total - Cost / Total), after discount|  |
|quote/version/alternative/quoteline/updatedBy| *None* |Updated by: The user who last updated the data|  |
|quote/version/alternative/quoteline/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|quote/version/alternative/quoteline/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|quote/version/alternative/quoteline/registeredBy| *None* |Registered by: The user who registered the data|  |
|quote/version/alternative/quoteline/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|quote/version/alternative/quoteline/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|quote/version/alternative/quoteline/productCategoryKey| *None* |Product category: The category the product is defined in|  |
|quote/version/alternative/quoteline/productFamilyKey| *None* |Product family: The family the product is defined in|  |
|quote/version/alternative/quoteline/productTypeKey| *None* |Product type: The type of product|  |
|quote/version/alternative/quoteline/status| *None* |Quote status: Status field showing the status of each line.|  |
|quote/version/alternative/quoteline/subTotal| *None* |Sum: Sum of Quantity * Unit list price|  |
|quote/version/alternative/quoteline/vatAmount| *None* |VAT (amount: The calculated VAT amount|  |
|quote/version/alternative/quoteline/totalPriceIncVAT| *None* |Total incl. VAT: Total including VAT|  |
|quote/version/alternative/quoteline/totalPriceWithAlternativeDiscount| *None* |Total incl. alt. disc: Total, including any discount percentage set on the alternative|  |
|name| *None* |Company name|  |
|department| *None* |Department|  |
|nameDepartment| *None* |Company: Displays the company an activity is linked to|  |
|hasInfoText| *None* |Has note: Displays an icon indicating if there is additional information available about the contact|  |
|hasInterests| *None* |Has interests: Displays an Icon indicating if the contact has active interests|  |
|category| *None* |Category|  |
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
|restrictionPostalAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|restrictionPostalAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|restrictionPostalAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|restrictionPostalAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|restrictionPostalAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|restrictionPostalAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|restrictionPostalAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|restrictionPostalAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|restrictionPostalAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|restrictionPostalAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|restrictionPostalAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|contactAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|contactAssociate/contactCategory| *None* |Category: Category|  |
|contactAssociate/role| *None* |Role : Role|  |
|contactAssociate/assocName| *None* |User ID : User ID|  |
|contactAssociate/assocTooltip| *None* |Description : Description|  |
|contactAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|contactAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|contactAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|contactAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|contactAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|contactAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|contactAssociate/otherGroups| *None* |Other groups: Other groups|  |
|contactAssociate/userName| *None* |User name: User name|  |
|contactAssociate/personEmail| *None* |E-mail|  |
|contactSupportAssociate/firstName| *None* |Our service contact - First name: Displays the contact's first name|  |
|contactSupportAssociate/lastName| *None* |Our service contact - Last name: Displays the contact's last name|  |
|contactSupportAssociate/middleName| *None* |Our service contact - Middle Name: Displays the contact's middle name.|  |
|contactSupportAssociate/fullName| *None* |Our service contact - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|contactSupportAssociate/contactId| *None* |Our service contact - Company ID: Database ID of the company the user belongs to|  |
|contactSupportAssociate/personId| *None* |Our service contact - Contact ID: Database ID of the contact row|  |
|contactSupportAssociate/mrMrs| *None* |Our service contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contactSupportAssociate/title| *None* |Our service contact - Title: Displays whether the contact is addressed as Mr or Ms|  |
|contactSupportAssociate/associateDbId| *None* |Our service contact - ID|  |
|contactSupportAssociate/contactName| *None* |Our service contact - Owning company: Name of the company the user belongs to|  |
|contactSupportAssociate/contactDepartment| *None* |Our service contact - Owning department: Name of the department at the company the user belongs to|  |
|contactSupportAssociate/usergroup| *None* |Our service contact - Primary group: The user's primary user group|  |
|contactSupportAssociate/contactFullName| *None* |Our service contact - Owner: Name and department of the company the user belongs to|  |
|contactSupportAssociate/contactCategory| *None* |Our service contact - Category: Category|  |
|contactSupportAssociate/role| *None* |Our service contact - Role: Role|  |
|contactSupportAssociate/assocName| *None* |Our service contact - User ID: User ID|  |
|contactSupportAssociate/assocTooltip| *None* |Our service contact - Description: Description|  |
|contactSupportAssociate/assocType| *None* |Our service contact - Type: Type of user: associate, external user, system user, anonymous account|  |
|contactSupportAssociate/ejUserId| *None* |Our service contact - Service user ID: The database ID of a Service user|  |
|contactSupportAssociate/simultaneousEjUser| *None* |Our service contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|contactSupportAssociate/ejDisplayName| *None* |Our service contact - Nick name: User's nick name in Service|  |
|contactSupportAssociate/ejStatus| *None* |Our service contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|contactSupportAssociate/credentialType| *None* |Our service contact - Auth. type: What type of credentials to use when this user logs in|  |
|contactSupportAssociate/credentialDisplayValue| *None* |Our service contact - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|contactSupportAssociate/isActive| *None* |Our service contact - Active: Is this user active, and should be able to log in?|  |
|contactSupportAssociate/isActiveText| *None* |Our service contact - Active status: Is this user active, and should be able to log in?|  |
|contactSupportAssociate/portraitThumbnail| *None* |Our service contact - Person image: Person image|  |
|contactSupportAssociate/otherGroups| *None* |Our service contact - Other groups: Other groups|  |
|contactSupportAssociate/userName| *None* |Our service contact - User name: User name|  |
|contactSupportAssociate/personEmail| *None* |Our service contact - E-mail|  |
|contactSupportPerson/personId| *None* |User support contact - DB ID: Displays the database ID of a contact|  |
|contactSupportPerson/firstName| *None* |User support contact - First name: Displays the contact's first name|  |
|contactSupportPerson/lastName| *None* |User support contact - Last name: Displays the contact's last name|  |
|contactSupportPerson/middleName| *None* |User support contact - Middle name: Displays the contact's middle name.|  |
|contactSupportPerson/fullName| *None* |User support contact - Contact: Displays the contact to which an item is linked|  |
|contactSupportPerson/contactId| *None* |User support contact - Company ID: Database ID of company|  |
|contactSupportPerson/hasInfoText| *None* |User support contact - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|contactSupportPerson/hasInterests| *None* |User support contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|contactSupportPerson/personHasInterests| *None* |User support contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|contactSupportPerson/mrMrs| *None* |User support contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|contactSupportPerson/position| *None* |User support contact - Position|  |
|contactSupportPerson/personNumber| *None* |User support contact - Number: Displays the contact's number|  |
|contactSupportPerson/title| *None* |User support contact - Title: Displays the contact's job title|  |
|contactSupportPerson/personCountry| *None* |User support contact - Country: Country|  |
|contactSupportPerson/personCountryId| *None* |User support contact - Country ID: Country ID|  |
|contactSupportPerson/personNoMail| *None* |User support contact - No Mailings: Displays the contact's No Mailings checkbox|  |
|contactSupportPerson/rank| *None* |User support contact - Rank: Displays a contact's current rank|  |
|contactSupportPerson/birthdate| *None* |User support contact - Birthdate: Displays the contact's date of birth|  |
|contactSupportPerson/associateType| *None* |User support contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|contactSupportPerson/useAsMailingAddress| *None* |User support contact - Use as postal address: Use as postal address|  |
|contactSupportPerson/personSource| *None* |User support contact - Source: Source (Contact)|  |
|contactSupportPerson/retired| *None* |User support contact - Former employee: Indicates whether the contact has retired/left the company|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactSupportPerson/birthYear| *None* |User support contact - Birth year: Displays contact's birth year|  |
|contactSupportPerson/birthMonth| *None* |User support contact - Birth month: Displays contact's birth month|  |
|contactSupportPerson/birthDay| *None* |User support contact - Birth day: Displays contact's birth day (day of month)|  |
|contactSupportPerson/kanaFirstName| *None* |User support contact - First name, kana: Contact's first name, in kana alphabet|  |
|contactSupportPerson/kanaLastName| *None* |User support contact - Last name, kana: Contact's last name, in kana alphabet|  |
|contactSupportPerson/personUpdatedBy| *None* |User support contact - Updated by: The user who last updated the data|  |
|contactSupportPerson/personUpdatedByFullName| *None* |User support contact - Updated by - Full name: The user who last updated the data|  |
|contactSupportPerson/personUpdatedDate| *None* |User support contact - Updated: The date/time the data was last updated in UTC.|  |
|contactSupportPerson/personRegisteredBy| *None* |User support contact - Registered by: The user who registered the data|  |
|contactSupportPerson/personRegisteredByFullName| *None* |User support contact - Registered by - Full name: The user who registered the data|  |
|contactSupportPerson/personRegisteredDate| *None* |User support contact - Registered date: The date/time the data was registered in UTC.|  |
|contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|contactSupportPerson/personActiveErpLinks| *None* |User support contact - ERP connected: Is there an active ERP Sync?|  |
|contactSupportPerson/ticketPriority| *None* |User support contact - Service priority: Default service priority for this contact|  |
|contactSupportPerson/supportLanguage| *None* |User support contact - Preferred language: Preferred language used for reply templates and more|  |
|contactSupportPerson/supportAssociate| *None* |User support contact - Our service contact: Default service contact for this contact|  |
|contactSupportPerson/supportAssociateFullName| *None* |User support contact - Our service contact - Full name: Default service contact for this contact|  |
|contactSupportPerson/personAssociateId| *None* |User support contact - Our contact: Displays our contact|  |
|contactSupportPerson/personAssociateFullName| *None* |User support contact - Our contact - Full name: Displays our contact|  |
|contactSupportPerson/personCategory| *None* |User support contact - Category|  |
|contactSupportPerson/personBusiness| *None* |User support contact - Business|  |
|contactSupportPerson/personDeletedDate| *None* |User support contact - Deleted date: Deleted date|  |
|contactSupportPerson/hasCompany| *None* |User support contact - Has company: The contact is associated with a company|  |
|contactSupportPerson/isProjectMember| *None* |User support contact - Is project member: This person is a project member|  |
|contactSupportPerson/isStakeholder| *None* |User support contact - Is stakeholder: This person is a sale stakeholder|  |
|contactSupportPerson/who| *None* |User support contact - Full name: Displays the contact's full name.|  |
|contactSupportPerson/personInfo/textId| *None* |User support contact - Text ID|  |
|contactSupportPerson/personInfo/infoText| *None* |User support contact - Information: Displays the text entered in the description field|  |
|contactSupportPerson/personUdef/SuperOffice:1| *None* |User support contact - contactshorttext: tooltipshorttext|  |
|contactSupportPerson/personUdef/SuperOffice:2| *None* |User support contact - contactlongtext: tooltiplongtext|  |
|contactSupportPerson/personUdef/SuperOffice:3| *None* |User support contact - contactnumber|  |
|contactSupportPerson/personUdef/SuperOffice:4| *None* |User support contact - contactdate|  |
|contactSupportPerson/personUdef/SuperOffice:5| *None* |User support contact - contactunlimiteddate: tooltipunlimiteddate|  |
|contactSupportPerson/personUdef/SuperOffice:6| *None* |User support contact - contactcheckbox|  |
|contactSupportPerson/personUdef/SuperOffice:7| *None* |User support contact - contactdropdownlistbox|  |
|contactSupportPerson/personUdef/SuperOffice:8| *None* |User support contact - contactdecimal|  |
|contactSupportPerson/personUdef/SuperOffice:9| *None* |User support contact - page1saleonly|  |
|contactSupportPerson/personUdef/SuperOffice:10| *None* |User support contact - page1marketingonly|  |
|contactSupportPerson/personUdef/SuperOffice:11| *None* |User support contact - page1adminonly|  |
|contactSupportPerson/personExtra/x\_person\_integer| *None* |User support contact - Extra Integer: Custom person integer|  |
|contactSupportPerson/personExtra/x\_person\_hidden\_integer| *None* |User support contact - Extra hidden integer: Custom integer field that is hidden|  |
|contactSupportPerson/personExtra/x\_person\_float| *None* |User support contact - Extra float: Custom float field|  |
|contactSupportPerson/personExtra/x\_person\_longtext| *None* |User support contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|contactSupportPerson/personExtra/x\_person\_date| *None* |User support contact - Extra date: Custom date field on person. Default value = 28.03.2019|  |
|contactSupportPerson/personExtra/x\_person\_datetime| *None* |User support contact - Extra DateTime: Custom person date and time field. No default|  |
|contactSupportPerson/personExtra/x\_person\_time| *None* |User support contact - Extra time: Custom time field on person. Current time as default|  |
|contactSupportPerson/personExtra/x\_person\_boolean| *None* |User support contact - Extra Boolean: Custom boolean field on person. Default checked|  |
|contactSupportPerson/personExtra/x\_person\_timespan| *None* |User support contact - Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|contactSupportPerson/personExtra/x\_person\_shorttext| *None* |User support contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|contactSupportPerson/personExtra/x\_person\_shorttext\_list| *None* |User support contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|contactSupportPerson/personExtra/x\_person\_user\_relation| *None* |User support contact - Extra user relation: Custom person-user relation field|  |
|contactSupportPerson/personExtra/x\_person\_category\_relation| *None* |User support contact - Extra category relation: Custom person-category relation|  |
|contactSupportPerson/personExtra/x\_person\_priority\_relation| *None* |User support contact - Extra priority relation: Custom person-priority relation|  |
|contactSupportPerson/personExtra/x\_person\_request\_relation| *None* |User support contact - Extra request relation: Request relation on contact|  |
|contactSupportPerson/personExtra/x\_person\_appointment\_relation| *None* |User support contact - Extra appointment relation: Appointment relation on person|  |
|contactSupportPerson/personExtra/x\_person\_contact\_relation| *None* |User support contact - Extra company relation: Company relation on contact|  |
|contactSupportPerson/personExtra/y\_rental/id| *None* |User support contact - Rental - id: Displays the row's primary key (y\_rental)|  |
|contactSupportPerson/personExtra/y\_rental/x\_start| *None* |User support contact - Rental - Start rental|  |
|contactSupportPerson/personExtra/y\_rental/x\_end| *None* |User support contact - Rental - End|  |
|contactSupportPerson/personExtra/y\_rental/x\_amount| *None* |User support contact - Rental - Amount: Number to rent. Default = 1|  |
|contactSupportPerson/personExtra/y\_rental/x\_contact| *None* |User support contact - Rental - Renter: Company that rents equipment|  |
|contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name| *None* |User support contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|contactSupportPerson/isMailingRecipient| *None* |User support contact - Is mailing recipient: isMailingRecipient|  |
|contactSupportPerson/hasStoreConsent| *None* |User support contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/withdrawnStoreConsent| *None* |User support contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/hasEmarketingConsent| *None* |User support contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/withdrawnEmarketingConsent| *None* |User support contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/subscription| *None* |User support contact - Subscription: Subscription for marketing|  |
|contactSupportPerson/legalBaseStore| *None* |User support contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/legalBaseEmarketing| *None* |User support contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/consentSourceStore| *None* |User support contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/consentSourceEmarketing| *None* |User support contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactExtra/x\_contact\_request\_relation| *None* |Extra Request relation: Request relation on company|  |
|contactExtra/x\_contact\_contact| *None* |Extra contact relation: Contact relation on company|  |
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
|selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|selectionIdRequest| *None* |Selection ID: Database ID of selection which members are to be fetched from|  |
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
|personBusiness| *None* |Business|  |
|personDeletedDate| *None* |Deleted date: Deleted date|  |
|hasCompany| *None* |Has company: The contact is associated with a company|  |
|isProjectMember| *None* |Is project member: This person is a project member|  |
|isStakeholder| *None* |Is stakeholder: This person is a sale stakeholder|  |
|favouritePersonAssociateId| *None* |Associate ID: Associate ID|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|personExtra/y\_rental/x\_start| *None* |Rental - Start rental|  |
|personExtra/y\_rental/x\_end| *None* |Rental - End|  |
|personExtra/y\_rental/x\_amount| *None* |Rental - Amount: Number to rent. Default = 1|  |
|personExtra/y\_rental/x\_contact| *None* |Rental - Renter: Company that rents equipment|  |
|personExtra/y\_rental/y\_equipment/x\_name| *None* |Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|personSourceRelation/personId| *None* |Source - DB ID: Displays the database ID of a contact|  |
|personSourceRelation/firstName| *None* |Source - First name: Displays the contact's first name|  |
|personSourceRelation/lastName| *None* |Source - Last name: Displays the contact's last name|  |
|personSourceRelation/middleName| *None* |Source - Middle name: Displays the contact's middle name.|  |
|personSourceRelation/fullName| *None* |Source - Contact: Displays the contact to which an item is linked|  |
|personSourceRelation/contactId| *None* |Source - Company ID: Database ID of company|  |
|personSourceRelation/hasInfoText| *None* |Source - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|personSourceRelation/hasInterests| *None* |Source - Has interests: Displays an Icon indicating if the contact has active interests|  |
|personSourceRelation/personHasInterests| *None* |Source - Has interests: Displays an Icon indicating if the contact has active interests|  |
|personSourceRelation/mrMrs| *None* |Source - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personSourceRelation/position| *None* |Source - Position|  |
|personSourceRelation/personNumber| *None* |Source - Number: Displays the contact's number|  |
|personSourceRelation/title| *None* |Source - Title: Displays the contact's job title|  |
|personSourceRelation/personCountry| *None* |Source - Country: Country|  |
|personSourceRelation/personCountryId| *None* |Source - Country ID: Country ID|  |
|personSourceRelation/personNoMail| *None* |Source - No Mailings: Displays the contact's No Mailings checkbox|  |
|personSourceRelation/rank| *None* |Source - Rank: Displays a contact's current rank|  |
|personSourceRelation/birthdate| *None* |Source - Birthdate: Displays the contact's date of birth|  |
|personSourceRelation/associateType| *None* |Source - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personSourceRelation/useAsMailingAddress| *None* |Source - Use as postal address: Use as postal address|  |
|personSourceRelation/personSource| *None* |Source - Source: Source (Contact)|  |
|personSourceRelation/retired| *None* |Source - Former employee: Indicates whether the contact has retired/left the company|  |
|personSourceRelation/birthYear| *None* |Source - Birth year: Displays contact's birth year|  |
|personSourceRelation/birthMonth| *None* |Source - Birth month: Displays contact's birth month|  |
|personSourceRelation/birthDay| *None* |Source - Birth day: Displays contact's birth day (day of month)|  |
|personSourceRelation/kanaFirstName| *None* |Source - First name, kana: Contact's first name, in kana alphabet|  |
|personSourceRelation/kanaLastName| *None* |Source - Last name, kana: Contact's last name, in kana alphabet|  |
|personSourceRelation/personUpdatedBy| *None* |Source - Updated by: The user who last updated the data|  |
|personSourceRelation/personUpdatedByFullName| *None* |Source - Updated by - Full name: The user who last updated the data|  |
|personSourceRelation/personUpdatedDate| *None* |Source - Updated: The date/time the data was last updated in UTC.|  |
|personSourceRelation/personRegisteredBy| *None* |Source - Registered by: The user who registered the data|  |
|personSourceRelation/personRegisteredByFullName| *None* |Source - Registered by - Full name: The user who registered the data|  |
|personSourceRelation/personRegisteredDate| *None* |Source - Registered date: The date/time the data was registered in UTC.|  |
|personSourceRelation/portraitThumbnail| *None* |Source - Person image: Person image|  |
|personSourceRelation/personActiveErpLinks| *None* |Source - ERP connected: Is there an active ERP Sync?|  |
|personSourceRelation/ticketPriority| *None* |Source - Service priority: Default service priority for this contact|  |
|personSourceRelation/supportLanguage| *None* |Source - Preferred language: Preferred language used for reply templates and more|  |
|personSourceRelation/supportAssociate| *None* |Source - Our service contact: Default service contact for this contact|  |
|personSourceRelation/supportAssociateFullName| *None* |Source - Our service contact - Full name: Default service contact for this contact|  |
|personSourceRelation/personAssociateId| *None* |Source - Our contact: Displays our contact|  |
|personSourceRelation/personAssociateFullName| *None* |Source - Our contact - Full name: Displays our contact|  |
|personSourceRelation/personCategory| *None* |Source - Category|  |
|personSourceRelation/personBusiness| *None* |Source - Business|  |
|personSourceRelation/personDeletedDate| *None* |Source - Deleted date: Deleted date|  |
|personSourceRelation/hasCompany| *None* |Source - Has company: The contact is associated with a company|  |
|personSourceRelation/isProjectMember| *None* |Source - Is project member: This person is a project member|  |
|personSourceRelation/isStakeholder| *None* |Source - Is stakeholder: This person is a sale stakeholder|  |
|personSourceRelation/restrictionContactId| *None* |Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/restrictionPersonId| *None* |Source - Company ID: Database ID of company to fetch relations for|  |
|personSourceRelation/who| *None* |Source - Full name: Full name of company/contact|  |
|personSourceRelation/personPersonRelation| *None* |Source - Contact-to-contact relation: Name of relation, not taking into account the relation direction|  |
|personTargetRelation/personId| *None* |Target - DB ID: Displays the database ID of a contact|  |
|personTargetRelation/firstName| *None* |Target - First name: Displays the contact's first name|  |
|personTargetRelation/lastName| *None* |Target - Last name: Displays the contact's last name|  |
|personTargetRelation/middleName| *None* |Target - Middle name: Displays the contact's middle name.|  |
|personTargetRelation/fullName| *None* |Target - Contact: Displays the contact to which an item is linked|  |
|personTargetRelation/contactId| *None* |Target - Company ID: Database ID of company|  |
|personTargetRelation/hasInfoText| *None* |Target - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|personTargetRelation/hasInterests| *None* |Target - Has interests: Displays an Icon indicating if the contact has active interests|  |
|personTargetRelation/personHasInterests| *None* |Target - Has interests: Displays an Icon indicating if the contact has active interests|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personTargetRelation/mrMrs| *None* |Target - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personTargetRelation/position| *None* |Target - Position|  |
|personTargetRelation/personNumber| *None* |Target - Number: Displays the contact's number|  |
|personTargetRelation/title| *None* |Target - Title: Displays the contact's job title|  |
|personTargetRelation/personCountry| *None* |Target - Country: Country|  |
|personTargetRelation/personCountryId| *None* |Target - Country ID: Country ID|  |
|personTargetRelation/personNoMail| *None* |Target - No Mailings: Displays the contact's No Mailings checkbox|  |
|personTargetRelation/rank| *None* |Target - Rank: Displays a contact's current rank|  |
|personTargetRelation/birthdate| *None* |Target - Birthdate: Displays the contact's date of birth|  |
|personTargetRelation/associateType| *None* |Target - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personTargetRelation/useAsMailingAddress| *None* |Target - Use as postal address: Use as postal address|  |
|personTargetRelation/personSource| *None* |Target - Source: Source (Contact)|  |
|personTargetRelation/retired| *None* |Target - Former employee: Indicates whether the contact has retired/left the company|  |
|personTargetRelation/birthYear| *None* |Target - Birth year: Displays contact's birth year|  |
|personTargetRelation/birthMonth| *None* |Target - Birth month: Displays contact's birth month|  |
|personTargetRelation/birthDay| *None* |Target - Birth day: Displays contact's birth day (day of month)|  |
|personTargetRelation/kanaFirstName| *None* |Target - First name, kana: Contact's first name, in kana alphabet|  |
|personTargetRelation/kanaLastName| *None* |Target - Last name, kana: Contact's last name, in kana alphabet|  |
|personTargetRelation/personUpdatedBy| *None* |Target - Updated by: The user who last updated the data|  |
|personTargetRelation/personUpdatedByFullName| *None* |Target - Updated by - Full name: The user who last updated the data|  |
|personTargetRelation/personUpdatedDate| *None* |Target - Updated: The date/time the data was last updated in UTC.|  |
|personTargetRelation/personRegisteredBy| *None* |Target - Registered by: The user who registered the data|  |
|personTargetRelation/personRegisteredByFullName| *None* |Target - Registered by - Full name: The user who registered the data|  |
|personTargetRelation/personRegisteredDate| *None* |Target - Registered date: The date/time the data was registered in UTC.|  |
|personTargetRelation/portraitThumbnail| *None* |Target - Person image: Person image|  |
|personTargetRelation/personActiveErpLinks| *None* |Target - ERP connected: Is there an active ERP Sync?|  |
|personTargetRelation/ticketPriority| *None* |Target - Service priority: Default service priority for this contact|  |
|personTargetRelation/supportLanguage| *None* |Target - Preferred language: Preferred language used for reply templates and more|  |
|personTargetRelation/supportAssociate| *None* |Target - Our service contact: Default service contact for this contact|  |
|personTargetRelation/supportAssociateFullName| *None* |Target - Our service contact - Full name: Default service contact for this contact|  |
|personTargetRelation/personAssociateId| *None* |Target - Our contact: Displays our contact|  |
|personTargetRelation/personAssociateFullName| *None* |Target - Our contact - Full name: Displays our contact|  |
|personTargetRelation/personCategory| *None* |Target - Category|  |
|personTargetRelation/personBusiness| *None* |Target - Business|  |
|personTargetRelation/personDeletedDate| *None* |Target - Deleted date: Deleted date|  |
|personTargetRelation/hasCompany| *None* |Target - Has company: The contact is associated with a company|  |
|personTargetRelation/isProjectMember| *None* |Target - Is project member: This person is a project member|  |
|personTargetRelation/isStakeholder| *None* |Target - Is stakeholder: This person is a sale stakeholder|  |
|personTargetRelation/restrictionContactId| *None* |Target - Company ID: Database ID of company to fetch relations for|  |
|personTargetRelation/restrictionPersonId| *None* |Target - Company ID: Database ID of company to fetch relations for|  |
|personTargetRelation/who| *None* |Target - Full name: Full name of company/contact|  |
|personTargetRelation/personPersonRelation| *None* |Target - Contact-to-contact relation: Name of relation, not taking into account the relation direction|  |
|personSourceRelation/personContactRelation| *None* |Source - Contact-to-company relation: Name of relation, not taking into account the relation direction|  |
|personTargetRelation/contactPersonRelation| *None* |Target - Company-to-contact relation: Name of relation, not taking into account the relation direction|  |
|personAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|personAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|personAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|personAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|personAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|personAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|personAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|personAssociate/associateDbId| *None* |ID|  |
|personAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|personAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|personAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|personAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|personAssociate/contactCategory| *None* |Category: Category|  |
|personAssociate/role| *None* |Role : Role|  |
|personAssociate/assocName| *None* |User ID : User ID|  |
|personAssociate/assocTooltip| *None* |Description : Description|  |
|personAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|personAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|personAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|personAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|personAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|personAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|personAssociate/otherGroups| *None* |Other groups: Other groups|  |
|personAssociate/userName| *None* |User name: User name|  |
|personAssociate/personEmail| *None* |E-mail|  |
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
|correspondingAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|correspondingAssociate/contactCategory| *None* |Category: Category|  |
|correspondingAssociate/role| *None* |Role : Role|  |
|correspondingAssociate/assocName| *None* |User ID : User ID|  |
|correspondingAssociate/assocTooltip| *None* |Description : Description|  |
|correspondingAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|correspondingAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|correspondingAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|correspondingAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|correspondingAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|correspondingAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|correspondingAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|correspondingAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|correspondingAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|correspondingAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|correspondingAssociate/otherGroups| *None* |Other groups: Other groups|  |
|correspondingAssociate/userName| *None* |User name: User name|  |
|correspondingAssociate/personEmail| *None* |E-mail|  |
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
|personContact/phone/formattedNumber| *None* |Phone : Displays phone number|  |
|personContact/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|personContact/deletedDate| *None* |Deleted date: Deleted date|  |
|personContact/mainContact| *None* |Main contact: Main contact for this company|  |
|personContact/contactPhone/formattedNumber| *None* |Telephone - Phone: Displays phone number|  |
|personContact/contactPhone/description| *None* |Telephone - Description: Phone number description|  |
|personContact/contactFax/formattedNumber| *None* |Fax - Phone: Displays phone number|  |
|personContact/contactFax/description| *None* |Fax - Description: Phone number description|  |
|personContact/searchPhone/formattedNumber| *None* |Searchphone - Phone: Displays phone number|  |
|personContact/searchPhone/description| *None* |Searchphone - Description: Phone number description|  |
|personContact/email/emailProtocol| *None* |Protocol: E-mail protocol, such as SMTP|  |
|personContact/email/emailAddress| *None* |E-mail|  |
|personContact/email/emailDescription| *None* |Description|  |
|personContact/email/emailId| *None* |ID|  |
|personContact/email/emailLastSent| *None* |Last sent: The date and time an e-mail was last sent to this address|  |
|personContact/email/emailBounceCount| *None* |Bounce count: Bounce count for this e-mail address|  |
|personContact/email/emailLastBounce| *None* |Last bounce: Date and time for last bounce to this e-mail address|  |
|personContact/email/emailHasBounced| *None* |Has bounced: This checkbox is active if delivery to this e-mail address has failed.|  |
|personContact/postAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|personContact/postAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|personContact/postAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|personContact/postAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|personContact/postAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personContact/postAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|personContact/postAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personContact/postAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personContact/postAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|personContact/postAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|personContact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionPostalAddress/addressId| *None* |Postal address - Address ID: Database ID for the address record|  |
|personContact/restrictionPostalAddress/line1| *None* |Postal address - Address 1: First line of the address|  |
|personContact/restrictionPostalAddress/line2| *None* |Postal address - Address 2: Second line of the address|  |
|personContact/restrictionPostalAddress/line3| *None* |Postal address - Address 3: Third line of the address|  |
|personContact/restrictionPostalAddress/county| *None* |Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personContact/restrictionPostalAddress/city| *None* |Postal address - City: This criterion corresponds to the City field on the Company card.|  |
|personContact/restrictionPostalAddress/zip| *None* |Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personContact/restrictionPostalAddress/state| *None* |Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personContact/restrictionPostalAddress/wgs84latitude| *None* |Postal address - Latitude: Latitude|  |
|personContact/restrictionPostalAddress/wgs84longitude| *None* |Postal address - Longitude: Longitude|  |
|personContact/restrictionPostalAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionPostalAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/addressId| *None* |Street address - Address ID: Database ID for the address record|  |
|personContact/streetAddress/line1| *None* |Street address - Address 1: First line of the address|  |
|personContact/streetAddress/line2| *None* |Street address - Address 2: Second line of the address|  |
|personContact/streetAddress/line3| *None* |Street address - Address 3: Third line of the address|  |
|personContact/streetAddress/county| *None* |Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personContact/streetAddress/city| *None* |Street address - City: This criterion corresponds to the City field on the Company card.|  |
|personContact/streetAddress/zip| *None* |Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personContact/streetAddress/state| *None* |Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personContact/streetAddress/wgs84latitude| *None* |Street address - Latitude: Latitude|  |
|personContact/streetAddress/wgs84longitude| *None* |Street address - Longitude: Longitude|  |
|personContact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/addressId| *None* |Search address - Address ID: Database ID for the address record|  |
|personContact/restrictionAddress/line1| *None* |Search address - Address 1: First line of the address|  |
|personContact/restrictionAddress/line2| *None* |Search address - Address 2: Second line of the address|  |
|personContact/restrictionAddress/line3| *None* |Search address - Address 3: Third line of the address|  |
|personContact/restrictionAddress/county| *None* |Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|personContact/restrictionAddress/city| *None* |Search address - City: This criterion corresponds to the City field on the Company card.|  |
|personContact/restrictionAddress/zip| *None* |Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|personContact/restrictionAddress/state| *None* |Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|personContact/restrictionAddress/wgs84latitude| *None* |Search address - Latitude: Latitude|  |
|personContact/restrictionAddress/wgs84longitude| *None* |Search address - Longitude: Longitude|  |
|personContact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|personContact/url/URLAddress| *None* |URL|  |
|personContact/url/URLDescription| *None* |Description|  |
|personContact/contactAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|personContact/contactAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|personContact/contactAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|personContact/contactAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/contactAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|personContact/contactAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|personContact/contactAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personContact/contactAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|personContact/contactAssociate/associateDbId| *None* |ID|  |
|personContact/contactAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|personContact/contactAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|personContact/contactAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|personContact/contactAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|personContact/contactAssociate/contactCategory| *None* |Category: Category|  |
|personContact/contactAssociate/role| *None* |Role : Role|  |
|personContact/contactAssociate/assocName| *None* |User ID : User ID|  |
|personContact/contactAssociate/assocTooltip| *None* |Description : Description|  |
|personContact/contactAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|personContact/contactAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|personContact/contactAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personContact/contactAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|personContact/contactAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personContact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|personContact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|personContact/contactAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|personContact/contactAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|personContact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|personContact/contactAssociate/otherGroups| *None* |Other groups: Other groups|  |
|personContact/contactAssociate/userName| *None* |User name: User name|  |
|personContact/contactAssociate/personEmail| *None* |E-mail|  |
|personContact/contactSupportAssociate/firstName| *None* |Our service contact - First name: Displays the contact's first name|  |
|personContact/contactSupportAssociate/lastName| *None* |Our service contact - Last name: Displays the contact's last name|  |
|personContact/contactSupportAssociate/middleName| *None* |Our service contact - Middle Name: Displays the contact's middle name.|  |
|personContact/contactSupportAssociate/fullName| *None* |Our service contact - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|personContact/contactSupportAssociate/contactId| *None* |Our service contact - Company ID: Database ID of the company the user belongs to|  |
|personContact/contactSupportAssociate/personId| *None* |Our service contact - Contact ID: Database ID of the contact row|  |
|personContact/contactSupportAssociate/mrMrs| *None* |Our service contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personContact/contactSupportAssociate/title| *None* |Our service contact - Title: Displays whether the contact is addressed as Mr or Ms|  |
|personContact/contactSupportAssociate/associateDbId| *None* |Our service contact - ID|  |
|personContact/contactSupportAssociate/contactName| *None* |Our service contact - Owning company: Name of the company the user belongs to|  |
|personContact/contactSupportAssociate/contactDepartment| *None* |Our service contact - Owning department: Name of the department at the company the user belongs to|  |
|personContact/contactSupportAssociate/usergroup| *None* |Our service contact - Primary group: The user's primary user group|  |
|personContact/contactSupportAssociate/contactFullName| *None* |Our service contact - Owner: Name and department of the company the user belongs to|  |
|personContact/contactSupportAssociate/contactCategory| *None* |Our service contact - Category: Category|  |
|personContact/contactSupportAssociate/role| *None* |Our service contact - Role: Role|  |
|personContact/contactSupportAssociate/assocName| *None* |Our service contact - User ID: User ID|  |
|personContact/contactSupportAssociate/assocTooltip| *None* |Our service contact - Description: Description|  |
|personContact/contactSupportAssociate/assocType| *None* |Our service contact - Type: Type of user: associate, external user, system user, anonymous account|  |
|personContact/contactSupportAssociate/ejUserId| *None* |Our service contact - Service user ID: The database ID of a Service user|  |
|personContact/contactSupportAssociate/simultaneousEjUser| *None* |Our service contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personContact/contactSupportAssociate/ejDisplayName| *None* |Our service contact - Nick name: User's nick name in Service|  |
|personContact/contactSupportAssociate/ejStatus| *None* |Our service contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personContact/contactSupportAssociate/credentialType| *None* |Our service contact - Auth. type: What type of credentials to use when this user logs in|  |
|personContact/contactSupportAssociate/credentialDisplayValue| *None* |Our service contact - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|personContact/contactSupportAssociate/isActive| *None* |Our service contact - Active: Is this user active, and should be able to log in?|  |
|personContact/contactSupportAssociate/isActiveText| *None* |Our service contact - Active status: Is this user active, and should be able to log in?|  |
|personContact/contactSupportAssociate/portraitThumbnail| *None* |Our service contact - Person image: Person image|  |
|personContact/contactSupportAssociate/otherGroups| *None* |Our service contact - Other groups: Other groups|  |
|personContact/contactSupportAssociate/userName| *None* |Our service contact - User name: User name|  |
|personContact/contactSupportAssociate/personEmail| *None* |Our service contact - E-mail|  |
|personContact/contactSupportPerson/personId| *None* |User support contact - DB ID: Displays the database ID of a contact|  |
|personContact/contactSupportPerson/firstName| *None* |User support contact - First name: Displays the contact's first name|  |
|personContact/contactSupportPerson/lastName| *None* |User support contact - Last name: Displays the contact's last name|  |
|personContact/contactSupportPerson/middleName| *None* |User support contact - Middle name: Displays the contact's middle name.|  |
|personContact/contactSupportPerson/fullName| *None* |User support contact - Contact: Displays the contact to which an item is linked|  |
|personContact/contactSupportPerson/contactId| *None* |User support contact - Company ID: Database ID of company|  |
|personContact/contactSupportPerson/hasInfoText| *None* |User support contact - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|personContact/contactSupportPerson/hasInterests| *None* |User support contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|personContact/contactSupportPerson/personHasInterests| *None* |User support contact - Has interests: Displays an Icon indicating if the contact has active interests|  |
|personContact/contactSupportPerson/mrMrs| *None* |User support contact - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personContact/contactSupportPerson/position| *None* |User support contact - Position|  |
|personContact/contactSupportPerson/personNumber| *None* |User support contact - Number: Displays the contact's number|  |
|personContact/contactSupportPerson/title| *None* |User support contact - Title: Displays the contact's job title|  |
|personContact/contactSupportPerson/personCountry| *None* |User support contact - Country: Country|  |
|personContact/contactSupportPerson/personCountryId| *None* |User support contact - Country ID: Country ID|  |
|personContact/contactSupportPerson/personNoMail| *None* |User support contact - No Mailings: Displays the contact's No Mailings checkbox|  |
|personContact/contactSupportPerson/rank| *None* |User support contact - Rank: Displays a contact's current rank|  |
|personContact/contactSupportPerson/birthdate| *None* |User support contact - Birthdate: Displays the contact's date of birth|  |
|personContact/contactSupportPerson/associateType| *None* |User support contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|personContact/contactSupportPerson/useAsMailingAddress| *None* |User support contact - Use as postal address: Use as postal address|  |
|personContact/contactSupportPerson/personSource| *None* |User support contact - Source: Source (Contact)|  |
|personContact/contactSupportPerson/retired| *None* |User support contact - Former employee: Indicates whether the contact has retired/left the company|  |
|personContact/contactSupportPerson/birthYear| *None* |User support contact - Birth year: Displays contact's birth year|  |
|personContact/contactSupportPerson/birthMonth| *None* |User support contact - Birth month: Displays contact's birth month|  |
|personContact/contactSupportPerson/birthDay| *None* |User support contact - Birth day: Displays contact's birth day (day of month)|  |
|personContact/contactSupportPerson/kanaFirstName| *None* |User support contact - First name, kana: Contact's first name, in kana alphabet|  |
|personContact/contactSupportPerson/kanaLastName| *None* |User support contact - Last name, kana: Contact's last name, in kana alphabet|  |
|personContact/contactSupportPerson/personUpdatedBy| *None* |User support contact - Updated by: The user who last updated the data|  |
|personContact/contactSupportPerson/personUpdatedByFullName| *None* |User support contact - Updated by - Full name: The user who last updated the data|  |
|personContact/contactSupportPerson/personUpdatedDate| *None* |User support contact - Updated: The date/time the data was last updated in UTC.|  |
|personContact/contactSupportPerson/personRegisteredBy| *None* |User support contact - Registered by: The user who registered the data|  |
|personContact/contactSupportPerson/personRegisteredByFullName| *None* |User support contact - Registered by - Full name: The user who registered the data|  |
|personContact/contactSupportPerson/personRegisteredDate| *None* |User support contact - Registered date: The date/time the data was registered in UTC.|  |
|personContact/contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|personContact/contactSupportPerson/personActiveErpLinks| *None* |User support contact - ERP connected: Is there an active ERP Sync?|  |
|personContact/contactSupportPerson/ticketPriority| *None* |User support contact - Service priority: Default service priority for this contact|  |
|personContact/contactSupportPerson/supportLanguage| *None* |User support contact - Preferred language: Preferred language used for reply templates and more|  |
|personContact/contactSupportPerson/supportAssociate| *None* |User support contact - Our service contact: Default service contact for this contact|  |
|personContact/contactSupportPerson/supportAssociateFullName| *None* |User support contact - Our service contact - Full name: Default service contact for this contact|  |
|personContact/contactSupportPerson/personAssociateId| *None* |User support contact - Our contact: Displays our contact|  |
|personContact/contactSupportPerson/personAssociateFullName| *None* |User support contact - Our contact - Full name: Displays our contact|  |
|personContact/contactSupportPerson/personCategory| *None* |User support contact - Category|  |
|personContact/contactSupportPerson/personBusiness| *None* |User support contact - Business|  |
|personContact/contactSupportPerson/personDeletedDate| *None* |User support contact - Deleted date: Deleted date|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/contactSupportPerson/hasCompany| *None* |User support contact - Has company: The contact is associated with a company|  |
|personContact/contactSupportPerson/isProjectMember| *None* |User support contact - Is project member: This person is a project member|  |
|personContact/contactSupportPerson/isStakeholder| *None* |User support contact - Is stakeholder: This person is a sale stakeholder|  |
|personContact/contactSupportPerson/who| *None* |User support contact - Full name: Displays the contact's full name.|  |
|personContact/contactSupportPerson/personInfo/textId| *None* |User support contact - Text ID|  |
|personContact/contactSupportPerson/personInfo/infoText| *None* |User support contact - Information: Displays the text entered in the description field|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:1| *None* |User support contact - contactshorttext: tooltipshorttext|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:2| *None* |User support contact - contactlongtext: tooltiplongtext|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:3| *None* |User support contact - contactnumber|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:4| *None* |User support contact - contactdate|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:5| *None* |User support contact - contactunlimiteddate: tooltipunlimiteddate|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:6| *None* |User support contact - contactcheckbox|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:7| *None* |User support contact - contactdropdownlistbox|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:8| *None* |User support contact - contactdecimal|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:9| *None* |User support contact - page1saleonly|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:10| *None* |User support contact - page1marketingonly|  |
|personContact/contactSupportPerson/personUdef/SuperOffice:11| *None* |User support contact - page1adminonly|  |
|personContact/contactSupportPerson/personExtra/x\_person\_integer| *None* |User support contact - Extra Integer: Custom person integer|  |
|personContact/contactSupportPerson/personExtra/x\_person\_hidden\_integer| *None* |User support contact - Extra hidden integer: Custom integer field that is hidden|  |
|personContact/contactSupportPerson/personExtra/x\_person\_float| *None* |User support contact - Extra float: Custom float field|  |
|personContact/contactSupportPerson/personExtra/x\_person\_longtext| *None* |User support contact - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|personContact/contactSupportPerson/personExtra/x\_person\_date| *None* |User support contact - Extra date: Custom date field on person. Default value = 28.03.2019|  |
|personContact/contactSupportPerson/personExtra/x\_person\_datetime| *None* |User support contact - Extra DateTime: Custom person date and time field. No default|  |
|personContact/contactSupportPerson/personExtra/x\_person\_time| *None* |User support contact - Extra time: Custom time field on person. Current time as default|  |
|personContact/contactSupportPerson/personExtra/x\_person\_boolean| *None* |User support contact - Extra Boolean: Custom boolean field on person. Default checked|  |
|personContact/contactSupportPerson/personExtra/x\_person\_timespan| *None* |User support contact - Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|personContact/contactSupportPerson/personExtra/x\_person\_shorttext| *None* |User support contact - Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|personContact/contactSupportPerson/personExtra/x\_person\_shorttext\_list| *None* |User support contact - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|personContact/contactSupportPerson/personExtra/x\_person\_user\_relation| *None* |User support contact - Extra user relation: Custom person-user relation field|  |
|personContact/contactSupportPerson/personExtra/x\_person\_category\_relation| *None* |User support contact - Extra category relation: Custom person-category relation|  |
|personContact/contactSupportPerson/personExtra/x\_person\_priority\_relation| *None* |User support contact - Extra priority relation: Custom person-priority relation|  |
|personContact/contactSupportPerson/personExtra/x\_person\_request\_relation| *None* |User support contact - Extra request relation: Request relation on contact|  |
|personContact/contactSupportPerson/personExtra/x\_person\_appointment\_relation| *None* |User support contact - Extra appointment relation: Appointment relation on person|  |
|personContact/contactSupportPerson/personExtra/x\_person\_contact\_relation| *None* |User support contact - Extra company relation: Company relation on contact|  |
|personContact/contactSupportPerson/personExtra/y\_rental/id| *None* |User support contact - Rental - id: Displays the row's primary key (y\_rental)|  |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_start| *None* |User support contact - Rental - Start rental|  |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_end| *None* |User support contact - Rental - End|  |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_amount| *None* |User support contact - Rental - Amount: Number to rent. Default = 1|  |
|personContact/contactSupportPerson/personExtra/y\_rental/x\_contact| *None* |User support contact - Rental - Renter: Company that rents equipment|  |
|personContact/contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name| *None* |User support contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|personContact/contactSupportPerson/isMailingRecipient| *None* |User support contact - Is mailing recipient: isMailingRecipient|  |
|personContact/contactSupportPerson/hasStoreConsent| *None* |User support contact - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|personContact/contactSupportPerson/withdrawnStoreConsent| *None* |User support contact - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|personContact/contactSupportPerson/hasEmarketingConsent| *None* |User support contact - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|personContact/contactSupportPerson/withdrawnEmarketingConsent| *None* |User support contact - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|personContact/contactSupportPerson/subscription| *None* |User support contact - Subscription: Subscription for marketing|  |
|personContact/contactSupportPerson/legalBaseStore| *None* |User support contact - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|personContact/contactSupportPerson/legalBaseEmarketing| *None* |User support contact - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|personContact/contactSupportPerson/consentSourceStore| *None* |User support contact - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|personContact/contactSupportPerson/consentSourceEmarketing| *None* |User support contact - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|personContact/contactInterestIds| *None* |Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|personContact/contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|personContact/contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|personContact/contactUdef/SuperOffice:3| *None* |companynumber|  |
|personContact/contactUdef/SuperOffice:4| *None* |companydate|  |
|personContact/contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|personContact/contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|personContact/contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|personContact/contactUdef/SuperOffice:8| *None* |companydecimal|  |
|personContact/contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|personContact/contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|personContact/contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|personContact/contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|personContact/contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|personContact/contactExtra/x\_contact\_integer| *None* |Extra Integer: Custom integer field|  |
|personContact/contactExtra/x\_contact\_hidden\_integer| *None* |Extra hidden integer: Custom integer field - hidden|  |
|personContact/contactExtra/x\_contact\_default\_integer| *None* |Extra Default Integer: Custom integer field with default value 123.|  |
|personContact/contactExtra/x\_contact\_float| *None* |Extra Float: Custom float field with 3 decimals|  |
|personContact/contactExtra/x\_contact\_longtext| *None* |Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|personContact/contactExtra/x\_contact\_dropdown| *None* |Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|personContact/contactExtra/x\_contact\_date| *None* |Extra date: Custom date field. User current as default.|  |
|personContact/contactExtra/x\_contact\_datetime| *None* |Extra DateTime: Custom Date Time field. No default value. External|  |
|personContact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.|  |
|personContact/contactExtra/x\_contact\_boolean| *None* |Extra boolean: Custom boolean field.|  |
|personContact/contactExtra/x\_contact\_timespan| *None* |Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|personContact/contactExtra/x\_contact\_shorttext| *None* |Extra short text: Custom short text field. Keep HTML tags.|  |
|personContact/contactExtra/x\_contact\_short\_dropdown| *None* |Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|personContact/contactExtra/x\_contact\_contact\_relation| *None* |Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|personContact/contactExtra/x\_contact\_request\_relation| *None* |Extra Request relation: Request relation on company|  |
|personContact/contactExtra/x\_contact\_contact| *None* |Extra contact relation: Contact relation on company|  |
|personContact/NumberOfActivities| *None* |Number of activities|  |
|personContact/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|personContact/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|personContact/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|personContact/LastActivity| *None* |Date of last activity|  |
|personContact/LastCompletedActivity| *None* |Date of last completed activity|  |
|personContact/LastDoByActivity| *None* |Date of last non-completed activity|  |
|personContact/NumberOfSales| *None* |Number of sales|  |
|personContact/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|personContact/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|personContact/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|personContact/LastSale| *None* |Date of last sale|  |
|personContact/LastCompletedSale| *None* |Date of last completed sale|  |
|personContact/LastDoBySale| *None* |Date of last non-completed sale|  |
|personContact/NumberOfTickets| *None* |Number of requests|  |
|personContact/NumberOfTicketsInPeriod| *None* |Number of requests in last 90 days|  |
|personContact/NumberOfNotCompletedTickets| *None* |Number of non-completed requests|  |
|personContact/NumberOfNotCompletedTicketsInPeriod| *None* |Number of non-completed requests in last 90 days|  |
|personContact/LastTicket| *None* |Date of last request|  |
|personContact/LastCompletedTicket| *None* |Date of last completed request|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/LastDoByTicket| *None* |Date of last non-completed request|  |
|personContact/SaintStatus1| *None* |Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|personContact/SaintStatus2| *None* |C-company: Kundens navn starter med bokstaven C|  |
|personContact/saintSaleStatus| *None* |With status|  |
|personContact/saintAmountClass| *None* |Amount class|  |
|personContact/saintActivityType| *None* |SAINT type|  |
|personContact/saintDirection| *None* |Direction|  |
|personContact/saintIntention| *None* |Intention|  |
|personContact/saintTicketStatus| *None* |Status|  |
|personContact/saintTicketCategory| *None* |Category|  |
|personContact/selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|personContact/selectionIdRequest| *None* |Selection ID: Database ID of selection which members are to be fetched from|  |
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
|request/contactId| *None* |Company ID: Database ID of company|  |
|request/personId| *None* |Contact ID: Database ID of the contact row|  |
|request/saleId| *None* |Sale ID: The database ID of the sale record|  |
|request/projectId| *None* |Project ID: Database ID of project record|  |
|request/ticketStatusName| *None* |Status: Request status|  |
|request/categoryFullName| *None* |Category: Request category|  |
|request/priorityName| *None* |Priority: Service priority|  |
|request/ticketId| *None* |ID: Displays request ID|  |
|request/title| *None* |Title: Displays the request title|  |
|request/createdAt| *None* |Created: Displays when the request was created|  |
|request/lastChanged| *None* |Last changed: Displays when the request was last changed|  |
|request/author| *None* |Author: Displays the author of the request|  |
|request/readByOwner| *None* |Read by owner: Displays when the request was read by the owner|  |
|request/firstReadByOwner| *None* |First read by owner: Displays when the request was read by owner for the first time|  |
|request/firstReadByUser| *None* |First read by user: Displays when the request was read by user for the first time|  |
|request/readByCustomer| *None* |Read by contact: Displays when the request was read by the contact|  |
|request/status| *None* |Internal status: Shows only system defined statuses for a request|  |
|request/origin| *None* |Origin: Origin|  |
|request/slevel| *None* |Access level: Access level|  |
|request/numberOfMessages| *None* |Number of messages: Number of messages|  |
|request/numberOfReplies| *None* |Number of replies: Number of replies|  |
|request/connectId| *None* |Merged with request: Merged with request|  |
|request/readStatus| *None* |Read: Read|  |
|request/realTimeSpentQueue| *None* |Real time in queue: Real time in queue|  |
|request/realTimeSpentExternally| *None* |Real time externally: Real time externally|  |
|request/realTimeSpentInternally| *None* |Real time internally: Real time internally|  |
|request/timeSpentQueue| *None* |Time spent in queue: Time spent in queue|  |
|request/timeSpentExternally| *None* |Time spent externally: Time spent externally|  |
|request/timeSpentInternally| *None* |Time spent internally: Time spent internally|  |
|request/timeSpent| *None* |Time spent: Time spent|  |
|request/timeToReply| *None* |Time to reply: Time to reply|  |
|request/timeToClose| *None* |Time to close: Time to close|  |
|request/realTimeToReply| *None* |Real time to reply: Real time to reply|  |
|request/realTimeToClose| *None* |Real time to close: Real time to close|  |
|request/repliedAt| *None* |Replied at: Replied at|  |
|request/closedAt| *None* |Closed at: Closed at|  |
|request/activated| *None* |Postponed to: Postponed to|  |
|request/deadline| *None* |Deadline: Deadline|  |
|request/has\_attachment| *None* |Has attachment: Indicates whether the e-mail has one or more attachments|  |
|request/tags| *None* |Tags: Tags connected to a request|  |
|request/ownedBy| *None* |Owner: The owner of the request|  |
|request/content| *None* |Content: Search for content in messages related to requests|  |
|request/messageLanguage| *None* |Language: Recognized language in messages|  |
|request/sentimentScore| *None* |Sentiment: Sentiment score, -100 to +100|  |
|request/suggestedCategory| *None* |Sugg.Cat.: Suggested service category|  |
|request/createdBy/firstName| *None* |Created by - First name: Displays the contact's first name|  |
|request/createdBy/lastName| *None* |Created by - Last name: Displays the contact's last name|  |
|request/createdBy/middleName| *None* |Created by - Middle Name: Displays the contact's middle name.|  |
|request/createdBy/fullName| *None* |Created by - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|request/createdBy/contactId| *None* |Created by - Company ID: Database ID of the company the user belongs to|  |
|request/createdBy/personId| *None* |Created by - Contact ID: Database ID of the contact row|  |
|request/createdBy/mrMrs| *None* |Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|request/createdBy/title| *None* |Created by - Title: Displays whether the contact is addressed as Mr or Ms|  |
|request/createdBy/associateDbId| *None* |Created by - ID|  |
|request/createdBy/contactName| *None* |Created by - Owning company: Name of the company the user belongs to|  |
|request/createdBy/contactDepartment| *None* |Created by - Owning department: Name of the department at the company the user belongs to|  |
|request/createdBy/usergroup| *None* |Created by - Primary group: The user's primary user group|  |
|request/createdBy/contactFullName| *None* |Created by - Owner: Name and department of the company the user belongs to|  |
|request/createdBy/contactCategory| *None* |Created by - Category: Category|  |
|request/createdBy/role| *None* |Created by - Role: Role|  |
|request/createdBy/assocName| *None* |Created by - User ID: User ID|  |
|request/createdBy/assocTooltip| *None* |Created by - Description: Description|  |
|request/createdBy/assocType| *None* |Created by - Type: Type of user: associate, external user, system user, anonymous account|  |
|request/createdBy/ejUserId| *None* |Created by - Service user ID: The database ID of a Service user|  |
|request/createdBy/simultaneousEjUser| *None* |Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/createdBy/ejDisplayName| *None* |Created by - Nick name: User's nick name in Service|  |
|request/createdBy/ejStatus| *None* |Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in|  |
|request/createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|request/createdBy/isActive| *None* |Created by - Active: Is this user active, and should be able to log in?|  |
|request/createdBy/isActiveText| *None* |Created by - Active status: Is this user active, and should be able to log in?|  |
|request/createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|request/createdBy/otherGroups| *None* |Created by - Other groups: Other groups|  |
|request/createdBy/userName| *None* |Created by - User name: User name|  |
|request/createdBy/personEmail| *None* |Created by - E-mail|  |
|request/ownedBy/firstName| *None* |Owner - First name: Displays the contact's first name|  |
|request/ownedBy/lastName| *None* |Owner - Last name: Displays the contact's last name|  |
|request/ownedBy/middleName| *None* |Owner - Middle Name: Displays the contact's middle name.|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|request/ownedBy/fullName| *None* |Owner - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|request/ownedBy/contactId| *None* |Owner - Company ID: Database ID of the company the user belongs to|  |
|request/ownedBy/personId| *None* |Owner - Contact ID: Database ID of the contact row|  |
|request/ownedBy/mrMrs| *None* |Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|request/ownedBy/title| *None* |Owner - Title: Displays whether the contact is addressed as Mr or Ms|  |
|request/ownedBy/associateDbId| *None* |Owner - ID|  |
|request/ownedBy/contactName| *None* |Owner - Owning company: Name of the company the user belongs to|  |
|request/ownedBy/contactDepartment| *None* |Owner - Owning department: Name of the department at the company the user belongs to|  |
|request/ownedBy/usergroup| *None* |Owner - Primary group: The user's primary user group|  |
|request/ownedBy/contactFullName| *None* |Owner - Owner: Name and department of the company the user belongs to|  |
|request/ownedBy/contactCategory| *None* |Owner - Category: Category|  |
|request/ownedBy/role| *None* |Owner - Role: Role|  |
|request/ownedBy/assocName| *None* |Owner - User ID: User ID|  |
|request/ownedBy/assocTooltip| *None* |Owner - Description: Description|  |
|request/ownedBy/assocType| *None* |Owner - Type: Type of user: associate, external user, system user, anonymous account|  |
|request/ownedBy/ejUserId| *None* |Owner - Service user ID: The database ID of a Service user|  |
|request/ownedBy/simultaneousEjUser| *None* |Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|request/ownedBy/ejDisplayName| *None* |Owner - Nick name: User's nick name in Service|  |
|request/ownedBy/ejStatus| *None* |Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|request/ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in|  |
|request/ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|request/ownedBy/isActive| *None* |Owner - Active: Is this user active, and should be able to log in?|  |
|request/ownedBy/isActiveText| *None* |Owner - Active status: Is this user active, and should be able to log in?|  |
|request/ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|request/ownedBy/otherGroups| *None* |Owner - Other groups: Other groups|  |
|request/ownedBy/userName| *None* |Owner - User name: User name|  |
|request/ownedBy/personEmail| *None* |Owner - E-mail|  |
|request/extra/x\_ticket\_integer| *None* |Extra integer: Custom ticket integer. Default 123. External. Show in properties|  |
|request/extra/x\_ticket\_float| *None* |Extra float: Custom float on Request. 2 decimal places|  |
|request/extra/x\_ticket\_longtext| *None* |Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props|  |
|request/extra/x\_ticket\_date| *None* |Extra date: Custom date field on Request. No default value|  |
|request/extra/x\_ticket\_datetime| *None* |Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request|  |
|request/extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.|  |
|request/extra/x\_ticket\_boolean| *None* |Extra boolean: Custom boolean on Ticket.|  |
|request/extra/x\_ticket\_timespan| *None* |Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props|  |
|request/extra/x\_ticket\_short\_text| *None* |Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request|  |
|request/extra/x\_ticket\_shorttext\_list| *None* |Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot|  |
|request/extra/x\_ticket\_timestamp| *None* |Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field|  |
|request/extra/x\_ticket\_project\_relation| *None* |Extra project: Custom project relation on Request|  |
|request/extra/x\_ticket\_faq| *None* |Extra FAQ Relation|  |
|request/extra/x\_ticket\_category\_relation| *None* |Extra category relation: Category relation on request|  |
|request/extra/y\_equipment/x\_name| *None* |Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|projectMembers/completed| *None* |Completed: Displays a check mark indicating if the project has been completed.|  |
|projectMembers/projectId| *None* |DB ID: Displays the database ID for a project row|  |
|projectMembers/name| *None* |Project name: Displays the Project's name|  |
|projectMembers/number| *None* |Number: Displays the project's number|  |
|projectMembers/type| *None* |Project type: Displays the project's type|  |
|projectMembers/status| *None* |Status: Displays the project's status|  |
|projectMembers/statusRank| *None* |Status rank: Rank of the project status in the status list|  |
|projectMembers/associateId| *None* |ID: Displays login ID of the associate who owns the project|  |
|projectMembers/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|projectMembers/icon| *None* |Category: Displays the icon for an activity type|  |
|projectMembers/text| *None* |Text: Displays a descriptive text for the item|  |
|projectMembers/description| *None* |Description : Description|  |
|projectMembers/updatedBy| *None* |Updated by: The user who last updated the data|  |
|projectMembers/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|projectMembers/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|projectMembers/registeredBy| *None* |Registered by: The user who registered the data|  |
|projectMembers/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|projectMembers/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|projectMembers/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|projectMembers/nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|projectMembers/endDate| *None* |End date: End date of project|  |
|projectMembers/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|projectMembers/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|projectMembers/function| *None* |Function: Displays the project member's function in the project|  |
|projectMembers/projectPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|projectMembers/projectPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|projectMembers/projectPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|projectMembers/projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectMembers/projectEvent/isExternalEvent| *None* |Event: Is this an external event|  |
|projectMembers/projectEvent/eventDate| *None* |Event date: Event date|  |
|projectMembers/projectEvent/hasSignOn| *None* |Sign On: Does this event have the Sign On function enabled|  |
|projectMembers/projectEvent/hasSignOff| *None* |Sign Off: Does this event have the Sign Off function enabled|  |
|projectMembers/projectUrl/URLAddress| *None* |URL|  |
|projectMembers/projectUrl/URLDescription| *None* |Description|  |
|projectMembers/projectAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|projectMembers/projectAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|projectMembers/projectAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|projectMembers/projectAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|projectMembers/projectAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|projectMembers/projectAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|projectMembers/projectAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|projectMembers/projectAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|projectMembers/projectAssociate/associateDbId| *None* |ID|  |
|projectMembers/projectAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|projectMembers/projectAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|projectMembers/projectAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|projectMembers/projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|projectMembers/projectAssociate/contactCategory| *None* |Category: Category|  |
|projectMembers/projectAssociate/role| *None* |Role : Role|  |
|projectMembers/projectAssociate/assocName| *None* |User ID : User ID|  |
|projectMembers/projectAssociate/assocTooltip| *None* |Description : Description|  |
|projectMembers/projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|projectMembers/projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|projectMembers/projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectMembers/projectAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|projectMembers/projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectMembers/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|projectMembers/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMembers/projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|projectMembers/projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|projectMembers/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectMembers/projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|projectMembers/projectAssociate/userName| *None* |User name: User name|  |
|projectMembers/projectAssociate/personEmail| *None* |E-mail|  |
|projectMembers/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|projectMembers/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|projectMembers/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|projectMembers/projectUdef/SuperOffice:4| *None* |projectdate|  |
|projectMembers/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|projectMembers/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|projectMembers/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|projectMembers/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|projectMembers/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|projectMembers/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
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
|projectMembers/SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|projectMembers/saintSaleStatus| *None* |With status|  |
|projectMembers/saintAmountClass| *None* |Amount class|  |
|projectMembers/saintActivityType| *None* |SAINT type|  |
|projectMembers/saintDirection| *None* |Direction|  |
|projectMembers/saintIntention| *None* |Intention|  |
|projectMembers/saintTicketStatus| *None* |Status|  |
|projectMembers/saintTicketCategory| *None* |Category|  |
|projectMembers/project/textId| *None* |Text ID|  |
|projectMembers/project/infoText| *None* |Information: Displays the text entered in the description field|  |
|personAppointment/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed|  |
|personAppointment/icon| *None* |Category: Displays the icon for an activity type|  |
|personAppointment/date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|personAppointment/time| *None* |Time: Time|  |
|personAppointment/type| *None* |Type: Displays the type of an activity|  |
|personAppointment/recordType| *None* |Record type : Shows the record type|  |
|personAppointment/text| *None* |Text: Displays a descriptive text for the item|  |
|personAppointment/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|personAppointment/contactId| *None* |Company ID: Database ID of company|  |
|personAppointment/personId| *None* |Contact ID: Database ID of the contact row|  |
|personAppointment/projectId| *None* |Project ID: Database ID of project record|  |
|personAppointment/saleId| *None* |Sale ID: The database ID of the sale record|  |
|personAppointment/userGroup| *None* |User group : The user group that owns the record|  |
|personAppointment/who| *None* |Who: Contact and/or company|  |
|personAppointment/updatedBy| *None* |Updated by: The user who last updated the data|  |
|personAppointment/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|personAppointment/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personAppointment/registeredBy| *None* |Registered by: The user who registered the data|  |
|personAppointment/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|personAppointment/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|personAppointment/appointmentId| *None* |DB ID: Displays the database ID of a row|  |
|personAppointment/endDate| *None* |End date: Displays the deadline for a follow-up/sale|  |
|personAppointment/priority| *None* |Priority: Displays the priority of the activity|  |
|personAppointment/alarm| *None* |Has alarm: Displays the alarm state of a follow-up|  |
|personAppointment/recurring| *None* |Repeating: Displays an icon indicating if the follow-up is part of a repeating follow-up|  |
|personAppointment/booking| *None* |Invitation: Displays an icon if the follow-up is an invitation. All invitations will be displayed in a tooltip.|  |
|personAppointment/intention| *None* |Intention: Displays the intention of the follow-up type|  |
|personAppointment/location| *None* |Location: Display the location where the follow-up will take place.|  |
|personAppointment/recurrenceRuleId| *None* |RR-ID: Repetition rule ID of follow-up|  |
|personAppointment/rawType| *None* |Type: Type field for appointment, not decoded or formatted|  |
|personAppointment/rawStatus| *None* |Status: Status field for the follow-up, not decoded or formatted|  |
|personAppointment/cautionWarning| *None* |Warning: Warning for invitations with potential problems: not properly synchronized with an external calendar, unsupported repetition pattern, e-mail notification failed, or other problems.|  |
|personAppointment/visibleInDiary| *None* |ExcludeBook: Is the activity visible in the diary?|  |
|personAppointment/endTime| *None* |End time: End time of an activity|  |
|personAppointment/suggestedAppointmentId| *None* |Follow-up ID (suggestion: The database ID of a follow-up that originates in a suggestion|  |
|personAppointment/completedDate| *None* |Completed date: Displays the actual date a follow-up/sale was marked as completed|  |
|personAppointment/isMilestone| *None* |Milestone: Shows whether or not the follow-ups in this row are milestones|  |
|personAppointment/invitedPersonId| *None* |ID of invited person: appointment.invitedpersonid record - utility for rd|  |
|personAppointment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
|personAppointment/joinVideomeetUrl| *None* |Video meeting URL: URL for joining the video meeting|  |
|personAppointment/duration| *None* |Duration: The duration of the chat session|  |
|personAppointment/visibleFor| *None* |Visible for|  |
|personAppointment/appointmentPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|personAppointment/appointmentPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|personAppointment/appointmentPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|personAppointment/appointmentPublish/publishedBy| *None* |Published by: Published by|  |
|personAppointment/appointmentUdef/SuperOffice:1| *None* |followupshorttext|  |
|personAppointment/appointmentUdef/SuperOffice:2| *None* |followuplongtext|  |
|personAppointment/appointmentUdef/SuperOffice:3| *None* |followupnumber|  |
|personAppointment/appointmentUdef/SuperOffice:4| *None* |followupdate|  |
|personAppointment/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate|  |
|personAppointment/appointmentUdef/SuperOffice:6| *None* |followupcheckbox|  |
|personAppointment/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox|  |
|personAppointment/appointmentUdef/SuperOffice:8| *None* |followupdecimal|  |
|personAppointment/associate/firstName| *None* |First name: Displays the contact's first name|  |
|personAppointment/associate/lastName| *None* |Last name: Displays the contact's last name|  |
|personAppointment/associate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|personAppointment/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|personAppointment/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|personAppointment/associate/personId| *None* |Contact ID: Database ID of the contact row|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAppointment/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|personAppointment/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|personAppointment/associate/associateDbId| *None* |ID|  |
|personAppointment/associate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|personAppointment/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|personAppointment/associate/usergroup| *None* |Primary group: The user's primary user group|  |
|personAppointment/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|personAppointment/associate/contactCategory| *None* |Category: Category|  |
|personAppointment/associate/role| *None* |Role : Role|  |
|personAppointment/associate/assocName| *None* |User ID : User ID|  |
|personAppointment/associate/assocTooltip| *None* |Description : Description|  |
|personAppointment/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|personAppointment/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|personAppointment/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|personAppointment/associate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|personAppointment/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|personAppointment/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|personAppointment/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|personAppointment/associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|personAppointment/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|personAppointment/associate/portraitThumbnail| *None* |Person image: Person image|  |
|personAppointment/associate/otherGroups| *None* |Other groups: Other groups|  |
|personAppointment/associate/userName| *None* |User name: User name|  |
|personAppointment/associate/personEmail| *None* |E-mail|  |
|personAppointment/appointment/textId| *None* |Text ID|  |
|personAppointment/appointment/description| *None* |Text: Displays the text entered in the description field|  |
|status| *None* |Status: Displays the project's status|  |
|statusRank| *None* |Status rank: Rank of the project status in the status list|  |
|nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|endDate| *None* |End date: End date of project|  |
|imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|projectPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|projectPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|projectPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectEvent/isExternalEvent| *None* |Event: Is this an external event|  |
|projectEvent/eventDate| *None* |Event date: Event date|  |
|projectEvent/hasSignOn| *None* |Sign On: Does this event have the Sign On function enabled|  |
|projectEvent/hasSignOff| *None* |Sign Off: Does this event have the Sign Off function enabled|  |
|projectUrl/URLAddress| *None* |URL|  |
|projectUrl/URLDescription| *None* |Description|  |
|projectAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|projectAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|projectAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|projectAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|projectAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|projectAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|projectAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|projectAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|projectAssociate/associateDbId| *None* |ID|  |
|projectAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|projectAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|projectAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|projectAssociate/contactCategory| *None* |Category: Category|  |
|projectAssociate/role| *None* |Role : Role|  |
|projectAssociate/assocName| *None* |User ID : User ID|  |
|projectAssociate/assocTooltip| *None* |Description : Description|  |
|projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|projectAssociate/userName| *None* |User name: User name|  |
|projectAssociate/personEmail| *None* |E-mail|  |
|projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|projectUdef/SuperOffice:3| *None* |projectnumber|  |
|projectUdef/SuperOffice:4| *None* |projectdate|  |
|projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|selectionAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|selectionAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|selectionAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|selectionAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|selectionAssociate/associateDbId| *None* |ID|  |
|selectionAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|selectionAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|selectionAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|selectionAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|selectionAssociate/contactCategory| *None* |Category: Category|  |
|selectionAssociate/role| *None* |Role : Role|  |
|selectionAssociate/assocName| *None* |User ID : User ID|  |
|selectionAssociate/assocTooltip| *None* |Description : Description|  |
|selectionAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|selectionAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|selectionAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|selectionAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|selectionAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|selectionAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|selectionAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|selectionAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|selectionAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|selectionAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|selectionAssociate/otherGroups| *None* |Other groups: Other groups|  |
|selectionAssociate/userName| *None* |User name: User name|  |
|selectionAssociate/personEmail| *None* |E-mail|  |
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
|mailingAddr/mailingAddrId| *None* |!!!Mailing addr Id: !!!Mailing addr Id Tooltip|  |
|mailingAddr/contact/contactId| *None* |Company - Company ID: Database ID of company|  |
|mailingAddr/contact/name| *None* |Company - Company name|  |
|mailingAddr/contact/department| *None* |Company - Department|  |
|mailingAddr/contact/nameDepartment| *None* |Company - Company: Displays the company an activity is linked to|  |
|mailingAddr/contact/hasInfoText| *None* |Company - Has note: Displays an icon indicating if there is additional information available about the contact|  |
|mailingAddr/contact/hasInterests| *None* |Company - Has interests: Displays an Icon indicating if the contact has active interests|  |
|mailingAddr/contact/associateId| *None* |Company - Our contact: Displays our contact|  |
|mailingAddr/contact/category| *None* |Company - Category|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/contact/streetAddress/addressId| *None* |Company - Street address - Address ID: Database ID for the address record|  |
|mailingAddr/contact/streetAddress/line1| *None* |Company - Street address - Address 1: First line of the address|  |
|mailingAddr/contact/streetAddress/line2| *None* |Company - Street address - Address 2: Second line of the address|  |
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
|mailingAddr/contact/contactAssociate/contactFullName| *None* |Company - Owner: Name and department of the company the user belongs to|  |
|mailingAddr/contact/contactAssociate/contactCategory| *None* |Company - Category: Category|  |
|mailingAddr/contact/contactAssociate/role| *None* |Company - Role: Role|  |
|mailingAddr/contact/contactAssociate/assocName| *None* |Company - User ID: User ID|  |
|mailingAddr/contact/contactAssociate/assocTooltip| *None* |Company - Description: Description|  |
|mailingAddr/contact/contactAssociate/assocType| *None* |Company - Type: Type of user: associate, external user, system user, anonymous account|  |
|mailingAddr/contact/contactAssociate/ejUserId| *None* |Company - Service user ID: The database ID of a Service user|  |
|mailingAddr/contact/contactAssociate/simultaneousEjUser| *None* |Company - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/contact/contactAssociate/ejDisplayName| *None* |Company - Nick name: User's nick name in Service|  |
|mailingAddr/contact/contactAssociate/ejStatus| *None* |Company - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/contact/contactAssociate/credentialType| *None* |Company - Auth. type: What type of credentials to use when this user logs in|  |
|mailingAddr/contact/contactAssociate/credentialDisplayValue| *None* |Company - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|mailingAddr/contact/contactAssociate/isActive| *None* |Company - Active: Is this user active, and should be able to log in?|  |
|mailingAddr/contact/contactAssociate/isActiveText| *None* |Company - Active status: Is this user active, and should be able to log in?|  |
|mailingAddr/contact/contactAssociate/portraitThumbnail| *None* |Company - Person image: Person image|  |
|mailingAddr/contact/contactAssociate/otherGroups| *None* |Company - Other groups: Other groups|  |
|mailingAddr/contact/contactAssociate/userName| *None* |Company - User name: User name|  |
|mailingAddr/contact/contactAssociate/personEmail| *None* |Company - E-mail|  |
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
|mailingAddr/contact/LastDoBySale| *None* |Company - Date of last non-completed sale|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|mailingAddr/person/personBusiness| *None* |Contact - Business|  |
|mailingAddr/person/personDeletedDate| *None* |Contact - Deleted date: Deleted date|  |
|mailingAddr/person/hasCompany| *None* |Contact - Has company: The contact is associated with a company|  |
|mailingAddr/person/isProjectMember| *None* |Contact - Is project member: This person is a project member|  |
|mailingAddr/person/isStakeholder| *None* |Contact - Is stakeholder: This person is a sale stakeholder|  |
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
|mailingAddr/person/personAddress/county| *None* |Contact - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.|  |
|mailingAddr/person/personAddress/city| *None* |Contact - Contact address - City: This criterion corresponds to the City field on the Company card.|  |
|mailingAddr/person/personAddress/zip| *None* |Contact - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.|  |
|mailingAddr/person/personAddress/state| *None* |Contact - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.|  |
|mailingAddr/person/personAddress/wgs84latitude| *None* |Contact - Contact address - Latitude: Latitude|  |
|mailingAddr/person/personAddress/wgs84longitude| *None* |Contact - Contact address - Longitude: Longitude|  |
|mailingAddr/person/personAddress/formattedAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/personAddress/formattedMultiLineAddress| *None* |Contact - Contact address - {formattedAddress}: {formattedAddress}|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|mailingAddr/person/personExtra/y\_rental/x\_start| *None* |Contact - Rental - Start rental|  |
|mailingAddr/person/personExtra/y\_rental/x\_end| *None* |Contact - Rental - End|  |
|mailingAddr/person/personExtra/y\_rental/x\_amount| *None* |Contact - Rental - Amount: Number to rent. Default = 1|  |
|mailingAddr/person/personExtra/y\_rental/x\_contact| *None* |Contact - Rental - Renter: Company that rents equipment|  |
|mailingAddr/person/personExtra/y\_rental/y\_equipment/x\_name| *None* |Contact - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
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
|mailingAddr/person/personAssociate/contactFullName| *None* |Contact - Owner: Name and department of the company the user belongs to|  |
|mailingAddr/person/personAssociate/contactCategory| *None* |Contact - Category: Category|  |
|mailingAddr/person/personAssociate/role| *None* |Contact - Role: Role|  |
|mailingAddr/person/personAssociate/assocName| *None* |Contact - User ID: User ID|  |
|mailingAddr/person/personAssociate/assocTooltip| *None* |Contact - Description: Description|  |
|mailingAddr/person/personAssociate/assocType| *None* |Contact - Type: Type of user: associate, external user, system user, anonymous account|  |
|mailingAddr/person/personAssociate/ejUserId| *None* |Contact - Service user ID: The database ID of a Service user|  |
|mailingAddr/person/personAssociate/simultaneousEjUser| *None* |Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/person/personAssociate/ejDisplayName| *None* |Contact - Nick name: User's nick name in Service|  |
|mailingAddr/person/personAssociate/ejStatus| *None* |Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/person/personAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in|  |
|mailingAddr/person/personAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|mailingAddr/person/personAssociate/isActive| *None* |Contact - Active: Is this user active, and should be able to log in?|  |
|mailingAddr/person/personAssociate/isActiveText| *None* |Contact - Active status: Is this user active, and should be able to log in?|  |
|mailingAddr/person/personAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/personAssociate/otherGroups| *None* |Contact - Other groups: Other groups|  |
|mailingAddr/person/personAssociate/userName| *None* |Contact - User name: User name|  |
|mailingAddr/person/personAssociate/personEmail| *None* |Contact - E-mail|  |
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
|mailingAddr/person/correspondingAssociate/usergroup| *None* |Contact - Primary group: The user's primary user group|  |
|mailingAddr/person/correspondingAssociate/contactFullName| *None* |Contact - Owner: Name and department of the company the user belongs to|  |
|mailingAddr/person/correspondingAssociate/contactCategory| *None* |Contact - Category: Category|  |
|mailingAddr/person/correspondingAssociate/role| *None* |Contact - Role: Role|  |
|mailingAddr/person/correspondingAssociate/assocName| *None* |Contact - User ID: User ID|  |
|mailingAddr/person/correspondingAssociate/assocTooltip| *None* |Contact - Description: Description|  |
|mailingAddr/person/correspondingAssociate/assocType| *None* |Contact - Type: Type of user: associate, external user, system user, anonymous account|  |
|mailingAddr/person/correspondingAssociate/ejUserId| *None* |Contact - Service user ID: The database ID of a Service user|  |
|mailingAddr/person/correspondingAssociate/simultaneousEjUser| *None* |Contact - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|mailingAddr/person/correspondingAssociate/ejDisplayName| *None* |Contact - Nick name: User's nick name in Service|  |
|mailingAddr/person/correspondingAssociate/ejStatus| *None* |Contact - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|mailingAddr/person/correspondingAssociate/credentialType| *None* |Contact - Auth. type: What type of credentials to use when this user logs in|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/person/correspondingAssociate/credentialDisplayValue| *None* |Contact - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|mailingAddr/person/correspondingAssociate/isActive| *None* |Contact - Active: Is this user active, and should be able to log in?|  |
|mailingAddr/person/correspondingAssociate/isActiveText| *None* |Contact - Active status: Is this user active, and should be able to log in?|  |
|mailingAddr/person/correspondingAssociate/portraitThumbnail| *None* |Contact - Person image: Person image|  |
|mailingAddr/person/correspondingAssociate/otherGroups| *None* |Contact - Other groups: Other groups|  |
|mailingAddr/person/correspondingAssociate/userName| *None* |Contact - User name: User name|  |
|mailingAddr/person/correspondingAssociate/personEmail| *None* |Contact - E-mail|  |
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
|sale/completed| *None* |Completed: Displays a checkbox showing if an appointment is completed|  |
|sale/icon| *None* |Category: Displays the icon for an activity type|  |
|sale/date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|sale/time| *None* |Time: Time|  |
|sale/type| *None* |Type: Displays the type of an activity|  |
|sale/recordType| *None* |Record type : Shows the record type|  |
|sale/text| *None* |Text: Displays a descriptive text for the item|  |
|sale/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|sale/contactId| *None* |Company ID: Database ID of company|  |
|sale/personId| *None* |Contact ID: Database ID of the contact row|  |
|sale/projectId| *None* |Project ID: Database ID of project record|  |
|sale/saleId| *None* |Sale ID: The database ID of the sale record|  |
|sale/userGroup| *None* |User group : The user group that owns the record|  |
|sale/who| *None* |Who: Contact and/or company|  |
|sale/updatedBy| *None* |Updated by: The user who last updated the data|  |
|sale/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|sale/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|sale/registeredBy| *None* |Registered by: The user who registered the data|  |
|sale/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|sale/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|sale/currencyId| *None* |Currency ID: The currency list item ID|  |
|sale/currency| *None* |Currency: The currency of the sale|  |
|sale/credited| *None* |Credited: The user to be credited with the sale|  |
|sale/lossReason| *None* |Reason (lost: The reason for losing the sale|  |
|sale/source| *None* |Source: The source (lead) of the sale|  |
|sale/competitor| *None* |Competitor: The competitor who won the sale|  |
|sale/heading| *None* |Sale: The name of the sale|  |
|sale/amount| *None* |Amount: The gross sales total|  |
|sale/amountWeighted| *None* |Weighted amount: Virtual field calculated from amount * probability percent.|  |
|sale/earning| *None* |Profit: Gross profit (gross sales total - cost) for the sale|  |
|sale/earningPercent| *None* |Profit as % : The profit as a percentage of the gross sales total|  |
|sale/probPercent| *None* |Probability as %: Probability as %|  |
|sale/originalStage| *None* |Stage: Displays the stage of the sale|  |
|sale/stage| *None* |Stage: Displays the stage of the sale|  |
|sale/saleStatus| *None* |Status: The status of the sale - open, lost or sold|  |
|sale/stageRank| *None* |Stage rank: Rank of the sale stage in the stage list|  |
|sale/saleType| *None* |Sale type: Sale type, from list|  |
|sale/nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|sale/reopenDate| *None* |Reopen date: Displays the reopen date for the sale|  |
|sale/stalledComment| *None* |Reason (stalled: The reason the sale has been stalled|  |
|sale/saleTypeCategory| *None* |Sale type category: Sale type category|  |
|sale/soldReason| *None* |Reason (sold: Reason (sold)|  |
|sale/saleNumber| *None* |Number: Number|  |
|sale/hasStakeholders| *None* |Has stakeholders: Does this sale have stakeholders enabled|  |
|sale/hasQuote| *None* |Has quote?: Does the sale have a quote attached?|  |
|sale/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|sale/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|sale/visibleFor| *None* |Visible for|  |
|sale/sale/textId| *None* |Text ID|  |
|sale/sale/description| *None* |Text: Displays the text entered in the description field|  |
|sale/salePublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|sale/salePublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|sale/salePublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|sale/salePublish/publishedBy| *None* |Published by: Published by|  |
|sale/associate/firstName| *None* |First name: Displays the contact's first name|  |
|sale/associate/lastName| *None* |Last name: Displays the contact's last name|  |
|sale/associate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|sale/associate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|sale/associate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|sale/associate/personId| *None* |Contact ID: Database ID of the contact row|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/associate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|sale/associate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|sale/associate/associateDbId| *None* |ID|  |
|sale/associate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|sale/associate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|sale/associate/usergroup| *None* |Primary group: The user's primary user group|  |
|sale/associate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|sale/associate/contactCategory| *None* |Category: Category|  |
|sale/associate/role| *None* |Role : Role|  |
|sale/associate/assocName| *None* |User ID : User ID|  |
|sale/associate/assocTooltip| *None* |Description : Description|  |
|sale/associate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|sale/associate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|sale/associate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|sale/associate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|sale/associate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|sale/associate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|sale/associate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|sale/associate/otherGroups| *None* |Other groups: Other groups|  |
|sale/associate/userName| *None* |User name: User name|  |
|sale/associate/personEmail| *None* |E-mail|  |
|sale/saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|sale/saleUdef/SuperOffice:2| *None* |salelongtext|  |
|sale/saleUdef/SuperOffice:3| *None* |salenumber|  |
|sale/saleUdef/SuperOffice:4| *None* |saledate|  |
|sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|sale/saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|sale/saleUdef/SuperOffice:8| *None* |saledecimal|  |
|document/textId| *None* |Text ID|  |
|document/description| *None* |Text: Displays the text entered in the description field|  |
|appointmentId| *None* |DB ID: Displays the database ID of a row|  |
|priority| *None* |Priority: Displays the priority of the activity|  |
|alarm| *None* |Has alarm: Displays the alarm state of a follow-up|  |
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
|appointment/textId| *None* |Text ID|  |
|appointment/description| *None* |Text: Displays the text entered in the description field|  |
|ticketStatusName| *None* |Status: Request status|  |
|categoryFullName| *None* |Category: Request category|  |
|priorityName| *None* |Priority: Service priority|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|tags| *None* |Tags: Tags connected to a request|  |
|ownedBy| *None* |Owner: The owner of the request|  |
|content| *None* |Content: Search for content in messages related to requests|  |
|messageLanguage| *None* |Language: Recognized language in messages|  |
|sentimentScore| *None* |Sentiment: Sentiment score, -100 to +100|  |
|suggestedCategory| *None* |Sugg.Cat.: Suggested service category|  |
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
|createdBy/contactFullName| *None* |Created by - Owner: Name and department of the company the user belongs to|  |
|createdBy/contactCategory| *None* |Created by - Category: Category|  |
|createdBy/role| *None* |Created by - Role: Role|  |
|createdBy/assocName| *None* |Created by - User ID: User ID|  |
|createdBy/assocTooltip| *None* |Created by - Description: Description|  |
|createdBy/assocType| *None* |Created by - Type: Type of user: associate, external user, system user, anonymous account|  |
|createdBy/ejUserId| *None* |Created by - Service user ID: The database ID of a Service user|  |
|createdBy/simultaneousEjUser| *None* |Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|createdBy/ejDisplayName| *None* |Created by - Nick name: User's nick name in Service|  |
|createdBy/ejStatus| *None* |Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in|  |
|createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|createdBy/isActive| *None* |Created by - Active: Is this user active, and should be able to log in?|  |
|createdBy/isActiveText| *None* |Created by - Active status: Is this user active, and should be able to log in?|  |
|createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|createdBy/otherGroups| *None* |Created by - Other groups: Other groups|  |
|createdBy/userName| *None* |Created by - User name: User name|  |
|createdBy/personEmail| *None* |Created by - E-mail|  |
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
|ownedBy/contactFullName| *None* |Owner - Owner: Name and department of the company the user belongs to|  |
|ownedBy/contactCategory| *None* |Owner - Category: Category|  |
|ownedBy/role| *None* |Owner - Role: Role|  |
|ownedBy/assocName| *None* |Owner - User ID: User ID|  |
|ownedBy/assocTooltip| *None* |Owner - Description: Description|  |
|ownedBy/assocType| *None* |Owner - Type: Type of user: associate, external user, system user, anonymous account|  |
|ownedBy/ejUserId| *None* |Owner - Service user ID: The database ID of a Service user|  |
|ownedBy/simultaneousEjUser| *None* |Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ownedBy/ejDisplayName| *None* |Owner - Nick name: User's nick name in Service|  |
|ownedBy/ejStatus| *None* |Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in|  |
|ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|ownedBy/isActive| *None* |Owner - Active: Is this user active, and should be able to log in?|  |
|ownedBy/isActiveText| *None* |Owner - Active status: Is this user active, and should be able to log in?|  |
|ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|ownedBy/otherGroups| *None* |Owner - Other groups: Other groups|  |
|ownedBy/userName| *None* |Owner - User name: User name|  |
|ownedBy/personEmail| *None* |Owner - E-mail|  |
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
|extra/x\_ticket\_faq| *None* |Extra FAQ Relation|  |
|extra/x\_ticket\_category\_relation| *None* |Extra category relation: Category relation on request|  |
|extra/y\_equipment/x\_name| *None* |Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |

## Sample

```http!
GET /api/v1/archive/Favourites?$select=person/personAssociateFullName,person/personAddress/line2,project/updatedBy,project/projectAssociate/lastName,project/projectUdef/SuperOffice:7
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

