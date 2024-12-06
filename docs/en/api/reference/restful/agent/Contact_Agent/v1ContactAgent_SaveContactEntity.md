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
  "ContactId": 502,
  "Name": "Medhurst Inc and Sons",
  "Department": "",
  "OrgNr": "557689",
  "Number1": "1246559",
  "Number2": "756420",
  "UpdatedDate": "2011-10-31T10:17:55.2383919+01:00",
  "CreatedDate": "2010-07-02T10:17:55.2383919+02:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "ut",
      "Description": "Total content-based Graphic Interface"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ut",
      "Description": "Total content-based Graphic Interface"
    }
  ],
  "Interests": [
    {
      "Id": 89,
      "Name": "Lemke Group",
      "ToolTip": "Et quod.",
      "Deleted": false,
      "Rank": 892,
      "Type": "cumque",
      "ColorBlock": 877,
      "IconHint": "ea",
      "Selected": false,
      "LastChanged": "2013-10-24T10:17:55.2383919+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "doloremque",
      "Hidden": false,
      "FullName": "Dr. Michael Maynard Jerde Jr."
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "nihil",
      "Description": "Object-based secondary circuit"
    },
    {
      "Value": "iste",
      "StrippedValue": "nihil",
      "Description": "Object-based secondary circuit"
    }
  ],
  "Phones": [
    {
      "Value": "nisi",
      "StrippedValue": "molestiae",
      "Description": "Inverse client-driven budgetary management"
    },
    {
      "Value": "nisi",
      "StrippedValue": "molestiae",
      "Description": "Inverse client-driven budgetary management"
    }
  ],
  "Faxes": [
    {
      "Value": "fugiat",
      "StrippedValue": "et",
      "Description": "Organized background monitoring"
    },
    {
      "Value": "fugiat",
      "StrippedValue": "et",
      "Description": "Organized background monitoring"
    }
  ],
  "Description": "Synergistic 24/7 encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "magni",
      "PersonId": 52,
      "Mrmrs": "porro",
      "Firstname": "Lorenz",
      "Lastname": "McGlynn",
      "MiddleName": "Hermann-Kerluke",
      "Title": "velit",
      "Description": "Phased holistic task-force",
      "Email": "shana@kutch.biz",
      "FullName": "Selmer Krajcik",
      "DirectPhone": "1-632-755-8933 x768",
      "FormalName": "Adams, Hudson and Zulauf",
      "CountryId": 529,
      "ContactId": 586,
      "ContactName": "Muller-Ortiz",
      "Retired": 404,
      "Rank": 296,
      "ActiveInterests": 328,
      "ContactDepartment": "",
      "ContactCountryId": 20,
      "ContactOrgNr": "456903",
      "FaxPhone": "(625)716-0081 x200",
      "MobilePhone": "(828)719-8507 x072",
      "ContactPhone": "385.523.8774 x458",
      "AssociateName": "Rosenbaum, Altenwerth and Conn",
      "AssociateId": 565,
      "UsePersonAddress": true,
      "ContactFax": "dolorem",
      "Kanafname": "sed",
      "Kanalname": "qui",
      "Post1": "dolore",
      "Post2": "laborum",
      "Post3": "possimus",
      "EmailName": "giovanni@emardpredovic.name",
      "ContactFullName": "Niko Kilback",
      "ActiveErpLinks": 809,
      "TicketPriorityId": 1000,
      "SupportLanguageId": 251,
      "SupportAssociateId": 619,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "doloremque",
  "Xstop": false,
  "ActiveInterests": 386,
  "GroupId": 961,
  "ActiveStatusMonitorId": 278,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 30,
  "DbiAgentId": 450,
  "DbiLastSyncronized": "2008-12-04T10:17:55.2383919+01:00",
  "DbiKey": "vero",
  "DbiLastModified": "2010-06-27T10:17:55.2383919+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 413,
  "ActiveErpLinks": 280,
  "BounceEmails": [
    "marco@bartolettistracke.ca",
    "cade@jewess.uk"
  ],
  "Domains": [
    "ratione",
    "eligendi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "odio",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "pariatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 687,
  "Name": "Price Group",
  "Department": "",
  "OrgNr": "711367",
  "Number1": "1284619",
  "Number2": "481398",
  "UpdatedDate": "2013-03-15T10:17:55.2383919+01:00",
  "CreatedDate": "2022-05-25T10:17:55.2383919+02:00",
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "pariatur",
      "Description": "Cross-group scalable hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 205
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "pariatur",
      "Description": "Cross-group scalable hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 205
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 461,
      "Name": "Wyman-Leffler",
      "ToolTip": "Nisi neque voluptate.",
      "Deleted": false,
      "Rank": 979,
      "Type": "incidunt",
      "ColorBlock": 600,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "1998-01-25T10:17:55.2383919+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quos",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Chandler Terrell Dicki DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 412
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eligendi",
      "StrippedValue": "vitae",
      "Description": "Virtual bifurcated alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "vitae",
      "Description": "Virtual bifurcated alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "earum",
      "Description": "Re-engineered hybrid knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "earum",
      "Description": "Re-engineered hybrid knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusantium",
      "StrippedValue": "ut",
      "Description": "Upgradable 5th generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "ut",
      "Description": "Upgradable 5th generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    }
  ],
  "Description": "Cross-platform radical leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "enim",
      "PersonId": 724,
      "Mrmrs": "non",
      "Firstname": "Amelia",
      "Lastname": "McGlynn",
      "MiddleName": "Labadie Group",
      "Title": "eum",
      "Description": "Distributed 24 hour instruction set",
      "Email": "lou_heaney@murray.name",
      "FullName": "Daija Guido Wisozk DDS",
      "DirectPhone": "1-285-944-6105",
      "FormalName": "Cremin, Prosacco and Bernier",
      "CountryId": 32,
      "ContactId": 751,
      "ContactName": "Simonis-O'Conner",
      "Retired": 821,
      "Rank": 194,
      "ActiveInterests": 742,
      "ContactDepartment": "redefine rich applications",
      "ContactCountryId": 484,
      "ContactOrgNr": "1392685",
      "FaxPhone": "436-296-9313",
      "MobilePhone": "1-275-278-6287 x1131",
      "ContactPhone": "(613)380-8235",
      "AssociateName": "Spinka Inc and Sons",
      "AssociateId": 987,
      "UsePersonAddress": false,
      "ContactFax": "rem",
      "Kanafname": "vel",
      "Kanalname": "atque",
      "Post1": "ut",
      "Post2": "esse",
      "Post3": "omnis",
      "EmailName": "ian@denesik.name",
      "ContactFullName": "Miss Melissa Hamill",
      "ActiveErpLinks": 224,
      "TicketPriorityId": 346,
      "SupportLanguageId": 813,
      "SupportAssociateId": 839,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 582
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "mollitia",
  "Xstop": true,
  "ActiveInterests": 853,
  "GroupId": 820,
  "ActiveStatusMonitorId": 208,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 592,
  "DbiAgentId": 711,
  "DbiLastSyncronized": "1999-05-28T10:17:55.2383919+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2008-08-22T10:17:55.2383919+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 337,
  "ActiveErpLinks": 455,
  "BounceEmails": [
    "ethelyn_rice@shanahanhamill.info",
    "hilbert@sporer.name"
  ],
  "Domains": [
    "vero",
    "autem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "583040247",
    "SuperOffice:2": "Luis Windler IV"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "illo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 40
    }
  }
}
```