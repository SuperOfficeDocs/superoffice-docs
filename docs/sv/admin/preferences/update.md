---
uid: help-sv-preferences-manage
title: Arbeta med inställningar
description: Så lägger du till, ändrar och tar bort inställningar.
keywords: inställning
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
category: Settings and maintenance
topic: preferences
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
redirect_from: /sv/admin/preferences/learn/update-preferences
---

# Arbeta med inställningar

## Gå till den inställning du vill uppdatera

1. Klicka på knappen <i class="ph ph-gear" aria-hidden="true"></i> **Inställningar** i navigatorn.
2. Välj önskad gruppinställning i listrutan högst upp.
3. Markera ett alternativ i listan **Inställningar**.

    I fältet **Aktiva inställningar** visas alternativ som redan har angetts för den här inställningen. Om fältet är tomt kan det bero på att du inte har markerat att olika nivåer ska visas.

> [!TIP]
> Använd fältet **Fritextsökning** högst upp i fönstret för att hitta den parameter du vill ändra. Sökresultaten visas i listan nedanför.

## Lägga till inställningar

1. Gå till den parameter du vill lägga till en ny inställning för.

1. Klicka på **Lägg till** längst ned i fönstret.

1. Under **Inställningen gäller för** i dialogrutan **Inställning** väljer du på [vilken nivå][2] inställningen ska tillämpas: hela systemet, en databas, en användargrupp eller en enskild användare.

    * Om ett eller flera alternativ är inaktiverade kan den här inställningen inte tillämpas på dem.

1. Välj namnet på den önskade databasen, gruppen eller användaren, beroende på vad du valde ovan.

    * Om du har valt **System** fylls fältet **Mål** i automatiskt eftersom det bara finns ett system.

1. Namnet på fältet under **Värde** varierar beroende på vilken inställning det gäller. Här anger du värden för inställningen genom att antingen skriva något i fältet, välja från en fördefinierad lista, markera en ruta osv., beroende på vilken inställningstyp det handlar om.

1. Om du har valt en högre nivå än lägsta möjliga under **Inställningen gäller för** och vill ta bort aktiva inställningarna på alla lägre nivåer kan du markera **Ta bort inställningar på lägre nivå** längst ned i dialogrutan. Den nya inställningen kommer då att styra över de inställningar som har angetts på lägre nivåer.

1. Klicka på **Spara**. Inställningen blir tillgänglig för användarna nästa gång de loggar in i SuperOffice.

> [!NOTE]
> Parametrar med aktiva individuella inställningar visas i feststil i inställningslistan.

## <a id="edit"></a>Redigera inställningar

1. Gå till den inställning du vill uppdatera.

1. Dubbelklicka på den inställning som du vill ändra.

1. Uppdatera fälten efter behov.

1. Klicka på **Spara** (eller **Avbryt** för att förkasta dina ändringar).

    * Inställningen blir tillgänglig för användarna nästa gång de loggar in i SuperOffice.

## <a id="personal"></a>Tillåt individuella inställningar

1. Gå till den inställning du vill göra tillgänglig på menyn **Personliga inställningar**.

1. Markera **Tillåt individuella inställningar**. Inställningen kommer att visas i dialogrutan **Inställningar** och varje användare kan redigera den efter egna önskemål.

> [!NOTE]
> Inställningar på användarnivå är inte tillgängliga för alla inställningar.

## Ta bort inställningar

1. Gå till den parameter du vill ta bort en inställning för.

1. Markera en eller flera inställningar som du vill ta bort och klicka på **Ta bort** längst ned i fönstret. Alla markerade inställningar tas bort från listan.

<!-- Referenced links -->
[2]: index.md#levels

<!-- Referenced images -->
