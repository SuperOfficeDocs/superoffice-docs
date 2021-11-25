---
title: POST Agents/Quote/SaveQuote
id: v1QuoteAgent_SaveQuote
---

# POST Agents/Quote/SaveQuote

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
    "QuoteId": 547,
    "SaleId": 925,
    "QuoteConnectionId": 297,
    "ERPQuoteKey": "harum",
    "ERPOrderKey": "suscipit",
    "ActiveQuoteVersionId": 200,
    "AcceptedQuoteAlternativeId": 408,
    "UseValuesFromQuote": 436,
    "DocumentId": 522,
    "PoNumber": "1284827",
    "OrderComment": "animi",
    "PreferredEmailCulture": "emilio@kunzegraham.info",
    "ActiveQuoteVersion": {},
    "FavoriteQuoteAlternative": {}
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 917,
  "SaleId": 571,
  "QuoteConnectionId": 670,
  "ERPQuoteKey": "consequatur",
  "ERPOrderKey": "et",
  "ActiveQuoteVersionId": 504,
  "AcceptedQuoteAlternativeId": 480,
  "UseValuesFromQuote": 710,
  "DocumentId": 409,
  "PoNumber": "778966",
  "OrderComment": "rerum",
  "PreferredEmailCulture": "jed@tillman.info",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 135,
    "ERPQuoteVersionKey": "consectetur",
    "QuoteId": 163,
    "Description": "Customizable multi-state framework",
    "Number": "281154",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 250,
    "SentDate": "2021-08-30T18:28:49.9891371+02:00",
    "FollowupId": 786,
    "ExpirationDate": "2007-09-27T18:28:49.9891371+02:00",
    "DeliveryCountryId": 615,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 697,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "illo",
    "ERPPaymentTypeKey": "hic",
    "ERPDeliveryTermsKey": "sint",
    "ERPDeliveryTypeKey": "optio",
    "Rank": 969,
    "ApprovedBy": 85,
    "ApprovedText": "qui",
    "ApprovedRegisteredBy": 74,
    "ApprovedRegisteredDate": "2009-12-23T18:28:49.9891371+01:00",
    "ExtraField1": "aut",
    "ExtraField2": "repudiandae",
    "ExtraField3": "consequuntur",
    "ExtraField4": "voluptatum",
    "ExtraField5": "id",
    "LastRecalculated": "2004-11-17T18:28:49.9891371+01:00",
    "Updated": "2009-03-10T18:28:49.9891371+01:00",
    "UpdatedAssociateId": 698,
    "Registered": "2013-07-24T18:28:49.9891371+02:00",
    "RegisteredAssociateId": 704,
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
        "FieldLength": 179
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 460,
    "ERPQuoteAlternativeKey": "velit",
    "QuoteVersionId": 347,
    "Name": "Hegmann Group",
    "Description": "Re-contextualized even-keeled data-warehouse",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 19465.273999999998,
    "ERPDiscountAmount": 25281.978,
    "DiscountPercent": 25479.42,
    "DiscountAmount": 25285.111999999997,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "optio",
    "VAT": 8875.488,
    "EarningPercent": 17788.584,
    "EarningAmount": 29948.504,
    "SubTotal": 6032.95,
    "TotalPrice": 15861.173999999999,
    "ExtraField1": "voluptas",
    "ExtraField2": "eius",
    "ExtraField3": "asperiores",
    "ExtraField4": "vel",
    "ExtraField5": "ad",
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
      "FieldLength": 215
    }
  }
}
```