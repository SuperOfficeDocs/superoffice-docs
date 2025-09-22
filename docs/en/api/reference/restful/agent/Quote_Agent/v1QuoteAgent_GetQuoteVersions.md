---
title: POST Agents/Quote/GetQuoteVersions
uid: v1QuoteAgent_GetQuoteVersions
generated: true
content_type: reference
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
  "QuoteId": 983
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "QuoteVersionId": 240,
    "ERPQuoteVersionKey": "illo",
    "QuoteId": 775,
    "Description": "Monitored intermediate orchestration",
    "Number": "620625",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "embrace world-class infomediaries",
    "LikelyQuoteAlternativeId": 690,
    "SentDate": "2018-10-07T11:24:48.5157652+02:00",
    "FollowupId": 482,
    "ExpirationDate": "2018-10-14T11:24:48.5157652+02:00",
    "DeliveryCountryId": 396,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 498,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "aut",
    "ERPPaymentTypeKey": "impedit",
    "ERPDeliveryTermsKey": "qui",
    "ERPDeliveryTypeKey": "voluptas",
    "Rank": 104,
    "ApprovedBy": 202,
    "ApprovedText": "magnam",
    "ApprovedRegisteredBy": 867,
    "ApprovedRegisteredDate": "1999-08-24T11:24:48.5157652+02:00",
    "ExtraField1": "ducimus",
    "ExtraField2": "ad",
    "ExtraField3": "possimus",
    "ExtraField4": "voluptatem",
    "ExtraField5": "earum",
    "LastRecalculated": "2011-07-11T11:24:48.5157652+02:00",
    "Updated": "2014-01-21T11:24:48.5157652+01:00",
    "UpdatedAssociateId": 512,
    "Registered": "2008-04-02T11:24:48.5157652+02:00",
    "RegisteredAssociateId": 288,
    "RequestAssociateId": 303,
    "RequestComment": "eligendi",
    "QuoteAlternatives": [
      {
        "QuoteAlternativeId": 255,
        "ERPQuoteAlternativeKey": "corporis",
        "QuoteVersionId": 46,
        "Name": "Kassulke-Bednar",
        "Description": "Phased well-modulated migration",
        "Status": "Error",
        "Reason": "",
        "ERPDiscountPercent": 21210.912,
        "ERPDiscountAmount": 16823.311999999998,
        "DiscountPercent": 13940.032,
        "DiscountAmount": 30073.863999999998,
        "UserValueOverride": "DiscountAmount",
        "VATInfo": "fuga",
        "VAT": 10712.011999999999,
        "EarningPercent": 25056.329999999998,
        "EarningAmount": 18108.252,
        "SubTotal": 4011.52,
        "TotalPrice": 21771.898,
        "ExtraField1": "expedita",
        "ExtraField2": "quas",
        "ExtraField3": "qui",
        "ExtraField4": "adipisci",
        "ExtraField5": "cumque",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 612
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 224
      }
    }
  }
]
```