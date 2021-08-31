---
title: ValidateQuoteVersion
id: v1QuoteAgent_ValidateQuoteVersion
---

# ValidateQuoteVersion

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 331,
  "Action": "Approve"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "mollitia",
  "TechExplanation": "sequi",
  "ErrorCode": "placeat",
  "ChangedSale": {
    "ContactName": "Morissette LLC",
    "SaleDate": "2001-02-02T14:58:04.9324603+01:00",
    "SaleId": 563,
    "Probability": 99,
    "Title": "tenetur",
    "Amount": 21681.012,
    "Currency": "quasi",
    "ProjectName": "Kovacek, Schmeler and Hermiston",
    "AssociateFullName": "Miss Claire Armstrong",
    "Description": "Future-proofed tertiary initiative",
    "Status": "Lost",
    "WeightedAmount": 24097.326,
    "ProjectId": 460,
    "EarningPercent": 29798.072,
    "Earning": 4478.486,
    "ContactId": 735,
    "AssociateId": 419,
    "PersonId": 318,
    "SaleTypeId": 392,
    "SaleTypeName": "Weimann, Wuckert and Reichel",
    "PersonFullName": "Jesus Hodkiewicz",
    "Completed": "Completed",
    "ActiveErpLinks": 207,
    "NextDueDate": "1999-12-24T14:58:04.9324603+01:00",
    "Number": "1279902",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 561
      }
    }
  },
  "ChangedQuote": {
    "QuoteId": 80,
    "SaleId": 635,
    "QuoteConnectionId": 910,
    "ERPQuoteKey": "est",
    "ERPOrderKey": "quos",
    "ActiveQuoteVersionId": 856,
    "AcceptedQuoteAlternativeId": 583,
    "UseValuesFromQuote": 231,
    "DocumentId": 587,
    "PoNumber": "903539",
    "OrderComment": "adipisci",
    "PreferredEmailCulture": "garrick_botsford@kulas.ca",
    "ActiveQuoteVersion": {},
    "FavoriteQuoteAlternative": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 553
      }
    }
  },
  "ChangedQuoteVersion": {
    "QuoteVersionId": 457,
    "ERPQuoteVersionKey": "hic",
    "QuoteId": 851,
    "Description": "Grass-roots fault-tolerant application",
    "Number": "608146",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 126,
    "SentDate": "2017-11-08T14:58:04.9334545+01:00",
    "FollowupId": 227,
    "ExpirationDate": "1996-08-15T14:58:04.9334545+02:00",
    "DeliveryCountryId": 88,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 253,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "laudantium",
    "ERPPaymentTypeKey": "dolorem",
    "ERPDeliveryTermsKey": "et",
    "ERPDeliveryTypeKey": "qui",
    "Rank": 354,
    "ApprovedBy": 541,
    "ApprovedText": "voluptas",
    "ApprovedRegisteredBy": 942,
    "ApprovedRegisteredDate": "2010-09-23T14:58:04.9334545+02:00",
    "ExtraField1": "minima",
    "ExtraField2": "itaque",
    "ExtraField3": "necessitatibus",
    "ExtraField4": "doloremque",
    "ExtraField5": "vero",
    "LastRecalculated": "2014-09-18T14:58:04.9334545+02:00",
    "Updated": "2008-05-25T14:58:04.9334545+02:00",
    "UpdatedAssociateId": 371,
    "Registered": "1995-12-29T14:58:04.9334545+01:00",
    "RegisteredAssociateId": 679,
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
        "FieldLength": 562
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
          "FieldType": "System.Int32",
          "FieldLength": 24
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
          "FieldType": "System.Int32",
          "FieldLength": 24
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
      "FieldLength": 901
    }
  }
}
```