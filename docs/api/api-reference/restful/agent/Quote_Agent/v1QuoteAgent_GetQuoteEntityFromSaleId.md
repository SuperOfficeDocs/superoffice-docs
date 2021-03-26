---
title: POST Agents/Quote/GetQuoteEntityFromSaleId
id: v1QuoteAgent_GetQuoteEntityFromSaleId
---

# POST Agents/Quote/GetQuoteEntityFromSaleId

```http
POST /api/v1/Agents/Quote/GetQuoteEntityFromSaleId
```

Get a Quote for a sale







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteEntityFromSaleId?$select=name,department,category/id
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

SaleId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | int32 |  |


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
POST /api/v1/Agents/Quote/GetQuoteEntityFromSaleId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleId": 513
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 415,
  "SaleId": 794,
  "QuoteConnectionId": 211,
  "ERPQuoteKey": "reprehenderit",
  "ERPOrderKey": "a",
  "ActiveQuoteVersionId": 575,
  "AcceptedQuoteAlternativeId": 338,
  "UseValuesFromQuote": 157,
  "DocumentId": 650,
  "PoNumber": "158951",
  "OrderComment": "est",
  "PreferredEmailCulture": "destany@stantonwatsica.biz",
  "QuoteVersions": [
    {
      "QuoteVersionId": 865,
      "ERPQuoteVersionKey": "aut",
      "QuoteId": 193,
      "Description": "Customizable transitional forecast",
      "Number": "802333",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 183,
      "SentDate": "2002-04-08T16:48:30.4499398+02:00",
      "FollowupId": 636,
      "ExpirationDate": "1995-05-16T16:48:30.4499398+02:00",
      "DeliveryCountryId": 282,
      "HasOwnDeliveryAddress": false,
      "InvoiceCountryId": 139,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "qui",
      "ERPPaymentTypeKey": "exercitationem",
      "ERPDeliveryTermsKey": "saepe",
      "ERPDeliveryTypeKey": "quas",
      "Rank": 998,
      "ApprovedBy": 225,
      "ApprovedText": "deleniti",
      "ApprovedRegisteredBy": 531,
      "ApprovedRegisteredDate": "2006-02-24T16:48:30.4499398+01:00",
      "ExtraField1": "velit",
      "ExtraField2": "et",
      "ExtraField3": "est",
      "ExtraField4": "eaque",
      "ExtraField5": "quae",
      "LastRecalculated": "2002-07-14T16:48:30.4499398+02:00",
      "Updated": "2012-04-12T16:48:30.4499398+02:00",
      "UpdatedAssociateId": 896,
      "Registered": "2020-05-15T16:48:30.4499398+02:00",
      "RegisteredAssociateId": 658,
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "harness impactful e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 828
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
      "FieldLength": 1001
    }
  }
}
```