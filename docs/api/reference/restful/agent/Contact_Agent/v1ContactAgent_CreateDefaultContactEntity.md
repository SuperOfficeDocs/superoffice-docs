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

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 361,
  "Name": "Greenholt, Hintz and Greenholt",
  "Department": "synergize intuitive markets",
  "OrgNr": "1041818",
  "Number1": "1118103",
  "Number2": "785838",
  "UpdatedDate": "2004-03-31T11:10:26.2255548+02:00",
  "CreatedDate": "2011-03-02T11:10:26.2255548+01:00",
  "Emails": [
    {
      "Value": "ipsum",
      "StrippedValue": "quae",
      "Description": "Fundamental clear-thinking service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "quae",
      "Description": "Fundamental clear-thinking service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 723,
      "Name": "Gorczany Inc and Sons",
      "ToolTip": "Non at cumque aliquam corrupti aut inventore esse.",
      "Deleted": false,
      "Rank": 2,
      "Type": "rerum",
      "ColorBlock": 118,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2012-03-08T11:10:26.2255548+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "debitis",
      "StyleHint": "molestiae",
      "Hidden": true,
      "FullName": "Lexi Blake Walsh MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "facilis",
      "Description": "Implemented demand-driven access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "facilis",
      "Description": "Implemented demand-driven access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "omnis",
      "Description": "Enhanced local intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "omnis",
      "Description": "Enhanced local intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corrupti",
      "StrippedValue": "et",
      "Description": "Triple-buffered scalable frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "et",
      "Description": "Triple-buffered scalable frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "Description": "Function-based bifurcated forecast",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cumque",
      "PersonId": 660,
      "Mrmrs": "eveniet",
      "Firstname": "Jedediah",
      "Lastname": "Farrell",
      "MiddleName": "Senger, Heller and Lockman",
      "Title": "qui",
      "Description": "Digitized composite algorithm",
      "Email": "frank@reilly.biz",
      "FullName": "Magali Harvey MD",
      "DirectPhone": "610.097.6700 x1865",
      "FormalName": "Mohr Group",
      "CountryId": 416,
      "ContactId": 117,
      "ContactName": "Johns, Ritchie and Ryan",
      "Retired": 827,
      "Rank": 82,
      "ActiveInterests": 282,
      "ContactDepartment": "",
      "ContactCountryId": 415,
      "ContactOrgNr": "396893",
      "FaxPhone": "187.783.5423",
      "MobilePhone": "099-304-1905",
      "ContactPhone": "1-392-482-3064 x312",
      "AssociateName": "Abshire Group",
      "AssociateId": 798,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "quos",
      "Kanalname": "accusamus",
      "Post1": "beatae",
      "Post2": "non",
      "Post3": "repudiandae",
      "EmailName": "eddie@oconnell.com",
      "ContactFullName": "Miss Hoyt Reichel",
      "ActiveErpLinks": 531,
      "TicketPriorityId": 479,
      "SupportLanguageId": 554,
      "SupportAssociateId": 237,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 739
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "adipisci",
  "Xstop": true,
  "ActiveInterests": 987,
  "GroupId": 322,
  "ActiveStatusMonitorId": 171,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 750,
  "DbiAgentId": 330,
  "DbiLastSyncronized": "2016-05-30T11:10:26.2295527+02:00",
  "DbiKey": "esse",
  "DbiLastModified": "2002-05-01T11:10:26.2295527+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 222,
  "ActiveErpLinks": 926,
  "BounceEmails": [
    "guy_sauer@abbotthyatt.biz",
    "jarrod@nitzsche.com"
  ],
  "Domains": [
    "hic",
    "illum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2029628606",
    "SuperOffice:2": "Pietro Bogan"
  },
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 720
    }
  }
}
```