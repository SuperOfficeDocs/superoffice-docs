---
title: webapp_architecture
description: Web client architecture
author: Tony Yates
so.date: 04.17.2018
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Web client architecture

## Configuration Manager

When accessed for the first time, the **Configuration Manager** loads and parses a base set of [system configuration files][3] that declare every page and dialog, type of control, interactive action, and menus that appear throughout the application.

![Web client page framework][img1]

The Configuration Manager builds a **large object graph** that represents a complete page structure. The completed structure is then passed through a **series of filters** that perform specific tasks, such as enable or disable a feature, replace resource text with internationalized values, and more - all based on the context of the current user.

## Configuration files

All configuration definitions are SOML configuration files that represent system pages defining all dependencies and UI pages defining all user-interface elements.

Each request to the *default.aspx* page invokes the PageBuilder framework and uses [SuperState][2] to determine which panels, cards, views, and controls are shown.

**The components in a typical CRM web page:**

![PageFramework][img2]

A webpage contains one or more panels, such as the navigator panel on the left, a button bar on the bottom, and the main panel in the center.

A panel contains one or more cards, where each card contains one or more views, which in turn contain one or more control groups that host UI controls.

At the core of a UI page, its' definition declares the root page element, which contains a data element and a panels element:

```XML
<page id="SoExamplePage">
  <data></data>
  <panels></panels>
</page>
```

The `data` element contains all [data-handler][6] elements used for data binding and persisting data changes. The example below references the `ContactEntityDataHandler`, used to retrieve and persist all company-related data.

```XML
<data>
  <datahandlers>
    <datahandler id="ContactEntityDataHandler" type="ContactEntityDataHandler"/>
    ...
  </datahandlers>
</data>
```

The `panels` element contains a set of panels that represent layout areas on a page. The master page, for example, uses 4 panels: Menu, Navigator, ButtonBar, and one that represents an entity page. Below is an excerpt from the *SoContactPage.config* file.

```XML
<page id="ContactPage">
  <data></data>
  <panels>
    <panel reference="Menu" />
    <panel reference="Navigator" />
    <panel reference="ButtonBar" />
    <panel reference="Contact" />
  </panels>
</page>
```

An element with the `reference` attribute is a common convention for splitting the configuration into smaller, more manageable files. The convention means all referenced elements are in another file called the same as the declared ID, prefixed with *So* and suffixed with the name of the element. For example, *SoMenuPanel.config*.

When viewing the *SoMenuPanel.config* file, the contents begin with the base element, followed by valid child elements.

```XML
<panel id="Menu">
  ...
</panel>
```

Panels have child elements called **cards**, which have child elements called **views**, which have child elements called **controls**, and so on. Page configurations are detailed in the [Web client page configuration][3] section.

## Filters

A **filters task** is to modify and adjust the configuration, based on settings, state, and other factors. For example, all state concerning the configuration is handled by a filter (Context filter).

A **filter list** is used to determine which filters to use and in what order.

```xml
<!-- See the file SoFilterList.config -->
<filters>
  <filter phase="pre" name="ContextFilter"></filter>
  <filter phase="post" name="ResourceFilter"></filter>
  ...
</filters>
```

1. PageBuilder calls the Configuration Manager, which in turn invokes the FilterEngine.
2. FilterEngine gets the filter list from the Configuration Manager and begins to invoke each one.

![Web client filter engine][img3]

**The growth and shrinking of a processed page:**

![web client config file lifecycle][img4]

In sum, filters add and remove fragments of the configuration. The main purpose is to reduce client output, enforce rules(rights) based on client state/user.

### MergeFilter

One such filter is the `MergeFilter`, which discovers files with a *.merge* extension and containing fragments of SOML to add, remove, or replace portions of the graph.

[Merge files][4] are a means used by both SuperOffice and third-parties to customize existing functionality.

> [!NOTE]
> MergeFilter **executes before cache**, all others filters after cache. The filters reside in the client, not in the web services.

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

## PageBuilder

After completing the filter process, [PageBuilder][3] uses the final SOML structure of a page to, as the name applies, build the page. It uses implementations of a panel, card, view, control, and datahander to set up the different panels, cards, views, and controls in the right combination. 99 percent of the visible UI are the controls.

In addition to building the page, PageBuilder also makes sure the data handlers populate, collect form data, and perform page saves.

![PageBuilder process][img5]

## Single-page application callbacks

One of the biggest challenges with the page framework was to recreate the dynamics and responsiveness of the Windows client. The Web client must be able to seamlessly reflect changes in not just the UI but in the current and supermode(SuperState) cache as well.

Using a combination of configuration and [SuperState][2], the Web client can prevent full-page postbacks (causing flickering, lost focus, and position) by using the server-side callback mechanism in ASP.NET.

**SoProtocol** has everything needed to perform the necessary calculations that determine what, and what not, to update in the UI. Callback requests arrive as [SoProtocol][2] containing querystring key-value parameters. A module called **SoProtocolModule** parses SoProtocol strings and updates current SuperState changes with the parameters in the last request.

SoProtocol value changes are used by the **ContextFilter** to modify the configuration. Parts of the configuration that are not affected by the changes in SuperState/Current are removed. This means that almost all unnecessary parsing and rendering are eliminated.

Once PageBuilder has created and initialized all its objects, the **Callbackhandler** loops through the cards that made it through the filters and sends a request back to the client to renders the HTML.

On the client-side, a function receives the HTML and puts it back where it belongs. This means that with only one request to the server we can update all the cards on a panel, or even none, if the request didn’t result in any changes in SuperState.

## Lifecycle

While navigating around in the client, incoming requests sent to the server are interpreted and rewritten into an SoProtocol URL. The SoProtocolModule uses the parsed URL to determine what to display on the page and what data to load into the page.

![lifecycle][img6]

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

<!-- Referenced links -->
[2]: ../pagebuilder/superstate/index.md
[3]: ../pagebuilder/config/index.md
[4]: change-page-config.md
[6]: ../pagebuilder/datahandlers/index.md

<!-- Referenced images -->
[img1]: media/web-client-page-framework.png
[img2]: media/web-client-pagebuilder-framework2.png
[img3]: media/web-client-filter-engine.png
[img4]: media/web-client-merge-file-process.png
[img5]: media/web-client-page-builder-process.png
[img6]: media/config-lifecycle.png
