---
uid: help-no-task-menu-add
title: Legge til elementer i Oppgave-menylisten
description: Legge til elementer i Oppgave-menylisten
keywords: Oppgave-meny
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
redirect_from: /no/admin/lists/learn/add-items-to-task-menu
language: no
---

# Legge til elementer i Oppgave-menylisten

## Trinn

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **Oppgave-meny** fra rullegardinmenyen.

1. Klikk på **Legg til**-knappen under Forekomster-listen.

1. Skriv ønsket navn på forekomsten i feltet **Navn**. *(Obligatorisk)*

1. Velg Oppgave-menyen du vil koble forekomsten til.

1. Velg ønsket Oppgave-menytype:

    * URL: Skriv inn **URL-adressen** i URL-feltet og velg hvilken type [URL-format][4] du vil bruke.
    * [CRMScript][5]: Velg hvilket **skript** du vil at Oppgave-menyen skal kjøre.
    * [SOProtocol][6]: Skriv inn **SOProtocol**-URLen du vil at listeforekomsten skal navigere til.

1. Merk av i boksene for hvor du vil at Oppgave-menyforekomsten.

1. Legg eventuelt inn en beskrivelse av forekomsten i feltet **Beskrivelse**. Les om [Oversettelse][7].

1. Klikk **Lagre** for å lagre endringene eller **Avbryt** for å forkaste dem.

## Bruke malvariabler

Når du legger til en URL-adresse, kan det være nyttig å bruke for eksempel malvariabelen for aktivt firma til å hente ut informasjon fra andre applikasjoner via URL. URL-adressen må angi parametere, for eksempel slik: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. org.nr. her er malvariabelen for organisasjonsnummeret, men andre variabler som firmanavn &lt;name&gt;, firmatelefonnummer &lt;cpho&gt; og navn på personen &lt;attn&gt;, kan også brukes.

## Er SuperOffice CRM for Web installert på en https-webside? (Onsite)

[!include[HTTPS restriction](../includes/web-panels-and-https.md)]

## Aktuelt innhold

* [Legge til et webpanelelement][1]
* [Legge til en oversettelse][7]
* [Spesialiserte lister][3]

<!-- Referenced links -->
[1]: ../web-panels/admin/add-web-panel.md
[3]: ../../admin/lists/specialized-lists.md
[4]: ../web-panels/admin/url-encoding.md
[5]: ../../automation/crmscript/learn/index.md
[6]: ../../../en/customization/soprotocol/index.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
