---
uid: help-da-service-screen-properties
title: Egenskaber for skærmbillede
description: Egenskaber for skærmbillede
author: SuperOffice RnD
date: 06.29.2022
keywords: skærmbillede
topic: reference
language: da
---

# Egenskaber for skærmbillede

Her kan du redigere egenskaberne for et skærmbillede. Du kan blandt andet oprette script til forudberegning af variabler, gerne baseret på Cgi-variabler, som skærmbilledet har fået via en webadresse, eller en post fra en formular i det aktuelle skærmbillede eller et andet skærmbillede.

## Egenskaber

* **Mappe:** Hvis du har organiseret skærmbillederne i en mappestruktur, skal du klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og vælge en mappe.
* **Navn**: Et beskrivende navn på skærmbilledet.
* **Id-streng**: En streng, der entydigt identificerer dette skærmbillede, så der kan henvises til det i webadresser
* **Godkendelsesnøgle**: Det er muligt at køre et eget defineret skærmbillede uden at være logget ind som bruger. For at gøre dette skal du angive en godkendelsesnøgle.
* **Advar ved navigering**: Advar, når brugeren navigerer væk fra siden, og den indeholder ikke-gemte data.
* **Brug automatisk gemning**: Aktivér funktionen til [automatisk lagring][1].

## Scripts

* **Indlæsningsscript (før setFromCgi)**: Dette script køres, før skærmelementerne tildeles deres værdier
* **Indlæsningsscript (efter setFromCgi)**: Dette script køres, efter at skærmelementerne tildeles deres værdier
* **Indlæs script (køres efter alt andet)**: Dette script køres helt til sidst, efter at script og kode for eventuelle knapper er kørt.
* **Skjult variabel**: Variablerne, der er defineret her, gemmes, når skærmbilledet tilføjes, således at det næste skærmbillede har adgang til disse variabler.

<!-- Referenced links -->
[1]: ../../../request/learn/create.md
