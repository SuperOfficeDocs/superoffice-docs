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

## Why create all pages through CONFIG files?

* The ability to customize the application by only editing few XML files. Since all these config files are controlled and managed by the PageBuilder, any third-party customizations can be added in a way the framework will understand.

* It allows customizations to be done without altering the HTML files directly. This makes keeping track of customizations easier when upgrading to a new version of CRM.web.

* It is easy to validate properly structured XML files. If the system is going to depend on the config files, validation is very important since you can catch most of the issues at compile time rather than when executing the code.

> [!TIP]
> Familiarize yourself with PageBuilder before going into more detail on the config files.

## SuperOffice Markup Language (SOML)

SOML is an XML format that conforms to a well-defined schema defining the entire web applications structure. It is written in files with a *.config* or [.merge][1] file extension and referred to as **configuration files**.

The SOML content in *.config* and *.merge* files are identical, but:

* Files with a .config extension contain pre-configured SOML that defined the structure of the web application

* Files with a .merge extension are fragments discovered at runtime and interpolated into the overall configuration model to append additional functionality. Integrations and customizations often use .merge files to include additional functionality or behavior.

Configuration files make up both the [infrastructure components][2] and [user-interface][3] (UI) components of the application. Infrastructure components are a collection of files that represent the system itself and are referred to as system files.

## Lifecycle

While navigating around in the client, incoming requests sent to the server are interpreted and rewritten into an SoProtocol URL. The SoProtocolModule uses the parsed URL to determine what to display on the page and what data to load into the page.

![lifecycle][img1]

1. When a callback request is made to the server, the request is in the form of the soprotocol.

2. The SoProtocolModule HttpModule parses the soprotocol string and updates the SuperState and Current reflecting the changes made from the last request.

3. These changes are used by the ContextFilter to modify the configuration.

4. Parts of the configuration that are not affected by the changes in SuperState/Current are removed.

5. When the PageBuilder receives the configuration, it has no knowledge of what to render and what to not render. The PageBuilder only builds what the configuration tells it to build.

To reduce the response payload and enforce things such as user-rights, SoProtocolModule uses the page framework to build the entire page configuration. Then based on the user's context, the configuration is then parsed multiple times by various filters to strip away unchanged or unnecessary parts of the page.

Before the unchanged parts of the page are stripped away, we need to build the entire page configuration, this has several steps:

1. The page configuration is parsed multiple times

    1. Fragments are resolved and put together.
    2. Data-driven config for WWW panels and external applications are generated
    3. The merge-filter merges custom merge files with standard configuration files
    4. Caching is performed.
    5. All other filters

2. First cached in the database to reduce startup time after an application recycle

3. Then cached in the application session for optimal access to the fully parsed configuration

4. Use the magic Flush command to clear the cache both on client and server

5. Last but not least the context filter and many other filters. The main purpose is to reduce client output, enforce rules(rights) based on client state/user.

The following illustration shows how the configuration grows and then shrinks from this process.

![web client config file lifecycle][img2]

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
  <controlgroup id="MoreMainHeaderGroup_OrgId" type="ControlGroup" />
```

## Data-driven

Config for web panels and external applications are generated using templates. These reside in the Service layer.

## Filters

Adds and removes fragments of the configuration. The main purpose is to reduce client output, enforce rules(rights) based on client state/user.

MergeFilter executes before cache, all others filters after cache. The filters reside in the client, not in the web services.

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

Caches exist in the database and the application. Fragments and data-driven config are cached in the database. The post MergeFilter is run on the client. Use the magic `?Flush` command to clear the cache both on the client and server.

<!-- Referenced links -->
[1]: ../../tutorials/customize/cust-and-deploy.md
[2]: system-config-files.md
[3]: ui-config-files.md

<!-- Referenced images -->
[img1]: media/config-lifecycle.png
[img2]: media/web-client-merge-file-process.png