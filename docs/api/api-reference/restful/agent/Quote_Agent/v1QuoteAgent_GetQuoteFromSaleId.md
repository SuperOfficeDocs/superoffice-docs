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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleId": 813
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 31,
  "SaleId": 128,
  "QuoteConnectionId": 636,
  "ERPQuoteKey": "deleniti",
  "ERPOrderKey": "repellat",
  "ActiveQuoteVersionId": 860,
  "AcceptedQuoteAlternativeId": 226,
  "UseValuesFromQuote": 443,
  "DocumentId": 548,
  "PoNumber": "893452",
  "OrderComment": "optio",
  "PreferredEmailCulture": "leland@lesch.uk",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 854,
    "ERPQuoteVersionKey": "assumenda",
    "QuoteId": 341,
    "Description": "Triple-buffered homogeneous hierarchy",
    "Number": "1318014",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 80,
    "SentDate": "2006-03-13T16:48:30.4439412+01:00",
    "FollowupId": 105,
    "ExpirationDate": "2004-01-02T16:48:30.4439412+01:00",
    "DeliveryCountryId": 783,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 137,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "minus",
    "ERPPaymentTypeKey": "non",
    "ERPDeliveryTermsKey": "officia",
    "ERPDeliveryTypeKey": "autem",
    "Rank": 201,
    "ApprovedBy": 434,
    "ApprovedText": "et",
    "ApprovedRegisteredBy": 220,
    "ApprovedRegisteredDate": "2016-05-27T16:48:30.4439412+02:00",
    "ExtraField1": "et",
    "ExtraField2": "sunt",
    "ExtraField3": "unde",
    "ExtraField4": "ut",
    "ExtraField5": "expedita",
    "LastRecalculated": "2012-09-25T16:48:30.4439412+02:00",
    "Updated": "2006-09-08T16:48:30.4439412+02:00",
    "UpdatedAssociateId": 422,
    "Registered": "2017-02-25T16:48:30.4439412+01:00",
    "RegisteredAssociateId": 362,
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
        "FieldType": "System.Int32",
        "FieldLength": 157
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 312,
    "ERPQuoteAlternativeKey": "vitae",
    "QuoteVersionId": 948,
    "Name": "Quigley, Tremblay and Kutch",
    "Description": "Pre-emptive bandwidth-monitored Graphic Interface",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 22918.942,
    "ERPDiscountAmount": 28284.35,
    "DiscountPercent": 7421.312,
    "DiscountAmount": 7418.178,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "cumque",
    "VAT": 18443.59,
    "EarningPercent": 6938.6759999999995,
    "EarningAmount": 18706.845999999998,
    "SubTotal": 3673.048,
    "TotalPrice": 5111.554,
    "ExtraField1": "nam",
    "ExtraField2": "et",
    "ExtraField3": "modi",
    "ExtraField4": "quia",
    "ExtraField5": "voluptates",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 67
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
      "FieldType": "System.String",
      "FieldLength": 221
    }
  }
}
```