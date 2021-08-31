---
title: SaveQuoteEntity
id: v1QuoteAgent_SaveQuoteEntity
---

# SaveQuoteEntity

```http
POST /api/v1/Agents/Quote/SaveQuoteEntity
```

Saves a QuoteEntity.

Versions and alternatives will not be saved by this call.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/SaveQuoteEntity?$select=name,department,category/id
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

QuoteEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteEntity |  | Quote methods <para /> Carrier object for QuoteEntity. Services for the QuoteEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>. |


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
POST /api/v1/Agents/Quote/SaveQuoteEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteEntity": {
    "QuoteId": 660,
    "SaleId": 356,
    "QuoteConnectionId": 193,
    "ERPQuoteKey": "minima",
    "ERPOrderKey": "maiores",
    "ActiveQuoteVersionId": 632,
    "AcceptedQuoteAlternativeId": 795,
    "UseValuesFromQuote": 660,
    "DocumentId": 413,
    "PoNumber": "1160223",
    "OrderComment": "iusto",
    "PreferredEmailCulture": "eleanora@abbottlesch.us",
    "QuoteVersions": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 559,
  "SaleId": 448,
  "QuoteConnectionId": 339,
  "ERPQuoteKey": "a",
  "ERPOrderKey": "accusantium",
  "ActiveQuoteVersionId": 967,
  "AcceptedQuoteAlternativeId": 851,
  "UseValuesFromQuote": 449,
  "DocumentId": 504,
  "PoNumber": "1005823",
  "OrderComment": "ea",
  "PreferredEmailCulture": "lucie.lindgren@senger.info",
  "QuoteVersions": [
    {
      "QuoteVersionId": 493,
      "ERPQuoteVersionKey": "quas",
      "QuoteId": 226,
      "Description": "Horizontal 6th generation architecture",
      "Number": "1206499",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 419,
      "SentDate": "2000-07-23T14:58:05.0134733+02:00",
      "FollowupId": 952,
      "ExpirationDate": "1995-11-30T14:58:05.0134733+01:00",
      "DeliveryCountryId": 693,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 859,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "delectus",
      "ERPPaymentTypeKey": "eaque",
      "ERPDeliveryTermsKey": "nobis",
      "ERPDeliveryTypeKey": "nihil",
      "Rank": 633,
      "ApprovedBy": 618,
      "ApprovedText": "totam",
      "ApprovedRegisteredBy": 575,
      "ApprovedRegisteredDate": "2017-02-26T14:58:05.0134733+01:00",
      "ExtraField1": "rerum",
      "ExtraField2": "animi",
      "ExtraField3": "ea",
      "ExtraField4": "rerum",
      "ExtraField5": "tenetur",
      "LastRecalculated": "2017-02-11T14:58:05.0134733+01:00",
      "Updated": "2010-09-14T14:58:05.0134733+02:00",
      "UpdatedAssociateId": 224,
      "Registered": "2004-07-20T14:58:05.0134733+02:00",
      "RegisteredAssociateId": 594,
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "drive leading-edge models"
          },
          "FieldType": "System.Int32",
          "FieldLength": 814
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
      "FieldType": "System.Int32",
      "FieldLength": 17
    }
  }
}
```