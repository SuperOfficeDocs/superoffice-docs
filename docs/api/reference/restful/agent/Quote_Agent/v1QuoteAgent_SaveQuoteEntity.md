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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteEntity": {
    "QuoteId": 62,
    "SaleId": 696,
    "QuoteConnectionId": 6,
    "ERPQuoteKey": "culpa",
    "ERPOrderKey": "illum",
    "ActiveQuoteVersionId": 932,
    "AcceptedQuoteAlternativeId": 502,
    "UseValuesFromQuote": 733,
    "DocumentId": 972,
    "PoNumber": "959962",
    "OrderComment": "expedita",
    "PreferredEmailCulture": "merl.harber@yostwest.biz",
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
  "QuoteId": 58,
  "SaleId": 453,
  "QuoteConnectionId": 62,
  "ERPQuoteKey": "quam",
  "ERPOrderKey": "aut",
  "ActiveQuoteVersionId": 8,
  "AcceptedQuoteAlternativeId": 83,
  "UseValuesFromQuote": 548,
  "DocumentId": 996,
  "PoNumber": "1015523",
  "OrderComment": "qui",
  "PreferredEmailCulture": "jeff@mckenzie.biz",
  "QuoteVersions": [
    {
      "QuoteVersionId": 80,
      "ERPQuoteVersionKey": "est",
      "QuoteId": 141,
      "Description": "Self-enabling coherent utilisation",
      "Number": "849909",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 707,
      "SentDate": "2004-09-24T18:28:49.9541373+02:00",
      "FollowupId": 835,
      "ExpirationDate": "2006-01-22T18:28:49.9541373+01:00",
      "DeliveryCountryId": 955,
      "HasOwnDeliveryAddress": true,
      "InvoiceCountryId": 35,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "est",
      "ERPPaymentTypeKey": "voluptatum",
      "ERPDeliveryTermsKey": "omnis",
      "ERPDeliveryTypeKey": "odit",
      "Rank": 854,
      "ApprovedBy": 827,
      "ApprovedText": "in",
      "ApprovedRegisteredBy": 640,
      "ApprovedRegisteredDate": "1995-02-13T18:28:49.9541373+01:00",
      "ExtraField1": "qui",
      "ExtraField2": "laborum",
      "ExtraField3": "magni",
      "ExtraField4": "animi",
      "ExtraField5": "laudantium",
      "LastRecalculated": "2006-01-29T18:28:49.9541373+01:00",
      "Updated": "1999-03-20T18:28:49.9541373+01:00",
      "UpdatedAssociateId": 977,
      "Registered": "1999-05-06T18:28:49.9541373+02:00",
      "RegisteredAssociateId": 411,
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
          "FieldLength": 526
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
      "FieldLength": 245
    }
  }
}
```