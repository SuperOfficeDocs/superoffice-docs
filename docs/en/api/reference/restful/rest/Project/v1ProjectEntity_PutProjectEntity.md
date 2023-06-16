---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ProjectEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 590,
  "Name": "Stracke Inc and Sons",
  "ProjectNumber": "1131751",
  "ProjectMembers": [
    {
      "ProjectmemberId": 754,
      "ContactId": 266,
      "ProjectId": 835,
      "ContactName": "Auer-Simonis",
      "ContactDepartment": "",
      "ProjectName": "Berge-Cummings",
      "EmailId": 243,
      "EmailAddress": "tod@sauerkuhn.info",
      "CountryId": 381,
      "Firstname": "Bret",
      "MiddleName": "Harris, McDermott and Fritsch",
      "Lastname": "Hoppe",
      "PersonId": 893,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Rempel LLC",
      "Phone": "116-847-9123 x3040",
      "PhoneId": 419,
      "ProjectMemberTypeId": 142,
      "EmailAddressName": "torrance_koss@bogan.info",
      "Comment": "sit",
      "FullName": "Dr. Jamey Mckayla Bernhard"
    }
  ],
  "Urls": [
    {
      "Value": "commodi",
      "StrippedValue": "asperiores",
      "Description": "Customizable secondary emulation"
    },
    {
      "Value": "commodi",
      "StrippedValue": "asperiores",
      "Description": "Customizable secondary emulation"
    }
  ],
  "CreatedDate": "2016-02-22T16:00:48.149054+01:00",
  "UpdatedDate": "2008-12-06T16:00:48.149054+01:00",
  "Description": "Intuitive exuding contingency",
  "Postit": "doloremque",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Proactive grid-enabled product",
  "ActiveStatusMonitorId": 939,
  "Links": [
    {
      "EntityName": "Keebler Group",
      "Id": 858,
      "Description": "Function-based eco-centric core",
      "ExtraInfo": "dignissimos",
      "LinkId": 120
    },
    {
      "EntityName": "Keebler Group",
      "Id": 858,
      "Description": "Function-based eco-centric core",
      "ExtraInfo": "dignissimos",
      "LinkId": 120
    }
  ],
  "ActiveLinks": 699,
  "Completed": false,
  "NextMilestoneDate": "2004-08-10T16:00:48.149054+02:00",
  "NmdAppointmentId": 396,
  "EndDate": "2012-01-22T16:00:48.149054+01:00",
  "ActiveErpLinks": 896,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "iure"
  },
  "PublishEventDate": "2005-11-19T16:00:48.149054+01:00",
  "PublishTo": "1999-06-25T16:00:48.149054+02:00",
  "PublishFrom": "2009-04-19T16:00:48.149054+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 830,
  "Name": "Goyette Inc and Sons",
  "ProjectNumber": "1252992",
  "ProjectMembers": [
    {
      "ProjectmemberId": 472,
      "ContactId": 720,
      "ProjectId": 968,
      "ContactName": "Huel, Bednar and Spencer",
      "ContactDepartment": "",
      "ProjectName": "Keeling-Eichmann",
      "EmailId": 606,
      "EmailAddress": "madisen@johnson.name",
      "CountryId": 46,
      "Firstname": "Jamie",
      "MiddleName": "Fahey, Effertz and Lakin",
      "Lastname": "O'Kon",
      "PersonId": 80,
      "Mrmrs": "vel",
      "ProjectMemberTypeName": "Lakin-Klocko",
      "Phone": "280.210.8984 x946",
      "PhoneId": 893,
      "ProjectMemberTypeId": 435,
      "EmailAddressName": "shyanne@ernser.com",
      "Comment": "dolorum",
      "FullName": "Dimitri Steuber",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "praesentium",
      "Description": "Networked leading edge attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 758
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "praesentium",
      "Description": "Networked leading edge attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 758
        }
      }
    }
  ],
  "CreatedDate": "2001-07-18T16:00:48.149054+02:00",
  "UpdatedDate": "2010-06-14T16:00:48.149054+02:00",
  "Description": "Switchable mobile knowledge base",
  "Postit": "atque",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Front-line modular alliance",
  "ActiveStatusMonitorId": 350,
  "Links": [
    {
      "EntityName": "Sauer LLC",
      "Id": 926,
      "Description": "Distributed 3rd generation portal",
      "ExtraInfo": "enim",
      "LinkId": 883,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    }
  ],
  "ActiveLinks": 312,
  "Completed": false,
  "NextMilestoneDate": "2019-12-09T16:00:48.149054+01:00",
  "NmdAppointmentId": 104,
  "EndDate": "2001-01-31T16:00:48.149054+01:00",
  "ActiveErpLinks": 937,
  "UserDefinedFields": {
    "SuperOffice:1": "417531015",
    "SuperOffice:2": "Erick Cronin"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "debitis"
  },
  "PublishEventDate": "2019-02-11T16:00:48.149054+01:00",
  "PublishTo": "2002-10-07T16:00:48.149054+02:00",
  "PublishFrom": "2015-04-01T16:00:48.149054+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 827
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```