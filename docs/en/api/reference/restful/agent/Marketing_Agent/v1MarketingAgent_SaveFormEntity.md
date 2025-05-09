---
title: POST Agents/Marketing/SaveFormEntity
uid: v1MarketingAgent_SaveFormEntity
generated: true
---

# POST Agents/Marketing/SaveFormEntity

```http
POST /api/v1/Agents/Marketing/SaveFormEntity
```

Updates the existing FormEntity or creates a new FormEntity if the id parameter is empty








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

## Request Body: entity 

The FormEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FormId | Integer | Primary key |
| FormKey | String | A short string used as unique id to access this form |
| Name | String | The name of this form |
| Description | String | Detailed description |
| Config | String | The JSON-formatted config of this form |
| FolderId | Integer | The folder which this form belongs to. -1 indicates that the shipment is on the root |
| ScriptId | Integer | The CRMScript Macro which will be run when the form is submitted. |
| ResponseShipmentId | Integer | The id of the s_shipment that is used to send the response mails |
| Active | Boolean | Indicates if this form is active or not |
| Expires | String | After this datetime, the form will become inactive |
| MaxSubmits | Integer | After this number of submits, the form will become inactive |
| Type | String | What kind of form is this? Indicates if this is a normal form or a template |
| Recipe | String | The JSON-formatted recipe of this form |
| GroupId | Integer | The group which this form belongs to. |
| NewTicket | Boolean | Indicates if this form creates a ticket or not |
| RecaptchaMode | String | What is the state of the recaptcha configuration? This is a read-only member |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |
| UpdatedCount | Integer | Number of updates made to this record |
| EmailFlows | Array | EmailFlows this form is used in (read-only) |
| FolderName | String | The name of the folder for this form |

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
POST /api/v1/Agents/Marketing/SaveFormEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "FormId": 482,
  "FormKey": "cumque",
  "Name": "Hettinger Inc and Sons",
  "Description": "Monitored background hierarchy",
  "Config": "qui",
  "FolderId": 640,
  "ScriptId": 427,
  "ResponseShipmentId": 530,
  "Active": false,
  "Expires": "2011-05-07T16:32:39.3363462+02:00",
  "MaxSubmits": 585,
  "Type": "Normal",
  "Recipe": "occaecati",
  "GroupId": 517,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2005-03-22T16:32:39.3363462+01:00",
  "RegisteredAssociateId": 66,
  "Updated": "2018-05-30T16:32:39.3363462+02:00",
  "UpdatedAssociateId": 160,
  "UpdatedCount": 159,
  "EmailFlows": [
    148,
    450
  ],
  "FolderName": "Walter LLC"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormId": 194,
  "FormKey": "rem",
  "Name": "Reinger-Hudson",
  "Description": "Persevering eco-centric internet solution",
  "Config": "nesciunt",
  "FolderId": 424,
  "ScriptId": 557,
  "ResponseShipmentId": 102,
  "Active": false,
  "Expires": "2017-04-26T16:32:39.3363462+02:00",
  "MaxSubmits": 872,
  "Type": "Normal",
  "Recipe": "illo",
  "GroupId": 1000,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2006-01-07T16:32:39.3363462+01:00",
  "RegisteredAssociateId": 511,
  "Updated": "2006-11-13T16:32:39.3363462+01:00",
  "UpdatedAssociateId": 812,
  "UpdatedCount": 565,
  "EmailFlows": [
    780,
    442
  ],
  "FolderName": "Welch-Ernser",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 239
    }
  }
}
```