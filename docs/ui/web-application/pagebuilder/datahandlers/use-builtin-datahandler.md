---
title: datahandler_use
description: How to use an existing data handler
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to use an existing data handler

You can use a data handler to display a certain set of results retrieved through the web service.

## Identify handler in page.config

If we plan to use a data handler, the handler should be identified in the [page config][1].

The below code adds the `ProjectEntityDataHandler` to the **Contact** page.

```XML
<page id="ContactPage">
  <data>
    <datahandlers>
      <!-- Some other Data Handler declarations-->
      <!-- Our Data Handler-->
      <datahandler id="ProjectEntityDataHandler" type="ProjectEntityDataHandler"></datahandler>
      <!--End of our Data Handler-->
    </datahandlers>
  </data>
  <!-- Some other code-->
</page>
```

The handler can now be used and identified by the datahandler ID.

## Use handler in panel

The following code segment shows the use of the above data handler in the *SoContactPanel.config* file.

[!code-xml[XML](includes/socontactpanel.xml)]

Here we have used `ProjectEntityDataHandler` to call the project name from the web service. The following line retrieves the project name by accessing the Project entity’s `name` property.

[!code-xml[XML](includes/socontactpanel.xml?range=20)]

Since we plan to display the results in a text box in the control tab, we declared it as giving the type `type=SoTextBox`.

The Contact page’s **More** view after the modification:

![01][img1]

<!-- Referenced links -->
[1]: ../config/page.md

<!-- Referenced images -->
[img1]: media/image001.jpg
