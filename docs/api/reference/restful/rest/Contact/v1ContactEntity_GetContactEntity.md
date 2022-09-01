---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
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

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 23 Jun 2003 11:10:52 G6T

{
  "ContactId": 712,
  "Name": "Kozey-Littel",
  "Department": "",
  "OrgNr": "1405012",
  "Number1": "1566776",
  "Number2": "602297",
  "UpdatedDate": "2003-06-23T11:10:52.6571764+02:00",
  "CreatedDate": "2008-07-12T11:10:52.6571764+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "distinctio",
      "Description": "Triple-buffered zero administration hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 413
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "distinctio",
      "Description": "Triple-buffered zero administration hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 413
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 638,
      "Name": "Kerluke-Ondricka",
      "ToolTip": "Magnam quis itaque aperiam non.",
      "Deleted": false,
      "Rank": 253,
      "Type": "magni",
      "ColorBlock": 452,
      "IconHint": "suscipit",
      "Selected": false,
      "LastChanged": "2010-11-18T11:10:52.6571764+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "quod",
      "Hidden": false,
      "FullName": "Jaida Novella Wiza V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "saepe",
      "Description": "Reverse-engineered contextually-based local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "saepe",
      "Description": "Reverse-engineered contextually-based local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptate",
      "StrippedValue": "exercitationem",
      "Description": "Up-sized actuating circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "exercitationem",
      "Description": "Up-sized actuating circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "consequatur",
      "Description": "Grass-roots intermediate hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "consequatur",
      "Description": "Grass-roots intermediate hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Description": "Organic multimedia local area network",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "autem",
      "PersonId": 156,
      "Mrmrs": "quisquam",
      "Firstname": "Herman",
      "Lastname": "Morissette",
      "MiddleName": "Bayer Group",
      "Title": "aut",
      "Description": "Fundamental demand-driven conglomeration",
      "Email": "vernie@schmeler.uk",
      "FullName": "Mr. Marisol Florian Schultz",
      "DirectPhone": "1-609-015-2245",
      "FormalName": "Murphy-Schumm",
      "CountryId": 465,
      "ContactId": 921,
      "ContactName": "Brakus-Auer",
      "Retired": 180,
      "Rank": 161,
      "ActiveInterests": 327,
      "ContactDepartment": "",
      "ContactCountryId": 755,
      "ContactOrgNr": "659922",
      "FaxPhone": "020-895-1888",
      "MobilePhone": "1-453-437-4881 x05014",
      "ContactPhone": "1-171-593-3165",
      "AssociateName": "Bergstrom-Ratke",
      "AssociateId": 76,
      "UsePersonAddress": true,
      "ContactFax": "reiciendis",
      "Kanafname": "quia",
      "Kanalname": "officiis",
      "Post1": "architecto",
      "Post2": "ut",
      "Post3": "voluptas",
      "EmailName": "austyn@reichel.info",
      "ContactFullName": "Prof. Francis Nader Jr.",
      "ActiveErpLinks": 402,
      "TicketPriorityId": 753,
      "SupportLanguageId": 625,
      "SupportAssociateId": 977,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "fuga",
  "Xstop": true,
  "ActiveInterests": 914,
  "GroupId": 363,
  "ActiveStatusMonitorId": 330,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 445,
  "DbiAgentId": 592,
  "DbiLastSyncronized": "2007-10-01T11:10:52.6621748+02:00",
  "DbiKey": "fuga",
  "DbiLastModified": "2000-12-10T11:10:52.6621748+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 177,
  "ActiveErpLinks": 595,
  "BounceEmails": [
    "hayden@wittingnicolas.us",
    "lyda@torphy.ca"
  ],
  "Domains": [
    "molestias",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Sigurd Johns"
  },
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "numquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 734
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```