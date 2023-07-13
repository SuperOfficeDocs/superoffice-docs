---
uid: help-sv-faq-workflow
title: Arbetsflödesfaser
description: Arbetsflödesfaser
author: SuperOffice RnD
so.date: 06.29.2022
keywords: FAQ
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: sv
---

# Arbetsflödesfaser

I en ny installation har du två standardsteg i arbetsflödet: **Inte publicerad** och **Publicerad**. Det går att lägga till flera steg mellan dessa. Du kan t.ex. skapa ett arbetsflöde där en FAQ-post skickas till stavningskontroll så att en person kontrollerar posten och sedan publicerar den eller skickar tillbaka den opublicerad för redigering.

## Skapa nya steg

1. Gå till ![ikon][img4] **Huvudmeny** i det övre fältet och välj **Kunskapsbas** > **FAQ**.
1. Klicka på knappen **Arbetsflöde**. Du kommer då till skärmen **Visa arbetsflöde**.
1. Klicka på knappen **Nytt steg**. Du kommer då till skärmen **Nytt steg**.
1. Ange ett beskrivande namn på steget i fältet **Namn**.
1. I listan **Placera ett nytt steg mellan** väljer du var i processen du vill placera det nya steget.
1. Klicka på **OK**. Du kommer då till skärmen **Redigera steg**.
1. I listan **Välj användare** längst ned på skärmen väljer du namnet på en användare som ska ha åtkomst till detta steg i arbetsflödet.
1. Välj vilken åtkomstnivå användaren ska ha. Du kan välja mellan följande alternativ:
    * **Kan flytta**: Användaren har behörighet att ändra arbetsflödets steg för poster (publicera eller avbryta publicering).
    * **Kan ändra**: Användaren har behörighet att ändra i FAQ-poster.
    * **Full åtkomst**: Användaren har full behörighet för arbetsflödet.
1. Klicka på ![ikon][img3] knappen **Lägg till** för att lägga till användaren i listan under **Användaråtkomst**.
1. Upprepa steg 7–9 om du vill lägga till fler användare.
1. Klicka på **OK**. Steget skapas och är nu tillgängligt när du publicerar FAQ-poster.

## Redigera steg

Du kan både ändra namnet på ett steg och justera vilka användare som ska ha åtkomst till det.

1. Gå till ![ikon][img4] **Huvudmeny** i det övre fältet och välj **Kunskapsbas** > **FAQ**.
1. Klicka på knappen **Arbetsflöde**.
1. Klicka på stegets namn. Du kommer då till skärmen **Redigera steg**.
1. Ändra namnet vid behov.
1. Justera vilka användare som ska ha åtkomst till steget:
    * Om du vill lägga till användare följer du proceduren ovan.
    * Om du vill ta bort användare väljer du användarna i fråga, klickar på ![ikon][img1] knappen **Åtgärder** och väljer **Ta bort åtkomst för valda användare**.
1. Klicka på **OK**. Ändringarna sparas.

## Ta bort steg

1. Gå till ![ikon][img4] **Huvudmeny** i det övre fältet och välj **Kunskapsbas** > **FAQ**.
1. Klicka på ![ikon][img2] knappen **Arbetsflöde**.
1. Klicka på stegets namn. Du kommer då till skärmen **Redigera steg**.
1. Klicka på **Ta bort**. Om steget inte har några tillhörande FAQ-poster raderas det omedelbart.

   > [!NOTE]
   > Du kan inte ta bort standardstegen **Inte publicerad** och **Publicerad**.

1. Om det finns FAQ-poster kopplade till steget väljer du vilket steg i arbetsflödet som FAQ-posterna ska flyttas till. Välj önskat steg i listan **Flytta till arbetsflöde**.
1. Klicka på **Ta bort**. Steget raderas och tillhörande FAQ-poster flyttas till det valda steget.

## Publicera via arbetsflöde

1. [Öppna FAQ-posten][1].
1. Om du vill justera något före publicering kan du följa proceduren under [Publicera FAQ-poster][2].
1. Klicka på knappen **Flytta framåt i arbetsflödet** tills det står **Publicerad** i fältet **Arbetsflödesfas** på fliken **Detaljer**.

   > [!TIP]
   > Du kan välja att upphäva publiceringen av FAQ-posten genom att klicka på knappen **Flytta bakåt i arbetsflödet**.

<!-- Referenced links -->
[1]: view-entry.md
[2]: publish.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/gearblack.png
[img3]: ../../../media/icons/btn-add.png
[img4]: ../../../media/icons/main-menu.png
