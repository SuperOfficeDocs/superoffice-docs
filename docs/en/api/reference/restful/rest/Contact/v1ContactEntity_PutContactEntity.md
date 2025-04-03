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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 607,
  "Name": "Terry-Connelly",
  "Department": "",
  "OrgNr": "992039",
  "Number1": "928052",
  "Number2": "1637280",
  "UpdatedDate": "2024-10-29T14:28:26.8364487+01:00",
  "CreatedDate": "2006-10-13T14:28:26.8364487+02:00",
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "officia",
      "Description": "Pre-emptive 5th generation policy"
    },
    {
      "Value": "quo",
      "StrippedValue": "officia",
      "Description": "Pre-emptive 5th generation policy"
    }
  ],
  "Interests": [
    {
      "Id": 388,
      "Name": "Hackett, Roberts and Funk",
      "ToolTip": "Alias magnam provident omnis.",
      "Deleted": false,
      "Rank": 663,
      "Type": "quae",
      "ColorBlock": 408,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "2003-06-08T14:28:26.8364487+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "natus",
      "Hidden": true,
      "FullName": "Terrell Hansen"
    }
  ],
  "Urls": [
    {
      "Value": "eaque",
      "StrippedValue": "iste",
      "Description": "Reduced non-volatile conglomeration"
    },
    {
      "Value": "eaque",
      "StrippedValue": "iste",
      "Description": "Reduced non-volatile conglomeration"
    }
  ],
  "Phones": [
    {
      "Value": "sint",
      "StrippedValue": "non",
      "Description": "Object-based explicit access"
    },
    {
      "Value": "sint",
      "StrippedValue": "non",
      "Description": "Object-based explicit access"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "nisi",
      "Description": "Advanced mission-critical superstructure"
    },
    {
      "Value": "qui",
      "StrippedValue": "nisi",
      "Description": "Advanced mission-critical superstructure"
    }
  ],
  "Description": "Public-key motivating firmware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cupiditate",
      "PersonId": 550,
      "Mrmrs": "quia",
      "Firstname": "Augustus",
      "Lastname": "Effertz",
      "MiddleName": "Kunze, Howe and Considine",
      "Title": "sunt",
      "Description": "Multi-channelled context-sensitive success",
      "Email": "eladio_rosenbaum@armstrong.ca",
      "FullName": "Connor Nicola Quigley DDS",
      "DirectPhone": "543-254-5390 x202",
      "FormalName": "Jenkins, Anderson and McLaughlin",
      "CountryId": 642,
      "ContactId": 752,
      "ContactName": "Hammes-Reinger",
      "Retired": 656,
      "Rank": 519,
      "ActiveInterests": 942,
      "ContactDepartment": "",
      "ContactCountryId": 763,
      "ContactOrgNr": "163116",
      "FaxPhone": "962-998-2377 x409",
      "MobilePhone": "534.411.9422",
      "ContactPhone": "1-305-090-2037 x7883",
      "AssociateName": "Friesen LLC",
      "AssociateId": 623,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "consequatur",
      "Kanalname": "nihil",
      "Post1": "et",
      "Post2": "atque",
      "Post3": "assumenda",
      "EmailName": "benjamin@oconnergreen.biz",
      "ContactFullName": "Carole Franecki",
      "ActiveErpLinks": 580,
      "TicketPriorityId": 844,
      "SupportLanguageId": 91,
      "SupportAssociateId": 685,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1419863"
    }
  ],
  "NoMailing": false,
  "Kananame": "omnis",
  "Xstop": true,
  "ActiveInterests": 619,
  "GroupId": 925,
  "ActiveStatusMonitorId": 68,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 252,
  "DbiAgentId": 905,
  "DbiLastSyncronized": "2014-07-02T14:28:26.8364487+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2001-12-05T14:28:26.8364487+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 56,
  "ActiveErpLinks": 628,
  "BounceEmails": [
    "jazmin@okonjast.biz",
    "reyna@strackerussel.uk"
  ],
  "Domains": [
    "nam",
    "ad"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "899485381",
    "SuperOffice:2": "Ms. Adah Feest"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sapiente"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 387,
  "Name": "Predovic Inc and Sons",
  "Department": "",
  "OrgNr": "630184",
  "Number1": "313499",
  "Number2": "1003452",
  "UpdatedDate": "2005-03-14T14:28:26.8364487+01:00",
  "CreatedDate": "2024-05-27T14:28:26.8364487+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "vel",
      "Description": "Distributed human-resource matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "vel",
      "Description": "Distributed human-resource matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 419,
      "Name": "McDermott-McClure",
      "ToolTip": "Officiis cum rem perferendis numquam sint quia.",
      "Deleted": false,
      "Rank": 997,
      "Type": "enim",
      "ColorBlock": 955,
      "IconHint": "ipsam",
      "Selected": false,
      "LastChanged": "2005-09-14T14:28:26.8364487+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facere",
      "StyleHint": "pariatur",
      "Hidden": false,
      "FullName": "Brain McKenzie",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "minus",
      "StrippedValue": "id",
      "Description": "Public-key eco-centric moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "id",
      "Description": "Public-key eco-centric moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "odit",
      "StrippedValue": "omnis",
      "Description": "Enhanced bottom-line knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "omnis",
      "Description": "Enhanced bottom-line knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sequi",
      "StrippedValue": "nihil",
      "Description": "Distributed real-time ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 251
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "nihil",
      "Description": "Distributed real-time ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 251
        }
      }
    }
  ],
  "Description": "Polarised intangible neural-net",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 925,
      "Mrmrs": "rerum",
      "Firstname": "Nathan",
      "Lastname": "Heidenreich",
      "MiddleName": "Boyle-Stamm",
      "Title": "qui",
      "Description": "Quality-focused multi-state paradigm",
      "Email": "crawford.koch@leannon.uk",
      "FullName": "Jermey Miller",
      "DirectPhone": "847-236-7512 x997",
      "FormalName": "Hyatt-Hansen",
      "CountryId": 193,
      "ContactId": 314,
      "ContactName": "Koelpin, Friesen and Littel",
      "Retired": 757,
      "Rank": 816,
      "ActiveInterests": 376,
      "ContactDepartment": "",
      "ContactCountryId": 528,
      "ContactOrgNr": "945193",
      "FaxPhone": "(796)621-4786",
      "MobilePhone": "1-944-144-3954 x71869",
      "ContactPhone": "(520)225-9008",
      "AssociateName": "Jacobi, Franecki and Lebsack",
      "AssociateId": 435,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "hic",
      "Kanalname": "incidunt",
      "Post1": "libero",
      "Post2": "distinctio",
      "Post3": "et",
      "EmailName": "amara_heaney@herman.co.uk",
      "ContactFullName": "Brenna Boyle",
      "ActiveErpLinks": 351,
      "TicketPriorityId": 706,
      "SupportLanguageId": 102,
      "SupportAssociateId": 391,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1098477",
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
  "NoMailing": true,
  "Kananame": "dolores",
  "Xstop": false,
  "ActiveInterests": 546,
  "GroupId": 428,
  "ActiveStatusMonitorId": 140,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 746,
  "DbiAgentId": 993,
  "DbiLastSyncronized": "1999-12-27T14:28:26.8364487+01:00",
  "DbiKey": "unde",
  "DbiLastModified": "2014-09-10T14:28:26.8364487+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 395,
  "ActiveErpLinks": 138,
  "BounceEmails": [
    "camilla_lindgren@kreiger.name",
    "wilma@anderson.name"
  ],
  "Domains": [
    "magni",
    "iusto"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Vern McCullough",
    "SuperOffice:2": "Georgette Rowland Wiegand DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "cumque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 281
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```