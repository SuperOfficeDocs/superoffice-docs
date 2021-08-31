---
title: SaveQuoteVersion
id: v1QuoteAgent_SaveQuoteVersion
---

# SaveQuoteVersion

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
    "QuoteVersionId": 623,
    "ERPQuoteVersionKey": "harum",
    "QuoteId": 170,
    "Description": "Cloned contextually-based moderator",
    "Number": "661638",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 415,
    "SentDate": "2010-12-03T14:58:04.9394596+01:00",
    "FollowupId": 512,
    "ExpirationDate": "1997-11-09T14:58:04.9394596+01:00",
    "DeliveryCountryId": 342,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 338,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "fugiat",
    "ERPPaymentTypeKey": "occaecati",
    "ERPDeliveryTermsKey": "qui",
    "ERPDeliveryTypeKey": "repellat",
    "Rank": 779,
    "ApprovedBy": 461,
    "ApprovedText": "pariatur",
    "ApprovedRegisteredBy": 786,
    "ApprovedRegisteredDate": "2015-02-21T14:58:04.9404599+01:00",
    "ExtraField1": "amet",
    "ExtraField2": "dolore",
    "ExtraField3": "nesciunt",
    "ExtraField4": "nobis",
    "ExtraField5": "qui",
    "LastRecalculated": "1999-03-16T14:58:04.9414597+01:00",
    "Updated": "2015-01-10T14:58:04.9414597+01:00",
    "UpdatedAssociateId": 436,
    "Registered": "1998-09-30T14:58:04.9414597+02:00",
    "RegisteredAssociateId": 104,
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
  "QuoteVersionId": 484,
  "ERPQuoteVersionKey": "quis",
  "QuoteId": 598,
  "Description": "Grass-roots secondary Graphic Interface",
  "Number": "680310",
  "State": "Archived",
  "ArchivedState": "Archived",
  "Status": "Error",
  "Reason": "",
  "LikelyQuoteAlternativeId": 898,
  "SentDate": "2006-05-24T14:58:04.9414597+02:00",
  "FollowupId": 225,
  "ExpirationDate": "2019-10-02T14:58:04.9414597+02:00",
  "DeliveryCountryId": 484,
  "HasOwnDeliveryAddress": false,
  "InvoiceCountryId": 377,
  "HasOwnInvoiceAddress": true,
  "ERPPaymentTermsKey": "quis",
  "ERPPaymentTypeKey": "iste",
  "ERPDeliveryTermsKey": "atque",
  "ERPDeliveryTypeKey": "eum",
  "Rank": 657,
  "ApprovedBy": 940,
  "ApprovedText": "quia",
  "ApprovedRegisteredBy": 168,
  "ApprovedRegisteredDate": "2005-12-04T14:58:04.9424673+01:00",
  "ExtraField1": "laudantium",
  "ExtraField2": "libero",
  "ExtraField3": "libero",
  "ExtraField4": "at",
  "ExtraField5": "error",
  "LastRecalculated": "1995-05-18T14:58:04.9424673+02:00",
  "Updated": "2016-12-24T14:58:04.9424673+01:00",
  "UpdatedAssociateId": 243,
  "Registered": "2006-04-27T14:58:04.9424673+02:00",
  "RegisteredAssociateId": 618,
  "QuoteAlternatives": [
    {
      "QuoteAlternativeId": 471,
      "ERPQuoteAlternativeKey": "rerum",
      "QuoteVersionId": 566,
      "Name": "Connelly Inc and Sons",
      "Description": "Cross-group 5th generation pricing structure",
      "Status": "Error",
      "Reason": "",
      "ERPDiscountPercent": 22094.7,
      "ERPDiscountAmount": 15431.815999999999,
      "DiscountPercent": 9257.836,
      "DiscountAmount": 6330.6799999999994,
      "UserValueOverride": "DiscountAmount",
      "VATInfo": "quia",
      "VAT": 23956.296,
      "EarningPercent": 23808.998,
      "EarningAmount": 10132.222,
      "SubTotal": 25538.966,
      "TotalPrice": 26482.3,
      "ExtraField1": "non",
      "ExtraField2": "magni",
      "ExtraField3": "mollitia",
      "ExtraField4": "et",
      "ExtraField5": "non",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 611
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
      "FieldType": "System.String",
      "FieldLength": 916
    }
  }
}
```