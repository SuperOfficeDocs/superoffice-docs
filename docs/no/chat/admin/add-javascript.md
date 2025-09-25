---
uid: help-no-chat-add-javascript
title: Legg til JavaScript for websiden
description: Live Chat er en populær måte for kunder og potensielle kunder å komme i kontakt med deg når de besøker websiden din. Denne guiden viser deg hvordan du legger til en chat-widget på websiden din.
keywords: chat JavaScript
author: SuperOffice Product and Engineering
date: 09.25.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
redirect_from: /no/chat/learn/admin/add-javascript
index: true
---

# Legg til JavaScript for websiden

Hvis du vil gjøre chatfunksjonen tilgjengelig for kundene, må du legge til JavaScript på de relevante sidene på websiden din. Hvis du har satt opp flere chatkanaler, har hver kanal et bestemt JavaScript som legges til på den eller de relevante sidene.

Nå som du har [konfigurert chatwidgeten][1], viser dette trinnet hvordan du legger den til på websiden din.

## Trinn

1. [!include[Go to](../../learn/includes/goto-sm.md)]
1. Velg <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chat** i navigatoren.
1. Velg en chatkanal i listen, og klikk deretter på **Vis**. JavaScript for den valgte chatkanalen vises.
1. Velg og kopier skriptet.
1. Logg inn på redigeringsprogrammet på websiden din.
1. Gå til den delen der du kan redigere eller legge til HTML-kode.
1. Lim JavaScript for kontrollprogrammet til chat inn i koden til nettsiden din.
1. Lagre, oppgrader eller publiser endringene (dette avhenger av hvilket system du bruker).
1. Åpne eller oppdater websiden.

Chatvinduet er nå tilgjengelig og live. Besøkende på websiden din kan begynne å chatte med deg.

> [!NOTE]
> Når du aktiverer chat-funksjonen, må organisasjonen være klar til å håndtere alle innkommende chatsamtaler.
>
> Parameteren *DEFER* sikrer at dette skriptet ikke blokkerer åpning av en side. Skriptet kjøres etter at siden er ferdig lastet.

## Video: legg til chatwidgeten

Se denne demoen for å se hvordan du legger til chatwidgeten på websiden din.
(Denne videoen viser en tidligere versjon av SuperOffice, så designet kan se annerledes ut. Trinnene er de samme.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Q-i8nxHqAPc]

(videolengde – 2.04)

## Relatert innhold

* [Koble chatten til Kundesenter][3]
* [Tjenester for kunstig intelligens][2]

<!-- Referenced links -->
[1]: channel-create.md
[2]: ../../ai/learn/index.md
[3]: ../../customer-center/learn/enable-chat.md

<!-- Referenced images -->
