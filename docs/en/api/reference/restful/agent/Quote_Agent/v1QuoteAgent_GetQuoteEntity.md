---
title: POST Agents/Quote/GetQuoteEntity
uid: v1QuoteAgent_GetQuoteEntity
generated: true
---

# POST Agents/Quote/GetQuoteEntity

```http
POST /api/v1/Agents/Quote/GetQuoteEntity
```

Get a Quote







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteEntity?$select=name,department,category/id
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

QuoteId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteId | Integer |  |

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
POST /api/v1/Agents/Quote/GetQuoteEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 551
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 696,
  "SaleId": 649,
  "QuoteConnectionId": 614,
  "ERPQuoteKey": "aperiam",
  "ERPOrderKey": "tempore",
  "ActiveQuoteVersionId": 974,
  "AcceptedQuoteAlternativeId": 131,
  "UseValuesFromQuote": 519,
  "DocumentId": 257,
  "PoNumber": "823879",
  "OrderComment": "delectus",
  "PreferredEmailCulture": "mattie@boscogaylord.ca",
  "QuoteVersions": [
    {
      "QuoteVersionId": 493,
      "ERPQuoteVersionKey": "et",
      "QuoteId": 164,
      "Description": "Managed composite policy",
      "Number": "623419",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 798,
      "SentDate": "2023-07-22T12:57:34.7428121+02:00",
      "FollowupId": 845,
      "ExpirationDate": "2019-10-14T12:57:34.7428121+02:00",
      "DeliveryCountryId": 492,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 943,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "qui",
      "ERPPaymentTypeKey": "voluptatem",
      "ERPDeliveryTermsKey": "similique",
      "ERPDeliveryTypeKey": "provident",
      "Rank": 440,
      "ApprovedBy": 407,
      "ApprovedText": "eaque",
      "ApprovedRegisteredBy": 680,
      "ApprovedRegisteredDate": "2011-12-17T12:57:34.7428121+01:00",
      "ExtraField1": "omnis",
      "ExtraField2": "fuga",
      "ExtraField3": "est",
      "ExtraField4": "aliquid",
      "ExtraField5": "consequatur",
      "LastRecalculated": "2007-01-28T12:57:34.7428121+01:00",
      "Updated": "2006-01-16T12:57:34.7428121+01:00",
      "UpdatedAssociateId": 745,
      "Registered": "2000-11-08T12:57:34.7428121+01:00",
      "RegisteredAssociateId": 374,
      "RequestAssociateId": 557,
      "RequestComment": "voluptate",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 145
    }
  }
}
```