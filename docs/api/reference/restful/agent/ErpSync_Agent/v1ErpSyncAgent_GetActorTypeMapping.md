---
title: POST Agents/ErpSync/GetActorTypeMapping
id: v1ErpSyncAgent_GetActorTypeMapping
---

# POST Agents/ErpSync/GetActorTypeMapping

```http
POST /api/v1/Agents/ErpSync/GetActorTypeMapping
```

Get the current mappings for one connection/actor; connection+actor type = unique key



## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetActorTypeMapping?$select=name,department,category/id
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

ErpConnectionId, ActorType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 |  |
| ActorType | string |  |


## Response: object

Mapping information for one Actor, contains array of field mappings (ERP &lt;-&gt; SuperOffice)



Carrier object for ErpSyncActorTypeMapping.
Services for the ErpSyncActorTypeMapping Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IErpSyncAgent">ErpSync Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 | Primary key |
| IsActive | bool | Is this sync mapping active |
| FieldMappings | array | Array of individual field mappings; explicitly map to empty CrmFieldKey to indicate non-sync |
| ActorTypeErp | string | The actor type (ERP side) |
| ActorTypeCrm | string | The actor type (CRM side) |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ErpSync/GetActorTypeMapping
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 770,
  "ActorType": "Customer"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 934,
  "IsActive": true,
  "FieldMappings": [
    {
      "ErpFieldId": 733,
      "CrmFieldKey": "et",
      "CrmDisplayName": "Boyer Inc and Sons",
      "CrmDisplayTooltip": "consectetur",
      "ErpFieldKey": "cumque",
      "FieldType": "Checkbox",
      "ErpDisplayName": "Cummerata Inc and Sons",
      "ErpDisplayTooltip": "soluta",
      "SyncToCrm": false,
      "SyncToErp": false,
      "ShowInGui": false,
      "ShowInSearch": true,
      "AlreadyMapped": true,
      "MissingInERP": false,
      "MissingInCRM": false,
      "Access": "Mandatory",
      "ListReference": "dolores",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize mission-critical eyeballs"
          },
          "FieldType": "System.String",
          "FieldLength": 246
        }
      }
    }
  ],
  "ActorTypeErp": "Customer",
  "ActorTypeCrm": "Contact",
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
      "FieldLength": 744
    }
  }
}
```