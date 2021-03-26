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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Quote": {
    "QuoteId": 607,
    "SaleId": 194,
    "QuoteConnectionId": 80,
    "ERPQuoteKey": "et",
    "ERPOrderKey": "omnis",
    "ActiveQuoteVersionId": 524,
    "AcceptedQuoteAlternativeId": 240,
    "UseValuesFromQuote": 140,
    "DocumentId": 683,
    "PoNumber": "1524637",
    "OrderComment": "autem",
    "PreferredEmailCulture": "maggie@zboncak.ca",
    "ActiveQuoteVersion": {},
    "FavoriteQuoteAlternative": {}
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 130,
  "SaleId": 985,
  "QuoteConnectionId": 950,
  "ERPQuoteKey": "voluptatem",
  "ERPOrderKey": "autem",
  "ActiveQuoteVersionId": 932,
  "AcceptedQuoteAlternativeId": 362,
  "UseValuesFromQuote": 904,
  "DocumentId": 812,
  "PoNumber": "86368",
  "OrderComment": "nulla",
  "PreferredEmailCulture": "gennaro.boyer@mann.us",
  "ActiveQuoteVersion": {
    "QuoteVersionId": 341,
    "ERPQuoteVersionKey": "magni",
    "QuoteId": 389,
    "Description": "Right-sized multi-state focus group",
    "Number": "1435538",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 384,
    "SentDate": "2020-01-11T16:48:30.4399398+01:00",
    "FollowupId": 367,
    "ExpirationDate": "2014-04-23T16:48:30.4399398+02:00",
    "DeliveryCountryId": 132,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 952,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "amet",
    "ERPPaymentTypeKey": "maxime",
    "ERPDeliveryTermsKey": "eos",
    "ERPDeliveryTypeKey": "sint",
    "Rank": 442,
    "ApprovedBy": 276,
    "ApprovedText": "accusamus",
    "ApprovedRegisteredBy": 661,
    "ApprovedRegisteredDate": "2004-07-24T16:48:30.4399398+02:00",
    "ExtraField1": "magni",
    "ExtraField2": "aperiam",
    "ExtraField3": "voluptatem",
    "ExtraField4": "doloremque",
    "ExtraField5": "asperiores",
    "LastRecalculated": "2020-10-09T16:48:30.4399398+02:00",
    "Updated": "1995-02-18T16:48:30.4399398+01:00",
    "UpdatedAssociateId": 402,
    "Registered": "2012-01-14T16:48:30.4399398+01:00",
    "RegisteredAssociateId": 948,
    "QuoteAlternatives": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower granular e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 148
      }
    }
  },
  "FavoriteQuoteAlternative": {
    "QuoteAlternativeId": 618,
    "ERPQuoteAlternativeKey": "sunt",
    "QuoteVersionId": 802,
    "Name": "Connelly, Hauck and Kautzer",
    "Description": "Diverse value-added core",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 7317.8899999999994,
    "ERPDiscountAmount": 14645.181999999999,
    "DiscountPercent": 3071.3199999999997,
    "DiscountAmount": 360.40999999999997,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "quaerat",
    "VAT": 26930.462,
    "EarningPercent": 16343.81,
    "EarningAmount": 22828.056,
    "SubTotal": 7421.312,
    "TotalPrice": 14441.472,
    "ExtraField1": "similique",
    "ExtraField2": "dolorem",
    "ExtraField3": "natus",
    "ExtraField4": "natus",
    "ExtraField5": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 64
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
      "FieldLength": 722
    }
  }
}
```