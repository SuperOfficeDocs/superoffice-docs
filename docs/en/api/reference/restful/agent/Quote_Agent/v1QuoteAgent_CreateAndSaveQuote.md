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
  "SaleId": 10,
  "ConnectionId": 385,
  "FirstAlternativeName": "Treutel, Schmidt and Tremblay"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 161,
  "SaleId": 891,
  "QuoteConnectionId": 110,
  "ERPQuoteKey": "asperiores",
  "ERPOrderKey": "placeat",
  "ActiveQuoteVersionId": 616,
  "AcceptedQuoteAlternativeId": 754,
  "UseValuesFromQuote": 866,
  "DocumentId": 63,
  "PoNumber": "1796839",
  "OrderComment": "numquam",
  "PreferredEmailCulture": "leon.pfeffer@medhurst.uk",
  "QuoteVersions": [
    {
      "QuoteVersionId": 407,
      "ERPQuoteVersionKey": "est",
      "QuoteId": 112,
      "Description": "Seamless local local area network",
      "Number": "706938",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 427,
      "SentDate": "2001-10-20T12:19:46.1014395+02:00",
      "FollowupId": 101,
      "ExpirationDate": "2023-02-17T12:19:46.1014395+01:00",
      "DeliveryCountryId": 112,
      "HasOwnDeliveryAddress": true,
      "InvoiceCountryId": 269,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "eveniet",
      "ERPPaymentTypeKey": "adipisci",
      "ERPDeliveryTermsKey": "sed",
      "ERPDeliveryTypeKey": "soluta",
      "Rank": 635,
      "ApprovedBy": 773,
      "ApprovedText": "qui",
      "ApprovedRegisteredBy": 750,
      "ApprovedRegisteredDate": "1999-09-06T12:19:46.1014395+02:00",
      "ExtraField1": "nihil",
      "ExtraField2": "sed",
      "ExtraField3": "dolorum",
      "ExtraField4": "commodi",
      "ExtraField5": "qui",
      "LastRecalculated": "2022-02-19T12:19:46.1014395+01:00",
      "Updated": "1999-12-18T12:19:46.1014395+01:00",
      "UpdatedAssociateId": 529,
      "Registered": "2020-06-11T12:19:46.1014395+02:00",
      "RegisteredAssociateId": 957,
      "RequestAssociateId": 510,
      "RequestComment": "eaque",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 886
    }
  }
}
```