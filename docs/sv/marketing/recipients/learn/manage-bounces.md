---
uid: help-sv-blocked-email-addresses
title: Blockerade e-postadresser
description: Lär dig hur du hanterar returnerade e-postmeddelanden i den här guiden.
keywords: blockerade e-postadresser, studsar, för många returer, returnerade e-postmeddelanden
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /sv/marketing/mailing/learn/follow-up/manage-bounces
language: sv
---

# Hantera studsar

Det finns många anledningar till att e-postadresser returneras. Dina kontakter byter jobb, en e-postadress är felstavad och tillfälliga fel i kundens infrastruktur är de vanligaste orsakerna till att utskick returneras.

De första gångerna du skickade ut ditt utskick kanske du får ett stort antal returnerade e-postmeddelanden. Det är positivt, eftersom det betyder att du kan uppdatera alla e-postadresser som är felstavade eller inte längre används. Uppdatering av returnerade e-postadresser hjälper dig att öka framgångsgraden för dina framtida utskick.

Du kan hantera returnerad och blockerad e-post för enskilda utskick och för ALLA utskick.

## Varför returneras e-postmeddelanden?

Det kan t.ex. bero på fel i e-postadresser, skräppostfilter, Internetproblem eller att mottagarnas inkorgar är fulla.

* Tillfälliga problem: leveransförseningar, e-postservern tillfälligt otillgänglig
* Permanenta problem: fel adress, okänd domän.

E-postadresser som inte fungerar tillfälligt blockeras inte och hoppas inte över vid nästa utskick.

> [!NOTE]
> För att förhindra felstavade eller ogiltiga e-postadresser validerar SuperOffice e-postadresser som tas emot via chatt och i formulär. Valideringen görs med hjälp av DNS lookup och kontrollerar grundläggande syntax i e-postmeddelanden.

Det finns två typer av returneringar:

En **hård retur** är när ditt utskick inte kan levereras permanent, eftersom e-postadressen inte finns, domänen inte finns (längre) eller mottagarens e-postserver har blockerat leveransen. Uppdatering av e-postadressen löser problemet.

En **mjuk retur** uppstår när det finns ett tillfälligt leveransproblem. SuperOffice CRM kommer att försöka skicka utskicket igen flera gånger för att leverera det när ett e-postmeddelande returneras. Först när e-postmeddelandet inte kan levereras efter flera gånger kommer det att registreras som en hård retur.

Använd filterknapparna (Skickat, Returnerat och Öppnat) för att filtrera [mottagarlistan][1]. När du har valt alla kontakter där utskicket returnerades kan du samla dem i ett urval eller projekt med hjälp av åtgärdsmenyknappen i nedre vänstra hörnet.

![Filtrera dina returnerade e-postmeddelanden och välj vad du vill göra med dem -screenshot][img2]

## Så här åtgärdar du en enskild e-postadress

1. Välj e-postmeddelandet i listan och klicka på **Öppna** i sidopanelen för att redigera kontakten.
2. Gå till fliken **Detaljer**.
3. En varningsikon (<i class="ph ph-warning" aria-hidden="true"></i>) bredvid e-postadressen indikerar att det finns ett problem med denna. Håll muspekaren över ikonen för att visa orsaken till problemet.

> [!TIP]
> Klicka på en kolumn för att komma åt sorterings- och grupperingsfunktionerna.

## Blockerade e-postadresser

E-postadresser som har misslyckats på grund av permanenta fel eller har returnerats upprepade gånger blockeras automatiskt. Blockerade adresser hoppas över i alla framtida utskick för att skydda ditt avsändarrykte.

Som standard blockeras en e-postadress efter 5 på varandra följande returer. Denna tröskel definierar vad som anses vara **för många returer**. Det hjälper till att identifiera opålitliga adresser som konsekvent misslyckas. Du kan justera denna gräns i den globala inställningen **Antal returer som accepteras innan e-postadressen inaktiveras** i Inställningar och underhåll.

Alla blockerade e-postutskick från alla utskick arkiveras under fliken **Blockerade e-postadresser**. Den här fliken ger en utmärkt översikt över e-postadresser som måste rensas.

> [!TIP]
> Klicka på en kolumn för att komma åt sorterings- och grupperingsfunktionerna.

## Alternativ för returer

Om du vill hantera flera e-postadresser, kan du välja alternativ under knappen **Åtgärd**.

### Exportera

1. Markera de e-postadresser som du vill exportera.
2. Välj **Åtgärder** > **Exportera**.
3. Välj ett exportformat. Exportfiltret visas längst ner i din webbläsare. Du hittar den även i mappen Hämtningar.

### Lägg till nytt urval

1. Markera de e-postadresser som du vill lägga till i ett nytt urval.
2. Välj **Åtgärder** > **Lägg till nytt urval**.
3. Skriv namnet på det nya urvalet och klicka på **OK**. Ett nytt statiskt urval skapas med de valda e-postadresserna.

### Lägg till nytt projekt

1. Markera de e-postadresser som du vill lägga till i ett nytt projekt.
2. Välj **Åtgärder** > **Lägg till nytt projekt**.
3. Ange namnet på det nya projektet och klicka på **OK**. Ett nytt projekt skapas med de valda e-postadresserna.

### Lägg till befintligt urval

1. Markera de e-postadresser som du vill lägga till i ett befintligt urval.
2. Välj **Åtgärder** > **Lägg till befintligt urval**.
3. Börja skriva i sökfältet för att hitta det relevanta urvalet.
4. I resultatlistan klickar du på det urval som du vill använda.
5. Klicka på **OK**. De valda e-postadresserna läggs till i urvalet.

### Lägg till befintligt projekt

1. Markera de e-postadresser som du vill lägga till i ett befintligt projekt.
2. Välj **Åtgärder** > **Lägg till befintligt projekt**.
3. Börja skriva i sökfältet för att hitta det relevanta projektet.
4. I resultatlistan klickar du på det projekt som du vill använda.
5. Klicka på **OK**. De valda e-postadresserna läggs till i projektet

### Ta bort markerade e-postadresser

Använd detta alternativ för att ta bort e-postadresser permanent från databasen.

1. Markera de e-postadresser som du vill ta bort.
2. Välj **Åtgärder** > **Ta bort markerade e-postadresser**.
3. Bekräfta genom att klicka på **OK**.

### Ta bort returflagga

Använd det här alternativet för att ta bort e-postadresser från listan, så att de kan användas i utskick. Detta kan vara relevant om returerna beror på en felaktig konfiguration eller tillfälliga tekniska orsaker, eller om du vet att de aktuella e-postadresserna är korrekta och vill försöka skicka en gång till.

1. Skicka e-postadresserna som du vill ta bort returflaggorna för.
2. Välj **Åtgärder** > **Ta bort returflagga**.
3. Bekräfta genom att klicka på **OK**.

### Ange som tidigare anställd

Använd det här alternativet för att ange en kontakt som tidigare anställd.

1. Markera de e-postadresser som du vill ta bort.
2. Välj **Åtgärder** > **Ange som tidigare anställd**.
3. Bekräfta genom att klicka på **OK**.

<!-- Referenced links -->
[1]: look-at-recipient-list.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/marketing/filter-recipients.png
