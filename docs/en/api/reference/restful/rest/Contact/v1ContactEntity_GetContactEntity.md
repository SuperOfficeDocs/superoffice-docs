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
Last-Modified: Fri, 25 Jul 2008 12:15:26 G7T

{
  "ContactId": 641,
  "Name": "Gottlieb-Osinski",
  "Department": "",
  "OrgNr": "1140742",
  "Number1": "872255",
  "Number2": "287608",
  "UpdatedDate": "2008-07-25T12:15:26.6116411+02:00",
  "CreatedDate": "2021-11-30T12:15:26.6116411+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "dolor",
      "Description": "Total upward-trending matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 115
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "dolor",
      "Description": "Total upward-trending matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 115
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 28,
      "Name": "Paucek LLC",
      "ToolTip": "Laudantium omnis.",
      "Deleted": true,
      "Rank": 206,
      "Type": "molestiae",
      "ColorBlock": 674,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "1996-06-25T12:15:26.6116411+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "eveniet",
      "Hidden": false,
      "FullName": "Deion Eleonore McDermott Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "rem",
      "Description": "Customer-focused zero tolerance matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 932
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "rem",
      "Description": "Customer-focused zero tolerance matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 932
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sapiente",
      "StrippedValue": "ut",
      "Description": "Decentralized bottom-line contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "ut",
      "Description": "Decentralized bottom-line contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iure",
      "StrippedValue": "doloremque",
      "Description": "Configurable object-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 232
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "doloremque",
      "Description": "Configurable object-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 232
        }
      }
    }
  ],
  "Description": "Re-contextualized full-range service-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequuntur",
      "PersonId": 412,
      "Mrmrs": "in",
      "Firstname": "Misty",
      "Lastname": "Boyer",
      "MiddleName": "Wiza-Robel",
      "Title": "quidem",
      "Description": "Implemented scalable instruction set",
      "Email": "rollin.lemke@weimann.us",
      "FullName": "Solon Wuckert",
      "DirectPhone": "1-769-837-8121 x5048",
      "FormalName": "Roob Inc and Sons",
      "CountryId": 758,
      "ContactId": 277,
      "ContactName": "Roberts, Rutherford and Murazik",
      "Retired": 958,
      "Rank": 541,
      "ActiveInterests": 109,
      "ContactDepartment": "",
      "ContactCountryId": 647,
      "ContactOrgNr": "1505164",
      "FaxPhone": "1-557-780-6753 x6820",
      "MobilePhone": "848-006-4261",
      "ContactPhone": "279.758.3439 x35131",
      "AssociateName": "Olson-Thiel",
      "AssociateId": 679,
      "UsePersonAddress": false,
      "ContactFax": "dolorem",
      "Kanafname": "et",
      "Kanalname": "quo",
      "Post1": "suscipit",
      "Post2": "minus",
      "Post3": "incidunt",
      "EmailName": "jamarcus_feil@legros.uk",
      "ContactFullName": "Shawna Muller",
      "ActiveErpLinks": 6,
      "TicketPriorityId": 463,
      "SupportLanguageId": 270,
      "SupportAssociateId": 254,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 523
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "tempora",
  "Xstop": false,
  "ActiveInterests": 832,
  "GroupId": 198,
  "ActiveStatusMonitorId": 270,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 3,
  "DbiAgentId": 854,
  "DbiLastSyncronized": "2020-03-31T12:15:26.6156409+02:00",
  "DbiKey": "nulla",
  "DbiLastModified": "2012-02-23T12:15:26.6156409+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 168,
  "ActiveErpLinks": 118,
  "BounceEmails": [
    "bryon.nicolas@kovacek.biz",
    "susan@witting.name"
  ],
  "Domains": [
    "aut",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Barney Mohr"
  },
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 232
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```