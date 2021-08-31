---
title: SaveQuote
id: v1QuoteAgent_SaveQuote
---

# SaveQuote

```http
POST /api/v1/Agents/Quote/SaveQuote
```

Saves a Quote







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/SaveQuote?$select=name,department,category/id
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

Quote 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Quote |  | Quote carrier with the active quote version and favorite alternative. <para /> Carrier object for Quote. Services for the Quote Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>. |


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
POST /api/v1/Agents/Quote/SaveQuote
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Quote": {
    "QuoteId": 209,
    "SaleId": 920,
    "QuoteConnectionId": 639,
    "ERPQuoteKey": "aut",
    "ERPOrderKey": "omnis",
    "ActiveQuoteVersionId": 983,
    "AcceptedQuoteAlternativeId": 818,
    "UseValuesFromQuote": 75,
    "DocumentId": 863,
    "PoNumber": "1271922",
    "OrderComment": "exercitationem",
    "PreferredEmailCulture": "kelvin.russel@flatleyrobel.ca",
    "ActiveQuoteVersion": {},
    "FavoriteQuoteAlternative": {}
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 695,
  "SaleId": 899,
  "QuoteConnectionId": 560,
  "ERPQuoteKey": "est",
  "ERPOrderKey": "rerum",
  "ActiveQuoteVersionId": 36,
  "AcceptedQuoteAlternativeId": 928,
  "UseValuesFromQuote": 420,
  "DocumentId": 973,
  "PoNumber": "1540037",
  "OrderComment": "tenetur",
  "PreferredEmailCulture": "rafael_sauer@mcdermott.info",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 569,
    "ERPQuoteVersionKey": "odio",
    "QuoteId": 917,
    "Description": "Multi-channelled multi-state attitude",
    "Number": "1406088",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 107,
    "SentDate": "2020-11-28T14:58:05.0024659+01:00",
    "FollowupId": 159,
    "ExpirationDate": "1997-05-24T14:58:05.0024659+02:00",
    "DeliveryCountryId": 308,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 715,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "qui",
    "ERPPaymentTypeKey": "dolorem",
    "ERPDeliveryTermsKey": "accusamus",
    "ERPDeliveryTypeKey": "est",
    "Rank": 151,
    "ApprovedBy": 129,
    "ApprovedText": "commodi",
    "ApprovedRegisteredBy": 24,
    "ApprovedRegisteredDate": "1994-07-17T14:58:05.0024659+02:00",
    "ExtraField1": "quis",
    "ExtraField2": "quos",
    "ExtraField3": "consequatur",
    "ExtraField4": "molestiae",
    "ExtraField5": "consectetur",
    "LastRecalculated": "2011-03-03T14:58:05.0024659+01:00",
    "Updated": "2003-05-31T14:58:05.0024659+02:00",
    "UpdatedAssociateId": 824,
    "Registered": "2000-04-24T14:58:05.0024659+02:00",
    "RegisteredAssociateId": 551,
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
        "FieldLength": 620
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 480,
    "ERPQuoteAlternativeKey": "eum",
    "QuoteVersionId": 764,
    "Name": "Grant Group",
    "Description": "Optimized composite Graphic Interface",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 11501.779999999999,
    "ERPDiscountAmount": 8220.482,
    "DiscountPercent": 3607.234,
    "DiscountAmount": 22091.566,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "vel",
    "VAT": 16506.778,
    "EarningPercent": 28309.422,
    "EarningAmount": 26266.054,
    "SubTotal": 26009.066,
    "TotalPrice": 9173.2179999999989,
    "ExtraField1": "dignissimos",
    "ExtraField2": "quae",
    "ExtraField3": "aspernatur",
    "ExtraField4": "sit",
    "ExtraField5": "maxime",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 525
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
      "FieldLength": 31
    }
  }
}
```