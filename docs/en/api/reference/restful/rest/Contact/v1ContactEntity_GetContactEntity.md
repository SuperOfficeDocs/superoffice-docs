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
Last-Modified: Wed, 02 Oct 2019 03:51:33 G10T

{
  "ContactId": 102,
  "Name": "Hermiston LLC",
  "Department": "",
  "OrgNr": "540373",
  "Number1": "393172",
  "Number2": "1513738",
  "UpdatedDate": "2019-10-02T03:51:33.3022985+02:00",
  "CreatedDate": "2014-06-27T03:51:33.3022985+02:00",
  "Emails": [
    {
      "Value": "tenetur",
      "StrippedValue": "a",
      "Description": "Face to face coherent archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "a",
      "Description": "Face to face coherent archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 564,
      "Name": "Borer Inc and Sons",
      "ToolTip": "Ab sed voluptates non.",
      "Deleted": false,
      "Rank": 675,
      "Type": "a",
      "ColorBlock": 265,
      "IconHint": "veritatis",
      "Selected": true,
      "LastChanged": "2008-03-12T03:51:33.3022985+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsam",
      "StyleHint": "maxime",
      "Hidden": false,
      "FullName": "Jody Ullrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quidem",
      "StrippedValue": "minima",
      "Description": "Persevering mobile focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 648
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "minima",
      "Description": "Persevering mobile focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 648
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "maiores",
      "StrippedValue": "eligendi",
      "Description": "Mandatory stable solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "eligendi",
      "Description": "Mandatory stable solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ab",
      "StrippedValue": "sunt",
      "Description": "Assimilated regional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "sunt",
      "Description": "Assimilated regional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    }
  ],
  "Description": "Organic mobile capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "hic",
      "PersonId": 308,
      "Mrmrs": "neque",
      "Firstname": "Julia",
      "Lastname": "Boyer",
      "MiddleName": "Cremin LLC",
      "Title": "temporibus",
      "Description": "Assimilated homogeneous system engine",
      "Email": "justyn.kemmer@rodriguezborer.info",
      "FullName": "Keegan Madaline Jast PhD",
      "DirectPhone": "250.470.2815",
      "FormalName": "Smith-Welch",
      "CountryId": 218,
      "ContactId": 430,
      "ContactName": "Mann, Cronin and Haag",
      "Retired": 792,
      "Rank": 594,
      "ActiveInterests": 2,
      "ContactDepartment": "",
      "ContactCountryId": 85,
      "ContactOrgNr": "1364618",
      "FaxPhone": "785-315-6450 x2476",
      "MobilePhone": "(754)270-9271 x12934",
      "ContactPhone": "(403)080-3572 x3528",
      "AssociateName": "Moore, Legros and Willms",
      "AssociateId": 883,
      "UsePersonAddress": false,
      "ContactFax": "impedit",
      "Kanafname": "et",
      "Kanalname": "sunt",
      "Post1": "adipisci",
      "Post2": "quia",
      "Post3": "nam",
      "EmailName": "irma@quigleymayer.info",
      "ContactFullName": "Mr. Braeden Shields",
      "ActiveErpLinks": 789,
      "TicketPriorityId": 446,
      "SupportLanguageId": 693,
      "SupportAssociateId": 558,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "reiciendis",
  "Xstop": false,
  "ActiveInterests": 613,
  "GroupId": 749,
  "ActiveStatusMonitorId": 437,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 767,
  "DbiAgentId": 729,
  "DbiLastSyncronized": "2004-04-12T03:51:33.3491613+02:00",
  "DbiKey": "repellendus",
  "DbiLastModified": "2006-09-05T03:51:33.3491613+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 777,
  "ActiveErpLinks": 361,
  "BounceEmails": [
    "jeffery@hauck.uk",
    "angelina_will@marvin.info"
  ],
  "Domains": [
    "architecto",
    "totam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Layla Schumm",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 888
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```