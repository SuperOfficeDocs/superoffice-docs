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
  "ProjectId": 646,
  "Name": "Gleason Group",
  "ProjectNumber": "1242369",
  "ProjectMembers": [
    {
      "ProjectmemberId": 793,
      "ContactId": 878,
      "ProjectId": 625,
      "ContactName": "Crist, Wehner and Moen",
      "ContactDepartment": "",
      "ProjectName": "Breitenberg, Maggio and Schaden",
      "EmailId": 41,
      "EmailAddress": "brycen@skilesrunte.co.uk",
      "CountryId": 623,
      "Firstname": "Annette",
      "MiddleName": "Frami, Koch and Hermiston",
      "Lastname": "O'Reilly",
      "PersonId": 338,
      "Mrmrs": "quaerat",
      "ProjectMemberTypeName": "Tillman Group",
      "Phone": "1-131-387-2132 x95586",
      "PhoneId": 828,
      "ProjectMemberTypeId": 780,
      "EmailAddressName": "alene_bartell@crooks.us",
      "Comment": "sunt",
      "FullName": "Addison Robel"
    }
  ],
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "impedit",
      "Description": "Self-enabling zero tolerance concept"
    },
    {
      "Value": "dolores",
      "StrippedValue": "impedit",
      "Description": "Self-enabling zero tolerance concept"
    }
  ],
  "CreatedDate": "2002-02-10T13:38:17.5461866+01:00",
  "UpdatedDate": "2023-10-28T13:38:17.5461866+02:00",
  "Description": "Robust client-server support",
  "Postit": "nesciunt",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Streamlined reciprocal customer loyalty",
  "ActiveStatusMonitorId": 27,
  "Links": [
    {
      "EntityName": "Marvin, Bailey and Roob",
      "Id": 79,
      "Description": "Adaptive optimizing service-desk",
      "ExtraInfo": "recusandae",
      "LinkId": 873
    },
    {
      "EntityName": "Marvin, Bailey and Roob",
      "Id": 79,
      "Description": "Adaptive optimizing service-desk",
      "ExtraInfo": "recusandae",
      "LinkId": 873
    }
  ],
  "ActiveLinks": 929,
  "Completed": false,
  "NextMilestoneDate": "1998-06-30T13:38:17.5461866+02:00",
  "NmdAppointmentId": 998,
  "EndDate": "2002-11-21T13:38:17.5461866+01:00",
  "ActiveErpLinks": 156,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Prof. Erwin Dayton O'Keefe II"
  },
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "nihil"
  },
  "PublishEventDate": "1998-12-22T13:38:17.5461866+01:00",
  "PublishTo": "2007-07-12T13:38:17.5461866+02:00",
  "PublishFrom": "2004-10-27T13:38:17.5461866+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 599,
  "Name": "Lubowitz Inc and Sons",
  "ProjectNumber": "1238784",
  "ProjectMembers": [
    {
      "ProjectmemberId": 186,
      "ContactId": 885,
      "ProjectId": 475,
      "ContactName": "Abshire Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Wisozk LLC",
      "EmailId": 281,
      "EmailAddress": "alvah@kovacek.ca",
      "CountryId": 384,
      "Firstname": "Yvette",
      "MiddleName": "Gleichner, Prosacco and Farrell",
      "Lastname": "Durgan",
      "PersonId": 102,
      "Mrmrs": "excepturi",
      "ProjectMemberTypeName": "Schinner, Flatley and Gislason",
      "Phone": "601.804.0185 x2156",
      "PhoneId": 77,
      "ProjectMemberTypeId": 504,
      "EmailAddressName": "lloyd@reynolds.name",
      "Comment": "et",
      "FullName": "Mr. Rolando Abernathy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 495
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "itaque",
      "StrippedValue": "cupiditate",
      "Description": "Inverse mission-critical strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 993
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "cupiditate",
      "Description": "Inverse mission-critical strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 993
        }
      }
    }
  ],
  "CreatedDate": "2010-11-19T13:38:17.5461866+01:00",
  "UpdatedDate": "2006-06-30T13:38:17.5461866+02:00",
  "Description": "Total holistic function",
  "Postit": "aut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Cross-group executive knowledge user",
  "ActiveStatusMonitorId": 380,
  "Links": [
    {
      "EntityName": "Rolfson-Emmerich",
      "Id": 952,
      "Description": "Re-engineered intermediate migration",
      "ExtraInfo": "sed",
      "LinkId": 867,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 555
        }
      }
    }
  ],
  "ActiveLinks": 107,
  "Completed": false,
  "NextMilestoneDate": "2008-10-27T13:38:17.5461866+01:00",
  "NmdAppointmentId": 772,
  "EndDate": "2014-01-23T13:38:17.5461866+01:00",
  "ActiveErpLinks": 150,
  "UserDefinedFields": {
    "SuperOffice:1": "1828897265",
    "SuperOffice:2": "Evalyn Oceane Wuckert IV"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "nobis"
  },
  "PublishEventDate": "2009-06-17T13:38:17.5461866+02:00",
  "PublishTo": "2015-08-02T13:38:17.5461866+02:00",
  "PublishFrom": "2002-06-23T13:38:17.5461866+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 92
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```