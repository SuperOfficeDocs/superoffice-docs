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
  "ContactId": 458,
  "Name": "Haag Group",
  "Department": "",
  "OrgNr": "949926",
  "Number1": "440304",
  "Number2": "1758779",
  "UpdatedDate": "2013-05-31T11:44:41.7890717+02:00",
  "CreatedDate": "2017-03-23T11:44:41.7890717+01:00",
  "Emails": [
    {
      "Value": "consectetur",
      "StrippedValue": "nam",
      "Description": "Cross-group mobile pricing structure"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "nam",
      "Description": "Cross-group mobile pricing structure"
    }
  ],
  "Interests": [
    {
      "Id": 492,
      "Name": "Wuckert, Russel and Koch",
      "ToolTip": "Rem velit aperiam quia qui.",
      "Deleted": true,
      "Rank": 755,
      "Type": "est",
      "ColorBlock": 320,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2008-07-22T11:44:41.7890717+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "rerum",
      "Hidden": false,
      "FullName": "Jayden Koch"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "unde",
      "Description": "Switchable bottom-line local area network"
    },
    {
      "Value": "ut",
      "StrippedValue": "unde",
      "Description": "Switchable bottom-line local area network"
    }
  ],
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Object-based systemic Graphic Interface"
    },
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Object-based systemic Graphic Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "delectus",
      "StrippedValue": "nemo",
      "Description": "Managed fault-tolerant encoding"
    },
    {
      "Value": "delectus",
      "StrippedValue": "nemo",
      "Description": "Managed fault-tolerant encoding"
    }
  ],
  "Description": "Innovative reciprocal service-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sequi",
      "PersonId": 279,
      "Mrmrs": "itaque",
      "Firstname": "Cristian",
      "Lastname": "Gerhold",
      "MiddleName": "Christiansen, Veum and Kilback",
      "Title": "molestiae",
      "Description": "Robust full-range challenge",
      "Email": "delta_hermann@fadel.ca",
      "FullName": "Camilla Renner Jr.",
      "DirectPhone": "(564)138-9981 x823",
      "FormalName": "Bechtelar, Schinner and Waters",
      "CountryId": 482,
      "ContactId": 157,
      "ContactName": "Sanford Inc and Sons",
      "Retired": 719,
      "Rank": 381,
      "ActiveInterests": 142,
      "ContactDepartment": "",
      "ContactCountryId": 61,
      "ContactOrgNr": "380765",
      "FaxPhone": "992-639-5627 x56580",
      "MobilePhone": "090.794.8368 x173",
      "ContactPhone": "081.679.2004 x87152",
      "AssociateName": "Quitzon-Torp",
      "AssociateId": 463,
      "UsePersonAddress": true,
      "ContactFax": "commodi",
      "Kanafname": "maxime",
      "Kanalname": "porro",
      "Post1": "aliquam",
      "Post2": "rerum",
      "Post3": "autem",
      "EmailName": "frida@schoen.biz",
      "ContactFullName": "Lavina Blanda",
      "ActiveErpLinks": 400,
      "TicketPriorityId": 302,
      "SupportLanguageId": 888,
      "SupportAssociateId": 211,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "tenetur",
  "Xstop": false,
  "ActiveInterests": 811,
  "GroupId": 438,
  "ActiveStatusMonitorId": 949,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 494,
  "DbiAgentId": 146,
  "DbiLastSyncronized": "2011-12-28T11:44:41.7890717+01:00",
  "DbiKey": "commodi",
  "DbiLastModified": "2020-10-21T11:44:41.7890717+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 556,
  "ActiveErpLinks": 759,
  "BounceEmails": [
    "katelyn@hayes.us",
    "eileen@fay.info"
  ],
  "Domains": [
    "omnis",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Ebba Bernier Sr.",
    "SuperOffice:2": "Maximillia Rolfson"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "iusto"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "rem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 921,
  "Name": "Little, O'Kon and Schmeler",
  "Department": "",
  "OrgNr": "480768",
  "Number1": "1454295",
  "Number2": "643468",
  "UpdatedDate": "1997-01-29T11:44:41.8046899+01:00",
  "CreatedDate": "2013-07-13T11:44:41.8046899+02:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "dolore",
      "Description": "Seamless non-volatile productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "dolore",
      "Description": "Seamless non-volatile productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 950,
      "Name": "Rippin-Feil",
      "ToolTip": "Quis quia consequatur quis nobis.",
      "Deleted": false,
      "Rank": 863,
      "Type": "rem",
      "ColorBlock": 848,
      "IconHint": "harum",
      "Selected": false,
      "LastChanged": "2000-07-18T11:44:41.8046899+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corrupti",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Era Steuber",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quasi",
      "StrippedValue": "minima",
      "Description": "Universal interactive capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "minima",
      "Description": "Universal interactive capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "maxime",
      "Description": "Customer-focused systematic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "maxime",
      "Description": "Customer-focused systematic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "beatae",
      "Description": "Horizontal executive standardization",
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
      "Value": "ut",
      "StrippedValue": "beatae",
      "Description": "Horizontal executive standardization",
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
  "Description": "Customer-focused system-worthy software",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "maiores",
      "PersonId": 784,
      "Mrmrs": "et",
      "Firstname": "Sonia",
      "Lastname": "Kertzmann",
      "MiddleName": "Roberts-Gleason",
      "Title": "deleniti",
      "Description": "Stand-alone object-oriented contingency",
      "Email": "shana_romaguera@lebsackondricka.co.uk",
      "FullName": "Gerald Auer",
      "DirectPhone": "195-137-1380",
      "FormalName": "Hyatt-Walsh",
      "CountryId": 656,
      "ContactId": 927,
      "ContactName": "Gleason LLC",
      "Retired": 23,
      "Rank": 626,
      "ActiveInterests": 944,
      "ContactDepartment": "",
      "ContactCountryId": 985,
      "ContactOrgNr": "755168",
      "FaxPhone": "187-403-0955 x1715",
      "MobilePhone": "1-332-021-4740 x2876",
      "ContactPhone": "(229)454-7448 x4298",
      "AssociateName": "Sauer Inc and Sons",
      "AssociateId": 29,
      "UsePersonAddress": true,
      "ContactFax": "magni",
      "Kanafname": "voluptatem",
      "Kanalname": "id",
      "Post1": "suscipit",
      "Post2": "sunt",
      "Post3": "voluptatum",
      "EmailName": "claire@schumm.uk",
      "ContactFullName": "Dave Cummings IV",
      "ActiveErpLinks": 433,
      "TicketPriorityId": 310,
      "SupportLanguageId": 960,
      "SupportAssociateId": 758,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 554
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 931,
  "GroupId": 429,
  "ActiveStatusMonitorId": 631,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 91,
  "DbiAgentId": 707,
  "DbiLastSyncronized": "2015-01-06T11:44:41.8046899+01:00",
  "DbiKey": "dolorum",
  "DbiLastModified": "1998-11-01T11:44:41.8046899+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 25,
  "ActiveErpLinks": 790,
  "BounceEmails": [
    "cooper@windler.biz",
    "warren@rath.com"
  ],
  "Domains": [
    "iste",
    "eveniet"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Augusta Crona",
    "SuperOffice:2": "Ms. Armand Roob DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "eum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 222
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```