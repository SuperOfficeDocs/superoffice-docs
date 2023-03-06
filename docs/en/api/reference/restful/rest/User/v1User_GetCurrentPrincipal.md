---
title: GET User/currentPrincipal
uid: v1User_GetCurrentPrincipal
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RecurrenceInfo

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

## Sample request

```http!
GET /api/v1/User/currentPrincipal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "at",
  "AssociateId": 94,
  "IsPerson": false,
  "PersonId": 768,
  "CountryId": 769,
  "HomeCountryId": 125,
  "ContactId": 491,
  "GroupId": 243,
  "BusinessId": 767,
  "CategoryId": 625,
  "ContactOwner": 586,
  "RoleId": 462,
  "RoleName": "Windler-Franecki",
  "RoleDescription": "Vision-oriented maximized pricing structure",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 669,
      "OwnerName": "Runolfsdottir-Wiegand",
      "OwnerDescription": "Synergized incremental hierarchy",
      "ModuleId": 892,
      "Name": "Murazik-Cronin",
      "Description": "Multi-tiered explicit superstructure",
      "Version": "qui",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 21,
      "ExtraInfo": "qui",
      "SortOrder": 372,
      "LicenseNumber": 704,
      "IsHidden": true,
      "IsUnrestricted": false,
      "ExpiryDate": "2001-05-03T14:19:11.0686043+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 143
        }
      }
    }
  ],
  "FullName": "Evans Murphy",
  "EMailAddress": "quas",
  "FunctionRights": [
    "sint",
    "ullam"
  ],
  "EjUserId": 669,
  "EjAccessLevel": 305,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "optio",
      "SearchName": "Dietrich-Kuhlman",
      "DisplayName": "Boyer-Kuhic",
      "CredentialId": 562
    },
    {
      "Type": "optio",
      "SearchName": "Dietrich-Kuhlman",
      "DisplayName": "Boyer-Kuhic",
      "CredentialId": 562
    }
  ],
  "SecondaryGroups": [
    329,
    144
  ],
  "DatabaseContextIdentifier": "iure",
  "UserName": "Keebler Group"
}
```