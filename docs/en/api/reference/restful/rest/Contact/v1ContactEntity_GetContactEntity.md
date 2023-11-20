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
Last-Modified: Sat, 08 Nov 2008 13:38:17 G11T

{
  "ContactId": 18,
  "Name": "Langosh Inc and Sons",
  "Department": "productize bricks-and-clicks bandwidth",
  "OrgNr": "1301147",
  "Number1": "577033",
  "Number2": "1434200",
  "UpdatedDate": "2008-11-08T13:38:17.2337227+01:00",
  "CreatedDate": "2022-09-27T13:38:17.2337227+02:00",
  "Emails": [
    {
      "Value": "debitis",
      "StrippedValue": "iste",
      "Description": "Multi-lateral heuristic projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 533
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "iste",
      "Description": "Multi-lateral heuristic projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 533
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 481,
      "Name": "O'Connell Group",
      "ToolTip": "Culpa dolorem provident harum ab.",
      "Deleted": true,
      "Rank": 537,
      "Type": "accusamus",
      "ColorBlock": 519,
      "IconHint": "quas",
      "Selected": false,
      "LastChanged": "2022-08-31T13:38:17.2337227+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "itaque",
      "StyleHint": "animi",
      "Hidden": false,
      "FullName": "Serena Walker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 590
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "earum",
      "StrippedValue": "et",
      "Description": "Quality-focused secondary matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "et",
      "Description": "Quality-focused secondary matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "adipisci",
      "StrippedValue": "impedit",
      "Description": "Progressive maximized framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "impedit",
      "Description": "Progressive maximized framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "tempore",
      "Description": "Digitized intermediate neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "tempore",
      "Description": "Digitized intermediate neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "Description": "De-engineered motivating budgetary management",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "blanditiis",
      "PersonId": 126,
      "Mrmrs": "molestias",
      "Firstname": "Eileen",
      "Lastname": "Kassulke",
      "MiddleName": "Zieme-Dickens",
      "Title": "aliquam",
      "Description": "Exclusive homogeneous hub",
      "Email": "dana@ruecker.biz",
      "FullName": "Prudence Leffler",
      "DirectPhone": "1-179-380-3655 x4682",
      "FormalName": "Williamson Group",
      "CountryId": 191,
      "ContactId": 816,
      "ContactName": "McGlynn LLC",
      "Retired": 780,
      "Rank": 202,
      "ActiveInterests": 303,
      "ContactDepartment": "",
      "ContactCountryId": 53,
      "ContactOrgNr": "1182722",
      "FaxPhone": "1-253-588-8010",
      "MobilePhone": "115-921-0292",
      "ContactPhone": "1-672-864-8725",
      "AssociateName": "Steuber, Dicki and Bogan",
      "AssociateId": 280,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "sed",
      "Kanalname": "in",
      "Post1": "magni",
      "Post2": "fuga",
      "Post3": "et",
      "EmailName": "jaren.bernier@price.info",
      "ContactFullName": "Stan Feeney",
      "ActiveErpLinks": 488,
      "TicketPriorityId": 97,
      "SupportLanguageId": 48,
      "SupportAssociateId": 717,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "adipisci",
  "Xstop": true,
  "ActiveInterests": 973,
  "GroupId": 455,
  "ActiveStatusMonitorId": 730,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 971,
  "DbiAgentId": 607,
  "DbiLastSyncronized": "2008-03-31T13:38:17.2337227+02:00",
  "DbiKey": "in",
  "DbiLastModified": "2023-01-31T13:38:17.2337227+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 953,
  "ActiveErpLinks": 346,
  "BounceEmails": [
    "dereck@flatley.uk",
    "holden@kertzmann.co.uk"
  ],
  "Domains": [
    "iste",
    "fuga"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Tianna Casper",
    "SuperOffice:2": "124868006"
  },
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "rem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 12
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```