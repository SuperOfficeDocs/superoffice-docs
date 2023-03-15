---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 822
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 524,
  "Name": "Grady, Ratke and Vandervort",
  "Department": "",
  "OrgNr": "619203",
  "Number1": "852187",
  "Number2": "381397",
  "UpdatedDate": "2012-03-14T12:15:18.5137624+01:00",
  "CreatedDate": "2007-04-23T12:15:18.5137624+02:00",
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "quibusdam",
      "Description": "Automated explicit product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 705
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "quibusdam",
      "Description": "Automated explicit product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 705
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 97,
      "Name": "Fritsch, Beer and Halvorson",
      "ToolTip": "Rerum similique cum natus ut.",
      "Deleted": false,
      "Rank": 499,
      "Type": "quaerat",
      "ColorBlock": 477,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2012-08-23T12:15:18.5137624+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Mertie Welch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 287
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "ut",
      "Description": "Secured neutral encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1001
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "ut",
      "Description": "Secured neutral encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1001
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Business-focused 4th generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Business-focused 4th generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellat",
      "StrippedValue": "rem",
      "Description": "Multi-lateral system-worthy methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "rem",
      "Description": "Multi-lateral system-worthy methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    }
  ],
  "Description": "Reverse-engineered intermediate analyzer",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veniam",
      "PersonId": 804,
      "Mrmrs": "officiis",
      "Firstname": "Emmy",
      "Lastname": "Hackett",
      "MiddleName": "Murphy LLC",
      "Title": "totam",
      "Description": "Re-contextualized non-volatile utilisation",
      "Email": "dave@wunsch.com",
      "FullName": "Gladys Haley",
      "DirectPhone": "544.597.8098",
      "FormalName": "Graham-Friesen",
      "CountryId": 119,
      "ContactId": 344,
      "ContactName": "Zemlak LLC",
      "Retired": 887,
      "Rank": 809,
      "ActiveInterests": 539,
      "ContactDepartment": "",
      "ContactCountryId": 638,
      "ContactOrgNr": "185370",
      "FaxPhone": "1-053-674-3334",
      "MobilePhone": "(474)715-4581 x310",
      "ContactPhone": "1-847-156-7272 x952",
      "AssociateName": "Langosh-Hamill",
      "AssociateId": 4,
      "UsePersonAddress": false,
      "ContactFax": "ea",
      "Kanafname": "explicabo",
      "Kanalname": "hic",
      "Post1": "est",
      "Post2": "molestias",
      "Post3": "modi",
      "EmailName": "kaycee@mertzraynor.us",
      "ContactFullName": "Prof. Ted Bud Howe DDS",
      "ActiveErpLinks": 546,
      "TicketPriorityId": 122,
      "SupportLanguageId": 687,
      "SupportAssociateId": 437,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 92
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nobis",
  "Xstop": false,
  "ActiveInterests": 251,
  "GroupId": 558,
  "ActiveStatusMonitorId": 702,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 147,
  "DbiAgentId": 607,
  "DbiLastSyncronized": "2004-04-06T12:15:18.5187592+02:00",
  "DbiKey": "eos",
  "DbiLastModified": "2000-03-10T12:15:18.5187592+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 707,
  "ActiveErpLinks": 84,
  "BounceEmails": [
    "madaline@mraz.biz",
    "mercedes_spencer@kulasbins.co.uk"
  ],
  "Domains": [
    "doloremque",
    "dolores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Foster Raynor I",
    "SuperOffice:2": "2103028790"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 571
    }
  }
}
```