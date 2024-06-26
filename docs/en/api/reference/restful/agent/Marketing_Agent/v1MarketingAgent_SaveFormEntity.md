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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FormId": 990,
  "FormKey": "non",
  "Name": "Stark, Goldner and Balistreri",
  "Description": "Digitized regional local area network",
  "Config": "voluptatum",
  "FolderId": 455,
  "ScriptId": 594,
  "ResponseShipmentId": 888,
  "Active": false,
  "Expires": "2014-05-22T04:22:27.0653754+02:00",
  "MaxSubmits": 774,
  "Type": "Normal",
  "Recipe": "quia",
  "GroupId": 618,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2015-04-11T04:22:27.0653754+02:00",
  "RegisteredAssociateId": 651,
  "Updated": "1999-03-15T04:22:27.0653754+01:00",
  "UpdatedAssociateId": 182,
  "UpdatedCount": 744,
  "EmailFlows": [
    44,
    799
  ],
  "FolderName": "Cormier-Frami"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormId": 539,
  "FormKey": "ipsum",
  "Name": "Koss-Beer",
  "Description": "Public-key discrete ability",
  "Config": "nam",
  "FolderId": 498,
  "ScriptId": 229,
  "ResponseShipmentId": 142,
  "Active": true,
  "Expires": "2010-08-05T04:22:27.0653754+02:00",
  "MaxSubmits": 632,
  "Type": "Normal",
  "Recipe": "sit",
  "GroupId": 742,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2007-11-21T04:22:27.0653754+01:00",
  "RegisteredAssociateId": 671,
  "Updated": "1997-09-28T04:22:27.0653754+02:00",
  "UpdatedAssociateId": 162,
  "UpdatedCount": 368,
  "EmailFlows": [
    192,
    904
  ],
  "FolderName": "Dibbert-Feil",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 260
    }
  }
}
```