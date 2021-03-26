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
  "Associate": "autem",
  "AssociateId": 203,
  "IsPerson": false,
  "PersonId": 195,
  "CountryId": 679,
  "HomeCountryId": 83,
  "ContactId": 3,
  "GroupId": 174,
  "BusinessId": 889,
  "CategoryId": 751,
  "ContactOwner": 61,
  "RoleId": 173,
  "RoleName": "Green, Satterfield and Simonis",
  "RoleDescription": "Visionary neutral help-desk",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 791,
      "OwnerName": "Yundt, Cartwright and Mitchell",
      "OwnerDescription": "Monitored tertiary process improvement",
      "ModuleId": 927,
      "Name": "Schaefer-Carroll",
      "Description": "Implemented upward-trending knowledge base",
      "Version": "voluptate",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 525,
      "ExtraInfo": "quidem",
      "SortOrder": 554,
      "LicenseNumber": 442,
      "IsHidden": true,
      "IsUnrestricted": false,
      "ExpiryDate": "2019-03-31T09:41:00.1062155+02:00",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "reintermediate e-business action-items"
          },
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "FullName": "Filiberto Schowalter",
  "EMailAddress": "impedit",
  "FunctionRights": [
    "ut",
    "ut"
  ],
  "EjUserId": 248,
  "EjAccessLevel": 401,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "quibusdam",
      "SearchName": "Reichert Group",
      "DisplayName": "Bartoletti-Dare",
      "CredentialId": 264
    },
    {
      "Type": "quibusdam",
      "SearchName": "Reichert Group",
      "DisplayName": "Bartoletti-Dare",
      "CredentialId": 264
    }
  ],
  "SecondaryGroups": [
    641,
    239
  ],
  "DatabaseContextIdentifier": "et",
  "UserName": "Legros-Champlin"
}
```