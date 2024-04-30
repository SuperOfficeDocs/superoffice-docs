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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 41
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 918,
  "ERPQuoteVersionKey": "voluptatem",
  "QuoteId": 99,
  "Description": "Public-key zero administration Graphic Interface",
  "Number": "1107403",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "",
  "LikelyQuoteAlternativeId": 380,
  "SentDate": "2003-07-30T11:16:09.5848946+02:00",
  "FollowupId": 938,
  "ExpirationDate": "2021-04-27T11:16:09.5848946+02:00",
  "DeliveryCountryId": 78,
  "HasOwnDeliveryAddress": true,
  "InvoiceCountryId": 503,
  "HasOwnInvoiceAddress": false,
  "ERPPaymentTermsKey": "sint",
  "ERPPaymentTypeKey": "eligendi",
  "ERPDeliveryTermsKey": "tempore",
  "ERPDeliveryTypeKey": "neque",
  "Rank": 97,
  "ApprovedBy": 785,
  "ApprovedText": "placeat",
  "ApprovedRegisteredBy": 790,
  "ApprovedRegisteredDate": "1999-04-16T11:16:09.5848946+02:00",
  "ExtraField1": "quisquam",
  "ExtraField2": "ut",
  "ExtraField3": "aut",
  "ExtraField4": "aut",
  "ExtraField5": "amet",
  "LastRecalculated": "1998-03-17T11:16:09.5848946+01:00",
  "Updated": "2004-08-10T11:16:09.5848946+02:00",
  "UpdatedAssociateId": 454,
  "Registered": "2017-03-21T11:16:09.5848946+01:00",
  "RegisteredAssociateId": 945,
  "RequestAssociateId": 652,
  "RequestComment": "neque",
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 61,
      "ERPQuoteAlternativeKey": "autem",
      "QuoteVersionId": 463,
      "Name": "Anderson LLC",
      "Description": "Decentralized tangible data-warehouse",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 16055.482,
      "ERPDiscountAmount": 21580.724,
      "DiscountPercent": 25093.938,
      "DiscountAmount": 26347.538,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "deserunt",
      "VAT": 15181.096,
      "EarningPercent": 23965.698,
      "EarningAmount": 6465.442,
      "SubTotal": 28152.721999999998,
      "TotalPrice": 5822.972,
      "ExtraField1": "id",
      "ExtraField2": "veniam",
      "ExtraField3": "debitis",
      "ExtraField4": "molestias",
      "ExtraField5": "suscipit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 668
    }
  }
}
```