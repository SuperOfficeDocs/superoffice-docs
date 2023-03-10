---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 306,
  "Name": "Gerhold-Hessel",
  "Department": "",
  "OrgNr": "1372385",
  "Number1": "1692933",
  "Number2": "1017730",
  "UpdatedDate": "2007-03-09T12:15:18.4477625+01:00",
  "CreatedDate": "2004-01-25T12:15:18.4477625+01:00",
  "Emails": [
    {
      "Value": "itaque",
      "StrippedValue": "consequatur",
      "Description": "Versatile demand-driven monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 14
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "consequatur",
      "Description": "Versatile demand-driven monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 14
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 49,
      "Name": "Bartell-Boehm",
      "ToolTip": "Quasi error.",
      "Deleted": false,
      "Rank": 156,
      "Type": "sed",
      "ColorBlock": 212,
      "IconHint": "dignissimos",
      "Selected": false,
      "LastChanged": "2002-08-30T12:15:18.4487581+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sapiente",
      "StyleHint": "at",
      "Hidden": false,
      "FullName": "Dr. Mariane Nicole Prosacco",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 764
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "esse",
      "StrippedValue": "iure",
      "Description": "Reverse-engineered web-enabled monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "iure",
      "Description": "Reverse-engineered web-enabled monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "at",
      "Description": "Inverse dedicated function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "at",
      "Description": "Inverse dedicated function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quis",
      "StrippedValue": "quia",
      "Description": "Synergistic intangible knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "quia",
      "Description": "Synergistic intangible knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    }
  ],
  "Description": "Networked global website",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "expedita",
      "PersonId": 199,
      "Mrmrs": "adipisci",
      "Firstname": "Guido",
      "Lastname": "Daugherty",
      "MiddleName": "Stiedemann, Bernhard and Walsh",
      "Title": "consequatur",
      "Description": "Enterprise-wide transitional help-desk",
      "Email": "hazel_waelchi@crooksdietrich.us",
      "FullName": "Jade Gustave Walker Jr.",
      "DirectPhone": "1-652-645-0508",
      "FormalName": "Barrows-Rempel",
      "CountryId": 678,
      "ContactId": 981,
      "ContactName": "Steuber, Mohr and Wisoky",
      "Retired": 695,
      "Rank": 116,
      "ActiveInterests": 822,
      "ContactDepartment": "",
      "ContactCountryId": 151,
      "ContactOrgNr": "707243",
      "FaxPhone": "(152)448-8626 x9351",
      "MobilePhone": "1-331-667-5138 x3860",
      "ContactPhone": "(056)915-8167 x22278",
      "AssociateName": "Schulist Group",
      "AssociateId": 685,
      "UsePersonAddress": false,
      "ContactFax": "odio",
      "Kanafname": "exercitationem",
      "Kanalname": "vitae",
      "Post1": "neque",
      "Post2": "reiciendis",
      "Post3": "dolores",
      "EmailName": "devin.altenwerth@schmidtmcdermott.name",
      "ContactFullName": "Haven O'Conner",
      "ActiveErpLinks": 778,
      "TicketPriorityId": 139,
      "SupportLanguageId": 342,
      "SupportAssociateId": 223,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "natus",
  "Xstop": false,
  "ActiveInterests": 781,
  "GroupId": 720,
  "ActiveStatusMonitorId": 654,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 701,
  "DbiAgentId": 318,
  "DbiLastSyncronized": "1999-05-27T12:15:18.4527592+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "1999-11-20T12:15:18.4527592+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 324,
  "ActiveErpLinks": 94,
  "BounceEmails": [
    "bernard_mayert@jakubowski.ca",
    "sadie_damore@jaskolski.co.uk"
  ],
  "Domains": [
    "similique",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "37902208",
    "SuperOffice:2": "Janessa Clarabelle Kemmer DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 422
    }
  }
}
```