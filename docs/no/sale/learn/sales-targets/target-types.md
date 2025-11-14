---
uid: help-no-sales-target-types
title: Sette opp en salgsmåltype med undertyper
description: Å holde seg oppdatert på salgsmålene dine kan være stressende. Men hvis du definerer parametere og dimensjoner for salgsmålene dine, blir det mye enklere å administrere målene.
keywords: salgsmål, dimensjon
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: howto
license: salespremium, Unlimited sales targets
functional_right: Targets administrator
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Sette opp en salgsmåltype med undertyper

Å holde seg oppdatert på salgsmålene dine kan være stressende. Men hvis du definerer parametere og dimensjoner for salgsmålene dine, blir det mye enklere å administrere målene.

Som standard inneholder SuperOffice én måltype: **Alle salg – Beløp**. Du kan legge til tilpassede måltyper basert på salgsdata, firmaopplysninger eller brukerdefinerte felt.

## Krav

Du må ha den funksjonelle rettigheten **Targets administrator** for å legge til, redigere eller slette måltyper.

> [!NOTE]
> For å legge til måltyper trenger du lisensen Unlimited sales targets i tillegg til Sales Premium-lisensen.

## Tilgjengelige måltyper

En **måltype** definerer hva du vil måle. Du kan velge mellom følgende systemdefinerte dimensjoner:

* Alle salg
* Salgstype
* Salg kilde
* Salg kreditert
* Salg konkurrent
* Firma kategori
* Firma bransje
* Firma land

Du kan også bruke dine egne brukerdefinerte felt, forutsatt at de inneholder listeverdier.

**Hver dimensjon kan kun brukes én gang for å unngå duplikater.**

## Legg til en ny måltype

1. Klikk <i class="ph ph-list" aria-label="Hovedmeny"></i> og velg **Mål**.

1. I **Mål**-skjermen, klikk **Legg til ny måltype** for å definere en tilpasset salgsdimensjon. Du kan også klikke <i class="ph ph-gear" aria-label="Tannhjul"></i> (**Konfigurer mål**) på en eksisterende fane for å redigere den.

    ![Mål-skjermen med Legg til ny måltype-knappen -screenshot][img4]

1. Klikk **Måltype** for å velge dimensjonen du vil spore, som **Salgskilde** eller **Firmakategori**.

    ![Målinnstillinger-dialog for å opprette en ny måltype -screenshot][img1]

1. Klikk **Måleenhet** for å velge hvordan resultater beregnes:

    * **Beløp:** Total verdi av salg
    * **Antall:** Antall salg
    * **Fortjeneste:** Fortjenestemargin

    Alternativene avhenger av den valgte måltypen.

1. Under **Separate mål**, velg spesifikke undertyper som skal spores separat. Alternativene avhenger av den valgte måltypen.

    For eksempel, hvis måltypen er **Kategori**, er undertypene firmakategoriene dine.

1. Velg avkrysningsboksen **Tilgjengelig kun på firmanivå og gruppenivå** hvis denne måltypen ikke skal være tilgjengelig på brukernivå.

1. Klikk **Lagre**. Måltypen legges til som en fane. Du kan nå [legge til grupper og brukere i salgsmålet ditt][3].

## Fjerne en måltype

For å slette en måltype:

1. Åpne **Målinnstillinger** fra den relevante fanen.
2. Klikk **Slett**.

> [!WARNING]
> Å slette en måltype fjerner permanent alle relaterte data for alle år - tidligere, nåværende og fremtidige. Du kan ikke slette standardtypen **Alle salg – Beløp**.

## Tips og feilsøking

* Etter lagring kan måltypen og måleenheten ikke endres. For å justere disse innstillingene, opprett en ny måltype og slett den gamle.

* Du kan redigere listen **Separate mål** og avkrysningsboksen **Tilgjengelig kun på firmanivå og gruppenivå** etter lagring.

    > [!NOTE]
    > Hvis du aktiverer tilgjengelighet kun på firma/gruppe-nivå etter å ha angitt verdier på brukernivå, vises en advarsel. Å lagre denne endringen vil slette målene på brukernivå.

## Aktuelle emner

* [Legg til grupper og brukere i salgsmålet ditt][3]
* [Bruke salgsmål i dashboard-figurer][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/target-settings.png
[img4]: ../../../../media/loc/en/sale/add-new-target-type-button.png
