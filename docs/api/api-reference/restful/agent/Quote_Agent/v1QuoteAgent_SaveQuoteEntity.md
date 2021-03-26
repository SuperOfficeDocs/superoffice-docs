---
title: POST Agents/Quote/SaveQuoteEntity
id: v1QuoteAgent_SaveQuoteEntity
---

# POST Agents/Quote/SaveQuoteEntity

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteEntity": {
    "QuoteId": 303,
    "SaleId": 44,
    "QuoteConnectionId": 832,
    "ERPQuoteKey": "tempora",
    "ERPOrderKey": "unde",
    "ActiveQuoteVersionId": 437,
    "AcceptedQuoteAlternativeId": 874,
    "UseValuesFromQuote": 38,
    "DocumentId": 526,
    "PoNumber": "1177891",
    "OrderComment": "recusandae",
    "PreferredEmailCulture": "leslie_abbott@stantonparker.co.uk",
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
  "QuoteId": 805,
  "SaleId": 438,
  "QuoteConnectionId": 929,
  "ERPQuoteKey": "nesciunt",
  "ERPOrderKey": "autem",
  "ActiveQuoteVersionId": 60,
  "AcceptedQuoteAlternativeId": 778,
  "UseValuesFromQuote": 818,
  "DocumentId": 238,
  "PoNumber": "1610807",
  "OrderComment": "et",
  "PreferredEmailCulture": "kira@olson.com",
  "QuoteVersions": [
    {
      "QuoteVersionId": 760,
      "ERPQuoteVersionKey": "in",
      "QuoteId": 828,
      "Description": "Sharable secondary initiative",
      "Number": "765090",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 842,
      "SentDate": "2008-09-02T16:48:30.451945+02:00",
      "FollowupId": 671,
      "ExpirationDate": "2002-01-13T16:48:30.451945+01:00",
      "DeliveryCountryId": 461,
      "HasOwnDeliveryAddress": true,
      "InvoiceCountryId": 747,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "porro",
      "ERPPaymentTypeKey": "odit",
      "ERPDeliveryTermsKey": "quae",
      "ERPDeliveryTypeKey": "et",
      "Rank": 692,
      "ApprovedBy": 511,
      "ApprovedText": "eius",
      "ApprovedRegisteredBy": 579,
      "ApprovedRegisteredDate": "2020-01-01T16:48:30.451945+01:00",
      "ExtraField1": "non",
      "ExtraField2": "nisi",
      "ExtraField3": "debitis",
      "ExtraField4": "nihil",
      "ExtraField5": "unde",
      "LastRecalculated": "2016-09-24T16:48:30.451945+02:00",
      "Updated": "2016-01-29T16:48:30.451945+01:00",
      "UpdatedAssociateId": 927,
      "Registered": "2011-11-16T16:48:30.451945+01:00",
      "RegisteredAssociateId": 349,
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
          "FieldLength": 949
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
        "Reason": "innovate dynamic deliverables"
      },
      "FieldType": "System.String",
      "FieldLength": 915
    }
  }
}
```