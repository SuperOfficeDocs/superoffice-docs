---
title: POST Agents/Quote/SaveQuoteVersion
uid: v1QuoteAgent_SaveQuoteVersion
generated: true
---

# POST Agents/Quote/SaveQuoteVersion

```http
POST /api/v1/Agents/Quote/SaveQuoteVersion
```

Saves a quote version







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/SaveQuoteVersion?$select=name,department,category/id
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

QuoteVersion 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersion | QuoteVersion | Information about a version of the . <para /> Carrier object for QuoteVersion. Services for the QuoteVersion Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>. |

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
POST /api/v1/Agents/Quote/SaveQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersion": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 539,
  "ERPQuoteVersionKey": "est",
  "QuoteId": 36,
  "Description": "Down-sized zero administration Graphical User Interface",
  "Number": "618924",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "leverage end-to-end web-readiness",
  "LikelyQuoteAlternativeId": 926,
  "SentDate": "2008-07-21T14:45:06.0375135+02:00",
  "FollowupId": 49,
  "ExpirationDate": "2005-05-23T14:45:06.0375135+02:00",
  "DeliveryCountryId": 469,
  "HasOwnDeliveryAddress": true,
  "InvoiceCountryId": 182,
  "HasOwnInvoiceAddress": false,
  "ERPPaymentTermsKey": "necessitatibus",
  "ERPPaymentTypeKey": "fuga",
  "ERPDeliveryTermsKey": "sint",
  "ERPDeliveryTypeKey": "aut",
  "Rank": 921,
  "ApprovedBy": 22,
  "ApprovedText": "soluta",
  "ApprovedRegisteredBy": 527,
  "ApprovedRegisteredDate": "2019-07-24T14:45:06.0375135+02:00",
  "ExtraField1": "quia",
  "ExtraField2": "voluptate",
  "ExtraField3": "incidunt",
  "ExtraField4": "tempore",
  "ExtraField5": "ipsa",
  "LastRecalculated": "2007-07-08T14:45:06.0375135+02:00",
  "Updated": "2006-02-24T14:45:06.0375135+01:00",
  "UpdatedAssociateId": 669,
  "Registered": "2007-03-02T14:45:06.0375135+01:00",
  "RegisteredAssociateId": 161,
  "RequestAssociateId": 972,
  "RequestComment": "ut",
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 911,
      "ERPQuoteAlternativeKey": "iste",
      "QuoteVersionId": 547,
      "Name": "McDermott, Murazik and Kuhn",
      "Description": "Distributed background functionalities",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 25705.068,
      "ERPDiscountAmount": 25980.86,
      "DiscountPercent": 23028.631999999998,
      "DiscountAmount": 16585.128,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "similique",
      "VAT": 3779.604,
      "EarningPercent": 13350.84,
      "EarningAmount": 9568.101999999999,
      "SubTotal": 23530.072,
      "TotalPrice": 10787.228,
      "ExtraField1": "et",
      "ExtraField2": "molestiae",
      "ExtraField3": "provident",
      "ExtraField4": "ducimus",
      "ExtraField5": "ab",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 449
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 686
    }
  }
}
```