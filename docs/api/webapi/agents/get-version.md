---
title: How to get the API version
uid: webapi_agents_get_version
description: How to get the Agents WebAPI version
author: {github-id}
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# How to get the API version

You can get the version number and build-date from the **API endpoint**: `/api`

This returns a block with the supported versions and the NetServer version number.

* If you don't ask specifically, you get the HTML representation.
* If you ask for Javascript, you get the following:

```javascript
{ "v1": "http://www.example.com/crm/api/v1",
  "Version": "v1",
  "NetServerVersion": "8.1.6431.038",
  "NetServerAssembly": "8.1.0.0",
  "NetServerDate": "2017-08-10",
  "NetServer": "SuperOffice NetServer 8.1 Release (Build: 6431)",
  "NetServerLabel": "9729",
  "Services": "Services83",
  "Services80": "http://www.superoffice.net/ws/crm/NetServer/Services80",
  "Services81": "http://www.superoffice.net/ws/crm/NetServer/Services81",
  "Services82": "http://www.superoffice.net/ws/crm/NetServer/Services82",
  "Services83": "http://www.superoffice.net/ws/crm/NetServer/Services83",
}
```

## Supported URLs

If you fetch the version URL, you get back a list of supported URLs: `/api/v1`

This returns an array of URLs mapped to the HTTP methods they support, along with some documentation:

```javascript
{
  "http://www.example.com/WebApi/api/v1/Agents/Relation/CreateDefaultContactRelationEntity": {
    "POST": "Set default values into a new ContactRelationEntity."
  },
  "http://www.example.com/WebApi/api/v1/Agents/Relation/GetContactRelationEntity": {
    "POST": "?contactRelationEntityId={contactRelationEntityId}   Gets a ContactRelationEntity object."
  },
  "http://www.example.com/WebApi/api/v1/Agents/Relation/SaveContactRelation": {
    "POST": "Creates a new or updates an existing contact relation."
  },
  "http://www.example.com/WebApi/api/v1/Agents/Relation/DeleteContactRelation": {
    "POST": "Deletes the specified contact relation."
  },
  "http://www.example.com/WebApi/api/v1/List/WebPanel": {
    "GET": "Gets description of WebPanelEntity list",
    "PUT": "Save the description of WebPanelEntity list"
  },
  "http://www.example.com/WebApi/api/v1/List/WebPanel/Items": {
    "GET": "Gets a list of all WebPanelEntity list items.",
    "POST": "Create a new WebPanelEntity list item"
  },
  "http://www.example.com/WebApi/api/v1/List/WebPanel/Items/{id}": {
    "GET": "Gets a WebPanelEntity list item.",
    "PUT": "Updates the existing WebPanelEntity",
    "DELETE": "Marks the existing WebPanelEntity as deleted."
  },
 ...
```

You can use this information to determine if the server supports the features you need.
