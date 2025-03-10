---
uid: help-da-flow-participants
title: Flowdeltagere
description: Et komplet overblik over alle deltagere inden for flowet.
keywords: Marketing, flow, flowdeltager, deltager
author: Bergfrid Dias, Trude Lien Smedbråten
date: 12.11.2024
version: 10.3.5
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Flowdeltagere

## Trin

For at se listen over deltagere for et specifikt flow:

1. Gå til **Marketing** > **Flows**.
2. Klik for at vælge et flow.
3. Vælg fanen **Deltagere**.
4. Vælg eventuelt, hvad listen skal grupperes efter.

![Flow-deltagerliste -screenshot][img1]

Brug tandhjulet (<i class="ph ph-gear" aria-hidden="true"></i>) i listen's header til at tilpasse kolonnerne.

![Flow-deltagerliste, tilpas kolonner -screenshot][img2]

## Deltagerstatus

| Status | Beskrivelse |
|---|---|
| I gang | Deltageren er aktiv i flowet. |
| Afsluttet | Deltageren har gennemført alle trin i flowet. |
| Afsluttet med succes | Deltageren har gennemført flowet og opfyldt succeskriteriet. Inkluderet i flowets succesrate. |
| Frafald | Deltageren er frafaldet, altid med en specificeret frafaldsårsag. |
| Annulleret | Deltageren vil ikke fuldføre flowet, fordi en administrator afsluttede flowet. |

## <a id="logic"></a>Tilmelding og progression gennem flowet

Før hvert trin revurderer SuperOffice CRM, om deltageren kan fortsætte.

For alle trin-typer:

1. Er deltagerens status *I gang*?
2. Opfylder deltageren det definerede succeskriterium?
3. Er personen markeret som fratrådt?
4. Er personen tilføjet til udelukkelseslisten?

​Yderligere for e-mail trin:​

1. Er deres samtykke gyldigt?​
2. Er personen abonneret på flow-abonnementstypen?
3. Har personen en registreret e-mailadresse?​
4. Er e-mailadressen allerede aktiv i flowet?​
5. Er e-mailadressen ikke blokeret?​

Yderligere for SMS trin:​

1. Har personen et registreret mobilnummer til SMS?

### Hvordan påvirker succeskriterier tilmelding

* Personer, der allerede opfylder succeskriterierne, vil stadig blive tilføjet til flowet og talt som succeser. Deres progression gennem flow-trinene afhænger af konfigurationen.

* Personer, der opfylder succeskriterierne efter at have gennemført et flow, vil ikke blive inkluderet i flowets succesrate, da det skete efter deres aktive deltagelse.

### Hvilken gren vil en deltager følge?

I en opdeling følger deltagerne den første (venstre) gren, hvor de opfylder de specificerede betingelser.

## Opgaver

* Tilføj til udvalg: Inkluderer deltageren i et statisk udvalg.
* Tilføj til flow: Angiver, at denne person foreslås til tilmelding i et andet flow.
* Fjern fra flow: Fjerner alle registreringer af personens deltagelse i det nuværende flow.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-participants.png
[img2]: ../../../../media/loc/en/marketing/flow-participant-columns.png
