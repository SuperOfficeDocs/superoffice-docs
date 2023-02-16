---
title: POST Agents/Marketing/CreateDefaultFormEntity
uid: v1MarketingAgent_CreateDefaultFormEntity
---

# POST Agents/Marketing/CreateDefaultFormEntity

```http
POST /api/v1/Agents/Marketing/CreateDefaultFormEntity
```

Set default values into a new FormEntity.


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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: FormEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| FormId | int32 | Primary key |
| FormKey | string | A short string used as unique id to access this form |
| Name | string | The name of this form |
| Description | string | Detailed description |
| Config | string | The JSON-formatted config of this form |
| FolderId | int32 | The folder which this form belongs to. -1 indicates that the shipment is on the root |
| ScriptId | int32 | The CRMScript Macro which will be run when the form is submitted. |
| ResponseShipmentId | int32 | The id of the s_shipment that is used to send the response mails |
| Active | bool | Indicates if this form is active or not |
| Expires | date-time | After this datetime, the form will become inactive |
| MaxSubmits | int32 | After this number of submits, the form will become inactive |
| Type | string | What kind of form is this? Indicates if this is a normal form or a template |
| Recipe | string | The JSON-formatted recipe of this form |
| GroupId | int32 | The group which this form belongs to. |
| NewTicket | bool | Indicates if this form creates a ticket or not |
| RecaptchaMode | string | What is the state of the recaptcha configuration? This is a read-only member |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |
| FolderName | string | The name of the folder for this form |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Marketing/CreateDefaultFormEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormId": 325,
  "FormKey": "quia",
  "Name": "Prosacco, Schamberger and Balistreri",
  "Description": "Streamlined 5th generation contingency",
  "Config": "eum",
  "FolderId": 575,
  "ScriptId": 571,
  "ResponseShipmentId": 654,
  "Active": false,
  "Expires": "1999-05-13T14:19:03.7019992+02:00",
  "MaxSubmits": 488,
  "Type": "Normal",
  "Recipe": "et",
  "GroupId": 797,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "1999-03-10T14:19:03.7019992+01:00",
  "RegisteredAssociateId": 874,
  "Updated": "2014-09-09T14:19:03.7019992+02:00",
  "UpdatedAssociateId": 24,
  "UpdatedCount": 288,
  "FolderName": "Mohr-Luettgen",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 508
    }
  }
}
```