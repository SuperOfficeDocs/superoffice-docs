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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 14 Aug 2009 03:44:57 G8T

{
  "ContactId": 711,
  "Name": "Fritsch LLC",
  "Department": "",
  "OrgNr": "1017884",
  "Number1": "1061285",
  "Number2": "7112",
  "UpdatedDate": "2009-08-14T03:44:57.1402759+02:00",
  "CreatedDate": "2006-01-16T03:44:57.1402759+01:00",
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "aut",
      "Description": "Function-based bifurcated utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "aut",
      "Description": "Function-based bifurcated utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 688,
      "Name": "Cartwright-Gorczany",
      "ToolTip": "Repellendus ut.",
      "Deleted": false,
      "Rank": 942,
      "Type": "officia",
      "ColorBlock": 634,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2011-08-14T03:44:57.1402759+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "minus",
      "Hidden": true,
      "FullName": "Miss Carol Dejon Stroman Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vitae",
      "StrippedValue": "sint",
      "Description": "Extended coherent instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "sint",
      "Description": "Extended coherent instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "maxime",
      "StrippedValue": "iure",
      "Description": "Optional reciprocal middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "iure",
      "Description": "Optional reciprocal middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "quod",
      "Description": "Persistent empowering success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "quod",
      "Description": "Persistent empowering success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
        }
      }
    }
  ],
  "Description": "Decentralized explicit focus group",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "deleniti",
      "PersonId": 17,
      "Mrmrs": "odit",
      "Firstname": "Oliver",
      "Lastname": "Lehner",
      "MiddleName": "Reichel, Halvorson and O'Connell",
      "Title": "nam",
      "Description": "Multi-lateral scalable matrix",
      "Email": "ewell.ziemann@blickdamore.biz",
      "FullName": "Kaya Flatley",
      "DirectPhone": "(381)366-2083 x53520",
      "FormalName": "Zboncak-Hammes",
      "CountryId": 178,
      "ContactId": 513,
      "ContactName": "Metz Group",
      "Retired": 186,
      "Rank": 3,
      "ActiveInterests": 212,
      "ContactDepartment": "",
      "ContactCountryId": 749,
      "ContactOrgNr": "773888",
      "FaxPhone": "(125)123-5462",
      "MobilePhone": "1-007-194-7994 x499",
      "ContactPhone": "1-340-020-5300 x668",
      "AssociateName": "Beer, Wolff and Huel",
      "AssociateId": 870,
      "UsePersonAddress": true,
      "ContactFax": "velit",
      "Kanafname": "asperiores",
      "Kanalname": "laborum",
      "Post1": "excepturi",
      "Post2": "facere",
      "Post3": "voluptatum",
      "EmailName": "ona.lind@wolfmante.ca",
      "ContactFullName": "Ernesto Will",
      "ActiveErpLinks": 633,
      "TicketPriorityId": 238,
      "SupportLanguageId": 353,
      "SupportAssociateId": 890,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 986
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "consequatur",
  "Xstop": false,
  "ActiveInterests": 921,
  "GroupId": 255,
  "ActiveStatusMonitorId": 559,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 421,
  "DbiAgentId": 922,
  "DbiLastSyncronized": "2001-02-14T03:44:57.1402759+01:00",
  "DbiKey": "beatae",
  "DbiLastModified": "2005-05-20T03:44:57.1402759+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 167,
  "ActiveErpLinks": 586,
  "BounceEmails": [
    "alfreda@gutkowski.biz",
    "augustine@jenkinsmurray.us"
  ],
  "Domains": [
    "voluptatibus",
    "odit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1436214696",
    "SuperOffice:2": "Zita Mertz"
  },
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 615
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```