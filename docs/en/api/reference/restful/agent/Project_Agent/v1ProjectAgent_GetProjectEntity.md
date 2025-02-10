---
title: POST Agents/Project/GetProjectEntity
uid: v1ProjectAgent_GetProjectEntity
generated: true
---

# POST Agents/Project/GetProjectEntity

```http
POST /api/v1/Agents/Project/GetProjectEntity
```

Gets a ProjectEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEntity?projectEntityId=512
POST /api/v1/Agents/Project/GetProjectEntity?$select=name,department,category/id
```


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

### Response body: ProjectEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/GetProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 157,
  "Name": "Rosenbaum-Lowe",
  "ProjectNumber": "1191238",
  "ProjectMembers": [
    {
      "ProjectmemberId": 463,
      "ContactId": 981,
      "ProjectId": 213,
      "ContactName": "Dach Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Little Inc and Sons",
      "EmailId": 85,
      "EmailAddress": "maia@littelkeebler.ca",
      "CountryId": 166,
      "Firstname": "Edwin",
      "MiddleName": "Hettinger-Abshire",
      "Lastname": "Schuster",
      "PersonId": 345,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Weimann, Bode and McClure",
      "Phone": "628.888.6990 x45498",
      "PhoneId": 941,
      "ProjectMemberTypeId": 446,
      "EmailAddressName": "zola_wuckert@rempel.co.uk",
      "Comment": "expedita",
      "FullName": "Ali Kuvalis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 108
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "De-engineered object-oriented support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 677
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "De-engineered object-oriented support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 677
        }
      }
    }
  ],
  "CreatedDate": "2000-12-28T12:01:28.1503067+01:00",
  "UpdatedDate": "2007-06-08T12:01:28.1503067+02:00",
  "Description": "Integrated global success",
  "Postit": "laudantium",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Cloned intermediate access",
  "ActiveStatusMonitorId": 200,
  "Links": [
    {
      "EntityName": "Ankunding-Shields",
      "Id": 926,
      "Description": "Progressive zero tolerance projection",
      "ExtraInfo": "vero",
      "LinkId": 459,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    }
  ],
  "ActiveLinks": 462,
  "Completed": true,
  "NextMilestoneDate": "2008-04-10T12:01:28.1503067+02:00",
  "NmdAppointmentId": 2,
  "EndDate": "2019-07-24T12:01:28.1503067+02:00",
  "ActiveErpLinks": 379,
  "UserDefinedFields": {
    "SuperOffice:1": "Bailey Brown",
    "SuperOffice:2": "Mrs. Libby Hannah Frami III"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "natus"
  },
  "PublishEventDate": "2014-02-28T12:01:28.1503067+01:00",
  "PublishTo": "2004-02-09T12:01:28.1503067+01:00",
  "PublishFrom": "2004-04-21T12:01:28.1503067+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 843
    }
  }
}
```