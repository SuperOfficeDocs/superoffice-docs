---
title: POST Agents/Quote/SaveQuoteVersion
id: v1QuoteAgent_SaveQuoteVersion
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
| QuoteVersion |  | Information about a version of the . <para /> Carrier object for QuoteVersion. Services for the QuoteVersion Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>. |


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
POST /api/v1/Agents/Quote/SaveQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersion": {
    "QuoteVersionId": 850,
    "ERPQuoteVersionKey": "quas",
    "QuoteId": 911,
    "Description": "Advanced zero defect utilisation",
    "Number": "1565313",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 961,
    "SentDate": "1997-11-10T16:48:30.4199346+01:00",
    "FollowupId": 748,
    "ExpirationDate": "2009-07-14T16:48:30.4199346+02:00",
    "DeliveryCountryId": 219,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 137,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "fuga",
    "ERPPaymentTypeKey": "animi",
    "ERPDeliveryTermsKey": "laboriosam",
    "ERPDeliveryTypeKey": "eligendi",
    "Rank": 465,
    "ApprovedBy": 789,
    "ApprovedText": "nemo",
    "ApprovedRegisteredBy": 950,
    "ApprovedRegisteredDate": "2016-04-03T16:48:30.4199346+02:00",
    "ExtraField1": "porro",
    "ExtraField2": "odio",
    "ExtraField3": "possimus",
    "ExtraField4": "aut",
    "ExtraField5": "eveniet",
    "LastRecalculated": "2016-05-22T16:48:30.4199346+02:00",
    "Updated": "1998-02-05T16:48:30.4199346+01:00",
    "UpdatedAssociateId": 262,
    "Registered": "2015-10-25T16:48:30.4199346+01:00",
    "RegisteredAssociateId": 917,
    "QuoteAlternatives": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 936,
  "ERPQuoteVersionKey": "mollitia",
  "QuoteId": 926,
  "Description": "Synergized actuating array",
  "Number": "919180",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "",
  "LikelyQuoteAlternativeId": 578,
  "SentDate": "2004-09-04T16:48:30.4219378+02:00",
  "FollowupId": 990,
  "ExpirationDate": "2021-01-08T16:48:30.4219378+01:00",
  "DeliveryCountryId": 677,
  "HasOwnDeliveryAddress": false,
  "InvoiceCountryId": 53,
  "HasOwnInvoiceAddress": false,
  "ERPPaymentTermsKey": "voluptatibus",
  "ERPPaymentTypeKey": "consequatur",
  "ERPDeliveryTermsKey": "consequatur",
  "ERPDeliveryTypeKey": "eius",
  "Rank": 981,
  "ApprovedBy": 669,
  "ApprovedText": "reprehenderit",
  "ApprovedRegisteredBy": 475,
  "ApprovedRegisteredDate": "1995-05-01T16:48:30.4219378+02:00",
  "ExtraField1": "iste",
  "ExtraField2": "voluptatibus",
  "ExtraField3": "rerum",
  "ExtraField4": "ratione",
  "ExtraField5": "sit",
  "LastRecalculated": "2004-07-15T16:48:30.4219378+02:00",
  "Updated": "2002-03-27T16:48:30.4219378+01:00",
  "UpdatedAssociateId": 257,
  "Registered": "2013-05-01T16:48:30.4219378+02:00",
  "RegisteredAssociateId": 559,
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 860,
      "ERPQuoteAlternativeKey": "sit",
      "QuoteVersionId": 267,
      "Name": "Hand-King",
      "Description": "Advanced leading edge support",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 16682.282,
      "ERPDiscountAmount": 5866.848,
      "DiscountPercent": 24454.602,
      "DiscountAmount": 23677.37,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "et",
      "VAT": 23777.658,
      "EarningPercent": 13582.756,
      "EarningAmount": 11520.583999999999,
      "SubTotal": 21706.084,
      "TotalPrice": 26883.451999999997,
      "ExtraField1": "aspernatur",
      "ExtraField2": "explicabo",
      "ExtraField3": "possimus",
      "ExtraField4": "fugit",
      "ExtraField5": "nam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "aggregate innovative markets"
          },
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "optimize virtual schemas"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 576
    }
  }
}
```