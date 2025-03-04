---
uid: help-da-flows
title: Marketing automation - flows
description: Introduktion til SuperOffice Marketing automatisering og flows.
keywords: Marketing, flow, kundesegment, kunderejse, kommunikation
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.17.2024
version: 10.3.9
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Marketing automation - flows

Forestil dig at kunne levere den perfekte e-mail til dit publikum præcis, når de har brug for det. Relevante e-mails øger ikke kun chancerne for at blive læst, men påvirker også engagementet med dine call-to-action (CTA) links og styrker kundens forhold. Med marketing automation kan du tilpasse e-mails til specifikke kundesegmenter baseret på deres position i salgsprocessen, produktinteresser, engagementsniveau og meget mere.

Men det stopper ikke der. Adresser kommunikationsudfordringer på tværs af alle stadier i kunderejsen.

* Forbedr hele kunderejsen​: Fang og pleje leads; Upsell/cross-sell til eksisterende kunder; Faciliter onboarding og adoption; Strømlin event-tilmeldingsprocesser; Send påmindelser.

* Vær relevant med mindre manuelt arbejde​: Nå både potentielle og eksisterende kunder fra det samme værktøj; Brug triggere og filtre til at skabe segmenterede dryp-kampagner; Få dybere indsigt i marketingaktiviteter​.

* Udnyt CRM-data til målrettede marketingindsatser: Segmenter dit publikum og lever skræddersyet information ved hjælp af CRM-data; Forstå kundebehov og skab personlige rejser.

* Juster marketing og salg​: Automatiser håndtrykket mellem marketing- og salgsteams ved at forbinde CRM-aktiviteter og meddelelser​; CRM-aktiviteter kan påvirke igangværende automation​; Sikre gennemsigtighed mellem marketing, salg og service​.

* Rapportering fra lead til indtægt​: Bevis effekten af marketingindsatser ved at forbinde marketing- og salgsrapporter.

Træk og slip flowdesigner er dit værktøj til at bygge disse dynamiske flows.

![Træk og slip-flowdesigner -screenshot][img2]

## <a id="ex"></a>Use cases

* **Byde nye kunder velkommen:** Send personlige e-mails, rabatter og del din brandhistorie. Støt onboarding af nye produkter.
* **Engagement-kampagner:** Hold aktive kunder engagerede og informerede med relevant indhold, produktopdateringer og eksklusive tilbud.
* **Up/cross sell kampagner:** Anbefal relaterede varer baseret på købshistorik eller adfærd for at øge indtægterne.
* **Event-tilmeldingsprocesser:** Inkluder person via SMS, webinar-påmindelser og opfølgning.

## Hvad er et flow

Et flow er en automatiseret sekvens af marketing-relaterede trin, såsom at sende en besked, opdatere deltageroplysninger eller oprette en aktivitet.

En **trigger** fungerer som flowets startpunkt og definerer HVORNÅR en person foreslås som deltager i et flow. For eksempel, når en person indsender en [Person mig formular][9]. Du kan også [manuelt tilmelde SuperOffice personer][4].

Yderligere **filtre** anvendes derefter for at afgøre, om personen tilhører det segment, flowet målretter mod. Filtre afgør HVEM der tilføjes som deltagere. For eksempel et lead-capturing flow, der kun målretter potentielle kunder og ikke eksisterende kunder.

Efter tilmelding skrider deltagerne frem langs den definerede sti. Efter at have fuldført et trin, går de videre til det næste. Deltagerstatus revurderes før enhver handling i et trin. Læs mere om [tilmelding og flow-logik][5].

## Workflow

Marketing automation følger omtrent denne workflow:

1. Planlæg din kommunikation​.
1. [Opret indholdet​.][7]
1. [Byg flowet.][1]
1. [Definer trin og handlinger.][6]
1. Sæt mål og spor succes.
1. [Overvåg og analysér​.][3]

Flows understøtter forskellige måder at arbejde på​. Planlæg og opret indhold før flowet er sat op, og forbind derefter allerede forberedt indhold til et specifikt flow. Eller, begynd med at sætte flowet op og lad plads til e-mails, som vil komme fra indholdsskribenter senere.

## Hvor finder man flows

SuperOffice Marketing har én fane, der vedrører flows.

![Marketing Flows panel -screenshot][img1]

**Flows fanen** giver dig mulighed for at oprette nye flows og se tidligere oprettede. Brug den sekundære række af faner (Alle, Seneste, I gang) og søgefeltet for at udforske de tilgængelige flows. Dobbeltklik på et flow for at se detaljer om det.

Vælg mellem liste eller flise **visningstilstand** i nederste højre hjørne.

