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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 24 Sep 2015 17:37:38 G9T

{
  "ContactId": 426,
  "Name": "Murazik Group",
  "Department": "",
  "OrgNr": "896285",
  "Number1": "987403",
  "Number2": "953203",
  "UpdatedDate": "2015-09-24T17:37:38.3918608+02:00",
  "CreatedDate": "2022-10-09T17:37:38.3918608+02:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "laboriosam",
      "Description": "Synergized upward-trending instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "laboriosam",
      "Description": "Synergized upward-trending instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 302,
      "Name": "Conn-Champlin",
      "ToolTip": "Mollitia eos quia ea doloremque suscipit natus.",
      "Deleted": false,
      "Rank": 959,
      "Type": "ex",
      "ColorBlock": 886,
      "IconHint": "nostrum",
      "Selected": true,
      "LastChanged": "2008-05-16T17:37:38.3918608+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reprehenderit",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Clark Walsh",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eius",
      "StrippedValue": "quaerat",
      "Description": "Total stable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "quaerat",
      "Description": "Total stable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sequi",
      "StrippedValue": "ut",
      "Description": "Horizontal non-volatile array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 830
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "ut",
      "Description": "Horizontal non-volatile array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 830
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "omnis",
      "Description": "Grass-roots multi-state open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 940
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "omnis",
      "Description": "Grass-roots multi-state open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 940
        }
      }
    }
  ],
  "Description": "Persevering national Graphical User Interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "soluta",
      "PersonId": 620,
      "Mrmrs": "in",
      "Firstname": "Jayden",
      "Lastname": "Thiel",
      "MiddleName": "Russel LLC",
      "Title": "ipsam",
      "Description": "Grass-roots transitional success",
      "Email": "genesis@corwin.com",
      "FullName": "Fredy Gleichner",
      "DirectPhone": "1-422-409-1293 x773",
      "FormalName": "Mann-Koss",
      "CountryId": 787,
      "ContactId": 774,
      "ContactName": "Becker, Gerhold and Ziemann",
      "Retired": 221,
      "Rank": 291,
      "ActiveInterests": 53,
      "ContactDepartment": "",
      "ContactCountryId": 320,
      "ContactOrgNr": "1173402",
      "FaxPhone": "1-444-518-3124 x442",
      "MobilePhone": "974-919-9564",
      "ContactPhone": "671.496.5223 x64654",
      "AssociateName": "Runte-Fay",
      "AssociateId": 483,
      "UsePersonAddress": false,
      "ContactFax": "facere",
      "Kanafname": "sapiente",
      "Kanalname": "consectetur",
      "Post1": "amet",
      "Post2": "commodi",
      "Post3": "aut",
      "EmailName": "kayley@pollich.com",
      "ContactFullName": "Lindsay Hickle",
      "ActiveErpLinks": 713,
      "TicketPriorityId": 144,
      "SupportLanguageId": 26,
      "SupportAssociateId": 123,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 880
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quidem",
  "Xstop": true,
  "ActiveInterests": 144,
  "GroupId": 940,
  "ActiveStatusMonitorId": 107,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 641,
  "DbiAgentId": 404,
  "DbiLastSyncronized": "2021-05-26T17:37:38.3958597+02:00",
  "DbiKey": "sit",
  "DbiLastModified": "2012-04-27T17:37:38.3958597+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 713,
  "ActiveErpLinks": 760,
  "BounceEmails": [
    "alf@doylegraham.uk",
    "milo@reingerklocko.co.uk"
  ],
  "Domains": [
    "quam",
    "quam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Casey Sanford",
    "SuperOffice:2": "99084343"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "architecto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 737
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```