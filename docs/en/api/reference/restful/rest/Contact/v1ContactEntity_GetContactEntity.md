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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 17 Dec 2007 14:28:26 G12T

{
  "ContactId": 247,
  "Name": "Pouros, Bahringer and Beier",
  "Department": "",
  "OrgNr": "1119955",
  "Number1": "875268",
  "Number2": "1107390",
  "UpdatedDate": "2007-12-17T14:28:26.820824+01:00",
  "CreatedDate": "1998-12-10T14:28:26.820824+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "fugiat",
      "Description": "Triple-buffered neutral website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 550
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "fugiat",
      "Description": "Triple-buffered neutral website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 550
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 763,
      "Name": "Buckridge-Homenick",
      "ToolTip": "Modi occaecati sint quia esse tenetur.",
      "Deleted": false,
      "Rank": 873,
      "Type": "laudantium",
      "ColorBlock": 961,
      "IconHint": "quidem",
      "Selected": false,
      "LastChanged": "2001-03-31T14:28:26.820824+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Leatha Ryan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 9
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Focused tertiary standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 521
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Focused tertiary standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 521
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Public-key homogeneous parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Public-key homogeneous parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "facilis",
      "StrippedValue": "voluptatem",
      "Description": "Up-sized analyzing productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "voluptatem",
      "Description": "Up-sized analyzing productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    }
  ],
  "Description": "Multi-lateral clear-thinking support",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "reprehenderit",
      "PersonId": 939,
      "Mrmrs": "eius",
      "Firstname": "Fidel",
      "Lastname": "Steuber",
      "MiddleName": "Armstrong, Balistreri and Larson",
      "Title": "saepe",
      "Description": "Visionary stable capability",
      "Email": "alexa@block.uk",
      "FullName": "Norval Dare III",
      "DirectPhone": "398-187-1461",
      "FormalName": "Simonis, Keeling and Franecki",
      "CountryId": 224,
      "ContactId": 420,
      "ContactName": "O'Keefe-Bauch",
      "Retired": 31,
      "Rank": 578,
      "ActiveInterests": 847,
      "ContactDepartment": "",
      "ContactCountryId": 199,
      "ContactOrgNr": "1485974",
      "FaxPhone": "(600)991-2091 x398",
      "MobilePhone": "788-238-1504",
      "ContactPhone": "238-194-5164 x640",
      "AssociateName": "Pollich Group",
      "AssociateId": 761,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "nisi",
      "Kanalname": "sit",
      "Post1": "alias",
      "Post2": "vitae",
      "Post3": "et",
      "EmailName": "roberto@hermistonhoppe.co.uk",
      "ContactFullName": "Ayla Bahringer",
      "ActiveErpLinks": 24,
      "TicketPriorityId": 43,
      "SupportLanguageId": 554,
      "SupportAssociateId": 207,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1290938",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 607,
  "GroupId": 150,
  "ActiveStatusMonitorId": 395,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 892,
  "DbiAgentId": 878,
  "DbiLastSyncronized": "2001-11-13T14:28:26.820824+01:00",
  "DbiKey": "impedit",
  "DbiLastModified": "2019-06-12T14:28:26.820824+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 975,
  "ActiveErpLinks": 800,
  "BounceEmails": [
    "annie@runtegusikowski.name",
    "nayeli@kautzer.info"
  ],
  "Domains": [
    "consectetur",
    "voluptatum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Sherwood Goldner PhD",
    "SuperOffice:2": "Berneice Kuhn"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "reprehenderit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 160
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```