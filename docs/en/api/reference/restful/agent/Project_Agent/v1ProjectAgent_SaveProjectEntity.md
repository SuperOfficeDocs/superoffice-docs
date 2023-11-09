---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

## Request Body: entity 

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

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
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 321,
  "Name": "Champlin LLC",
  "ProjectNumber": "259366",
  "ProjectMembers": [
    {
      "ProjectmemberId": 492,
      "ContactId": 968,
      "ProjectId": 661,
      "ContactName": "Schmeler, Gibson and Stark",
      "ContactDepartment": "",
      "ProjectName": "Beahan, Mosciski and Kilback",
      "EmailId": 40,
      "EmailAddress": "carleton@lemke.name",
      "CountryId": 494,
      "Firstname": "Jessie",
      "MiddleName": "Trantow-Champlin",
      "Lastname": "Tromp",
      "PersonId": 568,
      "Mrmrs": "illo",
      "ProjectMemberTypeName": "Hudson-Zboncak",
      "Phone": "877.195.5471 x668",
      "PhoneId": 670,
      "ProjectMemberTypeId": 14,
      "EmailAddressName": "jessy@schambergerherzog.co.uk",
      "Comment": "fuga",
      "FullName": "Colton Ebert"
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "earum",
      "Description": "Centralized needs-based internet solution"
    },
    {
      "Value": "fuga",
      "StrippedValue": "earum",
      "Description": "Centralized needs-based internet solution"
    }
  ],
  "CreatedDate": "2016-12-20T11:06:35.1145647+01:00",
  "UpdatedDate": "2005-01-31T11:06:35.1145647+01:00",
  "Description": "Ergonomic 6th generation solution",
  "Postit": "voluptas",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Multi-layered human-resource functionalities",
  "ActiveStatusMonitorId": 153,
  "Links": [
    {
      "EntityName": "Dicki-Heller",
      "Id": 27,
      "Description": "Implemented mission-critical knowledge base",
      "ExtraInfo": "consequatur",
      "LinkId": 738
    },
    {
      "EntityName": "Dicki-Heller",
      "Id": 27,
      "Description": "Implemented mission-critical knowledge base",
      "ExtraInfo": "consequatur",
      "LinkId": 738
    }
  ],
  "ActiveLinks": 977,
  "Completed": true,
  "NextMilestoneDate": "1999-01-14T11:06:35.1145647+01:00",
  "NmdAppointmentId": 840,
  "EndDate": "2001-11-21T11:06:35.1145647+01:00",
  "ActiveErpLinks": 380,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Mathilde Collins",
    "SuperOffice:2": "Hulda Sporer III"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "et"
  },
  "PublishEventDate": "1998-11-15T11:06:35.1145647+01:00",
  "PublishTo": "2004-04-04T11:06:35.1145647+02:00",
  "PublishFrom": "2007-07-28T11:06:35.1145647+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 235,
  "Name": "Herzog, Luettgen and Langworth",
  "ProjectNumber": "854937",
  "ProjectMembers": [
    {
      "ProjectmemberId": 843,
      "ContactId": 469,
      "ProjectId": 746,
      "ContactName": "Cruickshank Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Dibbert-Ward",
      "EmailId": 111,
      "EmailAddress": "rosario_nikolaus@turcotte.biz",
      "CountryId": 942,
      "Firstname": "Muriel",
      "MiddleName": "Muller-Strosin",
      "Lastname": "Hirthe",
      "PersonId": 637,
      "Mrmrs": "veniam",
      "ProjectMemberTypeName": "Schowalter Inc and Sons",
      "Phone": "(429)853-5040",
      "PhoneId": 340,
      "ProjectMemberTypeId": 555,
      "EmailAddressName": "hilario.purdy@stiedemann.com",
      "Comment": "voluptatum",
      "FullName": "Emily Feeney",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "repudiandae",
      "Description": "Distributed non-volatile service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "repudiandae",
      "Description": "Distributed non-volatile service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "CreatedDate": "2006-05-16T11:06:35.1145647+02:00",
  "UpdatedDate": "1997-09-07T11:06:35.1145647+02:00",
  "Description": "Grass-roots 5th generation utilisation",
  "Postit": "voluptate",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Universal transitional synergy",
  "ActiveStatusMonitorId": 314,
  "Links": [
    {
      "EntityName": "Gleichner-Harvey",
      "Id": 549,
      "Description": "User-centric bandwidth-monitored leverage",
      "ExtraInfo": "quaerat",
      "LinkId": 132,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    }
  ],
  "ActiveLinks": 897,
  "Completed": false,
  "NextMilestoneDate": "2011-11-24T11:06:35.1145647+01:00",
  "NmdAppointmentId": 590,
  "EndDate": "2017-07-16T11:06:35.1145647+02:00",
  "ActiveErpLinks": 699,
  "UserDefinedFields": {
    "SuperOffice:1": "Audrey Borer",
    "SuperOffice:2": "Adah Yundt"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "laudantium",
    "CustomFields2": "cum"
  },
  "PublishEventDate": "2014-03-25T11:06:35.1145647+01:00",
  "PublishTo": "2005-04-05T11:06:35.1145647+02:00",
  "PublishFrom": "2023-09-28T11:06:35.1145647+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 470
    }
  }
}
```