---
title: POST Agents/Quote/ValidateQuoteVersion
id: v1QuoteAgent_ValidateQuoteVersion
---

# POST Agents/Quote/ValidateQuoteVersion

```http
POST /api/v1/Agents/Quote/ValidateQuoteVersion
```

When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT.

ValidateQuoteVersion shall be called when the user presses the validate button, presses the send button or closes the quote dialog. RecalculateQuoteAlternative should typically validate all alternatives, set values in extrafields, and set the state in the version.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/ValidateQuoteVersion?$select=name,department,category/id
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

QuoteVersionId, Action 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 |  |
| Action | string |  |


## Response: object

The QuoteVersionValidated is returned after a call to ValidateQuoteAlternative. It contains flags indicating changes to quote, quoteversion/quotealternative and quotelines.



Carrier object for QuoteVersionValidated.
Services for the QuoteVersionValidated Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsOk | bool | Answer to the question / An indication if the operation went well. |
| UserExplanation | string | A localized explanation to the answer. |
| TechExplanation | string | Always in English |
| ErrorCode | string | An error code, if available. |
| ChangedSale |  | If the sale has been changed, the carrier will be added. |
| ChangedQuote |  | The validated version is a member of Quote |
| ChangedQuoteVersion |  | The validated QuoteVersion |
| ChangedQuoteAlternatives | array | The changed QuoteAlternatives |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/ValidateQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 980,
  "Action": "Approve"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": true,
  "UserExplanation": "illo",
  "TechExplanation": "voluptatem",
  "ErrorCode": "consequuntur",
  "ChangedSale": {
    "ContactName": "Ryan-Gorczany",
    "SaleDate": "1999-03-03T18:28:49.9141372+01:00",
    "SaleId": 878,
    "Probability": 935,
    "Title": "tempore",
    "Amount": 4403.2699999999995,
    "Currency": "et",
    "ProjectName": "Lesch-Dare",
    "AssociateFullName": "Camila Koepp",
    "Description": "Switchable secondary orchestration",
    "Status": "Lost",
    "WeightedAmount": 4409.538,
    "ProjectId": 326,
    "EarningPercent": 12557.938,
    "Earning": 2287.8199999999997,
    "ContactId": 766,
    "AssociateId": 654,
    "PersonId": 425,
    "SaleTypeId": 9,
    "SaleTypeName": "King, Considine and Prohaska",
    "PersonFullName": "Andy Grady",
    "Completed": "Completed",
    "ActiveErpLinks": 967,
    "NextDueDate": "2008-05-12T18:28:49.9151085+02:00",
    "Number": "719505",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 123
      }
    }
  },
  "ChangedQuote": {
    "QuoteId": 456,
    "SaleId": 634,
    "QuoteConnectionId": 224,
    "ERPQuoteKey": "totam",
    "ERPOrderKey": "ullam",
    "ActiveQuoteVersionId": 206,
    "AcceptedQuoteAlternativeId": 868,
    "UseValuesFromQuote": 579,
    "DocumentId": 386,
    "PoNumber": "1326519",
    "OrderComment": "fugit",
    "PreferredEmailCulture": "ada@jacobsjohnston.info",
    "ActiveQuoteVersion": {},
    "FavoriteQuoteAlternative": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 535
      }
    }
  },
  "ChangedQuoteVersion": {
    "QuoteVersionId": 679,
    "ERPQuoteVersionKey": "ex",
    "QuoteId": 377,
    "Description": "Managed exuding toolset",
    "Number": "929495",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 542,
    "SentDate": "2017-10-31T18:28:49.9161089+01:00",
    "FollowupId": 153,
    "ExpirationDate": "1996-02-29T18:28:49.9161089+01:00",
    "DeliveryCountryId": 836,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 677,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "quia",
    "ERPPaymentTypeKey": "neque",
    "ERPDeliveryTermsKey": "quas",
    "ERPDeliveryTypeKey": "magnam",
    "Rank": 363,
    "ApprovedBy": 728,
    "ApprovedText": "odit",
    "ApprovedRegisteredBy": 829,
    "ApprovedRegisteredDate": "2000-04-04T18:28:49.9161089+02:00",
    "ExtraField1": "earum",
    "ExtraField2": "odio",
    "ExtraField3": "quam",
    "ExtraField4": "mollitia",
    "ExtraField5": "voluptatibus",
    "LastRecalculated": "1998-08-01T18:28:49.9161089+02:00",
    "Updated": "1996-02-02T18:28:49.9161089+01:00",
    "UpdatedAssociateId": 127,
    "Registered": "2014-12-18T18:28:49.9161089+01:00",
    "RegisteredAssociateId": 273,
    "QuoteAlternatives": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 443
      }
    }
  },
  "ChangedQuoteAlternatives": [
    {
      "QuoteLinesHasChanged": false,
      "ChangedQuoteAlternative": {},
      "Changes": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 215
        }
      }
    },
    {
      "QuoteLinesHasChanged": false,
      "ChangedQuoteAlternative": {},
      "Changes": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 215
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
      "FieldLength": 894
    }
  }
}
```