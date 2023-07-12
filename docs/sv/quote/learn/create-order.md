---
uid: help-sv-quote-create-order
title: offert skapa order
description: I den här guiden förklarar vi hur du registrerar en order.
author: SuperOffice RnD
so.date: 02.16.2023
keywords: offert
so.topic: howto
language: sv
---

# Registrera order

När kunden accepterar offerten, kan du registrera ordern så att den skickas vidare till exempelvis ordermottagning eller lager för vidare behandling.

> [!TIP]
> För att registrera en order för en arkiverad version av offerten, välj denna version i fältet **Version** och klicka på **Aktivera**. Då kopieras den arkiverade offerten och görs till gällande version. Den tidigare versionen av offerten arkiveras.

1. Klicka på **Registrera order** i dialogrutan **Redigera offert för**. Dialogrutan **Skapa order utifrån offertversion** visas. I dialogrutans namnlist står det vilken offertversion ordern baseras på.

    > [!NOTE]
    > Du kan inte registrera ordern om [offerten inte har godkänts][1] eller [offerten innehåller fel eller varningar][2].

1. Om offerten innehåller flera alternativ väljer du önskat alternativ i fältet **Välj alternativ**.
1. För att skicka via e-post markerar du **Skicka orderbekräftelse via e-post** och väljer önskad e-postmall och språk.
1. Ange kundens **ordernummer** (inköpsordernummer), om ett sådant finns, och lägg in en **Orderkommentar** om du önskar.
1. Markera **Markera försäljningen som såld (100 %)** för att ändra statusen på försäljningen.
1. Klicka på **OK**.

    Om du valde att skicka ordern som e-post visas dialogrutan **Nytt e-postmeddelande**. Här kan du redigera texten och skicka bekräftelsen till kunden.

Om SuperOffice CRM är anslutet till ett ERP-system (antingen med den inbyggda lösningen i SuperOffice eller en tredjepartskontakt) registreras ordern där och bearbetas automatiskt. Om SuperOffice CRM inte är ansluten till ett ERP-system måste du registrera ordern manuellt i det externa systemet.

<!-- Referenced links -->
[1]: approve.md
[2]: add-product.md#warning

<!-- Referenced images -->
