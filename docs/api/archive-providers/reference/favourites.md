---
uid: Favourites
title: Favourites
description: Archive provider for the list of favourites
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "Favourites"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
|updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|registeredBy| *None* |Registered by: The user who registered the data|  |
|registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|currencyId| *None* |Currency ID: The currency list item ID|  |
|currency| *None* |Currency: The currency of the sale|  |
|credited| *None* |Credited: The user to be credited with the sale|  |
|lossReason| *None* |Reason (lost: The reason for losing the sale|  |
|source| *None* |Source: The source (lead) of the sale|  |
|competitor| *None* |Competitor: The competitor who won the sale|  |
|heading| *None* |Sale: Displays a descriptive text for the item|  |
|amount| *None* |Amount: The gross sales total|  |
|amountWeighted| *None* |Weighted amount: Virtual field calculated from amount * probability percent.|  |
|earning| *None* |Profit: Gross profit (gross sales total - cost) for the sale|  |
|earningPercent| *None* |Profit as % : The profit as a percentage of the gross sales total|  |
|probPercent| *None* |Probability as %: Probability as %|  |
|originalStage| *None* |Stage: Displays the stage of the sale|  |
|stage| *None* |Stage: Displays the stage of the sale|  |
|saleStatus| *None* |Status: The status of the sale - open, lost or sold|  |
|saleType| *None* |Sale type: Sale type, from list|  |
|nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|reopenDate| *None* |Reopen date: Displays the reopen date for the sale|  |
|stalledComment| *None* |Reason (stalled: The reason the sale has been stalled|  |
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
|person/personUpdatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|person/personRegisteredBy| *None* |Registered by: The user who registered the data|  |
|person/personRegisteredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|person/portraitThumbnail| *None* |Person image: Person image|  |
|person/personActiveErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|person/ticketPriority| *None* |Service priority: Default service priority for this contact|  |
|person/supportLanguage| *None* |Preferred language: Preferred language used for reply templates and more|  |
|person/supportAssociate| *None* |Our service contact: Default service contact for this contact|  |
|person/personAssociateId| *None* |Our contact: Displays our contact|  |
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
|person/isMailingRecipient| *None* |isMailingRecipient: isMailingRecipient|  |
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
|contact/number| *None* |Number|  |
|contact/code| *None* |Code|  |
|contact/orgnr| *None* |VAT No.|  |
|contact/stop| *None* |Stop|  |
|contact/contactNoMail| *None* |No mailings (company|  |
|contact/updatedBy| *None* |Updated by: The user who last updated the data|  |
|contact/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|contact/registeredBy| *None* |Registered by: The user who registered the data|  |
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
|contact/SaintStatus1| *None* |Neglected customer|  |
|contact/SaintStatus2| *None* |C-company|  |
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
|project/associateId| *None* |ID: Displays login ID of the associate who owns the project|  |
|project/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|project/icon| *None* |Category: Displays the icon for an activity type|  |
|project/text| *None* |Text: Displays a descriptive text for the item|  |
|project/description| *None* |Description : Description|  |
|project/updatedBy| *None* |Updated by: The user who last updated the data|  |
|project/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|project/registeredBy| *None* |Registered by: The user who registered the data|  |
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
|project/SaintStatus3| *None* |Not completed activites with intention sale|  |
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
|saleStakeholder/person/personUpdatedDate| *None* |Stakeholder - Updated: The date/time the data was last updated in UTC.|  |
|saleStakeholder/person/personRegisteredBy| *None* |Stakeholder - Registered by: The user who registered the data|  |
|saleStakeholder/person/personRegisteredDate| *None* |Stakeholder - Registered date: The date/time the data was registered in UTC.|  |
|saleStakeholder/person/portraitThumbnail| *None* |Stakeholder - Person image: Person image|  |
|saleStakeholder/person/personActiveErpLinks| *None* |Stakeholder - ERP connected: Is there an active ERP Sync?|  |
|saleStakeholder/person/ticketPriority| *None* |Stakeholder - Service priority: Default service priority for this contact|  |
|saleStakeholder/person/supportLanguage| *None* |Stakeholder - Preferred language: Preferred language used for reply templates and more|  |
|saleStakeholder/person/supportAssociate| *None* |Stakeholder - Our service contact: Default service contact for this contact|  |
|saleStakeholder/person/personAssociateId| *None* |Stakeholder - Our contact: Displays our contact|  |
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
|saleStakeholder/person/isMailingRecipient| *None* |Stakeholder - isMailingRecipient: isMailingRecipient|  |
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
|saleStakeholder/contact/number| *None* |Stakeholder - Number|  |
|saleStakeholder/contact/code| *None* |Stakeholder - Code|  |
|saleStakeholder/contact/orgnr| *None* |Stakeholder - VAT No.|  |
|saleStakeholder/contact/stop| *None* |Stakeholder - Stop|  |
|saleStakeholder/contact/contactNoMail| *None* |Stakeholder - No mailings (company)|  |
|saleStakeholder/contact/updatedBy| *None* |Stakeholder - Updated by: The user who last updated the data|  |
|saleStakeholder/contact/updatedDate| *None* |Stakeholder - Updated: The date/time the data was last updated in UTC.|  |
|saleStakeholder/contact/registeredBy| *None* |Stakeholder - Registered by: The user who registered the data|  |
|saleStakeholder/contact/registeredDate| *None* |Stakeholder - Registered date: The date/time the data was registered in UTC.|  |
|saleStakeholder/contact/contactSource| *None* |Stakeholder - Source: Source (Company)|  |
|saleStakeholder/contact/contactDeleted| *None* |Stakeholder - Deleted: Deleted|  |
|saleStakeholder/contact/phone/formattedNumber| *None* |Stakeholder - Phone: Displays phone number|  |
|saleStakeholder/contact/activeErpLinks| *None* |Stakeholder - ERP connected: Is there an active ERP Sync?|  |
|saleStakeholder/contact/deletedDate| *None* |Stakeholder - Deleted date: Deleted date|  |
|saleStakeholder/contact/mainContact| *None* |Stakeholder - Main contact: Main contact for this company|  |
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
|saleStakeholder/contact/SaintStatus1| *None* |Stakeholder - Neglected customer|  |
|saleStakeholder/contact/SaintStatus2| *None* |Stakeholder - C-company|  |
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
|quote/version/alternative/quoteline/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|quote/version/alternative/quoteline/registeredBy| *None* |Registered by: The user who registered the data|  |
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
|contactSupportPerson/personNoMail| *None* |User support contact - No Mailings: Displays the contact's No Mailings checkbox|  |
|contactSupportPerson/rank| *None* |User support contact - Rank: Displays a contact's current rank|  |
|contactSupportPerson/birthdate| *None* |User support contact - Birthdate: Displays the contact's date of birth|  |
|contactSupportPerson/associateType| *None* |User support contact - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|contactSupportPerson/useAsMailingAddress| *None* |User support contact - Use as postal address: Use as postal address|  |
|contactSupportPerson/personSource| *None* |User support contact - Source: Source (Contact)|  |
|contactSupportPerson/retired| *None* |User support contact - Former employee: Indicates whether the contact has retired/left the company|  |
|contactSupportPerson/birthYear| *None* |User support contact - Birth year: Displays contact's birth year|  |
|contactSupportPerson/birthMonth| *None* |User support contact - Birth month: Displays contact's birth month|  |
|contactSupportPerson/birthDay| *None* |User support contact - Birth day: Displays contact's birth day (day of month)|  |
|contactSupportPerson/kanaFirstName| *None* |User support contact - First name, kana: Contact's first name, in kana alphabet|  |
|contactSupportPerson/kanaLastName| *None* |User support contact - Last name, kana: Contact's last name, in kana alphabet|  |
|contactSupportPerson/personUpdatedBy| *None* |User support contact - Updated by: The user who last updated the data|  |
|contactSupportPerson/personUpdatedDate| *None* |User support contact - Updated: The date/time the data was last updated in UTC.|  |
|contactSupportPerson/personRegisteredBy| *None* |User support contact - Registered by: The user who registered the data|  |
|contactSupportPerson/personRegisteredDate| *None* |User support contact - Registered date: The date/time the data was registered in UTC.|  |
|contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|contactSupportPerson/personActiveErpLinks| *None* |User support contact - ERP connected: Is there an active ERP Sync?|  |
|contactSupportPerson/ticketPriority| *None* |User support contact - Service priority: Default service priority for this contact|  |
|contactSupportPerson/supportLanguage| *None* |User support contact - Preferred language: Preferred language used for reply templates and more|  |
|contactSupportPerson/supportAssociate| *None* |User support contact - Our service contact: Default service contact for this contact|  |
|contactSupportPerson/personAssociateId| *None* |User support contact - Our contact: Displays our contact|  |
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
|contactSupportPerson/isMailingRecipient| *None* |User support contact - isMailingRecipient: isMailingRecipient|  |
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
|personUpdatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personRegisteredBy| *None* |Registered by: The user who registered the data|  |
|personRegisteredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|portraitThumbnail| *None* |Person image: Person image|  |
|personActiveErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|ticketPriority| *None* |Service priority: Default service priority for this contact|  |
|supportLanguage| *None* |Preferred language: Preferred language used for reply templates and more|  |
|supportAssociate| *None* |Our service contact: Default service contact for this contact|  |
|personAssociateId| *None* |Our contact: Displays our contact|  |
|personCategory| *None* |Category|  |
|personBusiness| *None* |Business|  |
|personDeletedDate| *None* |Deleted date: Deleted date|  |
|hasCompany| *None* |Has company: The contact is associated with a company|  |
|isProjectMember| *None* |Is project member: This person is a project member|  |
|isStakeholder| *None* |Is stakeholder: This person is a sale stakeholder|  |
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
|personContact/number| *None* |Number|  |
|personContact/code| *None* |Code|  |
|personContact/orgnr| *None* |VAT No.|  |
|personContact/stop| *None* |Stop|  |
|personContact/contactNoMail| *None* |No mailings (company|  |
|personContact/updatedBy| *None* |Updated by: The user who last updated the data|  |
|personContact/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personContact/registeredBy| *None* |Registered by: The user who registered the data|  |
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
|personContact/contactSupportPerson/personUpdatedDate| *None* |User support contact - Updated: The date/time the data was last updated in UTC.|  |
|personContact/contactSupportPerson/personRegisteredBy| *None* |User support contact - Registered by: The user who registered the data|  |
|personContact/contactSupportPerson/personRegisteredDate| *None* |User support contact - Registered date: The date/time the data was registered in UTC.|  |
|personContact/contactSupportPerson/portraitThumbnail| *None* |User support contact - Person image: Person image|  |
|personContact/contactSupportPerson/personActiveErpLinks| *None* |User support contact - ERP connected: Is there an active ERP Sync?|  |
|personContact/contactSupportPerson/ticketPriority| *None* |User support contact - Service priority: Default service priority for this contact|  |
|personContact/contactSupportPerson/supportLanguage| *None* |User support contact - Preferred language: Preferred language used for reply templates and more|  |
|personContact/contactSupportPerson/supportAssociate| *None* |User support contact - Our service contact: Default service contact for this contact|  |
|personContact/contactSupportPerson/personAssociateId| *None* |User support contact - Our contact: Displays our contact|  |
|personContact/contactSupportPerson/personCategory| *None* |User support contact - Category|  |
|personContact/contactSupportPerson/personBusiness| *None* |User support contact - Business|  |
|personContact/contactSupportPerson/personDeletedDate| *None* |User support contact - Deleted date: Deleted date|  |
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
|personContact/contactSupportPerson/isMailingRecipient| *None* |User support contact - isMailingRecipient: isMailingRecipient|  |
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
|personContact/LastDoByTicket| *None* |Date of last non-completed request|  |
|personContact/SaintStatus1| *None* |Neglected customer|  |
|personContact/SaintStatus2| *None* |C-company|  |
|personContact/saintSaleStatus| *None* |With status|  |
|personContact/saintAmountClass| *None* |Amount class|  |
|personContact/saintActivityType| *None* |SAINT type|  |
|personContact/saintDirection| *None* |Direction|  |
|personContact/saintIntention| *None* |Intention|  |
|personContact/saintTicketStatus| *None* |Status|  |
|personContact/saintTicketCategory| *None* |Category|  |
|personContact/selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|personContact/selectionIdRequest| *None* |Selection ID: Database ID of selection which members are to be fetched from|  |
|isMailingRecipient| *None* |isMailingRecipient: isMailingRecipient|  |
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
|projectMembers/completed| *None* |Completed: Displays a check mark indicating if the project has been completed.|  |
|projectMembers/projectId| *None* |DB ID: Displays the database ID for a project row|  |
|projectMembers/name| *None* |Project name: Displays the Project's name|  |
|projectMembers/number| *None* |Number: Displays the project's number|  |
|projectMembers/type| *None* |Project type: Displays the project's type|  |
|projectMembers/status| *None* |Status: Displays the project's status|  |
|projectMembers/associateId| *None* |ID: Displays login ID of the associate who owns the project|  |
|projectMembers/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|projectMembers/icon| *None* |Category: Displays the icon for an activity type|  |
|projectMembers/text| *None* |Text: Displays a descriptive text for the item|  |
|projectMembers/description| *None* |Description : Description|  |
|projectMembers/updatedBy| *None* |Updated by: The user who last updated the data|  |
|projectMembers/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|projectMembers/registeredBy| *None* |Registered by: The user who registered the data|  |
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
|projectMembers/SaintStatus3| *None* |Not completed activites with intention sale|  |
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
|personAppointment/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|personAppointment/registeredBy| *None* |Registered by: The user who registered the data|  |
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
|SaintStatus3| *None* |Not completed activites with intention sale|  |
|project/textId| *None* |Text ID|  |
|project/infoText| *None* |Information: Displays the text entered in the description field|  |
|selectionId| *None* |Selection ID: The database ID of the selection|  |
|kind| *None* |Selection is : The kind of selection (static, dynamic or combined)|  |
|targetTableNumber| *None* |Selection of: Displays what the selection consists of|  |
|combinationType| *None* |Combination type: Displays the combination type for a selection|  |
|done| *None* |Completed: Shows whether the selection has been completed|  |
|lastLoaded| *None* |Viewed: When was the result list for the selection last shown|  |
|lastLoadedBy| *None* |Viewed by: Who was the last person to show the result list for the selection|  |
|lastMembershipChange| *None* |Members changed: When was the result list for the selection last changed, for instance due to a change in the criteria|  |
|lastMembershipChangeBy| *None* |Members changed by: Who was the last person to change the result list for the selection, for instance by changing the criteria|  |
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
|mailingDescription| *None* |Name: Displays the name of the mailing|  |
|mailingSent| *None* |Sent: Displays the sent status of the mailing|  |
|mailingEndDate| *None* |Date: Displays the date of the mailing|  |
|mailingType| *None* |Type: Display the type of the mailing|  |
|mailingSentTo| *None* |Sent to: Displays to whom the mailing was sent|  |
|mailingOwner| *None* |Owner: Displays the owner of the mailing|  |
|mailingDeleted| *None* |Deleted: Deleted|  |
|recipientStatus| *None* |Reception status: Status of mailing reception|  |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
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
|sale/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|sale/registeredBy| *None* |Registered by: The user who registered the data|  |
|sale/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|sale/currencyId| *None* |Currency ID: The currency list item ID|  |
|sale/currency| *None* |Currency: The currency of the sale|  |
|sale/credited| *None* |Credited: The user to be credited with the sale|  |
|sale/lossReason| *None* |Reason (lost: The reason for losing the sale|  |
|sale/source| *None* |Source: The source (lead) of the sale|  |
|sale/competitor| *None* |Competitor: The competitor who won the sale|  |
|sale/heading| *None* |Sale: Displays a descriptive text for the item|  |
|sale/amount| *None* |Amount: The gross sales total|  |
|sale/amountWeighted| *None* |Weighted amount: Virtual field calculated from amount * probability percent.|  |
|sale/earning| *None* |Profit: Gross profit (gross sales total - cost) for the sale|  |
|sale/earningPercent| *None* |Profit as % : The profit as a percentage of the gross sales total|  |
|sale/probPercent| *None* |Probability as %: Probability as %|  |
|sale/originalStage| *None* |Stage: Displays the stage of the sale|  |
|sale/stage| *None* |Stage: Displays the stage of the sale|  |
|sale/saleStatus| *None* |Status: The status of the sale - open, lost or sold|  |
|sale/saleType| *None* |Sale type: Sale type, from list|  |
|sale/nextDueDate| *None* |Next activity: Date for next activity for a sale, updated live from the sale's activities|  |
|sale/reopenDate| *None* |Reopen date: Displays the reopen date for the sale|  |
|sale/stalledComment| *None* |Reason (stalled: The reason the sale has been stalled|  |
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
|ownedBy| *None* |Owner: The owner of the request|  |
|content| *None* |Content: Search for content in messages related to requests|  |
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

## Sample

```http!
GET /api/v1/archive/Favourites?$select=sale/description,person/withdrawnEmarketingConsent,contact/restrictionAddress/wgs84latitude,contact/contactAssociate/contactId,saleUdef/SuperOffice:5
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

