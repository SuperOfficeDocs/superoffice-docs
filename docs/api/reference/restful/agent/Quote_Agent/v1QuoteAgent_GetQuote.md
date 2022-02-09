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
  "QuoteId": 776
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 257,
  "SaleId": 780,
  "QuoteConnectionId": 880,
  "ERPQuoteKey": "necessitatibus",
  "ERPOrderKey": "unde",
  "ActiveQuoteVersionId": 606,
  "AcceptedQuoteAlternativeId": 918,
  "UseValuesFromQuote": 961,
  "DocumentId": 465,
  "PoNumber": "1323535",
  "OrderComment": "vitae",
  "PreferredEmailCulture": "felix.mosciski@jacobson.biz",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 831,
    "ERPQuoteVersionKey": "voluptatem",
    "QuoteId": 92,
    "Description": "Re-engineered user-facing initiative",
    "Number": "919181",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 104,
    "SentDate": "1999-10-25T18:28:49.9911374+02:00",
    "FollowupId": 359,
    "ExpirationDate": "2000-07-05T18:28:49.9911374+02:00",
    "DeliveryCountryId": 302,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 564,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "ipsum",
    "ERPPaymentTypeKey": "libero",
    "ERPDeliveryTermsKey": "sint",
    "ERPDeliveryTypeKey": "cumque",
    "Rank": 639,
    "ApprovedBy": 578,
    "ApprovedText": "quo",
    "ApprovedRegisteredBy": 181,
    "ApprovedRegisteredDate": "2013-12-04T18:28:49.9911374+01:00",
    "ExtraField1": "magni",
    "ExtraField2": "officiis",
    "ExtraField3": "laudantium",
    "ExtraField4": "similique",
    "ExtraField5": "delectus",
    "LastRecalculated": "2006-03-20T18:28:49.9921373+01:00",
    "Updated": "1995-11-24T18:28:49.9921373+01:00",
    "UpdatedAssociateId": 251,
    "Registered": "2008-04-24T18:28:49.9921373+02:00",
    "RegisteredAssociateId": 263,
    "QuoteAlternatives": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "expedite dynamic channels"
        },
        "FieldType": "System.Int32",
        "FieldLength": 221
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 95,
    "ERPQuoteAlternativeKey": "earum",
    "QuoteVersionId": 420,
    "Name": "Dietrich LLC",
    "Description": "Synchronised 3rd generation neural-net",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 9621.38,
    "ERPDiscountAmount": 7051.5,
    "DiscountPercent": 10116.552,
    "DiscountAmount": 13410.386,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "earum",
    "VAT": 6966.882,
    "EarningPercent": 27203.12,
    "EarningAmount": 30167.884,
    "SubTotal": 2955.362,
    "TotalPrice": 26378.878,
    "ExtraField1": "placeat",
    "ExtraField2": "officia",
    "ExtraField3": "autem",
    "ExtraField4": "doloribus",
    "ExtraField5": "minima",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 565
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
      "FieldLength": 899
    }
  }
}
```