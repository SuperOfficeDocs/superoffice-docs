---
uid: help-no-task-menu-add
title: Legge til elementer i Oppgave-menylisten
description: Legge til elementer i Oppgave-menylisten
author: SuperOffice RnD
date: 01.11.2023
keywords: Innstillinger og vedlikehold
topic: help
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Legge til elementer i Oppgave-menylisten

Når du legger til en forekomst på listen **Oppgave-meny** i Innstillinger og vedlikehold, ser dialogboksen Rediger forekomst annerledes ut enn det som er beskrevet under [Legg til elementer][2].

Slik fyller du ut feltene i dialogboksen Rediger listeelementer for Oppgave-menyen:

1. Klikk på Legg til-knappen under Forekomster-listen.
    > Skal du legge til en forekomst på en spesialisert liste?
    Enkelte listetyper er mer spesialiserte enn de som er nevnt i denne prosedyren. [Spesialiserte lister][3]

1. Skriv ønsket navn på forekomsten i feltet **Navn**.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Velg Oppgave-menyen du vil koble forekomsten til.

1. Velg ønsket Oppgave-menytype-URL, CRMScript eller SOProtocol.
    * URL
        * Skriv inn **URL-adressen** i URL-feltet.
        * Velg hvilken type **koding** du vil bruke.
        Vil du vite mer om [URL-format][4]?
    * CRMScript
        * Velg hvilket **skript** du vil at Oppgave-menyen skal kjøre.
        Vil du vite mer om [CRMScript][5]?
    * SOProtocol
        * Skriv inn **SOProtocol**-URLen du vil at listeforekomsten skal navigere til.
        Vil du vite mer om [SOProtocol][6]?

1. Merk av i boksene for hvor du vil at Oppgave-menyforekomsten.

1. Legg eventuelt inn en beskrivelse av forekomsten i feltet **Beskrivelse**. Les om [Oversettelse][7].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> Når du legger til en URL-adresse, kan det være nyttig å bruke for eksempel malvariabelen for aktivt firma til å hente ut informasjon fra andre applikasjoner via URL. URL-adressen må angi parametere, for eksempel slik: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. org.nr. her er malvariabelen for organisasjonsnummeret, men andre variabler som firmanavn &lt;name&gt;, firmatelefonnummer &lt;cpho&gt; og navn på personen &lt;attn&gt;, kan også brukes.

## Er SuperOffice CRM for Web installert på en https-webside? (Onsite)

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Aktuelle emner

* [Legge til et webpanelelement][1]
* [Legge til en oversettelse][7]

<!-- Referenced links -->
[1]: web-panel-add-item.md
[2]: adding-items.md
[3]: specialized-lists.md
[4]: ../../../../en/ui/web-panels/url-encoding.md
[5]: ../../../automation/crmscript/learn/index.md
[6]: ../../../../en/ui/soprotocol/index.md
[7]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
