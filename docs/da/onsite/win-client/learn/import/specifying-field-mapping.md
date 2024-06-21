---
uid: help-da-specifying-field-mapping
title: Specifikation af felttilknytning
description: Specifikation af felttilknytning
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Angivelse af felttilknytning

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Indholdet af den første post i importfilen vises i kolonnen **Felt i fil** under **Felttilknytning**. Vælg et felt, du vil importere i databasen.

1. Klik på knappen **Tilknyt** under **Felttilknytning**.

    > [!NOTE]
    > Du kan også dobbeltklikke på det felt, du vil importere.

1. Navnet på det gældende felt i importfilen vises i **Felt i importfil** i dialogboksen **Felttilknytning**. På listen **Vælg felt fra tabel** skal du vælge den type data, du vil importere til SuperOffice-databasen, f.eks. firmaer.

1. I tabellen **Navn** vises alle tilgængelige felter for den datatype, du valgte på listen **Vælg felt fra tabel** undtagen dem, du allerede har tilknyttet. Vælg et felt for at tilknytte det.

1. Klik på **OK**. Informationen under **Felttilknytning** på skærmbilledet **Importér** opdateres.

    [!include[Save mapping](includes/tip-save-mapping.md)]

1. Gentag proceduren for at tilknytte yderligere felter. Du kan importere flere forskellige datatyper. Husk, at felter, der ikke er tilknyttet en post i SuperOffice-databasen, slet ikke importeres.

> [!NOTE]
> Hvis du har angivet en importbeskrivelsesfil i feltet **Importér beskrivelsesfil** er der muligvis allerede oplysninger i kolonnen **Felt i SuperOffice CRM** under **Felttilknytning**. Hvis det er nødvendigt, kan du ændre felttilknytningen ved [at slette felttilknytningen][1] og derefter angive en ny felttilknytning igen.

<!-- Referenced links -->
[1]: deleting-field-mapping.md

<!-- Referenced images -->
