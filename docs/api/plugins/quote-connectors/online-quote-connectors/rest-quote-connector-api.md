---
title: Online REST quote connector API
uid: quote_connector_rest_api
description: Online REST quote connectors
author: xt1
keywords: quote
---

# Online REST quote connector API

**In Development, currently unavailable.**

The REST API is similar to the [SOAP API](soap-quote-connector-api.md) - it mostly mirrors the C# [IQuoteConnector interface](../api/iquoteconnector.md).

[Quote Connector Swagger v3 JSON definition](../media/QuoteConnector-swagger.json) - you can use this to generate a server in the language of your choice.

[Sample API JSON requests and responses](rest-quote-connector-samples.md) - this gives you an insight into what requests from SuperOffice to the connector look like, and how your quote connector service should respond to requests.

## REST Connectors are Online apps

Your connector is an app with an app registration.
Part of the app registration is what base URL to call.

When configuring a connection in the maintenance panel, you can specify a shared secret
for authentication, or leave it blank to use JWT authentication.

## REST Quote Connector Authentication

The REST Quote Connector supports one of multiple authentication methods:

* Shared Secret token - NetServer sends the Secret as a BASIC auth with username = tenant, password = shared secret.
* Shared Secret JWT - NetServer signs a JWT with the Secret, and uses the JWT as a bearer token.
* OAuth Bearer token from the partner's IdP - TBD

Validity can be determined based on the tenant id + shared secret value, or on the claims contained in the JWT.

The connector returns `string` containing access token that can be used as bearer token on behalf of user, or return HTTP 401 Unauthorized or 403 Forbidden.


### Shared Secret Basic Authentication 

You configure the shared secret as a property on the quote connection in the SuperOffice
admin client.

SuperOffice calls the connctor API with BASIC authentication where the password is
a shared secret defined on the connection.

### JWT Bearer Authentication

The tenant + user information will be contained in the JWT - we just need to verify that the signature is correct before we can trust it.

The JWT Authenticate middleware looks at the JWT value, decodes the JWT and validates the signature against the environment's public key.

