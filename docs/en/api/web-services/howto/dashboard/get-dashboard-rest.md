---
uid: get-dashboard-rest
title: Working with dashboards
description: In this how-to guide, you will learn how to get all dashboards and all tiles for a dashboard.
keywords: dashboard
author: AnthonyYates
date: 02.09.2024
content_type: howto
language: en
redirect_from:
  - /en/dashboard/howto/dashboard
  - /en/api/web-services/howto/dashboard
  - /en/api/netserver/web-services/howto/dashboard
---

<!-- markdownlint-disable-file MD013 -->
# Working with dashboards

In this how-to guide, you will learn how to get all dashboards, and all tiles for a given dashboard.

The code in this guide represents HTTP requests to the SuperOffice REST API. You can use any programming language to make these requests. The examples in this guide use the `GET` method to retrieve data from the SuperOffice database.

![Dashboard][dashboard-page]

## Get all dashboards

To get all dashboards, you can use the following endpoint:

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/archive/dynamic?$select=dashboard.dashboard_id,dashboard.associate_id,dashboard.name,dashboard.description,dashboard.dashboard_theme_id,dashboard.columns HTTP/1.1
Accept: application/json
Authorization: Bearer {{token}}
Accept-Language: en
```

The response will contain an array of dashboards, including the dashboard ID, associate_id, name, description, and the number of columns.

```json
{
  "value": [
    {
      "PrimaryKey": "2",
      "EntityName": "dashboard",
      "dashboard.dashboard_id": 2,
      "dashboard.associate_id": 22,
      "dashboard.name": "Status",
      "dashboard.description": "Key numbers I follow",
    },
    {
      "PrimaryKey": "3",
      "EntityName": "dashboard",
      "dashboard.dashboard_id": 3,
      "dashboard.associate_id": 22,
      "dashboard.name": "Requests",
      "dashboard.description": "",
    },
    {
      "PrimaryKey": "98",
      "EntityName": "dashboard",
      "dashboard.dashboard_id": 98,
      "dashboard.associate_id": 5,
      "dashboard.name": "DemoDash",
      "dashboard.description": "Configuration demo ",
    },
    {
      "PrimaryKey": "108",
      "EntityName": "dashboard",
      "dashboard.dashboard_id": 108,
      "dashboard.associate_id": 22,
      "dashboard.name": "Flow default report",
      "dashboard.description": "Flow report",
    }
  ]
}
```

The following text will focus on the DemoDash dashboard.

```json
{
    "PrimaryKey": "98",
    "EntityName": "dashboard",
    "dashboard.dashboard_id": 98,
    "dashboard.associate_id": 5,
    "dashboard.name": "DemoDash",
    "dashboard.description": "Configuration demo "
}
```

## Get all tiles for a DemoDash dashboard

To get all tiles for a given dashboard, you can use the following endpoint:

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/archive/dynamic?$select=dashboard_tile.dashboard_tile_definition_id,dashboard_tile.dashboard_tile_id,dashboard_tile.dashboard_id&$filter=dashboard_tile.dashboard_id eq 98 HTTP/1.1
Accept: application/json
Authorization: Bearer {{token}}
```

The selected fields are:

1. the dashboard tile definition ID.
2. the dashboard tile ID.
3. the dashboard ID.

The criteria field is the dashboard ID. This gets the dashboard tiles names from the [dashboard tile table][0] where the dashboard id is 98.

Response:

```json
{
  "value": [
    {
      "PrimaryKey": "681",
      "EntityName": "dashboard_tile",
      "dashboard_tile.dashboard_tile_id": 681,
      "dashboard_tile.dashboard_id": 98,
      "dashboard_tile.dashboard_tile_definition_id": 681
    },
    {
      "PrimaryKey": "752",
      "EntityName": "dashboard_tile",
      "dashboard_tile.dashboard_tile_id": 752,
      "dashboard_tile.dashboard_id": 98,
      "dashboard_tile.dashboard_tile_definition_id": 752
    }
  ]
}
```

<!-- image references-->
[dashboard-page]: media/dashboard-page.png

<!-- links -->
[0]: ../../../../database/tables/dashboard.md
