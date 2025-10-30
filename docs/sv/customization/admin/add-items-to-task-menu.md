---
uid: help-sv-task-menu-add
title: Lägg till poster i listan Uppgiftsmeny
description: Lägg till poster i listan Uppgiftsmeny
keywords: Uppgiftsmeny
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Inställningar och underhåll
index: true
redirect_from: /sv/admin/lists/learn/add-items-to-task-menu
language: sv
---

# Lägg till poster i listan Uppgiftsmeny

## Steg

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **Uppgiftsmeny** från rullgardinsmenyn.

1. Klicka på knappen **Lägg till** under listan med poster.

1. Skriv in ett namn på posten i fältet **Namn**. *(Obligatorisk)*

1. Välj den uppgiftsmeny du vill koppla posten till.

1. Välj önskad typ för uppgiftsmenyn:

    * URL: Ange **webbadressen** i URL-fältet och välj vilken typ av [URL-format][4] du vill använda.
    * [CRMScript][5]: Välj vilket **skript** du vill att uppgiftsmenyn ska köra.
    * [SOProtocol][6]: Ange den **SOProtocol**-URL du vill att posten ska navigera till.

1. Kryssa i rutorna för var du vill att Uppgiftsmenyposten ska visas.

1. Skriv eventuellt en beskrivning av posten i fältet **Beskrivning**. Läs om [översättning][7].

1. Klicka på **Spara** för att spara ändringarna eller **Avbryt** för att förkasta dem.

## Använda mallvariabler

När du lägger till en webbadress kan det vara praktiskt att använda till exempel mallvariabeln för aktivt företag för att hämta information från andra applikationer via webbadressen. Webbadressen måste innehålla parametrar som i det här fiktiva exemplet: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn är mallvariabeln för organisationsnummer, men andra variabler, t.ex. företagsnamn &lt;name&gt;, företagets telefonnummer &lt;cpho&gt; och kontaktnamn &lt;attn&gt;, kan också användas.

## Är SuperOffice CRM for Web installerat på en HTTPS-sida? (Lokalt)

[!include[HTTPS restriction](../includes/web-panels-and-https.md)]

## Relaterat innehåll

* [Lägg till en webbpanelpost][1]
* [Lägg till en översättning][7]
* [Specialiserade listor][3]

<!-- Referenced links -->
[1]: ../web-panels/admin/add-web-panel.md
[3]: ../../admin/lists/specialized-lists.md
[4]: ../web-panels/admin/url-encoding.md
[5]: ../../automation/crmscript/learn/index.md
[6]: ../../../en/customization/soprotocol/index.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
