---
uid: help-sv-sync-configure-field-allocation
title: Konfigurera fälttilldelning
description: Konfigurera fälttilldelning
author: Bergfrid Dias
so.date: 03.29.2023
keywords: offert, synk, referens, ERP, tilldelning
so.topic: howto
so.user: admin
language: sv
---

# Konfigurera fälttilldelning

När du synkroniserar data mellan SuperOffice och ERP-system måste du ange vilka SuperOffice-fält och ERP-fält som hör samman.

> [!NOTE]
> När du ska redigera en ERP-koppling, måste du inaktivera den först.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Markera ERP-kopplingen och klicka på knappen **Kopplingar** nederst. Dialogrutan **Kopplingar** visar flikarna för de tillgängliga aktörerna i ERP-systemet.

1. Markera fliken för den aktör du vill konfigurera tilldelningar för.

1. Markera **Synkronisera ERP \[actor\] med SuperOffice \[entity\]**.

1. I listan nedanför måste du välja synkroniseringsriktning och vilket SuperOffice-fält respektive ERP-fält ska kopplas till (synkroniseras med). Dessutom kan du välja om fälten ska visas i sökresultat och på **ERP**-fliken.
    Listan har följande kolumner:

    * **Visa i sökning**: Markera det här alternativet om fältet ska visas i sökresultat.
    * **ERP-fält**: Här visas namnet på fältet i ERP-systemet.
    * **Riktning**: Här väljer du riktning(ar) för synkroniseringen. Se tabell med ikoner nedan.

    * **SuperOffice-fält**: här väljer du det SuperOffice-fält du vill synkronisera. Vissa fält (till exempel kund- och personnummer) kan inte synkroniseras, och listan blir då tom.
    * **Visa på ERP-flik**: Markera det här alternativet om du vill att fältet ska visas på **ERP**-fliken i SuperOffice CRM (fönstren Företag, Kontakt och Projekt).

        > [!NOTE]
        > Om du har valt att synkronisera det här fältet med ett SuperOffice-fält behöver det inte visas på **ERP**-fliken.

1. Upprepa steg 4 till 6 för att konfigurera fältkopplingar för andra aktörer.

1. Klicka på **Klar** för att slutföra. Under listan **ERP-kopplingar** visas alla fält som är synkroniserade för de olika aktörerna.

1. Markera **Aktiv** för ERP-kopplingen du redigerade.

## Vad betyder ikonerna?

| Ikon | Förklaring |
|---|---|
| ![ikon][img1] | Ingen synkronisering (SuperOffice-fält är valt). Om fältet är obligatoriskt MÅSTE du välja en riktning. |
| ![ikon][img2] | Synkronisering båda hållen. |
| ![ikon][img3] | Synkronisering från SuperOffice till ERP-systemet. |
| ![ikon][img4] | Synkronisering från ERP-systemet till SuperOffice. |
| ![ikon][img5] | Ingen synkronisering (SuperOffice-fält är INTE valt), eller så kan inte fältet synkroniseras (till exempel kundnamn). Detta kan bero på att det är skrivskyddade fält. Håll muspekaren över ikonen för mer information. |

> [!NOTE]
> Pilarna är inaktiverade tills du väljer ett SuperOffice-fält.

## Felsökning

Om du angav felaktiga inställningar för fältkopplingarna visas ett felmeddelande som beskriver vad som är fel. Det kan till exempel gälla ett obligatoriskt fält som saknar synkroniseringsriktning. Du måste rätta till felet innan du kan aktivera ERP-kopplingen.

## Så här kopplar/allokerar du listobjekt

Om du kategorikopplade listor (till exempel kategori) måste du också [kopplat de enskilda objekten i varje lista][1].

<!-- Referenced links -->
[1]: sync-configure-list-mapping.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/sync-none.bmp
[img2]: ../../../../../media/icons/admin/sync-2-way.bmp
[img3]: ../../../../../media/icons/admin/sync-to-erp.bmp
[img4]: ../../../../../media/icons/admin/sync-to-so.bmp
[img5]: ../../../../../media/icons/admin/sync-deactivated.bmp
