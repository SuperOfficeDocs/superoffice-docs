---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=False
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

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 27 Sep 2002 03:24:51 G9T

{
  "ContactId": 707,
  "Name": "Monahan, Schowalter and Gutkowski",
  "Department": "",
  "OrgNr": "393355",
  "Number1": "1733346",
  "Number2": "557471",
  "UpdatedDate": "2002-09-27T03:24:51.4899959+02:00",
  "CreatedDate": "2016-05-01T03:24:51.4899959+02:00",
  "Emails": [
    {
      "Value": "neque",
      "StrippedValue": "quos",
      "Description": "Decentralized foreground alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "quos",
      "Description": "Decentralized foreground alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 146,
      "Name": "Sporer, Upton and Spinka",
      "ToolTip": "Voluptas consequatur dolorem voluptatem iste minus sint aut.",
      "Deleted": true,
      "Rank": 428,
      "Type": "quis",
      "ColorBlock": 345,
      "IconHint": "a",
      "Selected": true,
      "LastChanged": "2018-02-04T03:24:51.4899959+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Prof. Bill Klocko MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "modi",
      "Description": "Right-sized methodical neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "modi",
      "Description": "Right-sized methodical neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "illum",
      "StrippedValue": "eligendi",
      "Description": "Fundamental systematic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "eligendi",
      "Description": "Fundamental systematic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laudantium",
      "StrippedValue": "est",
      "Description": "Enhanced 24/7 capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "est",
      "Description": "Enhanced 24/7 capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    }
  ],
  "Description": "Vision-oriented hybrid moratorium",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "praesentium",
      "PersonId": 190,
      "Mrmrs": "similique",
      "Firstname": "Kadin",
      "Lastname": "Green",
      "MiddleName": "Rutherford-Muller",
      "Title": "ipsa",
      "Description": "Up-sized encompassing neural-net",
      "Email": "giovanni@jerde.ca",
      "FullName": "Prof. Zane Camylle Dicki PhD",
      "DirectPhone": "1-461-856-7715",
      "FormalName": "Schmidt-Graham",
      "CountryId": 431,
      "ContactId": 112,
      "ContactName": "Hermann-Hartmann",
      "Retired": 925,
      "Rank": 288,
      "ActiveInterests": 124,
      "ContactDepartment": "",
      "ContactCountryId": 192,
      "ContactOrgNr": "939524",
      "FaxPhone": "(719)107-6016",
      "MobilePhone": "519-388-1433 x745",
      "ContactPhone": "969.660.1984",
      "AssociateName": "Moen-McGlynn",
      "AssociateId": 218,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "et",
      "Kanalname": "eos",
      "Post1": "error",
      "Post2": "ex",
      "Post3": "quia",
      "EmailName": "arnold.mcglynn@daugherty.info",
      "ContactFullName": "Elisa Crist",
      "ActiveErpLinks": 31,
      "TicketPriorityId": 858,
      "SupportLanguageId": 882,
      "SupportAssociateId": 979,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 154
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "explicabo",
  "Xstop": true,
  "ActiveInterests": 776,
  "GroupId": 649,
  "ActiveStatusMonitorId": 798,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 138,
  "DbiAgentId": 205,
  "DbiLastSyncronized": "2010-11-29T03:24:51.4899959+01:00",
  "DbiKey": "quis",
  "DbiLastModified": "2020-07-30T03:24:51.4899959+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 125,
  "ActiveErpLinks": 863,
  "BounceEmails": [
    "kira_prosacco@hammes.biz",
    "tina_gottlieb@rath.com"
  ],
  "Domains": [
    "eaque",
    "cumque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Faustino Howe",
    "SuperOffice:2": "Ashtyn Schumm"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "dignissimos"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 199
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```