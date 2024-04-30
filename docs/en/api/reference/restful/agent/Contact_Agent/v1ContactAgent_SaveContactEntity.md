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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 437,
  "Name": "Fahey-Kuhic",
  "Department": "",
  "OrgNr": "279863",
  "Number1": "1512558",
  "Number2": "974344",
  "UpdatedDate": "2004-04-26T11:44:33.0254682+02:00",
  "CreatedDate": "2020-01-20T11:44:33.0254682+01:00",
  "Emails": [
    {
      "Value": "dolorum",
      "StrippedValue": "velit",
      "Description": "Object-based logistical policy"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "velit",
      "Description": "Object-based logistical policy"
    }
  ],
  "Interests": [
    {
      "Id": 931,
      "Name": "Stracke-Lang",
      "ToolTip": "Quam laboriosam veniam nulla.",
      "Deleted": true,
      "Rank": 405,
      "Type": "libero",
      "ColorBlock": 636,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2013-02-05T11:44:33.0254682+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "magni",
      "Hidden": false,
      "FullName": "Micah Gardner Howell IV"
    }
  ],
  "Urls": [
    {
      "Value": "cum",
      "StrippedValue": "fugit",
      "Description": "Secured content-based application"
    },
    {
      "Value": "cum",
      "StrippedValue": "fugit",
      "Description": "Secured content-based application"
    }
  ],
  "Phones": [
    {
      "Value": "unde",
      "StrippedValue": "explicabo",
      "Description": "Operative full-range functionalities"
    },
    {
      "Value": "unde",
      "StrippedValue": "explicabo",
      "Description": "Operative full-range functionalities"
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "aliquid",
      "Description": "Stand-alone regional projection"
    },
    {
      "Value": "rerum",
      "StrippedValue": "aliquid",
      "Description": "Stand-alone regional projection"
    }
  ],
  "Description": "Extended human-resource conglomeration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloremque",
      "PersonId": 250,
      "Mrmrs": "porro",
      "Firstname": "Deangelo",
      "Lastname": "Maggio",
      "MiddleName": "Wehner, Hodkiewicz and Quitzon",
      "Title": "ducimus",
      "Description": "Enterprise-wide systemic access",
      "Email": "furman@mayert.co.uk",
      "FullName": "Lea Balistreri",
      "DirectPhone": "545.775.9189 x26116",
      "FormalName": "Brakus-Bogisich",
      "CountryId": 132,
      "ContactId": 160,
      "ContactName": "Koch-Streich",
      "Retired": 529,
      "Rank": 574,
      "ActiveInterests": 16,
      "ContactDepartment": "",
      "ContactCountryId": 384,
      "ContactOrgNr": "1095031",
      "FaxPhone": "021-106-3458 x6651",
      "MobilePhone": "1-488-607-1128",
      "ContactPhone": "059-501-0050",
      "AssociateName": "Hermiston, Walsh and Williamson",
      "AssociateId": 917,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "repellat",
      "Kanalname": "dolore",
      "Post1": "officiis",
      "Post2": "quo",
      "Post3": "voluptates",
      "EmailName": "meta_lang@moenullrich.co.uk",
      "ContactFullName": "Miss Garfield Kunze",
      "ActiveErpLinks": 267,
      "TicketPriorityId": 444,
      "SupportLanguageId": 755,
      "SupportAssociateId": 531,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "omnis",
  "Xstop": true,
  "ActiveInterests": 255,
  "GroupId": 192,
  "ActiveStatusMonitorId": 711,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 78,
  "DbiAgentId": 674,
  "DbiLastSyncronized": "1998-12-02T11:44:33.0254682+01:00",
  "DbiKey": "molestiae",
  "DbiLastModified": "2007-04-09T11:44:33.0254682+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 339,
  "ActiveErpLinks": 55,
  "BounceEmails": [
    "gilda.jenkins@bartoletti.uk",
    "myrl_hansen@green.info"
  ],
  "Domains": [
    "facere",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Davion Brando Sanford III",
    "SuperOffice:2": "1570228153"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "enim"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 788,
  "Name": "Gutmann-Huels",
  "Department": "",
  "OrgNr": "784914",
  "Number1": "1429203",
  "Number2": "756572",
  "UpdatedDate": "1998-02-15T11:44:33.0410903+01:00",
  "CreatedDate": "1997-09-25T11:44:33.0410903+02:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "cupiditate",
      "Description": "Object-based fresh-thinking productivity",
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
      "Value": "sit",
      "StrippedValue": "cupiditate",
      "Description": "Object-based fresh-thinking productivity",
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
  "Interests": [
    {
      "Id": 563,
      "Name": "Corwin LLC",
      "ToolTip": "Quam pariatur.",
      "Deleted": false,
      "Rank": 893,
      "Type": "velit",
      "ColorBlock": 373,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2001-01-05T11:44:33.0410903+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Laron Beier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "excepturi",
      "Description": "Monitored client-server frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 557
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "excepturi",
      "Description": "Monitored client-server frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 557
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "id",
      "StrippedValue": "cupiditate",
      "Description": "User-friendly scalable internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "cupiditate",
      "Description": "User-friendly scalable internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellat",
      "StrippedValue": "quia",
      "Description": "User-friendly contextually-based capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "quia",
      "Description": "User-friendly contextually-based capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "Description": "Balanced 3rd generation matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repudiandae",
      "PersonId": 673,
      "Mrmrs": "vitae",
      "Firstname": "Selmer",
      "Lastname": "Thiel",
      "MiddleName": "Purdy, West and Leuschke",
      "Title": "labore",
      "Description": "Balanced 5th generation firmware",
      "Email": "anastacio_ortiz@mann.us",
      "FullName": "Tamia Schroeder",
      "DirectPhone": "(204)716-5346 x2501",
      "FormalName": "Von-Raynor",
      "CountryId": 19,
      "ContactId": 561,
      "ContactName": "Langosh Inc and Sons",
      "Retired": 852,
      "Rank": 74,
      "ActiveInterests": 424,
      "ContactDepartment": "",
      "ContactCountryId": 691,
      "ContactOrgNr": "663870",
      "FaxPhone": "508.614.5204",
      "MobilePhone": "(484)101-3593 x42619",
      "ContactPhone": "1-489-441-5510 x99539",
      "AssociateName": "Walter-Hermann",
      "AssociateId": 157,
      "UsePersonAddress": true,
      "ContactFax": "eius",
      "Kanafname": "voluptatem",
      "Kanalname": "soluta",
      "Post1": "voluptates",
      "Post2": "molestias",
      "Post3": "soluta",
      "EmailName": "bette@brakusveum.ca",
      "ContactFullName": "Mrs. Willy Mueller",
      "ActiveErpLinks": 650,
      "TicketPriorityId": 868,
      "SupportLanguageId": 502,
      "SupportAssociateId": 470,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "totam",
  "Xstop": false,
  "ActiveInterests": 813,
  "GroupId": 139,
  "ActiveStatusMonitorId": 1002,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 818,
  "DbiAgentId": 898,
  "DbiLastSyncronized": "2009-09-25T11:44:33.0410903+02:00",
  "DbiKey": "earum",
  "DbiLastModified": "2006-03-27T11:44:33.0410903+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 634,
  "ActiveErpLinks": 32,
  "BounceEmails": [
    "katrine.trantow@predovic.ca",
    "gilberto@nader.info"
  ],
  "Domains": [
    "quisquam",
    "cum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2100881259",
    "SuperOffice:2": "Sydnie Osinski"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "perspiciatis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 450
    }
  }
}
```