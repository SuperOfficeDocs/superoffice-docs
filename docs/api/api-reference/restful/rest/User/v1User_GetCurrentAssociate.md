---
title: GET User/currentAssociate
id: v1User_GetCurrentAssociate
---

# GET User/currentAssociate

```http
GET /api/v1/User/currentAssociate
```

Gets the currently logged in user's associate information (username, associate id, role)

Calls the Associate agent service GetAssociate.






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

Carrier object for Associate.
Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, also login name, possibly database user name |
| PersonId | int32 | Owning person record  <para>Use MDO List name "person" to get list items.</para> |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| Type | string | User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| GroupIdx | int32 | Primary group membership, see UserGroupLink for secondary memberships |
| FullName | string | The associate's culture formatted fullname (firstname, middleName and lastname) |
| FormalName | string | The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| Deleted | bool | If true, the user is retired and should have no rights, not appear in lists, etc. |
| EjUserId | int32 | ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| UserName | string | User name |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/User/currentAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 348,
  "Name": "McGlynn-Marquardt",
  "PersonId": 724,
  "Rank": 818,
  "Tooltip": "sit",
  "Type": "AnonymousAssociate",
  "GroupIdx": 824,
  "FullName": "Dan Schoen II",
  "FormalName": "Emmerich LLC",
  "Deleted": false,
  "EjUserId": 712,
  "UserName": "Rau, Spencer and Bashirian",
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
      "FieldLength": 355
    }
  }
}
```