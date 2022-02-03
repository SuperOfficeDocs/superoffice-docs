---
title: PUT Project/{id}
id: v1ProjectEntity_PutProjectEntity
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
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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


## Response: object

The Project Service. The service implements all services working with the Project object



ProjectEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 800,
  "Name": "Bode-Leffler",
  "ProjectNumber": "973439",
  "ProjectMembers": [
    {
      "ProjectmemberId": 255,
      "ContactId": 328,
      "ProjectId": 817,
      "ContactName": "Kunde Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Crist LLC",
      "EmailId": 131,
      "EmailAddress": "brown.pfannerstill@zemlaklarson.info",
      "CountryId": 961,
      "Firstname": "Alice",
      "MiddleName": "Zulauf, Mann and Klocko",
      "Lastname": "Renner",
      "PersonId": 763,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Baumbach, Monahan and Dibbert",
      "Phone": "508-441-2602",
      "PhoneId": 380,
      "ProjectMemberTypeId": 978,
      "EmailAddressName": "missouri.franecki@lynchorn.us",
      "Comment": "corporis",
      "FullName": "Delphine Schaden"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "reiciendis",
      "Description": "Multi-channelled fresh-thinking interface"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "reiciendis",
      "Description": "Multi-channelled fresh-thinking interface"
    }
  ],
  "CreatedDate": "2012-01-15T18:25:50.8138839+01:00",
  "UpdatedDate": "1996-03-09T18:25:50.8138839+01:00",
  "Description": "Programmable multimedia knowledge base",
  "Postit": "consequatur",
  "CreatedBy": {
    "AssociateId": 646,
    "Name": "Gutkowski, Ward and Rolfson",
    "PersonId": 189,
    "Rank": 485,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 21,
    "FullName": "Jaydon Weissnat",
    "FormalName": "Kuvalis, Hettinger and Rau",
    "Deleted": false,
    "EjUserId": 661,
    "UserName": "Shanahan, Keebler and Roob"
  },
  "UpdatedBy": {
    "AssociateId": 568,
    "Name": "Stiedemann, Morar and Waters",
    "PersonId": 58,
    "Rank": 847,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 25,
    "FullName": "Glennie Hintz",
    "FormalName": "Berge-Gusikowski",
    "Deleted": false,
    "EjUserId": 353,
    "UserName": "Willms Inc and Sons"
  },
  "Associate": {
    "AssociateId": 929,
    "Name": "Kirlin-Keeling",
    "PersonId": 304,
    "Rank": 928,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 821,
    "FullName": "Kasandra Hessel",
    "FormalName": "Harber, Stroman and Waters",
    "Deleted": false,
    "EjUserId": 882,
    "UserName": "Hoppe-Walter"
  },
  "ProjectStatus": {
    "Id": 919,
    "Value": "aut",
    "Tooltip": "qui"
  },
  "ProjectType": {
    "Id": 677,
    "Value": "pariatur",
    "Tooltip": "aliquid"
  },
  "HasImage": false,
  "ImageDescription": "Implemented uniform emulation",
  "ActiveStatusMonitorId": 164,
  "Links": [
    {
      "EntityName": "Romaguera-VonRueden",
      "Id": 858,
      "Description": "Vision-oriented disintermediate concept",
      "ExtraInfo": "pariatur",
      "LinkId": 14
    },
    {
      "EntityName": "Romaguera-VonRueden",
      "Id": 858,
      "Description": "Vision-oriented disintermediate concept",
      "ExtraInfo": "pariatur",
      "LinkId": 14
    }
  ],
  "ActiveLinks": 664,
  "Completed": false,
  "NextMilestoneDate": "2010-01-06T18:25:50.8158835+01:00",
  "NmdAppointmentId": 973,
  "EndDate": "2011-10-17T18:25:50.8158835+02:00",
  "ActiveErpLinks": 201,
  "UserDefinedFields": {
    "SuperOffice:1": "1723167585",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "voluptate",
    "CustomFields2": "itaque"
  },
  "PublishEventDate": "2001-05-04T18:25:50.8158835+02:00",
  "PublishTo": "1994-12-19T18:25:50.8158835+01:00",
  "PublishFrom": "2021-11-09T18:25:50.8158835+01:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 421,
  "Name": "Botsford-Crona",
  "ProjectNumber": "1320091",
  "ProjectMembers": [
    {
      "ProjectmemberId": 943,
      "ContactId": 23,
      "ProjectId": 741,
      "ContactName": "Gusikowski-Torphy",
      "ContactDepartment": "",
      "ProjectName": "Hyatt Inc and Sons",
      "EmailId": 223,
      "EmailAddress": "tavares@funk.co.uk",
      "CountryId": 267,
      "Firstname": "Maymie",
      "MiddleName": "Kunde-Wehner",
      "Lastname": "Cartwright",
      "PersonId": 764,
      "Mrmrs": "distinctio",
      "ProjectMemberTypeName": "Legros, Rosenbaum and Kohler",
      "Phone": "022.275.5234 x71825",
      "PhoneId": 57,
      "ProjectMemberTypeId": 975,
      "EmailAddressName": "keshaun@toy.uk",
      "Comment": "dolorum",
      "FullName": "Quincy Fadel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 724
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Assimilated actuating Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Assimilated actuating Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    }
  ],
  "CreatedDate": "2003-10-20T18:25:50.8208852+02:00",
  "UpdatedDate": "2000-04-19T18:25:50.8208852+02:00",
  "Description": "Customer-focused intangible standardization",
  "Postit": "saepe",
  "CreatedBy": {
    "AssociateId": 56,
    "Name": "Kuhic Inc and Sons",
    "PersonId": 273,
    "Rank": 890,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 796,
    "FullName": "Anna Rau",
    "FormalName": "Dietrich, Kassulke and Rodriguez",
    "Deleted": false,
    "EjUserId": 21,
    "UserName": "Welch-Jast",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 472
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 463,
    "Name": "Greenholt, Kub and Gerhold",
    "PersonId": 943,
    "Rank": 620,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 235,
    "FullName": "Warren Reinger V",
    "FormalName": "Schowalter, Moen and Rodriguez",
    "Deleted": false,
    "EjUserId": 576,
    "UserName": "Kohler LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 988
      }
    }
  },
  "Associate": {
    "AssociateId": 950,
    "Name": "Aufderhar-Batz",
    "PersonId": 175,
    "Rank": 802,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 772,
    "FullName": "Romaine Kihn",
    "FormalName": "Carroll, Robel and Dietrich",
    "Deleted": false,
    "EjUserId": 21,
    "UserName": "Bailey Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 7
      }
    }
  },
  "ProjectStatus": {
    "Id": 898,
    "Value": "voluptatem",
    "Tooltip": "aspernatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark cutting-edge synergies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 196
      }
    }
  },
  "ProjectType": {
    "Id": 982,
    "Value": "ullam",
    "Tooltip": "ipsa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 464
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Balanced object-oriented challenge",
  "ActiveStatusMonitorId": 796,
  "Links": [
    {
      "EntityName": "Lowe-Windler",
      "Id": 896,
      "Description": "Automated high-level flexibility",
      "ExtraInfo": "et",
      "LinkId": 140,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    }
  ],
  "ActiveLinks": 745,
  "Completed": false,
  "NextMilestoneDate": "2020-04-14T18:25:50.8218852+02:00",
  "NmdAppointmentId": 99,
  "EndDate": "2013-05-24T18:25:50.8218852+02:00",
  "ActiveErpLinks": 1001,
  "UserDefinedFields": {
    "SuperOffice:1": "1821477592",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "voluptas"
  },
  "PublishEventDate": "2013-07-20T18:25:50.8228849+02:00",
  "PublishTo": "2016-03-06T18:25:50.8228849+01:00",
  "PublishFrom": "2006-12-07T18:25:50.8228849+01:00",
  "IsPublished": false,
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
      "FieldLength": 269
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```