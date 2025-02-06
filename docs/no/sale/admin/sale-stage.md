---
uid: help-no-sale-stage-add
title: Legge til en salgsfase
description: Legge til en salgsfase
keywords: legg til salgsfase, ny salgsfase, listen Salg – Fase, salgsfase, fase, salg
author: Bergfrid Dias
date: 02.03.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Salgsfase

[!include[Må være administrator](../../learn/includes/req-admin.md)]

Feltet **Fase** i Salg-bildet viser hvilken fase et salg befinner seg i, for eksempel "Åpent", "Solgt" eller "Tapt". Disse fasene er forhåndsdefinert i listen **Salg – Fase**, som du finner under **Lister** i **Innstillinger og vedlikehold**.

Faser kan knyttes til [salgstyper][1] for å angi hvilke faser som er tilgjengelige for hver type. Hvis det ikke er definert en salgsguide, vil feltet **Fase** fortsatt være synlig i Salg-bildet, slik at brukerne kan se og oppdatere salgets gjeldende fase.

## Legge til en salgsfase

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **Salg – Fase** fra rullegardinmenyen. Fanen **Elementer** viser alle eksisterende faser.

1. Klikk på **Legg til** for å åpne dialogboksen **Rediger listeelement**.

1. Skriv inn navnet på den nye fasen i feltet **Navn**. *(Obligatorisk)*

    Dette navnet vil vises i feltet **Fase** i Salg-bildet.

1. I feltet **Sannsynlighet** angir du sannsynligheten for et vellykket salg i denne fasen, som en prosentverdi.

    Denne verdien vises ved siden av fasen i Salg-bildet.

1. *(Valgfritt)* Legg til en beskrivelse i feltet **Beskrivelse** for å forklare formålet med fasen.

1. Klikk på **Lagre** for å lagre endringene eller **Avbryt** for å forkaste dem.

## Redigere eller slette en salgsfase

1. Følg trinn 1–2 i **Legge til en salgsfase** for å åpne listen **Salg – Fase**.

1. For å redigere:
   1. Dobbeltklikk på ønsket fase for å åpne dialogboksen **Rediger listeelement**.
   1. Oppdater feltene etter behov og klikk **Lagre**.

1. For å slette:
   1. Velg fasen i listen og klikk **Slett**.

    > [!CAUTION]
    > Hvis du sletter en fase, fjernes den fra alle tilknyttede salgstyper og salgsguider. Kontroller at fasen ikke er i aktiv bruk før du fortsetter.

## Gjenopprette en slettet salgsfase

Hvis en salgsfase har blitt slettet, kan du gjenopprette den fra listen **Salg – Fase**. Merk at gjenoppretting ikke automatisk gjenoppretter koblinger mellom den gjenopprettede fasen og tilhørende salgstyper eller guider. Disse må settes opp manuelt om nødvendig.

Fremgangsmåten ligner på [gjenoppretting av en slettet salgstype][2].

## Relatert innhold

* [Legge til eller oppdatere salgstyper][1]
* [Opprette en salgsguide][3]
* [Redigere en salgsguide][4]
* [Følge opp salgsprosessen][5]

<!-- Refererte lenker -->
[1]: sale-type.md
[2]: sale-type.md#restore
[3]: create-sales-guide.md
[4]: edit-sales-guide.md
[5]: ../learn/sales-guides.md#change-stage