If the signature is valid (i.e. signed with the environment's private key), then we accept the JWT and allow the call.

### Quote Connector re-authentication

If the quote connector responds with **401 Unauthorized** or **403 Forbidden**, then the REST quote plugin in the fileset will try to generate a fresh JWT and then retry the call to the service.

The client will retry once with a fresh JWT.

## Quote Connector missing methods

If the REST quote plugin tries to call an endpoint and receives an HTTP error of **404 NotFound** or **410 Gone** then the endpoint is flagged as not-implemented, and subsequent calls to the endpoint are skipped.

This avoids unnecessary calls to the service, and improves performance.

## Quote Connector endpoints

All of these require a HTTP `Authenticate` header with a `Basic` username + shared secret, `Bearer` JWT signed with the shared secret.

Invalid access tokens must be rejected with a 401 HTTP error, which will trigger a re-authenticate on the client side.

The client will retry once with a fresh JWT.

## Quote Connector parameters

In addition to the parameters specified in the interface, the POST body will also include 

* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Example:
```json
```

## `POST baseUrl/GetConfigurationFields`

Called when configuring/editing a connection.

Returns [`Dictionary<string, FieldMetadataInfo>`](../api/data-carriers/fieldmetadatainfo.md) containing the fields you want the user to edit/set on the connection.

The values are stored in the fileset's connection and passed in subsequent calls.

The fields are displayed in the configuration dialog in the admin client.
The values the user inputs are stored in SuperOffice and passed along as ConfigValues in
subsequent calls to the REST connector.

## `POST baseUrl/TestConnection`

* Dictionary< string,string > `ConnectionData` - configuration values

Called when the TEST button or saving a connection.

Returns [`PluginResponseInfo`](../api/data-carriers/pluginresponseinfo.md) containing Ok if the test went well, or error message if connection is configured correctly.

See the [sample request](./rest-quote-connector-samples.md#post-testconnection)

## `POST baseUrl/GetCapabilities`

We have the [common capabilities](../capability-names.md) and a couple of extra online-specific capabilities.

Capabilities are fetched once per user, and then cached for 30 minutes.

Standard capabilites:

* `iproductprovider_provide_cost` Determines if the Cost and Earning field is shown in the GUI.
* `iproductprovider_provide_minimumprice` Determines if the Minimum Price field is shown in the GUI, and if the minimum price is checked against the list price field. 
* `iproductprovider_provide_stockdata` Determines whether the inStock values are shown in the GUI or not
* `iproductprovider_provide_extradata` Determines if the extra data fields are shown in the GUI.
* `iproductprovider_provide_picture` If this is FALSE, then the picture in the quote line dialog is not shown.
* `iorderconsumer_send_order_confirm` If the capability is FALSE, then the E-MAIL section of the PLACE ORDER dialog is shown.
* `iorderconsumer_place_order` If not then the PlaceOrder method is not called. The PLACE ORDER button is still shown.
* `iorderconsumer_provide_orderstate` If the capability is FALSE, then no GET STATUS button appears after an order has been placed in the ERP system.
* `ilistprovider_provide_productcategorylist` Can the connector provide the Product category list?
* `ilistprovider_provide_productfamilylist` Can the connector provide the Product family list?
* `ilistprovider_provide_producttypelist` Can the connector provide the Product type list?
* `ilistprovider_provide_paymenttermslist` Can the connector provide the Payment terms list?
* `ilistprovider_provide_paymenttypelist` Can the connector provide the Payment type list?
* `ilistprovider_provide_deliverytermslist` Can the connector provide the Delivery terms list?
* `ilistprovider_provide_deliverytypelist` Can the connector provide the Delivery type list?
* `iconnector_perform_complexsearch` Can the connector provide the &quot;Advanced Search&quot; feature (magnifying glass next to search field, leading to a full Find dialog) - implies GetSearchableFields impl.
* `iaddressprovider_provide_addresses` If the capability is TRUE; then the quote will use the delivery and invoice addresses provided by the connector.

Online extra capabilities:

* `cache-pricelists` Can the quote engine cache the pricelists to increase performance?
* `no-cache-quotelists` Turn off caching of *ilistprovider_* lists - make every list request call the remote service.

Return a dictionary of capabilities mapped to boolean values.

See the [sample request](./rest-quote-connector-samples.md#post-getcapabilities)

## Lists
### `POST baseUrl/GetQuoteList` 

* string QuoteListType - List name
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Lists are fetched from the remote service unless the corresponding capability has been turned off.
Built-in MDO lists (like "category" or "associate") are not fetched from the remote service.

If the capability `no-cache-quotelists` is false, then lists are cached for 30 minutes per user after the first fetch for improved performance on the client.


## Pricelists

Pricelists are active or inactive, and have valid-from and -to dates.

The capability `cache-pricelists` controls caching on the client side. If this capability is true, the the client does not have to call on the connector to load the pricelist
info as often.

### `POST baseUrl/GetAllPriceLists`

* `string` IsoCurrencyCode - currency from Sale. "NOK" or "USD" etc.

Return all the pricelists, active or inactive for a give currency.

If capability `cache-pricelists` is true, then list of pricelists is cached for 30 minutes on the client side.

### `POST baseUrl/GetActivePriceLists`

* `string` IsoCurrencyCode - currency from Sale
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Return only the active pricelists for a given currency. If no pricelists are returned, then the connector cannot be used to create a quote for this sale.

If capability `cache-pricelists` is true, then list of pricelists is cached for 30 minutes on the client side.

See the [sample request](./rest-quote-connector-samples.md#post-getactivepricelists)

## Address info

### `POST baseUrl/GetAddresses`

* [`QuoteAlternativeContextInfo`](../api/data-carriers/quotealternativecontextinfo.md) Context - information about the quote alternative.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Return custom billing/shipping addresses for the quote.
Requires `iaddressprovider_provide_addresses` capability.

Returns `AddressInfo[]` - array of addresses.

* First element is QuoteBillingAddress
* Second element is QuoteShippingAddress

## Events

 Quote events are triggered by user actions.
 The quote service receives a copy of the quote and returns a possibly modified copy of the quote state.

### `POST baseUrl/OnBeforeCreateQuote`

* [`QuoteAlternativeContextInfo`](../api/data-carriers/quotealternativecontextinfo.md) Context -  information about the quote with a single alternative.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

 Called when the user creates a quote, before the quote has been saved to the database.

See the [sample request](./rest-quote-connector-samples.md#post-onbeforecreatequote)

### `POST baseUrl/OnBeforeCreateQuoteVersion`

* [`QuoteVersionContextInfo`](../api/data-carriers/quoteversioncontextinfo.md) QuoteContext - the quote with a version and all its alternatives.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Called when the user creates a new version - and the initial version when creating a new quote, before the version has been saved to the database.

### `POST /OnBeforeCreateQuoteAlternative`

* [`QuoteAlternativeContextInfo`](../api/data-carriers/quotealternativecontextinfo.md) Context - information about the quote with a single alternative.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Called when the user creates a new alternative within a version, and the initial alternative when creating a new quote.

### `POST /OnBeforeDeleteQuote` 

* `IContactInfo3` Contact - company information including custom fields.
* `ISaleInfo3` Sale - sale information that quote belongs to, including custom fields.
* `QuoteInfo` Quote - quote information that is being deleted.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Called when the quote is about to be deleted, so that the service can mark the ERP quote as deleted.

No return value.

### `POST /OnAfterSentQuoteVersion`

* `QuoteVersionContextInfo` QuoteContext - information about the quote with a version and all its alternatives.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Returns [`QuoteSentResponseInfo`](../api/data-carriers/quotesentresponseinfo.md) - status on if quote was published in ERP.

### `POST /OnQuoteLineChanged`

* `QuoteAlternativeContextInfo` Context - information about the quote with a version and all its alternatives.
* `QuoteLineInfo` QuoteLine - the quoteline that was changed
* `string[]` ChangedFields - list of fields that were modified.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Called whenever the user modifies a field on a quoteline.
You must implement sub-total and discount calculations. You can set quoteline status and reason to report errors.
If not implemented (server returns 404 NotFound) then default quoteline calculations are applied.

Returns [`QuoteLineInfo`](../api/data-carriers/quotelineinfo.md) - updated quoteline.
Return null to apply default quoteline calculations instead.

## Product info

### `POST /FindProduct`

* `QuoteAlternativeContextInfo` Context - information about the quote alternative.
* `string` CurrencyCode - NOK or SEK from the sale.
* `string` UserInput - what the user typed into the search field
* `string` PriceListKey - blank if no pricelist chosen, otherwise a pricelist key "PLXYZ".
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Called when user has typed something into the search field at the top of the add product dialog.

Returns [`ProductInfo[]`](../api/data-carriers/productinfo.md) - array of matching products.

### `POST /GetProduct`

* `QuoteAlternativeContextInfo` Context - information about the quote alternative.
* `string` ErpProductKey - product key found earlier.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Returns `ProductInfo` - details on the selected product

### `POST /GetProducts`

* `QuoteAlternativeContextInfo` Context - information about the quote alternative.
* `string[]` ErpProductKeys - product keys found earlier.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

 
Returns `ProductInfo[]` - details on the selected products

### `POST /GetQuoteLinesFromProduct`

* `QuoteAlternativeContextInfo` Context - information about the quote alternative.
* `string` ErpProductKey - product key found earlier.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Called when user selects a product from the search result. The result is added to the quote.

Returns `QuoteLineInfo[]` - details on the selected products. A single product can turn into multiple quote lines.

### `POST /GetNumberOfProductImages`

* `string` ErpProductKey - product id.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Returns `int` - number of images. 0 or 1 or more.

### `POST /GetProductImage`

* `string` ErpProductKey - product id
* `ìnt` Rank - image number
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Get the image URL or Base64 encoded image data for a product. Called when displaying product details in the quoteline dialog.

Returned value is cached on the client to improve performance.

Returns `string` - Base64 encoded image or URL to image.

## Advanced Search

### `POST /GetSearchableFields`

* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Called when advanced search is clicked. Advanced search requires the `iconnector_perform_complexsearch`  capability.

The result is cached in the fileset per connection, since the set of searchable fields should not change from minute to minute.
 
Returns `FieldMetadataInfo[]` - list of fields and how to use them in search.

### `POST /GetSearchResults`

* `SearchRestrictionInfo[]` Restrictions - search field values and operators.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Returns `ProductInfo[]` - search matches.

## Calculations

If the endpoint is not implemented or returns NULL, then the default QuoteConnector calculations are used instead.

Returning HTTP 404 NotFound flags the endpoint as missing, and stops further calls to the endpoint. The default QuoteConnector is then called directly, skipping the round-trip to the Quote Connector service.

### `POST /RecalculateQuoteAlternative`

* `QuoteAlternativeContextInfo` Context - information about the quote alternative.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Calculate new values on the quote alternative. Called after quote lines are added.

If not implemented, then defaults to SuperOffice connector calculations.

Returns [`QuoteAlternativeWithLinesInfo`](../api/data-carriers/quotealternativewithlinesinfo.md) - updated quote lines and alternative.

### `POST /ValidateQuoteVersion`

* `QuoteVersionContextInfo` QuoteContext - information about the quote with a version and all its alternatives.
* `QuoteAction` action - what the user is requesting:  Validate(1), Send(2), PlaceOrder(3), UpdatePrice(4)
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Allows the connector to verify that the quote is in the correct state to perform the action.
If the returned status is nok ok, then the action is blocked and an error dialog shown.

Returns `QuoteResponseInfo` - returns updated quote and status values. 

### `POST /UpdateQuoteVersionPrices`

* `QuoteVersionContextInfo` QuoteContext - information about the quote with a version and all its alternatives.
* `string[]` WriteableFields - list of fields that connector is allowed to update.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Update price on the all the quotelines for each alternative in the current quote version.
If not implemented, then default implementation does nothing.

Returns `QuoteVersionResponseInfo` - updated quote information.

## Ordering

### `POST /PlaceOrder`

* `QuoteAlternativeContextInfo` Context - information about the quote alternative.
* `dictionary<string,string>` ConfigValues - dictionary containing the configuration settings for the connection.
* `object` ConnectionInfo - object containing the connection id, and related ERP Sync connection info, if any.

Turn the quote into an order.
Called when the user clicks the PLACE ORDER button.
Requires the `iorderconsumer_place_order` capability.

Returns `PlaceOrderResponseInfo` - if the order placement went ok. 
 
### `POST /GetOrderState`

* `QuoteAlternativeContextInfo` Context - information about the quote alternative.

How is the order we placed doing?
Displays result in UI.
Requires `iorderconsumer_provide_orderstate` capability.

Returns [`OrderResponseInfo`](../api/data-carriers/orderresponseinfo.md) - ok or error status.

