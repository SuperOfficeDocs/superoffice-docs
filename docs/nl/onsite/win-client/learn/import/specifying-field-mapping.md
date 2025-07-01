---
uid: help-nl-specifying-field-mapping
title: Veldtoewijzing opgeven
description: Veldtoewijzing opgeven
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: howto
language: nl
platform: win
deployment: onsite
---

# Veldtoewijzing opgeven

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. De inhoud van de eerste record in het importbestand wordt weergegeven in de kolom **Veld in bestand** onder **Veldtoewijzing**. Selecteer een veld dat u wilt importeren in de database.

1. Klik op de knop **Toewijzing** onder **Veldtoewijzing**.

    > [!NOTE]
    > U kunt ook dubbelklikken op het veld dat u wilt importeren.

1. De naam van het huidige veld in het importbestand wordt weergegeven in **Veld in importbestand** in het dialoogvenster **Veld toewijzen**. Kies in de keuzelijst **Veld selecteren in tabel** het type gegevens dat u wilt importeren in de SuperOffice-database, bijvoorbeeld bedrijven.

1. In de tabel **Naam** worden alle beschikbare velden weergegeven voor het gegevenstype dat u hebt geselecteerd in de keuzelijst **Veld selecteren in tabel**, met uitzondering van de velden die al zijn toegewezen. Selecteer een veld dat u wilt toewijzen.

1. Klik op **OK**. De informatie onder **Veldtoewijzing** in het scherm **Import** wordt bijgewerkt.

    [!include[Save mapping](includes/tip-save-mapping.md)]

1. Herhaal de procedure om extra velden toe te wijzen. U kunt verschillende gegevenstypen importeren. Houdt er rekening mee dat bestanden die niet zijn toegewezen aan een record in de SuperOffice-database niet worden geÃ¯mporteerd.

> [!NOTE]
> Als u een importbeschrijvingsbestand hebt opgegeven in het veld **Importbeschrijvingsbestand**, staan er mogelijk al gegevens in de kolom **Veld in SuperOffice CRM** onder **Veldtoewijzing**. Wijzig indien nodig de veldtoewijzing met [veldtoewijzing verwijderen][1] en vervolgens opnieuw een nieuwe veldtoewijzing in te voeren.

<!-- Referenced links -->
[1]: deleting-field-mapping.md

<!-- Referenced images -->
