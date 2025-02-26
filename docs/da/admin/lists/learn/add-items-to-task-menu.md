---
uid: help-da-task-menu-add
title: Tilføjelse af forekomster til listen for menuen Opgave
description: Tilføjelse af forekomster til listen for menuen Opgave
keywords: menuen Opgave
author: SuperOffice RnD
date: 01.11.2023
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføjelse af forekomster til listen for menuen Opgave

Når du føjer en forekomst til listen for **menuen Opgave** i Indstillinger og vedligeholdelse, ser dialogboksen Rediger forekomst anderledes ud end den, der er beskrevet under [Tilføj elementer][2].

Sådan udfyldes felterne i dialogboksen Rediger forekomster for menuen Opgave:

1. Klik på knappen Tilføj under listen Forekomster.
    > Vil du føje en forekomst til en specialiseret liste?
    Nogle listetyper er mere specialiserede end dem, der henvises til i denne procedure. [Specialiserede lister][3]

1. Indtast navnet for forekomsten i feltet **Navn**.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Vælg den opgavemenu, du vil knytte forekomsten til.

1. Vælg den ønskede opgavemenutype URL, CRMScript eller SOProtocol.
    * URL
        * Skriv **URL-adressen** i URL-feltet.
        * Vælg den type **kodning**, du ønsker.
        Vil du vide mere om [URL-kodning][4]?
    * CRMScript
        * Vælg, hvilket **script** opgavemenuen skal køre.
        Vil du vide mere om [CRMScript][5]?
    * SoProtocol
        * Indtast den **SoProtocol**-URL, som listeelementet skal navigere til.
        Vil du vide mere om [SoProtocol][6]?

1. Markér afkrydsningsfelterne for det sted, hvor menuvalget Opgave skal vises.

1. Angiv eventuelt en beskrivelse af forekomsten i feltet **Beskrivelse**. Læs om [Oversættelse][7].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> Når du tilføjer en URL-adresse, kan det være nyttigt at bruge f.eks. skabelonvariablen for aktivt firma til at hente oplysninger fra andre programmer via en URL. URL-adressen skal angive parametre som i dette fiktive eksempel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn er skabelonvariablen for organisationsnummer, men andre variabler, såsom firmanavn &lt;name&gt;, firmaets telefonnummer &lt;cpho&gt; eller personnavn &lt;attn&gt; kan også anvendes.

## Er SuperOffice CRM for Web installeret på et https-websted? (Onsite)

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Relateret indhold

* [Tilføjelse af et webpanelelement][1]
* [Tilføjelse af en oversættelse][7]

<!-- Referenced links -->
[1]: web-panel-add-item.md
[2]: adding-items.md
[3]: specialized-lists.md
[4]: ../../../../en/ui/web-panels/url-encoding.md
[5]: ../../../automation/crmscript/learn/index.md
[6]: ../../../../en/ui/soprotocol/index.md
[7]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
