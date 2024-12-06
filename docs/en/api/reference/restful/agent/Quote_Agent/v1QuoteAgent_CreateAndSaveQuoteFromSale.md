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
  "CopyFromSaleId": 75,
  "CopyToSaleId": 490
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 679,
  "SaleId": 944,
  "QuoteConnectionId": 826,
  "ERPQuoteKey": "aut",
  "ERPOrderKey": "atque",
  "ActiveQuoteVersionId": 387,
  "AcceptedQuoteAlternativeId": 674,
  "UseValuesFromQuote": 738,
  "DocumentId": 514,
  "PoNumber": "1298584",
  "OrderComment": "molestias",
  "PreferredEmailCulture": "ronny_pfeffer@homenick.biz",
  "QuoteVersions": [
    {
      "QuoteVersionId": 618,
      "ERPQuoteVersionKey": "quia",
      "QuoteId": 79,
      "Description": "Virtual attitude-oriented hardware",
      "Number": "1571329",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "matrix killer communities",
      "LikelyQuoteAlternativeId": 712,
      "SentDate": "2022-04-07T10:17:55.9415595+02:00",
      "FollowupId": 949,
      "ExpirationDate": "2011-05-11T10:17:55.9415595+02:00",
      "DeliveryCountryId": 921,
      "HasOwnDeliveryAddress": true,
      "InvoiceCountryId": 919,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "reiciendis",
      "ERPPaymentTypeKey": "assumenda",
      "ERPDeliveryTermsKey": "rem",
      "ERPDeliveryTypeKey": "consequuntur",
      "Rank": 548,
      "ApprovedBy": 514,
      "ApprovedText": "sunt",
      "ApprovedRegisteredBy": 106,
      "ApprovedRegisteredDate": "2008-12-29T10:17:55.9415595+01:00",
      "ExtraField1": "sit",
      "ExtraField2": "expedita",
      "ExtraField3": "quam",
      "ExtraField4": "commodi",
      "ExtraField5": "harum",
      "LastRecalculated": "2009-05-09T10:17:55.9415595+02:00",
      "Updated": "2022-12-20T10:17:55.9415595+01:00",
      "UpdatedAssociateId": 705,
      "Registered": "2012-02-18T10:17:55.9415595+01:00",
      "RegisteredAssociateId": 27,
      "RequestAssociateId": 404,
      "RequestComment": "ut",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 843
    }
  }
}
```