---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 820,
  "Name": "Huel, Mayert and Weber",
  "Department": "",
  "OrgNr": "1067510",
  "Number1": "1542961",
  "Number2": "419487",
  "UpdatedDate": "2021-06-25T23:04:03.964023+02:00",
  "CreatedDate": "2001-05-29T23:04:03.964023+02:00",
  "Emails": [
    {
      "Value": "excepturi",
      "StrippedValue": "distinctio",
      "Description": "Diverse 5th generation implementation"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "distinctio",
      "Description": "Diverse 5th generation implementation"
    }
  ],
  "Interests": [
    {
      "Id": 779,
      "Name": "Hodkiewicz-Reichel",
      "ToolTip": "Veritatis deserunt deleniti ratione.",
      "Deleted": false,
      "Rank": 489,
      "Type": "facilis",
      "ColorBlock": 525,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "2018-11-01T23:04:03.964023+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "esse",
      "Hidden": false,
      "FullName": "Anne Considine"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "qui",
      "Description": "Reactive methodical installation"
    },
    {
      "Value": "ut",
      "StrippedValue": "qui",
      "Description": "Reactive methodical installation"
    }
  ],
  "Phones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "ratione",
      "Description": "Reactive user-facing pricing structure"
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "ratione",
      "Description": "Reactive user-facing pricing structure"
    }
  ],
  "Faxes": [
    {
      "Value": "ratione",
      "StrippedValue": "qui",
      "Description": "Secured fault-tolerant concept"
    },
    {
      "Value": "ratione",
      "StrippedValue": "qui",
      "Description": "Secured fault-tolerant concept"
    }
  ],
  "Description": "Organized didactic solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "possimus",
      "PersonId": 635,
      "Mrmrs": "mollitia",
      "Firstname": "Charles",
      "Lastname": "Hane",
      "MiddleName": "Gaylord LLC",
      "Title": "velit",
      "Description": "Streamlined mission-critical analyzer",
      "Email": "marquise.erdman@reinger.com",
      "FullName": "Prof. Domenica Kara Lang",
      "DirectPhone": "1-424-770-7543 x457",
      "FormalName": "Rutherford, Keebler and Abshire",
      "CountryId": 571,
      "ContactId": 791,
      "ContactName": "Goyette-Fadel",
      "Retired": 926,
      "Rank": 142,
      "ActiveInterests": 93,
      "ContactDepartment": "",
      "ContactCountryId": 779,
      "ContactOrgNr": "601659",
      "FaxPhone": "1-520-629-3026 x9873",
      "MobilePhone": "436-060-5683 x48592",
      "ContactPhone": "1-510-451-7928 x229",
      "AssociateName": "Hermann Inc and Sons",
      "AssociateId": 706,
      "UsePersonAddress": true,
      "ContactFax": "culpa",
      "Kanafname": "quia",
      "Kanalname": "dolore",
      "Post1": "quod",
      "Post2": "a",
      "Post3": "dolorum",
      "EmailName": "jolie.auer@ziemann.info",
      "ContactFullName": "Mercedes Schulist",
      "ActiveErpLinks": 69,
      "TicketPriorityId": 693,
      "SupportLanguageId": 566,
      "SupportAssociateId": 172,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptate",
  "Xstop": true,
  "ActiveInterests": 642,
  "GroupId": 784,
  "ActiveStatusMonitorId": 210,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 565,
  "DbiAgentId": 879,
  "DbiLastSyncronized": "2016-01-29T23:04:03.9700198+01:00",
  "DbiKey": "mollitia",
  "DbiLastModified": "2020-10-14T23:04:03.9700198+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 907,
  "ActiveErpLinks": 774,
  "BounceEmails": [
    "birdie.runte@gleichnerkoelpin.us",
    "charlene.roberts@hansen.co.uk"
  ],
  "Domains": [
    "accusantium",
    "modi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Shaina Jakubowski Jr.",
    "SuperOffice:2": "Ms. Savanna Dietrich III"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "consectetur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 683,
  "Name": "Hermann Group",
  "Department": "",
  "OrgNr": "837465",
  "Number1": "985570",
  "Number2": "927001",
  "UpdatedDate": "1997-07-07T23:04:03.9800231+02:00",
  "CreatedDate": "2012-10-16T23:04:03.9800231+02:00",
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "natus",
      "Description": "Realigned dynamic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "natus",
      "Description": "Realigned dynamic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 183,
      "Name": "Harvey Inc and Sons",
      "ToolTip": "Incidunt nulla laudantium neque.",
      "Deleted": false,
      "Rank": 828,
      "Type": "ratione",
      "ColorBlock": 353,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2012-03-28T23:04:03.9800231+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Vernice Kale Moore I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 682
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "voluptas",
      "Description": "Virtual content-based parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 235
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "voluptas",
      "Description": "Virtual content-based parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 235
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "officia",
      "StrippedValue": "quibusdam",
      "Description": "Front-line leading edge flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 459
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "quibusdam",
      "Description": "Front-line leading edge flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 459
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "facere",
      "StrippedValue": "quia",
      "Description": "Diverse methodical frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 246
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "quia",
      "Description": "Diverse methodical frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 246
        }
      }
    }
  ],
  "Description": "Devolved optimizing productivity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 604,
      "Mrmrs": "in",
      "Firstname": "Yadira",
      "Lastname": "Leannon",
      "MiddleName": "Bosco Group",
      "Title": "quia",
      "Description": "Mandatory encompassing migration",
      "Email": "lucy_metz@mccullough.co.uk",
      "FullName": "Emmanuel Moen",
      "DirectPhone": "(828)396-7298 x458",
      "FormalName": "Koch-Waters",
      "CountryId": 983,
      "ContactId": 198,
      "ContactName": "Thiel LLC",
      "Retired": 101,
      "Rank": 268,
      "ActiveInterests": 302,
      "ContactDepartment": "",
      "ContactCountryId": 189,
      "ContactOrgNr": "864217",
      "FaxPhone": "037.599.5912 x695",
      "MobilePhone": "209-910-7024",
      "ContactPhone": "1-012-411-0578 x896",
      "AssociateName": "Schuster Inc and Sons",
      "AssociateId": 47,
      "UsePersonAddress": true,
      "ContactFax": "id",
      "Kanafname": "cumque",
      "Kanalname": "consequatur",
      "Post1": "voluptatibus",
      "Post2": "enim",
      "Post3": "commodi",
      "EmailName": "uriah@moenlynch.name",
      "ContactFullName": "Hiram Lubowitz",
      "ActiveErpLinks": 957,
      "TicketPriorityId": 862,
      "SupportLanguageId": 896,
      "SupportAssociateId": 415,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "nulla",
  "Xstop": false,
  "ActiveInterests": 756,
  "GroupId": 214,
  "ActiveStatusMonitorId": 159,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 704,
  "DbiAgentId": 825,
  "DbiLastSyncronized": "2017-08-11T23:04:03.9850228+02:00",
  "DbiKey": "laboriosam",
  "DbiLastModified": "2008-01-28T23:04:03.9850228+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 208,
  "ActiveErpLinks": 741,
  "BounceEmails": [
    "liza@blick.co.uk",
    "gracie@jaskolski.com"
  ],
  "Domains": [
    "voluptas",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jake Connelly",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "quam"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 863
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```