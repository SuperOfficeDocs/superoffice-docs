---
title: POST Agents/EMail/GetFolderInfo
id: v1EMailAgent_GetFolderInfo
---

# POST Agents/EMail/GetFolderInfo

```http
POST /api/v1/Agents/EMail/GetFolderInfo
```

Retrieve information about folders.

If folders parameter is not specified(null), information about all subscribed folders will be returned.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetFolderInfo?$select=name,department,category/id
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

ConnectionInfo, Folders 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| Folders | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Name of folder |
| Delimiter | string | The character which is used to delimit folder levels on the server |
| Flags | string | Flags associated with the folder |
| TotalItems | int32 | Total number of messages in the folder |
| UnreadItems | int32 | Number of unread messages in the folder |
| Subscribed | bool | Indicates if the folder is subscribed to |
| EmailFolderId | int32 | Primary key |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/GetFolderInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": {
    "ServerName": "Abshire-Hilll",
    "UserName": "Paucek Group",
    "Password": "vero",
    "Folder": "tempore",
    "UseSSL": false
  },
  "Folders": [
    "quis",
    "eaque"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Padberg Group",
    "Delimiter": "eligendi",
    "Flags": "nesciunt",
    "TotalItems": 145,
    "UnreadItems": 803,
    "Subscribed": false,
    "EmailFolderId": 401,
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
        "FieldLength": 29
      }
    }
  }
]
```