---
title: POST Agents/Quote/GetQuoteEntityFromSaleId
uid: v1QuoteAgent_GetQuoteEntityFromSaleId
generated: true
---

# POST Agents/Quote/GetQuoteEntityFromSaleId

```http
POST /api/v1/Agents/Quote/GetQuoteEntityFromSaleId
```

Get a Quote for a sale







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteEntityFromSaleId?$select=name,department,category/id
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

SaleId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | Integer |  |

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
POST /api/v1/Agents/Quote/GetQuoteEntityFromSaleId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleId": 518
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 624,
  "SaleId": 183,
  "QuoteConnectionId": 640,
  "ERPQuoteKey": "qui",
  "ERPOrderKey": "fugiat",
  "ActiveQuoteVersionId": 326,
  "AcceptedQuoteAlternativeId": 901,
  "UseValuesFromQuote": 899,
  "DocumentId": 182,
  "PoNumber": "600203",
  "OrderComment": "qui",
  "PreferredEmailCulture": "joan_yundt@eichmann.com",
  "QuoteVersions": [
    {
      "QuoteVersionId": 620,
      "ERPQuoteVersionKey": "enim",
      "QuoteId": 9,
      "Description": "Organized explicit methodology",
      "Number": "114290",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 171,
      "SentDate": "2018-05-22T16:00:41.6644415+02:00",
      "FollowupId": 468,
      "ExpirationDate": "2004-01-02T16:00:41.6644415+01:00",
      "DeliveryCountryId": 383,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 806,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "vel",
      "ERPPaymentTypeKey": "praesentium",
      "ERPDeliveryTermsKey": "quis",
      "ERPDeliveryTypeKey": "adipisci",
      "Rank": 267,
      "ApprovedBy": 957,
      "ApprovedText": "praesentium",
      "ApprovedRegisteredBy": 894,
      "ApprovedRegisteredDate": "1998-04-08T16:00:41.6644415+02:00",
      "ExtraField1": "odio",
      "ExtraField2": "magni",
      "ExtraField3": "illo",
      "ExtraField4": "in",
      "ExtraField5": "eum",
      "LastRecalculated": "2017-11-23T16:00:41.6644415+01:00",
      "Updated": "2002-01-30T16:00:41.6644415+01:00",
      "UpdatedAssociateId": 435,
      "Registered": "1997-10-06T16:00:41.6644415+02:00",
      "RegisteredAssociateId": 550,
      "RequestAssociateId": 296,
      "RequestComment": "est",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 457
    }
  }
}
```