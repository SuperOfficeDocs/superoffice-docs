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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 540,
  "Name": "Wolf, Roberts and Hauck",
  "ProjectNumber": "1488432",
  "ProjectMembers": [
    {
      "ProjectmemberId": 234,
      "ContactId": 806,
      "ProjectId": 179,
      "ContactName": "Cartwright-Stehr",
      "ContactDepartment": "",
      "ProjectName": "Konopelski LLC",
      "EmailId": 724,
      "EmailAddress": "dominic@klein.info",
      "CountryId": 602,
      "Firstname": "Wilber",
      "MiddleName": "Torp-Terry",
      "Lastname": "Cummings",
      "PersonId": 420,
      "Mrmrs": "ullam",
      "ProjectMemberTypeName": "Watsica-Goodwin",
      "Phone": "1-225-680-7725 x554",
      "PhoneId": 473,
      "ProjectMemberTypeId": 747,
      "EmailAddressName": "tracey_zboncak@price.co.uk",
      "Comment": "ipsam",
      "FullName": "Shaina Padberg"
    }
  ],
  "Urls": [
    {
      "Value": "quod",
      "StrippedValue": "at",
      "Description": "Cross-platform optimal core"
    },
    {
      "Value": "quod",
      "StrippedValue": "at",
      "Description": "Cross-platform optimal core"
    }
  ],
  "CreatedDate": "2022-02-11T04:02:06.7128881+01:00",
  "UpdatedDate": "2020-10-22T04:02:06.7128881+02:00",
  "Description": "Mandatory demand-driven array",
  "Postit": "voluptate",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Team-oriented cohesive portal",
  "ActiveStatusMonitorId": 486,
  "Links": [
    {
      "EntityName": "McDermott Inc and Sons",
      "Id": 361,
      "Description": "Universal secondary hardware",
      "ExtraInfo": "cum",
      "LinkId": 671
    },
    {
      "EntityName": "McDermott Inc and Sons",
      "Id": 361,
      "Description": "Universal secondary hardware",
      "ExtraInfo": "cum",
      "LinkId": 671
    }
  ],
  "ActiveLinks": 341,
  "Completed": false,
  "NextMilestoneDate": "2013-08-08T04:02:06.7128881+02:00",
  "NmdAppointmentId": 284,
  "EndDate": "2011-03-15T04:02:06.7128881+01:00",
  "ActiveErpLinks": 705,
  "UserDefinedFields": {
    "SuperOffice:1": "Cody Christopher Ward PhD",
    "SuperOffice:2": "1965272573"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "similique",
    "CustomFields2": "dolorem"
  },
  "PublishEventDate": "2008-01-22T04:02:06.7128881+01:00",
  "PublishTo": "2012-11-14T04:02:06.7128881+01:00",
  "PublishFrom": "2005-11-13T04:02:06.7128881+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 526,
  "Name": "O'Reilly Inc and Sons",
  "ProjectNumber": "926695",
  "ProjectMembers": [
    {
      "ProjectmemberId": 786,
      "ContactId": 571,
      "ProjectId": 427,
      "ContactName": "Kutch Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Wiegand, Harber and Emard",
      "EmailId": 279,
      "EmailAddress": "drake@hansenprosacco.info",
      "CountryId": 182,
      "Firstname": "Rhoda",
      "MiddleName": "Wilkinson Group",
      "Lastname": "Mraz",
      "PersonId": 358,
      "Mrmrs": "beatae",
      "ProjectMemberTypeName": "Frami-Senger",
      "Phone": "(959)218-5961 x13665",
      "PhoneId": 468,
      "ProjectMemberTypeId": 596,
      "EmailAddressName": "erling@robelemard.uk",
      "Comment": "assumenda",
      "FullName": "Edwina Adelbert Denesik Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 261
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consectetur",
      "StrippedValue": "ex",
      "Description": "Object-based reciprocal emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "ex",
      "Description": "Object-based reciprocal emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    }
  ],
  "CreatedDate": "2018-11-04T04:02:06.7128881+01:00",
  "UpdatedDate": "2011-11-10T04:02:06.7128881+01:00",
  "Description": "Fully-configurable multi-state complexity",
  "Postit": "neque",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Extended even-keeled hierarchy",
  "ActiveStatusMonitorId": 724,
  "Links": [
    {
      "EntityName": "Stoltenberg-Pollich",
      "Id": 83,
      "Description": "Object-based grid-enabled productivity",
      "ExtraInfo": "excepturi",
      "LinkId": 310,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 989
        }
      }
    }
  ],
  "ActiveLinks": 231,
  "Completed": true,
  "NextMilestoneDate": "2013-06-27T04:02:06.7128881+02:00",
  "NmdAppointmentId": 508,
  "EndDate": "2017-05-20T04:02:06.7128881+02:00",
  "ActiveErpLinks": 816,
  "UserDefinedFields": {
    "SuperOffice:1": "787859449",
    "SuperOffice:2": "Hillary Mayer"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "explicabo"
  },
  "PublishEventDate": "2008-04-16T04:02:06.7128881+02:00",
  "PublishTo": "2010-02-24T04:02:06.7128881+01:00",
  "PublishFrom": "2014-03-14T04:02:06.7128881+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 469
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```