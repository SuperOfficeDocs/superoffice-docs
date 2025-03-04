---
title: POST Agents/Quote/SaveQuoteEntity
uid: v1QuoteAgent_SaveQuoteEntity
generated: true
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
| QuoteEntity | QuoteEntity | Quote methods <para /> Carrier object for QuoteEntity. Services for the QuoteEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>. |

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
POST /api/v1/Agents/Quote/SaveQuoteEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 261,
  "SaleId": 510,
  "QuoteConnectionId": 830,
  "ERPQuoteKey": "voluptate",
  "ERPOrderKey": "quia",
  "ActiveQuoteVersionId": 319,
  "AcceptedQuoteAlternativeId": 991,
  "UseValuesFromQuote": 884,
  "DocumentId": 996,
  "PoNumber": "419051",
  "OrderComment": "quos",
  "PreferredEmailCulture": "kristopher@reichertschroeder.uk",
  "QuoteVersions": [
    {
      "QuoteVersionId": 806,
      "ERPQuoteVersionKey": "repudiandae",
      "QuoteId": 302,
      "Description": "Extended dedicated contingency",
      "Number": "1026661",
      "State": "Archived",
      "ArchivedState": "Archived",
      "Status": "Error",
      "Reason": "",
      "LikelyQuoteAlternativeId": 165,
      "SentDate": "2002-04-04T14:13:41.1251915+02:00",
      "FollowupId": 373,
      "ExpirationDate": "2014-11-18T14:13:41.1251915+01:00",
      "DeliveryCountryId": 262,
      "HasOwnDeliveryAddress": true,
      "InvoiceCountryId": 262,
      "HasOwnInvoiceAddress": false,
      "ERPPaymentTermsKey": "optio",
      "ERPPaymentTypeKey": "quo",
      "ERPDeliveryTermsKey": "eveniet",
      "ERPDeliveryTypeKey": "laborum",
      "Rank": 294,
      "ApprovedBy": 654,
      "ApprovedText": "numquam",
      "ApprovedRegisteredBy": 319,
      "ApprovedRegisteredDate": "1998-11-21T14:13:41.1251915+01:00",
      "ExtraField1": "veniam",
      "ExtraField2": "exercitationem",
      "ExtraField3": "quo",
      "ExtraField4": "inventore",
      "ExtraField5": "voluptatibus",
      "LastRecalculated": "2014-07-02T14:13:41.1251915+02:00",
      "Updated": "2018-03-30T14:13:41.1251915+02:00",
      "UpdatedAssociateId": 142,
      "Registered": "2002-12-15T14:13:41.1251915+01:00",
      "RegisteredAssociateId": 210,
      "RequestAssociateId": 358,
      "RequestComment": "labore",
      "QuoteAlternatives": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 88
    }
  }
}
```