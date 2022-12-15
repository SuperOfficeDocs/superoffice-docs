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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 17 Aug 2007 02:49:50 G8T

{
  "ContactId": 677,
  "Name": "Nolan, Crist and Jacobs",
  "Department": "",
  "OrgNr": "662448",
  "Number1": "644189",
  "Number2": "302329",
  "UpdatedDate": "2007-08-17T02:49:50.7765657+02:00",
  "CreatedDate": "2007-05-14T02:49:50.7765657+02:00",
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "earum",
      "Description": "Progressive bifurcated strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "earum",
      "Description": "Progressive bifurcated strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 78,
      "Name": "Sporer Inc and Sons",
      "ToolTip": "Eos quo minus et et minus temporibus.",
      "Deleted": true,
      "Rank": 663,
      "Type": "neque",
      "ColorBlock": 84,
      "IconHint": "ipsam",
      "Selected": true,
      "LastChanged": "2004-01-18T02:49:50.7765657+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "possimus",
      "Hidden": false,
      "FullName": "Miss Prince Hodkiewicz II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 66
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "maiores",
      "StrippedValue": "quaerat",
      "Description": "Focused exuding orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "quaerat",
      "Description": "Focused exuding orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "expedita",
      "StrippedValue": "quod",
      "Description": "Configurable homogeneous capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "quod",
      "Description": "Configurable homogeneous capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "dignissimos",
      "Description": "Fundamental systematic matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "dignissimos",
      "Description": "Fundamental systematic matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "Description": "Re-contextualized directional secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 617,
      "Mrmrs": "qui",
      "Firstname": "Demetrius",
      "Lastname": "Anderson",
      "MiddleName": "Schuppe Group",
      "Title": "est",
      "Description": "Down-sized contextually-based intranet",
      "Email": "lenny@purdy.info",
      "FullName": "Mrs. Kelly Raina Jerde I",
      "DirectPhone": "(495)172-1877",
      "FormalName": "Schneider-Muller",
      "CountryId": 753,
      "ContactId": 652,
      "ContactName": "Krajcik, Stokes and Prohaska",
      "Retired": 354,
      "Rank": 82,
      "ActiveInterests": 416,
      "ContactDepartment": "",
      "ContactCountryId": 307,
      "ContactOrgNr": "1294473",
      "FaxPhone": "1-045-742-1958",
      "MobilePhone": "080.907.4620",
      "ContactPhone": "709-047-3926 x746",
      "AssociateName": "Mante, Rodriguez and Raynor",
      "AssociateId": 994,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "neque",
      "Kanalname": "harum",
      "Post1": "ullam",
      "Post2": "et",
      "Post3": "et",
      "EmailName": "assunta@stiedemannlangosh.us",
      "ContactFullName": "Emerson Melyssa Kiehn DVM",
      "ActiveErpLinks": 821,
      "TicketPriorityId": 677,
      "SupportLanguageId": 87,
      "SupportAssociateId": 140,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 192
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 207,
  "GroupId": 463,
  "ActiveStatusMonitorId": 317,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 784,
  "DbiAgentId": 446,
  "DbiLastSyncronized": "1996-06-30T02:49:50.7765657+02:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "1997-04-01T02:49:50.7765657+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 387,
  "ActiveErpLinks": 130,
  "BounceEmails": [
    "flo.rippin@krajcik.uk",
    "maegan@king.com"
  ],
  "Domains": [
    "aut",
    "nemo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kristofer Fritsch I",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "totam"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "exercitationem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 928
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```