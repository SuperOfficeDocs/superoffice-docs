---
title: POST Agents/Quote/CreateAndSaveQuote
uid: v1QuoteAgent_CreateAndSaveQuote
generated: true
---

# POST Agents/Quote/CreateAndSaveQuote

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuote
```

Creates a new quote on a sale.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuote?$select=name,department,category/id
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

SaleId, ConnectionId, FirstAlternativeName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | Integer |  |
| ConnectionId | Integer |  |
| FirstAlternativeName | String |  |

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
POST /api/v1/Agents/Quote/CreateAndSaveQuote
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleId": 493,
  "ConnectionId": 515,
  "FirstAlternativeName": "Jaskolski-Prohaska"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 570,
  "SaleId": 809,
  "QuoteConnectionId": 334,
  "ERPQuoteKey": "tempore",
  "ERPOrderKey": "rerum",
  "ActiveQuoteVersionId": 592,
  "AcceptedQuoteAlternativeId": 240,
  "UseValuesFromQuote": 953,
  "DocumentId": 188,
  "PoNumber": "1042488",
  "OrderComment": "vero",
  "PreferredEmailCulture": "albertha@moen.co.uk",
  "QuoteVersions": [
    {
      "QuoteVersionId": 168,
      "ERPQuoteVersionKey": "mollitia",
      "QuoteId": 434,
      "Description": "Re-contextualized exuding installation",
      "Number": "1548824",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 481,
      "SentDate": "1999-08-12T13:14:01.0020135+02:00",
      "FollowupId": 964,
      "ExpirationDate": "2020-01-09T13:14:01.0020135+01:00",
      "DeliveryCountryId": 700,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 15,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "voluptatem",
      "ERPPaymentTypeKey": "et",
      "ERPDeliveryTermsKey": "ut",
      "ERPDeliveryTypeKey": "voluptas",
      "Rank": 320,
      "ApprovedBy": 561,
      "ApprovedText": "nobis",
      "ApprovedRegisteredBy": 980,
      "ApprovedRegisteredDate": "2006-02-27T13:14:01.0020135+01:00",
      "ExtraField1": "quasi",
      "ExtraField2": "tempore",
      "ExtraField3": "soluta",
      "ExtraField4": "sed",
      "ExtraField5": "perspiciatis",
      "LastRecalculated": "2015-05-28T13:14:01.0020135+02:00",
      "Updated": "2017-07-19T13:14:01.0020135+02:00",
      "UpdatedAssociateId": 223,
      "Registered": "2009-01-11T13:14:01.0020135+01:00",
      "RegisteredAssociateId": 560,
      "RequestAssociateId": 496,
      "RequestComment": "quo",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 471
    }
  }
}
```