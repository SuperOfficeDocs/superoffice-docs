---
title: POST Agents/Selection/CreateDefaultMailMergeSettings
id: v1SelectionAgent_CreateDefaultMailMergeSettings
---

# POST Agents/Selection/CreateDefaultMailMergeSettings

```http
POST /api/v1/Agents/Selection/CreateDefaultMailMergeSettings
```

Set default values into a new MailMergeSettings.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Settings specifying what selection to perform the mailmerge on, what merge document to use etc.



Carrier object for MailMergeSettings.
Services for the MailMergeSettings Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISelectionAgent">Selection Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 | Identity of selection to use as source for recipients. |
| DocumentId | int32 | Identity of document to be used as merge draft. |
| MailMergeDeliveryType | string | How the merged document is delivered to the recipients. |
| CustomAttention | string | Custom value for attention. |
| AlwaysUseCustomAttention | bool | Should custom attention always be used? If false, only use custom attention where there is no default. |
| SaveDocument | bool | Should we save a reference to the merge document on each recipient. |
| CustomMailBody | string | If specified, use this value as default mail body. |
| TaskEntity |  | If specified, register a task on recipients using properties from this object. |
| AddCompanyInterest | int32 | Add this company interest to each company recipient. |
| AddPersonInterest | int32 | Add this person interest to each person recipient. |
| RemoveCompanyInterest | int32 | Remove this company interest on each company recipient. |
| RemovePersonInterest | int32 | Remove this person interest on each person recipient. |
| IncludeNoMailingsRecipient | bool | Include recipients that are marked with NoMailings |
| TestOnly | bool | If true, do the merge task, but use current user as target, instead of selection members |
| ProjectId | int32 | Identity of project to use as source for recipients. |
| IncludeRetiredRecipients | bool | Include recipients that are marked as retired |
| IncludeStoppedRecipients | bool | Include recipients that are marked with stop |
| CustomMailSubject | string | If specified, use this value as default mail subject. |
| ExtraInfo | string | Used to store additional information for the delivery systems. |
| Synchronous | bool |  |
| IsTemporarySelection | bool | If true, the selection is a temporary selection that can be deleted later. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/CreateDefaultMailMergeSettings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 666,
  "DocumentId": 581,
  "MailMergeDeliveryType": "BestFit",
  "CustomAttention": "est",
  "AlwaysUseCustomAttention": false,
  "SaveDocument": true,
  "CustomMailBody": "ab",
  "TaskEntity": {
    "ProjectId": 789,
    "TypeId": 550,
    "StartDate": "2010-03-17T18:28:50.2124467+01:00",
    "Duration": 675,
    "Description": "Intuitive solution-oriented middleware",
    "PriorityId": 176,
    "VisibleFor": {},
    "Completed": "Completed",
    "OwnerAssociateId": 676,
    "SingleEntryOnEachCompany": false,
    "SaleId": 520,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 727
      }
    }
  },
  "AddCompanyInterest": 346,
  "AddPersonInterest": 469,
  "RemoveCompanyInterest": 582,
  "RemovePersonInterest": 299,
  "IncludeNoMailingsRecipient": true,
  "TestOnly": false,
  "ProjectId": 579,
  "IncludeRetiredRecipients": false,
  "IncludeStoppedRecipients": false,
  "CustomMailSubject": "aut",
  "ExtraInfo": "sunt",
  "Synchronous": false,
  "IsTemporarySelection": true,
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
      "FieldLength": 87
    }
  }
}
```