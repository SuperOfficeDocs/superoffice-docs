---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 588,
  "Name": "Satterfield, Schowalter and Torphy",
  "Department": "",
  "OrgNr": "640618",
  "Number1": "1329934",
  "Number2": "1586866",
  "UpdatedDate": "2013-08-24T13:13:59.735066+02:00",
  "CreatedDate": "2015-10-26T13:13:59.735066+01:00",
  "Emails": [
    {
      "Value": "tempore",
      "StrippedValue": "neque",
      "Description": "Polarised directional paradigm"
    },
    {
      "Value": "tempore",
      "StrippedValue": "neque",
      "Description": "Polarised directional paradigm"
    }
  ],
  "Interests": [
    {
      "Id": 810,
      "Name": "Toy, Price and Jacobi",
      "ToolTip": "Quae eligendi.",
      "Deleted": true,
      "Rank": 410,
      "Type": "ut",
      "ColorBlock": 308,
      "IconHint": "quas",
      "Selected": false,
      "LastChanged": "2003-04-15T13:13:59.735066+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quibusdam",
      "StyleHint": "harum",
      "Hidden": true,
      "FullName": "Lelah Weber"
    }
  ],
  "Urls": [
    {
      "Value": "dignissimos",
      "StrippedValue": "ipsam",
      "Description": "Sharable bandwidth-monitored interface"
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "ipsam",
      "Description": "Sharable bandwidth-monitored interface"
    }
  ],
  "Phones": [
    {
      "Value": "enim",
      "StrippedValue": "repellat",
      "Description": "Horizontal fault-tolerant ability"
    },
    {
      "Value": "enim",
      "StrippedValue": "repellat",
      "Description": "Horizontal fault-tolerant ability"
    }
  ],
  "Faxes": [
    {
      "Value": "commodi",
      "StrippedValue": "aut",
      "Description": "Reverse-engineered clear-thinking portal"
    },
    {
      "Value": "commodi",
      "StrippedValue": "aut",
      "Description": "Reverse-engineered clear-thinking portal"
    }
  ],
  "Description": "Distributed zero administration attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quam",
      "PersonId": 246,
      "Mrmrs": "voluptatem",
      "Firstname": "Edwina",
      "Lastname": "Toy",
      "MiddleName": "Bahringer, Zulauf and Hoeger",
      "Title": "sunt",
      "Description": "Optional zero tolerance middleware",
      "Email": "manuela.wolff@hills.co.uk",
      "FullName": "Kaleb Schmidt",
      "DirectPhone": "127-880-5490 x580",
      "FormalName": "Lemke-Sanford",
      "CountryId": 415,
      "ContactId": 982,
      "ContactName": "Altenwerth, Johns and Pfeffer",
      "Retired": 256,
      "Rank": 709,
      "ActiveInterests": 934,
      "ContactDepartment": "",
      "ContactCountryId": 102,
      "ContactOrgNr": "819893",
      "FaxPhone": "373-129-5515",
      "MobilePhone": "069.336.4790",
      "ContactPhone": "773-424-4139 x115",
      "AssociateName": "Russel, Crona and Hegmann",
      "AssociateId": 966,
      "UsePersonAddress": true,
      "ContactFax": "saepe",
      "Kanafname": "recusandae",
      "Kanalname": "quia",
      "Post1": "sint",
      "Post2": "saepe",
      "Post3": "corrupti",
      "EmailName": "georgette_adams@raynorcartwright.com",
      "ContactFullName": "Pearl Howell",
      "ActiveErpLinks": 144,
      "TicketPriorityId": 386,
      "SupportLanguageId": 110,
      "SupportAssociateId": 81,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1123936"
    }
  ],
  "NoMailing": false,
  "Kananame": "velit",
  "Xstop": false,
  "ActiveInterests": 382,
  "GroupId": 253,
  "ActiveStatusMonitorId": 750,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 61,
  "DbiAgentId": 759,
  "DbiLastSyncronized": "2022-09-25T13:13:59.735066+02:00",
  "DbiKey": "ullam",
  "DbiLastModified": "2023-02-01T13:13:59.735066+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 914,
  "ActiveErpLinks": 680,
  "BounceEmails": [
    "lamar@mullerstoltenberg.co.uk",
    "alexa_cormier@smith.co.uk"
  ],
  "Domains": [
    "sint",
    "at"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Idella Mann"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "delectus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 557,
  "Name": "Ondricka Inc and Sons",
  "Department": "",
  "OrgNr": "1506888",
  "Number1": "1445679",
  "Number2": "1385595",
  "UpdatedDate": "2024-09-01T13:13:59.735066+02:00",
  "CreatedDate": "2013-04-23T13:13:59.735066+02:00",
  "Emails": [
    {
      "Value": "enim",
      "StrippedValue": "minima",
      "Description": "Synergized client-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 438
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "minima",
      "Description": "Synergized client-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 438
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 706,
      "Name": "Stanton, Considine and Witting",
      "ToolTip": "Dolorem omnis alias.",
      "Deleted": false,
      "Rank": 454,
      "Type": "magni",
      "ColorBlock": 163,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2007-10-04T13:13:59.735066+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "doloremque",
      "Hidden": false,
      "FullName": "Alfred Kuhn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "atque",
      "StrippedValue": "quod",
      "Description": "Customer-focused executive service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "quod",
      "Description": "Customer-focused executive service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "unde",
      "StrippedValue": "laboriosam",
      "Description": "Optimized next generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "laboriosam",
      "Description": "Optimized next generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corrupti",
      "StrippedValue": "alias",
      "Description": "Phased executive interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "alias",
      "Description": "Phased executive interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    }
  ],
  "Description": "Focused assymetric implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 157,
      "Mrmrs": "libero",
      "Firstname": "Gregory",
      "Lastname": "Langworth",
      "MiddleName": "Gerlach, Friesen and Reichert",
      "Title": "labore",
      "Description": "Total didactic conglomeration",
      "Email": "joel.bednar@hoeger.info",
      "FullName": "Grace Nicolas",
      "DirectPhone": "1-315-137-4455 x153",
      "FormalName": "Zieme-Fisher",
      "CountryId": 315,
      "ContactId": 332,
      "ContactName": "Waelchi-Bechtelar",
      "Retired": 710,
      "Rank": 208,
      "ActiveInterests": 346,
      "ContactDepartment": "",
      "ContactCountryId": 651,
      "ContactOrgNr": "1729781",
      "FaxPhone": "715-846-0276",
      "MobilePhone": "454-363-6654",
      "ContactPhone": "314.621.1323",
      "AssociateName": "Nienow-Gerhold",
      "AssociateId": 880,
      "UsePersonAddress": true,
      "ContactFax": "nihil",
      "Kanafname": "rem",
      "Kanalname": "harum",
      "Post1": "ut",
      "Post2": "amet",
      "Post3": "repellat",
      "EmailName": "louie@hackett.co.uk",
      "ContactFullName": "Mckenna Parisian",
      "ActiveErpLinks": 533,
      "TicketPriorityId": 930,
      "SupportLanguageId": 149,
      "SupportAssociateId": 217,
      "CategoryName": "VIP Customer",
      "PersonNumber": "590653",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptates",
  "Xstop": true,
  "ActiveInterests": 607,
  "GroupId": 803,
  "ActiveStatusMonitorId": 882,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 564,
  "DbiAgentId": 429,
  "DbiLastSyncronized": "2013-12-10T13:13:59.750692+01:00",
  "DbiKey": "quidem",
  "DbiLastModified": "2022-03-27T13:13:59.750692+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 985,
  "ActiveErpLinks": 483,
  "BounceEmails": [
    "mariam.heidenreich@friesen.ca",
    "ewald.mertz@hermistonleuschke.uk"
  ],
  "Domains": [
    "aperiam",
    "corrupti"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1600105920",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 546
    }
  }
}
```