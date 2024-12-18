---
title: POST Agents/Quote/CreateAndSaveQuote
uid: v1QuoteAgent_CreateAndSaveQuote
generated: true
---

# POST Agents/Quote/CreateAndSaveQuote

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
| SaleId | Integer |  |
| ConnectionId | Integer |  |
| FirstAlternativeName | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: QuoteEntity

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/CreateAndSaveQuote
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 785,
  "ConnectionId": 853,
  "FirstAlternativeName": "Klein, Cruickshank and McDermott"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 920,
  "SaleId": 582,
  "QuoteConnectionId": 532,
  "ERPQuoteKey": "assumenda",
  "ERPOrderKey": "beatae",
  "ActiveQuoteVersionId": 138,
  "AcceptedQuoteAlternativeId": 647,
  "UseValuesFromQuote": 631,
  "DocumentId": 532,
  "PoNumber": "1201336",
  "OrderComment": "nobis",
  "PreferredEmailCulture": "otis.mayert@kuvalis.ca",
  "QuoteVersions": [
    {
      "QuoteVersionId": 31,
      "ERPQuoteVersionKey": "iste",
      "QuoteId": 719,
      "Description": "Enhanced homogeneous software",
      "Number": "848202",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 758,
      "SentDate": "2021-05-28T10:17:55.9415595+02:00",
      "FollowupId": 19,
      "ExpirationDate": "2000-04-11T10:17:55.9415595+02:00",
      "DeliveryCountryId": 443,
      "HasOwnDeliveryAddress": true,
      "InvoiceCountryId": 227,
      "HasOwnInvoiceAddress": true,
      "ERPPaymentTermsKey": "aut",
      "ERPPaymentTypeKey": "dignissimos",
      "ERPDeliveryTermsKey": "autem",
      "ERPDeliveryTypeKey": "repudiandae",
      "Rank": 501,
      "ApprovedBy": 371,
      "ApprovedText": "totam",
      "ApprovedRegisteredBy": 917,
      "ApprovedRegisteredDate": "2015-12-16T10:17:55.9415595+01:00",
      "ExtraField1": "ratione",
      "ExtraField2": "repudiandae",
      "ExtraField3": "neque",
      "ExtraField4": "odit",
      "ExtraField5": "ut",
      "LastRecalculated": "1998-07-22T10:17:55.9415595+02:00",
      "Updated": "2007-09-21T10:17:55.9415595+02:00",
      "UpdatedAssociateId": 270,
      "Registered": "2012-05-29T10:17:55.9415595+02:00",
      "RegisteredAssociateId": 366,
      "RequestAssociateId": 441,
      "RequestComment": "officia",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 677
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 397
    }
  }
}
```