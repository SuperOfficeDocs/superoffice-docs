---
uid: help-sv-adding-items-to-currency-list
title: Lägga till poster i listan Valuta
description: Lägga till poster i listan Valuta
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar och underhåll
content_type: howto
language: sv
---
 
# Lägga till poster i listan Allmänt – Valuta

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] när posterna är valutor:

1. Skriv in namnet på posten i fältet **Namn**.

    > [!NOTE]
    > [!include[Mandatory](includes/note-mandatory-field.md)]

2. Ange den aktuella valutakursen genom att ange ett tal i fältet **Kurs**.

    > [!NOTE]
    > Detta är kursen mot basvalutan. Basvalutan är den valuta där kursen är inställd på 1. Om basvalutan är EUR, beräknas kursen för andra valutor mot denna valuta och den angivna enheten (se nästa punkt). GBP 1 motsvarar till exempel EUR 1,562 enligt dagens kurs, medan NOK 100 skulle motsvara EUR 12,677. Denna beräkning visas när du har angett valutakurs och enhet.

3. Ange enheten som ska användas i förhållande till basvalutan i fältet **Enhet**. Standardvärdet kan till exempel vara 100 för norska kronor och 1 för brittiska pund.

4. Skriv eventuellt en beskrivning av valutan i fältet **Beskrivning**.

5. Klicka på **Spara**. Valutan läggs nu till som en egen post i listan **Poster**. Upprepa proceduren om du vill lägga till fler valutor.

    > [!NOTE]
    > Du måste aktivera valutor och välja standardvaluta i fönstret **Inställningar** (i gruppen **System**).
