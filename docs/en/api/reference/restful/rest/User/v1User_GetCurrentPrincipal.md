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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "quam",
  "AssociateId": 600,
  "IsPerson": false,
  "PersonId": 792,
  "CountryId": 678,
  "HomeCountryId": 538,
  "ContactId": 844,
  "GroupId": 333,
  "BusinessId": 802,
  "CategoryId": 109,
  "ContactOwner": 208,
  "RoleId": 831,
  "RoleName": "Pollich, Spinka and Walker",
  "RoleDescription": "Devolved assymetric matrix",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 378,
      "OwnerName": "Wehner-Vandervort",
      "OwnerDescription": "Devolved intangible parallelism",
      "ModuleId": 515,
      "Name": "Prosacco, Conroy and Fadel",
      "Description": "Function-based cohesive knowledge user",
      "Version": "culpa",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 648,
      "ExtraInfo": "voluptatem",
      "SortOrder": 93,
      "LicenseNumber": 70,
      "IsHidden": false,
      "IsUnrestricted": false,
      "ExpiryDate": "2021-11-28T17:37:39.5924394+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 486
        }
      }
    }
  ],
  "FullName": "Abbey Franecki",
  "EMailAddress": "est",
  "FunctionRights": [
    "aut",
    "adipisci"
  ],
  "EjUserId": 236,
  "EjAccessLevel": 814,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "delectus",
      "SearchName": "Becker, Swaniawski and Reichel",
      "DisplayName": "Collins, Lindgren and Labadie",
      "CredentialId": 243
    },
    {
      "Type": "delectus",
      "SearchName": "Becker, Swaniawski and Reichel",
      "DisplayName": "Collins, Lindgren and Labadie",
      "CredentialId": 243
    }
  ],
  "SecondaryGroups": [
    125,
    176
  ],
  "DatabaseContextIdentifier": "in",
  "UserName": "White Inc and Sons"
}
```