<!-- markdownlint-disable-file MD041 -->
1. **Projektnamn:** Skriv in namnet på projektet i fältet högst upp på fliken **Projekt**. ***Projektnamn*** visas i rött för att indikera att detta är ett obligatoriskt fält.

    Om du försöker registrera ett projekt med [samma eller liknande namn][5] som ett befintligt projekt öppnas dialogrutan **Dubbletter**. Den fungerar på samma sätt som för företag.

1. **Nummer:** Nästa lediga projektnummer visas automatiskt av SuperOffice CRM i detta fält. Standardinställningen är att 10001 är det första projektnumret och att värdet sedan ökar med 1 för varje nytt projekt. Administratörer kan ändra detta i Inställningar och underhåll, så du behöver inte tänka på detta.

1. **Webbadress:** I det här fältet visas en tabell med kolumnerna **Webbadress (URL)** och **Titel**.

    Här skriver du in adressen till en webbsida och en kort beskrivning om vad för slags sida det är. Om du vill kan du lägga in flera webbadresser. Klicka utanför tabellen när du är klar eller tryck på **TABB**-tangenten tills tabellen stängs.

1. **Beskrivningsfält:** I den stora textrutan kan du lägga in en utförligare beskrivning av projektet.

1. **Ansvarig:** Här kan du ange vem som är ansvarig för projektet. Om du klickar på pilen visas en lista över andra användare, användargrupper och resurser i databasen.

1. **Typ:** Här kan du ange vad för slags typ av projekt det handlar om. Om du klickar på pilen visas en lista över fördefinierade projekttyper. Det här fältet är obligatoriskt och **måste** fyllas i. [!include[SM](../../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Vissa projekttyper är kopplade till en [projektguide][2]. Om du byter projekttyp försvinner även den tillhörande projektguiden. Eventuella händelser och dokument som har skapats i samband med projektguiden blir kvar på detaljkortet **Aktiviteter** i kalendern. Om du byter tillbaka till den ursprungliga projekttypen återupprättas kopplingen mellan händelser/dokument och projektguiden.

1. **Status:** Här kan du ange vilken status projektet har. Om du klickar på pilen visas en lista med standardalternativ. [!include[SM](../../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Om projektet är kopplat till en [projektguide][2] visas statusarna för projektguiden i det här fältet. När du ändrar en status, till exempel från **Planerat** till **Under arbete** markeras den första statusen på detaljkortet **Projektguide** som slutfört, med en bock.

1. **Slutdatum:** Ange slutdatumet för projektet i fältet **Slutdatum**. För att ändra det föreslagna slutdatumet klickar du på pilen vid datumet och väljer ett nytt datum i kalendern som visas.

1. **Nästa milstolpe:** Om projektet är kopplat till en projektguide visar fältet **Nästa milstolpe** datumet för projektets nästa milstolpshändelse. Om detta datum är före dagens datum är det rödmarkerat. Om projektet inte är kopplat till en projektguide visas slutdatumet för projektet här. Datumet **Nästa milstolpe** beräknas automatiskt utifrån aktiviteter som är kopplade till projektet eller registrerade via projektguiden. Det här är vanligtvis datumet för nästa öppna aktivitet i detaljkortet **Aktiviteter** för projektet.

1. **Användardefinierade fält:**[!include[3 udef](../../../learn/includes/more-udef.md)]

1. **Slutförd:** Den här rutan anger om projektet är slutfört.

<!-- Referenced links -->
[5]: ../../../learn/basics/duplicates.md
[2]: ../project-guide/index.md

<!-- Referenced images -->