| Ikon | Tilstand | Beskrivelse |
|:-:|---|---|
| ![ikon][img9] | Flise (thumbnail) | Viser et miniaturebillede af hvert flow med essentielle data. Klik på <i class="ph ph-list" aria-label="Task menu"></i> for at åbne, redigere, kopiere eller slette flowet. |
| ![ikon][img8] | Liste (arkiv, gitter) | Viser en liste over alle flows med information præsenteret i kolonner. Du kan gruppere, filtrere og tilpasse kolonnerne ligesom i [sektion faner][12]. Højreklik for at åbne kontekstmenuen for at åbne, redigere, kopiere eller slette flowet. |

## <a id="view"></a>Vis flow-skærmen

Øverst kan du se flowets navn og dets placering inden for mappestrukturen. Du har følgende muligheder:

| Mulighed | Beskrivelse |
|---|---|
| I gang | Skift denne skydeknap for at starte eller pause flowet. |
| Rediger | Åbner flowet i redigeringstilstand. |

Skærmen **Vis flow** består af følgende faner:

* **Oversigt:** Giver grundlæggende information om flowet og forskellige statistikker.
* **Flow:** Tilbyder en skrivebeskyttet visning af flowet, der tillader brugere at få et overblik uden at pause og redigere flowet. Klik på et trin for at se detaljerne.
* **Rapporter:** Viser diagrammer med statistikker for flowet, brugt til at overvåge dets ydeevne.
* **Deltagere:** Præsenterer en liste over alle deltagere i flowet, der viser deres e-mailadresse, firmasaffiliation, tilmeldingsdato, nuværende status, nuværende trin, sidste afsendte, dato for sidste afsendte og status for sidste afsendte.
* **Flowindhold:** Indeholder flow mailinger og formularer brugt af flowet.

## <a id="success"></a>Succeskriterier

Succeskriterier etablerer parametrene for at bestemme flowets succes. For eksempel:

* Person opdateret
* Salg oprettet på person eller firma
* Aftale oprettet
* Sag oprettet
* Deltager tilføjet til udvalg eller projekt
* Formular indsendt
* Link klikket

Ved at definere succeskriterier kan du vurdere flowets effektivitet: Opnår vi vores mål, mens personen forbliver engageret i flowet? **Succesrate** repræsenterer procentdelen af tilmeldte deltagere i flowet, der fuldfører det med opfyldte succeskriterier.

Et succeskriterium kan indebære en ændring i en persons kategori (såsom overgang til en salgsmoden lead), mens de er engageret i flowet. Alle interaktioner med personen bidrager til denne ændring.

Enhver medarbeider kan opfylde succeskriterier ved at ændre data i CRM-databasen. Flow-automation vil reagere passende, uanset hvordan succeskriterierne blev opfyldt. Uanset om data opdateres automatisk af flowet eller manuelt af en salgsrepræsentant, fungerer systemet konsistent.

Ved opfyldelse af et succeskriterium kan kampagnen enten stoppe eller fortsætte for deltageren. I begge tilfælde anses deltageren for at være succesfuld. Du kan bestemme, om disse succesfulde deltagere skal overgå til et mere relevant flow.

Det er tilrådeligt for de fleste automatiserede flows at sætte succeskriterier for tilmeldte deltagere. Det er dog ikke obligatorisk at definere sådanne kriterier.

## <a id="req"></a>Krav

* Marketing Premium licens (ny tier)
* Sales essential eller premium - for at oprette et salg
* Service essential eller premium - for at oprette en sag
* SMS connector - for at sende SMS

### Funktionelle rettigheder

Adgang til flows og flowindhold styres af en brugers rolle og [funktionelle rettigheder][11].

| Handling | Flow administrator | Kan redigere flowindhold |
|---|:-:|:-:|
| Se flow | X | X |
| Opret/rediger flowindhold | X | X |
| Slet flowindhold | X | |
| Opret/rediger flow (åbn flow-editor, gem) | X | |
| Kør/pause/stop flow | X | |

## Relateret indhold

* [Opret flow][1]
* [Sådan kører, pauser og stopper du et flow][2]
* [Se statistikker][3]

<!-- Referenced links -->
[1]: create.md
[2]: run-pause-end.md
[3]: view-statistics.md
[4]: participants.md
[5]: participants.md#logic
[6]: define-flow-actions.md
[7]: content.md
[9]: ../../forms/learn/tutorial-contact-me.md
[11]: ../../../admin/user-management/learn/role/functional-rights.md
[12]: ../../../learn/section-tabs/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flows-panel.png
[img2]: ../../../../media/loc/en/marketing/flow-editor-with-step-menu.png
[img8]: ../../../../../common/icons/view-list.png
[img9]: ../../../../../common/icons/view-thumbs.png
