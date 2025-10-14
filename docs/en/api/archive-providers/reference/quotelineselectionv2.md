---
uid: QuoteLineSelectionV2
title: QuoteLineSelectionV2
description: This is the archive Provider for the Selection QuoteLine archive.
keywords: QuoteLineSelectionV2 archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "QuoteLineSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.QuoteLineSelectionProviderV2">SuperOffice.CRM.ArchiveLists.Archive.QuoteLineSelectionProviderV2</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the Selection QuoteLine archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"quoteLine"|[[Quoteline static]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|quoteLineId|int|Quote line ID: Database identity of the quote line| x |
|quoteAlternativeId|int|Alternative ID: The database identity of the quote alternative| x |
|erpProductKey|string|Product key: The foreign key of the product the quote line is based on.| x |
|rank|int|Rank: Shows the rank of a product| x |
|quantity|decimal|Quantity: The quantity that is offered| x |
|name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|description|string|Description: Description of the product that is offered| x |
|code|string|Code: The product or article code. This code is created to help you quickly find products you offer regularly.| x |
|quantityUnit|string|Unit: The unit of the product that is offered.| x |
|priceUnit|string|Price unit: What is the price unit defined in| x |
|url|string|Web address: The web address of the product info.| x |
|subscriptionUnit|string|Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month| x |
|subscriptionQuantity|decimal|Subscription quantity: Number of subscription units offered| x |
|UnitListPriceSubscriptionQuantity| *None* |Subscription list price: Unit price * subscription quantity|  |
|PriceUnitSubscriptionUnit| *None* |P/S Unit: Price unit/subscription unit|  |
|PriceUnitSubscriptionQuantityUnit| *None* |Expanded unit: Price unit @ subscription quantity + unit|  |
|vatInfo|string|VAT info: | x |
|vat|decimal|VAT: May be filled out by the ERP system| x |
|unitCost|decimal|Cost: Cost per item.| x |
|unitMinimumPrice|decimal|Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.| x |
|unitListPrice|decimal|List price: List price of a unit| x |
|totalPrice|decimal|Total: List price * Quantity - Discount Amount| x |
|totalCost|decimal|Total cost|  |
|quoteLineThumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|quoteLineThumbnailLarge| *None* |Thumbnail: A miniature version of the product picture|  |
|discountAmount|decimal|Discount: Discount amount given by salesperson| x |
|discountPercent|decimal|Discount (%: Discount percent given by salesperson| x |
|earningAmount|decimal|Earnings: Amount of Earnings (Total - Cost) on the line, after discount| x |
|earningPercent|decimal|Earnings (%: Percentage Earnings on the line (Total - Cost / Total), after discount| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|productCategoryKey|listExternal|Product category: The category the product is defined in|  |
|productFamilyKey|listExternal|Product family: The family the product is defined in|  |
|productTypeKey|listExternal|Product type: The type of product|  |
|status|listAny|Quote status: Status field showing the status of each line.| x |
|subTotal|decimal|Sum: Sum of Quantity * Unit list price| x |
|vatAmount|decimal|VAT (amount: The calculated VAT amount| x |
|totalPriceIncVAT|decimal|Total incl. VAT: Total including VAT| x |
|totalPriceWithAlternativeDiscount|decimal|Total incl. alt. disc: Total, including any discount percentage set on the alternative| x |
|selectionId|int|Selection ID: The database ID of the selection|  |
|selectionMemberId| *None* |Selection member ID: The database ID of the selection member record|  |
|rowKind| *None* |Icon indicating whether the row comes from a static or a dynamic selection|  |
|targetTableNumber| *None* |TargetTableNumber: TargetTableNumber| x |
|targetRecordId| *None* |TargetRecordId: TargetRecordId| x |
|contactId| *None* |Company ID: Database ID of company| x |
|personId| *None* |Contact ID: Database ID of the contact row| x |
|alternative/quoteAlternativeId|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|alternative/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|alternative/name|string|Name: Name of the quote alternative| x |
|alternative/description|string|Description: Description of the quote alternative| x |
|alternative/status|listAny|Quote status: Status field showing the status of each line.| x |
|alternative/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|alternative/erpDiscountPercent|decimal|ERP Discount %: Discount percentage suggested by ERP system| x |
|alternative/erpDiscountAmount|decimal|ERP Discount: Discount amount suggested by ERP system| x |
|alternative/discountPercent|decimal|Discount %: Enter discount in percent for entire alternative| x |
|alternative/discountAmount|decimal|Discount: Enter total discount for entire alternative| x |
|alternative/vatInfo|string|VAT Info: Information about value-added and other taxes| x |
|alternative/vat|decimal|VAT: Value-added and other taxes, total amount| x |
|alternative/earningPercent|decimal|Earnings %: Total Earnings as a percentage of the total price, of all lines in the quote alternative, including all discounts| x |
|alternative/earningAmount|decimal|Earnings: Total Earnings for all lines in the quote alternative, including all discounts| x |
|alternative/totalPrice|decimal|Total: Total price of all items in the quote alternative, including all discounts| x |
|alternative/extraField1|string|Extra 1: Extra field 1 on the quote alternative| x |
|alternative/extraField2|string|Extra 2: Extra field 2 on the quote alternative| x |
|alternative/extraField3|string|Extra 3: Extra field 3on the quote alternative| x |
|alternative/extraField4|string|Extra 4: Extra field 4 on the quote alternative| x |
|alternative/extraField5|string|Extra 5: Extra field 5 on the quote alternative| x |
|alternative/alternativeOrdering|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|alternative/subTotal|decimal|Total before discount: Total of all lines, before applying the Alternative discount| x |
|alternative/totalPriceIncVAT|decimal|Total incl. VAT: Total of all lines, including VAT| x |
|alternative/vatAmount|decimal|VAT: VAT (amount) for the alternative| x |
|alternative/version/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|alternative/version/description|string|Description: Description of the quote version| x |
|alternative/version/number|string|Number: Reference number for the quote version| x |
|alternative/version/sent|date|Sent: The date the quote (version) was sent to the customer| x |
|alternative/version/expiration|date|Expiry date: The last date that the quote is valid| x |
|alternative/version/state|listAny|State: The current state the quote is in| x |
|alternative/version/status|listAny|Quote status: Status field showing the status of each line.| x |
|alternative/version/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|alternative/version/paymentTerms|listExternal|Payment terms: Payment terms|  |
|alternative/version/paymentType|listExternal|Payment type: Payment type|  |
|alternative/version/deliveryTerms|listExternal|Delivery terms: Delivery terms|  |
|alternative/version/deliveryType|listExternal|Delivery type: Delivery type|  |
|alternative/version/approvedBy|associate|Approved by: Associate who approved a quote that broke one or more of the workflow rules that trigger an approval process| x |
|alternative/version/approvalRegisteredBy|associate|Approval reg by: Associate who entered the approval of a quote that broke one or more of the workflow rules that trigger an approval process.  Not necessarily the person who approved the quote.| x |
|alternative/version/approvedText|string|Approval comment: Comment added to the approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|alternative/version/approvedDate|date|Approved date: Date of approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|alternative/version/extraField1|string|Extra field 1: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField2|string|Extra field 2: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField3|string|Extra field 3: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField4|string|Extra field 4: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField5|string|Extra field 5: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/quote/quoteId|int|Quote ID: SuperOffice database ID of quote record| x |
|alternative/version/quote/poNumber|string|P.O. Number: Customer's purchase order number| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/orderComment|string|Comment: Customer's comment| x |
|alternative/version/quote/connectionId|int|DB-ID: Database ID| x |
|alternative/version/quote/registeredDate|date|Registered at: Displays the date when the quote was registered.| x |
|alternative/version/quote/sale/completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|alternative/version/quote/sale/icon|listAny|Category: Displays the icon for an activity type| x |
|alternative/version/quote/sale/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|alternative/version/quote/sale/time| *None* |Time: Time|  |
|alternative/version/quote/sale/type|listAny|Type: Displays the type of an activity| x |
|alternative/version/quote/sale/recordType|string|Record type : Shows the record type| x |
|alternative/version/quote/sale/text|positiveString|Text: Displays a descriptive text for the item| x |
|alternative/version/quote/sale/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|alternative/version/quote/sale/contactId|listAny|Company ID: Database ID of company| x |
|alternative/version/quote/sale/personId|listAny|Contact ID: Database ID of the contact row| x |
|alternative/version/quote/sale/projectId|listAny|Project ID: Database ID of project record| x |
|alternative/version/quote/sale/saleId|int|Sale ID: The database ID of the sale record| x |
|alternative/version/quote/sale/userGroup|userGroup|User group : The user group that owns the record| x |
|alternative/version/quote/sale/who| *None* |Who: Contact and/or company|  |
|alternative/version/quote/sale/updatedBy|associate|Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|alternative/version/quote/sale/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/registeredBy|associate|Registered by: The user who registered the data| x |
|alternative/version/quote/sale/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|alternative/version/quote/sale/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/currencyId|int|Currency ID: The currency list item ID| x |
|alternative/version/quote/sale/currency|listAny|Currency: The currency of the sale| x |
|alternative/version/quote/sale/credited|listAny|Credited: The user to be credited with the sale| x |
|alternative/version/quote/sale/lossReason|listAny|Reason (lost: The reason for losing the sale| x |
|alternative/version/quote/sale/source|listAny|Source: The source (lead) of the sale| x |
|alternative/version/quote/sale/competitor|listAny|Competitor: The competitor who won the sale| x |
|alternative/version/quote/sale/heading|stringorPK|Sale: The name of the sale| x |
|alternative/version/quote/sale/amount|decimal|Amount: The gross sales total| x |
|alternative/version/quote/sale/amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.| x |
|alternative/version/quote/sale/earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale| x |
|alternative/version/quote/sale/earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total| x |
|alternative/version/quote/sale/probPercent|int|Probability as %: Probability as %| x |
|alternative/version/quote/sale/originalStage|listAny|Stage: Displays the stage of the sale| x |
|alternative/version/quote/sale/stage|listAny|Stage: Displays the stage of the sale| x |
|alternative/version/quote/sale/stageName| *None* |Stage name: Displays the stage of the sale| x |
|alternative/version/quote/sale/saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|alternative/version/quote/sale/stageRank| *None* |Stage rank: Rank of the sale stage in the stage list| x |
|alternative/version/quote/sale/saleType|listAny|Sale type: Sale type, from list| x |
|alternative/version/quote/sale/saleTypeId| *None* |Sale type ID: Sale type, from list| x |
|alternative/version/quote/sale/stageId| *None* |Sale stage ID: Displays the stage of the sale| x |
|alternative/version/quote/sale/nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|alternative/version/quote/sale/reopenDate|date|Reopen date: Displays the reopen date for the sale| x |
|alternative/version/quote/sale/stalledComment|listAny|Reason (stalled: The reason the sale has been stalled| x |
|alternative/version/quote/sale/saleTypeCategory|listAny|Sale type category: Sale type category| x |
|alternative/version/quote/sale/soldReason|listAny|Reason (sold: Reason (sold)| x |
|alternative/version/quote/sale/saleNumber|string|Number: Number| x |
|alternative/version/quote/sale/hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders enabled| x |
|alternative/version/quote/sale/hasQuote|bool|Has quote?: Does the sale have a quote attached?| x |
|alternative/version/quote/sale/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|alternative/version/quote/sale/description|string|Description: The long description field on Sale|  |
|alternative/version/quote/sale/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/createdByWorkflow|listAny|Created by flow: Created by flow| x |
|alternative/version/quote/sale/amountInBaseCurrency| *None* |Amount (BaseCurrency): The gross sales total| x |
|alternative/version/quote/sale/amountWeightedInBaseCurrency| *None* |Weighted amount (BaseCurrency): Virtual field calculated from amount * probability percent.| x |
|alternative/version/quote/sale/daysInStage| *None* |Days in stage: Total number of days in this stage| x |
|alternative/version/quote/sale/visibleFor|listAny|Visible for|  |
|alternative/version/quote/sale/sale/textId|int|Text ID| x |
|alternative/version/quote/sale/sale/description|positiveString|Text: Displays the text entered in the description field| x |
|alternative/version/quote/sale/person/personId|int|DB ID: Displays the database ID of a contact| x |
|alternative/version/quote/sale/person/firstName|string|First name: Displays the contact's first name| x |
|alternative/version/quote/sale/person/lastName|string|Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/person/middleName|string|Middle name: Displays the contact's middle name.| x |
|alternative/version/quote/sale/person/fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
|alternative/version/quote/sale/person/contactId|int|Company ID: Database ID of company| x |
|alternative/version/quote/sale/person/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|alternative/version/quote/sale/person/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|alternative/version/quote/sale/person/personHasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|alternative/version/quote/sale/person/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/person/position|listAny|Position| x |
|alternative/version/quote/sale/person/personNumber|string|Number: Displays the contact's number| x |
|alternative/version/quote/sale/person/title|string|Title: Displays the contact's job title| x |
|alternative/version/quote/sale/person/personCountry|listAny|Country: Country| x |
|alternative/version/quote/sale/person/personCountryId|int|Country ID: Country ID| x |
|alternative/version/quote/sale/person/personNoMail|bool|No Mailings: Displays the contact's No Mailings checkbox| x |
|alternative/version/quote/sale/person/rank|int|Rank: Displays a contact's current rank| x |
|alternative/version/quote/sale/person/birthdate| *None* |Birthdate: Displays the contact's date of birth|  |
|alternative/version/quote/sale/person/associateType| *None* |User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|alternative/version/quote/sale/person/useAsMailingAddress|bool|Use as postal address: Use as postal address| x |
|alternative/version/quote/sale/person/personSource|listAny|Source: Source (Contact)| x |
|alternative/version/quote/sale/person/retired|bool|Former employee: Indicates whether the contact has retired/left the company| x |
|alternative/version/quote/sale/person/birthYear|int|Birth year: Displays contact's birth year| x |
|alternative/version/quote/sale/person/birthMonth|int|Birth month: Displays contact's birth month| x |
|alternative/version/quote/sale/person/birthDay|int|Birth day: Displays contact's birth day (day of month)| x |
|alternative/version/quote/sale/person/kanaFirstName|string|First name, kana: Contact's first name, in kana alphabet| x |
|alternative/version/quote/sale/person/kanaLastName|string|Last name, kana: Contact's last name, in kana alphabet| x |
|alternative/version/quote/sale/person/personUpdatedBy|associate|Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/person/personUpdatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|alternative/version/quote/sale/person/personUpdatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/person/personRegisteredBy|associate|Registered by: The user who registered the data| x |
|alternative/version/quote/sale/person/personRegisteredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|alternative/version/quote/sale/person/personRegisteredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/person/portraitThumbnail| *None* |Person image: Person image|  |
|alternative/version/quote/sale/person/personActiveErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/person/ticketPriority|listAny|Service priority: Default service priority for this contact| x |
|alternative/version/quote/sale/person/supportLanguage|listAny|Preferred language: Preferred language used for reply templates and more| x |
|alternative/version/quote/sale/person/supportAssociate|associate|Our service contact: Default service contact for this contact| x |
|alternative/version/quote/sale/person/supportAssociateFullName|associate|Our service contact - Full name: Default service contact for this contact| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/person/personAssociateId|associate|Our contact: Displays our contact| x |
|alternative/version/quote/sale/person/personAssociateFullName|associate|Our contact - Full name: Displays our contact| x |
|alternative/version/quote/sale/person/personCategory|listAny|Category| x |
|alternative/version/quote/sale/person/personCategoryGroup|listAny|Category group| x |
|alternative/version/quote/sale/person/personBusiness|listAny|Business| x |
|alternative/version/quote/sale/person/leadstatus|listAny|Lead status| x |
|alternative/version/quote/sale/person/personDeletedDate|datetime|Deleted date: Deleted date|  |
|alternative/version/quote/sale/person/hasCompany|bool|Has company: The contact is associated with a company| x |
|alternative/version/quote/sale/person/isProjectMember|bool|Is project member: This person is a project member| x |
|alternative/version/quote/sale/person/isStakeholder|bool|Is stakeholder: This person is a sale stakeholder| x |
|alternative/version/quote/sale/person/updatedByWorkflow|listAny|Updated by flow: Updated by flow| x |
|alternative/version/quote/sale/person/whenUpdatedByWorkflow|datetime|When updated by flow: When updated by flow| x |
|alternative/version/quote/sale/person/createdByForm|listAny|Created by form: Created by form| x |
|alternative/version/quote/sale/person/phone/formattedNumber|string|Phone : Displays phone number|  |
|alternative/version/quote/sale/person/personDirectPhone/formattedNumber|string|Direct - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personDirectPhone/description|string|Direct - Description: Phone number description| x |
|alternative/version/quote/sale/person/personMobilePhone/formattedNumber|string|Mobile - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personMobilePhone/description|string|Mobile - Description: Phone number description| x |
|alternative/version/quote/sale/person/personPrivate/formattedNumber|string|Private - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personPrivate/description|string|Private - Description: Phone number description| x |
|alternative/version/quote/sale/person/personPager/formattedNumber|string|Other - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personPager/description|string|Other - Description: Phone number description| x |
|alternative/version/quote/sale/person/personDirectFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personDirectFax/description|string|Fax - Description: Phone number description| x |
|alternative/version/quote/sale/person/searchPhone/formattedNumber|string|Phone : Displays phone number|  |
|alternative/version/quote/sale/person/searchPhone/description|string|Description: Phone number description| x |
|alternative/version/quote/sale/person/personInfo/textId|int|Text ID| x |
|alternative/version/quote/sale/person/personInfo/infoText|positiveString|Information: Displays the text entered in the description field| x |
|alternative/version/quote/sale/person/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|alternative/version/quote/sale/person/email/emailAddress|string|E-mail| x |
|alternative/version/quote/sale/person/email/emailDescription|string|Description| x |
|alternative/version/quote/sale/person/email/emailId|int|ID| x |
|alternative/version/quote/sale/person/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|alternative/version/quote/sale/person/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|alternative/version/quote/sale/person/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|alternative/version/quote/sale/person/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|alternative/version/quote/sale/person/personUrl/URLAddress|string|URL| x |
|alternative/version/quote/sale/person/personUrl/URLDescription|string|Description| x |
|alternative/version/quote/sale/person/personAddress/addressId|int|Contact address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/person/personAddress/line1|string|Contact address - Address 1: First line of the address| x |
|alternative/version/quote/sale/person/personAddress/line2|string|Contact address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/person/personAddress/line3|string|Contact address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/person/personAddress/county|string|Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/personAddress/city|string|Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/person/personAddress/zip|string|Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/person/personAddress/state|string|Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/personAddress/wgs84latitude|decimal|Contact address - Latitude: Latitude| x |
|alternative/version/quote/sale/person/personAddress/wgs84longitude|decimal|Contact address - Longitude: Longitude| x |
|alternative/version/quote/sale/person/personAddress/formattedAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/personAddress/formattedMultiLineAddress| *None* |Contact address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/person/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|alternative/version/quote/sale/person/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/person/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/person/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/person/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/person/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|alternative/version/quote/sale/person/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|alternative/version/quote/sale/person/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/personInterestIds|listInterest|Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|alternative/version/quote/sale/person/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:3|int|contactnumber| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:4|date|contactdate| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:6|bool|contactcheckbox| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:8|decimal|contactdecimal| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:9|string|page1saleonly| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:10|string|page1marketingonly| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:11|string|page1adminonly| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_integer|int|Extra Integer: Custom person integer| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_float|decimal|Extra float: Custom float field| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/id|int|Rental - id: Displays the row's primary key (y\_rental)| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_start|date|Rental - Start rental| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_end|date|Rental - End| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|alternative/version/quote/sale/person/personExtra/y\_car/id|int|Car - id: Displays the row's primary key (y\_car)| x |
|alternative/version/quote/sale/person/personAssociate/firstName|string|First name: Displays the contact's first name| x |
|alternative/version/quote/sale/person/personAssociate/lastName|string|Last name: Displays the contact's last name| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/person/personAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|alternative/version/quote/sale/person/personAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/person/personAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/person/personAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/person/personAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/person/personAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/person/personAssociate/associateDbId|associate|ID| x |
|alternative/version/quote/sale/person/personAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/person/personAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/person/personAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|alternative/version/quote/sale/person/personAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|alternative/version/quote/sale/person/personAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/person/personAssociate/contactCategory|listAny|Category: Category| x |
|alternative/version/quote/sale/person/personAssociate/role|listAny|Role : Role| x |
|alternative/version/quote/sale/person/personAssociate/assocName|associate|User ID : User ID| x |
|alternative/version/quote/sale/person/personAssociate/assocTooltip|string|Description : Description|  |
|alternative/version/quote/sale/person/personAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/person/personAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/person/personAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/person/personAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/person/personAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/person/personAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/person/personAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/person/personAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/person/personAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/person/personAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|alternative/version/quote/sale/person/personAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|alternative/version/quote/sale/person/personAssociate/userName|string|User name: User name| x |
|alternative/version/quote/sale/person/personAssociate/personEmail|string|E-mail| x |
|alternative/version/quote/sale/person/personAssociate/locationAddress|string|Location: Location| x |
|alternative/version/quote/sale/person/personAssociate/isLocation|bool|Is a location: Is a location| x |
|alternative/version/quote/sale/person/correspondingAssociate/firstName|string|First name: Displays the contact's first name| x |
|alternative/version/quote/sale/person/correspondingAssociate/lastName|string|Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/person/correspondingAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|alternative/version/quote/sale/person/correspondingAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/person/correspondingAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/person/correspondingAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/person/correspondingAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/person/correspondingAssociate/associateDbId|associate|ID| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/person/correspondingAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|alternative/version/quote/sale/person/correspondingAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactCategory|listAny|Category: Category| x |
|alternative/version/quote/sale/person/correspondingAssociate/role|listAny|Role : Role| x |
|alternative/version/quote/sale/person/correspondingAssociate/assocName|associate|User ID : User ID| x |
|alternative/version/quote/sale/person/correspondingAssociate/assocTooltip|string|Description : Description|  |
|alternative/version/quote/sale/person/correspondingAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/person/correspondingAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/person/correspondingAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/person/correspondingAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/person/correspondingAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/person/correspondingAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/person/correspondingAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/person/correspondingAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/person/correspondingAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/person/correspondingAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|alternative/version/quote/sale/person/correspondingAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|alternative/version/quote/sale/person/correspondingAssociate/userName|string|User name: User name| x |
|alternative/version/quote/sale/person/correspondingAssociate/personEmail|string|E-mail| x |
|alternative/version/quote/sale/person/correspondingAssociate/locationAddress|string|Location: Location| x |
|alternative/version/quote/sale/person/correspondingAssociate/isLocation|bool|Is a location: Is a location| x |
|alternative/version/quote/sale/person/isMailingRecipient|bool|Is mailing recipient: isMailingRecipient| x |
|alternative/version/quote/sale/person/hasStoreConsent|bool|Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|alternative/version/quote/sale/person/withdrawnStoreConsent|bool|Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|alternative/version/quote/sale/person/hasEmarketingConsent|bool|Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|alternative/version/quote/sale/person/withdrawnEmarketingConsent|bool|Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|alternative/version/quote/sale/person/subscription|listAny|Subscription: Subscription for marketing| x |
|alternative/version/quote/sale/person/legalBaseStore|listAny|Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|alternative/version/quote/sale/person/legalBaseEmarketing|listAny|Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|alternative/version/quote/sale/person/consentSourceStore|listAny|Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|alternative/version/quote/sale/person/consentSourceEmarketing|listAny|Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|alternative/version/quote/sale/contact/contactId|int|Company ID: Database ID of company| x |
|alternative/version/quote/sale/contact/name|stringorPK|Company name| x |
|alternative/version/quote/sale/contact/department|string|Department| x |
|alternative/version/quote/sale/contact/nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|alternative/version/quote/sale/contact/hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|alternative/version/quote/sale/contact/hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|alternative/version/quote/sale/contact/associateId|associate|Our contact: Displays our contact| x |
|alternative/version/quote/sale/contact/category|listAny|Category| x |
|alternative/version/quote/sale/contact/categoryGroup|listAny|Category group| x |
|alternative/version/quote/sale/contact/business|listAny|Business| x |
|alternative/version/quote/sale/contact/country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|alternative/version/quote/sale/contact/countryId|int|Country ID: Country ID| x |
|alternative/version/quote/sale/contact/number|string|Number| x |
|alternative/version/quote/sale/contact/code|string|Code| x |
|alternative/version/quote/sale/contact/orgnr|string|VAT No.| x |
|alternative/version/quote/sale/contact/stop|bool|Stop| x |
|alternative/version/quote/sale/contact/contactNoMail|bool|No mailings (company| x |
|alternative/version/quote/sale/contact/updatedBy|associate|Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/contact/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|alternative/version/quote/sale/contact/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/contact/registeredBy|associate|Registered by: The user who registered the data| x |
|alternative/version/quote/sale/contact/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|alternative/version/quote/sale/contact/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/contact/contactSource|listAny|Source: Source (Company)| x |
|alternative/version/quote/sale/contact/contactDeleted|bool|Deleted: Deleted| x |
|alternative/version/quote/sale/contact/phone/formattedNumber|string|Phone : Displays phone number|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/contact/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/contact/deletedDate|datetime|Deleted date: Deleted date|  |
|alternative/version/quote/sale/contact/mainContact| *None* |Main contact: Main contact for this company| x |
|alternative/version/quote/sale/contact/contactPhone/formattedNumber|string|Telephone - Phone: Displays phone number|  |
|alternative/version/quote/sale/contact/contactPhone/description|string|Telephone - Description: Phone number description| x |
|alternative/version/quote/sale/contact/contactFax/formattedNumber|string|Fax - Phone: Displays phone number|  |
|alternative/version/quote/sale/contact/contactFax/description|string|Fax - Description: Phone number description| x |
|alternative/version/quote/sale/contact/searchPhone/formattedNumber|string|Searchphone - Phone: Displays phone number|  |
|alternative/version/quote/sale/contact/searchPhone/description|string|Searchphone - Description: Phone number description| x |
|alternative/version/quote/sale/contact/email/emailProtocol|string|Protocol: E-mail protocol, such as SMTP| x |
|alternative/version/quote/sale/contact/email/emailAddress|string|E-mail| x |
|alternative/version/quote/sale/contact/email/emailDescription|string|Description| x |
|alternative/version/quote/sale/contact/email/emailId|int|ID| x |
|alternative/version/quote/sale/contact/email/emailLastSent|datetime|Last sent: The date and time an e-mail was last sent to this address| x |
|alternative/version/quote/sale/contact/email/emailBounceCount|int|Bounce count: Bounce count for this e-mail address| x |
|alternative/version/quote/sale/contact/email/emailLastBounce|datetime|Last bounce: Date and time for last bounce to this e-mail address| x |
|alternative/version/quote/sale/contact/email/emailHasBounced|bool|Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|alternative/version/quote/sale/contact/postAddress/addressId|int|Postal address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/contact/postAddress/line1|string|Postal address - Address 1: First line of the address| x |
|alternative/version/quote/sale/contact/postAddress/line2|string|Postal address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/contact/postAddress/line3|string|Postal address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/contact/postAddress/county|string|Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/postAddress/city|string|Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/contact/postAddress/zip|string|Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/contact/postAddress/state|string|Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/postAddress/wgs84latitude|decimal|Postal address - Latitude: Latitude| x |
|alternative/version/quote/sale/contact/postAddress/wgs84longitude|decimal|Postal address - Longitude: Longitude| x |
|alternative/version/quote/sale/contact/postAddress/formattedAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/postAddress/formattedMultiLineAddress| *None* |Postal address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/streetAddress/addressId|int|Street address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/contact/streetAddress/line1|string|Street address - Address 1: First line of the address| x |
|alternative/version/quote/sale/contact/streetAddress/line2|string|Street address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/contact/streetAddress/line3|string|Street address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/contact/streetAddress/county|string|Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/streetAddress/city|string|Street address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/contact/streetAddress/zip|string|Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/contact/streetAddress/state|string|Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/streetAddress/wgs84latitude|decimal|Street address - Latitude: Latitude| x |
|alternative/version/quote/sale/contact/streetAddress/wgs84longitude|decimal|Street address - Longitude: Longitude| x |
|alternative/version/quote/sale/contact/streetAddress/formattedAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/streetAddress/formattedMultiLineAddress| *None* |Street address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/restrictionAddress/addressId|int|Search address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/contact/restrictionAddress/line1|string|Search address - Address 1: First line of the address| x |
|alternative/version/quote/sale/contact/restrictionAddress/line2|string|Search address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/contact/restrictionAddress/line3|string|Search address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/contact/restrictionAddress/county|string|Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/restrictionAddress/city|string|Search address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/contact/restrictionAddress/zip|string|Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/contact/restrictionAddress/state|string|Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/restrictionAddress/wgs84latitude|decimal|Search address - Latitude: Latitude| x |
|alternative/version/quote/sale/contact/restrictionAddress/wgs84longitude|decimal|Search address - Longitude: Longitude| x |
|alternative/version/quote/sale/contact/restrictionAddress/formattedAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/restrictionAddress/formattedMultiLineAddress| *None* |Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/url/URLAddress|string|URL| x |
|alternative/version/quote/sale/contact/url/URLDescription|string|Description| x |
|alternative/version/quote/sale/contact/contactAssociate/firstName|string|First name: Displays the contact's first name| x |
|alternative/version/quote/sale/contact/contactAssociate/lastName|string|Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/contact/contactAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|alternative/version/quote/sale/contact/contactAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/contact/contactAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/contact/contactAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/contact/contactAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/contact/contactAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/contact/contactAssociate/associateDbId|associate|ID| x |
|alternative/version/quote/sale/contact/contactAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/contact/contactAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/contact/contactAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|alternative/version/quote/sale/contact/contactAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|alternative/version/quote/sale/contact/contactAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/contact/contactAssociate/contactCategory|listAny|Category: Category| x |
|alternative/version/quote/sale/contact/contactAssociate/role|listAny|Role : Role| x |
|alternative/version/quote/sale/contact/contactAssociate/assocName|associate|User ID : User ID| x |
|alternative/version/quote/sale/contact/contactAssociate/assocTooltip|string|Description : Description|  |
|alternative/version/quote/sale/contact/contactAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/contact/contactAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/contact/contactAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/contact/contactAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/contact/contactAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/contact/contactAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/contact/contactAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/contact/contactAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/contact/contactAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/contact/contactAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|alternative/version/quote/sale/contact/contactAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|alternative/version/quote/sale/contact/contactAssociate/userName|string|User name: User name| x |
|alternative/version/quote/sale/contact/contactAssociate/personEmail|string|E-mail| x |
|alternative/version/quote/sale/contact/contactAssociate/locationAddress|string|Location: Location| x |
|alternative/version/quote/sale/contact/contactAssociate/isLocation|bool|Is a location: Is a location| x |
|alternative/version/quote/sale/contact/contactInterestIds|listInterest|Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:3|int|companynumber| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:4|date|companydate| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:9|string|page1saleonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:11|string|page1adminonly| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
|alternative/version/quote/sale/contact/contactExtra/y\_organization/x\_name|string|Organization - Name| x |
|alternative/version/quote/sale/contact/NumberOfActivities|int|Number of activities|  |
|alternative/version/quote/sale/contact/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|alternative/version/quote/sale/contact/LastActivity|date|Date of last activity|  |
|alternative/version/quote/sale/contact/LastCompletedActivity|date|Date of last completed activity|  |
|alternative/version/quote/sale/contact/LastDoByActivity|date|Date of last non-completed activity|  |
|alternative/version/quote/sale/contact/NumberOfSales|int|Number of sales|  |
|alternative/version/quote/sale/contact/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|alternative/version/quote/sale/contact/LastSale|date|Date of last sale|  |
|alternative/version/quote/sale/contact/LastCompletedSale|date|Date of last completed sale|  |
|alternative/version/quote/sale/contact/LastDoBySale|date|Date of last non-completed sale|  |
|alternative/version/quote/sale/contact/NumberOfTickets|int|Number of requests|  |
|alternative/version/quote/sale/contact/NumberOfTicketsInPeriod|int|Number of requests in last 90 days|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedTickets|int|Number of non-completed requests|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedTicketsInPeriod|int|Number of non-completed requests in last 90 days|  |
|alternative/version/quote/sale/contact/LastTicket|date|Date of last request|  |
|alternative/version/quote/sale/contact/LastCompletedTicket|date|Date of last completed request|  |
|alternative/version/quote/sale/contact/LastDoByTicket|date|Date of last non-completed request|  |
|alternative/version/quote/sale/contact/SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|alternative/version/quote/sale/contact/SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|alternative/version/quote/sale/contact/saintSaleStatus|listAny|With status|  |
|alternative/version/quote/sale/contact/saintAmountClass|listAny|Amount class|  |
|alternative/version/quote/sale/contact/saintActivityType|listAny|SAINT type|  |
|alternative/version/quote/sale/contact/saintDirection|listAny|Direction|  |
|alternative/version/quote/sale/contact/saintIntention|listAny|Intention|  |
|alternative/version/quote/sale/contact/saintTicketStatus|listAny|Status|  |
|alternative/version/quote/sale/contact/saintTicketCategory|listAny|Category|  |
|alternative/version/quote/sale/associate/firstName|string|First name: Displays the contact's first name| x |
|alternative/version/quote/sale/associate/lastName|string|Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|alternative/version/quote/sale/associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/associate/personId|int|Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/associate/associateDbId|associate|ID| x |
|alternative/version/quote/sale/associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|alternative/version/quote/sale/associate/usergroupId|int|Group ID: The user's primary user group| x |
|alternative/version/quote/sale/associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/associate/contactCategory|listAny|Category: Category| x |
|alternative/version/quote/sale/associate/role|listAny|Role : Role| x |
|alternative/version/quote/sale/associate/assocName|associate|User ID : User ID| x |
|alternative/version/quote/sale/associate/assocTooltip|string|Description : Description|  |
|alternative/version/quote/sale/associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/associate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/associate/portraitThumbnail| *None* |Person image: Person image|  |
|alternative/version/quote/sale/associate/otherGroups|userGroup|Other groups: Other groups|  |
|alternative/version/quote/sale/associate/userName|string|User name: User name| x |
|alternative/version/quote/sale/associate/personEmail|string|E-mail| x |
|alternative/version/quote/sale/associate/locationAddress|string|Location: Location| x |
|alternative/version/quote/sale/associate/isLocation|bool|Is a location: Is a location| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:1|string|saleshorttext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:2|string|salelongtext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:3|int|salenumber| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:4|date|saledate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:6|bool|salecheckbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:8|decimal|saledecimal| x |
|alternative/version/quote/sale/project/completed|bool|Project - Completed: Displays a check mark indicating if the project has been completed.| x |
|alternative/version/quote/sale/project/projectId|int|Project - DB ID: Displays the database ID for a project row| x |
|alternative/version/quote/sale/project/name|stringorPK|Project - Project name: Displays the Project's name| x |
|alternative/version/quote/sale/project/number|string|Project - Number: Displays the project's number| x |
|alternative/version/quote/sale/project/type|listAny|Project - Project type: Displays the project's type| x |
|alternative/version/quote/sale/project/status|listAny|Project - Status: Displays the project's status| x |
|alternative/version/quote/sale/project/statusRank| *None* |Project - Status rank: Rank of the project status in the status list| x |
|alternative/version/quote/sale/project/associateId|associate|Project - ID: Displays login ID of the associate who owns the project| x |
|alternative/version/quote/sale/project/hasInfoText|bool|Project - Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|alternative/version/quote/sale/project/icon| *None* |Project - Category: Displays the icon for an activity type| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/project/text|string|Project - Text: Displays a descriptive text for the item| x |
|alternative/version/quote/sale/project/description|string|Project - Description: Description| x |
|alternative/version/quote/sale/project/updatedBy|associate|Project - Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/project/updatedByFullName|associate|Project - Updated by - Full name: The user who last updated the data| x |
|alternative/version/quote/sale/project/updatedDate|date|Project - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/project/registeredBy|associate|Project - Registered by: The user who registered the data| x |
|alternative/version/quote/sale/project/registeredByFullName|associate|Project - Registered by - Full name: The user who registered the data| x |
|alternative/version/quote/sale/project/registeredDate|date|Project - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/project/hasGuide|bool|Project - Guided: Does this sale have a Sales Guide| x |
|alternative/version/quote/sale/project/nextMilestone|date|Project - Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|alternative/version/quote/sale/project/endDate|date|Project - End date: End date of project| x |
|alternative/version/quote/sale/project/imageThumbnail| *None* |Project - Thumbnail: Scaled-down image of project image|  |
|alternative/version/quote/sale/project/activeErpLinks|bool|Project - ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/project/projectPublish/isPublished|bool|Project - Published: Displays an icon indicating if the project or sale has been published| x |
|alternative/version/quote/sale/project/projectPublish/publishedFrom|date|Project - From date: Start date for publishing. The record will not be visible prior to this date| x |
|alternative/version/quote/sale/project/projectPublish/publishedTo|date|Project - To date: End date for publishing. The record will not be visible after this date| x |
|alternative/version/quote/sale/project/projectPublish/publishedBy| *None* |Project - Published by: Published by|  |
|alternative/version/quote/sale/project/projectEvent/isExternalEvent|bool|Project - Event: Is this an external event| x |
|alternative/version/quote/sale/project/projectEvent/eventDate|date|Project - Event date: Event date| x |
|alternative/version/quote/sale/project/projectEvent/hasSignOn|bool|Project - Sign On: Does this event have the Sign On function enabled| x |
|alternative/version/quote/sale/project/projectEvent/hasSignOff|bool|Project - Sign Off: Does this event have the Sign Off function enabled| x |
|alternative/version/quote/sale/project/projectUrl/URLAddress|string|Project - URL| x |
|alternative/version/quote/sale/project/projectUrl/URLDescription|string|Project - Description| x |
|alternative/version/quote/sale/project/projectAssociate/firstName|string|Project - First name: Displays the contact's first name| x |
|alternative/version/quote/sale/project/projectAssociate/lastName|string|Project - Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/project/projectAssociate/middleName|string|Project - Middle Name: Displays the contact's middle name.| x |
|alternative/version/quote/sale/project/projectAssociate/fullName|string|Project - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/project/projectAssociate/contactId|int|Project - Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/project/projectAssociate/personId|int|Project - Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/project/projectAssociate/mrMrs|string|Project - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/project/projectAssociate/title|string|Project - Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/project/projectAssociate/associateDbId|associate|Project - ID| x |
|alternative/version/quote/sale/project/projectAssociate/contactName|string|Project - Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/project/projectAssociate/contactDepartment|string|Project - Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/project/projectAssociate/usergroup|userGroup|Project - Primary group: The user's primary user group| x |
|alternative/version/quote/sale/project/projectAssociate/usergroupId|int|Project - Group ID: The user's primary user group| x |
|alternative/version/quote/sale/project/projectAssociate/contactFullName|string|Project - Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/project/projectAssociate/contactCategory|listAny|Project - Category: Category| x |
|alternative/version/quote/sale/project/projectAssociate/role|listAny|Project - Role: Role| x |
|alternative/version/quote/sale/project/projectAssociate/assocName|associate|Project - User ID: User ID| x |
|alternative/version/quote/sale/project/projectAssociate/assocTooltip|string|Project - Description: Description|  |
|alternative/version/quote/sale/project/projectAssociate/assocType|listAny|Project - Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/project/projectAssociate/ejUserId|int|Project - Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/project/projectAssociate/simultaneousEjUser|bool|Project - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/project/projectAssociate/ejDisplayName|string|Project - Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/project/projectAssociate/ejStatus|int|Project - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/project/projectAssociate/credentialType| *None* |Project - Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/project/projectAssociate/credentialDisplayValue| *None* |Project - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/project/projectAssociate/isActive|bool|Project - Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/project/projectAssociate/isActiveText|bool|Project - Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/project/projectAssociate/portraitThumbnail| *None* |Project - Person image: Person image|  |
|alternative/version/quote/sale/project/projectAssociate/otherGroups|userGroup|Project - Other groups: Other groups|  |
|alternative/version/quote/sale/project/projectAssociate/userName|string|Project - User name: User name| x |
|alternative/version/quote/sale/project/projectAssociate/personEmail|string|Project - E-mail| x |
|alternative/version/quote/sale/project/projectAssociate/locationAddress|string|Project - Location: Location| x |
|alternative/version/quote/sale/project/projectAssociate/isLocation|bool|Project - Is a location: Is a location| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:1|string|Project - projectshorttext| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:2|string|Project - projectlongtext| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:3|int|Project - projectnumber| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:4|date|Project - projectdate| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:5|unlimitedDate|Project - projectunlimiteddate| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:6|bool|Project - projectcheckbox| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:7|listAny|Project - projectdropdownlistbox| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:8|decimal|Project - projectdecimal| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:9|int|Project - page1saleandmarketing| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:10|int|Project - page1saleandadmin| x |
|alternative/version/quote/sale/project/NumberOfActivities|int|Project - Number of activities|  |
|alternative/version/quote/sale/project/NumberOfActivitiesInPeriod|int|Project - Number of activities in last 90 days|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedActivities|int|Project - Number of non-completed activities|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedActivitiesInPeriod|int|Project - Number of non-completed activities in last 90 days|  |
|alternative/version/quote/sale/project/LastActivity|date|Project - Date of last activity|  |
|alternative/version/quote/sale/project/LastCompletedActivity|date|Project - Date of last completed activity|  |
|alternative/version/quote/sale/project/LastDoByActivity|date|Project - Date of last non-completed activity|  |
|alternative/version/quote/sale/project/NumberOfSales|int|Project - Number of sales|  |
|alternative/version/quote/sale/project/NumberOfSalesInPeriod|int|Project - Number of sales in last 90 days|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedSales|int|Project - Number of non-completed sales|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedSalesInPeriod|int|Project - Number of non-completed sales in last 90 days|  |
|alternative/version/quote/sale/project/LastSale|date|Project - Date of last sale|  |
|alternative/version/quote/sale/project/LastCompletedSale|date|Project - Date of last completed sale|  |
|alternative/version/quote/sale/project/LastDoBySale|date|Project - Date of last non-completed sale|  |
|alternative/version/quote/sale/project/SaintStatus3|saintStatus|Project - Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|alternative/version/quote/sale/project/saintSaleStatus|listAny|Project - With status|  |
|alternative/version/quote/sale/project/saintAmountClass|listAny|Project - Amount class|  |
|alternative/version/quote/sale/project/saintActivityType|listAny|Project - SAINT type|  |
|alternative/version/quote/sale/project/saintDirection|listAny|Project - Direction|  |
|alternative/version/quote/sale/project/saintIntention|listAny|Project - Intention|  |
|alternative/version/quote/sale/project/saintTicketStatus|listAny|Project - Status|  |
|alternative/version/quote/sale/project/saintTicketCategory|listAny|Project - Category|  |
|alternative/version/quote/sale/project/project/textId|int|Project - Text ID| x |
|alternative/version/quote/sale/project/project/infoText|positiveString|Project - Information: Displays the text entered in the description field| x |
|alternative/version/quote/connection/quoteConnectionId|int|ERP connection - DB-ID: Database ID| x |
|alternative/version/quote/connection/deleted|bool|ERP connection - Deleted: Column showing if the ERP connection has been marked as deleted| x |
|alternative/version/quote/connection/allAccess|bool|ERP connection - Unrestricted: There are no access restrictions on this ERP connection| x |
|alternative/version/quote/connection/erpName|int|ERP connection - ERP name: Name of ERP system| x |
|alternative/version/quote/connection/displayName|string|ERP connection - Name: Localized display name| x |
|alternative/version/quote/connection/displayDescription|string|ERP connection - Description: Describes the connection in more detail.| x |
|alternative/version/quote/connection/connectorName|string|ERP connection - Quote Connector name: Name of Quote Connector module. Defined by the developer of the module.| x |
|alternative/version/quote/connection/extraData|string|ERP connection - Extra data: XML encoded data.| x |
|alternative/version/quote/connection/updatedBy|associate|ERP connection - Updated by: The user who last updated the data| x |
|alternative/version/quote/connection/updatedDate|date|ERP connection - Updated: The date/time the data was last updated in UTC.| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/connection/registeredBy|associate|ERP connection - Registered by: The user who registered the data| x |
|alternative/version/quote/connection/registeredDate|date|ERP connection - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/connection/erpConnection/id|int|ERP connection - ERP connections - Connection ID: Database key for an ERP connection|  |
|alternative/version/quote/connection/erpConnection/name|string|ERP connection - ERP connections - Name: Name of the ERP connection in the CRM system|  |
|alternative/version/quote/connection/erpConnection/description|string|ERP connection - ERP connections - Description: The description of the ERP connection in the CRM system|  |
|alternative/version/quote/connection/erpConnection/active|bool|ERP connection - ERP connections - Active: Is the ERP connection currently active?|  |
|alternative/version/quote/connection/erpConnection/erpId|string|ERP connection - ERP connections - ERP ID: The global unique ID of this ERP connection, as used by the Sync Connector|  |
|alternative/version/quote/connection/erpConnection/mostRecent|string|ERP connection - ERP connections - Timestamp: The timestamp of the most recent synchronization on this ERP connection|  |
|alternative/version/quote/connection/erpConnection/allAccess|bool|ERP connection - ERP connections - Unrestricted: There are no access restrictions on this ERP connection|  |
|alternative/version/quote/connection/erpConnection/deleted|bool|ERP connection - ERP connections - Deleted: Column showing if the ERP connection has been marked as deleted|  |
|alternative/version/quote/connection/erpConnection/updatedBy|associate|ERP connection - ERP connections - Updated by: The user who last updated the data| x |
|alternative/version/quote/connection/erpConnection/updatedDate|date|ERP connection - ERP connections - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/connection/erpConnection/registeredBy|associate|ERP connection - ERP connections - Registered by: The user who registered the data| x |
|alternative/version/quote/connection/erpConnection/registeredDate|date|ERP connection - ERP connections - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/connection/erpConnection/connector/id|stringorPK|ERP connection - ERP connections - Connection ID: Database key for an ERP connection| x |
|alternative/version/quote/connection/erpConnection/connector/url|string|ERP connection - ERP connections - URL of Sync Connector: The URL to the location where the Sync Connector is installed| x |
|alternative/version/quote/connection/erpConnection/connector/name|string|ERP connection - ERP connections - Name: Name of the ERP connection in the CRM system| x |
|alternative/version/quote/connection/erpConnection/connector/updatedBy|associate|ERP connection - ERP connections - Updated by: The user who last updated the data| x |
|alternative/version/quote/connection/erpConnection/connector/updatedDate|date|ERP connection - ERP connections - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/connection/erpConnection/connector/registeredBy|associate|ERP connection - ERP connections - Registered by: The user who registered the data| x |
|alternative/version/quote/connection/erpConnection/connector/registeredDate|date|ERP connection - ERP connections - Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/QuoteLineSelectionV2?$select=alternative/version/quote/sale/person/personUrl/URLAddress,alternative/version/quote/sale/person/personExtra/y_rental/id,alternative/version/quote/sale/contact/orgnr,alternative/version/quote/sale/contact/streetAddress/city,alternative/version/quote/sale/saleUdef/SuperOffice:2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

