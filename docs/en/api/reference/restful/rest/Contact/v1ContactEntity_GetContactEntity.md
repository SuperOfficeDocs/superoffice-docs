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
Last-Modified: Wed, 23 Feb 2000 14:32:11 G2T

{
  "ContactId": 512,
  "Name": "D'Amore, O'Keefe and Gaylord",
  "Department": "",
  "OrgNr": "1485015",
  "Number1": "823332",
  "Number2": "820341",
  "UpdatedDate": "2000-02-23T14:32:11.3020727+01:00",
  "CreatedDate": "2010-05-20T14:32:11.3020727+02:00",
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "sed",
      "Description": "Innovative user-facing focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "sed",
      "Description": "Innovative user-facing focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 471,
      "Name": "Cremin-Lueilwitz",
      "ToolTip": "Quisquam sunt.",
      "Deleted": false,
      "Rank": 147,
      "Type": "maiores",
      "ColorBlock": 106,
      "IconHint": "accusamus",
      "Selected": false,
      "LastChanged": "2013-11-12T14:32:11.3020727+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ratione",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Prof. Araceli Lubowitz Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequuntur",
      "StrippedValue": "et",
      "Description": "Operative responsive budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 777
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "et",
      "Description": "Operative responsive budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 777
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "omnis",
      "Description": "Managed neutral emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "omnis",
      "Description": "Managed neutral emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "velit",
      "Description": "Switchable demand-driven focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "velit",
      "Description": "Switchable demand-driven focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    }
  ],
  "Description": "Networked solution-oriented middleware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 272,
      "Mrmrs": "debitis",
      "Firstname": "Steve",
      "Lastname": "Lockman",
      "MiddleName": "Anderson, Pagac and Berge",
      "Title": "eos",
      "Description": "Virtual dynamic task-force",
      "Email": "heidi@klein.com",
      "FullName": "Virgie Parisian",
      "DirectPhone": "553-941-9076",
      "FormalName": "Cronin, Braun and Kiehn",
      "CountryId": 258,
      "ContactId": 418,
      "ContactName": "Corwin Inc and Sons",
      "Retired": 290,
      "Rank": 625,
      "ActiveInterests": 111,
      "ContactDepartment": "",
      "ContactCountryId": 581,
      "ContactOrgNr": "1794048",
      "FaxPhone": "792.143.2890",
      "MobilePhone": "975-101-5379 x98828",
      "ContactPhone": "105-871-0454 x19439",
      "AssociateName": "Boyer-Torp",
      "AssociateId": 348,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "aut",
      "Kanalname": "adipisci",
      "Post1": "omnis",
      "Post2": "nemo",
      "Post3": "dolore",
      "EmailName": "georgiana.anderson@rennermetz.info",
      "ContactFullName": "Mrs. Herminia Prohaska PhD",
      "ActiveErpLinks": 274,
      "TicketPriorityId": 392,
      "SupportLanguageId": 524,
      "SupportAssociateId": 54,
      "CategoryName": "VIP Customer",
      "PersonNumber": "441854",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": false,
  "ActiveInterests": 395,
  "GroupId": 674,
  "ActiveStatusMonitorId": 366,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 348,
  "DbiAgentId": 551,
  "DbiLastSyncronized": "2009-06-22T14:32:11.3020727+02:00",
  "DbiKey": "vel",
  "DbiLastModified": "2010-03-15T14:32:11.3020727+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 604,
  "ActiveErpLinks": 63,
  "BounceEmails": [
    "haley_hauck@wiegand.uk",
    "judy_lowe@leschwintheiser.biz"
  ],
  "Domains": [
    "et",
    "illo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Avery Elmer Green Jr.",
    "SuperOffice:2": "341772534"
  },
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "odio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 153
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```