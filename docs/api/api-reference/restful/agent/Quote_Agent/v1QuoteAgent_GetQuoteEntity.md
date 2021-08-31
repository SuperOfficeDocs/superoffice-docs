---
title: GetQuoteEntity
id: v1QuoteAgent_GetQuoteEntity
---

# GetQuoteEntity

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 760
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 151,
  "SaleId": 174,
  "QuoteConnectionId": 638,
  "ERPQuoteKey": "aut",
  "ERPOrderKey": "veritatis",
  "ActiveQuoteVersionId": 76,
  "AcceptedQuoteAlternativeId": 61,
  "UseValuesFromQuote": 509,
  "DocumentId": 65,
  "PoNumber": "1671644",
  "OrderComment": "illum",
  "PreferredEmailCulture": "maribel.eichmann@runolfsdottirbreitenberg.info",
  "QuoteVersions": [
    {
      "QuoteVersionId": 364,
      "ERPQuoteVersionKey": "voluptatibus",
      "QuoteId": 219,
      "Description": "Customer-focused didactic instruction set",
      "Number": "1337429",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 732,
      "SentDate": "2014-07-13T14:58:05.0094681+02:00",
      "FollowupId": 551,
      "ExpirationDate": "2019-07-01T14:58:05.0094681+02:00",
      "DeliveryCountryId": 966,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 443,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "aspernatur",
      "ERPPaymentTypeKey": "vel",
      "ERPDeliveryTermsKey": "vero",
      "ERPDeliveryTypeKey": "debitis",
      "Rank": 773,
      "ApprovedBy": 697,
      "ApprovedText": "ipsa",
      "ApprovedRegisteredBy": 376,
      "ApprovedRegisteredDate": "2014-02-28T14:58:05.0094681+01:00",
      "ExtraField1": "quia",
      "ExtraField2": "et",
      "ExtraField3": "perspiciatis",
      "ExtraField4": "sunt",
      "ExtraField5": "ut",
      "LastRecalculated": "2006-04-25T14:58:05.0094681+02:00",
      "Updated": "2015-01-29T14:58:05.0094681+01:00",
      "UpdatedAssociateId": 235,
      "Registered": "2010-03-27T14:58:05.0094681+01:00",
      "RegisteredAssociateId": 884,
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
          "FieldLength": 667
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
      "FieldLength": 559
    }
  }
}
```