---
title: webapp_soml
description: SuperOffice Markup Language (SOML)
author: Tony Yates
so.date: 04.17.2018
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# SuperOffice Markup Language (SOML)

The XML markup used is SuperOffice specific and is called **SuperOffice Markup Language** (SOML).

The overall requirements are simple:

* Be human-readable
* Be easy to customize and extend
* Be easy to validate
* Be easy to parse and transform as necessary

From the beginning, requirements stated that SOML must be intuitively structured and easy to extend. The representation must be orthogonal to easily introduce new elements without having to change the overall structure of the document. Additionally, the SOML must be factored into logical isolated units, which enables the reuse of existing objects when implemented new objects.

Early validation improves productivity, and therefore SuperOffice uses a fixed SOML structure suitable for schema validation.

Some errors cannot be caught with schema validation alone. These types of validations include checking references between objects, and on the implementation-level provides a validation delegation framework, which ensures that the SOML is completely validated during initialization.

## File extensions

The XML format conforms to a well-defined schema defining the entire web application's structure. It is written in files with a *.config* or [.merge][1] file extension and referred to as **configuration files**.

The SOML content in *.config* and *.merge* files are identical, but:

* Files with a config extension contain pre-configured SOML that defined the structure of the web application

* Files with a merge extension are fragments discovered at runtime and interpolated into the overall configuration model to append additional functionality. Integrations and customizations often use merge files to include additional functionality or behavior.

## File names

The naming convention for all configuration files is to start with the prefix "So". The text that follows the prefix represents the contents of the file. Regarding UI configuration files, the root name generally pertains to the entity shown in the UI, such as Person. The filename suffix is the first SOML element in the file.

For example, consider the company card, the name of the configuration file that describes all the elements that make up the company card resides in a file called *SoContactPage.config*.

It follows the convention:

```text
So[Entity][Element]
```

Inspecting the contents of the *SoContactPage.config* file, the SOML is:

```xml
<page id="ContactPage">
  <data>
    <datahandlers>
      ...
    </datahandlers>
  </data>
  <panels>
    <panel reference="Menu" />
    <panel reference="ButtonBar" />
    <!--panel reference="Navigation" /-->
    <panel reference="Navigator" />
    <panel layout-position="center" reference="Contact" />
  </panels>
</page>
```

## Fragments

For easier discoverability and file maintainability, a page structure can optionally be split into smaller logical fragments and saved as multiple files. There is a strict naming convention for this to work.

**Syntax:** `So[Reference_Name][Type].config`

Thus the filename for the above referenced **Navigator** panel fragment should be *SoNavigatorPanel.config*.

The `panel` element uses a `reference` attribute to indicate that the panel's contents reside in a file that follows the standard naming convention. With that knowledge, the following files must also exist and contain their respective parts, which they do:

* SoMenuPanelPanel.config
* SoButtonBarPanel.config
* SoNavigatorPanel.config
* SoContactPanel.config

Each one of these files exists under the root or a sub-folder in *App_Data\WebClient\Web*. The [SoContactPanel.config file][1] declares even more element fragments that reference other files.

### All ID attributes are prefixed with reference ID

Each element (panel, card, view, control) in a page is uniquely identified by the ID of that object.

As a general rule, a card, view, or control may have a reference instead of actual content. In that case, a configuration fragment of that type and with the name specified in the reference attribute value will be fetched and merged into the configuration.

```XML
<view id="MainView" reference="MainView"></view>
```

This will cause the system to look for a view configuration fragment with the reference name *MainView*. In *SoMainViewView.config*, the filename is constructed from the reference name: "So\<reference-name>\<TagName>.config".

The first example is a **view** with `id` value MainView. The `reference` attribute is *MainView*, which means that the content of this view must be in a file named *SoMainViewView.config*. *SoMainViewView.config* does exist and contains the content that declares the top left view of the company card.

[!code-xml[XML](includes/somainviewview.xml)]

Looking further down in the file, there are more fragments declared using both `reference` and `referenceWithIdUpdate` attribute.

The difference between the 2 is that `reference` is used when the element ID is unique and the contents of the element reside in the file that follows the naming convention *So[id][Element].config*.

Because no elements of the same type can have the same ID, the `referenceWithIdUpdate`attribute is used when **more than one element of the same type** wants to reference the same content. To avoid creating duplicate content in files *SoMoreMainHeaderGroupControlGroup.config* and *SoInterestMainHeaderGroupControlGroup.config*, using `referenceWithIdUpdate` means reference this file instead of using my ID as the link.

Using the following image to illustrate the point, no matter what tab is selected in the main card, the contents of the MainHeaderGroup control group and ContactButtonBar control group are shown in all views.

![web-client-company-main-card][img1]

Therefore, the best way to avoid creating 2 files with the same content named:

* SoMoreMainHeaderGroupControlGroup.config
* SoInterestMainHeaderGroupControlGroup.config

Is to use *referenceWithIdUpdate* and reference one file named:

* *SoMainHeaderGroupControlGroup.config*

```XML
<controlgroups>
  <controlgroup id="MoreMainHeaderGroup_OrgId" type="ControlGroup" />
```

From *SoMainHeaderGroupControlGroup.config:*

```XML
<controlgroups>
   <controlgroup id="MoreMainHeaderGroup" referenceWithIdUpdate="MainHeaderGroup"/>
```

## View fragments

With the code below, the config data for a view will appear as a separate config file because we have referenced the views within the cards:

```XML
<cards>
  <card id="ContactMainCard" type="SoTabbedCard" placeholderid="leftpanel" cardtype="MainCard">
    <views>
      <view id="MainView" reference="MainView"></view>
    </views>
  </card>
</cards>
```

The reference *MainView* in the `view` element means that the definition can be found in the `SoMainViewconfig` file.

<!-- Referenced links -->
[1]: panel.md

<!-- Referenced images -->
[img1]: media/web-client-company-main-card.png
