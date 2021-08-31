---
title: GET User/currentPrincipal
id: v1User_GetCurrentPrincipal
---

# GET User/currentPrincipal

```http
GET /api/v1/User/currentPrincipal
```

Gets the currently logged in user's information, even in Online.

Does not call an agent - just returns the current session info.






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



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string |  |
| Associate | string |  |
| AssociateId | int32 |  |
| IsPerson | bool |  |
| PersonId | int32 |  |
| CountryId | int32 |  |
| HomeCountryId | int32 |  |
| ContactId | int32 |  |
| GroupId | int32 |  |
| BusinessId | int32 |  |
| CategoryId | int32 |  |
| ContactOwner | int32 |  |
| RoleId | int32 |  |
| RoleName | string |  |
| RoleDescription | string |  |
| RoleType | string |  |
| Licenses | array |  |
| FullName | string |  |
| EMailAddress | string |  |
| FunctionRights | array |  |
| EjUserId | int32 |  |
| EjAccessLevel | int32 |  |
| EjUserStatus | string |  |
| ProvidedCredentials | array |  |
| SecondaryGroups | array |  |
| DatabaseContextIdentifier | string |  |
| UserName | string |  |

## Sample Request

```http!
GET /api/v1/User/currentPrincipal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "enim",
  "AssociateId": 582,
  "IsPerson": true,
  "PersonId": 858,
  "CountryId": 593,
  "HomeCountryId": 208,
  "ContactId": 918,
  "GroupId": 619,
  "BusinessId": 899,
  "CategoryId": 200,
  "ContactOwner": 277,
  "RoleId": 585,
  "RoleName": "Powlowski Inc and Sons",
  "RoleDescription": "Secured regional focus group",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 172,
      "OwnerName": "Kilback, Bins and Turcotte",
      "OwnerDescription": "Customizable exuding strategy",
      "ModuleId": 9,
      "Name": "Mayer Group",
      "Description": "Front-line real-time structure",
      "Version": "voluptates",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 337,
      "ExtraInfo": "aut",
      "SortOrder": 524,
      "LicenseNumber": 222,
      "IsHidden": true,
      "IsUnrestricted": true,
      "ExpiryDate": "2010-05-21T15:05:43.1878995+02:00",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 604
        }
      }
    }
  ],
  "FullName": "Milan Lowe",
  "EMailAddress": "id",
  "FunctionRights": [
    "et",
    "quis"
  ],
  "EjUserId": 715,
  "EjAccessLevel": 214,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "voluptate",
      "SearchName": "Heathcote Group",
      "DisplayName": "Johnston, Barton and Hilpert",
      "CredentialId": 484
    },
    {
      "Type": "voluptate",
      "SearchName": "Heathcote Group",
      "DisplayName": "Johnston, Barton and Hilpert",
      "CredentialId": 484
    }
  ],
  "SecondaryGroups": [
    451,
    966
  ],
  "DatabaseContextIdentifier": "est",
  "UserName": "Connelly-Morar"
}
```