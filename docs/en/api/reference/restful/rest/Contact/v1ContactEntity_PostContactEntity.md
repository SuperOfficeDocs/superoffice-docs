---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity 

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
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 115,
  "Name": "Mraz Inc and Sons",
  "Department": "",
  "OrgNr": "1617686",
  "Number1": "774177",
  "Number2": "1185732",
  "UpdatedDate": "2016-05-28T17:54:08.0699594+02:00",
  "CreatedDate": "2022-02-18T17:54:08.0699594+01:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "quis",
      "Description": "Automated multi-tasking hardware"
    },
    {
      "Value": "aut",
      "StrippedValue": "quis",
      "Description": "Automated multi-tasking hardware"
    }
  ],
  "Interests": [
    {
      "Id": 543,
      "Name": "Kovacek-Rosenbaum",
      "ToolTip": "Excepturi deleniti aut ratione vero voluptas.",
      "Deleted": true,
      "Rank": 809,
      "Type": "dolores",
      "ColorBlock": 397,
      "IconHint": "nam",
      "Selected": true,
      "LastChanged": "2018-06-05T17:54:08.0699594+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "totam",
      "Hidden": false,
      "FullName": "Hanna Macejkovic"
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "tenetur",
      "Description": "Organic didactic orchestration"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "tenetur",
      "Description": "Organic didactic orchestration"
    }
  ],
  "Phones": [
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Team-oriented bandwidth-monitored firmware"
    },
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Team-oriented bandwidth-monitored firmware"
    }
  ],
  "Faxes": [
    {
      "Value": "quasi",
      "StrippedValue": "dignissimos",
      "Description": "Grass-roots grid-enabled infrastructure"
    },
    {
      "Value": "quasi",
      "StrippedValue": "dignissimos",
      "Description": "Grass-roots grid-enabled infrastructure"
    }
  ],
  "Description": "Intuitive user-facing project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 743,
      "Mrmrs": "quam",
      "Firstname": "Jazmin",
      "Lastname": "Brekke",
      "MiddleName": "Gaylord Inc and Sons",
      "Title": "ut",
      "Description": "Persevering reciprocal focus group",
      "Email": "glenda.pouros@boyleolson.us",
      "FullName": "Dr. Philip Angela Hoeger II",
      "DirectPhone": "577-822-9606 x74285",
      "FormalName": "Crooks LLC",
      "CountryId": 831,
      "ContactId": 629,
      "ContactName": "Abbott, Brakus and Hartmann",
      "Retired": 199,
      "Rank": 337,
      "ActiveInterests": 576,
      "ContactDepartment": "",
      "ContactCountryId": 297,
      "ContactOrgNr": "1000444",
      "FaxPhone": "073.543.2410 x77235",
      "MobilePhone": "(912)609-9789 x16798",
      "ContactPhone": "980.114.9879",
      "AssociateName": "Waters-Klocko",
      "AssociateId": 975,
      "UsePersonAddress": false,
      "ContactFax": "nobis",
      "Kanafname": "aut",
      "Kanalname": "eligendi",
      "Post1": "earum",
      "Post2": "in",
      "Post3": "aliquid",
      "EmailName": "madisyn_wunsch@stammdaniel.com",
      "ContactFullName": "Naomi Aufderhar",
      "ActiveErpLinks": 143,
      "TicketPriorityId": 389,
      "SupportLanguageId": 463,
      "SupportAssociateId": 522,
      "CategoryName": "VIP Customer",
      "PersonNumber": "579842"
    }
  ],
  "NoMailing": false,
  "Kananame": "velit",
  "Xstop": false,
  "ActiveInterests": 894,
  "GroupId": 714,
  "ActiveStatusMonitorId": 630,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 378,
  "DbiAgentId": 650,
  "DbiLastSyncronized": "1998-03-28T17:54:08.0855828+01:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "1999-06-20T17:54:08.0855828+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 575,
  "ActiveErpLinks": 634,
  "BounceEmails": [
    "noble.kessler@monahanschoen.com",
    "abe@weber.info"
  ],
  "Domains": [
    "optio",
    "assumenda"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Alison Klein"
  },
  "ExtraFields": {
    "ExtraFields1": "error",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "nobis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 48,
  "Name": "Jones LLC",
  "Department": "",
  "OrgNr": "1824355",
  "Number1": "979930",
  "Number2": "395026",
  "UpdatedDate": "1999-10-28T17:54:08.0855828+02:00",
  "CreatedDate": "2007-07-17T17:54:08.0855828+02:00",
  "Emails": [
    {
      "Value": "blanditiis",
      "StrippedValue": "deserunt",
      "Description": "Inverse local middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "deserunt",
      "Description": "Inverse local middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 812,
      "Name": "Corwin-Stroman",
      "ToolTip": "Ea necessitatibus.",
      "Deleted": false,
      "Rank": 38,
      "Type": "repellat",
      "ColorBlock": 158,
      "IconHint": "eius",
      "Selected": true,
      "LastChanged": "2019-08-06T17:54:08.0855828+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "amet",
      "StyleHint": "vero",
      "Hidden": false,
      "FullName": "Kale Walsh",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 872
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "quaerat",
      "Description": "Right-sized multimedia solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 456
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "quaerat",
      "Description": "Right-sized multimedia solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 456
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "impedit",
      "Description": "Organized global challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "impedit",
      "Description": "Organized global challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eveniet",
      "StrippedValue": "inventore",
      "Description": "Public-key object-oriented monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "inventore",
      "Description": "Public-key object-oriented monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    }
  ],
  "Description": "Configurable bi-directional database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "inventore",
      "PersonId": 938,
      "Mrmrs": "ratione",
      "Firstname": "Verda",
      "Lastname": "Koelpin",
      "MiddleName": "Bruen Inc and Sons",
      "Title": "nihil",
      "Description": "Ergonomic 6th generation instruction set",
      "Email": "jermey@zieme.co.uk",
      "FullName": "Mrs. Adelia Langosh Sr.",
      "DirectPhone": "1-281-824-6580 x93840",
      "FormalName": "Swaniawski-Torphy",
      "CountryId": 133,
      "ContactId": 407,
      "ContactName": "Von-White",
      "Retired": 792,
      "Rank": 596,
      "ActiveInterests": 61,
      "ContactDepartment": "",
      "ContactCountryId": 268,
      "ContactOrgNr": "1258835",
      "FaxPhone": "221.029.0669",
      "MobilePhone": "492.399.8299 x94855",
      "ContactPhone": "565-440-2187",
      "AssociateName": "Kunze, Kris and Berge",
      "AssociateId": 343,
      "UsePersonAddress": true,
      "ContactFax": "enim",
      "Kanafname": "consequuntur",
      "Kanalname": "eum",
      "Post1": "quidem",
      "Post2": "incidunt",
      "Post3": "sit",
      "EmailName": "adolphus.larkin@tremblay.uk",
      "ContactFullName": "Tess Kovacek",
      "ActiveErpLinks": 182,
      "TicketPriorityId": 2,
      "SupportLanguageId": 491,
      "SupportAssociateId": 678,
      "CategoryName": "VIP Customer",
      "PersonNumber": "858494",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 453
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "excepturi",
  "Xstop": false,
  "ActiveInterests": 845,
  "GroupId": 477,
  "ActiveStatusMonitorId": 460,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 526,
  "DbiAgentId": 474,
  "DbiLastSyncronized": "2016-12-31T17:54:08.0855828+01:00",
  "DbiKey": "reiciendis",
  "DbiLastModified": "2006-05-11T17:54:08.0855828+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 51,
  "ActiveErpLinks": 535,
  "BounceEmails": [
    "jacey.moen@stokes.info",
    "kirstin@schultzvon.name"
  ],
  "Domains": [
    "voluptatem",
    "beatae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Megane Hand",
    "SuperOffice:2": "Dr. Willow Kuphal"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 95
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```