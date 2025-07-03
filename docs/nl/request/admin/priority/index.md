---
uid: help-nl-request-priority
title: Verzoekprioriteiten
description: Verzoekprioriteiten
keywords: verzoek, prioriteit, escaleren
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/request/learn/priority/index
index: true
---

# Verzoekprioriteiten

Alle verzoeken die in SuperOffice zijn geregistreerd, worden toegewezen aan een prioriteit die het belang van het verzoek weerspiegelt.

De standaardprioriteiten in het systeem zijn **Hoog**, **Gemiddeld** en **Laag**. U kunt echter zowel nieuwe prioriteiten toevoegen als de instellingen van bestaande prioriteiten bewerken.

De prioriteit van een verzoek kan bijvoorbeeld worden bepaald door:

* De persoon
* Het bedrijf
* De postbus
* Een e-mailfilter

Nadat een prioriteit is toegewezen aan een verzoek, kan deze worden gebruikt om een escalatie van het verzoek te beheren.

Bijvoorbeeld: u kunt instellen dat alle verzoeken van een bepaald bedrijf VIP-prioriteit moeten hebben en dat u per e-mail een melding wilt ontvangen wanneer het verzoek niet binnen een bepaalde tijd is gelezen.

## Volgorde van overschrijven

Prioriteiten overschrijven elkaar in deze volgorde:

1. Prioriteit opgegeven voor een e-mailfilter
1. Prioriteit opgegeven voor een persoon
1. Prioriteit opgegeven voor een bedrijf
1. Prioriteit opgegeven voor een postbus
1. Standaardprioriteiten

Door deze volgorde krijgt een verzoek van een persoon met een hoge prioriteit altijd voorrang, zelfs als de postbus een lage prioriteit heeft.

## Escalatie

Voor verzoeken kunt u een onbeperkt aantal prioriteiten definiëren. Voor elke prioriteit kunt u escalatieniveaus instellen, zodat het systeem het verzoek automatisch escaleert als het niet binnen een bepaalde tijd is gelezen of verwerkt.

Bijvoorbeeld: gebruikersondersteuning en SLA-overeenkomsten kunnen vereisen dat een leverancier binnen 2 uur begint met het oplossen van een probleem. U kunt dan instellen dat verzoeken worden geëscaleerd en aan een nieuwe behandelaar worden toegewezen als ze niet binnen de opgegeven tijd zijn verwerkt. U kunt meerdere escalaties instellen en meldingen ontvangen via e-mail of telefoon.

## Toegankelijkheid

Elke prioriteit heeft een toegankelijkheidsinstelling. Als de prioriteit op **Extern** is ingesteld, is deze toegankelijk via het SuperOffice Customer Centre.

Als er meer dan twee externe prioriteiten beschikbaar zijn, kan de klant de prioriteit van zijn verzoek zelf kiezen. Dit kan ertoe leiden dat klanten altijd de hoogste prioriteit selecteren om sneller een antwoord te krijgen. Daarom is het verstandig om de hoogste prioriteiten als **Intern** in te stellen en alleen **Gemiddeld** en **Laag** extern beschikbaar te maken.

## Gerelateerde inhoud

* [Prioriteit maken][1]
* [Prioriteiten verwijderen][2]
* [Escalatieniveaus maken][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md
