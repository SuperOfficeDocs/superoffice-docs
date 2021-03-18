---
uid: QuoteLineSelectionV2
title: QuoteLineSelectionV2
description: This is the archive Provider for the Selection QuoteLine archive.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
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
|alternative/version/quote/orderComment|string|Comment: Customer's comment| x |
|alternative/version/quote/connectionId|int|DB-ID: Database ID| x |
|alternative/version/quote/registeredDate|date|Registered at: Displays the date when the quote was registered.| x |
|alternative/version/quote/sale/completed|bool|Sale - Completed: Displays a checkbox showing if an appointment is completed| x |
|alternative/version/quote/sale/icon| *None* |Sale - Category: Displays the icon for an activity type| x |
|alternative/version/quote/sale/date|date|Sale - Date: Displays start date of a follow-up / sale date of a sale| x |
|alternative/version/quote/sale/time| *None* |Sale - Time: Time|  |
|alternative/version/quote/sale/type|listAny|Sale - Type: Displays the type of an activity| x |
|alternative/version/quote/sale/recordType|string|Sale - Record type: Shows the record type| x |
|alternative/version/quote/sale/text|positiveString|Sale - Text: Displays a descriptive text for the item| x |
|alternative/version/quote/sale/associateId|associate|Sale - ID: Displays the login ID of the associate who owns the activity.| x |
|alternative/version/quote/sale/contactId|listAny|Sale - Company ID: Database ID of company| x |
|alternative/version/quote/sale/personId|listAny|Sale - Contact ID: Database ID of the contact row| x |
|alternative/version/quote/sale/projectId|listAny|Sale - Project ID: Database ID of project record| x |
|alternative/version/quote/sale/saleId|int|Sale - Sale ID: The database ID of the sale record| x |
|alternative/version/quote/sale/userGroup|userGroup|Sale - User group: The user group that owns the record| x |
|alternative/version/quote/sale/who| *None* |Sale - Who: Contact and/or company|  |
|alternative/version/quote/sale/updatedBy|associate|Sale - Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/updatedDate|date|Sale - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/registeredBy|associate|Sale - Registered by: The user who registered the data| x |
|alternative/version/quote/sale/registeredDate|date|Sale - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/currencyId|int|Sale - Currency ID: The currency list item ID| x |
|alternative/version/quote/sale/currency|listAny|Sale - Currency: The currency of the sale| x |
|alternative/version/quote/sale/credited|listAny|Sale - Credited: The user to be credited with the sale| x |
|alternative/version/quote/sale/lossReason|listAny|Sale - Reason (lost): The reason for losing the sale| x |
|alternative/version/quote/sale/source|listAny|Sale - Source: The source (lead) of the sale| x |
|alternative/version/quote/sale/competitor|listAny|Sale - Competitor: The competitor who won the sale| x |
|alternative/version/quote/sale/heading|stringorPK|Sale - Sale: Displays a descriptive text for the item| x |
|alternative/version/quote/sale/amount|decimal|Sale - Amount: The gross sales total| x |
|alternative/version/quote/sale/amountWeighted|decimal|Sale - Weighted amount: Virtual field calculated from amount * probability percent.| x |
|alternative/version/quote/sale/earning|decimal|Sale - Profit: Gross profit (gross sales total - cost) for the sale| x |
|alternative/version/quote/sale/earningPercent|decimal|Sale - Profit as %: The profit as a percentage of the gross sales total| x |
|alternative/version/quote/sale/probPercent|int|Sale - Probability as %: Probability as %| x |
|alternative/version/quote/sale/originalStage|listAny|Sale - Stage: Displays the stage of the sale| x |
|alternative/version/quote/sale/stage|listAny|Sale - Stage: Displays the stage of the sale| x |
|alternative/version/quote/sale/saleStatus|listAny|Sale - Status: The status of the sale - open, lost or sold| x |
|alternative/version/quote/sale/saleType|listAny|Sale - Sale type: Sale type, from list| x |
|alternative/version/quote/sale/nextDueDate|date|Sale - Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|alternative/version/quote/sale/reopenDate|date|Sale - Reopen date: Displays the reopen date for the sale| x |
|alternative/version/quote/sale/stalledComment|listAny|Sale - Reason (stalled): The reason the sale has been stalled| x |
|alternative/version/quote/sale/soldReason|listAny|Sale - Reason (sold): Reason (sold)| x |
|alternative/version/quote/sale/saleNumber|string|Sale - Number: Number| x |
|alternative/version/quote/sale/hasStakeholders|bool|Sale - Has stakeholders: Does this sale have stakeholders enabled| x |
|alternative/version/quote/sale/hasQuote|bool|Sale - Has quote?: Does the sale have a quote attached?| x |
|alternative/version/quote/sale/hasGuide|bool|Sale - Guided: Does this sale have a Sales Guide| x |
|alternative/version/quote/sale/description|string|Sale - Description: The long description field on Sale|  |
|alternative/version/quote/sale/activeErpLinks|bool|Sale - ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/visibleFor|listAny|Sale - Visible for|  |
|alternative/version/quote/sale/sale/textId|int|Sale - Text ID| x |
|alternative/version/quote/sale/sale/description|positiveString|Sale - Text: Displays the text entered in the description field| x |
|alternative/version/quote/sale/person/personId|int|Sale - DB ID: Displays the database ID of a contact| x |
|alternative/version/quote/sale/person/firstName|string|Sale - First name: Displays the contact's first name| x |
|alternative/version/quote/sale/person/lastName|string|Sale - Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/person/middleName|string|Sale - Middle name: Displays the contact's middle name.| x |
|alternative/version/quote/sale/person/fullName|stringorPK|Sale - Contact: Displays the contact to which an item is linked| x |
|alternative/version/quote/sale/person/contactId|int|Sale - Company ID: Database ID of company| x |
|alternative/version/quote/sale/person/hasInfoText|bool|Sale - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|alternative/version/quote/sale/person/hasInterests|bool|Sale - Has interests: Displays an Icon indicating if the contact has active interests| x |
|alternative/version/quote/sale/person/personHasInterests|bool|Sale - Has interests: Displays an Icon indicating if the contact has active interests| x |
|alternative/version/quote/sale/person/mrMrs|string|Sale - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/person/position|listAny|Sale - Position| x |
|alternative/version/quote/sale/person/personNumber|string|Sale - Number: Displays the contact's number| x |
|alternative/version/quote/sale/person/title|string|Sale - Title: Displays the contact's job title| x |
|alternative/version/quote/sale/person/personCountry|listAny|Sale - Country: Country| x |
|alternative/version/quote/sale/person/personNoMail|bool|Sale - No Mailings: Displays the contact's No Mailings checkbox| x |
|alternative/version/quote/sale/person/rank|int|Sale - Rank: Displays a contact's current rank| x |
|alternative/version/quote/sale/person/birthdate| *None* |Sale - Birthdate: Displays the contact's date of birth|  |
|alternative/version/quote/sale/person/associateType| *None* |Sale - User type: Displays an icon indicating if a contact is an associate or external contact with log-in rights and currently online. This information is updated only once while the archive is loading.|  |
|alternative/version/quote/sale/person/useAsMailingAddress|bool|Sale - Use as postal address: Use as postal address| x |
|alternative/version/quote/sale/person/personSource|listAny|Sale - Source: Source (Contact)| x |
|alternative/version/quote/sale/person/retired|bool|Sale - Former employee: Indicates whether the contact has retired/left the company| x |
|alternative/version/quote/sale/person/birthYear|int|Sale - Birth year: Displays contact's birth year| x |
|alternative/version/quote/sale/person/birthMonth|int|Sale - Birth month: Displays contact's birth month| x |
|alternative/version/quote/sale/person/birthDay|int|Sale - Birth day: Displays contact's birth day (day of month)| x |
|alternative/version/quote/sale/person/kanaFirstName|string|Sale - First name, kana: Contact's first name, in kana alphabet| x |
|alternative/version/quote/sale/person/kanaLastName|string|Sale - Last name, kana: Contact's last name, in kana alphabet| x |
|alternative/version/quote/sale/person/personUpdatedBy|associate|Sale - Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/person/personUpdatedDate|date|Sale - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/person/personRegisteredBy|associate|Sale - Registered by: The user who registered the data| x |
|alternative/version/quote/sale/person/personRegisteredDate|date|Sale - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/person/portraitThumbnail| *None* |Sale - Person image: Person image|  |
|alternative/version/quote/sale/person/personActiveErpLinks|bool|Sale - ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/person/ticketPriority|listAny|Sale - Service priority: Default service priority for this contact| x |
|alternative/version/quote/sale/person/supportLanguage|listAny|Sale - Preferred language: Preferred language used for reply templates and more| x |
|alternative/version/quote/sale/person/supportAssociate|associate|Sale - Our service contact: Default service contact for this contact| x |
|alternative/version/quote/sale/person/personAssociateId|associate|Sale - Our contact: Displays our contact| x |
|alternative/version/quote/sale/person/personCategory|listAny|Sale - Category| x |
|alternative/version/quote/sale/person/personBusiness|listAny|Sale - Business| x |
|alternative/version/quote/sale/person/personDeletedDate|datetime|Sale - Deleted date: Deleted date|  |
|alternative/version/quote/sale/person/hasCompany|bool|Sale - Has company: The contact is associated with a company| x |
|alternative/version/quote/sale/person/isProjectMember|bool|Sale - Is project member: This person is a project member| x |
|alternative/version/quote/sale/person/isStakeholder|bool|Sale - Is stakeholder: This person is a sale stakeholder| x |
|alternative/version/quote/sale/person/phone/formattedNumber|string|Sale - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personDirectPhone/formattedNumber|string|Sale - Direct - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personDirectPhone/description|string|Sale - Direct - Description: Phone number description| x |
|alternative/version/quote/sale/person/personMobilePhone/formattedNumber|string|Sale - Mobile - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personMobilePhone/description|string|Sale - Mobile - Description: Phone number description| x |
|alternative/version/quote/sale/person/personPrivate/formattedNumber|string|Sale - Private - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personPrivate/description|string|Sale - Private - Description: Phone number description| x |
|alternative/version/quote/sale/person/personPager/formattedNumber|string|Sale - Other - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personPager/description|string|Sale - Other - Description: Phone number description| x |
|alternative/version/quote/sale/person/personDirectFax/formattedNumber|string|Sale - Fax - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/personDirectFax/description|string|Sale - Fax - Description: Phone number description| x |
|alternative/version/quote/sale/person/searchPhone/formattedNumber|string|Sale - Phone: Displays phone number|  |
|alternative/version/quote/sale/person/searchPhone/description|string|Sale - Description: Phone number description| x |
|alternative/version/quote/sale/person/personInfo/textId|int|Sale - Text ID| x |
|alternative/version/quote/sale/person/personInfo/infoText|positiveString|Sale - Information: Displays the text entered in the description field| x |
|alternative/version/quote/sale/person/email/emailProtocol|string|Sale - Protocol: E-mail protocol, such as SMTP| x |
|alternative/version/quote/sale/person/email/emailAddress|string|Sale - E-mail| x |
|alternative/version/quote/sale/person/email/emailDescription|string|Sale - Description| x |
|alternative/version/quote/sale/person/email/emailId|int|Sale - ID| x |
|alternative/version/quote/sale/person/email/emailLastSent|datetime|Sale - Last sent: The date and time an e-mail was last sent to this address| x |
|alternative/version/quote/sale/person/email/emailBounceCount|int|Sale - Bounce count: Bounce count for this e-mail address| x |
|alternative/version/quote/sale/person/email/emailLastBounce|datetime|Sale - Last bounce: Date and time for last bounce to this e-mail address| x |
|alternative/version/quote/sale/person/email/emailHasBounced|bool|Sale - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|alternative/version/quote/sale/person/personUrl/URLAddress|string|Sale - URL| x |
|alternative/version/quote/sale/person/personUrl/URLDescription|string|Sale - Description| x |
|alternative/version/quote/sale/person/personAddress/addressId|int|Sale - Contact address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/person/personAddress/line1|string|Sale - Contact address - Address 1: First line of the address| x |
|alternative/version/quote/sale/person/personAddress/line2|string|Sale - Contact address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/person/personAddress/line3|string|Sale - Contact address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/person/personAddress/county|string|Sale - Contact address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/personAddress/city|string|Sale - Contact address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/person/personAddress/zip|string|Sale - Contact address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/person/personAddress/state|string|Sale - Contact address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/personAddress/wgs84latitude|decimal|Sale - Contact address - Latitude: Latitude| x |
|alternative/version/quote/sale/person/personAddress/wgs84longitude|decimal|Sale - Contact address - Longitude: Longitude| x |
|alternative/version/quote/sale/person/personAddress/formattedAddress| *None* |Sale - Contact address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/personAddress/formattedMultiLineAddress| *None* |Sale - Contact address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/restrictionAddress/addressId|int|Sale - Search address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/person/restrictionAddress/line1|string|Sale - Search address - Address 1: First line of the address| x |
|alternative/version/quote/sale/person/restrictionAddress/line2|string|Sale - Search address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/person/restrictionAddress/line3|string|Sale - Search address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/person/restrictionAddress/county|string|Sale - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/restrictionAddress/city|string|Sale - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/person/restrictionAddress/zip|string|Sale - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/person/restrictionAddress/state|string|Sale - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/person/restrictionAddress/wgs84latitude|decimal|Sale - Search address - Latitude: Latitude| x |
|alternative/version/quote/sale/person/restrictionAddress/wgs84longitude|decimal|Sale - Search address - Longitude: Longitude| x |
|alternative/version/quote/sale/person/restrictionAddress/formattedAddress| *None* |Sale - Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/restrictionAddress/formattedMultiLineAddress| *None* |Sale - Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/personInterestIds|listInterest|Sale - Contact interest: This criterion corresponds to a contact's interests.  It is available via the Contact dialog's Interests tab.|  |
|alternative/version/quote/sale/person/personUdef/SuperOffice:1|string|Sale - contactshorttext: tooltipshorttext| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:2|string|Sale - contactlongtext: tooltiplongtext| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:3|int|Sale - contactnumber| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:4|date|Sale - contactdate| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:5|unlimitedDate|Sale - contactunlimiteddate: tooltipunlimiteddate| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:6|bool|Sale - contactcheckbox| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:7|listAny|Sale - contactdropdownlistbox| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:8|decimal|Sale - contactdecimal| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:9|string|Sale - page1saleonly| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:10|string|Sale - page1marketingonly| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:11|string|Sale - page1adminonly| x |
|alternative/version/quote/sale/person/isMailingRecipient|bool|Sale - isMailingRecipient: isMailingRecipient| x |
|alternative/version/quote/sale/person/hasStoreConsent|bool|Sale - Consent - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|alternative/version/quote/sale/person/withdrawnStoreConsent|bool|Sale - Consent is withdrawn - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|alternative/version/quote/sale/person/hasEmarketingConsent|bool|Sale - Consent - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|alternative/version/quote/sale/person/withdrawnEmarketingConsent|bool|Sale - Consent is withdrawn - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|alternative/version/quote/sale/person/subscription|listAny|Sale - Subscription: Subscription for marketing| x |
|alternative/version/quote/sale/person/legalBaseStore|listAny|Sale - Legal basis - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|alternative/version/quote/sale/person/legalBaseEmarketing|listAny|Sale - Legal basis - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|alternative/version/quote/sale/person/consentSourceStore|listAny|Sale - Source - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|alternative/version/quote/sale/person/consentSourceEmarketing|listAny|Sale - Source - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|alternative/version/quote/sale/contact/contactId|int|Sale - Company ID: Database ID of company| x |
|alternative/version/quote/sale/contact/name|stringorPK|Sale - Company name| x |
|alternative/version/quote/sale/contact/department|string|Sale - Department| x |
|alternative/version/quote/sale/contact/nameDepartment| *None* |Sale - Company: Displays the company an activity is linked to| x |
|alternative/version/quote/sale/contact/hasInfoText|bool|Sale - Has note: Displays an icon indicating if there is additional information available about the contact| x |
|alternative/version/quote/sale/contact/hasInterests|bool|Sale - Has interests: Displays an Icon indicating if the contact has active interests| x |
|alternative/version/quote/sale/contact/associateId|associate|Sale - Our contact: Displays our contact| x |
|alternative/version/quote/sale/contact/category|listAny|Sale - Category| x |
|alternative/version/quote/sale/contact/business|listAny|Sale - Business| x |
|alternative/version/quote/sale/contact/country|listAny|Sale - Country: This criterion corresponds to the Country field on the Company card.| x |
|alternative/version/quote/sale/contact/number|string|Sale - Number| x |
|alternative/version/quote/sale/contact/code|string|Sale - Code| x |
|alternative/version/quote/sale/contact/orgnr|string|Sale - VAT No.| x |
|alternative/version/quote/sale/contact/stop|bool|Sale - Stop| x |
|alternative/version/quote/sale/contact/contactNoMail|bool|Sale - No mailings (company)| x |
|alternative/version/quote/sale/contact/updatedBy|associate|Sale - Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/contact/updatedDate|date|Sale - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/contact/registeredBy|associate|Sale - Registered by: The user who registered the data| x |
|alternative/version/quote/sale/contact/registeredDate|date|Sale - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/contact/contactSource|listAny|Sale - Source: Source (Company)| x |
|alternative/version/quote/sale/contact/contactDeleted|bool|Sale - Deleted: Deleted| x |
|alternative/version/quote/sale/contact/phone/formattedNumber|string|Sale - Phone: Displays phone number|  |
|alternative/version/quote/sale/contact/activeErpLinks|bool|Sale - ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/contact/deletedDate|datetime|Sale - Deleted date: Deleted date|  |
|alternative/version/quote/sale/contact/mainContact| *None* |Sale - Main contact: Main contact for this company| x |
|alternative/version/quote/sale/contact/contactPhone/formattedNumber|string|Sale - Telephone - Phone: Displays phone number|  |
|alternative/version/quote/sale/contact/contactPhone/description|string|Sale - Telephone - Description: Phone number description| x |
|alternative/version/quote/sale/contact/contactFax/formattedNumber|string|Sale - Fax - Phone: Displays phone number|  |
|alternative/version/quote/sale/contact/contactFax/description|string|Sale - Fax - Description: Phone number description| x |
|alternative/version/quote/sale/contact/searchPhone/formattedNumber|string|Sale - Searchphone - Phone: Displays phone number|  |
|alternative/version/quote/sale/contact/searchPhone/description|string|Sale - Searchphone - Description: Phone number description| x |
|alternative/version/quote/sale/contact/email/emailProtocol|string|Sale - Protocol: E-mail protocol, such as SMTP| x |
|alternative/version/quote/sale/contact/email/emailAddress|string|Sale - E-mail| x |
|alternative/version/quote/sale/contact/email/emailDescription|string|Sale - Description| x |
|alternative/version/quote/sale/contact/email/emailId|int|Sale - ID| x |
|alternative/version/quote/sale/contact/email/emailLastSent|datetime|Sale - Last sent: The date and time an e-mail was last sent to this address| x |
|alternative/version/quote/sale/contact/email/emailBounceCount|int|Sale - Bounce count: Bounce count for this e-mail address| x |
|alternative/version/quote/sale/contact/email/emailLastBounce|datetime|Sale - Last bounce: Date and time for last bounce to this e-mail address| x |
|alternative/version/quote/sale/contact/email/emailHasBounced|bool|Sale - Has bounced: This checkbox is active if delivery to this e-mail address has failed.| x |
|alternative/version/quote/sale/contact/postAddress/addressId|int|Sale - Postal address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/contact/postAddress/line1|string|Sale - Postal address - Address 1: First line of the address| x |
|alternative/version/quote/sale/contact/postAddress/line2|string|Sale - Postal address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/contact/postAddress/line3|string|Sale - Postal address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/contact/postAddress/county|string|Sale - Postal address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/postAddress/city|string|Sale - Postal address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/contact/postAddress/zip|string|Sale - Postal address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/contact/postAddress/state|string|Sale - Postal address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/postAddress/wgs84latitude|decimal|Sale - Postal address - Latitude: Latitude| x |
|alternative/version/quote/sale/contact/postAddress/wgs84longitude|decimal|Sale - Postal address - Longitude: Longitude| x |
|alternative/version/quote/sale/contact/postAddress/formattedAddress| *None* |Sale - Postal address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/postAddress/formattedMultiLineAddress| *None* |Sale - Postal address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/streetAddress/addressId|int|Sale - Street address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/contact/streetAddress/line1|string|Sale - Street address - Address 1: First line of the address| x |
|alternative/version/quote/sale/contact/streetAddress/line2|string|Sale - Street address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/contact/streetAddress/line3|string|Sale - Street address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/contact/streetAddress/county|string|Sale - Street address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/streetAddress/city|string|Sale - Street address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/contact/streetAddress/zip|string|Sale - Street address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/contact/streetAddress/state|string|Sale - Street address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/streetAddress/wgs84latitude|decimal|Sale - Street address - Latitude: Latitude| x |
|alternative/version/quote/sale/contact/streetAddress/wgs84longitude|decimal|Sale - Street address - Longitude: Longitude| x |
|alternative/version/quote/sale/contact/streetAddress/formattedAddress| *None* |Sale - Street address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/streetAddress/formattedMultiLineAddress| *None* |Sale - Street address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/restrictionAddress/addressId|int|Sale - Search address - Address ID: Database ID for the address record| x |
|alternative/version/quote/sale/contact/restrictionAddress/line1|string|Sale - Search address - Address 1: First line of the address| x |
|alternative/version/quote/sale/contact/restrictionAddress/line2|string|Sale - Search address - Address 2: Second line of the address| x |
|alternative/version/quote/sale/contact/restrictionAddress/line3|string|Sale - Search address - Address 3: Third line of the address| x |
|alternative/version/quote/sale/contact/restrictionAddress/county|string|Sale - Search address - County: This criterion corresponds to the County field on the Company card. It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/restrictionAddress/city|string|Sale - Search address - City: This criterion corresponds to the City field on the Company card.| x |
|alternative/version/quote/sale/contact/restrictionAddress/zip|string|Sale - Search address - Postcode: This criterion corresponds to the Zip Code field on the Company card.| x |
|alternative/version/quote/sale/contact/restrictionAddress/state|string|Sale - Search address - State: This criterion corresponds to the State field on the Company card.  \It will only be visible if required by a country's address format.| x |
|alternative/version/quote/sale/contact/restrictionAddress/wgs84latitude|decimal|Sale - Search address - Latitude: Latitude| x |
|alternative/version/quote/sale/contact/restrictionAddress/wgs84longitude|decimal|Sale - Search address - Longitude: Longitude| x |
|alternative/version/quote/sale/contact/restrictionAddress/formattedAddress| *None* |Sale - Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/restrictionAddress/formattedMultiLineAddress| *None* |Sale - Search address - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/url/URLAddress|string|Sale - URL| x |
|alternative/version/quote/sale/contact/url/URLDescription|string|Sale - Description| x |
|alternative/version/quote/sale/contact/contactAssociate/firstName|string|Sale - First name: Displays the contact's first name| x |
|alternative/version/quote/sale/contact/contactAssociate/lastName|string|Sale - Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/contact/contactAssociate/middleName|string|Sale - Middle Name: Displays the contact's middle name.| x |
|alternative/version/quote/sale/contact/contactAssociate/fullName|string|Sale - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/contact/contactAssociate/contactId|int|Sale - Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/contact/contactAssociate/personId|int|Sale - Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/contact/contactAssociate/mrMrs|string|Sale - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/contact/contactAssociate/title|string|Sale - Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/contact/contactAssociate/associateDbId|associate|Sale - ID| x |
|alternative/version/quote/sale/contact/contactAssociate/contactName|string|Sale - Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/contact/contactAssociate/contactDepartment|string|Sale - Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/contact/contactAssociate/usergroup|userGroup|Sale - Primary group: The user's primary user group| x |
|alternative/version/quote/sale/contact/contactAssociate/contactFullName|string|Sale - Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/contact/contactAssociate/contactCategory|listAny|Sale - Category: Category| x |
|alternative/version/quote/sale/contact/contactAssociate/role|listAny|Sale - Role: Role| x |
|alternative/version/quote/sale/contact/contactAssociate/assocName|associate|Sale - User ID: User ID| x |
|alternative/version/quote/sale/contact/contactAssociate/assocTooltip|string|Sale - Description: Description|  |
|alternative/version/quote/sale/contact/contactAssociate/assocType|listAny|Sale - Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/contact/contactAssociate/ejUserId|int|Sale - Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/contact/contactAssociate/simultaneousEjUser|bool|Sale - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/contact/contactAssociate/ejDisplayName|string|Sale - Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/contact/contactAssociate/ejStatus|int|Sale - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/contact/contactAssociate/credentialType| *None* |Sale - Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/contact/contactAssociate/credentialDisplayValue| *None* |Sale - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/contact/contactAssociate/isActive|bool|Sale - Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/contact/contactAssociate/isActiveText|bool|Sale - Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/contact/contactAssociate/portraitThumbnail| *None* |Sale - Person image: Person image|  |
|alternative/version/quote/sale/contact/contactAssociate/otherGroups|userGroup|Sale - Other groups: Other groups|  |
|alternative/version/quote/sale/contact/contactAssociate/userName|string|Sale - User name: User name| x |
|alternative/version/quote/sale/contact/contactAssociate/personEmail|string|Sale - E-mail| x |
|alternative/version/quote/sale/contact/contactInterestIds|listInterest|Sale - Company Interest: This criterion corresponds to the Interests tab on the Company card.|  |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:1|string|Sale - companyshorttext: tooltipshorttext| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:2|string|Sale - companylongtext: tooltiplongtext| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:3|int|Sale - companynumber| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:4|date|Sale - companydate| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:5|unlimitedDate|Sale - companyunlimiteddate: tooltipunlimiteddate| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:6|bool|Sale - companycheckbox| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:7|listAny|Sale - companydropdownlistbox| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:8|decimal|Sale - companydecimal| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:9|string|Sale - page1saleonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:10|string|Sale - page1marketingonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:11|string|Sale - page1adminonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:12|listAny|Sale - Udlist one: Static tooltip for udlist one| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:13|listAny|Sale - Udlist two: Static tooltip for udlist two| x |
|alternative/version/quote/sale/contact/NumberOfActivities|int|Sale - Number of activities|  |
|alternative/version/quote/sale/contact/NumberOfActivitiesInPeriod|int|Sale - Number of activities in last 90 days|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedActivities|int|Sale - Number of non-completed activities|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedActivitiesInPeriod|int|Sale - Number of non-completed activities in last 90 days|  |
|alternative/version/quote/sale/contact/LastActivity|date|Sale - Date of last activity|  |
|alternative/version/quote/sale/contact/LastCompletedActivity|date|Sale - Date of last completed activity|  |
|alternative/version/quote/sale/contact/LastDoByActivity|date|Sale - Date of last non-completed activity|  |
|alternative/version/quote/sale/contact/NumberOfSales|int|Sale - Number of sales|  |
|alternative/version/quote/sale/contact/NumberOfSalesInPeriod|int|Sale - Number of sales in last 90 days|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedSales|int|Sale - Number of non-completed sales|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedSalesInPeriod|int|Sale - Number of non-completed sales in last 90 days|  |
|alternative/version/quote/sale/contact/LastSale|date|Sale - Date of last sale|  |
|alternative/version/quote/sale/contact/LastCompletedSale|date|Sale - Date of last completed sale|  |
|alternative/version/quote/sale/contact/LastDoBySale|date|Sale - Date of last non-completed sale|  |
|alternative/version/quote/sale/contact/NumberOfTickets|int|Sale - Number of requests|  |
|alternative/version/quote/sale/contact/NumberOfTicketsInPeriod|int|Sale - Number of requests in last 90 days|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedTickets|int|Sale - Number of non-completed requests|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedTicketsInPeriod|int|Sale - Number of non-completed requests in last 90 days|  |
|alternative/version/quote/sale/contact/LastTicket|date|Sale - Date of last request|  |
|alternative/version/quote/sale/contact/LastCompletedTicket|date|Sale - Date of last completed request|  |
|alternative/version/quote/sale/contact/LastDoByTicket|date|Sale - Date of last non-completed request|  |
|alternative/version/quote/sale/contact/SaintStatus1|saintStatus|Sale - Neglected customer|  |
|alternative/version/quote/sale/contact/SaintStatus2|saintStatus|Sale - C-company|  |
|alternative/version/quote/sale/contact/saintSaleStatus|listAny|Sale - With status|  |
|alternative/version/quote/sale/contact/saintAmountClass|listAny|Sale - Amount class|  |
|alternative/version/quote/sale/contact/saintActivityType|listAny|Sale - SAINT type|  |
|alternative/version/quote/sale/contact/saintDirection|listAny|Sale - Direction|  |
|alternative/version/quote/sale/contact/saintIntention|listAny|Sale - Intention|  |
|alternative/version/quote/sale/contact/saintTicketStatus|listAny|Sale - Status|  |
|alternative/version/quote/sale/contact/saintTicketCategory|listAny|Sale - Category|  |
|alternative/version/quote/sale/associate/firstName|string|Sale - First name: Displays the contact's first name| x |
|alternative/version/quote/sale/associate/lastName|string|Sale - Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/associate/middleName|string|Sale - Middle Name: Displays the contact's middle name.| x |
|alternative/version/quote/sale/associate/fullName|string|Sale - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/associate/contactId|int|Sale - Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/associate/personId|int|Sale - Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/associate/mrMrs|string|Sale - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/associate/title|string|Sale - Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/associate/associateDbId|associate|Sale - ID| x |
|alternative/version/quote/sale/associate/contactName|string|Sale - Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/associate/contactDepartment|string|Sale - Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/associate/usergroup|userGroup|Sale - Primary group: The user's primary user group| x |
|alternative/version/quote/sale/associate/contactFullName|string|Sale - Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/associate/contactCategory|listAny|Sale - Category: Category| x |
|alternative/version/quote/sale/associate/role|listAny|Sale - Role: Role| x |
|alternative/version/quote/sale/associate/assocName|associate|Sale - User ID: User ID| x |
|alternative/version/quote/sale/associate/assocTooltip|string|Sale - Description: Description|  |
|alternative/version/quote/sale/associate/assocType|listAny|Sale - Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/associate/ejUserId|int|Sale - Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/associate/simultaneousEjUser|bool|Sale - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/associate/ejDisplayName|string|Sale - Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/associate/ejStatus|int|Sale - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/associate/credentialType| *None* |Sale - Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/associate/credentialDisplayValue| *None* |Sale - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/associate/isActive|bool|Sale - Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/associate/isActiveText|bool|Sale - Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/associate/portraitThumbnail| *None* |Sale - Person image: Person image|  |
|alternative/version/quote/sale/associate/otherGroups|userGroup|Sale - Other groups: Other groups|  |
|alternative/version/quote/sale/associate/userName|string|Sale - User name: User name| x |
|alternative/version/quote/sale/associate/personEmail|string|Sale - E-mail| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:1|string|Sale - saleshorttext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:2|string|Sale - salelongtext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:3|int|Sale - salenumber| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:4|date|Sale - saledate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:5|unlimitedDate|Sale - saleunlimiteddate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:6|bool|Sale - salecheckbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:7|listAny|Sale - saledropdownlistbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:8|decimal|Sale - saledecimal| x |
|alternative/version/quote/sale/project/completed|bool|Sale - Project - Completed: Displays a check mark indicating if the project has been completed.| x |
|alternative/version/quote/sale/project/projectId|int|Sale - Project - DB ID: Displays the database ID for a project row| x |
|alternative/version/quote/sale/project/name|stringorPK|Sale - Project - Project name: Displays the Project's name| x |
|alternative/version/quote/sale/project/number|string|Sale - Project - Number: Displays the project's number| x |
|alternative/version/quote/sale/project/type|listAny|Sale - Project - Project type: Displays the project's type| x |
|alternative/version/quote/sale/project/status|listAny|Sale - Project - Status: Displays the project's status| x |
|alternative/version/quote/sale/project/associateId|associate|Sale - Project - ID: Displays login ID of the associate who owns the project| x |
|alternative/version/quote/sale/project/hasInfoText|bool|Sale - Project - Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|alternative/version/quote/sale/project/icon| *None* |Sale - Project - Category: Displays the icon for an activity type| x |
|alternative/version/quote/sale/project/text|string|Sale - Project - Text: Displays a descriptive text for the item| x |
|alternative/version/quote/sale/project/description|string|Sale - Project - Description: Description| x |
|alternative/version/quote/sale/project/updatedBy|associate|Sale - Project - Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/project/updatedDate|date|Sale - Project - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/project/registeredBy|associate|Sale - Project - Registered by: The user who registered the data| x |
|alternative/version/quote/sale/project/registeredDate|date|Sale - Project - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/project/hasGuide|bool|Sale - Project - Guided: Does this sale have a Sales Guide| x |
|alternative/version/quote/sale/project/nextMilestone|date|Sale - Project - Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|alternative/version/quote/sale/project/endDate|date|Sale - Project - End date: End date of project| x |
|alternative/version/quote/sale/project/imageThumbnail| *None* |Sale - Project - Thumbnail: Scaled-down image of project image|  |
|alternative/version/quote/sale/project/activeErpLinks|bool|Sale - Project - ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/project/projectPublish/isPublished|bool|Sale - Project - Published: Displays an icon indicating if the project or sale has been published| x |
|alternative/version/quote/sale/project/projectPublish/publishedFrom|date|Sale - Project - From date: Start date for publishing. The record will not be visible prior to this date| x |
|alternative/version/quote/sale/project/projectPublish/publishedTo|date|Sale - Project - To date: End date for publishing. The record will not be visible after this date| x |
|alternative/version/quote/sale/project/projectPublish/publishedBy| *None* |Sale - Project - Published by: Published by|  |
|alternative/version/quote/sale/project/projectEvent/isExternalEvent|bool|Sale - Project - Event: Is this an external event| x |
|alternative/version/quote/sale/project/projectEvent/eventDate|date|Sale - Project - Event date: Event date| x |
|alternative/version/quote/sale/project/projectEvent/hasSignOn|bool|Sale - Project - Sign On: Does this event have the Sign On function enabled| x |
|alternative/version/quote/sale/project/projectEvent/hasSignOff|bool|Sale - Project - Sign Off: Does this event have the Sign Off function enabled| x |
|alternative/version/quote/sale/project/projectUrl/URLAddress|string|Sale - Project - URL| x |
|alternative/version/quote/sale/project/projectUrl/URLDescription|string|Sale - Project - Description| x |
|alternative/version/quote/sale/project/projectAssociate/firstName|string|Sale - Project - First name: Displays the contact's first name| x |
|alternative/version/quote/sale/project/projectAssociate/lastName|string|Sale - Project - Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/project/projectAssociate/middleName|string|Sale - Project - Middle Name: Displays the contact's middle name.| x |
|alternative/version/quote/sale/project/projectAssociate/fullName|string|Sale - Project - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/project/projectAssociate/contactId|int|Sale - Project - Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/project/projectAssociate/personId|int|Sale - Project - Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/project/projectAssociate/mrMrs|string|Sale - Project - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/project/projectAssociate/title|string|Sale - Project - Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/project/projectAssociate/associateDbId|associate|Sale - Project - ID| x |
|alternative/version/quote/sale/project/projectAssociate/contactName|string|Sale - Project - Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/project/projectAssociate/contactDepartment|string|Sale - Project - Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/project/projectAssociate/usergroup|userGroup|Sale - Project - Primary group: The user's primary user group| x |
|alternative/version/quote/sale/project/projectAssociate/contactFullName|string|Sale - Project - Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/project/projectAssociate/contactCategory|listAny|Sale - Project - Category: Category| x |
|alternative/version/quote/sale/project/projectAssociate/role|listAny|Sale - Project - Role: Role| x |
|alternative/version/quote/sale/project/projectAssociate/assocName|associate|Sale - Project - User ID: User ID| x |
|alternative/version/quote/sale/project/projectAssociate/assocTooltip|string|Sale - Project - Description: Description|  |
|alternative/version/quote/sale/project/projectAssociate/assocType|listAny|Sale - Project - Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/project/projectAssociate/ejUserId|int|Sale - Project - Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/project/projectAssociate/simultaneousEjUser|bool|Sale - Project - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/project/projectAssociate/ejDisplayName|string|Sale - Project - Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/project/projectAssociate/ejStatus|int|Sale - Project - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/project/projectAssociate/credentialType| *None* |Sale - Project - Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/project/projectAssociate/credentialDisplayValue| *None* |Sale - Project - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/project/projectAssociate/isActive|bool|Sale - Project - Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/project/projectAssociate/isActiveText|bool|Sale - Project - Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/project/projectAssociate/portraitThumbnail| *None* |Sale - Project - Person image: Person image|  |
|alternative/version/quote/sale/project/projectAssociate/otherGroups|userGroup|Sale - Project - Other groups: Other groups|  |
|alternative/version/quote/sale/project/projectAssociate/userName|string|Sale - Project - User name: User name| x |
|alternative/version/quote/sale/project/projectAssociate/personEmail|string|Sale - Project - E-mail| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:1|string|Sale - Project - projectshorttext| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:2|string|Sale - Project - projectlongtext| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:3|int|Sale - Project - projectnumber| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:4|date|Sale - Project - projectdate| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:5|unlimitedDate|Sale - Project - projectunlimiteddate| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:6|bool|Sale - Project - projectcheckbox| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:7|listAny|Sale - Project - projectdropdownlistbox| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:8|decimal|Sale - Project - projectdecimal| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:9|int|Sale - Project - page1saleandmarketing| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:10|int|Sale - Project - page1saleandadmin| x |
|alternative/version/quote/sale/project/NumberOfActivities|int|Sale - Project - Number of activities|  |
|alternative/version/quote/sale/project/NumberOfActivitiesInPeriod|int|Sale - Project - Number of activities in last 90 days|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedActivities|int|Sale - Project - Number of non-completed activities|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedActivitiesInPeriod|int|Sale - Project - Number of non-completed activities in last 90 days|  |
|alternative/version/quote/sale/project/LastActivity|date|Sale - Project - Date of last activity|  |
|alternative/version/quote/sale/project/LastCompletedActivity|date|Sale - Project - Date of last completed activity|  |
|alternative/version/quote/sale/project/LastDoByActivity|date|Sale - Project - Date of last non-completed activity|  |
|alternative/version/quote/sale/project/NumberOfSales|int|Sale - Project - Number of sales|  |
|alternative/version/quote/sale/project/NumberOfSalesInPeriod|int|Sale - Project - Number of sales in last 90 days|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedSales|int|Sale - Project - Number of non-completed sales|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedSalesInPeriod|int|Sale - Project - Number of non-completed sales in last 90 days|  |
|alternative/version/quote/sale/project/LastSale|date|Sale - Project - Date of last sale|  |
|alternative/version/quote/sale/project/LastCompletedSale|date|Sale - Project - Date of last completed sale|  |
|alternative/version/quote/sale/project/LastDoBySale|date|Sale - Project - Date of last non-completed sale|  |
|alternative/version/quote/sale/project/SaintStatus3|saintStatus|Sale - Project - Not completed activites with intention sale|  |
|alternative/version/quote/sale/project/saintSaleStatus|listAny|Sale - Project - With status|  |
|alternative/version/quote/sale/project/saintAmountClass|listAny|Sale - Project - Amount class|  |
|alternative/version/quote/sale/project/saintActivityType|listAny|Sale - Project - SAINT type|  |
|alternative/version/quote/sale/project/saintDirection|listAny|Sale - Project - Direction|  |
|alternative/version/quote/sale/project/saintIntention|listAny|Sale - Project - Intention|  |
|alternative/version/quote/sale/project/saintTicketStatus|listAny|Sale - Project - Status|  |
|alternative/version/quote/sale/project/saintTicketCategory|listAny|Sale - Project - Category|  |
|alternative/version/quote/sale/project/project/textId|int|Sale - Project - Text ID| x |
|alternative/version/quote/sale/project/project/infoText|positiveString|Sale - Project - Information: Displays the text entered in the description field| x |
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
GET /api/v1/archive/QuoteLineSelectionV2?$select=personId,alternative/version/quote/sale/person/consentSourceEmarketing,alternative/version/quote/sale/contact/hasInfoText,alternative/version/quote/sale/contact/updatedBy,alternative/version/quote/sale/contact/email/emailHasBounced
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

