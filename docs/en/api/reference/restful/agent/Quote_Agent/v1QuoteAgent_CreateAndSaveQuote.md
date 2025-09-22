---
title: POST Agents/Quote/CreateAndSaveQuote
uid: v1QuoteAgent_CreateAndSaveQuote
generated: true
content_type: reference
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SaleId": 194,
  "ConnectionId": 133,
  "FirstAlternativeName": "Gislason, Steuber and Dickens"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 976,
  "SaleId": 841,
  "QuoteConnectionId": 598,
  "ERPQuoteKey": "sapiente",
  "ERPOrderKey": "aperiam",
  "ActiveQuoteVersionId": 354,
  "AcceptedQuoteAlternativeId": 41,
  "UseValuesFromQuote": 626,
  "DocumentId": 212,
  "PoNumber": "1326791",
  "OrderComment": "non",
  "PreferredEmailCulture": "jacques@olsonrenner.com",
  "QuoteVersions": [
    {
      "QuoteVersionId": 172,
      "ERPQuoteVersionKey": "minus",
      "QuoteId": 181,
      "Description": "Cross-group homogeneous contingency",
      "Number": "1085409",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 378,
      "SentDate": "2009-07-23T11:24:48.5313897+02:00",
      "FollowupId": 484,
      "ExpirationDate": "2018-12-18T11:24:48.5313897+01:00",
      "DeliveryCountryId": 8,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 402,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "sed",
      "ERPPaymentTypeKey": "laudantium",
      "ERPDeliveryTermsKey": "iure",
      "ERPDeliveryTypeKey": "sequi",
      "Rank": 284,
      "ApprovedBy": 249,
      "ApprovedText": "cumque",
      "ApprovedRegisteredBy": 346,
      "ApprovedRegisteredDate": "2019-05-16T11:24:48.5313897+02:00",
      "ExtraField1": "laborum",
      "ExtraField2": "maxime",
      "ExtraField3": "vel",
      "ExtraField4": "id",
      "ExtraField5": "dolores",
      "LastRecalculated": "2025-03-31T11:24:48.5313897+02:00",
      "Updated": "2001-01-03T11:24:48.5313897+01:00",
      "UpdatedAssociateId": 483,
      "Registered": "2010-05-29T11:24:48.5313897+02:00",
      "RegisteredAssociateId": 517,
      "RequestAssociateId": 160,
      "RequestComment": "mollitia",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 95
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 267
    }
  }
}
```