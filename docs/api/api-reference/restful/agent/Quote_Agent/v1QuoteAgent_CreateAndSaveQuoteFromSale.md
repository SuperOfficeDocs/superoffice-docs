---
title: CreateAndSaveQuoteFromSale
id: v1QuoteAgent_CreateAndSaveQuoteFromSale
---

# CreateAndSaveQuoteFromSale

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CopyFromSaleId": 856,
  "CopyToSaleId": 372
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 528,
  "SaleId": 617,
  "QuoteConnectionId": 864,
  "ERPQuoteKey": "quidem",
  "ERPOrderKey": "inventore",
  "ActiveQuoteVersionId": 711,
  "AcceptedQuoteAlternativeId": 622,
  "UseValuesFromQuote": 820,
  "DocumentId": 362,
  "PoNumber": "580245",
  "OrderComment": "quam",
  "PreferredEmailCulture": "ryley.labadie@vandervort.uk",
  "QuoteVersions": [
    {
      "QuoteVersionId": 760,
      "ERPQuoteVersionKey": "eius",
      "QuoteId": 666,
      "Description": "Multi-layered background matrices",
      "Number": "472368",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 16,
      "SentDate": "1996-10-22T14:58:05.0144649+02:00",
      "FollowupId": 836,
      "ExpirationDate": "2011-06-13T14:58:05.0144649+02:00",
      "DeliveryCountryId": 563,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 539,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "ut",
      "ERPPaymentTypeKey": "exercitationem",
      "ERPDeliveryTermsKey": "autem",
      "ERPDeliveryTypeKey": "totam",
      "Rank": 418,
      "ApprovedBy": 436,
      "ApprovedText": "exercitationem",
      "ApprovedRegisteredBy": 484,
      "ApprovedRegisteredDate": "2020-09-24T14:58:05.0144649+02:00",
      "ExtraField1": "ut",
      "ExtraField2": "incidunt",
      "ExtraField3": "tempora",
      "ExtraField4": "rerum",
      "ExtraField5": "ut",
      "LastRecalculated": "1998-11-24T14:58:05.0144649+01:00",
      "Updated": "2014-02-08T14:58:05.0144649+01:00",
      "UpdatedAssociateId": 847,
      "Registered": "2013-09-29T14:58:05.0144649+02:00",
      "RegisteredAssociateId": 676,
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
          "FieldLength": 785
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
        "Reason": "seize compelling mindshare"
      },
      "FieldType": "System.Int32",
      "FieldLength": 783
    }
  }
}
```