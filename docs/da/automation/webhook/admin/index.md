---
uid: help-da-webhook-panel
title: Webhooks-panel
description: Se, administrer og overvåg webhooks fra Indstillinger og vedligeholdelse.
keywords: webhook-panel, webhook-status, deaktiveret webhook, genstart webhook, overvåg webhooks
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
language: da
---

# Webhooks-panel

Webhooks-panelet er det centrale sted for administratorer og konsulenter til at administrere webhook-abonnementer i SuperOffice. Du finder det under **Indstillinger og vedligeholdelse** > **System design** > **Webhooks**.

Fra dette panel kan du se tilstanden for alle webhooks på et øjeblik, oprette nye abonnementer, redigere eksisterende og gendanne webhooks, der er blevet automatisk deaktiveret på grund af leveringsfejl.

![Oversigt over Webhooks-panel i Indstillinger og vedligeholdelse -screenshot][img1]

## Webhook-listen

Listen viser alle registrerede webhooks. Du kan sortere og filtrere efter enhver kolonne.

| Kolonne | Beskrivelse |
| --- | --- |
| Navn | Webhookens visningsnavn. |
| Status | Statusmærke der viser den aktuelle tilstand. |
| Antal begivenheder | Antallet af hændelsestyper, som webhook'en abonnerer på. |
| Mål-URL | Destinations-URL eller CRMScript-navn. |
| Seneste begivenhed | Tidsstempel for det seneste leveringsforsøg. |
| Flere på hinanden følgende fejl | Antal på hinanden følgende leveringsfejl i de seneste 24 timer. |
| Opdateret af | Hvem der sidst ændrede webhook'en. |

Hold musemarkøren over en række for at se det fulde navn i kolonnen Opdateret af.

## Statusmærker

Hver webhook har et statusmærke, der viser den aktuelle tilstand.

| Status | Farve | Betydning |
| --- | --- | --- |
| Aktiv | Grøn | Kører uden fejl i de seneste 24 timer. |
| Aktiv med fejl | Gul | Kører, men har haft leveringsfejl i de seneste 24 timer. |
| Stoppet | Grå | Manuelt stoppet af en administrator. |
| Deaktiveret | Rød | Automatisk deaktiveret af systemet efter 9 på hinanden følgende leveringsfejl. |

## Kontekstmenuhandlinger

Højreklik på en webhook-række for at få adgang til følgende handlinger.

| Handling | Beskrivelse |
| --- | --- |
| Rediger | Åbner webhook-formularen med alle aktuelle værdier udfyldt. |
| Kopier | Opretter en kopi med "(copy)" tilføjet til navnet. Kopien oprettes i tilstanden Stoppet. |
| Aktiver/stop | Starter eller stopper levering for webhook'en. |
| Genstart | Genaktiverer en deaktiveret webhook. Vises kun, når webhook-status er Deaktiveret. |
| Slet | Fjerner permanent webhook'en. En bekræftelse vises inden sletning. |

## Leveringshistorik

Vælg en webhook-række for at åbne detaljepanelet. Fanen **Hændelser** viser en leveringslog pr. webhook.

| Kolonne | Beskrivelse |
| --- | --- |
| Tidsstempel | Hvornår leveringen blev forsøgt. |
| Status | Resultatet af forsøget. |
| Forsøg | Antal leveringsforsøg for denne hændelse. |
| Fejlkode | Den fejl, der blev returneret, hvis leveringen mislykkedes. |

Du kan prøve individuelle mislykkede hændelser igen direkte fra listen og eksportere den fulde liste til CSV.

## Automatisk deaktivering og gendannelse

Hvis en webhook modtager 9 på hinanden følgende leveringsfejl, deaktiverer systemet den automatisk. Rækken viser en fejltæller (for eksempel 7/9) og den seneste fejl.

For at gendanne en deaktiveret webhook:

1. Løs det problem, der forårsagede leveringsfejlene.
1. Højreklik på webhook-rækken og vælg **Genstart**.

Webhook'en vender tilbage til Aktiv-status og genoptager normal levering.

## Beskeder i SuperOffice

Notifikationsmodtagere ser en advarsel i SuperOffice, når en webhook automatisk deaktiveres. Vælg advarslen for at åbne Webhooks-panelet.

## Relateret indhold

* [Opret webhook][1]
* [Webhooks-udviklervejledning][2]

<!-- Referenced links -->
[1]: create.md
[2]: ../dev/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-system-design-webhook-overview.png
