---
title: superstate
description: SuperState
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# SuperState

When a user makes a change to a webpage, the SuperState captures the changes. Therefore, SuperState is **the memory of a page**. It updates the cache and writes the changes back to the database when the user logs out of the system.

![01][img1]

The above diagram shows us all the main components of the SuperOffice web application. In this section, we focus on the yellow box.

## What is SuperState?

SuperState is the mechanism that holds the current state of the different elements of the SuperOffice web application and the mechanism that tells other components what, how, and when to render.

The main tasks of the SuperState are:

* to maintain the current cache of the logged-in user
* to update the cache as the session goes on
* to save the preference of the user when they log out of the system

In SuperOffice, the cache will initially be empty when a user logs on to the system for the first time. When the user moves about in the session the cache will be updated from either the config files that make up a page or from the database. Once the user logs out of the system, the data in the cache will be stored back into the database. Therefore, when the user logs into the system for the second time, there will be a considerable amount of data in the cache since it will be updated from the data that was saved in the database.

When the user moves from a page to another page that consists of different information (for example from the Company page to the Project page), the SuperState will first check whether the data requested by the user exists in the cache and fetch it from there. If not it will fetch the data from the database. If it is in the cache, SuperState will hand over the data as well as the page config data (data from page config XML files) to the [page builder][1] to create the page and render it.

If it is not in the cache, SuperState will get the data from the database and hand over the data and the page config data to the page builder to render the page. Then store the new data in the cache for future reference. This is why the last box is named *CRM.web Client Bridge*. The SuperState acts as a bridge for the database and the rest of the SuperOffice web components.

Learn more about [state changes, triggers][2], and the role of [SoProtocol][3].

## Data structure and the helper class

The class diagram shows the SuperState data structure, its helper classes, the class that builds the SuperState, and the class that manages the configuration of the pages.

![02][img2]

Here we can see how the SuperState holds data for the different panels, cards, and views in SuperOffice as well as how it holds data on history items and the window positioning. The helper class has methods to deal with the data structure.

All the functionality are provided from 2 different classes:

* **ConfigurationManager:** loads, parses, and filters XML files, and temporarily stores them in the session cache.

* **SuperStateManager:** reads SuperState data from the database and stores any changes back to the database on session end. It uses the ConfigurationManager to retrieve config data used to build up the SuperState data structure.

![03][img3]

<!-- Referenced links -->
[1]: ../config/index.md
[2]: state-changes.md
[3]: role-of-soprotocol.md

<!-- Referenced images -->
[img1]: media/image001.gif
[img2]: media/image002.jpg
[img3]: media/image003.jpg
