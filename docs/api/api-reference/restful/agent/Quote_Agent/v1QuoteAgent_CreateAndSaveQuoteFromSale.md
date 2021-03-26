---
title: POST Agents/Quote/CreateAndSaveQuoteFromSale
id: v1QuoteAgent_CreateAndSaveQuoteFromSale
---

# POST Agents/Quote/CreateAndSaveQuoteFromSale

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuoteFromSale
```

Creates a copy the active version with connected alternatives and quotelines from another sale.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuoteFromSale?$select=name,department,category/id
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

CopyFromSaleId, CopyToSaleId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CopyFromSaleId | int32 |  |
| CopyToSaleId | int32 |  |


## Response: object

Quote methods



Carrier object for QuoteEntity.
Services for the QuoteEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

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
| QuoteVersions | array | Array og QuoteVersions connected to the quote. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/CreateAndSaveQuoteFromSale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "CopyFromSaleId": 664,
  "CopyToSaleId": 327
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 976,
  "SaleId": 949,
  "QuoteConnectionId": 852,
  "ERPQuoteKey": "autem",
  "ERPOrderKey": "repudiandae",
  "ActiveQuoteVersionId": 230,
  "AcceptedQuoteAlternativeId": 944,
  "UseValuesFromQuote": 604,
  "DocumentId": 257,
  "PoNumber": "872471",
  "OrderComment": "vitae",
  "PreferredEmailCulture": "reyes@sporerfeil.info",
  "QuoteVersions": [
    {
      "QuoteVersionId": 576,
      "ERPQuoteVersionKey": "aut",
      "QuoteId": 665,
      "Description": "Grass-roots secondary moderator",
      "Number": "785536",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "drive distributed solutions",
      "LikelyQuoteAlternativeId": 473,
      "SentDate": "2016-09-07T16:48:30.4529397+02:00",
      "FollowupId": 455,
      "ExpirationDate": "1995-05-17T16:48:30.4529397+02:00",
      "DeliveryCountryId": 854,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 596,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "eum",
      "ERPPaymentTypeKey": "fugit",
      "ERPDeliveryTermsKey": "nisi",
      "ERPDeliveryTypeKey": "eaque",
      "Rank": 996,
      "ApprovedBy": 906,
      "ApprovedText": "consequatur",
      "ApprovedRegisteredBy": 841,
      "ApprovedRegisteredDate": "2004-04-19T16:48:30.4529397+02:00",
      "ExtraField1": "voluptatem",
      "ExtraField2": "sed",
      "ExtraField3": "et",
      "ExtraField4": "molestiae",
      "ExtraField5": "est",
      "LastRecalculated": "2007-08-12T16:48:30.4529397+02:00",
      "Updated": "2019-08-31T16:48:30.4529397+02:00",
      "UpdatedAssociateId": 356,
      "Registered": "2011-01-21T16:48:30.4529397+01:00",
      "RegisteredAssociateId": 392,
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
          "FieldLength": 988
        }
      }
    }
  ],
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
      "FieldLength": 975
    }
  }
}
```