---
title: POST Agents/Quote/CreateAndSaveQuoteVersion
uid: v1QuoteAgent_CreateAndSaveQuoteVersion
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Quote/CreateAndSaveQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 606
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 456,
  "ERPQuoteVersionKey": "magnam",
  "QuoteId": 372,
  "Description": "Digitized 3rd generation Graphical User Interface",
  "Number": "1476382",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "",
  "LikelyQuoteAlternativeId": 220,
  "SentDate": "2008-11-09T02:49:44.9997158+01:00",
  "FollowupId": 113,
  "ExpirationDate": "2009-06-18T02:49:44.9997158+02:00",
  "DeliveryCountryId": 687,
  "HasOwnDeliveryAddress": false,
  "InvoiceCountryId": 261,
  "HasOwnInvoiceAddress": true,
  "ERPPaymentTermsKey": "harum",
  "ERPPaymentTypeKey": "hic",
  "ERPDeliveryTermsKey": "ut",
  "ERPDeliveryTypeKey": "corrupti",
  "Rank": 754,
  "ApprovedBy": 317,
  "ApprovedText": "eius",
  "ApprovedRegisteredBy": 696,
  "ApprovedRegisteredDate": "2004-04-23T02:49:44.9997158+02:00",
  "ExtraField1": "expedita",
  "ExtraField2": "asperiores",
  "ExtraField3": "hic",
  "ExtraField4": "velit",
  "ExtraField5": "qui",
  "LastRecalculated": "1996-09-02T02:49:44.9997158+02:00",
  "Updated": "2004-12-13T02:49:44.9997158+01:00",
  "UpdatedAssociateId": 341,
  "Registered": "1995-12-08T02:49:44.9997158+01:00",
  "RegisteredAssociateId": 346,
  "RequestAssociateId": 293,
  "RequestComment": "in",
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 893,
      "ERPQuoteAlternativeKey": "maxime",
      "QuoteVersionId": 679,
      "Name": "Hilpert-Schaefer",
      "Description": "Cloned solution-oriented collaboration",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 11294.936,
      "ERPDiscountAmount": 20562.174,
      "DiscountPercent": 4948.586,
      "DiscountAmount": 26037.272,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "perferendis",
      "VAT": 7524.7339999999995,
      "EarningPercent": 81.484,
      "EarningAmount": 28735.646,
      "SubTotal": 23808.998,
      "TotalPrice": 4932.916,
      "ExtraField1": "asperiores",
      "ExtraField2": "quo",
      "ExtraField3": "hic",
      "ExtraField4": "cupiditate",
      "ExtraField5": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 146
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 561
    }
  }
}
```