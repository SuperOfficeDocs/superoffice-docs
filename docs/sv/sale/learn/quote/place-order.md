---
uid: help-sv-quote-place-order
title: Registrera order
description: Lär dig hur du registrerar en order i SuperOffice CRM.
keywords: registrera order, skapa order, order baserad på offertversion, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/quote/learn/create-order
---

# Registrera order

När kunden har accepterat offerten kan du registrera ordern så att den skickas vidare till orderhantering eller lager.

> [!NOTE]
> Du kan inte registrera ordern om offerten [innehåller fel eller varningar][2].

## Steg

1. Klicka på **Registrera order** i dialogrutan **Redigera offert**. Dialogrutan **Skapa order utifrån offertversion** visas. Namnlisten visar vilken version av offerten ordern baseras på.

    För att registrera en order för en arkiverad version, välj versionen i fältet **Version** och klicka på **Aktivera**. Den arkiverade versionen kopieras och blir den aktuella versionen. Tidigare versioner arkiveras.

1. Om offerten innehåller flera alternativ, välj önskat alternativ i fältet **Välj alternativ**.
1. För att skicka ordern via e-post, markera **Skicka orderbekräftelse via e-post**, och välj e-postmall och språk.
1. Ange kundens **ordernummer** (inköpsordernummer) om det finns, samt eventuell **orderkommentar**.
1. Markera **Markera försäljningen som såld (100 %)** för att ändra försäljningens status.
1. Klicka på **OK**.

    Om du valde att skicka ordern via e-post öppnas dialogrutan **Nytt e-postmeddelande**, där du kan redigera meddelandet och skicka bekräftelsen till kunden.

Om SuperOffice CRM är anslutet till ett ERP-system (antingen via inbyggd lösning eller tredjepartskoppling) registreras och hanteras ordern automatiskt där. Om ingen ERP-anslutning finns måste du registrera ordern manuellt i det externa systemet.

<!-- Referenced links -->
[2]: create.md#warning
