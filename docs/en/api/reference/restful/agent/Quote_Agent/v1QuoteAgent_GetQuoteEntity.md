---
title: POST Agents/Quote/GetQuoteEntity
uid: v1QuoteAgent_GetQuoteEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Quote/GetQuoteEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 385
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 337,
  "SaleId": 4,
  "QuoteConnectionId": 530,
  "ERPQuoteKey": "necessitatibus",
  "ERPOrderKey": "provident",
  "ActiveQuoteVersionId": 982,
  "AcceptedQuoteAlternativeId": 334,
  "UseValuesFromQuote": 976,
  "DocumentId": 192,
  "PoNumber": "673470",
  "OrderComment": "ducimus",
  "PreferredEmailCulture": "daphne@hamillwelch.us",
  "QuoteVersions": [
    {
      "QuoteVersionId": 794,
      "ERPQuoteVersionKey": "delectus",
      "QuoteId": 188,
      "Description": "Visionary client-driven model",
      "Number": "1272921",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 67,
      "SentDate": "2021-04-28T12:15:19.9557403+02:00",
      "FollowupId": 928,
      "ExpirationDate": "2008-09-16T12:15:19.9557403+02:00",
      "DeliveryCountryId": 711,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 278,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "hic",
      "ERPPaymentTypeKey": "ullam",
      "ERPDeliveryTermsKey": "provident",
      "ERPDeliveryTypeKey": "eos",
      "Rank": 522,
      "ApprovedBy": 650,
      "ApprovedText": "natus",
      "ApprovedRegisteredBy": 363,
      "ApprovedRegisteredDate": "2007-12-30T12:15:19.9557403+01:00",
      "ExtraField1": "numquam",
      "ExtraField2": "numquam",
      "ExtraField3": "commodi",
      "ExtraField4": "mollitia",
      "ExtraField5": "debitis",
      "LastRecalculated": "2001-04-05T12:15:19.9557403+02:00",
      "Updated": "2021-03-24T12:15:19.9557403+01:00",
      "UpdatedAssociateId": 281,
      "Registered": "2017-09-18T12:15:19.9557403+02:00",
      "RegisteredAssociateId": 335,
      "RequestAssociateId": 616,
      "RequestComment": "cum",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 159
    }
  }
}
```