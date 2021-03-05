---
title: pb_add_textbox_to_navigator
description: How to add new components to an existing page (SoTextBox to Navigator)
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to add new components to an existing page

We are going to add a new component to the contact page. A SoTextBox is added to the page, above the navigator buttons on the upper-left corner of the **Contact** page (in the navigator panel).

```XML
<!--my SoTextBox Starts-->
<controlgroup id="sotextbox" type="SoControlGroup" position="relative" top="5px" left="26px">
  <controls>
    <control id="ContactSoTextBox" type="SoTextBox" width="50px" >
      <datasource>ContactEntityDataHandler.ContactEntity.Name</datasource>
    </control>
  </controls>
</controlgroup>
<!--my SoTextBox Ends-->
```

> [!NOTE]
> In this case, `position` should be set to "relative" and `top` and `left` attributes should be set according to the place where we want to have them.

SoTextBox binds data from the ContactEntityDataHandler. Data is fetched from database.

[!code-xml[XML](includes/navigator.xml)]

**Result:**

![04][img1]

The SoTextBox we added is shown in the red rectangle.

## Data binding

In the *SoNavigatorPanel.config* file, the data is bound by using the ContactEntityDataHandler ID.

[!code-xml[XML](includes/navigator.xml?range=12)]

## Triggers

To have the field updated automatically, we need to trigger the field based on the current Contact. This will cause our textbox to be updated when the Contact changes. Here's how:

```XML
<panel id="Navigator" type="SoPanel" soprotocol="" paneltype="Navigator" top="20px" left="0px" height="800px" overflow="auto" width="160px" position="absolute" zindex="99">
  <cards>
    <card id="NavigatorCard" type="SoCard" placeholderid="myPlc" cardtype="NavigatorCard">
      <views>
        <view id="NavigatorView" type="SoPlainView" overflow="auto" soprotocol="Navigator" >
          <controlgroups>
            <!--Some other Code-->
          </controlgroups>
          <config>
          </config>
          <!--Our trigger begins here-->
          <triggers>
            <trigger type="current">contact</trigger>
          </triggers>
          <!--Our trigger Ends here-->
        </view>
        <view id="NavigatorSystemView" type="SoSystemView" soprotocol=""></view>
      </views>
    </card>
  </cards> 
</panel>
```

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image004.jpg
