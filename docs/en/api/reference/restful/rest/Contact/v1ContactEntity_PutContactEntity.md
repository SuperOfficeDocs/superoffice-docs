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
  "ContactId": 208,
  "Name": "Raynor-King",
  "Department": "",
  "OrgNr": "79845",
  "Number1": "1052472",
  "Number2": "283336",
  "UpdatedDate": "2000-09-09T11:16:13.7925618+02:00",
  "CreatedDate": "2015-12-21T11:16:13.7925618+01:00",
  "Emails": [
    {
      "Value": "asperiores",
      "StrippedValue": "non",
      "Description": "Customer-focused dynamic knowledge user"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "non",
      "Description": "Customer-focused dynamic knowledge user"
    }
  ],
  "Interests": [
    {
      "Id": 333,
      "Name": "Hudson-Kulas",
      "ToolTip": "Aut est.",
      "Deleted": false,
      "Rank": 507,
      "Type": "ducimus",
      "ColorBlock": 149,
      "IconHint": "quisquam",
      "Selected": false,
      "LastChanged": "2012-03-02T11:16:13.7925618+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quam",
      "StyleHint": "quae",
      "Hidden": false,
      "FullName": "Carolanne Thiel"
    }
  ],
  "Urls": [
    {
      "Value": "adipisci",
      "StrippedValue": "non",
      "Description": "Realigned impactful forecast"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "non",
      "Description": "Realigned impactful forecast"
    }
  ],
  "Phones": [
    {
      "Value": "culpa",
      "StrippedValue": "accusantium",
      "Description": "Organic upward-trending toolset"
    },
    {
      "Value": "culpa",
      "StrippedValue": "accusantium",
      "Description": "Organic upward-trending toolset"
    }
  ],
  "Faxes": [
    {
      "Value": "ipsam",
      "StrippedValue": "voluptatem",
      "Description": "Ameliorated homogeneous alliance"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "voluptatem",
      "Description": "Ameliorated homogeneous alliance"
    }
  ],
  "Description": "Organic context-sensitive interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 657,
      "Mrmrs": "similique",
      "Firstname": "Claudie",
      "Lastname": "Ziemann",
      "MiddleName": "Rau Group",
      "Title": "hic",
      "Description": "Future-proofed user-facing budgetary management",
      "Email": "jazmin@okeefekeebler.us",
      "FullName": "Sammie McGlynn",
      "DirectPhone": "036-168-8681",
      "FormalName": "Christiansen, Crist and Crooks",
      "CountryId": 873,
      "ContactId": 521,
      "ContactName": "Barton-Bins",
      "Retired": 53,
      "Rank": 193,
      "ActiveInterests": 323,
      "ContactDepartment": "",
      "ContactCountryId": 69,
      "ContactOrgNr": "747661",
      "FaxPhone": "(609)421-7506 x00464",
      "MobilePhone": "003.711.9609 x3847",
      "ContactPhone": "1-394-523-7604 x1440",
      "AssociateName": "Dooley Group",
      "AssociateId": 714,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "qui",
      "Kanalname": "corporis",
      "Post1": "neque",
      "Post2": "repellendus",
      "Post3": "eligendi",
      "EmailName": "wilbert_rath@ziemeritchie.biz",
      "ContactFullName": "Ivory Ziemann",
      "ActiveErpLinks": 723,
      "TicketPriorityId": 439,
      "SupportLanguageId": 626,
      "SupportAssociateId": 918,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "soluta",
  "Xstop": false,
  "ActiveInterests": 781,
  "GroupId": 547,
  "ActiveStatusMonitorId": 756,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 838,
  "DbiAgentId": 668,
  "DbiLastSyncronized": "2001-01-13T11:16:13.8082242+01:00",
  "DbiKey": "eaque",
  "DbiLastModified": "2013-11-07T11:16:13.8082242+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 792,
  "ActiveErpLinks": 367,
  "BounceEmails": [
    "kobe.cummings@okunevakilback.ca",
    "veda_mohr@braun.com"
  ],
  "Domains": [
    "voluptatum",
    "dolore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 73,
  "Name": "Lehner-King",
  "Department": "",
  "OrgNr": "682649",
  "Number1": "941869",
  "Number2": "1441387",
  "UpdatedDate": "2022-09-21T11:16:13.8082242+02:00",
  "CreatedDate": "2020-10-06T11:16:13.8082242+02:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "velit",
      "Description": "Assimilated full-range encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "velit",
      "Description": "Assimilated full-range encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 732,
      "Name": "Heaney, Hessel and Bergstrom",
      "ToolTip": "Provident temporibus.",
      "Deleted": true,
      "Rank": 711,
      "Type": "et",
      "ColorBlock": 5,
      "IconHint": "eligendi",
      "Selected": false,
      "LastChanged": "2002-07-13T11:16:13.8082242+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "architecto",
      "Hidden": false,
      "FullName": "Reta Stamm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 167
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ex",
      "StrippedValue": "iste",
      "Description": "Future-proofed national portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "iste",
      "Description": "Future-proofed national portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "architecto",
      "StrippedValue": "ipsam",
      "Description": "Streamlined zero defect hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 948
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "ipsam",
      "Description": "Streamlined zero defect hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 948
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fuga",
      "StrippedValue": "minima",
      "Description": "Re-engineered full-range product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "minima",
      "Description": "Re-engineered full-range product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "Description": "Extended coherent array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsa",
      "PersonId": 379,
      "Mrmrs": "fugit",
      "Firstname": "Gayle",
      "Lastname": "Ward",
      "MiddleName": "Smith, Murphy and Eichmann",
      "Title": "porro",
      "Description": "Team-oriented encompassing approach",
      "Email": "lesley@reinger.ca",
      "FullName": "Miss Misael Kaylie Thompson",
      "DirectPhone": "798.965.3917",
      "FormalName": "Brekke, Weber and Schumm",
      "CountryId": 869,
      "ContactId": 62,
      "ContactName": "Gibson Group",
      "Retired": 721,
      "Rank": 206,
      "ActiveInterests": 152,
      "ContactDepartment": "",
      "ContactCountryId": 249,
      "ContactOrgNr": "1265789",
      "FaxPhone": "610-140-5284 x7267",
      "MobilePhone": "(533)552-3974 x771",
      "ContactPhone": "675-662-0219",
      "AssociateName": "Sauer LLC",
      "AssociateId": 90,
      "UsePersonAddress": true,
      "ContactFax": "quo",
      "Kanafname": "illum",
      "Kanalname": "recusandae",
      "Post1": "pariatur",
      "Post2": "reiciendis",
      "Post3": "possimus",
      "EmailName": "jarrell.wunsch@parker.ca",
      "ContactFullName": "Jaclyn Bode",
      "ActiveErpLinks": 460,
      "TicketPriorityId": 807,
      "SupportLanguageId": 499,
      "SupportAssociateId": 640,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 111
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "libero",
  "Xstop": false,
  "ActiveInterests": 490,
  "GroupId": 174,
  "ActiveStatusMonitorId": 794,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 404,
  "DbiAgentId": 437,
  "DbiLastSyncronized": "2009-04-18T11:16:13.8082242+02:00",
  "DbiKey": "velit",
  "DbiLastModified": "2013-07-12T11:16:13.8082242+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 82,
  "ActiveErpLinks": 156,
  "BounceEmails": [
    "kayli@doyledicki.info",
    "ernesto.sporer@harber.co.uk"
  ],
  "Domains": [
    "officiis",
    "ullam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "535721142",
    "SuperOffice:2": "1840896163"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "molestiae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 892
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```