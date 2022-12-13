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
| QuoteId | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Quote/GetQuoteEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 325
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 176,
  "SaleId": 557,
  "QuoteConnectionId": 977,
  "ERPQuoteKey": "et",
  "ERPOrderKey": "et",
  "ActiveQuoteVersionId": 877,
  "AcceptedQuoteAlternativeId": 839,
  "UseValuesFromQuote": 319,
  "DocumentId": 133,
  "PoNumber": "1034051",
  "OrderComment": "autem",
  "PreferredEmailCulture": "ericka@oconnersteuber.com",
  "QuoteVersions": [
    {
      "QuoteVersionId": 491,
      "ERPQuoteVersionKey": "asperiores",
      "QuoteId": 613,
      "Description": "Face to face zero administration policy",
      "Number": "752506",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 802,
      "SentDate": "2001-08-05T02:49:45.0465904+02:00",
      "FollowupId": 675,
      "ExpirationDate": "2003-06-08T02:49:45.0465904+02:00",
      "DeliveryCountryId": 493,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 857,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "nobis",
      "ERPPaymentTypeKey": "ex",
      "ERPDeliveryTermsKey": "aperiam",
      "ERPDeliveryTypeKey": "sunt",
      "Rank": 393,
      "ApprovedBy": 558,
      "ApprovedText": "est",
      "ApprovedRegisteredBy": 915,
      "ApprovedRegisteredDate": "2004-10-27T02:49:45.0465904+02:00",
      "ExtraField1": "illum",
      "ExtraField2": "temporibus",
      "ExtraField3": "velit",
      "ExtraField4": "et",
      "ExtraField5": "ad",
      "LastRecalculated": "2006-07-12T02:49:45.0465904+02:00",
      "Updated": "2000-09-11T02:49:45.0465904+02:00",
      "UpdatedAssociateId": 6,
      "Registered": "1997-05-04T02:49:45.0465904+02:00",
      "RegisteredAssociateId": 971,
      "RequestAssociateId": 835,
      "RequestComment": "explicabo",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 820
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 593
    }
  }
}
```