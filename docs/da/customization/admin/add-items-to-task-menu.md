---
uid: help-da-task-menu-add
title: Tilføjelse af forekomster til listen for menuen Opgave
description: Tilføjelse af forekomster til listen for menuen Opgave
keywords: Opgavemenuen 
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /da/admin/lists/learn/add-items-to-task-menu
language: da
---

# Tilføjelse af forekomster til listen for menuen Opgave

## Trin

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Vælg **menuen Opgave** fra rullemenuen.

1. Klik på knappen **Tilføj** under listen Forekomster.

1. Indtast navnet for forekomsten i feltet **Navn**. *(Obligatorisk)*

1. Vælg den opgavemenu, du vil knytte forekomsten til.

1. Vælg den ønskede opgavemenutype:

    * URL: Skriv **URL-adressen** i URL-feltet og vælg den type [URL-kodning][4], du ønsker.
    * [CRMScript][5]: Vælg, hvilket **script** opgavemenuen skal køre.
    * [SoProtocol][6]: ndtast den **SoProtocol**-URL, som listeelementet skal navigere til.

1. Markér afkrydsningsfelterne for det sted, hvor menuvalget Opgave skal vises.

1. Angiv eventuelt en beskrivelse af forekomsten i feltet **Beskrivelse**. Læs om [Oversættelse][7].

1. Klik på **Gem** for at anvende ændringerne eller **Afbryd** for at kassere dem.

## Brug af skabelonvariabler

Når du tilføjer en URL-adresse, kan det være nyttigt at bruge f.eks. skabelonvariablen for aktivt firma til at hente oplysninger fra andre programmer via en URL. URL-adressen skal angive parametre som i dette fiktive eksempel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn er skabelonvariablen for organisationsnummer, men andre variabler, såsom firmanavn &lt;name&gt;, firmaets telefonnummer &lt;cpho&gt; eller personnavn &lt;attn&gt; kan også anvendes.

## Er SuperOffice CRM for Web installeret på et https-websted? (Onsite)

[!include[HTTPS restriction](../includes/web-panels-and-https.md)]

## Relateret indhold

* [Tilføjelse af et webpanelelement][1]
* [Tilføjelse af en oversættelse][7]
* [Specialiserede lister][3]

<!-- Referenced links -->
[1]: ../web-panels/admin/add-web-panel.md
[4]: ../web-panels/admin/url-encoding.md
[3]: ../../admin/lists/specialized-lists.md
[5]: ../../automation/crmscript/learn/index.md
[6]: ../../../en/customization/soprotocol/index.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
