---
uid: help-da-chat-add-javascript
title: Tilføj JavaScript til dit websted
description: Live Chat er en populær måde for dine kunder og kundeemner at komme i kontakt med dig, når de besøger dit websted. Denne video viser dig, hvordan du kan føje en chatwidget til din webside.
keywords: chat JavaScript
author: SuperOffice Product and Engineering
date: 09.25.2025
version: 10.5
content_type: howto
license: cep
category: Service
topic: chat
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from: /da/chat/learn/admin/add-javascript
index: true
---

# Tilføj JavaScript til dit websted

Hvis du vil gøre chatfunktionen tilgængelig for kunderne, skal du tilføje JavaScript på de relevante sider på dit websted. Hvis du har sat flere chatkanaler op, har hver kanal et bestemt JavaScript, som tilføjes på den eller de relevante sider.

Nu hvor du har [konfigureret chatwidgeten][1], viser dette trin dig, hvordan du tilføjer den til dit websted.

## Trin

1. [!include[Go to](../../learn/includes/goto-sm.md)]
1. Vælg <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chat** i navigatoren.
1. Vælg en chatkanal på listen, og klik på **Vis**. JavaScript for den valgte chatkanal vises.
1. Vælg og kopier scriptet.
1. Log ind på redigeringssiden på dit websted.
1. Gå til afsnittet, hvor du kan redigere eller tilføje HTML-kode.
1. Indsæt JavaScript for din chatwidget i koden på din webside.
1. Gem, opgrader eller udgiv ændringerne (dette afhænger af, hvilket system du bruger).
1. Åbn eller opdater din webside.

Chatwidgetten er nu tilgængelig og live. Besøgende på dit websted kan begynde at chatte med dig.

> [!NOTE]
> Når du aktiverer chatfunktionen, skal din organisation være klar til at håndtere alle indgående chatsamtaler.
>
> Parameteren *DEFER* sikrer, at dette script ikke blokerer for åbning af en side. Scriptet kører, efter at siden er indlæst.

## Video: tilføj chatwidgetten

Se denne demo for at se, hvordan du tilføjer chatwidgetten til dit websted.
(Denne video viser en tidligere version af SuperOffice, så designet kan se anderledes ud. Trinene er de samme.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Q-i8nxHqAPc]

(videoens længde - 2:04)

## Relateret indhold

* [Knyt chat til dit kundecenter][3]
* [Kunstig intelligens-tjenester][2]

<!-- Referenced links -->
[1]: channel-create.md
[2]: ../../ai/learn/index.md
[3]: ../../customer-center/learn/enable-chat.md
