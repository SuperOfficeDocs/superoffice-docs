---
title: GetQuote
id: v1QuoteAgent_GetQuote
---

# GetQuote

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 16
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 189,
  "SaleId": 288,
  "QuoteConnectionId": 338,
  "ERPQuoteKey": "id",
  "ERPOrderKey": "assumenda",
  "ActiveQuoteVersionId": 609,
  "AcceptedQuoteAlternativeId": 641,
  "UseValuesFromQuote": 59,
  "DocumentId": 726,
  "PoNumber": "942338",
  "OrderComment": "rem",
  "PreferredEmailCulture": "may_lockman@casper.ca",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 40,
    "ERPQuoteVersionKey": "vero",
    "QuoteId": 576,
    "Description": "Secured global algorithm",
    "Number": "1617465",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 90,
    "SentDate": "1999-11-14T14:58:05.004465+01:00",
    "FollowupId": 933,
    "ExpirationDate": "2007-05-12T14:58:05.004465+02:00",
    "DeliveryCountryId": 409,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 158,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "quas",
    "ERPPaymentTypeKey": "ut",
    "ERPDeliveryTermsKey": "in",
    "ERPDeliveryTypeKey": "nesciunt",
    "Rank": 222,
    "ApprovedBy": 277,
    "ApprovedText": "hic",
    "ApprovedRegisteredBy": 752,
    "ApprovedRegisteredDate": "2013-07-02T14:58:05.004465+02:00",
    "ExtraField1": "maxime",
    "ExtraField2": "aut",
    "ExtraField3": "est",
    "ExtraField4": "reiciendis",
    "ExtraField5": "eligendi",
    "LastRecalculated": "2003-09-13T14:58:05.004465+02:00",
    "Updated": "2020-09-07T14:58:05.004465+02:00",
    "UpdatedAssociateId": 606,
    "Registered": "1996-11-24T14:58:05.004465+01:00",
    "RegisteredAssociateId": 796,
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
        "FieldLength": 81
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 723,
    "ERPQuoteAlternativeKey": "molestias",
    "QuoteVersionId": 686,
    "Name": "Bogisich-Barton",
    "Description": "Self-enabling non-volatile interface",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 16751.23,
    "ERPDiscountAmount": 21455.363999999998,
    "DiscountPercent": 24758.6,
    "DiscountAmount": 5014.4,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "iusto",
    "VAT": 19618.84,
    "EarningPercent": 17130.444,
    "EarningAmount": 19725.396,
    "SubTotal": 10273.252,
    "TotalPrice": 6293.072,
    "ExtraField1": "ipsam",
    "ExtraField2": "quibusdam",
    "ExtraField3": "commodi",
    "ExtraField4": "quas",
    "ExtraField5": "officiis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 63
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
      "FieldLength": 456
    }
  }
}
```