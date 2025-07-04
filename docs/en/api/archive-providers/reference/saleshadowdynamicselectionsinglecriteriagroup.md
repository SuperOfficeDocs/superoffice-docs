---
uid: SaleShadowDynamicSelectionSingleCriteriaGroup
title: SaleShadowDynamicSelectionSingleCriteriaGroup
description: Shadow contact provider for the dynamic sale provider.
keywords: SaleShadowDynamicSelectionSingleCriteriaGroup archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "SaleShadowDynamicSelectionSingleCriteriaGroup"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.SaleShadowSelectionDynamicProviderSingleCriteriaGroup">SuperOffice.CRM.ArchiveLists.Archive.SaleShadowSelectionDynamicProviderSingleCriteriaGroup</see> inside NetServer's SODatabase assembly.

Shadow contact provider for the dynamic sale provider.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"sale"|Sale|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|icon|listAny|Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|time| *None* |Time: Time|  |
|type|listAny|Type: Displays the type of an activity| x |
|recordType|string|Record type : Shows the record type| x |
|text|positiveString|Text: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|projectId|listAny|Project ID: Database ID of project record| x |
|saleId|int|Sale ID: The database ID of the sale record| x |
|userGroup|userGroup|User group : The user group that owns the record| x |
|who| *None* |Who: Contact and/or company|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|currencyId|int|Currency ID: The currency list item ID| x |
|currency|listAny|Currency: The currency of the sale| x |
|credited|listAny|Credited: The user to be credited with the sale| x |
|lossReason|listAny|Reason (lost: The reason for losing the sale| x |
|source|listAny|Source: The source (lead) of the sale| x |
|competitor|listAny|Competitor: The competitor who won the sale| x |
|heading|stringorPK|Sale: The name of the sale| x |
|amount|decimal|Amount: The gross sales total| x |
|amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.| x |
|earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale| x |
|earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total| x |
|probPercent|int|Probability as %: Probability as %| x |
|originalStage|listAny|Stage: Displays the stage of the sale| x |
|stage|listAny|Stage: Displays the stage of the sale| x |
|stageName| *None* |Stage name: Displays the stage of the sale| x |
|saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|stageRank| *None* |Stage rank: Rank of the sale stage in the stage list| x |
|saleType|listAny|Sale type: Sale type, from list| x |
|saleTypeId| *None* |Sale type ID: Sale type, from list| x |
|stageId| *None* |Sale stage ID: Displays the stage of the sale| x |
|nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|reopenDate|date|Reopen date: Displays the reopen date for the sale| x |
|stalledComment|listAny|Reason (stalled: The reason the sale has been stalled| x |
|saleTypeCategory|listAny|Sale type category: Sale type category| x |
|soldReason|listAny|Reason (sold: Reason (sold)| x |
|saleNumber|string|Number: Number| x |
|hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders enabled| x |
|hasQuote|bool|Has quote?: Does the sale have a quote attached?| x |
|hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|description|string|Description: The long description field on Sale|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|createdByWorkflow|listAny|Created by flow: Created by flow| x |
|amountInBaseCurrency| *None* |Amount (BaseCurrency): The gross sales total| x |
|amountWeightedInBaseCurrency| *None* |Weighted amount (BaseCurrency): Virtual field calculated from amount * probability percent.| x |
|visibleFor|listAny|Visible for|  |
|sale/textId|int|Text ID| x |
|sale/description|positiveString|Text: Displays the text entered in the description field| x |
|salePublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|salePublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|salePublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|salePublish/publishedBy| *None* |Published by: Published by|  |
|person/personId|int|DB ID: Displays the database ID of a contact| x |
|person/firstName|string|First name: Displays the contact's first name| x |
|person/lastName|string|Last name: Displays the contact's last name| x |
|person/middleName|string|Middle name: Displays the contact's middle name.| x |
|person/fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
|person/contactId|int|Company ID: Database ID of company| x |
|person/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|person/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|person/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/position|listAny|Position| x |
|person/personNumber|string|Number: Displays the contact's number| x |
|person/title|string|Title: Displays the contact's job title| x |
|person/personCountry|listAny|Country: Country| x |
|person/personCountryId|int|Country ID: Country ID| x |
|person/personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox| x |
|person/rank|int|Rank: Displays a contact's current rank| x |
|person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|person/useAsMailingAddress|bool|Use as postal address: Use as postal address| x |
|person/personSource|listAny|Source: Source (Contact)| x |
|person/retired|bool|Former employee: Indicates whether the contact has retired/left the company| x |
|person/birthYear|int|Birth year: Displays contact's birth year| x |
|person/birthMonth|int|Birth month: Displays contact's birth month| x |
|person/birthDay|int|Birth day: Displays contact's birth day (day of month)| x |
|person/kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet| x |
|person/kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet| x |
|person/personUpdatedBy|associate|Updated by: The user who last updated the data| x |
|person/personUpdatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|person/personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|person/personRegisteredBy|associate|Registered by: The user who registered the data| x |
|person/personRegisteredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|person/personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|person/portraitThumbnail| *None* |Person image: Person image|  |
|person/personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|person/ticketPriority|listAny|Service priority: Default service priority for this contact| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|person/supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|person/supportAssociateFullName|associate|Our service contact - Full name: Default service contact for this contact| x |
|person/personAssociateId|associate|Our contact: Displays our contact| x |
|person/personAssociateFullName|associate|Our contact - Full name: Displays our contact| x |
|person/personCategory|listAny|Category| x |
|person/personBusiness|listAny|Business| x |
|person/personDeletedDate|datetime|Deleted date: Deleted date|  |
|person/hasCompany|bool|Has company: The contact is associated with a company| x |
|person/isProjectMember|bool|Is project member: This person is a project member| x |
|person/isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|person/updatedByWorkflow|listAny|Updated by flow: Updated by flow| x |
|person/whenUpdatedByWorkflow|datetime|When updated by flow: When updated by flow| x |
|person/createdByForm|listAny|Created by form: Created by form| x |
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
|person/personExtra/x\_person\_integer|int|Extra Integer: Custom person integer| x |
|person/personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden| x |
|person/personExtra/x\_person\_float|decimal|Extra float: Custom float field| x |
|person/personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|person/personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019| x |
|person/personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default| x |
|person/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default| x |
|person/personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked| x |
|person/personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|person/personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|person/personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|person/personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field| x |
|person/personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation| x |
|person/personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation| x |
|person/personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact| x |
|person/personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person| x |
|person/personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact| x |
|person/personExtra/y\_rental/id|int|Rental - id: Displays the row's primary key (y\_rental)| x |
|person/personExtra/y\_rental/x\_start|date|Rental - Start rental| x |
|person/personExtra/y\_rental/x\_end|date|Rental - End| x |
|person/personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1| x |
|person/personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment| x |
|person/personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|person/personExtra/y\_car/id|int|Car - id: Displays the row's primary key (y\_car)| x |
|person/personAssociate/firstName|string|First name: Displays the contact's first name| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/personAssociate/lastName|string|Last name: Displays the contact's last name| x |
|person/personAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|person/personAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|person/personAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|person/personAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|person/personAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/personAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|person/personAssociate/associateDbId|associate|ID| x |
|person/personAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|person/personAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|person/personAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|person/personAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|person/personAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|person/personAssociate/contactCategory|listAny|Category: Category| x |
|person/personAssociate/role|listAny|Role : Role| x |
|person/personAssociate/assocName|associate|User ID : User ID| x |
|person/personAssociate/assocTooltip|string|Description : Description|  |
|person/personAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|person/personAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|person/personAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|person/personAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|person/personAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|person/personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|person/personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|person/personAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|person/personAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|person/personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|person/personAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|person/personAssociate/userName|string|User name: User name| x |
|person/personAssociate/personEmail|string|E-mail| x |
|person/personAssociate/locationAddress|string|Location: Location| x |
|person/personAssociate/isLocation|bool|Is a location: Is a location| x |
|person/correspondingAssociate/firstName|string|First name: Displays the contact's first name| x |
|person/correspondingAssociate/lastName|string|Last name: Displays the contact's last name| x |
|person/correspondingAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|person/correspondingAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|person/correspondingAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|person/correspondingAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|person/correspondingAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|person/correspondingAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|person/correspondingAssociate/associateDbId|associate|ID| x |
|person/correspondingAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|person/correspondingAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|person/correspondingAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|person/correspondingAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|person/correspondingAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|person/correspondingAssociate/contactCategory|listAny|Category: Category| x |
|person/correspondingAssociate/role|listAny|Role : Role| x |
|person/correspondingAssociate/assocName|associate|User ID : User ID| x |
|person/correspondingAssociate/assocTooltip|string|Description : Description|  |
|person/correspondingAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|person/correspondingAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|person/correspondingAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|person/correspondingAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|person/correspondingAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|person/correspondingAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|person/correspondingAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|person/correspondingAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|person/correspondingAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|person/correspondingAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|person/correspondingAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|person/correspondingAssociate/userName|string|User name: User name| x |
|person/correspondingAssociate/personEmail|string|E-mail| x |
|person/correspondingAssociate/locationAddress|string|Location: Location| x |
|person/correspondingAssociate/isLocation|bool|Is a location: Is a location| x |
|person/isMailingRecipient|bool|Is mailing recipient: isMailingRecipient| x |
|person/hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/subscription|listAny|Subscription: Subscription for marketing| x |
|person/legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|person/consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contact/contactId|int|Company ID: Database ID of company| x |
|contact/name|stringorPK|Company name| x |
|contact/department|string|Department| x |
|contact/nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|contact/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|contact/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|contact/associateId|associate|Our contact: Displays our contact| x |
|contact/category|listAny|Category| x |
|contact/business|listAny|Business| x |
|contact/country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|contact/countryId|int|Country ID: Country ID| x |
|contact/number|string|Number| x |
|contact/code|string|Code| x |
|contact/orgnr|string|VAT No.| x |
|contact/stop|bool|Stop| x |
|contact/contactNoMail|bool|No mailings (company| x |
|contact/updatedBy|associate|Updated by: The user who last updated the data| x |
|contact/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|contact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|contact/registeredBy|associate|Registered by: The user who registered the data| x |
|contact/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|contact/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contact/contactSource|listAny|Source: Source (Company)| x |
|contact/contactDeleted|bool|Deleted: Deleted| x |
|contact/phone/formattedNumber|string|Phone : Displays phone number|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|contact/deletedDate|datetime|Deleted date: Deleted date|  |
|contact/mainContact| *None* |Main contact: Main contact for this company| x |
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
|contact/contactAssociate/usergroupId|int|Group ID: The user's primary user group| x |
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
|contact/contactAssociate/locationAddress|string|Location: Location| x |
|contact/contactAssociate/isLocation|bool|Is a location: Is a location| x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|contact/contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|contact/contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|contact/contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|contact/contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|contact/contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|contact/contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|contact/contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|contact/contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|contact/contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|contact/contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|contact/contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|contact/contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|contact/contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|contact/contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
|contact/contactExtra/y\_organization/x\_name|string|Organization - Name| x |
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
|contact/SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|contact/SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|contact/saintSaleStatus|listAny|With status|  |
|contact/saintAmountClass|listAny|Amount class|  |
|contact/saintActivityType|listAny|SAINT type|  |
|contact/saintDirection|listAny|Direction|  |
|contact/saintIntention|listAny|Intention|  |
|contact/saintTicketStatus|listAny|Status|  |
|contact/saintTicketCategory|listAny|Category|  |
|associate/firstName|string|First name: Displays the contact's first name| x |
|associate/lastName|string|Last name: Displays the contact's last name| x |
|associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|associate/personId|int|Contact ID: Database ID of the contact row|  |
|associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|associate/associateDbId|associate|ID| x |
|associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|associate/usergroupId|int|Group ID: The user's primary user group| x |
|associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|associate/contactCategory|listAny|Category: Category| x |
|associate/role|listAny|Role : Role| x |
|associate/assocName|associate|User ID : User ID| x |
|associate/assocTooltip|string|Description : Description|  |
|associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|associate/portraitThumbnail| *None* |Person image: Person image|  |
|associate/otherGroups|userGroup|Other groups: Other groups|  |
|associate/userName|string|User name: User name| x |
|associate/personEmail|string|E-mail| x |
|associate/locationAddress|string|Location: Location| x |
|associate/isLocation|bool|Is a location: Is a location| x |
|saleUdef/SuperOffice:1|string|saleshorttext| x |
|saleUdef/SuperOffice:2|string|salelongtext| x |
|saleUdef/SuperOffice:3|int|salenumber| x |
|saleUdef/SuperOffice:4|date|saledate| x |
|saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|saleUdef/SuperOffice:6|bool|salecheckbox| x |
|saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|saleUdef/SuperOffice:8|decimal|saledecimal| x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|project/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|project/projectId|int|DB ID: Displays the database ID for a project row| x |
|project/name|stringorPK|Project name: Displays the Project's name| x |
|project/number|string|Number: Displays the project's number| x |
|project/type|listAny|Project type: Displays the project's type| x |
|project/status|listAny|Status: Displays the project's status| x |
|project/statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|project/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|project/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|project/icon| *None* |Category: Displays the icon for an activity type| x |
|project/text|string|Text: Displays a descriptive text for the item| x |
|project/description|string|Description : Description| x |
|project/updatedBy|associate|Updated by: The user who last updated the data| x |
|project/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|project/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|project/registeredBy|associate|Registered by: The user who registered the data| x |
|project/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|project/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|project/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|project/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|project/endDate|date|End date: End date of project| x |
|project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|project/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|project/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|project/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|project/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|project/projectEvent/eventDate|date|Event date: Event date| x |
|project/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|project/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|project/projectUrl/URLAddress|string|URL| x |
|project/projectUrl/URLDescription|string|Description| x |
|project/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|project/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|project/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|project/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|project/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|project/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|project/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/associateDbId|associate|ID| x |
|project/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|project/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|project/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|project/projectAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|project/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|project/projectAssociate/contactCategory|listAny|Category: Category| x |
|project/projectAssociate/role|listAny|Role : Role| x |
|project/projectAssociate/assocName|associate|User ID : User ID| x |
|project/projectAssociate/assocTooltip|string|Description : Description|  |
|project/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|project/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|project/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|project/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|project/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|project/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|project/projectAssociate/userName|string|User name: User name| x |
|project/projectAssociate/personEmail|string|E-mail| x |
|project/projectAssociate/locationAddress|string|Location: Location| x |
|project/projectAssociate/isLocation|bool|Is a location: Is a location| x |
|project/projectUdef/SuperOffice:1|string|projectshorttext| x |
|project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|project/projectUdef/SuperOffice:3|int|projectnumber| x |
|project/projectUdef/SuperOffice:4|date|projectdate| x |
|project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|project/NumberOfActivities|int|Number of activities|  |
|project/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|project/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|project/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|project/LastActivity|date|Date of last activity|  |
|project/LastCompletedActivity|date|Date of last completed activity|  |
|project/LastDoByActivity|date|Date of last non-completed activity|  |
|project/NumberOfSales|int|Number of sales|  |
|project/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|project/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|project/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|project/LastSale|date|Date of last sale|  |
|project/LastCompletedSale|date|Date of last completed sale|  |
|project/LastDoBySale|date|Date of last non-completed sale|  |
|project/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|project/saintSaleStatus|listAny|With status|  |
|project/saintAmountClass|listAny|Amount class|  |
|project/saintActivityType|listAny|SAINT type|  |
|project/saintDirection|listAny|Direction|  |
|project/saintIntention|listAny|Intention|  |
|project/saintTicketStatus|listAny|Status|  |
|project/saintTicketCategory|listAny|Category|  |
|project/project/textId|int|Text ID| x |
|project/project/infoText|positiveString|Information: Displays the text entered in the description field| x |
|saleStakeholder/saleStakeholderId|int|Stakeholder - Stakeholder ID: Database ID of the stakeholder row| x |
|saleStakeholder/saleId|int|Stakeholder - Sale ID: The database ID of the sale record| x |
|saleStakeholder/comment|string|Stakeholder - Sales role comment text: Sales role comment text| x |
|saleStakeholder/salesRoleId|listAny|Stakeholder - Sales role: Sales role| x |
|saleStakeholder/hasInfoText|bool|Stakeholder - Sales role comment: Sales role comment| x |
|saleStakeholder/person/personId|int|Stakeholder - DB ID: Displays the database ID of a contact| x |
|saleStakeholder/person/firstName|string|Stakeholder - First name: Displays the contact's first name| x |
|saleStakeholder/person/lastName|string|Stakeholder - Last name: Displays the contact's last name| x |
|saleStakeholder/person/middleName|string|Stakeholder - Middle name: Displays the contact's middle name.| x |
|saleStakeholder/person/fullName|stringorPK|Stakeholder - Contact: Displays the contact to which an item is linked| x |
|saleStakeholder/person/contactId|int|Stakeholder - Company ID: Database ID of company| x |
|saleStakeholder/person/hasInfoText|bool|Stakeholder - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|saleStakeholder/person/hasInterests|bool|Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests| x |
|saleStakeholder/person/personHasInterests|bool|Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests| x |
|saleStakeholder/person/mrMrs|string|Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|saleStakeholder/person/position|listAny|Stakeholder - Position| x |
|saleStakeholder/person/personNumber|string|Stakeholder - Number: Displays the contact's number| x |
|saleStakeholder/person/title|string|Stakeholder - Title: Displays the contact's job title| x |
|saleStakeholder/person/personCountry|listAny|Stakeholder - Country: Country| x |
|saleStakeholder/person/personCountryId|int|Stakeholder - Country ID: Country ID| x |
|saleStakeholder/person/personNoMail|bool|Stakeholder - No Mailings: Displays the contact's No Mailings checkbox| x |
|saleStakeholder/person/rank|int|Stakeholder - Rank: Displays a contact's current rank| x |
|saleStakeholder/person/birthdate| *None* |Stakeholder - Birthdate: Displays the contact's date of birth|  |
|saleStakeholder/person/associateType| *None* |Stakeholder - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|saleStakeholder/person/useAsMailingAddress|bool|Stakeholder - Use as postal address: Use as postal address| x |
|saleStakeholder/person/personSource|listAny|Stakeholder - Source: Source (Contact)| x |
|saleStakeholder/person/retired|bool|Stakeholder - Former employee: Indicates whether the contact has retired/left the company| x |
|saleStakeholder/person/birthYear|int|Stakeholder - Birth year: Displays contact's birth year| x |
|saleStakeholder/person/birthMonth|int|Stakeholder - Birth month: Displays contact's birth month| x |
|saleStakeholder/person/birthDay|int|Stakeholder - Birth day: Displays contact's birth day (day of month)| x |
|saleStakeholder/person/kanaFirstName|string|Stakeholder - First name, kana: Contact's first name, in kana alphabet| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/kanaLastName|string|Stakeholder - Last name, kana: Contact's last name, in kana alphabet| x |
|saleStakeholder/person/personUpdatedBy|associate|Stakeholder - Updated by: The user who last updated the data| x |
|saleStakeholder/person/personUpdatedByFullName|associate|Stakeholder - Updated by - Full name: The user who last updated the data| x |
|saleStakeholder/person/personUpdatedDate|date|Stakeholder - Updated: The date/time the data was last updated in UTC.| x |
|saleStakeholder/person/personRegisteredBy|associate|Stakeholder - Registered by: The user who registered the data| x |
|saleStakeholder/person/personRegisteredByFullName|associate|Stakeholder - Registered by - Full name: The user who registered the data| x |
|saleStakeholder/person/personRegisteredDate|date|Stakeholder - Registered date: The date/time the data was registered in UTC.| x |
|saleStakeholder/person/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/personActiveErpLinks|bool|Stakeholder - ERP connected: Is there an active ERP Sync?| x |
|saleStakeholder/person/ticketPriority|listAny|Stakeholder - Service priority: Default service priority for this contact| x |
|saleStakeholder/person/supportLanguage|listAny|Stakeholder - Preferred language: Preferred language used for reply templates and more| x |
|saleStakeholder/person/supportAssociate|associate|Stakeholder - Our service contact: Default service contact for this contact| x |
|saleStakeholder/person/supportAssociateFullName|associate|Stakeholder - Our service contact - Full name: Default service contact for this contact| x |
|saleStakeholder/person/personAssociateId|associate|Stakeholder - Our contact: Displays our contact| x |
|saleStakeholder/person/personAssociateFullName|associate|Stakeholder - Our contact - Full name: Displays our contact| x |
|saleStakeholder/person/personCategory|listAny|Stakeholder - Category| x |
|saleStakeholder/person/personBusiness|listAny|Stakeholder - Business| x |
|saleStakeholder/person/personDeletedDate|datetime|Stakeholder - Deleted date: Deleted date|  |
|saleStakeholder/person/hasCompany|bool|Stakeholder - Has company: The contact is associated with a company| x |
|saleStakeholder/person/isProjectMember|bool|Stakeholder - Is project member: This person is a project member| x |
|saleStakeholder/person/isStakeholder|bool|Stakeholder - Is stakeholder: This person is a sale stakeholder| x |
|saleStakeholder/person/updatedByWorkflow|listAny|Stakeholder - Updated by flow: Updated by flow| x |
|saleStakeholder/person/whenUpdatedByWorkflow|datetime|Stakeholder - When updated by flow: When updated by flow| x |
|saleStakeholder/person/createdByForm|listAny|Stakeholder - Created by form: Created by form| x |
|saleStakeholder/person/phone/formattedNumber|string|Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectPhone/formattedNumber|string|Stakeholder - Direct - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectPhone/description|string|Stakeholder - Direct - Description: Phone number description| x |
|saleStakeholder/person/personMobilePhone/formattedNumber|string|Stakeholder - Mobile - Phone: Displays phone number|  |
|saleStakeholder/person/personMobilePhone/description|string|Stakeholder - Mobile - Description: Phone number description| x |
|saleStakeholder/person/personPrivate/formattedNumber|string|Stakeholder - Private - Phone: Displays phone number|  |
|saleStakeholder/person/personPrivate/description|string|Stakeholder - Private - Description: Phone number description| x |
|saleStakeholder/person/personPager/formattedNumber|string|Stakeholder - Other - Phone: Displays phone number|  |
|saleStakeholder/person/personPager/description|string|Stakeholder - Other - Description: Phone number description| x |
|saleStakeholder/person/personDirectFax/formattedNumber|string|Stakeholder - Fax - Phone: Displays phone number|  |
|saleStakeholder/person/personDirectFax/description|string|Stakeholder - Fax - Description: Phone number description| x |
|saleStakeholder/person/searchPhone/formattedNumber|string|Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/person/searchPhone/description|string|Stakeholder - Description: Phone number description| x |
|saleStakeholder/person/personInfo/textId|int|Stakeholder - Text ID| x |
|saleStakeholder/person/personInfo/infoText|positiveString|Stakeholder - Information: Displays the text entered in the description field| x |
|saleStakeholder/person/email/emailProtocol|string|Stakeholder - Protocol: E-mail protocol, such as SMTP| x |
|saleStakeholder/person/email/emailAddress|string|Stakeholder - E-mail| x |
|saleStakeholder/person/email/emailDescription|string|Stakeholder - Description| x |
|saleStakeholder/person/email/emailId|int|Stakeholder - ID| x |
|saleStakeholder/person/email/emailLastSent|datetime|Stakeholder - Last sent: The date and time an e-mail was last sent to this address| x |
|saleStakeholder/person/email/emailBounceCount|int|Stakeholder - Bounce count: Bounce count for this e-mail address| x |
|saleStakeholder/person/email/emailLastBounce|datetime|Stakeholder - Last bounce: Date and time for last bounce to this e-mail address| x |
|saleStakeholder/person/email/emailHasBounced|bool|Stakeholder - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|saleStakeholder/person/personUrl/URLAddress|string|Stakeholder - URL| x |
|saleStakeholder/person/personUrl/URLDescription|string|Stakeholder - Description| x |
|saleStakeholder/person/personAddress/addressId|int|Stakeholder - Contact address - Address ID: Database ID for the address record| x |
|saleStakeholder/person/personAddress/line1|string|Stakeholder - Contact address - Address 1: First line of the address| x |
|saleStakeholder/person/personAddress/line2|string|Stakeholder - Contact address - Address 2: Second line of the address| x |
|saleStakeholder/person/personAddress/line3|string|Stakeholder - Contact address - Address 3: Third line of the address| x |
|saleStakeholder/person/personAddress/county|string|Stakeholder - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|saleStakeholder/person/personAddress/city|string|Stakeholder - Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|saleStakeholder/person/personAddress/zip|string|Stakeholder - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|saleStakeholder/person/personAddress/state|string|Stakeholder - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|saleStakeholder/person/personAddress/wgs84latitude|decimal|Stakeholder - Contact address - Latitude: Latitude| x |
|saleStakeholder/person/personAddress/wgs84longitude|decimal|Stakeholder - Contact address - Longitude: Longitude| x |
|saleStakeholder/person/personAddress/formattedAddress| *None* |Stakeholder - Contact address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personAddress/formattedMultiLineAddress| *None* |Stakeholder - Contact address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/addressId|int|Stakeholder - Search address - Address ID: Database ID for the address record| x |
|saleStakeholder/person/restrictionAddress/line1|string|Stakeholder - Search address - Address 1: First line of the address| x |
|saleStakeholder/person/restrictionAddress/line2|string|Stakeholder - Search address - Address 2: Second line of the address| x |
|saleStakeholder/person/restrictionAddress/line3|string|Stakeholder - Search address - Address 3: Third line of the address| x |
|saleStakeholder/person/restrictionAddress/county|string|Stakeholder - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|saleStakeholder/person/restrictionAddress/city|string|Stakeholder - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|saleStakeholder/person/restrictionAddress/zip|string|Stakeholder - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|saleStakeholder/person/restrictionAddress/state|string|Stakeholder - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|saleStakeholder/person/restrictionAddress/wgs84latitude|decimal|Stakeholder - Search address - Latitude: Latitude| x |
|saleStakeholder/person/restrictionAddress/wgs84longitude|decimal|Stakeholder - Search address - Longitude: Longitude| x |
|saleStakeholder/person/restrictionAddress/formattedAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/formattedMultiLineAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personInterestIds|listInterest|Stakeholder - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|saleStakeholder/person/personUdef/SuperOffice:1|string|Stakeholder - contactshorttext: tooltipshorttext| x |
|saleStakeholder/person/personUdef/SuperOffice:2|string|Stakeholder - contactlongtext: tooltiplongtext| x |
|saleStakeholder/person/personUdef/SuperOffice:3|int|Stakeholder - contactnumber| x |
|saleStakeholder/person/personUdef/SuperOffice:4|date|Stakeholder - contactdate| x |
|saleStakeholder/person/personUdef/SuperOffice:5|unlimitedDate|Stakeholder - contactunlimiteddate: tooltipunlimiteddate| x |
|saleStakeholder/person/personUdef/SuperOffice:6|bool|Stakeholder - contactcheckbox| x |
|saleStakeholder/person/personUdef/SuperOffice:7|listAny|Stakeholder - contactdropdownlistbox| x |
|saleStakeholder/person/personUdef/SuperOffice:8|decimal|Stakeholder - contactdecimal| x |
|saleStakeholder/person/personUdef/SuperOffice:9|string|Stakeholder - page1saleonly| x |
|saleStakeholder/person/personUdef/SuperOffice:10|string|Stakeholder - page1marketingonly| x |
|saleStakeholder/person/personUdef/SuperOffice:11|string|Stakeholder - page1adminonly| x |
|saleStakeholder/person/personExtra/x\_person\_integer|int|Stakeholder - Extra Integer: Custom person integer| x |
|saleStakeholder/person/personExtra/x\_person\_hidden\_integer|int|Stakeholder - Extra hidden integer: Custom integer field that is hidden| x |
|saleStakeholder/person/personExtra/x\_person\_float|decimal|Stakeholder - Extra float: Custom float field| x |
|saleStakeholder/person/personExtra/x\_person\_longtext|string|Stakeholder - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|saleStakeholder/person/personExtra/x\_person\_date|date|Stakeholder - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|saleStakeholder/person/personExtra/x\_person\_datetime|datetime|Stakeholder - Extra DateTime: Custom person date and time field. No default| x |
|saleStakeholder/person/personExtra/x\_person\_time| *None* |Stakeholder - Extra time: Custom time field on person. Current time as default| x |
|saleStakeholder/person/personExtra/x\_person\_boolean|bool|Stakeholder - Extra Boolean: Custom boolean field on person. Default checked| x |
|saleStakeholder/person/personExtra/x\_person\_timespan|timeSpan|Stakeholder - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|saleStakeholder/person/personExtra/x\_person\_shorttext|string|Stakeholder - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|saleStakeholder/person/personExtra/x\_person\_shorttext\_list|listAny|Stakeholder - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|saleStakeholder/person/personExtra/x\_person\_user\_relation|associate|Stakeholder - Extra user relation: Custom person-user relation field| x |
|saleStakeholder/person/personExtra/x\_person\_category\_relation|listAny|Stakeholder - Extra category relation: Custom person-category relation| x |
|saleStakeholder/person/personExtra/x\_person\_priority\_relation|listAny|Stakeholder - Extra priority relation: Custom person-priority relation| x |
|saleStakeholder/person/personExtra/x\_person\_request\_relation|stringorPK|Stakeholder - Extra request relation: Request relation on contact| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/personExtra/x\_person\_appointment\_relation|stringorPK|Stakeholder - Extra appointment relation: Appointment relation on person| x |
|saleStakeholder/person/personExtra/x\_person\_contact\_relation|stringorPK|Stakeholder - Extra company relation: Company relation on contact| x |
|saleStakeholder/person/personExtra/y\_rental/id|int|Stakeholder - Rental - id: Displays the row's primary key (y\_rental)| x |
|saleStakeholder/person/personExtra/y\_rental/x\_start|date|Stakeholder - Rental - Start rental| x |
|saleStakeholder/person/personExtra/y\_rental/x\_end|date|Stakeholder - Rental - End| x |
|saleStakeholder/person/personExtra/y\_rental/x\_amount|int|Stakeholder - Rental - Amount: Number to rent. Default = 1| x |
|saleStakeholder/person/personExtra/y\_rental/x\_contact|stringorPK|Stakeholder - Rental - Renter: Company that rents equipment| x |
|saleStakeholder/person/personExtra/y\_rental/y\_equipment/x\_name|string|Stakeholder - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|saleStakeholder/person/personExtra/y\_car/id|int|Stakeholder - Car - id: Displays the row's primary key (y\_car)| x |
|saleStakeholder/person/personAssociate/firstName|string|Stakeholder - First name: Displays the contact's first name| x |
|saleStakeholder/person/personAssociate/lastName|string|Stakeholder - Last name: Displays the contact's last name| x |
|saleStakeholder/person/personAssociate/middleName|string|Stakeholder - Middle Name: Displays the contact's middle name.| x |
|saleStakeholder/person/personAssociate/fullName|string|Stakeholder - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|saleStakeholder/person/personAssociate/contactId|int|Stakeholder - Company ID: Database ID of the company the user belongs to|  |
|saleStakeholder/person/personAssociate/personId|int|Stakeholder - Contact ID: Database ID of the contact row|  |
|saleStakeholder/person/personAssociate/mrMrs|string|Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|saleStakeholder/person/personAssociate/title|string|Stakeholder - Title: Displays whether the contact is addressed as Mr or Ms| x |
|saleStakeholder/person/personAssociate/associateDbId|associate|Stakeholder - ID| x |
|saleStakeholder/person/personAssociate/contactName|string|Stakeholder - Owning company: Name of the company the user belongs to| x |
|saleStakeholder/person/personAssociate/contactDepartment|string|Stakeholder - Owning department: Name of the department at the company the user belongs to| x |
|saleStakeholder/person/personAssociate/usergroup|userGroup|Stakeholder - Primary group: The user's primary user group| x |
|saleStakeholder/person/personAssociate/usergroupId|int|Stakeholder - Group ID: The user's primary user group| x |
|saleStakeholder/person/personAssociate/contactFullName|string|Stakeholder - Owner: Name and department of the company the user belongs to| x |
|saleStakeholder/person/personAssociate/contactCategory|listAny|Stakeholder - Category: Category| x |
|saleStakeholder/person/personAssociate/role|listAny|Stakeholder - Role: Role| x |
|saleStakeholder/person/personAssociate/assocName|associate|Stakeholder - User ID: User ID| x |
|saleStakeholder/person/personAssociate/assocTooltip|string|Stakeholder - Description: Description|  |
|saleStakeholder/person/personAssociate/assocType|listAny|Stakeholder - Type: Type of user: associate, external user, system user, anonymous account| x |
|saleStakeholder/person/personAssociate/ejUserId|int|Stakeholder - Service user ID: The database ID of a Service user|  |
|saleStakeholder/person/personAssociate/simultaneousEjUser|bool|Stakeholder - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|saleStakeholder/person/personAssociate/ejDisplayName|string|Stakeholder - Nick name: User's nick name in Service| x |
|saleStakeholder/person/personAssociate/ejStatus|int|Stakeholder - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|saleStakeholder/person/personAssociate/credentialType| *None* |Stakeholder - Auth. type: What type of credentials to use when this user logs in| x |
|saleStakeholder/person/personAssociate/credentialDisplayValue| *None* |Stakeholder - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|saleStakeholder/person/personAssociate/isActive|bool|Stakeholder - Active: Is this user active, and should be able to log in?| x |
|saleStakeholder/person/personAssociate/isActiveText|bool|Stakeholder - Active status: Is this user active, and should be able to log in?| x |
|saleStakeholder/person/personAssociate/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/personAssociate/otherGroups|userGroup|Stakeholder - Other groups: Other groups|  |
|saleStakeholder/person/personAssociate/userName|string|Stakeholder - User name: User name| x |
|saleStakeholder/person/personAssociate/personEmail|string|Stakeholder - E-mail| x |
|saleStakeholder/person/personAssociate/locationAddress|string|Stakeholder - Location: Location| x |
|saleStakeholder/person/personAssociate/isLocation|bool|Stakeholder - Is a location: Is a location| x |
|saleStakeholder/person/correspondingAssociate/firstName|string|Stakeholder - First name: Displays the contact's first name| x |
|saleStakeholder/person/correspondingAssociate/lastName|string|Stakeholder - Last name: Displays the contact's last name| x |
|saleStakeholder/person/correspondingAssociate/middleName|string|Stakeholder - Middle Name: Displays the contact's middle name.| x |
|saleStakeholder/person/correspondingAssociate/fullName|string|Stakeholder - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|saleStakeholder/person/correspondingAssociate/contactId|int|Stakeholder - Company ID: Database ID of the company the user belongs to|  |
|saleStakeholder/person/correspondingAssociate/personId|int|Stakeholder - Contact ID: Database ID of the contact row|  |
|saleStakeholder/person/correspondingAssociate/mrMrs|string|Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|saleStakeholder/person/correspondingAssociate/title|string|Stakeholder - Title: Displays whether the contact is addressed as Mr or Ms| x |
|saleStakeholder/person/correspondingAssociate/associateDbId|associate|Stakeholder - ID| x |
|saleStakeholder/person/correspondingAssociate/contactName|string|Stakeholder - Owning company: Name of the company the user belongs to| x |
|saleStakeholder/person/correspondingAssociate/contactDepartment|string|Stakeholder - Owning department: Name of the department at the company the user belongs to| x |
|saleStakeholder/person/correspondingAssociate/usergroup|userGroup|Stakeholder - Primary group: The user's primary user group| x |
|saleStakeholder/person/correspondingAssociate/usergroupId|int|Stakeholder - Group ID: The user's primary user group| x |
|saleStakeholder/person/correspondingAssociate/contactFullName|string|Stakeholder - Owner: Name and department of the company the user belongs to| x |
|saleStakeholder/person/correspondingAssociate/contactCategory|listAny|Stakeholder - Category: Category| x |
|saleStakeholder/person/correspondingAssociate/role|listAny|Stakeholder - Role: Role| x |
|saleStakeholder/person/correspondingAssociate/assocName|associate|Stakeholder - User ID: User ID| x |
|saleStakeholder/person/correspondingAssociate/assocTooltip|string|Stakeholder - Description: Description|  |
|saleStakeholder/person/correspondingAssociate/assocType|listAny|Stakeholder - Type: Type of user: associate, external user, system user, anonymous account| x |
|saleStakeholder/person/correspondingAssociate/ejUserId|int|Stakeholder - Service user ID: The database ID of a Service user|  |
|saleStakeholder/person/correspondingAssociate/simultaneousEjUser|bool|Stakeholder - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|saleStakeholder/person/correspondingAssociate/ejDisplayName|string|Stakeholder - Nick name: User's nick name in Service| x |
|saleStakeholder/person/correspondingAssociate/ejStatus|int|Stakeholder - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|saleStakeholder/person/correspondingAssociate/credentialType| *None* |Stakeholder - Auth. type: What type of credentials to use when this user logs in| x |
|saleStakeholder/person/correspondingAssociate/credentialDisplayValue| *None* |Stakeholder - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|saleStakeholder/person/correspondingAssociate/isActive|bool|Stakeholder - Active: Is this user active, and should be able to log in?| x |
|saleStakeholder/person/correspondingAssociate/isActiveText|bool|Stakeholder - Active status: Is this user active, and should be able to log in?| x |
|saleStakeholder/person/correspondingAssociate/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/correspondingAssociate/otherGroups|userGroup|Stakeholder - Other groups: Other groups|  |
|saleStakeholder/person/correspondingAssociate/userName|string|Stakeholder - User name: User name| x |
|saleStakeholder/person/correspondingAssociate/personEmail|string|Stakeholder - E-mail| x |
|saleStakeholder/person/correspondingAssociate/locationAddress|string|Stakeholder - Location: Location| x |
|saleStakeholder/person/correspondingAssociate/isLocation|bool|Stakeholder - Is a location: Is a location| x |
|saleStakeholder/person/isMailingRecipient|bool|Stakeholder - Is mailing recipient: isMailingRecipient| x |
|saleStakeholder/person/hasStoreConsent|bool|Stakeholder - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/withdrawnStoreConsent|bool|Stakeholder - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/hasEmarketingConsent|bool|Stakeholder - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/withdrawnEmarketingConsent|bool|Stakeholder - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/subscription|listAny|Stakeholder - Subscription: Subscription for marketing| x |
|saleStakeholder/person/legalBaseStore|listAny|Stakeholder - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|saleStakeholder/person/legalBaseEmarketing|listAny|Stakeholder - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|saleStakeholder/person/consentSourceStore|listAny|Stakeholder - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|saleStakeholder/person/consentSourceEmarketing|listAny|Stakeholder - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|saleStakeholder/contact/contactId|int|Stakeholder - Company ID: Database ID of company| x |
|saleStakeholder/contact/name|stringorPK|Stakeholder - Company name| x |
|saleStakeholder/contact/department|string|Stakeholder - Department| x |
|saleStakeholder/contact/nameDepartment| *None* |Stakeholder - Company: Displays the company an activity is linked to| x |
|saleStakeholder/contact/hasInfoText|bool|Stakeholder - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|saleStakeholder/contact/hasInterests|bool|Stakeholder - Has interests: Displays an Icon indicating if the contact has active interests| x |
|saleStakeholder/contact/associateId|associate|Stakeholder - Our contact: Displays our contact| x |
|saleStakeholder/contact/category|listAny|Stakeholder - Category| x |
|saleStakeholder/contact/business|listAny|Stakeholder - Business| x |
|saleStakeholder/contact/country|listAny|Stakeholder - Country: This criterion corresponds to the Country field on the Company card.| x |
|saleStakeholder/contact/countryId|int|Stakeholder - Country ID: Country ID| x |
|saleStakeholder/contact/number|string|Stakeholder - Number| x |
|saleStakeholder/contact/code|string|Stakeholder - Code| x |
|saleStakeholder/contact/orgnr|string|Stakeholder - VAT No.| x |
|saleStakeholder/contact/stop|bool|Stakeholder - Stop| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/contact/contactNoMail|bool|Stakeholder - No mailings (company)| x |
|saleStakeholder/contact/updatedBy|associate|Stakeholder - Updated by: The user who last updated the data| x |
|saleStakeholder/contact/updatedByFullName|associate|Stakeholder - Updated by - Full name: The user who last updated the data| x |
|saleStakeholder/contact/updatedDate|date|Stakeholder - Updated: The date/time the data was last updated in UTC.| x |
|saleStakeholder/contact/registeredBy|associate|Stakeholder - Registered by: The user who registered the data| x |
|saleStakeholder/contact/registeredByFullName|associate|Stakeholder - Registered by - Full name: The user who registered the data| x |
|saleStakeholder/contact/registeredDate|date|Stakeholder - Registered date: The date/time the data was registered in UTC.| x |
|saleStakeholder/contact/contactSource|listAny|Stakeholder - Source: Source (Company)| x |
|saleStakeholder/contact/contactDeleted|bool|Stakeholder - Deleted: Deleted| x |
|saleStakeholder/contact/phone/formattedNumber|string|Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/contact/activeErpLinks|bool|Stakeholder - ERP connected: Is there an active ERP Sync?| x |
|saleStakeholder/contact/deletedDate|datetime|Stakeholder - Deleted date: Deleted date|  |
|saleStakeholder/contact/mainContact| *None* |Stakeholder - Main contact: Main contact for this company| x |
|saleStakeholder/contact/contactPhone/formattedNumber|string|Stakeholder - Telephone - Phone: Displays phone number|  |
|saleStakeholder/contact/contactPhone/description|string|Stakeholder - Telephone - Description: Phone number description| x |
|saleStakeholder/contact/contactFax/formattedNumber|string|Stakeholder - Fax - Phone: Displays phone number|  |
|saleStakeholder/contact/contactFax/description|string|Stakeholder - Fax - Description: Phone number description| x |
|saleStakeholder/contact/searchPhone/formattedNumber|string|Stakeholder - Searchphone - Phone: Displays phone number|  |
|saleStakeholder/contact/searchPhone/description|string|Stakeholder - Searchphone - Description: Phone number description| x |
|saleStakeholder/contact/email/emailProtocol|string|Stakeholder - Protocol: E-mail protocol, such as SMTP| x |
|saleStakeholder/contact/email/emailAddress|string|Stakeholder - E-mail| x |
|saleStakeholder/contact/email/emailDescription|string|Stakeholder - Description| x |
|saleStakeholder/contact/email/emailId|int|Stakeholder - ID| x |
|saleStakeholder/contact/email/emailLastSent|datetime|Stakeholder - Last sent: The date and time an e-mail was last sent to this address| x |
|saleStakeholder/contact/email/emailBounceCount|int|Stakeholder - Bounce count: Bounce count for this e-mail address| x |
|saleStakeholder/contact/email/emailLastBounce|datetime|Stakeholder - Last bounce: Date and time for last bounce to this e-mail address| x |
|saleStakeholder/contact/email/emailHasBounced|bool|Stakeholder - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|saleStakeholder/contact/postAddress/addressId|int|Stakeholder - Postal address - Address ID: Database ID for the address record| x |
|saleStakeholder/contact/postAddress/line1|string|Stakeholder - Postal address - Address 1: First line of the address| x |
|saleStakeholder/contact/postAddress/line2|string|Stakeholder - Postal address - Address 2: Second line of the address| x |
|saleStakeholder/contact/postAddress/line3|string|Stakeholder - Postal address - Address 3: Third line of the address| x |
|saleStakeholder/contact/postAddress/county|string|Stakeholder - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|saleStakeholder/contact/postAddress/city|string|Stakeholder - Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|saleStakeholder/contact/postAddress/zip|string|Stakeholder - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|saleStakeholder/contact/postAddress/state|string|Stakeholder - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|saleStakeholder/contact/postAddress/wgs84latitude|decimal|Stakeholder - Postal address - Latitude: Latitude| x |
|saleStakeholder/contact/postAddress/wgs84longitude|decimal|Stakeholder - Postal address - Longitude: Longitude| x |
|saleStakeholder/contact/postAddress/formattedAddress| *None* |Stakeholder - Postal address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/postAddress/formattedMultiLineAddress| *None* |Stakeholder - Postal address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/addressId|int|Stakeholder - Street address - Address ID: Database ID for the address record| x |
|saleStakeholder/contact/streetAddress/line1|string|Stakeholder - Street address - Address 1: First line of the address| x |
|saleStakeholder/contact/streetAddress/line2|string|Stakeholder - Street address - Address 2: Second line of the address| x |
|saleStakeholder/contact/streetAddress/line3|string|Stakeholder - Street address - Address 3: Third line of the address| x |
|saleStakeholder/contact/streetAddress/county|string|Stakeholder - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|saleStakeholder/contact/streetAddress/city|string|Stakeholder - Street address - City: This criterion corresponds to the City field on the Company card.| x |
|saleStakeholder/contact/streetAddress/zip|string|Stakeholder - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|saleStakeholder/contact/streetAddress/state|string|Stakeholder - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|saleStakeholder/contact/streetAddress/wgs84latitude|decimal|Stakeholder - Street address - Latitude: Latitude| x |
|saleStakeholder/contact/streetAddress/wgs84longitude|decimal|Stakeholder - Street address - Longitude: Longitude| x |
|saleStakeholder/contact/streetAddress/formattedAddress| *None* |Stakeholder - Street address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/formattedMultiLineAddress| *None* |Stakeholder - Street address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/addressId|int|Stakeholder - Search address - Address ID: Database ID for the address record| x |
|saleStakeholder/contact/restrictionAddress/line1|string|Stakeholder - Search address - Address 1: First line of the address| x |
|saleStakeholder/contact/restrictionAddress/line2|string|Stakeholder - Search address - Address 2: Second line of the address| x |
|saleStakeholder/contact/restrictionAddress/line3|string|Stakeholder - Search address - Address 3: Third line of the address| x |
|saleStakeholder/contact/restrictionAddress/county|string|Stakeholder - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|saleStakeholder/contact/restrictionAddress/city|string|Stakeholder - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|saleStakeholder/contact/restrictionAddress/zip|string|Stakeholder - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|saleStakeholder/contact/restrictionAddress/state|string|Stakeholder - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|saleStakeholder/contact/restrictionAddress/wgs84latitude|decimal|Stakeholder - Search address - Latitude: Latitude| x |
|saleStakeholder/contact/restrictionAddress/wgs84longitude|decimal|Stakeholder - Search address - Longitude: Longitude| x |
|saleStakeholder/contact/restrictionAddress/formattedAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/formattedMultiLineAddress| *None* |Stakeholder - Search address - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/url/URLAddress|string|Stakeholder - URL| x |
|saleStakeholder/contact/url/URLDescription|string|Stakeholder - Description| x |
|saleStakeholder/contact/contactAssociate/firstName|string|Stakeholder - First name: Displays the contact's first name| x |
|saleStakeholder/contact/contactAssociate/lastName|string|Stakeholder - Last name: Displays the contact's last name| x |
|saleStakeholder/contact/contactAssociate/middleName|string|Stakeholder - Middle Name: Displays the contact's middle name.| x |
|saleStakeholder/contact/contactAssociate/fullName|string|Stakeholder - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|saleStakeholder/contact/contactAssociate/contactId|int|Stakeholder - Company ID: Database ID of the company the user belongs to|  |
|saleStakeholder/contact/contactAssociate/personId|int|Stakeholder - Contact ID: Database ID of the contact row|  |
|saleStakeholder/contact/contactAssociate/mrMrs|string|Stakeholder - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|saleStakeholder/contact/contactAssociate/title|string|Stakeholder - Title: Displays whether the contact is addressed as Mr or Ms| x |
|saleStakeholder/contact/contactAssociate/associateDbId|associate|Stakeholder - ID| x |
|saleStakeholder/contact/contactAssociate/contactName|string|Stakeholder - Owning company: Name of the company the user belongs to| x |
|saleStakeholder/contact/contactAssociate/contactDepartment|string|Stakeholder - Owning department: Name of the department at the company the user belongs to| x |
|saleStakeholder/contact/contactAssociate/usergroup|userGroup|Stakeholder - Primary group: The user's primary user group| x |
|saleStakeholder/contact/contactAssociate/usergroupId|int|Stakeholder - Group ID: The user's primary user group| x |
|saleStakeholder/contact/contactAssociate/contactFullName|string|Stakeholder - Owner: Name and department of the company the user belongs to| x |
|saleStakeholder/contact/contactAssociate/contactCategory|listAny|Stakeholder - Category: Category| x |
|saleStakeholder/contact/contactAssociate/role|listAny|Stakeholder - Role: Role| x |
|saleStakeholder/contact/contactAssociate/assocName|associate|Stakeholder - User ID: User ID| x |
|saleStakeholder/contact/contactAssociate/assocTooltip|string|Stakeholder - Description: Description|  |
|saleStakeholder/contact/contactAssociate/assocType|listAny|Stakeholder - Type: Type of user: associate, external user, system user, anonymous account| x |
|saleStakeholder/contact/contactAssociate/ejUserId|int|Stakeholder - Service user ID: The database ID of a Service user|  |
|saleStakeholder/contact/contactAssociate/simultaneousEjUser|bool|Stakeholder - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|saleStakeholder/contact/contactAssociate/ejDisplayName|string|Stakeholder - Nick name: User's nick name in Service| x |
|saleStakeholder/contact/contactAssociate/ejStatus|int|Stakeholder - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|saleStakeholder/contact/contactAssociate/credentialType| *None* |Stakeholder - Auth. type: What type of credentials to use when this user logs in| x |
|saleStakeholder/contact/contactAssociate/credentialDisplayValue| *None* |Stakeholder - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|saleStakeholder/contact/contactAssociate/isActive|bool|Stakeholder - Active: Is this user active, and should be able to log in?| x |
|saleStakeholder/contact/contactAssociate/isActiveText|bool|Stakeholder - Active status: Is this user active, and should be able to log in?| x |
|saleStakeholder/contact/contactAssociate/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/contact/contactAssociate/otherGroups|userGroup|Stakeholder - Other groups: Other groups|  |
|saleStakeholder/contact/contactAssociate/userName|string|Stakeholder - User name: User name| x |
|saleStakeholder/contact/contactAssociate/personEmail|string|Stakeholder - E-mail| x |
|saleStakeholder/contact/contactAssociate/locationAddress|string|Stakeholder - Location: Location| x |
|saleStakeholder/contact/contactAssociate/isLocation|bool|Stakeholder - Is a location: Is a location| x |
|saleStakeholder/contact/contactInterestIds|listInterest|Stakeholder - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|saleStakeholder/contact/contactUdef/SuperOffice:1|string|Stakeholder - companyshorttext: tooltipshorttext| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/contact/contactUdef/SuperOffice:2|string|Stakeholder - companylongtext: tooltiplongtext| x |
|saleStakeholder/contact/contactUdef/SuperOffice:3|int|Stakeholder - companynumber| x |
|saleStakeholder/contact/contactUdef/SuperOffice:4|date|Stakeholder - companydate| x |
|saleStakeholder/contact/contactUdef/SuperOffice:5|unlimitedDate|Stakeholder - companyunlimiteddate: tooltipunlimiteddate| x |
|saleStakeholder/contact/contactUdef/SuperOffice:6|bool|Stakeholder - companycheckbox| x |
|saleStakeholder/contact/contactUdef/SuperOffice:7|listAny|Stakeholder - companydropdownlistbox| x |
|saleStakeholder/contact/contactUdef/SuperOffice:8|decimal|Stakeholder - companydecimal| x |
|saleStakeholder/contact/contactUdef/SuperOffice:9|string|Stakeholder - page1saleonly| x |
|saleStakeholder/contact/contactUdef/SuperOffice:10|string|Stakeholder - page1marketingonly| x |
|saleStakeholder/contact/contactUdef/SuperOffice:11|string|Stakeholder - page1adminonly| x |
|saleStakeholder/contact/contactUdef/SuperOffice:12|listAny|Stakeholder - Udlist one: Static tooltip for udlist one| x |
|saleStakeholder/contact/contactUdef/SuperOffice:13|listAny|Stakeholder - Udlist two: Static tooltip for udlist two| x |
|saleStakeholder/contact/contactExtra/x\_contact\_integer|int|Stakeholder - Extra Integer: Custom integer field| x |
|saleStakeholder/contact/contactExtra/x\_contact\_hidden\_integer|int|Stakeholder - Extra hidden integer: Custom integer field - hidden| x |
|saleStakeholder/contact/contactExtra/x\_contact\_default\_integer|int|Stakeholder - Extra Default Integer: Custom integer field with default value 123.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_float|decimal|Stakeholder - Extra Float: Custom float field with 3 decimals| x |
|saleStakeholder/contact/contactExtra/x\_contact\_longtext|string|Stakeholder - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|saleStakeholder/contact/contactExtra/x\_contact\_dropdown|listAny|Stakeholder - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_date|date|Stakeholder - Extra date: Custom date field. User current as default.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_datetime|datetime|Stakeholder - Extra DateTime: Custom Date Time field. No default value. External| x |
|saleStakeholder/contact/contactExtra/x\_contact\_time| *None* |Stakeholder - Extra time: Custom time field.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_boolean|bool|Stakeholder - Extra boolean: Custom boolean field.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_timespan|timeSpan|Stakeholder - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|saleStakeholder/contact/contactExtra/x\_contact\_shorttext|string|Stakeholder - Extra short text: Custom short text field. Keep HTML tags.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_short\_dropdown|listAny|Stakeholder - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Stakeholder - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|saleStakeholder/contact/contactExtra/x\_contact\_request\_relation|stringorPK|Stakeholder - Extra Request relation: Request relation on company| x |
|saleStakeholder/contact/contactExtra/x\_contact\_contact|stringorPK|Stakeholder - Extra contact relation: Contact relation on company| x |
|saleStakeholder/contact/contactExtra/y\_organization/x\_name|string|Stakeholder - Organization - Name| x |
|saleStakeholder/contact/NumberOfActivities|int|Stakeholder - Number of activities|  |
|saleStakeholder/contact/NumberOfActivitiesInPeriod|int|Stakeholder - Number of activities in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedActivities|int|Stakeholder - Number of non-completed activities|  |
|saleStakeholder/contact/NumberOfNotCompletedActivitiesInPeriod|int|Stakeholder - Number of non-completed activities in last 90 days|  |
|saleStakeholder/contact/LastActivity|date|Stakeholder - Date of last activity|  |
|saleStakeholder/contact/LastCompletedActivity|date|Stakeholder - Date of last completed activity|  |
|saleStakeholder/contact/LastDoByActivity|date|Stakeholder - Date of last non-completed activity|  |
|saleStakeholder/contact/NumberOfSales|int|Stakeholder - Number of sales|  |
|saleStakeholder/contact/NumberOfSalesInPeriod|int|Stakeholder - Number of sales in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedSales|int|Stakeholder - Number of non-completed sales|  |
|saleStakeholder/contact/NumberOfNotCompletedSalesInPeriod|int|Stakeholder - Number of non-completed sales in last 90 days|  |
|saleStakeholder/contact/LastSale|date|Stakeholder - Date of last sale|  |
|saleStakeholder/contact/LastCompletedSale|date|Stakeholder - Date of last completed sale|  |
|saleStakeholder/contact/LastDoBySale|date|Stakeholder - Date of last non-completed sale|  |
|saleStakeholder/contact/NumberOfTickets|int|Stakeholder - Number of requests|  |
|saleStakeholder/contact/NumberOfTicketsInPeriod|int|Stakeholder - Number of requests in last 90 days|  |
|saleStakeholder/contact/NumberOfNotCompletedTickets|int|Stakeholder - Number of non-completed requests|  |
|saleStakeholder/contact/NumberOfNotCompletedTicketsInPeriod|int|Stakeholder - Number of non-completed requests in last 90 days|  |
|saleStakeholder/contact/LastTicket|date|Stakeholder - Date of last request|  |
|saleStakeholder/contact/LastCompletedTicket|date|Stakeholder - Date of last completed request|  |
|saleStakeholder/contact/LastDoByTicket|date|Stakeholder - Date of last non-completed request|  |
|saleStakeholder/contact/SaintStatus1|saintStatus|Stakeholder - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|saleStakeholder/contact/SaintStatus2|saintStatus|Stakeholder - C-company: Kundens navn starter med bokstaven C|  |
|saleStakeholder/contact/saintSaleStatus|listAny|Stakeholder - With status|  |
|saleStakeholder/contact/saintAmountClass|listAny|Stakeholder - Amount class|  |
|saleStakeholder/contact/saintActivityType|listAny|Stakeholder - SAINT type|  |
|saleStakeholder/contact/saintDirection|listAny|Stakeholder - Direction|  |
|saleStakeholder/contact/saintIntention|listAny|Stakeholder - Intention|  |
|saleStakeholder/contact/saintTicketStatus|listAny|Stakeholder - Status|  |
|saleStakeholder/contact/saintTicketCategory|listAny|Stakeholder - Category|  |
|quote/quoteId|int|Quote ID: SuperOffice database ID of quote record| x |
|quote/poNumber|string|P.O. Number: Customer's purchase order number| x |
|quote/orderComment|string|Comment: Customer's comment| x |
|quote/connectionId|int|DB-ID: Database ID| x |
|quote/registeredDate|date|Registered at: Displays the date when the quote was registered.| x |
|quote/version/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|quote/version/description|string|Description: Description of the quote version| x |
|quote/version/number|string|Number: Reference number for the quote version| x |
|quote/version/sent|date|Sent: The date the quote (version) was sent to the customer| x |
|quote/version/expiration|date|Expiry date: The last date that the quote is valid| x |
|quote/version/state|listAny|State: The current state the quote is in| x |
|quote/version/status|listAny|Quote status: Status field showing the status of each line.| x |
|quote/version/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|quote/version/paymentTerms|listExternal|Payment terms: Payment terms|  |
|quote/version/paymentType|listExternal|Payment type: Payment type|  |
|quote/version/deliveryTerms|listExternal|Delivery terms: Delivery terms|  |
|quote/version/deliveryType|listExternal|Delivery type: Delivery type|  |
|quote/version/approvedBy|associate|Approved by: Associate who approved a quote that broke one or more of the workflow rules that trigger an approval process| x |
|quote/version/approvalRegisteredBy|associate|Approval reg by: Associate who entered the approval of a quote that broke one or more of the workflow rules that trigger an approval process.  Not necessarily the person who approved the quote.| x |
|quote/version/approvedText|string|Approval comment: Comment added to the approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|quote/version/approvedDate|date|Approved date: Date of approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|quote/version/extraField1|string|Extra field 1: One of the extra fields on the product; meaning is installation dependent| x |
|quote/version/extraField2|string|Extra field 2: One of the extra fields on the product; meaning is installation dependent| x |
|quote/version/extraField3|string|Extra field 3: One of the extra fields on the product; meaning is installation dependent| x |
|quote/version/extraField4|string|Extra field 4: One of the extra fields on the product; meaning is installation dependent| x |
|quote/version/extraField5|string|Extra field 5: One of the extra fields on the product; meaning is installation dependent| x |
|quote/version/alternative/quoteAlternativeId|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|quote/version/alternative/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|quote/version/alternative/name|string|Name: Name of the quote alternative| x |
|quote/version/alternative/description|string|Description: Description of the quote alternative| x |
|quote/version/alternative/status|listAny|Quote status: Status field showing the status of each line.| x |
|quote/version/alternative/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|quote/version/alternative/erpDiscountPercent|decimal|ERP Discount %: Discount percentage suggested by ERP system| x |
|quote/version/alternative/erpDiscountAmount|decimal|ERP Discount: Discount amount suggested by ERP system| x |
|quote/version/alternative/discountPercent|decimal|Discount %: Enter discount in percent for entire alternative| x |
|quote/version/alternative/discountAmount|decimal|Discount: Enter total discount for entire alternative| x |
|quote/version/alternative/vatInfo|string|VAT Info: Information about value-added and other taxes| x |
|quote/version/alternative/vat|decimal|VAT: Value-added and other taxes, total amount| x |
|quote/version/alternative/earningPercent|decimal|Earnings %: Total Earnings as a percentage of the total price, of all lines in the quote alternative, including all discounts| x |
|quote/version/alternative/earningAmount|decimal|Earnings: Total Earnings for all lines in the quote alternative, including all discounts| x |
|quote/version/alternative/totalPrice|decimal|Total: Total price of all items in the quote alternative, including all discounts| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|quote/version/alternative/extraField1|string|Extra 1: Extra field 1 on the quote alternative| x |
|quote/version/alternative/extraField2|string|Extra 2: Extra field 2 on the quote alternative| x |
|quote/version/alternative/extraField3|string|Extra 3: Extra field 3on the quote alternative| x |
|quote/version/alternative/extraField4|string|Extra 4: Extra field 4 on the quote alternative| x |
|quote/version/alternative/extraField5|string|Extra 5: Extra field 5 on the quote alternative| x |
|quote/version/alternative/alternativeOrdering|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|quote/version/alternative/subTotal|decimal|Total before discount: Total of all lines, before applying the Alternative discount| x |
|quote/version/alternative/totalPriceIncVAT|decimal|Total incl. VAT: Total of all lines, including VAT| x |
|quote/version/alternative/vatAmount|decimal|VAT: VAT (amount) for the alternative| x |
|quote/version/alternative/quoteline/quoteLineId|int|Quote line ID: Database identity of the quote line| x |
|quote/version/alternative/quoteline/quoteAlternativeId|int|Alternative ID: The database identity of the quote alternative| x |
|quote/version/alternative/quoteline/erpProductKey|string|Product key: The foreign key of the product the quote line is based on.| x |
|quote/version/alternative/quoteline/rank|int|Rank: Shows the rank of a product| x |
|quote/version/alternative/quoteline/quantity|decimal|Quantity: The quantity that is offered| x |
|quote/version/alternative/quoteline/name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|quote/version/alternative/quoteline/description|string|Description: Description of the product that is offered| x |
|quote/version/alternative/quoteline/code|string|Code: The product or article code. This code is created to help you quickly find products you offer regularly.| x |
|quote/version/alternative/quoteline/quantityUnit|string|Unit: The unit of the product that is offered.| x |
|quote/version/alternative/quoteline/priceUnit|string|Price unit: What is the price unit defined in| x |
|quote/version/alternative/quoteline/url|string|Web address: The web address of the product info.| x |
|quote/version/alternative/quoteline/subscriptionUnit|string|Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month| x |
|quote/version/alternative/quoteline/subscriptionQuantity|decimal|Subscription quantity: Number of subscription units offered| x |
|quote/version/alternative/quoteline/UnitListPriceSubscriptionQuantity| *None* |Subscription list price: Unit price * subscription quantity|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionUnit| *None* |P/S Unit: Price unit/subscription unit|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionQuantityUnit| *None* |Expanded unit: Price unit @ subscription quantity + unit|  |
|quote/version/alternative/quoteline/vatInfo|string|VAT info: | x |
|quote/version/alternative/quoteline/vat|decimal|VAT: May be filled out by the ERP system| x |
|quote/version/alternative/quoteline/unitCost|decimal|Cost: Cost per item.| x |
|quote/version/alternative/quoteline/unitMinimumPrice|decimal|Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.| x |
|quote/version/alternative/quoteline/unitListPrice|decimal|List price: List price of a unit| x |
|quote/version/alternative/quoteline/totalPrice|decimal|Total: List price * Quantity - Discount Amount| x |
|quote/version/alternative/quoteline/totalCost|decimal|Total cost|  |
|quote/version/alternative/quoteline/quoteLineThumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|quote/version/alternative/quoteline/quoteLineThumbnailLarge| *None* |Thumbnail: A miniature version of the product picture|  |
|quote/version/alternative/quoteline/discountAmount|decimal|Discount: Discount amount given by salesperson| x |
|quote/version/alternative/quoteline/discountPercent|decimal|Discount (%: Discount percent given by salesperson| x |
|quote/version/alternative/quoteline/earningAmount|decimal|Earnings: Amount of Earnings (Total - Cost) on the line, after discount| x |
|quote/version/alternative/quoteline/earningPercent|decimal|Earnings (%: Percentage Earnings on the line (Total - Cost / Total), after discount| x |
|quote/version/alternative/quoteline/updatedBy|associate|Updated by: The user who last updated the data| x |
|quote/version/alternative/quoteline/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|quote/version/alternative/quoteline/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|quote/version/alternative/quoteline/registeredBy|associate|Registered by: The user who registered the data| x |
|quote/version/alternative/quoteline/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|quote/version/alternative/quoteline/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|quote/version/alternative/quoteline/productCategoryKey|listExternal|Product category: The category the product is defined in|  |
|quote/version/alternative/quoteline/productFamilyKey|listExternal|Product family: The family the product is defined in|  |
|quote/version/alternative/quoteline/productTypeKey|listExternal|Product type: The type of product|  |
|quote/version/alternative/quoteline/status|listAny|Quote status: Status field showing the status of each line.| x |
|quote/version/alternative/quoteline/subTotal|decimal|Sum: Sum of Quantity * Unit list price| x |
|quote/version/alternative/quoteline/vatAmount|decimal|VAT (amount: The calculated VAT amount| x |
|quote/version/alternative/quoteline/totalPriceIncVAT|decimal|Total incl. VAT: Total including VAT| x |
|quote/version/alternative/quoteline/totalPriceWithAlternativeDiscount|decimal|Total incl. alt. disc: Total, including any discount percentage set on the alternative| x |

## Sample

```http!
GET /api/v1/archive/SaleShadowDynamicSelectionSingleCriteriaGroup?$select=person/personUdef/SuperOffice:7,person/personUdef/SuperOffice:11,contact/business,contact/postAddress/line3,contact/streetAddress/state
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

