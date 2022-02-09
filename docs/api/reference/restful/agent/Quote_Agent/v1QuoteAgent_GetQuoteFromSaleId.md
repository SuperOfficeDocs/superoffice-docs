---
title: POST Agents/Quote/GetQuoteFromSaleId
id: v1QuoteAgent_GetQuoteFromSaleId
---

# POST Agents/Quote/GetQuoteFromSaleId

```http
POST /api/v1/Agents/Quote/GetQuoteFromSaleId
```

Get a Quote for a sale







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteFromSaleId?$select=name,department,category/id
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
| SaleId | int32 |  |


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
POST /api/v1/Agents/Quote/GetQuoteFromSaleId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 446
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 547,
  "SaleId": 800,
  "QuoteConnectionId": 501,
  "ERPQuoteKey": "nisi",
  "ERPOrderKey": "cumque",
  "ActiveQuoteVersionId": 456,
  "AcceptedQuoteAlternativeId": 108,
  "UseValuesFromQuote": 482,
  "DocumentId": 10,
  "PoNumber": "668113",
  "OrderComment": "nobis",
  "PreferredEmailCulture": "rosanna@thompsonhackett.com",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 336,
    "ERPQuoteVersionKey": "in",
    "QuoteId": 101,
    "Description": "User-friendly leading edge forecast",
    "Number": "933185",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 224,
    "SentDate": "2009-02-08T18:28:49.9941378+01:00",
    "FollowupId": 961,
    "ExpirationDate": "2007-05-04T18:28:49.9941378+02:00",
    "DeliveryCountryId": 487,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 462,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "sunt",
    "ERPPaymentTypeKey": "doloribus",
    "ERPDeliveryTermsKey": "consequatur",
    "ERPDeliveryTypeKey": "recusandae",
    "Rank": 752,
    "ApprovedBy": 324,
    "ApprovedText": "molestiae",
    "ApprovedRegisteredBy": 203,
    "ApprovedRegisteredDate": "2016-02-13T18:28:49.9941378+01:00",
    "ExtraField1": "molestiae",
    "ExtraField2": "iure",
    "ExtraField3": "aliquid",
    "ExtraField4": "impedit",
    "ExtraField5": "ab",
    "LastRecalculated": "2004-09-04T18:28:49.9941378+02:00",
    "Updated": "2009-12-24T18:28:49.9941378+01:00",
    "UpdatedAssociateId": 187,
    "Registered": "2015-11-26T18:28:49.9941378+01:00",
    "RegisteredAssociateId": 234,
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
        "FieldLength": 849
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 872,
    "ERPQuoteAlternativeKey": "necessitatibus",
    "QuoteVersionId": 730,
    "Name": "Labadie Group",
    "Description": "Fully-configurable methodical moderator",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 30590.974,
    "ERPDiscountAmount": 15748.35,
    "DiscountPercent": 347.87399999999997,
    "DiscountAmount": 20342.793999999998,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "aspernatur",
    "VAT": 21355.076,
    "EarningPercent": 3441.132,
    "EarningAmount": 12288.413999999999,
    "SubTotal": 7722.1759999999995,
    "TotalPrice": 18995.174,
    "ExtraField1": "ea",
    "ExtraField2": "fuga",
    "ExtraField3": "cumque",
    "ExtraField4": "voluptas",
    "ExtraField5": "beatae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 197
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
      "FieldLength": 66
    }
  }
}
```