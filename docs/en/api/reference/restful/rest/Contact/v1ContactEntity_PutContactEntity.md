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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 341,
  "Name": "Sipes Inc and Sons",
  "Department": "",
  "OrgNr": "1439488",
  "Number1": "827676",
  "Number2": "1245782",
  "UpdatedDate": "2020-06-21T13:13:31.5270328+02:00",
  "CreatedDate": "2005-01-02T13:13:31.5270328+01:00",
  "Emails": [
    {
      "Value": "excepturi",
      "StrippedValue": "error",
      "Description": "Decentralized 24 hour system engine"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "error",
      "Description": "Decentralized 24 hour system engine"
    }
  ],
  "Interests": [
    {
      "Id": 99,
      "Name": "Parisian-Kiehn",
      "ToolTip": "Aut aperiam commodi minima doloremque impedit libero.",
      "Deleted": false,
      "Rank": 696,
      "Type": "et",
      "ColorBlock": 264,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "1999-11-28T13:13:31.5270328+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Noel Little"
    }
  ],
  "Urls": [
    {
      "Value": "ipsam",
      "StrippedValue": "inventore",
      "Description": "Persistent directional time-frame"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "inventore",
      "Description": "Persistent directional time-frame"
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "aut",
      "Description": "Networked bottom-line attitude"
    },
    {
      "Value": "molestias",
      "StrippedValue": "aut",
      "Description": "Networked bottom-line attitude"
    }
  ],
  "Faxes": [
    {
      "Value": "culpa",
      "StrippedValue": "qui",
      "Description": "Multi-lateral intermediate knowledge user"
    },
    {
      "Value": "culpa",
      "StrippedValue": "qui",
      "Description": "Multi-lateral intermediate knowledge user"
    }
  ],
  "Description": "Persistent radical help-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 937,
      "Mrmrs": "exercitationem",
      "Firstname": "Beverly",
      "Lastname": "Nader",
      "MiddleName": "Bailey, Friesen and Roberts",
      "Title": "perspiciatis",
      "Description": "Customizable attitude-oriented contingency",
      "Email": "craig@kemmer.us",
      "FullName": "Prof. Derick Nikki DuBuque DDS",
      "DirectPhone": "1-120-570-2670 x14365",
      "FormalName": "Stiedemann, Ward and D'Amore",
      "CountryId": 418,
      "ContactId": 674,
      "ContactName": "Anderson, Watsica and Hahn",
      "Retired": 237,
      "Rank": 779,
      "ActiveInterests": 620,
      "ContactDepartment": "synergize proactive systems",
      "ContactCountryId": 728,
      "ContactOrgNr": "854418",
      "FaxPhone": "403.184.8048 x76840",
      "MobilePhone": "771-736-0901 x66809",
      "ContactPhone": "(566)121-9187",
      "AssociateName": "Reichel-Marquardt",
      "AssociateId": 579,
      "UsePersonAddress": true,
      "ContactFax": "excepturi",
      "Kanafname": "aliquam",
      "Kanalname": "consequuntur",
      "Post1": "ipsum",
      "Post2": "qui",
      "Post3": "ea",
      "EmailName": "conrad.orn@rodriguez.info",
      "ContactFullName": "Augustus Willms Sr.",
      "ActiveErpLinks": 921,
      "TicketPriorityId": 876,
      "SupportLanguageId": 828,
      "SupportAssociateId": 158,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ratione",
  "Xstop": false,
  "ActiveInterests": 94,
  "GroupId": 879,
  "ActiveStatusMonitorId": 14,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 863,
  "DbiAgentId": 625,
  "DbiLastSyncronized": "2018-11-23T13:13:31.5270328+01:00",
  "DbiKey": "error",
  "DbiLastModified": "2024-11-17T13:13:31.5270328+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 759,
  "ActiveErpLinks": 298,
  "BounceEmails": [
    "clarissa@bailey.com",
    "hermina_stroman@lynchjacobs.biz"
  ],
  "Domains": [
    "non",
    "optio"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Martin Hyatt II",
    "SuperOffice:2": "Daisha Hahn"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "maiores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 366,
  "Name": "Rosenbaum Inc and Sons",
  "Department": "",
  "OrgNr": "1472394",
  "Number1": "1431055",
  "Number2": "1276085",
  "UpdatedDate": "2011-07-02T13:13:31.5426546+02:00",
  "CreatedDate": "2002-03-13T13:13:31.5426546+01:00",
  "Emails": [
    {
      "Value": "mollitia",
      "StrippedValue": "voluptatem",
      "Description": "Advanced 24 hour function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "voluptatem",
      "Description": "Advanced 24 hour function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 752,
      "Name": "Smith, Stoltenberg and VonRueden",
      "ToolTip": "Quo qui beatae qui dolores consequatur.",
      "Deleted": true,
      "Rank": 783,
      "Type": "maiores",
      "ColorBlock": 715,
      "IconHint": "doloribus",
      "Selected": false,
      "LastChanged": "2009-12-20T13:13:31.5426546+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ex",
      "StyleHint": "quo",
      "Hidden": true,
      "FullName": "Ms. Cristina Kub Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "quo",
      "Description": "Centralized 6th generation benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "quo",
      "Description": "Centralized 6th generation benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "voluptatum",
      "Description": "Team-oriented leading edge secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "voluptatum",
      "Description": "Team-oriented leading edge secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "a",
      "StrippedValue": "vel",
      "Description": "Right-sized dedicated productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 485
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "vel",
      "Description": "Right-sized dedicated productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 485
        }
      }
    }
  ],
  "Description": "Monitored well-modulated concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellat",
      "PersonId": 957,
      "Mrmrs": "saepe",
      "Firstname": "Dayton",
      "Lastname": "Schmidt",
      "MiddleName": "Borer-Luettgen",
      "Title": "id",
      "Description": "Horizontal zero tolerance implementation",
      "Email": "rhianna_medhurst@gibson.info",
      "FullName": "Arianna Kailey Kirlin I",
      "DirectPhone": "190.023.3988 x693",
      "FormalName": "Ernser LLC",
      "CountryId": 598,
      "ContactId": 669,
      "ContactName": "Kub, Schumm and Franecki",
      "Retired": 976,
      "Rank": 770,
      "ActiveInterests": 848,
      "ContactDepartment": "",
      "ContactCountryId": 598,
      "ContactOrgNr": "975126",
      "FaxPhone": "313.983.0540 x0940",
      "MobilePhone": "946-904-2022",
      "ContactPhone": "1-067-413-1226",
      "AssociateName": "Klein Group",
      "AssociateId": 719,
      "UsePersonAddress": true,
      "ContactFax": "iure",
      "Kanafname": "illo",
      "Kanalname": "pariatur",
      "Post1": "est",
      "Post2": "accusantium",
      "Post3": "sunt",
      "EmailName": "mariane_wehner@kohlerreichel.com",
      "ContactFullName": "Ms. Andreanne Larue Hermiston",
      "ActiveErpLinks": 902,
      "TicketPriorityId": 321,
      "SupportLanguageId": 114,
      "SupportAssociateId": 595,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "impedit",
  "Xstop": true,
  "ActiveInterests": 158,
  "GroupId": 961,
  "ActiveStatusMonitorId": 838,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 566,
  "DbiAgentId": 52,
  "DbiLastSyncronized": "2022-11-21T13:13:31.5426546+01:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2016-08-04T13:13:31.5426546+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 320,
  "ActiveErpLinks": 606,
  "BounceEmails": [
    "shaina_jones@morissette.uk",
    "travon@farrell.name"
  ],
  "Domains": [
    "quas",
    "soluta"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1584447172"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "culpa"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 494
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```