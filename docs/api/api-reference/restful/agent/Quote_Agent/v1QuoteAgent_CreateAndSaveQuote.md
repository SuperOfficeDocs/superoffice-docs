---
title: CreateAndSaveQuote
id: v1QuoteAgent_CreateAndSaveQuote
---

# CreateAndSaveQuote

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuote
```

Creates a new quote on a sale.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuote?$select=name,department,category/id
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

SaleId, ConnectionId, FirstAlternativeName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | int32 |  |
| ConnectionId | int32 |  |
| FirstAlternativeName | string |  |


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
POST /api/v1/Agents/Quote/CreateAndSaveQuote
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 16,
  "ConnectionId": 803,
  "FirstAlternativeName": "Wolff, Wintheiser and Lang"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 377,
  "SaleId": 971,
  "QuoteConnectionId": 220,
  "ERPQuoteKey": "rerum",
  "ERPOrderKey": "eum",
  "ActiveQuoteVersionId": 664,
  "AcceptedQuoteAlternativeId": 372,
  "UseValuesFromQuote": 295,
  "DocumentId": 186,
  "PoNumber": "795901",
  "OrderComment": "eum",
  "PreferredEmailCulture": "priscilla.bayer@dickinsonkautzer.com",
  "QuoteVersions": [
    {
      "QuoteVersionId": 460,
      "ERPQuoteVersionKey": "repudiandae",
      "QuoteId": 438,
      "Description": "Self-enabling regional collaboration",
      "Number": "724168",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 311,
      "SentDate": "2012-07-24T14:58:05.008465+02:00",
      "FollowupId": 789,
      "ExpirationDate": "2007-06-14T14:58:05.008465+02:00",
      "DeliveryCountryId": 396,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 641,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "labore",
      "ERPPaymentTypeKey": "natus",
      "ERPDeliveryTermsKey": "accusantium",
      "ERPDeliveryTypeKey": "ratione",
      "Rank": 188,
      "ApprovedBy": 482,
      "ApprovedText": "rerum",
      "ApprovedRegisteredBy": 778,
      "ApprovedRegisteredDate": "2000-11-15T14:58:05.008465+01:00",
      "ExtraField1": "aut",
      "ExtraField2": "voluptatem",
      "ExtraField3": "dolor",
      "ExtraField4": "vel",
      "ExtraField5": "odit",
      "LastRecalculated": "2010-03-18T14:58:05.008465+01:00",
      "Updated": "1997-07-06T14:58:05.008465+02:00",
      "UpdatedAssociateId": 215,
      "Registered": "2008-10-18T14:58:05.008465+02:00",
      "RegisteredAssociateId": 569,
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
          "FieldLength": 792
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
      "FieldLength": 268
    }
  }
}
```