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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 31 Jan 1998 14:19:10 G1T

{
  "ContactId": 784,
  "Name": "Waters Group",
  "Department": "",
  "OrgNr": "581476",
  "Number1": "1612622",
  "Number2": "679328",
  "UpdatedDate": "1998-01-31T14:19:10.1623498+01:00",
  "CreatedDate": "2016-09-15T14:19:10.1623498+02:00",
  "Emails": [
    {
      "Value": "doloremque",
      "StrippedValue": "consequatur",
      "Description": "Optimized dynamic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "consequatur",
      "Description": "Optimized dynamic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 329,
      "Name": "Sporer LLC",
      "ToolTip": "Cumque sit ducimus et quos numquam.",
      "Deleted": true,
      "Rank": 577,
      "Type": "in",
      "ColorBlock": 394,
      "IconHint": "molestias",
      "Selected": true,
      "LastChanged": "2018-02-22T14:19:10.1623498+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "pariatur",
      "StyleHint": "minus",
      "Hidden": true,
      "FullName": "Emilia Gottlieb",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 987
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "consequatur",
      "Description": "Networked mission-critical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "consequatur",
      "Description": "Networked mission-critical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolor",
      "StrippedValue": "asperiores",
      "Description": "Persistent real-time parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 450
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "asperiores",
      "Description": "Persistent real-time parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 450
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eius",
      "StrippedValue": "sunt",
      "Description": "Reduced 24/7 algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "sunt",
      "Description": "Reduced 24/7 algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "Description": "Robust non-volatile orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eligendi",
      "PersonId": 524,
      "Mrmrs": "nobis",
      "Firstname": "Coby",
      "Lastname": "Heathcote",
      "MiddleName": "Sipes, Marks and Ankunding",
      "Title": "dignissimos",
      "Description": "Diverse multi-tasking methodology",
      "Email": "randy.waters@hodkiewiczpurdy.name",
      "FullName": "Mathew Bogan",
      "DirectPhone": "(101)899-4216 x425",
      "FormalName": "Veum Group",
      "CountryId": 777,
      "ContactId": 768,
      "ContactName": "Von-Ullrich",
      "Retired": 118,
      "Rank": 72,
      "ActiveInterests": 403,
      "ContactDepartment": "",
      "ContactCountryId": 594,
      "ContactOrgNr": "954088",
      "FaxPhone": "858-096-2373",
      "MobilePhone": "1-646-216-0241 x10555",
      "ContactPhone": "(234)308-1180",
      "AssociateName": "Hammes Inc and Sons",
      "AssociateId": 89,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "odit",
      "Kanalname": "nihil",
      "Post1": "sunt",
      "Post2": "cum",
      "Post3": "fugit",
      "EmailName": "lee_moen@gerholdlegros.uk",
      "ContactFullName": "Ernie Liza Lynch Jr.",
      "ActiveErpLinks": 76,
      "TicketPriorityId": 514,
      "SupportLanguageId": 388,
      "SupportAssociateId": 840,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "consequatur",
  "Xstop": false,
  "ActiveInterests": 844,
  "GroupId": 374,
  "ActiveStatusMonitorId": 299,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 382,
  "DbiAgentId": 431,
  "DbiLastSyncronized": "2009-09-16T14:19:10.1779741+02:00",
  "DbiKey": "quis",
  "DbiLastModified": "2001-12-07T14:19:10.1779741+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 332,
  "ActiveErpLinks": 488,
  "BounceEmails": [
    "rene@jones.co.uk",
    "murray_kerluke@funklabadie.biz"
  ],
  "Domains": [
    "error",
    "autem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2087325310",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "adipisci",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 796
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```