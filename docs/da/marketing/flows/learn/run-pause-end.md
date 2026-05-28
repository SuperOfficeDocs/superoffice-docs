---
uid: help-da-flow-run-pause-end
title: Køre, pause og afslutte flow
description: Sådan kører, pauser, genoptager, afslutter og sletter en SuperOffice Marketing automation-strøm.
keywords: Marketing, flow
author: Bergfrid Dias, Trude Lien Smedbråten
date: 05.28.2026
version: 11.12
content_type: howto
category: marketing
topic: flows
license: marketingpremium
tier: plus
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Køre, pause og afslutte flow

## <a id="status"></a>Flowstatus

* **Stoppet:** Repræsenterer et nyt flow, der ikke er startet (eller et afsluttet flow). Triggere er ikke aktiveret.

* **I gang:** Ingen ændringer er tilladt, mens flowet er i gang. Automatiske triggere er aktiveret, og deltagere tilføjes til flowet.

* **På pause:** Triggere forbliver aktiveret. Deltagere tilføjes til flowet, men de afventer bevægelse til det første trin. Eksisterende deltagere forbliver på deres nuværende trin, når flowet er pauset. Denne status bruges, når man foretager ændringer eller forbedringer af et flow. På **CRM Suite-planer** anses et pauset flow stadig som aktivt, fordi det fortsætter med at indsamle indkommende kontakter til efterfølgende behandling og tæller mod grænsen for aktive flows.

![Marketing flows med forskellige status og statistik -screenshot][img1]

## Start flow for første gang

For at starte et nyt flow:

1. Gå til **Marketing** > **Flows**.
2. Vælg det flow, du ønsker at starte.
3. I headeren, skift knappen til **ON**. Status ændres til **I gang**.

Dette aktiverer flowets triggere. Nye deltagere tilføjes til flowets deltagerliste baseret på disse triggere. Flowdeltagere vil bevæge sig gennem flowet, handlinger vil blive udført, indtil de opfylder flowets succeskriterier, når afslutningstrinnet eller falder fra.

## Pause flow

For midlertidigt at stoppe et flow der er i gang:

1. Åbn det flow, du ønsker at pause.
2. I headeren, skift knappen til **OFF**. Status ændres til **På pause**.

* Denne handling fryser den aktuelle status for alle deltagere, som forbliver på deres nuværende trin.
* **Triggere forbliver aktive**, hvilket får deltagerlisten til at fortsætte med at vokse. Nye deltagere tilmeldes, men placeres i en kø.
* **Rediger**-knappen er tilgængelig, hvilket giver flowadministratorer mulighed for at opdatere flowet (med nogle begrænsninger).

## Genoptag flow (på pause > i gang)

For at genstarte et pauset flow, skift knappen til **ON** i **Vis flow**-skærmen.

* Alle deltagere vil fortsætte fra det trin, de var på, da flowet blev pauset.
* Deltagere, der tilmeldte sig og blev køet under pausen, vil bevæge sig til det første trin.
* Eventuelle ændringer i flowet vil gælde for en deltager, hvis de endnu ikke er gået videre fra det relevante trin.

## Afslut flow

For at afslutte flowet:

1. Åbn flowet.
2. Vælg **Opgave** > **Afslut flow**.

* Flowets status ændres til **Stoppet**.
* Alle triggere for dette flow deaktiveres, og tilmelding ophører. Ingen nye deltagere vil blive tilføjet til flowet.
* Aktive deltagere får status = *Annulleret*. De vil ikke fuldføre flowet.

> [!CAUTION]
> Denne opgave bør kun bruges til flows, der ikke længere er relevante. At afslutte et flow er ikke beregnet til mindre justeringer - brug i stedet pause. **Annullerede deltagere vil ikke fortsætte flowet, hvis du beslutter at køre det igen.**

Hvis flowet startes igen efter afslutning, går kun nye deltagere gennem flowet, gamle deltagere beholder status Annulleret.

## <a id="delete"></a>Slet flow

1. Pause flowet. Flowets status ændres til **På pause**.
1. Afslut flowet. Status ændres til **Stoppet**.
1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Opgavemenu"></i> og vælg **Slet flow**.
1. Bekræft handlingen.

Denne mulighed er tilgængelig både i **Vis flow**-skærmen og i oversigten over alle flows.

## Fejlfinding

### Kan ikke køre flow

Alle nødvendige indstillinger skal være gyldige, før flowet kan køre. For eksempel kan et flow med et e-mail trin ikke køre, hvis e-mail indstillinger som fra-adresse eller svar-adresse mangler. Kig efter advarselsikonet - tooltip beskriver problemet.

### Kan ikke slette flow

Du kan ikke slette et flow, der er i gang. Først skal du pause flowet. Derefter skal du afslutte flowet, så status ændres til **Stoppet**. Til sidst skal du klikke på <i class="ph ph-dots-three-circle-vertical" aria-label="Opgavemenu"></i> og vælge **Slet flow**.

### Grænsen for aktive flows er nået (CRM Suite)

På **Plus**-planen kan din organisation have maksimalt 10 aktive flows på samme tid. Både kørende og pausede flows tæller med i denne grænse.

Når grænsen er nået:

* Til/fra-knappen **I gang** er ikke tilgængelig for flows, der ikke kører.
* Flowets sidehoved viser det aktuelle antal, for eksempel *10 af 10 aktive flows*.
* Hvis du holder musen over den utilgængelige til/fra-knap, vises: *Du har nået grænsen på 10 kørende flows, der er tilladt på Plus-pakken. Stop venligst nogle kørende flows, før du starter andre, eller opgradér til Super-pakken.*

For at frigøre kapacitet skal du afslutte nogle flows, så deres status ændres til **Stoppet**. Hvis du har brug for flere aktive flows, skal du opgradere til **Super**-planen. Se [Plangrænser][2].

## Relateret indhold

* [Opdater flow][1]

<!-- Referenced links -->
[2]: ../../../admin/license/crm-suite.md
[1]: update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-status.png
