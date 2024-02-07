---
title: POST Agents/Quote/GetQuoteVersion
uid: v1QuoteAgent_GetQuoteVersion
generated: true
---

# POST Agents/Quote/GetQuoteVersion

```http
POST /api/v1/Agents/Quote/GetQuoteVersion
```

Get a QuoteVersion







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteVersion?$select=name,department,category/id
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

QuoteVersionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: QuoteVersion

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 | Primary key |
| ERPQuoteVersionKey | string | Key in the ERP system that uniquely identifies this Version within the ERP system (if available, the field may be empty). |
| QuoteId | int32 | Foreign key to CRM quote (the conceptual parent). Owning Quote of this Quote Version. |
| Description | string | Description of Version. Potentially longer text description, typically used in a tooltip. Max 2K. |
| Number | string | A quote number that the user (or ERP connector) can fill out. |
| State | string | Current state of this quote version. |
| ArchivedState | string | State that this quote version had, right before it was changed to Archived; in this way we can show what happened before the archiving. |
| Status | string | If there was a problem with for instance calculation, this field is set to warning or error. |
| Reason | string | If there was a problem, this field contains a localized explanation of the problem and possible steps to fix it that the user can be shown. |
| LikelyQuoteAlternativeId | int32 | The alternative that is considered most likely to be accepted. Used to calculate probable income. |
| SentDate | date-time | The date the version was sent to the customer. |
| FollowupId | int32 | Link to a follow-up activity, created when this quote version was sent to the customer. |
| ExpirationDate | date-time | Last date the quote Version is valid, expiration is at midnight end of this day. |
| DeliveryCountryId | int32 | Country of delivery address, typically copied from the contact record |
| HasOwnDeliveryAddress | bool | The delivery address is not the same as the contact's Street address |
| InvoiceCountryId | int32 | Country of invoice address, typically copied from contact record |
| HasOwnInvoiceAddress | bool | The quote has an address for Invoicing. This will typically be copied from the company's addresses. |
| ERPPaymentTermsKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text. For instance: ‘Standard 30 days’. |
| ERPPaymentTypeKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text. For instance: 'Invoice'. |
| ERPDeliveryTermsKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text. For instance: ‘FOB’ (‘Free on board’). |
| ERPDeliveryTypeKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text. For instance: ‘Air’. |
| Rank | int32 | Rank/Version number, starts at 1 |
| ApprovedBy | int32 | Id of associate who approved (or rejected approval) for this version |
| ApprovedText | string | Text with comments on why approval was granted (or rejected) |
| ApprovedRegisteredBy | int32 | Id of associate who actually entered the approval; might be different from ApprovedBy (f.x. due to telephone consultation/approval) |
| ApprovedRegisteredDate | date-time | When was approval granted or rejected |
| ExtraField1 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField2 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField3 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField4 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField5 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| LastRecalculated | date-time | When this version was last subjected to a total recalculation. This field must be set by the connector, since the connector may choose to ignore a RecalculateVersion call based on policies and possibly the current value of this field. SuperOffice will set this field to 1.1.1760 whenever any change occurs to the quote, to indicate that a recalculation is needed. |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| RequestAssociateId | int32 | User to whom the request proposal should be delivered |
| RequestComment | string | Comment for why quote should be approved |
| QuoteAlternatives | array | The QuoteAlternatives for the QuoteVersion |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/GetQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 904
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 710,
  "ERPQuoteVersionKey": "qui",
  "QuoteId": 373,
  "Description": "Cross-platform human-resource knowledge base",
  "Number": "153694",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "facilitate value-added networks",
  "LikelyQuoteAlternativeId": 467,
  "SentDate": "1997-09-04T16:54:56.096147+02:00",
  "FollowupId": 41,
  "ExpirationDate": "2011-03-15T16:54:56.096147+01:00",
  "DeliveryCountryId": 900,
  "HasOwnDeliveryAddress": false,
  "InvoiceCountryId": 62,
  "HasOwnInvoiceAddress": false,
  "ERPPaymentTermsKey": "facere",
  "ERPPaymentTypeKey": "eaque",
  "ERPDeliveryTermsKey": "voluptatem",
  "ERPDeliveryTypeKey": "inventore",
  "Rank": 469,
  "ApprovedBy": 421,
  "ApprovedText": "autem",
  "ApprovedRegisteredBy": 521,
  "ApprovedRegisteredDate": "2002-07-15T16:54:56.096147+02:00",
  "ExtraField1": "quo",
  "ExtraField2": "provident",
  "ExtraField3": "debitis",
  "ExtraField4": "deserunt",
  "ExtraField5": "sit",
  "LastRecalculated": "2006-01-12T16:54:56.0971559+01:00",
  "Updated": "2009-06-13T16:54:56.0971559+02:00",
  "UpdatedAssociateId": 578,
  "Registered": "2022-09-09T16:54:56.0971559+02:00",
  "RegisteredAssociateId": 941,
  "RequestAssociateId": 125,
  "RequestComment": "eum",
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 412,
      "ERPQuoteAlternativeKey": "natus",
      "QuoteVersionId": 215,
      "Name": "Okuneva, Gutmann and Bednar",
      "Description": "Organic heuristic groupware",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 22336.018,
      "ERPDiscountAmount": 9405.134,
      "DiscountPercent": 23404.712,
      "DiscountAmount": 12583.01,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "ut",
      "VAT": 25501.358,
      "EarningPercent": 10307.726,
      "EarningAmount": 25341.523999999998,
      "SubTotal": 19361.852,
      "TotalPrice": 8019.906,
      "ExtraField1": "maxime",
      "ExtraField2": "est",
      "ExtraField3": "dolorem",
      "ExtraField4": "praesentium",
      "ExtraField5": "molestiae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 156
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 90
    }
  }
}
```