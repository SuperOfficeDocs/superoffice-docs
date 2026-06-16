---
uid: help-no-webhook-panel
title: Webhooker
description: Vis, administrer og overvåk webhooks fra Innstillinger og vedlikehold.
keywords: webhook-panel, webhook-status, deaktivert webhook, genstart webhook, overvåk webhooks
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: concept
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
---

# Webhooker

Webhooker-panelet er det sentrale stedet for administratorer og konsulenter til å administrere webhook-abonnementer i SuperOffice. Du finner det under **Innstillinger og vedlikehold** > **System design** > **Webhooker**.

Fra dette panelet kan du se tilstanden for alle webhooks på ett øyekast, opprette nye abonnementer, redigere eksisterende og gjenopprette webhooks som har blitt automatisk deaktivert på grunn av leveringsfeil.

![Oversikt over Webhooker i Innstillinger og vedlikehold -screenshot][img1]

## Webhook-listen

Listen viser alle registrerte webhooks. Du kan sortere og filtrere etter hvilken som helst kolonne.

| Kolonne | Beskrivelse |
| --- | --- |
| Navn | Visningsnavnet for webhooken. |
| Status | Statusmerke som viser gjeldende tilstand. |
| Antall hendelser | Antall hendelsestyper webhooken abonnerer på. |
| Mål-URL | Destinasjons-URL eller CRMScript-navn. |
| Siste hendelse | Tidsstempel for siste leveringsforsøk. |
| Påfølgende feil | Antall påfølgende leveringsfeil de siste 24 timene. |
| Oppdatert av | Hvem som sist endret webhooken. |

## Statusmerker

Hver webhook har et statusmerke som viser gjeldende tilstand.

| Status | Farge | Betydning |
| --- | --- | --- |
| Aktiv | Grønn | Kjører uten feil de siste 24 timene. |
| Aktiv med feil | Gul | Kjører, men har hatt leveringsfeil de siste 24 timene. |
| Stoppet | Grå | Manuelt stoppet av en administrator. |
| Deaktivert | Rød | Automatisk deaktivert av systemet etter 9 påfølgende leveringsfeil. |

## Kontekstmenyhandlinger

Høyreklikk på en webhookrad for å få tilgang til følgende handlinger.

| Handling | Beskrivelse |
| --- | --- |
| Rediger | Åpner webhookskjemaet med alle gjeldende verdier forhåndsutfylt. |
| Kopier | Oppretter en kopi med "(copy)" lagt til navnet. Kopien opprettes i tilstanden Stoppet. |
| Aktiver/stopp | Starter eller stopper levering for webhooken. |
| Start på nytt | Aktiverer en deaktivert webhook på nytt. Vises bare når webhook-status er Deaktivert. |
| Slett | Fjerner webhooken permanent. En bekreftelse vises før sletting. |

## Leveringshistorikk

Velg en webhook-rad for å åpne detaljpanelet. Fanen **Hendelser** viser en leveringslogg per webhook.

| Kolonne | Beskrivelse |
| --- | --- |
| Tidsstempel | Når leveringen ble forsøkt. |
| Status | Resultatet av forsøket. |
| Forsøk | Antall leveringsforsøk for denne hendelsen. |
| Feilkode | Feilen som ble returnert hvis leveringen mislyktes. |

Du kan prøve individuelle mislykkede hendelser på nytt direkte fra listen og eksportere hele listen til CSV.

## Automatisk deaktivering og gjenoppretting

Hvis en webhook mottar 9 påfølgende leveringsfeil, deaktiverer systemet den automatisk. Raden viser en feilteller (for eksempel 7/9) og den siste feilen.

For å gjenopprette en deaktivert webhook:

1. Løs problemet som forårsaket leveringsfeilene.
1. Høyreklikk på webhook-raden og velg **Start på nytt**.

Webhooken returnerer til Aktiv-status og gjenopptar normal levering.

## Varsler i SuperOffice

Varslingsmottakere ser et varsel i SuperOffice når en webhook automatisk deaktiveres. Velg varselet for å åpne Webhooker-panelet.

## Relatert innhold

* [Opprett webhook][1]
* [Utviklerveiledning for webhooks][2]

<!-- Referenced links -->
[1]: create.md
[2]: ../../../../en/automation/webhook/dev/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-system-design-webhook-overview.png
