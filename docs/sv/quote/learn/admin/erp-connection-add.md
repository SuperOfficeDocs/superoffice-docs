---
uid: help-sv-erp-connection-add
title: Lägg till ERP-koppling
description: Lägg till ERP-koppling
author: SuperOffice RnD
date: 06.29.2022
keywords: offert, ERP, referens
topic: howto
language: sv
---

# Lägga till ERP-koppling (Quote Connector)

Varje Quote Connector måste ha en ERP-koppling med konfigurationsinformation för att koppla Quote Connector till SuperOffice.

Hur konfigurerar jag en ERP-koppling för SuperOffice CRM för webben (online)?

1. Gå till [https://online.superoffice.com/appstore][4].
2. Hitta rätt "sync"-app för ditt ERP-system. [Klicka här om du vill söka][2]
3. Hitta rätt "quote"-app för ditt ERP-system. [Klicka här om du vill söka][3]
4. För att slutföra installationen kontaktar du app-leverantören.

## Lägga till en ERP-koppling

1. Gå till fliken **ERP-kopplingar** i fönstret Offert/Synk.

1. Klicka på **Lägg till** nederst i listan **ERP-kopplingar**. Dialogrutan **Ange ny ERP-koppling** öppnas.

1. Skriv in ett namn på ERP-kopplingen i fältet **Namn**.

1. Välj önskad **Quote Connector** i listan. Listan är identisk med **Tillgängliga Quote Connectors**.

1. Välj ett **Område**:

    * **Alla**: Välj det här alternativet om alla användare ska kunna använda ERP-kopplingen. Det innebär att de kan använda prislistorna som är tillgängliga via denna koppling.
    * **Angivna användare + grupper**: Klicka på **Välj grupper och användare** för att välja vilka användargrupper och/eller användare som ska få tillgång till ERP-kopplingen.

1. Välj ERP-kopplingen som ska hantera synkroniseringen i fältet **ERP-koppling**.

1. Längst ned i dialogrutan anger du önskade inställningar. Innehållet i listan varierar beroende på vilken typ av Quote Connector du har valt.

1. Skriv in en beskrivning av ERP-kopplingen i fältet nederst.

1. Klicka på **Testa ERP-kopplingen** för att kontrollera att kopplingen fungerar.

1. Klicka på **OK**.

## Ta bort och återställa

Nederst i listan **ERP-kopplingar** kan du ta bort ERP-kopplingar som inte längre används.

Så här återställer du en borttagen ERP-koppling:

1. Markera **Borttagen**.
1. Välj den borttagna kopplingen i listan.
1. Klicka på **Återskapa**.

<!-- Referenced links -->
[4]: https://online.superoffice.com/appstore
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote

<!-- Referenced images -->
