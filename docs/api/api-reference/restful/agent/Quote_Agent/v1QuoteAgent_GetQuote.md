---
title: POST Agents/Quote/GetQuote
id: v1QuoteAgent_GetQuote
---

# POST Agents/Quote/GetQuote

```http
POST /api/v1/Agents/Quote/GetQuote
```

Get a Quote







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuote?$select=name,department,category/id
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


## Response: object

Quote carrier with the active quote version and favorite alternative.



Carrier object for Quote.
Services for the Quote Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| ActiveQuoteVersion |  | The active quote version for the quote |
| FavoriteQuoteAlternative |  | The favorite quote alternative for the quote and active quote version. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/GetQuote
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 628
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 85,
  "SaleId": 256,
  "QuoteConnectionId": 852,
  "ERPQuoteKey": "ipsam",
  "ERPOrderKey": "ut",
  "ActiveQuoteVersionId": 444,
  "AcceptedQuoteAlternativeId": 903,
  "UseValuesFromQuote": 791,
  "DocumentId": 246,
  "PoNumber": "325316",
  "OrderComment": "rerum",
  "PreferredEmailCulture": "claire@reichert.uk",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 692,
    "ERPQuoteVersionKey": "non",
    "QuoteId": 928,
    "Description": "Exclusive system-worthy structure",
    "Number": "1330265",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 582,
    "SentDate": "1994-08-25T16:48:30.4409398+02:00",
    "FollowupId": 75,
    "ExpirationDate": "2015-04-14T16:48:30.4409398+02:00",
    "DeliveryCountryId": 88,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 172,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "qui",
    "ERPPaymentTypeKey": "expedita",
    "ERPDeliveryTermsKey": "et",
    "ERPDeliveryTypeKey": "quam",
    "Rank": 203,
    "ApprovedBy": 78,
    "ApprovedText": "aut",
    "ApprovedRegisteredBy": 630,
    "ApprovedRegisteredDate": "2005-10-17T16:48:30.44294+02:00",
    "ExtraField1": "qui",
    "ExtraField2": "quas",
    "ExtraField3": "natus",
    "ExtraField4": "qui",
    "ExtraField5": "iusto",
    "LastRecalculated": "2021-03-01T16:48:30.44294+01:00",
    "Updated": "2014-05-30T16:48:30.44294+02:00",
    "UpdatedAssociateId": 308,
    "Registered": "2012-11-14T16:48:30.44294+01:00",
    "RegisteredAssociateId": 117,
    "QuoteAlternatives": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 929
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 392,
    "ERPQuoteAlternativeKey": "porro",
    "QuoteVersionId": 378,
    "Name": "Reichel Group",
    "Description": "Face to face incremental collaboration",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 5938.9299999999994,
    "ERPDiscountAmount": 28566.41,
    "DiscountPercent": 507.70799999999997,
    "DiscountAmount": 9016.518,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "culpa",
    "VAT": 8643.572,
    "EarningPercent": 19139.338,
    "EarningAmount": 3143.402,
    "SubTotal": 5688.21,
    "TotalPrice": 14469.678,
    "ExtraField1": "expedita",
    "ExtraField2": "animi",
    "ExtraField3": "corporis",
    "ExtraField4": "odio",
    "ExtraField5": "vitae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 768
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 206
    }
  }
}
```