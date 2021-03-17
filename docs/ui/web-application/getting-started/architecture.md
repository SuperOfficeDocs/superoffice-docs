---
uid: WebClientArchitecture
title: webapp_architecture
description: Web client architecture
author: Tony Yates
so.date: 04.17.2018
keywords:
so.topic:
so.client: web
---

# Web client architecture

First conceived and built on ASP.NET technology in 2005, the CRM Web Framework used cutting-edge Web 2.0 techniques, and was delivered as one of the first enterprise CRM single-page applications (SPA) on the market. It continues to evolve, using the latest web development technologies, and remains the finest CRM platform available.

SuperOffice CRM Web is an application, from the ground up, built for extensibility. Nearly every feature, from user-interface (UI) to the database, is customizable.

![CustomCode][6]

Like similar platforms, SuperOffice Web is comprised of several components that render a page in a browser. Its strength is its flexibility. The entire application structure is declared in XML configuration files.

The XML markup used is SuperOffice specific and is called **SuperOffice Markup Language** (SOML).

## Requirements

The overall requirements are simple:

* Be human-readable
* Be easy to customize and extend
* Be easy to validate
* Be easy to parse and transform as necessary

### Easy to read and extend

From the beginning, requirements stated that SOML must be intuitively structured and easy to extend. The representation must be orthogonal to easily introduce new elements without having to change the overall structure of the document. Additionally, the SOML must be factored into logical isolated units, which enables the reuse of existing objects when implemented new objects.

Early validation improves productivity, and therefore SuperOffice uses a fixed SOML structure suitable for schema validation.

Some errors cannot be caught with schema validation alone. These types of validations include checking references between objects, and on the implementation-level provides a validation delegation framework, which ensures that the SOML is completely validated during initialization.

### Easy to transform and customize

When accessed for the first time, the **Configuration Manager** loads and parses a base set of system configuration files that declare every page and dialog, type of control, interactive action, and menus that appear throughout the application.

![Web client page framework][img1]

The Configuration Manager builds a large object graph that represents a complete page structure. The completed structure is then passed through a series of filters that perform specific tasks, such as enable or disable a feature, replace resource text with internationalized values, and more; all based on the context of the current user.

## Configuration files

All configuration definitions are SOML configuration files that represent system pages defining all dependencies, and UI pages defining all user-interface (UI) elements.

System configuration files, which define all pages, dialogs, and dependent files, are covered in more detail in the [page-configuration section][1].

Each request to *default.aspx* page invokes the PageBuilder framework and uses [SuperState][2] to determine which panels, cards, views and controls are shown.

Below is a diagram that shows the components in a typical CRM web page.

![PageFramework][img2]

A webpage contains one or more panels, such as the navigator panel on the left, a button bar on the bottom, and the main panel in the center.

A panel contains one or more cards, where each card contains one or more views, which in turn contain one or more control groups that host UI controls.

At the core of a UI page, its' definition declares the root page element, which contains a data element and a panels element.

**Example client page:**

```XML
<page id="SoExamplePage">
  <data></data>
  <panels></panels>
</page>
```

The data element contains all data-handler elements used for data binding and persisting data changes. The example below references the `ContactEntityDataHandler`, used to retrieve and persist all company-related data.

```XML
<data>
  <datahandlers>
    <datahandler id="ContactEntityDataHandler" type="ContactEntityDataHandler"/>
    ...
  </datahandlers>
</data>
```

The panels element contains a set of panels that represent layout areas on a page. The master page, for example, uses four panels: Menu, Navigator, ButtonBar, and one that represents an entity page. Below is an excerpt from the *SoContactPage.config* file.

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

An element with the `reference` attribute is a common convention for splitting up the SOML up into smaller, more manageble files. The convention means all referenced elements are in another file called the same as the declared ID, prefixed with *So* and suffixed with the name of the element. For example, *SoMenuPanel.config*.

When viewing the *SoMenuPanel.config* file, the contents begin with the base element, followed by valid child elements.

```XML
<panel id="Menu">
  ...
</panel>
```

Panels have child elements called cards, which have child elements called views, which have child elements called controls, and so on. Page configurations are detailed in the [Web client page configuration][3] section.

## Filters

A filters task is to modify and adjust the configuration, based on settings, state, and other factors. For example, all state concerning the configuration is handled by a filter (Context filter).

A filter list is used to determine witch filters to use and in which order.

```xml
<!-- See the file SoFilterList.config -->
<filters>
  <filter phase="pre" name="ContextFilter"></filter>
  <filter phase="post" name="ResourceFilter"></filter>
  ...
</filters>
```

1. PageBuilder calls the Configuration Manager, which in turn invokes the FilterEngine.
2. FilterEngine gets the filter list from the configuration manager and begins to invoke each one.

![Web client filter engine][img3]

**The growth and shrinking of a processed page:**

![web client config file lifecycle][img4]

One such filter is the `MergeFilter`, which discovers files with a *.merge* extension and containing fragments of SOML to add, remove, or replace portions of the graph.

Merge files are a means used by both SuperOffice and third-parties to customize existing functionality and are discussed at length in the article: [Deploying Merge Files][4].

## PageBuilder

After completing the filter process, [PageBuilder][3] uses the final SOML structure of a page to; as the name applies, build the page. It uses implementations of a Panel, Card, View, Control, and Datahander to set up the different panels, card, views, and controls in the right combination. 99% of the visible UI are the controls.

In addition to building the page, it also makes sure the data handlers populate, collect form data and perform page saves.

![web client config file lifecycle][img5]

## Single-page application callbacks

One of the biggest challenges with the page framework was to recreate the dynamics and responsiveness of the Windows client. The Web client must be able to seamlessly reflect changes in not just the UI but in the current and supermode(SuperState) cache as well.

Using a combination of configuration and SuperState, the web client can prevent full-page postbacks (causing flickering, lost focus, and position) by using the server-side callback mechanism in ASP.NET.

**SoProtocol** has everything needed to perform the necessary calculations that determine what, and what not, to update in the UI. Callback requests arrive as [soprotocol][5] containing querystring key-value parameters. A module called **SoProtocolModule** parses soprotocol strings and updates current SuperState changes with the parameters in the last request.

SoProtocol value changes are used by the ContextFilter to modify the configuration. Parts of the configuration that are not affected by the changes in SuperState/Current are removed. This means that almost all unnecessary parsing and rendering are eliminated.

PageBuilder doesn't know what and what not to render, it only builds what the ConfigurationManager tells it to build.

Once PageBuilder has created and initialized all its objects, the Callbackhandler loops through the cards that made it through the filters and sends a request back to the client to renders the HTML.

On the client-side a function receives the HTML and puts it back where it belongs. This means that with only one request to the server we can update all the cards on a panel, or even none, if the request didn’t result in any changes in SuperState.


<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/onsite/web-client/page-configuration.md
[2]: ../pagebuilder/superstate/index.md
[3]: ../pagebuilder/config/index.md
[4]: https://community.superoffice.com/en/content/content/webclient/customization-and-deployment/
[5]: ../../soprotocol/index.md

<!-- Referenced images -->
[img1]: media/web-client-page-framework.png
[img2]: media/web-client-pagebuilder-framework2.png
[img3]: media/web-client-filter-engine.png
[img4]: media/web-client-merge-file-process.png
[img5]: media/web-client-page-builder-process.png
[img6]: media/web-client-custom-code.png
