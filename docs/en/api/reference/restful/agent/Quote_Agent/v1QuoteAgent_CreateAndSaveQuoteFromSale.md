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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CopyFromSaleId": 430,
  "CopyToSaleId": 220
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 300,
  "SaleId": 195,
  "QuoteConnectionId": 251,
  "ERPQuoteKey": "tenetur",
  "ERPOrderKey": "aut",
  "ActiveQuoteVersionId": 743,
  "AcceptedQuoteAlternativeId": 38,
  "UseValuesFromQuote": 953,
  "DocumentId": 117,
  "PoNumber": "1223422",
  "OrderComment": "necessitatibus",
  "PreferredEmailCulture": "halle@parker.name",
  "QuoteVersions": [
    {
      "QuoteVersionId": 530,
      "ERPQuoteVersionKey": "dignissimos",
      "QuoteId": 99,
      "Description": "Horizontal contextually-based service-desk",
      "Number": "677558",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 904,
      "SentDate": "1999-12-23T16:54:56.1524506+01:00",
      "FollowupId": 271,
      "ExpirationDate": "1999-09-24T16:54:56.1524506+02:00",
      "DeliveryCountryId": 1000,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 126,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "qui",
      "ERPPaymentTypeKey": "itaque",
      "ERPDeliveryTermsKey": "possimus",
      "ERPDeliveryTypeKey": "assumenda",
      "Rank": 327,
      "ApprovedBy": 395,
      "ApprovedText": "explicabo",
      "ApprovedRegisteredBy": 328,
      "ApprovedRegisteredDate": "2005-07-02T16:54:56.1524506+02:00",
      "ExtraField1": "est",
      "ExtraField2": "odit",
      "ExtraField3": "sapiente",
      "ExtraField4": "voluptatem",
      "ExtraField5": "asperiores",
      "LastRecalculated": "2005-12-06T16:54:56.1524506+01:00",
      "Updated": "2001-08-11T16:54:56.1524506+02:00",
      "UpdatedAssociateId": 700,
      "Registered": "1998-05-11T16:54:56.1524506+02:00",
      "RegisteredAssociateId": 519,
      "RequestAssociateId": 319,
      "RequestComment": "cupiditate",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 948
    }
  }
}
```