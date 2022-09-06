---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
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

## Response

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 611,
  "Name": "Parisian, Schamberger and Connelly",
  "Department": "",
  "OrgNr": "1659426",
  "Number1": "649893",
  "Number2": "218730",
  "UpdatedDate": "2008-02-19T11:10:52.6641741+01:00",
  "CreatedDate": "2009-02-08T11:10:52.6641741+01:00",
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "eum",
      "Description": "Team-oriented upward-trending orchestration"
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "eum",
      "Description": "Team-oriented upward-trending orchestration"
    }
  ],
  "Interests": [
    {
      "Id": 910,
      "Name": "Donnelly Group",
      "ToolTip": "Maiores nihil quia quidem sit vel distinctio.",
      "Deleted": false,
      "Rank": 414,
      "Type": "labore",
      "ColorBlock": 356,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2010-11-13T11:10:52.6651867+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Godfrey Vicenta Spinka II"
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "assumenda",
      "Description": "Cross-platform multi-tasking website"
    },
    {
      "Value": "omnis",
      "StrippedValue": "assumenda",
      "Description": "Cross-platform multi-tasking website"
    }
  ],
  "Phones": [
    {
      "Value": "id",
      "StrippedValue": "soluta",
      "Description": "Front-line leading edge hierarchy"
    },
    {
      "Value": "id",
      "StrippedValue": "soluta",
      "Description": "Front-line leading edge hierarchy"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "aspernatur",
      "Description": "Phased grid-enabled contingency"
    },
    {
      "Value": "qui",
      "StrippedValue": "aspernatur",
      "Description": "Phased grid-enabled contingency"
    }
  ],
  "Description": "Visionary context-sensitive middleware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 871,
      "Mrmrs": "enim",
      "Firstname": "Helga",
      "Lastname": "Cole",
      "MiddleName": "Conroy, Harvey and Gleason",
      "Title": "ad",
      "Description": "Secured client-driven moderator",
      "Email": "sadye.wyman@hagenesdouglas.info",
      "FullName": "Santiago Osborne Oberbrunner MD",
      "DirectPhone": "154.529.6383 x37145",
      "FormalName": "Reynolds Group",
      "CountryId": 566,
      "ContactId": 367,
      "ContactName": "Skiles, Price and Turcotte",
      "Retired": 172,
      "Rank": 239,
      "ActiveInterests": 752,
      "ContactDepartment": "",
      "ContactCountryId": 765,
      "ContactOrgNr": "698223",
      "FaxPhone": "1-386-457-1229",
      "MobilePhone": "1-928-806-5646 x603",
      "ContactPhone": "(192)505-8814",
      "AssociateName": "Kutch LLC",
      "AssociateId": 738,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "quas",
      "Kanalname": "consequatur",
      "Post1": "eos",
      "Post2": "aut",
      "Post3": "dolorem",
      "EmailName": "seamus@wiegand.name",
      "ContactFullName": "Ms. Martina Osinski",
      "ActiveErpLinks": 914,
      "TicketPriorityId": 780,
      "SupportLanguageId": 164,
      "SupportAssociateId": 254,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "nesciunt",
  "Xstop": true,
  "ActiveInterests": 942,
  "GroupId": 357,
  "ActiveStatusMonitorId": 854,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 984,
  "DbiAgentId": 898,
  "DbiLastSyncronized": "2009-03-26T11:10:52.6681746+01:00",
  "DbiKey": "possimus",
  "DbiLastModified": "2017-01-29T11:10:52.6681746+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 223,
  "ActiveErpLinks": 174,
  "BounceEmails": [
    "addie@conroy.com",
    "wendell@schoen.info"
  ],
  "Domains": [
    "nobis",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1356874257",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "adipisci"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 272,
  "Name": "Boyer, VonRueden and Crona",
  "Department": "",
  "OrgNr": "1086245",
  "Number1": "1415601",
  "Number2": "1393915",
  "UpdatedDate": "2013-02-28T11:10:52.6781744+01:00",
  "CreatedDate": "2002-07-19T11:10:52.6781744+02:00",
  "Emails": [
    {
      "Value": "enim",
      "StrippedValue": "consequatur",
      "Description": "Vision-oriented client-driven local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "consequatur",
      "Description": "Vision-oriented client-driven local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 453,
      "Name": "Kohler-Lynch",
      "ToolTip": "Quia consequatur voluptatum maxime.",
      "Deleted": false,
      "Rank": 805,
      "Type": "vitae",
      "ColorBlock": 781,
      "IconHint": "voluptatibus",
      "Selected": false,
      "LastChanged": "2003-03-10T11:10:52.6781744+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "rerum",
      "Hidden": true,
      "FullName": "Claire Schiller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "quo",
      "Description": "Visionary transitional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "quo",
      "Description": "Visionary transitional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "debitis",
      "StrippedValue": "deleniti",
      "Description": "Cross-group high-level matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "deleniti",
      "Description": "Cross-group high-level matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "soluta",
      "StrippedValue": "voluptas",
      "Description": "Multi-layered 24 hour hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "voluptas",
      "Description": "Multi-layered 24 hour hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    }
  ],
  "Description": "Self-enabling modular artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dicta",
      "PersonId": 936,
      "Mrmrs": "voluptate",
      "Firstname": "Rosalia",
      "Lastname": "Okuneva",
      "MiddleName": "Glover, Schumm and Bradtke",
      "Title": "omnis",
      "Description": "Object-based impactful portal",
      "Email": "tyson@abernathy.us",
      "FullName": "Ms. Freeman Bauch",
      "DirectPhone": "(159)928-1527 x726",
      "FormalName": "Hudson LLC",
      "CountryId": 151,
      "ContactId": 143,
      "ContactName": "Lueilwitz-Reichert",
      "Retired": 251,
      "Rank": 993,
      "ActiveInterests": 714,
      "ContactDepartment": "",
      "ContactCountryId": 252,
      "ContactOrgNr": "1383840",
      "FaxPhone": "1-043-226-7833 x76370",
      "MobilePhone": "885-932-4741",
      "ContactPhone": "159.168.7687 x584",
      "AssociateName": "Torphy LLC",
      "AssociateId": 660,
      "UsePersonAddress": false,
      "ContactFax": "doloremque",
      "Kanafname": "pariatur",
      "Kanalname": "quisquam",
      "Post1": "est",
      "Post2": "delectus",
      "Post3": "neque",
      "EmailName": "santina.brown@leffler.co.uk",
      "ContactFullName": "Jeremy Farrell",
      "ActiveErpLinks": 826,
      "TicketPriorityId": 577,
      "SupportLanguageId": 261,
      "SupportAssociateId": 710,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 571
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 772,
  "GroupId": 653,
  "ActiveStatusMonitorId": 880,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 34,
  "DbiAgentId": 355,
  "DbiLastSyncronized": "2010-05-28T11:10:52.6821752+02:00",
  "DbiKey": "esse",
  "DbiLastModified": "2001-03-06T11:10:52.6821752+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 492,
  "ActiveErpLinks": 969,
  "BounceEmails": [
    "nia_roob@ernser.biz",
    "yesenia@homenick.co.uk"
  ],
  "Domains": [
    "eveniet",
    "autem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Icie Krajcik",
    "SuperOffice:2": "Kaley Lang"
  },
  "ExtraFields": {
    "ExtraFields1": "porro",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "molestiae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 307
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
