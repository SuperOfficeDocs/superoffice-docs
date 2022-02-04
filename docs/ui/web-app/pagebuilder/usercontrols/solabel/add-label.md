---
title: Adding a labelwebapp_add_label
uid: Adding a label
description: How to add a label 
author: Tony Yates
so.date: 06.24.2016
keywords: gui
so.topic: howto
so.client: web
so.envir: onsite
---

# Adding a label

In this example, we will add a new label called **Quick Links** to the navigator panel. For this. we need to modify the *SoNavigatorPanel.config* file. We have used the control called SoLabel to add the label.

## Example 1

```XML
<panel id="Navigator" type="SoPanel" soprotocol="" paneltype="Navigator" top="20px" left="0px" height="800px" overflow="auto" width="160px" position="absolute" zindex="99">
  <cards>
    <card id="NavigatorCard" type="SoCard" placeholderid="" cardtype="NavigatorCard">
      <views>
        <view id="NavigatorView" type="SoPlainView" overflow="auto" soprotocol="Navigator" >
          <controlgroups>
            <controlgroup id="ButtonGroup" type="SoControlGroup" position="relative" left="16px" top="10px">
              <controls>
                <!--Some other Code -->
                <!--Our Code Begins here -->
                <control id="newLabel" type="SoLabel" context-style="Heading" row="0" column="0">
                  <caption>Quick Links</caption>
                </control>
                <!-- Our Code Ends here -->
                <!--Some other Code -->
              </controls>
            </controlgroup>
          </controlgroups>
        </view>
      </views>
    </card>
  </cards>
</panel>
```

The change is marked between the 2 comments (Our code begins/ends here). We have added a label using *SoLabel*. In the `control` element, we have given an ID that could recognize the control and what type of control it is (SoLabel). The `caption` element is used to set the text on the label control. Once this code segment is added the navigator pane will look as follows:

![01][img1]

## Example 2

Depending on the place we use the control we can change the position of the display. For example, if we were to use it under the `ContactButton` control the label would be displayed after the **Company** button.

```XML
<panel id="Navigator" type="SoPanel" soprotocol="" paneltype="Navigator" top="20px" left="0px" height="800px" overflow="auto" width="160px" position="absolute" zindex="99">
  <cards>
    <card id="NavigatorCard" type="SoCard" placeholderid="" cardtype="NavigatorCard">
      <views>
        <view id="NavigatorView" type="SoPlainView" overflow="auto" soprotocol="Navigator" >
          <controlgroups>
            <controlgroup id="ButtonGroup" type="SoControlGroup" position="relative" left="16px" top="10px">
              <controls>
              <!--Some other Code -->
                <control id="contactButton" type="SoToolButton">
                <caption>[SR_COMMON_CONTACT]</caption>
                <tooltip>{button_id=TooltipOnLContact}</tooltip>
                <!--Some other Code --> 
              </control>
              <!--Our Code Begins here -->
                <control id="newLabel" type="SoLabel" context-style="Heading" row="0" column="0">
                  <caption>Quick Links</caption>
                </control>
              <!-- Our Code Ends here -->
              <!--Some other Code -->
              </controls>
            </controlgroup>
          </controlgroups>
        </view>
      </views>
    </card>
  </cards>
</panel>
```

![02][img2]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
