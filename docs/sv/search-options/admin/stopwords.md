---
uid: help-sv-stopwords
title: Stoppord
description: Stoppord
keywords: fritext, söka, stoppord
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
redirect_from: /sv/admin/options/learn/freetext-search/stopwords
---

# Stoppord

Ett stoppord är ett ord som inte är indexerat (inte ingår i en fritextsökning). Vanligtvis rör det sig om ord som *och*, *eller*, *det* och *för*. Syftet med att definiera stoppord är att det ska gå fortare att söka i fritextindexet genom att onödiga ord exkluderas och att mindre utrymme används i databasen.

De ord som definieras som stoppord för fritextsökningar läggs in i tabellen **Stoppordslista** på fliken **Fritextsökning** i fönstret Systemval.

## Innan du börjar

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. I lokala installationer ska du se till att alternativet **Aktivera fritextsökning** är markerat. I CRM Online är detta alternativ alltid aktiverat.

> [!TIP]
> Om du vill att dina ändringar ska gälla retroaktivt måste du [återskapa fritextindexet][3]. Det gör du efter att du har lagt till stoppord, efter att systemet föreslår stoppord eller efter att du har importerat stora mängder text.

## Lägg till stoppord

1. Klicka på knappen **Lägg till** under stoppordslistan.

1. Skriv in ett eller flera stoppord som du vill använda i dialogrutan **Nya stoppord**. Använd ett icke-alfabetiskt tecken (utom punkt) som avgränsare.

1. Klicka på **Spara**.

1. Ett meddelande informerar dig om att ändringar av stoppordslistan inte tillämpas retroaktivt. Med andra ord tillämpas nya stoppord inte på text som lades in innan stoppordet definierades. Klicka på **OK**.

## Föreslå stoppord

Istället för att lägga till stoppord manuellt kan du låta systemet föreslå stoppord åt dig.

1. Klicka på knappen **Föreslå** under stoppordslistan.

1. Ett meddelande informerar dig om att det kan ta lång tid för systemet att gå igenom ordlistan och indexet för att hitta möjliga stoppord. Klicka på **OK**.

1. När systemet har hittat möjliga stoppord visas de i dialogrutan **Nya stoppord**. De vanligaste orden i databasen visas högst upp. Markera de ord du vill lägga till som stoppord. Håll ner **Ctrl**-tangenten och klicka på de önskade stopporden.

1. Klicka på **Spara**.

1. Ett meddelande påminner dig om att ändringarna av stoppordslistan inte gäller retroaktivt, vilket innebär att nya stoppord inte tillämpas på fält som har skapats innan stopporden definierades. Klicka på **OK**.

## Ta bort stoppord

Syftet med att ta bort stoppord är att de ska inkluderas i fritextsökningar efter att ha varit exkluderade. Så här tar du bort ett stoppord från listan:

1. Välj önskat stoppord.

1. Klicka på knappen **Ta bort** under stoppordslistan.

<!-- Referenced links -->
[3]: regenerate-index.md

<!-- Referenced images -->
