---
title: pagebuilder_datadriven_page_config
description: Data driven page configuration
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# Data driven page configuration

Some parts of the configuration file are filled in according to data in the database. The PageBuilder framework replaces part of the config file with new data generated from information in the database.

For example, the layout of the user-defined fields on the **More** tab is stored in the database in the `UDefField` table. The actual values in the user-defined fields are stored in a different table.

The config for the **More** tab on the company card looks like this:

```XML
<view id="more" type="SoView" soprotocol="udef" current="contact">
  <caption>[SR_MORE_CONTACT]</caption>
  <controlgroups>
    <controlgroup id="contactmainmoreudefgroup" type="SoControlGroup" left="16px" right="20px" top="85px" bottom="54px" overflow="auto" position="absolute">
      <controls>
      </controls>
      <config>
        <grouptype>absolute</grouptype>
      </config>
    </controlgroup>
  </controlgroups>
</view>
```

The control group is empty, but the framework knows that it needs to place the controls defined in the `UdefField` table in the database inside this element because of the *SoUdefConfiguration.config* file defines the ID of the control group.

The PageBuilder generates the controls needed to show the user-defined fields using the data in the `UdefField` table in the database.
