---
title: POST Agents/Quote/GetQuoteVersions
uid: v1QuoteAgent_GetQuoteVersions
generated: true
---

# POST Agents/Quote/GetQuoteVersions

```http
POST /api/v1/Agents/Quote/GetQuoteVersions
```

Get all quote versions for a sale







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteVersions?$select=name,department,category/id
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
| QuoteId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/Quote/GetQuoteVersions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteId": 677
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "QuoteVersionId": 36,
    "ERPQuoteVersionKey": "rerum",
    "QuoteId": 288,
    "Description": "Secured dedicated initiative",
    "Number": "1102373",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 925,
    "SentDate": "2000-07-28T13:28:23.5230176+02:00",
    "FollowupId": 598,
    "ExpirationDate": "2008-06-24T13:28:23.5230176+02:00",
    "DeliveryCountryId": 736,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 356,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "ut",
    "ERPPaymentTypeKey": "dolorem",
    "ERPDeliveryTermsKey": "sit",
    "ERPDeliveryTypeKey": "sapiente",
    "Rank": 396,
    "ApprovedBy": 727,
    "ApprovedText": "expedita",
    "ApprovedRegisteredBy": 996,
    "ApprovedRegisteredDate": "1998-07-14T13:28:23.5230176+02:00",
    "ExtraField1": "atque",
    "ExtraField2": "mollitia",
    "ExtraField3": "quod",
    "ExtraField4": "quo",
    "ExtraField5": "ut",
    "LastRecalculated": "2001-06-06T13:28:23.5230176+02:00",
    "Updated": "2024-08-18T13:28:23.5230176+02:00",
    "UpdatedAssociateId": 412,
    "Registered": "2017-11-30T13:28:23.5230176+01:00",
    "RegisteredAssociateId": 825,
    "RequestAssociateId": 439,
    "RequestComment": "qui",
    "QuoteAlternatives": [
      {
        "QuoteAlternativeId": 11,
        "ERPQuoteAlternativeKey": "eum",
        "QuoteVersionId": 54,
        "Name": "Glover, Lindgren and Wunsch",
        "Description": "Profit-focused 6th generation paradigm",
        "Status": "Error",
        "Reason": "",
        "ERPDiscountPercent": 9533.6279999999988,
        "ERPDiscountAmount": 1172.116,
        "DiscountPercent": 890.05599999999993,
        "DiscountAmount": 28218.536,
        "UserValueOverride": "DiscountAmount",
        "VATInfo": "inventore",
        "VAT": 4610.114,
        "EarningPercent": 6866.594,
        "EarningAmount": 12532.866,
        "SubTotal": 2673.302,
        "TotalPrice": 22389.296,
        "ExtraField1": "necessitatibus",
        "ExtraField2": "temporibus",
        "ExtraField3": "eveniet",
        "ExtraField4": "tenetur",
        "ExtraField5": "sunt",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 349
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 997
      }
    }
  }
]
```