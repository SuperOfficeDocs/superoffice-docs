<!-- markdownlint-disable-file MD041 -->
1. Ange försäljningsbeloppet.

2. Välj valutan för försäljningen (om det här alternativet är aktiverat).

3. Ange det företag som försäljningen ska kopplas till i fältet **Företag**.

4. Ange eventuell kontakt för företaget i fältet **Kontakt**.

5. Ange eventuellt projekt som du vill koppla till försäljningen i fältet **Projekt**.

6. I den stora textrutan till vänster kan du lägga in en utförligare beskrivning av försäljningen.

7. Uppe till höger på fliken **Försäljning** kan du ange ett uppskattat försäljningsbelopp.

8. I fältet **Ägare** visas automatiskt den inloggade användaren. Du kan välja en annan användare vid behov.

9. Ange försäljningstypen i fältet **Försäljningstyp**. Om du klickar på pilen visas en lista över tillgängliga försäljningstyper. [!include[SM](../../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Vissa försäljningstyper är kopplade till en [säljguide][1]. Om du byter försäljningstyp försvinner även den tillhörande säljguiden. Eventuella händelser och dokument som har skapats i samband med säljguiden blir kvar på detaljkortet **Aktiviteter** i kalendern. Om du byter tillbaka till den ursprungliga försäljningstypen återupprättas kopplingen mellan händelser/dokument och säljguiden.

10. I fältet **Fas** anger du aktuell fas för försäljningen:

    * Om det inte finns några faser kopplade till försäljningens försäljningstyp har försäljningen statusen **Öppen**. Om du klickar på pilen kan du ställa in försäljningen på **Såld** eller **Förlorad**. Då ändras även fälten nedan, så att du kan ange datum, konkurrent och orsak till den [lyckade/förlorade försäljningen][2].

    * Om det finns faser kopplade till försäljningens försäljningstyp kan du klicka på pilen för att välja en försäljningsfas. En försäljningstyp med olika försäljningsfaser kan vara kopplad till en [säljguide][1] och är fördefinierad i Inställningar och underhåll.

    > [!NOTE]
    > När du ändrar en fas, till exempel från **Första möte** till **Offert** markeras den första fasen på detaljkortet **Säljguide** som slutförd, med en bock.

11. Till höger om fältet **Fas** visas ett procenttal som anger sannolikheten för att försäljningen ska lyckas i den här fasen. Den kopplas till fasen och definieras i Inställningar och underhåll. Du kan dock ändra den manuellt i SuperOffice CRM om du vill.

12. I kryssrutan **Uppskjuten** kan du markera om försäljningen är [uppskjuten][2]. Till exempel om kunden bestämmer sig för att vänta till nästa år innan de köper.

    > [!NOTE]
    > Fälten nedan ändrar sig om du markerar **Uppskjuten**. **Nästa aktivitet** ändras till **Återöppningsdatum**, där du kan ange ett datum för när försäljningen ska öppnas igen, och **Källa** ändras till **Orsak (uppskjuten)**, där du kan ange orsaken till att försäljningen har skjutits upp. Om du markerar försäljningen som uppskjuten, visas dialogrutan **Händelse** när du klickar på **Spara**. Här kan du boka kommande möten eller samtal för att följa upp den uppskjutna försäljningen.

13. Ange fastställt försäljningsdatum i fältet **Försäljningsdatum**. För att ändra det föreslagna försäljningsdatumet klickar du på pilen vid datumet och väljer ett nytt datum i kalendern som visas.

14. Fältet **Nästa aktivitet** visar datumet för nästa händelse som är kopplad till försäljningen (den senaste händelsen som ännu inte är slutförd). Om detta datum är före dagens datum är det rödmarkerat.

15. Ange källan till försäljningen i fältet **Källa**. Om du klickar på pilen visas en lista över de tillgängliga valen.

16. När du klickar i fältet **Synlig för** visas en lista där du kan välja om urvalet ska vara synligt för alla, privat (bara synligt för den som är definierad som ägare) eller synligt för alla i en av grupperna som ägaren är medlem i.

17. Om försäljningen har statusen **Såld** eller **Förlorad** kan du markera i rutan **Slutfört**.

18. Om du markerar i rutan **Publicera** visas försäljningen för externa användare i Audience (egen licens krävs).

<!-- Referenced links -->
[1]: ../sales-guide/index.md
[2]: ../stages.md
