---
title: IQuoteConnector
uid: i_quote_connector 
description: IQuoteConnector
author: SuperOffice Product and Engineering
date:
keywords: quote
content_type: howto
redirect_from: /en/api/netserver/plugins/quote-connectors/api/iquoteconnector
---

<!-- markdownlint-disable-file MD013 -->

# IQuoteConnector

This is the interface SuperOffice will call to integrate against an ERP system in the realm of quotes and orders.
SuperOffice uses  capabilities to determine what the connector can and cannot do.

If an ERP system does not provide products, or if the ERP system is not available, the searches can be delegated to the built-in SuperOffice product registry by using
the SuperOffice IProductRegisterCache object that is provided at startup.

Currencies are specified in ISO three letter codes: USD, NOK, SEK, EUR, GBP, etc.
See [http://www.currency-iso.org/dl_iso_table_a1.xls][1] for details.

The user may click the TEST button in the configuration dialog, which calls the TestConnection method.

## int CRMConnectionId

The id of this connection in the CRM system

## <a id="get-configuration-fields"></a>Dictionary&lt;string, FieldMetadataInfo> GetConfigurationFields()

This is a request for metadata needed to populate the Quote connection configuration admin dialog that takes in the information needed to create a connection to an ERP system.
The values entered in the dialog are stored in the SuperOffice db and used when
[`InitializeConnection`](#init-connection) is called by the client.
Returns: [FieldMetadataInfo][2] dictionary. A list of field descriptions for the GUI to use when populating the config dialog. Make sure that the FieldMetadataInfo.Rank is set.

## PluginResponseInfo TestConnection(Dictionary&lt;string, string> connectionData)

Check that the ERP connection is good. Return some status info that the Admin client can show to the user.

Testing if the connection data is sufficient to get a connection with the ERP system.
The Connector should try to do some operations to check if the connection has sufficient rights
to run. The connection has not been created yet.

* connectionData: {"name" = "value"}. The names are defined by the [FieldMetadata][2] returned by the [GetConfigurationFields](#get-configuration-fields). The values are what the user typed into the fields in the configure connection dialog.

Returns: Ok or not + a status or error message. This message is shown in a result dialog.

## <a id="init-connection"></a>PluginResponseInfo InitializeConnection(SuperOffice.CRM.QuoteConnectionInfo connectionData, SuperOffice.CRM.UserInfo user, bool isOnTravel, Dictionary&lt;string, string> connectionConfigFields, IProductRegisterCache productRegister)

 Set up the connection to the ERP system.
 Will be called as part of SuperOffice client startup for each installed connection.
 Configuration data comes from the configuration dialog shown in the Admin client (see [`GetConfigurationFields`](#get-configuration-fields))

* [QuoteConnectionInfo][3] connectionData: Contains the configuration values defined in the Admin client.
* UserInfo user: Information about the logged in user
* bool isOnTravel: Is the user on Travel?
* Dictionary connectionConfigFields: `{"name" = "value"}`. The names are defined by the [FieldMetadata][2]. The values are what the user typed into the fields in the configure connection dialog.
* [IProductRegisterCache][8] productRegister: Product caching object that allows connectors to stash product information in the SuperOffice database for off-line use.

Returns: IsOk set to false if connector can’t provide service (no network)
 The connector is then ignored until the application restarts.

## Dictionary&lt;string, bool> GetCapabilities()

Return a set of capability name &gt; status pairs that tell the system what capabilities this connector provides.

If a capability is missing, then the corresponding parts of the quote UI are disabled.

Returns: List of all capabilities that the connector supports. Capability names must match [the list of capability names][10].

## bool CanProvideCapability(string capabilityName)

Check if one named capability can be provided by this connector.

* capabilityName: Name of the capability, see the list for [valid names][10].

Returns: True if connector has this capability

## QuoteResponseInfo OnBeforeCreateQuote(QuoteAlternativeContextInfo context)

Called when a user is creating a quote.
The Quote does not exist in database at this time;
any changes in the returned QuoteResponseInfo will be saved and the GUI updated.

* [QuoteAlternativeContextInfo][4] context: The quote and its parts.

Returns:QuoteResponseInfo An updated quote. If returns IsOk = false, then quote creation is aborted.

## QuoteVersionResponseInfo OnBeforeCreateQuoteVersion(QuoteVersionContextInfo context)

Called when a user is creating a new quote version.
The version does not exist in database at this time; any changes in the returned QuoteVersionResponseInfo will be saved and the GUI updated.

* [QuoteVersionContextInfo][5] context: The quote and its parts.

Returns: [QuoteVersionResponseInfo][6] An updated quote version. If returns IsOk = false, then quoteversion creation is aborted.

## QuoteAlternativeResponseInfo OnBeforeCreateQuoteAlternative(QuoteAlternativeContextInfo context)

Called when a user is creating a quote alternative.
The quote alternative does not exist in database at this time; any changes in the returned Quote alternative will be saved and the GUI updated.

* [QuoteAlternativeContextInfo][4] context: The quote and its parts.

Returns: [QuoteAlternativeResponseInfo][7] An updated quote alternative. If returns IsOk = false, then quote alternative creation is aborted.

## void OnAfterSaveQuote(QuoteAlternativeContextInfo context)

Called after a sale containing a quote is saved or created. (Notice that new items have now gotten their ids in the CRM system.)

* [QuoteAlternativeContextInfo][4] context: The quote and its parts. The context is read-only. The records have been written to the database.

## void OnBeforeDeleteQuote(QuoteInfo quote, ISaleInfo sale, IContactInfo contact)

Called before a sale containing a quote is deleted.
Clean up in the ERP system, if needed.

The connector cannot stop the quote being deleted in the CRM system.

* quote: The Quote being deleted
* sale: The sale the quote belongs to
* contact: The main contact on the sale

## QuoteSentResponseInfo OnAfterSentQuoteVersion(QuoteVersionContextInfo quoteContext)

Called after a quote version is sent to the user's customer.

You may do extra work and return the modified the Quote Version info, but you cannot
abort the sending process. Any mail or document generation in SuperOffice is
independent of the connector.

* quoteContext: The Quote Version that was sent to the customer
Returns: URL and/or modified quote version info.

## ListItemInfo[] GetQuoteList(string quoteListType)

Gets a named list from the connector.

There are a few lists in the ERP system that we would like to show to the users:
payment terms and types, delivery terms and types, and product classifications (product category, product family and product type).

These lists can be supplied by the ERP connector using this interface.
SuperOffice will take these values and convert the simple flat list of values into a SuperOffice list that appears in the GUI.

If the ERP connector wants to supply a more complex nested list, then the ERP connector can implement a full MDO Provider.

There are some lists in the system we would like the ERP system to provide data for, if it can:

* ProductCategory
* ProductFamily
* ProductType
* PaymentTerms
* PaymentType
* DeliveryTerms
* DeliveryType

If a quote list is NULL, then the GUI will fall back to a text input field, where the user can enter text. This text is passed to the ERP plugin unchanged.

The Quote configuration API may also refer to custom list names which will be filled in by asking here.
I.e. you will be asked for more lists than just the ones mentioned here, if you have added custom lists to the configuration dialog.

* quoteListType: The quoteListType parameter is case insensitive.

Returns: Return array of QuoteListItems. Return NULL if the given list is not supported.

## int GetNumberOfActivePriceLists(string isoCurrencyCode)

Is used to warn the user if there is no active price lists in a given currency.

* isoCurrencyCode: Iso currency code like: USD or NOK. Case insensitive.
Returns:
Return all price lists if isoCurrencyCode is empty.
Return an empty array if there is no PriceList with the stated currency available.

## PriceListInfo[] GetActivePriceLists(string isoCurrencyCode)

Used by the admin client.
Gets the available active PriceLists in a specific currency.

* isoCurrencyCode: Iso currency like: USD or NOK. Case insensitive.

Returns:
Return empty array if there is no PriceList available in the currency.
Return all price lists if isoCurrencyCode is empty.

## PriceListInfo[] GetAllPriceLists(string isoCurrencyCode)

Called when creating quotes.
Gets the all PriceLists in the given currency, including those inactive.

* isoCurrencyCode: Iso currency like: USD or NOK. Case insensitive.

Returns:
Return empty array if there is no PriceList available.
Return all price lists if isoCurrencyCode is empty.

## ProductInfo[] FindProduct(QuoteAlternativeContextInfo context, string currencyCode, string userinput, string priceListKey)

The connector should treat this as a freetext search, the user might want to enter several words
and expect the system to search for through several fields like name, description, product code, extrafields, etc.

Since the return list is a potentially large return value, the connector or the ERP system should
limit the number of matches returned to a few hundred.

The fast searcher in the add product dialog calls this function to populate the dropdown list.

* context:
* currencyCode:
* userinput:
* priceListKey: If the price list is empty, the function will search in all active price  lists.

Returns: An array of products matching the search words

## ProductInfo GetProduct(QuoteAlternativeContextInfo context, string erpProductKey)

Gets a product based on erpProductKey. When the user picks a product from the result of a find,
the quote system converts the search info to a product.

* context: the quote alternative
* erpProductKey: the product id to get details on.

If the argument is null or empty, the function will throw an ArgumentException.
If the product is not found, the function will throw an Exception.

Returns: Returns the product info with the specified key.

## ProductInfo[] GetProducts(QuoteAlternativeContextInfo context, string[] erpProductKeys)

See `GetProduct` above for details

* context: the quote alternative
* erpProductKey: the product id to get details on.

Returns: Return products based on an array of unique ERP keys; handy when you’ve found products through archive providers or other mechanisms that leave you holding an ERPKey

## QuoteLineInfo[] GetQuoteLinesFromProduct(QuoteAlternativeContextInfo context, string erpProductKey)

Given a product ERP Key, return one or more quote lines with the product data filled in, and some default values, typically quantity set to 1 (but not necessarily!)
The quoteLineId will be provided by SuperOffice later.

* erpProductKey: id of the product selected in the find dialog or dropdown list.
* context: the quote alternative the quote is being added to.

Returns: Return the QuoteLine(-s) with the product info filled in.
Only the first non-null quoteline returned is added.
The ERP Product Key must be filled in in the return value.
The ERP price list id should also be filled in.

If the erpProductKey is null or empty, the function will throw an ArgumentException.
If the product is not found, the function will throw an Exception.

## int GetNumberOfProductImages(string erpProductKey)

Gets the number of images available for this product

* erpProductKey: id of the product

Returns: Count of images on the product. 0 if no images.

## string GetProductImage(string erpProductKey, int rank)

Gets the full size picture of the given product.

* erpProductKey:
* rank: Which of the images to return, will in the first version only ask for the first.

If the erpProductKey is null or empty, the function will throw an ArgumentException.
If the product is not found, the function will throw an Exception.

Returns:
Returns the full size picture of the given product.
Return NULL if no picture available.

## ProductInfo[] GetSearchResults(SearchRestrictionInfo[] restrictions)

Get metadata about the fields that can be used as search criteria. Note that
they do not have to be the same as the fields in the ProductInfo structure;
but erpPriceListKey has to be supported.

There are three levels of searching:

a) Quick search through IProductProvider.FindProduct - this is mandatory for all connectors that provide products
b) Advanced search through IProductSearchProvider - this is optional, and implements are more generic search, but still with a fixed result type (ProductInfo array)
c) Implement an Archive Provider called FindProduct&lt;Your connector name&gt; - this is a fully custom provider that can do whatever it wants, but it has to support a minimal result and restriction column set.

This interface defines alternative **b)** of the above list.

* restrictions: Array of restrictions chosen by the user; see `SearchRestrictionInfo` for details

Returns: Array (possibly empty) of hits, populated as fully as reasonably possible (should follow same policy as `FindProducts`).

## FieldMetadataInfo[] GetSearchableFields()

Returns: Metadata structures describing the searchable fields for the restrictions used in `GetSearchResults` above.

Perform the advanced search and return results

## QuoteLineInfo OnQuoteLineChanged(QuoteAlternativeContextInfo context, QuoteLineInfo ql, string[] changedFields)

Called when the user has changed a field in the Quote Line.
The QuoteContext is readonly; QuoteLine may be changed in the return value.
Response time must be fast since this method is called often (every time a field is changed).

The connect can signal errors or warnings by setting the `QuoteLineInfo.Status` and `QuoteLineInfo.Reason` fields.
This information will be displayed in the Quote Line dialog and in the quote-line archive.

* context: The alternative this quoteline belongs to
* ql: The changed quoteline
* changedFields: List of fields that were changed, in the format: "TableName.FieldName"

Returns: The updated quote line

## QuoteAlternativeWithLinesInfo RecalculateQuoteAlternative(QuoteAlternativeContextInfo context)

The user is finished with entering the quotelines, and wants to calculate the order discount (alternative discount)
on this alternative.
This method is called whenever the quote lines are changed in the alternative, or when the user clicks the RECALCULATE button.

The connector may signal problems with the quote by setting the  Quote Alternative Status
to Error, Warning or OkWithInfo, and fill in the alternative's Reason field with an explanation.

Use `QuoteCalculation.CalculateQuoteAlternativeWithLines` helper to help you calculate amounts.

* context: The context as it appears to the user

Returns: The updated alternative

## QuoteResponseInfo ValidateQuoteVersion(QuoteVersionContextInfo context, QuoteAction action)

Validates the version, looks for problems. Will typically change the Status and Reason fields, possibly change the State to NeedsApproval. Should validate all the alternatives in the context and their quote-lines.

The user is finished with entering the quote-lines, and wants to prepare the sending of the quote.
This method gives the ERP system a chance to enforce its business rules.

This method is called whenever the user clicks the SEND button, the PLACE ORDER or closes the quote dialog.

Quote Lines, Alternatives, Version and Quote fields can be changed in the return value. Changed values are stored in SuperOffice copy of the quote.

Use `QuoteCalculation.CalculateVersionWithAlternatives` to help you calculate amounts.

Validation should not change the prices on quotelines - it should ensure conformance to business rules.

A draft quote version will have state = `QuoteVersionStateInfo.DraftNotCalculated` when called.
The connector should set the version state to `QuoteVersionStateInfo.DraftCalculated`
if the calculations were successful. Leave the state as DraftNotCalculated if the ERP system was not available or some other factor that made the calculation unsuccessful.

The connector can trigger the approval workflow by setting the state to `QuoteVersionStateInfo.DraftNeedsApproval`. When a user with the approval permission
has approved or rejected the quote, the quote version state will be `QuoteVersionStateInfo.DraftApproved` or `QuoteVersionStateInfo.DraftNotApproved`.

Note that recalculate may also be called when the quote is Approved, or Archived.  In these cases, please leave the quote version state alone.

The connector may signal problems with the quote by setting the Quote Version Status
to Error, Warning or OkWithInfo, and fill in the version's Reason field with an explanation.

The [QuoteConnectorBase][9] implementation of this method defines methods for validating - see `QuoteConnectorBase.ValidateQuoteLine`.

* context: The context as it appears to the user
* action: The action that started this call; the context it is called in, like place order or send quote

Returns: The updated Context, with changes to State and UserExplanation if needed.

## QuoteVersionResponseInfo UpdateQuoteVersionPrices(QuoteVersionContextInfo context, HashSet< string > writeableFields)

Fetch new prices from the price list for all the alternatives in the quote.
This method is explicitly triggered by the user clicking the UPDATE PRICES button in the quote dialog.

The connector should update all the quotelines on all the alternatives with new list prices, minimum prices, cost prices, etc from the price list, and update the ERP discount suggestions.

The system will call `ValidateQuoteVersion` after calling this method to determine the new version state.

* context: The quote version, with alternatives and quote lines
* writeableFields: Collection of quoteline field names that are writeable according to the QuotelineConfiguration table. Field names are all lowercase.

Returns: Updated quote version, with alternatives and quote lines.

## PlaceOrderResponseInfo PlaceOrder(QuoteAlternativeContextInfo context)

Some ERP systems will be able to turn quotes into orders. The user selects a quote alternative to send to  the ERP system and clicks OK in the CREATE ORDER dialog.
After the Quote has been accepted/sold, then the user can check the delivery status with the ERP system.

Place the order in the ERP system.
If the operation returns successfully, the Quote will be locked (completed) in the CRM system
and all updates will come from the ERP system thru the GetOrderState function.

Requires that the Create-Order capability is true. If the Create-Order capability is false, then this
function is not called.

* context: The selected Quote Alternative, along with the version and lines

Returns: The context, with any updates. The ERPOrderKey should be filled in with the id of the generated order.

If the returned state in not OK, then the PlaceOrder call is aborted and the error message displayed.

## OrderResponseInfo GetOrderState(QuoteAlternativeContextInfo context)

After the order is created in the ERP system and the user wants to see what the current state of
the order is this function gets called.

This new version will be displayed in the GUI.

Requires that the Order-State capability is true.

* context: the quote alternative that was placed as an order

Returns:
If nothing has changed it should return null.
To create a new QuoteVersion, set OrderResponseInfo.CRMQuoteVersion.QuoteVersionId to 0, and return a new version with a new alternative and quotelines describing the current state.

## AddressInfo[] GetAddresses(QuoteAlternativeContextInfo context)

Returns two addresses:

* \[0\] = the invoice address.
* \[1\] = the delivery address.

The addresses are used in the generated quote document.

* context: the quote alternative being sent or placed as an order

Returns: Returns null if no address was found.

<!-- Referenced links -->
[1]: http://www.currency-iso.org/dl_iso_table_a1.xls
[2]: data-carriers/fieldmetadatainfo.md
[3]: data-carriers/quoteconnectioninfo.md
[4]: data-carriers/quotealternativecontextinfo.md
[5]: data-carriers/quoteversioncontextinfo.md
[6]: data-carriers/quoteversionresponseinfo.md
[7]: data-carriers/quotealternativeinfo.md
[8]: iproductregistercache.md
[9]: quoteconnectorbase.md
[10]: ../capability-names.md
