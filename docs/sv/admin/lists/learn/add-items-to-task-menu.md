---
uid: help-sv-task-menu-add
title: Lägg till poster i listan Uppgiftsmeny
description: Lägg till poster i listan Uppgiftsmeny
author: SuperOffice RnD
date: 01.11.2023
keywords: Inställningar och underhåll
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägg till poster i listan Uppgiftsmeny

När du lägger till en post i listan **Uppgiftsmeny** under Inställningar och underhåll ser dialogrutan Redigera post annorlunda ut än i beskrivningen under [Lägg till poster][2].

Så här fyller du i fälten i dialogrutan Redigera poster för Uppgiftsmenyn:

1. Klicka på knappen Lägg till under listan med poster.
    > Vill du lägga till en post i en speciallista?
    Vissa listtyper är mer specialiserade än de som beskrivs i den här proceduren. [Specialiserade listor][3]

1. Skriv in ett namn på posten i fältet **Namn**.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Välj den uppgiftsmeny du vill koppla posten till.

1. Välj önskad URL, CRMScript eller SOProtocol för uppgiftsmenyn.
    * URL
        * Ange **webbadressen** i URL-fältet.
        * Välj vilken typ av **format** du vill använda.
        Vill du veta mer om [URL-format][4]?
    * CRMScript
        * Välj vilket **skript** du vill att uppgiftsmenyn ska köra.
        Vill du veta mer om [CRMScript][5]?
    * SOProtocol
        * Ange den **SOProtocol**-URL du vill att posten ska navigera till.
        Vill du veta mer om [SOProtocol][6]?

1. Kryssa i rutorna för var du vill att Uppgiftsmenyposten ska visas.

1. Skriv eventuellt en beskrivning av posten i fältet **Beskrivning**. Läs om [översättning][7].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> När du lägger till en webbadress kan det vara praktiskt att använda till exempel mallvariabeln för aktivt företag för att hämta information från andra applikationer via webbadressen. Webbadressen måste innehålla parametrar som i det här fiktiva exemplet: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn är mallvariabeln för organisationsnummer, men andra variabler, t.ex. företagsnamn &lt;name&gt;, företagets telefonnummer &lt;cpho&gt; och kontaktnamn &lt;attn&gt;, kan också användas.

## Är SuperOffice CRM for Web installerat på en HTTPS-sida? (Lokalt)

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Relaterat innehåll

* [Lägg till en webbpanelpost][1]
* [Lägg till en översättning][7]

<!-- Referenced links -->
[1]: web-panel-add-item.md
[2]: adding-items.md
[3]: specialized-lists.md
[4]: ../../../../en/ui/web-panels/url-encoding.md
[5]: ../../../automation/crmscript/learn/index.md
[6]: ../../../../en/customization/soprotocol/index.md
[7]: ../../../localization/learn/translate-fields.md

<!-- Referenced images -->
