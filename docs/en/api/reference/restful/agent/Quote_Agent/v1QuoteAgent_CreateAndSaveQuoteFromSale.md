---
title: POST Agents/Quote/CreateAndSaveQuoteFromSale
uid: v1QuoteAgent_CreateAndSaveQuoteFromSale
generated: true
---

# POST Agents/Quote/CreateAndSaveQuoteFromSale

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuoteFromSale
```

Creates a copy the active version with connected alternatives and quotelines from another sale.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuoteFromSale?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

CopyFromSaleId, CopyToSaleId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopyFromSaleId | Integer |  |
| CopyToSaleId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: QuoteEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteId | int32 | Primary key |
| SaleId | int32 | The foreign key to the corresponding sale |
| QuoteConnectionId | int32 | The connection in the CRM system to where this quote came from. Identifies the ERP connection used for this quote. Each quote is bound to one and only one connection. |
| ERPQuoteKey | string | Foreign key of quote (if available). The key in the ERP system that identifies this sale's Quote (as opposed to the later Order information) |
| ERPOrderKey | string | The key in the ERP system that identifies this sale's Order, as transferred and possibly later edited in the ERP system.  Only filled out if there exists a corresponding order representation of the quote in the ERP system. |
| ActiveQuoteVersionId | int32 | The primary key of the Quote Version that is currently active. (The active version will always be the latest version.) |
| AcceptedQuoteAlternativeId | int32 | The primary key of the Quote Alternative which was finally accepted by the customer. Set when the user is marking a quote as accepted. |
| UseValuesFromQuote | int32 | If true, then the Earning, Earning_Percent and Amount fields are populated from the QuoteVersion.QuoteAlternative (current revision, most-likely alternative). |
| DocumentId | int32 | The ID of the main Quote Document |
| PoNumber | string | Customer's Purchase order number |
| OrderComment | string | A comment that is intended for the Invoice, Order, Packing list and similar stages - AFTER the quote has become an order and goes to ERP for processing |
| PreferredEmailCulture | string | When emails are sent (offer or confirmation), a language can be chosen in the GUI; this field saves the most recent choice and can be used to default the next such choice. Default-default is user's current language |
| QuoteVersions | array | Array og QuoteVersions connected to the quote. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/CreateAndSaveQuoteFromSale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "CopyFromSaleId": 796,
  "CopyToSaleId": 984
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 75,
  "SaleId": 319,
  "QuoteConnectionId": 755,
  "ERPQuoteKey": "nam",
  "ERPOrderKey": "ut",
  "ActiveQuoteVersionId": 651,
  "AcceptedQuoteAlternativeId": 724,
  "UseValuesFromQuote": 644,
  "DocumentId": 449,
  "PoNumber": "930661",
  "OrderComment": "ullam",
  "PreferredEmailCulture": "anjali.schroeder@botsfordcollins.us",
  "QuoteVersions": [
    {
      "QuoteVersionId": 95,
      "ERPQuoteVersionKey": "eum",
      "QuoteId": 684,
      "Description": "Multi-layered foreground Graphic Interface",
      "Number": "949809",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 91,
      "SentDate": "2000-07-17T23:03:56.7936194+02:00",
      "FollowupId": 379,
      "ExpirationDate": "2021-11-12T23:03:56.7936194+01:00",
      "DeliveryCountryId": 696,
      "HasOwnDeliveryAddress": true,
      "InvoiceCountryId": 643,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "accusantium",
      "ERPPaymentTypeKey": "aut",
      "ERPDeliveryTermsKey": "vero",
      "ERPDeliveryTypeKey": "esse",
      "Rank": 592,
      "ApprovedBy": 168,
      "ApprovedText": "est",
      "ApprovedRegisteredBy": 816,
      "ApprovedRegisteredDate": "2015-02-21T23:03:56.7936194+01:00",
      "ExtraField1": "dolor",
      "ExtraField2": "rerum",
      "ExtraField3": "laudantium",
      "ExtraField4": "veritatis",
      "ExtraField5": "magnam",
      "LastRecalculated": "2006-08-21T23:03:56.7936194+02:00",
      "Updated": "2005-06-20T23:03:56.7936194+02:00",
      "UpdatedAssociateId": 18,
      "Registered": "2010-01-06T23:03:56.7936194+01:00",
      "RegisteredAssociateId": 947,
      "RequestAssociateId": 704,
      "RequestComment": "molestias",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 419
    }
  }
}
```