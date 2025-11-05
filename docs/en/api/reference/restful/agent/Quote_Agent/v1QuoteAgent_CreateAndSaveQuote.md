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


NsApiSlow threshold: 5000 ms.






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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 893,
  "ConnectionId": 994,
  "FirstAlternativeName": "Beahan, Friesen and Bechtelar"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 370,
  "SaleId": 404,
  "QuoteConnectionId": 117,
  "ERPQuoteKey": "rerum",
  "ERPOrderKey": "rerum",
  "ActiveQuoteVersionId": 832,
  "AcceptedQuoteAlternativeId": 844,
  "UseValuesFromQuote": 469,
  "DocumentId": 270,
  "PoNumber": "456101",
  "OrderComment": "nisi",
  "PreferredEmailCulture": "geraldine@schmittfahey.co.uk",
  "QuoteVersions": [
    {
      "QuoteVersionId": 794,
      "ERPQuoteVersionKey": "et",
      "QuoteId": 38,
      "Description": "Mandatory value-added instruction set",
      "Number": "975400",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 813,
      "SentDate": "2002-02-12T02:30:47.7413192+01:00",
      "FollowupId": 414,
      "ExpirationDate": "2024-03-24T02:30:47.7413192+01:00",
      "DeliveryCountryId": 702,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 293,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "cum",
      "ERPPaymentTypeKey": "magni",
      "ERPDeliveryTermsKey": "sunt",
      "ERPDeliveryTypeKey": "adipisci",
      "Rank": 109,
      "ApprovedBy": 648,
      "ApprovedText": "consequatur",
      "ApprovedRegisteredBy": 372,
      "ApprovedRegisteredDate": "2020-07-14T02:30:47.7413192+02:00",
      "ExtraField1": "in",
      "ExtraField2": "illum",
      "ExtraField3": "delectus",
      "ExtraField4": "magni",
      "ExtraField5": "reprehenderit",
      "LastRecalculated": "2004-09-25T02:30:47.7413192+02:00",
      "Updated": "2012-06-24T02:30:47.7413192+02:00",
      "UpdatedAssociateId": 924,
      "Registered": "2019-04-10T02:30:47.7413192+02:00",
      "RegisteredAssociateId": 522,
      "RequestAssociateId": 904,
      "RequestComment": "dignissimos",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 115
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 734
    }
  }
}
```