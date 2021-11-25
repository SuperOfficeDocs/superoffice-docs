---
title: POST Agents/Quote/GetQuoteEntity
id: v1QuoteAgent_GetQuoteEntity
---

# POST Agents/Quote/GetQuoteEntity

```http
POST /api/v1/Agents/Quote/GetQuoteEntity
```

Get a Quote







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Quote/GetQuoteEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 523
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 656,
  "SaleId": 727,
  "QuoteConnectionId": 796,
  "ERPQuoteKey": "harum",
  "ERPOrderKey": "fuga",
  "ActiveQuoteVersionId": 801,
  "AcceptedQuoteAlternativeId": 424,
  "UseValuesFromQuote": 85,
  "DocumentId": 322,
  "PoNumber": "1766689",
  "OrderComment": "facilis",
  "PreferredEmailCulture": "tad_rogahn@champlin.info",
  "QuoteVersions": [
    {
      "QuoteVersionId": 808,
      "ERPQuoteVersionKey": "qui",
      "QuoteId": 614,
      "Description": "Re-engineered demand-driven software",
      "Number": "1210931",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 510,
      "SentDate": "2017-12-14T18:28:49.9501071+01:00",
      "FollowupId": 315,
      "ExpirationDate": "2007-08-18T18:28:49.9501071+02:00",
      "DeliveryCountryId": 304,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 319,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "asperiores",
      "ERPPaymentTypeKey": "recusandae",
      "ERPDeliveryTermsKey": "est",
      "ERPDeliveryTypeKey": "distinctio",
      "Rank": 166,
      "ApprovedBy": 362,
      "ApprovedText": "perferendis",
      "ApprovedRegisteredBy": 957,
      "ApprovedRegisteredDate": "2005-05-01T18:28:49.9501071+02:00",
      "ExtraField1": "libero",
      "ExtraField2": "et",
      "ExtraField3": "dolore",
      "ExtraField4": "iste",
      "ExtraField5": "aut",
      "LastRecalculated": "2013-01-01T18:28:49.9501071+01:00",
      "Updated": "2001-06-26T18:28:49.9501071+02:00",
      "UpdatedAssociateId": 403,
      "Registered": "2002-09-06T18:28:49.9501071+02:00",
      "RegisteredAssociateId": 435,
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
          "FieldLength": 396
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
        "Reason": "whiteboard customized supply-chains"
      },
      "FieldType": "System.String",
      "FieldLength": 226
    }
  }
}
```