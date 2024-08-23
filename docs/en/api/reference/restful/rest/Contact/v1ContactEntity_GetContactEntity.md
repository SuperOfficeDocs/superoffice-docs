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
GET /api/v1/Contact/{id}?fk=True
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 05 Oct 2013 13:28:31 G10T

{
  "ContactId": 686,
  "Name": "Kling Group",
  "Department": "",
  "OrgNr": "1444226",
  "Number1": "1354723",
  "Number2": "850846",
  "UpdatedDate": "2013-10-05T13:28:31.4449206+02:00",
  "CreatedDate": "2005-09-04T13:28:31.4449206+02:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "officia",
      "Description": "Function-based bottom-line database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 576
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "officia",
      "Description": "Function-based bottom-line database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 576
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 598,
      "Name": "Hodkiewicz Group",
      "ToolTip": "Minus aspernatur totam ea aperiam.",
      "Deleted": false,
      "Rank": 644,
      "Type": "commodi",
      "ColorBlock": 233,
      "IconHint": "officiis",
      "Selected": false,
      "LastChanged": "2020-08-04T13:28:31.4449206+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Everett Alize Torp PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 704
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "ut",
      "Description": "Intuitive analyzing attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "ut",
      "Description": "Intuitive analyzing attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quos",
      "StrippedValue": "officiis",
      "Description": "Balanced mobile migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "officiis",
      "Description": "Balanced mobile migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quo",
      "StrippedValue": "rem",
      "Description": "Innovative intermediate throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "rem",
      "Description": "Innovative intermediate throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    }
  ],
  "Description": "Customer-focused cohesive workforce",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 824,
      "Mrmrs": "vel",
      "Firstname": "Brook",
      "Lastname": "DuBuque",
      "MiddleName": "Waters-Stroman",
      "Title": "cupiditate",
      "Description": "Enterprise-wide real-time service-desk",
      "Email": "bradley_jacobi@grady.ca",
      "FullName": "Greta Bartell",
      "DirectPhone": "(490)357-7242",
      "FormalName": "Smitham-Hoeger",
      "CountryId": 426,
      "ContactId": 637,
      "ContactName": "Leffler-Kirlin",
      "Retired": 107,
      "Rank": 182,
      "ActiveInterests": 824,
      "ContactDepartment": "",
      "ContactCountryId": 504,
      "ContactOrgNr": "434713",
      "FaxPhone": "(524)205-2131",
      "MobilePhone": "1-139-094-9526",
      "ContactPhone": "833-403-2892 x42230",
      "AssociateName": "Wunsch-Friesen",
      "AssociateId": 790,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "ut",
      "Kanalname": "dolorum",
      "Post1": "dolor",
      "Post2": "illum",
      "Post3": "quis",
      "EmailName": "jayda_schiller@becker.info",
      "ContactFullName": "Zackery Effertz",
      "ActiveErpLinks": 832,
      "TicketPriorityId": 137,
      "SupportLanguageId": 624,
      "SupportAssociateId": 313,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 745
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quisquam",
  "Xstop": true,
  "ActiveInterests": 222,
  "GroupId": 271,
  "ActiveStatusMonitorId": 312,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 32,
  "DbiAgentId": 142,
  "DbiLastSyncronized": "2000-10-08T13:28:31.460542+02:00",
  "DbiKey": "non",
  "DbiLastModified": "2003-03-25T13:28:31.460542+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 912,
  "ActiveErpLinks": 183,
  "BounceEmails": [
    "viva.schulist@corkery.ca",
    "toby@corkery.name"
  ],
  "Domains": [
    "non",
    "autem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Mr. Ivory Terrill Funk"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "numquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 770
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```