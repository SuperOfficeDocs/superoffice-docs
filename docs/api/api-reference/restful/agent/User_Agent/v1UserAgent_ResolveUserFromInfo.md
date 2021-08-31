---
title: ResolveUserFromInfo
id: v1UserAgent_ResolveUserFromInfo
---

# ResolveUserFromInfo

```http
POST /api/v1/Agents/User/ResolveUserFromInfo
```

Get a user from the provided information.

If the user or associated person does not exist, it will be created on demand.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/ResolveUserFromInfo?$select=name,department,category/id
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

ContactId, PersonName, PhoneNumbers, Emails, UserType, Credential 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| PersonName | string |  |
| PhoneNumbers | array |  |
| Emails | array |  |
| UserType | string |  |
| Credential |  | Credentials supported for authentication <para /> Carrier object for Credential. Services for the Credential Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |


## Response: object

The User Service. The service implements all services working with the User object.



Carrier object for ResolvedUser.
Services for the ResolvedUser Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| User |  | The resolved User instance. |
| PersonCreated | bool | Indicates if the resolved person was created or not. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/User/ResolveUserFromInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 11,
  "PersonName": "Feest Group",
  "PhoneNumbers": [
    "760680",
    "1360190"
  ],
  "Emails": [
    "lera@beahankerluke.us",
    "jason_langworth@russel.info"
  ],
  "UserType": "AnonymousAssociate",
  "Credential": {
    "Type": {},
    "Value": "consequatur",
    "DisplayValue": "et"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "User": {
    "AssociateId": 55,
    "Name": "Hamill-Walsh",
    "Rank": 280,
    "Tooltip": "provident",
    "LicenseOwners": [
      {},
      {}
    ],
    "Role": {},
    "UserGroup": {},
    "OtherGroups": [
      {},
      {}
    ],
    "Person": {},
    "Deleted": true,
    "Lastlogin": "2012-04-20T14:58:05.4226249+02:00",
    "Lastlogout": "2012-01-14T14:58:05.4226249+01:00",
    "EjUserId": 956,
    "RequestSignature": "eos",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": true,
    "Credentials": [
      {},
      {}
    ],
    "UserName": "Kling, Langworth and Schumm",
    "TicketCategories": [
      {},
      {}
    ],
    "NickName": "Hand Inc and Sons",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "incidunt",
      "ExtraFields2": "deserunt"
    },
    "CustomFields": {
      "CustomFields1": "qui",
      "CustomFields2": "voluptas"
    },
    "PostSaveCommands": [
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
        "FieldType": "System.String",
        "FieldLength": 827
      }
    }
  },
  "PersonCreated": true,
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
      "FieldLength": 272
    }
  }
}
```