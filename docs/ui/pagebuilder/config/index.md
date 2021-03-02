---
title: pagebuilder_config       
description: PageBuilder config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# PageBuilder config files

The PageBuilder is the mechanism that is defined by SuperOffice to build the pages of the CRM.web application. This section will focus on the many different config files that PageBuilder uses.

## Why create all Pages through CONFIG files?

* The ability to customize the application by only editing few XML files. Since all these config files are controlled and managed by the PageBuilder, any third-party customizations can be added in a way the framework will understand.

* It allows customizations to be done without altering the HTML files directly. This makes keeping track of customizations easier when upgrading to a new version of CRM.web.

* It is easy to validate properly structured XML files. If the system is going to depend on the config files, validation is very important since you can catch most of the issues at compile time rather than when executing the code.

> [!TIP]
> Familiarize yourself with PageBuilder before going into more detail on the config files.

## Lifecycle

![lifecycle][img1]

1. When a callback request is made to the server, the request is in the form of the soprotocol.
2. The SoProtocolModule parses the soprotocol and updates the SuperState and Current reflecting the changes made from the last request.
3. These changes are used by the ContextFilter to modify the configuration.
4. Parts of the configuration that isn’t affected by the changes in SuperState/Current are removed.
5. When the PageBuilder receives the configuration, it has no knowledge of what to render and what to not render. The PageBuilder only builds what the configuration tells it to build.

## Fragments (filenames)

Configuration files can be split into smaller fragments to enable reuse. There is a strict naming convention for this to work.

Fragments must be named correctly:

* Syntax: `So[Reference_Name][Type].config`
* Example: `SoContactCommonHeaderControlGroup.config`

Fragment filename: *SoNavigatorPanel.config*

```XML
<panels>
  <panel reference="Menu" />
  <panel reference="ButtonBar" />
  <panel reference="Navigator" />
  <panel reference="Contact" />
</panels>
```

You can have several paths. Must start with CustomPath. You should turn off the cache during development - or you won't see changes to the config file appear in the GUI.

### Fragments are page configuration specific

From *SoMainHeaderGroupControlGroup.config:*

```XML
<controlgroups>
   <controlgroup id="MoreMainHeaderGroup" referenceWithIdUpdate="MainHeaderGroup"/>
```

### All ID attributes are prefixed with ref. id

```XML
<controlgroups>
  <controlgroup id="MoreMainHeaderGroup_OrgId" type=“ControlGroup" />
```

## Data driven

Config for web panels and external applications are generated using templates. These reside in the Service layer.

## Filters

Adds and removes fragments of the configuration. The main purpose is to reduce client output, enforce rules(rights) based on client state/user.

MergeFilter executes before cache, all others filters after cache. The filters resides in the client - not in the web services.

Filter filename: `SoFilterList.config`

```XML
<filters>
  <filter phase="precache" name="MergeFilter"></filter>
  <filter phase="post" name="ContextFilter"></filter>
  <filter phase="post" name="DataFilter"></filter>
  <filter phase="post" name="FunctionalRightsFilter"></filter>
  <filter phase="post" name="SessionStateFilter"></filter>
  <filter phase="post" name="UserPreferenceFilter"></filter>
  <filter phase="post" name="LocalizationFilter"></filter>
  <filter phase="post" name="SentryFilter"></filter>
</filters>
```

## Configuration cache

Caches exist in the database and the application. Fragments and data driven config are cached in the database. The post MergeFilter is run on the client. Use the magic `?Flush` command to clear the cache both on client and server.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/ config-lifecycle.png
