---
title: app_config_files
description: SuperOffice PageBuilder application (UI) configuration files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# User interface files

What's shown in a browser window is generally associated with being a UI configuration component.

For example, the following SOML represents a dialog page called *SoPlainCardDialog.config*. It contains a root element **page** and contains two child elements, **title** and **panels**. The **panels** element is a container for one or more **panel** elements. In this case it only contains one **panel** of type **SoDialogPanel**.

![PageFramework][img1]

The panel element contains a **cards** child element and this represents a contains for one or more **card** elements. In this case, only one **card** element of type **SoDialogSimpleCard** is declared.

The **card** element contains a **views** element, which is a container for one or more **view** elements. In this case, only on **view** element of type **SoDialogSimpleView** is declared.

The **view** element contains a **controlgroups** element, which is a container for one or more **controlgroup** element. In this case, only one **controlgroup** of type **SoControlGroup** is declared.

The controlgroup element contains a **controls** element, which is a container for one or more **control** elements. In this case, only one control of type **SoLabel** is declared.

Beginning to see a pattern yet?

```xml
<!-- SoPlainCardDialog.config -->
<page id="PlainCardDialog">
  <title>Plain Dialog</title>
  <panels>
    <panel id="MainPanel" type="SoDialogPanel" soprotocol="main">
      <cards>
        <card id="MainCard" type="SoDialogSimpleCard" placeholderid="MainDialogCard"
              cardtype="MainCard" position="absolute" top="10px">
          <views>
            <view id="MainView" type="SoDialogSimpleView" soprotocol="view1">
              <controlgroups>
                <controlgroup id="MainHeaderGroup" type="SoControlGroup"
                              left="50px" top="50px" position="absolute">
                  <controls>
                    <control id="DialogHeader" type="SoLabel" width="100%">
                      <caption>Plain Dialog Label</caption>
                    </control>
                  </controls>
                </controlgroup>
              </controlgroups>
             </view>
          </views>
          <config>
            <customcssclass>mycardtop</customcssclass>
          </config>
        </card>
      </cards>
    </panel>
  </panels>
</page>
```

All elements have child **config** elements for additional functionality, but only certain controls use them. Here the [card][1] uses a **config** element to define a CSS style that should override the default. It's up to the control implementation to define what child elements are available in the config element and then process each accordingly.

The naming convention for all configuration files is to start with the prefix "So". The text that follows the prefix represents the contents of the file. Regarding UI configuration files, the root name generally pertains to the entity shown in the UI; such as Person. The filename suffix is the first SOML element in the file.

For example, consider the company card, the name of the configuration file that describes all the elements that make up the company card resides in a file called *SoContactPage.config*.

It follows the convention:

```text
So[Entity][Element]
```

Inspecting the contents of the SoContactPage.config, the SOML is:

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

For easier discoverability and file maintainability, a page structure is optionally be broken down into logical fragments and saved in multiple files.

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/M_SuperOffice_DCF_Web_UI_Controls_CardBase_InitializeViews.htm

<!-- Referenced images -->
[img1]: media/web-client-pagebuilder-framework2.png
