---
title: POST PreferenceDescription
uid: v1PreferenceDescription_PostPreferenceDescription
generated: true
---

# POST PreferenceDescription

```http
POST /api/v1/PreferenceDescription
```

Creates a new PreferenceDescription


Calls the Preference agent service SavePreferenceDescription.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/PreferenceDescription?$select=name,department,category/id
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

## Request Body: newEntity 

The PreferenceDescription to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescId | Integer | Primary key |
| Section | String | Preference section name |
| Key | String | Preference key name |
| Name | String | Multi-language name |
| ValueType | String | 1=number, 2=text, 3=bool, 4=list of values; 5=list table ref; 6=contact ID, 7=Person ID, 8=Project ID, 9=Selection ID |
| MaxLevel | String | Lowest allowed setting level, set by user, but not lower than sysMaxLevel |
| SysMaxLevel | String | Lowest allowed setting level, set by SuperOffice |
| AccessFlags | String | 1=wizard mode, 2=level 0, 4=admin gui, 8=crm gui |
| Description | String | Description of preference, multi-language parsed |
| IsBuiltin | Boolean | 1 = This row populated and maintained by SuperOffice |
| TableName | String | If valueType = 5, then TableName contains the table referenced by the preference |
| UserDefinedListId | Integer | Read-only field, If valueType = 5, and TableName is UDList, then UserdefinedLIstId contains the id of the list referenced by the preference |
| Rank | Integer | Rank field for ordering sections, and keys within sections |
| SubGroup | String | Keys that share a value (including NULL) in this field are shown together; a visual spacer is shown between groups |
| MinLevel | Integer | The minimum (furthest away from User) level this preference can be set for |
| MaxValue | Integer | Max value (if type 1); list table ID (if type 5) |
| MinValue | Integer | Min value (if type 1); list extra id (if type 5) |
| RequiredLicense | String | Licenses the user/installation must have if this reference is to be shown. Comma-separated list of owner.module pairs |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreferenceDescriptionWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescId | int32 | Primary key |
| Section | string | Preference section name |
| Key | string | Preference key name |
| Name | string | Multi-language name |
| ValueType | string | 1=number, 2=text, 3=bool, 4=list of values; 5=list table ref; 6=contact ID, 7=Person ID, 8=Project ID, 9=Selection ID |
| MaxLevel | string | Lowest allowed setting level, set by user, but not lower than sysMaxLevel |
| SysMaxLevel | string | Lowest allowed setting level, set by SuperOffice |
| AccessFlags | string | 1=wizard mode, 2=level 0, 4=admin gui, 8=crm gui |
| Description | string | Description of preference, multi-language parsed |
| IsBuiltin | bool | 1 = This row populated and maintained by SuperOffice |
| TableName | string | If valueType = 5, then TableName contains the table referenced by the preference |
| UserDefinedListId | int32 | Read-only field, If valueType = 5, and TableName is UDList, then UserdefinedLIstId contains the id of the list referenced by the preference |
| Rank | int32 | Rank field for ordering sections, and keys within sections |
| SubGroup | string | Keys that share a value (including NULL) in this field are shown together; a visual spacer is shown between groups |
| MinLevel | int32 | The minimum (furthest away from User) level this preference can be set for |
| MaxValue | int32 | Max value (if type 1); list table ID (if type 5) |
| MinValue | int32 | Min value (if type 1); list extra id (if type 5) |
| RequiredLicense | string | Licenses the user/installation must have if this reference is to be shown. Comma-separated list of owner.module pairs |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/PreferenceDescription
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PrefDescId": 321,
  "Section": "optio",
  "Key": "amet",
  "Name": "Roberts Group",
  "ValueType": "Bool",
  "MaxLevel": "Database",
  "SysMaxLevel": "Database",
  "AccessFlags": "adminGUI",
  "Description": "Proactive scalable capacity",
  "IsBuiltin": false,
  "TableName": "Veum, Weimann and Hauck",
  "UserDefinedListId": 478,
  "Rank": 180,
  "SubGroup": "distinctio",
  "MinLevel": 358,
  "MaxValue": 474,
  "MinValue": 784,
  "RequiredLicense": "fugiat"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PrefDescId": 954,
  "Section": "dolore",
  "Key": "quam",
  "Name": "Jacobi-Keebler",
  "ValueType": "Bool",
  "MaxLevel": "Database",
  "SysMaxLevel": "Database",
  "AccessFlags": "adminGUI",
  "Description": "Cross-group bandwidth-monitored superstructure",
  "IsBuiltin": true,
  "TableName": "Nolan, Brakus and Hickle",
  "UserDefinedListId": 655,
  "Rank": 449,
  "SubGroup": "nostrum",
  "MinLevel": 232,
  "MaxValue": 122,
  "MinValue": 405,
  "RequiredLicense": "deserunt",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 707
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```