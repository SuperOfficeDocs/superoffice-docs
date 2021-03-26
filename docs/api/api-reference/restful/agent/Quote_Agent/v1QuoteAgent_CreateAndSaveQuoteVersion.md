---
title: POST Agents/Quote/CreateAndSaveQuoteVersion
id: v1QuoteAgent_CreateAndSaveQuoteVersion
---

# POST Agents/Quote/CreateAndSaveQuoteVersion

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuoteVersion
```

Created a new QuoteVersion based on another QuoteVersion on the same Quote.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/CreateAndSaveQuoteVersion?$select=name,department,category/id
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
| QuoteVersionId | int32 |  |


## Response: object

Information about a version of the .



Carrier object for QuoteVersion.
Services for the QuoteVersion Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| QuoteAlternatives | array | The QuoteAlternatives for the QuoteVersion |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/CreateAndSaveQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 630
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 33,
  "ERPQuoteVersionKey": "incidunt",
  "QuoteId": 95,
  "Description": "Object-based static matrix",
  "Number": "1056172",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "",
  "LikelyQuoteAlternativeId": 115,
  "SentDate": "2015-04-12T16:48:30.4159351+02:00",
  "FollowupId": 674,
  "ExpirationDate": "2020-03-27T16:48:30.4159351+01:00",
  "DeliveryCountryId": 357,
  "HasOwnDeliveryAddress": false,
  "InvoiceCountryId": 987,
  "HasOwnInvoiceAddress": false,
  "ERPPaymentTermsKey": "dolores",
  "ERPPaymentTypeKey": "et",
  "ERPDeliveryTermsKey": "aut",
  "ERPDeliveryTypeKey": "explicabo",
  "Rank": 284,
  "ApprovedBy": 586,
  "ApprovedText": "corporis",
  "ApprovedRegisteredBy": 859,
  "ApprovedRegisteredDate": "2001-10-09T16:48:30.4159351+02:00",
  "ExtraField1": "porro",
  "ExtraField2": "iure",
  "ExtraField3": "impedit",
  "ExtraField4": "facilis",
  "ExtraField5": "necessitatibus",
  "LastRecalculated": "1995-01-19T16:48:30.4159351+01:00",
  "Updated": "2016-11-11T16:48:30.4159351+01:00",
  "UpdatedAssociateId": 418,
  "Registered": "1996-05-01T16:48:30.4159351+02:00",
  "RegisteredAssociateId": 426,
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 474,
      "ERPQuoteAlternativeKey": "velit",
      "QuoteVersionId": 391,
      "Name": "Lemke-Schneider",
      "Description": "Open-source multi-state focus group",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 2510.334,
      "ERPDiscountAmount": 18725.649999999998,
      "DiscountPercent": 15309.59,
      "DiscountAmount": 13673.642,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "ea",
      "VAT": 10849.908,
      "EarningPercent": 29957.906,
      "EarningAmount": 1288.074,
      "SubTotal": 30318.316,
      "TotalPrice": 7813.062,
      "ExtraField1": "voluptates",
      "ExtraField2": "unde",
      "ExtraField3": "voluptatum",
      "ExtraField4": "eligendi",
      "ExtraField5": "tempore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 916
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
      "FieldLength": 53
    }
  }
}
```