---
uid: help-no-specifying-field-mapping
title: Angi felttilordning
description: Angi felttilordning
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Angi felttilordning

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. I kolonnen **Felt i fil** under **Felttilordning** vises innholdet i den første posten i importfilen. Merk et felt du vil importere til databasen.

1. Klikk på **Legg til**-knappen under **Felttilordning**.

    > [!NOTE]
    >Du kan også dobbeltklikke på feltet du vil importere.

1. Navnet på det aktuelle feltet i importfilen vises i feltet **Felt i importfil **i dialogboksen **Felttilordning**. l I listeboksen **Velg felt fra tabell** velger du hvilken type data du vil importere til SuperOffice-databasen, for eksempel firmaer.

1. I tabellen under **Navn** vises alle tilgjengelige felt, minus de som allerede er tilordnet, for datatypen du valgte i listeboksen **Velg felt fra tabell**. Velg et felt du vil tilordne.

1. Klikk på **OK**. Opplysningene under **Felttilordning** i **Importer**-bildet er nå blitt oppdatert.

    [!include[Save mapping](includes/tip-save-mapping.md)]

1. Gjenta prosedyren for å tilordne flere felt. Det går an å importere flere forskjellige datatyper. Husk at felt som ikke er tilordnet en post i SuperOffice-databasen, ikke vil bli importert i det hele tatt.

> [!NOTE]
> Hvis du anga en importbeskrivelsesfil i feltet **Importbeskrivelsesfil**, vil det kanskje allerede være informasjon i kolonnen **Felt i SuperOffice CRM** under **Felttilordning**. Du kan om nødvendig endre felttilordningen ved å [slette felttilordning][1] og deretter angi en ny felttilordning.

<!-- Referenced links -->
[1]: deleting-field-mapping.md

<!-- Referenced images -->
