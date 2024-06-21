---
uid: help-no-specifying-advanced-import-settings
title: Angi avanserte importinnstillinger
description: Angi avanserte importinnstillinger
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Angi avanserte importinnstillinger

Avanserte importinnstillinger omfatter blant annet innstillinger for datoformat og feltskilletegn. Hensikten med dem er at SuperOffice skal tolke importfilen på riktig måte.

> [!NOTE]
> Hvis du skal kunne tilordne feltene fra importfilen riktig, kan det hende du må redigere innstillingene for tekstskilletegn, feltskilletegn og radskilletegn.

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Klikk på **Avansert**-knappen.

1. I dialogboksen **Avanserte alternativer** velger du et forhåndsdefinert format fra listeboksen **Datoformat**. Månedsnavn kan ikke brukes, bare tall.

    > [!NOTE]
    >**Native ID** betyr en SuperOffice-dato. SuperOffice teller sekunder siden 01.01.1970, og det er dette tallet som kalles **Native ID**.

1. I listeboksen **Nummerformatering** velger du blant de forhåndsdefinerte alternativene for desimalskilletegn.

1. I feltet **Avmerkingsboksformatering** skriver du inn tegnet/tegnene som i importfilen brukes til å angi at en avmerkingsboks er aktivert.

1. I feltet **Tekstskilletegn** skriver du inn det tegnet som i importfilen brukes til å angi at det som står mellom to slike, skal tolkes som ren tekst.

    > [!NOTE]
    > Tekstskilletegn overstyrer eventuelle felt- og radskilletegn (se nedenfor). Det vil for eksempel si at hvis et feltskilletegn forekommer mellom to tekstskilletegn, oppfattes det som ren tekst. Du er imidlertid ikke nødt til å bruke tekstskilletegn hvis ikke importfilene dine inneholder felt- eller radskilletegn.

1. I listeboksen **Feltskilletegn** velger du blant de forhåndsdefinerte alternativene for hvilke tegn som skal skille felt fra hverandre.

1. I listeboksen **Radskilletegn** velger du blant de forhåndsdefinerte alternativene for hvilke tegn som skal skille rader fra hverandre.

1. I listeboksen **Medarbeiderformatering** velger du blant de forhåndsdefinerte formatene for hvordan navn i importfilen skal tolkes, for eksempel om fornavn kommer før etternavn.

    > [!NOTE]
    >**Native ID** vil si medarbeiderens **associate_id**, som finnes i databasen. Hvis det ikke finnes noen slik ID, brukes innholdet i feltet **Standard medarbeider**.

1. I listeboksen **Standard medarbeider** velger du hvilket navn som skal settes inn som standard hvis SuperOffice-databasen ikke klarer å tolke medarbeiderformateringen i importfilen.

1. I listeboksen **Landformatering** velger du blant de forhåndsdefinerte formatene for hvordan land skal tolkes, for eksempel om landsnavnet er lokalt eller engelsk.

    > [!NOTE]
    >**Native ID** vil si **country_id**, som finnes i databasen.

1. I listeboksen **Standard landsnavn** velger du hvilket land som skal settes inn hvis SuperOffice-databasen ikke klarer å tolke landformateringen i importfilen.

1. I listeboksen **Valuta** velger du hvilken valuta som skal settes inn hvis SuperOffice-databasen ikke klarer å tolke valutaformateringen i importfilen.

1. Merk av for **Oppdater fritekstindeks** for at fritekstindeksen skal oppdateres fortløpende under import, slik at den er ferdig oppdatert når importen er ferdig.

    > [!NOTE]
    > Importhastigheten reduseres hvis du merker av for **Oppdater fritekstindeks**. Hvis du skal importere store mengder data, kan du kjøre importen uten dette valget avmerket, og senere [generere en ny fritekstindeks][2] fra **Systemvalg**-bildet.

1. Når du har angitt de nødvendige innstillingene, klikker du på **OK.**

    [!include[Save mapping](includes/tip-save-mapping.md)]

> [!NOTE]
> Hvis du anga en importbeskrivelsesfil i feltet **Importbeskrivelsesfil**, vil det allerede være angitt informasjon i dialogboksen **Avanserte innstillinger**. Denne informasjonen kan du imidlertid endre i henhold til beskrivelsen ovenfor. Husk at importbeskrivelsesfilen må lagres for at den skal oppdateres med de nye valgene som er gjort.

<!-- Referenced links -->
[2]: ../../../../admin/options/learn/freetext-search/regenerate-index.md

<!-- Referenced images -->
