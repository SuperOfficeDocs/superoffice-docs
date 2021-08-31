---
title: GetQuoteFromSaleId
id: v1QuoteAgent_GetQuoteFromSaleId
---

# GetQuoteFromSaleId

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
  "SaleId": 3
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 375,
  "SaleId": 896,
  "QuoteConnectionId": 783,
  "ERPQuoteKey": "sit",
  "ERPOrderKey": "rem",
  "ActiveQuoteVersionId": 866,
  "AcceptedQuoteAlternativeId": 46,
  "UseValuesFromQuote": 329,
  "DocumentId": 654,
  "PoNumber": "978402",
  "OrderComment": "quo",
  "PreferredEmailCulture": "jeremie@willms.name",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 5,
    "ERPQuoteVersionKey": "non",
    "QuoteId": 430,
    "Description": "Ameliorated methodical moderator",
    "Number": "1217879",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 174,
    "SentDate": "2018-08-24T14:58:05.0064661+02:00",
    "FollowupId": 853,
    "ExpirationDate": "2005-02-03T14:58:05.0064661+01:00",
    "DeliveryCountryId": 913,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 904,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "adipisci",
    "ERPPaymentTypeKey": "ipsam",
    "ERPDeliveryTermsKey": "ea",
    "ERPDeliveryTypeKey": "odit",
    "Rank": 12,
    "ApprovedBy": 191,
    "ApprovedText": "alias",
    "ApprovedRegisteredBy": 687,
    "ApprovedRegisteredDate": "2011-07-10T14:58:05.0064661+02:00",
    "ExtraField1": "magnam",
    "ExtraField2": "nemo",
    "ExtraField3": "dolorem",
    "ExtraField4": "nobis",
    "ExtraField5": "nisi",
    "LastRecalculated": "2005-08-27T14:58:05.0064661+02:00",
    "Updated": "2020-12-12T14:58:05.0064661+01:00",
    "UpdatedAssociateId": 605,
    "Registered": "2005-03-04T14:58:05.0064661+01:00",
    "RegisteredAssociateId": 577,
    "QuoteAlternatives": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline wireless platforms"
        },
        "FieldType": "System.String",
        "FieldLength": 321
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 964,
    "ERPQuoteAlternativeKey": "atque",
    "QuoteVersionId": 239,
    "Name": "Romaguera-Hegmann",
    "Description": "Synergistic empowering moratorium",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 22915.808,
    "ERPDiscountAmount": 18753.856,
    "DiscountPercent": 28939.356,
    "DiscountAmount": 18938.762,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "omnis",
    "VAT": 21433.426,
    "EarningPercent": 28845.336,
    "EarningAmount": 7045.232,
    "SubTotal": 22856.262,
    "TotalPrice": 16077.42,
    "ExtraField1": "nam",
    "ExtraField2": "quia",
    "ExtraField3": "et",
    "ExtraField4": "non",
    "ExtraField5": "inventore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 534
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
      "FieldLength": 916
    }
  }
}
```