---
title: POST Agents/ForeignSystem/GetAppByName
id: v1ForeignSystemAgent_GetAppByName
---

# POST Agents/ForeignSystem/GetAppByName

```http
POST /api/v1/Agents/ForeignSystem/GetAppByName
```

Gets the ForeignApp with the given name.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetAppByName?$select=name,department,category/id
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

ApplicationName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | string |  |


## Response: object

Carrier object for ForeignAppEntity.
Services for the ForeignAppEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy |  | The person that created the foreign application. |
| UpdatedBy |  | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/GetAppByName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Skiles Inc and Sons"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 32,
  "Name": "Doyle-Fisher",
  "CreatedDate": "2005-06-17T18:28:49.2031229+02:00",
  "UpdatedDate": "1997-03-04T18:28:49.2031229+01:00",
  "CreatedBy": {
    "AssociateId": 590,
    "Name": "Sawayn, Ratke and Wintheiser",
    "PersonId": 374,
    "Rank": 882,
    "Tooltip": "blanditiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 6,
    "FullName": "Adele Anderson",
    "FormalName": "Lehner-Buckridge",
    "Deleted": false,
    "EjUserId": 500,
    "UserName": "Leannon Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 611
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 422,
    "Name": "Dietrich, Kerluke and Kulas",
    "PersonId": 990,
    "Rank": 534,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 700,
    "FullName": "Roslyn Frami",
    "FormalName": "Wolff, Blick and Rempel",
    "Deleted": false,
    "EjUserId": 165,
    "UserName": "Raynor-Krajcik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 745
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 478,
      "Name": "Ritchie-Prosacco",
      "CreatedDate": "1999-10-10T18:28:49.204123+02:00",
      "UpdatedDate": "2016-05-10T18:28:49.204123+02:00",
      "AssociateFullName": "Vaughn Barrows",
      "CreatedBy": "sit",
      "UpdatedBy": "perferendis",
      "DeviceIdentifier": "unde",
      "ForeignAppId": 343,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "deliver integrated e-services"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 703
    }
  }
}
```