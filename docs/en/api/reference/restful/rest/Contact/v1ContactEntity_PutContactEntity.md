---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
content_type: reference
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 623,
  "Name": "Douglas, Spinka and Nader",
  "Department": "",
  "OrgNr": "727497",
  "Number1": "803666",
  "Number2": "1180542",
  "UpdatedDate": "2018-05-17T03:46:59.8474445+02:00",
  "CreatedDate": "2015-09-14T03:46:59.8474445+02:00",
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "eos",
      "Description": "Re-contextualized bottom-line strategy"
    },
    {
      "Value": "rerum",
      "StrippedValue": "eos",
      "Description": "Re-contextualized bottom-line strategy"
    }
  ],
  "Interests": [
    {
      "Id": 284,
      "Name": "Ortiz Inc and Sons",
      "ToolTip": "Quia facere distinctio.",
      "Deleted": true,
      "Rank": 418,
      "Type": "consequatur",
      "ColorBlock": 5,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "1998-10-17T03:46:59.8474445+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "quod",
      "Hidden": false,
      "FullName": "Heath Reinger"
    }
  ],
  "Urls": [
    {
      "Value": "ipsa",
      "StrippedValue": "illo",
      "Description": "Horizontal incremental migration"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "illo",
      "Description": "Horizontal incremental migration"
    }
  ],
  "Phones": [
    {
      "Value": "nihil",
      "StrippedValue": "voluptatibus",
      "Description": "Proactive fault-tolerant strategy"
    },
    {
      "Value": "nihil",
      "StrippedValue": "voluptatibus",
      "Description": "Proactive fault-tolerant strategy"
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "saepe",
      "Description": "Right-sized value-added hierarchy"
    },
    {
      "Value": "eos",
      "StrippedValue": "saepe",
      "Description": "Right-sized value-added hierarchy"
    }
  ],
  "Description": "Fully-configurable object-oriented budgetary management",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laborum",
      "PersonId": 597,
      "Mrmrs": "quos",
      "Firstname": "Vivien",
      "Lastname": "Cremin",
      "MiddleName": "Reynolds-Sauer",
      "Title": "optio",
      "Description": "Quality-focused composite productivity",
      "Email": "emmy_franecki@feest.name",
      "FullName": "Dr. Dahlia Baumbach",
      "DirectPhone": "554.963.8497 x992",
      "FormalName": "Feil-Grant",
      "CountryId": 180,
      "ContactId": 144,
      "ContactName": "Kuhic-Kunze",
      "Retired": 238,
      "Rank": 934,
      "ActiveInterests": 835,
      "ContactDepartment": "implement sticky users",
      "ContactCountryId": 849,
      "ContactOrgNr": "1271125",
      "FaxPhone": "(763)086-4285 x96699",
      "MobilePhone": "1-089-072-9340",
      "ContactPhone": "659-172-9461",
      "AssociateName": "Denesik LLC",
      "AssociateId": 509,
      "UsePersonAddress": true,
      "ContactFax": "debitis",
      "Kanafname": "voluptatibus",
      "Kanalname": "aut",
      "Post1": "repellendus",
      "Post2": "non",
      "Post3": "quo",
      "EmailName": "hilbert_lubowitz@wolffsmith.com",
      "ContactFullName": "Coralie Leannon",
      "ActiveErpLinks": 304,
      "TicketPriorityId": 134,
      "SupportLanguageId": 14,
      "SupportAssociateId": 128,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1048334"
    }
  ],
  "NoMailing": false,
  "Kananame": "dicta",
  "Xstop": false,
  "ActiveInterests": 708,
  "GroupId": 564,
  "ActiveStatusMonitorId": 247,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 636,
  "DbiAgentId": 754,
  "DbiLastSyncronized": "1999-04-04T03:46:59.8474445+02:00",
  "DbiKey": "unde",
  "DbiLastModified": "2006-05-20T03:46:59.8474445+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 42,
  "ActiveErpLinks": 357,
  "BounceEmails": [
    "keenan_wisozk@ruecker.name",
    "laurianne@lebsack.com"
  ],
  "Domains": [
    "repellendus",
    "ut"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Della Shields"
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "laboriosam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 80,
  "Name": "Cormier, Wolf and Fadel",
  "Department": "",
  "OrgNr": "375167",
  "Number1": "1235494",
  "Number2": "263036",
  "UpdatedDate": "1998-08-14T03:46:59.8474445+02:00",
  "CreatedDate": "2001-05-30T03:46:59.8474445+02:00",
  "Emails": [
    {
      "Value": "provident",
      "StrippedValue": "minus",
      "Description": "Self-enabling object-oriented implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 963
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "minus",
      "Description": "Self-enabling object-oriented implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 963
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 763,
      "Name": "King, Daugherty and Steuber",
      "ToolTip": "Molestiae maxime ab delectus distinctio suscipit ut.",
      "Deleted": false,
      "Rank": 673,
      "Type": "blanditiis",
      "ColorBlock": 756,
      "IconHint": "ratione",
      "Selected": true,
      "LastChanged": "2023-02-26T03:46:59.8474445+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sunt",
      "StyleHint": "dicta",
      "Hidden": false,
      "FullName": "Daphne Kozey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 416
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "assumenda",
      "StrippedValue": "nihil",
      "Description": "Organized systematic flexibility",
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
      "Value": "assumenda",
      "StrippedValue": "nihil",
      "Description": "Organized systematic flexibility",
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
  "Phones": [
    {
      "Value": "odit",
      "StrippedValue": "sit",
      "Description": "Cross-platform national projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 51
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "sit",
      "Description": "Cross-platform national projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 51
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "asperiores",
      "Description": "Grass-roots motivating superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "asperiores",
      "Description": "Grass-roots motivating superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    }
  ],
  "Description": "Assimilated systemic benchmark",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "error",
      "PersonId": 140,
      "Mrmrs": "dolorem",
      "Firstname": "Hipolito",
      "Lastname": "Weimann",
      "MiddleName": "Weber-Purdy",
      "Title": "eos",
      "Description": "Future-proofed mission-critical customer loyalty",
      "Email": "patience@bergnaumhilll.biz",
      "FullName": "Aliyah Stroman",
      "DirectPhone": "(085)574-0168 x50953",
      "FormalName": "Swift-Breitenberg",
      "CountryId": 401,
      "ContactId": 640,
      "ContactName": "Abbott, Corkery and Crist",
      "Retired": 579,
      "Rank": 601,
      "ActiveInterests": 182,
      "ContactDepartment": "",
      "ContactCountryId": 36,
      "ContactOrgNr": "397971",
      "FaxPhone": "1-681-332-5615 x9299",
      "MobilePhone": "266.618.5160",
      "ContactPhone": "802.254.1305 x8289",
      "AssociateName": "Sporer-Reynolds",
      "AssociateId": 617,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "in",
      "Kanalname": "modi",
      "Post1": "nemo",
      "Post2": "quo",
      "Post3": "a",
      "EmailName": "ellen.schmeler@kirlinboyle.com",
      "ContactFullName": "Winona Halvorson",
      "ActiveErpLinks": 441,
      "TicketPriorityId": 651,
      "SupportLanguageId": 754,
      "SupportAssociateId": 789,
      "CategoryName": "VIP Customer",
      "PersonNumber": "689056",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 445
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "numquam",
  "Xstop": true,
  "ActiveInterests": 722,
  "GroupId": 215,
  "ActiveStatusMonitorId": 857,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 923,
  "DbiAgentId": 296,
  "DbiLastSyncronized": "2025-03-18T03:46:59.863068+01:00",
  "DbiKey": "aut",
  "DbiLastModified": "2003-07-09T03:46:59.863068+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 88,
  "ActiveErpLinks": 128,
  "BounceEmails": [
    "buck@feestrath.us",
    "hildegard@rolfson.ca"
  ],
  "Domains": [
    "et",
    "provident"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Merl Kshlerin III",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "quod"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 61
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```