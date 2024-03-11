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
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 621,
  "Name": "Abbott-Ryan",
  "Department": "",
  "OrgNr": "1013206",
  "Number1": "894658",
  "Number2": "942620",
  "UpdatedDate": "2021-01-15T14:23:54.9759039+01:00",
  "CreatedDate": "1998-01-22T14:23:54.9759039+01:00",
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "et",
      "Description": "Team-oriented clear-thinking hub"
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "et",
      "Description": "Team-oriented clear-thinking hub"
    }
  ],
  "Interests": [
    {
      "Id": 417,
      "Name": "Runolfsdottir, Rutherford and Halvorson",
      "ToolTip": "Odit illum quisquam nulla qui eius.",
      "Deleted": false,
      "Rank": 252,
      "Type": "nesciunt",
      "ColorBlock": 680,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2016-10-11T14:23:54.9759039+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "quod",
      "Hidden": false,
      "FullName": "Ms. Joey Willis Block"
    }
  ],
  "Urls": [
    {
      "Value": "porro",
      "StrippedValue": "repudiandae",
      "Description": "De-engineered assymetric knowledge user"
    },
    {
      "Value": "porro",
      "StrippedValue": "repudiandae",
      "Description": "De-engineered assymetric knowledge user"
    }
  ],
  "Phones": [
    {
      "Value": "harum",
      "StrippedValue": "modi",
      "Description": "Fundamental next generation database"
    },
    {
      "Value": "harum",
      "StrippedValue": "modi",
      "Description": "Fundamental next generation database"
    }
  ],
  "Faxes": [
    {
      "Value": "nam",
      "StrippedValue": "aut",
      "Description": "Pre-emptive optimal analyzer"
    },
    {
      "Value": "nam",
      "StrippedValue": "aut",
      "Description": "Pre-emptive optimal analyzer"
    }
  ],
  "Description": "Persevering solution-oriented instruction set",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "at",
      "PersonId": 296,
      "Mrmrs": "eaque",
      "Firstname": "Genoveva",
      "Lastname": "Strosin",
      "MiddleName": "Jakubowski, Rippin and Schmitt",
      "Title": "magnam",
      "Description": "Devolved maximized secured line",
      "Email": "jade_romaguera@raynorkuhic.info",
      "FullName": "Frankie Howe",
      "DirectPhone": "(134)402-4432",
      "FormalName": "Nienow LLC",
      "CountryId": 906,
      "ContactId": 835,
      "ContactName": "Flatley, Barrows and Thompson",
      "Retired": 792,
      "Rank": 384,
      "ActiveInterests": 256,
      "ContactDepartment": "",
      "ContactCountryId": 572,
      "ContactOrgNr": "1653277",
      "FaxPhone": "1-601-909-6490 x634",
      "MobilePhone": "1-475-310-6660 x011",
      "ContactPhone": "1-262-963-9093 x02131",
      "AssociateName": "Mosciski-Blanda",
      "AssociateId": 58,
      "UsePersonAddress": false,
      "ContactFax": "doloremque",
      "Kanafname": "repellat",
      "Kanalname": "et",
      "Post1": "ea",
      "Post2": "voluptatem",
      "Post3": "ab",
      "EmailName": "abigale.boyer@ritchie.ca",
      "ContactFullName": "Leone Norma Parker IV",
      "ActiveErpLinks": 98,
      "TicketPriorityId": 392,
      "SupportLanguageId": 838,
      "SupportAssociateId": 370,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "fugit",
  "Xstop": false,
  "ActiveInterests": 141,
  "GroupId": 56,
  "ActiveStatusMonitorId": 432,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 881,
  "DbiAgentId": 529,
  "DbiLastSyncronized": "2005-11-19T14:23:54.9759039+01:00",
  "DbiKey": "aut",
  "DbiLastModified": "2020-02-20T14:23:54.9759039+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 279,
  "ActiveErpLinks": 366,
  "BounceEmails": [
    "joelle_williamson@towne.name",
    "ayden@cassin.biz"
  ],
  "Domains": [
    "atque",
    "dolorem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Barbara Bartoletti",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 317,
  "Name": "Goodwin-Kassulke",
  "Department": "",
  "OrgNr": "1671986",
  "Number1": "1106444",
  "Number2": "781296",
  "UpdatedDate": "2010-04-30T14:23:54.9759039+02:00",
  "CreatedDate": "2006-04-05T14:23:54.9759039+02:00",
  "Emails": [
    {
      "Value": "accusantium",
      "StrippedValue": "quisquam",
      "Description": "Mandatory eco-centric focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "quisquam",
      "Description": "Mandatory eco-centric focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 973,
      "Name": "Grady, Hirthe and Murphy",
      "ToolTip": "Totam pariatur quas aut.",
      "Deleted": false,
      "Rank": 170,
      "Type": "nisi",
      "ColorBlock": 639,
      "IconHint": "quo",
      "Selected": true,
      "LastChanged": "2001-09-18T14:23:54.9759039+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eligendi",
      "StyleHint": "dolorem",
      "Hidden": true,
      "FullName": "Miss Winfield Schaefer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dicta",
      "StrippedValue": "sunt",
      "Description": "Devolved uniform core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 863
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "sunt",
      "Description": "Devolved uniform core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 863
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ex",
      "StrippedValue": "quia",
      "Description": "Devolved 24 hour forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 137
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "quia",
      "Description": "Devolved 24 hour forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 137
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "sit",
      "Description": "Pre-emptive multi-state hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 129
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "sit",
      "Description": "Pre-emptive multi-state hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 129
        }
      }
    }
  ],
  "Description": "Programmable national orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 927,
      "Mrmrs": "quisquam",
      "Firstname": "Lottie",
      "Lastname": "Larson",
      "MiddleName": "Ebert-Kiehn",
      "Title": "eos",
      "Description": "Extended bottom-line policy",
      "Email": "granville_kutch@bartell.info",
      "FullName": "Prof. Demario Brianne Stamm",
      "DirectPhone": "953.045.5448 x17869",
      "FormalName": "Torphy-McCullough",
      "CountryId": 574,
      "ContactId": 572,
      "ContactName": "Ullrich LLC",
      "Retired": 872,
      "Rank": 197,
      "ActiveInterests": 152,
      "ContactDepartment": "",
      "ContactCountryId": 999,
      "ContactOrgNr": "680800",
      "FaxPhone": "1-981-327-0051 x4213",
      "MobilePhone": "327.874.1048 x882",
      "ContactPhone": "482.712.5575",
      "AssociateName": "Purdy, Cummerata and Spencer",
      "AssociateId": 314,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "at",
      "Kanalname": "fugiat",
      "Post1": "excepturi",
      "Post2": "voluptatem",
      "Post3": "quas",
      "EmailName": "lester@beahanaufderhar.co.uk",
      "ContactFullName": "Miss Ethyl Bode",
      "ActiveErpLinks": 234,
      "TicketPriorityId": 123,
      "SupportLanguageId": 515,
      "SupportAssociateId": 583,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dicta",
  "Xstop": false,
  "ActiveInterests": 978,
  "GroupId": 958,
  "ActiveStatusMonitorId": 717,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 103,
  "DbiAgentId": 364,
  "DbiLastSyncronized": "2002-09-30T14:23:54.9915278+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2006-09-26T14:23:54.9915278+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 679,
  "ActiveErpLinks": 33,
  "BounceEmails": [
    "selmer@oharadietrich.biz",
    "abdullah_mccullough@grimeswuckert.uk"
  ],
  "Domains": [
    "nemo",
    "commodi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Dr. Gudrun Cummerata III"
  },
  "ExtraFields": {
    "ExtraFields1": "odio",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "quibusdam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 423
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```