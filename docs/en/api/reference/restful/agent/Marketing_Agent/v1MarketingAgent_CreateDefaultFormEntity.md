---
title: POST Agents/Marketing/CreateDefaultFormEntity
uid: v1MarketingAgent_CreateDefaultFormEntity
generated: true
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
| EmailFlows | array | EmailFlows this form is used in (read-only) |
| FolderName | string | The name of the folder for this form |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Marketing/CreateDefaultFormEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormId": 765,
  "FormKey": "accusamus",
  "Name": "Gibson LLC",
  "Description": "Front-line fresh-thinking emulation",
  "Config": "consequatur",
  "FolderId": 218,
  "ScriptId": 739,
  "ResponseShipmentId": 236,
  "Active": false,
  "Expires": "2009-12-04T14:13:40.5628193+01:00",
  "MaxSubmits": 471,
  "Type": "Normal",
  "Recipe": "et",
  "GroupId": 222,
  "NewTicket": true,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2004-12-02T14:13:40.5628193+01:00",
  "RegisteredAssociateId": 458,
  "Updated": "2014-12-18T14:13:40.5628193+01:00",
  "UpdatedAssociateId": 164,
  "UpdatedCount": 59,
  "EmailFlows": [
    40,
    257
  ],
  "FolderName": "Feeney Group",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 842
    }
  }
}
```