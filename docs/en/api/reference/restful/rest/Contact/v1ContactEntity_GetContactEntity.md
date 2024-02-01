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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 13 Feb 2011 23:04:03 G2T

{
  "ContactId": 289,
  "Name": "Russel, Schulist and Boyer",
  "Department": "",
  "OrgNr": "474891",
  "Number1": "592952",
  "Number2": "266356",
  "UpdatedDate": "2011-02-13T23:04:03.9560202+01:00",
  "CreatedDate": "2017-09-11T23:04:03.9560202+02:00",
  "Emails": [
    {
      "Value": "nemo",
      "StrippedValue": "eum",
      "Description": "Programmable executive access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 718
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "eum",
      "Description": "Programmable executive access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 718
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 99,
      "Name": "Sipes Group",
      "ToolTip": "Molestiae magni qui voluptate fugiat cum.",
      "Deleted": false,
      "Rank": 856,
      "Type": "atque",
      "ColorBlock": 646,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2015-12-15T23:04:03.9565212+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Mrs. Efrain Keebler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 554
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "odit",
      "Description": "Multi-layered neutral instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "odit",
      "Description": "Multi-layered neutral instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "maiores",
      "StrippedValue": "non",
      "Description": "Automated logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "non",
      "Description": "Automated logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Intuitive 4th generation success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Intuitive 4th generation success",
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
  "Description": "Diverse value-added model",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "earum",
      "PersonId": 800,
      "Mrmrs": "eos",
      "Firstname": "Antonetta",
      "Lastname": "Stamm",
      "MiddleName": "Jacobs, West and Rodriguez",
      "Title": "dolor",
      "Description": "Down-sized grid-enabled internet solution",
      "Email": "hector@wittingharris.info",
      "FullName": "Cara Hintz",
      "DirectPhone": "1-794-930-1973 x73167",
      "FormalName": "Greenfelder Group",
      "CountryId": 676,
      "ContactId": 725,
      "ContactName": "Schiller Group",
      "Retired": 198,
      "Rank": 160,
      "ActiveInterests": 746,
      "ContactDepartment": "",
      "ContactCountryId": 179,
      "ContactOrgNr": "556936",
      "FaxPhone": "1-584-970-1910 x10113",
      "MobilePhone": "(648)011-2689 x1189",
      "ContactPhone": "(659)676-7740",
      "AssociateName": "Koepp Inc and Sons",
      "AssociateId": 188,
      "UsePersonAddress": false,
      "ContactFax": "recusandae",
      "Kanafname": "distinctio",
      "Kanalname": "voluptate",
      "Post1": "consequatur",
      "Post2": "voluptatum",
      "Post3": "omnis",
      "EmailName": "bertrand@johns.name",
      "ContactFullName": "Lucio Stark",
      "ActiveErpLinks": 745,
      "TicketPriorityId": 358,
      "SupportLanguageId": 150,
      "SupportAssociateId": 355,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dolore",
  "Xstop": true,
  "ActiveInterests": 373,
  "GroupId": 355,
  "ActiveStatusMonitorId": 647,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 953,
  "DbiAgentId": 393,
  "DbiLastSyncronized": "2004-02-02T23:04:03.9605201+01:00",
  "DbiKey": "assumenda",
  "DbiLastModified": "2009-05-21T23:04:03.9610199+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 130,
  "ActiveErpLinks": 327,
  "BounceEmails": [
    "tomas@feil.info",
    "dayana@breitenberg.com"
  ],
  "Domains": [
    "mollitia",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "394103208",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "possimus"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "numquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 893
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```