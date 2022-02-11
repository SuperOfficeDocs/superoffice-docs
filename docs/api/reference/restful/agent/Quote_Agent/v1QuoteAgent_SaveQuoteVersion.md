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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteVersion": {
    "QuoteVersionId": 561,
    "ERPQuoteVersionKey": "dolor",
    "QuoteId": 243,
    "Description": "Secured even-keeled encryption",
    "Number": "1101971",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 601,
    "SentDate": "2018-11-14T18:28:49.9221376+01:00",
    "FollowupId": 941,
    "ExpirationDate": "2000-07-25T18:28:49.9221376+02:00",
    "DeliveryCountryId": 220,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 525,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "eius",
    "ERPPaymentTypeKey": "harum",
    "ERPDeliveryTermsKey": "qui",
    "ERPDeliveryTypeKey": "neque",
    "Rank": 477,
    "ApprovedBy": 526,
    "ApprovedText": "ad",
    "ApprovedRegisteredBy": 628,
    "ApprovedRegisteredDate": "2014-04-03T18:28:49.9221376+02:00",
    "ExtraField1": "minima",
    "ExtraField2": "atque",
    "ExtraField3": "ut",
    "ExtraField4": "aliquid",
    "ExtraField5": "ipsum",
    "LastRecalculated": "2019-01-29T18:28:49.9221376+01:00",
    "Updated": "1995-03-13T18:28:49.9221376+01:00",
    "UpdatedAssociateId": 663,
    "Registered": "2015-06-30T18:28:49.9221376+02:00",
    "RegisteredAssociateId": 536,
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
  "QuoteVersionId": 630,
  "ERPQuoteVersionKey": "officia",
  "QuoteId": 216,
  "Description": "Compatible bifurcated portal",
  "Number": "742649",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "",
  "LikelyQuoteAlternativeId": 825,
  "SentDate": "2011-09-17T18:28:49.9231374+02:00",
  "FollowupId": 174,
  "ExpirationDate": "2013-09-09T18:28:49.9231374+02:00",
  "DeliveryCountryId": 360,
  "HasOwnDeliveryAddress": true,
  "InvoiceCountryId": 127,
  "HasOwnInvoiceAddress": true,
  "ERPPaymentTermsKey": "et",
  "ERPPaymentTypeKey": "ad",
  "ERPDeliveryTermsKey": "harum",
  "ERPDeliveryTypeKey": "neque",
  "Rank": 257,
  "ApprovedBy": 484,
  "ApprovedText": "delectus",
  "ApprovedRegisteredBy": 948,
  "ApprovedRegisteredDate": "2018-05-30T18:28:49.9231374+02:00",
  "ExtraField1": "et",
  "ExtraField2": "a",
  "ExtraField3": "ea",
  "ExtraField4": "dolorem",
  "ExtraField5": "provident",
  "LastRecalculated": "2015-10-06T18:28:49.9231374+02:00",
  "Updated": "1994-07-26T18:28:49.9231374+02:00",
  "UpdatedAssociateId": 602,
  "Registered": "2011-05-26T18:28:49.9231374+02:00",
  "RegisteredAssociateId": 798,
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 663,
      "ERPQuoteAlternativeKey": "autem",
      "QuoteVersionId": 330,
      "Name": "Schneider-Kunde",
      "Description": "Synergistic user-facing hierarchy",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 30058.194,
      "ERPDiscountAmount": 11489.243999999999,
      "DiscountPercent": 921.396,
      "DiscountAmount": 20371.0,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "optio",
      "VAT": 25037.525999999998,
      "EarningPercent": 29105.458,
      "EarningAmount": 28193.464,
      "SubTotal": 12504.66,
      "TotalPrice": 14635.779999999999,
      "ExtraField1": "reprehenderit",
      "ExtraField2": "qui",
      "ExtraField3": "ab",
      "ExtraField4": "aperiam",
      "ExtraField5": "commodi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 639
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
      "FieldLength": 519
    }
  }
}
```